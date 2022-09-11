using System;
using antlr.collections;

namespace antlr;

[Serializable]
public class NoViableAltException : RecognitionException
{
	public GInterface17 ginterface17_0;

	public AST ast_0;

	public override string Message => (string)Class26.smethod_0(7345793, this, null);

	public NoViableAltException(AST ast_1)
	{
	}

	public NoViableAltException(GInterface17 ginterface17_1, string string_1)
	{
	}
}
