namespace Sarubyte.Core.Shared.Errors;

public static class ExitCodes
{
    public const int Success = 0;
    public const int Usage = 1; // wrong command
    public const int Data = 2; // invalid archive
    public const int Io = 3; // read/write error
    public const int Internal = 4; // internal bug
}