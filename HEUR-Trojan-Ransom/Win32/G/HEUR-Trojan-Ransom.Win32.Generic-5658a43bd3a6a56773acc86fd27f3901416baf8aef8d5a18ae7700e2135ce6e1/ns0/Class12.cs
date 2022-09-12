using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;

namespace ns0;

internal sealed class Class12
{
	internal sealed class Class13
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
		private struct Struct6
		{
		}

		private static readonly Array array_0;

		private static readonly Array array_1;

		private static readonly object object_0;

		internal static byte byte_0/* Not supported: data(00) */;

		[SecuritySafeCritical]
		internal static Assembly smethod_0(short short_0, short short_1)
		{
			int num = 0;
			Assembly result = (((short_0 ^ short_1) - 114) ^ 0) switch
			{
				0 => Assembly.GetExecutingAssembly(), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static AppDomain smethod_1(int int_0, short short_0)
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			int num = 0;
			AppDomain result = (((int_0 ^ short_0) - 117) ^ 0) switch
			{
				0 => (AppDomain)(IEvidenceFactory)AppDomain.CurrentDomain, 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_2<T, U, V>(T gparam_0, V gparam_1, U gparam_2, char char_0, short short_0) where T : XElement where V : XName
		{
			int num = 0;
			switch (((short_0 ^ char_0) - 54) ^ 0)
			{
			case 0:
				((XElement)gparam_0).SetAttributeValue((XName)(object)gparam_1, (object)gparam_2);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static void smethod_3<T, U>(T gparam_0, U gparam_1, int int_0, short short_0) where T : AppDomain where U : ResolveEventHandler
		{
			int num = 0;
			switch (((short_0 ^ int_0) - 36) ^ 0)
			{
			case 0:
				gparam_0.ResourceResolve += gparam_1;
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static string smethod_4<T>(T gparam_0, char char_0, int int_0) where T : ResolveEventArgs
		{
			int num = 0;
			string result;
			do
			{
				result = (((int_0 ^ char_0) - 3) ^ num) switch
				{
					0 => gparam_0.Name, 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static byte[] smethod_5<T>(T gparam_0, int int_0, int int_1) where T : MemoryStream
		{
			int num = 0;
			byte[] result = (((int_1 ^ int_0) - 1) ^ 0) switch
			{
				0 => gparam_0.ToArray(), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static string smethod_6(char char_0, short short_0, short short_1)
		{
			int num = 0;
			string result;
			do
			{
				result = (((short_1 ^ short_0) - 38) ^ num) switch
				{
					0 => Conversions.ToString(char_0), 
					_ => null, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_7<T, U, V>(T gparam_0, V gparam_1, U gparam_2, char char_0, int int_0) where T : Hashtable
		{
			int num = 0;
			int num2;
			do
			{
				switch (((char_0 ^ int_0) - 40) ^ num)
				{
				case 0:
					gparam_0.Add(gparam_1, gparam_2);
					break;
				}
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static SettingsBase smethod_8<T>(T gparam_0, int int_0, char char_0) where T : SettingsBase
		{
			int num = 0;
			SettingsBase result;
			int num2;
			do
			{
				result = (SettingsBase)((((int_0 ^ char_0) - 2) ^ num) switch
				{
					0 => SettingsBase.Synchronized((SettingsBase)(object)gparam_0), 
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
		internal static void smethod_9<T, U>(U gparam_0, T gparam_1, short short_0, char char_0) where T : ShutdownEventHandler where U : WindowsFormsApplicationBase
		{
			int num = 0;
			do
			{
				switch (((short_0 ^ char_0) - 21) ^ num)
				{
				case 0:
					((WindowsFormsApplicationBase)gparam_0).add_Shutdown((ShutdownEventHandler)(object)gparam_1);
					break;
				}
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static string smethod_10<T>(T gparam_0, int int_0, short short_0)
		{
			int num = 0;
			string result = (((short_0 ^ int_0) - 17) ^ 0) switch
			{
				0 => gparam_0.ToString(), 
				1 => Conversions.ToString((object)gparam_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_11<T>(T gparam_0, bool bool_0, char char_0, short short_0) where T : Control
		{
			int num = 0;
			int num2;
			do
			{
				switch (((char_0 ^ short_0) - 88) ^ num)
				{
				case 0:
					((Control)gparam_0).ResumeLayout(bool_0);
					break;
				}
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static Assembly smethod_12(byte[] byte_1, byte[] byte_2, SecurityContextSource securityContextSource_0, short short_0, short short_1)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			Assembly result;
			int num2;
			do
			{
				result = (((short_0 ^ short_1) - 59) ^ num) switch
				{
					0 => Assembly.Load(byte_1, byte_2, securityContextSource_0), 
					_ => null, 
				};
				num++;
				num2 = short_1 * short_1;
				num2 = short_1 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static Exception smethod_13(int int_0, short short_0, short short_1)
		{
			int num = 0;
			Exception result = (((short_1 ^ short_0) - 97) ^ 0) switch
			{
				0 => ProjectData.CreateProjectError(int_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static XAttribute smethod_14<T>(T gparam_0, short short_0, short short_1) where T : XElement
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			int num = 0;
			XAttribute result;
			do
			{
				result = (XAttribute)((((short_1 ^ short_0) - 47) ^ num) switch
				{
					0 => (object)(XObject)((XElement)gparam_0).get_FirstAttribute(), 
					_ => null, 
				});
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static bool smethod_15<T>(T gparam_0, int int_0, char char_0) where T : XAttribute
		{
			int num = 0;
			bool result = (((char_0 ^ int_0) - 34) ^ 0) switch
			{
				0 => ((XAttribute)gparam_0).get_IsNamespaceDeclaration(), 
				_ => false, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_16<T>(T gparam_0, char char_0, int int_0) where T : XAttribute
		{
			int num = 0;
			do
			{
				switch (((char_0 ^ int_0) - 82) ^ num)
				{
				case 0:
					((XAttribute)gparam_0).Remove();
					break;
				}
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static object smethod_17<T>(T gparam_0, int int_0, char char_0)
		{
			int num = 0;
			object result = (((char_0 ^ int_0) - 16) ^ 0) switch
			{
				0 => RuntimeHelpers.GetObjectValue(gparam_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static string[] smethod_18<T>(T gparam_0, int int_0, short short_0) where T : Assembly
		{
			int num = 0;
			string[] result;
			int num2;
			do
			{
				result = (((int_0 ^ short_0) - 115) ^ num) switch
				{
					0 => (string[])(Array)gparam_0.GetManifestResourceNames(), 
					_ => null, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		static Class13()
		{
			array_1 = new char[39];
			char[] array = new char[8];
			array[7] = 'Θ';
			array[2] = 'ㄾ';
			array[6] = 'ᱟ';
			array[5] = '᠘';
			array[3] = '☥';
			array[4] = 'ዹ';
			array[0] = '㨇';
			array[1] = 'ࡔ';
			object_0 = new string[1];
			array_0 = array;
		}
	}

	internal sealed class Class14
	{
		internal sealed class Class15
		{
			internal sealed class Class16
			{
				internal List<XAttribute> list_0;

				internal Class16()
				{
				}
			}
		}

		[SecuritySafeCritical]
		internal static void smethod_0<T>(T gparam_0, AutoScaleMode autoScaleMode_0, char char_0, short short_0) where T : ContainerControl
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			switch (((char_0 ^ short_0) - 54) ^ 0)
			{
			case 0:
				((ContainerControl)gparam_0).set_AutoScaleMode(autoScaleMode_0);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static void smethod_1<T, U>(U gparam_0, T gparam_1, int int_0, char char_0) where U : Hashtable
		{
			int num = 0;
			switch (((int_0 ^ char_0) - 17) ^ 0)
			{
			case 0:
				gparam_0.Remove(gparam_1);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static void smethod_2<T>(T gparam_0, byte[] byte_0, short short_0, char char_0) where T : string
		{
			int num = 0;
			do
			{
				switch (((short_0 ^ char_0) - 74) ^ num)
				{
				case 0:
					File.WriteAllBytes(gparam_0, byte_0);
					break;
				}
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static string smethod_3<T>(T gparam_0, int int_0, int int_1, short short_0, short short_1) where T : string
		{
			int num = 0;
			string result = (((short_0 ^ short_1) - 107) ^ 0) switch
			{
				0 => Strings.Mid((string)gparam_0, int_0, int_1), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_4<T, U>(T gparam_0, U gparam_1, short short_0, int int_0) where T : XElement where U : string
		{
			int num = 0;
			int num2;
			do
			{
				switch (((int_0 ^ short_0) - 18) ^ num)
				{
				case 0:
					((XElement)gparam_0).set_Value((string)gparam_1);
					break;
				}
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static string smethod_5<T>(T gparam_0, short short_0, short short_1) where T : XElement
		{
			int num = 0;
			string result;
			int num2;
			do
			{
				result = (((short_0 ^ short_1) - 10) ^ num) switch
				{
					0 => (string)(IEnumerable<char>)((XElement)gparam_0).get_Value(), 
					_ => null, 
				};
				num++;
				num2 = short_1 * short_1;
				num2 = short_1 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static XAttribute smethod_6<T>(T gparam_0, short short_0, char char_0) where T : XAttribute
		{
			int num = 0;
			XAttribute result = (XAttribute)((((char_0 ^ short_0) - 24) ^ 0) switch
			{
				0 => ((XAttribute)gparam_0).get_NextAttribute(), 
				_ => null, 
			});
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static bool smethod_7<T, U>(T gparam_0, U gparam_1, int int_0, char char_0) where T : string where U : string
		{
			int num = 0;
			bool result;
			int num2;
			do
			{
				result = (((char_0 ^ int_0) - 6) ^ num) switch
				{
					0 => gparam_0.Equals(gparam_1), 
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
		internal static bool smethod_8<T>(T gparam_0, char char_0, int int_0) where T : WindowsFormsApplicationBase
		{
			int num = 0;
			bool result = (((int_0 ^ char_0) - 36) ^ 0) switch
			{
				0 => ((WindowsFormsApplicationBase)gparam_0).get_SaveMySettingsOnExit(), 
				_ => true, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_9<T>(T gparam_0, int int_0, int int_1) where T : ApplicationSettingsBase
		{
			int num = 0;
			switch (((int_1 ^ int_0) - 0) ^ 0)
			{
			case 0:
				((ApplicationSettingsBase)gparam_0).Save();
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static StringBuilder smethod_10<T>(T gparam_0, char char_0, short short_0, short short_1) where T : StringBuilder
		{
			int num = 0;
			StringBuilder result;
			do
			{
				result = (((short_0 ^ short_1) - 70) ^ num) switch
				{
					0 => gparam_0.Append(char_0), 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static XName smethod_11<T>(T gparam_0, char char_0, char char_1) where T : XAttribute
		{
			int num = 0;
			XName result = (XName)((((char_1 ^ char_0) - 89) ^ 0) switch
			{
				0 => (ISerializable)((XAttribute)gparam_0).get_Name(), 
				_ => null, 
			});
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static bool smethod_12<T, U>(U gparam_0, T gparam_1, char char_0, short short_0) where T : Assembly where U : Assembly
		{
			int num = 0;
			bool result = (((char_0 ^ short_0) - 2) ^ 0) switch
			{
				0 => (Assembly?)gparam_0 != (Assembly?)gparam_1, 
				_ => true, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static bool smethod_13<T>(T gparam_0, int int_0, char char_0) where T : WeakReference
		{
			int num = 0;
			bool result;
			do
			{
				result = (((char_0 ^ int_0) - 123) ^ num) switch
				{
					0 => gparam_0.IsAlive, 
					_ => true, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_14<T, U>(T gparam_0, U gparam_1, char char_0, int int_0) where T : Control where U : string
		{
			int num = 0;
			switch (((int_0 ^ char_0) - 71) ^ 0)
			{
			case 0:
				((Control)gparam_0).set_Name((string)gparam_1);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static string smethod_15<T>(T gparam_0, short short_0, int int_0) where T : SpecialDirectoriesProxy
		{
			int num = 0;
			string result = (((short_0 ^ int_0) - 95) ^ 0) switch
			{
				0 => ((SpecialDirectoriesProxy)gparam_0).get_Temp(), 
				_ => null, 
			};
			num++;
			return result;
		}
	}

	internal sealed class Class17
	{
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct7
	{
		internal IContainer icontainer_0;
	}

	[SecuritySafeCritical]
	internal static void smethod_0<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, char char_0, short short_0) where T : Stream
	{
		int num = 0;
		switch (((short_0 ^ char_0) - 20) ^ 0)
		{
		case 0:
			gparam_0.Write(byte_0, int_0, int_1);
			break;
		}
		num++;
	}

	[SecuritySafeCritical]
	internal static Exception smethod_1<T>(T gparam_0, int int_0, char char_0) where T : Exception
	{
		int num = 0;
		Exception result = (((int_0 ^ char_0) - 50) ^ 0) switch
		{
			0 => (Exception)(ISerializable)gparam_0.InnerException, 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_2(bool bool_0, short short_0, int int_0)
	{
		int num = 0;
		int num2;
		do
		{
			switch (((int_0 ^ short_0) - 114) ^ num)
			{
			case 0:
				Application.SetCompatibleTextRenderingDefault(bool_0);
				break;
			}
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static object smethod_3<T, U>(U gparam_0, T gparam_1, short short_0, short short_1) where T : string where U : AppDomain
	{
		int num = 0;
		object result = (((short_1 ^ short_0) - 91) ^ 0) switch
		{
			0 => gparam_0.GetData(gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static FileSystemProxy smethod_4<T>(T gparam_0, short short_0, short short_1) where T : ServerComputer
	{
		int num = 0;
		FileSystemProxy result = (FileSystemProxy)((((short_1 ^ short_0) - 94) ^ 0) switch
		{
			0 => ((ServerComputer)gparam_0).get_FileSystem(), 
			_ => null, 
		});
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static char smethod_5(int int_0, short short_0, short short_1)
	{
		int num = 0;
		char result;
		do
		{
			result = (((short_0 ^ short_1) - 92) ^ num) switch
			{
				0 => Strings.Chr(int_0), 
				_ => '\n', 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static bool smethod_6<T, U>(T gparam_0, U gparam_1, short short_0, short short_1) where T : Hashtable
	{
		int num = 0;
		bool result = (((short_0 ^ short_1) - 119) ^ 0) switch
		{
			0 => gparam_0.ContainsKey(gparam_1), 
			_ => true, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static object smethod_7<T, U>(U gparam_0, T gparam_1, int int_0, char char_0)
	{
		int num = 0;
		object result = (((int_0 ^ char_0) - 127) ^ 0) switch
		{
			0 => Operators.AddObject((object)gparam_0, (object)gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_8<T>(T gparam_0, string[] string_0, short short_0, int int_0) where T : WindowsFormsApplicationBase
	{
		int num = 0;
		switch (((short_0 ^ int_0) - 84) ^ 0)
		{
		case 0:
			((WindowsFormsApplicationBase)gparam_0).Run(string_0);
			break;
		}
		num++;
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_9<T>(T gparam_0, int int_0, int int_1) where T : Type
	{
		int num = 0;
		Assembly result = (((int_0 ^ int_1) - 73) ^ 0) switch
		{
			0 => (Assembly)(ICustomAttributeProvider)gparam_0.Assembly, 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static int smethod_10<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, short short_0, char char_0) where T : Stream
	{
		int num = 0;
		int result = (((short_0 ^ char_0) - 35) ^ 0) switch
		{
			0 => gparam_0.Read(byte_0, int_0, int_1), 
			_ => int_1, 
		};
		num++;
		return result;
	}
}
