using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using YntkCmRvu3wTEtF9OJ;
using rgkhkgXAA8K86lvqCu;

namespace tRXv04reXswpeecTQDY;

[StandardModule]
internal sealed class M56fU2rr09iuGB7BpKn
{
	public static void MLbHI30aEq()
	{
		VswWInf8Zitix7YaLbi();
		if (TWowCvfJuVwvKCNbwo7())
		{
			int try0010_dispatch = -1;
			int num = default(int);
			int num2 = default(int);
			string executablePath = default(string);
			int num3 = default(int);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					int num4;
					switch (try0010_dispatch)
					{
					default:
						num = 1;
						goto IL_0078;
					case 145:
						{
							num2 = num;
							goto IL_0021;
						}
						IL_0078:
						num = 2;
						executablePath = Application.get_ExecutablePath();
						goto IL_006c;
						IL_006c:
						num = 3;
						if (EkWM3SuPulRFvZGJal.PnYZiZTvL4)
						{
							goto IL_0062;
						}
						break;
						IL_0062:
						NZAfi7fKjl9RWRF4E2X();
						num3 = -2;
						goto IL_0015;
						IL_0015:
						num = 5;
						_ = 0;
						if (TWowCvfJuVwvKCNbwo7())
						{
							jZ4El6fAQDDMpgp2DIP(executablePath);
							break;
						}
						goto IL_0021;
						IL_0021:
						if (num3 > -2)
						{
							switch (num3)
							{
							default:
								goto end_IL_0010;
							case 1:
								break;
							case 0:
								goto end_IL_0010;
							}
						}
						num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 5:
							goto IL_0015;
						default:
							goto end_IL_0010;
						case 4:
							goto IL_0062;
						case 3:
							goto IL_006c;
						case 2:
							goto IL_0078;
						case 0:
							goto end_IL_0010;
						case 6:
						case 7:
							goto end_IL_0010_2;
						}
						goto default;
					}
					break;
					end_IL_0010:;
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0010_dispatch = 145;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0010_2:
				break;
			}
			if (num2 == 0)
			{
				return;
			}
		}
		ProjectData.ClearProjectError();
	}

	internal static void NZAfi7fKjl9RWRF4E2X()
	{
		ProjectData.ClearProjectError();
	}

	internal static bool jZ4El6fAQDDMpgp2DIP(object object_0)
	{
		return eK62xVsZcFHMst7JEQ.ODBZ82SU8a((string)object_0);
	}

	internal static bool TWowCvfJuVwvKCNbwo7()
	{
		return true;
	}

	internal static bool VswWInf8Zitix7YaLbi()
	{
		return false;
	}
}
