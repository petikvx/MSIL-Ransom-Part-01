using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Xml;
using SmartAssembly.Attributes;
using SmartAssembly.License;
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartExceptionsWithoutUI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class Class16 : ReportSender
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
				using (FileStream stream_ = File.Open(string_3, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					SimpleZip.Class5.smethod_0(stream_, array, 0, int_0, 363, 308);
					UnhandledExceptionHandlerWithoutUI.smethod_1(stream_, 851, 891);
				}
				byte[] inArray;
				try
				{
					inArray = SimpleZip.Zip(array);
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

		[SecuritySafeCritical]
		static Struct8()
		{
			Class32.smethod_1();
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

		[SecuritySafeCritical]
		static Struct9()
		{
			Class32.smethod_1();
		}
	}

	private struct Struct10
	{
		public string string_0;

		public Struct9 struct9_0;

		[SpecialName]
		public bool method_0()
		{
			return Class3.smethod_1(string_0, 387, 491) == 0;
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

		[SecuritySafeCritical]
		static Struct10()
		{
			Class32.smethod_1();
		}
	}

	private readonly Dictionary<string, Struct8> dictionary_0 = new Dictionary<string, Struct8>();

	private readonly List<Struct9> list_0 = new List<Struct9>();

	internal Exception exception_0;

	internal Guid guid_0;

	internal char[] char_0 = new char[0];

	internal Dictionary<string, object> dictionary_1 = new Dictionary<string, object>();

	internal XmlWriter xmlWriter_0;

	internal List<Class20> list_1 = new List<Class20>();

	internal List<string> list_2 = new List<string>();

	internal Dictionary<string, int> dictionary_2 = new Dictionary<string, int>();

	internal Dictionary<string, int> dictionary_3 = new Dictionary<string, int>();

	internal MemoryStream memoryStream_0;

	internal byte[] byte_0;

	internal FatalExceptionEventHandler fatalExceptionEventHandler_0;

	internal EventHandler eventHandler_0;

	public Class16(Guid guid_1, Exception exception_1, IWebProxy iwebProxy_1)
	{
		Guid guid = (guid_0 = guid_1);
		Exception ex = (exception_0 = exception_1);
		MemoryStream memoryStream = (memoryStream_0 = new MemoryStream());
		XmlWriter xmlWriter = (xmlWriter_0 = new XmlTextWriter(memoryStream_0, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false)));
		SetProxy(iwebProxy_1);
		string string_;
		if ((string_ = "UNICODE".ToUpper()) == null)
		{
			return;
		}
		if (!UsageCounts.smethod_0(string_, "ASCII", 647, 669))
		{
			if (UsageCounts.smethod_0(string_, "UNICODE", 173, 183))
			{
				char[] array = (char_0 = new char[58]
				{
					'\u0001', '\u0002', '\u0003', '\u0004', '\u0005', '\u0006', '\a', '\b', '\u000e', '\u000f',
					'\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017', '\u0018', '\u0019',
					'\u001a', '\u001b', '\u001c', '\u001d', '\u001e', '\u001f', '\u007f', '\u0080', '\u0081', '\u0082',
					'\u0083', '\u0084', '\u0086', '\u0087', '\u0088', '\u0089', '\u008a', '\u008b', '\u008c', '\u008d',
					'\u008e', '\u008f', '\u0090', '\u0091', '\u0092', '\u0093', '\u0094', '\u0095', '\u0096', '\u0097',
					'\u0098', '\u0099', '\u009a', '\u009b', '\u009c', '\u009d', '\u009e', '\u009f'
				});
			}
		}
		else
		{
			char[] array2 = (char_0 = new char[62]
			{
				'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
				'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
				'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D',
				'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
				'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X',
				'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7',
				'8', '9'
			});
		}
	}

	private static string smethod_5(object object_0)
	{
		try
		{
			if (object_0 == null)
			{
				return string.Empty;
			}
			if (object_0 is int int_)
			{
				return AutoHeightLabel.smethod_1(ref int_, "x", 934, 951);
			}
			if (object_0 is long long_)
			{
				return Class37.smethod_4(ref long_, "x", 591, 560);
			}
			if (object_0 is short short_)
			{
				return Class26.smethod_2(ref short_, "x", 681, 707);
			}
			if (object_0 is uint num)
			{
				return num.ToString("x");
			}
			if (object_0 is ulong ulong_)
			{
				return SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_3(ref ulong_, "x", 713, 725);
			}
			if (object_0 is ushort ushort_)
			{
				return ReportSender1.smethod_2(ref ushort_, "x", 678, 667);
			}
			if (object_0 is byte b)
			{
				return b.ToString("x");
			}
			if (object_0 is sbyte b2)
			{
				return b2.ToString("x");
			}
			if (object_0 is IntPtr intptr_)
			{
				return Class26.smethod_3(ref intptr_, 493, 494).ToString("x");
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

	private static string smethod_6(string string_0)
	{
		if (UsageCounts.smethod_0(string_0, "\"<RSAKeyValue>", 600, 579) && AppNameFinder.smethod_1(string_0, "</RSAKeyValue>\"", 6, 108))
		{
			return "*** Information not reported for security reasons ***";
		}
		return string_0;
	}

	private void method_1(Class20 class20_0, FieldInfo fieldInfo_0)
	{
		string text = (((object)fieldInfo_0 == null) ? null : Win32.smethod_13(fieldInfo_0, 114, 52));
		string string_ = (((object)fieldInfo_0 == null) ? "Object" : "Field");
		object obj = class20_0.method_1();
		if (obj == null)
		{
			using (new Class25(xmlWriter_0, string_))
			{
				if ((object)fieldInfo_0 != null)
				{
					if (fieldInfo_0.IsStatic)
					{
						xmlWriter_0.WriteAttributeString("Static", "1");
					}
					Type type = StackFrameHelper.smethod_2(fieldInfo_0, 678, 742);
					if ((object)type != null && FatalExceptionEventArgs.smethod_0(type, 208, 133))
					{
						method_5(ReportExceptionEventArgs.smethod_2(type, 121, 2));
						if (PoweredByAttribute.smethod_3(type, 936, 928))
						{
							xmlWriter_0.WriteAttributeString("ByRef", "1");
						}
						if (PoweredByAttribute.smethod_3(type, 72, 65))
						{
							xmlWriter_0.WriteAttributeString("Pointer", "1");
						}
						if (type.IsArray)
						{
							xmlWriter_0.WriteAttributeString("Rank", Class21.smethod_5(type, 739, 663).ToString());
						}
					}
					else
					{
						method_5(type);
					}
				}
				if (text != null)
				{
					method_3(text);
				}
				xmlWriter_0.WriteAttributeString("Null", "1");
				return;
			}
		}
		Type type2 = class20_0.method_1().GetType();
		string text2 = null;
		string text3 = null;
		if (obj is string)
		{
			text2 = "System.String";
		}
		if (text2 == null)
		{
			if (!Class21.smethod_6(type2, 918, 991) && !(obj is IntPtr) && !(obj is UIntPtr))
			{
				if (type2.IsValueType && (object)type2.Module != GetType().Module)
				{
					text2 = type2.FullName;
				}
			}
			else
			{
				text2 = SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_4(type2, 759, 654);
				if (obj is int int_)
				{
					StringBuilder stringBuilder = new StringBuilder();
					if (int_ >= 32)
					{
						stringBuilder.Append('\'');
						stringBuilder.Append((char)obj);
						stringBuilder.Append("' ");
					}
					stringBuilder.Append("(0x");
					stringBuilder.Append(AutoHeightLabel.smethod_1(ref int_, "x", 716, 733));
					stringBuilder.Append(')');
					text3 = SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_0(stringBuilder, 476, 410);
				}
				if (obj is bool)
				{
					text3 = WaitSendingReportControl.smethod_1(SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_0(obj, 798, 856), 10, 107);
				}
				if (text3 == null)
				{
					string text4 = smethod_5(obj);
					if (Class3.smethod_1(text4, 696, 720) > 0)
					{
						StringBuilder stringBuilder2 = new StringBuilder();
						stringBuilder2.Append(SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_0(obj, 1010, 948));
						stringBuilder2.Append(" (0x");
						stringBuilder2.Append(text4);
						stringBuilder2.Append(')');
						text3 = SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_0(stringBuilder2, 551, 609);
					}
					else
					{
						text3 = SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_0(obj, 103, 33);
					}
				}
			}
		}
		using (new Class25(xmlWriter_0, string_))
		{
			if ((object)fieldInfo_0 != null && fieldInfo_0.IsStatic)
			{
				xmlWriter_0.WriteAttributeString("Static", "1");
			}
			if (text2 != null)
			{
				method_5(type2);
				if (text != null)
				{
					method_3(text);
				}
				if (type2.IsEnum)
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
				xmlWriter_0.WriteAttributeString("Value", smethod_6(text3));
			}
			else
			{
				if ((object)fieldInfo_0 != null)
				{
					method_5(fieldInfo_0.FieldType);
				}
				method_2(class20_0);
				if (text != null)
				{
					method_3(text);
				}
			}
		}
	}

	private void method_2(Class20 class20_0)
	{
		object object_ = class20_0.method_1();
		int num = -1;
		for (int i = 0; i < list_1.Count; i++)
		{
			if (UsageReportSender.smethod_6(list_1[i].method_1(), object_, 986, 968))
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			num = list_1.Count;
			list_1.Add(class20_0);
		}
		xmlWriter_0.WriteAttributeString("ID", num.ToString());
	}

	private void method_3(string string_0)
	{
		int num = method_6(string_0);
		if (num != -1)
		{
			xmlWriter_0.WriteAttributeString("NameID", num.ToString());
		}
		else
		{
			xmlWriter_0.WriteAttributeString("Name", string_0);
		}
	}

	private static Struct10 smethod_7(Type type_0)
	{
		Struct10 result = Struct10.smethod_0();
		if ((object)type_0 != null && (object)Class22.smethod_0(Class21.smethod_3(type_0, 227, 161), "SmartAssembly.Attributes.PoweredByAttribute", 840, 789) != null)
		{
			result.string_0 = ((type_0.MetadataToken & 0xFFFFFF) - 1).ToString();
			Assembly assembly = Class21.smethod_3(type_0, 325, 263);
			result.struct9_0 = new Struct9(ReportSender1.smethod_3(assembly, 739, 672).ModuleVersionId.ToString("B"), assembly.FullName);
		}
		return result;
	}

	private int method_4(Struct10 struct10_0)
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

	private void method_5(Type type_0)
	{
		if ((object)type_0 == null)
		{
			return;
		}
		try
		{
			Struct10 struct10_ = smethod_7(type_0);
			if (!struct10_.method_0())
			{
				xmlWriter_0.WriteAttributeString("TypeDefID", struct10_.string_0);
				int num = method_4(struct10_);
				if (num > 0)
				{
					xmlWriter_0.WriteAttributeString("Assembly", num.ToString());
				}
				return;
			}
			string text = SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_4(type_0, 568, 577);
			int value;
			if (dictionary_2.ContainsKey(text))
			{
				value = dictionary_2[text];
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				string name = Class20.smethod_2(Class21.smethod_3(type_0, 321, 259), 1015, 1021).Name;
				if (Class3.smethod_1(name, 543, 631) > 0 && name != "mscorlib")
				{
					stringBuilder.Append('[');
					stringBuilder.Append(name);
					stringBuilder.Append(']');
				}
				string @namespace = type_0.Namespace;
				if (Class3.smethod_1(@namespace, 295, 335) > 0)
				{
					stringBuilder.Append(@namespace);
					stringBuilder.Append('.');
				}
				if (FatalExceptionEventArgs.smethod_0(type_0, 998, 947))
				{
					type_0 = ReportExceptionEventArgs.smethod_2(type_0, 681, 722);
				}
				int num2 = HeaderControl.smethod_3(text, "+", 26, 52);
				if (num2 > 0)
				{
					string value2 = text.Substring(Class3.smethod_1(@namespace, 490, 386) + 1, num2 - @namespace.Length).Replace("+", "/");
					stringBuilder.Append(value2);
				}
				stringBuilder.Append(type_0.Name);
				value = list_2.Count;
				list_2.Add(stringBuilder.ToString());
				dictionary_2.Add(text, value);
			}
			xmlWriter_0.WriteAttributeString("TypeName", value.ToString());
		}
		catch
		{
		}
	}

	private int method_6(string string_0)
	{
		try
		{
			bool flag = char_0[0] == '\u0001';
			if (string_0 != null && Class3.smethod_1(string_0, 472, 432) != 0 && (!flag || Class3.smethod_1(string_0, 358, 270) <= 4) && (flag || string_0[0] == '#'))
			{
				int num = 0;
				int num2 = Class3.smethod_1(string_0, 856, 816) - 1;
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

	private static string smethod_8()
	{
		try
		{
			return AppNameFinder.smethod_0(136, 170);
		}
		catch
		{
			return "N/A";
		}
	}

	private Assembly[] method_7()
	{
		try
		{
			return Class34.smethod_1(148, 255).GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { smethod_9() };
		}
	}

	private static Assembly smethod_9()
	{
		try
		{
			return SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_3(111, 55);
		}
		catch
		{
			return null;
		}
	}

	internal byte[] method_8()
	{
		return method_9();
	}

	private byte[] method_9()
	{
		if (byte_0 != null)
		{
			return byte_0;
		}
		xmlWriter_0.WriteStartDocument();
		using (new Class25(xmlWriter_0, "UnhandledExceptionReport"))
		{
			xmlWriter_0.WriteAttributeString("AssemblyID", "{8188F18B-DD19-48CB-888D-E596F7B0AB27}".ToUpper());
			XmlWriter xmlWriter = xmlWriter_0;
			DateTime dateTime_ = SimpleZip.Class6.smethod_0(872, 890);
			xmlWriter.WriteAttributeString("DateTime", Class14.smethod_0(ref dateTime_, "s", 427, 431));
			xmlWriter_0.WriteAttributeString("Path", smethod_8());
			if (SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_7(guid_0, Guid.Empty, 447, 417))
			{
				XmlWriter xmlWriter2 = xmlWriter_0;
				Guid guid = guid_0;
				xmlWriter2.WriteAttributeString("UserID", SendingReportFeedbackEventArgs.smethod_0(ref guid, "B", 643, 703));
			}
			XmlWriter xmlWriter3 = xmlWriter_0;
			Guid guid2 = Guid.NewGuid();
			xmlWriter3.WriteAttributeString("ReportID", SendingReportFeedbackEventArgs.smethod_0(ref guid2, "B", 213, 233));
			if (list_0.Count > 0)
			{
				list_0.Clear();
			}
			list_0.Add(new Struct9("{8188F18B-DD19-48CB-888D-E596F7B0AB27}", string.Empty));
			if (dictionary_3.Count > 0)
			{
				dictionary_3.Clear();
			}
			dictionary_3.Add("{8188F18B-DD19-48CB-888D-E596F7B0AB27}", 0);
			using (new Class25(xmlWriter_0, "Assemblies"))
			{
				Assembly assembly = smethod_9();
				Assembly[] array = method_7();
				foreach (Assembly assembly2 in array)
				{
					if ((object)assembly2 == null)
					{
						continue;
					}
					using (new Class25(xmlWriter_0, "Assembly"))
					{
						try
						{
							xmlWriter_0.WriteAttributeString("Name", Class26.smethod_5(assembly2, 641, 760));
							xmlWriter_0.WriteAttributeString("CodeBase", Class26.smethod_5(assembly2, 278, 364));
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
			using (new Class25(xmlWriter_0, "CustomProperties"))
			{
				if (dictionary_1 != null && dictionary_1.Count > 0)
				{
					foreach (string key in dictionary_1.Keys)
					{
						using (new Class25(xmlWriter_0, "CustomProperty"))
						{
							xmlWriter_0.WriteAttributeString("Name", key);
							string text = (string)dictionary_1[key];
							if (text == null)
							{
								xmlWriter_0.WriteAttributeString("Null", "1");
							}
							else
							{
								xmlWriter_0.WriteAttributeString("Value", Class37.smethod_3("\"", text, "\"", 370, 352));
							}
						}
					}
				}
			}
			if (dictionary_0 != null && dictionary_0.Count > 0)
			{
				using (new Class25(xmlWriter_0, "AttachedFiles"))
				{
					foreach (string key2 in dictionary_0.Keys)
					{
						using (new Class25(xmlWriter_0, "AttachedFile"))
						{
							xmlWriter_0.WriteAttributeString("Key", key2);
							Struct8 @struct = dictionary_0[key2];
							xmlWriter_0.WriteAttributeString("FileName", @struct.string_0);
							XmlWriter xmlWriter4 = xmlWriter_0;
							int int_ = @struct.int_0;
							xmlWriter4.WriteAttributeString("Length", int_.ToString());
							if (Class3.smethod_1(@struct.string_2, 683, 707) > 0)
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
			using (new Class25(xmlWriter_0, "SystemInformation"))
			{
				try
				{
					HeaderControl.smethod_4(xmlWriter_0, "NETVersion", SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_0(SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_3(285, 325), 406, 464), 520, 619);
					HeaderControl.smethod_4(xmlWriter_0, "OSVersion", SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_0(SecurityExceptionEventArgs.smethod_0(67, 98).Version, 1010, 948), 871, 772);
					HeaderControl.smethod_4(xmlWriter_0, "OSPlatformID", SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_0(SecurityExceptionEventArgs.smethod_0(283, 314).Platform, 587, 525), 645, 742);
					HeaderControl.smethod_4(xmlWriter_0, "ServicePack", Win32.smethod_4(), 530, 625);
					HeaderControl.smethod_4(xmlWriter_0, "ServerR2", Win32.smethod_2() ? "1" : "0", 980, 951);
					HeaderControl.smethod_4(xmlWriter_0, "X64", Win32.smethod_1() ? "1" : "0", 183, 212);
					HeaderControl.smethod_4(xmlWriter_0, "Workstation", Win32.smethod_3() ? "1" : "0", 610, 513);
				}
				catch
				{
				}
			}
			List<Exception> list = new List<Exception>();
			for (Exception ex = exception_0; ex != null; ex = Class37.smethod_5(ex, 557, 587))
			{
				list.Add(ex);
			}
			list.Reverse();
			using (new Class25(xmlWriter_0, "StackTrace"))
			{
				foreach (Exception item in list)
				{
					try
					{
						method_12(item);
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
									using (new Class25(xmlWriter_0, "RemovedFrames"))
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
									int num2 = (int)Class31.smethod_2(type, "MethodID", 738, 699).GetValue(item2);
									int num3 = (int)Class31.smethod_2(type, "ILOffset", 247, 174).GetValue(item2);
									int num4 = (int)Class31.smethod_2(type, "ExceptionStackDepth", 739, 698).GetValue(item2);
									object[] array2 = (object[])Class31.smethod_2(type, "Objects", 317, 356).GetValue(item2);
									Struct10 struct10_ = smethod_7(type);
									if (struct10_.method_0())
									{
										continue;
									}
									using (new Class25(xmlWriter_0, "StackFrame"))
									{
										xmlWriter_0.WriteAttributeString("MethodID", num2.ToString());
										xmlWriter_0.WriteAttributeString("ExceptionStackDepth", num4.ToString());
										int num5 = method_4(struct10_);
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
												method_1(new Class20(object_, bool_1: true), null);
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
			method_10();
			using (new Class25(xmlWriter_0, "TypeNames"))
			{
				xmlWriter_0.WriteAttributeString("Count", list_2.Count.ToString());
				for (int k = 0; k < list_2.Count; k++)
				{
					string value;
					try
					{
						value = list_2[k].ToString();
					}
					catch (Exception ex2)
					{
						value = '"' + ex2.Message + '"';
					}
					xmlWriter_0.WriteElementString("TypeName", value);
				}
			}
			using (new Class25(xmlWriter_0, "AssemblyIDs"))
			{
				xmlWriter_0.WriteAttributeString("Count", list_0.Count.ToString());
				for (int l = 0; l < list_0.Count; l++)
				{
					using (new Class25(xmlWriter_0, "AssemblyID"))
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

	private void method_10()
	{
		using (new Class25(xmlWriter_0, "Objects"))
		{
			for (int i = 0; i < list_1.Count; i++)
			{
				Class20 @class = list_1[i];
				object obj = @class.method_1();
				Type type = @class.method_2();
				using (new Class25(xmlWriter_0, "ObjectDef"))
				{
					xmlWriter_0.WriteAttributeString("ID", i.ToString());
					string text = null;
					bool flag = true;
					string[] array = PoweredBy.smethod_2("", new char[1] { ',' }, 781, 796);
					foreach (string text2 in array)
					{
						if (text2 != "" && UsageCounts.smethod_0(SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_4(type, 425, 464), text2, 550, 573))
						{
							flag = false;
							break;
						}
					}
					object[] customAttributes = type.GetCustomAttributes(inherit: true);
					for (int k = 0; k < customAttributes.Length; k++)
					{
						Attribute attribute = (Attribute)customAttributes[k];
						string text3 = Win32.smethod_13(attribute.GetType(), 81, 23);
						if (!(text3 != "DoNotCaptureFieldsAttribute") || !(text3 != "DoNotCaptureAttribute"))
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						try
						{
							text = SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_0(obj, 201, 143);
							text = (UsageCounts.smethod_0(text, SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_4(type, 982, 943), 702, 676) ? null : (UnhandledExceptionHandlerWithoutUI.smethod_3(type, 24, 123) ? HeaderControl.smethod_5(type, obj, "d", 306, 342) : ((!(obj is Guid)) ? Class37.smethod_3("\"", text, "\"", 985, 971) : Class37.smethod_3("{", text, "}", 737, 755))));
						}
						catch
						{
						}
						if (text != null)
						{
							xmlWriter_0.WriteAttributeString("Value", smethod_6(text));
						}
					}
					if (FatalExceptionEventArgs.smethod_0(type, 578, 535))
					{
						method_5(ReportExceptionEventArgs.smethod_2(type, 358, 285));
						if (PoweredByAttribute.smethod_3(type, 735, 727))
						{
							xmlWriter_0.WriteAttributeString("ByRef", "1");
						}
						if (PoweredByAttribute.smethod_3(type, 132, 141))
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
						xmlWriter_0.WriteAttributeString("Length", SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_0(stringBuilder, 639, 569));
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
								method_1(new Class20(StackFrameHelper.smethod_3(array2, m, 589, 532), bool_1: false), null);
							}
							catch
							{
							}
						}
						continue;
					}
					method_5(type);
					if (!@class.method_0() || !flag)
					{
						continue;
					}
					try
					{
						if (obj is IEnumerable)
						{
							using (new Class25(xmlWriter_0, "IEnumerable"))
							{
								int num = 0;
								foreach (object item in (IEnumerable)obj)
								{
									if (num <= 20)
									{
										method_1(new Class20(item, bool_1: false), null);
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
					method_11(@class);
				}
			}
		}
	}

	private void method_11(Class20 class20_0)
	{
		FieldInfo[] array = Class21.smethod_8(class20_0.method_2(), BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, 456, 444);
		FieldInfo[] array2 = array;
		foreach (FieldInfo fieldInfo in array2)
		{
			try
			{
				if (UsageReportSender.smethod_7(fieldInfo, 808, 888) || (fieldInfo.IsStatic && fieldInfo.IsInitOnly))
				{
					continue;
				}
				bool flag = true;
				object[] customAttributes = fieldInfo.GetCustomAttributes(inherit: true);
				for (int j = 0; j < customAttributes.Length; j++)
				{
					Attribute attribute = (Attribute)customAttributes[j];
					if (UsageCounts.smethod_0(Win32.smethod_13(attribute.GetType(), 890, 828), "DoNotCaptureAttribute", 632, 610))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					method_1(new Class20(fieldInfo.GetValue(class20_0.method_1()), bool_1: false), fieldInfo);
				}
			}
			catch
			{
			}
		}
		class20_0 = new Class20(class20_0.method_1(), ReportExceptionEventArgs.smethod_2(class20_0.method_2(), 627, 527), class20_0.method_0());
		if ((object)class20_0.method_2() != null)
		{
			using (new Class25(xmlWriter_0, "Field"))
			{
				method_3("__base");
				xmlWriter_0.WriteAttributeString("ID", list_1.Count.ToString());
			}
			list_1.Add(class20_0);
		}
	}

	private void method_12(Exception exception_1)
	{
		using (new Class25(xmlWriter_0, "Exception"))
		{
			try
			{
				Type type_ = Class25.smethod_0(exception_1, 585, 621);
				method_5(type_);
				string value = "N/A";
				try
				{
					value = Class26.smethod_0(exception_1, 537, 599);
				}
				catch
				{
				}
				xmlWriter_0.WriteAttributeString("Message", value);
				string text = SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_1(exception_1, 832, 777).Trim();
				xmlWriter_0.WriteAttributeString("ExceptionStackTrace", text);
				int num = text.IndexOf(' ');
				text = Class27.smethod_3(text, num + 1, 441, 391);
				num = HeaderControl.smethod_3(text, "\r\n", 905, 934);
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				xmlWriter_0.WriteAttributeString("Method", text);
				method_2(new Class20(exception_1, bool_1: true));
			}
			catch
			{
			}
		}
	}

	internal void method_13(string string_0, object object_0)
	{
		dictionary_1.Add(string_0, object_0);
	}

	internal void method_14(string string_0, string string_1)
	{
		if (File.Exists(string_1))
		{
			Struct8 value = new Struct8(string_1);
			dictionary_0.Add(string_0, value);
		}
	}

	internal bool method_15()
	{
		Class37.smethod_0(1u);
		try
		{
			InvokeSendingReportFeedback(SendingReportStep.PreparingReport);
			byte[] array;
			try
			{
				array = method_9();
			}
			catch (Exception e)
			{
				int num = -1;
				try
				{
					StackTrace stackTrace = new StackTrace(e);
					if (Win32.smethod_14(stackTrace, 563, 533) > 0)
					{
						StackFrame frame = stackTrace.GetFrame(Win32.smethod_14(stackTrace, 105, 79) - 1);
						num = Class21.smethod_7(frame, 528, 593);
					}
				}
				catch
				{
				}
				InvokeSendingReportFeedback(SendingReportStep.PreparingReport, License.smethod_3("ERR 2006: {0} @ 0x{1:x4}", Class26.smethod_0(e, 662, 728), num, 584, 546));
				return false;
			}
			Class19 class19_ = new Class19("", "a13EdN9QluI", "v6.9.13.59 from 9/7/2014 03:35:51 ص");
			return method_0(array, class19_);
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception exception_)
		{
			method_17(new FatalExceptionEventArgs(exception_));
			return false;
		}
	}

	[SpecialName]
	public void method_16(FatalExceptionEventHandler fatalExceptionEventHandler_1)
	{
		FatalExceptionEventHandler fatalExceptionEventHandler = fatalExceptionEventHandler_0;
		FatalExceptionEventHandler fatalExceptionEventHandler2;
		do
		{
			fatalExceptionEventHandler2 = fatalExceptionEventHandler;
			FatalExceptionEventHandler value = (FatalExceptionEventHandler)Class34.smethod_0(fatalExceptionEventHandler2, fatalExceptionEventHandler_1, 1010, 957);
			fatalExceptionEventHandler = Interlocked.CompareExchange(ref fatalExceptionEventHandler_0, value, fatalExceptionEventHandler2);
		}
		while ((object)fatalExceptionEventHandler != fatalExceptionEventHandler2);
	}

	public void method_17(FatalExceptionEventArgs fatalExceptionEventArgs_0)
	{
		fatalExceptionEventHandler_0?.Invoke(this, fatalExceptionEventArgs_0);
	}

	[SpecialName]
	public void method_18(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Class34.smethod_0(eventHandler2, eventHandler_1, 259, 332);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal void method_19()
	{
		try
		{
			string text = AppNameFinder.smethod_0(479, 508);
			method_20(text);
			string string_ = AppPathFinder.ReadInstalledSaPath();
			Process.Start(SendingReportFeedbackEventArgs1.smethod_0(string_, "SmartAssembly.exe", 639, 622), Class37.smethod_3("/AddExceptionReport \"", text, "\"", 479, 461));
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
			method_17(new FatalExceptionEventArgs(exception_));
		}
	}

	internal bool method_20(string string_0)
	{
		try
		{
			byte[] buffer = method_9();
			byte[] array;
			try
			{
				array = SimpleZip.Zip(buffer);
			}
			catch
			{
				array = null;
			}
			byte[] array2 = Class15.smethod_0(array, "<RSAKeyValue><Modulus>6O6DbDLV9y/u81tMRzmLH3AoTfaBNQZ53eJJFY28qxTx6gBzaAji7fJFmcjE0ZcghwRVa/E+nJ0FlcHFiKY/Faz1NuFYuP7mL+zvuZgcaaxApHA8oQFHjysHhC8LuCUoyYPB1vOUOimrzWXpQ6Q9S2nWpMNYz7McRrTBacsYnOc=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			FileStream fileStream = File.OpenWrite(string_0);
			byte[] array3 = SimpleZip.Stream0.smethod_0(Encoding.ASCII, "{8188F18B-DD19-48CB-888D-E596F7B0AB27}", 264, 369);
			StackFrameHelper.smethod_0(fileStream, array3, 0, array3.Length, 732, 688);
			StackFrameHelper.smethod_0(fileStream, array2, 0, array2.Length, 387, 495);
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

	[SecuritySafeCritical]
	static Class16()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static byte[] smethod_10(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 104:
				return Convert.FromBase64String(string_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte smethod_11(string string_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 7:
				return Convert.ToByte(string_0, int_0);
			}
		}
	}
}
