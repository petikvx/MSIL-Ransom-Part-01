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
using SmartAssembly.Shared;
using SmartAssembly.Zip;

namespace SmartAssembly.SmartExceptionsCore;

internal class ErrorReportSender : ReportSender
{
	private struct AttachedFile
	{
		public readonly string FileName;

		public readonly string Data;

		public readonly string Error;

		public readonly int Length;
	}

	private struct AssemblyInformation
	{
		public readonly string AssemblyId;

		public readonly string AssemblyFullName;

		public AssemblyInformation(string string_0, string string_1)
		{
			AssemblyId = string_0;
			AssemblyFullName = string_1;
		}
	}

	private struct TypeInformation
	{
		public string ID;

		public AssemblyInformation AssemblyInformation;

		public bool IsEmpty => ID.Length == 0;

		public static TypeInformation Empty => new TypeInformation(string.Empty, string.Empty, string.Empty);

		private TypeInformation(string string_0, string string_1, string string_2)
		{
			ID = string_0;
			AssemblyInformation = new AssemblyInformation(string_1, string_2);
		}
	}

	private readonly Exception m_CurrentException;

	private readonly Guid m_UserId;

	private readonly char[] m_ObfuscationChars = new char[0];

	private readonly Dictionary<string, object> m_CustomProperties = new Dictionary<string, object>();

	private readonly Dictionary<string, AttachedFile> m_AttachedFiles = new Dictionary<string, AttachedFile>();

	private readonly XmlWriter m_XmlWriter;

	private readonly List<ObjectAndType> m_ExceptionObjects = new List<ObjectAndType>();

	private readonly List<string> m_TypeNames = new List<string>();

	private readonly Dictionary<string, int> m_TypeNamesCache = new Dictionary<string, int>();

	private readonly List<AssemblyInformation> m_AssemblyIDs = new List<AssemblyInformation>();

	private readonly Dictionary<string, int> m_AssemblyIDsCache = new Dictionary<string, int>();

	private readonly MemoryStream m_MemoryStream;

	private byte[] m_ReportData;

	public event FatalExceptionEventHandler FatalException
	{
		add
		{
			FatalExceptionEventHandler fatalExceptionEventHandler = this.FatalException;
			FatalExceptionEventHandler fatalExceptionEventHandler2;
			do
			{
				fatalExceptionEventHandler2 = fatalExceptionEventHandler;
				FatalExceptionEventHandler value2 = (FatalExceptionEventHandler)Delegate.Combine(fatalExceptionEventHandler2, value);
				fatalExceptionEventHandler = Interlocked.CompareExchange(ref this.FatalException, value2, fatalExceptionEventHandler2);
			}
			while ((object)fatalExceptionEventHandler != fatalExceptionEventHandler2);
		}
	}

	public event EventHandler DebuggerLaunched
	{
		add
		{
			EventHandler eventHandler = this.DebuggerLaunched;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.DebuggerLaunched, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ErrorReportSender(Guid guid_0, Exception exception_0, IWebProxy iwebProxy_0)
	{
		m_UserId = guid_0;
		m_CurrentException = exception_0;
		m_MemoryStream = new MemoryStream();
		m_XmlWriter = new XmlTextWriter(m_MemoryStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		SetProxy(iwebProxy_0);
		switch ("UNICODE".ToUpper())
		{
		case "UNICODE":
			m_ObfuscationChars = new char[58]
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
			m_ObfuscationChars = new char[62]
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

	private static string GetHexValue(object object_0)
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

	private static string GetValidatedInformation(string string_0)
	{
		if (string_0.StartsWith("\"<RSAKeyValue>") && string_0.EndsWith("</RSAKeyValue>\""))
		{
			return "*** Information not reported for security reasons ***";
		}
		return string_0;
	}

	private void SaveObjectInformation(ObjectAndType objectAndType_0, FieldInfo fieldInfo_0)
	{
		string text = fieldInfo_0?.Name;
		string string_ = (((object)fieldInfo_0 == null) ? "Object" : "Field");
		object @object = objectAndType_0.GetObject();
		if (@object == null)
		{
			using (new XmlElementSpanner(m_XmlWriter, string_))
			{
				if ((object)fieldInfo_0 != null)
				{
					if (fieldInfo_0.IsStatic)
					{
						m_XmlWriter.WriteAttributeString("Static", "1");
					}
					Type fieldType = fieldInfo_0.FieldType;
					if ((object)fieldType != null && fieldType.HasElementType)
					{
						AddObjectTypeAttribute(fieldType.GetElementType());
						if (fieldType.IsByRef)
						{
							m_XmlWriter.WriteAttributeString("ByRef", "1");
						}
						if (fieldType.IsPointer)
						{
							m_XmlWriter.WriteAttributeString("Pointer", "1");
						}
						if (fieldType.IsArray)
						{
							m_XmlWriter.WriteAttributeString("Rank", fieldType.GetArrayRank().ToString());
						}
					}
					else
					{
						AddObjectTypeAttribute(fieldType);
					}
				}
				if (text != null)
				{
					AddNameAttribute(text);
				}
				m_XmlWriter.WriteAttributeString("Null", "1");
				return;
			}
		}
		Type type = objectAndType_0.GetObject().GetType();
		string text2 = null;
		string text3 = null;
		if (@object is string)
		{
			text2 = "System.String";
		}
		if (text2 == null)
		{
			if (!type.IsPrimitive && !(@object is IntPtr) && !(@object is UIntPtr))
			{
				if (type.IsValueType && (object)type.Module != GetType().Module)
				{
					text2 = type.FullName;
				}
			}
			else
			{
				text2 = type.FullName;
				if (@object is int num)
				{
					StringBuilder stringBuilder = new StringBuilder();
					if (num >= 32)
					{
						stringBuilder.Append('\'');
						stringBuilder.Append((char)@object);
						stringBuilder.Append("' ");
					}
					stringBuilder.Append("(0x");
					stringBuilder.Append(num.ToString("x"));
					stringBuilder.Append(')');
					text3 = stringBuilder.ToString();
				}
				if (@object is bool)
				{
					text3 = @object.ToString()!.ToLower();
				}
				if (text3 == null)
				{
					string hexValue = GetHexValue(@object);
					if (hexValue.Length > 0)
					{
						StringBuilder stringBuilder2 = new StringBuilder();
						stringBuilder2.Append(@object.ToString());
						stringBuilder2.Append(" (0x");
						stringBuilder2.Append(hexValue);
						stringBuilder2.Append(')');
						text3 = stringBuilder2.ToString();
					}
					else
					{
						text3 = @object.ToString();
					}
				}
			}
		}
		using (new XmlElementSpanner(m_XmlWriter, string_))
		{
			if ((object)fieldInfo_0 != null && fieldInfo_0.IsStatic)
			{
				m_XmlWriter.WriteAttributeString("Static", "1");
			}
			if (text2 != null)
			{
				AddObjectTypeAttribute(type);
				if (text != null)
				{
					AddNameAttribute(text);
				}
				if (type.IsEnum)
				{
					text3 = @object.ToString();
				}
				if (@object is Guid)
				{
					text3 = string.Concat("{", @object, "}");
				}
				if (text3 == null)
				{
					text3 = string.Concat("\"", @object, "\"");
				}
				m_XmlWriter.WriteAttributeString("Value", GetValidatedInformation(text3));
			}
			else
			{
				if ((object)fieldInfo_0 != null)
				{
					AddObjectTypeAttribute(fieldInfo_0.FieldType);
				}
				SaveObjectAndWriteIDAttribute(objectAndType_0);
				if (text != null)
				{
					AddNameAttribute(text);
				}
			}
		}
	}

	private void SaveObjectAndWriteIDAttribute(ObjectAndType objectAndType_0)
	{
		object @object = objectAndType_0.GetObject();
		int num = -1;
		for (int i = 0; i < m_ExceptionObjects.Count; i++)
		{
			if (object.ReferenceEquals(m_ExceptionObjects[i].GetObject(), @object))
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			num = m_ExceptionObjects.Count;
			m_ExceptionObjects.Add(objectAndType_0);
		}
		m_XmlWriter.WriteAttributeString("ID", num.ToString());
	}

	private void AddNameAttribute(string string_0)
	{
		int iDFromObfuscatedName = GetIDFromObfuscatedName(string_0);
		if (iDFromObfuscatedName != -1)
		{
			m_XmlWriter.WriteAttributeString("NameID", iDFromObfuscatedName.ToString());
		}
		else
		{
			m_XmlWriter.WriteAttributeString("Name", string_0);
		}
	}

	private static TypeInformation GetTypeInformation(Type type_0)
	{
		TypeInformation empty = TypeInformation.Empty;
		if ((object)type_0 != null && (object)type_0.Assembly.GetType("SmartAssembly.Attributes.PoweredByAttribute") != null)
		{
			empty.ID = ((type_0.MetadataToken & 0xFFFFFF) - 1).ToString();
			Assembly assembly = type_0.Assembly;
			empty.AssemblyInformation = new AssemblyInformation(assembly.ManifestModule.ModuleVersionId.ToString("B"), assembly.FullName);
		}
		return empty;
	}

	private int GetIndexForAssemblyID(TypeInformation typeInformation_0)
	{
		string key = typeInformation_0.AssemblyInformation.AssemblyId.ToUpper();
		if (m_AssemblyIDsCache.ContainsKey(key))
		{
			return m_AssemblyIDsCache[key];
		}
		int count = m_AssemblyIDs.Count;
		m_AssemblyIDs.Add(typeInformation_0.AssemblyInformation);
		m_AssemblyIDsCache.Add(key, count);
		return count;
	}

	private void AddObjectTypeAttribute(Type type_0)
	{
		if ((object)type_0 == null)
		{
			return;
		}
		try
		{
			TypeInformation typeInformation = GetTypeInformation(type_0);
			if (!typeInformation.IsEmpty)
			{
				m_XmlWriter.WriteAttributeString("TypeDefID", typeInformation.ID);
				int indexForAssemblyID = GetIndexForAssemblyID(typeInformation);
				if (indexForAssemblyID > 0)
				{
					m_XmlWriter.WriteAttributeString("Assembly", indexForAssemblyID.ToString());
				}
				return;
			}
			string fullName = type_0.FullName;
			int value;
			if (m_TypeNamesCache.ContainsKey(fullName))
			{
				value = m_TypeNamesCache[fullName];
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
				int num = fullName.LastIndexOf("+");
				if (num > 0)
				{
					string value2 = fullName.Substring(@namespace.Length + 1, num - @namespace.Length).Replace("+", "/");
					stringBuilder.Append(value2);
				}
				stringBuilder.Append(type_0.Name);
				value = m_TypeNames.Count;
				m_TypeNames.Add(stringBuilder.ToString());
				m_TypeNamesCache.Add(fullName, value);
			}
			m_XmlWriter.WriteAttributeString("TypeName", value.ToString());
		}
		catch
		{
		}
	}

	private int GetIDFromObfuscatedName(string string_0)
	{
		try
		{
			bool flag = m_ObfuscationChars[0] == '\u0001';
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
						for (int i = 0; i < m_ObfuscationChars.Length; i++)
						{
							if (m_ObfuscationChars[i] == c)
							{
								num = num * m_ObfuscationChars.Length + i;
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

	private static string GetExecutablePath()
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

	private Assembly[] GetAssemblies()
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { GetCurrentAssembly() };
		}
	}

	private static Assembly GetCurrentAssembly()
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

	private byte[] GetReportData()
	{
		if (m_ReportData != null)
		{
			return m_ReportData;
		}
		m_XmlWriter.WriteStartDocument();
		using (new XmlElementSpanner(m_XmlWriter, "UnhandledExceptionReport"))
		{
			m_XmlWriter.WriteAttributeString("AssemblyID", "{9EADBEBC-3D5B-44AD-9ABE-7FB1EC533F65}".ToUpper());
			m_XmlWriter.WriteAttributeString("DateTime", DateTime.Now.ToString("s"));
			m_XmlWriter.WriteAttributeString("Path", GetExecutablePath());
			if (m_UserId != Guid.Empty)
			{
				XmlWriter xmlWriter = m_XmlWriter;
				Guid userId = m_UserId;
				xmlWriter.WriteAttributeString("UserID", userId.ToString("B"));
			}
			m_XmlWriter.WriteAttributeString("ReportID", Guid.NewGuid().ToString("B"));
			if (m_AssemblyIDs.Count > 0)
			{
				m_AssemblyIDs.Clear();
			}
			m_AssemblyIDs.Add(new AssemblyInformation("{9EADBEBC-3D5B-44AD-9ABE-7FB1EC533F65}", string.Empty));
			if (m_AssemblyIDsCache.Count > 0)
			{
				m_AssemblyIDsCache.Clear();
			}
			m_AssemblyIDsCache.Add("{9EADBEBC-3D5B-44AD-9ABE-7FB1EC533F65}", 0);
			using (new XmlElementSpanner(m_XmlWriter, "Assemblies"))
			{
				Assembly currentAssembly = GetCurrentAssembly();
				Assembly[] assemblies = GetAssemblies();
				foreach (Assembly assembly in assemblies)
				{
					if ((object)assembly == null)
					{
						continue;
					}
					using (new XmlElementSpanner(m_XmlWriter, "Assembly"))
					{
						try
						{
							m_XmlWriter.WriteAttributeString("Name", assembly.FullName);
							m_XmlWriter.WriteAttributeString("CodeBase", assembly.CodeBase);
							if ((object)assembly == currentAssembly)
							{
								m_XmlWriter.WriteAttributeString("This", "1");
							}
						}
						catch
						{
						}
					}
				}
			}
			using (new XmlElementSpanner(m_XmlWriter, "CustomProperties"))
			{
				if (m_CustomProperties != null && m_CustomProperties.Count > 0)
				{
					foreach (string key in m_CustomProperties.Keys)
					{
						using (new XmlElementSpanner(m_XmlWriter, "CustomProperty"))
						{
							m_XmlWriter.WriteAttributeString("Name", key);
							string text = (string)m_CustomProperties[key];
							if (text == null)
							{
								m_XmlWriter.WriteAttributeString("Null", "1");
							}
							else
							{
								m_XmlWriter.WriteAttributeString("Value", "\"" + text + "\"");
							}
						}
					}
				}
			}
			if (m_AttachedFiles != null && m_AttachedFiles.Count > 0)
			{
				using (new XmlElementSpanner(m_XmlWriter, "AttachedFiles"))
				{
					foreach (string key2 in m_AttachedFiles.Keys)
					{
						using (new XmlElementSpanner(m_XmlWriter, "AttachedFile"))
						{
							m_XmlWriter.WriteAttributeString("Key", key2);
							AttachedFile attachedFile = m_AttachedFiles[key2];
							m_XmlWriter.WriteAttributeString("FileName", attachedFile.FileName);
							XmlWriter xmlWriter2 = m_XmlWriter;
							int length = attachedFile.Length;
							xmlWriter2.WriteAttributeString("Length", length.ToString());
							if (attachedFile.Error.Length > 0)
							{
								m_XmlWriter.WriteAttributeString("Error", attachedFile.Error);
							}
							else
							{
								m_XmlWriter.WriteAttributeString("Data", attachedFile.Data);
							}
						}
					}
				}
			}
			using (new XmlElementSpanner(m_XmlWriter, "SystemInformation"))
			{
				try
				{
					m_XmlWriter.WriteElementString("NETVersion", Environment.Version.ToString());
					m_XmlWriter.WriteElementString("OSVersion", Environment.OSVersion.Version.ToString());
					m_XmlWriter.WriteElementString("OSPlatformID", Environment.OSVersion.Platform.ToString());
					m_XmlWriter.WriteElementString("ServicePack", Win32.ServicePack);
					m_XmlWriter.WriteElementString("ServerR2", Win32.IsServerR2 ? "1" : "0");
					m_XmlWriter.WriteElementString("X64", Win32.IsX64 ? "1" : "0");
					m_XmlWriter.WriteElementString("Workstation", Win32.IsWorkstation ? "1" : "0");
				}
				catch
				{
				}
			}
			List<Exception> list = new List<Exception>();
			for (Exception ex = m_CurrentException; ex != null; ex = ex.InnerException)
			{
				list.Add(ex);
			}
			list.Reverse();
			using (new XmlElementSpanner(m_XmlWriter, "StackTrace"))
			{
				foreach (Exception item in list)
				{
					try
					{
						WriteException(item);
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
									using (new XmlElementSpanner(m_XmlWriter, "RemovedFrames"))
									{
										m_XmlWriter.WriteAttributeString("TotalFramesCount", count.ToString());
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
									object[] array = (object[])type.GetField("Objects")!.GetValue(item2);
									TypeInformation typeInformation = GetTypeInformation(type);
									if (typeInformation.IsEmpty)
									{
										continue;
									}
									using (new XmlElementSpanner(m_XmlWriter, "StackFrame"))
									{
										m_XmlWriter.WriteAttributeString("MethodID", num2.ToString());
										m_XmlWriter.WriteAttributeString("ExceptionStackDepth", num4.ToString());
										int indexForAssemblyID = GetIndexForAssemblyID(typeInformation);
										if (indexForAssemblyID > 0)
										{
											m_XmlWriter.WriteAttributeString("Assembly", indexForAssemblyID.ToString());
										}
										if (num3 != -1)
										{
											m_XmlWriter.WriteAttributeString("ILOffset", num3.ToString());
										}
										object[] array2 = array;
										foreach (object object_ in array2)
										{
											try
											{
												SaveObjectInformation(new ObjectAndType(object_, bool_0: true), null);
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
			WriteObjects();
			using (new XmlElementSpanner(m_XmlWriter, "TypeNames"))
			{
				m_XmlWriter.WriteAttributeString("Count", m_TypeNames.Count.ToString());
				for (int k = 0; k < m_TypeNames.Count; k++)
				{
					string value;
					try
					{
						value = m_TypeNames[k].ToString();
					}
					catch (Exception ex2)
					{
						value = '"' + ex2.Message + '"';
					}
					m_XmlWriter.WriteElementString("TypeName", value);
				}
			}
			using (new XmlElementSpanner(m_XmlWriter, "AssemblyIDs"))
			{
				m_XmlWriter.WriteAttributeString("Count", m_AssemblyIDs.Count.ToString());
				for (int l = 0; l < m_AssemblyIDs.Count; l++)
				{
					using (new XmlElementSpanner(m_XmlWriter, "AssemblyID"))
					{
						AssemblyInformation assemblyInformation = m_AssemblyIDs[l];
						m_XmlWriter.WriteAttributeString("ID", assemblyInformation.AssemblyId);
						if (assemblyInformation.AssemblyFullName.Length > 0)
						{
							m_XmlWriter.WriteAttributeString("FullName", assemblyInformation.AssemblyFullName);
						}
					}
				}
			}
		}
		m_XmlWriter.WriteEndDocument();
		m_XmlWriter.Flush();
		m_MemoryStream.Flush();
		m_ReportData = m_MemoryStream.ToArray();
		return m_ReportData;
	}

	private void WriteObjects()
	{
		using (new XmlElementSpanner(m_XmlWriter, "Objects"))
		{
			for (int i = 0; i < m_ExceptionObjects.Count; i++)
			{
				ObjectAndType objectAndType = m_ExceptionObjects[i];
				object @object = objectAndType.GetObject();
				Type type = objectAndType.GetType();
				using (new XmlElementSpanner(m_XmlWriter, "ObjectDef"))
				{
					m_XmlWriter.WriteAttributeString("ID", i.ToString());
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
							text = @object.ToString();
							text = ((text == type.FullName) ? null : (type.IsEnum ? Enum.Format(type, @object, "d") : ((!(@object is Guid)) ? ("\"" + text + "\"") : ("{" + text + "}"))));
						}
						catch
						{
						}
						if (text != null)
						{
							m_XmlWriter.WriteAttributeString("Value", GetValidatedInformation(text));
						}
					}
					if (type.HasElementType)
					{
						AddObjectTypeAttribute(type.GetElementType());
						if (type.IsByRef)
						{
							m_XmlWriter.WriteAttributeString("ByRef", "1");
						}
						if (type.IsPointer)
						{
							m_XmlWriter.WriteAttributeString("Pointer", "1");
						}
						if (!type.IsArray)
						{
							continue;
						}
						Array array2 = (Array)@object;
						m_XmlWriter.WriteAttributeString("Rank", array2.Rank.ToString());
						StringBuilder stringBuilder = new StringBuilder();
						for (int l = 0; l < array2.Rank; l++)
						{
							if (l > 0)
							{
								stringBuilder.Append(',');
							}
							stringBuilder.Append(array2.GetLength(l));
						}
						m_XmlWriter.WriteAttributeString("Length", stringBuilder.ToString());
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
								SaveObjectInformation(new ObjectAndType(array2.GetValue(m), bool_0: false), null);
							}
							catch
							{
							}
						}
						continue;
					}
					AddObjectTypeAttribute(type);
					if (!objectAndType.FirstLevel || !flag)
					{
						continue;
					}
					try
					{
						if (@object is IEnumerable)
						{
							using (new XmlElementSpanner(m_XmlWriter, "IEnumerable"))
							{
								int num = 0;
								foreach (object item in (IEnumerable)@object)
								{
									if (num <= 20)
									{
										SaveObjectInformation(new ObjectAndType(item, bool_0: false), null);
										num++;
										continue;
									}
									m_XmlWriter.WriteElementString("More", string.Empty);
									break;
								}
							}
						}
					}
					catch
					{
					}
					WriteObjectFields(objectAndType);
				}
			}
		}
	}

	private void WriteObjectFields(ObjectAndType objectAndType_0)
	{
		FieldInfo[] fields = objectAndType_0.GetType().GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
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
					SaveObjectInformation(new ObjectAndType(fieldInfo.GetValue(objectAndType_0.GetObject()), bool_0: false), fieldInfo);
				}
			}
			catch
			{
			}
		}
		objectAndType_0 = new ObjectAndType(objectAndType_0.GetObject(), objectAndType_0.GetType().BaseType, objectAndType_0.FirstLevel);
		if ((object)objectAndType_0.GetType() != null)
		{
			using (new XmlElementSpanner(m_XmlWriter, "Field"))
			{
				AddNameAttribute("__base");
				m_XmlWriter.WriteAttributeString("ID", m_ExceptionObjects.Count.ToString());
			}
			m_ExceptionObjects.Add(objectAndType_0);
		}
	}

	private void WriteException(Exception exception_0)
	{
		using (new XmlElementSpanner(m_XmlWriter, "Exception"))
		{
			try
			{
				Type type = exception_0.GetType();
				AddObjectTypeAttribute(type);
				string value = "N/A";
				try
				{
					value = exception_0.Message;
				}
				catch
				{
				}
				m_XmlWriter.WriteAttributeString("Message", value);
				string text = exception_0.StackTrace!.Trim();
				m_XmlWriter.WriteAttributeString("ExceptionStackTrace", text);
				int num = text.IndexOf(' ');
				text = text.Substring(num + 1);
				num = text.IndexOf("\r\n");
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				m_XmlWriter.WriteAttributeString("Method", text);
				SaveObjectAndWriteIDAttribute(new ObjectAndType(exception_0, bool_0: true));
			}
			catch
			{
			}
		}
	}

	internal bool SendReport()
	{
		try
		{
			InvokeSendingReportFeedback(SendingReportStep.PreparingReport);
			byte[] reportData;
			try
			{
				reportData = GetReportData();
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
				InvokeSendingReportFeedback(SendingReportStep.PreparingReport, $"ERR 2006: {ex.Message} @ 0x{num:x4}");
				return false;
			}
			NotificationEmailSettings notificationEmailSettings_ = new NotificationEmailSettings("", "aGbuBtagEyu", "v6.9.12.57 from 19/09/2014 13:44:52");
			return SendReport(reportData, notificationEmailSettings_);
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception exception_)
		{
			InvokeFatalException(new FatalExceptionEventArgs(exception_));
			return false;
		}
	}

	public void InvokeFatalException(FatalExceptionEventArgs fatalExceptionEventArgs_0)
	{
		this.FatalException?.Invoke(this, fatalExceptionEventArgs_0);
	}

	internal void LaunchDebugger()
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			SaveEncryptedReport(tempFileName);
			string path = AppPathFinder.ReadInstalledSaPath();
			Process.Start(Path.Combine(path, "SmartAssembly.exe"), "/AddExceptionReport \"" + tempFileName + "\"");
			if (this.DebuggerLaunched != null)
			{
				this.DebuggerLaunched(this, EventArgs.Empty);
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception exception_)
		{
			InvokeFatalException(new FatalExceptionEventArgs(exception_));
		}
	}

	internal bool SaveEncryptedReport(string string_0)
	{
		try
		{
			byte[] reportData = GetReportData();
			byte[] byte_;
			try
			{
				byte_ = SimpleZip.Zip(reportData);
			}
			catch
			{
				byte_ = null;
			}
			byte[] array = Encryption.Encrypt(byte_, "<RSAKeyValue><Modulus>p19IUWXgcBEUanZSAJRxgMOGN2rLRXDS6iYgzxYKveOZlKrDVwdrhTND74B3nV5ewjm7WWgvvGb62pEaC9XyfCaKo0FVOUXK6mveowJ/VukB+wJCDZCMZEqFgBnjIGDzkBsmJUA5Swa/eLQhaEMCBueDf7lSLjoJm0webUxWeF0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			FileStream fileStream = File.OpenWrite(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes("{9EADBEBC-3D5B-44AD-9ABE-7FB1EC533F65}");
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
