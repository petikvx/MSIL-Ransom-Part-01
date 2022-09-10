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

namespace ns11;

internal class Class45 : Class44
{
	internal struct Struct20
	{
		public readonly string string_0;

		public readonly string string_1;

		public readonly string string_2;

		public readonly int int_0;

		public Struct20(string fileName)
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
					inArray = Class58.smethod_56(array);
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

		internal static bool PFsJvvZpcwDapHinSrl()
		{
			return true;
		}

		internal static bool QjYvMJZhmPlPjXOBW7x()
		{
			return false;
		}
	}

	internal struct Struct21
	{
		public readonly string string_0;

		public readonly string string_1;

		public Struct21(string assemblyID, string assemblyFullName)
		{
			string_0 = assemblyID;
			string_1 = assemblyFullName;
		}

		internal static bool GQBcoXZaiwtc5BA6a8n()
		{
			return true;
		}

		internal static bool FRfp7NZL8lqDSW6mVB7()
		{
			return false;
		}
	}

	internal struct Struct22
	{
		public string string_0;

		public Struct21 struct21_0;

		public bool IsEmpty => string_0.Length == 0;

		public static Struct22 Empty => new Struct22(string.Empty, string.Empty, string.Empty);

		private Struct22(string id, string assemblyID, string assemblyFullName)
		{
			string_0 = id;
			struct21_0 = new Struct21(assemblyID, assemblyFullName);
		}

		internal static bool FVa2mbZMJuT87tjGT5N()
		{
			return true;
		}

		internal static bool zWWjyNZTfdIJguIKKfg()
		{
			return false;
		}
	}

	private readonly Exception exception_0;

	private readonly Guid guid_0;

	internal readonly char[] char_0;

	internal readonly Dictionary<string, object> dictionary_0;

	internal readonly Dictionary<string, Struct20> dictionary_1;

	internal XmlWriter xmlWriter_0;

	private readonly List<Class49> list_0;

	private readonly List<string> list_1;

	private readonly Dictionary<string, int> dictionary_2;

	internal readonly List<Struct21> list_2;

	internal readonly Dictionary<string, int> dictionary_3;

	private MemoryStream memoryStream_0;

	private byte[] byte_0;

	internal Delegate19 delegate19_0;

	internal EventHandler eventHandler_0;

	public event Delegate19 FatalException
	{
		add
		{
			Delegate19 @delegate = delegate19_0;
			Delegate19 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate19 value2 = (Delegate19)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate19_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			Delegate19 @delegate = delegate19_0;
			Delegate19 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate19 value2 = (Delegate19)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate19_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public event EventHandler DebuggerLaunched
	{
		add
		{
			if (!RtOvMaZPBkyB76fasd9())
			{
				goto IL_004f;
			}
			EventHandler eventHandler = default(EventHandler);
			switch (3)
			{
			case 0:
			case 3:
				eventHandler = eventHandler_0;
				goto IL_004f;
			case 1:
			case 2:
				break;
			default:
				goto IL_0049;
			case 5:
				goto IL_004f;
			case 6:
				return;
			}
			goto IL_003b;
			IL_003b:
			EventHandler value2 = default(EventHandler);
			EventHandler eventHandler2 = default(EventHandler);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			goto IL_0049;
			IL_0049:
			if ((object)eventHandler == eventHandler2)
			{
				return;
			}
			goto IL_004f;
			IL_004f:
			eventHandler2 = eventHandler;
			value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
			goto IL_003b;
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

	public Class45(Guid userId, Exception currentException, IWebProxy proxy)
	{
		while (true)
		{
			char_0 = new char[0];
			while (true)
			{
				IL_00f9:
				dictionary_0 = new Dictionary<string, object>();
				dictionary_1 = new Dictionary<string, Struct20>();
				int num = 6;
				if (ltCZl8ZeuCbBCuFIClM())
				{
					goto IL_003b;
				}
				goto IL_00cb;
				IL_00cb:
				while (true)
				{
					switch (num)
					{
					case 6:
						list_0 = new List<Class49>();
						list_1 = new List<string>();
						dictionary_2 = new Dictionary<string, int>();
						num = 1;
						if (ltCZl8ZeuCbBCuFIClM())
						{
						}
						continue;
					case 1:
						list_2 = new List<Struct21>();
						dictionary_3 = new Dictionary<string, int>();
						break;
					case 2:
						goto IL_00f9;
					case 0:
						goto end_IL_00f9;
					case 5:
					case 7:
						return;
					case 8:
						return;
					}
					break;
				}
				goto IL_003b;
				IL_003b:
				base._002Ector();
				guid_0 = userId;
				exception_0 = currentException;
				iwebProxy_0 = proxy;
				switch ("ASCII".ToUpper())
				{
				default:
					return;
				case "UNICODE":
					break;
				case "ASCII":
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
				char_0 = new char[58]
				{
					'\u0001', '\u0002', '\u0003', '\u0004', '\u0005', '\u0006', '\a', '\b', '\u000e', '\u000f',
					'\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017', '\u0018', '\u0019',
					'\u001a', '\u001b', '\u001c', '\u001d', '\u001e', '\u001f', '\u007f', '\u0080', '\u0081', '\u0082',
					'\u0083', '\u0084', '\u0086', '\u0087', '\u0088', '\u0089', '\u008a', '\u008b', '\u008c', '\u008d',
					'\u008e', '\u008f', '\u0090', '\u0091', '\u0092', '\u0093', '\u0094', '\u0095', '\u0096', '\u0097',
					'\u0098', '\u0099', '\u009a', '\u009b', '\u009c', '\u009d', '\u009e', '\u009f'
				};
				num = 8;
				if (!RtOvMaZPBkyB76fasd9())
				{
					return;
				}
				goto IL_00cb;
				continue;
				end_IL_00f9:
				break;
			}
		}
	}

	private void method_0(Class49 class49_0, FieldInfo fieldInfo_0)
	{
		int num = 11;
		if (!RtOvMaZPBkyB76fasd9())
		{
			goto IL_0162;
		}
		goto IL_0202;
		IL_0202:
		StringBuilder stringBuilder = default(StringBuilder);
		string text4 = default(string);
		string text3 = default(string);
		string text = default(string);
		Type type = default(Type);
		string text2 = default(string);
		object object_ = default(object);
		Class59 @class = default(Class59);
		switch (num)
		{
		case 5:
			goto IL_006e;
		case 11:
			goto IL_00a8;
		case 1:
			goto IL_00ab;
		case 2:
		case 7:
			goto IL_00ce;
		case 4:
			goto IL_00e3;
		case 0:
			goto IL_00f9;
		case 6:
		case 8:
			goto IL_0162;
		case 10:
			goto IL_016a;
		case 12:
			stringBuilder.Append(text4);
			stringBuilder.Append(')');
			text3 = stringBuilder.ToString();
			goto IL_01b8;
		case 9:
			stringBuilder.Append(" (0x");
			goto case 12;
		case 3:
			goto IL_0249;
		case 14:
			try
			{
				if ((object)fieldInfo_0 != null && fieldInfo_0.IsStatic)
				{
					xmlWriter_0.WriteAttributeString("Static", "1");
				}
				if (text != null)
				{
					method_3(type);
					if (text2 != null)
					{
						method_2(text2);
					}
					if (type.IsEnum)
					{
						text3 = object_.ToString();
					}
					if (object_ is Guid)
					{
						text3 = string.Concat("{", object_, "}");
					}
					if (text3 == null)
					{
						text3 = string.Concat("\"", object_, "\"");
					}
					xmlWriter_0.WriteAttributeString("Value", Class58.smethod_84(text3));
				}
				else
				{
					if ((object)fieldInfo_0 != null)
					{
						method_3(fieldInfo_0.FieldType);
					}
					method_1(class49_0);
					if (text2 != null)
					{
						method_2(text2);
					}
				}
				return;
			}
			finally
			{
				((IDisposable)@class)?.Dispose();
			}
		}
		goto IL_0015;
		IL_01b8:
		string name = default(string);
		@class = new Class59(xmlWriter_0, name);
		num = 14;
		if (ltCZl8ZeuCbBCuFIClM())
		{
		}
		goto IL_0202;
		IL_016a:
		Class59 class2 = new Class59(xmlWriter_0, name);
		num = 3;
		if (!ltCZl8ZeuCbBCuFIClM())
		{
			goto IL_0202;
		}
		goto IL_0249;
		IL_0249:
		try
		{
			Type fieldType = default(Type);
			if ((object)fieldInfo_0 != null)
			{
				if (fieldInfo_0.IsStatic)
				{
					if (!RtOvMaZPBkyB76fasd9())
					{
						goto IL_030c;
					}
					switch (0)
					{
					case 0:
						break;
					case 5:
						goto IL_02e5;
					case 6:
						goto IL_02ee;
					default:
						goto IL_030c;
					case 2:
					case 4:
						goto IL_0336;
					case 7:
						goto IL_0342;
					}
					xmlWriter_0.WriteAttributeString("Static", "1");
				}
				fieldType = fieldInfo_0.FieldType;
				if ((object)fieldType != null && fieldType.HasElementType)
				{
					method_3(fieldType.GetElementType());
					if (fieldType.IsByRef)
					{
						xmlWriter_0.WriteAttributeString("ByRef", "1");
					}
					goto IL_02e5;
				}
				method_3(fieldType);
			}
			goto IL_0336;
			IL_0336:
			if (text2 != null)
			{
				method_2(text2);
			}
			goto IL_0342;
			IL_02e5:
			if (fieldType.IsPointer)
			{
				goto IL_02ee;
			}
			goto IL_0303;
			IL_02ee:
			xmlWriter_0.WriteAttributeString("Pointer", "1");
			goto IL_0303;
			IL_0303:
			if (fieldType.IsArray)
			{
				goto IL_030c;
			}
			goto IL_0336;
			IL_0342:
			xmlWriter_0.WriteAttributeString("Null", "1");
			return;
			IL_030c:
			xmlWriter_0.WriteAttributeString("Rank", fieldType.GetArrayRank().ToString());
			goto IL_0336;
		}
		finally
		{
			((IDisposable)class2)?.Dispose();
		}
		IL_00f9:
		if (type.IsPrimitive || object_ is IntPtr || object_ is UIntPtr)
		{
			text = type.FullName;
			if (object_ is char)
			{
				goto IL_0015;
			}
			goto IL_005e;
		}
		if (type.IsValueType && (object)type.Module != GetType().Module)
		{
			text = type.FullName;
		}
		goto IL_01b8;
		IL_00a8:
		if ((object)fieldInfo_0 != null)
		{
			goto IL_00ab;
		}
		object obj = null;
		goto IL_00b4;
		IL_006e:
		text4 = Class58.smethod_154(object_);
		if (text4.Length > 0)
		{
			stringBuilder = new StringBuilder();
			stringBuilder.Append(object_.ToString());
			num = 9;
			if (!RtOvMaZPBkyB76fasd9())
			{
				goto IL_00a8;
			}
			goto IL_0202;
		}
		text3 = object_.ToString();
		goto IL_01b8;
		IL_00ce:
		if (object_ != null)
		{
			type = class49_0.object_0.GetType();
			text = null;
			goto IL_00e3;
		}
		goto IL_016a;
		IL_00ab:
		obj = fieldInfo_0.Name;
		goto IL_00b4;
		IL_00e3:
		text3 = null;
		if (object_ is string)
		{
			text = "System.String";
		}
		if (text == null)
		{
			goto IL_00f9;
		}
		goto IL_01b8;
		IL_005e:
		if (object_ is bool)
		{
			text3 = object_.ToString()!.ToLower();
		}
		goto IL_0162;
		IL_0015:
		int num2 = (char)object_;
		StringBuilder stringBuilder2 = new StringBuilder();
		if (num2 >= 32)
		{
			stringBuilder2.Append('\'');
			stringBuilder2.Append((char)object_);
			stringBuilder2.Append("' ");
		}
		stringBuilder2.Append("(0x");
		stringBuilder2.Append(num2.ToString("x"));
		stringBuilder2.Append(')');
		text3 = stringBuilder2.ToString();
		goto IL_005e;
		IL_0162:
		if (text3 == null)
		{
			goto IL_006e;
		}
		goto IL_01b8;
		IL_00b4:
		text2 = (string)obj;
		name = (((object)fieldInfo_0 == null) ? "Object" : "Field");
		object_ = class49_0.object_0;
		goto IL_00ce;
	}

	internal void method_1(Class49 class49_0)
	{
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			object object_ = class49_0.object_0;
			int num = 6;
			if (!RtOvMaZPBkyB76fasd9())
			{
				goto IL_005c;
			}
			goto IL_0091;
			IL_0091:
			switch (num)
			{
			case 6:
				break;
			case 5:
				num2 = 0;
				while (num2 < list_0.Count)
				{
					if (!object.ReferenceEquals(list_0[num2].object_0, object_))
					{
						num2++;
						continue;
					}
					goto default;
				}
				goto IL_004c;
			default:
				num3 = num2;
				goto IL_004c;
			case 2:
			case 4:
				goto IL_005c;
			case 0:
				continue;
			case 7:
				return;
				IL_004c:
				if (num3 == -1)
				{
					num3 = list_0.Count;
					goto IL_005c;
				}
				goto IL_0068;
			}
			goto IL_0006;
			IL_005c:
			list_0.Add(class49_0);
			goto IL_0068;
			IL_0068:
			xmlWriter_0.WriteAttributeString("ID", num3.ToString());
			num = 7;
			if (!RtOvMaZPBkyB76fasd9())
			{
				goto IL_0006;
			}
			goto IL_0091;
			IL_0006:
			num3 = -1;
			num = 5;
			if (ltCZl8ZeuCbBCuFIClM())
			{
				break;
			}
			goto IL_0091;
		}
	}

	private void method_2(string string_0)
	{
		while (true)
		{
			int num = Class58.smethod_115(string_0, this);
			while (true)
			{
				if (num == -1)
				{
					xmlWriter_0.WriteAttributeString("Name", string_0);
					if (RtOvMaZPBkyB76fasd9())
					{
						switch (5)
						{
						case 0:
						case 1:
							break;
						case 4:
							goto end_IL_0042;
						default:
							goto IL_0052;
						case 5:
							return;
						}
					}
					continue;
				}
				goto IL_0052;
				IL_0052:
				xmlWriter_0.WriteAttributeString("NameID", num.ToString());
				return;
				continue;
				end_IL_0042:
				break;
			}
		}
	}

	private static Struct22 smethod_0(Type type_0)
	{
		if (!ltCZl8ZeuCbBCuFIClM())
		{
			switch (5)
			{
			case 0:
			case 5:
				break;
			case 2:
				goto IL_0038;
			case 1:
				goto IL_003b;
			default:
				goto IL_004d;
			case 6:
				goto IL_009b;
			}
		}
		Struct22 empty = Struct22.Empty;
		goto IL_0038;
		IL_009b:
		return empty;
		IL_004d:
		empty.string_0 = ((type_0.MetadataToken & 0xFFFFFF) - 1).ToString();
		Assembly assembly = type_0.Assembly;
		empty.struct21_0 = new Struct21(assembly.ManifestModule.ModuleVersionId.ToString("B"), assembly.FullName);
		goto IL_009b;
		IL_0038:
		if ((object)type_0 != null)
		{
			goto IL_003b;
		}
		goto IL_009b;
		IL_003b:
		if ((object)type_0.Assembly.GetType("SmartAssembly.Attributes.PoweredByAttribute") != null)
		{
			goto IL_004d;
		}
		goto IL_009b;
	}

	internal void method_3(Type type_0)
	{
		if ((object)type_0 == null)
		{
			return;
		}
		try
		{
			Struct22 struct22_ = smethod_0(type_0);
			string fullName = default(string);
			StringBuilder stringBuilder = default(StringBuilder);
			string name = default(string);
			int value = default(int);
			string @namespace = default(string);
			while (true)
			{
				int num;
				if (struct22_.IsEmpty)
				{
					fullName = type_0.FullName;
					if (!dictionary_2.ContainsKey(fullName))
					{
						stringBuilder = new StringBuilder();
						name = type_0.Assembly.GetName().Name;
						if (name.Length <= 0 || !(name != "mscorlib"))
						{
							goto IL_0086;
						}
						stringBuilder.Append('[');
						goto IL_019a;
					}
					value = dictionary_2[fullName];
					num = 8;
					if (!RtOvMaZPBkyB76fasd9())
					{
						goto IL_0106;
					}
				}
				else
				{
					num = 9;
					if (ltCZl8ZeuCbBCuFIClM())
					{
					}
				}
				goto IL_01bf;
				IL_019a:
				stringBuilder.Append(name);
				stringBuilder.Append(']');
				goto IL_0086;
				IL_0131:
				stringBuilder.Append(@namespace);
				num = 1;
				if (!RtOvMaZPBkyB76fasd9())
				{
					goto IL_018c;
				}
				goto IL_01bf;
				IL_018c:
				stringBuilder.Append('.');
				goto IL_0099;
				IL_0099:
				if (!type_0.HasElementType)
				{
					goto IL_00a4;
				}
				goto IL_0147;
				IL_0147:
				type_0 = type_0.GetElementType();
				goto IL_00a4;
				IL_00a4:
				int num2 = fullName.LastIndexOf("+");
				if (num2 > 0)
				{
					string value2 = fullName.Substring(@namespace.Length + 1, num2 - @namespace.Length).Replace("+", "/");
					stringBuilder.Append(value2);
				}
				stringBuilder.Append(type_0.Name);
				value = list_1.Count;
				list_1.Add(stringBuilder.ToString());
				dictionary_2.Add(fullName, value);
				num = 10;
				if (!RtOvMaZPBkyB76fasd9())
				{
					goto IL_0131;
				}
				goto IL_01bf;
				IL_0086:
				@namespace = type_0.Namespace;
				if (@namespace.Length <= 0)
				{
					goto IL_0099;
				}
				num = 5;
				if (!RtOvMaZPBkyB76fasd9())
				{
					goto IL_0147;
				}
				goto IL_01bf;
				IL_0106:
				xmlWriter_0.WriteAttributeString("TypeDefID", struct22_.string_0);
				num = 3;
				if (!RtOvMaZPBkyB76fasd9())
				{
					continue;
				}
				goto IL_01bf;
				IL_01bf:
				switch (num)
				{
				case 9:
					break;
				case 5:
					goto IL_0131;
				case 7:
					goto IL_0147;
				case 1:
				case 6:
					goto IL_018c;
				default:
					goto IL_019a;
				case 2:
					continue;
				case 3:
				{
					int num3 = Class58.smethod_67(this, struct22_);
					if (num3 > 0)
					{
						xmlWriter_0.WriteAttributeString("Assembly", num3.ToString());
					}
					return;
				}
				case 8:
				case 10:
					xmlWriter_0.WriteAttributeString("TypeName", value.ToString());
					return;
				}
				goto IL_0106;
			}
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
		using (new Class59(xmlWriter_0, "UnhandledExceptionReport"))
		{
			xmlWriter_0.WriteAttributeString("AssemblyID", "{FE10A302-31B7-4EF2-AA46-5131772A0A9D}".ToUpper());
			xmlWriter_0.WriteAttributeString("DateTime", DateTime.Now.ToString("s"));
			xmlWriter_0.WriteAttributeString("Path", Class58.smethod_32());
			if (guid_0 != Guid.Empty)
			{
				XmlWriter xmlWriter = xmlWriter_0;
				Guid guid = guid_0;
				xmlWriter.WriteAttributeString("UserID", guid.ToString("B"));
			}
			xmlWriter_0.WriteAttributeString("ReportID", Guid.NewGuid().ToString("B"));
			if (list_2.Count > 0)
			{
				list_2.Clear();
			}
			list_2.Add(new Struct21("{FE10A302-31B7-4EF2-AA46-5131772A0A9D}", string.Empty));
			if (dictionary_3.Count > 0)
			{
				dictionary_3.Clear();
			}
			dictionary_3.Add("{FE10A302-31B7-4EF2-AA46-5131772A0A9D}", 0);
			using (new Class59(xmlWriter_0, "Assemblies"))
			{
				Assembly assembly = Class58.smethod_31();
				Assembly[] array = Class58.smethod_168(this);
				foreach (Assembly assembly2 in array)
				{
					if ((object)assembly2 == null)
					{
						continue;
					}
					using (new Class59(xmlWriter_0, "Assembly"))
					{
						try
						{
							xmlWriter_0.WriteAttributeString("Name", assembly2.FullName);
							xmlWriter_0.WriteAttributeString("CodeBase", assembly2.CodeBase);
							if ((object)assembly2 == assembly)
							{
								xmlWriter_0.WriteAttributeString("This", "1");
							}
						}
						catch
						{
						}
					}
				}
			}
			using (new Class59(xmlWriter_0, "CustomProperties"))
			{
				if (dictionary_0 != null && dictionary_0.Count > 0)
				{
					foreach (string key in dictionary_0.Keys)
					{
						using (new Class59(xmlWriter_0, "CustomProperty"))
						{
							xmlWriter_0.WriteAttributeString("Name", key);
							string text = (string)dictionary_0[key];
							if (text == null)
							{
								xmlWriter_0.WriteAttributeString("Null", "1");
							}
							else
							{
								xmlWriter_0.WriteAttributeString("Value", "\"" + text + "\"");
							}
						}
					}
				}
			}
			if (dictionary_1 != null && dictionary_1.Count > 0)
			{
				using (new Class59(xmlWriter_0, "AttachedFiles"))
				{
					foreach (string key2 in dictionary_1.Keys)
					{
						using (new Class59(xmlWriter_0, "AttachedFile"))
						{
							xmlWriter_0.WriteAttributeString("Key", key2);
							Struct20 @struct = dictionary_1[key2];
							xmlWriter_0.WriteAttributeString("FileName", @struct.string_0);
							XmlWriter xmlWriter2 = xmlWriter_0;
							int int_ = @struct.int_0;
							xmlWriter2.WriteAttributeString("Length", int_.ToString());
							if (@struct.string_2.Length > 0)
							{
								xmlWriter_0.WriteAttributeString("Error", @struct.string_2);
							}
							else
							{
								xmlWriter_0.WriteAttributeString("Data", @struct.string_1);
							}
						}
					}
				}
			}
			using (new Class59(xmlWriter_0, "SystemInformation"))
			{
				try
				{
					xmlWriter_0.WriteElementString("NETVersion", Environment.Version.ToString());
					xmlWriter_0.WriteElementString("OSVersion", Environment.OSVersion.Version.ToString());
					xmlWriter_0.WriteElementString("OSPlatformID", Environment.OSVersion.Platform.ToString());
					xmlWriter_0.WriteElementString("ServicePack", Class57.ServicePack);
					xmlWriter_0.WriteElementString("ServerR2", Class57.IsServerR2 ? "1" : "0");
					xmlWriter_0.WriteElementString("X64", Class57.IsX64 ? "1" : "0");
					xmlWriter_0.WriteElementString("Workstation", Class57.IsWorkstation ? "1" : "0");
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
			using (new Class59(xmlWriter_0, "StackTrace"))
			{
				foreach (Exception item in list)
				{
					try
					{
						Class58.smethod_97(this, item);
						if (!item.Data.Contains("SmartStackFrames"))
						{
							continue;
						}
						ICollection collection = (ICollection)item.Data["SmartStackFrames"];
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
									using (new Class59(xmlWriter_0, "RemovedFrames"))
									{
										xmlWriter_0.WriteAttributeString("TotalFramesCount", count.ToString());
									}
								}
								else
								{
									if (num > 100 && num <= count - 100)
									{
										continue;
									}
									int num2 = (int)type.GetField("MethodID")!.GetValue(item2);
									int num3 = (int)type.GetField("ILOffset")!.GetValue(item2);
									int num4 = (int)type.GetField("ExceptionStackDepth")!.GetValue(item2);
									object[] array2 = (object[])type.GetField("Objects")!.GetValue(item2);
									Struct22 struct22_ = smethod_0(type);
									if (struct22_.IsEmpty)
									{
										continue;
									}
									using (new Class59(xmlWriter_0, "StackFrame"))
									{
										xmlWriter_0.WriteAttributeString("MethodID", num2.ToString());
										xmlWriter_0.WriteAttributeString("ExceptionStackDepth", num4.ToString());
										int num5 = Class58.smethod_67(this, struct22_);
										if (num5 > 0)
										{
											xmlWriter_0.WriteAttributeString("Assembly", num5.ToString());
										}
										if (num3 != -1)
										{
											xmlWriter_0.WriteAttributeString("ILOffset", num3.ToString());
										}
										object[] array3 = array2;
										foreach (object o in array3)
										{
											try
											{
												method_0(new Class49(o, firstLevel: true), null);
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
			using (new Class59(xmlWriter_0, "TypeNames"))
			{
				xmlWriter_0.WriteAttributeString("Count", list_1.Count.ToString());
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
					xmlWriter_0.WriteElementString("TypeName", value);
				}
			}
			using (new Class59(xmlWriter_0, "AssemblyIDs"))
			{
				xmlWriter_0.WriteAttributeString("Count", list_2.Count.ToString());
				for (int l = 0; l < list_2.Count; l++)
				{
					using (new Class59(xmlWriter_0, "AssemblyID"))
					{
						Struct21 struct2 = list_2[l];
						xmlWriter_0.WriteAttributeString("ID", struct2.string_0);
						if (struct2.string_1.Length > 0)
						{
							xmlWriter_0.WriteAttributeString("FullName", struct2.string_1);
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

	private void method_5()
	{
		using (new Class59(xmlWriter_0, "Objects"))
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				Class49 @class = list_0[i];
				object object_ = @class.object_0;
				Type type_ = @class.type_0;
				using (new Class59(xmlWriter_0, "ObjectDef"))
				{
					xmlWriter_0.WriteAttributeString("ID", i.ToString());
					string text = null;
					bool flag = true;
					string[] array = "".Split(new char[1] { ',' });
					foreach (string text2 in array)
					{
						if (text2 != "" && type_.FullName!.StartsWith(text2))
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
						if (!(name != "DoNotCaptureFieldsAttribute") || !(name != "DoNotCaptureAttribute"))
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
							text = ((text == type_.FullName) ? null : (type_.IsEnum ? Enum.Format(type_, object_, "d") : ((!(object_ is Guid)) ? ("\"" + text + "\"") : ("{" + text + "}"))));
						}
						catch
						{
						}
						if (text != null)
						{
							xmlWriter_0.WriteAttributeString("Value", Class58.smethod_84(text));
						}
					}
					if (type_.HasElementType)
					{
						method_3(type_.GetElementType());
						if (type_.IsByRef)
						{
							xmlWriter_0.WriteAttributeString("ByRef", "1");
						}
						if (type_.IsPointer)
						{
							xmlWriter_0.WriteAttributeString("Pointer", "1");
						}
						if (!type_.IsArray)
						{
							continue;
						}
						Array array2 = (Array)object_;
						xmlWriter_0.WriteAttributeString("Rank", array2.Rank.ToString());
						StringBuilder stringBuilder = new StringBuilder();
						for (int l = 0; l < array2.Rank; l++)
						{
							if (l > 0)
							{
								stringBuilder.Append(',');
							}
							stringBuilder.Append(array2.GetLength(l));
						}
						xmlWriter_0.WriteAttributeString("Length", stringBuilder.ToString());
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
								method_0(new Class49(array2.GetValue(m), firstLevel: false), null);
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
							using (new Class59(xmlWriter_0, "IEnumerable"))
							{
								int num = 0;
								foreach (object item in (IEnumerable)object_)
								{
									while (true)
									{
										if (num > 20)
										{
											int num2 = 4;
											if (RtOvMaZPBkyB76fasd9())
											{
												while (true)
												{
													switch (num2)
													{
													default:
														num2 = 2;
														if (RtOvMaZPBkyB76fasd9())
														{
															continue;
														}
														break;
													case 0:
													case 3:
														break;
													case 2:
														goto IL_037f;
													case 5:
														goto end_IL_0365;
													case 1:
													case 4:
														xmlWriter_0.WriteElementString("More", string.Empty);
														goto end_IL_0385;
													}
													break;
												}
												continue;
											}
										}
										else
										{
											method_0(new Class49(item, firstLevel: false), null);
										}
										goto IL_037f;
										IL_037f:
										num++;
										break;
										continue;
										end_IL_0365:
										break;
									}
									continue;
									end_IL_0385:
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

	private void method_6(Class49 class49_0)
	{
		int num = 5;
		FieldInfo[] array = default(FieldInfo[]);
		if (RtOvMaZPBkyB76fasd9())
		{
			FieldInfo[] fields = default(FieldInfo[]);
			while (true)
			{
				switch (num)
				{
				case 5:
					fields = class49_0.type_0.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					goto case 1;
				case 1:
				case 4:
					array = fields;
					num = 0;
					if (RtOvMaZPBkyB76fasd9())
					{
						continue;
					}
					return;
				case 0:
				case 2:
					break;
				default:
					goto IL_0137;
				case 6:
					goto IL_015a;
				case 7:
					return;
				}
				break;
			}
		}
		bool flag = default(bool);
		foreach (FieldInfo fieldInfo in array)
		{
			try
			{
				int num2;
				if (fieldInfo.IsLiteral)
				{
					num2 = 5;
					if (ltCZl8ZeuCbBCuFIClM())
					{
					}
					goto IL_009e;
				}
				if (fieldInfo.IsStatic && fieldInfo.IsInitOnly)
				{
					num2 = 1;
					if (RtOvMaZPBkyB76fasd9())
					{
						goto IL_009e;
					}
					continue;
				}
				flag = true;
				object[] customAttributes = fieldInfo.GetCustomAttributes(inherit: true);
				int num3 = 0;
				while (num3 < customAttributes.Length)
				{
					Attribute attribute = (Attribute)customAttributes[num3];
					if (!(attribute.GetType().Name == "DoNotCaptureAttribute"))
					{
						num3++;
						continue;
					}
					goto IL_0109;
				}
				goto IL_010b;
				IL_0109:
				flag = false;
				goto IL_010b;
				IL_009e:
				switch (num2)
				{
				case 1:
					break;
				case 0:
				case 5:
					break;
				default:
					goto IL_0109;
				case 3:
					goto IL_010b;
				case 6:
					break;
				}
				goto end_IL_0069;
				IL_010b:
				if (flag)
				{
					method_0(new Class49(fieldInfo.GetValue(class49_0.object_0), firstLevel: false), fieldInfo);
				}
				end_IL_0069:;
			}
			catch
			{
			}
		}
		goto IL_0137;
		IL_0137:
		class49_0 = new Class49(class49_0.object_0, class49_0.type_0.BaseType, class49_0.bool_0);
		goto IL_015a;
		IL_015a:
		if ((object)class49_0.type_0 != null)
		{
			using (new Class59(xmlWriter_0, "Field"))
			{
				method_2("__base");
				xmlWriter_0.WriteAttributeString("ID", list_0.Count.ToString());
			}
			list_0.Add(class49_0);
		}
	}

	internal bool method_7()
	{
		try
		{
			Class58.smethod_45((Class44)this, Enum4.const_0);
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
					while (stackTrace.FrameCount > 0)
					{
						while (true)
						{
							StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
							if (!ltCZl8ZeuCbBCuFIClM())
							{
								switch (4)
								{
								default:
									continue;
								case 0:
								case 3:
									break;
								case 4:
									num = frame.GetILOffset();
									goto end_IL_0054;
								}
							}
							break;
						}
						continue;
						end_IL_0054:
						break;
					}
				}
				catch
				{
				}
				Class58.smethod_159((Class44)this, Enum4.const_0, $"ERR 2006: {ex.Message} @ 0x{num:x4}");
				return false;
			}
			Class48 class48_ = new Class48("", "ffv", "v0.0.0.0 from 16/05/2018 00:54:31");
			return Class58.smethod_89(class48_, array, (Class44)this);
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception fatalException)
		{
			Class58.smethod_15(new EventArgs0(fatalException), this);
			return false;
		}
	}

	internal static bool RtOvMaZPBkyB76fasd9()
	{
		return true;
	}

	internal static bool ltCZl8ZeuCbBCuFIClM()
	{
		return false;
	}
}
