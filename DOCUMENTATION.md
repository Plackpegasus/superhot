# Superhot – GAMEDEV HS23

Dies ist die Dokumentation des Projekts «Superhot», eine Abgabe innerhalb des Moduls «Game Development» von Nico Schneider und Elia Rohrbach.

## Grundidee

Unsere Umsetzung des Spiels «Superhot» ist eine Nachstellung des gleichnamigen Shooters vom Entwickler «SUPERHOT Team», welches im Februar 2016 erstmalig für Windows, Linux und macOS erschienen ist. Die Grundmechanik des First-Person Shooters basiert auf den klassischen Mechaniken eines Shooters, wobei der Spieler innerhalb eines Levels mehrere Gegner mit verschiedenen Waffen bekämpft. Jedoch bewegt sich die Zeit innerhalb des Spiels nur, wenn sich der Spieler bewegt. Das ermöglicht dem Spieler, seine Situation in Slow-Motion zu analysieren und entsprechend zu reagieren, was eine taktische Komponente ins Spiel einfliessen lässt.

Als Fans des Shooters haben Nico und ich uns entschieden, innerhalb des Moduls «Game Development» die Mechanik und visuellen Elemente von Superhot nachzubauen. Daraus entstand unsere Version des Shooters, wobei wie beim Originalspiel auch die Gameengine Unity verwendet wurde.

### Anleitung

Unsere Umsetzung von Superhot übernimmt die gängigsten Steuerelemente eines First-Person Shooters.
Die Steuerungsmechaniken sind wie folgt:

- Tasten «WASD»: Bewegung des Spielers nach vorne, links, hinten und rechts.
- Leertaste: Hüpfen
- Linke Maustaste: Schuss mit Waffe
- Taste «R»: Neustarten des Levels

## 3rd Party Assets

### 3D Assets

Innerhalb unserer Umsetzung wurden einige kostenlose und frei verwendbare 3D-Modelle von den Plattformen Sketchfab, Ultimaker Thingiverse und dem Unity Asset Store verwendet. Dazu gehörigen beispielsweise das Modell des Gegners, die Pistole des Spielers etc. Alle verwendeten Assets sind nachfolgend aufgeführt (letzter Aufruf aller Links: 19. Dezember 2023):

– Gegner (Modell von @huge_man auf Sketchfab)
https://sketchfab.com/3d-models/low-poly-base-mesh-530-tri-138ca18c246a4b13b3e108bd88df95a2

– Pistole (Modell von @dog_g auf UltiMaker Thingiverse)
https://www.thingiverse.com/thing:4572894

### Animation

Für die Gegner wurde eine kostenlose Animation im Loop verwendet, die von Adobe Mixamo stammt. Dabei handelt es sich um die «Shooting»-Animation, welche auf www.mixamo.com einsehbar ist (ein Adobe Account ist notwendig).

## Musik und Sound Effects

Unserer Adaption von Superhot verwendet zwei Audioquellen von externen Quellen:

– Hintergrundmusik: Danger Snow – Dan Henig (Zugang nur über YouTube-Account in die Audio-Mediathek möglich). Verwendung unter der YouTube-Mediathek Lizenz. Eine allenfalls kommerzielle Verwendung wäre nicht zulässig.

– Sound «Pistolenschuss»: Hier wurde die Audiodatei «35 Gun,Hand,Foley Glock 10mm/Reloading» aus der BBC Sound Library.

## Functional and Non-Functional Requirements

### Functional Requirements

- Zeit der Szene und der Gegner wird mit Bewegungen des Spielers verknüpft
- Basic-Playercontroller: Spieler kann Laufen und Hüpfen
- Mind. ein Spiellevel
- Mind. drei Gegner im Level zum Bekämpfen
- Mind. ein Waffentyp mit Projektil (Bsp. Pistole), der vom Spieler eingesetzt werden kann
- Mind. ein Sound-Effekt, der sinnvoll im Spiel eingesetzt wird
- Spieler kann sterben
- Spieler und Gegner sterben bei einmaligem Treffer/Schaden
- Spieler kann das Level neu starten

### Non-Functional Requirements

- Die Waffe ist für den Spieler sichtbar
- Das Projektil der Waffe ist für den Spieler sichtbar
- Ein Level muss Deckung für den Spieler bieten

## Playtesting

Das Playtesting haben wir während der Entwicklunsgzeit am Mittwoch, 6. Dezember 2023 an der HSLU durchgeführt. Getestet wurde mit ingesamt sieben Personen, mit unterschiedlichen Gaming-Vorerfahrungen und Geschlechtern. Uns war es wichtig, dass Playtesting mit genug Abstand zum Abgabetermin umzusetzen, um bei Erkenntnissen entsprechend reagieren zu können.

Zum Termind es Playtestings waren die Grundlagen von Superhot implementiert. Es fehlten noch sämtliche Sounds und Animationen.

### Playtesting-Setup

Für das Playtesting haben wir ein frühes Playtesting-Level konzipiert, dass den Testpersonen gezeigt wurde. In diesem Playtesting-Level war es den Spielern möglich, alle implementierten Features zu nutzen. Während und im Anschluss des Testings wurde, die Testpersonen mit einem vorher definierten Fragebogen abgefragt. Alle Antworten wurden im Anschluss in einem Google Form gesammelt.

Der Fragebogen umfasste folgende Fragen:

- Wie ist dein Vorname?
- Welches Alter hat die Testperson?
- Wie häufig spielst du Games (Nie / Selten / Manchmal / Häufig )
- Was ist die Hauptmechanik dieses Spiels? (freie Antwort)
- Wie merkst du, dass du einen Gegner getroffen hast? (freie Antwort)
- Was war der frustrierendste Moment/Aspekt, den du gerade erlebt hast während dem Spiel? (freie Antwort)
- Wie viel Spass macht dir das Spiel aktuell von 1 - 10? (Antwortskala von 1 bis und mit 10)
- Wie einfach findest das Spiel zu spielen und zu verstehen? (Antwortskala von 1 bis und mit 10)
- Was denkst du, könnte den Spass noch erhöhen? (freie Antwort)
- War da irgendetwas, was du gerne machen wolltest, aber nicht konntest? (freie Antwort)

### Playtesting Ergebnis

... (Ergebnisse hier)

Sämtliche Aussagen der Testpersonen und Ergebnisse des Playtestings können unter folgendem Link angesehen werden:
https://docs.google.com/spreadsheets/d/1kXPqphzmnG5195DDlOivgWjdf4xOO4wrbs8OSr79KxU/edit?usp=sharing

## Individueller Beitrag

### Analyse: Zeitachse

### Analyse: Verwendung von Raycast für schiessende Enemies
