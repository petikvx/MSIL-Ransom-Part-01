using System;

namespace AjScript.Interpreter;

public abstract class LexerException : Exception
{
	protected LexerException(string msg)
		: base(msg)
	{
	}
}
