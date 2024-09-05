namespace MinimalAPI_Ejercicio1
{
    public class OperacionDivision : IOperacionDivisionService
    {
        public decimal Dividir(decimal valor1, decimal valor2)
        {
            return valor1 / valor2;
        }
    }
}
