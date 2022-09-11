using System;

namespace antlr;

[Serializable]
public class RecognitionException : ANTLRException
{
	public string string_0;

	public int int_0;

	public int int_1;

	public RecognitionException()
	{
	}

	public RecognitionException(string string_1)
	{
	}

	public RecognitionException(string string_1, string string_2, int int_2, int int_3)
	{
	}

	public virtual string vmethod_0()
	{
		return (string)Class26.smethod_0(7347279, this, null);
	}

	public virtual int vmethod_1()
	{
		return (int)Class26.smethod_0(7347294, this, null);
	}

	public virtual int vmethod_2()
	{
		return (int)Class26.smethod_0(7347305, this, null);
	}

	[Obsolete("Replaced by Message property since version 2.7.0", true)]
	public virtual string vmethod_3()
	{
		return (string)Class26.smethod_0(7347320, this, null);
	}

	public override string ToString()
	{
		return (string)Class26.smethod_0(7347211, this, null);
	}
}
