namespace Sarubyte.Core.Shared.Errors;

public sealed class DataFormatException(string message, Exception? inner = null) : SarubyteException(message, ExitCodes.Data, inner);