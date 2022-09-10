using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Xml;
using ns7;

namespace ns9;

internal class Class29 : Class28
{
	internal struct Struct11
	{
		public readonly string string_0;

		public readonly string string_1;

		public readonly string string_2;

		public readonly int int_0;

		public Struct11(string fileName)
		{
			string_0 = string.Empty;
			string_1 = string.Empty;
			string_2 = string.Empty;
			int_0 = 0;
			try
			{
				FileInfo fileInfo = new FileInfo(fileName);
				string_0 = Path.GetFileName(fileName);
				int_0 = (int)fileInfo.Length;
				byte[] array = new byte[int_0];
				using (FileStream fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					fileStream.Read(array, 0, int_0);
					fileStream.Close();
				}
				byte[] inArray;
				try
				{
					inArray = Class42.smethod_75(array);
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

		internal static bool it4sdWKElCSCbYcqBOJ()
		{
			return true;
		}

		internal static bool vTPaYhK6SD2QOHr3d3i()
		{
			return false;
		}
	}

	internal struct Struct12
	{
		public readonly string string_0;

		public readonly string string_1;

		public Struct12(string assemblyID, string assemblyFullName)
		{
			string_0 = assemblyID;
			string_1 = assemblyFullName;
		}

		internal static bool kUb5mGKrhKD6vjK8Y56()
		{
			return true;
		}

		internal static bool yiHrFrKaC4Wa81hZRCK()
		{
			return false;
		}
	}

	internal struct Struct13
	{
		public string string_0;

		public Struct12 struct12_0;

		public bool IsEmpty => string_0.Length == 0;

		public static Struct13 Empty => new Struct13(string.Empty, string.Empty, string.Empty);

		private Struct13(string id, string assemblyID, string assemblyFullName)
		{
			string_0 = id;
			struct12_0 = new Struct12(assemblyID, assemblyFullName);
		}

		internal static bool SeBO8XK3g4H1K1BBsQq()
		{
			return true;
		}

		internal static bool e5WIgoKSEpKy4gmdDso()
		{
			return false;
		}
	}

	private readonly Exception exception_0;

	private readonly Guid guid_0;

	internal readonly char[] char_0;

	internal readonly Dictionary<string, object> dictionary_0;

	internal readonly Dictionary<string, Struct11> dictionary_1;

	internal XmlWriter xmlWriter_0;

	private readonly List<Class33> list_0;

	private readonly List<string> list_1;

	private readonly Dictionary<string, int> dictionary_2;

	internal readonly List<Struct12> list_2;

	internal readonly Dictionary<string, int> dictionary_3;

	private MemoryStream memoryStream_0;

	private byte[] byte_0;

	internal Delegate9 delegate9_0;

	internal EventHandler eventHandler_0;

	public event Delegate9 FatalException
	{
		add
		{
			Delegate9 @delegate = delegate9_0;
			Delegate9 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate9 value2 = (Delegate9)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate9_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			if (dNC049Kjg84JhI5xb9B())
			{
				goto IL_0056;
			}
			Delegate9 @delegate = default(Delegate9);
			switch (5)
			{
			case 0:
			case 5:
				@delegate = delegate9_0;
				goto IL_005c;
			case 3:
				break;
			default:
				goto IL_0056;
			case 1:
			case 4:
				goto IL_005c;
			case 6:
				return;
			}
			goto IL_003b;
			IL_003b:
			Delegate9 delegate2 = default(Delegate9);
			Delegate9 value2 = (Delegate9)Delegate.Remove(delegate2, value);
			@delegate = Interlocked.CompareExchange(ref delegate9_0, value2, delegate2);
			goto IL_0056;
			IL_0056:
			if ((object)@delegate == delegate2)
			{
				return;
			}
			goto IL_005c;
			IL_005c:
			delegate2 = @delegate;
			goto IL_003b;
		}
	}

	public event EventHandler DebuggerLaunched
	{
		add
		{
			EventHandler value2 = default(EventHandler);
			EventHandler eventHandler2 = default(EventHandler);
			while (true)
			{
				EventHandler eventHandler = eventHandler_0;
				if (dNC049Kjg84JhI5xb9B())
				{
				}
				switch (0)
				{
				case 4:
					break;
				default:
					eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
					if ((object)eventHandler == eventHandler2)
					{
						return;
					}
					goto case 0;
				case 0:
				case 1:
					eventHandler2 = eventHandler;
					goto case 2;
				case 2:
				case 5:
					value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					goto default;
				case 6:
					return;
				}
			}
		}
		remove
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public Class29(Guid userId, Exception currentException, IWebProxy proxy)
	{
		string text = default(string);
		while (true)
		{
			char_0 = new char[0];
			while (true)
			{
				dictionary_0 = new Dictionary<string, object>();
				dictionary_1 = new Dictionary<string, Struct11>();
				list_0 = new List<Class33>();
				list_1 = new List<string>();
				int num = 6;
				if (!dNC049Kjg84JhI5xb9B())
				{
				}
				while (true)
				{
					switch (num)
					{
					case 2:
					case 6:
						dictionary_2 = new Dictionary<string, int>();
						list_2 = new List<Struct12>();
						dictionary_3 = new Dictionary<string, int>();
						base._002Ector();
						goto case 5;
					case 5:
						guid_0 = userId;
						exception_0 = currentException;
						goto default;
					default:
						iwebProxy_0 = proxy;
						if ((text = Class14.smethod_0(1109).ToUpper()) == null)
						{
							return;
						}
						goto IL_0058;
					case 0:
					case 1:
						break;
					case 3:
						goto end_IL_00a1;
					case 7:
						if (text == Class14.smethod_0(1118))
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
						return;
					case 8:
						return;
					}
					break;
					IL_0058:
					if (!(text == Class14.smethod_0(1109)))
					{
						num = 7;
						if (!dNC049Kjg84JhI5xb9B())
						{
						}
						continue;
					}
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
					return;
				}
				continue;
				end_IL_00a1:
				break;
			}
		}
	}

	private void method_0(Class33 class33_0, FieldInfo fieldInfo_0)
	{
		string text;
		string name;
		Class43 @class = default(Class43);
		StringBuilder stringBuilder = default(StringBuilder);
		int num2 = default(int);
		string text5 = default(string);
		StringBuilder stringBuilder2 = default(StringBuilder);
		while (true)
		{
			IL_01c2:
			object obj;
			if ((object)fieldInfo_0 == null)
			{
				obj = null;
				goto IL_01b8;
			}
			goto IL_01b2;
			IL_01b2:
			obj = fieldInfo_0.Name;
			goto IL_01b8;
			IL_01b8:
			text = (string)obj;
			string text2;
			if ((object)fieldInfo_0 == null)
			{
				text2 = Class14.smethod_0(1140);
				goto IL_01a1;
			}
			goto IL_0197;
			IL_0197:
			text2 = Class14.smethod_0(1131);
			goto IL_01a1;
			IL_01a1:
			name = text2;
			object object_ = class33_0.object_0;
			if (object_ == null)
			{
				break;
			}
			Type type = class33_0.object_0.GetType();
			while (true)
			{
				string text3 = null;
				string text4 = null;
				if (object_ is string)
				{
					text3 = Class14.smethod_0(1203);
				}
				int num;
				if (text3 == null)
				{
					if (type.IsPrimitive || object_ is IntPtr)
					{
						goto IL_0160;
					}
					num = 8;
					if (UZKavfKxAviXXsV9qe9())
					{
						goto IL_0077;
					}
				}
				goto IL_03b4;
				IL_03c3:
				try
				{
					if ((object)fieldInfo_0 != null && fieldInfo_0.IsStatic)
					{
						goto IL_042b;
					}
					goto IL_044a;
					IL_042b:
					xmlWriter_0.WriteAttributeString(Class14.smethod_0(1149), Class14.smethod_0(1158));
					goto IL_044a;
					IL_044a:
					if (text3 != null)
					{
						method_3(type);
						if (text != null)
						{
							method_2(text);
						}
						if (!type.IsEnum)
						{
							goto IL_0453;
						}
						text4 = object_.ToString();
						if (UZKavfKxAviXXsV9qe9())
						{
							switch (0)
							{
							case 3:
								break;
							case 0:
								goto IL_0453;
							case 2:
							case 6:
								goto IL_045b;
							default:
								goto IL_0477;
							case 1:
							case 4:
								goto IL_04cb;
							case 7:
								goto IL_04cf;
							}
							goto IL_042b;
						}
					}
					else
					{
						if ((object)fieldInfo_0 != null)
						{
							method_3(fieldInfo_0.FieldType);
						}
						method_1(class33_0);
					}
					goto IL_04cb;
					IL_0453:
					if (object_ is Guid)
					{
						goto IL_045b;
					}
					goto IL_0477;
					IL_04cb:
					if (text == null)
					{
						return;
					}
					goto IL_04cf;
					IL_0477:
					if (text4 == null)
					{
						text4 = string.Concat(Class14.smethod_0(1258), object_, Class14.smethod_0(1258));
					}
					xmlWriter_0.WriteAttributeString(Class14.smethod_0(1263), Class42.smethod_138(text4));
					return;
					IL_04cf:
					method_2(text);
					return;
					IL_045b:
					text4 = string.Concat(Class14.smethod_0(1248), object_, Class14.smethod_0(1253));
					goto IL_0477;
				}
				finally
				{
					((IDisposable)@class)?.Dispose();
				}
				IL_00ba:
				stringBuilder.Append((char)object_);
				stringBuilder.Append(Class14.smethod_0(1224));
				goto IL_00d8;
				IL_00d8:
				stringBuilder.Append(Class14.smethod_0(1229));
				stringBuilder.Append(num2.ToString(Class14.smethod_0(1234)));
				stringBuilder.Append(')');
				goto IL_010a;
				IL_0077:
				switch (num)
				{
				case 4:
					break;
				default:
					goto IL_010a;
				case 5:
				case 8:
					goto IL_0133;
				case 6:
					continue;
				case 13:
					goto end_IL_0184;
				case 1:
				case 7:
					goto IL_01b2;
				case 3:
					goto IL_01c2;
				case 9:
					goto end_IL_01c2;
				case 11:
					if (text5.Length > 0)
					{
						stringBuilder2 = new StringBuilder();
						stringBuilder2.Append(object_.ToString());
						goto case 10;
					}
					text4 = object_.ToString();
					goto IL_03b4;
				case 10:
					stringBuilder2.Append(Class14.smethod_0(1239));
					stringBuilder2.Append(text5);
					goto case 12;
				case 12:
					stringBuilder2.Append(')');
					text4 = stringBuilder2.ToString();
					goto IL_03b4;
				case 2:
					goto IL_03b4;
				case 14:
					goto IL_03c3;
				}
				goto IL_00ba;
				IL_0133:
				if (object_ is UIntPtr)
				{
					goto IL_0160;
				}
				if (type.IsValueType && (object)type.Module != GetType().Module)
				{
					text3 = type.FullName;
				}
				goto IL_03b4;
				IL_0160:
				text3 = type.FullName;
				if (object_ is char)
				{
					num2 = (char)object_;
					stringBuilder = new StringBuilder();
					if (num2 >= 32)
					{
						stringBuilder.Append('\'');
						goto IL_00ba;
					}
					goto IL_00d8;
				}
				goto IL_0126;
				IL_010a:
				text4 = stringBuilder.ToString();
				goto IL_0126;
				IL_03b4:
				@class = new Class43(xmlWriter_0, name);
				goto IL_03c3;
				IL_0126:
				if (object_ is bool)
				{
					text4 = object_.ToString()!.ToLower();
				}
				if (text4 == null)
				{
					text5 = Class42.smethod_56(object_);
					num = 11;
					if (!dNC049Kjg84JhI5xb9B())
					{
					}
					goto IL_0077;
				}
				goto IL_03b4;
				continue;
				end_IL_0184:
				break;
			}
			goto IL_0197;
			continue;
			end_IL_01c2:
			break;
		}
		using (new Class43(xmlWriter_0, name))
		{
			Type fieldType = default(Type);
			if ((object)fieldInfo_0 != null)
			{
				if (fieldInfo_0.IsStatic)
				{
					if (!UZKavfKxAviXXsV9qe9())
					{
						goto IL_027e;
					}
					switch (2)
					{
					case 2:
						break;
					case 1:
					case 4:
						goto IL_027e;
					case 6:
						goto IL_029e;
					default:
						goto IL_02ee;
					case 0:
						goto IL_02f7;
					case 7:
						goto IL_0332;
					}
					xmlWriter_0.WriteAttributeString(Class14.smethod_0(1149), Class14.smethod_0(1158));
				}
				fieldType = fieldInfo_0.FieldType;
				goto IL_027e;
			}
			goto IL_0326;
			IL_02ee:
			if (fieldType.IsArray)
			{
				goto IL_02f7;
			}
			goto IL_0326;
			IL_029e:
			if (fieldType.IsByRef)
			{
				xmlWriter_0.WriteAttributeString(Class14.smethod_0(1163), Class14.smethod_0(1158));
			}
			if (fieldType.IsPointer)
			{
				xmlWriter_0.WriteAttributeString(Class14.smethod_0(1172), Class14.smethod_0(1158));
			}
			goto IL_02ee;
			IL_0326:
			if (text != null)
			{
				method_2(text);
			}
			goto IL_0332;
			IL_0332:
			xmlWriter_0.WriteAttributeString(Class14.smethod_0(1194), Class14.smethod_0(1158));
			return;
			IL_02f7:
			xmlWriter_0.WriteAttributeString(Class14.smethod_0(1185), fieldType.GetArrayRank().ToString());
			goto IL_0326;
			IL_027e:
			if ((object)fieldType != null && fieldType.HasElementType)
			{
				method_3(fieldType.GetElementType());
				goto IL_029e;
			}
			method_3(fieldType);
			goto IL_0326;
		}
	}

	internal void method_1(Class33 class33_0)
	{
		object object_ = class33_0.object_0;
		int num = -1;
		for (int i = 0; i < list_0.Count; i++)
		{
			if (object.ReferenceEquals(list_0[i].object_0, object_))
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			num = list_0.Count;
			list_0.Add(class33_0);
		}
		xmlWriter_0.WriteAttributeString(Class14.smethod_0(1272), num.ToString());
	}

	private void method_2(string string_0)
	{
		int num = 2;
		int num2 = default(int);
		if (UZKavfKxAviXXsV9qe9())
		{
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					num2 = Class42.smethod_39(string_0, this);
					num = 3;
					if (!dNC049Kjg84JhI5xb9B())
					{
					}
					continue;
				default:
					return;
				case 1:
				case 3:
					break;
				case 4:
					return;
				case 5:
					return;
				}
				break;
			}
		}
		if (num2 != -1)
		{
			xmlWriter_0.WriteAttributeString(Class14.smethod_0(1277), num2.ToString());
		}
		else
		{
			xmlWriter_0.WriteAttributeString(Class14.smethod_0(1286), string_0);
		}
	}

	private static Struct13 smethod_0(Type type_0)
	{
		Struct13 empty;
		Assembly assembly = default(Assembly);
		while (true)
		{
			empty = Struct13.Empty;
			if (dNC049Kjg84JhI5xb9B())
			{
			}
			switch (4)
			{
			case 2:
				continue;
			case 1:
			case 4:
				if ((object)type_0 == null)
				{
					break;
				}
				goto case 0;
			case 0:
				if ((object)type_0.Assembly.GetType(Class14.smethod_0(1295)) == null)
				{
					break;
				}
				empty.string_0 = ((type_0.MetadataToken & 0xFFFFFF) - 1).ToString();
				assembly = type_0.Assembly;
				goto default;
			default:
				empty.struct12_0 = new Struct12(assembly.ManifestModule.ModuleVersionId.ToString(Class14.smethod_0(1356)), assembly.FullName);
				break;
			case 6:
				break;
			}
			break;
		}
		return empty;
	}

	internal void method_3(Type type_0)
	{
		if ((object)type_0 == null)
		{
			return;
		}
		try
		{
			Struct13 struct13_ = smethod_0(type_0);
			int num = 9;
			int value = default(int);
			if (UZKavfKxAviXXsV9qe9())
			{
				int num2 = default(int);
				string fullName = default(string);
				StringBuilder stringBuilder = default(StringBuilder);
				string @namespace = default(string);
				int num3 = default(int);
				while (true)
				{
					switch (num)
					{
					default:
						num = 7;
						if (!dNC049Kjg84JhI5xb9B())
						{
						}
						continue;
					case 9:
					{
						if (!struct13_.IsEmpty)
						{
							xmlWriter_0.WriteAttributeString(Class14.smethod_0(1361), struct13_.string_0);
							num2 = Class42.smethod_139(this, struct13_);
							goto case 1;
						}
						fullName = type_0.FullName;
						if (dictionary_2.ContainsKey(fullName))
						{
							value = dictionary_2[fullName];
							break;
						}
						stringBuilder = new StringBuilder();
						string name = type_0.Assembly.GetName().Name;
						if (name.Length > 0 && name != Class14.smethod_0(1387))
						{
							stringBuilder.Append('[');
							stringBuilder.Append(name);
							stringBuilder.Append(']');
						}
						goto case 7;
					}
					case 1:
						if (num2 <= 0)
						{
							return;
						}
						goto case 2;
					case 2:
					case 4:
						xmlWriter_0.WriteAttributeString(Class14.smethod_0(1374), num2.ToString());
						return;
					case 7:
						@namespace = type_0.Namespace;
						if (@namespace.Length > 0)
						{
							stringBuilder.Append(@namespace);
							stringBuilder.Append('.');
						}
						if (type_0.HasElementType)
						{
							goto case 3;
						}
						goto IL_015b;
					case 3:
						type_0 = type_0.GetElementType();
						goto IL_015b;
					case 6:
					case 8:
					{
						string value2 = fullName.Substring(@namespace.Length + 1, num3 - @namespace.Length).Replace(Class14.smethod_0(1400), Class14.smethod_0(1405));
						stringBuilder.Append(value2);
						goto IL_01af;
					}
					case 5:
						dictionary_2.Add(fullName, value);
						break;
					case 0:
					case 10:
						break;
						IL_015b:
						num3 = fullName.LastIndexOf(Class14.smethod_0(1400));
						if (num3 > 0)
						{
							goto case 6;
						}
						goto IL_01af;
						IL_01af:
						stringBuilder.Append(type_0.Name);
						value = list_1.Count;
						list_1.Add(stringBuilder.ToString());
						goto case 5;
					}
					break;
				}
			}
			xmlWriter_0.WriteAttributeString(Class14.smethod_0(1410), value.ToString());
		}
		catch
		{
		}
	}

	internal byte[] method_4()
	{
		if (byte_0 != null)
		{
			return byte_0;
		}
		memoryStream_0 = new MemoryStream();
		xmlWriter_0 = new XmlTextWriter(memoryStream_0, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		xmlWriter_0.WriteStartDocument();
		using (new Class43(xmlWriter_0, Class14.smethod_0(1423)))
		{
			xmlWriter_0.WriteAttributeString(Class14.smethod_0(1456), Class14.smethod_0(1051).ToUpper());
			xmlWriter_0.WriteAttributeString(Class14.smethod_0(1473), DateTime.Now.ToString(Class14.smethod_0(1486)));
			xmlWriter_0.WriteAttributeString(Class14.smethod_0(1491), Class42.smethod_80());
			if (guid_0 != Guid.Empty)
			{
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = Class14.smethod_0(1500);
				Guid guid = guid_0;
				xmlWriter.WriteAttributeString(localName, guid.ToString(Class14.smethod_0(1356)));
			}
			xmlWriter_0.WriteAttributeString(Class14.smethod_0(1509), Guid.NewGuid().ToString(Class14.smethod_0(1356)));
			if (list_2.Count > 0)
			{
				list_2.Clear();
			}
			list_2.Add(new Struct12(Class14.smethod_0(1051), string.Empty));
			if (dictionary_3.Count > 0)
			{
				dictionary_3.Clear();
			}
			dictionary_3.Add(Class14.smethod_0(1051), 0);
			using (new Class43(xmlWriter_0, Class14.smethod_0(1522)))
			{
				Assembly assembly = Class42.smethod_134();
				Assembly[] array = Class42.smethod_24(this);
				foreach (Assembly assembly2 in array)
				{
					if ((object)assembly2 == null)
					{
						continue;
					}
					using (new Class43(xmlWriter_0, Class14.smethod_0(1374)))
					{
						try
						{
							xmlWriter_0.WriteAttributeString(Class14.smethod_0(1286), assembly2.FullName);
							xmlWriter_0.WriteAttributeString(Class14.smethod_0(1539), assembly2.CodeBase);
							if ((object)assembly2 == assembly)
							{
								xmlWriter_0.WriteAttributeString(Class14.smethod_0(1552), Class14.smethod_0(1158));
							}
						}
						catch
						{
						}
					}
				}
			}
			using (new Class43(xmlWriter_0, Class14.smethod_0(1561)))
			{
				if (dictionary_0 != null && dictionary_0.Count > 0)
				{
					foreach (string key in dictionary_0.Keys)
					{
						using (new Class43(xmlWriter_0, Class14.smethod_0(1586)))
						{
							xmlWriter_0.WriteAttributeString(Class14.smethod_0(1286), key);
							string text = (string)dictionary_0[key];
							if (text == null)
							{
								xmlWriter_0.WriteAttributeString(Class14.smethod_0(1194), Class14.smethod_0(1158));
							}
							else
							{
								xmlWriter_0.WriteAttributeString(Class14.smethod_0(1263), Class14.smethod_0(1258) + text + Class14.smethod_0(1258));
							}
						}
					}
				}
			}
			if (dictionary_1 != null && dictionary_1.Count > 0)
			{
				using (new Class43(xmlWriter_0, Class14.smethod_0(1607)))
				{
					foreach (string key2 in dictionary_1.Keys)
					{
						using (new Class43(xmlWriter_0, Class14.smethod_0(1628)))
						{
							xmlWriter_0.WriteAttributeString(Class14.smethod_0(1645), key2);
							Struct11 @struct = dictionary_1[key2];
							xmlWriter_0.WriteAttributeString(Class14.smethod_0(1650), @struct.string_0);
							XmlWriter xmlWriter2 = xmlWriter_0;
							string localName2 = Class14.smethod_0(1663);
							int int_ = @struct.int_0;
							xmlWriter2.WriteAttributeString(localName2, int_.ToString());
							if (@struct.string_2.Length > 0)
							{
								xmlWriter_0.WriteAttributeString(Class14.smethod_0(1672), @struct.string_2);
							}
							else
							{
								xmlWriter_0.WriteAttributeString(Class14.smethod_0(1681), @struct.string_1);
							}
						}
					}
				}
			}
			using (new Class43(xmlWriter_0, Class14.smethod_0(1690)))
			{
				try
				{
					xmlWriter_0.WriteElementString(Class14.smethod_0(1715), Environment.Version.ToString());
					xmlWriter_0.WriteElementString(Class14.smethod_0(1732), Environment.OSVersion.Version.ToString());
					xmlWriter_0.WriteElementString(Class14.smethod_0(1745), Environment.OSVersion.Platform.ToString());
					xmlWriter_0.WriteElementString(Class14.smethod_0(1762), Class41.ServicePack);
					xmlWriter_0.WriteElementString(Class14.smethod_0(1779), Class41.IsServerR2 ? Class14.smethod_0(1158) : Class14.smethod_0(1792));
					xmlWriter_0.WriteElementString(Class14.smethod_0(1797), Class41.IsX64 ? Class14.smethod_0(1158) : Class14.smethod_0(1792));
					xmlWriter_0.WriteElementString(Class14.smethod_0(1802), Class41.IsWorkstation ? Class14.smethod_0(1158) : Class14.smethod_0(1792));
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
			using (new Class43(xmlWriter_0, Class14.smethod_0(1819)))
			{
				foreach (Exception item in list)
				{
					try
					{
						Class42.smethod_135(this, item);
						if (!item.Data.Contains(Class14.smethod_0(1836)))
						{
							continue;
						}
						ICollection collection = (ICollection)item.Data[Class14.smethod_0(1836)];
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
									using (new Class43(xmlWriter_0, Class14.smethod_0(1861)))
									{
										xmlWriter_0.WriteAttributeString(Class14.smethod_0(1882), count.ToString());
									}
								}
								else
								{
									if (num > 100 && num <= count - 100)
									{
										continue;
									}
									int num2 = (int)type.GetField(Class14.smethod_0(1907))!.GetValue(item2);
									int num3 = (int)type.GetField(Class14.smethod_0(1920))!.GetValue(item2);
									int num4 = (int)type.GetField(Class14.smethod_0(1933))!.GetValue(item2);
									object[] array2 = (object[])type.GetField(Class14.smethod_0(1962))!.GetValue(item2);
									Struct13 struct13_ = smethod_0(type);
									if (struct13_.IsEmpty)
									{
										continue;
									}
									using (new Class43(xmlWriter_0, Class14.smethod_0(1975)))
									{
										xmlWriter_0.WriteAttributeString(Class14.smethod_0(1907), num2.ToString());
										xmlWriter_0.WriteAttributeString(Class14.smethod_0(1933), num4.ToString());
										int num5 = Class42.smethod_139(this, struct13_);
										if (num5 > 0)
										{
											xmlWriter_0.WriteAttributeString(Class14.smethod_0(1374), num5.ToString());
										}
										if (num3 != -1)
										{
											xmlWriter_0.WriteAttributeString(Class14.smethod_0(1920), num3.ToString());
										}
										object[] array3 = array2;
										foreach (object o in array3)
										{
											try
											{
												method_0(new Class33(o, firstLevel: true), null);
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
			method_5();
			using (new Class43(xmlWriter_0, Class14.smethod_0(1992)))
			{
				xmlWriter_0.WriteAttributeString(Class14.smethod_0(2005), list_1.Count.ToString());
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
					xmlWriter_0.WriteElementString(Class14.smethod_0(1410), value);
				}
			}
			using (new Class43(xmlWriter_0, Class14.smethod_0(2014)))
			{
				xmlWriter_0.WriteAttributeString(Class14.smethod_0(2005), list_2.Count.ToString());
				for (int l = 0; l < list_2.Count; l++)
				{
					using (new Class43(xmlWriter_0, Class14.smethod_0(1456)))
					{
						Struct12 struct2 = list_2[l];
						if (UZKavfKxAviXXsV9qe9())
						{
							switch (3)
							{
							case 0:
							case 3:
								xmlWriter_0.WriteAttributeString(Class14.smethod_0(1272), struct2.string_0);
								break;
							case 4:
								goto IL_0aa4;
							}
						}
						if (struct2.string_1.Length > 0)
						{
							goto IL_0aa4;
						}
						goto end_IL_0a40;
						IL_0aa4:
						xmlWriter_0.WriteAttributeString(Class14.smethod_0(2031), struct2.string_1);
						end_IL_0a40:;
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

	private void method_5()
	{
		using (new Class43(xmlWriter_0, Class14.smethod_0(1962)))
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				Class33 @class = list_0[i];
				object object_ = @class.object_0;
				Type type_ = @class.type_0;
				using (new Class43(xmlWriter_0, Class14.smethod_0(2044)))
				{
					xmlWriter_0.WriteAttributeString(Class14.smethod_0(1272), i.ToString());
					string text = null;
					bool flag = true;
					string[] array = Class14.smethod_0(187).Split(new char[1] { ',' });
					foreach (string text2 in array)
					{
						if (text2 != Class14.smethod_0(187) && type_.FullName!.StartsWith(text2))
						{
							flag = false;
							break;
						}
					}
					object[] customAttributes = type_.GetCustomAttributes(inherit: true);
					for (int k = 0; k < customAttributes.Length; k++)
					{
						Attribute attribute = (Attribute)customAttributes[k];
						string name = attribute.GetType().Name;
						if (!(name != Class14.smethod_0(2057)) || !(name != Class14.smethod_0(2094)))
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						try
						{
							text = object_.ToString();
							text = ((text == type_.FullName) ? null : (type_.IsEnum ? Enum.Format(type_, object_, Class14.smethod_0(2123)) : ((!(object_ is Guid)) ? (Class14.smethod_0(1258) + text + Class14.smethod_0(1258)) : (Class14.smethod_0(1248) + text + Class14.smethod_0(1253)))));
						}
						catch
						{
						}
						if (text != null)
						{
							xmlWriter_0.WriteAttributeString(Class14.smethod_0(1263), Class42.smethod_138(text));
						}
					}
					if (type_.HasElementType)
					{
						method_3(type_.GetElementType());
						if (type_.IsByRef)
						{
							xmlWriter_0.WriteAttributeString(Class14.smethod_0(1163), Class14.smethod_0(1158));
						}
						if (type_.IsPointer)
						{
							xmlWriter_0.WriteAttributeString(Class14.smethod_0(1172), Class14.smethod_0(1158));
						}
						if (!type_.IsArray)
						{
							continue;
						}
						Array array2 = (Array)object_;
						xmlWriter_0.WriteAttributeString(Class14.smethod_0(1185), array2.Rank.ToString());
						StringBuilder stringBuilder = new StringBuilder();
						for (int l = 0; l < array2.Rank; l++)
						{
							if (l > 0)
							{
								stringBuilder.Append(',');
							}
							stringBuilder.Append(array2.GetLength(l));
						}
						xmlWriter_0.WriteAttributeString(Class14.smethod_0(1663), stringBuilder.ToString());
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
								method_0(new Class33(array2.GetValue(m), firstLevel: false), null);
							}
							catch
							{
							}
						}
						continue;
					}
					method_3(type_);
					if (!@class.bool_0 || !flag)
					{
						continue;
					}
					try
					{
						if (object_ is IEnumerable)
						{
							using (new Class43(xmlWriter_0, Class14.smethod_0(2128)))
							{
								int num = 0;
								foreach (object item in (IEnumerable)object_)
								{
									if (num <= 20)
									{
										method_0(new Class33(item, firstLevel: false), null);
										num++;
										continue;
									}
									xmlWriter_0.WriteElementString(Class14.smethod_0(2145), string.Empty);
									break;
								}
							}
						}
					}
					catch
					{
					}
					method_6(@class);
				}
			}
		}
	}

	private void method_6(Class33 class33_0)
	{
		FieldInfo[] fields = class33_0.type_0.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		FieldInfo[] array = fields;
		bool flag = default(bool);
		foreach (FieldInfo fieldInfo in array)
		{
			try
			{
				if (fieldInfo.IsLiteral)
				{
					if (dNC049Kjg84JhI5xb9B())
					{
					}
					switch (5)
					{
					case 0:
					case 5:
						break;
					case 1:
						goto IL_00b7;
					default:
						goto IL_00ba;
					case 6:
						break;
					}
				}
				else
				{
					if (fieldInfo.IsStatic && fieldInfo.IsInitOnly)
					{
						continue;
					}
					flag = true;
					object[] customAttributes = fieldInfo.GetCustomAttributes(inherit: true);
					int num = 0;
					while (num < customAttributes.Length)
					{
						Attribute attribute = (Attribute)customAttributes[num];
						if (!(attribute.GetType().Name == Class14.smethod_0(2094)))
						{
							num++;
							continue;
						}
						goto IL_00b7;
					}
					goto IL_00ba;
				}
				goto end_IL_001f;
				IL_00b7:
				flag = false;
				goto IL_00ba;
				IL_00ba:
				if (flag)
				{
					method_0(new Class33(fieldInfo.GetValue(class33_0.object_0), firstLevel: false), fieldInfo);
				}
				end_IL_001f:;
			}
			catch
			{
			}
		}
		class33_0 = new Class33(class33_0.object_0, class33_0.type_0.BaseType, class33_0.bool_0);
		if ((object)class33_0.type_0 != null)
		{
			using (new Class43(xmlWriter_0, Class14.smethod_0(1131)))
			{
				method_2(Class14.smethod_0(2154));
				xmlWriter_0.WriteAttributeString(Class14.smethod_0(1272), list_0.Count.ToString());
			}
			list_0.Add(class33_0);
		}
	}

	internal bool method_7()
	{
		try
		{
			Class42.smethod_97((Class28)this, Enum1.const_0);
			byte[] array;
			try
			{
				array = method_4();
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
				Class42.smethod_146((Class28)this, Enum1.const_0, string.Format(Class14.smethod_0(2163), ex.Message, num));
				return false;
			}
			Class32 class32_ = new Class32(Class14.smethod_0(187), Class14.smethod_0(2196), Class14.smethod_0(2201));
			return Class42.smethod_144(class32_, array, (Class28)this);
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception fatalException)
		{
			Class42.smethod_105(this, new EventArgs0(fatalException));
			return false;
		}
	}

	internal static bool UZKavfKxAviXXsV9qe9()
	{
		return true;
	}

	internal static bool dNC049Kjg84JhI5xb9B()
	{
		return false;
	}
}
