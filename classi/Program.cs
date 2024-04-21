using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace classi
{
    public class Auto()
    {
        public int peso;
        public int anni;
        //void funzioneclasse();

        //so mettendo dentro una classe unaltra classe 
        public Libro miolibro;



        public class Miaauto()
        {
            
        }
    }

    public class Libro()
    {
        public string marca;


        public class Miolibro
        {

        }
    }

    public class Gomma()
    {
        public int numero;


        public class esca
        {

        }
    }





    internal class Program
    {
        static void Main(string[] args)
        {
          
            void funzioneclasse()
            {

            }

            //creazione istanza
            Auto miaauto = new Auto();
            Libro miolibro = new Libro();
            miaauto.miolibro = new Libro();
            Gomma esca = new Gomma();

            //asegniazione valore

            esca.numero = 129;
            miaauto.peso = 10000;
            miaauto.anni = 1998;
            miaauto.miolibro.marca = "mondadori";
            miolibro.marca = "mondadori";
            

           

            //lettura 
            Console.WriteLine(miaauto.peso);
            Console.WriteLine(miaauto.anni);
            Console.WriteLine(miaauto.miolibro);
            Console.WriteLine(esca.numero);
            //cosi stampo 
            Console.WriteLine(miaauto);
        }
    }
}
