using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.Zip;
using ns0;
using ns3;

namespace ns1;

internal sealed class Class7 : ReportSender
{
	private struct Struct1
	{
		public readonly string string_0;

		public readonly string string_1;

		public readonly string string_2;

		public readonly int int_0;
	}

	private struct Struct2
	{
		public readonly string string_0;

		public readonly string string_1;

		public Struct2(string string_2, string string_3)
		{
			string_0 = string_2;
			string_1 = string_3;
		}
	}

	private struct Struct3
	{
		public string string_0;

		public Struct2 struct2_0;

		[SpecialName]
		public bool method_0()
		{
			return string_0.Length == 0;
		}

		[SpecialName]
		public static Struct3 smethod_0()
		{
			return new Struct3(string.Empty, string.Empty, string.Empty);
		}

		private Struct3(string string_1, string string_2, string string_3)
		{
			string_0 = string_1;
			struct2_0 = new Struct2(string_2, string_3);
		}
	}

	[NonSerialized]
	internal static GetString getString_1;

	private readonly Exception exception_0;

	private readonly Guid guid_0;

	private readonly char[] char_0 = new char[0];

	private readonly Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();

	private readonly Dictionary<string, Struct1> dictionary_1 = new Dictionary<string, Struct1>();

	private readonly XmlWriter xmlWriter_0;

	private readonly List<Class11> list_0 = new List<Class11>();

	private readonly List<string> list_1 = new List<string>();

	private readonly Dictionary<string, int> dictionary_2 = new Dictionary<string, int>();

	private readonly List<Struct2> list_2 = new List<Struct2>();

	private readonly Dictionary<string, int> dictionary_3 = new Dictionary<string, int>();

	private readonly MemoryStream memoryStream_0;

	private byte[] byte_0;

	private FatalExceptionEventHandler fatalExceptionEventHandler_0;

	private EventHandler eventHandler_0;

	static Class7()
	{
		Strings.CreateGetStringDelegate(typeof(Class7));
	}

	public Class7(Guid guid_1, Exception exception_1, IWebProxy iwebProxy_1)
	{
		guid_0 = guid_1;
		exception_0 = exception_1;
		memoryStream_0 = new MemoryStream();
		xmlWriter_0 = new XmlTextWriter(memoryStream_0, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		SetProxy(iwebProxy_1);
		string text;
		if ((text = getString_1(1270).ToUpper()) == null)
		{
			return;
		}
		if (!(text == getString_1(1270)))
		{
			if (text == getString_1(1279))
			{
				char_0 = new char[58]
				{
					'\u0001', '\u0002', '\u0003', '\u0004', '\u0005', '\u0006', '\a', '\b', '\u000e', '\u000f',
					'\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017', '\u0018', '\u0019',
					'\u001a', '\u001b', '\u001c', '\u001d', '\u001e', '\u001f', '\u007f', '\u0080', '\u0081', '\u0082',
					'\u0083', '\u0084', '\u0086', '\u0087', '\u0088', '\u0089', '\u008a', '\u008b', '\u008c', '\u008d',
					'\u008e', '\u008f', '\u0090', '\u0091', '\u0092', '\u0093', '\u0094', '\u0095', '\u0096', '\u0097',
					'\u0098', '\u0099', '\u009a', '\u009b', '\u009c', '\u009d', '\u009e', '\u009f'
				};
			}
		}
		else
		{
			char_0 = new char[62]
			{
				'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
				'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
				'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D',
				'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
				'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X',
				'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7',
				'8', '9'
			};
		}
	}

	private static string smethod_0(object object_0)
	{
		try
		{
			if (object_0 == null)
			{
				return string.Empty;
			}
			if (object_0 is int num)
			{
				return num.ToString(getString_1(1292));
			}
			if (object_0 is long num2)
			{
				return num2.ToString(getString_1(1292));
			}
			if (object_0 is short num3)
			{
				return num3.ToString(getString_1(1292));
			}
			if (object_0 is uint num4)
			{
				return num4.ToString(getString_1(1292));
			}
			if (object_0 is ulong num5)
			{
				return num5.ToString(getString_1(1292));
			}
			if (object_0 is ushort num6)
			{
				return num6.ToString(getString_1(1292));
			}
			if (object_0 is byte b)
			{
				return b.ToString(getString_1(1292));
			}
			if (object_0 is sbyte b2)
			{
				return b2.ToString(getString_1(1292));
			}
			if (object_0 is IntPtr intPtr)
			{
				return intPtr.ToInt64().ToString(getString_1(1292));
			}
			if (object_0 is UIntPtr)
			{
				return ((UIntPtr)object_0).ToUInt64().ToString(getString_1(1292));
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	private static string smethod_1(string string_0)
	{
		if (string_0.StartsWith(getString_1(1297)) && string_0.EndsWith(getString_1(1318)))
		{
			return getString_1(1339);
		}
		return string_0;
	}

	private void method_1(Class11 class11_0, FieldInfo fieldInfo_0)
	{
		string text = fieldInfo_0?.Name;
		string string_ = (((object)fieldInfo_0 == null) ? getString_1(1421) : getString_1(1412));
		object obj = class11_0.method_1();
		if (obj == null)
		{
			using (new Class14(xmlWriter_0, string_))
			{
				if ((object)fieldInfo_0 != null)
				{
					if (fieldInfo_0.IsStatic)
					{
						xmlWriter_0.WriteAttributeString(getString_1(1430), getString_1(1439));
					}
					Type fieldType = fieldInfo_0.FieldType;
					if ((object)fieldType != null && fieldType.HasElementType)
					{
						method_5(fieldType.GetElementType());
						if (fieldType.IsByRef)
						{
							xmlWriter_0.WriteAttributeString(getString_1(1444), getString_1(1439));
						}
						if (fieldType.IsPointer)
						{
							xmlWriter_0.WriteAttributeString(getString_1(1453), getString_1(1439));
						}
						if (fieldType.IsArray)
						{
							xmlWriter_0.WriteAttributeString(getString_1(1466), fieldType.GetArrayRank().ToString());
						}
					}
					else
					{
						method_5(fieldType);
					}
				}
				if (text != null)
				{
					method_3(text);
				}
				xmlWriter_0.WriteAttributeString(getString_1(1475), getString_1(1439));
				return;
			}
		}
		Type type = class11_0.method_1().GetType();
		string text2 = null;
		string text3 = null;
		if (obj is string)
		{
			text2 = getString_1(1484);
		}
		if (text2 == null)
		{
			if (!type.IsPrimitive && !(obj is IntPtr) && !(obj is UIntPtr))
			{
				if (type.IsValueType && (object)type.Module != GetType().Module)
				{
					text2 = type.FullName;
				}
			}
			else
			{
				text2 = type.FullName;
				if (obj is int num)
				{
					StringBuilder stringBuilder = new StringBuilder();
					if (num >= 32)
					{
						stringBuilder.Append('\'');
						stringBuilder.Append((char)obj);
						stringBuilder.Append(getString_1(1505));
					}
					stringBuilder.Append(getString_1(1510));
					stringBuilder.Append(num.ToString(getString_1(1292)));
					stringBuilder.Append(')');
					text3 = stringBuilder.ToString();
				}
				if (obj is bool)
				{
					text3 = obj.ToString()!.ToLower();
				}
				if (text3 == null)
				{
					string text4 = smethod_0(obj);
					if (text4.Length > 0)
					{
						StringBuilder stringBuilder2 = new StringBuilder();
						stringBuilder2.Append(obj.ToString());
						stringBuilder2.Append(getString_1(1515));
						stringBuilder2.Append(text4);
						stringBuilder2.Append(')');
						text3 = stringBuilder2.ToString();
					}
					else
					{
						text3 = obj.ToString();
					}
				}
			}
		}
		using (new Class14(xmlWriter_0, string_))
		{
			if ((object)fieldInfo_0 != null && fieldInfo_0.IsStatic)
			{
				xmlWriter_0.WriteAttributeString(getString_1(1430), getString_1(1439));
			}
			if (text2 != null)
			{
				method_5(type);
				if (text != null)
				{
					method_3(text);
				}
				if (type.IsEnum)
				{
					text3 = obj.ToString();
				}
				if (obj is Guid)
				{
					text3 = string.Concat(getString_1(511), obj, getString_1(1524));
				}
				if (text3 == null)
				{
					text3 = string.Concat(getString_1(1529), obj, getString_1(1529));
				}
				xmlWriter_0.WriteAttributeString(getString_1(1534), smethod_1(text3));
			}
			else
			{
				if ((object)fieldInfo_0 != null)
				{
					method_5(fieldInfo_0.FieldType);
				}
				method_2(class11_0);
				if (text != null)
				{
					method_3(text);
				}
			}
		}
	}

	private void method_2(Class11 class11_0)
	{
		object objB = class11_0.method_1();
		int num = -1;
		for (int i = 0; i < list_0.Count; i++)
		{
			if (object.ReferenceEquals(list_0[i].method_1(), objB))
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			num = list_0.Count;
			list_0.Add(class11_0);
		}
		xmlWriter_0.WriteAttributeString(getString_1(1543), num.ToString());
	}

	private void method_3(string string_0)
	{
		int num = method_6(string_0);
		if (num != -1)
		{
			xmlWriter_0.WriteAttributeString(getString_1(1548), num.ToString());
		}
		else
		{
			xmlWriter_0.WriteAttributeString(getString_1(1557), string_0);
		}
	}

	private static Struct3 smethod_2(Type type_0)
	{
		Struct3 result = Struct3.smethod_0();
		if ((object)type_0 != null && (object)type_0.Assembly.GetType(getString_1(1566)) != null)
		{
			result.string_0 = ((type_0.MetadataToken & 0xFFFFFF) - 1).ToString();
			Assembly assembly = type_0.Assembly;
			result.struct2_0 = new Struct2(assembly.ManifestModule.ModuleVersionId.ToString(getString_1(1627)), assembly.FullName);
		}
		return result;
	}

	private int method_4(Struct3 struct3_0)
	{
		string key = struct3_0.struct2_0.string_0.ToUpper();
		if (dictionary_3.ContainsKey(key))
		{
			return dictionary_3[key];
		}
		int count = list_2.Count;
		list_2.Add(struct3_0.struct2_0);
		dictionary_3.Add(key, count);
		return count;
	}

	private void method_5(Type type_0)
	{
		if ((object)type_0 == null)
		{
			return;
		}
		try
		{
			Struct3 struct3_ = smethod_2(type_0);
			if (!struct3_.method_0())
			{
				xmlWriter_0.WriteAttributeString(getString_1(1632), struct3_.string_0);
				int num = method_4(struct3_);
				if (num > 0)
				{
					xmlWriter_0.WriteAttributeString(getString_1(1645), num.ToString());
				}
				return;
			}
			string fullName = type_0.FullName;
			int value;
			if (dictionary_2.ContainsKey(fullName))
			{
				value = dictionary_2[fullName];
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				string name = type_0.Assembly.GetName().Name;
				if (name.Length > 0 && name != getString_1(1658))
				{
					stringBuilder.Append('[');
					stringBuilder.Append(name);
					stringBuilder.Append(']');
				}
				string @namespace = type_0.Namespace;
				if (@namespace.Length > 0)
				{
					stringBuilder.Append(@namespace);
					stringBuilder.Append('.');
				}
				if (type_0.HasElementType)
				{
					type_0 = type_0.GetElementType();
				}
				int num2 = fullName.LastIndexOf(getString_1(1671));
				if (num2 > 0)
				{
					string value2 = fullName.Substring(@namespace.Length + 1, num2 - @namespace.Length).Replace(getString_1(1671), getString_1(1676));
					stringBuilder.Append(value2);
				}
				stringBuilder.Append(type_0.Name);
				value = list_1.Count;
				list_1.Add(stringBuilder.ToString());
				dictionary_2.Add(fullName, value);
			}
			xmlWriter_0.WriteAttributeString(getString_1(1681), value.ToString());
		}
		catch
		{
		}
	}

	private int method_6(string string_0)
	{
		try
		{
			bool flag = char_0[0] == '\u0001';
			if (string_0 != null && string_0.Length != 0 && (!flag || string_0.Length <= 4) && (flag || string_0[0] == '#'))
			{
				int num = 0;
				int num2 = string_0.Length - 1;
				while (true)
				{
					if (num2 >= 0 && (flag || num2 != 0))
					{
						char c = string_0[num2];
						bool flag2 = false;
						for (int i = 0; i < char_0.Length; i++)
						{
							if (char_0[i] == c)
							{
								num = num * char_0.Length + i;
								flag2 = true;
								break;
							}
						}
						if (!flag2)
						{
							break;
						}
						num2--;
						continue;
					}
					return num;
				}
				return -1;
			}
			return -1;
		}
		catch
		{
			return -1;
		}
	}

	private static string smethod_3()
	{
		try
		{
			return Application.get_ExecutablePath();
		}
		catch
		{
			return getString_1(1694);
		}
	}

	private Assembly[] method_7()
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { smethod_4() };
		}
	}

	private static Assembly smethod_4()
	{
		try
		{
			return Assembly.GetExecutingAssembly();
		}
		catch
		{
			return null;
		}
	}

	private byte[] method_8()
	{
		if (byte_0 != null)
		{
			return byte_0;
		}
		xmlWriter_0.WriteStartDocument();
		using (new Class14(xmlWriter_0, getString_1(1699)))
		{
			xmlWriter_0.WriteAttributeString(getString_1(1732), getString_1(1212).ToUpper());
			xmlWriter_0.WriteAttributeString(getString_1(1749), DateTime.Now.ToString(getString_1(1762)));
			xmlWriter_0.WriteAttributeString(getString_1(436), smethod_3());
			if (guid_0 != Guid.Empty)
			{
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = getString_1(1767);
				Guid guid = guid_0;
				xmlWriter.WriteAttributeString(localName, guid.ToString(getString_1(1627)));
			}
			xmlWriter_0.WriteAttributeString(getString_1(1776), Guid.NewGuid().ToString(getString_1(1627)));
			if (list_2.Count > 0)
			{
				list_2.Clear();
			}
			list_2.Add(new Struct2(getString_1(1212), string.Empty));
			if (dictionary_3.Count > 0)
			{
				dictionary_3.Clear();
			}
			dictionary_3.Add(getString_1(1212), 0);
			using (new Class14(xmlWriter_0, getString_1(1789)))
			{
				Assembly assembly = smethod_4();
				Assembly[] array = method_7();
				foreach (Assembly assembly2 in array)
				{
					if ((object)assembly2 == null)
					{
						continue;
					}
					using (new Class14(xmlWriter_0, getString_1(1645)))
					{
						try
						{
							xmlWriter_0.WriteAttributeString(getString_1(1557), assembly2.FullName);
							xmlWriter_0.WriteAttributeString(getString_1(1806), assembly2.CodeBase);
							if ((object)assembly2 == assembly)
							{
								xmlWriter_0.WriteAttributeString(getString_1(1819), getString_1(1439));
							}
						}
						catch
						{
						}
					}
				}
			}
			using (new Class14(xmlWriter_0, getString_1(1828)))
			{
				if (dictionary_0 != null && dictionary_0.Count > 0)
				{
					foreach (string key in dictionary_0.Keys)
					{
						using (new Class14(xmlWriter_0, getString_1(1853)))
						{
							xmlWriter_0.WriteAttributeString(getString_1(1557), key);
							string text = (string)dictionary_0[key];
							if (text == null)
							{
								xmlWriter_0.WriteAttributeString(getString_1(1475), getString_1(1439));
							}
							else
							{
								xmlWriter_0.WriteAttributeString(getString_1(1534), getString_1(1529) + text + getString_1(1529));
							}
						}
					}
				}
			}
			if (dictionary_1 != null && dictionary_1.Count > 0)
			{
				using (new Class14(xmlWriter_0, getString_1(1874)))
				{
					foreach (string key2 in dictionary_1.Keys)
					{
						using (new Class14(xmlWriter_0, getString_1(1895)))
						{
							xmlWriter_0.WriteAttributeString(getString_1(1912), key2);
							Struct1 @struct = dictionary_1[key2];
							xmlWriter_0.WriteAttributeString(getString_1(1917), @struct.string_0);
							XmlWriter xmlWriter2 = xmlWriter_0;
							string localName2 = getString_1(1930);
							int int_ = @struct.int_0;
							xmlWriter2.WriteAttributeString(localName2, int_.ToString());
							if (@struct.string_2.Length > 0)
							{
								xmlWriter_0.WriteAttributeString(getString_1(1939), @struct.string_2);
							}
							else
							{
								xmlWriter_0.WriteAttributeString(getString_1(1948), @struct.string_1);
							}
						}
					}
				}
			}
			using (new Class14(xmlWriter_0, getString_1(1957)))
			{
				try
				{
					xmlWriter_0.WriteElementString(getString_1(1982), Environment.Version.ToString());
					xmlWriter_0.WriteElementString(getString_1(1999), Environment.OSVersion.Version.ToString());
					xmlWriter_0.WriteElementString(getString_1(2012), Environment.OSVersion.Platform.ToString());
					xmlWriter_0.WriteElementString(getString_1(2029), Win32.smethod_4());
					xmlWriter_0.WriteElementString(getString_1(2046), Win32.smethod_2() ? getString_1(1439) : getString_1(2059));
					xmlWriter_0.WriteElementString(getString_1(2064), Win32.smethod_1() ? getString_1(1439) : getString_1(2059));
					xmlWriter_0.WriteElementString(getString_1(2069), Win32.smethod_3() ? getString_1(1439) : getString_1(2059));
				}
				catch
				{
				}
			}
			List<Exception> list = new List<Exception>();
			for (Exception innerException = exception_0; innerException != null; innerException = innerException.InnerException)
			{
				list.Add(innerException);
			}
			list.Reverse();
			using (new Class14(xmlWriter_0, getString_1(2086)))
			{
				foreach (Exception item in list)
				{
					try
					{
						method_11(item);
						if (!item.Data.Contains(getString_1(2103)))
						{
							continue;
						}
						ICollection collection = (ICollection)item.Data[getString_1(2103)];
						int count = collection.Count;
						int num = 0;
						foreach (object item2 in collection)
						{
							try
							{
								Type type = item2.GetType();
								num++;
								if (num > 100 && num == count - 100)
								{
									using (new Class14(xmlWriter_0, getString_1(2128)))
									{
										xmlWriter_0.WriteAttributeString(getString_1(2149), count.ToString());
									}
								}
								else
								{
									if (num > 100 && num <= count - 100)
									{
										continue;
									}
									int num2 = (int)type.GetField(getString_1(2174))!.GetValue(item2);
									int num3 = (int)type.GetField(getString_1(2187))!.GetValue(item2);
									int num4 = (int)type.GetField(getString_1(2200))!.GetValue(item2);
									object[] array2 = (object[])type.GetField(getString_1(2229))!.GetValue(item2);
									Struct3 struct3_ = smethod_2(type);
									if (struct3_.method_0())
									{
										continue;
									}
									using (new Class14(xmlWriter_0, getString_1(2242)))
									{
										xmlWriter_0.WriteAttributeString(getString_1(2174), num2.ToString());
										xmlWriter_0.WriteAttributeString(getString_1(2200), num4.ToString());
										int num5 = method_4(struct3_);
										if (num5 > 0)
										{
											xmlWriter_0.WriteAttributeString(getString_1(1645), num5.ToString());
										}
										if (num3 != -1)
										{
											xmlWriter_0.WriteAttributeString(getString_1(2187), num3.ToString());
										}
										object[] array3 = array2;
										foreach (object object_ in array3)
										{
											try
											{
												method_1(new Class11(object_, bool_1: true), null);
											}
											catch
											{
											}
										}
									}
									continue;
								}
							}
							catch
							{
							}
						}
					}
					catch
					{
					}
				}
			}
			method_9();
			using (new Class14(xmlWriter_0, getString_1(2259)))
			{
				xmlWriter_0.WriteAttributeString(getString_1(2272), list_1.Count.ToString());
				for (int k = 0; k < list_1.Count; k++)
				{
					string value;
					try
					{
						value = list_1[k].ToString();
					}
					catch (Exception ex)
					{
						value = '"' + ex.Message + '"';
					}
					xmlWriter_0.WriteElementString(getString_1(1681), value);
				}
			}
			using (new Class14(xmlWriter_0, getString_1(2281)))
			{
				xmlWriter_0.WriteAttributeString(getString_1(2272), list_2.Count.ToString());
				for (int l = 0; l < list_2.Count; l++)
				{
					using (new Class14(xmlWriter_0, getString_1(1732)))
					{
						Struct2 struct2 = list_2[l];
						xmlWriter_0.WriteAttributeString(getString_1(1543), struct2.string_0);
						if (struct2.string_1.Length > 0)
						{
							xmlWriter_0.WriteAttributeString(getString_1(2298), struct2.string_1);
						}
					}
				}
			}
		}
		xmlWriter_0.WriteEndDocument();
		xmlWriter_0.Flush();
		memoryStream_0.Flush();
		byte_0 = memoryStream_0.ToArray();
		return byte_0;
	}

	private void method_9()
	{
		using (new Class14(xmlWriter_0, getString_1(2229)))
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				Class11 @class = list_0[i];
				object obj = @class.method_1();
				Type type = @class.method_2();
				using (new Class14(xmlWriter_0, getString_1(2311)))
				{
					xmlWriter_0.WriteAttributeString(getString_1(1543), i.ToString());
					string text = null;
					try
					{
						text = obj.ToString();
						text = ((text == type.FullName) ? null : (type.IsEnum ? Enum.Format(type, obj, getString_1(2324)) : ((!(obj is Guid)) ? (getString_1(1529) + text + getString_1(1529)) : (getString_1(511) + text + getString_1(1524)))));
					}
					catch
					{
					}
					if (text != null)
					{
						xmlWriter_0.WriteAttributeString(getString_1(1534), smethod_1(text));
					}
					if (type.HasElementType)
					{
						method_5(type.GetElementType());
						if (type.IsByRef)
						{
							xmlWriter_0.WriteAttributeString(getString_1(1444), getString_1(1439));
						}
						if (type.IsPointer)
						{
							xmlWriter_0.WriteAttributeString(getString_1(1453), getString_1(1439));
						}
						if (!type.IsArray)
						{
							continue;
						}
						Array array = (Array)obj;
						xmlWriter_0.WriteAttributeString(getString_1(1466), array.Rank.ToString());
						StringBuilder stringBuilder = new StringBuilder();
						for (int j = 0; j < array.Rank; j++)
						{
							if (j > 0)
							{
								stringBuilder.Append(',');
							}
							stringBuilder.Append(array.GetLength(j));
						}
						xmlWriter_0.WriteAttributeString(getString_1(1930), stringBuilder.ToString());
						if (array.Rank != 1)
						{
							continue;
						}
						int length = array.Length;
						for (int k = 0; k < length; k++)
						{
							if (k == 10 && length > 16)
							{
								k = length - 5;
							}
							try
							{
								method_1(new Class11(array.GetValue(k), bool_1: false), null);
							}
							catch
							{
							}
						}
						continue;
					}
					method_5(type);
					if (!@class.method_0())
					{
						continue;
					}
					bool flag = true;
					string[] array2 = getString_1(2329).Split(new char[1] { ',' });
					foreach (string text2 in array2)
					{
						if (text2 != getString_1(2329) && type.FullName!.StartsWith(text2))
						{
							flag = false;
							break;
						}
					}
					object[] customAttributes = type.GetCustomAttributes(inherit: true);
					for (int m = 0; m < customAttributes.Length; m++)
					{
						Attribute attribute = (Attribute)customAttributes[m];
						if (!(attribute.GetType().Name != getString_1(2330)))
						{
							flag = false;
							break;
						}
					}
					if (!flag)
					{
						continue;
					}
					try
					{
						if (obj is IEnumerable)
						{
							using (new Class14(xmlWriter_0, getString_1(2367)))
							{
								int num = 0;
								foreach (object item in (IEnumerable)obj)
								{
									if (num <= 20)
									{
										method_1(new Class11(item, bool_1: false), null);
										num++;
										continue;
									}
									xmlWriter_0.WriteElementString(getString_1(2384), string.Empty);
									break;
								}
							}
						}
					}
					catch
					{
					}
					method_10(@class);
				}
			}
		}
	}

	private void method_10(Class11 class11_0)
	{
		FieldInfo[] fields = class11_0.method_2().GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		FieldInfo[] array = fields;
		foreach (FieldInfo fieldInfo in array)
		{
			try
			{
				if (!fieldInfo.IsLiteral && (!fieldInfo.IsStatic || !fieldInfo.IsInitOnly))
				{
					method_1(new Class11(fieldInfo.GetValue(class11_0.method_1()), bool_1: false), fieldInfo);
				}
			}
			catch
			{
			}
		}
		class11_0 = new Class11(class11_0.method_1(), class11_0.method_2().BaseType, class11_0.method_0());
		if ((object)class11_0.method_2() != null)
		{
			using (new Class14(xmlWriter_0, getString_1(1412)))
			{
				method_3(getString_1(2393));
				xmlWriter_0.WriteAttributeString(getString_1(1543), list_0.Count.ToString());
			}
			list_0.Add(class11_0);
		}
	}

	private void method_11(Exception exception_1)
	{
		using (new Class14(xmlWriter_0, getString_1(2402)))
		{
			try
			{
				Type type = exception_1.GetType();
				method_5(type);
				string value = getString_1(1694);
				try
				{
					value = exception_1.Message;
				}
				catch
				{
				}
				xmlWriter_0.WriteAttributeString(getString_1(2415), value);
				string text = exception_1.StackTrace!.Trim();
				xmlWriter_0.WriteAttributeString(getString_1(2428), text);
				int num = text.IndexOf(' ');
				text = text.Substring(num + 1);
				num = text.IndexOf(getString_1(2457));
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				xmlWriter_0.WriteAttributeString(getString_1(2462), text);
				method_2(new Class11(exception_1, bool_1: true));
			}
			catch
			{
			}
		}
	}

	internal bool method_12()
	{
		try
		{
			InvokeSendingReportFeedback(SendingReportStep.PreparingReport);
			byte[] array;
			try
			{
				array = method_8();
			}
			catch (Exception ex)
			{
				int num = -1;
				try
				{
					StackTrace stackTrace = new StackTrace(ex);
					if (stackTrace.FrameCount > 0)
					{
						StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
						num = frame.GetILOffset();
					}
				}
				catch
				{
				}
				InvokeSendingReportFeedback(SendingReportStep.PreparingReport, string.Format(getString_1(2471), ex.Message, num));
				return false;
			}
			Class10 class10_ = new Class10(getString_1(2329), getString_1(2504), getString_1(2513));
			return method_0(array, class10_);
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception exception_)
		{
			method_14(new FatalExceptionEventArgs(exception_));
			return false;
		}
	}

	[SpecialName]
	public void method_13(FatalExceptionEventHandler fatalExceptionEventHandler_1)
	{
		FatalExceptionEventHandler fatalExceptionEventHandler = fatalExceptionEventHandler_0;
		FatalExceptionEventHandler fatalExceptionEventHandler2;
		do
		{
			fatalExceptionEventHandler2 = fatalExceptionEventHandler;
			FatalExceptionEventHandler value = (FatalExceptionEventHandler)Delegate.Combine(fatalExceptionEventHandler2, fatalExceptionEventHandler_1);
			fatalExceptionEventHandler = Interlocked.CompareExchange(ref fatalExceptionEventHandler_0, value, fatalExceptionEventHandler2);
		}
		while ((object)fatalExceptionEventHandler != fatalExceptionEventHandler2);
	}

	public void method_14(FatalExceptionEventArgs fatalExceptionEventArgs_0)
	{
		fatalExceptionEventHandler_0?.Invoke(this, fatalExceptionEventArgs_0);
	}

	[SpecialName]
	public void method_15(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal void method_16()
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			method_17(tempFileName);
			string path = Class4.smethod_0();
			Process.Start(Path.Combine(path, getString_1(2558)), getString_1(2583) + tempFileName + getString_1(1529));
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, EventArgs.Empty);
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception exception_)
		{
			method_14(new FatalExceptionEventArgs(exception_));
		}
	}

	internal bool method_17(string string_0)
	{
		try
		{
			byte[] array = method_8();
			byte[] array2;
			try
			{
				array2 = SimpleZip.Zip(array);
			}
			catch
			{
				array2 = null;
			}
			byte[] array3 = Class6.smethod_0(array2, getString_1(832));
			FileStream fileStream = File.OpenWrite(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes(getString_1(1212));
			fileStream.Write(bytes, 0, bytes.Length);
			fileStream.Write(array3, 0, array3.Length);
			fileStream.Close();
			return true;
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
