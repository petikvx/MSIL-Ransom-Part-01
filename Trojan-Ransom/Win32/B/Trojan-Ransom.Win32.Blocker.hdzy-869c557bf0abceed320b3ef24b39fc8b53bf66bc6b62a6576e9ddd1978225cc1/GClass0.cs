using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public sealed class GClass0
{
	private string string_0 = Class15.string_6;

	private string string_1 = Class15.string_7;

	private TcpClient tcpClient_0;

	private TcpClient tcpClient_1;

	private byte byte_0 = 5;

	private byte byte_1 = 2;

	private byte byte_2;

	private byte byte_3 = 1;

	private byte byte_4 = 3;

	public GClass0(TcpClient tcpClient_2)
	{
		tcpClient_0 = tcpClient_2;
	}

	public void method_0()
	{
		Console.WriteLine("NEW CONNECTION: " + tcpClient_0.Client.RemoteEndPoint!.ToString());
		NetworkStream stream = tcpClient_0.GetStream();
		byte[] array = new byte[2];
		stream.Read(array, 0, 2);
		Console.WriteLine($"authFields: version {array[0]} methods {array[1]}");
		byte[] array2 = new byte[array[1]];
		stream.Read(array2, 0, array2.Length);
		Console.WriteLine("socks client supports " + array2.Length + " methods");
		byte[] buffer = new byte[2] { byte_0, byte_1 };
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
		if (@string.Equals(string_0) && string2.Equals(string_1))
		{
			byte[] buffer2 = new byte[2] { byte_0, byte_2 };
			stream.Write(buffer2, 0, 2);
		}
		else
		{
			byte[] buffer3 = new byte[2] { byte_0, 2 };
			stream.Write(buffer3, 0, 2);
		}
		byte[] array6 = new byte[4];
		stream.Read(array6, 0, 4);
		Console.WriteLine("socksclient requests address type " + array6[3]);
		string text = string.Empty;
		if (array6[3] == byte_3)
		{
			byte[] array7 = new byte[4];
			stream.Read(array7, 0, 4);
			IPAddress iPAddress = new IPAddress(array7);
			text = iPAddress.ToString();
		}
		else if (array6[3] == byte_4)
		{
			byte[] array8 = new byte[1];
			stream.Read(array8, 0, 1);
			byte[] array9 = new byte[array8[0]];
			stream.Read(array9, 0, array8[0]);
			text = Encoding.Default.GetString(array9);
		}
		else
		{
			Console.WriteLine("unsupported addresstype " + array6[3]);
		}
		if (text != string.Empty)
		{
			byte[] array10 = new byte[2];
			stream.Read(array10, 0, 2);
			int port = BitConverter.ToUInt16(new byte[2]
			{
				array10[1],
				array10[0]
			}, 0);
			Console.WriteLine("requesting " + text + ":" + port);
			tcpClient_1 = new TcpClient(text, port);
			if (tcpClient_1.Connected)
			{
				byte[] array11 = new byte[10] { byte_0, byte_2, 0, 1, 0, 0, 0, 0, 0, 0 };
				string ipString = tcpClient_1.Client.LocalEndPoint!.ToString()!.Split(new char[1] { ':' })[0];
				IPAddress iPAddress2 = IPAddress.Parse(ipString);
				array11[4] = iPAddress2.GetAddressBytes()[0];
				array11[5] = iPAddress2.GetAddressBytes()[1];
				array11[6] = iPAddress2.GetAddressBytes()[2];
				array11[7] = iPAddress2.GetAddressBytes()[3];
				int num3 = int.Parse(tcpClient_1.Client.LocalEndPoint!.ToString()!.Split(new char[1] { ':' })[1]);
				array11[8] = BitConverter.GetBytes((ushort)num3)[0];
				array11[9] = BitConverter.GetBytes((ushort)num3)[1];
				stream.Write(array11, 0, 10);
				Console.WriteLine("writing reply");
				NetworkStream stream2 = tcpClient_1.GetStream();
				bool flag = false;
				while (tcpClient_1.Connected && tcpClient_0.Connected && !flag)
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
							Console.WriteLine("writing " + array13.Length + " to target");
						}
						if (stream2.DataAvailable)
						{
							byte[] array14 = new byte[10000];
							int num5 = stream2.Read(array14, 0, 10000);
							byte[] array15 = new byte[num5];
							Array.Copy(array14, array15, num5);
							stream.Write(array15, 0, array15.Length);
							Console.WriteLine("writing " + array15.Length + " to socks initiator");
						}
					}
					catch
					{
						flag = true;
					}
				}
				if (tcpClient_0.Connected)
				{
					tcpClient_0.Close();
				}
				if (tcpClient_1.Connected)
				{
					tcpClient_1.Close();
				}
			}
			else
			{
				Console.WriteLine("target host could not be connected.");
			}
		}
		else
		{
			Console.WriteLine("terminating connection");
		}
	}
}
