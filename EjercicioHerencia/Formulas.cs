namespace EjercicioHerencia
{
    public class Formulas : Operaciones
    {
        public double lado {  get; set; }
        public Formulas(double lado) {
            this.lado = lado;
        }
        public void imprimir()
        {
            Console.WriteLine($"El área es: {CalcularArea}");
            Console.WriteLine($"El perímetro es: {CalcularPerimetro}");
            Console.WriteLine($"El volúmen es: {CalcularVolumen}");
        }
    }
}
