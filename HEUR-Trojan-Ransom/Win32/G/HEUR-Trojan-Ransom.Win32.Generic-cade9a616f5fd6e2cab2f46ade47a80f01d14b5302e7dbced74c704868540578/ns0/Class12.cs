using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

internal sealed class Class12
{
	internal sealed class Class13
	{
		internal sealed class Class14
		{
			internal int int_0;

			internal Class14()
			{
			}
		}

		internal sealed class Class15
		{
			internal List<XAttribute> list_0;

			internal Class15()
			{
			}
		}

		[SecuritySafeCritical]
		internal static void smethod_0<T>(T gparam_0, short short_0, short short_1)
		{
			int num = 0;
			do
			{
				switch (((short_1 ^ short_0) - 69) ^ num)
				{
				case 2:
					Monitor.Enter(gparam_0);
					break;
				case 1:
					Monitor.Exit(gparam_0);
					break;
				case 0:
					ObjectFlowControl.CheckForSyncLockOnValueType((object)gparam_0);
					break;
				}
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static void smethod_1<T, U>(T gparam_0, U gparam_1, int int_0, char char_0) where T : WindowsFormsApplicationBase where U : ShutdownEventHandler
		{
			int num = 0;
			do
			{
				switch (((int_0 ^ char_0) - 109) ^ num)
				{
				case 0:
					((WindowsFormsApplicationBase)gparam_0).add_Shutdown((ShutdownEventHandler)(object)gparam_1);
					break;
				}
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static void smethod_2<T, U>(U gparam_0, T gparam_1, char char_0, short short_0) where T : string where U : Control
		{
			int num = 0;
			int num2;
			do
			{
				switch (((char_0 ^ short_0) - 40) ^ num)
				{
				case 0:
					((Control)gparam_0).set_Name((string)gparam_1);
					break;
				}
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static void smethod_3<T, U>(T gparam_0, U gparam_1, char char_0, int int_0) where T : Form where U : string
		{
			int num = 0;
			switch (((char_0 ^ int_0) - 62) ^ 0)
			{
			case 0:
				((Form)gparam_0).set_Text((string)gparam_1);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static string smethod_4<T>(T gparam_0, int int_0, int int_1) where T : XElement
		{
			int num = 0;
			string result = (((int_1 ^ int_0) - 52) ^ 0) switch
			{
				0 => (string)(IConvertible)((XElement)gparam_0).get_Value(), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static string smethod_5<T>(T gparam_0, char char_0, int int_0) where T : ResolveEventArgs
		{
			int num = 0;
			string result;
			do
			{
				result = (((char_0 ^ int_0) - 99) ^ num) switch
				{
					0 => (string)(IEquatable<string>)gparam_0.Name, 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_6<T>(T gparam_0, char char_0, short short_0) where T : XAttribute
		{
			int num = 0;
			switch (((short_0 ^ char_0) - 116) ^ 0)
			{
			case 0:
				((XAttribute)gparam_0).Remove();
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static string smethod_7<T>(T gparam_0, short short_0, short short_1) where T : XName
		{
			int num = 0;
			string result;
			int num2;
			do
			{
				result = (((short_1 ^ short_0) - 47) ^ num) switch
				{
					0 => (string)(IEnumerable)((XName)gparam_0).get_LocalName(), 
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
		internal static bool smethod_8<T, U>(U gparam_0, T gparam_1, char char_0, short short_0) where T : XNamespace where U : XNamespace
		{
			int num = 0;
			bool result;
			int num2;
			do
			{
				result = (((char_0 ^ short_0) - 119) ^ num) switch
				{
					0 => (XNamespace)(object)gparam_0 == (XNamespace)(object)gparam_1, 
					_ => false, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static object smethod_9<T, U, V>(T gparam_0, U gparam_1, V gparam_2, char char_0, short short_0) where T : ResourceManager where U : string where V : CultureInfo
		{
			int num = 0;
			object result = (((short_0 ^ char_0) - 116) ^ 0) switch
			{
				0 => gparam_0.GetObject(gparam_1, gparam_2), 
				_ => null, 
			};
			num++;
			return result;
		}
	}

	internal sealed class Class16
	{
		[SecuritySafeCritical]
		internal static Exception smethod_0<T>(T gparam_0, short short_0, char char_0) where T : Exception
		{
			int num = 0;
			Exception result;
			do
			{
				result = (((short_0 ^ char_0) - 70) ^ num) switch
				{
					0 => gparam_0.InnerException, 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_1<T>(T gparam_0, bool bool_0, short short_0, short short_1) where T : Control
		{
			int num = 0;
			switch (((short_1 ^ short_0) - 17) ^ 0)
			{
			case 0:
				((Control)gparam_0).ResumeLayout(bool_0);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static bool smethod_2<T>(T gparam_0, short short_0, int int_0) where T : WeakReference
		{
			int num = 0;
			bool result = (((int_0 ^ short_0) - 45) ^ 0) switch
			{
				0 => gparam_0.IsAlive, 
				_ => true, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_3<T>(T gparam_0, Size size_0, int int_0, int int_1) where T : Form
		{
			int num = 0;
			switch (((int_1 ^ int_0) - 7) ^ 0)
			{
			case 0:
				((Form)gparam_0).set_ClientSize(size_0);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static string smethod_4<T, U>(T gparam_0, U gparam_1, short short_0, short short_1) where T : string where U : string
		{
			int num = 0;
			string result;
			do
			{
				result = (((short_0 ^ short_1) - 53) ^ num) switch
				{
					0 => (string)(IEnumerable<char>)string.Concat(gparam_0, gparam_1), 
					_ => null, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_5<T, U>(U gparam_0, T gparam_1, short short_0, short short_1) where T : string where U : XElement
		{
			int num = 0;
			do
			{
				switch (((short_0 ^ short_1) - 100) ^ num)
				{
				case 0:
					((XElement)gparam_0).set_Value((string)gparam_1);
					break;
				}
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static XAttribute smethod_6<T>(T gparam_0, int int_0, short short_0) where T : XElement
		{
			int num = 0;
			XAttribute result = (XAttribute)((((short_0 ^ int_0) - 69) ^ 0) switch
			{
				0 => ((XElement)gparam_0).get_FirstAttribute(), 
				_ => null, 
			});
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_7<T>(T gparam_0, char char_0, char char_1) where T : ApplicationSettingsBase
		{
			int num = 0;
			switch (((char_0 ^ char_1) - 92) ^ 0)
			{
			case 0:
				((ApplicationSettingsBase)gparam_0).Save();
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static string smethod_8<T>(T gparam_0, char char_0, char char_1) where T : XAttribute
		{
			int num = 0;
			string result = (((char_0 ^ char_1) - 12) ^ 0) switch
			{
				0 => (string)(XAttribute)(object)gparam_0, 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static Assembly smethod_9<T>(T gparam_0, char char_0, short short_0) where T : Type
		{
			int num = 0;
			Assembly result = (((short_0 ^ char_0) - 99) ^ 0) switch
			{
				0 => gparam_0.Assembly, 
				_ => null, 
			};
			num++;
			return result;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct7
	{
		internal string[] string_0;
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_0(byte[] byte_0, byte[] byte_1, SecurityContextSource securityContextSource_0, short short_0, int int_0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		Assembly result = (((int_0 ^ short_0) - 121) ^ 0) switch
		{
			0 => Assembly.Load(byte_0, byte_1, securityContextSource_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static string smethod_1<T>(T gparam_0, string[] string_0, int int_0, char char_0) where T : string
	{
		int num = 0;
		string result;
		int num2;
		do
		{
			result = (((int_0 ^ char_0) - 53) ^ num) switch
			{
				0 => (string)(IEnumerable)Utils.GetResourceString((string)gparam_0, string_0), 
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
	internal static bool smethod_2<T, U>(T gparam_0, U gparam_1, short short_0, int int_0) where T : Assembly where U : Assembly
	{
		int num = 0;
		bool result;
		do
		{
			result = (((int_0 ^ short_0) - 45) ^ num) switch
			{
				0 => (Assembly?)gparam_0 != (Assembly?)gparam_1, 
				_ => false, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_3<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, int int_2, char char_0) where T : Stream
	{
		int num = 0;
		int num2;
		do
		{
			switch (((int_2 ^ char_0) - 72) ^ num)
			{
			case 0:
				gparam_0.Write(byte_0, int_0, int_1);
				break;
			}
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static bool smethod_4<T>(T gparam_0, int int_0, short short_0) where T : XAttribute
	{
		int num = 0;
		bool result;
		int num2;
		do
		{
			result = (((short_0 ^ int_0) - 12) ^ num) switch
			{
				0 => ((XAttribute)gparam_0).get_IsNamespaceDeclaration(), 
				_ => true, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_5<T>(T gparam_0, bool bool_0, char char_0, short short_0) where T : WindowsFormsApplicationBase
	{
		int num = 0;
		switch (((short_0 ^ char_0) - 47) ^ 0)
		{
		case 0:
			((WindowsFormsApplicationBase)gparam_0).set_SaveMySettingsOnExit(bool_0);
			break;
		}
		num++;
	}

	[SecuritySafeCritical]
	internal static string smethod_6<T>(T gparam_0, int int_0, int int_1) where T : Exception
	{
		int num = 0;
		string result = (((int_1 ^ int_0) - 103) ^ 0) switch
		{
			0 => (string)(IComparable)gparam_0.Message, 
			_ => null, 
		};
		num++;
		return result;
	}
}
