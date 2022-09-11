using System;
using System.Text;

internal class Exception0 : Exception
{
	private Encoding encoding_0;

	internal Encoding Encoding_0 => encoding_0;

	internal Exception0(Encoding encoding_1)
	{
		encoding_0 = encoding_1;
	}
}
