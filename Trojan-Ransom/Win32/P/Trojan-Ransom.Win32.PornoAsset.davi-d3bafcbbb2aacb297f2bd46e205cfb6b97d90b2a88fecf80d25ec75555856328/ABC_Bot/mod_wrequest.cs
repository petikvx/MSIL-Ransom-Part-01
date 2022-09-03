using System;
using System.IO;
using System.Net;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ABC_Bot;

[StandardModule]
internal sealed class mod_wrequest
{
	public static object request(string url, string post)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		HttpWebResponse httpWebResponse = default(HttpWebResponse);
		Stream stream = default(Stream);
		HttpWebRequest httpWebRequest = default(HttpWebRequest);
		byte[] bytes = default(byte[]);
		StreamReader streamReader = default(StreamReader);
		string text = default(string);
		object obj = default(object);
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
				case 324:
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
							goto IL_0012;
						case 4:
							goto IL_0022;
						case 5:
							goto IL_0031;
						case 6:
							goto IL_0040;
						case 7:
							goto IL_004f;
						case 8:
							goto IL_005d;
						case 9:
							goto IL_0068;
						case 10:
							goto IL_0077;
						case 11:
							goto IL_0081;
						case 12:
							goto IL_0093;
						case 13:
							goto IL_009f;
						case 14:
							goto IL_00aa;
						case 15:
							goto IL_00b6;
						case 16:
							goto IL_00c0;
						case 17:
							goto IL_00ca;
						case 18:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 19:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00ca:
					num = 17;
					httpWebResponse.Close();
					break;
					IL_00c0:
					num = 16;
					stream.Close();
					goto IL_00ca;
					IL_0009:
					num = 2;
					ServicePointManager.Expect100Continue = false;
					goto IL_0012;
					IL_0012:
					num = 3;
					httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
					goto IL_0022;
					IL_0022:
					num = 4;
					httpWebRequest.Method = "POST";
					goto IL_0031;
					IL_0031:
					num = 5;
					httpWebRequest.ContentType = "application/x-www-form-urlencoded";
					goto IL_0040;
					IL_0040:
					num = 6;
					bytes = Encoding.UTF8.GetBytes(post);
					goto IL_004f;
					IL_004f:
					num = 7;
					httpWebRequest.ContentLength = bytes.Length;
					goto IL_005d;
					IL_005d:
					num = 8;
					stream = httpWebRequest.GetRequestStream();
					goto IL_0068;
					IL_0068:
					num = 9;
					stream.Write(bytes, 0, bytes.Length);
					goto IL_0077;
					IL_0077:
					num = 10;
					stream.Close();
					goto IL_0081;
					IL_0081:
					num = 11;
					httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
					goto IL_0093;
					IL_0093:
					num = 12;
					stream = httpWebResponse.GetResponseStream();
					goto IL_009f;
					IL_009f:
					num = 13;
					streamReader = new StreamReader(stream);
					goto IL_00aa;
					IL_00aa:
					num = 14;
					text = streamReader.ReadToEnd();
					goto IL_00b6;
					IL_00b6:
					num = 15;
					streamReader.Close();
					goto IL_00c0;
					end_IL_0000_2:
					break;
				}
				num = 18;
				obj = text;
				break;
				end_IL_0000:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0000_dispatch = 324;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		object result = obj;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
