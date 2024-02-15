Gruppuppgift CI/CD

Vi var engagerade i utvecklingen och testningen av en applikation för att verifiera och analysera svenska personnummer. Den svenska personnummerstandarden är komplicerad och omfattar flera regler för att säkerställa dess giltighet. Vårt huvudsyfte var att utveckla ett program som kunde utföra olika former av enhetstester för att säkerställa att personnummer följde de strikta svenska reglerna.

EnhetsTester
Test av Personnumrets Längd
För att förstärka programmets flexibilitet och förmåga att hantera olika scenario skapade vi ett enhetstest för att verifiera längden på ett personnummer. Vi inkluderade både giltiga och ogiltiga personnummer, där längden var korrekt respektive för kort. Detta test syftade till att visa programmet kan hantera olika scenarier och ge korrekta svar.

Test av Könet i Personnumret
För att verifiera korrekt kön i personnumret skapade vi ett enhetstest där vi angav personnummer och förväntade oss korrekt resultat beroende på om personen borde vara man eller kvinna. Genom att använda sig av personnummer med kända kön verifierades programmets korrekta identifiering av könet.

Test av Åldersvalidering
För att utvidga programmets funktionalitet inkluderade vi ett test för att validera om den ålder som härleddes från personnumret stämde överens med förväntad ålder. Vi använde personnummer där vi specificerade en ålder och verifierade att programmet kunde korrekt fastställa om personen var av den angivna åldern.

Utökade Funktionaliteter (Om vi hade haft mer tid)
Validering av Kontrollsiffran
Vi hade ambitionen att skapa ett ytterligare test för att verifiera att kontrollsiffran i personnumret var korrekt. Detta skulle involvera att använda den matematiska operationen (10 - (X % 10)) % 10 för att beräkna och kontrollera kontrollsiffran. Dessvärre var tiden för knapp för oss att hinna med det i denna uppgiften.

Identifiering av Födelseort
En ytterligare funktionalitet som vi hade velat inkludera var att identifiera födelseorten baserat på personnumret. Detta skulle dock kräva ytterligare komplexitet och ännu mer tid för att kunna säkerställa att den stämde och fungerade korrekt.

Användning av GitHub Actions och Docker
För att automatisera enhetstestningen och distributionen använde vi oss av GitHub Actions och Docker. Vi skapade en YAML-fil för GitHub Actions där vi specificerade enhetstesterna och konfigurationen för att bygga och pusha programmet till Dockerhub. Genom att ta ett steg i taget och lösa eventuella problem steg för steg lyckades vi konfigurera GitHub Actions för att integrera och distribuera programmet.
Sammanfattningsvis var detta projekt en möjlighet att utforska och tillämpa koncept inom enhetstestning, Docker och CI/CD i ett verkligt scenario. Genom att ta små steg och iterera över programmet och dess tester lyckades vi nå vårt mål och skapa ett robust system för att hantera och analysera svenska personnummer. Sammarbeten inom gruppen har varit bra och med hjälp av en tydlig och kontinuerlig konversation lyckades vi med uppgiften och är alla nöjda med resultatet. 


Applikationen:                                                                                                                                                                                                  
Först definierar vi några grundläggande konstanter för att hantera svenska personnummer. Detta inkluderar Personnumer lenght, som är satt till 11 för att matcha den vanliga längden på ett svenskt personnummer. 
Vi definierar också Date Format som 'ååMMdd', vilket är formatet på datumdelen i ett svenskt personnummer. Dessutom skapar vi en konstant SEQUENCE PART LENGTH satt till 4 för sekvensdelen av personnumret.

För att samla in ett personnummer från användaren använder vi funktionen GetUserInput(). Denna funktion frågar användaren att mata in sitt personnummer och returnerar det som en sträng. Om användaren inte matar in något och trycker på enter, returnerar funktionen en tom sträng.

Nästa steg är att kontrollera om ett personnummer är giltigt med funktionen IsValidSwedishPersonnummer(). Denna funktion kontrollerar först att personnumrets längd är korrekt. Sedan använder den ett reguljärt uttryck för att säkerställa att formatet är korrekt, inklusive att kontrollera förekomsten av ett '-' eller '+'. Funktionen kontrollerar också att datumdelen är ett giltigt datum och att de sista fyra tecknen är numeriska.

För att bestämma kön baserat på personnumret har vi funktionen GetGender(). Den ser till den näst sista siffran i personnumret, där udda nummer indikerar en man och jämna en kvinna.

Slutligen har vi CheckAge() som beräknar en persons ålder från deras personnummer. Funktionen extraherar först födelseåret från personnumret. Sedan jämför den detta år med det aktuella året för att beräkna åldern. Funktionen tar också hänsyn till personer födda på 1900-talet och justerar åldersberäkningen för personer över 100 år.
