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

namespace ns4;

internal class Class27 : Class26
{
	private struct Struct7
	{
		public readonly string string_0;

		public readonly string string_1;

		public readonly string string_2;

		public readonly int int_0;
	}

	internal struct Struct8
	{
		public readonly string string_0;

		public readonly string string_1;

		public Struct8(string string_2, string string_3)
		{
			Class42.hMqjKD0znI7T7();
			string_0 = string_2;
			string_1 = string_3;
		}
	}

	internal struct Struct9
	{
		public string string_0;

		public Struct8 struct8_0;

		[SpecialName]
		public bool method_0()
		{
			return string_0.Length == 0;
		}

		[SpecialName]
		public static Struct9 smethod_0()
		{
			return new Struct9(string.Empty, string.Empty, string.Empty);
		}

		private Struct9(string string_1, string string_2, string string_3)
		{
			Class42.hMqjKD0znI7T7();
			string_0 = string_1;
			struct8_0 = new Struct8(string_2, string_3);
		}
	}

	private readonly Exception exception_0;

	private readonly Guid guid_0;

	internal readonly char[] char_0;

	private readonly Dictionary<string, object> dictionary_0;

	private readonly Dictionary<string, Struct7> dictionary_1;

	internal XmlTextWriter xmlTextWriter_0;

	private readonly List<Class31> list_0;

	private readonly List<string> list_1;

	private readonly Dictionary<string, int> dictionary_2;

	internal readonly List<Struct8> list_2;

	internal readonly Dictionary<string, int> dictionary_3;

	private MemoryStream memoryStream_0;

	private byte[] byte_0;

	internal object object_0;

	internal EventHandler eventHandler_0;

	public Class27(Guid guid_1, Exception exception_1, IWebProxy iwebProxy_1)
	{
		Class42.hMqjKD0znI7T7();
		char_0 = new char[0];
		dictionary_0 = new Dictionary<string, object>();
		dictionary_1 = new Dictionary<string, Struct7>();
		list_0 = new List<Class31>();
		list_1 = new List<string>();
		dictionary_2 = new Dictionary<string, int>();
		list_2 = new List<Struct8>();
		dictionary_3 = new Dictionary<string, int>();
		base._002Ector();
		guid_0 = guid_1;
		exception_0 = exception_1;
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

	private void method_0(Class31 class31_0, FieldInfo fieldInfo_0)
	{
		string text = fieldInfo_0?.Name;
		string string_ = (((object)fieldInfo_0 == null) ? "Object" : "Field");
		object obj = class31_0.object_0;
		if (obj == null)
		{
			using (new Class39(xmlTextWriter_0, string_))
			{
				if ((object)fieldInfo_0 != null)
				{
					if (fieldInfo_0.IsStatic)
					{
						xmlTextWriter_0.WriteAttributeString("Static", "1");
					}
					Type fieldType = fieldInfo_0.FieldType;
					if ((object)fieldType != null && fieldType.HasElementType)
					{
						method_3(fieldType.GetElementType());
						if (fieldType.IsByRef)
						{
							xmlTextWriter_0.WriteAttributeString("ByRef", "1");
						}
						if (fieldType.IsPointer)
						{
							xmlTextWriter_0.WriteAttributeString("Pointer", "1");
						}
						if (fieldType.IsArray)
						{
							xmlTextWriter_0.WriteAttributeString("Rank", fieldType.GetArrayRank().ToString());
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
				xmlTextWriter_0.WriteAttributeString("Null", "1");
				return;
			}
		}
		Type type = class31_0.object_0.GetType();
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
					string text4 = Class24.smethod_147(obj);
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
		using (new Class39(xmlTextWriter_0, string_))
		{
			if ((object)fieldInfo_0 != null && fieldInfo_0.IsStatic)
			{
				xmlTextWriter_0.WriteAttributeString("Static", "1");
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
				xmlTextWriter_0.WriteAttributeString("Value", Class24.smethod_83(text3));
			}
			else
			{
				if ((object)fieldInfo_0 != null)
				{
					method_3(fieldInfo_0.FieldType);
				}
				method_1(class31_0);
				if (text != null)
				{
					method_2(text);
				}
			}
		}
	}

	internal void method_1(Class31 class31_0)
	{
		object objB = class31_0.object_0;
		int num = -1;
		for (int i = 0; i < list_0.Count; i++)
		{
			if (object.ReferenceEquals(list_0[i].object_0, objB))
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			num = list_0.Count;
			list_0.Add(class31_0);
		}
		xmlTextWriter_0.WriteAttributeString("ID", num.ToString());
	}

	private void method_2(string string_0)
	{
		int num = Class24.smethod_66(this, string_0);
		if (num != -1)
		{
			xmlTextWriter_0.WriteAttributeString("NameID", num.ToString());
		}
		else
		{
			xmlTextWriter_0.WriteAttributeString("Name", string_0);
		}
	}

	private static Struct9 smethod_0(Type type_0)
	{
		Struct9 result = Struct9.smethod_0();
		if ((object)type_0 != null && (object)type_0.Assembly.GetType("SmartAssembly.Attributes.PoweredByAttribute") != null)
		{
			result.string_0 = ((type_0.MetadataToken & 0xFFFFFF) - 1).ToString();
			Assembly assembly = type_0.Assembly;
			result.struct8_0 = new Struct8(assembly.ManifestModule.ModuleVersionId.ToString("B"), assembly.FullName);
		}
		return result;
	}

	internal void method_3(Type type_0)
	{
		if ((object)type_0 == null)
		{
			return;
		}
		try
		{
			Struct9 struct9_ = smethod_0(type_0);
			if (!struct9_.method_0())
			{
				xmlTextWriter_0.WriteAttributeString("TypeDefID", struct9_.string_0);
				int num = Class24.smethod_16(struct9_, this);
				if (num > 0)
				{
					xmlTextWriter_0.WriteAttributeString("Assembly", num.ToString());
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
			xmlTextWriter_0.WriteAttributeString("TypeName", value.ToString());
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
		xmlTextWriter_0 = new XmlTextWriter(memoryStream_0, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		xmlTextWriter_0.WriteStartDocument();
		using (new Class39(xmlTextWriter_0, "UnhandledExceptionReport"))
		{
			xmlTextWriter_0.WriteAttributeString("AssemblyID", "{ED572A83-61B0-47F7-BC2D-38A950D9B848}".ToUpper());
			xmlTextWriter_0.WriteAttributeString("DateTime", DateTime.Now.ToString("s"));
			xmlTextWriter_0.WriteAttributeString("Path", Class24.smethod_168());
			if (guid_0 != Guid.Empty)
			{
				XmlTextWriter xmlTextWriter = xmlTextWriter_0;
				Guid guid = guid_0;
				xmlTextWriter.WriteAttributeString("UserID", guid.ToString("B"));
			}
			xmlTextWriter_0.WriteAttributeString("ReportID", Guid.NewGuid().ToString("B"));
			if (list_2.Count > 0)
			{
				list_2.Clear();
			}
			list_2.Add(new Struct8("{ED572A83-61B0-47F7-BC2D-38A950D9B848}", string.Empty));
			if (dictionary_3.Count > 0)
			{
				dictionary_3.Clear();
			}
			dictionary_3.Add("{ED572A83-61B0-47F7-BC2D-38A950D9B848}", 0);
			using (new Class39(xmlTextWriter_0, "Assemblies"))
			{
				Assembly assembly = Class24.smethod_137();
				Assembly[] array = Class24.smethod_158(this);
				foreach (Assembly assembly2 in array)
				{
					if ((object)assembly2 == null)
					{
						continue;
					}
					using (new Class39(xmlTextWriter_0, "Assembly"))
					{
						try
						{
							xmlTextWriter_0.WriteAttributeString("Name", assembly2.FullName);
							xmlTextWriter_0.WriteAttributeString("CodeBase", assembly2.CodeBase);
							if ((object)assembly2 == assembly)
							{
								xmlTextWriter_0.WriteAttributeString("This", "1");
							}
						}
						catch
						{
						}
					}
				}
			}
			using (new Class39(xmlTextWriter_0, "CustomProperties"))
			{
				if (dictionary_0 != null && dictionary_0.Count > 0)
				{
					foreach (string key in dictionary_0.Keys)
					{
						using (new Class39(xmlTextWriter_0, "CustomProperty"))
						{
							xmlTextWriter_0.WriteAttributeString("Name", key);
							string text = (string)dictionary_0[key];
							if (text == null)
							{
								xmlTextWriter_0.WriteAttributeString("Null", "1");
							}
							else
							{
								xmlTextWriter_0.WriteAttributeString("Value", "\"" + text + "\"");
							}
						}
					}
				}
			}
			if (dictionary_1 != null && dictionary_1.Count > 0)
			{
				using (new Class39(xmlTextWriter_0, "AttachedFiles"))
				{
					foreach (string key2 in dictionary_1.Keys)
					{
						using (new Class39(xmlTextWriter_0, "AttachedFile"))
						{
							xmlTextWriter_0.WriteAttributeString("Key", key2);
							Struct7 @struct = dictionary_1[key2];
							xmlTextWriter_0.WriteAttributeString("FileName", @struct.string_0);
							XmlTextWriter xmlTextWriter2 = xmlTextWriter_0;
							int int_ = @struct.int_0;
							xmlTextWriter2.WriteAttributeString("Length", int_.ToString());
							if (@struct.string_2.Length > 0)
							{
								xmlTextWriter_0.WriteAttributeString("Error", @struct.string_2);
							}
							else
							{
								xmlTextWriter_0.WriteAttributeString("Data", @struct.string_1);
							}
						}
					}
				}
			}
			using (new Class39(xmlTextWriter_0, "SystemInformation"))
			{
				try
				{
					xmlTextWriter_0.WriteElementString("NETVersion", Environment.Version.ToString());
					xmlTextWriter_0.WriteElementString("OSVersion", Environment.OSVersion.Version.ToString());
					xmlTextWriter_0.WriteElementString("OSPlatformID", Environment.OSVersion.Platform.ToString());
					xmlTextWriter_0.WriteElementString("ServicePack", Class24.smethod_171());
					xmlTextWriter_0.WriteElementString("ServerR2", Class24.smethod_107() ? "1" : "0");
					xmlTextWriter_0.WriteElementString("X64", Class24.smethod_159() ? "1" : "0");
					xmlTextWriter_0.WriteElementString("Workstation", Class24.smethod_49() ? "1" : "0");
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
			using (new Class39(xmlTextWriter_0, "StackTrace"))
			{
				foreach (Exception item in list)
				{
					try
					{
						Class24.smethod_165(this, item);
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
									using (new Class39(xmlTextWriter_0, "RemovedFrames"))
									{
										xmlTextWriter_0.WriteAttributeString("TotalFramesCount", count.ToString());
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
									Struct9 struct9_ = smethod_0(type);
									if (struct9_.method_0())
									{
										continue;
									}
									using (new Class39(xmlTextWriter_0, "StackFrame"))
									{
										xmlTextWriter_0.WriteAttributeString("MethodID", num2.ToString());
										xmlTextWriter_0.WriteAttributeString("ExceptionStackDepth", num4.ToString());
										int num5 = Class24.smethod_16(struct9_, this);
										if (num5 > 0)
										{
											xmlTextWriter_0.WriteAttributeString("Assembly", num5.ToString());
										}
										if (num3 != -1)
										{
											xmlTextWriter_0.WriteAttributeString("ILOffset", num3.ToString());
										}
										object[] array3 = array2;
										foreach (object object_ in array3)
										{
											try
											{
												method_0(new Class31(object_, bool_1: true), null);
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
			using (new Class39(xmlTextWriter_0, "TypeNames"))
			{
				xmlTextWriter_0.WriteAttributeString("Count", list_1.Count.ToString());
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
					xmlTextWriter_0.WriteElementString("TypeName", value);
				}
			}
			using (new Class39(xmlTextWriter_0, "AssemblyIDs"))
			{
				xmlTextWriter_0.WriteAttributeString("Count", list_2.Count.ToString());
				for (int l = 0; l < list_2.Count; l++)
				{
					using (new Class39(xmlTextWriter_0, "AssemblyID"))
					{
						Struct8 struct2 = list_2[l];
						xmlTextWriter_0.WriteAttributeString("ID", struct2.string_0);
						if (struct2.string_1.Length > 0)
						{
							xmlTextWriter_0.WriteAttributeString("FullName", struct2.string_1);
						}
					}
				}
			}
		}
		xmlTextWriter_0.WriteEndDocument();
		xmlTextWriter_0.Flush();
		memoryStream_0.Flush();
		byte_0 = memoryStream_0.ToArray();
		return byte_0;
	}

	private void method_5()
	{
		using (new Class39(xmlTextWriter_0, "Objects"))
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				Class31 @class = list_0[i];
				object obj = @class.object_0;
				Type type_ = @class.type_0;
				using (new Class39(xmlTextWriter_0, "ObjectDef"))
				{
					xmlTextWriter_0.WriteAttributeString("ID", i.ToString());
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
							text = obj.ToString();
							text = ((text == type_.FullName) ? null : (type_.IsEnum ? Enum.Format(type_, obj, "d") : ((!(obj is Guid)) ? ("\"" + text + "\"") : ("{" + text + "}"))));
						}
						catch
						{
						}
						if (text != null)
						{
							xmlTextWriter_0.WriteAttributeString("Value", Class24.smethod_83(text));
						}
					}
					if (type_.HasElementType)
					{
						method_3(type_.GetElementType());
						if (type_.IsByRef)
						{
							xmlTextWriter_0.WriteAttributeString("ByRef", "1");
						}
						if (type_.IsPointer)
						{
							xmlTextWriter_0.WriteAttributeString("Pointer", "1");
						}
						if (!type_.IsArray)
						{
							continue;
						}
						Array array2 = (Array)obj;
						xmlTextWriter_0.WriteAttributeString("Rank", array2.Rank.ToString());
						StringBuilder stringBuilder = new StringBuilder();
						for (int l = 0; l < array2.Rank; l++)
						{
							if (l > 0)
							{
								stringBuilder.Append(',');
							}
							stringBuilder.Append(array2.GetLength(l));
						}
						xmlTextWriter_0.WriteAttributeString("Length", stringBuilder.ToString());
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
								method_0(new Class31(array2.GetValue(m), bool_1: false), null);
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
						if (obj is IEnumerable)
						{
							using (new Class39(xmlTextWriter_0, "IEnumerable"))
							{
								int num = 0;
								foreach (object item in (IEnumerable)obj)
								{
									if (num <= 20)
									{
										method_0(new Class31(item, bool_1: false), null);
										num++;
										continue;
									}
									xmlTextWriter_0.WriteElementString("More", string.Empty);
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

	private void method_6(Class31 class31_0)
	{
		FieldInfo[] fields = class31_0.type_0.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
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
					method_0(new Class31(fieldInfo.GetValue(class31_0.object_0), bool_1: false), fieldInfo);
				}
			}
			catch
			{
			}
		}
		class31_0 = new Class31(class31_0.object_0, class31_0.type_0.BaseType, class31_0.bool_0);
		if ((object)class31_0.type_0 != null)
		{
			using (new Class39(xmlTextWriter_0, "Field"))
			{
				method_2("__base");
				xmlTextWriter_0.WriteAttributeString("ID", list_0.Count.ToString());
			}
			list_0.Add(class31_0);
		}
	}

	internal bool method_7()
	{
		try
		{
			Class24.smethod_115((Class26)this, Enum0.const_0);
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
				Class24.smethod_67((Class26)this, Enum0.const_0, $"ERR 2006: {ex.Message} @ 0x{num:x4}");
				return false;
			}
			Class30 class30_ = new Class30("", "1234", "v0.0.0.0 from 26/02/36 12:27:45 م");
			return Class24.smethod_39(array, class30_, (Class26)this);
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception exception_)
		{
			Class24.smethod_173(this, new EventArgs0(exception_));
			return false;
		}
	}
}
