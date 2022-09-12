using System;

namespace HtmlAgilityPack;

public class MissingXPathException : Exception
{
	public MissingXPathException()
	{
	}

	public MissingXPathException(string message)
		: base(message)
	{
	}

	public MissingXPathException(string message, Exception inner)
		: base(message, inner)
	{
	}
}
