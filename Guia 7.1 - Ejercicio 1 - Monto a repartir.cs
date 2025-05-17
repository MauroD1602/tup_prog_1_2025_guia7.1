namespace Guia_7._1___Ejercicio_1___Monto_a_repartir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] edades = new int[4];
            double[] porcentajes = new double[4];
            double[] partes = new double[4];
            double monto = 0;
            int totalEdades = 0;

            Console.Write("Ingrese el monto total a repartir: ");
            monto = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Ingrese la edad de la Nina {i + 1}: ");
                edades[i] = Convert.ToInt32(Console.ReadLine());
                totalEdades += edades[i];
            }

            for (int i = 0; i < 4; i++)
            {
                porcentajes[i] = (double)edades[i] / totalEdades * 100;
                partes[i] = (porcentajes[i] / 100) * monto;

                Console.WriteLine($"Nina {i + 1}:");
                Console.WriteLine($"Edad: {edades[i]} años");
                Console.WriteLine($"Porcentaje: {porcentajes[i]:0.00}%");
                Console.WriteLine($"Parte recibida: ${partes[i]:0.00}");
                Console.WriteLine();
            }
        }
    }
}
