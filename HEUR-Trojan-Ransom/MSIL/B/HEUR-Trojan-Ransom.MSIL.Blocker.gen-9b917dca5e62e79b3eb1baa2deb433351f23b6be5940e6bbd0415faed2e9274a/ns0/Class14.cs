using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
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

internal sealed class Class14
{
	internal sealed class Class15
	{
		[StructLayout(LayoutKind.Auto)]
		internal struct Struct9
		{
			internal bool bool_0;

			internal string string_0;
		}

		internal static SettingsBase smethod_0<T>(T gparam_0, int int_0, char char_0) where T : SettingsBase
		{
			int num = 0;
			SettingsBase result = (SettingsBase)((((int_0 ^ char_0) - 115) ^ 0) switch
			{
				0 => SettingsBase.Synchronized((SettingsBase)(object)gparam_0), 
				_ => null, 
			});
			num++;
			return result;
		}

		internal static void smethod_1(int int_0, short short_0, short short_1)
		{
			int num = 0;
			int num2;
			do
			{
				switch (((short_1 ^ short_0) - 30) ^ num)
				{
				case 0:
					Thread.Sleep(int_0);
					break;
				}
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		internal static object smethod_2<T, U>(U gparam_0, T gparam_1, char char_0, short short_0) where T : string where U : ManagementBaseObject
		{
			int num = 0;
			object result;
			int num2;
			do
			{
				result = (((short_0 ^ char_0) - 60) ^ num) switch
				{
					0 => ((ManagementBaseObject)gparam_0).get_Item((string)gparam_1), 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static object smethod_3<T, U, V>(T gparam_0, V gparam_1, U gparam_2, object[] object_0, string[] string_0, Type[] type_0, bool[] bool_0, int int_0, int int_1) where U : string where V : Type
		{
			int num = 0;
			object result = (((int_1 ^ int_0) - 97) ^ 0) switch
			{
				0 => NewLateBinding.LateGet((object)gparam_0, (Type)gparam_1, (string)gparam_2, object_0, string_0, type_0, bool_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static bool smethod_4<T>(T gparam_0, int int_0, short short_0) where T : string
		{
			int num = 0;
			bool result;
			do
			{
				result = (((short_0 ^ int_0) - 4) ^ num) switch
				{
					1 => Directory.Exists(gparam_0), 
					0 => File.Exists(gparam_0), 
					_ => false, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static Assembly smethod_5<T>(T gparam_0, short short_0, char char_0) where T : Type
		{
			int num = 0;
			Assembly result = (((char_0 ^ short_0) - 97) ^ 0) switch
			{
				0 => (Assembly)(ICustomAttributeProvider)gparam_0.Assembly, 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static int smethod_6<T>(T gparam_0, int int_0, short short_0) where T : Array
		{
			int num = 0;
			int result;
			int num2;
			do
			{
				result = (((short_0 ^ int_0) - 126) ^ num) switch
				{
					0 => gparam_0.Length, 
					_ => 11, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static void smethod_7<T>(T gparam_0, int int_0, int int_1) where T : Exception
		{
			int num = 0;
			switch (((int_0 ^ int_1) - 119) ^ 0)
			{
			case 0:
				ProjectData.SetProjectError((Exception)gparam_0);
				break;
			}
			num++;
		}

		internal static byte[] smethod_8<T>(T gparam_0, int int_0, char char_0) where T : MemoryStream
		{
			int num = 0;
			byte[] result = (((int_0 ^ char_0) - 90) ^ 0) switch
			{
				0 => (byte[])(Array)gparam_0.ToArray(), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_9<T>(T gparam_0, int int_0, short short_0) where T : string
		{
			int num = 0;
			do
			{
				switch (((int_0 ^ short_0) - 49) ^ num)
				{
				case 0:
					File.Delete(gparam_0);
					break;
				}
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
		}

		internal static int smethod_10<T>(T gparam_0, int int_0, int int_1, short short_0) where T : Array
		{
			int num = 0;
			int result = (((int_1 ^ short_0) - 28) ^ 0) switch
			{
				0 => Information.UBound((Array)gparam_0, int_0), 
				_ => 0, 
			};
			num++;
			return result;
		}

		internal static DriveType smethod_11<T>(T gparam_0, char char_0, int int_0) where T : DriveInfo
		{
			int num = 0;
			DriveType result;
			int num2;
			do
			{
				result = (((int_0 ^ char_0) - 65) ^ num) switch
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

		internal static Process smethod_12<T>(T gparam_0, int int_0, short short_0) where T : ProcessStartInfo
		{
			int num = 0;
			Process result = (((int_0 ^ short_0) - 18) ^ 0) switch
			{
				0 => (Process)(Component)Process.Start(gparam_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static string[] smethod_13<T, U>(U gparam_0, T gparam_1, int int_0, CompareMethod compareMethod_0, int int_1, int int_2) where T : string where U : string
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			string[] result = (((int_2 ^ int_1) - 23) ^ 0) switch
			{
				0 => (string[])(Array)Strings.Split((string)gparam_0, (string)gparam_1, int_0, compareMethod_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static int smethod_14<T>(T gparam_0, char char_0, short short_0)
		{
			int num = 0;
			int result = (((short_0 ^ char_0) - 78) ^ 0) switch
			{
				0 => Conversions.ToInteger((object)gparam_0), 
				_ => 15, 
			};
			num++;
			return result;
		}

		internal static int smethod_15<T, U>(T gparam_0, U gparam_1, bool bool_0, short short_0, short short_1) where T : string where U : string
		{
			int num = 0;
			int result;
			do
			{
				result = (((short_0 ^ short_1) - 9) ^ num) switch
				{
					0 => Operators.CompareString((string)gparam_0, (string)gparam_1, bool_0), 
					_ => 0, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static void smethod_16<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, short short_0, char char_0) where T : MemoryStream
		{
			int num = 0;
			switch (((char_0 ^ short_0) - 37) ^ 0)
			{
			case 0:
				gparam_0.Write(byte_0, int_0, int_1);
				break;
			}
			num++;
		}

		internal static string smethod_17<T>(T gparam_0, char char_0, short short_0) where T : DriveInfo
		{
			int num = 0;
			string result = (((short_0 ^ char_0) - 50) ^ 0) switch
			{
				0 => gparam_0.Name, 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_18<T, U, V>(U gparam_0, T gparam_1, V gparam_2, char char_0, int int_0) where T : string where U : FileSystemProxy where V : string
		{
			int num = 0;
			switch (((char_0 ^ int_0) - 27) ^ 0)
			{
			case 0:
				((FileSystemProxy)gparam_0).CopyFile((string)gparam_1, (string)gparam_2);
				break;
			}
			num++;
		}

		internal static void smethod_19<T, U, V>(U gparam_0, T gparam_1, V gparam_2, int int_0, int int_1) where T : string where U : AppDomain
		{
			int num = 0;
			switch (((int_1 ^ int_0) - 117) ^ 0)
			{
			case 0:
				gparam_0.SetData(gparam_1, gparam_2);
				break;
			}
			num++;
		}

		internal static int smethod_20<T>(T gparam_0, int int_0, int int_1, int int_2, char char_0) where T : Random
		{
			int num = 0;
			int result;
			do
			{
				result = (((char_0 ^ int_2) - 58) ^ num) switch
				{
					0 => gparam_0.Next(int_0, int_1), 
					_ => 4, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		internal static string smethod_21<T>(T gparam_0, byte[] byte_0, short short_0, char char_0) where T : Encoding
		{
			int num = 0;
			string result = (((char_0 ^ short_0) - 60) ^ 0) switch
			{
				0 => (string)(IComparable<string>)gparam_0.GetString(byte_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static Encoding smethod_22(char char_0, int int_0)
		{
			int num = 0;
			Encoding result;
			int num2;
			do
			{
				result = (((char_0 ^ int_0) - 127) ^ num) switch
				{
					0 => (Encoding)(ICloneable)Encoding.Default, 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static bool smethod_23<T>(T gparam_0, int int_0, int int_1) where T : Socket
		{
			int num = 0;
			bool result = (((int_1 ^ int_0) - 77) ^ 0) switch
			{
				0 => gparam_0.Connected, 
				_ => true, 
			};
			num++;
			return result;
		}
	}

	internal sealed class Class16
	{
		internal sealed class Class17
		{
			internal static Delegate smethod_0<T, U>(T gparam_0, U gparam_1, char char_0, short short_0) where T : Delegate where U : Delegate
			{
				int num = 0;
				Delegate result;
				do
				{
					result = (((short_0 ^ char_0) - 3) ^ num) switch
					{
						1 => (Delegate)(ISerializable)Delegate.Remove(gparam_0, gparam_1), 
						0 => (Delegate)(ISerializable)Delegate.Combine(gparam_0, gparam_1), 
						_ => null, 
					};
					num++;
				}
				while ((short_0 * short_0 + short_0) % 2 != 0);
				return result;
			}

			internal static Assembly smethod_1<T>(byte[] byte_0, byte[] byte_1, T gparam_0, short short_0, int int_0) where T : Evidence
			{
				int num = 0;
				Assembly result;
				int num2;
				do
				{
					result = (((int_0 ^ short_0) - 96) ^ num) switch
					{
						0 => Assembly.Load(byte_0, byte_1, (Evidence)gparam_0), 
						_ => null, 
					};
					num++;
					num2 = short_0 * short_0;
					num2 = short_0 + num2;
				}
				while (num2 % 2 != 0);
				return result;
			}

			internal static object smethod_2<T, U>(T gparam_0, U gparam_1, int int_0, short short_0)
			{
				int num = 0;
				object result = (((int_0 ^ short_0) - 59) ^ 0) switch
				{
					0 => Operators.ConcatenateObject((object)gparam_0, (object)gparam_1), 
					_ => null, 
				};
				num++;
				return result;
			}

			internal static Socket smethod_3<T>(T gparam_0, int int_0, char char_0) where T : TcpClient
			{
				int num = 0;
				Socket result;
				int num2;
				do
				{
					result = (((char_0 ^ int_0) - 16) ^ num) switch
					{
						0 => gparam_0.Client, 
						_ => null, 
					};
					num++;
					num2 = char_0 * char_0;
					num2 = char_0 + num2;
				}
				while (num2 % 2 != 0);
				return result;
			}

			internal static object smethod_4<T>(T gparam_0, object[] object_0, string[] string_0, short short_0, char char_0)
			{
				int num = 0;
				object result;
				int num2;
				do
				{
					result = (((short_0 ^ char_0) - 8) ^ num) switch
					{
						0 => NewLateBinding.LateIndexGet((object)gparam_0, object_0, string_0), 
						_ => null, 
					};
					num++;
					num2 = char_0 * char_0;
					num2 = char_0 + num2;
				}
				while (num2 % 2 != 0);
				return result;
			}

			internal static string smethod_5<T>(T gparam_0, short short_0, short short_1) where T : ComputerInfo
			{
				int num = 0;
				string result = (((short_0 ^ short_1) - 30) ^ 0) switch
				{
					0 => (string)(IComparable<string>)((ComputerInfo)gparam_0).get_OSFullName(), 
					1 => (string)(IComparable<string>)((ComputerInfo)gparam_0).get_OSVersion(), 
					_ => null, 
				};
				num++;
				return result;
			}

			internal static void smethod_6<T, U, V>(U gparam_0, T gparam_1, V gparam_2, char char_0, short short_0) where T : string where U : RegistryKey
			{
				int num = 0;
				switch (((short_0 ^ char_0) - 17) ^ 0)
				{
				case 0:
					gparam_0.SetValue(gparam_1, gparam_2);
					break;
				}
				num++;
			}

			internal static bool smethod_7<T, U>(T gparam_0, U gparam_1, int int_0, char char_0)
			{
				int num = 0;
				bool result;
				do
				{
					result = (((char_0 ^ int_0) - 27) ^ num) switch
					{
						0 => object.ReferenceEquals(gparam_0, gparam_1), 
						_ => true, 
					};
					num++;
				}
				while ((char_0 * char_0 + char_0) % 2 != 0);
				return result;
			}

			internal static ComputerInfo smethod_8<T>(T gparam_0, char char_0, short short_0) where T : ServerComputer
			{
				int num = 0;
				ComputerInfo result = (ComputerInfo)((((char_0 ^ short_0) - 71) ^ 0) switch
				{
					0 => ((ServerComputer)gparam_0).get_Info(), 
					_ => null, 
				});
				num++;
				return result;
			}

			internal static int smethod_9<T>(T gparam_0, char char_0, char char_1) where T : string
			{
				int num = 0;
				int result = (((char_0 ^ char_1) - 9) ^ 0) switch
				{
					0 => Conversions.ToInteger((string)gparam_0), 
					1 => gparam_0.Length, 
					2 => Convert.ToInt32(gparam_0), 
					_ => 13, 
				};
				num++;
				return result;
			}

			internal static WindowsIdentity smethod_10(char char_0, int int_0)
			{
				int num = 0;
				WindowsIdentity result = (((char_0 ^ int_0) - 25) ^ 0) switch
				{
					0 => (WindowsIdentity)(ISerializable)WindowsIdentity.GetCurrent(), 
					_ => null, 
				};
				num++;
				return result;
			}

			internal static void smethod_11<T>(T gparam_0, int int_0, int int_1) where T : TcpClient
			{
				int num = 0;
				switch (((int_1 ^ int_0) - 112) ^ 0)
				{
				case 0:
					gparam_0.Close();
					break;
				}
				num++;
			}

			internal static int smethod_12<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, SocketFlags socketFlags_0, short short_0, short short_1) where T : Socket
			{
				int num = 0;
				int result;
				do
				{
					result = (((short_1 ^ short_0) - 2) ^ num) switch
					{
						1 => gparam_0.Receive(byte_0, int_0, int_1, socketFlags_0), 
						0 => gparam_0.Send(byte_0, int_0, int_1, socketFlags_0), 
						_ => 5, 
					};
					num++;
				}
				while ((short_1 * short_1 + short_1) % 2 != 0);
				return result;
			}

			internal static Exception smethod_13(int int_0, short short_0, char char_0)
			{
				int num = 0;
				Exception result;
				do
				{
					result = (((short_0 ^ char_0) - 87) ^ num) switch
					{
						0 => ProjectData.CreateProjectError(int_0), 
						_ => null, 
					};
					num++;
				}
				while ((short_0 * short_0 + short_0) % 2 != 0);
				return result;
			}
		}

		internal static void smethod_0<T>(T gparam_0, char char_0, int int_0)
		{
			int num = 0;
			do
			{
				switch (((char_0 ^ int_0) - 123) ^ num)
				{
				case 1:
					Monitor.Exit(gparam_0);
					break;
				case 0:
					Monitor.Enter(gparam_0);
					break;
				}
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
		}

		internal static int smethod_1<T>(T gparam_0, int int_0, char char_0) where T : TcpClient
		{
			int num = 0;
			int result;
			do
			{
				result = (((int_0 ^ char_0) - 121) ^ num) switch
				{
					0 => gparam_0.Available, 
					_ => 6, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		internal static bool smethod_2<T, U>(U gparam_0, T gparam_1, int int_0, char char_0) where T : string where U : string
		{
			int num = 0;
			bool result;
			int num2;
			do
			{
				result = (((int_0 ^ char_0) - 80) ^ num) switch
				{
					0 => gparam_0.Contains(gparam_1), 
					_ => false, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static int smethod_3<T>(T gparam_0, AppWinStyle appWinStyle_0, bool bool_0, int int_0, char char_0, char char_1) where T : string
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			int result;
			do
			{
				result = (((char_0 ^ char_1) - 75) ^ num) switch
				{
					0 => Interaction.Shell((string)gparam_0, appWinStyle_0, bool_0, int_0), 
					_ => int_0, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		internal static void smethod_4<T>(T gparam_0, short short_0, char char_0) where T : Component
		{
			int num = 0;
			int num2;
			do
			{
				switch (((short_0 ^ char_0) - 103) ^ num)
				{
				case 0:
					gparam_0.Dispose();
					break;
				}
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		internal static Assembly smethod_5(char char_0, short short_0)
		{
			int num = 0;
			Assembly result = (((char_0 ^ short_0) - 12) ^ 0) switch
			{
				0 => Assembly.GetExecutingAssembly(), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_6<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, short short_0, int int_2) where T : Stream
		{
			int num = 0;
			int num2;
			do
			{
				switch (((short_0 ^ int_2) - 43) ^ num)
				{
				case 0:
					gparam_0.Write(byte_0, int_0, int_1);
					break;
				}
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		internal static long smethod_7<T>(T gparam_0, int int_0, short short_0) where T : MemoryStream
		{
			int num = 0;
			long result;
			do
			{
				result = (((int_0 ^ short_0) - 98) ^ num) switch
				{
					0 => gparam_0.Length, 
					_ => 14L, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static RegistryKey smethod_8<T, U>(T gparam_0, U gparam_1, bool bool_0, char char_0, char char_1) where T : RegistryKey where U : string
		{
			int num = 0;
			RegistryKey result;
			int num2;
			do
			{
				result = (((char_1 ^ char_0) - 42) ^ num) switch
				{
					0 => gparam_0.OpenSubKey(gparam_1, bool_0), 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static void smethod_9<T, U, V>(U gparam_0, T gparam_1, V gparam_2, char char_0, short short_0) where T : string where U : WebClient where V : string
		{
			int num = 0;
			switch (((char_0 ^ short_0) - 20) ^ 0)
			{
			case 0:
				gparam_0.DownloadFile(gparam_1, gparam_2);
				break;
			}
			num++;
		}

		internal static string[] smethod_10<T>(T gparam_0, char[] char_0, char char_1, char char_2) where T : string
		{
			int num = 0;
			string[] result = (((char_1 ^ char_2) - 28) ^ 0) switch
			{
				0 => (string[])(Array)gparam_0.Split(char_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_11<T>(T gparam_0, char char_0, short short_0) where T : StreamWriter
		{
			int num = 0;
			do
			{
				switch (((short_0 ^ char_0) - 32) ^ num)
				{
				case 0:
					gparam_0.Close();
					break;
				}
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
		}

		internal static void smethod_12<T, U>(T gparam_0, U gparam_1, char char_0, char char_1) where T : Socket where U : EndPoint
		{
			int num = 0;
			int num2;
			do
			{
				switch (((char_0 ^ char_1) - 16) ^ num)
				{
				case 0:
					gparam_0.Connect(gparam_1);
					break;
				}
				num++;
				num2 = char_1 * char_1;
				num2 = char_1 + num2;
			}
			while (num2 % 2 != 0);
		}

		internal static string smethod_13(Environment.SpecialFolder specialFolder_0, short short_0, char char_0)
		{
			int num = 0;
			string result = (((short_0 ^ char_0) - 93) ^ 0) switch
			{
				0 => Environment.GetFolderPath(specialFolder_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_14<T, U>(U gparam_0, T gparam_1, short short_0, short short_1) where T : string where U : string
		{
			int num = 0;
			switch (((short_1 ^ short_0) - 81) ^ 0)
			{
			case 0:
				File.Copy(gparam_0, gparam_1);
				break;
			}
			num++;
		}

		internal static FileSystemProxy smethod_15<T>(T gparam_0, short short_0, int int_0) where T : ServerComputer
		{
			int num = 0;
			FileSystemProxy result;
			do
			{
				result = (FileSystemProxy)((((short_0 ^ int_0) - 105) ^ num) switch
				{
					0 => ((ServerComputer)gparam_0).get_FileSystem(), 
					_ => null, 
				});
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static void smethod_16<T, U>(U gparam_0, T gparam_1, int int_0, char char_0) where T : ElapsedEventHandler where U : System.Timers.Timer
		{
			int num = 0;
			switch (((char_0 ^ int_0) - 31) ^ 0)
			{
			case 0:
				gparam_0.Elapsed += gparam_1;
				break;
			}
			num++;
		}

		internal static void smethod_17<T, U>(U gparam_0, T gparam_1, int int_0, int int_1) where T : string where U : ProcessStartInfo
		{
			int num = 0;
			switch (((int_1 ^ int_0) - 9) ^ 0)
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

		internal static void smethod_18<T, U>(U gparam_0, T gparam_1, bool bool_0, short short_0, int int_0) where T : string where U : RegistryKey
		{
			int num = 0;
			switch (((int_0 ^ short_0) - 32) ^ 0)
			{
			case 0:
				gparam_0.DeleteValue(gparam_1, bool_0);
				break;
			}
			num++;
		}

		internal static Evidence smethod_19<T>(T gparam_0, short short_0, int int_0) where T : Assembly
		{
			int num = 0;
			Evidence result = (((short_0 ^ int_0) - 70) ^ 0) switch
			{
				0 => (Evidence)(IEnumerable)((Assembly)gparam_0).get_Evidence(), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_20<T, U>(U gparam_0, T gparam_1, char char_0, short short_0) where T : string where U : TextWriter
		{
			int num = 0;
			int num2;
			do
			{
				switch (((short_0 ^ char_0) - 68) ^ num)
				{
				case 0:
					gparam_0.WriteLine(gparam_1);
					break;
				}
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		internal static void smethod_21<T>(T gparam_0, double double_0, short short_0, short short_1) where T : System.Timers.Timer
		{
			int num = 0;
			switch (((short_0 ^ short_1) - 25) ^ 0)
			{
			case 0:
				gparam_0.Interval = double_0;
				break;
			}
			num++;
		}

		internal static AppDomain smethod_22(short short_0, short short_1)
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			int num = 0;
			AppDomain result = (((short_0 ^ short_1) - 6) ^ 0) switch
			{
				0 => (AppDomain)(_AppDomain)AppDomain.CurrentDomain, 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static bool smethod_23<T>(T gparam_0, WindowsBuiltInRole windowsBuiltInRole_0, char char_0, short short_0) where T : WindowsPrincipal
		{
			int num = 0;
			bool result = (((char_0 ^ short_0) - 31) ^ 0) switch
			{
				0 => gparam_0.IsInRole(windowsBuiltInRole_0), 
				_ => false, 
			};
			num++;
			return result;
		}

		internal static void smethod_24<T, U, V>(V gparam_0, T gparam_1, U gparam_2, object[] object_0, string[] string_0, Type[] type_0, bool bool_0, bool bool_1, char char_0, int int_0) where T : Type where U : string
		{
			int num = 0;
			switch (((int_0 ^ char_0) - 67) ^ 0)
			{
			case 0:
				NewLateBinding.LateSetComplex((object)gparam_0, (Type)gparam_1, (string)gparam_2, object_0, string_0, type_0, bool_0, bool_1);
				break;
			}
			num++;
		}

		internal static DriveInfo[] smethod_25(char char_0, short short_0)
		{
			int num = 0;
			DriveInfo[] result;
			do
			{
				result = (((char_0 ^ short_0) - 83) ^ num) switch
				{
					0 => DriveInfo.GetDrives(), 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		internal static bool smethod_26<T, U>(T gparam_0, U gparam_1, char char_0, short short_0) where T : FileSystemProxy where U : string
		{
			int num = 0;
			bool result;
			do
			{
				result = (((char_0 ^ short_0) - 108) ^ num) switch
				{
					0 => ((FileSystemProxy)gparam_0).FileExists((string)gparam_1), 
					_ => false, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}
	}

	internal static void smethod_0(char char_0, short short_0)
	{
		int num = 0;
		switch (((short_0 ^ char_0) - 49) ^ 0)
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

	internal static RegistryProxy smethod_1<T>(T gparam_0, short short_0, char char_0) where T : ServerComputer
	{
		int num = 0;
		RegistryProxy result;
		int num2;
		do
		{
			result = (RegistryProxy)((((short_0 ^ char_0) - 68) ^ num) switch
			{
				0 => ((ServerComputer)gparam_0).get_Registry(), 
				_ => null, 
			});
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static void smethod_2<T>(T gparam_0, char char_0, char char_1) where T : System.Timers.Timer
	{
		int num = 0;
		switch (((char_0 ^ char_1) - 112) ^ 0)
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

	internal static IPAddress smethod_3<T>(T gparam_0, short short_0, short short_1) where T : string
	{
		int num = 0;
		IPAddress result;
		int num2;
		do
		{
			result = (((short_1 ^ short_0) - 118) ^ num) switch
			{
				0 => IPAddress.Parse(gparam_0), 
				_ => null, 
			};
			num++;
			num2 = short_1 * short_1;
			num2 = short_1 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static OperatingSystem smethod_4(int int_0, char char_0)
	{
		int num = 0;
		OperatingSystem result;
		int num2;
		do
		{
			result = (((char_0 ^ int_0) - 2) ^ num) switch
			{
				0 => (OperatingSystem)(ICloneable)Environment.OSVersion, 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static void smethod_5<T>(T gparam_0, ProcessWindowStyle processWindowStyle_0, char char_0, short short_0) where T : ProcessStartInfo
	{
		int num = 0;
		int num2;
		do
		{
			switch (((short_0 ^ char_0) - 74) ^ num)
			{
			case 0:
				gparam_0.WindowStyle = processWindowStyle_0;
				break;
			}
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static string smethod_6<T>(T gparam_0, char char_0, char char_1) where T : OperatingSystem
	{
		int num = 0;
		string result;
		int num2;
		do
		{
			result = (((char_0 ^ char_1) - 51) ^ num) switch
			{
				0 => (string)(IEquatable<string>)gparam_0.ServicePack, 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static ManagementObjectCollection smethod_7<T>(T gparam_0, char char_0, short short_0) where T : ManagementObjectSearcher
	{
		int num = 0;
		ManagementObjectCollection result = (ManagementObjectCollection)((((short_0 ^ char_0) - 109) ^ 0) switch
		{
			0 => (ICollection)((ManagementObjectSearcher)gparam_0).Get(), 
			_ => null, 
		});
		num++;
		return result;
	}

	internal static string smethod_8<T>(T gparam_0, int int_0, short short_0) where T : string
	{
		int num = 0;
		string result = (((int_0 ^ short_0) - 94) ^ 0) switch
		{
			0 => gparam_0.Trim(), 
			1 => Path.GetFileNameWithoutExtension(gparam_0), 
			2 => Path.GetFileName(gparam_0), 
			3 => Path.GetExtension(gparam_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static byte[] smethod_9<T, U>(T gparam_0, U gparam_1, int int_0, char char_0) where T : Encoding where U : string
	{
		int num = 0;
		byte[] result = (((char_0 ^ int_0) - 110) ^ 0) switch
		{
			0 => (byte[])(Array)gparam_0.GetBytes(gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_10<T>(T gparam_0, char char_0, short short_0)
	{
		int num = 0;
		string result = (((short_0 ^ char_0) - 17) ^ 0) switch
		{
			0 => (string)(IConvertible)gparam_0.ToString(), 
			1 => (string)(IConvertible)Conversions.ToString((object)gparam_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static object smethod_11<T, U, V>(U gparam_0, T gparam_1, V gparam_2, object[] object_0, string[] string_0, Type[] type_0, bool[] bool_0, bool bool_1, char char_0, char char_1) where T : Type where V : string
	{
		int num = 0;
		object result = (((char_1 ^ char_0) - 47) ^ 0) switch
		{
			0 => NewLateBinding.LateCall((object)gparam_0, (Type)gparam_1, (string)gparam_2, object_0, string_0, type_0, bool_0, bool_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static RegistryKey smethod_12<T>(T gparam_0, short short_0, char char_0) where T : RegistryProxy
	{
		int num = 0;
		RegistryKey result = (((short_0 ^ char_0) - 23) ^ 0) switch
		{
			0 => ((RegistryProxy)gparam_0).get_CurrentUser(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static object smethod_13<T, U>(T gparam_0, U gparam_1, short short_0, int int_0) where U : Type
	{
		int num = 0;
		object result;
		int num2;
		do
		{
			result = (((short_0 ^ int_0) - 54) ^ num) switch
			{
				0 => Conversions.ChangeType((object)gparam_0, (Type)gparam_1), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static MsgBoxResult smethod_14<T, U>(T gparam_0, MsgBoxStyle msgBoxStyle_0, U gparam_1, char char_0, short short_0)
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
			result = (MsgBoxResult)((((short_0 ^ char_0) - 7) ^ num) switch
			{
				0 => Interaction.MsgBox((object)gparam_0, msgBoxStyle_0, (object)gparam_1), 
				_ => 0, 
			});
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static string smethod_15<T, U>(U gparam_0, T gparam_1, int int_0, int int_1) where T : string where U : string
	{
		int num = 0;
		string result = (((int_1 ^ int_0) - 10) ^ 0) switch
		{
			0 => string.Concat(gparam_0, gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static int smethod_16<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, short short_0, int int_2) where T : Stream
	{
		int num = 0;
		int result;
		int num2;
		do
		{
			result = (((short_0 ^ int_2) - 98) ^ num) switch
			{
				0 => gparam_0.Read(byte_0, int_0, int_1), 
				_ => int_1, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static bool smethod_17<T>(T gparam_0, int int_0, SelectMode selectMode_0, int int_1, char char_0) where T : Socket
	{
		int num = 0;
		bool result;
		int num2;
		do
		{
			result = (((char_0 ^ int_1) - 111) ^ num) switch
			{
				0 => gparam_0.Poll(int_0, selectMode_0), 
				_ => true, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static string[] smethod_18<T>(T gparam_0, int int_0, short short_0) where T : string
	{
		int num = 0;
		string[] result = (((int_0 ^ short_0) - 103) ^ 0) switch
		{
			0 => Directory.GetDirectories(gparam_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_19<T, U>(U gparam_0, T gparam_1, short short_0, char char_0) where T : string where U : WebClient
	{
		int num = 0;
		string result = (((short_0 ^ char_0) - 94) ^ 0) switch
		{
			0 => (string)(IComparable)gparam_0.DownloadString(gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static object smethod_20<T, U>(bool bool_0, U gparam_0, T gparam_1, short short_0, char char_0)
	{
		int num = 0;
		object result = (((char_0 ^ short_0) - 6) ^ 0) switch
		{
			0 => Interaction.IIf(bool_0, (object)gparam_0, (object)gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static ManagementObjectEnumerator smethod_21<T>(T gparam_0, short short_0, int int_0) where T : ManagementObjectCollection
	{
		int num = 0;
		ManagementObjectEnumerator result;
		int num2;
		do
		{
			result = (ManagementObjectEnumerator)((((int_0 ^ short_0) - 56) ^ num) switch
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
}
