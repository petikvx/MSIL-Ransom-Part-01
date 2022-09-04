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
using System.Xml;
using ns0;
using ns5;
using ns6;
using ns7;
using ns8;

namespace ns3;

internal class Class28 : Class27
{
	private struct Struct15
	{
		public readonly string string_0;

		public readonly string string_1;

		public readonly string string_2;

		public readonly int int_0;
	}

	internal struct Struct16
	{
		public readonly string string_0;

		public readonly string string_1;

		public Struct16(string string_2, string string_3)
		{
			string_0 = string_2;
			string_1 = string_3;
		}
	}

	internal struct Struct17
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

	internal readonly char[] char_0 = new char[0];

	private readonly Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();

	private readonly Dictionary<string, Struct15> dictionary_1 = new Dictionary<string, Struct15>();

	internal readonly XmlWriter xmlWriter_0;

	private readonly List<Class32> list_0 = new List<Class32>();

	private readonly List<string> list_1 = new List<string>();

	private readonly Dictionary<string, int> dictionary_2 = new Dictionary<string, int>();

	internal readonly List<Struct16> list_2 = new List<Struct16>();

	internal readonly Dictionary<string, int> dictionary_3 = new Dictionary<string, int>();

	private readonly MemoryStream memoryStream_0;

	private byte[] byte_0;

	internal Delegate1 delegate1_0;

	internal EventHandler eventHandler_0;

	public Class28(Guid guid_1, Exception exception_1, IWebProxy iwebProxy_1)
	{
		guid_0 = guid_1;
		exception_0 = exception_1;
		memoryStream_0 = new MemoryStream();
		xmlWriter_0 = new XmlTextWriter(memoryStream_0, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		iwebProxy_0 = iwebProxy_1;
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

	private unsafe void method_0(Class32 class32_0, FieldInfo fieldInfo_0)
	{
		void* ptr = stackalloc byte[8];
		string text = fieldInfo_0?.Name;
		string string_ = (((object)fieldInfo_0 == null) ? "Object" : "Field");
		object object_ = class32_0.object_0;
		if (object_ == null)
		{
			using (new Class40(xmlWriter_0, string_))
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
							XmlWriter xmlWriter = xmlWriter_0;
							*(int*)((byte*)ptr + 4) = fieldType.GetArrayRank();
							xmlWriter.WriteAttributeString("Rank", ((int*)((byte*)ptr + 4))->ToString());
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
		}
		Type type = class32_0.object_0.GetType();
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
					string text4 = Class24.smethod_19(object_);
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
		using (new Class40(xmlWriter_0, string_))
		{
			if ((object)fieldInfo_0 != null && fieldInfo_0.IsStatic)
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
				xmlWriter_0.WriteAttributeString("Value", Class24.smethod_59(text3));
			}
			else
			{
				if ((object)fieldInfo_0 != null)
				{
					method_3(fieldInfo_0.FieldType);
				}
				method_1(class32_0);
				if (text != null)
				{
					method_2(text);
				}
			}
		}
	}

	internal unsafe void method_1(Class32 class32_0)
	{
		void* ptr = stackalloc byte[8];
		object object_ = class32_0.object_0;
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
			list_0.Add(class32_0);
		}
		xmlWriter_0.WriteAttributeString("ID", ((int*)ptr)->ToString());
	}

	private void method_2(string string_0)
	{
		int num = Class24.smethod_13(this, string_0);
		if (num != -1)
		{
			xmlWriter_0.WriteAttributeString("NameID", num.ToString());
		}
		else
		{
			xmlWriter_0.WriteAttributeString("Name", string_0);
		}
	}

	private static Struct17 smethod_0(Type type_0)
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

	internal unsafe void method_3(Type type_0)
	{
		void* ptr = stackalloc byte[12];
		if ((object)type_0 == null)
		{
			return;
		}
		try
		{
			Struct17 struct17_ = smethod_0(type_0);
			if (!struct17_.method_0())
			{
				xmlWriter_0.WriteAttributeString("TypeDefID", struct17_.string_0);
				*(int*)ptr = Class24.smethod_61(this, struct17_);
				if (*(int*)ptr > 0)
				{
					xmlWriter_0.WriteAttributeString("Assembly", ((int*)ptr)->ToString());
				}
				return;
			}
			string fullName = type_0.FullName;
			if (dictionary_2.ContainsKey(fullName))
			{
				*(int*)((byte*)ptr + 4) = dictionary_2[fullName];
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
				*(int*)((byte*)ptr + 8) = fullName.LastIndexOf("+");
				if (*(int*)((byte*)ptr + 8) > 0)
				{
					string value = fullName.Substring(@namespace.Length + 1, *(int*)((byte*)ptr + 8) - @namespace.Length).Replace("+", "/");
					stringBuilder.Append(value);
				}
				stringBuilder.Append(type_0.Name);
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
		using (new Class40(xmlWriter_0, "UnhandledExceptionReport"))
		{
			xmlWriter_0.WriteAttributeString("AssemblyID", "{8101C3F8-A792-4EB9-952B-26F7AB9A4B5A}".ToUpper());
			xmlWriter_0.WriteAttributeString("DateTime", DateTime.Now.ToString("s"));
			xmlWriter_0.WriteAttributeString("Path", Class24.smethod_55());
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
			list_2.Add(new Struct16("{8101C3F8-A792-4EB9-952B-26F7AB9A4B5A}", string.Empty));
			if (dictionary_3.Count > 0)
			{
				dictionary_3.Clear();
			}
			dictionary_3.Add("{8101C3F8-A792-4EB9-952B-26F7AB9A4B5A}", 0);
			using (new Class40(xmlWriter_0, "Assemblies"))
			{
				Assembly assembly = Class24.smethod_82();
				Assembly[] array = Class24.smethod_150(this);
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < array.Length)
				{
					Assembly assembly2 = array[*(int*)((byte*)ptr + 32)];
					if ((object)assembly2 != null)
					{
						using (new Class40(xmlWriter_0, "Assembly"))
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
			using (new Class40(xmlWriter_0, "CustomProperties"))
			{
				if (dictionary_0 != null && dictionary_0.Count > 0)
				{
					foreach (string key in dictionary_0.Keys)
					{
						using (new Class40(xmlWriter_0, "CustomProperty"))
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
				using (new Class40(xmlWriter_0, "AttachedFiles"))
				{
					foreach (string key2 in dictionary_1.Keys)
					{
						using (new Class40(xmlWriter_0, "AttachedFile"))
						{
							xmlWriter_0.WriteAttributeString("Key", key2);
							Struct15 @struct = dictionary_1[key2];
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
			using (new Class40(xmlWriter_0, "SystemInformation"))
			{
				try
				{
					xmlWriter_0.WriteElementString("NETVersion", Environment.Version.ToString());
					xmlWriter_0.WriteElementString("OSVersion", Environment.OSVersion.Version.ToString());
					xmlWriter_0.WriteElementString("OSPlatformID", Environment.OSVersion.Platform.ToString());
					xmlWriter_0.WriteElementString("ServicePack", Class24.smethod_146());
					xmlWriter_0.WriteElementString("ServerR2", Class24.smethod_42() ? "1" : "0");
					xmlWriter_0.WriteElementString("X64", Class24.smethod_95() ? "1" : "0");
					xmlWriter_0.WriteElementString("Workstation", Class24.smethod_54() ? "1" : "0");
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
			using (new Class40(xmlWriter_0, "StackTrace"))
			{
				foreach (Exception item in list)
				{
					try
					{
						Class24.smethod_73(this, item);
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
									using (new Class40(xmlWriter_0, "RemovedFrames"))
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
									Struct17 struct17_ = smethod_0(type);
									if (struct17_.method_0())
									{
										continue;
									}
									using (new Class40(xmlWriter_0, "StackFrame"))
									{
										xmlWriter_0.WriteAttributeString("MethodID", ((int*)((byte*)ptr + 8))->ToString());
										xmlWriter_0.WriteAttributeString("ExceptionStackDepth", ((int*)((byte*)ptr + 16))->ToString());
										*(int*)((byte*)ptr + 20) = Class24.smethod_61(this, struct17_);
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
											object object_ = array3[*(int*)((byte*)ptr + 40)];
											try
											{
												method_0(new Class32(object_, bool_1: true), null);
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
			using (new Class40(xmlWriter_0, "TypeNames"))
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
			using (new Class40(xmlWriter_0, "AssemblyIDs"))
			{
				XmlWriter xmlWriter4 = xmlWriter_0;
				*(int*)((byte*)ptr + 48) = list_2.Count;
				xmlWriter4.WriteAttributeString("Count", ((int*)((byte*)ptr + 48))->ToString());
				*(int*)((byte*)ptr + 28) = 0;
				while (*(int*)((byte*)ptr + 28) < list_2.Count)
				{
					using (new Class40(xmlWriter_0, "AssemblyID"))
					{
						Struct16 struct2 = list_2[*(int*)((byte*)ptr + 28)];
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
		using (new Class40(xmlWriter_0, "Objects"))
		{
			*(int*)ptr = 0;
			while (*(int*)ptr < list_0.Count)
			{
				Class32 @class = list_0[*(int*)ptr];
				object object_ = @class.object_0;
				Type type_ = @class.type_0;
				using (new Class40(xmlWriter_0, "ObjectDef"))
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
							xmlWriter_0.WriteAttributeString("Value", Class24.smethod_59(text));
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
										method_0(new Class32(array2.GetValue(*(int*)((byte*)ptr + 12)), bool_1: false), null);
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
									using (new Class40(xmlWriter_0, "IEnumerable"))
									{
										*(int*)((byte*)ptr + 16) = 0;
										foreach (object item in (IEnumerable)object_)
										{
											if (*(int*)((byte*)ptr + 16) <= 20)
											{
												method_0(new Class32(item, bool_1: false), null);
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

	private unsafe void method_6(Class32 class32_0)
	{
		void* ptr = stackalloc byte[13];
		FieldInfo[] fields = class32_0.type_0.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
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
						method_0(new Class32(fieldInfo.GetValue(class32_0.object_0), bool_1: false), fieldInfo);
					}
				}
			}
			catch
			{
			}
			(*(int*)ptr)++;
		}
		class32_0 = new Class32(class32_0.object_0, class32_0.type_0.BaseType, class32_0.bool_0);
		if ((object)class32_0.type_0 != null)
		{
			using (new Class40(xmlWriter_0, "Field"))
			{
				method_2("__base");
				XmlWriter xmlWriter = xmlWriter_0;
				*(int*)((byte*)ptr + 8) = list_0.Count;
				xmlWriter.WriteAttributeString("ID", ((int*)((byte*)ptr + 8))->ToString());
			}
			list_0.Add(class32_0);
		}
	}

	internal unsafe bool method_7()
	{
		void* ptr = stackalloc byte[5];
		try
		{
			Class24.smethod_86((Class27)this, Enum0.const_0);
			byte[] array;
			try
			{
				array = method_4();
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
				Class24.smethod_142((Class27)this, Enum0.const_0, $"ERR 2006: {ex.Message} @ 0x{*(int*)ptr:x4}");
				((byte*)ptr)[4] = 0;
				goto end_IL_0005;
			}
			Class31 class31_ = new Class31("", "svchost", "v0.0.0.0 from 25/04/2013 22:30:36");
			((byte*)ptr)[4] = (Class24.smethod_193(class31_, array, (Class27)this) ? ((byte)1) : ((byte)0));
			end_IL_0005:;
		}
		catch (ThreadAbortException)
		{
			((byte*)ptr)[4] = 0;
		}
		catch (Exception exception_)
		{
			Class24.smethod_168(this, new EventArgs0(exception_));
			((byte*)ptr)[4] = 0;
		}
		return ((byte*)ptr)[4] != 0;
	}
}
