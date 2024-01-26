# LA1303

### Beschreibung

Ich will  ein kleines schach basiert es spiel programmieren, in dem der spieler so viele figuren der gleichen art auf dem spielbrett plazieren muss, ohne dass eine andere figur geschlagen werden kann.

### User Stories

| US-№ | Verbindlichkeit | Typ        | Beschreibung                                                                                                                                                  |
| ---- | --------------- | ---------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 1    | Muss            | Funktional | Als spieler möchte ich eine kurze einführung bekommen, um das spiel zu verstehen                                                                                                                                                              |
| 2    | Muss            | Funktional | Als spieler möchte ich das spielfeld sehen, um spielen zu können.                                                                                                                                                              |
| 3    | Muss            | Funktional | Als spieler möchte ich zwischen den Figuren auswählen können, um mehr Abwechslung zu haben.                                                                                                                                                              |
| 4    | Muss            | Funktional | Als spieler möchte ich sehen können wann ich verloren habe, um aus meinen fehlern zu lernen.                                                                                                                                                               |
| 5    | Muss            | Funktional | Als Spieler möchte ich die anzahl platzierten Figuren sehen, um mich mit freunden messen zu können.                                                                                                                                                              |




### Testfälle

| TC-№ | Ausgangslage             | Eingabe                          | Erwartete Ausgabe                                                         |
| ---- | ------------------------ | -------------------------------- | ------------------------------------------------------------------------- |
| 1.1  | Spiel startet            | -                                |  "Welcome to the Knight Placement Game!" "Try to place as many knights as possible without one capturing another."  "Enter row and column to place a knight (e.g., 1 2):"|
| 2.1  | Spiel startet            | -                                | Spielfeld                                                                           |
| 2.2  | Spiel läuft              | Spieler Plaziert Figur           | Spielfeld mit Position aller Figuren                                                                          |
| 3.1  |  Spiel startet            | -              |              "Please choose what piece you would like to play:"                                                               |
| 4.1  | Spieler verliert          | -                                |  Spielfeld mit Position aller Figuren und markierung der falsch platzierten Figur                                                                      |
| 5.1  | spieler verliert / gewinnt   | -                                |   "Do you want to play again? (y/n): "                                                                        |
| 5.2  | spieler gewinnt / verliert    | y                                |  Spiel startet neu                                                                         |
| 5.3  |   spieler gewinnt / verliert  | n                                |      Spiel startet neu                                                                     |
                                                                     



### Testprotokoll

| TC-№   | Datum      | Resultat | Tester        |
| ------ | ---------- | -------- | ------------- |
| 1.1.1  | 02.02.2023 | OK       | Fabian Meyer  |
| 2.1.1  | 02.02.2023 | OK       | Fabian Meyer  |
| 2.2.1  | 02.02.2023 | OK       | Fabian Meyer  |
| 3.1.1  | 02.02.2023 | NOT OK       | Fabian Meyer  |
| 4.1.1  | 02.02.2023 | OK       | Fabian Meyer  |
| 5.1.1  | 02.02.2023 | OK       | Fabian Meyer  |
| 5.2.1  | 02.02.2023 | OK       | Fabian Meyer  |
| 5.3.1  | 02.02.2023 | OK       | Fabian Meyer  |



### Testbericht

Das Projekt funktioniert fehlerfrei. User story 3 nicht umgesetzt. 
