#define DEBUG
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace wmplayers;

public class cVBEvalProvider
{
	private CompilerErrorCollection m_oCompilerErrors;

	public CompilerErrorCollection CompilerErrors
	{
		get
		{
			return m_oCompilerErrors;
		}
		set
		{
			m_oCompilerErrors = value;
		}
	}

	public cVBEvalProvider()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		m_oCompilerErrors = new CompilerErrorCollection();
	}

	public object Eval(string vbCode)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		VBCodeProvider val = new VBCodeProvider();
		CompilerParameters val2 = new CompilerParameters();
		object obj = null;
		object result = null;
		try
		{
			val2.get_ReferencedAssemblies().Add("system.dll");
			val2.get_ReferencedAssemblies().Add("system.xml.dll");
			val2.get_ReferencedAssemblies().Add("system.data.dll");
			val2.get_ReferencedAssemblies().Add("mscorlib.dll");
			val2.set_CompilerOptions("/t:library");
			val2.set_GenerateInMemory(true);
			StringBuilder stringBuilder = new StringBuilder("");
			stringBuilder.Append("Imports System\r\n");
			stringBuilder.Append("Imports System.Xml\r\n");
			stringBuilder.Append("Imports System.Data\r\n");
			stringBuilder.Append("Imports System.IO\r\n");
			stringBuilder.Append("Imports System.Net\r\n");
			stringBuilder.Append("Namespace dValuate\r\n");
			stringBuilder.Append("Class EvalRunTime \r\n");
			stringBuilder.Append("Public Function EvaluateIt() As Object \r\n");
			stringBuilder.Append(vbCode + "\r\n");
			stringBuilder.Append("End Function \r\n");
			stringBuilder.Append("End Class \r\n");
			stringBuilder.Append("End Namespace\r\n");
			Debug.WriteLine(stringBuilder.ToString());
			try
			{
				CompilerResults val3 = ((CodeDomProvider)val).CompileAssemblyFromSource(val2, new string[1] { stringBuilder.ToString() });
				if (((CollectionBase)(object)val3.get_Errors()).Count != 0)
				{
					CompilerErrors = val3.get_Errors();
					throw new Exception("Compile Errors");
				}
				Assembly compiledAssembly = val3.get_CompiledAssembly();
				obj = RuntimeHelpers.GetObjectValue(compiledAssembly.CreateInstance("dValuate.EvalRunTime"));
				Type type = obj.GetType();
				MethodInfo method = type.GetMethod("EvaluateIt");
				result = RuntimeHelpers.GetObjectValue(method.Invoke(RuntimeHelpers.GetObjectValue(obj), null));
				return result;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Debug.WriteLine(ex2.Message);
				Debugger.Break();
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			Debug.WriteLine(ex4.Message);
			Debugger.Break();
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
