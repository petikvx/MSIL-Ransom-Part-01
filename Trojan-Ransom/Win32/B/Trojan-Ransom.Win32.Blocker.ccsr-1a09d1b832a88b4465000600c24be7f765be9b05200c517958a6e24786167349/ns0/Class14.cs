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
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartExceptionsWithUI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class Class14 : ReportSender
{
	private struct Struct16
	{
		public readonly string string_0;

		public readonly string string_1;

		public readonly string string_2;

		public readonly int int_0;

		public Struct16(string string_3)
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
					SimpleZip.Class11.smethod_0(stream_, array, 0, int_0, 836, 768);
					SendingReportFeedbackEventArgs.smethod_1(stream_, 628, 521);
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

		static Struct16()
		{
			DESCryptoIndirector.smethod_0();
		}
	}

	private struct Struct17
	{
		public readonly string string_0;

		public readonly string string_1;

		public Struct17(string string_2, string string_3)
		{
			string_0 = string_2;
			string_1 = string_3;
		}

		static Struct17()
		{
			DESCryptoIndirector.smethod_0();
		}
	}

	private struct Struct18
	{
		public string string_0;

		public Struct17 struct17_0;

		[SpecialName]
		public bool method_0()
		{
			return PoweredBy.smethod_0(string_0, 342, 262) == 0;
		}

		[SpecialName]
		public static Struct18 smethod_0()
		{
			return new Struct18(string.Empty, string.Empty, string.Empty);
		}

		private Struct18(string string_1, string string_2, string string_3)
		{
			string_0 = string_1;
			struct17_0 = new Struct17(string_2, string_3);
		}

		static Struct18()
		{
			DESCryptoIndirector.smethod_0();
		}
	}

	private readonly Dictionary<string, Struct16> dictionary_0 = new Dictionary<string, Struct16>();

	private readonly List<Struct17> list_0 = new List<Struct17>();

	internal Exception exception_0;

	internal Guid guid_0;

	internal char[] char_0 = new char[0];

	internal Dictionary<string, object> dictionary_1 = new Dictionary<string, object>();

	internal XmlWriter xmlWriter_0;

	internal List<Class18> list_1 = new List<Class18>();

	internal List<string> list_2 = new List<string>();

	internal Dictionary<string, int> dictionary_2 = new Dictionary<string, int>();

	internal Dictionary<string, int> dictionary_3 = new Dictionary<string, int>();

	internal MemoryStream memoryStream_0;

	internal byte[] byte_0;

	internal FatalExceptionEventHandler fatalExceptionEventHandler_0;

	internal EventHandler eventHandler_0;

	public Class14(Guid guid_1, Exception exception_1, IWebProxy iwebProxy_1)
	{
		Guid guid = (guid_0 = guid_1);
		Exception ex = (exception_0 = exception_1);
		MemoryStream memoryStream = (memoryStream_0 = new MemoryStream());
		XmlWriter xmlWriter = (xmlWriter_0 = new XmlTextWriter(memoryStream_0, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false)));
		SetProxy(iwebProxy_1);
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
			char[] array_ = new char[62];
			SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_0(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 429, 466);
			char[] array = (char_0 = array_);
			break;
		}
		}
	}

	private static string smethod_2(object object_0)
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
			if (object_0 is long long_)
			{
				return UnhandledExceptionHandlerWithUI.smethod_2(ref long_, "x", 7, 43);
			}
			if (object_0 is short short_)
			{
				return Attribute0.smethod_3(ref short_, "x", 269, 259);
			}
			if (object_0 is uint uint_)
			{
				return FeedbackControl.smethod_3(ref uint_, "x", 115, 60);
			}
			if (object_0 is ulong ulong_)
			{
				return Class29.smethod_3(ref ulong_, "x", 155, 215);
			}
			if (object_0 is ushort ushort_)
			{
				return UsageReportSender.smethod_3(ref ushort_, "x", 860, 895);
			}
			if (object_0 is byte b)
			{
				return b.ToString("x");
			}
			if (object_0 is sbyte sbyte_)
			{
				return ReportExceptionEventArgs.smethod_0(ref sbyte_, "x", 932, 931);
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

	private static string smethod_3(string string_0)
	{
		if (Win32.smethod_9(string_0, "\"<RSAKeyValue>", 609, 633) && Class24.smethod_3(string_0, "</RSAKeyValue>\"", 455, 510))
		{
			return "*** Information not reported for security reasons ***";
		}
		return string_0;
	}

	private void method_1(Class18 class18_0, FieldInfo fieldInfo_0)
	{
		string text = fieldInfo_0?.Name;
		string string_ = (((object)fieldInfo_0 == null) ? "Object" : "Field");
		object obj = class18_0.method_1();
		if (obj == null)
		{
			using (new Class23(xmlWriter_0, string_))
			{
				if ((object)fieldInfo_0 != null)
				{
					if (Attribute0.smethod_4(fieldInfo_0, 83, 28))
					{
						xmlWriter_0.WriteAttributeString("Static", "1");
					}
					Type type = Class24.smethod_4(fieldInfo_0, 186, 130);
					if ((object)type != null && type.HasElementType)
					{
						method_5(SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_1(type, 780, 812));
						if (type.IsByRef)
						{
							xmlWriter_0.WriteAttributeString("ByRef", "1");
						}
						if (type.IsPointer)
						{
							xmlWriter_0.WriteAttributeString("Pointer", "1");
						}
						if (type.IsArray)
						{
							xmlWriter_0.WriteAttributeString("Rank", Class24.smethod_5(type, 348, 286).ToString());
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
		Type type2 = FeedbackControl.smethod_0(class18_0.method_1(), 274, 360);
		string text2 = null;
		string text3 = null;
		if (obj is string)
		{
			text2 = "System.String";
		}
		if (text2 == null)
		{
			if (!type2.IsPrimitive && !(obj is IntPtr) && !(obj is UIntPtr))
			{
				if (type2.IsValueType && (object)type2.Module != GetType().Module)
				{
					text2 = type2.FullName;
				}
			}
			else
			{
				text2 = Class25.smethod_3(type2, 850, 877);
				if (obj is int num)
				{
					StringBuilder stringBuilder = new StringBuilder();
					if (num >= 32)
					{
						stringBuilder.Append('\'');
						stringBuilder.Append((char)obj);
						Class29.smethod_4(stringBuilder, "' ", 640, 697);
					}
					Class29.smethod_4(stringBuilder, "(0x", 157, 164);
					Class29.smethod_4(stringBuilder, num.ToString("x"), 779, 818);
					stringBuilder.Append(')');
					text3 = WaitSendingReportControl.smethod_4(stringBuilder, 298, 353);
				}
				if (obj is bool)
				{
					text3 = Class32.smethod_3(WaitSendingReportControl.smethod_4(obj, 556, 615), 18, 113);
				}
				if (text3 == null)
				{
					string string_2 = smethod_2(obj);
					if (PoweredBy.smethod_0(string_2, 208, 128) > 0)
					{
						StringBuilder stringBuilder2 = new StringBuilder();
						Class29.smethod_4(stringBuilder2, WaitSendingReportControl.smethod_4(obj, 390, 461), 310, 271);
						Class29.smethod_4(stringBuilder2, " (0x", 143, 182);
						Class29.smethod_4(stringBuilder2, string_2, 267, 306);
						stringBuilder2.Append(')');
						text3 = WaitSendingReportControl.smethod_4(stringBuilder2, 38, 109);
					}
					else
					{
						text3 = WaitSendingReportControl.smethod_4(obj, 828, 887);
					}
				}
			}
		}
		using (new Class23(xmlWriter_0, string_))
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
				xmlWriter_0.WriteAttributeString("Value", smethod_3(text3));
			}
			else
			{
				if ((object)fieldInfo_0 != null)
				{
					method_5(fieldInfo_0.FieldType);
				}
				method_2(class18_0);
				if (text != null)
				{
					method_3(text);
				}
			}
		}
	}

	private void method_2(Class18 class18_0)
	{
		object object_ = class18_0.method_1();
		int num = -1;
		for (int i = 0; i < list_1.Count; i++)
		{
			if (Class29.smethod_6(list_1[i].method_1(), object_, 706, 662))
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			num = list_1.Count;
			list_1.Add(class18_0);
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

	private static Struct18 smethod_4(Type type_0)
	{
		Struct18 result = Struct18.smethod_0();
		if ((object)type_0 != null && (object)Class19.smethod_2(type_0.Assembly, "SmartAssembly.Attributes.PoweredByAttribute", 571, 555) != null)
		{
			result.string_0 = ((type_0.MetadataToken & 0xFFFFFF) - 1).ToString();
			Assembly assembly = type_0.Assembly;
			result.struct17_0 = new Struct17(SendingReportFeedbackEventArgs1.smethod_1(assembly, 821, 807).ModuleVersionId.ToString("B"), assembly.FullName);
		}
		return result;
	}

	private int method_4(Struct18 struct18_0)
	{
		string key = struct18_0.struct17_0.string_0.ToUpper();
		if (dictionary_3.ContainsKey(key))
		{
			return dictionary_3[key];
		}
		int count = list_0.Count;
		list_0.Add(struct18_0.struct17_0);
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
			Struct18 struct18_ = smethod_4(type_0);
			if (!struct18_.method_0())
			{
				xmlWriter_0.WriteAttributeString("TypeDefID", struct18_.string_0);
				int num = method_4(struct18_);
				if (num > 0)
				{
					xmlWriter_0.WriteAttributeString("Assembly", num.ToString());
				}
				return;
			}
			string text = Class25.smethod_3(type_0, 517, 570);
			int value;
			if (dictionary_2.ContainsKey(text))
			{
				value = dictionary_2[text];
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				string name = SimpleZip.Class8.smethod_1(type_0.Assembly, 278, 336).Name;
				if (PoweredBy.smethod_0(name, 21, 69) > 0 && name != "mscorlib")
				{
					stringBuilder.Append('[');
					Class29.smethod_4(stringBuilder, name, 469, 492);
					stringBuilder.Append(']');
				}
				string @namespace = type_0.Namespace;
				if (PoweredBy.smethod_0(@namespace, 564, 612) > 0)
				{
					Class29.smethod_4(stringBuilder, @namespace, 877, 852);
					stringBuilder.Append('.');
				}
				if (type_0.HasElementType)
				{
					type_0 = SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_1(type_0, 577, 609);
				}
				int num2 = smethod_7(text, "+", 651, 762);
				if (num2 > 0)
				{
					string value2 = text.Substring(PoweredBy.smethod_0(@namespace, 758, 678) + 1, num2 - @namespace.Length).Replace("+", "/");
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
			if (string_0 != null && PoweredBy.smethod_0(string_0, 141, 221) != 0 && (!flag || PoweredBy.smethod_0(string_0, 496, 416) <= 4) && (flag || Class29.smethod_0(string_0, 0, 429, 502) == '#'))
			{
				int num = 0;
				int num2 = PoweredBy.smethod_0(string_0, 242, 162) - 1;
				while (true)
				{
					if (num2 >= 0 && (flag || num2 != 0))
					{
						char c = Class29.smethod_0(string_0, num2, 512, 603);
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

	private static string smethod_5()
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

	private Assembly[] method_7()
	{
		try
		{
			return Class30.smethod_3(79, 7).GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { smethod_6() };
		}
	}

	private static Assembly smethod_6()
	{
		try
		{
			return Class24.smethod_1(545, 538);
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
		SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_0(xmlWriter_0, 272, 346);
		using (new Class23(xmlWriter_0, "UnhandledExceptionReport"))
		{
			xmlWriter_0.WriteAttributeString("AssemblyID", "{E8999F69-FF1B-4846-9283-897940EB0660}".ToUpper());
			xmlWriter_0.WriteAttributeString("DateTime", HeaderControl.smethod_2(440, 482).ToString("s"));
			xmlWriter_0.WriteAttributeString("Path", smethod_5());
			if (SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_3(guid_0, Guid.Empty, 650, 666))
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
			list_0.Add(new Struct17("{E8999F69-FF1B-4846-9283-897940EB0660}", string.Empty));
			if (dictionary_3.Count > 0)
			{
				dictionary_3.Clear();
			}
			dictionary_3.Add("{E8999F69-FF1B-4846-9283-897940EB0660}", 0);
			using (new Class23(xmlWriter_0, "Assemblies"))
			{
				Assembly assembly = smethod_6();
				Assembly[] array = method_7();
				foreach (Assembly assembly2 in array)
				{
					if ((object)assembly2 == null)
					{
						continue;
					}
					using (new Class23(xmlWriter_0, "Assembly"))
					{
						try
						{
							xmlWriter_0.WriteAttributeString("Name", Class19.smethod_3(assembly2, 968, 1003));
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
			using (new Class23(xmlWriter_0, "CustomProperties"))
			{
				if (dictionary_1 != null && dictionary_1.Count > 0)
				{
					foreach (string key in dictionary_1.Keys)
					{
						using (new Class23(xmlWriter_0, "CustomProperty"))
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
				using (new Class23(xmlWriter_0, "AttachedFiles"))
				{
					foreach (string key2 in dictionary_0.Keys)
					{
						using (new Class23(xmlWriter_0, "AttachedFile"))
						{
							xmlWriter_0.WriteAttributeString("Key", key2);
							Struct16 @struct = dictionary_0[key2];
							xmlWriter_0.WriteAttributeString("FileName", @struct.string_0);
							XmlWriter xmlWriter2 = xmlWriter_0;
							int int_ = @struct.int_0;
							xmlWriter2.WriteAttributeString("Length", int_.ToString());
							if (PoweredBy.smethod_0(@struct.string_2, 865, 817) > 0)
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
			using (new Class23(xmlWriter_0, "SystemInformation"))
			{
				try
				{
					StackFrameHelper.smethod_3(xmlWriter_0, "NETVersion", WaitSendingReportControl.smethod_4(Environment.Version, 851, 792), 951, 993);
					StackFrameHelper.smethod_3(xmlWriter_0, "OSVersion", WaitSendingReportControl.smethod_4(AutoHeightLabel.smethod_2(769, 878).Version, 61, 118), 195, 149);
					StackFrameHelper.smethod_3(xmlWriter_0, "OSPlatformID", WaitSendingReportControl.smethod_4(Class21.smethod_4(AutoHeightLabel.smethod_2(996, 907), 828, 891), 592, 539), 301, 379);
					StackFrameHelper.smethod_3(xmlWriter_0, "ServicePack", Win32.smethod_4(), 1022, 936);
					StackFrameHelper.smethod_3(xmlWriter_0, "ServerR2", Win32.smethod_2() ? "1" : "0", 112, 38);
					StackFrameHelper.smethod_3(xmlWriter_0, "X64", Win32.smethod_1() ? "1" : "0", 500, 418);
					StackFrameHelper.smethod_3(xmlWriter_0, "Workstation", Win32.smethod_3() ? "1" : "0", 477, 395);
				}
				catch
				{
				}
			}
			List<Exception> list = new List<Exception>();
			for (Exception ex = exception_0; ex != null; ex = Class24.smethod_2(ex, 966, 944))
			{
				list.Add(ex);
			}
			list.Reverse();
			using (new Class23(xmlWriter_0, "StackTrace"))
			{
				foreach (Exception item in list)
				{
					try
					{
						method_12(item);
						if (!Class30.smethod_0(item, 239, 185).Contains("SmartStackFrames"))
						{
							continue;
						}
						ICollection collection = (ICollection)Class30.smethod_0(item, 642, 724)["SmartStackFrames"];
						int count = collection.Count;
						int num = 0;
						foreach (object item2 in collection)
						{
							try
							{
								Type type = FeedbackControl.smethod_0(item2, 449, 443);
								num++;
								if (num > 100 && num == count - 100)
								{
									using (new Class23(xmlWriter_0, "RemovedFrames"))
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
									Struct18 struct18_ = smethod_4(type);
									if (struct18_.method_0())
									{
										continue;
									}
									using (new Class23(xmlWriter_0, "StackFrame"))
									{
										xmlWriter_0.WriteAttributeString("MethodID", num2.ToString());
										xmlWriter_0.WriteAttributeString("ExceptionStackDepth", num4.ToString());
										int num5 = method_4(struct18_);
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
												method_1(new Class18(object_, bool_1: true), null);
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
			using (new Class23(xmlWriter_0, "TypeNames"))
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
			using (new Class23(xmlWriter_0, "AssemblyIDs"))
			{
				xmlWriter_0.WriteAttributeString("Count", list_0.Count.ToString());
				for (int l = 0; l < list_0.Count; l++)
				{
					using (new Class23(xmlWriter_0, "AssemblyID"))
					{
						Struct17 struct2 = list_0[l];
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
		using (new Class23(xmlWriter_0, "Objects"))
		{
			for (int i = 0; i < list_1.Count; i++)
			{
				Class18 @class = list_1[i];
				object obj = @class.method_1();
				Type type = @class.method_2();
				using (new Class23(xmlWriter_0, "ObjectDef"))
				{
					xmlWriter_0.WriteAttributeString("ID", i.ToString());
					string text = null;
					bool flag = true;
					string[] array = WaitSendingReportControl.smethod_0("", new char[1] { ',' }, 232, 177);
					foreach (string text2 in array)
					{
						if (text2 != "" && Win32.smethod_9(Class25.smethod_3(type, 870, 857), text2, 435, 427))
						{
							flag = false;
							break;
						}
					}
					object[] array2 = UsageReportSender.smethod_5(type, bool_0: true, 6, 90);
					for (int k = 0; k < array2.Length; k++)
					{
						Attribute object_ = (Attribute)array2[k];
						string name = FeedbackControl.smethod_0(object_, 194, 184).Name;
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
							text = WaitSendingReportControl.smethod_4(obj, 949, 1022);
							text = ((text == Class25.smethod_3(type, 660, 683)) ? null : (type.IsEnum ? SecurityExceptionEventArgs.smethod_2(type, obj, "d", 26, 16) : ((!(obj is Guid)) ? ("\"" + text + "\"") : ("{" + text + "}"))));
						}
						catch
						{
						}
						if (text != null)
						{
							xmlWriter_0.WriteAttributeString("Value", smethod_3(text));
						}
					}
					if (type.HasElementType)
					{
						method_5(SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_1(type, 172, 140));
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
						Array array3 = (Array)obj;
						xmlWriter_0.WriteAttributeString("Rank", Class29.smethod_7(array3, 904, 921).ToString());
						StringBuilder stringBuilder = new StringBuilder();
						for (int l = 0; l < Class29.smethod_7(array3, 870, 887); l++)
						{
							if (l > 0)
							{
								stringBuilder.Append(',');
							}
							StackFrameHelper.smethod_4(stringBuilder, Class25.smethod_4(array3, l, 730, 652), 536, 590);
						}
						xmlWriter_0.WriteAttributeString("Length", WaitSendingReportControl.smethod_4(stringBuilder, 97, 42));
						if (Class29.smethod_7(array3, 311, 294) != 1)
						{
							continue;
						}
						int length = array3.Length;
						for (int m = 0; m < length; m++)
						{
							if (m == 10 && length > 16)
							{
								m = length - 5;
							}
							try
							{
								method_1(new Class18(Class32.smethod_4(array3, m, 906, 907), bool_1: false), null);
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
							using (new Class23(xmlWriter_0, "IEnumerable"))
							{
								int num = 0;
								foreach (object item in (IEnumerable)obj)
								{
									if (num <= 20)
									{
										method_1(new Class18(item, bool_1: false), null);
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

	private void method_11(Class18 class18_0)
	{
		FieldInfo[] array = Class19.smethod_4(class18_0.method_2(), BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, 756, 722);
		FieldInfo[] array2 = array;
		foreach (FieldInfo fieldInfo in array2)
		{
			try
			{
				if (Form1.smethod_3(fieldInfo, 498, 481) || (Attribute0.smethod_4(fieldInfo, 62, 113) && Attribute0.smethod_4(fieldInfo, 808, 888)))
				{
					continue;
				}
				bool flag = true;
				object[] array3 = UsageReportSender.smethod_5(fieldInfo, bool_0: true, 779, 855);
				for (int j = 0; j < array3.Length; j++)
				{
					Attribute object_ = (Attribute)array3[j];
					if (FeedbackControl.smethod_0(object_, 23, 109).Name == "DoNotCaptureAttribute")
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					method_1(new Class18(fieldInfo.GetValue(class18_0.method_1()), bool_1: false), fieldInfo);
				}
			}
			catch
			{
			}
		}
		class18_0 = new Class18(class18_0.method_1(), Class25.smethod_2(class18_0.method_2(), 847, 801), class18_0.method_0());
		if ((object)class18_0.method_2() != null)
		{
			using (new Class23(xmlWriter_0, "Field"))
			{
				method_3("__base");
				xmlWriter_0.WriteAttributeString("ID", list_1.Count.ToString());
			}
			list_1.Add(class18_0);
		}
	}

	private void method_12(Exception exception_1)
	{
		using (new Class23(xmlWriter_0, "Exception"))
		{
			try
			{
				Type type_ = SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_0(exception_1, 379, 369);
				method_5(type_);
				string value = "N/A";
				try
				{
					value = AutoHeightLabel.smethod_1(exception_1, 394, 499);
				}
				catch
				{
				}
				xmlWriter_0.WriteAttributeString("Message", value);
				string text = Win32.smethod_10(exception_1, 75, 62).Trim();
				xmlWriter_0.WriteAttributeString("ExceptionStackTrace", text);
				int num = Class37.smethod_8(text, ' ', 341, 366);
				text = StackFrameHelper.smethod_2(text, num + 1, 309, 333);
				num = smethod_7(text, "\r\n", 990, 940);
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				xmlWriter_0.WriteAttributeString("Method", text);
				method_2(new Class18(exception_1, bool_1: true));
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
			Struct16 value = new Struct16(string_1);
			dictionary_0.Add(string_0, value);
		}
	}

	[SmartAssembly.SmartExceptionsCore.ReportUsage("Unhandled Exception Report Sent")]
	internal bool method_15()
	{
		Class35.smethod_0(1u);
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
					if (stackTrace.FrameCount > 0)
					{
						StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
						num = PoweredBy.smethod_1(frame, 701, 740);
					}
				}
				catch
				{
				}
				InvokeSendingReportFeedback(SendingReportStep.PreparingReport, SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_4("ERR 2006: {0} @ 0x{1:x4}", AutoHeightLabel.smethod_1(e, 939, 978), num, 375, 278));
				return false;
			}
			Class17 class17_ = new Class17("", "Nc0j6W1Ag", "v46.51.11.4 from 20/06/2013 01:18:07");
			return method_0(array, class17_);
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
			FatalExceptionEventHandler value = (FatalExceptionEventHandler)Class18.smethod_0(fatalExceptionEventHandler2, fatalExceptionEventHandler_1, 194, 234);
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
			EventHandler value = (EventHandler)Class18.smethod_0(eventHandler2, eventHandler_1, 473, 497);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal void method_19()
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			method_20(tempFileName);
			string string_ = AppPathFinder.ReadInstalledSaPath();
			Process.Start(ReportSender.smethod_0(string_, "SmartAssembly.exe", 358, 258), "/AddExceptionReport \"" + tempFileName + "\"");
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
			byte[] byte_;
			try
			{
				byte_ = SimpleZip.Zip(buffer);
			}
			catch
			{
				byte_ = null;
			}
			byte[] array = Class13.smethod_0(byte_, "<RSAKeyValue><Modulus>znwYeoTG6J3QopcRcVswJImI+sp841M9VIxjD0lwpQSIUbCGhs7GlMCO0wcXiv0A4XdWnvGHlxBCVBqx89h2hXKJ6VXiOgcxb17pgdTbMMqlj0hezKhZRm93xjdaMR7DiqWlfEot945SsraToAkIcII0lEug/xhK9gQuHLj4O0E=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			FileStream fileStream = ReportExceptionEventArgs.smethod_2(string_0, 830, 790);
			byte[] array2 = Win32.smethod_12(smethod_8(649, 660), "{E8999F69-FF1B-4846-9283-897940EB0660}", 652, 738);
			SendingReportFeedbackEventArgs.smethod_2(fileStream, array2, 0, array2.Length, 30, 55);
			SendingReportFeedbackEventArgs.smethod_2(fileStream, array, 0, array.Length, 159, 182);
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

	static Class14()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static int smethod_7(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 113:
				return string_0.LastIndexOf(string_1);
			case 114:
				return string_0.IndexOf(string_1);
			}
		}
	}

	internal static Encoding smethod_8(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 29:
				return Encoding.ASCII;
			}
		}
	}
}
