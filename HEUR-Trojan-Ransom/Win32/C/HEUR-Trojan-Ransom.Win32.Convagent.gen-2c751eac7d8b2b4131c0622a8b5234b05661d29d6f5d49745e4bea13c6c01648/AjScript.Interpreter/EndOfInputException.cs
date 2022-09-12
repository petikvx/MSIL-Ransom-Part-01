using System;

namespace AjScript.Interpreter;

public class EndOfInputException : Exception
{
	public EndOfInputException()
		: this("End of Input")
	{
	}

	public EndOfInputException(string msg)
		: base(msg)
	{
	}
}
