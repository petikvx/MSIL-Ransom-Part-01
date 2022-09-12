using System.Globalization;

namespace AjScript.Interpreter;

public class UnexpectedTokenException : LexerException
{
	public UnexpectedTokenException(Token token)
		: base(string.Format(CultureInfo.CurrentCulture, "Unexpected '{0}'", new object[1] { token.Value }))
	{
	}
}
