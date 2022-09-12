using System;

namespace AjScript.Interpreter;

public class ParserException : Exception
{
	public ParserException(string message)
		: base(message)
	{
	}
}
