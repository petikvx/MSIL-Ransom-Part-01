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
using ns0;
using ns10;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;
using ns9;

namespace ns2;

internal sealed class Class32 : Class31
{
	private struct Struct27
	{
		public readonly string string_0;

		public readonly string string_1;

		public readonly string string_2;

		public readonly int int_0;
	}

	private struct Struct28
	{
		public readonly string string_0;

		public readonly string string_1;

		public Struct28(string string_2, string string_3)
		{
			string_0 = string_2;
			string_1 = string_3;
		}
	}

	private struct Struct29
	{
		public string string_0;

		public Struct28 struct28_0;

		[SpecialName]
		public bool method_0()
		{
			return string_0.Length == 0;
		}

		[SpecialName]
		public static Struct29 smethod_0()
		{
			return new Struct29(string.Empty, string.Empty, string.Empty);
		}

		private Struct29(string string_1, string string_2, string string_3)
		{
			string_0 = string_1;
			struct28_0 = new Struct28(string_2, string_3);
		}
	}

	private readonly Exception exception_0;

	private readonly Guid guid_0;

	private readonly char[] char_0 = new char[0];

	private readonly Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();

	private readonly Dictionary<string, Struct27> dictionary_1 = new Dictionary<string, Struct27>();

	private readonly XmlWriter xmlWriter_0;

	private readonly List<Class36> list_0 = new List<Class36>();

	private readonly List<string> list_1 = new List<string>();

	private readonly Dictionary<string, int> dictionary_2 = new Dictionary<string, int>();

	private readonly List<Struct28> list_2 = new List<Struct28>();

	private readonly Dictionary<string, int> dictionary_3 = new Dictionary<string, int>();

	private readonly MemoryStream memoryStream_0;

	private byte[] byte_0;

	private Delegate8 delegate8_0;

	private EventHandler eventHandler_0;

	public Class32(Guid guid_1, Exception exception_1, IWebProxy iwebProxy_1)
	{
		guid_0 = guid_1;
		exception_0 = exception_1;
		memoryStream_0 = new MemoryStream();
		xmlWriter_0 = new XmlTextWriter(memoryStream_0, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		method_0(iwebProxy_1);
		string text;
		if ((text = Class15.smethod_0(950025).ToUpper()) == null)
		{
			return;
		}
		if (!(text == Class15.smethod_0(950038)))
		{
			if (text == Class15.smethod_0(950025))
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
				return num.ToString(Class15.smethod_0(950047));
			}
			if (object_0 is long num2)
			{
				return num2.ToString(Class15.smethod_0(950047));
			}
			if (object_0 is short num3)
			{
				return num3.ToString(Class15.smethod_0(950047));
			}
			if (object_0 is uint num4)
			{
				return num4.ToString(Class15.smethod_0(950047));
			}
			if (object_0 is ulong num5)
			{
				return num5.ToString(Class15.smethod_0(950047));
			}
			if (object_0 is ushort num6)
			{
				return num6.ToString(Class15.smethod_0(950047));
			}
			if (object_0 is byte b)
			{
				return b.ToString(Class15.smethod_0(950047));
			}
			if (object_0 is sbyte b2)
			{
				return b2.ToString(Class15.smethod_0(950047));
			}
			if (object_0 is IntPtr intPtr)
			{
				return intPtr.ToInt64().ToString(Class15.smethod_0(950047));
			}
			if (object_0 is UIntPtr)
			{
				return ((UIntPtr)object_0).ToUInt64().ToString(Class15.smethod_0(950047));
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	private static string smethod_1(string string_0)
	{
		if (string_0.StartsWith(Class15.smethod_0(950052)) && string_0.EndsWith(Class15.smethod_0(950073)))
		{
			return Class15.smethod_0(950094);
		}
		return string_0;
	}

	private void method_6(Class36 class36_0, FieldInfo fieldInfo_0)
	{
		string text = fieldInfo_0?.Name;
		string string_ = (((object)fieldInfo_0 == null) ? Class15.smethod_0(950176) : Class15.smethod_0(950167));
		object obj = class36_0.method_1();
		if (obj == null)
		{
			using (new Class44(xmlWriter_0, string_))
			{
				if ((object)fieldInfo_0 != null)
				{
					if (fieldInfo_0.IsStatic)
					{
						xmlWriter_0.WriteAttributeString(Class15.smethod_0(950185), Class15.smethod_0(950194));
					}
					Type fieldType = fieldInfo_0.FieldType;
					if ((object)fieldType != null && fieldType.HasElementType)
					{
						method_10(fieldType.GetElementType());
						if (fieldType.IsByRef)
						{
							xmlWriter_0.WriteAttributeString(Class15.smethod_0(950199), Class15.smethod_0(950194));
						}
						if (fieldType.IsPointer)
						{
							xmlWriter_0.WriteAttributeString(Class15.smethod_0(950208), Class15.smethod_0(950194));
						}
						if (fieldType.IsArray)
						{
							xmlWriter_0.WriteAttributeString(Class15.smethod_0(950221), fieldType.GetArrayRank().ToString());
						}
					}
					else
					{
						method_10(fieldType);
					}
				}
				if (text != null)
				{
					method_8(text);
				}
				xmlWriter_0.WriteAttributeString(Class15.smethod_0(950230), Class15.smethod_0(950194));
				return;
			}
		}
		Type type = class36_0.method_1().GetType();
		string text2 = null;
		string text3 = null;
		if (obj is string)
		{
			text2 = Class15.smethod_0(950239);
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
						stringBuilder.Append(Class15.smethod_0(950260));
					}
					stringBuilder.Append(Class15.smethod_0(950265));
					stringBuilder.Append(num.ToString(Class15.smethod_0(950047)));
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
						stringBuilder2.Append(Class15.smethod_0(950270));
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
		using (new Class44(xmlWriter_0, string_))
		{
			if ((object)fieldInfo_0 != null && fieldInfo_0.IsStatic)
			{
				xmlWriter_0.WriteAttributeString(Class15.smethod_0(950185), Class15.smethod_0(950194));
			}
			if (text2 != null)
			{
				method_10(type);
				if (text != null)
				{
					method_8(text);
				}
				if (type.IsEnum)
				{
					text3 = obj.ToString();
				}
				if (obj is Guid)
				{
					text3 = string.Concat(Class15.smethod_0(949266), obj, Class15.smethod_0(950279));
				}
				if (text3 == null)
				{
					text3 = string.Concat(Class15.smethod_0(950284), obj, Class15.smethod_0(950284));
				}
				xmlWriter_0.WriteAttributeString(Class15.smethod_0(950289), smethod_1(text3));
			}
			else
			{
				if ((object)fieldInfo_0 != null)
				{
					method_10(fieldInfo_0.FieldType);
				}
				method_7(class36_0);
				if (text != null)
				{
					method_8(text);
				}
			}
		}
	}

	private void method_7(Class36 class36_0)
	{
		object objB = class36_0.method_1();
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
			list_0.Add(class36_0);
		}
		xmlWriter_0.WriteAttributeString(Class15.smethod_0(950298), num.ToString());
	}

	private void method_8(string string_0)
	{
		int num = method_11(string_0);
		if (num != -1)
		{
			xmlWriter_0.WriteAttributeString(Class15.smethod_0(950303), num.ToString());
		}
		else
		{
			xmlWriter_0.WriteAttributeString(Class15.smethod_0(950312), string_0);
		}
	}

	private static Struct29 smethod_2(Type type_0)
	{
		Struct29 result = Struct29.smethod_0();
		if ((object)type_0 != null && (object)type_0.Assembly.GetType(Class15.smethod_0(950321)) != null)
		{
			result.string_0 = ((type_0.MetadataToken & 0xFFFFFF) - 1).ToString();
			Assembly assembly = type_0.Assembly;
			result.struct28_0 = new Struct28(assembly.ManifestModule.ModuleVersionId.ToString(Class15.smethod_0(950382)), assembly.FullName);
		}
		return result;
	}

	private int method_9(Struct29 struct29_0)
	{
		string key = struct29_0.struct28_0.string_0.ToUpper();
		if (dictionary_3.ContainsKey(key))
		{
			return dictionary_3[key];
		}
		int count = list_2.Count;
		list_2.Add(struct29_0.struct28_0);
		dictionary_3.Add(key, count);
		return count;
	}

	private void method_10(Type type_0)
	{
		if ((object)type_0 == null)
		{
			return;
		}
		try
		{
			Struct29 struct29_ = smethod_2(type_0);
			if (!struct29_.method_0())
			{
				xmlWriter_0.WriteAttributeString(Class15.smethod_0(950387), struct29_.string_0);
				int num = method_9(struct29_);
				if (num > 0)
				{
					xmlWriter_0.WriteAttributeString(Class15.smethod_0(950400), num.ToString());
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
				if (name.Length > 0 && name != Class15.smethod_0(950413))
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
				int num2 = fullName.LastIndexOf(Class15.smethod_0(950426));
				if (num2 > 0)
				{
					string value2 = fullName.Substring(@namespace.Length + 1, num2 - @namespace.Length).Replace(Class15.smethod_0(950426), Class15.smethod_0(950431));
					stringBuilder.Append(value2);
				}
				stringBuilder.Append(type_0.Name);
				value = list_1.Count;
				list_1.Add(stringBuilder.ToString());
				dictionary_2.Add(fullName, value);
			}
			xmlWriter_0.WriteAttributeString(Class15.smethod_0(950436), value.ToString());
		}
		catch
		{
		}
	}

	private int method_11(string string_0)
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
			return Class15.smethod_0(950449);
		}
	}

	private Assembly[] method_12()
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

	private byte[] method_13()
	{
		if (byte_0 != null)
		{
			return byte_0;
		}
		xmlWriter_0.WriteStartDocument();
		using (new Class44(xmlWriter_0, Class15.smethod_0(950454)))
		{
			xmlWriter_0.WriteAttributeString(Class15.smethod_0(950487), Class15.smethod_0(949967).ToUpper());
			xmlWriter_0.WriteAttributeString(Class15.smethod_0(950504), DateTime.Now.ToString(Class15.smethod_0(950517)));
			xmlWriter_0.WriteAttributeString(Class15.smethod_0(949191), smethod_3());
			if (guid_0 != Guid.Empty)
			{
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = Class15.smethod_0(950522);
				Guid guid = guid_0;
				xmlWriter.WriteAttributeString(localName, guid.ToString(Class15.smethod_0(950382)));
			}
			xmlWriter_0.WriteAttributeString(Class15.smethod_0(950531), Guid.NewGuid().ToString(Class15.smethod_0(950382)));
			if (list_2.Count > 0)
			{
				list_2.Clear();
			}
			list_2.Add(new Struct28(Class15.smethod_0(949967), string.Empty));
			if (dictionary_3.Count > 0)
			{
				dictionary_3.Clear();
			}
			dictionary_3.Add(Class15.smethod_0(949967), 0);
			using (new Class44(xmlWriter_0, Class15.smethod_0(950544)))
			{
				Assembly assembly = smethod_4();
				Assembly[] array = method_12();
				foreach (Assembly assembly2 in array)
				{
					if ((object)assembly2 == null)
					{
						continue;
					}
					using (new Class44(xmlWriter_0, Class15.smethod_0(950400)))
					{
						try
						{
							xmlWriter_0.WriteAttributeString(Class15.smethod_0(950312), assembly2.FullName);
							xmlWriter_0.WriteAttributeString(Class15.smethod_0(950561), assembly2.CodeBase);
							if ((object)assembly2 == assembly)
							{
								xmlWriter_0.WriteAttributeString(Class15.smethod_0(950574), Class15.smethod_0(950194));
							}
						}
						catch
						{
						}
					}
				}
			}
			using (new Class44(xmlWriter_0, Class15.smethod_0(950583)))
			{
				if (dictionary_0 != null && dictionary_0.Count > 0)
				{
					foreach (string key in dictionary_0.Keys)
					{
						using (new Class44(xmlWriter_0, Class15.smethod_0(950608)))
						{
							xmlWriter_0.WriteAttributeString(Class15.smethod_0(950312), key);
							string text = (string)dictionary_0[key];
							if (text == null)
							{
								xmlWriter_0.WriteAttributeString(Class15.smethod_0(950230), Class15.smethod_0(950194));
							}
							else
							{
								xmlWriter_0.WriteAttributeString(Class15.smethod_0(950289), Class15.smethod_0(950284) + text + Class15.smethod_0(950284));
							}
						}
					}
				}
			}
			if (dictionary_1 != null && dictionary_1.Count > 0)
			{
				using (new Class44(xmlWriter_0, Class15.smethod_0(950629)))
				{
					foreach (string key2 in dictionary_1.Keys)
					{
						using (new Class44(xmlWriter_0, Class15.smethod_0(950650)))
						{
							xmlWriter_0.WriteAttributeString(Class15.smethod_0(950667), key2);
							Struct27 @struct = dictionary_1[key2];
							xmlWriter_0.WriteAttributeString(Class15.smethod_0(950672), @struct.string_0);
							XmlWriter xmlWriter2 = xmlWriter_0;
							string localName2 = Class15.smethod_0(950685);
							int int_ = @struct.int_0;
							xmlWriter2.WriteAttributeString(localName2, int_.ToString());
							if (@struct.string_2.Length > 0)
							{
								xmlWriter_0.WriteAttributeString(Class15.smethod_0(950694), @struct.string_2);
							}
							else
							{
								xmlWriter_0.WriteAttributeString(Class15.smethod_0(950703), @struct.string_1);
							}
						}
					}
				}
			}
			using (new Class44(xmlWriter_0, Class15.smethod_0(950712)))
			{
				try
				{
					xmlWriter_0.WriteElementString(Class15.smethod_0(950737), Environment.Version.ToString());
					xmlWriter_0.WriteElementString(Class15.smethod_0(950754), Environment.OSVersion.Version.ToString());
					xmlWriter_0.WriteElementString(Class15.smethod_0(950767), Environment.OSVersion.Platform.ToString());
					xmlWriter_0.WriteElementString(Class15.smethod_0(950784), Class43.smethod_4());
					xmlWriter_0.WriteElementString(Class15.smethod_0(950801), Class43.smethod_2() ? Class15.smethod_0(950194) : Class15.smethod_0(950814));
					xmlWriter_0.WriteElementString(Class15.smethod_0(950819), Class43.smethod_1() ? Class15.smethod_0(950194) : Class15.smethod_0(950814));
					xmlWriter_0.WriteElementString(Class15.smethod_0(950824), Class43.smethod_3() ? Class15.smethod_0(950194) : Class15.smethod_0(950814));
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
			using (new Class44(xmlWriter_0, Class15.smethod_0(950841)))
			{
				foreach (Exception item in list)
				{
					try
					{
						method_16(item);
						if (!item.Data.Contains(Class15.smethod_0(950858)))
						{
							continue;
						}
						ICollection collection = (ICollection)item.Data[Class15.smethod_0(950858)];
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
									using (new Class44(xmlWriter_0, Class15.smethod_0(950883)))
									{
										xmlWriter_0.WriteAttributeString(Class15.smethod_0(950904), count.ToString());
									}
								}
								else
								{
									if (num > 100 && num <= count - 100)
									{
										continue;
									}
									int num2 = (int)type.GetField(Class15.smethod_0(950929))!.GetValue(item2);
									int num3 = (int)type.GetField(Class15.smethod_0(950942))!.GetValue(item2);
									int num4 = (int)type.GetField(Class15.smethod_0(950955))!.GetValue(item2);
									object[] array2 = (object[])type.GetField(Class15.smethod_0(950984))!.GetValue(item2);
									Struct29 struct29_ = smethod_2(type);
									if (struct29_.method_0())
									{
										continue;
									}
									using (new Class44(xmlWriter_0, Class15.smethod_0(950997)))
									{
										xmlWriter_0.WriteAttributeString(Class15.smethod_0(950929), num2.ToString());
										xmlWriter_0.WriteAttributeString(Class15.smethod_0(950955), num4.ToString());
										int num5 = method_9(struct29_);
										if (num5 > 0)
										{
											xmlWriter_0.WriteAttributeString(Class15.smethod_0(950400), num5.ToString());
										}
										if (num3 != -1)
										{
											xmlWriter_0.WriteAttributeString(Class15.smethod_0(950942), num3.ToString());
										}
										object[] array3 = array2;
										foreach (object object_ in array3)
										{
											try
											{
												method_6(new Class36(object_, bool_1: true), null);
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
			method_14();
			using (new Class44(xmlWriter_0, Class15.smethod_0(951014)))
			{
				xmlWriter_0.WriteAttributeString(Class15.smethod_0(951027), list_1.Count.ToString());
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
					xmlWriter_0.WriteElementString(Class15.smethod_0(950436), value);
				}
			}
			using (new Class44(xmlWriter_0, Class15.smethod_0(951036)))
			{
				xmlWriter_0.WriteAttributeString(Class15.smethod_0(951027), list_2.Count.ToString());
				for (int l = 0; l < list_2.Count; l++)
				{
					using (new Class44(xmlWriter_0, Class15.smethod_0(950487)))
					{
						Struct28 struct2 = list_2[l];
						xmlWriter_0.WriteAttributeString(Class15.smethod_0(950298), struct2.string_0);
						if (struct2.string_1.Length > 0)
						{
							xmlWriter_0.WriteAttributeString(Class15.smethod_0(951053), struct2.string_1);
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

	private void method_14()
	{
		using (new Class44(xmlWriter_0, Class15.smethod_0(950984)))
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				Class36 @class = list_0[i];
				object obj = @class.method_1();
				Type type = @class.method_2();
				using (new Class44(xmlWriter_0, Class15.smethod_0(951066)))
				{
					xmlWriter_0.WriteAttributeString(Class15.smethod_0(950298), i.ToString());
					string text = null;
					bool flag = true;
					string[] array = Class15.smethod_0(58).Split(new char[1] { ',' });
					foreach (string text2 in array)
					{
						if (text2 != Class15.smethod_0(58) && type.FullName!.StartsWith(text2))
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
						if (!(name != Class15.smethod_0(951079)) || !(name != Class15.smethod_0(951116)))
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
							text = ((text == type.FullName) ? null : (type.IsEnum ? Enum.Format(type, obj, Class15.smethod_0(951145)) : ((!(obj is Guid)) ? (Class15.smethod_0(950284) + text + Class15.smethod_0(950284)) : (Class15.smethod_0(949266) + text + Class15.smethod_0(950279)))));
						}
						catch
						{
						}
						if (text != null)
						{
							xmlWriter_0.WriteAttributeString(Class15.smethod_0(950289), smethod_1(text));
						}
					}
					if (type.HasElementType)
					{
						method_10(type.GetElementType());
						if (type.IsByRef)
						{
							xmlWriter_0.WriteAttributeString(Class15.smethod_0(950199), Class15.smethod_0(950194));
						}
						if (type.IsPointer)
						{
							xmlWriter_0.WriteAttributeString(Class15.smethod_0(950208), Class15.smethod_0(950194));
						}
						if (!type.IsArray)
						{
							continue;
						}
						Array array2 = (Array)obj;
						xmlWriter_0.WriteAttributeString(Class15.smethod_0(950221), array2.Rank.ToString());
						StringBuilder stringBuilder = new StringBuilder();
						for (int l = 0; l < array2.Rank; l++)
						{
							if (l > 0)
							{
								stringBuilder.Append(',');
							}
							stringBuilder.Append(array2.GetLength(l));
						}
						xmlWriter_0.WriteAttributeString(Class15.smethod_0(950685), stringBuilder.ToString());
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
								method_6(new Class36(array2.GetValue(m), bool_1: false), null);
							}
							catch
							{
							}
						}
						continue;
					}
					method_10(type);
					if (!@class.method_0() || !flag)
					{
						continue;
					}
					try
					{
						if (obj is IEnumerable)
						{
							using (new Class44(xmlWriter_0, Class15.smethod_0(951150)))
							{
								int num = 0;
								foreach (object item in (IEnumerable)obj)
								{
									if (num <= 20)
									{
										method_6(new Class36(item, bool_1: false), null);
										num++;
										continue;
									}
									xmlWriter_0.WriteElementString(Class15.smethod_0(951167), string.Empty);
									break;
								}
							}
						}
					}
					catch
					{
					}
					method_15(@class);
				}
			}
		}
	}

	private void method_15(Class36 class36_0)
	{
		FieldInfo[] fields = class36_0.method_2().GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
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
					if (attribute.GetType().Name == Class15.smethod_0(951116))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					method_6(new Class36(fieldInfo.GetValue(class36_0.method_1()), bool_1: false), fieldInfo);
				}
			}
			catch
			{
			}
		}
		class36_0 = new Class36(class36_0.method_1(), class36_0.method_2().BaseType, class36_0.method_0());
		if ((object)class36_0.method_2() != null)
		{
			using (new Class44(xmlWriter_0, Class15.smethod_0(950167)))
			{
				method_8(Class15.smethod_0(951176));
				xmlWriter_0.WriteAttributeString(Class15.smethod_0(950298), list_0.Count.ToString());
			}
			list_0.Add(class36_0);
		}
	}

	private void method_16(Exception exception_1)
	{
		using (new Class44(xmlWriter_0, Class15.smethod_0(951185)))
		{
			try
			{
				Type type = exception_1.GetType();
				method_10(type);
				string value = Class15.smethod_0(950449);
				try
				{
					value = exception_1.Message;
				}
				catch
				{
				}
				xmlWriter_0.WriteAttributeString(Class15.smethod_0(951198), value);
				string text = exception_1.StackTrace!.Trim();
				xmlWriter_0.WriteAttributeString(Class15.smethod_0(951211), text);
				int num = text.IndexOf(' ');
				text = text.Substring(num + 1);
				num = text.IndexOf(Class15.smethod_0(951240));
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				xmlWriter_0.WriteAttributeString(Class15.smethod_0(951245), text);
				method_7(new Class36(exception_1, bool_1: true));
			}
			catch
			{
			}
		}
	}

	internal bool method_17()
	{
		Class59.smethod_0(1u);
		try
		{
			method_5(Enum0.const_0);
			byte[] array;
			try
			{
				array = method_13();
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
				method_4(Enum0.const_0, string.Format(Class15.smethod_0(951254), ex.Message, num));
				return false;
			}
			Class35 class35_ = new Class35(Class15.smethod_0(58), Class15.smethod_0(951287), Class15.smethod_0(951292));
			return method_1(array, class35_);
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception exception_)
		{
			method_19(new EventArgs0(exception_));
			return false;
		}
	}

	[SpecialName]
	public void method_18(Delegate8 delegate8_1)
	{
		Delegate8 @delegate = delegate8_0;
		Delegate8 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate8 value = (Delegate8)Delegate.Combine(delegate2, delegate8_1);
			@delegate = Interlocked.CompareExchange(ref delegate8_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	public void method_19(EventArgs0 eventArgs0_0)
	{
		delegate8_0?.Invoke(this, eventArgs0_0);
	}

	[SpecialName]
	public void method_20(EventHandler eventHandler_1)
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

	internal void method_21()
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			method_22(tempFileName);
			string path = Class13.smethod_0();
			Process.Start(Path.Combine(path, Class15.smethod_0(951345)), Class15.smethod_0(951370) + tempFileName + Class15.smethod_0(950284));
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
			method_19(new EventArgs0(exception_));
		}
	}

	internal bool method_22(string string_0)
	{
		try
		{
			byte[] object_ = method_13();
			byte[] array;
			try
			{
				array = Class18.smethod_2(object_);
			}
			catch
			{
				array = null;
			}
			byte[] array2 = Class30.smethod_0(array, Class15.smethod_0(949587));
			FileStream fileStream = File.OpenWrite(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes(Class15.smethod_0(949967));
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
