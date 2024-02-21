using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1.Objects;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exo 1 : 
            // Developper un alogirthme FizzBuzz
            // Développer un programme qui pour les nombres entiers de 1 à 100 affiche
            // Fizz si le nombre est divisible par 3
            // Buzz si le nombre est divisible par 5
            // FizzBuzz si le nombre est divisble par 3 et 5
            // Sinon afficher le nombre
            // Exemple des primères occurences
            /*
             1
             2
             Fizz
             4
             Buzz
             */



            //===============================================================================================//

            /*
             Exo 2
             Un Document est composé d'une liste de feuille
             Un Fold est composé d'une liste de Document
             L'objectif de l'algo est de construire l'arbo suivant

            Fold
                -> Docs
                    -> Sheets

             Il faut que le programme parcours la liste des feuilles
             Et créer une Document pour l'ensemble des Feuilles qui se suivent avec le même type
             Et créer un Fold du moment qu'on recontre un un Document de Type Doc1
            
            Les noms les Plis doit être de ce type : Fold + incrément
            Les nom des documents doivent être de ce type : Doc + incrément à l'interieur du Fold
            
            Fold 1
                Doc 1
                    Feuille 1
                Doc 2
                    Feuille 2
                    Feuille 3
            Fold 2
                Doc 1
                    Feuille 4
                    Feuille 5
                Doc 2
                    Feuille 6
                    Feuille 7

            Fold 3
                Doc 1
                    Feuille 8
                Doc 2
                    Feuille 9

            Fold 4
                Doc 1
                    Feuille 10
                    Feuille 11
                Doc 2
                    Feuille 12
             */
            IReadOnlyList<Sheet> sheets = new List<Sheet>()
            {
                 new Sheet(Guid.NewGuid(), "Feuille 1", "Doc1")
                ,new Sheet(Guid.NewGuid(), "Feuille 2", "Doc2")
                ,new Sheet(Guid.NewGuid(), "Feuille 3", "Doc2")

                ,new Sheet(Guid.NewGuid(), "Feuille 4", "Doc1")
                ,new Sheet(Guid.NewGuid(), "Feuille 5", "Doc1")
                ,new Sheet(Guid.NewGuid(), "Feuille 6", "Doc2")
                ,new Sheet(Guid.NewGuid(), "Feuille 7", "Doc2")

                ,new Sheet(Guid.NewGuid(), "Feuille 8", "Doc1")
                ,new Sheet(Guid.NewGuid(), "Feuille 9", "Doc2")

                ,new Sheet(Guid.NewGuid(), "Feuille 10", "Doc1")
                ,new Sheet(Guid.NewGuid(), "Feuille 11", "Doc1")
                ,new Sheet(Guid.NewGuid(), "Feuille 12", "Doc2")
            };

        }
    }
}
