namespace Estructuras
{
    internal class Program
    {
        public static Predicate<string> miPredicado = n => n == "Alex";
        static void Main(string[] args)
        {
            

            miEstructura estructuraxd = new miEstructura();
            estructuraxd.Saludar();

            var nombres = new List<string>()
            {
                "Juan",
                "Alex",
                "Fernando",
                "Damian",
                "Eduardo"
            };
            // el metodo Find recibe un predicado, no un filtro como FindAsync
            //string resultado = nombres.Find("Alex");
            string resultado = nombres.Find(miPredicado);
            //Tambien puede recibir un metodo!
            //string resultado = nombres.Find(test);
        }
        static bool test(string name)
        {
            return name == "Alex";
        }
    }

    public interface IContratoSuma
    {
        int Sumatoria(int n1, int n2);
    }
    struct miEstructura : IContratoSuma
    {
        public void Saludar()
        {
            Console.WriteLine("Hola mundo alv fierro viejo");
        }

        public int Sumatoria(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
