using System;
using System.Text;

namespace antlr;

[Serializable]
public class MismatchedCharException : RecognitionException
{
	public enum GEnum1
	{
		const_0 = 1,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5
	}

	public GEnum1 genum1_0;

	public int int_2;

	public int int_3;

	public int int_4;

	public GClass2 gclass2_0;

	public GClass30 gclass30_0;

	public override string Message => (string)Class26.smethod_0(7345857, this, null);

	public MismatchedCharException()
	{
	}

	public MismatchedCharException(char char_0, char char_1, char char_2, bool bool_0, GClass30 gclass30_1)
	{
	}

	public MismatchedCharException(char char_0, char char_1, bool bool_0, GClass30 gclass30_1)
	{
	}

	public MismatchedCharException(char char_0, GClass2 gclass2_1, bool bool_0, GClass30 gclass30_1)
	{
	}

	private void method_0(StringBuilder stringBuilder_0, int int_5)
	{
		Class26.smethod_0(7345872, this, stringBuilder_0, int_5);
	}
}
