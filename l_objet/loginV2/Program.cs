using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginV2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Utilisateur> mesUsers = new List<Utilisateur>();

            mesUsers.Add(new Utilisateur("Delon", "Adelon", "leclandessiciliens", 3, "adelon@gmail.com", "emp"));
            mesUsers.Add(new Utilisateur("Belmondo", "Bebel", "leprofessionnel", 1, "belmondo@gmail.com", "cadre"));
            mesUsers.Add(new Utilisateur("démo", "user", "user", 3, "", "emp"));
            mesUsers.Add(new Utilisateur("Patrascu", "Gabriel", "sourisdent", 1, "patrascu@gmail.com", "cadre"));
            mesUsers.Add(new Utilisateur("Charvet", "Johnny", "letaulier", 2, "cjohnny@gmail.com", "cadre"));

            //List<Utilisateur>user1= mesUsers.FindAll(monUtil => monUtil.niveauAcces == 2);
            List<Utilisateur> usercadre = mesUsers.FindAll(monCadre => monCadre.Qualification == "cadre");

            foreach (Utilisateur item in usercadre)
            {
                Console.WriteLine(item.Nom + "qualification : " + item.Qualification);
            }
            Console.ReadKey();
        }
    }
}
