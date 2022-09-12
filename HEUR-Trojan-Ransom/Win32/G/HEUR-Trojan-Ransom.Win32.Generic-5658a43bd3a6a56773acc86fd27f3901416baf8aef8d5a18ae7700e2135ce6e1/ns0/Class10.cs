using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.MyServices;

namespace ns0;

internal sealed class Class10
{
	internal sealed class Class11
	{
		[SecuritySafeCritical]
		internal static void smethod_0<T>(T gparam_0, char char_0, int int_0)
		{
			int num = 0;
			switch (((char_0 ^ int_0) - 112) ^ 0)
			{
			case 0:
				Monitor.Exit(gparam_0);
				break;
			case 1:
				Monitor.Enter(gparam_0);
				break;
			case 2:
				ObjectFlowControl.CheckForSyncLockOnValueType((object)gparam_0);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static void smethod_1(char char_0, int int_0)
		{
			int num = 0;
			do
			{
				switch (((int_0 ^ char_0) - 63) ^ num)
				{
				case 1:
					ProjectData.EndApp();
					break;
				case 0:
					ProjectData.ClearProjectError();
					break;
				}
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static void smethod_2<T>(T gparam_0, SizeF sizeF_0, int int_0, int int_1) where T : ContainerControl
		{
			int num = 0;
			switch (((int_1 ^ int_0) - 74) ^ 0)
			{
			case 0:
				((ContainerControl)gparam_0).set_AutoScaleDimensions(sizeF_0);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static void smethod_3<T>(T gparam_0, ref bool bool_0, int int_0, char char_0)
		{
			int num = 0;
			switch (((char_0 ^ int_0) - 23) ^ 0)
			{
			case 0:
				Monitor.Enter(gparam_0, ref bool_0);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static Assembly smethod_4<T>(T gparam_0, char char_0, char char_1) where T : ResolveEventArgs
		{
			int num = 0;
			Assembly result;
			do
			{
				result = (((char_1 ^ char_0) - 1) ^ num) switch
				{
					0 => (Assembly)(ICustomAttributeProvider)gparam_0.RequestingAssembly, 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_5<T, U, V>(U gparam_0, T gparam_1, V gparam_2, char char_0, int int_0) where T : string where U : AppDomain
		{
			int num = 0;
			do
			{
				switch (((char_0 ^ int_0) - 56) ^ num)
				{
				case 0:
					gparam_0.SetData(gparam_1, gparam_2);
					break;
				}
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static SpecialDirectoriesProxy smethod_6<T>(T gparam_0, short short_0, short short_1) where T : FileSystemProxy
		{
			int num = 0;
			SpecialDirectoriesProxy result;
			int num2;
			do
			{
				result = (SpecialDirectoriesProxy)((((short_0 ^ short_1) - 67) ^ num) switch
				{
					0 => ((FileSystemProxy)gparam_0).get_SpecialDirectories(), 
					_ => null, 
				});
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static string smethod_7<T>(T gparam_0, string[] string_0, int int_0, short short_0) where T : string
		{
			int num = 0;
			string result;
			do
			{
				result = (((int_0 ^ short_0) - 74) ^ num) switch
				{
					0 => (string)(IComparable<string>)Utils.GetResourceString((string)gparam_0, string_0), 
					_ => null, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_8<T, U>(U gparam_0, T gparam_1, int int_0, short short_0) where U : XObject
		{
			int num = 0;
			do
			{
				switch (((short_0 ^ int_0) - 111) ^ num)
				{
				case 0:
					((XObject)gparam_0).AddAnnotation((object)gparam_1);
					break;
				}
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static string smethod_9<T>(T gparam_0, short short_0, char char_0) where T : Exception
		{
			int num = 0;
			string result = (((char_0 ^ short_0) - 30) ^ 0) switch
			{
				0 => (string)(IEquatable<string>)gparam_0.Message, 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_10<T>(T gparam_0, short short_0, char char_0) where T : Exception
		{
			int num = 0;
			switch (((char_0 ^ short_0) - 36) ^ 0)
			{
			case 0:
				ProjectData.SetProjectError((Exception)gparam_0);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static void smethod_11<T, U>(U gparam_0, T gparam_1, int int_0, char char_0) where T : EventHandler where U : Form
		{
			int num = 0;
			do
			{
				switch (((int_0 ^ char_0) - 97) ^ num)
				{
				case 0:
					((Form)gparam_0).add_Load((EventHandler)gparam_1);
					break;
				}
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static XAttribute smethod_12<T, U>(U gparam_0, T gparam_1, char char_0, short short_0) where T : XName where U : XElement
		{
			int num = 0;
			XAttribute result;
			int num2;
			do
			{
				result = (XAttribute)((((char_0 ^ short_0) - 39) ^ num) switch
				{
					0 => ((XElement)gparam_0).Attribute((XName)(object)gparam_1), 
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
		internal static bool smethod_13<T, U>(U gparam_0, T gparam_1, char char_0, int int_0)
		{
			int num = 0;
			bool result;
			int num2;
			do
			{
				result = (((char_0 ^ int_0) - 61) ^ num) switch
				{
					0 => object.ReferenceEquals(gparam_0, gparam_1), 
					_ => true, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_0<T, U, V>(T gparam_0, V gparam_1, U gparam_2, char char_0, char char_1) where T : ResourceManager where U : CultureInfo where V : string
	{
		int num = 0;
		object result;
		do
		{
			result = (((char_1 ^ char_0) - 27) ^ num) switch
			{
				0 => gparam_0.GetObject(gparam_1, gparam_2), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static Process smethod_1<T>(T gparam_0, short short_0, char char_0) where T : string
	{
		int num = 0;
		Process result;
		int num2;
		do
		{
			result = (((char_0 ^ short_0) - 72) ^ num) switch
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
	internal static string smethod_2<T>(T gparam_0, short short_0, int int_0) where T : XAttribute
	{
		int num = 0;
		string result = (((short_0 ^ int_0) - 30) ^ 0) switch
		{
			0 => (string)(XAttribute)(object)gparam_0, 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static string smethod_3<T, U>(U gparam_0, T gparam_1, char char_0, char char_1) where T : string where U : string
	{
		int num = 0;
		string result = (((char_0 ^ char_1) - 75) ^ 0) switch
		{
			0 => string.Concat(gparam_0, gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_4<T>(T gparam_0, Size size_0, short short_0, int int_0) where T : Form
	{
		int num = 0;
		switch (((short_0 ^ int_0) - 122) ^ 0)
		{
		case 0:
			((Form)gparam_0).set_ClientSize(size_0);
			break;
		}
		num++;
	}

	[SecuritySafeCritical]
	internal static bool smethod_5<T, U>(T gparam_0, U gparam_1, int int_0, int int_1) where T : XNamespace where U : XNamespace
	{
		int num = 0;
		bool result = (((int_0 ^ int_1) - 24) ^ 0) switch
		{
			0 => (XNamespace)(object)gparam_0 == (XNamespace)(object)gparam_1, 
			_ => false, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_6<T, U>(T gparam_0, U gparam_1, int int_0, int int_1) where T : Form where U : string
	{
		int num = 0;
		switch (((int_1 ^ int_0) - 80) ^ 0)
		{
		case 0:
			((Form)gparam_0).set_Text((string)gparam_1);
			break;
		}
		num++;
	}

	[SecuritySafeCritical]
	internal static int smethod_7<T>(T gparam_0, char char_0, int int_0) where T : string
	{
		int num = 0;
		int result = (((char_0 ^ int_0) - 126) ^ 0) switch
		{
			0 => Strings.Asc((string)gparam_0), 
			1 => Strings.Len((string)gparam_0), 
			_ => int_0, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static string smethod_8<T>(T gparam_0, char char_0, short short_0) where T : XName
	{
		int num = 0;
		string result;
		do
		{
			result = (((char_0 ^ short_0) - 72) ^ num) switch
			{
				0 => (string)(IComparable)((XName)gparam_0).get_LocalName(), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_9<T>(T gparam_0, bool bool_0, short short_0, short short_1) where T : WindowsFormsApplicationBase
	{
		int num = 0;
		do
		{
			switch (((short_1 ^ short_0) - 27) ^ num)
			{
			case 0:
				((WindowsFormsApplicationBase)gparam_0).set_SaveMySettingsOnExit(bool_0);
				break;
			}
			num++;
		}
		while ((short_1 * short_1 + short_1) % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static void smethod_10<T>(T gparam_0, int int_0, char char_0) where T : Control
	{
		int num = 0;
		do
		{
			switch (((int_0 ^ char_0) - 0) ^ num)
			{
			case 0:
				((Control)gparam_0).SuspendLayout();
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static string smethod_11<T>(T gparam_0, short short_0, int int_0) where T : XNamespace
	{
		int num = 0;
		string result = (((int_0 ^ short_0) - 124) ^ 0) switch
		{
			0 => (string)(IConvertible)((XNamespace)gparam_0).get_NamespaceName(), 
			_ => null, 
		};
		num++;
		return result;
	}
}
