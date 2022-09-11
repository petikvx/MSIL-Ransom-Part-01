using System;
using System.Collections;
using System.IO;
using antlr.collections;

namespace antlr;

[Serializable]
public abstract class BaseAST : AST, ICloneable
{
	protected internal BaseAST down;

	protected internal BaseAST right;

	private static bool verboseStringConversion;

	private static string[] tokenNames;

	public virtual int Type
	{
		get
		{
			return (int)Class26.smethod_0(7398181, this, null);
		}
		set
		{
			Class26.smethod_0(7398196, this, value);
		}
	}

	static BaseAST()
	{
		Class26.smethod_0(7397433, null, null);
	}

	public virtual void imethod_0(AST ast_0)
	{
		Class26.smethod_0(7398345, this, ast_0);
	}

	private void method_0(ArrayList arrayList_0, AST ast_0, bool bool_0)
	{
		Class26.smethod_0(7398367, this, arrayList_0, ast_0, bool_0);
	}

	public override bool Equals(object obj)
	{
		return (bool)Class26.smethod_0(7398387, this, obj);
	}

	public virtual bool Equals(AST t)
	{
		return (bool)Class26.smethod_0(7398275, this, t);
	}

	public virtual bool imethod_1(AST ast_0)
	{
		return (bool)Class26.smethod_0(7398288, this, ast_0);
	}

	public virtual bool imethod_2(AST ast_0)
	{
		return (bool)Class26.smethod_0(7398305, this, ast_0);
	}

	public virtual bool imethod_3(AST ast_0)
	{
		return (bool)Class26.smethod_0(7398326, this, ast_0);
	}

	public virtual bool imethod_4(AST ast_0)
	{
		return (bool)Class26.smethod_0(7398215, this, ast_0);
	}

	public virtual IEnumerator imethod_5(AST ast_0)
	{
		return (IEnumerator)Class26.smethod_0(7398228, this, ast_0);
	}

	public virtual IEnumerator imethod_6(AST ast_0)
	{
		return (IEnumerator)Class26.smethod_0(7398245, this, ast_0);
	}

	public virtual AST imethod_7()
	{
		return (AST)Class26.smethod_0(7398266, this, null);
	}

	public virtual AST imethod_8()
	{
		return (AST)Class26.smethod_0(7398154, this, null);
	}

	public virtual string imethod_9()
	{
		return (string)Class26.smethod_0(7398170, this, null);
	}

	public int imethod_10()
	{
		return (int)Class26.smethod_0(7398085, this, null);
	}

	public abstract void imethod_11(int int_0, string string_0);

	public abstract void imethod_12(AST ast_0);

	public abstract void imethod_13(GInterface17 ginterface17_0);

	public virtual void vmethod_0()
	{
		Class26.smethod_0(7398100, this, null);
	}

	public virtual void imethod_14(AST ast_0)
	{
		Class26.smethod_0(7398116, this, ast_0);
	}

	public virtual void imethod_15(AST ast_0)
	{
		Class26.smethod_0(7398138, this, ast_0);
	}

	public virtual void imethod_16(string string_0)
	{
		Class26.smethod_0(7398024, this, string_0);
	}

	public virtual void imethod_17(int int_0)
	{
		Class26.smethod_0(7398041, this, int_0);
	}

	public static void smethod_0(bool bool_0, string[] string_0)
	{
		Class26.smethod_0(7398062, null, bool_0, string_0);
	}

	public override string ToString()
	{
		return (string)Class26.smethod_0(7398077, this, null);
	}

	public virtual string imethod_18()
	{
		return (string)Class26.smethod_0(7397964, this, null);
	}

	public virtual string imethod_19()
	{
		return (string)Class26.smethod_0(7397983, this, null);
	}

	public virtual string vmethod_1()
	{
		return (string)Class26.smethod_0(7397998, this, null);
	}

	public virtual string vmethod_2(string string_0)
	{
		return (string)Class26.smethod_0(7398009, this, string_0);
	}

	public static string smethod_1(string string_0)
	{
		return (string)Class26.smethod_0(7397897, null, string_0);
	}

	public static string smethod_2(string string_0)
	{
		return (string)Class26.smethod_0(7397913, null, string_0);
	}

	public virtual void vmethod_3(TextWriter textWriter_0)
	{
		Class26.smethod_0(7397929, this, textWriter_0);
	}

	public virtual void vmethod_4(TextWriter textWriter_0)
	{
		Class26.smethod_0(7397950, this, textWriter_0);
	}

	public virtual void vmethod_5(TextWriter textWriter_0)
	{
		Class26.smethod_0(7400911, this, textWriter_0);
	}

	public virtual void vmethod_6(TextWriter textWriter_0)
	{
		Class26.smethod_0(7400924, this, textWriter_0);
	}

	[Obsolete("Deprecated since version 2.7.2. Use ASTFactory.dup() instead.", false)]
	public virtual object Clone()
	{
		return Class26.smethod_0(7400941, this, null);
	}

	public override int GetHashCode()
	{
		return (int)Class26.smethod_0(7400956, this, null);
	}
}
