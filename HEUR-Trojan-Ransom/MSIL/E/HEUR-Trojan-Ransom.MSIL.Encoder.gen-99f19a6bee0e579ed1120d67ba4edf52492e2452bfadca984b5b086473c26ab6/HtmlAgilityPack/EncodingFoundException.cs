using System;
using System.Text;

namespace HtmlAgilityPack;

internal class EncodingFoundException : Exception
{
	private Encoding _encoding;

	internal Encoding Encoding => _encoding;

	internal EncodingFoundException(Encoding encoding)
	{
		_encoding = encoding;
	}
}
