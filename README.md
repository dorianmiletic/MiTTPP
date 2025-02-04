Primjena automatskog testiranja uz pomoć Selenium WebDrivera i Katalon Recordera (PROJEKT)

Projekt se sastoji od 5 test caseova koji su provedeni na demo stranici pod urlom: "https://bakeronline.be/be-en/", uz pomoć korištenja Selenium WebDrivera i Katalon Recordera te znanja stečena pod laboratorijskim vježbama.

Korišteni alati, programski jezici i tehnologije:

-Microsoft Visual Studio 2019 (novije verzije također prihvatljive)

-Katalon Recorder 

-C# (moguće i ostali programski jezici no za ovaj projekt je korišten C#)

-Selenium WebDriver

-NUnit 

-Google Chrome (također Mozila Firefox moguć za korištenje uz potrebne izmjene.)


Opis pojedinih tesnih slučajeva:

Register.cs
 1. Otvoriti https://bakeronline.be/be-en/ putem Google Chroma
 2. Kliknuti na Register
 3. Unijeti email "blabla21@gmail.com"
 4. Unijeti šifru "blabla221"
 5. Upisati ime "Moje"
 6. Upisati prezime "ime"
 7. Upisati broj mobitela "0485 55 31 22"
 8. Kliknuti Create Account


Logout.cs

 1. Otvoriti https://bakeronline.be/be-en/ putem Google Chroma
 2. Kliknuti na Logout
 
Search.cs

1. Otvoriti https://bakeronline.be/be-en/ putem Google Chroma
2. Kliknuti na prostor za pretraživanje
3. Upisati "belgium"
4. Odabrati url "https://shop.paul-belgium.be/be-nl/paul-rive-gauche"


ClickingMoreInfo.cs

 1. Otvoriti https://bakeronline.be/be-en/ putem Google Chroma
 2. Kliknuti na gumb "More Info"

ChangeLanguage.cs

 1. Otvoriti https://bakeronline.be/be-en/ putem Google Chroma
 2. Scrolati do kraja stranice i kliknuti na gumb "Belgium"
 3. Odabrati land "English
 4. Odabrati jezik "English"
 5. Ponovno odabrati land pod "Belgium"
 6. Odabrati jezik "English"



Potrebni alati i paketi za pokretanje projekta:

-Imate Microsoft Visual Studio 2019 ili noviji, uz instaliran paket za C# jezik
-Imati instalirane sljedeće pakete:
• NUnit framework (4.3.2)
• Selenium WebDriver (4.28.0)
• Selenium Support(4.28.0)
• Nunit3 Test Adapter (4.6.0)

Testovi se pokreću putem Test Explorera koji se nalazi pod Test->Test Explorer
Unutar novo otvorenog prozora testove možemo pokrenuti zasebno ili sve odjednom.

BITNO: PROJEKT PRIJE POKRETANJA BUILDATI, inaće testovi neće biti prepoznati


MOGUĆE DA TESTOVI NEĆE PROĆI, ako paketi su zastarijeli ili pak konfiguracija nije dobro instalirana/ podrška za zadane alate nije više omogućena.

Ako prepoznate moguće greške/poboljšanje koda te ako Vam je potrebna pomoć slobodno se javite, pokušati ću odgovoriti što prije.

