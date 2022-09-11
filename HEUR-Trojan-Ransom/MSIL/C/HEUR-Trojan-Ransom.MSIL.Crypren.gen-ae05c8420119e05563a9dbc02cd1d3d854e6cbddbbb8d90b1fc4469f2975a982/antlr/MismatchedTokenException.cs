using System;
using antlr.collections;

namespace antlr;

[Serializable]
public class MismatchedTokenException : RecognitionException
{
	public enum GEnum2
	{
		const_0 = 1,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5
	}

	internal string[] string_1;

	public GInterface17 ginterface17_0;

	public AST ast_0;

	internal string string_2;

	public GEnum2 genum2_0;

	public int int_2;

	public int int_3;

	public GClass2 gclass2_0;

	public override string Message => (string)Class26.smethod_0(7345894, this, null);

	public MismatchedTokenException()
	{
	}

	public MismatchedTokenException(string[] string_3, AST ast_1, int int_4, int int_5, bool bool_0)
	{
	}

	public MismatchedTokenException(string[] string_3, AST ast_1, int int_4, bool bool_0)
	{
	}

	public MismatchedTokenException(string[] string_3, AST ast_1, GClass2 gclass2_1, bool bool_0)
	{
	}

	public MismatchedTokenException(string[] string_3, GInterface17 ginterface17_1, int int_4, int int_5, bool bool_0, string string_4)
	{
	}

	public MismatchedTokenException(string[] string_3, GInterface17 ginterface17_1, int int_4, bool bool_0, string string_4)
	{
	}

	public MismatchedTokenException(string[] string_3, GInterface17 ginterface17_1, GClass2 gclass2_1, bool bool_0, string string_4)
	{
	}

	private string method_0(int int_4)
	{
		return (string)Class26.smethod_0(7345905, this, int_4);
	}
}
