# Projekt-Dokumentation

Nicola Karrer und Carina Sutter

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 13.03.2024 | 0.0.1   | Basis Rogue Game Code |
| 20.03.2024 | 0.0.2   | Basis Rogue Game Code + Sammlung von Ideen |
| 27.03.2024 | 1.0.0   | Behebung von Fehlern und Implementierung von unseren eigenen Ideen|
| 03.04.2024 | 1.0.1   | Implementation von unseren eigenen Ideen und Dokumentation|

## 1 Informieren

### 1.1 Ihr Projekt

Unser Projekt besteht ein Rogue Game zu entwickeln. Da wir aber noch zu wenig Erfahrung haben, werden wir den Grundcode von einem Entwickler kopieren, der uns vorgeschlagen wurde und dann das Spiel auf unsere eigene Weise erweitern.


### 1.2 Anforderungen

Dies sind die Anforderungen, die wir vom Code der Webseite herausnahmen. Da wir noch nicht entschieden haben, was wir genau dazu implementieren, werden diese User Storys später mit einem X hinzugefügt.

| US-N | Beschreibung                         |
| ---- | ------------------------------------ |
| 1 | GUI wird generiert |
| 2 | Farben anpassung |
| 3 | Dungeonmapräume werden generiert |
| 4 | Spieler wird generiert |
| 5 | Spieler kann sich bewegen |
| 6 | Räume werden mit Gängen verknüpft |
| 7 | Informationen werden im Terminal ausgegeben |
| 8 | Spieler hat Stats |
| 9 | Monster werden generiert |
| 10 | Monster haben Stats |
| 11 | Spieler kann Monster killen |
| 12 | Monster können sich bewegen |
| 13 | Türen die man öffnen kann |
| X14 | Überarbeitung Combat-System |
| X15 | Treppen werden richtig generiert |
| X16 | Treppen führen ins nächste Level |
| X17 | Verschiedene Arten von Monstern |


## 2 Planen

| AP-№  | Frist | Beschreibung               | Zuständig    | geplante Zeit | 
| ----- | ----- | -------------------------- | ------------ | -------------- |
| 1.A   | 13.03 | GUI generieren             | Nicola | 10min |
| 2.A   | 13.03 | Farb palette anpassen      | Nicola | 10min |
| 3.A   | 13.03 | Map generierung            | Nicola | 60min |
| 4.A   | 13.03 | Player generierung         | Nicola | 30min |
| 5.A   | 13.03 | Player Inputs              | Nicola | 20min |
| 6.A   | 13.03 | Room connections           | Nicola | 30min |
| 7.A   | 13.03 | Nachrichten ausgabe        | Nicola | 20min |
| 8.A   | 20.03 | Player stats               | Nicola | 25min |
| 9.A   | 20.03 | Monster generierung        | Nicola | 30min |
| 10.A  | 20.03 | Individualität der Monster | Nicola | 20min |
| 11.A  | 20.03 | Combat system              | Nicola | 45min |
| 12.A  | 20.03 | Attacken der Monster       | Nicola | 45min |
| 13.A  | 20.03 | Türen, die man öffnen kann | Nicola | 15min |
| X14.1 | 27.03 | Monster greifen Spieler an | Nicola | 180min |
| X15.1 | 27.03 | Treppen werden generiert   | Carina | 180min |
| X16.1 | 03.04 | Funktion der Treppen       | Carina | 180min |
| X17.1 | 03.04 | Mehr Arten von Monstern    | Nicola | 180min |


## 3 Entscheiden

Wir haben uns dazu entschlossen, nichts genaues zu planen und unsere Ideen bei der Entwicklung hinzuzufügen, damit wir flexibel bleiben und das Spiel so gestalten können, wie wir es gerne möchten.

Ideen:
Tower-based Rogue-like game

Nach dem man alle Monster getötet hat, erscheint eine Treppe mit der man aufs nächste Level kann.

Je höher man geht, desto stärkere Monster kommen und die schwierigkeit erhöht sich dadurch.

Die Gegner droppen immer bessere Ausrüstung, die man dann verbessern kann.

Jedes 5er Level ist ein Puzzle raum, wo man nicht nur Stärke braucht.

Jedes 10er Level ist ein Boss raum, der nochmal um einiges schwerer ist als das vorherige Level.

Waffen mit verschiedenen Attributen: Schwert, Lang-schwert, Bogen, Hammer, Speer

Monster mit unterschiedlichen Stats: Kobold, Zombie, Ghoul, Mage, Skeleton, Slime

Bosses: Necron the Necromancer, Storm the Skycaster, Goldor the Titan, Maxor the Wither


## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 13.03 | Nicola    | 10min | 15min |
| 2.A  | 20.03 | Nicola    | 10min | 15min |
| 3.A  | 27.03 | Nicola    | 60min | 60min |
| 4.A  | 03.04 | Nicola    | 30min | 30min |
| 5.A  | 03.04 | Nicola    | 20min | 20min |
| 6.A  | 03.04 | Nicola    | 30min | 40min |
| 7.A  | 03.04 | Nicola    | 20min | 20min |
| 8.A  | 03.04 | Nicola    | 25min | 25min |
| 9.A  | 03.04 | Nicola    | 30min | 40min |
| 10.A  | 03.04 | Nicola   | 20min | 20min |
| 11.A  | 03.04 | Nicola   | 45min | 60min |
| 12.A  | 03.04 | Nicola   | 45min | 60min |
| 13.A  | 03.04 | Nicola   | 15min | 15min |
| X14.A | 27.03 | Nicola   | 180min | 180min |
| X15.A | 27.03 | Carina   | 180min | 180min |
| X16.A | 03.04 | Carina   | 180min | 180min |
| X17.A | 03.04 | Nicola   | 180min | 180min |


## 5 Reflexion

Am Ende hat Nicola noch versucht, das Combat-System Funktionsfähig zu machen und mehr Monster einzufügen, während Carina die Treppe für den Übergang implementierte. Leider hatten wir nicht genügend Zeit, um es komplett fertig zu machen, aber wir haben einen Ansatz, an der wir weiter arbeiten können.
Wir haben schon oft zusammen gearbeitet und ich denke, dass wir gut vorangekommen sind. Die Aufteilung hätten wir besser gestalten können um den Arbeitsweg zu verbessern. Es hatte auch ein paar Fehler vom ursprünglichen Code, wo wir die Lösung entweder in den Kommentaren oder selber suchen musste.
