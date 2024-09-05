namespace MinimalAPI_Ejercicio1
{
    //esta clase será inyectada como dependencia en otros componentes del sistema
    public class OperacionSuma : IOperacionSumaService
    {

        // Este método es parte de la interfaz IOperacionSumaService y debe ser implementado por esta clase
        public decimal Suma(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
