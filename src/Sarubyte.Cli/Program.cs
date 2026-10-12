/*
            __,__
      .--.  .-"     "-.  .--.
     / .. \/  .-. .-.  \/ .. \
    | |  '|  /   Y   \  |'  | |
    | \   \  \ 0 | 0 /  /   / |
     \ '- ,\.-"`` ``"-./, -' /
      `'-' /_   ^ ^   _\ '-'`
          |  \._   _./  |
          \   \ `~` /   /
   jgs     '._ '-=-' _.'
              '~---~'
*/

using System.CommandLine;
using Microsoft.Extensions.DependencyInjection;
using Sarubyte.Cli.Hosting;

ServiceCollection services = new ServiceCollection();

// Tools below

await using var provider = services.BuildServiceProvider();

Option<bool> verbose = new Option<bool>("--verbose")
{
 Description = "Show technical details when an error happens.",
 Recursive = true
};

RootCommand root = new RootCommand("Sarubyte: a toolbox for devs.");

root.Options.Add(verbose);

foreach (var command in provider.GetServices<ICliCommand>())
{
 root.Subcommands.Add(command.Build());
}

var parseResult = root.Parse(args);
var invocation = new InvocationConfiguration { EnableDefaultExceptionHandler = false };
var errorHandler = new ErrorHandler(Console.Error);

try
{
 return await root.Parse(args).InvokeAsync();
}
catch (Exception ex)
{
 return errorHandler.Handle(ex, parseResult.GetValue(verbose));
}