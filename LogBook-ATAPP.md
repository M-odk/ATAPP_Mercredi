# LOGBOOK 

**DATES**

***

10.02.2021 : Commencement du projet

17.02.2021 : vacances scolaires

24.02.2021 : absence

03.03.2021 : Partie transposition de la v1 à faire

10.03.2021 : Schema sur papier du projet (sans inclure la librairie Manufaktura.controls) 

![schéma](schema-transposition.jpg)

TODO : régléchir à comment transposer

17.03.2021 : absence pendant 3 périodes 

- Avancement sur la préparation du TPI (documentation)
- Avancement sur le code 

24.03.2021 : création du tableau de transposition en code (dans la solution de la librairie manufaktura)

- créer les notes 
```c#
            /*Une note est : une hauteur, une durée et la tige
                de la note est déterminée automatiquement si true */

            Note Do = new Note(Pitch.C2, duration, true);
            Note Re = new Note(Pitch.D2, duration, true);
```
- créer les gammes contenant les notes (Listes)
```c#
            // Gamme de Fa majeur ( 1b ) 
            GM_Fa = new List<Note>() { Fa, Sol, La, SiB, Do, Re, Mi };

            // Gamme de do majeur ( 0 ) 
            GM_Do = new List<Note>() { Do, Re, Mi, Fa, Sol, La, Si };

            // Gamme de sol majeur ( 1# ) 
            GM_Sol = new List<Note>() { Sol, La, Si, Do, Re, Mi, FaD };
```

- créer deux dictionnaires qui contiennent chacune des listes de gammes (gammes majeures / gammes relatives mineures) avec comme index l'altération

```c#
    /* Dictionnaire contenant une clé (armature) --> valeur (gamme majeure) */
            gammesMajeures = new Dictionary<string, List<Note>>()
            {
                 {"6b", GM_Solb },
                 {"5b", GM_Reb },
                 {"4b", GM_Lab },
                 {"3b", GM_Mib },
                 {"2b", GM_Sib },
                 {"1b", GM_Fa },

                 {"0", GM_Do },
                 {"1#", GM_Sol },
                 {"2#", GM_Re },
                 {"3#", GM_La },
                 {"4#", GM_Mi },
                 {"5#", GM_Si },
            };

```
 31.03.2021

- Changement du tableau de transposition en créant une classe Gamme
- Permet de stocker trois valeurs dans le dictionnaire au lieu de deux
- Affichage et classe gamme qui contient l'armature et la liste de notes

```c#
    /* Dictionnaire contenant une clé (Nom qui sera affiché dans la liste déroulante) --> valeur (Gamme(string, List<Note>)) */
            gammesMajeures = new Dictionary<string, Gamme >()
            {
                 {"Sol b", Gamme("6b", GM_Solb) },
                 {"Re b", Gamme("6b", GM_Solb) },
               //  etc ...
            };

```
- Avancement sur des projets de modules à rendre cette semaine (M152)