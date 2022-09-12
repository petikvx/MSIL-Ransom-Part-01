using System;

namespace HtmlAgilityPack;

public class HtmlWebException : Exception
{
	public HtmlWebException(string message)
		: base(message)
	{
	}
}
