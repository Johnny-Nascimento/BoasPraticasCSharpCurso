using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Modelos;

try
{
    string comandoASerExecutado = args[0].Trim();
    Dictionary<string, IComando> comandosDoSistema = new()
    {
        { "import", new Importacao()},
        { "help", new Ajuda()},
        { "show", new Mostrar()},
        { "list", new Lista()}
    };

    IComando? comando;
    if (comandosDoSistema.TryGetValue(comandoASerExecutado, out comando))
    {
        await comando.ExecutarAsync(args);
    }
    else
        Console.WriteLine("Comando inválido!");
}
catch (Exception ex)
{
    // mostra a exceção em vermelho
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Aconteceu um exceção: {ex.Message}");
}
finally
{
    Console.ForegroundColor = ConsoleColor.White;
}
