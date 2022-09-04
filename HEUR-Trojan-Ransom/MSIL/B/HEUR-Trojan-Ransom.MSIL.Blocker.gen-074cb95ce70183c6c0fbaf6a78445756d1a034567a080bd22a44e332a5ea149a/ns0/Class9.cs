using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Policy;
using System.Text;
using System.Threading;

namespace ns0;

internal sealed class Class9
{
	internal sealed class Class10
	{
		internal sealed class Class11
		{
			internal static int smethod_0<T>(T gparam_0, int int_0, short short_0, short short_1) where T : Array
			{
				int num = 0;
				int result;
				int num2;
				do
				{
					result = (((short_1 ^ short_0) - 76) ^ num) switch
					{
						0 => gparam_0.GetLength(int_0), 
						_ => 11, 
					};
					num++;
					num2 = short_1 * short_1;
					num2 = short_1 + num2;
				}
				while (num2 % 2 != 0);
				return result;
			}
		}

		internal sealed class Class12
		{
		}

		internal sealed class Class13
		{
		}

		internal static int smethod_0<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, char char_0, char char_1) where T : Stream
		{
			int num = 0;
			int result;
			int num2;
			do
			{
				result = (((char_1 ^ char_0) - 69) ^ num) switch
				{
					0 => gparam_0.Read(byte_0, int_0, int_1), 
					_ => 11, 
				};
				num++;
				num2 = char_1 * char_1;
				num2 = char_1 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static AppDomain smethod_1(int int_0, short short_0)
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			int num = 0;
			AppDomain result = (((short_0 ^ int_0) - 31) ^ 0) switch
			{
				0 => (AppDomain)(_AppDomain)AppDomain.CurrentDomain, 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static StringBuilder smethod_2<T>(T gparam_0, char char_0, int int_0, short short_0) where T : StringBuilder
		{
			int num = 0;
			StringBuilder result;
			do
			{
				result = (((int_0 ^ short_0) - 96) ^ num) switch
				{
					0 => gparam_0.Append(char_0), 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		internal static string smethod_3<T>(T gparam_0, int int_0, char char_0)
		{
			int num = 0;
			string result;
			do
			{
				result = (((int_0 ^ char_0) - 35) ^ num) switch
				{
					0 => (string)(IEquatable<string>)gparam_0.ToString(), 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		internal static Assembly smethod_4(short short_0, int int_0)
		{
			int num = 0;
			Assembly result = (((short_0 ^ int_0) - 40) ^ 0) switch
			{
				0 => Assembly.GetExecutingAssembly(), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static object smethod_5<T, U>(U gparam_0, T gparam_1, int int_0, short short_0) where T : string where U : ResourceManager
		{
			int num = 0;
			object result = (((short_0 ^ int_0) - 11) ^ 0) switch
			{
				0 => gparam_0.GetObject(gparam_1), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_6<T>(T gparam_0, char char_0, short short_0) where T : ResourceManager
		{
			int num = 0;
			switch (((short_0 ^ char_0) - 53) ^ 0)
			{
			case 0:
				gparam_0.ReleaseAllResources();
				break;
			}
			num++;
		}

		internal static MethodInfo smethod_7<T>(T gparam_0, short short_0, int int_0) where T : Assembly
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			int num = 0;
			MethodInfo result = (((int_0 ^ short_0) - 102) ^ 0) switch
			{
				0 => (MethodInfo)(_MethodInfo)gparam_0.EntryPoint, 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static ParameterInfo[] smethod_8<T>(T gparam_0, char char_0, int int_0) where T : MethodBase
		{
			int num = 0;
			ParameterInfo[] result = (((int_0 ^ char_0) - 93) ^ 0) switch
			{
				0 => gparam_0.GetParameters(), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_9<T, U, V>(T gparam_0, V gparam_1, U gparam_2, char char_0, char char_1) where T : AppDomain where V : string
		{
			int num = 0;
			switch (((char_0 ^ char_1) - 24) ^ 0)
			{
			case 0:
				gparam_0.SetData(gparam_1, gparam_2);
				break;
			}
			num++;
		}

		internal static void smethod_10<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, char char_0, int int_2) where T : Stream
		{
			int num = 0;
			do
			{
				switch (((int_2 ^ char_0) - 75) ^ num)
				{
				case 0:
					gparam_0.Write(byte_0, int_0, int_1);
					break;
				}
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
		}

		internal static Evidence smethod_11<T>(T gparam_0, char char_0, int int_0) where T : Assembly
		{
			int num = 0;
			Evidence result = (((int_0 ^ char_0) - 52) ^ 0) switch
			{
				0 => ((Assembly)gparam_0).get_Evidence(), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static object smethod_12<T, U>(T gparam_0, U gparam_1, int int_0, short short_0) where T : AppDomain where U : string
		{
			int num = 0;
			object result = (((short_0 ^ int_0) - 56) ^ 0) switch
			{
				0 => gparam_0.GetData(gparam_1), 
				_ => null, 
			};
			num++;
			return result;
		}
	}

	internal static void smethod_0<T>(T gparam_0, int int_0, short short_0)
	{
		int num = 0;
		switch (((int_0 ^ short_0) - 35) ^ 0)
		{
		case 0:
			Monitor.Enter(gparam_0);
			break;
		case 1:
			Monitor.Exit(gparam_0);
			break;
		}
		num++;
	}

	internal static void smethod_1<T, U>(T gparam_0, U gparam_1, short short_0, char char_0) where T : AppDomain where U : ResolveEventHandler
	{
		int num = 0;
		do
		{
			switch (((short_0 ^ char_0) - 3) ^ num)
			{
			case 0:
				gparam_0.ResourceResolve += gparam_1;
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}

	internal static Assembly smethod_2<T>(byte[] byte_0, byte[] byte_1, T gparam_0, int int_0, int int_1) where T : Evidence
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		int num = 0;
		Assembly result = (((int_1 ^ int_0) - 68) ^ 0) switch
		{
			0 => (Assembly)(IEvidenceFactory)Assembly.Load(byte_0, byte_1, (Evidence)gparam_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string[] smethod_3<T>(T gparam_0, int int_0, int int_1) where T : Assembly
	{
		int num = 0;
		string[] result = (((int_1 ^ int_0) - 61) ^ 0) switch
		{
			0 => (string[])(Array)gparam_0.GetManifestResourceNames(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static DateTime smethod_4(short short_0, short short_1)
	{
		int num = 0;
		DateTime result = (((short_1 ^ short_0) - 64) ^ 0) switch
		{
			0 => DateTime.Now, 
			_ => default(DateTime), 
		};
		num++;
		return result;
	}

	internal static string smethod_5<T, U>(U gparam_0, T gparam_1, int int_0, char char_0) where T : string where U : string
	{
		int num = 0;
		string result = (((int_0 ^ char_0) - 125) ^ 0) switch
		{
			0 => (string)(IEnumerable)string.Concat(gparam_0, gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static char[] smethod_6<T>(T gparam_0, short short_0, short short_1) where T : string
	{
		int num = 0;
		char[] result = (((short_1 ^ short_0) - 103) ^ 0) switch
		{
			0 => (char[])(Array)gparam_0.ToCharArray(), 
			_ => null, 
		};
		num++;
		return result;
	}
}
