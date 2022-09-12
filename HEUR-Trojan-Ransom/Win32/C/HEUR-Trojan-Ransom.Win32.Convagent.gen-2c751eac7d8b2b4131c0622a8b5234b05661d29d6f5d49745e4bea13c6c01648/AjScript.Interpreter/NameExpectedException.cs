namespace AjScript.Interpreter;

public class NameExpectedException : LexerException
{
	public NameExpectedException()
		: base("A name was expected")
	{
	}
}
