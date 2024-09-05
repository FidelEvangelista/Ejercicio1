using MinimalAPI_Ejercicio1;

var builder = WebApplication.CreateBuilder(args);

// Configuraci�n de servicios e inyecci�n de dependencias
builder.Services.AddScoped<IOperacionSumaService, OperacionSuma>();
builder.Services.AddScoped<IOperacionRestaService, OperacionResta>();
builder.Services.AddScoped<IOperacionDivisionService, OperacionDivision>();
builder.Services.AddScoped<IOperacionMultiplicacion, OperacionMultiplicacion>();

// Creaci�n de la aplicaci�n
var app = builder.Build();

#region Middlewares para operaciones aritm�ticas
app.MapGet("/operacionSuma", (decimal a, decimal b, IOperacionSumaService service) =>
{
    try
    {
        // Llamada al servicio para realizar la operaci�n
        var result = service.Suma(a, b);
        return Results.Ok(result);
    }
    catch (Exception)
    {
        // Manejo de errores 
        return Results.Problem("Error en la operaci�n Suma");
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
        return Results.Problem("Error en la operaci�n Resta");
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
        return Results.Problem("Error en la operaci�n Divisi�n");
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
        return Results.Problem("Error en la operaci�n Multiplicacion");
    }
});
#endregion


//https://localhost:7056/operacionResta?a=8.6&b=2
app.Run();
