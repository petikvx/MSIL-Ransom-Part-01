using System;
using antlr;
using antlr.collections;

public class GClass24 : BaseAST
{
	public class GClass20 : GClass19
	{
		public override string String_0 => (string)Class26.smethod_0(7400020, this, null);

		public override AST vmethod_0()
		{
			return (AST)Class26.smethod_0(7400039, this, null);
		}
	}

	public static readonly GClass20 gclass20_0;

	internal int int_0;

	internal string string_0;

	public override int Type
	{
		get
		{
			return (int)Class26.smethod_0(7400141, this, null);
		}
		set
		{
			Class26.smethod_0(7400156, this, value);
		}
	}

	[Obsolete("Deprecated since version 2.7.2. Use ASTFactory.dup() instead.", false)]
	protected GClass24(GClass24 gclass24_0)
	{
	}

	public GClass24()
	{
	}

	public GClass24(GInterface17 ginterface17_0)
	{
	}

	static GClass24()
	{
		Class26.smethod_0(7400242, null, null);
	}

	public override string imethod_9()
	{
		return (string)Class26.smethod_0(7400130, this, null);
	}

	public override void imethod_11(int int_1, string string_1)
	{
		Class26.smethod_0(7400173, this, int_1, string_1);
	}

	public override void imethod_12(AST ast_0)
	{
		Class26.smethod_0(7400067, this, ast_0);
	}

	public override void imethod_13(GInterface17 ginterface17_0)
	{
		Class26.smethod_0(7400081, this, ginterface17_0);
	}

	public override void imethod_16(string string_1)
	{
		Class26.smethod_0(7400103, this, string_1);
	}

	public override void imethod_17(int int_1)
	{
		Class26.smethod_0(7400116, this, int_1);
	}

	[Obsolete("Deprecated since version 2.7.2. Use ASTFactory.dup() instead.", false)]
	public override object Clone()
	{
		return Class26.smethod_0(7400005, this, null);
	}
}
