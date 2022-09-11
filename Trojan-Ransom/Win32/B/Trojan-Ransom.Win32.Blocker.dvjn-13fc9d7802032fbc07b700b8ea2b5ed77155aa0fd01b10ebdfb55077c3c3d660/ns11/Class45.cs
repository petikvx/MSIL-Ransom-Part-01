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
					inArray = Class56.smethod_88(array);
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

		internal static bool Yv9TkwXCjj7cJE2LCuD()
		{
			return true;
		}

		internal static bool a3UJMfX46G3XFsQBunw()
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

		internal static bool ORmXX5XkaW4P4KIsxWX()
		{
			return true;
		}

		internal static bool hvWCVjX2bbVO1yRY7Yr()
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

		internal static bool axhI76XccANICb7EEUR()
		{
			return true;
		}

		internal static bool A1WX0QXsqKEwWeAXao6()
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

	private readonly List<Class49> list_0 = new List<Class49>();

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

	public Class45(Guid userId, Exception currentException, IWebProxy proxy)
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

	private void method_0(Class49 class49_0, FieldInfo fieldInfo_0)
	{
		string text = fieldInfo_0?.Name;
		string name = (((object)fieldInfo_0 == null) ? "Object" : "Field");
		object object_ = class49_0.object_0;
		if (object_ == null)
		{
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
		}
		Type type = class49_0.object_0.GetType();
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
				if (object_ is int num)
				{
					StringBuilder stringBuilder = new StringBuilder();
					if (num >= 32)
					{
						stringBuilder.Append('\'');
						stringBuilder.Append((char)object_);
						stringBuilder.Append("' ");
					}
					stringBuilder.Append("(0x");
					stringBuilder.Append(num.ToString("x"));
					stringBuilder.Append(')');
					text3 = stringBuilder.ToString();
				}
				if (object_ is bool)
				{
					text3 = object_.ToString()!.ToLower();
				}
				if (text3 == null)
				{
					string text4 = Class56.smethod_5(object_);
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
		using (new Class59(xmlWriter_0, name))
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
				xmlWriter_0.WriteAttributeString("Value", Class56.smethod_60(text3));
			}
			else
			{
				if ((object)fieldInfo_0 != null)
				{
					method_3(fieldInfo_0.FieldType);
				}
				method_1(class49_0);
				if (text != null)
				{
					method_2(text);
				}
			}
		}
	}

	internal void method_1(Class49 class49_0)
	{
		while (true)
		{
			object object_ = class49_0.object_0;
			while (true)
			{
				IL_00a2:
				int num = -1;
				for (int i = 0; i < list_0.Count; i++)
				{
					if (object.ReferenceEquals(list_0[i].object_0, object_))
					{
						num = i;
						break;
					}
				}
				if (num != -1)
				{
					goto IL_003b;
				}
				goto IL_0085;
				IL_0085:
				num = list_0.Count;
				goto IL_0091;
				IL_0091:
				list_0.Add(class49_0);
				goto IL_003b;
				IL_003b:
				while (true)
				{
					xmlWriter_0.WriteAttributeString("ID", num.ToString());
					if (!Kar145X3MtifxHuFE4w())
					{
						switch (7)
						{
						case 2:
							break;
						case 1:
							goto end_IL_003b;
						default:
							goto IL_0091;
						case 6:
							goto IL_00a2;
						case 0:
						case 4:
							goto end_IL_00a2;
						case 7:
							return;
						}
						continue;
					}
					break;
					continue;
					end_IL_003b:
					break;
				}
				goto IL_0085;
				continue;
				end_IL_00a2:
				break;
			}
		}
	}

	private void method_2(string string_0)
	{
		if (amd5bfXu28id3YlMOU7())
		{
			switch (3)
			{
			default:
				return;
			case 0:
			case 3:
				break;
			case 1:
			case 4:
				goto IL_0036;
			case 2:
				return;
			case 5:
				return;
			}
		}
		int num = Class56.smethod_151(string_0, this);
		goto IL_0036;
		IL_0036:
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
			string value = default(string);
			string @namespace = default(string);
			int value2 = default(int);
			while (struct22_.IsEmpty)
			{
				string fullName = type_0.FullName;
				while (true)
				{
					if (!dictionary_2.ContainsKey(fullName))
					{
						StringBuilder stringBuilder = new StringBuilder();
						string name = type_0.Assembly.GetName().Name;
						if (Kar145X3MtifxHuFE4w())
						{
						}
						switch (2)
						{
						case 3:
							break;
						case 8:
							goto end_IL_0070;
						case 2:
							if (name.Length > 0 && name != "mscorlib")
							{
								stringBuilder.Append('[');
								goto case 1;
							}
							goto IL_0112;
						case 1:
							stringBuilder.Append(name);
							stringBuilder.Append(']');
							goto IL_0112;
						default:
							stringBuilder.Append('.');
							goto IL_0133;
						case 5:
						{
							int num = fullName.LastIndexOf("+");
							if (num > 0)
							{
								value = fullName.Substring(@namespace.Length + 1, num - @namespace.Length).Replace("+", "/");
								goto case 4;
							}
							goto IL_0188;
						}
						case 4:
						case 6:
							stringBuilder.Append(value);
							goto IL_0188;
						case 7:
						case 9:
							dictionary_2.Add(fullName, value2);
							goto IL_01c2;
						case 10:
							goto IL_01c2;
							IL_0112:
							@namespace = type_0.Namespace;
							if (@namespace.Length > 0)
							{
								stringBuilder.Append(@namespace);
								goto default;
							}
							goto IL_0133;
							IL_0133:
							if (type_0.HasElementType)
							{
								type_0 = type_0.GetElementType();
							}
							goto case 5;
							IL_0188:
							stringBuilder.Append(type_0.Name);
							value2 = list_1.Count;
							list_1.Add(stringBuilder.ToString());
							goto case 7;
						}
						continue;
					}
					value2 = dictionary_2[fullName];
					goto IL_01c2;
					IL_01c2:
					xmlWriter_0.WriteAttributeString("TypeName", value2.ToString());
					return;
					continue;
					end_IL_0070:
					break;
				}
			}
			xmlWriter_0.WriteAttributeString("TypeDefID", struct22_.string_0);
			int num2 = Class56.smethod_33(struct22_, this);
			if (num2 > 0)
			{
				xmlWriter_0.WriteAttributeString("Assembly", num2.ToString());
			}
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
			while (true)
			{
				xmlWriter_0 = new XmlTextWriter(memoryStream_0, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
				while (true)
				{
					xmlWriter_0.WriteStartDocument();
					while (true)
					{
						using (new Class59(xmlWriter_0, "UnhandledExceptionReport"))
						{
							xmlWriter_0.WriteAttributeString("AssemblyID", "{F0280EF0-7ADC-4BC9-80E4-1C939C365FDB}".ToUpper());
							xmlWriter_0.WriteAttributeString("DateTime", DateTime.Now.ToString("s"));
							xmlWriter_0.WriteAttributeString("Path", Class56.smethod_47());
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
							list_2.Add(new Struct21("{F0280EF0-7ADC-4BC9-80E4-1C939C365FDB}", string.Empty));
							if (dictionary_3.Count > 0)
							{
								dictionary_3.Clear();
							}
							dictionary_3.Add("{F0280EF0-7ADC-4BC9-80E4-1C939C365FDB}", 0);
							using (new Class59(xmlWriter_0, "Assemblies"))
							{
								Assembly assembly = Class56.smethod_7();
								Assembly[] array = Class56.smethod_104(this);
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
										Class56.smethod_106(this, item);
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
														int num5 = Class56.smethod_33(struct22_, this);
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
										while (true)
										{
											IL_08fd:
											xmlWriter_0.WriteAttributeString("ID", struct2.string_0);
											while (struct2.string_1.Length > 0)
											{
												if (Kar145X3MtifxHuFE4w())
												{
												}
												switch (4)
												{
												default:
													continue;
												case 0:
												case 3:
													break;
												case 4:
													xmlWriter_0.WriteAttributeString("FullName", struct2.string_1);
													goto end_IL_08ec;
												}
												goto IL_08fd;
												continue;
												end_IL_08ec:
												break;
											}
											break;
										}
									}
								}
							}
						}
						xmlWriter_0.WriteEndDocument();
						xmlWriter_0.Flush();
						memoryStream_0.Flush();
						byte_0 = memoryStream_0.ToArray();
						if (!amd5bfXu28id3YlMOU7())
						{
							break;
						}
						switch (7)
						{
						case 4:
							break;
						default:
							goto end_IL_09d2;
						case 0:
						case 2:
							goto end_IL_09e9;
						case 5:
							goto end_IL_09f6;
						case 6:
							goto end_IL_0a0f;
						case 7:
							return byte_0;
						}
						continue;
						end_IL_09d2:
						break;
					}
					continue;
					end_IL_09e9:
					break;
				}
				continue;
				end_IL_09f6:
				break;
			}
			continue;
			end_IL_0a0f:
			break;
		}
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
							xmlWriter_0.WriteAttributeString("Value", Class56.smethod_60(text));
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
										if (num <= 20)
										{
											method_0(new Class49(item, firstLevel: false), null);
											num++;
											if (!amd5bfXu28id3YlMOU7())
											{
												break;
											}
											switch (5)
											{
											case 0:
											case 2:
												continue;
											case 5:
												goto end_IL_036b;
											case 1:
											case 3:
												goto IL_037f;
											case 4:
												break;
											}
											goto end_IL_0374;
										}
										goto IL_037f;
										IL_037f:
										xmlWriter_0.WriteElementString("More", string.Empty);
										goto end_IL_0374;
										continue;
										end_IL_036b:
										break;
									}
									continue;
									end_IL_0374:
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
		FieldInfo[] fields = class49_0.type_0.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
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
					method_0(new Class49(fieldInfo.GetValue(class49_0.object_0), firstLevel: false), fieldInfo);
				}
			}
			catch
			{
			}
		}
		class49_0 = new Class49(class49_0.object_0, class49_0.type_0.BaseType, class49_0.bool_0);
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
			Class56.smethod_105((Class44)this, Enum4.const_0);
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
							if (Kar145X3MtifxHuFE4w())
							{
							}
							switch (4)
							{
							default:
								continue;
							case 0:
							case 3:
								break;
							case 4:
								num = frame.GetILOffset();
								goto end_IL_001c;
							}
							goto IL_0053;
							continue;
							end_IL_001c:
							break;
						}
						break;
						IL_0053:;
					}
				}
				catch
				{
				}
				Class56.smethod_51((Class44)this, Enum4.const_0, $"ERR 2006: {ex.Message} @ 0x{num:x4}");
				return false;
			}
			Class48 class48_ = new Class48("", "ffv", "v0.0.0.0 from 7/18/2018 7:43:53 PM");
			return Class56.smethod_3(array, class48_, (Class44)this);
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception fatalException)
		{
			Class56.smethod_23(new EventArgs0(fatalException), this);
			return false;
		}
	}

	internal static bool amd5bfXu28id3YlMOU7()
	{
		return true;
	}

	internal static bool Kar145X3MtifxHuFE4w()
	{
		return false;
	}
}
