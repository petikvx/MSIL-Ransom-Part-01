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
					inArray = Class33.smethod_71(array);
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

		internal static bool du9GfN7bUCk4YESmkYG()
		{
			return true;
		}

		internal static bool Y0rMhc7yr11Fs1C0shX()
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

		internal static bool DkOd7g7IT5kqTXgH3yg()
		{
			return true;
		}

		internal static bool RlZ1ht7oDsq7isrE1FJ()
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

		internal static bool WwnRel7lcpDGgMksLqb()
		{
			return true;
		}

		internal static bool V2T4eH7XU2nQkBSIlZ6()
		{
			return false;
		}
	}

	private readonly Exception exception_0;

	private readonly Guid guid_0;

	internal readonly char[] char_0 = new char[0];

	internal readonly Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();

	internal readonly Dictionary<string, Struct11> dictionary_1 = new Dictionary<string, Struct11>();

	internal XmlWriter xmlWriter_0;

	private readonly List<Class34> list_0 = new List<Class34>();

	private readonly List<string> list_1 = new List<string>();

	private readonly Dictionary<string, int> dictionary_2 = new Dictionary<string, int>();

	internal readonly List<Struct12> list_2 = new List<Struct12>();

	internal readonly Dictionary<string, int> dictionary_3 = new Dictionary<string, int>();

	private MemoryStream memoryStream_0;

	private byte[] byte_0;

	internal Delegate10 delegate10_0;

	internal EventHandler eventHandler_0;

	public event Delegate10 FatalException
	{
		add
		{
			if (!kgZ5dp7K5QTgbHY3ESA())
			{
				goto IL_0056;
			}
			Delegate10 @delegate = default(Delegate10);
			switch (0)
			{
			case 0:
				@delegate = delegate10_0;
				break;
			case 1:
			case 3:
				break;
			case 2:
			case 4:
				goto IL_0048;
			default:
				goto IL_0056;
			case 6:
				return;
			}
			goto IL_0039;
			IL_0048:
			Delegate10 value2 = default(Delegate10);
			Delegate10 delegate2 = default(Delegate10);
			@delegate = Interlocked.CompareExchange(ref delegate10_0, value2, delegate2);
			goto IL_0056;
			IL_0056:
			if ((object)@delegate == delegate2)
			{
				return;
			}
			goto IL_0039;
			IL_0039:
			delegate2 = @delegate;
			value2 = (Delegate10)Delegate.Combine(delegate2, value);
			goto IL_0048;
		}
		remove
		{
			Delegate10 @delegate = delegate10_0;
			Delegate10 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate10 value2 = (Delegate10)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate10_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public event EventHandler DebuggerLaunched
	{
		add
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler eventHandler2 = default(EventHandler);
			while (true)
			{
				EventHandler eventHandler = eventHandler_0;
				int num = 2;
				if (!kgZ5dp7K5QTgbHY3ESA())
				{
					break;
				}
				do
				{
					switch (num)
					{
					case 1:
					case 2:
						eventHandler2 = eventHandler;
						goto case 3;
					case 3:
					{
						EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
						eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
						goto default;
					}
					default:
						if ((object)eventHandler != eventHandler2)
						{
							goto case 1;
						}
						goto IL_0024;
					case 0:
					case 4:
						break;
					case 6:
						return;
					}
					break;
					IL_0024:
					num = 6;
				}
				while (kgZ5dp7K5QTgbHY3ESA());
			}
		}
	}

	public Class29(Guid userId, Exception currentException, IWebProxy proxy)
	{
		guid_0 = userId;
		exception_0 = currentException;
		iwebProxy_0 = proxy;
		string text;
		if ((text = Class14.smethod_0(4890).ToUpper()) == null)
		{
			return;
		}
		if (!(text == Class14.smethod_0(4890)))
		{
			if (text == Class14.smethod_0(4899))
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

	private void method_0(Class34 class34_0, FieldInfo fieldInfo_0)
	{
		string text = default(string);
		string text2 = default(string);
		object object_;
		string text3;
		Class43 @class = default(Class43);
		Type type = default(Type);
		string text4 = default(string);
		int num2 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		Class43 class2 = default(Class43);
		while (true)
		{
			IL_0177:
			object obj;
			if ((object)fieldInfo_0 == null)
			{
				obj = null;
				goto IL_016e;
			}
			goto IL_0157;
			IL_031f:
			if (text == null)
			{
				text2 = Class33.smethod_14(object_);
				goto IL_032c;
			}
			goto IL_0386;
			IL_016e:
			text3 = (string)obj;
			string name = (((object)fieldInfo_0 != null) ? Class14.smethod_0(4912) : Class14.smethod_0(4921));
			object_ = class34_0.object_0;
			int num;
			if (object_ == null)
			{
				@class = new Class43(xmlWriter_0, name);
				num = 6;
				if (VMR0GY7C89EH2ljF4AX())
				{
					goto IL_0188;
				}
			}
			else
			{
				type = class34_0.object_0.GetType();
				text4 = null;
				text = null;
				num = 11;
				if (VMR0GY7C89EH2ljF4AX())
				{
					goto IL_0311;
				}
			}
			while (true)
			{
				switch (num)
				{
				case 3:
				case 11:
					if (!(object_ is string))
					{
						goto IL_0076;
					}
					goto case 0;
				case 7:
					if ((object)type.Module != GetType().Module)
					{
						num = 1;
						if (kgZ5dp7K5QTgbHY3ESA())
						{
							continue;
						}
						goto case 0;
					}
					goto IL_0386;
				case 0:
					text4 = Class14.smethod_0(4979);
					goto IL_0076;
				case 9:
					num2 = (char)object_;
					stringBuilder = new StringBuilder();
					if (num2 >= 32)
					{
						num = 10;
						if (kgZ5dp7K5QTgbHY3ESA())
						{
							continue;
						}
						break;
					}
					goto IL_02ca;
				case 5:
					break;
				case 8:
					goto IL_0177;
				case 1:
					goto IL_0188;
				case 2:
				case 6:
					try
					{
						if ((object)fieldInfo_0 != null)
						{
							if (fieldInfo_0.IsStatic)
							{
								xmlWriter_0.WriteAttributeString(Class14.smethod_0(4930), Class14.smethod_0(2062));
							}
							Type fieldType = fieldInfo_0.FieldType;
							if ((object)fieldType != null && fieldType.HasElementType)
							{
								method_3(fieldType.GetElementType());
								if (fieldType.IsByRef)
								{
									xmlWriter_0.WriteAttributeString(Class14.smethod_0(4939), Class14.smethod_0(2062));
								}
								if (fieldType.IsPointer)
								{
									xmlWriter_0.WriteAttributeString(Class14.smethod_0(4948), Class14.smethod_0(2062));
								}
								if (fieldType.IsArray)
								{
									xmlWriter_0.WriteAttributeString(Class14.smethod_0(4961), fieldType.GetArrayRank().ToString());
								}
							}
							else
							{
								method_3(fieldType);
							}
						}
						if (text3 != null)
						{
							method_2(text3);
						}
						xmlWriter_0.WriteAttributeString(Class14.smethod_0(4970), Class14.smethod_0(2062));
						return;
					}
					finally
					{
						((IDisposable)@class)?.Dispose();
					}
				case 10:
					stringBuilder.Append('\'');
					stringBuilder.Append((char)object_);
					stringBuilder.Append(Class14.smethod_0(5000));
					goto IL_02ca;
				default:
					goto IL_0311;
				case 13:
					goto IL_032c;
				case 4:
					goto IL_0386;
				case 14:
					goto end_IL_0177;
					IL_0076:
					if (text4 == null)
					{
						if (type.IsPrimitive || object_ is IntPtr || object_ is UIntPtr)
						{
							text4 = type.FullName;
							if (object_ is char)
							{
								goto case 9;
							}
							goto IL_0308;
						}
						if (type.IsValueType)
						{
							goto case 7;
						}
					}
					goto IL_0386;
					IL_02ca:
					stringBuilder.Append(Class14.smethod_0(5005));
					stringBuilder.Append(num2.ToString(Class14.smethod_0(2031)));
					stringBuilder.Append(')');
					text = stringBuilder.ToString();
					goto IL_0308;
					IL_0308:
					if (object_ is bool)
					{
						goto IL_0311;
					}
					goto IL_031f;
				}
				break;
			}
			goto IL_0157;
			IL_0157:
			obj = fieldInfo_0.Name;
			goto IL_016e;
			IL_0311:
			text = object_.ToString()!.ToLower();
			goto IL_031f;
			IL_0188:
			text4 = type.FullName;
			goto IL_0386;
			IL_0386:
			class2 = new Class43(xmlWriter_0, name);
			break;
			IL_032c:
			if (text2.Length > 0)
			{
				StringBuilder stringBuilder2 = new StringBuilder();
				stringBuilder2.Append(object_.ToString());
				stringBuilder2.Append(Class14.smethod_0(5010));
				stringBuilder2.Append(text2);
				stringBuilder2.Append(')');
				text = stringBuilder2.ToString();
			}
			else
			{
				text = object_.ToString();
			}
			goto IL_0386;
			continue;
			end_IL_0177:
			break;
		}
		try
		{
			if ((object)fieldInfo_0 != null && fieldInfo_0.IsStatic)
			{
				xmlWriter_0.WriteAttributeString(Class14.smethod_0(4930), Class14.smethod_0(2062));
			}
			if (text4 != null)
			{
				method_3(type);
				if (text3 != null)
				{
					method_2(text3);
				}
				if (type.IsEnum)
				{
					text = object_.ToString();
				}
				if (object_ is Guid)
				{
					text = string.Concat(Class14.smethod_0(1697), object_, Class14.smethod_0(5019));
				}
				if (text == null)
				{
					text = string.Concat(Class14.smethod_0(2202), object_, Class14.smethod_0(2202));
				}
				xmlWriter_0.WriteAttributeString(Class14.smethod_0(5024), Class33.smethod_119(text));
			}
			else
			{
				if ((object)fieldInfo_0 != null)
				{
					method_3(fieldInfo_0.FieldType);
				}
				method_1(class34_0);
				if (text3 != null)
				{
					method_2(text3);
				}
			}
		}
		finally
		{
			((IDisposable)class2)?.Dispose();
		}
	}

	internal void method_1(Class34 class34_0)
	{
		int num2 = default(int);
		while (true)
		{
			object object_ = class34_0.object_0;
			int num = 5;
			if (!kgZ5dp7K5QTgbHY3ESA())
			{
				goto IL_003e;
			}
			goto IL_0083;
			IL_0083:
			switch (num)
			{
			case 4:
			case 6:
				break;
			case 5:
				num2 = -1;
				goto IL_003e;
			case 2:
				goto IL_003e;
			default:
				goto IL_0071;
			case 0:
			case 3:
				continue;
			case 7:
				return;
			}
			goto IL_0006;
			IL_003e:
			for (int i = 0; i < list_0.Count; i++)
			{
				if (object.ReferenceEquals(list_0[i].object_0, object_))
				{
					num2 = i;
					break;
				}
			}
			goto IL_0071;
			IL_0006:
			list_0.Add(class34_0);
			goto IL_0012;
			IL_0071:
			if (num2 == -1)
			{
				num2 = list_0.Count;
				goto IL_0006;
			}
			goto IL_0012;
			IL_0012:
			xmlWriter_0.WriteAttributeString(Class14.smethod_0(5033), num2.ToString());
			num = 7;
			if (!kgZ5dp7K5QTgbHY3ESA())
			{
				continue;
			}
			goto IL_0083;
		}
	}

	private void method_2(string string_0)
	{
		while (true)
		{
			int num = Class33.smethod_136(this, string_0);
			while (true)
			{
				if (num == -1)
				{
					xmlWriter_0.WriteAttributeString(Class14.smethod_0(5047), string_0);
					if (!kgZ5dp7K5QTgbHY3ESA())
					{
						continue;
					}
					switch (5)
					{
					default:
						return;
					case 1:
					case 4:
						continue;
					case 0:
						break;
					case 2:
					case 3:
						return;
					case 5:
						return;
					}
					break;
				}
				xmlWriter_0.WriteAttributeString(Class14.smethod_0(5038), num.ToString());
				return;
			}
		}
	}

	private static Struct13 smethod_0(Type type_0)
	{
		Assembly assembly = default(Assembly);
		while (true)
		{
			Struct13 empty = Struct13.Empty;
			while (true)
			{
				if ((object)type_0 != null && (object)type_0.Assembly.GetType(Class14.smethod_0(5056)) != null)
				{
					empty.string_0 = ((type_0.MetadataToken & 0xFFFFFF) - 1).ToString();
					if (!kgZ5dp7K5QTgbHY3ESA())
					{
						break;
					}
					switch (3)
					{
					case 0:
					case 1:
						break;
					case 5:
						goto end_IL_0069;
					case 2:
					case 3:
						assembly = type_0.Assembly;
						goto default;
					default:
						empty.struct12_0 = new Struct12(assembly.ManifestModule.ModuleVersionId.ToString(Class14.smethod_0(5117)), assembly.FullName);
						goto IL_00ad;
					case 6:
						goto IL_00ad;
					}
					continue;
				}
				goto IL_00ad;
				IL_00ad:
				return empty;
				continue;
				end_IL_0069:
				break;
			}
		}
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
			if (!struct13_.IsEmpty)
			{
				xmlWriter_0.WriteAttributeString(Class14.smethod_0(5122), struct13_.string_0);
				int num = Class33.smethod_49(this, struct13_);
				if (num > 0)
				{
					xmlWriter_0.WriteAttributeString(Class14.smethod_0(5135), num.ToString());
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
				if (name.Length > 0 && name != Class14.smethod_0(5148))
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
				int num2 = fullName.LastIndexOf(Class14.smethod_0(5161));
				if (num2 > 0)
				{
					string value2 = fullName.Substring(@namespace.Length + 1, num2 - @namespace.Length).Replace(Class14.smethod_0(5161), Class14.smethod_0(5166));
					stringBuilder.Append(value2);
				}
				stringBuilder.Append(type_0.Name);
				value = list_1.Count;
				list_1.Add(stringBuilder.ToString());
				dictionary_2.Add(fullName, value);
			}
			xmlWriter_0.WriteAttributeString(Class14.smethod_0(5171), value.ToString());
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
		using (new Class43(xmlWriter_0, Class14.smethod_0(5184)))
		{
			xmlWriter_0.WriteAttributeString(Class14.smethod_0(5217), Class14.smethod_0(1264).ToUpper());
			xmlWriter_0.WriteAttributeString(Class14.smethod_0(5234), DateTime.Now.ToString(Class14.smethod_0(5247)));
			xmlWriter_0.WriteAttributeString(Class14.smethod_0(2734), Class33.smethod_101());
			if (guid_0 != Guid.Empty)
			{
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = Class14.smethod_0(5252);
				Guid guid = guid_0;
				xmlWriter.WriteAttributeString(localName, guid.ToString(Class14.smethod_0(5117)));
			}
			xmlWriter_0.WriteAttributeString(Class14.smethod_0(5261), Guid.NewGuid().ToString(Class14.smethod_0(5117)));
			if (list_2.Count > 0)
			{
				list_2.Clear();
			}
			list_2.Add(new Struct12(Class14.smethod_0(1264), string.Empty));
			if (dictionary_3.Count > 0)
			{
				dictionary_3.Clear();
			}
			dictionary_3.Add(Class14.smethod_0(1264), 0);
			using (new Class43(xmlWriter_0, Class14.smethod_0(5274)))
			{
				Assembly assembly = Class33.smethod_92();
				Assembly[] array = Class33.smethod_148(this);
				foreach (Assembly assembly2 in array)
				{
					if ((object)assembly2 == null)
					{
						continue;
					}
					using (new Class43(xmlWriter_0, Class14.smethod_0(5135)))
					{
						try
						{
							xmlWriter_0.WriteAttributeString(Class14.smethod_0(5047), assembly2.FullName);
							xmlWriter_0.WriteAttributeString(Class14.smethod_0(5291), assembly2.CodeBase);
							if ((object)assembly2 == assembly)
							{
								xmlWriter_0.WriteAttributeString(Class14.smethod_0(5304), Class14.smethod_0(2062));
							}
						}
						catch
						{
						}
					}
				}
			}
			using (new Class43(xmlWriter_0, Class14.smethod_0(5313)))
			{
				if (dictionary_0 != null && dictionary_0.Count > 0)
				{
					foreach (string key in dictionary_0.Keys)
					{
						using (new Class43(xmlWriter_0, Class14.smethod_0(5338)))
						{
							xmlWriter_0.WriteAttributeString(Class14.smethod_0(5047), key);
							string text = (string)dictionary_0[key];
							if (text == null)
							{
								xmlWriter_0.WriteAttributeString(Class14.smethod_0(4970), Class14.smethod_0(2062));
							}
							else
							{
								xmlWriter_0.WriteAttributeString(Class14.smethod_0(5024), Class14.smethod_0(2202) + text + Class14.smethod_0(2202));
							}
						}
					}
				}
			}
			if (dictionary_1 != null && dictionary_1.Count > 0)
			{
				using (new Class43(xmlWriter_0, Class14.smethod_0(5359)))
				{
					foreach (string key2 in dictionary_1.Keys)
					{
						using (new Class43(xmlWriter_0, Class14.smethod_0(5380)))
						{
							xmlWriter_0.WriteAttributeString(Class14.smethod_0(5397), key2);
							Struct11 @struct = dictionary_1[key2];
							xmlWriter_0.WriteAttributeString(Class14.smethod_0(5402), @struct.string_0);
							XmlWriter xmlWriter2 = xmlWriter_0;
							string localName2 = Class14.smethod_0(5415);
							int int_ = @struct.int_0;
							xmlWriter2.WriteAttributeString(localName2, int_.ToString());
							if (@struct.string_2.Length > 0)
							{
								xmlWriter_0.WriteAttributeString(Class14.smethod_0(5424), @struct.string_2);
							}
							else
							{
								xmlWriter_0.WriteAttributeString(Class14.smethod_0(5433), @struct.string_1);
							}
						}
					}
				}
			}
			using (new Class43(xmlWriter_0, Class14.smethod_0(5442)))
			{
				try
				{
					xmlWriter_0.WriteElementString(Class14.smethod_0(5467), Environment.Version.ToString());
					xmlWriter_0.WriteElementString(Class14.smethod_0(5484), Environment.OSVersion.Version.ToString());
					xmlWriter_0.WriteElementString(Class14.smethod_0(5497), Environment.OSVersion.Platform.ToString());
					xmlWriter_0.WriteElementString(Class14.smethod_0(5514), Class42.ServicePack);
					xmlWriter_0.WriteElementString(Class14.smethod_0(5531), Class42.IsServerR2 ? Class14.smethod_0(2062) : Class14.smethod_0(5544));
					xmlWriter_0.WriteElementString(Class14.smethod_0(5549), Class42.IsX64 ? Class14.smethod_0(2062) : Class14.smethod_0(5544));
					xmlWriter_0.WriteElementString(Class14.smethod_0(5554), Class42.IsWorkstation ? Class14.smethod_0(2062) : Class14.smethod_0(5544));
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
			using (new Class43(xmlWriter_0, Class14.smethod_0(5571)))
			{
				foreach (Exception item in list)
				{
					try
					{
						Class33.smethod_78(item, this);
						if (!item.Data.Contains(Class14.smethod_0(2635)))
						{
							continue;
						}
						ICollection collection = (ICollection)item.Data[Class14.smethod_0(2635)];
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
									using (new Class43(xmlWriter_0, Class14.smethod_0(5588)))
									{
										xmlWriter_0.WriteAttributeString(Class14.smethod_0(5609), count.ToString());
									}
								}
								else
								{
									if (num > 100 && num <= count - 100)
									{
										continue;
									}
									int num2 = (int)type.GetField(Class14.smethod_0(5634))!.GetValue(item2);
									int num3 = (int)type.GetField(Class14.smethod_0(5647))!.GetValue(item2);
									int num4 = (int)type.GetField(Class14.smethod_0(5660))!.GetValue(item2);
									object[] array2 = (object[])type.GetField(Class14.smethod_0(5689))!.GetValue(item2);
									Struct13 struct13_ = smethod_0(type);
									if (struct13_.IsEmpty)
									{
										continue;
									}
									using (new Class43(xmlWriter_0, Class14.smethod_0(5702)))
									{
										xmlWriter_0.WriteAttributeString(Class14.smethod_0(5634), num2.ToString());
										xmlWriter_0.WriteAttributeString(Class14.smethod_0(5660), num4.ToString());
										int num5 = Class33.smethod_49(this, struct13_);
										if (num5 > 0)
										{
											xmlWriter_0.WriteAttributeString(Class14.smethod_0(5135), num5.ToString());
										}
										if (num3 != -1)
										{
											xmlWriter_0.WriteAttributeString(Class14.smethod_0(5647), num3.ToString());
										}
										object[] array3 = array2;
										foreach (object o in array3)
										{
											try
											{
												method_0(new Class34(o, firstLevel: true), null);
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
			using (new Class43(xmlWriter_0, Class14.smethod_0(5719)))
			{
				xmlWriter_0.WriteAttributeString(Class14.smethod_0(5732), list_1.Count.ToString());
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
					xmlWriter_0.WriteElementString(Class14.smethod_0(5171), value);
				}
			}
			using (new Class43(xmlWriter_0, Class14.smethod_0(5741)))
			{
				xmlWriter_0.WriteAttributeString(Class14.smethod_0(5732), list_2.Count.ToString());
				for (int l = 0; l < list_2.Count; l++)
				{
					using (new Class43(xmlWriter_0, Class14.smethod_0(5217)))
					{
						Struct12 struct2 = list_2[l];
						if (!VMR0GY7C89EH2ljF4AX())
						{
							switch (2)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_0a95;
							case 4:
								goto IL_0aa4;
							}
						}
						xmlWriter_0.WriteAttributeString(Class14.smethod_0(5033), struct2.string_0);
						goto IL_0a95;
						IL_0aa4:
						xmlWriter_0.WriteAttributeString(Class14.smethod_0(5758), struct2.string_1);
						goto end_IL_0a40;
						IL_0a95:
						if (struct2.string_1.Length > 0)
						{
							goto IL_0aa4;
						}
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
		using (new Class43(xmlWriter_0, Class14.smethod_0(5689)))
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				Class34 @class = list_0[i];
				object object_ = @class.object_0;
				Type type_ = @class.type_0;
				using (new Class43(xmlWriter_0, Class14.smethod_0(5771)))
				{
					xmlWriter_0.WriteAttributeString(Class14.smethod_0(5033), i.ToString());
					string text = null;
					bool flag = true;
					string[] array = Class14.smethod_0(257).Split(new char[1] { ',' });
					foreach (string text2 in array)
					{
						if (text2 != Class14.smethod_0(257) && type_.FullName!.StartsWith(text2))
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
						if (!(name != Class14.smethod_0(5784)) || !(name != Class14.smethod_0(5821)))
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
							text = ((text == type_.FullName) ? null : (type_.IsEnum ? Enum.Format(type_, object_, Class14.smethod_0(5850)) : ((!(object_ is Guid)) ? (Class14.smethod_0(2202) + text + Class14.smethod_0(2202)) : (Class14.smethod_0(1697) + text + Class14.smethod_0(5019)))));
						}
						catch
						{
						}
						if (text != null)
						{
							xmlWriter_0.WriteAttributeString(Class14.smethod_0(5024), Class33.smethod_119(text));
						}
					}
					if (type_.HasElementType)
					{
						method_3(type_.GetElementType());
						if (type_.IsByRef)
						{
							xmlWriter_0.WriteAttributeString(Class14.smethod_0(4939), Class14.smethod_0(2062));
						}
						if (type_.IsPointer)
						{
							xmlWriter_0.WriteAttributeString(Class14.smethod_0(4948), Class14.smethod_0(2062));
						}
						if (!type_.IsArray)
						{
							continue;
						}
						Array array2 = (Array)object_;
						xmlWriter_0.WriteAttributeString(Class14.smethod_0(4961), array2.Rank.ToString());
						StringBuilder stringBuilder = new StringBuilder();
						for (int l = 0; l < array2.Rank; l++)
						{
							if (l > 0)
							{
								stringBuilder.Append(',');
							}
							stringBuilder.Append(array2.GetLength(l));
						}
						xmlWriter_0.WriteAttributeString(Class14.smethod_0(5415), stringBuilder.ToString());
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
								method_0(new Class34(array2.GetValue(m), firstLevel: false), null);
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
							using (new Class43(xmlWriter_0, Class14.smethod_0(5855)))
							{
								int num = 0;
								foreach (object item in (IEnumerable)object_)
								{
									while (true)
									{
										if (num > 20)
										{
											if (VMR0GY7C89EH2ljF4AX())
											{
											}
											switch (4)
											{
											default:
												goto end_IL_03d5;
											case 0:
											case 2:
												continue;
											case 5:
												break;
											case 1:
											case 4:
												xmlWriter_0.WriteElementString(Class14.smethod_0(5872), string.Empty);
												goto end_IL_03d5;
											case 3:
												goto end_IL_03d5;
											}
										}
										else
										{
											method_0(new Class34(item, firstLevel: false), null);
											num++;
										}
										break;
									}
									continue;
									end_IL_03d5:
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

	private void method_6(Class34 class34_0)
	{
		int i = default(int);
		FieldInfo[] array = default(FieldInfo[]);
		object[] customAttributes = default(object[]);
		bool flag = default(bool);
		Class43 @class = default(Class43);
		while (true)
		{
			FieldInfo[] fields = class34_0.type_0.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			int num = 5;
			if (kgZ5dp7K5QTgbHY3ESA())
			{
				goto IL_001e;
			}
			goto IL_0123;
			IL_0123:
			for (; i < array.Length; i++)
			{
				FieldInfo fieldInfo = array[i];
				try
				{
					if (fieldInfo.IsLiteral)
					{
						continue;
					}
					if (!fieldInfo.IsStatic)
					{
						goto IL_00af;
					}
					if (kgZ5dp7K5QTgbHY3ESA())
					{
						switch (0)
						{
						case 0:
							break;
						case 4:
							goto end_IL_0058;
						default:
							goto IL_00bc;
						case 1:
						case 3:
							goto IL_00fd;
						case 6:
							goto end_IL_0058;
						}
					}
					if (!fieldInfo.IsInitOnly)
					{
						goto IL_00af;
					}
					goto end_IL_0058;
					IL_00bc:
					for (int j = 0; j < customAttributes.Length; j++)
					{
						Attribute attribute = (Attribute)customAttributes[j];
						if (attribute.GetType().Name == Class14.smethod_0(5821))
						{
							flag = false;
							break;
						}
					}
					goto IL_00fd;
					IL_00af:
					flag = true;
					customAttributes = fieldInfo.GetCustomAttributes(inherit: true);
					goto IL_00bc;
					IL_00fd:
					if (flag)
					{
						method_0(new Class34(fieldInfo.GetValue(class34_0.object_0), firstLevel: false), fieldInfo);
					}
					end_IL_0058:;
				}
				catch
				{
				}
			}
			class34_0 = new Class34(class34_0.object_0, class34_0.type_0.BaseType, class34_0.bool_0);
			if ((object)class34_0.type_0 != null)
			{
				@class = new Class43(xmlWriter_0, Class14.smethod_0(4912));
				num = 0;
				if (VMR0GY7C89EH2ljF4AX())
				{
					break;
				}
				goto IL_001e;
			}
			break;
			IL_001e:
			switch (num)
			{
			case 6:
				break;
			case 5:
				array = fields;
				goto case 1;
			case 1:
				i = 0;
				goto IL_0123;
			default:
				goto IL_0123;
			case 0:
			case 4:
				try
				{
					method_2(Class14.smethod_0(5881));
					xmlWriter_0.WriteAttributeString(Class14.smethod_0(5033), list_0.Count.ToString());
				}
				finally
				{
					((IDisposable)@class)?.Dispose();
				}
				list_0.Add(class34_0);
				return;
			case 7:
				return;
			}
		}
	}

	internal bool method_7()
	{
		try
		{
			Class33.smethod_40((Class28)this, Enum1.const_0);
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
				Class33.smethod_113((Class28)this, Enum1.const_0, string.Format(Class14.smethod_0(5890), ex.Message, num));
				return false;
			}
			Class32 class32_ = new Class32(Class14.smethod_0(257), Class14.smethod_0(5923), Class14.smethod_0(5928));
			return Class33.smethod_2(array, (Class28)this, class32_);
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception fatalException)
		{
			Class33.smethod_131(new EventArgs0(fatalException), this);
			return false;
		}
	}

	internal static bool kgZ5dp7K5QTgbHY3ESA()
	{
		return true;
	}

	internal static bool VMR0GY7C89EH2ljF4AX()
	{
		return false;
	}
}
