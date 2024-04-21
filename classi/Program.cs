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

    public class Provauno()
    {
        public string esempio1;
        public Provadue provadue;

        

        public class provauno()
        {

        }

        public void Metodo()
        {
            Console.WriteLine($"ciao mondo {esempio1}");
        }
    }

    public class Provadue()
    {
        public int esempio2;
        public static int provastatica;



    }

   
    public class Costruttore()
    {
        public int nombre;

        public Costruttore(int nombre)
        {
            this.nombre = nombre;
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
            Costruttore ogetto = new Costruttore(2);
            Auto miaauto = new Auto();
            Libro miolibro = new Libro();
            miaauto.miolibro = new Libro();
            Gomma esca = new Gomma();
            Provauno provauno = new Provauno();
            provauno.provadue = new Provadue();
            Provadue.provastatica++;



            //asegniazione valore

            esca.numero = 129;
            miaauto.peso = 10000;
            miaauto.anni = 1998;
            miaauto.miolibro.marca = "mondadori";
            miolibro.marca = "mondadori";


            provauno.esempio1 = "vediamo se va";
            provauno.
            provadue = new Provadue();
            provauno.Metodo();




            //lettura 
            Console.WriteLine(miaauto.peso);
            Console.WriteLine(miaauto.anni);
            Console.WriteLine(miaauto.miolibro);
            Console.WriteLine(esca.numero);
            Console.WriteLine(provauno.esempio1);
            //cosi stampo 
            Console.WriteLine(miaauto);
        }
    }
}
