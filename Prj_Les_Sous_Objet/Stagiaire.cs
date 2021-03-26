using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Les_Sous_Objet
{
    class Stagiaire
    {
        public double NI;   
        public string Nom;
        public string Prenom;

        public Matier mat1;
        public Matier mat2;
        public Matier mat3;

        public double Moy;

        // Methode de calcule moyenne generale
        public void MoyenneGenerale()
        {
            double mt1 = mat1.Note * mat1.Ceofficient;
            double mt2 = mat2.Note * mat2.Ceofficient;
            double mt3 = mat3.Note * mat3.Ceofficient;
            double totCeo = mat1.Ceofficient + mat2.Ceofficient + mat3.Ceofficient;

            Moy = (mt1 + mt1 + mt3) / totCeo;

        }

        // Affichage 
        public void Affichage() {
            Console.WriteLine("Le NI : {0}" , NI);
            Console.WriteLine("Le nom : {0} ", Nom);
            Console.WriteLine("Le prenom : {0} ", Prenom);
            Console.WriteLine("La Moyenne Generale : {0}" , Moy);
        }

        // Constructore
        public Stagiaire()
        { 
            
        }

    }
}
