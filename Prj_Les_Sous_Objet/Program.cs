using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Les_Sous_Objet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objet Stagiares

            Stagiaire stg1 = new Stagiaire();
            stg1.NI = 585545;
            stg1.Nom = "Amine";
            stg1.Prenom = "Amroussi";

            // objet Matier 
            stg1.mat1 = new Matier();
            stg1.mat2 = new Matier();
            stg1.mat3 = new Matier();

            // Matier 1 
            stg1.mat1.Designation = "Algorthme";
            stg1.mat1.Note = 15.5;
            stg1.mat1.Ceofficient = 4;

            // Matier 2
            stg1.mat2.Designation = "Programation strecturé";
            stg1.mat2.Note = 16.2;
            stg1.mat2.Ceofficient = 3;

            // Matier 1 
            stg1.mat1.Designation = "POO";
            stg1.mat1.Note = 18;
            stg1.mat1.Ceofficient = 4;

            // Appeles des methode 
            stg1.MoyenneGenerale();
            stg1.Affichage();


            Console.ReadKey();

        }
    }
}
