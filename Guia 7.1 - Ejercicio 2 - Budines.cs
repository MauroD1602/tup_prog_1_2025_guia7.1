namespace Guia_7._1___Ejercicio_2___Budines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cantMasa, cantSobrante;
            int cantCajas, cantBudines, cantPaquetes, cantBS, cantPS;

            Console.WriteLine("Cant Masa en Gramos");
            cantMasa = Convert.ToDouble(Console.ReadLine());

            cantBudines = (int)(cantMasa / 55);
            cantSobrante = cantMasa % 55;
            cantPaquetes = cantBudines / 12;
            cantCajas = cantPaquetes / 20;
            cantBS = cantBudines % 12;
            cantPS = cantPaquetes % 20;

            Console.WriteLine("Produccion: ");
            Console.WriteLine($"Budines: {cantBudines}, Paquetes: {cantPaquetes}, Cajas: {cantCajas}");
            Console.WriteLine("Sobrantes: ");
            Console.WriteLine($"Masa en g: {cantSobrante}, Budines en g: {cantBS}, Paquetes: {cantPS}");
        }
    }
}
