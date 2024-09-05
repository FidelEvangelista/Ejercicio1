namespace MinimalAPI_Ejercicio1
{
    public class OperacionMultiplicacion : IOperacionMultiplicacion
    {
        public decimal Multiplicacion(decimal valor1, decimal valor2)
        {
            return valor1 * valor2;
        }
    }
}
