using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utente
{
    internal class Utente
    {
        private string email;
        private string password;
        private bool isLoggedIn;
        private int[] voti {  get; set; }

        public Utente() { }
        public Utente(string email, string password)
        {
            this.email = email;
            this.password = password;
            this.isLoggedIn = false;
            this.voti = new int[] { 0, 0, 0};
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }
        public void SetPassword(string password)
        {
            this.password = password;
        }

        public bool getIsLogged()
        {
            return this.isLoggedIn;
        }

        public string Login(string email, string password) 
        {
            if (this.email == email && this.password == password)
            {
                isLoggedIn = true;
                return "Login effettuato con successo!";
            }
            else
            {
                return "Email e password non corretti";
            }
        }

        public void Vota()
        {
            for (int i = 0; i < voti.Length; i++)
            {
                Console.Write($"Domanda {i + 1}");
                Console.Write("Opzione 1");
                Console.Write("Opzione 2");
                Console.Write("Opzione 3");
                voti[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
