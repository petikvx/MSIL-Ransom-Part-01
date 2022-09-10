using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using ns0;
using ns10;
using ns2;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;
using ns9;

namespace ns1;

internal sealed class Class23 : Class22
{
	private struct Struct15
	{
		public readonly string string_0;

		public readonly string string_1;

		public readonly string string_2;

		public readonly int int_0;

		public Struct15(string fileName)
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
					inArray = Class9.smethod_2(buffer);
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

		public Struct16(string assemblyID, string assemblyFullName)
		{
			string_0 = assemblyID;
			string_1 = assemblyFullName;
		}
	}

	private struct Struct17
	{
		public string string_0;

		public Struct16 struct16_0;

		public bool IsEmpty => string_0.Length == 0;

		public static Struct17 Empty => new Struct17(string.Empty, string.Empty, string.Empty);

		private Struct17(string id, string assemblyID, string assemblyFullName)
		{
			string_0 = id;
			struct16_0 = new Struct16(assemblyID, assemblyFullName);
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

	private readonly char[] char_0 = new char[0];

	private readonly Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();

	private readonly Dictionary<string, Struct15> dictionary_1 = new Dictionary<string, Struct15>();

	private readonly XmlWriter xmlWriter_0;

	private readonly List<Class27> list_0 = new List<Class27>();

	private readonly List<string> list_1 = new List<string>();

	private readonly Dictionary<string, int> dictionary_2 = new Dictionary<string, int>();

	private readonly List<Struct16> list_2 = new List<Struct16>();

	private readonly Dictionary<string, int> dictionary_3 = new Dictionary<string, int>();

	private readonly MemoryStream memoryStream_0;

	private byte[] byte_0;

	private Delegate1 delegate1_0;

	private EventHandler eventHandler_0;

	public event Delegate1 FatalException
	{
		add
		{
			Delegate1 @delegate = delegate1_0;
			Delegate1 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate1 value2 = (Delegate1)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate1_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			Delegate1 @delegate = delegate1_0;
			Delegate1 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate1 value2 = (Delegate1)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate1_0, value2, delegate2);
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

	public Class23(Guid userId, Exception currentException, IWebProxy proxy)
	{
		guid_0 = userId;
		exception_0 = currentException;
		memoryStream_0 = new MemoryStream();
		xmlWriter_0 = new XmlTextWriter(memoryStream_0, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		method_0(proxy);
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

	private static string smethod_0(object o)
	{
		try
		{
			if (o == null)
			{
				return string.Empty;
			}
			if (o is int num)
			{
				return num.ToString("x");
			}
			if (o is long num2)
			{
				return num2.ToString("x");
			}
			if (o is short num3)
			{
				return num3.ToString("x");
			}
			if (o is uint num4)
			{
				return num4.ToString("x");
			}
			if (o is ulong num5)
			{
				return num5.ToString("x");
			}
			if (o is ushort num6)
			{
				return num6.ToString("x");
			}
			if (o is byte b)
			{
				return b.ToString("x");
			}
			if (o is sbyte b2)
			{
				return b2.ToString("x");
			}
			if (o is IntPtr intPtr)
			{
				return intPtr.ToInt64().ToString("x");
			}
			if (o is UIntPtr)
			{
				return ((UIntPtr)o).ToUInt64().ToString("x");
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	private static string smethod_1(string value)
	{
		if (value.StartsWith("\"<RSAKeyValue>") && value.EndsWith("</RSAKeyValue>\""))
		{
			return "*** Information not reported for security reasons ***";
		}
		return value;
	}

	private void method_5(Class27 objectAndType, FieldInfo fieldType)
	{
		string text = fieldType?.Name;
		string name = (((object)fieldType == null) ? "Object" : "Field");
		object obj = objectAndType.method_0();
		if (obj == null)
		{
			using (new Class36(xmlWriter_0, name))
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
						method_9(fieldType2.GetElementType());
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
							xmlWriter_0.WriteAttributeString("Rank", fieldType2.GetArrayRank().ToString());
						}
					}
					else
					{
						method_9(fieldType2);
					}
				}
				if (text != null)
				{
					method_7(text);
				}
				xmlWriter_0.WriteAttributeString("Null", "1");
				return;
			}
		}
		Type type = objectAndType.method_0().GetType();
		string text2 = null;
		string text3 = null;
		if (obj is string)
		{
			text2 = "System.String";
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
						stringBuilder.Append("' ");
					}
					stringBuilder.Append("(0x");
					stringBuilder.Append(num.ToString("x"));
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
						stringBuilder2.Append(" (0x");
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
		using (new Class36(xmlWriter_0, name))
		{
			if ((object)fieldType != null && fieldType.IsStatic)
			{
				xmlWriter_0.WriteAttributeString("Static", "1");
			}
			if (text2 != null)
			{
				method_9(type);
				if (text != null)
				{
					method_7(text);
				}
				if (type.IsEnum)
				{
					text3 = obj.ToString();
				}
				if (obj is Guid)
				{
					text3 = string.Concat("{", obj, "}");
				}
				if (text3 == null)
				{
					text3 = string.Concat("\"", obj, "\"");
				}
				xmlWriter_0.WriteAttributeString("Value", smethod_1(text3));
			}
			else
			{
				if ((object)fieldType != null)
				{
					method_9(fieldType.FieldType);
				}
				method_6(objectAndType);
				if (text != null)
				{
					method_7(text);
				}
			}
		}
	}

	private void method_6(Class27 objectAndType)
	{
		object objB = objectAndType.method_0();
		int num = -1;
		for (int i = 0; i < list_0.Count; i++)
		{
			if (object.ReferenceEquals(list_0[i].method_0(), objB))
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			num = list_0.Count;
			list_0.Add(objectAndType);
		}
		xmlWriter_0.WriteAttributeString("ID", num.ToString());
	}

	private void method_7(string name)
	{
		int num = method_10(name);
		if (num != -1)
		{
			xmlWriter_0.WriteAttributeString("NameID", num.ToString());
		}
		else
		{
			xmlWriter_0.WriteAttributeString("Name", name);
		}
	}

	private static Struct17 smethod_2(Type objectType)
	{
		Struct17 empty = Struct17.Empty;
		if ((object)objectType != null && (object)objectType.Assembly.GetType("SmartAssembly.Attributes.PoweredByAttribute") != null)
		{
			empty.string_0 = ((objectType.MetadataToken & 0xFFFFFF) - 1).ToString();
			Assembly assembly = objectType.Assembly;
			empty.struct16_0 = new Struct16(assembly.ManifestModule.ModuleVersionId.ToString("B"), assembly.FullName);
		}
		return empty;
	}

	private int method_8(Struct17 typeInformation)
	{
		string key = typeInformation.struct16_0.string_0.ToUpper();
		if (dictionary_3.ContainsKey(key))
		{
			return dictionary_3[key];
		}
		int count = list_2.Count;
		list_2.Add(typeInformation.struct16_0);
		dictionary_3.Add(key, count);
		return count;
	}

	private void method_9(Type objectType)
	{
		if ((object)objectType == null)
		{
			return;
		}
		try
		{
			Struct17 typeInformation = smethod_2(objectType);
			if (!typeInformation.IsEmpty)
			{
				xmlWriter_0.WriteAttributeString("TypeDefID", typeInformation.string_0);
				int num = method_8(typeInformation);
				if (num > 0)
				{
					xmlWriter_0.WriteAttributeString("Assembly", num.ToString());
				}
				return;
			}
			string fullName = objectType.FullName;
			int value;
			if (dictionary_2.ContainsKey(fullName))
			{
				value = dictionary_2[fullName];
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
				int num2 = fullName.LastIndexOf("+");
				if (num2 > 0)
				{
					string value2 = fullName.Substring(@namespace.Length + 1, num2 - @namespace.Length).Replace("+", "/");
					stringBuilder.Append(value2);
				}
				stringBuilder.Append(objectType.Name);
				value = list_1.Count;
				list_1.Add(stringBuilder.ToString());
				dictionary_2.Add(fullName, value);
			}
			xmlWriter_0.WriteAttributeString("TypeName", value.ToString());
		}
		catch
		{
		}
	}

	private int method_10(string obfuscatedName)
	{
		try
		{
			bool flag = char_0[0] == '\u0001';
			if (obfuscatedName != null && obfuscatedName.Length != 0 && (!flag || obfuscatedName.Length <= 4) && (flag || obfuscatedName[0] == '#'))
			{
				int num = 0;
				int num2 = obfuscatedName.Length - 1;
				while (true)
				{
					if (num2 >= 0 && (flag || num2 != 0))
					{
						char c = obfuscatedName[num2];
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
			return "N/A";
		}
	}

	private Assembly[] method_11()
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

	internal byte[] method_12()
	{
		return method_13();
	}

	private byte[] method_13()
	{
		if (byte_0 != null)
		{
			return byte_0;
		}
		xmlWriter_0.WriteStartDocument();
		using (new Class36(xmlWriter_0, "UnhandledExceptionReport"))
		{
			xmlWriter_0.WriteAttributeString("AssemblyID", "{F0C71864-193B-4207-B969-A15E8EDFFBBB}".ToUpper());
			xmlWriter_0.WriteAttributeString("DateTime", DateTime.Now.ToString("s"));
			xmlWriter_0.WriteAttributeString("Path", smethod_3());
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
			list_2.Add(new Struct16("{F0C71864-193B-4207-B969-A15E8EDFFBBB}", string.Empty));
			if (dictionary_3.Count > 0)
			{
				dictionary_3.Clear();
			}
			dictionary_3.Add("{F0C71864-193B-4207-B969-A15E8EDFFBBB}", 0);
			using (new Class36(xmlWriter_0, "Assemblies"))
			{
				Assembly assembly = smethod_4();
				Assembly[] array = method_11();
				foreach (Assembly assembly2 in array)
				{
					if ((object)assembly2 == null)
					{
						continue;
					}
					using (new Class36(xmlWriter_0, "Assembly"))
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
			using (new Class36(xmlWriter_0, "CustomProperties"))
			{
				if (dictionary_0 != null && dictionary_0.Count > 0)
				{
					foreach (string key in dictionary_0.Keys)
					{
						using (new Class36(xmlWriter_0, "CustomProperty"))
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
				using (new Class36(xmlWriter_0, "AttachedFiles"))
				{
					foreach (string key2 in dictionary_1.Keys)
					{
						using (new Class36(xmlWriter_0, "AttachedFile"))
						{
							xmlWriter_0.WriteAttributeString("Key", key2);
							Struct15 @struct = dictionary_1[key2];
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
			using (new Class36(xmlWriter_0, "SystemInformation"))
			{
				try
				{
					xmlWriter_0.WriteElementString("NETVersion", Environment.Version.ToString());
					xmlWriter_0.WriteElementString("OSVersion", Environment.OSVersion.Version.ToString());
					xmlWriter_0.WriteElementString("OSPlatformID", Environment.OSVersion.Platform.ToString());
					xmlWriter_0.WriteElementString("ServicePack", Class35.ServicePack);
					xmlWriter_0.WriteElementString("ServerR2", Class35.IsServerR2 ? "1" : "0");
					xmlWriter_0.WriteElementString("X64", Class35.IsX64 ? "1" : "0");
					xmlWriter_0.WriteElementString("Workstation", Class35.IsWorkstation ? "1" : "0");
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
			using (new Class36(xmlWriter_0, "StackTrace"))
			{
				foreach (Exception item in list)
				{
					try
					{
						method_16(item);
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
									using (new Class36(xmlWriter_0, "RemovedFrames"))
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
									Struct17 typeInformation = smethod_2(type);
									if (typeInformation.IsEmpty)
									{
										continue;
									}
									using (new Class36(xmlWriter_0, "StackFrame"))
									{
										xmlWriter_0.WriteAttributeString("MethodID", num2.ToString());
										xmlWriter_0.WriteAttributeString("ExceptionStackDepth", num4.ToString());
										int num5 = method_8(typeInformation);
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
												method_5(new Class27(o, firstLevel: true), null);
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
			using (new Class36(xmlWriter_0, "TypeNames"))
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
			using (new Class36(xmlWriter_0, "AssemblyIDs"))
			{
				xmlWriter_0.WriteAttributeString("Count", list_2.Count.ToString());
				for (int l = 0; l < list_2.Count; l++)
				{
					using (new Class36(xmlWriter_0, "AssemblyID"))
					{
						Struct16 struct2 = list_2[l];
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

	private void method_14()
	{
		using (new Class36(xmlWriter_0, "Objects"))
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				Class27 @class = list_0[i];
				object obj = @class.method_0();
				Type type = @class.method_1();
				using (new Class36(xmlWriter_0, "ObjectDef"))
				{
					xmlWriter_0.WriteAttributeString("ID", i.ToString());
					string text = null;
					bool flag = true;
					string[] array = "".Split(new char[1] { ',' });
					foreach (string text2 in array)
					{
						if (text2 != "" && type.FullName!.StartsWith(text2))
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
							text = obj.ToString();
							text = ((text == type.FullName) ? null : (type.IsEnum ? Enum.Format(type, obj, "d") : ((!(obj is Guid)) ? ("\"" + text + "\"") : ("{" + text + "}"))));
						}
						catch
						{
						}
						if (text != null)
						{
							xmlWriter_0.WriteAttributeString("Value", smethod_1(text));
						}
					}
					if (type.HasElementType)
					{
						method_9(type.GetElementType());
						if (type.IsByRef)
						{
							xmlWriter_0.WriteAttributeString("ByRef", "1");
						}
						if (type.IsPointer)
						{
							xmlWriter_0.WriteAttributeString("Pointer", "1");
						}
						if (!type.IsArray)
						{
							continue;
						}
						Array array2 = (Array)obj;
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
								method_5(new Class27(array2.GetValue(m), firstLevel: false), null);
							}
							catch
							{
							}
						}
						continue;
					}
					method_9(type);
					if (!@class.FirstLevel || !flag)
					{
						continue;
					}
					try
					{
						if (obj is IEnumerable)
						{
							using (new Class36(xmlWriter_0, "IEnumerable"))
							{
								int num = 0;
								foreach (object item in (IEnumerable)obj)
								{
									if (num <= 20)
									{
										method_5(new Class27(item, firstLevel: false), null);
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
					method_15(@class);
				}
			}
		}
	}

	private void method_15(Class27 objectToWrite)
	{
		FieldInfo[] fields = objectToWrite.method_1().GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
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
					if (attribute.GetType().Name == "DoNotCaptureAttribute")
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					method_5(new Class27(fieldInfo.GetValue(objectToWrite.method_0()), firstLevel: false), fieldInfo);
				}
			}
			catch
			{
			}
		}
		objectToWrite = new Class27(objectToWrite.method_0(), objectToWrite.method_1().BaseType, objectToWrite.FirstLevel);
		if ((object)objectToWrite.method_1() != null)
		{
			using (new Class36(xmlWriter_0, "Field"))
			{
				method_7("__base");
				xmlWriter_0.WriteAttributeString("ID", list_0.Count.ToString());
			}
			list_0.Add(objectToWrite);
		}
	}

	private void method_16(Exception exceptionToWrite)
	{
		using (new Class36(xmlWriter_0, "Exception"))
		{
			try
			{
				Type type = exceptionToWrite.GetType();
				method_9(type);
				string value = "N/A";
				try
				{
					value = exceptionToWrite.Message;
				}
				catch
				{
				}
				xmlWriter_0.WriteAttributeString("Message", value);
				string text = exceptionToWrite.StackTrace!.Trim();
				xmlWriter_0.WriteAttributeString("ExceptionStackTrace", text);
				int num = text.IndexOf(' ');
				text = text.Substring(num + 1);
				num = text.IndexOf("\r\n");
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				xmlWriter_0.WriteAttributeString("Method", text);
				method_6(new Class27(exceptionToWrite, firstLevel: true));
			}
			catch
			{
			}
		}
	}

	internal void method_17(string name, object value)
	{
		dictionary_0.Add(name, value);
	}

	internal void method_18(string name, string fileName)
	{
		if (File.Exists(fileName))
		{
			Struct15 value = new Struct15(fileName);
			dictionary_1.Add(name, value);
		}
	}

	[Attribute9("Unhandled Exception Report Sent")]
	internal bool method_19()
	{
		Class52.smethod_0(1u);
		try
		{
			method_4(Enum1.const_0);
			byte[] reportData;
			try
			{
				reportData = method_13();
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
				method_3(Enum1.const_0, $"ERR 2006: {ex.Message} @ 0x{num:x4}");
				return false;
			}
			Class26 notificationEmailSettings = new Class26("", "ABAUhaIGR0VI", "v4.2.4.5 from 5/25/2014 8:04:17 AM");
			return method_1(reportData, notificationEmailSettings);
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception fatalException)
		{
			method_20(new EventArgs0(fatalException));
			return false;
		}
	}

	public void method_20(EventArgs0 e)
	{
		delegate1_0?.Invoke(this, e);
	}

	private void method_21()
	{
		eventHandler_0?.Invoke(this, EventArgs.Empty);
	}

	internal void method_22()
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			method_23(tempFileName);
			string path = Class4.smethod_0();
			Process.Start(Path.Combine(path, "SmartAssembly.exe"), "/AddExceptionReport \"" + tempFileName + "\"");
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, EventArgs.Empty);
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception fatalException)
		{
			method_20(new EventArgs0(fatalException));
		}
	}

	internal bool method_23(string fileName)
	{
		try
		{
			byte[] buffer = method_13();
			byte[] data;
			try
			{
				data = Class9.smethod_2(buffer);
			}
			catch
			{
				data = null;
			}
			byte[] array = Class21.smethod_0(data, "<RSAKeyValue><Modulus>n6J9m8OYa1exXG6ZBNtnFJorH0WNhaXXzmaBj5GvrOx6bJJ6ZHN0CaJ/Q2NFEbuola/QuSDzNCQxTBFzsitGl/8NJZ+/qVY4SlFHh+zIGxPFzOrtvOABq994JJbY+a06COOzsewJ55wsDmT1f88/EeltMVoOyOG7wF7LObp4sZE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			FileStream fileStream = File.OpenWrite(fileName);
			byte[] bytes = Encoding.ASCII.GetBytes("{F0C71864-193B-4207-B969-A15E8EDFFBBB}");
			fileStream.Write(bytes, 0, bytes.Length);
			fileStream.Write(array, 0, array.Length);
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
