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

internal class Class46 : Class45
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
					inArray = Class21.smethod_46(array);
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

		internal static bool qPiXHysrp4KgJd9DXtJ()
		{
			return true;
		}

		internal static bool XDrafvs7uPdvxXgKLV3()
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

		internal static bool G4Sl9IsSFeL1sxEsd9I()
		{
			return true;
		}

		internal static bool F5FhnxsP6Ep7HwGe453()
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

		internal static bool zqKuBPsuq3wdhGcvjcj()
		{
			return true;
		}

		internal static bool zV5sREsyipi93cwdaS0()
		{
			return false;
		}
	}

	private readonly Exception exception_0;

	private readonly Guid guid_0;

	internal readonly char[] char_0 = new char[0];

	internal readonly Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();

	internal readonly Dictionary<string, Struct20> dictionary_1 = new Dictionary<string, Struct20>();

	internal XmlWriter xmlWriter_0;

	private readonly List<Class50> list_0 = new List<Class50>();

	private readonly List<string> list_1 = new List<string>();

	private readonly Dictionary<string, int> dictionary_2 = new Dictionary<string, int>();

	internal readonly List<Struct21> list_2 = new List<Struct21>();

	internal readonly Dictionary<string, int> dictionary_3 = new Dictionary<string, int>();

	private MemoryStream memoryStream_0;

	private byte[] byte_0;

	internal Delegate19 delegate19_0;

	internal EventHandler eventHandler_0;

	public event Delegate19 FatalException
	{
		add
		{
			while (true)
			{
				Delegate19 @delegate = delegate19_0;
				while (true)
				{
					Delegate19 delegate2 = @delegate;
					while (true)
					{
						IL_0044:
						Delegate19 value2 = (Delegate19)Delegate.Combine(delegate2, value);
						while (true)
						{
							@delegate = Interlocked.CompareExchange(ref delegate19_0, value2, delegate2);
							if ((object)@delegate != delegate2)
							{
								break;
							}
							if (!JueoMQsjqWLhNSut0T3())
							{
								break;
							}
							switch (6)
							{
							case 5:
								goto IL_0044;
							case 1:
							case 2:
								goto end_IL_0030;
							case 0:
							case 4:
								goto end_IL_0054;
							case 6:
								return;
							}
							continue;
							end_IL_0030:
							break;
						}
						break;
					}
					continue;
					end_IL_0054:
					break;
				}
			}
		}
		remove
		{
			if (!JueoMQsjqWLhNSut0T3())
			{
				goto IL_0043;
			}
			Delegate19 @delegate = default(Delegate19);
			switch (0)
			{
			case 0:
				@delegate = delegate19_0;
				goto IL_0041;
			case 1:
			case 3:
				goto IL_0041;
			case 2:
			case 5:
				goto IL_0043;
			case 6:
				return;
			}
			goto IL_003b;
			IL_0043:
			Delegate19 delegate2 = default(Delegate19);
			Delegate19 value2 = (Delegate19)Delegate.Remove(delegate2, value);
			@delegate = Interlocked.CompareExchange(ref delegate19_0, value2, delegate2);
			goto IL_003b;
			IL_003b:
			if ((object)@delegate == delegate2)
			{
				return;
			}
			goto IL_0041;
			IL_0041:
			delegate2 = @delegate;
			goto IL_0043;
		}
	}

	public event EventHandler DebuggerLaunched
	{
		add
		{
			while (true)
			{
				EventHandler eventHandler = eventHandler_0;
				while (true)
				{
					EventHandler eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					if (JueoMQsjqWLhNSut0T3())
					{
						switch (4)
						{
						case 1:
						case 5:
							break;
						case 2:
						case 4:
							goto IL_0041;
						default:
							goto IL_004f;
						case 3:
							goto end_IL_0003;
						case 6:
							return;
						}
						continue;
					}
					goto IL_0041;
					IL_004f:
					if ((object)eventHandler == eventHandler2)
					{
						return;
					}
					continue;
					IL_0041:
					eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
					goto IL_004f;
					continue;
					end_IL_0003:
					break;
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

	public Class46(Guid userId, Exception currentException, IWebProxy proxy)
	{
		guid_0 = userId;
		exception_0 = currentException;
		iwebProxy_0 = proxy;
		switch ("ASCII".ToUpper())
		{
		case "UNICODE":
			char_0 = new char[58]
			{
				'\u0001', '\u0002', '\u0003', '\u0004', '\u0005', '\u0006', '\a', '\b', '\u000e', '\u000f',
				'\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017', '\u0018', '\u0019',
				'\u001a', '\u001b', '\u001c', '\u001d', '\u001e', '\u001f', '\u007f', '\u0080', '\u0081', '\u0082',
				'\u0083', '\u0084', '\u0086', '\u0087', '\u0088', '\u0089', '\u008a', '\u008b', '\u008c', '\u008d',
				'\u008e', '\u008f', '\u0090', '\u0091', '\u0092', '\u0093', '\u0094', '\u0095', '\u0096', '\u0097',
				'\u0098', '\u0099', '\u009a', '\u009b', '\u009c', '\u009d', '\u009e', '\u009f'
			};
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
			break;
		}
	}

	private void method_0(Class50 class50_0, FieldInfo fieldInfo_0)
	{
		StringBuilder stringBuilder = default(StringBuilder);
		string text = default(string);
		string name = default(string);
		object object_ = default(object);
		string text2 = default(string);
		string text3 = default(string);
		StringBuilder stringBuilder2 = default(StringBuilder);
		Type type = default(Type);
		string text4 = default(string);
		Class59 class2 = default(Class59);
		while (true)
		{
			object obj;
			if ((object)fieldInfo_0 == null)
			{
				obj = null;
				goto IL_020a;
			}
			int num = 0;
			if (!JueoMQsjqWLhNSut0T3())
			{
				goto IL_00ce;
			}
			goto IL_01aa;
			IL_01f8:
			obj = fieldInfo_0.Name;
			goto IL_020a;
			IL_0123:
			stringBuilder.Append(')');
			goto IL_012c;
			IL_020a:
			text = (string)obj;
			name = (((object)fieldInfo_0 != null) ? "Field" : "Object");
			object_ = class50_0.object_0;
			goto IL_01f0;
			IL_0133:
			if (object_ is bool)
			{
				text2 = object_.ToString()!.ToLower();
			}
			if (text2 != null)
			{
				goto IL_0062;
			}
			text3 = Class21.smethod_19(object_);
			goto IL_0155;
			IL_0165:
			stringBuilder2.Append(object_.ToString());
			stringBuilder2.Append(" (0x");
			stringBuilder2.Append(text3);
			goto IL_0195;
			IL_012c:
			text2 = stringBuilder.ToString();
			goto IL_0133;
			IL_01f0:
			if (object_ != null)
			{
				type = class50_0.object_0.GetType();
				text4 = null;
				text2 = null;
				if (object_ is string)
				{
					text4 = "System.String";
				}
				if (text4 != null)
				{
					goto IL_0062;
				}
				if (type.IsPrimitive)
				{
					goto IL_00bd;
				}
				num = 5;
				if (!JueoMQsjqWLhNSut0T3())
				{
					goto IL_0165;
				}
				goto IL_01aa;
			}
			using (new Class59(xmlWriter_0, name))
			{
				if ((object)fieldInfo_0 != null)
				{
					if (fieldInfo_0.IsStatic)
					{
						xmlWriter_0.WriteAttributeString("Static", "1");
					}
					Type fieldType = fieldInfo_0.FieldType;
					if ((object)fieldType != null && fieldType.HasElementType)
					{
						method_3(fieldType.GetElementType());
						if (fieldType.IsByRef)
						{
							xmlWriter_0.WriteAttributeString("ByRef", "1");
						}
						if (fieldType.IsPointer)
						{
							xmlWriter_0.WriteAttributeString("Pointer", "1");
						}
						if (fieldType.IsArray)
						{
							xmlWriter_0.WriteAttributeString("Rank", fieldType.GetArrayRank().ToString());
						}
					}
					else
					{
						method_3(fieldType);
					}
				}
				if (text != null)
				{
					method_2(text);
				}
				xmlWriter_0.WriteAttributeString("Null", "1");
				return;
			}
			IL_019e:
			text2 = stringBuilder2.ToString();
			goto IL_0062;
			IL_00bd:
			text4 = type.FullName;
			goto IL_00c6;
			IL_00ce:
			int num2 = (char)object_;
			stringBuilder = new StringBuilder();
			if (num2 >= 32)
			{
				stringBuilder.Append('\'');
				stringBuilder.Append((char)object_);
				stringBuilder.Append("' ");
			}
			stringBuilder.Append("(0x");
			stringBuilder.Append(num2.ToString("x"));
			goto IL_0123;
			IL_00c6:
			if (object_ is char)
			{
				goto IL_00ce;
			}
			goto IL_0133;
			IL_0155:
			if (text3.Length > 0)
			{
				stringBuilder2 = new StringBuilder();
				goto IL_0165;
			}
			text2 = object_.ToString();
			goto IL_0062;
			IL_0195:
			stringBuilder2.Append(')');
			goto IL_019e;
			IL_0062:
			class2 = new Class59(xmlWriter_0, name);
			num = 14;
			if (vVW3HysxnPb5T0NBCYa())
			{
				break;
			}
			goto IL_01aa;
			IL_01aa:
			switch (num)
			{
			case 5:
				break;
			case 6:
				goto IL_00c6;
			case 11:
				goto IL_00ce;
			case 9:
				goto IL_0123;
			default:
				goto IL_012c;
			case 10:
				goto IL_0155;
			case 3:
				goto IL_0165;
			case 13:
				goto IL_0195;
			case 12:
				goto IL_019e;
			case 2:
			case 7:
				goto IL_01f0;
			case 0:
			case 1:
				goto IL_01f8;
			case 4:
				continue;
			case 14:
				goto end_IL_0226;
			}
			if (!(object_ is IntPtr) && !(object_ is UIntPtr))
			{
				if (type.IsValueType && (object)type.Module != GetType().Module)
				{
					text4 = type.FullName;
				}
				goto IL_0062;
			}
			goto IL_00bd;
			continue;
			end_IL_0226:
			break;
		}
		try
		{
			if ((object)fieldInfo_0 != null && fieldInfo_0.IsStatic)
			{
				goto IL_0383;
			}
			goto IL_0398;
			IL_03b9:
			text2 = object_.ToString();
			goto IL_03c0;
			IL_0398:
			if (text4 == null)
			{
				if ((object)fieldInfo_0 != null)
				{
					goto IL_0367;
				}
				goto IL_0373;
			}
			method_3(type);
			if (text != null)
			{
				method_2(text);
			}
			goto IL_03b0;
			IL_03c0:
			if (object_ is Guid)
			{
				text2 = string.Concat("{", object_, "}");
			}
			if (text2 == null)
			{
				text2 = string.Concat("\"", object_, "\"");
			}
			xmlWriter_0.WriteAttributeString("Value", Class21.smethod_80(text2));
			return;
			IL_0367:
			method_3(fieldInfo_0.FieldType);
			goto IL_0373;
			IL_0383:
			xmlWriter_0.WriteAttributeString("Static", "1");
			goto IL_0398;
			IL_0373:
			method_1(class50_0);
			if (text != null)
			{
				if (vVW3HysxnPb5T0NBCYa())
				{
				}
				switch (7)
				{
				case 5:
					break;
				case 6:
					goto IL_0383;
				case 1:
				case 4:
					goto IL_03b0;
				case 2:
				case 3:
					goto IL_03b9;
				default:
					goto IL_03c0;
				case 7:
					method_2(text);
					return;
				}
				goto IL_0367;
			}
			return;
			IL_03b0:
			if (type.IsEnum)
			{
				goto IL_03b9;
			}
			goto IL_03c0;
		}
		finally
		{
			((IDisposable)class2)?.Dispose();
		}
	}

	internal void method_1(Class50 class50_0)
	{
		object object_ = class50_0.object_0;
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
			list_0.Add(class50_0);
		}
		xmlWriter_0.WriteAttributeString("ID", num.ToString());
	}

	private void method_2(string string_0)
	{
		int num = Class21.smethod_159(string_0, this);
		if (num != -1)
		{
			xmlWriter_0.WriteAttributeString("NameID", num.ToString());
		}
		else
		{
			xmlWriter_0.WriteAttributeString("Name", string_0);
		}
	}

	private static Struct22 smethod_0(Type type_0)
	{
		Struct22 empty = Struct22.Empty;
		if ((object)type_0 != null && (object)type_0.Assembly.GetType("SmartAssembly.Attributes.PoweredByAttribute") != null)
		{
			empty.string_0 = ((type_0.MetadataToken & 0xFFFFFF) - 1).ToString();
			Assembly assembly = type_0.Assembly;
			empty.struct21_0 = new Struct21(assembly.ManifestModule.ModuleVersionId.ToString("B"), assembly.FullName);
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
			Struct22 struct22_ = smethod_0(type_0);
			int num = 9;
			if (!vVW3HysxnPb5T0NBCYa())
			{
			}
			string fullName = default(string);
			StringBuilder stringBuilder = default(StringBuilder);
			string name = default(string);
			int value = default(int);
			int num2 = default(int);
			string value2 = default(string);
			string @namespace = default(string);
			while (true)
			{
				int num3;
				switch (num)
				{
				case 9:
					if (struct22_.IsEmpty)
					{
						fullName = type_0.FullName;
						if (!dictionary_2.ContainsKey(fullName))
						{
							stringBuilder = new StringBuilder();
							name = type_0.Assembly.GetName().Name;
							if (name.Length <= 0 || !(name != "mscorlib"))
							{
								goto IL_0132;
							}
							stringBuilder.Append('[');
							num = 8;
							if (!vVW3HysxnPb5T0NBCYa())
							{
								break;
							}
							goto case 2;
						}
						value = dictionary_2[fullName];
						goto case 10;
					}
					xmlWriter_0.WriteAttributeString("TypeDefID", struct22_.string_0);
					num2 = Class21.smethod_74(struct22_, this);
					if (num2 <= 0)
					{
						return;
					}
					goto case 1;
				case 8:
					stringBuilder.Append(name);
					stringBuilder.Append(']');
					goto IL_0132;
				case 1:
				case 3:
					xmlWriter_0.WriteAttributeString("Assembly", num2.ToString());
					return;
				case 7:
					if (type_0.HasElementType)
					{
						goto default;
					}
					goto IL_0166;
				default:
					type_0 = type_0.GetElementType();
					goto IL_0166;
				case 0:
					stringBuilder.Append(value2);
					goto IL_01ad;
				case 4:
				case 6:
					value = list_1.Count;
					goto case 2;
				case 2:
					list_1.Add(stringBuilder.ToString());
					dictionary_2.Add(fullName, value);
					goto case 10;
				case 10:
					{
						xmlWriter_0.WriteAttributeString("TypeName", value.ToString());
						return;
					}
					IL_0132:
					@namespace = type_0.Namespace;
					if (@namespace.Length > 0)
					{
						stringBuilder.Append(@namespace);
						stringBuilder.Append('.');
					}
					goto case 7;
					IL_01ad:
					stringBuilder.Append(type_0.Name);
					goto case 4;
					IL_0166:
					num3 = fullName.LastIndexOf("+");
					if (num3 > 0)
					{
						value2 = fullName.Substring(@namespace.Length + 1, num3 - @namespace.Length).Replace("+", "/");
						goto case 0;
					}
					goto IL_01ad;
				}
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
			xmlWriter_0.WriteAttributeString("AssemblyID", "{516600D7-3050-406A-87C1-F0EB057ED33B}".ToUpper());
			xmlWriter_0.WriteAttributeString("DateTime", DateTime.Now.ToString("s"));
			xmlWriter_0.WriteAttributeString("Path", Class21.smethod_136());
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
			list_2.Add(new Struct21("{516600D7-3050-406A-87C1-F0EB057ED33B}", string.Empty));
			if (dictionary_3.Count > 0)
			{
				dictionary_3.Clear();
			}
			dictionary_3.Add("{516600D7-3050-406A-87C1-F0EB057ED33B}", 0);
			using (new Class59(xmlWriter_0, "Assemblies"))
			{
				Assembly assembly = Class21.smethod_32();
				Assembly[] array = Class21.smethod_67(this);
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
					xmlWriter_0.WriteElementString("ServicePack", Class58.ServicePack);
					xmlWriter_0.WriteElementString("ServerR2", Class58.IsServerR2 ? "1" : "0");
					xmlWriter_0.WriteElementString("X64", Class58.IsX64 ? "1" : "0");
					xmlWriter_0.WriteElementString("Workstation", Class58.IsWorkstation ? "1" : "0");
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
						Class21.smethod_104(item, this);
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
										int num5 = Class21.smethod_74(struct22_, this);
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
												method_0(new Class50(o, firstLevel: true), null);
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
				Class50 @class = list_0[i];
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
							if (!vVW3HysxnPb5T0NBCYa())
							{
								switch (4)
								{
								case 0:
								case 4:
									if (text == type_.FullName)
									{
										text = null;
									}
									else
									{
										if (type_.IsEnum)
										{
											break;
										}
										text = ((!(object_ is Guid)) ? ("\"" + text + "\"") : ("{" + text + "}"));
									}
									goto end_IL_011b;
								case 1:
								case 2:
								case 5:
									goto end_IL_011b;
								}
							}
							text = Enum.Format(type_, object_, "d");
							end_IL_011b:;
						}
						catch
						{
						}
						if (text != null)
						{
							xmlWriter_0.WriteAttributeString("Value", Class21.smethod_80(text));
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
								method_0(new Class50(array2.GetValue(m), firstLevel: false), null);
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
									if (num <= 20)
									{
										method_0(new Class50(item, firstLevel: false), null);
										num++;
										continue;
									}
									xmlWriter_0.WriteElementString("More", string.Empty);
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

	private void method_6(Class50 class50_0)
	{
		bool flag = default(bool);
		object[] customAttributes = default(object[]);
		int num2 = default(int);
		Attribute attribute = default(Attribute);
		while (true)
		{
			FieldInfo[] fields = class50_0.type_0.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			while (true)
			{
				IL_000f:
				FieldInfo[] array = fields;
				int num = 0;
				while (true)
				{
					if (num >= array.Length)
					{
						goto IL_00ee;
					}
					FieldInfo fieldInfo = array[num];
					try
					{
						if (!fieldInfo.IsLiteral)
						{
							if (!fieldInfo.IsStatic || !fieldInfo.IsInitOnly)
							{
								flag = true;
								customAttributes = fieldInfo.GetCustomAttributes(inherit: true);
								num2 = 0;
								goto IL_0091;
							}
							int num3 = 1;
							if (!vVW3HysxnPb5T0NBCYa())
							{
							}
							while (true)
							{
								switch (num3)
								{
								default:
									num3 = 4;
									if (JueoMQsjqWLhNSut0T3())
									{
										continue;
									}
									break;
								case 1:
									break;
								case 0:
								case 5:
									break;
								case 2:
								case 4:
									goto IL_00af;
								case 3:
									goto IL_00ca;
								case 6:
									break;
								}
								break;
							}
						}
						goto end_IL_0020;
						IL_00af:
						if (!(attribute.GetType().Name == "DoNotCaptureAttribute"))
						{
							num2++;
							goto IL_0091;
						}
						flag = false;
						goto IL_00ca;
						IL_00ca:
						if (flag)
						{
							method_0(new Class50(fieldInfo.GetValue(class50_0.object_0), firstLevel: false), fieldInfo);
						}
						goto end_IL_0020;
						IL_0091:
						if (num2 < customAttributes.Length)
						{
							attribute = (Attribute)customAttributes[num2];
							goto IL_00af;
						}
						goto IL_00ca;
						end_IL_0020:;
					}
					catch
					{
					}
					num++;
					int num4 = 6;
					if (vVW3HysxnPb5T0NBCYa())
					{
						break;
					}
					goto IL_0120;
					IL_00ee:
					class50_0 = new Class50(class50_0.object_0, class50_0.type_0.BaseType, class50_0.bool_0);
					if ((object)class50_0.type_0 == null)
					{
						num4 = 5;
						if (!JueoMQsjqWLhNSut0T3())
						{
							goto IL_000f;
						}
						goto IL_0120;
					}
					using (new Class59(xmlWriter_0, "Field"))
					{
						method_2("__base");
						xmlWriter_0.WriteAttributeString("ID", list_0.Count.ToString());
					}
					list_0.Add(class50_0);
					return;
					IL_0120:
					switch (num4)
					{
					case 0:
					case 2:
						break;
					case 1:
						goto IL_000f;
					case 6:
						continue;
					default:
						goto IL_00ee;
					case 4:
					case 5:
						return;
					case 7:
						return;
					}
					break;
				}
				break;
			}
		}
	}

	internal bool method_7()
	{
		try
		{
			Class21.smethod_11((Class45)this, Enum4.const_0);
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
				Class21.smethod_75((Class45)this, Enum4.const_0, $"ERR 2006: {ex.Message} @ 0x{num:x4}");
				return false;
			}
			Class49 class49_ = new Class49("", "ffv", "v0.0.0.0 from 28/05/2018 13:09");
			return Class21.smethod_100(array, class49_, (Class45)this);
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception fatalException)
		{
			Class21.smethod_113(this, new EventArgs0(fatalException));
			return false;
		}
	}

	internal static bool JueoMQsjqWLhNSut0T3()
	{
		return true;
	}

	internal static bool vVW3HysxnPb5T0NBCYa()
	{
		return false;
	}
}
