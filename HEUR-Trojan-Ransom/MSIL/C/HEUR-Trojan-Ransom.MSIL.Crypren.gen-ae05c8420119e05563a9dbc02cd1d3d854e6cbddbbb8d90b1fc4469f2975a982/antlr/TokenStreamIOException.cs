using System;
using System.IO;

namespace antlr;

[Serializable]
public class TokenStreamIOException : TokenStreamException
{
	public IOException ioexception_0;

	public TokenStreamIOException(IOException ioexception_1)
	{
	}
}
