Gruppuppgift CI/CD

Vi arbetade med att utveckla och testa ett program för att verifiera och analysera svenska personnummer. Det svenska personnumret är komplicerat och involverar olika regler för att säkerställa dess giltighet. Målet var att skapa ett program som kunde genomföra olika typer av enhetstester för att validera personnummer enligt de svenska reglerna.

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
