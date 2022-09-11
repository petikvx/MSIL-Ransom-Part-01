using System;

namespace antlr;

[Serializable]
public class NoViableAltForCharException : RecognitionException
{
	public char char_0;

	public override string Message => (string)Class26.smethod_0(7345808, this, null);

	public NoViableAltForCharException(char char_1, GClass30 gclass30_0)
	{
	}

	public NoViableAltForCharException(char char_1, string string_1, int int_2, int int_3)
	{
	}
}
