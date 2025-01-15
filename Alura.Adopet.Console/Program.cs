using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Modelos;

try
{
    string comandoASerExecutado = args[0].Trim();
    switch (comandoASerExecutado)
    {
        case "import":
            Importacao importacao = new Importacao();
            await importacao.ExecutarAsync(args);
        break;

        case "help":
            Ajuda ajuda = new Ajuda();
            ajuda.MostraInformacoesDeAjuda(opcaoDeAjuda:args.Length == 2 ? args[1] : string.Empty);
        break;

        case "show":
            Mostrar mostrar = new Mostrar();
            await mostrar.ExecutarAsync(args);
        break;

        case "list":
            Lista lista = new Lista();
            await lista.ExecutarAsync(args);
        break;

        default:
            Console.WriteLine("Comando inválido!");
        break;
    }
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
