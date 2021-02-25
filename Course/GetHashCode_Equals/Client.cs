using System;
using System.Collections.Generic;
using System.Text;

namespace Course.GetHashCode_Equals
{
    class Client
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        // Vamos customizar a lógica para saber quando é que um Client é igual a um outro Client
        public override bool Equals(object obj)
        {
            // Vou comparar o "Client" com um outro "Client" que virá como argumento do  método "Equals(object obj)"

            if (!(obj is Client)) 
            {
                return false;
            }
            Client other = obj as Client;

            // Se eu quiser comparar os "Client" com base o "Email" deles
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
