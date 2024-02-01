using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Utente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Registrati \n2) Effetua il login");
            Console.WriteLine("Scegli un'opzione: ");
            int resp = int.Parse(Console.ReadLine());
            Utente utente = new Utente();
            Console.WriteLine("Inserisci email: ");
            string email = Console.ReadLine();
            utente.SetEmail(email);
            Console.WriteLine("Inserisci password: ");
            string password = Console.ReadLine();
            utente.SetPassword(password);

            do
            {
                Console.WriteLine("Effetua il login: ");
                Console.WriteLine("Email: ");
                email = Console.ReadLine();
                Console.WriteLine("Password: ");
                password = Console.ReadLine();
                Console.WriteLine(utente.Login(email, password));
            } while {!utente.getIsLogged()};




            Console.ReadLine();
        }
    }
}
