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

namespace ns9;

internal class Class40 : Class39
{
	private struct Struct12
	{
		public readonly string string_0;

		public readonly string string_1;

		public readonly string string_2;

		public readonly int int_0;
	}

	internal struct Struct13
	{
		public readonly string string_0;

		public readonly string string_1;

		public Struct13(string string_2, string string_3)
		{
			string_0 = string_2;
			string_1 = string_3;
		}

		internal static bool kJuIIMGSl1WMLaQ3qn3()
		{
			return true;
		}

		internal static bool oAFT6VGGAX9T0mkdTHO()
		{
			return false;
		}
	}

	internal struct Struct14
	{
		public string string_0;

		public Struct13 struct13_0;

		[SpecialName]
		public bool method_0()
		{
			return string_0.Length == 0;
		}

		[SpecialName]
		public static Struct14 smethod_0()
		{
			return new Struct14(string.Empty, string.Empty, string.Empty);
		}

		private Struct14(string string_1, string string_2, string string_3)
		{
			string_0 = string_1;
			struct13_0 = new Struct13(string_2, string_3);
		}

		internal static bool aymi1dGbYKhM1qaASRe()
		{
			return true;
		}

		internal static bool GoG3ceGdJOTZC10vKLk()
		{
			return false;
		}
	}

	private readonly Exception exception_0;

	private readonly Guid guid_0;

	internal readonly char[] char_0 = new char[0];

	internal readonly Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();

	private readonly Dictionary<string, Struct12> dictionary_1 = new Dictionary<string, Struct12>();

	internal XmlWriter xmlWriter_0;

	private readonly List<Class44> list_0 = new List<Class44>();

	private readonly List<string> list_1 = new List<string>();

	private readonly Dictionary<string, int> dictionary_2 = new Dictionary<string, int>();

	internal readonly List<Struct13> list_2 = new List<Struct13>();

	internal readonly Dictionary<string, int> dictionary_3 = new Dictionary<string, int>();

	private MemoryStream memoryStream_0;

	private byte[] byte_0;

	internal Delegate13 delegate13_0;

	internal EventHandler eventHandler_0;

	public Class40(Guid guid_1, Exception exception_1, IWebProxy iwebProxy_1)
	{
		guid_0 = guid_1;
		exception_0 = exception_1;
		iwebProxy_0 = iwebProxy_1;
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

	private void method_0(Class44 class44_0, FieldInfo fieldInfo_0)
	{
		int num = 1;
		if (!McbCCSSq2QNfrxAvKJk())
		{
		}
		string text3 = default(string);
		StringBuilder stringBuilder2 = default(StringBuilder);
		int num2 = default(int);
		object object_ = default(object);
		string text2 = default(string);
		Type type = default(Type);
		StringBuilder stringBuilder = default(StringBuilder);
		string text = default(string);
		string string_ = default(string);
		string text4 = default(string);
		Class52 class2 = default(Class52);
		while (true)
		{
			object obj;
			switch (num)
			{
			case 12:
				obj = fieldInfo_0.Name;
				goto IL_001a;
			case 8:
				text3 = "System.String";
				goto IL_0054;
			case 6:
			case 9:
				stringBuilder2 = new StringBuilder();
				goto default;
			default:
				if (num2 >= 32)
				{
					stringBuilder2.Append('\'');
					stringBuilder2.Append((char)object_);
					stringBuilder2.Append("' ");
				}
				stringBuilder2.Append("(0x");
				stringBuilder2.Append(num2.ToString("x"));
				stringBuilder2.Append(')');
				goto case 4;
			case 4:
				text2 = stringBuilder2.ToString();
				goto IL_00ff;
			case 7:
				if (object_ is UIntPtr)
				{
					goto IL_006c;
				}
				if (type.IsValueType)
				{
					goto case 2;
				}
				goto IL_035d;
			case 0:
			case 5:
				if (object_ is char)
				{
					num2 = (char)object_;
					goto case 6;
				}
				goto IL_00ff;
			case 1:
				if ((object)fieldInfo_0 != null)
				{
					goto case 12;
				}
				obj = null;
				goto IL_001a;
			case 2:
				if ((object)type.Module != GetType().Module)
				{
					text3 = type.FullName;
				}
				goto IL_035d;
			case 11:
				stringBuilder.Append(text);
				goto case 13;
			case 10:
				using (new Class52(xmlWriter_0, string_))
				{
					if ((object)fieldInfo_0 != null)
					{
						if (fieldInfo_0.IsStatic)
						{
							goto IL_0279;
						}
						goto IL_028e;
					}
					goto IL_031b;
					IL_0279:
					xmlWriter_0.WriteAttributeString("Static", "1");
					goto IL_028e;
					IL_028e:
					while (true)
					{
						Type fieldType = fieldInfo_0.FieldType;
						if ((object)fieldType != null && fieldType.HasElementType)
						{
							if (rgDuieSBwv4sR2Q2GXW())
							{
								switch (6)
								{
								case 5:
									break;
								case 1:
								case 4:
									continue;
								case 6:
									method_3(fieldType.GetElementType());
									if (fieldType.IsByRef)
									{
										xmlWriter_0.WriteAttributeString("ByRef", "1");
									}
									goto IL_02ca;
								default:
									goto IL_02ca;
								case 0:
									goto IL_031b;
								case 7:
									goto IL_0327;
								}
								break;
							}
							goto IL_02ca;
						}
						method_3(fieldType);
						goto IL_031b;
						IL_02ca:
						if (fieldType.IsPointer)
						{
							xmlWriter_0.WriteAttributeString("Pointer", "1");
						}
						if (fieldType.IsArray)
						{
							xmlWriter_0.WriteAttributeString("Rank", fieldType.GetArrayRank().ToString());
						}
						goto IL_031b;
					}
					goto IL_0279;
					IL_031b:
					if (text4 != null)
					{
						method_2(text4);
					}
					goto IL_0327;
					IL_0327:
					xmlWriter_0.WriteAttributeString("Null", "1");
					return;
				}
			case 13:
				stringBuilder.Append(')');
				text2 = stringBuilder.ToString();
				goto IL_035d;
			case 14:
				break;
				IL_006c:
				text3 = type.FullName;
				num = 0;
				if (!McbCCSSq2QNfrxAvKJk())
				{
					continue;
				}
				goto case 8;
				IL_0054:
				if (text3 == null)
				{
					if (!type.IsPrimitive && !(object_ is IntPtr))
					{
						num = 7;
						if (McbCCSSq2QNfrxAvKJk())
						{
						}
						continue;
					}
					goto IL_006c;
				}
				goto IL_035d;
				IL_001a:
				text4 = (string)obj;
				string_ = (((object)fieldInfo_0 == null) ? "Object" : "Field");
				object_ = class44_0.object_0;
				if (object_ != null)
				{
					type = class44_0.object_0.GetType();
					text3 = null;
					text2 = null;
					if (!(object_ is string))
					{
						goto IL_0054;
					}
					goto case 8;
				}
				goto case 10;
				IL_00ff:
				if (object_ is bool)
				{
					text2 = object_.ToString()!.ToLower();
				}
				if (text2 == null)
				{
					text = Class17.smethod_195(object_);
					if (text.Length > 0)
					{
						stringBuilder = new StringBuilder();
						stringBuilder.Append(object_.ToString());
						stringBuilder.Append(" (0x");
						num = 11;
						if (McbCCSSq2QNfrxAvKJk())
						{
						}
						continue;
					}
					text2 = object_.ToString();
				}
				goto IL_035d;
				IL_035d:
				class2 = new Class52(xmlWriter_0, string_);
				break;
			}
			break;
		}
		try
		{
			if ((object)fieldInfo_0 != null && fieldInfo_0.IsStatic)
			{
				goto IL_03cc;
			}
			goto IL_03e1;
			IL_03cc:
			xmlWriter_0.WriteAttributeString("Static", "1");
			goto IL_03e1;
			IL_03e1:
			while (true)
			{
				if (text3 == null)
				{
					if ((object)fieldInfo_0 != null)
					{
						method_3(fieldInfo_0.FieldType);
					}
					method_1(class44_0);
					if (text4 == null)
					{
						return;
					}
					if (!McbCCSSq2QNfrxAvKJk())
					{
						switch (7)
						{
						case 6:
							break;
						case 0:
							continue;
						case 1:
						case 2:
							goto IL_03ed;
						default:
							goto IL_0402;
						case 4:
							goto IL_0411;
						case 7:
							method_2(text4);
							return;
						}
					}
					break;
				}
				method_3(type);
				goto IL_03ed;
				IL_0409:
				if (object_ is Guid)
				{
					goto IL_0411;
				}
				goto IL_0422;
				IL_03ed:
				if (text4 != null)
				{
					method_2(text4);
				}
				if (type.IsEnum)
				{
					goto IL_0402;
				}
				goto IL_0409;
				IL_0411:
				text2 = string.Concat("{", object_, "}");
				goto IL_0422;
				IL_0422:
				if (text2 == null)
				{
					text2 = string.Concat("\"", object_, "\"");
				}
				xmlWriter_0.WriteAttributeString("Value", Class17.smethod_73(text2));
				return;
				IL_0402:
				text2 = object_.ToString();
				goto IL_0409;
			}
			goto IL_03cc;
		}
		finally
		{
			((IDisposable)class2)?.Dispose();
		}
	}

	internal void method_1(Class44 class44_0)
	{
		while (true)
		{
			object object_ = class44_0.object_0;
			while (true)
			{
				int num = -1;
				int num2 = 0;
				while (true)
				{
					if (num2 < list_0.Count)
					{
						if (object.ReferenceEquals(list_0[num2].object_0, object_))
						{
							num = num2;
							if (rgDuieSBwv4sR2Q2GXW())
							{
								switch (0)
								{
								case 5:
									goto end_IL_0055;
								case 3:
									goto end_IL_0065;
								case 0:
								case 2:
									goto IL_0077;
								case 1:
								case 4:
									goto IL_0093;
								case 7:
									return;
								}
								continue;
							}
							goto IL_0093;
						}
						num2++;
						continue;
					}
					goto IL_0077;
					IL_0093:
					xmlWriter_0.WriteAttributeString("ID", num.ToString());
					return;
					IL_0077:
					if (num == -1)
					{
						num = list_0.Count;
						list_0.Add(class44_0);
					}
					goto IL_0093;
					continue;
					end_IL_0055:
					break;
				}
				continue;
				end_IL_0065:
				break;
			}
		}
	}

	private void method_2(string string_0)
	{
		while (true)
		{
			int num = Class17.smethod_135(this, string_0);
			if (rgDuieSBwv4sR2Q2GXW())
			{
				switch (4)
				{
				case 0:
				case 2:
					break;
				case 1:
				case 4:
					goto IL_0035;
				default:
					goto IL_0039;
				case 5:
					return;
				}
				continue;
			}
			goto IL_0035;
			IL_0039:
			xmlWriter_0.WriteAttributeString("NameID", num.ToString());
			return;
			IL_0035:
			if (num == -1)
			{
				break;
			}
			goto IL_0039;
		}
		xmlWriter_0.WriteAttributeString("Name", string_0);
	}

	private static Struct14 smethod_0(Type type_0)
	{
		Struct14 result = Struct14.smethod_0();
		if ((object)type_0 != null && (object)type_0.Assembly.GetType("SmartAssembly.Attributes.PoweredByAttribute") != null)
		{
			result.string_0 = ((type_0.MetadataToken & 0xFFFFFF) - 1).ToString();
			Assembly assembly = type_0.Assembly;
			result.struct13_0 = new Struct13(assembly.ManifestModule.ModuleVersionId.ToString("B"), assembly.FullName);
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
			Struct14 struct14_ = smethod_0(type_0);
			if (!struct14_.method_0())
			{
				xmlWriter_0.WriteAttributeString("TypeDefID", struct14_.string_0);
				int num = Class17.smethod_140(struct14_, this);
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

	internal byte[] method_4()
	{
		while (byte_0 == null)
		{
			memoryStream_0 = new MemoryStream();
			if (!rgDuieSBwv4sR2Q2GXW())
			{
				continue;
			}
			switch (4)
			{
			case 3:
				continue;
			case 2:
			case 4:
				xmlWriter_0 = new XmlTextWriter(memoryStream_0, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
				goto default;
			default:
				xmlWriter_0.WriteStartDocument();
				using (new Class52(xmlWriter_0, "UnhandledExceptionReport"))
				{
					xmlWriter_0.WriteAttributeString("AssemblyID", "{F10BA855-5D50-46A2-B1AD-DE0A2F07B75F}".ToUpper());
					xmlWriter_0.WriteAttributeString("DateTime", DateTime.Now.ToString("s"));
					xmlWriter_0.WriteAttributeString("Path", Class17.smethod_156());
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
					list_2.Add(new Struct13("{F10BA855-5D50-46A2-B1AD-DE0A2F07B75F}", string.Empty));
					if (dictionary_3.Count > 0)
					{
						dictionary_3.Clear();
					}
					dictionary_3.Add("{F10BA855-5D50-46A2-B1AD-DE0A2F07B75F}", 0);
					using (new Class52(xmlWriter_0, "Assemblies"))
					{
						Assembly assembly = Class17.smethod_88();
						Assembly[] array = Class17.smethod_194(this);
						foreach (Assembly assembly2 in array)
						{
							if ((object)assembly2 == null)
							{
								continue;
							}
							using (new Class52(xmlWriter_0, "Assembly"))
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
					using (new Class52(xmlWriter_0, "CustomProperties"))
					{
						if (dictionary_0 != null && dictionary_0.Count > 0)
						{
							foreach (string key in dictionary_0.Keys)
							{
								using (new Class52(xmlWriter_0, "CustomProperty"))
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
						using (new Class52(xmlWriter_0, "AttachedFiles"))
						{
							foreach (string key2 in dictionary_1.Keys)
							{
								using (new Class52(xmlWriter_0, "AttachedFile"))
								{
									xmlWriter_0.WriteAttributeString("Key", key2);
									Struct12 @struct = dictionary_1[key2];
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
					using (new Class52(xmlWriter_0, "SystemInformation"))
					{
						try
						{
							xmlWriter_0.WriteElementString("NETVersion", Environment.Version.ToString());
							xmlWriter_0.WriteElementString("OSVersion", Environment.OSVersion.Version.ToString());
							xmlWriter_0.WriteElementString("OSPlatformID", Environment.OSVersion.Platform.ToString());
							xmlWriter_0.WriteElementString("ServicePack", Class17.smethod_17());
							xmlWriter_0.WriteElementString("ServerR2", Class17.smethod_101() ? "1" : "0");
							xmlWriter_0.WriteElementString("X64", Class17.smethod_50() ? "1" : "0");
							xmlWriter_0.WriteElementString("Workstation", Class17.smethod_91() ? "1" : "0");
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
					using (new Class52(xmlWriter_0, "StackTrace"))
					{
						foreach (Exception item in list)
						{
							try
							{
								Class17.smethod_39(item, this);
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
											using (new Class52(xmlWriter_0, "RemovedFrames"))
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
											Struct14 struct14_ = smethod_0(type);
											if (struct14_.method_0())
											{
												continue;
											}
											using (new Class52(xmlWriter_0, "StackFrame"))
											{
												xmlWriter_0.WriteAttributeString("MethodID", num2.ToString());
												xmlWriter_0.WriteAttributeString("ExceptionStackDepth", num4.ToString());
												int num5 = Class17.smethod_140(struct14_, this);
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
														method_0(new Class44(object_, bool_1: true), null);
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
					using (new Class52(xmlWriter_0, "TypeNames"))
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
					using (new Class52(xmlWriter_0, "AssemblyIDs"))
					{
						xmlWriter_0.WriteAttributeString("Count", list_2.Count.ToString());
						for (int l = 0; l < list_2.Count; l++)
						{
							using (new Class52(xmlWriter_0, "AssemblyID"))
							{
								Struct13 struct2 = list_2[l];
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
				goto case 0;
			case 0:
				xmlWriter_0.Flush();
				memoryStream_0.Flush();
				byte_0 = memoryStream_0.ToArray();
				goto case 7;
			case 1:
			case 6:
				break;
			case 7:
				return byte_0;
			}
			break;
		}
		return byte_0;
	}

	private void method_5()
	{
		using (new Class52(xmlWriter_0, "Objects"))
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				Class44 @class = list_0[i];
				object object_ = @class.object_0;
				Type type_ = @class.type_0;
				using (new Class52(xmlWriter_0, "ObjectDef"))
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
							xmlWriter_0.WriteAttributeString("Value", Class17.smethod_73(text));
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
								method_0(new Class44(array2.GetValue(m), bool_1: false), null);
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
							using (new Class52(xmlWriter_0, "IEnumerable"))
							{
								int num = 0;
								foreach (object item in (IEnumerable)object_)
								{
									if (num <= 20)
									{
										method_0(new Class44(item, bool_1: false), null);
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

	private void method_6(Class44 class44_0)
	{
		int num = 3;
		if (McbCCSSq2QNfrxAvKJk())
		{
		}
		int num2 = default(int);
		FieldInfo[] array = default(FieldInfo[]);
		FieldInfo fieldInfo = default(FieldInfo);
		Class52 @class = default(Class52);
		FieldInfo[] fields = default(FieldInfo[]);
		while (true)
		{
			switch (num)
			{
			case 5:
				if (num2 < array.Length)
				{
					fieldInfo = array[num2];
					goto case 0;
				}
				class44_0 = new Class44(class44_0.object_0, class44_0.type_0.BaseType, class44_0.bool_0);
				if ((object)class44_0.type_0 != null)
				{
					@class = new Class52(xmlWriter_0, "Field");
					num = 6;
					if (!McbCCSSq2QNfrxAvKJk())
					{
						continue;
					}
				}
				return;
			case 0:
				try
				{
					if (!fieldInfo.IsLiteral && (!fieldInfo.IsStatic || !fieldInfo.IsInitOnly))
					{
						bool flag = true;
						object[] customAttributes = fieldInfo.GetCustomAttributes(inherit: true);
						for (int i = 0; i < customAttributes.Length; i++)
						{
							Attribute attribute = (Attribute)customAttributes[i];
							if (attribute.GetType().Name == "DoNotCaptureAttribute")
							{
								flag = false;
								break;
							}
						}
						if (flag)
						{
							method_0(new Class44(fieldInfo.GetValue(class44_0.object_0), bool_1: false), fieldInfo);
						}
					}
				}
				catch
				{
				}
				num2++;
				goto case 5;
			case 3:
				fields = class44_0.type_0.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				goto case 1;
			case 1:
			case 2:
				array = fields;
				num2 = 0;
				goto case 5;
			default:
				num = 5;
				if (rgDuieSBwv4sR2Q2GXW())
				{
					continue;
				}
				break;
			case 4:
			case 6:
				break;
			case 7:
				return;
			}
			break;
		}
		try
		{
			method_2("__base");
			xmlWriter_0.WriteAttributeString("ID", list_0.Count.ToString());
		}
		finally
		{
			((IDisposable)@class)?.Dispose();
		}
		list_0.Add(class44_0);
	}

	internal bool method_7()
	{
		try
		{
			Class17.smethod_19((Class39)this, Enum1.const_0);
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
				Class17.smethod_183((Class39)this, Enum1.const_0, $"ERR 2006: {ex.Message} @ 0x{num:x4}");
				return false;
			}
			Class43 class43_ = new Class43("", "ffv", "v0.0.0.0 from 3/15/2018 12:18:45 PM");
			return Class17.smethod_2(class43_, array, (Class39)this);
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception exception_)
		{
			Class17.smethod_65(new EventArgs0(exception_), this);
			return false;
		}
	}

	internal static bool rgDuieSBwv4sR2Q2GXW()
	{
		return true;
	}

	internal static bool McbCCSSq2QNfrxAvKJk()
	{
		return false;
	}
}
