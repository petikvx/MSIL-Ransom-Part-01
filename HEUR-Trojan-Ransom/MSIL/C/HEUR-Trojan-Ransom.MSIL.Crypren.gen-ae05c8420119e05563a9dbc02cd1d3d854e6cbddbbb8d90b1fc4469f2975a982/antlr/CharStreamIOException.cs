using System;
using System.IO;

namespace antlr;

[Serializable]
public class CharStreamIOException : CharStreamException
{
	public IOException ioexception_0;

	public CharStreamIOException(IOException ioexception_1)
	{
	}
}
