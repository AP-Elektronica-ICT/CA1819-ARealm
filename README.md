CA1819-ARealm, project door:

*Joris van Looy*

*Wouter Huygen*

*Robbe Vermeire*

# ARealm: Turfwars in Antwerpen.
*Deze sectie is bedoelt voor een beschrijving van ons spel.*
*ARealm is een spel dat in elke stad gespeeld kan worden, maar voor ons project en MVP gaan we ons spitsen op enkel Antwerpen.*

**Doelgroep**: Kinderen 13-16 jaar.

**Aantal spelers**: 2-4 teams van max. 5 spelers.

### Speelgebied:

Het speelveld is voor nu Antwerpen, ‘t stad is onderverdeeld in verschillende districten. Deze opsplitsing gebeurd op basis van bestaande buurten, historische monumenten, grootte en nog veel andere factoren. We mikken op Antwerpen in te delen in 25 verschillende districten op te delen, deze 25 districten zijn gegroepeerd in concentrische cirkels rondom een centraal district. Deze cirkels noemen we banden en zijn een belangrijk deel van ons spel. We willen 3 banden maken rondom het centrale district van 12,8 & 4 districten groot.

### Punten verdienen:
Districten zijn er om te veroveren met je team, aan de hand van opdrachten specifiek voor dat district. Indien je een opdracht denkt opgelost te hebben verstuur je deze naar de server voor controle. De server valideert of je antwoord juist is en geeft je de correcte punten voor dat district. De opdrachten worden door ons gemaakt en kunnen makkelijk uitgebreid worden met nieuwe functionaliteiten. Voor nu willen we opdrachten ontwerpen op basis van:

•	**Locatie**, waarbij je op een specifieke locatie in een district moet zijn.

•	**Foto herkenning**, denk aan bepaalde gebouwen of monumenten trekken.

•	**Puzzels/Raadsels** die je met echte wereld informatie moet oplossen.


Nogmaals, deze opdrachten zijn modulair uit te breiden voor meer functionaliteiten in ons spel te brengen. Dit betekent dat we de core van het spel makkelijk kunnen uitbreiden en aanpassen aan andere steden. 

### Spelverloop:
De spelers gaan voor het begin van het spel naar het middelste district en maken daar hun teams aan, ze krijgen een korte tutorial via hun apparaat dat het spel uitlegt.

Eenmaal de teams gemaakt zijn en iedereen het spel snapt kan het spel beginnen. Het spel begint met alle groepen naar een verschillend district in de buitenste band te sturen, zodat er zoveel mogelijk afstand tussen teams zit. Alle teams moeten eerst in hun eigen begin district de opdracht oplossen voor ze naar andere districten kunnen gaan.

Op dit moment van het spel zijn enkel de districten die in de buitenste band liggen ontsloten. Alle teams proberen dan zoveel mogelijk districten te veroveren, want als er een bepaald deel van alle districten veroverd zijn sluit de buitenste cirkel definitief. Op hetzelfde moment wordt de 2de band ontsloten, zodat de teams daar punten kunnen gaan scoren. Dit doen ze op dezelfde manier als in de 1ste band, door het oplossen van de opdrachten uniek aan het district. Enkel krijgen de teams nu iets meer punten als in de vorige band. Dit proces van vergrendelen en ontgrendelen van banden wordt nog 1 maal uitgevoerd voor alle teams naar het centrale district moeten.

In het centrale district gaat er nog een gezamenlijke opdracht zijn waar de teams rechtstreeks tegen elkaar moeten spelen voor heel wat punten. 
Het team die na dit spel het meeste punten heeft is de winnaar van het spel.

### Secundaire opdrachten:
Dit is een mogelijke uitbreiding op het spel. We geven de teams doorheen het spel kleine opdrachten waartoe ze altijd kunnen bijdragen, onafhankelijk van in welk district ze zitten. Denk aan zoveel mogelijk foto’s trekken van gele auto’s, een kat en muis spel tegen een ander team. De mogelijkheden zijn praktisch oneindig en worden enkel gelimiteerd door onze creativiteit.

# Software Architectuur

Foto Algemene Architectuur:

![Algemene Architectuur](https://github.com/AP-Elektronica-ICT/CA1819-ARealm/blob/master/doc/img/Software%20Architectuur.png)

Frontend : Onze applicatie, Ionic of Unity.

Web API: Hier komen al onze calls binnen afkomstig van de frontend, ASP NET MVC core.

Services: Business Logic, ASP NET MVC core.

Repository: Calls naar Database, Entity Framework.

Database: Azure database.

We gaan heel onze backend, van web API tot de database hosten op Azure cloud services.

Layered Architectuur:

![Layered Architectuur](https://github.com/AP-Elektronica-ICT/CA1819-ARealm/blob/master/doc/img/Software%20Architecture.png)

# Links

Jira: https://jira.ap.be/secure/RapidBoard.jspa?rapidView=234&projectKey=CA18AR&view=planning&selectedIssue=CA18AR-14&epics=visible
