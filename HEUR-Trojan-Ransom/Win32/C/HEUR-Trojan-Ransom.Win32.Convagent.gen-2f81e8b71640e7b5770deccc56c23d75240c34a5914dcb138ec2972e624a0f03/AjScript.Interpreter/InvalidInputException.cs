using System.Globalization;

namespace AjScript.Interpreter;

public class InvalidInputException : LexerException
{
	public InvalidInputException(string text)
		: base(string.Format(CultureInfo.CurrentCulture, "Invalid Input '{0}'", new object[1] { text }))
	{
	}
}
