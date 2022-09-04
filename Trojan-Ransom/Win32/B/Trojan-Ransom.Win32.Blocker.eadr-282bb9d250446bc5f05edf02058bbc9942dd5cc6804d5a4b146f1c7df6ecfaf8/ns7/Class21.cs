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
using ns10;

namespace ns7;

internal class Class21 : Class20
{
	private struct Struct15
	{
		public readonly string string_0;

		public readonly string string_1;

		public readonly string string_2;

		public readonly int int_0;
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

	private readonly Guid guid_0;

	private readonly char[] char_0 = new char[0];

	private readonly Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();

	private readonly Dictionary<string, Struct15> dictionary_1 = new Dictionary<string, Struct15>();

	private readonly XmlWriter xmlWriter_0;

	private readonly List<Class25> list_0 = new List<Class25>();

	private readonly List<string> list_1 = new List<string>();

	private readonly Dictionary<string, int> dictionary_2 = new Dictionary<string, int>();

	private readonly List<Struct16> list_2 = new List<Struct16>();

	private readonly Dictionary<string, int> dictionary_3 = new Dictionary<string, int>();

	private readonly MemoryStream memoryStream_0;

	private byte[] byte_0;

	private Delegate0 delegate0_0;

	private EventHandler eventHandler_0;

	public Class21(Guid guid_1, Exception exception_1, IWebProxy iwebProxy_1)
	{
		guid_0 = guid_1;
		exception_0 = exception_1;
		memoryStream_0 = new MemoryStream();
		xmlWriter_0 = new XmlTextWriter(memoryStream_0, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		method_0(iwebProxy_1);
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
				return num.ToString("x");
			}
			if (object_0 is long num2)
			{
				return num2.ToString("x");
			}
			if (object_0 is short num3)
			{
				return num3.ToString("x");
			}
			if (object_0 is uint num4)
			{
				return num4.ToString("x");
			}
			if (object_0 is ulong num5)
			{
				return num5.ToString("x");
			}
			if (object_0 is ushort num6)
			{
				return num6.ToString("x");
			}
			if (object_0 is byte b)
			{
				return b.ToString("x");
			}
			if (object_0 is sbyte b2)
			{
				return b2.ToString("x");
			}
			if (object_0 is IntPtr intPtr)
			{
				return intPtr.ToInt64().ToString("x");
			}
			if (object_0 is UIntPtr)
			{
				return ((UIntPtr)object_0).ToUInt64().ToString("x");
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	private static string smethod_1(string string_0)
	{
		if (string_0.StartsWith("\"<RSAKeyValue>") && string_0.EndsWith("</RSAKeyValue>\""))
		{
			return "*** Information not reported for security reasons ***";
		}
		return string_0;
	}

	private void method_6(Class25 class25_0, FieldInfo fieldInfo_0)
	{
		string text = fieldInfo_0?.Name;
		string string_ = (((object)fieldInfo_0 == null) ? "Object" : "Field");
		object obj = class25_0.method_1();
		if (obj == null)
		{
			using (new Class31(xmlWriter_0, string_))
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
						method_10(fieldType.GetElementType());
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
						method_10(fieldType);
					}
				}
				if (text != null)
				{
					method_8(text);
				}
				xmlWriter_0.WriteAttributeString("Null", "1");
				return;
			}
		}
		Type type = class25_0.method_1().GetType();
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
		using (new Class31(xmlWriter_0, string_))
		{
			if ((object)fieldInfo_0 != null && fieldInfo_0.IsStatic)
			{
				xmlWriter_0.WriteAttributeString("Static", "1");
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
				if ((object)fieldInfo_0 != null)
				{
					method_10(fieldInfo_0.FieldType);
				}
				method_7(class25_0);
				if (text != null)
				{
					method_8(text);
				}
			}
		}
	}

	private void method_7(Class25 class25_0)
	{
		object objB = class25_0.method_1();
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
			list_0.Add(class25_0);
		}
		xmlWriter_0.WriteAttributeString("ID", num.ToString());
	}

	private void method_8(string string_0)
	{
		int num = method_11(string_0);
		if (num != -1)
		{
			xmlWriter_0.WriteAttributeString("NameID", num.ToString());
		}
		else
		{
			xmlWriter_0.WriteAttributeString("Name", string_0);
		}
	}

	private static Struct17 smethod_2(Type type_0)
	{
		Struct17 result = Struct17.smethod_0();
		if ((object)type_0 != null && (object)type_0.Assembly.GetType("SmartAssembly.Attributes.PoweredByAttribute") != null)
		{
			result.string_0 = ((type_0.MetadataToken & 0xFFFFFF) - 1).ToString();
			Assembly assembly = type_0.Assembly;
			result.struct16_0 = new Struct16(assembly.ManifestModule.ModuleVersionId.ToString("B"), assembly.FullName);
		}
		return result;
	}

	private int method_9(Struct17 struct17_0)
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

	private void method_10(Type type_0)
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
				xmlWriter_0.WriteAttributeString("TypeDefID", struct17_.string_0);
				int num = method_9(struct17_);
				if (num > 0)
				{
					xmlWriter_0.WriteAttributeString("Assembly", num.ToString());
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
				if (name.Length > 0 && name != "mscorlib")
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
			}
			xmlWriter_0.WriteAttributeString("TypeName", value.ToString());
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
			return "N/A";
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
		using (new Class31(xmlWriter_0, "UnhandledExceptionReport"))
		{
			xmlWriter_0.WriteAttributeString("AssemblyID", "{D277C1CB-A72B-49B5-AE9B-AB7823D8FAFD}".ToUpper());
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
			list_2.Add(new Struct16("{D277C1CB-A72B-49B5-AE9B-AB7823D8FAFD}", string.Empty));
			if (dictionary_3.Count > 0)
			{
				dictionary_3.Clear();
			}
			dictionary_3.Add("{D277C1CB-A72B-49B5-AE9B-AB7823D8FAFD}", 0);
			using (new Class31(xmlWriter_0, "Assemblies"))
			{
				Assembly assembly = smethod_4();
				Assembly[] array = method_12();
				foreach (Assembly assembly2 in array)
				{
					if ((object)assembly2 == null)
					{
						continue;
					}
					using (new Class31(xmlWriter_0, "Assembly"))
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
			using (new Class31(xmlWriter_0, "CustomProperties"))
			{
				if (dictionary_0 != null && dictionary_0.Count > 0)
				{
					foreach (string key in dictionary_0.Keys)
					{
						using (new Class31(xmlWriter_0, "CustomProperty"))
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
				using (new Class31(xmlWriter_0, "AttachedFiles"))
				{
					foreach (string key2 in dictionary_1.Keys)
					{
						using (new Class31(xmlWriter_0, "AttachedFile"))
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
			using (new Class31(xmlWriter_0, "SystemInformation"))
			{
				try
				{
					xmlWriter_0.WriteElementString("NETVersion", Environment.Version.ToString());
					xmlWriter_0.WriteElementString("OSVersion", Environment.OSVersion.Version.ToString());
					xmlWriter_0.WriteElementString("OSPlatformID", Environment.OSVersion.Platform.ToString());
					xmlWriter_0.WriteElementString("ServicePack", Class30.smethod_4());
					xmlWriter_0.WriteElementString("ServerR2", Class30.smethod_2() ? "1" : "0");
					xmlWriter_0.WriteElementString("X64", Class30.smethod_1() ? "1" : "0");
					xmlWriter_0.WriteElementString("Workstation", Class30.smethod_3() ? "1" : "0");
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
			using (new Class31(xmlWriter_0, "StackTrace"))
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
									using (new Class31(xmlWriter_0, "RemovedFrames"))
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
									Struct17 struct17_ = smethod_2(type);
									if (struct17_.method_0())
									{
										continue;
									}
									using (new Class31(xmlWriter_0, "StackFrame"))
									{
										xmlWriter_0.WriteAttributeString("MethodID", num2.ToString());
										xmlWriter_0.WriteAttributeString("ExceptionStackDepth", num4.ToString());
										int num5 = method_9(struct17_);
										if (num5 > 0)
										{
											xmlWriter_0.WriteAttributeString("Assembly", num5.ToString());
										}
										if (num3 != -1)
										{
											xmlWriter_0.WriteAttributeString("ILOffset", num3.ToString());
										}
										object[] array3 = array2;
										foreach (object object_ in array3)
										{
											try
											{
												method_6(new Class25(object_, bool_1: true), null);
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
			using (new Class31(xmlWriter_0, "TypeNames"))
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
			using (new Class31(xmlWriter_0, "AssemblyIDs"))
			{
				xmlWriter_0.WriteAttributeString("Count", list_2.Count.ToString());
				for (int l = 0; l < list_2.Count; l++)
				{
					using (new Class31(xmlWriter_0, "AssemblyID"))
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
		using (new Class31(xmlWriter_0, "Objects"))
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				Class25 @class = list_0[i];
				object obj = @class.method_1();
				Type type = @class.method_2();
				using (new Class31(xmlWriter_0, "ObjectDef"))
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
						method_10(type.GetElementType());
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
								method_6(new Class25(array2.GetValue(m), bool_1: false), null);
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
							using (new Class31(xmlWriter_0, "IEnumerable"))
							{
								int num = 0;
								foreach (object item in (IEnumerable)obj)
								{
									if (num <= 20)
									{
										method_6(new Class25(item, bool_1: false), null);
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

	private void method_15(Class25 class25_0)
	{
		FieldInfo[] fields = class25_0.method_2().GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
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
					method_6(new Class25(fieldInfo.GetValue(class25_0.method_1()), bool_1: false), fieldInfo);
				}
			}
			catch
			{
			}
		}
		class25_0 = new Class25(class25_0.method_1(), class25_0.method_2().BaseType, class25_0.method_0());
		if ((object)class25_0.method_2() != null)
		{
			using (new Class31(xmlWriter_0, "Field"))
			{
				method_8("__base");
				xmlWriter_0.WriteAttributeString("ID", list_0.Count.ToString());
			}
			list_0.Add(class25_0);
		}
	}

	private void method_16(Exception exception_1)
	{
		using (new Class31(xmlWriter_0, "Exception"))
		{
			try
			{
				Type type = exception_1.GetType();
				method_10(type);
				string value = "N/A";
				try
				{
					value = exception_1.Message;
				}
				catch
				{
				}
				xmlWriter_0.WriteAttributeString("Message", value);
				string text = exception_1.StackTrace!.Trim();
				xmlWriter_0.WriteAttributeString("ExceptionStackTrace", text);
				int num = text.IndexOf(' ');
				text = text.Substring(num + 1);
				num = text.IndexOf("\r\n");
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				xmlWriter_0.WriteAttributeString("Method", text);
				method_7(new Class25(exception_1, bool_1: true));
			}
			catch
			{
			}
		}
	}

	internal bool method_17()
	{
		Class46.smethod_0(1u);
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
				method_4(Enum0.const_0, $"ERR 2006: {ex.Message} @ 0x{num:x4}");
				return false;
			}
			Class24 class24_ = new Class24("", "1\u202egpj", "v0.0.0.0 from 24/02/2014 12:48:51");
			return method_1(array, class24_);
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
	public void method_18(Delegate0 delegate0_1)
	{
		Delegate0 @delegate = delegate0_0;
		Delegate0 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate0 value = (Delegate0)Delegate.Combine(delegate2, delegate0_1);
			@delegate = Interlocked.CompareExchange(ref delegate0_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	public void method_19(EventArgs0 eventArgs0_0)
	{
		delegate0_0?.Invoke(this, eventArgs0_0);
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
}
