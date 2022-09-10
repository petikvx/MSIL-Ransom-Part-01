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
using ns0;
using ns1;
using ns2;
using ns4;
using ns5;

namespace ns7;

internal sealed class Class35 : Class34
{
	internal struct Struct17
	{
		public readonly string string_0;

		public readonly string string_1;

		public readonly string string_2;

		public readonly int int_0;

		public Struct17(string fileName)
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
				byte[] buffer = new byte[int_0];
				using (FileStream fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					fileStream.Read(buffer, 0, int_0);
					fileStream.Close();
				}
				byte[] inArray;
				try
				{
					inArray = Class32.smethod_102(buffer);
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

	internal struct Struct18
	{
		public readonly string string_0;

		public readonly string string_1;

		public Struct18(string assemblyID, string assemblyFullName)
		{
			string_0 = assemblyID;
			string_1 = assemblyFullName;
		}
	}

	internal struct Struct19
	{
		public string string_0;

		public Struct18 struct18_0;

		public bool IsEmpty => string_0.Length == 0;

		public static Struct19 Empty => new Struct19(string.Empty, string.Empty, string.Empty);

		private Struct19(string id, string assemblyID, string assemblyFullName)
		{
			string_0 = id;
			struct18_0 = new Struct18(assemblyID, assemblyFullName);
		}
	}

	private const string string_3 = "{bf13b64c-b3d2-4165-b3f5-7f852d4744cf}";

	private const string string_4 = "{07572d6f-5375-47d5-8a8c-b5f0cbe5bad0}";

	private const string string_5 = "{6d3806d4-1193-4601-a7df-2249c7f0014b}";

	private const string string_6 = "{d316c294-ed40-4778-8b7b-29800a2dcbc3}";

	private const string string_7 = "{a9035fc5-7ed1-4e0c-8962-dfcb1d508afc}";

	private const string string_8 = "{73fbfb9b-41e7-4744-bf74-74b7c6c117c1}";

	private const string string_9 = "SmartAssembly.exe";

	private readonly Exception exception_0;

	private readonly Guid guid_0;

	internal readonly char[] char_0 = new char[0];

	internal readonly Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();

	internal readonly Dictionary<string, Struct17> dictionary_1 = new Dictionary<string, Struct17>();

	internal readonly XmlWriter xmlWriter_0;

	private readonly List<Class39> list_0 = new List<Class39>();

	private readonly List<string> list_1 = new List<string>();

	private readonly Dictionary<string, int> dictionary_2 = new Dictionary<string, int>();

	internal readonly List<Struct18> list_2 = new List<Struct18>();

	internal readonly Dictionary<string, int> dictionary_3 = new Dictionary<string, int>();

	private readonly MemoryStream memoryStream_0;

	private byte[] byte_0;

	internal Delegate2 delegate2_0;

	internal EventHandler eventHandler_0;

	public event Delegate2 FatalException
	{
		add
		{
			Delegate2 @delegate = delegate2_0;
			Delegate2 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate2 value2 = (Delegate2)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate2_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			Delegate2 @delegate = delegate2_0;
			Delegate2 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate2 value2 = (Delegate2)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate2_0, value2, delegate2);
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

	public Class35(Guid userId, Exception currentException, IWebProxy proxy)
	{
		guid_0 = userId;
		exception_0 = currentException;
		memoryStream_0 = new MemoryStream();
		xmlWriter_0 = new XmlTextWriter(memoryStream_0, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		iwebProxy_0 = proxy;
		switch ("UNICODE".ToUpper())
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

	private unsafe void method_0(Class39 objectAndType, FieldInfo fieldType)
	{
		void* ptr = stackalloc byte[8];
		string text = fieldType?.Name;
		string name = (((object)fieldType == null) ? "Object" : "Field");
		object object_ = objectAndType.object_0;
		if (object_ == null)
		{
			using (new Class48(xmlWriter_0, name))
			{
				if ((object)fieldType != null)
				{
					if (fieldType.IsStatic)
					{
						xmlWriter_0.WriteAttributeString("Static", "1");
					}
					Type fieldType2 = fieldType.FieldType;
					if ((object)fieldType2 != null && fieldType2.HasElementType)
					{
						method_3(fieldType2.GetElementType());
						if (fieldType2.IsByRef)
						{
							xmlWriter_0.WriteAttributeString("ByRef", "1");
						}
						if (fieldType2.IsPointer)
						{
							xmlWriter_0.WriteAttributeString("Pointer", "1");
						}
						if (fieldType2.IsArray)
						{
							XmlWriter xmlWriter = xmlWriter_0;
							*(int*)((byte*)ptr + 4) = fieldType2.GetArrayRank();
							xmlWriter.WriteAttributeString("Rank", ((int*)((byte*)ptr + 4))->ToString());
						}
					}
					else
					{
						method_3(fieldType2);
					}
				}
				if (text != null)
				{
					method_2(text);
				}
				xmlWriter_0.WriteAttributeString("Null", "1");
				return;
			}
		}
		Type type = objectAndType.object_0.GetType();
		string text2 = null;
		string text3 = null;
		if (object_ is string)
		{
			text2 = "System.String";
		}
		if (text2 == null)
		{
			if (!type.IsPrimitive && !(object_ is IntPtr) && !(object_ is UIntPtr))
			{
				if (type.IsValueType && (object)type.Module != GetType().Module)
				{
					text2 = type.FullName;
				}
			}
			else
			{
				text2 = type.FullName;
				if (object_ is char)
				{
					*(int*)ptr = (char)object_;
					StringBuilder stringBuilder = new StringBuilder();
					if (*(int*)ptr >= 32)
					{
						stringBuilder.Append('\'');
						stringBuilder.Append((char)object_);
						stringBuilder.Append("' ");
					}
					stringBuilder.Append("(0x");
					stringBuilder.Append(((int*)ptr)->ToString("x"));
					stringBuilder.Append(')');
					text3 = stringBuilder.ToString();
				}
				if (object_ is bool)
				{
					text3 = object_.ToString()!.ToLower();
				}
				if (text3 == null)
				{
					string text4 = Class32.smethod_64(object_);
					if (text4.Length > 0)
					{
						StringBuilder stringBuilder2 = new StringBuilder();
						stringBuilder2.Append(object_.ToString());
						stringBuilder2.Append(" (0x");
						stringBuilder2.Append(text4);
						stringBuilder2.Append(')');
						text3 = stringBuilder2.ToString();
					}
					else
					{
						text3 = object_.ToString();
					}
				}
			}
		}
		using (new Class48(xmlWriter_0, name))
		{
			if ((object)fieldType != null && fieldType.IsStatic)
			{
				xmlWriter_0.WriteAttributeString("Static", "1");
			}
			if (text2 != null)
			{
				method_3(type);
				if (text != null)
				{
					method_2(text);
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
				xmlWriter_0.WriteAttributeString("Value", Class32.smethod_114(text3));
			}
			else
			{
				if ((object)fieldType != null)
				{
					method_3(fieldType.FieldType);
				}
				method_1(objectAndType);
				if (text != null)
				{
					method_2(text);
				}
			}
		}
	}

	internal unsafe void method_1(Class39 objectAndType)
	{
		void* ptr = stackalloc byte[8];
		object object_ = objectAndType.object_0;
		*(int*)ptr = -1;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < list_0.Count)
		{
			if (!object.ReferenceEquals(list_0[*(int*)((byte*)ptr + 4)].object_0, object_))
			{
				(*(int*)((byte*)ptr + 4))++;
				continue;
			}
			*(int*)ptr = *(int*)((byte*)ptr + 4);
			break;
		}
		if (*(int*)ptr == -1)
		{
			*(int*)ptr = list_0.Count;
			list_0.Add(objectAndType);
		}
		xmlWriter_0.WriteAttributeString("ID", ((int*)ptr)->ToString());
	}

	private void method_2(string name)
	{
		int num = Class32.smethod_92(name, this);
		if (num != -1)
		{
			xmlWriter_0.WriteAttributeString("NameID", num.ToString());
		}
		else
		{
			xmlWriter_0.WriteAttributeString("Name", name);
		}
	}

	private static Struct19 smethod_0(Type objectType)
	{
		Struct19 empty = Struct19.Empty;
		if ((object)objectType != null && (object)objectType.Assembly.GetType("SmartAssembly.Attributes.PoweredByAttribute") != null)
		{
			empty.string_0 = ((objectType.MetadataToken & 0xFFFFFF) - 1).ToString();
			Assembly assembly = objectType.Assembly;
			empty.struct18_0 = new Struct18(assembly.ManifestModule.ModuleVersionId.ToString("B"), assembly.FullName);
		}
		return empty;
	}

	internal unsafe void method_3(Type objectType)
	{
		void* ptr = stackalloc byte[12];
		if ((object)objectType == null)
		{
			return;
		}
		try
		{
			Struct19 typeInformation = smethod_0(objectType);
			if (!typeInformation.IsEmpty)
			{
				xmlWriter_0.WriteAttributeString("TypeDefID", typeInformation.string_0);
				*(int*)ptr = Class32.smethod_83(typeInformation, this);
				if (*(int*)ptr > 0)
				{
					xmlWriter_0.WriteAttributeString("Assembly", ((int*)ptr)->ToString());
				}
				return;
			}
			string fullName = objectType.FullName;
			if (dictionary_2.ContainsKey(fullName))
			{
				*(int*)((byte*)ptr + 4) = dictionary_2[fullName];
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				string name = objectType.Assembly.GetName().Name;
				if (name.Length > 0 && name != "mscorlib")
				{
					stringBuilder.Append('[');
					stringBuilder.Append(name);
					stringBuilder.Append(']');
				}
				string @namespace = objectType.Namespace;
				if (@namespace.Length > 0)
				{
					stringBuilder.Append(@namespace);
					stringBuilder.Append('.');
				}
				if (objectType.HasElementType)
				{
					objectType = objectType.GetElementType();
				}
				*(int*)((byte*)ptr + 8) = fullName.LastIndexOf("+");
				if (*(int*)((byte*)ptr + 8) > 0)
				{
					string value = fullName.Substring(@namespace.Length + 1, *(int*)((byte*)ptr + 8) - @namespace.Length).Replace("+", "/");
					stringBuilder.Append(value);
				}
				stringBuilder.Append(objectType.Name);
				*(int*)((byte*)ptr + 4) = list_1.Count;
				list_1.Add(stringBuilder.ToString());
				dictionary_2.Add(fullName, *(int*)((byte*)ptr + 4));
			}
			xmlWriter_0.WriteAttributeString("TypeName", ((int*)((byte*)ptr + 4))->ToString());
		}
		catch
		{
		}
	}

	internal unsafe byte[] method_4()
	{
		void* ptr = stackalloc byte[52];
		if (byte_0 != null)
		{
			return byte_0;
		}
		xmlWriter_0.WriteStartDocument();
		using (new Class48(xmlWriter_0, "UnhandledExceptionReport"))
		{
			xmlWriter_0.WriteAttributeString("AssemblyID", "{C61C9459-17A0-4FB9-B2AC-64C5861D882A}".ToUpper());
			xmlWriter_0.WriteAttributeString("DateTime", DateTime.Now.ToString("s"));
			xmlWriter_0.WriteAttributeString("Path", Class32.smethod_104());
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
			list_2.Add(new Struct18("{C61C9459-17A0-4FB9-B2AC-64C5861D882A}", string.Empty));
			if (dictionary_3.Count > 0)
			{
				dictionary_3.Clear();
			}
			dictionary_3.Add("{C61C9459-17A0-4FB9-B2AC-64C5861D882A}", 0);
			using (new Class48(xmlWriter_0, "Assemblies"))
			{
				Assembly assembly = Class32.smethod_42();
				Assembly[] array = Class32.smethod_126(this);
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < array.Length)
				{
					Assembly assembly2 = array[*(int*)((byte*)ptr + 32)];
					if ((object)assembly2 != null)
					{
						using (new Class48(xmlWriter_0, "Assembly"))
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
					(*(int*)((byte*)ptr + 32))++;
				}
			}
			using (new Class48(xmlWriter_0, "CustomProperties"))
			{
				if (dictionary_0 != null && dictionary_0.Count > 0)
				{
					foreach (string key in dictionary_0.Keys)
					{
						using (new Class48(xmlWriter_0, "CustomProperty"))
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
				using (new Class48(xmlWriter_0, "AttachedFiles"))
				{
					foreach (string key2 in dictionary_1.Keys)
					{
						using (new Class48(xmlWriter_0, "AttachedFile"))
						{
							xmlWriter_0.WriteAttributeString("Key", key2);
							Struct17 @struct = dictionary_1[key2];
							xmlWriter_0.WriteAttributeString("FileName", @struct.string_0);
							XmlWriter xmlWriter2 = xmlWriter_0;
							*(int*)((byte*)ptr + 36) = @struct.int_0;
							xmlWriter2.WriteAttributeString("Length", ((int*)((byte*)ptr + 36))->ToString());
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
			using (new Class48(xmlWriter_0, "SystemInformation"))
			{
				try
				{
					xmlWriter_0.WriteElementString("NETVersion", Environment.Version.ToString());
					xmlWriter_0.WriteElementString("OSVersion", Environment.OSVersion.Version.ToString());
					xmlWriter_0.WriteElementString("OSPlatformID", Environment.OSVersion.Platform.ToString());
					xmlWriter_0.WriteElementString("ServicePack", Class47.ServicePack);
					xmlWriter_0.WriteElementString("ServerR2", Class47.IsServerR2 ? "1" : "0");
					xmlWriter_0.WriteElementString("X64", Class47.IsX64 ? "1" : "0");
					xmlWriter_0.WriteElementString("Workstation", Class47.IsWorkstation ? "1" : "0");
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
			using (new Class48(xmlWriter_0, "StackTrace"))
			{
				foreach (Exception item in list)
				{
					try
					{
						Class32.smethod_90(item, this);
						if (!item.Data.Contains("SmartStackFrames"))
						{
							continue;
						}
						ICollection collection = (ICollection)item.Data["SmartStackFrames"];
						*(int*)ptr = collection.Count;
						*(int*)((byte*)ptr + 4) = 0;
						foreach (object item2 in collection)
						{
							try
							{
								Type type = item2.GetType();
								(*(int*)((byte*)ptr + 4))++;
								if (*(int*)((byte*)ptr + 4) > 100 && *(int*)((byte*)ptr + 4) == *(int*)ptr - 100)
								{
									using (new Class48(xmlWriter_0, "RemovedFrames"))
									{
										xmlWriter_0.WriteAttributeString("TotalFramesCount", ((int*)ptr)->ToString());
									}
								}
								else
								{
									if (*(int*)((byte*)ptr + 4) > 100 && *(int*)((byte*)ptr + 4) <= *(int*)ptr - 100)
									{
										continue;
									}
									*(int*)((byte*)ptr + 8) = (int)type.GetField("MethodID")!.GetValue(item2);
									*(int*)((byte*)ptr + 12) = (int)type.GetField("ILOffset")!.GetValue(item2);
									*(int*)((byte*)ptr + 16) = (int)type.GetField("ExceptionStackDepth")!.GetValue(item2);
									object[] array2 = (object[])type.GetField("Objects")!.GetValue(item2);
									Struct19 typeInformation = smethod_0(type);
									if (typeInformation.IsEmpty)
									{
										continue;
									}
									using (new Class48(xmlWriter_0, "StackFrame"))
									{
										xmlWriter_0.WriteAttributeString("MethodID", ((int*)((byte*)ptr + 8))->ToString());
										xmlWriter_0.WriteAttributeString("ExceptionStackDepth", ((int*)((byte*)ptr + 16))->ToString());
										*(int*)((byte*)ptr + 20) = Class32.smethod_83(typeInformation, this);
										if (*(int*)((byte*)ptr + 20) > 0)
										{
											xmlWriter_0.WriteAttributeString("Assembly", ((int*)((byte*)ptr + 20))->ToString());
										}
										if (*(int*)((byte*)ptr + 12) != -1)
										{
											xmlWriter_0.WriteAttributeString("ILOffset", ((int*)((byte*)ptr + 12))->ToString());
										}
										object[] array3 = array2;
										*(int*)((byte*)ptr + 40) = 0;
										while (*(int*)((byte*)ptr + 40) < array3.Length)
										{
											object o = array3[*(int*)((byte*)ptr + 40)];
											try
											{
												method_0(new Class39(o, firstLevel: true), null);
											}
											catch
											{
											}
											(*(int*)((byte*)ptr + 40))++;
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
			using (new Class48(xmlWriter_0, "TypeNames"))
			{
				XmlWriter xmlWriter3 = xmlWriter_0;
				*(int*)((byte*)ptr + 44) = list_1.Count;
				xmlWriter3.WriteAttributeString("Count", ((int*)((byte*)ptr + 44))->ToString());
				*(int*)((byte*)ptr + 24) = 0;
				while (*(int*)((byte*)ptr + 24) < list_1.Count)
				{
					string value;
					try
					{
						value = list_1[*(int*)((byte*)ptr + 24)].ToString();
					}
					catch (Exception ex)
					{
						value = '"' + ex.Message + '"';
					}
					xmlWriter_0.WriteElementString("TypeName", value);
					(*(int*)((byte*)ptr + 24))++;
				}
			}
			using (new Class48(xmlWriter_0, "AssemblyIDs"))
			{
				XmlWriter xmlWriter4 = xmlWriter_0;
				*(int*)((byte*)ptr + 48) = list_2.Count;
				xmlWriter4.WriteAttributeString("Count", ((int*)((byte*)ptr + 48))->ToString());
				*(int*)((byte*)ptr + 28) = 0;
				while (*(int*)((byte*)ptr + 28) < list_2.Count)
				{
					using (new Class48(xmlWriter_0, "AssemblyID"))
					{
						Struct18 struct2 = list_2[*(int*)((byte*)ptr + 28)];
						xmlWriter_0.WriteAttributeString("ID", struct2.string_0);
						if (struct2.string_1.Length > 0)
						{
							xmlWriter_0.WriteAttributeString("FullName", struct2.string_1);
						}
					}
					(*(int*)((byte*)ptr + 28))++;
				}
			}
		}
		xmlWriter_0.WriteEndDocument();
		xmlWriter_0.Flush();
		memoryStream_0.Flush();
		byte_0 = memoryStream_0.ToArray();
		return byte_0;
	}

	private unsafe void method_5()
	{
		void* ptr = stackalloc byte[33];
		using (new Class48(xmlWriter_0, "Objects"))
		{
			*(int*)ptr = 0;
			while (*(int*)ptr < list_0.Count)
			{
				Class39 @class = list_0[*(int*)ptr];
				object object_ = @class.object_0;
				Type type_ = @class.type_0;
				using (new Class48(xmlWriter_0, "ObjectDef"))
				{
					xmlWriter_0.WriteAttributeString("ID", ((int*)ptr)->ToString());
					string text = null;
					((byte*)ptr)[32] = 1;
					string[] array = "".Split(new char[1] { ',' });
					*(int*)((byte*)ptr + 20) = 0;
					while (*(int*)((byte*)ptr + 20) < array.Length)
					{
						string text2 = array[*(int*)((byte*)ptr + 20)];
						if (!(text2 != "") || !type_.FullName!.StartsWith(text2))
						{
							(*(int*)((byte*)ptr + 20))++;
							continue;
						}
						((byte*)ptr)[32] = 0;
						break;
					}
					object[] customAttributes = type_.GetCustomAttributes(inherit: true);
					*(int*)((byte*)ptr + 24) = 0;
					while (*(int*)((byte*)ptr + 24) < customAttributes.Length)
					{
						Attribute attribute = (Attribute)customAttributes[*(int*)((byte*)ptr + 24)];
						string name = attribute.GetType().Name;
						if (name != "DoNotCaptureFieldsAttribute" && name != "DoNotCaptureAttribute")
						{
							(*(int*)((byte*)ptr + 24))++;
							continue;
						}
						((byte*)ptr)[32] = 0;
						break;
					}
					if (((byte*)ptr)[32] != 0)
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
							xmlWriter_0.WriteAttributeString("Value", Class32.smethod_114(text));
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
						if (type_.IsArray)
						{
							Array array2 = (Array)object_;
							XmlWriter xmlWriter = xmlWriter_0;
							*(int*)((byte*)ptr + 28) = array2.Rank;
							xmlWriter.WriteAttributeString("Rank", ((int*)((byte*)ptr + 28))->ToString());
							StringBuilder stringBuilder = new StringBuilder();
							*(int*)((byte*)ptr + 4) = 0;
							while (*(int*)((byte*)ptr + 4) < array2.Rank)
							{
								if (*(int*)((byte*)ptr + 4) > 0)
								{
									stringBuilder.Append(',');
								}
								stringBuilder.Append(array2.GetLength(*(int*)((byte*)ptr + 4)));
								(*(int*)((byte*)ptr + 4))++;
							}
							xmlWriter_0.WriteAttributeString("Length", stringBuilder.ToString());
							if (array2.Rank == 1)
							{
								*(int*)((byte*)ptr + 8) = array2.Length;
								*(int*)((byte*)ptr + 12) = 0;
								while (*(int*)((byte*)ptr + 12) < *(int*)((byte*)ptr + 8))
								{
									if (*(int*)((byte*)ptr + 12) == 10 && *(int*)((byte*)ptr + 8) > 16)
									{
										*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 8) - 5;
									}
									try
									{
										method_0(new Class39(array2.GetValue(*(int*)((byte*)ptr + 12)), firstLevel: false), null);
									}
									catch
									{
									}
									(*(int*)((byte*)ptr + 12))++;
								}
							}
						}
					}
					else
					{
						method_3(type_);
						if (@class.bool_0 && ((byte*)ptr)[32] != 0)
						{
							try
							{
								if (object_ is IEnumerable)
								{
									using (new Class48(xmlWriter_0, "IEnumerable"))
									{
										*(int*)((byte*)ptr + 16) = 0;
										foreach (object item in (IEnumerable)object_)
										{
											if (*(int*)((byte*)ptr + 16) <= 20)
											{
												method_0(new Class39(item, firstLevel: false), null);
												(*(int*)((byte*)ptr + 16))++;
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
				(*(int*)ptr)++;
			}
		}
	}

	private unsafe void method_6(Class39 objectToWrite)
	{
		void* ptr = stackalloc byte[13];
		FieldInfo[] fields = objectToWrite.type_0.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		FieldInfo[] array = fields;
		*(int*)ptr = 0;
		while (*(int*)ptr < array.Length)
		{
			FieldInfo fieldInfo = array[*(int*)ptr];
			try
			{
				if (!fieldInfo.IsLiteral && (!fieldInfo.IsStatic || !fieldInfo.IsInitOnly))
				{
					((byte*)ptr)[12] = 1;
					object[] customAttributes = fieldInfo.GetCustomAttributes(inherit: true);
					*(int*)((byte*)ptr + 4) = 0;
					while (*(int*)((byte*)ptr + 4) < customAttributes.Length)
					{
						Attribute attribute = (Attribute)customAttributes[*(int*)((byte*)ptr + 4)];
						if (!(attribute.GetType().Name == "DoNotCaptureAttribute"))
						{
							(*(int*)((byte*)ptr + 4))++;
							continue;
						}
						((byte*)ptr)[12] = 0;
						break;
					}
					if (((byte*)ptr)[12] != 0)
					{
						method_0(new Class39(fieldInfo.GetValue(objectToWrite.object_0), firstLevel: false), fieldInfo);
					}
				}
			}
			catch
			{
			}
			(*(int*)ptr)++;
		}
		objectToWrite = new Class39(objectToWrite.object_0, objectToWrite.type_0.BaseType, objectToWrite.bool_0);
		if ((object)objectToWrite.type_0 != null)
		{
			using (new Class48(xmlWriter_0, "Field"))
			{
				method_2("__base");
				XmlWriter xmlWriter = xmlWriter_0;
				*(int*)((byte*)ptr + 8) = list_0.Count;
				xmlWriter.WriteAttributeString("ID", ((int*)((byte*)ptr + 8))->ToString());
			}
			list_0.Add(objectToWrite);
		}
	}

	[Attribute10("Unhandled Exception Report Sent")]
	internal unsafe bool method_7()
	{
		void* ptr = stackalloc byte[5];
		try
		{
			Class32.smethod_30((Class34)this, Enum2.const_0);
			byte[] reportData;
			try
			{
				reportData = method_4();
			}
			catch (Exception ex)
			{
				*(int*)ptr = -1;
				try
				{
					StackTrace stackTrace = new StackTrace(ex);
					if (stackTrace.FrameCount > 0)
					{
						StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
						*(int*)ptr = frame.GetILOffset();
					}
				}
				catch
				{
				}
				Class32.smethod_72((Class34)this, Enum2.const_0, $"ERR 2006: {ex.Message} @ 0x{*(int*)ptr:x4}");
				((byte*)ptr)[4] = 0;
				goto end_IL_0005;
			}
			Class38 notificationEmailSettings = new Class38("", "", "v1.4.4.2 from 19/04/2012 00:14:13");
			((byte*)ptr)[4] = (Class32.smethod_132(reportData, notificationEmailSettings, (Class34)this) ? ((byte)1) : ((byte)0));
			end_IL_0005:;
		}
		catch (ThreadAbortException)
		{
			((byte*)ptr)[4] = 0;
		}
		catch (Exception fatalException)
		{
			Class32.smethod_71(this, new EventArgs0(fatalException));
			((byte*)ptr)[4] = 0;
		}
		return ((byte*)ptr)[4] != 0;
	}
}
