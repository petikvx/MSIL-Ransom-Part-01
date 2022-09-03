using System.Net;
using System.Net.Sockets;
using System.Text;

internal class Class17
{
	private TcpClient tcpClient_0;

	private TcpClient tcpClient_1;

	private byte byte_0 = 5;

	private byte byte_1 = 2;

	private byte byte_2;

	private byte byte_3 = 1;

	private byte byte_4 = 3;

	public Class17(TcpClient tcpClient_2)
	{
		tcpClient_0 = tcpClient_2;
	}

	public void method_0()
	{
		NetworkStream object_ = Delegate228.smethod_0(tcpClient_0);
		byte[] array = new byte[2];
		Delegate250.smethod_0(object_, array, 0, 2);
		byte[] array2 = new byte[array[1]];
		Delegate250.smethod_0(object_, array2, 0, array2.Length);
		byte[] array3 = new byte[2] { byte_0, byte_1 };
		Delegate251.smethod_0(object_, array3, 0, 2);
		ASCIIEncoding object_2 = Delegate252.smethod_0();
		byte[] array4 = new byte[64];
		Delegate250.smethod_0(object_, array4, 0, 64);
		Delegate185.smethod_0(array4[0]);
		int num = Delegate185.smethod_0(array4[1]);
		int num2 = Delegate185.smethod_0(array4[num + 2]);
		byte[] array5 = new byte[num];
		for (int i = 0; i <= num - 1; i++)
		{
			array5[i] = array4[i + 2];
		}
		byte[] array6 = new byte[num2];
		for (int j = 0; j <= num2 - 1; j++)
		{
			array6[j] = array4[j + num + 3];
		}
		string object_3 = Delegate105.smethod_0(object_2, array5);
		string object_4 = Delegate105.smethod_0(object_2, array6);
		if (Delegate253.smethod_0(object_3, Class2.string_6) && Delegate253.smethod_0(object_4, Class2.string_7))
		{
			byte[] array7 = new byte[2] { byte_0, byte_2 };
			Delegate251.smethod_0(object_, array7, 0, 2);
		}
		else
		{
			byte[] array8 = new byte[2] { byte_0, 2 };
			Delegate251.smethod_0(object_, array8, 0, 2);
		}
		byte[] array9 = new byte[4];
		Delegate250.smethod_0(object_, array9, 0, 4);
		string string_ = "";
		if (array9[3] == byte_3)
		{
			byte[] array10 = new byte[4];
			Delegate250.smethod_0(object_, array10, 0, 4);
			IPAddress object_5 = Delegate254.smethod_0(array10);
			string_ = Delegate69.smethod_0(object_5);
		}
		else if (array9[3] == byte_4)
		{
			byte[] array11 = new byte[1];
			Delegate250.smethod_0(object_, array11, 0, 1);
			byte[] array12 = new byte[array11[0]];
			Delegate250.smethod_0(object_, array12, 0, array11[0]);
			string_ = Delegate105.smethod_0(Delegate100.smethod_1(), array12);
		}
		if (!Delegate63.smethod_0(string_, ""))
		{
			return;
		}
		byte[] array13 = new byte[2];
		Delegate250.smethod_0(object_, array13, 0, 2);
		int int_ = Delegate255.smethod_0(new byte[2]
		{
			array13[1],
			array13[0]
		}, 0);
		tcpClient_1 = Delegate227.smethod_0(string_, int_);
		if (!Delegate256.smethod_0(tcpClient_1))
		{
			return;
		}
		byte[] array14 = new byte[10] { byte_0, byte_2, 0, 1, 0, 0, 0, 0, 0, 0 };
		string string_2 = Delegate77.smethod_0(Delegate69.smethod_0(Delegate258.smethod_0(Delegate257.smethod_0(tcpClient_1))), new char[1] { ':' })[0];
		IPAddress object_6 = Delegate119.smethod_0(string_2);
		array14[4] = Delegate259.smethod_0(object_6)[0];
		array14[5] = Delegate259.smethod_0(object_6)[1];
		array14[6] = Delegate259.smethod_0(object_6)[2];
		array14[7] = Delegate259.smethod_0(object_6)[3];
		int num3 = Delegate78.smethod_1(Delegate77.smethod_0(Delegate69.smethod_0(Delegate258.smethod_0(Delegate257.smethod_0(tcpClient_1))), new char[1] { ':' })[1]);
		array14[8] = Delegate260.smethod_0((ushort)num3)[0];
		array14[9] = Delegate260.smethod_0((ushort)num3)[1];
		Delegate251.smethod_0(object_, array14, 0, 10);
		try
		{
			NetworkStream object_7 = Delegate228.smethod_0(tcpClient_1);
			bool flag = false;
			while (Delegate256.smethod_0(tcpClient_1) && Delegate256.smethod_0(tcpClient_0) && !flag && Class19.bool_1)
			{
				Delegate82.smethod_2(100);
				try
				{
					if (Delegate261.smethod_0(object_))
					{
						byte[] array_ = new byte[10000];
						int num4 = Delegate250.smethod_0(object_, array_, 0, 10000);
						byte[] array15 = new byte[num4];
						Delegate262.smethod_0(array_, array15, num4);
						Delegate251.smethod_0(object_7, array15, 0, array15.Length);
					}
					if (Delegate261.smethod_0(object_7))
					{
						byte[] array_2 = new byte[10000];
						int num5 = Delegate250.smethod_0(object_7, array_2, 0, 10000);
						byte[] array16 = new byte[num5];
						Delegate262.smethod_0(array_2, array16, num5);
						Delegate251.smethod_0(object_, array16, 0, array16.Length);
					}
				}
				catch
				{
					flag = true;
				}
			}
		}
		catch
		{
		}
		if (Delegate256.smethod_0(tcpClient_0))
		{
			Delegate237.smethod_0(tcpClient_0);
		}
		if (Delegate256.smethod_0(tcpClient_1))
		{
			Delegate237.smethod_0(tcpClient_1);
		}
	}
}
