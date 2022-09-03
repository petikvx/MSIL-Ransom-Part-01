using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public sealed class GClass1
{
	public string[] string_0;

	public static int int_0 = 2;

	public static int int_1 = 0;

	public static GClass0 gclass0_0;

	public static bool bool_0 = false;

	public static int int_2 = 0;

	public static string string_1 = "@hotmail.com";

	public string[] string_2;

	private int int_3;

	private string string_3;

	private int int_4;

	private string string_4;

	private string[] string_5;

	public static List<string> list_0 = new List<string>();

	public GClass1()
	{
		string_2 = new string[5];
		string_3 = "signup.live.com";
		int_4 = 443;
		string string_ = "R0VUIC9jaGVja2F2YWlsLmFzcHg/Y2hrYXZhaWw9I2VtJnRrPTEzMTAwODY1ODE4MDYmbGljPTEgSFRUUC8xLjENCkhvc3Q6IHNpZ251cC5saXZlLmNvbQ0KVXNlci1BZ2VudDogTW96aWxsYS81LjAgKFdpbmRvd3M7IFU7IFdpbmRvd3MgTlQgNi4wOyBlbi1VUzsgcnY6MS45LjIuMTgpIEdlY2tvLzIwMTEwNjE0IEZpcmVmb3gvMy42LjE4DQpBY2NlcHQ6IGltYWdlL3BuZyxpbWFnZS8qO3E9MC44LCovKjtxPTAuNQ0KQWNjZXB0LUxhbmd1YWdlOiBlbi11cyxlbjtxPTAuNQ0KQWNjZXB0LUVuY29kaW5nOiBnemlwLGRlZmxhdGUNCkFjY2VwdC1DaGFyc2V0OiBJU08tODg1OS0xLHV0Zi04O3E9MC43LCo7cT0wLjcNCktlZXAtQWxpdmU6IDExNQ0KQ29ubmVjdGlvbjoga2VlcC1hbGl2ZQ0KUmVmZXJlcjogaHR0cHM6Ly9zaWdudXAubGl2ZS5jb20vP2xpYz0xDQpDb29raWU6IEFNU1RBVEU9QkJBRz0yNTYmU0NMU1Q9JlJFTkFNRVJVTEVOUz0mTmV3TU49JlVzZXJOYW1lUXM9JkxJTktJREVOQUJMRUQ9LTEmTElOS0lEPSZDSUQ9JlNDSz0mU0M9JlNJRD0wJlNFU1NJT05JRD0zNDk3MTE2MS1hY2E5LTQyY2YtYjNkYS1hMmFjNTk0MDVhOTEmU05DSUQ9JlBMVD1mYWxzZSZQSEM9MSZJQ1RSWT0mRUM9OyB4aWQ9MTFjZGFjYzctMjQ0NS00MWZkLTkxYjUtNjU1ODUyYTQ1MzViJiZCTFV4eHh4eHhDMTAyJjIzMjsgeGlkc2VxPTE7IFdMQ2FuYXJ5PWlDSlhaUVFVdFlKdmRNQ0pXTVA4SS9lVW9Ja0NIWkxjUFVGd1JHZTFZdms9OyB3bHY9QXxfLWQ6cypoZkdjQmcuMisxKzArMzsgaXBsPWM9dGlQaFVueEJjMmxoZkV0MWQyRnBkSHhyZDN3d2ZEQjhmSHcmdj0yOyBFPVA6bFRTUERqTUx6b2c9Om1EbXJnWjNjMy85UmdERjhHSnc4VmtPL3RBUkdwWXRodFNVOFlHRndndHM9OkY7IHdsYTQyPTsgTEQ9N2NmNGUxOWItOGZkNy00OGEwLWFhZTEtNWI1YmZjOWM1NGM5XzAwMTViNmNkYjExXzY0MzRfMTMxMDA5NDIxNTM2Nz1VMTIxMDE1OyBISVBTZXNzaW9uPTRoTlVHWTI0bENsTGFZd0lzUFlTZTBJcmtuZHFmdzVyaEdya0FicnRrazZscENZQnJaclRjbWxISEtRRVh6UG5CV3V2aEE3RlVQNmVsdG9ORVRLNnB5OUVxYWtXZndSVk12NFFxWmtjSnRWRk0kDQoNCg==";
		string_4 = method_4(ref string_);
		string_5 = new string[5] { "Error_1058", "Error_1062", "Error_1037", "Error_1081", "Error_1220" };
	}

	public void method_0(int int_5)
	{
		int_0 = int_5;
		string text = "abcdefghijklmnopqrstuvwxyz1234567890_-.";
		string text2 = "1234567890_-.";
		List<string> list = new List<string>();
		string text3 = text.Replace("_", string.Empty).Replace("-", string.Empty).Replace(".", string.Empty);
		int i = 0;
		checked
		{
			for (int length = text3.Length; i < length; i++)
			{
				string item = Conversions.ToString(text3[i]);
				list.Add(item);
			}
			if (int_5 > 0)
			{
				string text4 = text;
				int j = 0;
				for (int length2 = text4.Length; j < length2; j++)
				{
					string text5 = Conversions.ToString(text4[j]);
					if (text2.Contains(text5))
					{
						continue;
					}
					string text6 = text;
					int k = 0;
					for (int length3 = text6.Length; k < length3; k++)
					{
						string text7 = Conversions.ToString(text6[k]);
						if (Operators.CompareString(text7, ".", false) != 0)
						{
							string text8 = text5 + text7;
							if (!text8.Contains(".."))
							{
								list.Add(text8);
							}
						}
					}
				}
			}
			if (int_5 > 1)
			{
				string text9 = text;
				int l = 0;
				for (int length4 = text9.Length; l < length4; l++)
				{
					string text10 = Conversions.ToString(text9[l]);
					if (text2.Contains(text10))
					{
						continue;
					}
					string text11 = text;
					int m = 0;
					for (int length5 = text11.Length; m < length5; m++)
					{
						string text12 = Conversions.ToString(text11[m]);
						string text13 = text;
						int n = 0;
						for (int length6 = text13.Length; n < length6; n++)
						{
							string text14 = Conversions.ToString(text13[n]);
							if (Operators.CompareString(text14, ".", false) != 0)
							{
								string text15 = text10 + text12 + text14;
								if (!text15.Contains(".."))
								{
									list.Add(text15);
								}
							}
						}
					}
				}
			}
			string_0 = list.ToArray();
			list.Clear();
		}
	}

	public void method_1()
	{
		while (!bool_0)
		{
			int_1 = checked((int)Math.Round((double)(int_2 - int_3) / 5.0));
			int_3 = int_2;
			Thread.Sleep(5000);
		}
	}

	public void method_2(int int_5)
	{
		method_0(int_5);
		Thread thread = new Thread(method_1, 100);
		thread.Start();
		checked
		{
			int num = string_2.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string_2[i] = string.Empty;
				Thread thread2 = new Thread(delegate(object object_0)
				{
					method_5(Conversions.ToInteger(object_0));
				}, 100);
				thread2.Start(i);
			}
			while (true)
			{
				if (list_0.Count > 10)
				{
					list_0.Clear();
				}
				if (bool_0)
				{
					break;
				}
				int num2 = string_2.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					Thread.Sleep(1);
					if (string_2[j].Length == 0)
					{
						string_2[j] = string_0[int_2] + string_1;
						int_2++;
						if (int_2 > string_0.Length - 1)
						{
							int_2 = 0;
						}
					}
				}
			}
		}
	}

	private bool method_3(ref string string_6)
	{
		string[] array = Strings.Split(Strings.Replace(string_4, "#em", string_6, 1, -1, (CompareMethod)0), "\r\n", -1, (CompareMethod)0);
		checked
		{
			while (true)
			{
				TcpClient tcpClient = new TcpClient();
				try
				{
					tcpClient.Connect(string_3, int_4);
					SslStream sslStream = new SslStream(tcpClient.GetStream(), leaveInnerStreamOpen: false, smethod_0, null);
					sslStream.AuthenticateAsClient(string_3);
					ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
					byte[] array2 = new byte[801];
					byte[] array3 = new byte[1];
					int num = array.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						array3 = new byte[aSCIIEncoding.GetBytes(array[i] + "\r\n").Length + 1];
						array3 = aSCIIEncoding.GetBytes(array[i] + "\r\n");
						sslStream.Write(array3, 0, array3.Length);
						sslStream.Flush();
					}
					tcpClient.ReceiveTimeout = 5000;
					sslStream.Read(array2, 0, array2.Length);
					string @string = aSCIIEncoding.GetString(array2);
					if (@string.Contains(string_5[0]))
					{
						return false;
					}
					if (@string.Contains(string_5[1]))
					{
						return false;
					}
					if (@string.Contains(string_5[2]))
					{
						return false;
					}
					if (@string.Contains(string_5[3]))
					{
						return true;
					}
					if (@string.Contains(string_5[4]))
					{
						return false;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				if (Operators.CompareString(string_1, "@", false) != 0)
				{
					if (bool_0)
					{
						break;
					}
					Thread.Sleep(100);
					continue;
				}
				return false;
			}
			return false;
		}
	}

	private static bool smethod_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
	{
		if (sslPolicyErrors_0 == SslPolicyErrors.None)
		{
			return true;
		}
		return false;
	}

	public string method_4(ref string string_6)
	{
		byte[] bytes = Convert.FromBase64String(string_6);
		return Encoding.UTF8.GetString(bytes);
	}

	public void method_5(int int_5)
	{
		if (Operators.CompareString(string_2[int_5], "!", false) == 0)
		{
			string_2[int_5] = string.Empty;
		}
		while (!bool_0)
		{
			if (Operators.CompareString(string_1, "@", false) == 0)
			{
				Thread.Sleep(100);
				continue;
			}
			try
			{
				if (string_2[int_5].Length > 0)
				{
					string string_ = string_2[int_5];
					string_2[int_5] = string.Empty;
					if (method_3(ref string_))
					{
						list_0.Add(string_);
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(10);
		}
		string_2[int_5] = "!";
	}
}
