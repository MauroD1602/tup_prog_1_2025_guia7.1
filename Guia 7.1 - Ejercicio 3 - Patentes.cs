namespace Guia_7._1___Ejercicio_3___Patentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Ingrese un nro");
            num = Convert.ToInt32(Console.ReadLine());

            int parteLetras = num / 1000;
            int parteNumeros = num % 1000;

            string letra1 = "A";
            string letra2 = "A";
            string letra3 = "A";

            if (parteLetras > 0)
            {
                int l1, l2, l3;
                l3 = parteLetras % 26;
                parteLetras = parteLetras / 26;

                l2 = parteLetras % 26;
                parteLetras = parteLetras / 26;

                l1 = parteLetras % 26;

                letra3 = Convert.ToChar('A' + l3).ToString();
                letra2 = Convert.ToChar('A' + l2).ToString();
                letra1 = Convert.ToChar('A' + l1).ToString();
            }

            int c = parteNumeros / 100;
            int d = (parteNumeros / 10) % 10;
            int u = parteNumeros % 10;

            string numeros = Convert.ToChar('0' + c).ToString() + Convert.ToChar('0' + d).ToString() + Convert.ToChar('0' + u).ToString();

            Console.WriteLine($"Su patente es: {letra1 + letra2 + letra3 + numeros}");
        }
    }
}
