using System;
using System.IO;
using Boo.Lang.Compiler;
using Boo.Lang.Compiler.Ast;
using antlr;

public class GClass76 : IDisposable, ICompilerStep, ICompilerComponent
{
	private CompilerContext compilerContext_0;

	protected CompilerContext CompilerContext_0 => (CompilerContext)Class26.smethod_0(7354891, this, null);

	protected int Int32_0 => (int)Class26.smethod_0(7354939, this, null);

	public void Initialize(CompilerContext context)
	{
		Class26.smethod_0(7354906, this, context);
	}

	public void Dispose()
	{
		Class26.smethod_0(7354923, this, null);
	}

	public void Run()
	{
		Class26.smethod_0(7349706, this, null);
	}

	protected virtual void ParseModule(string inputName, TextReader reader, GDelegate7 errorHandler)
	{
		Class26.smethod_0(7349722, this, inputName, reader, errorHandler);
	}

	private void method_0(RecognitionException recognitionException_0)
	{
		Class26.smethod_0(7349742, this, recognitionException_0);
	}

	private void method_1(LexicalInfo lexicalInfo_0, RecognitionException recognitionException_0)
	{
		Class26.smethod_0(7349756, this, lexicalInfo_0, recognitionException_0);
	}

	private void method_2(LexicalInfo lexicalInfo_0, NoViableAltException noViableAltException_0)
	{
		Class26.smethod_0(7349651, this, lexicalInfo_0, noViableAltException_0);
	}
}
