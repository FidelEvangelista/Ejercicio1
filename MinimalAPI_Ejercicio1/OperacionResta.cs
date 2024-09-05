namespace MinimalAPI_Ejercicio1
{
    public class OperacionResta : IOperacionRestaService
    {
        public decimal Restar(decimal valor1, decimal valor2)
        {
            return valor1 - valor2;
        }
    }
}
