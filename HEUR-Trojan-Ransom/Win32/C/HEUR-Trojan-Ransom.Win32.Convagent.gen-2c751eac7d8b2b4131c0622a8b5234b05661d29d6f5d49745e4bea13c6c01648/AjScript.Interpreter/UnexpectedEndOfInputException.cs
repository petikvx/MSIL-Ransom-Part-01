namespace AjScript.Interpreter;

public class UnexpectedEndOfInputException : LexerException
{
	public UnexpectedEndOfInputException()
		: base("Unexpected End of Input")
	{
	}
}
