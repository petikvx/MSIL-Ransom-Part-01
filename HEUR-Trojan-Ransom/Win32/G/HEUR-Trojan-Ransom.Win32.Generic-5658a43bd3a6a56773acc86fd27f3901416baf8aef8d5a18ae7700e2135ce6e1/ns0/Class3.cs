using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;

namespace ns0;

[EditorBrowsable(EditorBrowsableState.Never)]
internal sealed class Class3
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	private sealed class Class4
	{
		private Class12.Class14.Class15.Class16 class16_0 = new Class12.Class14.Class15.Class16();

		internal string[] string_0;

		internal XNamespace[] xnamespace_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Class4(string[] string_1, XNamespace[] xnamespace_1, List<XAttribute> list_0)
		{
			string[] array = (string_0 = (string[])(ICollection)string_1);
			XNamespace[] array2 = (xnamespace_0 = (XNamespace[])(IStructuralComparable)xnamespace_1);
			class16_0.list_0 = list_0;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal XElement method_0(XElement xelement_0)
		{
			return (XElement)(IXmlSerializable)smethod_4(string_0, xnamespace_0, class16_0.list_0, xelement_0);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal object method_1(object object_0)
		{
			XElement val = (XElement)((object_0 is XElement) ? object_0 : null);
			if (val != null)
			{
				return smethod_4(string_0, xnamespace_0, class16_0.list_0, val);
			}
			return object_0;
		}

		[SecuritySafeCritical]
		static Class4()
		{
			Class5.Class6.smethod_0();
		}
	}

	internal sealed class Class5
	{
		internal sealed class Class6
		{
			private static bool bool_0;

			[SecuritySafeCritical]
			internal static void smethod_0()
			{
				if (bool_0)
				{
					return;
				}
				Type gparam_;
				Class10.Class11.smethod_0((object)(gparam_ = (Type)(IReflect)typeof(Class6)), 'Ǧ', 407);
				try
				{
					if (!bool_0)
					{
						bool_0 = true;
						Class12.Class13.smethod_3<AppDomain, ResolveEventHandler>(Class12.Class13.smethod_1(728, 685), Class7.smethod_1, 483, 455);
					}
				}
				finally
				{
					Class10.Class11.smethod_0((object)gparam_, 'š', 273);
				}
			}

			[SecuritySafeCritical]
			internal static string smethod_1<T, U>(T gparam_0, U gparam_1, char char_0, char char_1) where T : string where U : string
			{
				int num = 0;
				string result;
				do
				{
					result = (((char_0 ^ char_1) - 83) ^ num) switch
					{
						0 => (string)(IEnumerable<char>)Class10.smethod_3((string)gparam_0, (string)gparam_1, '\u0360', '\u032b'), 
						_ => null, 
					};
					num++;
				}
				while ((char_0 * char_0 + char_0) % 2 != 0);
				return result;
			}

			[SecuritySafeCritical]
			internal static void smethod_2<T>(T gparam_0, Size size_0, int int_0, int int_1) where T : Form
			{
				int num = 0;
				switch (((int_0 ^ int_1) - 43) ^ 0)
				{
				case 0:
					Class10.smethod_4<Form>((Form)(object)gparam_0, size_0, (short)498, 392);
					break;
				}
				num++;
			}

			[SecuritySafeCritical]
			internal static FileSystemProxy smethod_3<T>(T gparam_0, char char_0, int int_0) where T : ServerComputer
			{
				int num = 0;
				FileSystemProxy result;
				int num2;
				do
				{
					result = (FileSystemProxy)((((int_0 ^ char_0) - 89) ^ num) switch
					{
						0 => Class12.smethod_4<ServerComputer>((ServerComputer)(object)gparam_0, (short)960, (short)926), 
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
			internal static char smethod_4(int int_0, int int_1, char char_0)
			{
				int num = 0;
				char result = (((int_1 ^ char_0) - 108) ^ 0) switch
				{
					0 => Class12.smethod_5(int_0, 67, 31), 
					_ => char_0, 
				};
				num++;
				return result;
			}

			[SecuritySafeCritical]
			internal static string smethod_5<T>(T gparam_0, char char_0, char char_1) where T : XElement
			{
				int num = 0;
				string result = (((char_1 ^ char_0) - 79) ^ 0) switch
				{
					0 => (string)(IEnumerable)Class12.Class14.smethod_5<XElement>((XElement)(object)gparam_0, (short)501, (short)511), 
					_ => null, 
				};
				num++;
				return result;
			}

			[SecuritySafeCritical]
			internal static XAttribute smethod_6<T>(T gparam_0, char char_0, char char_1) where T : XAttribute
			{
				int num = 0;
				XAttribute result;
				int num2;
				do
				{
					result = (XAttribute)((((char_0 ^ char_1) - 12) ^ num) switch
					{
						0 => Class12.Class14.smethod_6<XAttribute>((XAttribute)(object)gparam_0, (short)942, 'ζ'), 
						_ => null, 
					});
					num++;
					num2 = char_1 * char_1;
					num2 = char_1 + num2;
				}
				while (num2 % 2 != 0);
				return result;
			}

			[SecuritySafeCritical]
			internal static bool smethod_7<T, U>(U gparam_0, T gparam_1, short short_0, int int_0) where U : Hashtable
			{
				int num = 0;
				bool result = (((int_0 ^ short_0) - 108) ^ 0) switch
				{
					0 => Class12.smethod_6((Hashtable)gparam_0, (object)gparam_1, (short)199, (short)176), 
					_ => true, 
				};
				num++;
				return result;
			}

			[SecuritySafeCritical]
			internal static string smethod_8<T>(T gparam_0, string[] string_0, int int_0, int int_1) where T : string
			{
				int num = 0;
				string result = (((int_0 ^ int_1) - 4) ^ 0) switch
				{
					0 => (string)(IEnumerable<char>)Class10.Class11.smethod_7((string)gparam_0, string_0, 835, (short)777), 
					_ => null, 
				};
				num++;
				return result;
			}

			[SecuritySafeCritical]
			internal static void smethod_9<T, U, V>(T gparam_0, V gparam_1, U gparam_2, int int_0, int int_1) where T : Hashtable
			{
				int num = 0;
				switch (((int_0 ^ int_1) - 83) ^ 0)
				{
				case 0:
					Class12.Class13.smethod_7((Hashtable)gparam_0, (object)gparam_1, (object)gparam_2, 'Ű', 344);
					break;
				}
				num++;
			}

			[SecuritySafeCritical]
			internal static string smethod_10<T>(T gparam_0, short short_0, short short_1) where T : Exception
			{
				int num = 0;
				string result = (((short_0 ^ short_1) - 1) ^ 0) switch
				{
					0 => (string)(ICloneable)Class10.Class11.smethod_9((Exception)gparam_0, (short)427, 'Ƶ'), 
					_ => null, 
				};
				num++;
				return result;
			}
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 330)]
		private struct Struct0
		{
		}

		private static readonly object object_0;

		private static readonly Array array_0;

		private static readonly object object_1;

		internal static byte byte_0/* Not supported: data(00) */;

		[SecuritySafeCritical]
		internal static SettingsBase smethod_0<T>(T gparam_0, short short_0, char char_0) where T : SettingsBase
		{
			int num = 0;
			SettingsBase result;
			do
			{
				result = (SettingsBase)((((char_0 ^ short_0) - 83) ^ num) switch
				{
					0 => Class12.Class13.smethod_8<SettingsBase>((SettingsBase)(object)gparam_0, 304, 'Ĳ'), 
					_ => null, 
				});
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static bool smethod_1<T>(T gparam_0, int int_0, int int_1) where T : WindowsFormsApplicationBase
		{
			int num = 0;
			bool result = (((int_0 ^ int_1) - 106) ^ 0) switch
			{
				0 => Class12.Class14.smethod_8<WindowsFormsApplicationBase>((WindowsFormsApplicationBase)(object)gparam_0, 'T', 112), 
				_ => true, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_2<T>(T gparam_0, int int_0, int int_1) where T : ApplicationSettingsBase
		{
			int num = 0;
			switch (((int_1 ^ int_0) - 42) ^ 0)
			{
			case 0:
				Class12.Class14.smethod_9<ApplicationSettingsBase>((ApplicationSettingsBase)(object)gparam_0, 160, 160);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static void smethod_3<T, U>(T gparam_0, U gparam_1, short short_0, char char_0) where T : WindowsFormsApplicationBase where U : ShutdownEventHandler
		{
			int num = 0;
			switch (((short_0 ^ char_0) - 100) ^ 0)
			{
			case 0:
				Class12.Class13.smethod_9<ShutdownEventHandler, WindowsFormsApplicationBase>((WindowsFormsApplicationBase)(object)gparam_0, (ShutdownEventHandler)(object)gparam_1, (short)606, 'ɋ');
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static object smethod_4<T, U>(U gparam_0, T gparam_1, int int_0, char char_0) where T : string where U : AppDomain
		{
			int num = 0;
			object result;
			int num2;
			do
			{
				result = (((char_0 ^ int_0) - 26) ^ num) switch
				{
					0 => Class12.smethod_3((AppDomain)gparam_0, (string)gparam_1, (short)352, (short)315), 
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
		internal static Assembly smethod_5(byte[] byte_1, byte[] byte_2, SecurityContextSource securityContextSource_0, char char_0, char char_1)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			int num = 0;
			Assembly result = (((char_0 ^ char_1) - 127) ^ 0) switch
			{
				0 => (Assembly)(_Assembly)Class12.Class13.smethod_12(byte_1, byte_2, securityContextSource_0, 38, 29), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_6<T, U>(T gparam_0, U gparam_1, int int_0, int int_1) where T : Form where U : EventHandler
		{
			int num = 0;
			switch (((int_0 ^ int_1) - 46) ^ 0)
			{
			case 0:
				Class10.Class11.smethod_11<EventHandler, Form>((Form)(object)gparam_0, (EventHandler)gparam_1, 429, 'ǌ');
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static int smethod_7<T>(T gparam_0, int int_0, int int_1) where T : string
		{
			int num = 0;
			int result = (((int_0 ^ int_1) - 86) ^ 0) switch
			{
				0 => Class10.smethod_7((string)gparam_0, 'ˆ', 696), 
				1 => Class10.smethod_7((string)gparam_0, 'C', 60), 
				_ => 8, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static XAttribute smethod_8<T, U>(T gparam_0, U gparam_1, char char_0, char char_1) where T : XElement where U : XName
		{
			int num = 0;
			XAttribute result;
			do
			{
				result = (XAttribute)((((char_0 ^ char_1) - 98) ^ num) switch
				{
					0 => (IXmlLineInfo)Class10.Class11.smethod_12<XName, XElement>((XElement)(object)gparam_0, (XName)(object)gparam_1, 'ϵ', (short)978), 
					_ => null, 
				});
				num++;
			}
			while ((char_1 * char_1 + char_1) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static XAttribute smethod_9<T>(T gparam_0, char char_0, short short_0) where T : XElement
		{
			int num = 0;
			XAttribute result;
			int num2;
			do
			{
				result = (XAttribute)((((short_0 ^ char_0) - 102) ^ num) switch
				{
					0 => Class12.Class13.smethod_14<XElement>((XElement)(object)gparam_0, (short)932, (short)907), 
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
		internal static bool smethod_10<T>(T gparam_0, char char_0, short short_0) where T : XAttribute
		{
			int num = 0;
			bool result;
			do
			{
				result = (((char_0 ^ short_0) - 64) ^ num) switch
				{
					0 => Class12.Class13.smethod_15<XAttribute>((XAttribute)(object)gparam_0, 945, 'Γ'), 
					_ => true, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static XName smethod_11<T>(T gparam_0, char char_0, char char_1) where T : XAttribute
		{
			int num = 0;
			XName result = (XName)((((char_0 ^ char_1) - 4) ^ 0) switch
			{
				0 => (IEquatable<XName>)Class12.Class14.smethod_11<XAttribute>((XAttribute)(object)gparam_0, '\u008c', 'Õ'), 
				_ => null, 
			});
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static string smethod_12<T>(T gparam_0, char char_0, int int_0) where T : XName
		{
			int num = 0;
			string result;
			do
			{
				result = (((char_0 ^ int_0) - 120) ^ num) switch
				{
					0 => (string)(IEquatable<string>)Class10.smethod_8<XName>((XName)(object)gparam_0, 'Ɓ', (short)457), 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_13<T>(T gparam_0, short short_0, int int_0) where T : Exception
		{
			int num = 0;
			int num2;
			do
			{
				switch (((short_0 ^ int_0) - 46) ^ num)
				{
				case 0:
					Class10.Class11.smethod_10((Exception)gparam_0, (short)772, '\u0320');
					break;
				}
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static void smethod_14<T>(T gparam_0, string[] string_0, int int_0, int int_1) where T : WindowsFormsApplicationBase
		{
			int num = 0;
			switch (((int_1 ^ int_0) - 85) ^ 0)
			{
			case 0:
				Class12.smethod_8<WindowsFormsApplicationBase>((WindowsFormsApplicationBase)(object)gparam_0, string_0, (short)206, 154);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static void smethod_15<T>(T gparam_0, bool bool_0, short short_0, char char_0) where T : WindowsFormsApplicationBase
		{
			int num = 0;
			switch (((short_0 ^ char_0) - 0) ^ 0)
			{
			case 0:
				Class10.smethod_9<WindowsFormsApplicationBase>((WindowsFormsApplicationBase)(object)gparam_0, bool_0, (short)220, (short)199);
				break;
			}
			num++;
		}

		static Class5()
		{
			array_0 = new char[165];
			char[] array = new char[8];
			array[5] = '㨡';
			array[6] = '\u0c01';
			array[0] = '㐎';
			array[4] = '㿓';
			array[1] = 'ᮺ';
			array[2] = '㿻';
			array[3] = '⥱';
			array[7] = '\u02d5';
			object_1 = new string[9];
			object_0 = array;
		}
	}

	public static string this[IEnumerable<XElement> ienumerable_0]
	{
		get
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			using (IEnumerator<XElement> enumerator = ienumerable_0.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XElement gparam_ = enumerator.Current;
					return (string)(IComparable)Class5.Class6.smethod_5<XElement>(gparam_, 'ʾ', '\u02f1');
				}
			}
			return null;
		}
		set
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			using IEnumerator<XElement> enumerator = ienumerable_0.GetEnumerator();
			if (enumerator.MoveNext())
			{
				XElement gparam_ = enumerator.Current;
				Class7.Class8.smethod_10<string, XElement>(gparam_, value, 'K', 29);
			}
		}
	}

	public static string this[IEnumerable<XElement> ienumerable_0, XName xname_0]
	{
		get
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			using (IEnumerator<XElement> enumerator = ienumerable_0.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XElement gparam_ = (XElement)(XNode)enumerator.Current;
					return (string)(IEnumerable)Class7.Class8.smethod_11<XAttribute>(Class5.smethod_8<XElement, XName>(gparam_, xname_0, 'Ɵ', 'ǽ'), 666, 'ʁ');
				}
			}
			return null;
		}
		set
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			using IEnumerator<XElement> enumerator = ienumerable_0.GetEnumerator();
			if (enumerator.MoveNext())
			{
				XElement gparam_ = enumerator.Current;
				Class7.Class8.smethod_12<XElement, XName, object>(gparam_, xname_0, (object)value, 'ŀ', 346);
			}
		}
	}

	public static string this[XElement xelement_0, XName xname_0]
	{
		get
		{
			return (string)(IComparable)Class7.Class8.smethod_11<XAttribute>(Class5.smethod_8<XElement, XName>(xelement_0, xname_0, '\u0334', '\u0356'), 63, '$');
		}
		set
		{
			Class7.Class8.smethod_12<XElement, XName, object>(xelement_0, xname_0, (object)value, 'Ǯ', 500);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	private Class3()
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XAttribute smethod_0(XName xname_0, object object_0)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		if (object_0 == null)
		{
			return null;
		}
		return new XAttribute(xname_0, smethod_5(object_0, 165, 'ò'));
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XAttribute smethod_1(XName xname_0, XNamespace xnamespace_0)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		XAttribute val = new XAttribute(xname_0, (object)Class3.smethod_17<XNamespace>(xnamespace_0, (short)290, (short)290));
		Class7.smethod_10<object, XObject>((XObject)(object)val, (object)xnamespace_0, '6', 'l');
		return val;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static object smethod_2(string[] string_0, XNamespace[] xnamespace_0, List<XAttribute> list_0, object object_0)
	{
		if (object_0 != null)
		{
			XElement val = (XElement)((object_0 is XElement) ? object_0 : null);
			if (val != null)
			{
				return smethod_4(string_0, xnamespace_0, list_0, val);
			}
			if (object_0 is IEnumerable ienumerable_)
			{
				return smethod_3(string_0, xnamespace_0, list_0, ienumerable_);
			}
		}
		return object_0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static IEnumerable smethod_3(string[] string_0, XNamespace[] xnamespace_0, List<XAttribute> list_0, IEnumerable ienumerable_0)
	{
		if (ienumerable_0 != null)
		{
			if (ienumerable_0 is IEnumerable<XElement> source)
			{
				return source.Select(new Class4(string_0, xnamespace_0, list_0).method_0);
			}
			return ienumerable_0.Cast<object>().Select(new Class4(string_0, xnamespace_0, list_0).method_1);
		}
		return ienumerable_0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XElement smethod_4(string[] string_0, XNamespace[] xnamespace_0, List<XAttribute> list_0, XElement xelement_0)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		checked
		{
			if (xelement_0 != null)
			{
				XAttribute val = Class5.smethod_9<XElement>(xelement_0, '\u0099', (short)255);
				while (val != null)
				{
					XAttribute val2 = Class5.Class6.smethod_6<XAttribute>(val, 'ː', '\u02dc');
					if (Class5.smethod_10<XAttribute>(val, 'c', (short)35))
					{
						XNamespace val3 = ((XObject)val).Annotation<XNamespace>();
						string gparam_ = (string)(IEnumerable)Class5.smethod_12<XName>(Class5.smethod_11<XAttribute>(val, 'ħ', 'ģ'), 'V', 46);
						if (val3 != null)
						{
							if ((string_0 != null && xnamespace_0 != null) ? true : false)
							{
								int num = string_0.Length - 1;
								int num2 = num;
								int num3 = 0;
								while (true)
								{
									int num4 = num3;
									int num5 = num2;
									if (num4 > num5)
									{
										break;
									}
									string gparam_2 = string_0[num3];
									XNamespace gparam_3 = xnamespace_0[num3];
									if (!Class7.smethod_11(gparam_, gparam_2, 221, 178))
									{
										num3++;
										continue;
									}
									if (Class7.smethod_12<XNamespace, XNamespace>(val3, gparam_3, 'ƣ', 452))
									{
										Class3.smethod_18<XAttribute>(val, 69, ';');
									}
									val = null;
									break;
								}
							}
							if (val != null)
							{
								if (list_0 != null)
								{
									int num6 = list_0.Count - 1;
									int num7 = num6;
									int num8 = 0;
									while (true)
									{
										int num9 = num8;
										int num5 = num7;
										if (num9 > num5)
										{
											break;
										}
										XAttribute val4 = list_0[num8];
										string gparam_4 = (string)(IEquatable<string>)Class5.smethod_12<XName>(Class5.smethod_11<XAttribute>(val4, 'Ì', 'È'), '\u0345', 829);
										XNamespace val5 = ((XObject)val4).Annotation<XNamespace>();
										if (val5 == null || !Class7.smethod_11(gparam_, gparam_4, 302, 321))
										{
											num8++;
											continue;
										}
										if (Class7.smethod_12<XNamespace, XNamespace>(val3, val5, 'İ', 343))
										{
											Class3.smethod_18<XAttribute>(val, 481, 'Ɵ');
										}
										val = null;
										break;
									}
								}
								if (val != null)
								{
									Class12.Class13.smethod_16<XAttribute>(val, 'Ʃ', 507);
									list_0.Add(val);
								}
							}
						}
					}
					val = val2;
				}
			}
			return (XElement)(IXmlSerializable)xelement_0;
		}
	}

	[SecuritySafeCritical]
	static Class3()
	{
		Class5.Class6.smethod_0();
	}

	[SecuritySafeCritical]
	internal static object smethod_5<T>(T gparam_0, int int_0, char char_0)
	{
		int num = 0;
		object result = (((char_0 ^ int_0) - 87) ^ 0) switch
		{
			0 => Class12.Class13.smethod_17((object)gparam_0, 599, 'ɇ'), 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_6<T>(T gparam_0, char char_0, short short_0)
	{
		int num = 0;
		switch (((char_0 ^ short_0) - 109) ^ 0)
		{
		case 0:
			Class10.Class11.smethod_0((object)gparam_0, 'Ĉ', 378);
			break;
		case 1:
			Class10.Class11.smethod_0((object)gparam_0, '\u02e7', 663);
			break;
		}
		num++;
	}

	[SecuritySafeCritical]
	internal static bool smethod_7<T, U>(T gparam_0, U gparam_1, char char_0, int int_0)
	{
		int num = 0;
		bool result = (((int_0 ^ char_0) - 75) ^ 0) switch
		{
			0 => Class10.Class11.smethod_13((object)gparam_0, (object)gparam_1, 'Ñ', 236), 
			_ => false, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_8<T>(T gparam_0, int int_0, int int_1) where T : Type
	{
		int num = 0;
		Assembly result = (((int_1 ^ int_0) - 126) ^ 0) switch
		{
			0 => Class12.smethod_9((Type)gparam_0, 1019, 946), 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static bool smethod_9<T, U>(U gparam_0, T gparam_1, char char_0, short short_0) where T : Assembly where U : Assembly
	{
		int num = 0;
		bool result;
		do
		{
			result = (((short_0 ^ char_0) - 52) ^ num) switch
			{
				0 => Class12.Class14.smethod_12((Assembly)gparam_0, (Assembly)gparam_1, 'Æ', (short)196), 
				_ => true, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static int smethod_10<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, char char_0, int int_2) where T : Stream
	{
		int num = 0;
		int result = (((int_2 ^ char_0) - 71) ^ 0) switch
		{
			0 => Class12.smethod_10((Stream)gparam_0, byte_0, int_0, int_1, (short)85, 'v'), 
			_ => int_0, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static string[] smethod_11<T>(T gparam_0, int int_0, int int_1) where T : Assembly
	{
		int num = 0;
		string[] result = (((int_1 ^ int_0) - 100) ^ 0) switch
		{
			0 => Class12.Class13.smethod_18((Assembly)gparam_0, 443, (short)456), 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static bool smethod_12<T>(T gparam_0, short short_0, int int_0) where T : WeakReference
	{
		int num = 0;
		bool result = (((short_0 ^ int_0) - 87) ^ 0) switch
		{
			0 => Class12.Class14.smethod_13((WeakReference)gparam_0, 662, '\u02ed'), 
			_ => false, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_13<T>(T gparam_0, char char_0, char char_1) where T : Control
	{
		int num = 0;
		do
		{
			switch (((char_1 ^ char_0) - 31) ^ num)
			{
			case 0:
				Class10.smethod_10<Control>((Control)(object)gparam_0, 400, 'Ɛ');
				break;
			}
			num++;
		}
		while ((char_1 * char_1 + char_1) % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static void smethod_14<T, U>(T gparam_0, U gparam_1, char char_0, char char_1) where T : Control where U : string
	{
		int num = 0;
		do
		{
			switch (((char_0 ^ char_1) - 125) ^ num)
			{
			case 0:
				Class12.Class14.smethod_14<Control, string>((Control)(object)gparam_0, (string)gparam_1, 'v', 49);
				break;
			}
			num++;
		}
		while ((char_1 * char_1 + char_1) % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static string smethod_15<T>(T gparam_0, int int_0, int int_1) where T : SpecialDirectoriesProxy
	{
		int num = 0;
		string result = (((int_0 ^ int_1) - 99) ^ 0) switch
		{
			0 => (string)(IEquatable<string>)Class12.Class14.smethod_15<SpecialDirectoriesProxy>((SpecialDirectoriesProxy)(object)gparam_0, (short)638, 545), 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static string smethod_16<T>(T gparam_0, int int_0, short short_0)
	{
		int num = 0;
		string result;
		do
		{
			result = (((short_0 ^ int_0) - 37) ^ num) switch
			{
				0 => (string)(ICloneable)Class12.Class13.smethod_10((object)gparam_0, 983, (short)965), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static string smethod_17<T>(T gparam_0, short short_0, short short_1) where T : XNamespace
	{
		int num = 0;
		string result = (((short_0 ^ short_1) - 0) ^ 0) switch
		{
			0 => (string)(IEnumerable<char>)Class10.smethod_11<XNamespace>((XNamespace)(object)gparam_0, (short)737, 669), 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_18<T>(T gparam_0, int int_0, char char_0) where T : XAttribute
	{
		int num = 0;
		switch (((int_0 ^ char_0) - 126) ^ 0)
		{
		case 0:
			Class12.Class13.smethod_16<XAttribute>((XAttribute)(object)gparam_0, 'Ķ', 356);
			break;
		}
		num++;
	}
}
