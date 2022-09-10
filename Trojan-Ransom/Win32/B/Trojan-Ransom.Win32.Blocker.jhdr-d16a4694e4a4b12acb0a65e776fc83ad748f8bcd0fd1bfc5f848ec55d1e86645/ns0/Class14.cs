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
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.StringsEncoding;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class Class14 : ReportSender
{
	private struct Struct15
	{
		public readonly string string_0;

		public readonly string string_1;

		public readonly string string_2;

		public readonly int int_0;

		public Struct15(string string_3)
		{
			string_0 = string.Empty;
			string_1 = string.Empty;
			string_2 = string.Empty;
			int_0 = 0;
			try
			{
				FileInfo fileInfo = new FileInfo(string_3);
				string_0 = Path.GetFileName(string_3);
				int_0 = (int)fileInfo.Length;
				byte[] buffer = new byte[int_0];
				using (FileStream fileStream = File.Open(string_3, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					fileStream.Read(buffer, 0, int_0);
					fileStream.Close();
				}
				byte[] inArray;
				try
				{
					inArray = SimpleZip.Zip(buffer);
				}
				catch
				{
					inArray = null;
				}
				string_1 = Convert.ToBase64String(inArray);
			}
			catch (Exception ex)
			{
				string_2 = ex.Message;
			}
		}
	}

	private struct Struct16
	{
		public readonly string string_0;

		public readonly string string_1;

		public Struct16(string string_2, string string_3)
		{
			string_0 = string_2;
			string_1 = string_3;
		}
	}

	private struct Struct17
	{
		public string string_0;

		public Struct16 struct16_0;

		[SpecialName]
		public bool method_0()
		{
			return string_0.Length == 0;
		}

		[SpecialName]
		public static Struct17 smethod_0()
		{
			return new Struct17(string.Empty, string.Empty, string.Empty);
		}

		private Struct17(string string_1, string string_2, string string_3)
		{
			string_0 = string_1;
			struct16_0 = new Struct16(string_2, string_3);
		}
	}

	private readonly Exception exception_0;

	private readonly Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();

	private readonly Dictionary<string, Struct15> dictionary_1 = new Dictionary<string, Struct15>();

	private readonly XmlWriter xmlWriter_0;

	private readonly List<Class18> list_0 = new List<Class18>();

	private readonly List<string> list_1 = new List<string>();

	private readonly List<Struct16> list_2 = new List<Struct16>();

	private EventHandler eventHandler_0;

	internal Guid guid_0;

	internal char[] char_0 = new char[0];

	internal Dictionary<string, int> dictionary_2 = new Dictionary<string, int>();

	internal Dictionary<string, int> dictionary_3 = new Dictionary<string, int>();

	internal MemoryStream memoryStream_0;

	internal byte[] byte_0;

	internal FatalExceptionEventHandler fatalExceptionEventHandler_0;

	public Class14(Guid guid_1, Exception exception_1, IWebProxy iwebProxy_1)
	{
		Guid guid = (guid_0 = guid_1);
		exception_0 = exception_1;
		MemoryStream memoryStream = (memoryStream_0 = new MemoryStream());
		xmlWriter_0 = new XmlTextWriter(memoryStream_0, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		SetProxy(iwebProxy_1);
		string text;
		if ((text = Strings.Get(1544).ToUpper()) == null)
		{
			return;
		}
		if (!(text == Strings.Get(1557)))
		{
			if (text == Strings.Get(1544))
			{
				char[] array = (char_0 = new char[58]
				{
					'\u0001', '\u0002', '\u0003', '\u0004', '\u0005', '\u0006', '\a', '\b', '\u000e', '\u000f',
					'\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017', '\u0018', '\u0019',
					'\u001a', '\u001b', '\u001c', '\u001d', '\u001e', '\u001f', '\u007f', '\u0080', '\u0081', '\u0082',
					'\u0083', '\u0084', '\u0086', '\u0087', '\u0088', '\u0089', '\u008a', '\u008b', '\u008c', '\u008d',
					'\u008e', '\u008f', '\u0090', '\u0091', '\u0092', '\u0093', '\u0094', '\u0095', '\u0096', '\u0097',
					'\u0098', '\u0099', '\u009a', '\u009b', '\u009c', '\u009d', '\u009e', '\u009f'
				});
			}
		}
		else
		{
			char[] array2 = (char_0 = new char[62]
			{
				'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
				'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
				'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D',
				'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
				'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X',
				'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7',
				'8', '9'
			});
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
				return num.ToString(Strings.Get(1566));
			}
			if (object_0 is long num2)
			{
				return num2.ToString(Strings.Get(1566));
			}
			if (object_0 is short num3)
			{
				return num3.ToString(Strings.Get(1566));
			}
			if (object_0 is uint num4)
			{
				return num4.ToString(Strings.Get(1566));
			}
			if (object_0 is ulong num5)
			{
				return num5.ToString(Strings.Get(1566));
			}
			if (object_0 is ushort num6)
			{
				return num6.ToString(Strings.Get(1566));
			}
			if (object_0 is byte b)
			{
				return b.ToString(Strings.Get(1566));
			}
			if (object_0 is sbyte b2)
			{
				return b2.ToString(Strings.Get(1566));
			}
			if (object_0 is IntPtr intPtr)
			{
				return intPtr.ToInt64().ToString(Strings.Get(1566));
			}
			if (object_0 is UIntPtr)
			{
				return ((UIntPtr)object_0).ToUInt64().ToString(Strings.Get(1566));
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	private static string smethod_1(string string_0)
	{
		if (string_0.StartsWith(Strings.Get(1571)) && string_0.EndsWith(Strings.Get(1592)))
		{
			return Strings.Get(1613);
		}
		return string_0;
	}

	private void method_1(Class18 class18_0, FieldInfo fieldInfo_0)
	{
		string text = fieldInfo_0?.Name;
		string string_ = (((object)fieldInfo_0 == null) ? Strings.Get(1695) : Strings.Get(1686));
		object obj = class18_0.method_1();
		if (obj == null)
		{
			using (new Class23(xmlWriter_0, string_))
			{
				if ((object)fieldInfo_0 != null)
				{
					if (fieldInfo_0.IsStatic)
					{
						xmlWriter_0.WriteAttributeString(Strings.Get(1704), Strings.Get(1713));
					}
					Type fieldType = fieldInfo_0.FieldType;
					if ((object)fieldType != null && fieldType.HasElementType)
					{
						method_5(fieldType.GetElementType());
						if (fieldType.IsByRef)
						{
							xmlWriter_0.WriteAttributeString(Strings.Get(1718), Strings.Get(1713));
						}
						if (fieldType.IsPointer)
						{
							xmlWriter_0.WriteAttributeString(Strings.Get(1727), Strings.Get(1713));
						}
						if (fieldType.IsArray)
						{
							xmlWriter_0.WriteAttributeString(Strings.Get(1740), fieldType.GetArrayRank().ToString());
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
				xmlWriter_0.WriteAttributeString(Strings.Get(1749), Strings.Get(1713));
				return;
			}
		}
		Type type = class18_0.method_1().GetType();
		string text2 = null;
		string text3 = null;
		if (obj is string)
		{
			text2 = Strings.Get(1758);
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
						stringBuilder.Append(Strings.Get(1779));
					}
					stringBuilder.Append(Strings.Get(1784));
					stringBuilder.Append(num.ToString(Strings.Get(1566)));
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
						stringBuilder2.Append(Strings.Get(1789));
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
		using (new Class23(xmlWriter_0, string_))
		{
			if ((object)fieldInfo_0 != null && fieldInfo_0.IsStatic)
			{
				xmlWriter_0.WriteAttributeString(Strings.Get(1704), Strings.Get(1713));
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
					text3 = string.Concat(Strings.Get(785), obj, Strings.Get(1798));
				}
				if (text3 == null)
				{
					text3 = string.Concat(Strings.Get(1803), obj, Strings.Get(1803));
				}
				xmlWriter_0.WriteAttributeString(Strings.Get(1808), smethod_1(text3));
			}
			else
			{
				if ((object)fieldInfo_0 != null)
				{
					method_5(fieldInfo_0.FieldType);
				}
				method_2(class18_0);
				if (text != null)
				{
					method_3(text);
				}
			}
		}
	}

	private void method_2(Class18 class18_0)
	{
		object objB = class18_0.method_1();
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
			list_0.Add(class18_0);
		}
		xmlWriter_0.WriteAttributeString(Strings.Get(1817), num.ToString());
	}

	private void method_3(string string_0)
	{
		int num = method_6(string_0);
		if (num != -1)
		{
			xmlWriter_0.WriteAttributeString(Strings.Get(1822), num.ToString());
		}
		else
		{
			xmlWriter_0.WriteAttributeString(Strings.Get(1831), string_0);
		}
	}

	private static Struct17 smethod_2(Type type_0)
	{
		Struct17 result = Struct17.smethod_0();
		if ((object)type_0 != null && (object)type_0.Assembly.GetType(Strings.Get(1840)) != null)
		{
			result.string_0 = ((type_0.MetadataToken & 0xFFFFFF) - 1).ToString();
			Assembly assembly = type_0.Assembly;
			result.struct16_0 = new Struct16(assembly.ManifestModule.ModuleVersionId.ToString(Strings.Get(1901)), assembly.FullName);
		}
		return result;
	}

	private int method_4(Struct17 struct17_0)
	{
		string key = struct17_0.struct16_0.string_0.ToUpper();
		if (dictionary_3.ContainsKey(key))
		{
			return dictionary_3[key];
		}
		int count = list_2.Count;
		list_2.Add(struct17_0.struct16_0);
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
			Struct17 struct17_ = smethod_2(type_0);
			if (!struct17_.method_0())
			{
				xmlWriter_0.WriteAttributeString(Strings.Get(1906), struct17_.string_0);
				int num = method_4(struct17_);
				if (num > 0)
				{
					xmlWriter_0.WriteAttributeString(Strings.Get(1919), num.ToString());
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
				if (name.Length > 0 && name != Strings.Get(1932))
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
				int num2 = fullName.LastIndexOf(Strings.Get(1945));
				if (num2 > 0)
				{
					string value2 = fullName.Substring(@namespace.Length + 1, num2 - @namespace.Length).Replace(Strings.Get(1945), Strings.Get(1950));
					stringBuilder.Append(value2);
				}
				stringBuilder.Append(type_0.Name);
				value = list_1.Count;
				list_1.Add(stringBuilder.ToString());
				dictionary_2.Add(fullName, value);
			}
			xmlWriter_0.WriteAttributeString(Strings.Get(1955), value.ToString());
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
			return Strings.Get(1968);
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

	internal byte[] method_8()
	{
		return method_9();
	}

	private byte[] method_9()
	{
		if (byte_0 != null)
		{
			return byte_0;
		}
		xmlWriter_0.WriteStartDocument();
		using (new Class23(xmlWriter_0, Strings.Get(1973)))
		{
			xmlWriter_0.WriteAttributeString(Strings.Get(2006), Strings.Get(1486).ToUpper());
			xmlWriter_0.WriteAttributeString(Strings.Get(2023), DateTime.Now.ToString(Strings.Get(2036)));
			xmlWriter_0.WriteAttributeString(Strings.Get(710), smethod_3());
			if (guid_0 != Guid.Empty)
			{
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = Strings.Get(2041);
				Guid guid = guid_0;
				xmlWriter.WriteAttributeString(localName, guid.ToString(Strings.Get(1901)));
			}
			xmlWriter_0.WriteAttributeString(Strings.Get(2050), Guid.NewGuid().ToString(Strings.Get(1901)));
			if (list_2.Count > 0)
			{
				list_2.Clear();
			}
			list_2.Add(new Struct16(Strings.Get(1486), string.Empty));
			if (dictionary_3.Count > 0)
			{
				dictionary_3.Clear();
			}
			dictionary_3.Add(Strings.Get(1486), 0);
			using (new Class23(xmlWriter_0, Strings.Get(2063)))
			{
				Assembly assembly = smethod_4();
				Assembly[] array = method_7();
				foreach (Assembly assembly2 in array)
				{
					if ((object)assembly2 == null)
					{
						continue;
					}
					using (new Class23(xmlWriter_0, Strings.Get(1919)))
					{
						try
						{
							xmlWriter_0.WriteAttributeString(Strings.Get(1831), assembly2.FullName);
							xmlWriter_0.WriteAttributeString(Strings.Get(2080), assembly2.CodeBase);
							if ((object)assembly2 == assembly)
							{
								xmlWriter_0.WriteAttributeString(Strings.Get(2093), Strings.Get(1713));
							}
						}
						catch
						{
						}
					}
				}
			}
			using (new Class23(xmlWriter_0, Strings.Get(2102)))
			{
				if (dictionary_0 != null && dictionary_0.Count > 0)
				{
					foreach (string key in dictionary_0.Keys)
					{
						using (new Class23(xmlWriter_0, Strings.Get(2127)))
						{
							xmlWriter_0.WriteAttributeString(Strings.Get(1831), key);
							string text2 = (string)dictionary_0[key];
							if (text2 == null)
							{
								xmlWriter_0.WriteAttributeString(Strings.Get(1749), Strings.Get(1713));
							}
							else
							{
								xmlWriter_0.WriteAttributeString(Strings.Get(1808), Strings.Get(1803) + text2 + Strings.Get(1803));
							}
						}
					}
				}
			}
			if (dictionary_1 != null && dictionary_1.Count > 0)
			{
				using (new Class23(xmlWriter_0, Strings.Get(2148)))
				{
					foreach (string key2 in dictionary_1.Keys)
					{
						using (new Class23(xmlWriter_0, Strings.Get(2169)))
						{
							xmlWriter_0.WriteAttributeString(Strings.Get(2186), key2);
							Struct15 @struct = dictionary_1[key2];
							xmlWriter_0.WriteAttributeString(Strings.Get(2191), @struct.string_0);
							XmlWriter xmlWriter2 = xmlWriter_0;
							string localName2 = Strings.Get(2204);
							int int_ = @struct.int_0;
							xmlWriter2.WriteAttributeString(localName2, int_.ToString());
							if (@struct.string_2.Length > 0)
							{
								xmlWriter_0.WriteAttributeString(Strings.Get(2213), @struct.string_2);
							}
							else
							{
								xmlWriter_0.WriteAttributeString(Strings.Get(2222), @struct.string_1);
							}
						}
					}
				}
			}
			using (new Class23(xmlWriter_0, Strings.Get(2231)))
			{
				try
				{
					xmlWriter_0.WriteElementString(Strings.Get(2256), Environment.Version.ToString());
					xmlWriter_0.WriteElementString(Strings.Get(2273), Environment.OSVersion.Version.ToString());
					xmlWriter_0.WriteElementString(Strings.Get(2286), Environment.OSVersion.Platform.ToString());
					xmlWriter_0.WriteElementString(Strings.Get(2303), Win32.smethod_4());
					xmlWriter_0.WriteElementString(Strings.Get(2320), Win32.smethod_2() ? Strings.Get(1713) : Strings.Get(2333));
					xmlWriter_0.WriteElementString(Strings.Get(2338), Win32.smethod_1() ? Strings.Get(1713) : Strings.Get(2333));
					xmlWriter_0.WriteElementString(Strings.Get(2343), Win32.smethod_3() ? Strings.Get(1713) : Strings.Get(2333));
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
			using (new Class23(xmlWriter_0, Strings.Get(2360)))
			{
				foreach (Exception item in list)
				{
					try
					{
						method_12(item);
						if (!item.Data.Contains(Strings.Get(2377)))
						{
							continue;
						}
						ICollection collection = (ICollection)item.Data[Strings.Get(2377)];
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
									using (new Class23(xmlWriter_0, Strings.Get(2402)))
									{
										xmlWriter_0.WriteAttributeString(Strings.Get(2423), count.ToString());
									}
								}
								else
								{
									if (num > 100 && num <= count - 100)
									{
										continue;
									}
									int num2 = (int)type.GetField(Strings.Get(2448))!.GetValue(item2);
									int num3 = (int)type.GetField(Strings.Get(2461))!.GetValue(item2);
									int num4 = (int)type.GetField(Strings.Get(2474))!.GetValue(item2);
									object[] array2 = (object[])type.GetField(Strings.Get(2503))!.GetValue(item2);
									Struct17 struct17_ = smethod_2(type);
									if (struct17_.method_0())
									{
										continue;
									}
									using (new Class23(xmlWriter_0, Strings.Get(2516)))
									{
										xmlWriter_0.WriteAttributeString(Strings.Get(2448), num2.ToString());
										xmlWriter_0.WriteAttributeString(Strings.Get(2474), num4.ToString());
										int num5 = method_4(struct17_);
										if (num5 > 0)
										{
											xmlWriter_0.WriteAttributeString(Strings.Get(1919), num5.ToString());
										}
										if (num3 != -1)
										{
											xmlWriter_0.WriteAttributeString(Strings.Get(2461), num3.ToString());
										}
										object[] array3 = array2;
										foreach (object object_ in array3)
										{
											try
											{
												method_1(new Class18(object_, bool_1: true), null);
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
			method_10();
			using (new Class23(xmlWriter_0, Strings.Get(2533)))
			{
				xmlWriter_0.WriteAttributeString(Strings.Get(2546), list_1.Count.ToString());
				for (int k = 0; k < list_1.Count; k++)
				{
					string value;
					try
					{
						value = list_1[k].ToString();
					}
					catch (Exception ex2)
					{
						value = '"' + ex2.Message + '"';
					}
					xmlWriter_0.WriteElementString(Strings.Get(1955), value);
				}
			}
			using (new Class23(xmlWriter_0, Strings.Get(2555)))
			{
				xmlWriter_0.WriteAttributeString(Strings.Get(2546), list_2.Count.ToString());
				for (int l = 0; l < list_2.Count; l++)
				{
					using (new Class23(xmlWriter_0, Strings.Get(2006)))
					{
						Struct16 struct2 = list_2[l];
						xmlWriter_0.WriteAttributeString(Strings.Get(1817), struct2.string_0);
						if (struct2.string_1.Length > 0)
						{
							xmlWriter_0.WriteAttributeString(Strings.Get(2572), struct2.string_1);
						}
					}
				}
			}
		}
		xmlWriter_0.WriteEndDocument();
		xmlWriter_0.Flush();
		memoryStream_0.Flush();
		byte[] array4 = (byte_0 = memoryStream_0.ToArray());
		return byte_0;
	}

	private void method_10()
	{
		using (new Class23(xmlWriter_0, Strings.Get(2503)))
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				Class18 @class = list_0[i];
				object obj = @class.method_1();
				Type type = @class.method_2();
				using (new Class23(xmlWriter_0, Strings.Get(2585)))
				{
					xmlWriter_0.WriteAttributeString(Strings.Get(1817), i.ToString());
					string text = null;
					bool flag = true;
					string[] array = Strings.Get(2598).Split(new char[1] { ',' });
					foreach (string text2 in array)
					{
						if (text2 != Strings.Get(2598) && type.FullName!.StartsWith(text2))
						{
							flag = false;
							break;
						}
					}
					object[] customAttributes = type.GetCustomAttributes(inherit: true);
					for (int k = 0; k < customAttributes.Length; k++)
					{
						Attribute attribute = (Attribute)customAttributes[k];
						string name = attribute.GetType().Name;
						if (!(name != Strings.Get(2599)) || !(name != Strings.Get(2636)))
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						try
						{
							text = obj.ToString();
							text = ((text == type.FullName) ? null : (type.IsEnum ? Enum.Format(type, obj, Strings.Get(2665)) : ((!(obj is Guid)) ? (Strings.Get(1803) + text + Strings.Get(1803)) : (Strings.Get(785) + text + Strings.Get(1798)))));
						}
						catch
						{
						}
						if (text != null)
						{
							xmlWriter_0.WriteAttributeString(Strings.Get(1808), smethod_1(text));
						}
					}
					if (type.HasElementType)
					{
						method_5(type.GetElementType());
						if (type.IsByRef)
						{
							xmlWriter_0.WriteAttributeString(Strings.Get(1718), Strings.Get(1713));
						}
						if (type.IsPointer)
						{
							xmlWriter_0.WriteAttributeString(Strings.Get(1727), Strings.Get(1713));
						}
						if (!type.IsArray)
						{
							continue;
						}
						Array array2 = (Array)obj;
						xmlWriter_0.WriteAttributeString(Strings.Get(1740), array2.Rank.ToString());
						StringBuilder stringBuilder = new StringBuilder();
						for (int l = 0; l < array2.Rank; l++)
						{
							if (l > 0)
							{
								stringBuilder.Append(',');
							}
							stringBuilder.Append(array2.GetLength(l));
						}
						xmlWriter_0.WriteAttributeString(Strings.Get(2204), stringBuilder.ToString());
						if (array2.Rank != 1)
						{
							continue;
						}
						int length = array2.Length;
						for (int m = 0; m < length; m++)
						{
							if (m == 10 && length > 16)
							{
								m = length - 5;
							}
							try
							{
								method_1(new Class18(array2.GetValue(m), bool_1: false), null);
							}
							catch
							{
							}
						}
						continue;
					}
					method_5(type);
					if (!@class.method_0() || !flag)
					{
						continue;
					}
					try
					{
						if (obj is IEnumerable)
						{
							using (new Class23(xmlWriter_0, Strings.Get(2670)))
							{
								int num = 0;
								foreach (object item in (IEnumerable)obj)
								{
									if (num <= 20)
									{
										method_1(new Class18(item, bool_1: false), null);
										num++;
										continue;
									}
									xmlWriter_0.WriteElementString(Strings.Get(2687), string.Empty);
									break;
								}
							}
						}
					}
					catch
					{
					}
					method_11(@class);
				}
			}
		}
	}

	private void method_11(Class18 class18_0)
	{
		FieldInfo[] fields = class18_0.method_2().GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		FieldInfo[] array = fields;
		foreach (FieldInfo fieldInfo in array)
		{
			try
			{
				if (fieldInfo.IsLiteral || (fieldInfo.IsStatic && fieldInfo.IsInitOnly))
				{
					continue;
				}
				bool flag = true;
				object[] customAttributes = fieldInfo.GetCustomAttributes(inherit: true);
				for (int j = 0; j < customAttributes.Length; j++)
				{
					Attribute attribute = (Attribute)customAttributes[j];
					if (attribute.GetType().Name == Strings.Get(2636))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					method_1(new Class18(fieldInfo.GetValue(class18_0.method_1()), bool_1: false), fieldInfo);
				}
			}
			catch
			{
			}
		}
		class18_0 = new Class18(class18_0.method_1(), class18_0.method_2().BaseType, class18_0.method_0());
		if ((object)class18_0.method_2() != null)
		{
			using (new Class23(xmlWriter_0, Strings.Get(1686)))
			{
				method_3(Strings.Get(2696));
				xmlWriter_0.WriteAttributeString(Strings.Get(1817), list_0.Count.ToString());
			}
			list_0.Add(class18_0);
		}
	}

	private void method_12(Exception exception_1)
	{
		using (new Class23(xmlWriter_0, Strings.Get(2705)))
		{
			try
			{
				Type type = exception_1.GetType();
				method_5(type);
				string value = Strings.Get(1968);
				try
				{
					value = exception_1.Message;
				}
				catch
				{
				}
				xmlWriter_0.WriteAttributeString(Strings.Get(2718), value);
				string text = exception_1.StackTrace!.Trim();
				xmlWriter_0.WriteAttributeString(Strings.Get(2731), text);
				int num = text.IndexOf(' ');
				text = text.Substring(num + 1);
				num = text.IndexOf(Strings.Get(2760));
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				xmlWriter_0.WriteAttributeString(Strings.Get(2765), text);
				method_2(new Class18(exception_1, bool_1: true));
			}
			catch
			{
			}
		}
	}

	internal void method_13(string string_0, object object_0)
	{
		dictionary_0.Add(string_0, object_0);
	}

	internal void method_14(string string_0, string string_1)
	{
		if (File.Exists(string_1))
		{
			Struct15 value = new Struct15(string_1);
			dictionary_1.Add(string_0, value);
		}
	}

	internal bool method_15()
	{
		Class35.smethod_0(1u);
		try
		{
			InvokeSendingReportFeedback(SendingReportStep.PreparingReport);
			byte[] array;
			try
			{
				array = method_9();
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
				InvokeSendingReportFeedback(SendingReportStep.PreparingReport, string.Format(Strings.Get(2774), ex.Message, num));
				return false;
			}
			Class17 class17_ = new Class17(Strings.Get(2807), Strings.Get(2836), Strings.Get(2849));
			return method_0(array, class17_);
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception exception_)
		{
			method_17(new FatalExceptionEventArgs(exception_));
			return false;
		}
	}

	[SpecialName]
	public void method_16(FatalExceptionEventHandler fatalExceptionEventHandler_1)
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

	public void method_17(FatalExceptionEventArgs fatalExceptionEventArgs_0)
	{
		fatalExceptionEventHandler_0?.Invoke(this, fatalExceptionEventArgs_0);
	}

	[SpecialName]
	public void method_18(EventHandler eventHandler_1)
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

	internal void method_19()
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			method_20(tempFileName);
			string path = AppPathFinder.ReadInstalledSaPath();
			Process.Start(Path.Combine(path, Strings.Get(2898)), Strings.Get(2923) + tempFileName + Strings.Get(1803));
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
			method_17(new FatalExceptionEventArgs(exception_));
		}
	}

	internal bool method_20(string string_0)
	{
		try
		{
			byte[] buffer = method_9();
			byte[] array;
			try
			{
				array = SimpleZip.Zip(buffer);
			}
			catch
			{
				array = null;
			}
			byte[] array2 = Class13.smethod_0(array, Strings.Get(1106));
			FileStream fileStream = File.OpenWrite(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes(Strings.Get(1486));
			fileStream.Write(bytes, 0, bytes.Length);
			fileStream.Write(array2, 0, array2.Length);
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
