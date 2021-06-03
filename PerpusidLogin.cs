using System;

namespace Jurnalmodul12_1302194105
{
    public class perpusidLogin
    {
        public string userName; // variable username
        public string password; // variable password


        public string inputUserName //property
        {
            get { return userName; } //get userName
            set { userName = value; } //set userName
        }
        public string inputPassword // property 
        {
            get { return password; } // get password
            set { password = value; }// set passsword
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            // method inputUser
            perpusidLogin inputUser = new perpusidLogin();
            inputUser.userName = "ihsan";
            inputUser.password = "12345";

            // user menginputkan username
            Console.WriteLine("Masukkan Username: ");
            string inputUsername = Console.ReadLine();


            // user mengintputkan password
            Console.WriteLine("Masukkan Password: ");
            string inputPassword = Console.ReadLine();


            

            // kondisi inputan username benar atau salah
            if (inputUsername.Equals(inputUser.userName) && (inputPassword.Equals(inputUser.password)))
            {
                Console.WriteLine("Selamat " + inputUsername + " anda berhasil melakukan login!");
            }
            else
            {
                Console.WriteLine("Username atau Password anda salah, coba ulang kembali");
            }
        }
    }
}
    
      