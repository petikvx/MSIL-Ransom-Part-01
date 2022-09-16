namespace GreenPixelsCalculator.IO;

public enum ResultType : byte
{
	SUCCESS,
	UNKNOWN,
	TERMINATED,
	CANT_READ,
	INVALID_DATA,
	UNKNOWN_COMMAND,
	UNEXPECTED_COMMAND
}
