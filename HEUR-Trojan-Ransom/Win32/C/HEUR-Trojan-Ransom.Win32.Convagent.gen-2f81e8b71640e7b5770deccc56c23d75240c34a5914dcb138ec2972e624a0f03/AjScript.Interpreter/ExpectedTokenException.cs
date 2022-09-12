using System.Globalization;

namespace AjScript.Interpreter;

public class ExpectedTokenException : LexerException
{
	public ExpectedTokenException(string token)
		: base(string.Format(CultureInfo.CurrentCulture, "Expected '{0}'", new object[1] { token }))
	{
	}
}
