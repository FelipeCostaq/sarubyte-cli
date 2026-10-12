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

var services = new ServiceCollection();

// Tools below

await using var provider = services.BuildServiceProvider();

RootCommand root = new RootCommand("Sarubyte: a toolbox for devs.");

foreach (var command in provider.GetServices<ICliCommand>())
{
 root.Subcommands.Add(command.Build());
}

return await root.Parse(args).InvokeAsync();