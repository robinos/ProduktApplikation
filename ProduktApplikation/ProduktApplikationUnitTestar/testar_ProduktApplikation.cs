using System;
using System.Collections.Generic; //Dictionary klass
using System.Management; //Behövs
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProduktApplikationSpace;

namespace ProduktApplikationUnitTestar
{
	/// <summary>
	/// Unittestar för ProduktApplikation
	/// </summary>
	[TestClass]
	public class testar_ProduktApplikation
	{
		ProduktApplikation produktApplikation;
		Produkt produkt1;

		/*
		 * Initialisation mellan avancerade testar. 
		 */
		public void initialise()
		{
			produktApplikation = new ProduktApplikation();
			produkt1 = new Produkt();

			produktApplikation.LäsaFrånDatabas();

			produkt1.ID = "10000";
			produkt1.Namn = "Test Namn";
			produkt1.Pris = 10.00m;
			produkt1.Typ = "Test Typ";
			produkt1.Farg = "Test Farg";
			produkt1.Bildfilnamn = "Test Bildfilnamn";
			produkt1.Ritningsfilnamn = "Test Ritningsfilnamn";
			produkt1.RefID = "20000";
			produkt1.Beskrivning = "Test Beskrivning";
			produkt1.Monteringsbeskrivning = "Test Monteringsbeskrivning";
		}

		/*
		 * Testar att det går att skapa en ProduktApplikation objekt.
		 */
		[TestMethod]
		public void test_SkapaNyProduktApplikationObjekt()
		{
			//Skapar Produkt objekt
			ProduktApplikation produktApplikationTest = new ProduktApplikation();
			Assert.IsNotNull(produktApplikationTest);
		}

		/*
		 * Testar att det går att läsa från databas utan problem och får en
		 * Dictionary produkter som utdata från Databas klassen.
		 */
		[TestMethod]
		public void test_LasaFranDatabas()
		{
			//Skapar Produkt objekt
			ProduktApplikation produktApplikationTest = new ProduktApplikation();
			Assert.IsTrue(produktApplikationTest.LäsaFrånDatabas());
			Assert.IsNotNull(produktApplikationTest.Produkter);
		}

		/*
		 * Testar att det går att läsa från databas utan problem och får en
		 * Dictionary produkter som utdata från Databas klassen som faktiskt
		 * innehåller data och är inte bara tom.  Testan även kollar att
		 * Dictionary i ProduktApplikation blir samma som den i Databas klassen. 
		 * Testen kommer att vara falsk med en tom databas.
		 */
		[TestMethod]
		public void test_LasaFranDatabasInteTom()
		{
			initialise();
			Assert.IsTrue(produktApplikation.Produkter.Count > 0);
			Assert.IsTrue(produktApplikation.SammaProdukter());
		}

		/*
		 * Testar LaggTillProdukt och TaBortProdukt i ProduktApplikation
		 */
		[TestMethod]
		public void test_LaggTillOchTarBortProdukt()
		{
			initialise();
			
			//Lägg till och testar att den blev tillagd
			Assert.IsTrue(produktApplikation.LäggTillProdukt(produkt1));
			produktApplikation.LäsaFrånDatabas();
			Assert.IsTrue(TestaAttIDExistera(produkt1.ID, produktApplikation.Produkter));

			//Tar bort och testar att den är borta
			Assert.IsTrue(produktApplikation.TaBortProdukt(produkt1.ID));
			produktApplikation.LäsaFrånDatabas();
			Assert.IsTrue(!TestaAttIDExistera(produkt1.ID, produktApplikation.Produkter));
		}

		/*
		 * Testar att LaggTillProdukt i ProduktApplikation inte lägger till vid
		 * existerande id.
		 */
		[TestMethod]
		public void test_InteLaggTillEnExisterande()
		{
			initialise();

			//Lägg till
			produktApplikation.LäggTillProdukt(produkt1);

			//Lägg till och testar att den blev INTE tillagd
			Assert.IsTrue(!produktApplikation.LäggTillProdukt(produkt1));

			//Ta bort
			produktApplikation.TaBortProdukt(produkt1.ID);
		}

		/*
		 * Testar att TaBortProdukt i ProduktApplikation inte ta bort om den inte
		 * finns.
		 */
		[TestMethod]
		public void test_InteTaBortIckeExisterande()
		{
			initialise();

			//Tar bort och testar att ingenting hände
			Assert.IsTrue(!produktApplikation.TaBortProdukt(produkt1.ID));
		}

		/*
		 * Testar UppdateraProdukt i ProduktApplikation
		 */
		[TestMethod]
		public void test_UppdateraProdukt()
		{
			initialise();

			Assert.IsTrue(produktApplikation.LäggTillProdukt(produkt1));

			produkt1.Farg = "Farg";
			Assert.IsTrue(produktApplikation.UppdateraProdukt(produkt1));
			produktApplikation.LäsaFrånDatabas();
			Assert.IsTrue(produkt1.Equals(HittaProdukt(produkt1.ID, produktApplikation.Produkter)));

			Assert.IsTrue(produktApplikation.TaBortProdukt(produkt1.ID));
		}

		/*
		 * Testar att UppdateraProdukt i ProduktApplikation inte ändrar om den inte
		 * finns.
		 */
		[TestMethod]
		public void test_UpdateraIckeExisterande()
		{
			initialise();

			//Updatera och testar att uppdatering mislyckades
			produkt1.Farg = "Farg";
			Assert.IsTrue(!produktApplikation.UppdateraProdukt(produkt1));
			produktApplikation.LäsaFrånDatabas();
			Assert.IsTrue(!TestaAttIDExistera(produkt1.ID, produktApplikation.Produkter));
		}

		/*
		 * Hjälpmetod för att testa att en id existera i Dictionary produkter
		 * i ProduktApplikation.
		 */
		private bool TestaAttIDExistera(string id, Dictionary<string,Produkt> produkter)
		{
			bool existera = false;

			foreach (Produkt produkt in produkter.Values)
			{
				if (id.Equals(produkt.ID)) existera = true;
			}

			return existera;
		}

		/*
		 * Hjälpmetod returnera produkten från Dictionary produkter i
		 * ProduktApplikation som matchar id angiven.
		 */
		private Produkt HittaProdukt(string id, Dictionary<string, Produkt> produkter)
		{
			Produkt produkt = new Produkt();

			//Söker efter namnet från comboboxen i produktsamlingen.  Detta gör att
			//namn måste vara unik.
			foreach (Produkt tempProdukt in produkter.Values)
			{
				if (tempProdukt.ID.Equals(id))
				{
					produkt = tempProdukt;
				}
			}

			return produkt;
		}
	}
}
