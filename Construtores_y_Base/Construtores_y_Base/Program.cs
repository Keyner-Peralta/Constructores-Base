using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Construtores_y_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo caballo = new Caballo("rodolfo");// Instancia de Caballo

            Humano humano = new Humano("Pedro");// Instancia de Humano

            Gorila gorila = new Gorila("Michael");// Instancia de Gorila

            Console.WriteLine(caballo.Name);
            Console.WriteLine(humano.Name);
            Console.WriteLine(gorila.Name);
            Console.WriteLine("---------------");

            Console.WriteLine(caballo.Name);
        }
    }

    class Mamifero
    {
        private string name;
        
        public Mamifero(string name) // Mamifero recibe los nombres que pasan por base
        {
            this.name = name;
        }

        public void Existe()
        {
            Console.WriteLine("Soy un mamifero por ende existo");
        }

        public string Name // Propiedad de clase equivalente a usar { get; set;}
        { 
            get { return name; } 
        }
    }
    class Caballo : Mamifero 
    {
        // Este Constructor recibe el nombre
        public Caballo(string name) : base(name) // base lo copia y lo manda al constructor de la clase Mamifero
        {
        }

        public void Galopar()
        {
            Console.WriteLine("Soy un caballo y puedo galopar");
        }
    }
    class Humano : Mamifero
    {
        public Humano(string name) : base(name)
        {
        }

        public void Pensar()
        {
            Console.WriteLine("Soy un humano y puedo pensar");
        }
    }
    class Gorila : Mamifero
    {
        public Gorila(string name) : base(name)
        {
        }

        public void Golpear()
        {
            Console.WriteLine("Soy un gorila y puedo golpear");
        }
    }
    
}
