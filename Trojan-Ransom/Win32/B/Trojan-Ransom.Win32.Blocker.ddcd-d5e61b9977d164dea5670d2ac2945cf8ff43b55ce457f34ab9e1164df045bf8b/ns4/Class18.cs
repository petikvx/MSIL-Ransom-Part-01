using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;
using ns1;
using ns3;

namespace ns4;

internal abstract class Class18
{
	private struct Struct9
	{
		public string string_0;

		public string string_1;

		public string string_2;

		public int int_0;
	}

	private struct Struct10
	{
		public string string_0;

		public string string_1;

		public Struct10(string string_2, string string_3)
		{
			string_0 = string_2;
			string_1 = string_3;
		}
	}

	private struct Struct11
	{
		public string string_0;

		public Struct10 struct10_0;

		[SpecialName]
		public bool method_0()
		{
			return string_0.Length == 0;
		}

		[SpecialName]
		public static Struct11 smethod_0()
		{
			return new Struct11(string.Empty, string.Empty, string.Empty);
		}

		public Struct11(string string_1, string string_2, string string_3)
		{
			string_0 = string_1;
			struct10_0 = new Struct10(string_2, string_3);
		}
	}

	private static string string_0 = "1";

	internal static bool bool_0 = false;

	private IWebProxy iwebProxy_0;

	private char[] char_0 = new char[0];

	private static Class18 class18_0 = null;

	private Exception exception_0;

	private Hashtable hashtable_0;

	private Hashtable hashtable_1;

	private XmlTextWriter xmlTextWriter_0;

	private ArrayList arrayList_0 = new ArrayList();

	private ArrayList arrayList_1 = new ArrayList();

	private Hashtable hashtable_2 = new Hashtable();

	private ArrayList arrayList_2 = new ArrayList();

	private Hashtable hashtable_3 = new Hashtable();

	private EventHandler eventHandler_0;

	private Delegate0 delegate0_0;

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_0(EventHandler eventHandler_1)
	{
		eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, eventHandler_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_1(Delegate0 delegate0_1)
	{
		delegate0_0 = (Delegate0)Delegate.Combine(delegate0_0, delegate0_1);
	}

	protected abstract void vmethod_0(EventArgs3 eventArgs3_0);

	protected abstract void vmethod_1(EventArgs2 eventArgs2_0);

	protected abstract void vmethod_2(EventArgs1 eventArgs1_0);

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static void smethod_0(Class18 class18_1)
	{
		if (class18_1 != null)
		{
			class18_0 = class18_1;
			AppDomain.CurrentDomain.UnhandledException += class18_1.method_4;
			Application.add_ThreadException((ThreadExceptionEventHandler)class18_1.method_3);
		}
	}

	[SpecialName]
	public char[] method_2()
	{
		if (char_0.Length == 0)
		{
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
		return char_0;
	}

	public static void smethod_1(Exception exception_1, object[] object_0)
	{
		try
		{
			if (exception_1 == null || !(exception_1 is SecurityException) || !(string_0 == "1") || !class18_0.method_21((SecurityException)exception_1))
			{
				class18_0.method_23(UnhandledException.smethod_11(exception_1, object_0), bool_1: false);
			}
		}
		catch
		{
			Application.Exit();
		}
	}

	public static Exception smethod_2(Exception exception_1, object[] object_0)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		smethod_3(exception_1, object_0);
		return (Exception)new SoapException(exception_1.Message, SoapException.ServerFaultCode);
	}

	public static void smethod_3(Exception exception_1, object[] object_0)
	{
		try
		{
			if (class18_0 == null)
			{
				Type[] types = Assembly.GetExecutingAssembly().GetTypes();
				foreach (Type type in types)
				{
					if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(Class18))
					{
						continue;
					}
					try
					{
						class18_0 = (Class18)Activator.CreateInstance(type, nonPublic: true);
						if (class18_0 != null)
						{
							break;
						}
					}
					catch
					{
					}
				}
			}
			if (class18_0 != null)
			{
				class18_0.method_23(UnhandledException.smethod_11(exception_1, object_0), bool_1: true);
			}
		}
		catch
		{
		}
	}

	private void method_3(object sender, ThreadExceptionEventArgs e)
	{
		try
		{
			if (!(e.Exception is SecurityException) || !(string_0 == "1") || !method_21(e.Exception as SecurityException))
			{
				method_23(e.Exception, bool_1: true);
			}
		}
		catch
		{
		}
	}

	private void method_4(object sender, UnhandledExceptionEventArgs e)
	{
		try
		{
			if ((!(e.ExceptionObject is SecurityException) || !(string_0 == "1") || !method_21(e.ExceptionObject as SecurityException)) && e.ExceptionObject is Exception)
			{
				method_23((Exception)e.ExceptionObject, !e.IsTerminating);
			}
		}
		catch
		{
		}
	}

	private string method_5(object object_0)
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

	private string method_6(string string_1)
	{
		if (string_1.StartsWith("\"<RSAKeyValue>") && string_1.EndsWith("</RSAKeyValue>\""))
		{
			return "*** Information not reported for security reasons ***";
		}
		return string_1;
	}

	private void method_7(object object_0, FieldInfo fieldInfo_0)
	{
		string text = fieldInfo_0?.Name;
		string localName = (((object)fieldInfo_0 == null) ? "Object" : "Field");
		if (object_0 == null)
		{
			xmlTextWriter_0.WriteStartElement(localName);
			if ((object)fieldInfo_0 != null)
			{
				if (fieldInfo_0.IsStatic)
				{
					xmlTextWriter_0.WriteAttributeString("Static", "1");
				}
				Type fieldType = fieldInfo_0.FieldType;
				if ((object)fieldType != null && fieldType.HasElementType)
				{
					method_11(fieldType.GetElementType());
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
					method_11(fieldType);
				}
			}
			if (text != null)
			{
				method_8(text);
			}
			xmlTextWriter_0.WriteAttributeString("Null", "1");
			xmlTextWriter_0.WriteEndElement();
			return;
		}
		Type type = object_0.GetType();
		string text2 = null;
		string text3 = null;
		if (object_0 is string)
		{
			text2 = "System.String";
		}
		if (text2 == null)
		{
			if (!type.IsPrimitive && !(object_0 is IntPtr) && !(object_0 is UIntPtr))
			{
				if (type.IsValueType && (object)type.Module != GetType().Module)
				{
					text2 = type.FullName;
				}
			}
			else
			{
				text2 = type.FullName;
				if (object_0 is int num)
				{
					StringBuilder stringBuilder = new StringBuilder();
					if (num >= 32)
					{
						stringBuilder.Append('\'');
						stringBuilder.Append((char)object_0);
						stringBuilder.Append("' ");
					}
					stringBuilder.Append("(0x");
					stringBuilder.Append(num.ToString("x"));
					stringBuilder.Append(')');
					text3 = stringBuilder.ToString();
				}
				if (object_0 is bool)
				{
					text3 = object_0.ToString()!.ToLower();
				}
				if (text3 == null)
				{
					string text4 = string.Empty;
					try
					{
						text4 = method_5(object_0);
					}
					catch
					{
					}
					if (text4.Length > 0)
					{
						StringBuilder stringBuilder2 = new StringBuilder();
						stringBuilder2.Append(object_0.ToString());
						stringBuilder2.Append(" (0x");
						stringBuilder2.Append(text4);
						stringBuilder2.Append(')');
						text3 = stringBuilder2.ToString();
					}
					else
					{
						text3 = object_0.ToString();
					}
				}
			}
		}
		if (text2 != null)
		{
			xmlTextWriter_0.WriteStartElement(localName);
			if ((object)fieldInfo_0 != null && fieldInfo_0.IsStatic)
			{
				xmlTextWriter_0.WriteAttributeString("Static", "1");
			}
			method_11(type);
			if (text != null)
			{
				method_8(text);
			}
			if (type.IsEnum)
			{
				text3 = object_0.ToString();
			}
			if (object_0 is Guid)
			{
				text3 = "{" + object_0.ToString() + "}";
			}
			if (text3 == null)
			{
				text3 = "\"" + object_0.ToString() + "\"";
			}
			xmlTextWriter_0.WriteAttributeString("Value", method_6(text3));
			xmlTextWriter_0.WriteEndElement();
			return;
		}
		xmlTextWriter_0.WriteStartElement(localName);
		if ((object)fieldInfo_0 != null && fieldInfo_0.IsStatic)
		{
			xmlTextWriter_0.WriteAttributeString("Static", "1");
		}
		int num2 = -1;
		for (int i = 0; i < arrayList_0.Count; i++)
		{
			try
			{
				if (arrayList_0[i]!.Equals(object_0))
				{
					num2 = i;
					break;
				}
			}
			catch
			{
			}
		}
		if (num2 == -1)
		{
			num2 = arrayList_0.Add(object_0);
		}
		xmlTextWriter_0.WriteAttributeString("ID", num2.ToString());
		if (text != null)
		{
			method_8(text);
		}
		xmlTextWriter_0.WriteEndElement();
	}

	private void method_8(string string_1)
	{
		int num = method_12(string_1);
		if (num != -1)
		{
			xmlTextWriter_0.WriteAttributeString("NameID", num.ToString());
		}
		else
		{
			xmlTextWriter_0.WriteAttributeString("Name", string_1);
		}
	}

	private Struct11 method_9(Type type_0)
	{
		Struct11 result = Struct11.smethod_0();
		if ((object)type_0 != null && (object)type_0.Assembly.GetType("SmartAssembly.Attributes.PoweredByAttribute") != null)
		{
			result.string_0 = ((type_0.MetadataToken & 0xFFFFFF) - 1).ToString();
			Assembly assembly = type_0.Assembly;
			result.struct10_0 = new Struct10(assembly.ManifestModule.ModuleVersionId.ToString("B"), assembly.FullName);
		}
		return result;
	}

	private int method_10(Struct11 struct11_0)
	{
		string key = struct11_0.struct10_0.string_0.ToUpper();
		if (hashtable_3.ContainsKey(key))
		{
			return (int)hashtable_3[key];
		}
		int num = arrayList_2.Add(struct11_0.struct10_0);
		hashtable_3.Add(key, num);
		return num;
	}

	private void method_11(Type type_0)
	{
		if ((object)type_0 == null)
		{
			return;
		}
		try
		{
			Struct11 struct11_ = method_9(type_0);
			if (!struct11_.method_0())
			{
				xmlTextWriter_0.WriteAttributeString("TypeDefID", struct11_.string_0);
				int num = method_10(struct11_);
				if (num > 0)
				{
					xmlTextWriter_0.WriteAttributeString("Assembly", num.ToString());
				}
				return;
			}
			int num2 = -1;
			string fullName = type_0.FullName;
			if (hashtable_2.ContainsKey(fullName))
			{
				num2 = (int)hashtable_2[fullName];
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
				int num3 = fullName.LastIndexOf("+");
				if (num3 > 0)
				{
					string value = fullName.Substring(@namespace.Length + 1, num3 - @namespace.Length).Replace("+", "/");
					stringBuilder.Append(value);
				}
				stringBuilder.Append(type_0.Name);
				num2 = arrayList_1.Add(stringBuilder.ToString());
				hashtable_2.Add(fullName, num2);
			}
			xmlTextWriter_0.WriteAttributeString("TypeName", num2.ToString());
		}
		catch
		{
		}
	}

	private int method_12(string string_1)
	{
		try
		{
			bool flag = method_2()[0] == '\u0001';
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
						for (int i = 0; i < method_2().Length; i++)
						{
							if (method_2()[i] == c)
							{
								num = num * method_2().Length + i;
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

	protected virtual Guid vmethod_3()
	{
		return Guid.Empty;
	}

	private string method_13()
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

	private Assembly[] method_14()
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { method_15() };
		}
	}

	private Assembly method_15()
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

	private byte[] method_16(string string_1)
	{
		MemoryStream memoryStream = new MemoryStream();
		xmlTextWriter_0 = new XmlTextWriter(memoryStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		xmlTextWriter_0.WriteStartDocument();
		xmlTextWriter_0.WriteStartElement("UnhandledExceptionReport");
		xmlTextWriter_0.WriteAttributeString("AssemblyID", "{A719DC5D-E444-4D2D-9458-12D21E15EE4B}".ToUpper());
		xmlTextWriter_0.WriteAttributeString("DateTime", DateTime.Now.ToString("s"));
		xmlTextWriter_0.WriteAttributeString("Path", method_13());
		Guid guid = vmethod_3();
		if (guid != Guid.Empty)
		{
			xmlTextWriter_0.WriteAttributeString("UserID", guid.ToString("B"));
		}
		if (string_1.Length > 0)
		{
			xmlTextWriter_0.WriteAttributeString("ReportID", string_1);
		}
		if (arrayList_2.Count > 0)
		{
			arrayList_2.Clear();
		}
		arrayList_2.Add(new Struct10("{A719DC5D-E444-4D2D-9458-12D21E15EE4B}", string.Empty));
		if (hashtable_3.Count > 0)
		{
			hashtable_3.Clear();
		}
		hashtable_3.Add("{A719DC5D-E444-4D2D-9458-12D21E15EE4B}", 0);
		xmlTextWriter_0.WriteStartElement("Assemblies");
		Assembly assembly = method_15();
		Assembly[] array = method_14();
		foreach (Assembly assembly2 in array)
		{
			if ((object)assembly2 == null)
			{
				continue;
			}
			xmlTextWriter_0.WriteStartElement("Assembly");
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
			xmlTextWriter_0.WriteEndElement();
		}
		xmlTextWriter_0.WriteEndElement();
		xmlTextWriter_0.WriteStartElement("CustomProperties");
		if (hashtable_0 != null && hashtable_0.Count > 0)
		{
			foreach (string key in hashtable_0.Keys)
			{
				xmlTextWriter_0.WriteStartElement("CustomProperty");
				xmlTextWriter_0.WriteAttributeString("Name", key);
				string text2 = (string)hashtable_0[key];
				if (text2 == null)
				{
					xmlTextWriter_0.WriteAttributeString("Null", "1");
				}
				else
				{
					xmlTextWriter_0.WriteAttributeString("Value", "\"" + text2 + "\"");
				}
				xmlTextWriter_0.WriteEndElement();
			}
		}
		xmlTextWriter_0.WriteEndElement();
		if (hashtable_1 != null && hashtable_1.Count > 0)
		{
			xmlTextWriter_0.WriteStartElement("AttachedFiles");
			foreach (string key2 in hashtable_1.Keys)
			{
				xmlTextWriter_0.WriteStartElement("AttachedFile");
				xmlTextWriter_0.WriteAttributeString("Key", key2);
				Struct9 @struct = (Struct9)hashtable_1[key2];
				xmlTextWriter_0.WriteAttributeString("FileName", @struct.string_0);
				xmlTextWriter_0.WriteAttributeString("Length", @struct.int_0.ToString());
				if (@struct.string_2.Length > 0)
				{
					xmlTextWriter_0.WriteAttributeString("Error", @struct.string_2);
				}
				else
				{
					xmlTextWriter_0.WriteAttributeString("Data", @struct.string_1);
				}
				xmlTextWriter_0.WriteEndElement();
			}
			xmlTextWriter_0.WriteEndElement();
		}
		xmlTextWriter_0.WriteStartElement("SystemInformation");
		try
		{
			xmlTextWriter_0.WriteElementString("OSVersion", Environment.OSVersion.Version.ToString());
			xmlTextWriter_0.WriteElementString("OSPlatformID", Environment.OSVersion.Platform.ToString());
			xmlTextWriter_0.WriteElementString("ServicePack", Class21.smethod_2());
		}
		catch
		{
		}
		xmlTextWriter_0.WriteEndElement();
		ArrayList arrayList = new ArrayList();
		for (Exception innerException = exception_0; innerException != null; innerException = innerException.InnerException)
		{
			Type type = innerException.GetType();
			if (type.Name == "UnhandledException" && type.Namespace == "SmartAssembly.SmartExceptionsCore")
			{
				arrayList.Add(innerException);
			}
			else
			{
				arrayList.Insert(0, innerException);
			}
		}
		xmlTextWriter_0.WriteStartElement("StackTrace");
		int count = arrayList.Count;
		int num = 0;
		foreach (Exception item in arrayList)
		{
			num++;
			if (num > 100 && num == count - 100)
			{
				xmlTextWriter_0.WriteStartElement("RemovedFrames");
				xmlTextWriter_0.WriteAttributeString("TotalFramesCount", count.ToString());
				xmlTextWriter_0.WriteEndElement();
			}
			else
			{
				if (num > 100 && num <= count - 100)
				{
					continue;
				}
				Type type2 = item.GetType();
				if (type2.Name == "UnhandledException" && type2.Namespace == "SmartAssembly.SmartExceptionsCore")
				{
					int num2 = 0;
					int num3 = -1;
					object[] array2 = null;
					Struct11 struct11_ = Struct11.smethod_0();
					bool flag = true;
					try
					{
						num2 = (int)type2.GetField("MethodID")!.GetValue(item);
						num3 = (int)type2.GetField("ILOffset")!.GetValue(item);
						array2 = (object[])type2.GetField("Objects")!.GetValue(item);
						struct11_ = method_9(type2);
					}
					catch
					{
						flag = false;
					}
					if (!flag || struct11_.method_0())
					{
						continue;
					}
					xmlTextWriter_0.WriteStartElement("StackFrame");
					xmlTextWriter_0.WriteAttributeString("MethodID", num2.ToString());
					int num4 = method_10(struct11_);
					if (num4 > 0)
					{
						xmlTextWriter_0.WriteAttributeString("Assembly", num4.ToString());
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
							method_7(object_, null);
						}
						catch
						{
						}
					}
					xmlTextWriter_0.WriteEndElement();
					continue;
				}
				xmlTextWriter_0.WriteStartElement("Exception");
				try
				{
					method_11(item.GetType());
					string value = "N/A";
					try
					{
						value = item.Message;
					}
					catch
					{
					}
					xmlTextWriter_0.WriteAttributeString("Message", value);
					string text4 = item.StackTrace!.Trim();
					xmlTextWriter_0.WriteAttributeString("ExceptionStackTrace", text4);
					int num5 = text4.IndexOf(' ');
					text4 = text4.Substring(num5 + 1);
					num5 = text4.IndexOf("\r\n");
					if (num5 != -1)
					{
						text4 = text4.Substring(0, num5);
					}
					xmlTextWriter_0.WriteAttributeString("Method", text4);
				}
				catch
				{
				}
				xmlTextWriter_0.WriteEndElement();
			}
		}
		xmlTextWriter_0.WriteEndElement();
		xmlTextWriter_0.WriteStartElement("Objects");
		int count2 = arrayList_0.Count;
		for (int k = 0; k < arrayList_0.Count; k++)
		{
			object obj7 = arrayList_0[k];
			Type type3 = obj7.GetType();
			xmlTextWriter_0.WriteStartElement("ObjectDef");
			xmlTextWriter_0.WriteAttributeString("ID", k.ToString());
			string text5 = null;
			try
			{
				text5 = obj7.ToString();
				text5 = ((text5 == type3.FullName) ? null : (type3.IsEnum ? Enum.Format(type3, obj7, "d") : ((!(obj7 is Guid)) ? ("\"" + text5 + "\"") : ("{" + text5 + "}"))));
			}
			catch
			{
			}
			if (text5 != null)
			{
				xmlTextWriter_0.WriteAttributeString("Value", method_6(text5));
			}
			if (type3.HasElementType)
			{
				method_11(type3.GetElementType());
				if (type3.IsByRef)
				{
					xmlTextWriter_0.WriteAttributeString("ByRef", "1");
				}
				if (type3.IsPointer)
				{
					xmlTextWriter_0.WriteAttributeString("Pointer", "1");
				}
				if (type3.IsArray)
				{
					Array array4 = (Array)obj7;
					xmlTextWriter_0.WriteAttributeString("Rank", array4.Rank.ToString());
					StringBuilder stringBuilder = new StringBuilder();
					for (int l = 0; l < array4.Rank; l++)
					{
						if (l > 0)
						{
							stringBuilder.Append(',');
						}
						stringBuilder.Append(array4.GetLength(l));
					}
					xmlTextWriter_0.WriteAttributeString("Length", stringBuilder.ToString());
					if (array4.Rank == 1)
					{
						int length = array4.Length;
						for (int m = 0; m < length; m++)
						{
							if (m == 10 && length > 16)
							{
								m = length - 5;
							}
							try
							{
								method_7(array4.GetValue(m), null);
							}
							catch
							{
							}
						}
					}
				}
			}
			else
			{
				method_11(type3);
				if (k < count2)
				{
					if (obj7 is IEnumerable)
					{
						xmlTextWriter_0.WriteStartElement("IEnumerable");
						try
						{
							int num6 = 0;
							foreach (object item2 in (IEnumerable)obj7)
							{
								if (num6 <= 20)
								{
									method_7(item2, null);
									num6++;
									continue;
								}
								xmlTextWriter_0.WriteElementString("More", string.Empty);
								break;
							}
						}
						catch
						{
						}
						xmlTextWriter_0.WriteEndElement();
					}
					bool flag2 = true;
					while ((object)type3 != null)
					{
						if (!flag2)
						{
							xmlTextWriter_0.WriteStartElement("BaseTypeDef");
							method_11(type3);
							xmlTextWriter_0.WriteEndElement();
						}
						FieldInfo[] fields = type3.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
						if (fields.Length > 0)
						{
							for (int n = 0; n < fields.Length; n++)
							{
								try
								{
									if (!fields[n].IsLiteral && (!fields[n].IsStatic || !fields[n].IsInitOnly))
									{
										method_7(fields[n].GetValue(obj7), fields[n]);
									}
								}
								catch
								{
								}
							}
						}
						type3 = type3.BaseType;
						flag2 = false;
						if (method_9(type3).method_0())
						{
							break;
						}
					}
				}
			}
			xmlTextWriter_0.WriteEndElement();
		}
		xmlTextWriter_0.WriteEndElement();
		xmlTextWriter_0.WriteStartElement("TypeNames");
		xmlTextWriter_0.WriteAttributeString("Count", arrayList_1.Count.ToString());
		for (int num7 = 0; num7 < arrayList_1.Count; num7++)
		{
			string empty = string.Empty;
			try
			{
				empty = arrayList_1[num7]!.ToString();
			}
			catch (Exception ex2)
			{
				empty = '"' + ex2.Message + '"';
			}
			xmlTextWriter_0.WriteElementString("TypeName", empty);
		}
		xmlTextWriter_0.WriteEndElement();
		xmlTextWriter_0.WriteStartElement("AssemblyIDs");
		xmlTextWriter_0.WriteAttributeString("Count", arrayList_2.Count.ToString());
		for (int num8 = 0; num8 < arrayList_2.Count; num8++)
		{
			xmlTextWriter_0.WriteStartElement("AssemblyID");
			Struct10 struct2 = (Struct10)arrayList_2[num8];
			xmlTextWriter_0.WriteAttributeString("ID", struct2.string_0);
			if (struct2.string_1.Length > 0)
			{
				xmlTextWriter_0.WriteAttributeString("FullName", struct2.string_1);
			}
			xmlTextWriter_0.WriteEndElement();
		}
		xmlTextWriter_0.WriteEndElement();
		xmlTextWriter_0.WriteEndElement();
		xmlTextWriter_0.WriteEndDocument();
		xmlTextWriter_0.Flush();
		memoryStream.Flush();
		return memoryStream.ToArray();
	}

	internal bool method_17(string string_1)
	{
		try
		{
			string string_2 = Guid.NewGuid().ToString("B");
			byte[] byte_ = method_16(string_2);
			FileStream fileStream = File.OpenWrite(string_1);
			byte[] byte_2 = Class4.smethod_1(byte_);
			byte[] array = Class17.smethod_0(byte_2, "<RSAKeyValue><Modulus>yLeJuXFH13RJ1Kvg7YL9ZAnmUKmU23RrbAY4uQzskwVz/km8AZtvUqDFutxP56My4bJkmpepAGLkut7dTptoVBRbJNQ/ih/60+K7yZP/3aq8BbWvLZTNfBZnOoWv8lkKjm1eLVNpK9acYTmdCPhlp2JF9s5TxWF1EYTcCgt+iC8=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			byte[] bytes = Encoding.ASCII.GetBytes("{A719DC5D-E444-4D2D-9458-12D21E15EE4B}");
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

	internal void method_18()
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			method_17(tempFileName);
			string text = method_20("Path");
			if (text.Length > 0 && !text.EndsWith("\\"))
			{
				text += "\\";
			}
			Process.Start(text + "{smartassembly}.exe", "/AddExceptionReport \"" + tempFileName + "\"");
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
			vmethod_1(new EventArgs2(exception_));
		}
	}

	internal bool method_19()
	{
		try
		{
			if (delegate0_0 != null)
			{
				delegate0_0(this, new EventArgs0(Enum0.const_0));
			}
			byte[] array = null;
			try
			{
				array = method_16(string.Empty);
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
				if (delegate0_0 != null)
				{
					delegate0_0(this, new EventArgs0(Enum0.const_0, $"ERR 2006: {ex.Message} @ 0x{num:x4}"));
				}
				return false;
			}
			byte[] array2 = Class4.smethod_1(array);
			if (array2 == null)
			{
				if (delegate0_0 != null)
				{
					delegate0_0(this, new EventArgs0(Enum0.const_0, Class4.string_0));
				}
				return false;
			}
			byte[] array3 = Class17.smethod_0(array2, "<RSAKeyValue><Modulus>yLeJuXFH13RJ1Kvg7YL9ZAnmUKmU23RrbAY4uQzskwVz/km8AZtvUqDFutxP56My4bJkmpepAGLkut7dTptoVBRbJNQ/ih/60+K7yZP/3aq8BbWvLZTNfBZnOoWv8lkKjm1eLVNpK9acYTmdCPhlp2JF9s5TxWF1EYTcCgt+iC8=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			if (array3 == null)
			{
				if (delegate0_0 != null)
				{
					delegate0_0(this, new EventArgs0(Enum0.const_0, Class17.string_0));
				}
				return false;
			}
			if (delegate0_0 != null)
			{
				delegate0_0(this, new EventArgs0(Enum0.const_1));
			}
			Class20 @class = new Class20("{00000000-0000-0000-0000-000000000000}");
			if (iwebProxy_0 != null)
			{
				@class.method_0(iwebProxy_0);
			}
			string text = @class.method_1();
			if (text == "OK")
			{
				if (delegate0_0 != null)
				{
					delegate0_0(this, new EventArgs0(Enum0.const_2));
				}
				byte[] bytes = Encoding.ASCII.GetBytes("{A719DC5D-E444-4D2D-9458-12D21E15EE4B}");
				byte[] array4 = new byte[bytes.Length + array3.Length];
				Array.Copy(bytes, array4, bytes.Length);
				Array.Copy(array3, 0, array4, bytes.Length, array3.Length);
				string text2 = @class.method_2(array4);
				if (text2.StartsWith("ERR"))
				{
					if (delegate0_0 != null)
					{
						delegate0_0(this, new EventArgs0(Enum0.const_2, text2));
					}
					return false;
				}
				if (delegate0_0 != null)
				{
					EventArgs0 eventArgs = new EventArgs0(Enum0.const_3);
					eventArgs.method_3(text2);
					delegate0_0(this, eventArgs);
				}
				return true;
			}
			string string_ = text;
			if (delegate0_0 != null)
			{
				delegate0_0(this, new EventArgs0(Enum0.const_1, string_));
			}
			return false;
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception exception_)
		{
			vmethod_1(new EventArgs2(exception_));
			return false;
		}
	}

	private string method_20(string string_1)
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\{smartassembly}");
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\{smartassembly}");
			}
			if (registryKey == null)
			{
				return string.Empty;
			}
			string result = (string)registryKey.GetValue(string_1, string.Empty);
			registryKey.Close();
			return result;
		}
		catch
		{
			return string.Empty;
		}
	}

	internal bool method_21(SecurityException securityException_0)
	{
		EventArgs1 eventArgs = new EventArgs1(securityException_0);
		vmethod_2(eventArgs);
		if (eventArgs.method_5())
		{
			return false;
		}
		if (!eventArgs.method_3())
		{
			Application.Exit();
		}
		return true;
	}

	internal string method_22()
	{
		Guid empty = Guid.Empty;
		string result = empty.ToString("B");
		try
		{
			string text = method_20("Path");
			if (text.Length > 0 && !text.EndsWith("\\"))
			{
				text += "\\";
			}
			string text2 = text + "{smartassembly}.license.xml";
			if (File.Exists(text2))
			{
				XmlTextReader xmlTextReader = new XmlTextReader(text2);
				if (xmlTextReader.Read())
				{
					result = xmlTextReader.GetAttribute("LicenseID");
				}
				xmlTextReader.Close();
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	internal void method_23(Exception exception_1, bool bool_1)
	{
		if (exception_1 == null || exception_1 is ThreadAbortException)
		{
			return;
		}
		bool_0 = true;
		bool flag = true;
		try
		{
			exception_0 = exception_1;
			hashtable_0 = null;
			hashtable_1 = null;
			EventArgs3 eventArgs = new EventArgs3(this, exception_1);
			if ("{00000000-0000-0000-0000-000000000000}".ToLower() == method_22().ToLower())
			{
				eventArgs.method_4();
			}
			string text = "{00000000-0000-0000-0000-000000000000}".ToLower();
			Guid empty = Guid.Empty;
			if (text == empty.ToString("B").ToLower())
			{
				eventArgs.method_5();
			}
			if (!bool_1)
			{
				eventArgs.method_6();
			}
			vmethod_0(eventArgs);
			flag = !eventArgs.method_7();
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception exception_2)
		{
			vmethod_1(new EventArgs2(exception_2));
		}
		exception_0 = null;
		hashtable_0 = null;
		hashtable_1 = null;
		bool_0 = false;
		if (!flag)
		{
			return;
		}
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			try
			{
				string fullName = assembly.FullName;
				if (fullName.EndsWith("31bf3856ad364e35") && fullName.StartsWith("PresentationFramework,"))
				{
					object obj = assembly.GetType("System.Windows.Application")!.GetProperty("Current")!.GetGetMethod()!.Invoke(null, null);
					obj.GetType().GetMethod("Shutdown", new Type[0])!.Invoke(obj, null);
				}
			}
			catch
			{
			}
		}
		Application.Exit();
		try
		{
			Environment.Exit(0);
		}
		catch
		{
		}
	}
}
