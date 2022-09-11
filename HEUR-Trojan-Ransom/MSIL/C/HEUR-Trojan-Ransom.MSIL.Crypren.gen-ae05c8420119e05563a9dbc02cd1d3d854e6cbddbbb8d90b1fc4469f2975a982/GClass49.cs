using System.IO;
using Boo.Lang.Compiler;
using Boo.Lang.Compiler.Ast;
using antlr;

public class GClass49 : GClass48
{
	protected GDelegate7 gdelegate7_0;

	public GClass49(GInterface18 ginterface18_0)
	{
	}

	public static Expression smethod_130(int int_142, string string_2, string string_3, GDelegate7 gdelegate7_1)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		return (Expression)Class26.smethod_0(7342446, null, int_142, string_2, string_3, gdelegate7_1);
	}

	public static Expression smethod_131(string string_2, string string_3)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		return (Expression)Class26.smethod_0(7342338, null, string_2, string_3);
	}

	public static CompileUnit smethod_132(string string_2)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		return (CompileUnit)Class26.smethod_0(7342355, null, string_2);
	}

	public static CompileUnit smethod_133(int int_142, string string_2)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		return (CompileUnit)Class26.smethod_0(7342371, null, int_142, string_2);
	}

	public static CompileUnit smethod_134(string string_2, string string_3)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		return (CompileUnit)Class26.smethod_0(7342384, null, string_2, string_3);
	}

	public static CompileUnit smethod_135(string string_2, TextReader textReader_0)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		return (CompileUnit)Class26.smethod_0(7342273, null, string_2, textReader_0);
	}

	public static CompileUnit smethod_136(int int_142, string string_2, TextReader textReader_0)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		return (CompileUnit)Class26.smethod_0(7342294, null, int_142, string_2, textReader_0);
	}

	public static Module smethod_137(int int_142, CompileUnit compileUnit_0, string string_2, TextReader textReader_0, GDelegate7 gdelegate7_1)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		return (Module)Class26.smethod_0(7342308, null, int_142, compileUnit_0, string_2, textReader_0, gdelegate7_1);
	}

	public static GClass49 smethod_138(int int_142, string string_2, TextReader textReader_0, GDelegate7 gdelegate7_1)
	{
		return (GClass49)Class26.smethod_0(7342329, null, int_142, string_2, textReader_0, gdelegate7_1);
	}

	public static GInterface18 smethod_139(int int_142, string string_2, TextReader textReader_0)
	{
		return (GInterface18)Class26.smethod_0(7342226, null, int_142, string_2, textReader_0);
	}

	public override void vmethod_33(RecognitionException recognitionException_0)
	{
		Class26.smethod_0(7342241, this, recognitionException_0);
	}

	protected override void vmethod_48(Property property_0)
	{
		Class26.smethod_0(7342263, this, property_0);
	}

	protected override void vmethod_49(LexicalInfo lexicalInfo_0)
	{
		Class26.smethod_0(7342148, this, lexicalInfo_0);
	}

	private void method_160(CompilerWarning compilerWarning_0)
	{
		Class26.smethod_0(7342165, this, compilerWarning_0);
	}

	private bool method_161()
	{
		return (bool)Class26.smethod_0(7342186, this, null);
	}

	private string method_162(Property property_0, string string_2, string string_3)
	{
		return (string)Class26.smethod_0(7342197, this, property_0, string_2, string_3);
	}
}
