ProduktApplikation (Demo) - Version 1.0 - 2014-10-27

F�r att k�ra:

1) I Databas klassen m�ste man �ndrar path i connectionString till d�r projektet ligger.  Utan en full path (t.ex med kod f�r att sj�lv uppt�cka d�r applikationen k�rdes), fick man inte tilll�telse att �ndra i databasen.

2) F�r att f� currencyTextBox i toolbox till Windows Forms m�ste man bygga hela solution.  Visual Studio borde automatiskt hitta den d�.

3) Har man yttligare problem med databasen rekommenderas det att starta om Visual Studio.

4) K�r.



Solutioninformation

JRINCCustomControls projektet inneh�ller currencyTextBox vilket anv�nds i ProduktApplikation projektet. Det �r baserad p� kod fr�n http://www.codeproject.com/Articles/248989/A-Currency-Masked-TextBox-from-TextBox-Class, men �ndrat f�r att f� tre olika funktionaliteter.

1.) Med decimaltecken (default ",") och ett obligatoriskt decimalv�rde (som 2 decimaler), accepterar textboxen nummer och decimaltecknen och ser till att den alltid har x decimal d�r x �r decimalv�rdet.  ie. med decimalv�rde 2, blir 12,1 -> 12,10 och 0 -> 0,00.  Vid f�r m�nga decimaler blir det avhuggen, ie. 112,345 -> 112,34.  Nollar framf�r blir borttagen, ie. 00012 -> 12.00.  Det g�r �ven att s�tta ett tusentalstecken (default " ") och ett pengar tecken (default "kr"). 

2.) Utan decimaltecken men med ett obligatoriskt decimalv�rde, acceptera textboxen ett nummer som m�ste vara en viss storlek och f�r nollar framf�r f�r att se till att det blir s�, ie. med decimalv�rde 5 blir 13 -> 00013. 

3.) Utan decimaltecken och utan obligatoriska decimalv�rde blir det bara en vanliga textbox.

**F�r att f� currencyTextBox i toolbox till Windows Forms m�ste man bygga hela solution.  Visual Studio borde automatiskt hitta den d�.**

- currencyTextBox.cs - kod



ProduktApplikation projektet inneh�ller huvudprogrammet.
Enlig MVC - Produkt �r en modell (data), ProduktApplikationForm �r vyn, och ProduktApplikation �r huvudkontroller (som hanterar kommunikation mellan data och vyn).  Databas �r en kontroller som har hand om databasen och kommunicera med huvudkontroller.

- Produkt.cs (Modell)
Databeh�llaren f�r data inl�st fr�n databasen, och ny data skriven till databasen.  Den har egna Equals och HashCode metoder.
Instansvariabler - id, namn, typ, farg, bildfilnamn, ritningsfilnamn, refid, beskrivning, monteringsbeskrivning
Metoder - Equals, Hashcode

- ProduktApplikationForm.cs (Vy)
Tar in input fr�n anv�ndaren och skickar till ProduktApplikation.  Testar indatan innan det skickas vidare.
Instansvariabler - produktApplikation, produktSamling, selectedProdukt 
Metoder - btnNy_Click, btnTaBort_Click, btnAndra_Click, cboxProduktBox_SelectedIndexChanged, S�ttProdukt, T�mma, TestaAttIDExistera, TestaAttNamnExistera, TestaAttSammaNamnExistera, Reng�rInput

- ProduktApplikation.cs (Huvud-Kontroller)
Skickar till Databas klassen och f�r svar som ges till ProduktApplikationForm klassen.
Instansvariabler - produktDatabas, produkter
Metoder - Main, L�saFr�nDatabas, L�ggTillProdukt, TaBortProdukt, UppdateraProdukt, SammaProdukter

- Databas.cs (Kontroller)
Hanterar all kontakt med databasen.  Testar nyckelv�rden innan ins�ttning/borttagning/uppdatering.
Instansvariabler - connectionString, produkter
Metoder - OpenConnection, CloseConnection, ProduktL�sare, Insert, Delete, Update, ExisterandeID

- TestDatabase.mdf
ID (char(5)), Namn (Varchar(30)), Pris (Decimal(10,2)), Typ (Varchar(30)), Farg (Varchar(30)), Bildfilnamn (Varchar(30)), Ritningsfilnamn (Varchar(30)), RefID (char(5)), Beskrivning (Varchar(600)), Montering (Varchar(300))



ProduktApplikationUnitTestar inneh�ller unit testar till ProduktApplikation.
De tv� klasser som testas �r Produkt och ProduktApplikation.  Databas g�r inte att testa pga databaskopplingen som ge unit testar problem.  Det kan dock testas genom ProduktApplikation som anv�nder den.  ProduktApplikationForm kan inte testas med vanliga Unit Testar utan m�ste testas med en UI test som har inte gjorts �n.

- testar_Produkt.cs
Testar skapande, tilldelning, och Equals metod i Produkt klassen.

- testar_ProduktApplikation.cs
Testar skapande, tilldelning, och metoder som kallar p� Databas och ger ProduktApplikationForm svar.
