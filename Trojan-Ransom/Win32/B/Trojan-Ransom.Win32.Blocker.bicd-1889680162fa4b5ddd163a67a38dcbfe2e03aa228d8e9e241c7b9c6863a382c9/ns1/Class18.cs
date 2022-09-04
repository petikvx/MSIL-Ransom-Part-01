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
using ns2;
using ns3;
using ns4;

namespace ns1;

internal sealed class Class18 : GClass4
{
	private struct Struct8
	{
		public readonly string string_0;

		public readonly string string_1;

		public readonly string string_2;

		public readonly int int_0;

		public Struct8(string string_3)
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
				byte[] array = new byte[int_0];
				using (FileStream fileStream = File.Open(string_3, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					fileStream.Read(array, 0, int_0);
					fileStream.Close();
				}
				byte[] inArray;
				try
				{
					inArray = GClass3.smethod_4(array);
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

		static Struct8()
		{
			GClass11.smethod_0();
		}
	}

	private struct Struct9
	{
		public readonly string string_0;

		public readonly string string_1;

		public Struct9(string string_2, string string_3)
		{
			string_0 = string_2;
			string_1 = string_3;
		}

		static Struct9()
		{
			GClass11.smethod_0();
		}
	}

	private struct Struct10
	{
		public string string_0;

		public Struct9 struct9_0;

		[SpecialName]
		public bool method_0()
		{
			return string_0.Length == 0;
		}

		[SpecialName]
		public static Struct10 smethod_0()
		{
			return new Struct10(string.Empty, string.Empty, string.Empty);
		}

		private Struct10(string string_1, string string_2, string string_3)
		{
			string_0 = string_1;
			struct9_0 = new Struct9(string_2, string_3);
		}

		static Struct10()
		{
			GClass11.smethod_0();
		}
	}

	private readonly Dictionary<string, Struct8> dictionary_0 = new Dictionary<string, Struct8>();

	private readonly List<Struct9> list_0 = new List<Struct9>();

	internal Exception exception_0;

	internal Guid guid_0;

	internal char[] char_0 = new char[0];

	internal Dictionary<string, object> dictionary_1 = new Dictionary<string, object>();

	internal XmlWriter xmlWriter_0;

	internal List<Class22> list_1 = new List<Class22>();

	internal List<string> list_2 = new List<string>();

	internal Dictionary<string, int> dictionary_2 = new Dictionary<string, int>();

	internal Dictionary<string, int> dictionary_3 = new Dictionary<string, int>();

	internal MemoryStream memoryStream_0;

	internal byte[] byte_0;

	internal GDelegate0 gdelegate0_0;

	internal EventHandler eventHandler_0;

	public Class18(Guid guid_1, Exception exception_1, IWebProxy iwebProxy_1)
	{
		Guid guid = (guid_0 = guid_1);
		Exception ex = (exception_0 = exception_1);
		MemoryStream memoryStream = (memoryStream_0 = new MemoryStream());
		XmlWriter xmlWriter = (xmlWriter_0 = new XmlTextWriter(memoryStream_0, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false)));
		method_0(iwebProxy_1);
		switch ("UNICODE".ToUpper())
		{
		case "UNICODE":
		{
			char[] array2 = (char_0 = new char[58]
			{
				'\u0001', '\u0002', '\u0003', '\u0004', '\u0005', '\u0006', '\a', '\b', '\u000e', '\u000f',
				'\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017', '\u0018', '\u0019',
				'\u001a', '\u001b', '\u001c', '\u001d', '\u001e', '\u001f', '\u007f', '\u0080', '\u0081', '\u0082',
				'\u0083', '\u0084', '\u0086', '\u0087', '\u0088', '\u0089', '\u008a', '\u008b', '\u008c', '\u008d',
				'\u008e', '\u008f', '\u0090', '\u0091', '\u0092', '\u0093', '\u0094', '\u0095', '\u0096', '\u0097',
				'\u0098', '\u0099', '\u009a', '\u009b', '\u009c', '\u009d', '\u009e', '\u009f'
			});
			break;
		}
		case "ASCII":
		{
			char[] array = (char_0 = new char[62]
			{
				'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
				'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
				'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D',
				'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
				'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X',
				'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7',
				'8', '9'
			});
			break;
		}
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

	private static string smethod_1(string string_1)
	{
		if (string_1.StartsWith("\"<RSAKeyValue>") && string_1.EndsWith("</RSAKeyValue>\""))
		{
			return "*** Information not reported for security reasons ***";
		}
		return string_1;
	}

	private void method_5(Class22 class22_0, FieldInfo fieldInfo_0)
	{
		string text = fieldInfo_0?.Name;
		string text2 = (((object)fieldInfo_0 == null) ? "Object" : "Field");
		object obj = class22_0.method_1();
		if (obj == null)
		{
			using (new Class27(xmlWriter_0, text2))
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
						method_9(fieldType.GetElementType());
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
						method_9(fieldType);
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
		Type type = class22_0.method_1().GetType();
		string text3 = null;
		string text4 = null;
		if (obj is string)
		{
			text3 = "System.String";
		}
		if (text3 == null)
		{
			if (!type.IsPrimitive && !(obj is IntPtr) && !(obj is UIntPtr))
			{
				if (type.IsValueType && (object)type.Module != GetType().Module)
				{
					text3 = type.FullName;
				}
			}
			else
			{
				text3 = type.FullName;
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
					text4 = stringBuilder.ToString();
				}
				if (obj is bool)
				{
					text4 = obj.ToString()!.ToLower();
				}
				if (text4 == null)
				{
					string text5 = smethod_0(obj);
					if (text5.Length > 0)
					{
						StringBuilder stringBuilder2 = new StringBuilder();
						stringBuilder2.Append(obj.ToString());
						stringBuilder2.Append(" (0x");
						stringBuilder2.Append(text5);
						stringBuilder2.Append(')');
						text4 = stringBuilder2.ToString();
					}
					else
					{
						text4 = obj.ToString();
					}
				}
			}
		}
		using (new Class27(xmlWriter_0, text2))
		{
			if ((object)fieldInfo_0 != null && fieldInfo_0.IsStatic)
			{
				xmlWriter_0.WriteAttributeString("Static", "1");
			}
			if (text3 != null)
			{
				method_9(type);
				if (text != null)
				{
					method_7(text);
				}
				if (type.IsEnum)
				{
					text4 = obj.ToString();
				}
				if (obj is Guid)
				{
					text4 = string.Concat("{", obj, "}");
				}
				if (text4 == null)
				{
					text4 = string.Concat("\"", obj, "\"");
				}
				xmlWriter_0.WriteAttributeString("Value", smethod_1(text4));
			}
			else
			{
				if ((object)fieldInfo_0 != null)
				{
					method_9(fieldInfo_0.FieldType);
				}
				method_6(class22_0);
				if (text != null)
				{
					method_7(text);
				}
			}
		}
	}

	private void method_6(Class22 class22_0)
	{
		object objB = class22_0.method_1();
		int num = -1;
		for (int i = 0; i < list_1.Count; i++)
		{
			if (object.ReferenceEquals(list_1[i].method_1(), objB))
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			num = list_1.Count;
			list_1.Add(class22_0);
		}
		xmlWriter_0.WriteAttributeString("ID", num.ToString());
	}

	private void method_7(string string_1)
	{
		int num = method_10(string_1);
		if (num != -1)
		{
			xmlWriter_0.WriteAttributeString("NameID", num.ToString());
		}
		else
		{
			xmlWriter_0.WriteAttributeString("Name", string_1);
		}
	}

	private static Struct10 smethod_2(Type type_0)
	{
		Struct10 result = Struct10.smethod_0();
		if ((object)type_0 != null && (object)type_0.Assembly.GetType("SmartAssembly.Attributes.PoweredByAttribute") != null)
		{
			result.string_0 = ((type_0.MetadataToken & 0xFFFFFF) - 1).ToString();
			Assembly assembly = type_0.Assembly;
			result.struct9_0 = new Struct9(assembly.ManifestModule.ModuleVersionId.ToString("B"), assembly.FullName);
		}
		return result;
	}

	private int method_8(Struct10 struct10_0)
	{
		string key = struct10_0.struct9_0.string_0.ToUpper();
		if (dictionary_3.ContainsKey(key))
		{
			return dictionary_3[key];
		}
		int count = list_0.Count;
		list_0.Add(struct10_0.struct9_0);
		dictionary_3.Add(key, count);
		return count;
	}

	private void method_9(Type type_0)
	{
		if ((object)type_0 == null)
		{
			return;
		}
		try
		{
			Struct10 struct10_ = smethod_2(type_0);
			if (!struct10_.method_0())
			{
				xmlWriter_0.WriteAttributeString("TypeDefID", struct10_.string_0);
				int num = method_8(struct10_);
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
				value = list_2.Count;
				list_2.Add(stringBuilder.ToString());
				dictionary_2.Add(fullName, value);
			}
			xmlWriter_0.WriteAttributeString("TypeName", value.ToString());
		}
		catch
		{
		}
	}

	private int method_10(string string_1)
	{
		try
		{
			bool flag = char_0[0] == '\u0001';
			if (string_1 != null && string_1.Length != 0 && (!flag || string_1.Length <= 4) && (flag || string_1[0] == '#'))
			{
				int num = 0;
				int num2 = string_1.Length - 1;
				while (true)
				{
					if (num2 >= 0 && (flag || num2 != 0))
					{
						char c = string_1[num2];
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
		using (new Class27(xmlWriter_0, "UnhandledExceptionReport"))
		{
			xmlWriter_0.WriteAttributeString("AssemblyID", "{6E58F09E-1D19-4C9A-BA17-00BCCC513BF5}".ToUpper());
			xmlWriter_0.WriteAttributeString("DateTime", DateTime.Now.ToString("s"));
			xmlWriter_0.WriteAttributeString("Path", smethod_3());
			if (guid_0 != Guid.Empty)
			{
				XmlWriter xmlWriter = xmlWriter_0;
				Guid guid = guid_0;
				xmlWriter.WriteAttributeString("UserID", guid.ToString("B"));
			}
			xmlWriter_0.WriteAttributeString("ReportID", Guid.NewGuid().ToString("B"));
			if (list_0.Count > 0)
			{
				list_0.Clear();
			}
			list_0.Add(new Struct9("{6E58F09E-1D19-4C9A-BA17-00BCCC513BF5}", string.Empty));
			if (dictionary_3.Count > 0)
			{
				dictionary_3.Clear();
			}
			dictionary_3.Add("{6E58F09E-1D19-4C9A-BA17-00BCCC513BF5}", 0);
			using (new Class27(xmlWriter_0, "Assemblies"))
			{
				Assembly assembly = smethod_4();
				Assembly[] array = method_11();
				foreach (Assembly assembly2 in array)
				{
					if ((object)assembly2 == null)
					{
						continue;
					}
					using (new Class27(xmlWriter_0, "Assembly"))
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
			using (new Class27(xmlWriter_0, "CustomProperties"))
			{
				if (dictionary_1 != null && dictionary_1.Count > 0)
				{
					foreach (string key in dictionary_1.Keys)
					{
						using (new Class27(xmlWriter_0, "CustomProperty"))
						{
							xmlWriter_0.WriteAttributeString("Name", key);
							string text = (string)dictionary_1[key];
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
			if (dictionary_0 != null && dictionary_0.Count > 0)
			{
				using (new Class27(xmlWriter_0, "AttachedFiles"))
				{
					foreach (string key2 in dictionary_0.Keys)
					{
						using (new Class27(xmlWriter_0, "AttachedFile"))
						{
							xmlWriter_0.WriteAttributeString("Key", key2);
							Struct8 @struct = dictionary_0[key2];
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
			using (new Class27(xmlWriter_0, "SystemInformation"))
			{
				try
				{
					xmlWriter_0.WriteElementString("NETVersion", Environment.Version.ToString());
					xmlWriter_0.WriteElementString("OSVersion", Environment.OSVersion.Version.ToString());
					xmlWriter_0.WriteElementString("OSPlatformID", Environment.OSVersion.Platform.ToString());
					xmlWriter_0.WriteElementString("ServicePack", GClass10.smethod_4());
					xmlWriter_0.WriteElementString("ServerR2", GClass10.smethod_2() ? "1" : "0");
					xmlWriter_0.WriteElementString("X64", GClass10.smethod_1() ? "1" : "0");
					xmlWriter_0.WriteElementString("Workstation", GClass10.smethod_3() ? "1" : "0");
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
			using (new Class27(xmlWriter_0, "StackTrace"))
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
									using (new Class27(xmlWriter_0, "RemovedFrames"))
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
									Struct10 struct10_ = smethod_2(type);
									if (struct10_.method_0())
									{
										continue;
									}
									using (new Class27(xmlWriter_0, "StackFrame"))
									{
										xmlWriter_0.WriteAttributeString("MethodID", num2.ToString());
										xmlWriter_0.WriteAttributeString("ExceptionStackDepth", num4.ToString());
										int num5 = method_8(struct10_);
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
												method_5(new Class22(object_, bool_1: true), null);
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
			using (new Class27(xmlWriter_0, "TypeNames"))
			{
				xmlWriter_0.WriteAttributeString("Count", list_2.Count.ToString());
				for (int k = 0; k < list_2.Count; k++)
				{
					string value;
					try
					{
						value = list_2[k].ToString();
					}
					catch (Exception ex)
					{
						value = '"' + ex.Message + '"';
					}
					xmlWriter_0.WriteElementString("TypeName", value);
				}
			}
			using (new Class27(xmlWriter_0, "AssemblyIDs"))
			{
				xmlWriter_0.WriteAttributeString("Count", list_0.Count.ToString());
				for (int l = 0; l < list_0.Count; l++)
				{
					using (new Class27(xmlWriter_0, "AssemblyID"))
					{
						Struct9 struct2 = list_0[l];
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
		byte[] array4 = (byte_0 = memoryStream_0.ToArray());
		return byte_0;
	}

	private void method_14()
	{
		using (new Class27(xmlWriter_0, "Objects"))
		{
			for (int i = 0; i < list_1.Count; i++)
			{
				Class22 @class = list_1[i];
				object obj = @class.method_1();
				Type type = @class.method_2();
				using (new Class27(xmlWriter_0, "ObjectDef"))
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
								method_5(new Class22(array2.GetValue(m), bool_1: false), null);
							}
							catch
							{
							}
						}
						continue;
					}
					method_9(type);
					if (!@class.method_0() || !flag)
					{
						continue;
					}
					try
					{
						if (obj is IEnumerable)
						{
							using (new Class27(xmlWriter_0, "IEnumerable"))
							{
								int num = 0;
								foreach (object item in (IEnumerable)obj)
								{
									if (num <= 20)
									{
										method_5(new Class22(item, bool_1: false), null);
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

	private void method_15(Class22 class22_0)
	{
		FieldInfo[] fields = class22_0.method_2().GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
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
					method_5(new Class22(fieldInfo.GetValue(class22_0.method_1()), bool_1: false), fieldInfo);
				}
			}
			catch
			{
			}
		}
		class22_0 = new Class22(class22_0.method_1(), class22_0.method_2().BaseType, class22_0.method_0());
		if ((object)class22_0.method_2() != null)
		{
			using (new Class27(xmlWriter_0, "Field"))
			{
				method_7("__base");
				xmlWriter_0.WriteAttributeString("ID", list_1.Count.ToString());
			}
			list_1.Add(class22_0);
		}
	}

	private void method_16(Exception exception_1)
	{
		using (new Class27(xmlWriter_0, "Exception"))
		{
			try
			{
				Type type = exception_1.GetType();
				method_9(type);
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
				method_6(new Class22(exception_1, bool_1: true));
			}
			catch
			{
			}
		}
	}

	internal void method_17(string string_1, object object_0)
	{
		dictionary_1.Add(string_1, object_0);
	}

	internal void method_18(string string_1, string string_2)
	{
		if (File.Exists(string_2))
		{
			Struct8 value = new Struct8(string_2);
			dictionary_0.Add(string_1, value);
		}
	}

	internal bool method_19()
	{
		Class39.smethod_0(1u);
		try
		{
			method_4(GEnum1.const_0);
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
				method_3(GEnum1.const_0, $"ERR 2006: {ex.Message} @ 0x{num:x4}");
				return false;
			}
			Class21 class21_ = new Class21("", "ddddd", "v0.0.0.0 from 07/06/2013 12:51:56 ص");
			return method_1(array, class21_);
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception exception_)
		{
			method_21(new GEventArgs0(exception_));
			return false;
		}
	}

	[SpecialName]
	public void method_20(GDelegate0 gdelegate0_1)
	{
		GDelegate0 gDelegate = gdelegate0_0;
		GDelegate0 gDelegate2;
		do
		{
			gDelegate2 = gDelegate;
			GDelegate0 value = (GDelegate0)Delegate.Combine(gDelegate2, gdelegate0_1);
			gDelegate = Interlocked.CompareExchange(ref gdelegate0_0, value, gDelegate2);
		}
		while ((object)gDelegate != gDelegate2);
	}

	public void method_21(GEventArgs0 geventArgs0_0)
	{
		gdelegate0_0?.Invoke(this, geventArgs0_0);
	}

	[SpecialName]
	public void method_22(EventHandler eventHandler_1)
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

	internal void method_23()
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			method_24(tempFileName);
			string path = GClass1.smethod_0();
			Process.Start(Path.Combine(path, "SmartAssembly.exe"), "/AddExceptionReport \"" + tempFileName + "\"");
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
			method_21(new GEventArgs0(exception_));
		}
	}

	internal bool method_24(string string_1)
	{
		try
		{
			byte[] array = method_13();
			byte[] array2;
			try
			{
				array2 = GClass3.smethod_4(array);
			}
			catch
			{
				array2 = null;
			}
			byte[] array3 = Class17.smethod_0(array2, "<RSAKeyValue><Modulus>xDrp4GnCR0V35kcPM9DNy/vnR9ZUsDAFHXlrhtpx+9EXKjxor1uvARQor6S7AAyoKa28a5Tajd2S4aOOKAlylB6Ge8ysCUS289dxFCEuNsgJarD3abwhm5h4kJlHOwd1jZm6ZxQ1wrzdCIcjZNHJ47ijwbh8c6+hw0OaCQa2Hc0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			FileStream fileStream = File.OpenWrite(string_1);
			byte[] bytes = Encoding.ASCII.GetBytes("{6E58F09E-1D19-4C9A-BA17-00BCCC513BF5}");
			fileStream.Write(bytes, 0, bytes.Length);
			fileStream.Write(array3, 0, array3.Length);
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

	static Class18()
	{
		GClass11.smethod_0();
	}
}
