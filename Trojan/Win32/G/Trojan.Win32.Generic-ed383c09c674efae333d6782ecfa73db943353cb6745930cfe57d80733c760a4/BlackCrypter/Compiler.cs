using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.CSharp;

namespace BlackCrypter;

internal class Compiler
{
	public Compiler(string sourceCode, string savePath, string iconPath)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		string[] array = new string[3] { "System.dll", "System.Windows.Forms.dll", "System.Drawing.dll" };
		Dictionary<string, string> obj = new Dictionary<string, string> { { "CompilerVersion", "v4.0" } };
		string text = "/target:winexe /platform:anycpu /optimize+";
		if (iconPath != "")
		{
			text = text + " /win32icon:\"" + iconPath + "\"";
		}
		CSharpCodeProvider val = new CSharpCodeProvider((IDictionary<string, string>)obj);
		try
		{
			CompilerParameters val2 = new CompilerParameters(array);
			val2.set_GenerateExecutable(true);
			val2.set_GenerateInMemory(false);
			val2.set_OutputAssembly(savePath);
			val2.set_CompilerOptions(text);
			val2.set_TreatWarningsAsErrors(false);
			val2.set_IncludeDebugInformation(false);
			CompilerParameters val3 = val2;
			CompilerResults val4 = ((CodeDomProvider)val).CompileAssemblyFromSource(val3, new string[1] { sourceCode });
			if (((CollectionBase)(object)val4.get_Errors()).Count > 0)
			{
				foreach (CompilerError item in (CollectionBase)(object)val4.get_Errors())
				{
					CompilerError val5 = item;
					MessageBox.Show($"{val5.get_ErrorText()}\nLine: {val5.get_Line()} - Column: {val5.get_Column()}\nFile: {val5.get_FileName()}");
				}
				return;
			}
			MessageBox.Show("Done!");
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
