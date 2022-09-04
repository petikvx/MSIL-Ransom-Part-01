using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConS;

public class iCompiler
{
	public static void GenerateExecutable(string Output, string Source, string Icon)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object objectValue = default(object);
		ICodeCompiler val = default(ICodeCompiler);
		CompilerParameters val2 = default(CompilerParameters);
		Dictionary<string, string> dictionary = default(Dictionary<string, string>);
		string text = default(string);
		CompilerResults val4 = default(CompilerResults);
		IEnumerator enumerator = default(IEnumerator);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				CompilerParameters val3;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 596:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0016;
						case 4:
							goto IL_001f;
						case 5:
							goto IL_0029;
						case 6:
							goto IL_0033;
						case 7:
							goto IL_0041;
						case 8:
							goto IL_0055;
						case 9:
							goto IL_0069;
						case 10:
							goto IL_007e;
						case 11:
							goto IL_0089;
						case 12:
							goto IL_009e;
						case 13:
							goto IL_00ad;
						case 14:
							goto IL_00c1;
						case 15:
							goto IL_00d4;
						case 16:
							goto IL_00df;
						case 17:
						case 18:
							goto IL_00ff;
						case 19:
							goto IL_010c;
						case 20:
							goto IL_011e;
						case 21:
							goto IL_013f;
						case 22:
							goto IL_0176;
						case 24:
							goto IL_019a;
						case 23:
						case 25:
						case 26:
							goto IL_01ac;
						case 27:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 28:
						case 29:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_013f:
					num = 21;
					MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject((object)"Error: ", NewLateBinding.LateGet(objectValue, (Type)null, "ErrorText", new object[0], (string[])null, (Type[])null, (bool[])null))), "", (MessageBoxButtons)0, (MessageBoxIcon)16);
					goto IL_0176;
					IL_0008:
					num = 2;
					val = new VBCodeProvider().CreateCompiler();
					goto IL_0016;
					IL_0016:
					num = 3;
					val2 = new CompilerParameters();
					goto IL_001f;
					IL_001f:
					num = 4;
					val2.set_GenerateExecutable(true);
					goto IL_0029;
					IL_0029:
					num = 5;
					val2.set_OutputAssembly(Output);
					goto IL_0033;
					IL_0033:
					num = 6;
					val2.set_CompilerOptions("/target:winexe");
					goto IL_0041;
					IL_0041:
					num = 7;
					val2.get_ReferencedAssemblies().Add("System.dll");
					goto IL_0055;
					IL_0055:
					num = 8;
					val2.get_ReferencedAssemblies().Add("System.Data.dll");
					goto IL_0069;
					IL_0069:
					num = 9;
					val2.get_ReferencedAssemblies().Add("System.Windows.Forms.dll");
					goto IL_007e;
					IL_007e:
					num = 10;
					dictionary = new Dictionary<string, string>();
					goto IL_0089;
					IL_0089:
					num = 11;
					dictionary.Add("CompilerVersion", "v2.0");
					goto IL_009e;
					IL_009e:
					num = 12;
					val2.set_CompilerOptions("/filealign:0x00000200 /optimize+ /platform:X86 /debug- /target:winexe");
					goto IL_00ad;
					IL_00ad:
					num = 13;
					text = Path.GetTempPath() + "\\iCompiler.ico";
					goto IL_00c1;
					IL_00c1:
					num = 14;
					if (Operators.CompareString(Icon, "", false) != 0)
					{
						goto IL_00d4;
					}
					goto IL_00ff;
					IL_00d4:
					num = 15;
					File.Copy(Icon, text);
					goto IL_00df;
					IL_00df:
					num = 16;
					val3 = val2;
					val3.set_CompilerOptions(val3.get_CompilerOptions() + " /win32icon:" + text);
					goto IL_00ff;
					IL_00ff:
					num = 18;
					val4 = val.CompileAssemblyFromSource(val2, Source);
					goto IL_010c;
					IL_010c:
					num = 19;
					if (((CollectionBase)(object)val4.get_Errors()).Count > 0)
					{
						goto IL_011e;
					}
					goto IL_019a;
					IL_011e:
					num = 20;
					enumerator = ((CollectionBase)(object)val4.get_Errors()).GetEnumerator();
					goto IL_017a;
					IL_017a:
					if (enumerator.MoveNext())
					{
						objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						goto IL_013f;
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto IL_01ac;
					IL_0176:
					num = 22;
					goto IL_017a;
					IL_01ac:
					num = 26;
					if (Operators.CompareString(Icon, "", false) == 0)
					{
						goto end_IL_0000_3;
					}
					break;
					IL_019a:
					num = 24;
					if (((CollectionBase)(object)val4.get_Errors()).Count != 0)
					{
					}
					goto IL_01ac;
					end_IL_0000_2:
					break;
				}
				num = 27;
				File.Delete(text);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 596;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
