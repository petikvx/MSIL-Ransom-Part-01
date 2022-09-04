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

namespace ns0;

internal sealed class Class23 : Class22
{
	private struct Struct14
	{
		public readonly string string_0;

		public readonly string string_1;

		public readonly string string_2;

		public readonly int int_0;
	}

	private struct Struct15
	{
		public readonly string string_0;

		public readonly string string_1;

		public Struct15(string CO_, string CO_)
		{
			string_0 = CO_;
			string_1 = CO_;
		}
	}

	private struct Struct16
	{
		public string string_0;

		public Struct15 struct15_0;

		private Struct16(string CO_, string CO_, string CO_)
		{
			string_0 = CO_;
			struct15_0 = new Struct15(CO_, CO_);
		}

		[SpecialName]
		public bool method_0()
		{
			return string_0.Length == 0;
		}

		[SpecialName]
		public static Struct16 smethod_0()
		{
			return new Struct16(string.Empty, string.Empty, string.Empty);
		}
	}

	private readonly Exception exception_0;

	private readonly Guid guid_0;

	private readonly char[] char_0 = new char[0];

	private readonly Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();

	private readonly Dictionary<string, Struct14> dictionary_1 = new Dictionary<string, Struct14>();

	private readonly XmlWriter xmlWriter_0;

	private readonly List<Class27> list_0 = new List<Class27>();

	private readonly List<string> list_1 = new List<string>();

	private readonly Dictionary<string, int> dictionary_2 = new Dictionary<string, int>();

	private readonly List<Struct15> list_2 = new List<Struct15>();

	private readonly Dictionary<string, int> dictionary_3 = new Dictionary<string, int>();

	private readonly MemoryStream memoryStream_0;

	private byte[] byte_0;

	private Delegate0 delegate0_0;

	private EventHandler eventHandler_0;

	public Class23(Guid CO_, Exception CO_, IWebProxy CO_)
	{
		guid_0 = CO_;
		exception_0 = CO_;
		memoryStream_0 = new MemoryStream();
		xmlWriter_0 = new XmlTextWriter(memoryStream_0, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		method_0(CO_);
		string text;
		if ((text = Class5.smethod_0(80138).ToUpper()) == null)
		{
			return;
		}
		if (!(text == Class5.smethod_0(80151)))
		{
			if (text == Class5.smethod_0(80138))
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

	private static string smethod_0(object CO_)
	{
		try
		{
			if (CO_ == null)
			{
				return string.Empty;
			}
			if (CO_ is int num)
			{
				return num.ToString(Class5.smethod_0(80160));
			}
			if (CO_ is long num2)
			{
				return num2.ToString(Class5.smethod_0(80160));
			}
			if (CO_ is short num3)
			{
				return num3.ToString(Class5.smethod_0(80160));
			}
			if (CO_ is uint num4)
			{
				return num4.ToString(Class5.smethod_0(80160));
			}
			if (CO_ is ulong num5)
			{
				return num5.ToString(Class5.smethod_0(80160));
			}
			if (CO_ is ushort num6)
			{
				return num6.ToString(Class5.smethod_0(80160));
			}
			if (CO_ is byte b)
			{
				return b.ToString(Class5.smethod_0(80160));
			}
			if (CO_ is sbyte b2)
			{
				return b2.ToString(Class5.smethod_0(80160));
			}
			if (CO_ is IntPtr intPtr)
			{
				return intPtr.ToInt64().ToString(Class5.smethod_0(80160));
			}
			if (CO_ is UIntPtr)
			{
				return ((UIntPtr)CO_).ToUInt64().ToString(Class5.smethod_0(80160));
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	private static string smethod_1(string CO_)
	{
		while (CO_.StartsWith(Class5.smethod_0(80165)))
		{
			while (2u != 0 || 1 == 0)
			{
				int num = (CO_.EndsWith(Class5.smethod_0(80186)) ? 1 : 0);
				while (num != 0)
				{
					if (7u != 0)
					{
						num = 80207;
						if (num != 0)
						{
							return Class5.smethod_0(num);
						}
						continue;
					}
					goto IL_0038;
				}
				goto end_IL_0000;
				IL_0038:;
			}
			continue;
			end_IL_0000:
			break;
		}
		return CO_;
	}

	private void method_6(Class27 CO_, FieldInfo CO_)
	{
		string text = CO_?.Name;
		string cO_ = (((object)CO_ == null) ? Class5.smethod_0(80289) : Class5.smethod_0(80280));
		object obj = CO_.method_1();
		if (obj == null)
		{
			using (new Class35(xmlWriter_0, cO_))
			{
				if ((object)CO_ != null)
				{
					if (CO_.IsStatic)
					{
						xmlWriter_0.WriteAttributeString(Class5.smethod_0(80298), Class5.smethod_0(80307));
					}
					Type fieldType = CO_.FieldType;
					if ((object)fieldType != null && fieldType.HasElementType)
					{
						method_10(fieldType.GetElementType());
						if (fieldType.IsByRef)
						{
							xmlWriter_0.WriteAttributeString(Class5.smethod_0(80312), Class5.smethod_0(80307));
						}
						if (fieldType.IsPointer)
						{
							xmlWriter_0.WriteAttributeString(Class5.smethod_0(80321), Class5.smethod_0(80307));
						}
						if (fieldType.IsArray)
						{
							xmlWriter_0.WriteAttributeString(Class5.smethod_0(80334), fieldType.GetArrayRank().ToString());
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
				xmlWriter_0.WriteAttributeString(Class5.smethod_0(80343), Class5.smethod_0(80307));
				return;
			}
		}
		Type type = CO_.method_1().GetType();
		string text2 = null;
		string text3 = null;
		if (obj is string)
		{
			text2 = Class5.smethod_0(80352);
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
						stringBuilder.Append(Class5.smethod_0(80373));
					}
					stringBuilder.Append(Class5.smethod_0(80378));
					stringBuilder.Append(num.ToString(Class5.smethod_0(80160)));
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
						stringBuilder2.Append(Class5.smethod_0(80383));
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
		using (new Class35(xmlWriter_0, cO_))
		{
			if ((object)CO_ != null && CO_.IsStatic)
			{
				xmlWriter_0.WriteAttributeString(Class5.smethod_0(80298), Class5.smethod_0(80307));
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
					text3 = string.Concat(Class5.smethod_0(79379), obj, Class5.smethod_0(80392));
				}
				if (text3 == null)
				{
					text3 = string.Concat(Class5.smethod_0(80397), obj, Class5.smethod_0(80397));
				}
				xmlWriter_0.WriteAttributeString(Class5.smethod_0(80402), smethod_1(text3));
			}
			else
			{
				if ((object)CO_ != null)
				{
					method_10(CO_.FieldType);
				}
				method_7(CO_);
				if (text != null)
				{
					method_8(text);
				}
			}
		}
	}

	private void method_7(Class27 CO_)
	{
		object objB = CO_.method_1();
		int num = -1;
		while (true)
		{
			int num2 = num;
			int num3 = 0;
			while (true)
			{
				num = num3;
				if (false)
				{
					break;
				}
				int num4 = list_0.Count;
				while (true)
				{
					if (num < num4)
					{
						int num5;
						if (!object.ReferenceEquals(list_0[num3].method_1(), objB))
						{
							num = num3;
							num4 = 1;
							if (num4 == 0)
							{
								continue;
							}
							num5 = num + num4;
						}
						else
						{
							num5 = num3;
							if (0 == 0)
							{
								num2 = num5;
								goto IL_0042;
							}
						}
						num3 = num5;
						break;
					}
					goto IL_0042;
					IL_0072:
					xmlWriter_0.WriteAttributeString(Class5.smethod_0(80411), num2.ToString());
					return;
					IL_0042:
					if (3 == 0)
					{
						break;
					}
					if (0 == 0)
					{
						int num6 = num2;
						if (0 == 0)
						{
							if (num6 != -1)
							{
								goto IL_0072;
							}
							num6 = list_0.Count;
						}
						num2 = num6;
						list_0.Add(CO_);
					}
					goto IL_0072;
				}
			}
		}
	}

	private void method_8(string CO_)
	{
		int num = method_11(CO_);
		int num2;
		if (4u != 0)
		{
			num2 = num;
			goto IL_0010;
		}
		goto IL_0014;
		IL_0010:
		if (0 == 0)
		{
			num = num2;
			goto IL_0014;
		}
		goto IL_0030;
		IL_0014:
		if (num == -1)
		{
			if (0 == 0)
			{
				xmlWriter_0.WriteAttributeString(Class5.smethod_0(80425), CO_);
				return;
			}
			goto IL_0010;
		}
		goto IL_0030;
		IL_0030:
		xmlWriter_0.WriteAttributeString(Class5.smethod_0(80416), num2.ToString());
	}

	private static Struct16 smethod_2(Type CO_)
	{
		Struct16 result;
		while (0 == 0)
		{
			result = Struct16.smethod_0();
			if ((object)CO_ == null)
			{
				break;
			}
			while ((object)CO_.Assembly.GetType(Class5.smethod_0(80434)) != null)
			{
				if (7 == 0)
				{
					goto IL_0000;
				}
				if (0 == 0)
				{
					result.string_0 = ((CO_.MetadataToken & 0xFFFFFF) - 1).ToString();
					Assembly assembly = CO_.Assembly;
					if (0 == 0)
					{
						result.struct15_0 = new Struct15(assembly.ManifestModule.ModuleVersionId.ToString(Class5.smethod_0(80495)), assembly.FullName);
						break;
					}
				}
			}
			break;
			IL_0000:;
		}
		return result;
	}

	private int method_9(Struct16 CO_)
	{
		string key = CO_.struct15_0.string_0.ToUpper();
		int num;
		if (7u != 0)
		{
			num = (dictionary_3.ContainsKey(key) ? 1 : 0);
			if (false)
			{
				goto IL_0028;
			}
			if (num == 0)
			{
				goto IL_0051;
			}
		}
		return dictionary_3[key];
		IL_002b:
		if (0 == 0)
		{
			int num2 = num;
			list_2.Add(CO_.struct15_0);
			dictionary_3.Add(key, num2);
			if (3 == 0)
			{
				goto IL_0051;
			}
			num = num2;
		}
		goto IL_0028;
		IL_0051:
		num = list_2.Count;
		goto IL_002b;
		IL_0028:
		if (true)
		{
			return num;
		}
		goto IL_002b;
	}

	private void method_10(Type CO_)
	{
		if ((object)CO_ == null)
		{
			return;
		}
		try
		{
			Struct16 cO_ = smethod_2(CO_);
			string fullName;
			int value;
			StringBuilder stringBuilder;
			string name;
			if (!cO_.method_0())
			{
				xmlWriter_0.WriteAttributeString(Class5.smethod_0(80500), cO_.string_0);
				int num = method_9(cO_);
				if (0 == 0)
				{
					if (num > 0)
					{
						xmlWriter_0.WriteAttributeString(Class5.smethod_0(80513), num.ToString());
					}
					return;
				}
			}
			else
			{
				fullName = CO_.FullName;
				if (dictionary_2.ContainsKey(fullName))
				{
					value = dictionary_2[fullName];
					goto IL_01a4;
				}
				stringBuilder = new StringBuilder();
				name = CO_.Assembly.GetName().Name;
				if (name.Length <= 0)
				{
					goto IL_00de;
				}
			}
			if (name != Class5.smethod_0(80526))
			{
				stringBuilder.Append('[');
				stringBuilder.Append(name);
				stringBuilder.Append(']');
			}
			goto IL_00de;
			IL_01a4:
			xmlWriter_0.WriteAttributeString(Class5.smethod_0(80549), value.ToString());
			return;
			IL_00de:
			string @namespace = CO_.Namespace;
			if (@namespace.Length > 0)
			{
				stringBuilder.Append(@namespace);
				stringBuilder.Append('.');
			}
			if (CO_.HasElementType)
			{
				CO_ = CO_.GetElementType();
			}
			int num2 = fullName.LastIndexOf(Class5.smethod_0(80539));
			if (num2 > 0)
			{
				string value2 = fullName.Substring(@namespace.Length + 1, num2 - @namespace.Length).Replace(Class5.smethod_0(80539), Class5.smethod_0(80544));
				stringBuilder.Append(value2);
			}
			stringBuilder.Append(CO_.Name);
			value = list_1.Count;
			list_1.Add(stringBuilder.ToString());
			dictionary_2.Add(fullName, value);
			goto IL_01a4;
		}
		catch
		{
		}
	}

	private int method_11(string CO_)
	{
		try
		{
			if (2 == 0)
			{
				goto IL_00a6;
			}
			int num = char_0[0];
			int num2 = 1;
			if (num2 == 0)
			{
				goto IL_0071;
			}
			bool flag = num == num2;
			if (CO_ != null)
			{
				if (false)
				{
					goto IL_0058;
				}
				if (CO_.Length != 0 && (!flag || CO_.Length <= 4))
				{
					if (!flag)
					{
						goto IL_0038;
					}
					goto IL_0045;
				}
			}
			goto IL_00b3;
			IL_0090:
			bool flag2 = default(bool);
			int num3 = default(int);
			if (flag2)
			{
				num3--;
				goto IL_0098;
			}
			return -1;
			IL_0098:
			if (num3 >= 0)
			{
				if (!flag)
				{
					goto IL_0058;
				}
				goto IL_00a6;
			}
			goto IL_005b;
			IL_0067:
			int num4 = default(int);
			num = num4;
			num2 = char_0.Length;
			goto IL_0071;
			IL_0058:
			if (num3 == 0)
			{
				goto IL_005b;
			}
			goto IL_00a6;
			IL_005b:
			int num5 = default(int);
			int num6 = num5;
			if (0 == 0)
			{
				return num6;
			}
			goto IL_007c;
			IL_007c:
			char c = default(char);
			if (num6 != c)
			{
				num4++;
				goto IL_0067;
			}
			num5 = num5 * char_0.Length + num4;
			flag2 = true;
			goto IL_0090;
			IL_0071:
			if (num < num2)
			{
				num6 = char_0[num4];
				goto IL_007c;
			}
			goto IL_0090;
			IL_00a6:
			c = CO_[num3];
			if (5 == 0)
			{
				goto IL_0038;
			}
			flag2 = false;
			num4 = 0;
			goto IL_0067;
			IL_00bf:
			int num7;
			return num7;
			IL_0038:
			if (CO_[0] == '#')
			{
				goto IL_0045;
			}
			goto IL_00b3;
			IL_00b3:
			num7 = -1;
			goto IL_00bf;
			IL_0045:
			num5 = 0;
			num7 = CO_.Length;
			if (8u != 0)
			{
				num3 = num7 - 1;
				goto IL_0098;
			}
			goto IL_00bf;
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
			return Class5.smethod_0(80562);
		}
	}

	private Assembly[] method_12()
	{
		try
		{
			Assembly[] assemblies;
			do
			{
				assemblies = AppDomain.CurrentDomain.GetAssemblies();
			}
			while (false);
			return assemblies;
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
		using (new Class35(xmlWriter_0, Class5.smethod_0(80567)))
		{
			xmlWriter_0.WriteAttributeString(Class5.smethod_0(80600), Class5.smethod_0(80080).ToUpper());
			xmlWriter_0.WriteAttributeString(Class5.smethod_0(80617), DateTime.Now.ToString(Class5.smethod_0(80630)));
			xmlWriter_0.WriteAttributeString(Class5.smethod_0(79304), smethod_3());
			if (guid_0 != Guid.Empty)
			{
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = Class5.smethod_0(80635);
				Guid guid = guid_0;
				xmlWriter.WriteAttributeString(localName, guid.ToString(Class5.smethod_0(80495)));
			}
			xmlWriter_0.WriteAttributeString(Class5.smethod_0(80644), Guid.NewGuid().ToString(Class5.smethod_0(80495)));
			if (list_2.Count > 0)
			{
				list_2.Clear();
			}
			list_2.Add(new Struct15(Class5.smethod_0(80080), string.Empty));
			if (dictionary_3.Count > 0)
			{
				dictionary_3.Clear();
			}
			dictionary_3.Add(Class5.smethod_0(80080), 0);
			using (new Class35(xmlWriter_0, Class5.smethod_0(80657)))
			{
				Assembly assembly = smethod_4();
				Assembly[] array = method_12();
				foreach (Assembly assembly2 in array)
				{
					if ((object)assembly2 == null)
					{
						continue;
					}
					using (new Class35(xmlWriter_0, Class5.smethod_0(80513)))
					{
						try
						{
							xmlWriter_0.WriteAttributeString(Class5.smethod_0(80425), assembly2.FullName);
							xmlWriter_0.WriteAttributeString(Class5.smethod_0(80674), assembly2.CodeBase);
							if ((object)assembly2 == assembly)
							{
								xmlWriter_0.WriteAttributeString(Class5.smethod_0(80687), Class5.smethod_0(80307));
							}
						}
						catch
						{
						}
					}
				}
			}
			using (new Class35(xmlWriter_0, Class5.smethod_0(80696)))
			{
				if (dictionary_0 != null && dictionary_0.Count > 0)
				{
					foreach (string key in dictionary_0.Keys)
					{
						using (new Class35(xmlWriter_0, Class5.smethod_0(80721)))
						{
							xmlWriter_0.WriteAttributeString(Class5.smethod_0(80425), key);
							string text = (string)dictionary_0[key];
							if (text == null)
							{
								xmlWriter_0.WriteAttributeString(Class5.smethod_0(80343), Class5.smethod_0(80307));
							}
							else
							{
								xmlWriter_0.WriteAttributeString(Class5.smethod_0(80402), Class5.smethod_0(80397) + text + Class5.smethod_0(80397));
							}
						}
					}
				}
			}
			if (dictionary_1 != null && dictionary_1.Count > 0)
			{
				using (new Class35(xmlWriter_0, Class5.smethod_0(80742)))
				{
					foreach (string key2 in dictionary_1.Keys)
					{
						using (new Class35(xmlWriter_0, Class5.smethod_0(80763)))
						{
							xmlWriter_0.WriteAttributeString(Class5.smethod_0(80780), key2);
							Struct14 @struct = dictionary_1[key2];
							xmlWriter_0.WriteAttributeString(Class5.smethod_0(80785), @struct.string_0);
							XmlWriter xmlWriter2 = xmlWriter_0;
							string localName2 = Class5.smethod_0(80798);
							int int_ = @struct.int_0;
							xmlWriter2.WriteAttributeString(localName2, int_.ToString());
							if (@struct.string_2.Length > 0)
							{
								xmlWriter_0.WriteAttributeString(Class5.smethod_0(80807), @struct.string_2);
							}
							else
							{
								xmlWriter_0.WriteAttributeString(Class5.smethod_0(80816), @struct.string_1);
							}
						}
					}
				}
			}
			using (new Class35(xmlWriter_0, Class5.smethod_0(80825)))
			{
				try
				{
					xmlWriter_0.WriteElementString(Class5.smethod_0(80850), Environment.Version.ToString());
					xmlWriter_0.WriteElementString(Class5.smethod_0(80867), Environment.OSVersion.Version.ToString());
					xmlWriter_0.WriteElementString(Class5.smethod_0(80880), Environment.OSVersion.Platform.ToString());
					xmlWriter_0.WriteElementString(Class5.smethod_0(80897), Class34.smethod_4());
					xmlWriter_0.WriteElementString(Class5.smethod_0(80914), Class34.smethod_2() ? Class5.smethod_0(80307) : Class5.smethod_0(80927));
					xmlWriter_0.WriteElementString(Class5.smethod_0(80932), Class34.smethod_1() ? Class5.smethod_0(80307) : Class5.smethod_0(80927));
					xmlWriter_0.WriteElementString(Class5.smethod_0(80937), Class34.smethod_3() ? Class5.smethod_0(80307) : Class5.smethod_0(80927));
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
			using (new Class35(xmlWriter_0, Class5.smethod_0(80954)))
			{
				foreach (Exception item in list)
				{
					try
					{
						method_16(item);
						if (!item.Data.Contains(Class5.smethod_0(80971)))
						{
							continue;
						}
						ICollection collection = (ICollection)item.Data[Class5.smethod_0(80971)];
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
									using (new Class35(xmlWriter_0, Class5.smethod_0(80996)))
									{
										xmlWriter_0.WriteAttributeString(Class5.smethod_0(81017), count.ToString());
									}
								}
								else
								{
									if (num > 100 && num <= count - 100)
									{
										continue;
									}
									int num2 = (int)type.GetField(Class5.smethod_0(81042))!.GetValue(item2);
									int num3 = (int)type.GetField(Class5.smethod_0(81055))!.GetValue(item2);
									int num4 = (int)type.GetField(Class5.smethod_0(81068))!.GetValue(item2);
									object[] array2 = (object[])type.GetField(Class5.smethod_0(81097))!.GetValue(item2);
									Struct16 cO_ = smethod_2(type);
									if (cO_.method_0())
									{
										continue;
									}
									using (new Class35(xmlWriter_0, Class5.smethod_0(81110)))
									{
										xmlWriter_0.WriteAttributeString(Class5.smethod_0(81042), num2.ToString());
										xmlWriter_0.WriteAttributeString(Class5.smethod_0(81068), num4.ToString());
										int num5 = method_9(cO_);
										if (num5 > 0)
										{
											xmlWriter_0.WriteAttributeString(Class5.smethod_0(80513), num5.ToString());
										}
										if (num3 != -1)
										{
											xmlWriter_0.WriteAttributeString(Class5.smethod_0(81055), num3.ToString());
										}
										object[] array3 = array2;
										foreach (object cO_2 in array3)
										{
											try
											{
												method_6(new Class27(cO_2, CO_: true), null);
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
			using (new Class35(xmlWriter_0, Class5.smethod_0(81127)))
			{
				xmlWriter_0.WriteAttributeString(Class5.smethod_0(81140), list_1.Count.ToString());
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
					xmlWriter_0.WriteElementString(Class5.smethod_0(80549), value);
				}
			}
			using (new Class35(xmlWriter_0, Class5.smethod_0(81149)))
			{
				xmlWriter_0.WriteAttributeString(Class5.smethod_0(81140), list_2.Count.ToString());
				for (int l = 0; l < list_2.Count; l++)
				{
					using (new Class35(xmlWriter_0, Class5.smethod_0(80600)))
					{
						Struct15 struct2 = list_2[l];
						xmlWriter_0.WriteAttributeString(Class5.smethod_0(80411), struct2.string_0);
						if (struct2.string_1.Length > 0)
						{
							xmlWriter_0.WriteAttributeString(Class5.smethod_0(81166), struct2.string_1);
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
		using (new Class35(xmlWriter_0, Class5.smethod_0(81097)))
		{
			int i;
			if (5u != 0)
			{
				i = 0;
			}
			Array array2 = default(Array);
			int length = default(int);
			for (; i < list_0.Count; i++)
			{
				Class27 @class = list_0[i];
				object obj = @class.method_1();
				Type type = @class.method_2();
				using (new Class35(xmlWriter_0, Class5.smethod_0(81179)))
				{
					xmlWriter_0.WriteAttributeString(Class5.smethod_0(80411), i.ToString());
					string text = null;
					bool flag = true;
					int num = 81192;
					while (true)
					{
						IL_007d:
						string[] array = Class5.smethod_0(num).Split(new char[1] { ',' });
						foreach (string text2 in array)
						{
							if (text2 != Class5.smethod_0(81192) && type.FullName!.StartsWith(text2))
							{
								flag = false;
								break;
							}
						}
						object[] customAttributes = type.GetCustomAttributes(inherit: true);
						int num2 = 0;
						while (true)
						{
							int num3;
							int num4;
							if (num2 < customAttributes.Length)
							{
								Attribute attribute = (Attribute)customAttributes[num2];
								string name = attribute.GetType().Name;
								if (name != Class5.smethod_0(81193) && name != Class5.smethod_0(81230))
								{
									num3 = num2;
									goto IL_0171;
								}
								num4 = 0;
								if (num4 != 0)
								{
									goto IL_013c;
								}
								flag = (byte)num4 != 0;
							}
							int num5 = (flag ? 1 : 0);
							goto IL_01a0;
							IL_01a0:
							if (num5 != 0)
							{
								try
								{
									text = obj.ToString();
									if (text == type.FullName)
									{
										text = null;
										if (5 == 0)
										{
											goto IL_01ea;
										}
									}
									else if (type.IsEnum)
									{
										text = Enum.Format(type, obj, Class5.smethod_0(81259));
									}
									else
									{
										if (obj is Guid)
										{
											goto IL_01ea;
										}
										text = Class5.smethod_0(80397) + text + Class5.smethod_0(80397);
									}
									goto end_IL_01a6;
									IL_01ea:
									text = Class5.smethod_0(79379) + text + Class5.smethod_0(80392);
									end_IL_01a6:;
								}
								catch
								{
								}
								if (text != null)
								{
									xmlWriter_0.WriteAttributeString(Class5.smethod_0(80402), smethod_1(text));
								}
							}
							if (type.HasElementType)
							{
								method_10(type.GetElementType());
								if (type.IsByRef)
								{
									xmlWriter_0.WriteAttributeString(Class5.smethod_0(80312), Class5.smethod_0(80307));
								}
								if (type.IsPointer)
								{
									xmlWriter_0.WriteAttributeString(Class5.smethod_0(80321), Class5.smethod_0(80307));
								}
								if (!type.IsArray)
								{
									break;
								}
								array2 = (Array)obj;
								xmlWriter_0.WriteAttributeString(Class5.smethod_0(80334), array2.Rank.ToString());
								StringBuilder stringBuilder = new StringBuilder();
								for (int k = 0; k < array2.Rank; k++)
								{
									if (k > 0)
									{
										stringBuilder.Append(',');
									}
									stringBuilder.Append(array2.GetLength(k));
								}
								xmlWriter_0.WriteAttributeString(Class5.smethod_0(80798), stringBuilder.ToString());
								num4 = array2.Rank;
								goto IL_013c;
							}
							method_10(type);
							if (!@class.method_0() || !flag)
							{
								break;
							}
							try
							{
								if (obj is IEnumerable)
								{
									using (new Class35(xmlWriter_0, Class5.smethod_0(81264)))
									{
										int num6 = 0;
										foreach (object item in (IEnumerable)obj)
										{
											if (num6 <= 20)
											{
												method_6(new Class27(item, CO_: false), null);
												int num7 = num6;
												if (0 == 0)
												{
													num7++;
												}
												num6 = num7;
												continue;
											}
											xmlWriter_0.WriteElementString(Class5.smethod_0(81281), string.Empty);
											break;
										}
									}
								}
							}
							catch
							{
							}
							method_15(@class);
							break;
							IL_019b:
							int num8;
							int num9 = num3 + num8;
							goto IL_014e;
							IL_0171:
							num8 = 1;
							if (num8 != 0)
							{
								num = num3 + num8;
								if (7 == 0)
								{
									goto IL_007d;
								}
								num2 = num;
								continue;
							}
							goto IL_019b;
							IL_014e:
							if (num9 >= length)
							{
								break;
							}
							num5 = num9;
							if (0 == 0)
							{
								if (num5 == 10 && length > 16)
								{
									num3 = length - 5;
									if (8 == 0)
									{
										goto IL_0171;
									}
									num9 = num3;
								}
								try
								{
									method_6(new Class27(array2.GetValue(num9), CO_: false), null);
								}
								catch
								{
								}
								num3 = num9;
								num8 = 1;
								goto IL_019b;
							}
							goto IL_01a0;
							IL_013c:
							if (num4 == 1)
							{
								length = array2.Length;
								num9 = 0;
								goto IL_014e;
							}
							break;
						}
						break;
					}
				}
			}
		}
	}

	private void method_15(Class27 CO_)
	{
		FieldInfo[] array;
		int i;
		do
		{
			FieldInfo[] fields = CO_.method_2().GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			array = fields;
			i = 0;
		}
		while (5 == 0);
		for (; i < array.Length; i++)
		{
			FieldInfo fieldInfo = array[i];
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
					if (attribute.GetType().Name == Class5.smethod_0(81230))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					method_6(new Class27(fieldInfo.GetValue(CO_.method_1()), CO_: false), fieldInfo);
				}
			}
			catch
			{
			}
		}
		CO_ = new Class27(CO_.method_1(), CO_.method_2().BaseType, CO_.method_0());
		if ((object)CO_.method_2() != null)
		{
			using (new Class35(xmlWriter_0, Class5.smethod_0(80280)))
			{
				method_8(Class5.smethod_0(81290));
				xmlWriter_0.WriteAttributeString(Class5.smethod_0(80411), list_0.Count.ToString());
			}
			list_0.Add(CO_);
		}
	}

	private void method_16(Exception CO_)
	{
		using (new Class35(xmlWriter_0, Class5.smethod_0(81299)))
		{
			try
			{
				Type type = CO_.GetType();
				method_10(type);
				do
				{
					string value = Class5.smethod_0(80562);
					try
					{
						value = CO_.Message;
					}
					catch
					{
					}
					xmlWriter_0.WriteAttributeString(Class5.smethod_0(81312), value);
				}
				while (false);
				string text = CO_.StackTrace!.Trim();
				int num;
				do
				{
					xmlWriter_0.WriteAttributeString(Class5.smethod_0(81325), text);
					num = text.IndexOf(' ');
					text = text.Substring(num + 1);
				}
				while (6 == 0);
				num = text.IndexOf(Class5.smethod_0(81354));
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				xmlWriter_0.WriteAttributeString(Class5.smethod_0(81359), text);
				method_7(new Class27(CO_, CO_: true));
			}
			catch
			{
			}
		}
	}

	internal bool method_17()
	{
		try
		{
			method_5(Enum0.const_0);
			byte[] cO_;
			try
			{
				cO_ = method_13();
			}
			catch (Exception ex)
			{
				int num = -1;
				try
				{
					StackTrace stackTrace = new StackTrace(ex);
					while (true)
					{
						int num2 = stackTrace.FrameCount;
						while (num2 > 0)
						{
							if (7u != 0)
							{
								StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
								num2 = frame.GetILOffset();
								if (0 == 0)
								{
									num = num2;
									break;
								}
								continue;
							}
							goto IL_0046;
						}
						break;
						IL_0046:;
					}
				}
				catch
				{
				}
				method_4(Enum0.const_0, string.Format(Class5.smethod_0(81368), ex.Message, num));
				bool result;
				do
				{
					result = false;
				}
				while (false ? true : false);
				return result;
			}
			Class26 cO_2 = new Class26(Class5.smethod_0(81192), Class5.smethod_0(81401), Class5.smethod_0(81414));
			return method_1(cO_, cO_2);
		}
		catch (ThreadAbortException)
		{
			if (0 == 0)
			{
				return false;
			}
			bool result;
			return result;
		}
		catch (Exception cO_3)
		{
			method_19(new EventArgs0(cO_3));
			return false;
		}
	}

	[SpecialName]
	public void method_18(Delegate0 CO_)
	{
		if (false)
		{
			goto IL_000f;
		}
		Delegate0 @delegate;
		if (0 == 0)
		{
			@delegate = delegate0_0;
		}
		goto IL_003d;
		IL_002d:
		Delegate0 delegate2;
		if ((object)@delegate == delegate2)
		{
			goto IL_000f;
		}
		goto IL_003d;
		IL_003d:
		if (7u != 0)
		{
			Delegate0 delegate3 = @delegate;
			if (6u != 0)
			{
				delegate2 = delegate3;
			}
			goto IL_0012;
		}
		goto IL_002d;
		IL_000f:
		if (0 == 0)
		{
			return;
		}
		goto IL_0012;
		IL_0012:
		Delegate0 value = (Delegate0)Delegate.Combine(delegate2, CO_);
		@delegate = Interlocked.CompareExchange(ref delegate0_0, value, delegate2);
		goto IL_002d;
	}

	public void method_19(EventArgs0 CO_)
	{
		delegate0_0?.Invoke(this, CO_);
	}

	[SpecialName]
	public void method_20(EventHandler CO_)
	{
		if (false)
		{
			goto IL_000f;
		}
		EventHandler eventHandler;
		if (0 == 0)
		{
			eventHandler = eventHandler_0;
		}
		goto IL_003d;
		IL_002d:
		EventHandler eventHandler2;
		if ((object)eventHandler == eventHandler2)
		{
			goto IL_000f;
		}
		goto IL_003d;
		IL_003d:
		if (7u != 0)
		{
			EventHandler eventHandler3 = eventHandler;
			if (6u != 0)
			{
				eventHandler2 = eventHandler3;
			}
			goto IL_0012;
		}
		goto IL_002d;
		IL_000f:
		if (0 == 0)
		{
			return;
		}
		goto IL_0012;
		IL_0012:
		EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, CO_);
		eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		goto IL_002d;
	}

	internal void method_21()
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			method_22(tempFileName);
			string path = Class3.smethod_0();
			Process.Start(Path.Combine(path, Class5.smethod_0(81459)), Class5.smethod_0(81484) + tempFileName + Class5.smethod_0(80397));
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, EventArgs.Empty);
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception cO_)
		{
			do
			{
				method_19(new EventArgs0(cO_));
			}
			while (3 == 0);
		}
	}

	internal bool method_22(string CO_)
	{
		bool result = default(bool);
		try
		{
			byte[] cO_ = method_13();
			byte[] cO_2;
			try
			{
				do
				{
					cO_2 = Class8.smethod_2(cO_);
				}
				while (1 == 0);
			}
			catch
			{
				cO_2 = null;
			}
			byte[] array = Class21.smethod_0(cO_2, Class5.smethod_0(79700));
			FileStream fileStream = File.OpenWrite(CO_);
			if (true)
			{
				byte[] bytes = Encoding.ASCII.GetBytes(Class5.smethod_0(80080));
				fileStream.Write(bytes, 0, bytes.Length);
				fileStream.Write(array, 0, array.Length);
				fileStream.Close();
			}
			result = true;
			return result;
		}
		catch (ThreadAbortException)
		{
			do
			{
				if (0 == 0 && 8u != 0)
				{
					result = false;
				}
			}
			while (false);
			return result;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
