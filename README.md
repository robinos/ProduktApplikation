ProduktApplikation
==================

A simple UI connected through controllers to a local database of products. (In swedish)



ProduktApplikation (Demo) - Version 1.0 - 2014-10-27

För att köra:

1) I Databas klassen måste man ändrar path i connectionString till där projektet ligger.  Utan en full path (med kod för att själv upptäcka där applikationen kördes), fick man inte tilllåtelse att ändra i databasen, bara läsa.

2) För att få currencyTextBox i toolbox till Windows Forms måste man bygga hela solution.  Visual Studio borde automatiskt hitta den då.

3) Har man yttligare problem med databasen rekommenderas det att starta om Visual Studio.

4) Kör.



Solutioninformation

JRINCCustomControls projektet innehåller currencyTextBox vilket används i ProduktApplikation projektet. Det är baserad på kod från http://www.codeproject.com/Articles/248989/A-Currency-Masked-TextBox-from-TextBox-Class, men ändrat för att få tre olika funktionaliteter.

1.) Med decimaltecken (default ",") och en obligatorisk decimalvärde, acceptera textboxen nummer och decimaltecken och se till att den alltid har x decimal där x är decimalvärdet.  ie. med decimalvärde 2, blir 12,1 -> 12,10 och 0 -> 0,00.  Vid för många decimaler blir det avhuggen, ie. 112,345 -> 112,34.  Nollar framför blir borttagen, ie. 00012 -> 12.00.  Det går även att sätta ett tusentalstecken (default " ") och ett pengar tecken (default "kr"). 

2.) Utan decimaltecken men med en obligatorisk decimalvärde, acceptera textboxen ett nummer som får extra nollar till en viss storlek, ie. med decimalvärde 5 blir 13 -> 00013. 

3.) Utan decimaltecken och någon obligatoriska decimalvärde, blir det bara en vanliga textbox.

**För att få currencyTextBox i toolbox till Windows Forms måste man bygga hela solution.  Visual Studio borde automatiskt hitta den då.**

- currencyTextBox.cs - kod
- bin -> debug -> JRINCCustomControls.XML - xml



ProduktApplikation projektet innehåller huvudprogrammet.
Enlig MVC - Databas och Produkt är modeller (data), ProduktApplikationForm är vyn, och ProduktApplikation är kontroller (som hanterar kommunikation mellan data och vyn).

- Produkt.cs (Modell)
Databehållaren för data inläst från databasen, och ny data skriven till databasen.  Den har egna Equals och HashCode metoder.
Instansvariabler - id, namn, typ, farg, bildfilnamn, ritningsfilnamn, refid, beskrivning, monteringsbeskrivning
Metoder - Equals, Hashcode

- ProduktApplikationForm.cs (Vy)
Tar in input från användaren och skickar till ProduktApplikation.  Testar indatan innan det skickas vidare.
Instansvariabler - produktApplikation, produktSamling, selectedProdukt 
Metoder - btnNy_Click, btnTaBort_Click, btnAndra_Click, cboxProduktBox_SelectedIndexChanged, SättProdukt, Tömma, TestaAttIDExistera, TestaAttNamnExistera, TestaAttSammaNamnExistera, RengörInput

- ProduktApplikation.cs (Huvud-Kontroller)
Skickar till Databas klassen och får svar som ges till ProduktApplikationForm klassen.
Instansvariabler - produktDatabas, produkter
Metoder - Main, LäsaFrånDatabas, LäggTillProdukt, TaBortProdukt, UppdateraProdukt, SammaProdukter

- Databas.cs (Kontroller)
Hanterar all kontakt med databasen.  Testar nyckelvärden innan insättning/borttagning/uppdatering.
Instansvariabler - connectionString, produkter
Metoder - OpenConnection, CloseConnection, ProduktLäsare, Insert, Delete, Update, ExisterandeID

- TestDatabase.mdf
ID (char(5)), Namn (Varchar(30)), Pris (Decimal(10,2)), Typ (Varchar(30)), Farg (Varchar(30)), Bildfilnamn (Varchar(30)), Ritningsfilnamn (Varchar(30)), RefID (char(5)), Beskrivning (Varchar(600)), Montering (Varchar(300))



ProduktApplikationUnitTestar innehåller unit testar till ProduktApplikation.
De två klasser som testas är Produkt och ProduktApplikation.  Databas går inte att testa pga databaskopplingen som ge unit testar problem.  Det kan dock testas genom ProduktApplikation som använder den.  ProduktApplikationForm kan inte testas med vanliga Unit Testar utan måste testas med en UI test som har inte gjorts än.

- testar_Produkt.cs
Testar skapande, tilldelning, och Equals metod i Produkt klassen.

- testar_ProduktApplikation.cs
Testar skapande, tilldelning, och metoder som kallar på Databas och ger ProduktApplikationForm svar (x).
