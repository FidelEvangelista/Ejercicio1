using MinimalAPI_Ejercicio1;

var builder = WebApplication.CreateBuilder(args);

// Configuración de servicios e inyección de dependencias
builder.Services.AddScoped<IOperacionSumaService, OperacionSuma>();
builder.Services.AddScoped<IOperacionRestaService, OperacionResta>();
builder.Services.AddScoped<IOperacionDivisionService, OperacionDivision>();
builder.Services.AddScoped<IOperacionMultiplicacion, OperacionMultiplicacion>();

// Creación de la aplicación
var app = builder.Build();

#region Middlewares para operaciones aritméticas
app.MapGet("/operacionSuma", (decimal a, decimal b, IOperacionSumaService service) =>
{
    try
    {
        // Llamada al servicio para realizar la operación
        var result = service.Suma(a, b);
        return Results.Ok(result);
    }
    catch (Exception)
    {
        // Manejo de errores 
        return Results.Problem("Error en la operación Suma");
    }
});

app.MapGet("/operacionResta", (decimal a, decimal b, IOperacionRestaService service) =>
{
    try
    {
        var result = service.Restar(a, b);
        return Results.Ok(result);
    }
    catch (Exception)
    {
        return Results.Problem("Error en la operación Resta");
    }
});

app.MapGet("/operacionDivision", (decimal a, decimal b, IOperacionDivisionService service) =>
{
    try
    {
        var result = service.Dividir(a, b);
        return Results.Ok(result);
    }
    catch (Exception)
    {
        return Results.Problem("Error en la operación División");
    }
});

app.MapGet("/operacionMultiplicacion", (decimal a, decimal b, IOperacionMultiplicacion service) =>
{
    try
    {
        var result = service.Multiplicacion(a, b);
        return Results.Ok(result);
    }
    catch (Exception)
    {
        return Results.Problem("Error en la operación Multiplicacion");
    }
});
#endregion


//https://localhost:7056/operacionResta?a=8.6&b=2
app.Run();
