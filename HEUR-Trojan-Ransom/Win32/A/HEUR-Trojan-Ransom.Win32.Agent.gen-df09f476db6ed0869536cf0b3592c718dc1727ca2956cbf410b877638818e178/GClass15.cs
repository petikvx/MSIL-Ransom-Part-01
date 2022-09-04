using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;

public class GClass15
{
	[CompilerGenerated]
	private GEnum6 genum6_0;

	[CompilerGenerated]
	private GEnum5 genum5_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private GEnum7 genum7_0;

	[SpecialName]
	[CompilerGenerated]
	public GEnum6 method_0()
	{
		return genum6_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(GEnum6 genum6_1)
	{
		genum6_0 = genum6_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public GEnum5 method_2()
	{
		return genum5_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_3(GEnum5 genum5_1)
	{
		genum5_0 = genum5_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public string method_4()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_5(string string_1)
	{
		string_0 = string_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public int method_6()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_7(int int_1)
	{
		int_0 = int_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public GEnum7 method_8()
	{
		return genum7_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_9(GEnum7 genum7_1)
	{
		genum7_0 = genum7_1;
	}

	public GClass15(GEnum5 genum5_1, GEnum6 genum6_1, string string_1, int int_1)
	{
		Class51.smethod_0();
		base._002Ector();
		method_1(genum6_1);
		method_3(genum5_1);
		method_5(string_1);
		method_7(int_1);
	}

	[SpecialName]
	public IPAddress method_10()
	{
		if (method_0() == (GEnum6)1)
		{
			try
			{
				return IPAddress.Parse(method_4());
			}
			catch
			{
				method_9((GEnum7)7);
				return null;
			}
		}
		if (method_0() == (GEnum6)3)
		{
			try
			{
				IPAddress[] hostAddresses = Dns.GetHostAddresses(method_4());
				int num = 0;
				IPAddress iPAddress;
				while (true)
				{
					if (num >= hostAddresses.Length)
					{
						return null;
					}
					iPAddress = hostAddresses[num];
					if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
					{
						break;
					}
					num++;
				}
				return iPAddress;
			}
			catch
			{
				method_9((GEnum7)4);
				return null;
			}
		}
		return null;
	}

	public byte[] method_11()
	{
		int value = IPAddress.NetworkToHostOrder(method_6());
		byte[] array;
		if (method_0() == (GEnum6)1)
		{
			array = new byte[10];
			string[] array2 = method_10().ToString().Split(new char[1] { '.' });
			for (int i = 4; i < array2.Length + 4; i++)
			{
				array[i] = Convert.ToByte(Convert.ToInt32(array2[i - 4]));
			}
			Buffer.BlockCopy(BitConverter.GetBytes(value), 0, array, 8, 2);
		}
		else
		{
			if (method_0() != (GEnum6)3)
			{
				return null;
			}
			array = new byte[method_4().Length + 7];
			array[4] = Convert.ToByte(method_4().Length);
			Buffer.BlockCopy(Encoding.ASCII.GetBytes(method_4()), 0, array, 5, method_4().Length);
			Buffer.BlockCopy(BitConverter.GetBytes(value), 0, array, array.Length - 2, 2);
		}
		array[0] = 5;
		array[1] = (byte)method_8();
		array[2] = 0;
		array[3] = (byte)method_0();
		return array;
	}
}
