using System;

namespace Authentication
{
    class Program
    {
        static void Main()
        {
            string login = "Admin";
            string password = "P@ssw0rd";

            Console.Write("Digite su login: ");

            // En la linea 17 declaramos una cadena de variables locales con el nombre usersLogin 
            // Y recibimos en ella lo escrito por el usuario .
            
            string usersLogin = Console.ReadLine(); 
            
            if (login == usersLogin)
            {
               Console.Write("Digite la contraseña: ");
                string usersPassword = Console.ReadLine();
                
                if (password == usersPassword)
                {
                    Console.WriteLine("Hola {0}, Usted entro al sistema.", usersLogin);
                }
                else
                {
                    Console.WriteLine("Habéis introducido una contraseña incorrecta.");
                }                
            }
            else
            {
                Console.WriteLine("No hay  usuario con tal nombre.");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}

