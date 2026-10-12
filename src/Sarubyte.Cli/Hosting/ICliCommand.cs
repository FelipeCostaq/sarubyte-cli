using System.CommandLine;

namespace Sarubyte.Cli.Hosting;

internal interface ICliCommand
{
    Command Build();
}