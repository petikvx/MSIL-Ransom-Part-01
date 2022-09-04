using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web.Services.Protocols;
using System.Xml;
using My;
using SmartAssembly.Attributes;
using SmartAssembly.License;
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartExceptionsWithUI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class Class17 : ReportSender
{
	private struct Struct18
	{
		public readonly string string_0;

		public readonly string string_1;

		public readonly string string_2;

		public readonly int int_0;

		public Struct18(string string_3)
		{
			FileInfo fileInfo = default(FileInfo);
			byte[] array = default(byte[]);
			FileStream fileStream = default(FileStream);
			byte[] array2 = default(byte[]);
			Exception ex2 = default(Exception);
			try
			{
				string_0 = string.Empty;
				string_1 = string.Empty;
				string_2 = string.Empty;
				int_0 = 0;
				try
				{
					fileInfo = new FileInfo(string_3);
					string_0 = ReportSender.smethod_2(string_3, 108, 70);
					int_0 = (int)Win32.smethod_10(fileInfo, 956, 971);
					array = new byte[int_0];
					fileStream = UnhandledExceptionHandlerWithUI.smethod_4(string_3, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 223, 131);
					try
					{
						SecurityExceptionEventArgs.smethod_2(fileStream, array, 0, int_0, 509, 424);
						Class22.smethod_4(fileStream, 258, 292);
					}
					finally
					{
						((IDisposable)fileStream)?.Dispose();
					}
					try
					{
						array2 = SimpleZip.Zip(array);
					}
					catch
					{
						array2 = null;
					}
					string_1 = Convert.ToBase64String(array2);
				}
				catch (Exception ex)
				{
					ex2 = ex;
					string_2 = ex2.Message;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException7(exception, fileInfo, array, fileStream, array2, ex2, this, string_3);
				throw;
			}
		}

		static Struct18()
		{
			try
			{
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
	}

	private struct Struct19
	{
		public readonly string string_0;

		public readonly string string_1;

		public Struct19(string string_2, string string_3)
		{
			try
			{
				string_0 = string_2;
				string_1 = string_3;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, this, string_2, string_3);
				throw;
			}
		}

		static Struct19()
		{
			try
			{
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
	}

	private struct Struct20
	{
		public string string_0;

		public Struct19 struct19_0;

		[SpecialName]
		public bool method_0()
		{
			try
			{
				return AppPathFinder.smethod_1(string_0, 357, 338) == 0;
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}

		[SpecialName]
		public static Struct20 smethod_0()
		{
			try
			{
				return new Struct20(string.Empty, string.Empty, string.Empty);
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException1(exception, num);
				throw;
			}
		}

		private Struct20(string string_1, string string_2, string string_3)
		{
			try
			{
				string_0 = string_1;
				struct19_0 = new Struct19(string_2, string_3);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, this, string_1, string_2, string_3);
				throw;
			}
		}

		static Struct20()
		{
			try
			{
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
	}

	private readonly Dictionary<string, Struct18> dictionary_0;

	private readonly List<Struct19> list_0;

	internal Exception exception_0;

	internal Guid guid_0;

	internal char[] char_0;

	internal Dictionary<string, object> dictionary_1;

	internal XmlWriter xmlWriter_0;

	internal List<Class21> list_1;

	internal List<string> list_2;

	internal Dictionary<string, int> dictionary_2;

	internal Dictionary<string, int> dictionary_3;

	internal MemoryStream memoryStream_0;

	internal byte[] byte_0;

	internal FatalExceptionEventHandler fatalExceptionEventHandler_0;

	internal EventHandler eventHandler_0;

	public Class17(Guid guid_1, Exception exception_1, IWebProxy iwebProxy_1)
	{
		char[] array = (char_0 = new char[0]);
		Dictionary<string, object> dictionary = (dictionary_1 = new Dictionary<string, object>());
		dictionary_0 = new Dictionary<string, Struct18>();
		List<Class21> list = (list_1 = new List<Class21>());
		List<string> list2 = (list_2 = new List<string>());
		Dictionary<string, int> dictionary2 = (dictionary_2 = new Dictionary<string, int>());
		list_0 = new List<Struct19>();
		Dictionary<string, int> dictionary3 = (dictionary_3 = new Dictionary<string, int>());
		base._002Ector();
		Guid guid = default(Guid);
		Exception ex = default(Exception);
		MemoryStream memoryStream = default(MemoryStream);
		XmlWriter xmlWriter = default(XmlWriter);
		string text = default(string);
		char[] array2 = default(char[]);
		char[] array3 = default(char[]);
		try
		{
			guid = (guid_0 = guid_1);
			ex = (exception_0 = exception_1);
			memoryStream = (memoryStream_0 = new MemoryStream());
			xmlWriter = (xmlWriter_0 = new XmlTextWriter(memoryStream_0, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false)));
			SetProxy(iwebProxy_1);
			if ((text = ReportSender1.smethod_2("UNICODE", 114, 14)) == null)
			{
				return;
			}
			if (!Class2.smethod_9(text, "ASCII", 273, 331))
			{
				if (Class2.smethod_9(text, "UNICODE", 408, 450))
				{
					array2 = (char_0 = new char[58]
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
				char[] array_ = new char[62];
				UsageReportSender.smethod_10(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 670, 703);
				array3 = (char_0 = array_);
			}
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[17]
			{
				text, array, dictionary, list, list2, dictionary2, dictionary3, guid, ex, memoryStream,
				xmlWriter, array3, array2, this, guid_1, exception_1, iwebProxy_1
			});
			throw;
		}
	}

	private static string smethod_4(object object_0)
	{
		int num = default(int);
		string text = default(string);
		int int_ = default(int);
		long long_ = default(long);
		short short_ = default(short);
		uint uint_ = default(uint);
		ulong ulong_ = default(ulong);
		ushort ushort_ = default(ushort);
		byte b = default(byte);
		sbyte sbyte_ = default(sbyte);
		IntPtr intptr_ = default(IntPtr);
		long num2 = default(long);
		UIntPtr uIntPtr = default(UIntPtr);
		ulong num3 = default(ulong);
		int num4 = default(int);
		try
		{
			try
			{
				num = 0;
				if (object_0 == null)
				{
					num = 23;
					text = string.Empty;
					return text;
				}
				num = 9;
				if (object_0 is int)
				{
					num = 2;
					int_ = (int)object_0;
					text = SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_3(ref int_, "x", 518, 560);
					return text;
				}
				num = 4;
				if (object_0 is long)
				{
					num = 21;
					long_ = (long)object_0;
					text = SimpleZip.Class7.smethod_1(ref long_, "x", 739, 767);
					return text;
				}
				num = 3;
				if (object_0 is short)
				{
					num = 10;
					short_ = (short)object_0;
					text = ReportSender1.smethod_3(ref short_, "x", 132, 240);
					return text;
				}
				num = 6;
				if (object_0 is uint)
				{
					num = 24;
					uint_ = (uint)object_0;
					text = SimpleZip.Class8.smethod_0(ref uint_, "x", 868, 769);
					return text;
				}
				num = 7;
				if (object_0 is ulong)
				{
					num = 14;
					ulong_ = (ulong)object_0;
					text = Class35.smethod_3(ref ulong_, "x", 435, 480);
					return text;
				}
				num = 11;
				if (object_0 is ushort)
				{
					num = 22;
					ushort_ = (ushort)object_0;
					text = Class3.smethod_7(ref ushort_, "x", 288, 296);
					return text;
				}
				num = 20;
				if (object_0 is byte)
				{
					num = 8;
					b = (byte)object_0;
					text = Class23.smethod_3(ref b, "x", 949, 1005);
					return text;
				}
				num = 15;
				if (object_0 is sbyte)
				{
					num = 12;
					sbyte_ = (sbyte)object_0;
					text = DoNotPruneTypeAttribute.smethod_7(ref sbyte_, "x", 90, 64);
					return text;
				}
				num = 18;
				if (object_0 is IntPtr)
				{
					num = 1;
					intptr_ = (IntPtr)object_0;
					num2 = Win32.smethod_13(ref intptr_, 145, 173);
					text = num2.ToString("x");
					return text;
				}
				num = 17;
				if (object_0 is UIntPtr)
				{
					num = 16;
					uIntPtr = (UIntPtr)object_0;
					num3 = uIntPtr.ToUInt64();
					text = num3.ToString("x");
					return text;
				}
				num = 25;
			}
			catch
			{
			}
			num4 = 3;
			return string.Empty;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[16]
			{
				text, int_, long_, short_, uint_, ulong_, ushort_, b, sbyte_, intptr_,
				num2, uIntPtr, num3, num, num4, object_0
			});
			throw;
		}
	}

	private static string smethod_5(string string_0)
	{
		int num = default(int);
		try
		{
			if (AppNameFinder.smethod_2(string_0, "\"<RSAKeyValue>", 372, 307))
			{
				num = 1;
				if (License.smethod_6(string_0, "</RSAKeyValue>\"", 662, 699))
				{
					num = 7;
					return "*** Information not reported for security reasons ***";
				}
				num = 3;
			}
			else
			{
				num = 3;
			}
			return string_0;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, num, string_0);
			throw;
		}
	}

	private void method_1(Class21 class21_0, FieldInfo fieldInfo_0)
	{
		int num = default(int);
		string text = default(string);
		string text2 = default(string);
		object obj3 = default(object);
		Class26 @class = default(Class26);
		int num2 = default(int);
		Type type = default(Type);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		Type type2 = default(Type);
		string text3 = default(string);
		string text4 = default(string);
		int num6 = default(int);
		int int_ = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		string text5 = default(string);
		StringBuilder stringBuilder2 = default(StringBuilder);
		Class26 class2 = default(Class26);
		int num7 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		try
		{
			num = 0;
			object obj;
			if ((object)fieldInfo_0 != null)
			{
				num = 1;
				obj = ConfirmFeatureUsageReportingForm_1.smethod_2(fieldInfo_0, 434, 436);
			}
			else
			{
				num = 2;
				obj = null;
			}
			text = (string)obj;
			object obj2;
			if ((object)fieldInfo_0 != null)
			{
				num = 5;
				obj2 = "Field";
			}
			else
			{
				num = 8;
				obj2 = "Object";
			}
			text2 = (string)obj2;
			obj3 = class21_0.method_1();
			if (obj3 == null)
			{
				num = 6;
				@class = new Class26(xmlWriter_0, text2);
				try
				{
					num2 = 14;
					if ((object)fieldInfo_0 != null)
					{
						num2 = 1;
						if (AppRegistryKeys.smethod_3(fieldInfo_0, 61, 73))
						{
							num2 = 18;
							Attribute0.smethod_0(xmlWriter_0, "Static", "1", 867, 851);
						}
						else
						{
							num2 = 7;
						}
						type = Class24.smethod_1(fieldInfo_0, 663, 761);
						if ((object)type != null)
						{
							num2 = 6;
							if (UsageCounts.smethod_7(type, 261, 344))
							{
								num2 = 9;
								method_5(FatalExceptionEventArgs.smethod_4(type, 996, 913));
								if (SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_7(type, 149, 189))
								{
									num2 = 0;
									Attribute0.smethod_0(xmlWriter_0, "ByRef", "1", 29, 45);
								}
								else
								{
									num2 = 13;
								}
								if (UsageCounts.smethod_7(type, 585, 535))
								{
									num2 = 11;
									Attribute0.smethod_0(xmlWriter_0, "Pointer", "1", 302, 286);
								}
								else
								{
									num2 = 16;
								}
								if (Form0.smethod_4(type, 838, 781))
								{
									num2 = 17;
									XmlWriter xmlWriter = xmlWriter_0;
									num3 = HeaderControl.smethod_4(type, 665, 767);
									Attribute0.smethod_0(xmlWriter, "Rank", num3.ToString(), 496, 448);
									num2 = 3;
								}
								else
								{
									num2 = 3;
								}
								goto IL_01b6;
							}
							num2 = 12;
						}
						else
						{
							num2 = 12;
						}
						method_5(type);
					}
					else
					{
						num2 = 3;
					}
					goto IL_01b6;
					IL_01b6:
					if (text != null)
					{
						num2 = 10;
						method_3(text);
					}
					else
					{
						num2 = 2;
					}
					Attribute0.smethod_0(xmlWriter_0, "Null", "1", 606, 622);
				}
				finally
				{
					num4 = 6;
					((IDisposable)@class)?.Dispose();
				}
				num5 = 4;
				return;
			}
			type2 = SimpleZip.Stream0.smethod_0(class21_0.method_1(), 442, 439);
			text3 = null;
			text4 = null;
			num6 = 8;
			if (obj3 is string)
			{
				num6 = 9;
				text3 = "System.String";
				num6 = 10;
			}
			else
			{
				num6 = 10;
			}
			if (text3 == null)
			{
				num6 = 7;
				if (!SimpleZip.smethod_3(type2, 51, 106))
				{
					num6 = 13;
					if (!(obj3 is IntPtr))
					{
						num6 = 21;
						if (!(obj3 is UIntPtr))
						{
							num6 = 14;
							if (type2.IsValueType)
							{
								num6 = 26;
								if ((object)type2.Module != GetType().Module)
								{
									num6 = 19;
									text3 = type2.FullName;
									num6 = 20;
								}
								else
								{
									num6 = 20;
								}
							}
							else
							{
								num6 = 20;
							}
							goto IL_04d5;
						}
						num6 = 3;
					}
					else
					{
						num6 = 3;
					}
				}
				else
				{
					num6 = 3;
				}
				text3 = AppNameFinder.smethod_4(type2, 828, 858);
				if (obj3 is char)
				{
					num6 = 24;
					int_ = (char)obj3;
					stringBuilder = new StringBuilder();
					if (int_ >= 32)
					{
						num6 = 15;
						DoNotObfuscateTypeAttribute.smethod_5(stringBuilder, '\'', 693, 699);
						DoNotObfuscateTypeAttribute.smethod_5(stringBuilder, (char)obj3, 973, 963);
						num6 = 23;
						Class21.smethod_4(stringBuilder, "' ", 571, 616);
						num6 = 4;
					}
					else
					{
						num6 = 4;
					}
					Class21.smethod_4(stringBuilder, "(0x", 844, 799);
					Class21.smethod_4(stringBuilder, SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_3(ref int_, "x", 222, 232), 633, 554);
					num6 = 11;
					DoNotObfuscateTypeAttribute.smethod_5(stringBuilder, ')', 890, 884);
					text4 = UsageReportSender.smethod_15(stringBuilder, 672, 734);
					num6 = 18;
				}
				else
				{
					num6 = 18;
				}
				if (obj3 is bool)
				{
					num6 = 6;
					text4 = DoNotPruneTypeAttribute.smethod_4(UsageReportSender.smethod_15(obj3, 911, 1009), 250, 154);
					num6 = 1;
				}
				else
				{
					num6 = 1;
				}
				if (text4 == null)
				{
					num6 = 27;
					text5 = smethod_4(obj3);
					if (AppPathFinder.smethod_1(text5, 336, 359) > 0)
					{
						num6 = 22;
						stringBuilder2 = new StringBuilder();
						Class21.smethod_4(stringBuilder2, UsageReportSender.smethod_15(obj3, 262, 376), 307, 352);
						num6 = 2;
						Class21.smethod_4(stringBuilder2, " (0x", 1008, 931);
						Class21.smethod_4(stringBuilder2, text5, 245, 166);
						num6 = 17;
						DoNotObfuscateTypeAttribute.smethod_5(stringBuilder2, ')', 870, 872);
						text4 = UsageReportSender.smethod_15(stringBuilder2, 907, 1013);
						num6 = 20;
					}
					else
					{
						num6 = 12;
						text4 = UsageReportSender.smethod_15(obj3, 469, 427);
						num6 = 20;
					}
				}
				else
				{
					num6 = 20;
				}
			}
			else
			{
				num6 = 20;
			}
			goto IL_04d5;
			IL_04d5:
			class2 = new Class26(xmlWriter_0, text2);
			try
			{
				num7 = 7;
				if ((object)fieldInfo_0 != null)
				{
					num7 = 14;
					if (fieldInfo_0.IsStatic)
					{
						num7 = 15;
						xmlWriter_0.WriteAttributeString("Static", "1");
					}
					else
					{
						num7 = 8;
					}
				}
				else
				{
					num7 = 8;
				}
				if (text3 != null)
				{
					num7 = 3;
					method_5(type2);
					if (text != null)
					{
						num7 = 1;
						method_3(text);
					}
					else
					{
						num7 = 19;
					}
					if (type2.IsEnum)
					{
						num7 = 17;
						text4 = obj3.ToString();
						num7 = 13;
					}
					else
					{
						num7 = 13;
					}
					if (obj3 is Guid)
					{
						num7 = 20;
						text4 = string.Concat("{", obj3, "}");
						num7 = 21;
					}
					else
					{
						num7 = 21;
					}
					if (text4 == null)
					{
						num7 = 11;
						text4 = string.Concat("\"", obj3, "\"");
						num7 = 18;
					}
					else
					{
						num7 = 18;
					}
					xmlWriter_0.WriteAttributeString("Value", smethod_5(text4));
					num7 = 6;
				}
				else
				{
					num7 = 16;
					if ((object)fieldInfo_0 != null)
					{
						num7 = 2;
						method_5(fieldInfo_0.FieldType);
					}
					else
					{
						num7 = 12;
					}
					method_2(class21_0);
					if (text != null)
					{
						num7 = 4;
						method_3(text);
					}
					else
					{
						num7 = 6;
					}
				}
			}
			finally
			{
				num8 = 1;
				((IDisposable)class2)?.Dispose();
			}
			num9 = 3;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[25]
			{
				text, text2, obj3, type, type2, text3, text4, int_, stringBuilder, text5,
				stringBuilder2, @class, num3, class2, num, num2, num4, num5, num6, num7,
				num8, num9, this, class21_0, fieldInfo_0
			});
			throw;
		}
	}

	private void method_2(Class21 class21_0)
	{
		int num = default(int);
		object obj = default(object);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			num = 8;
			obj = class21_0.method_1();
			num2 = -1;
			num3 = 0;
			num = 9;
			while (true)
			{
				if (num3 < list_1.Count)
				{
					num = 5;
					if (!Class32.smethod_2(list_1[num3].method_1(), obj, 750, 758))
					{
						num = 7;
						num3++;
						num = 9;
						continue;
					}
					num = 0;
					num2 = num3;
					num = 2;
					break;
				}
				num = 2;
				break;
			}
			if (num2 == -1)
			{
				num = 3;
				num2 = list_1.Count;
				list_1.Add(class21_0);
			}
			else
			{
				num = 10;
			}
			xmlWriter_0.WriteAttributeString("ID", num2.ToString());
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, obj, num2, num3, num, this, class21_0);
			throw;
		}
	}

	private void method_3(string string_0)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 0;
			num2 = method_6(string_0);
			if (num2 != -1)
			{
				num = 2;
				Attribute0.smethod_0(xmlWriter_0, "NameID", num2.ToString(), 348, 364);
			}
			else
			{
				xmlWriter_0.WriteAttributeString("Name", string_0);
			}
		}
		catch (Exception exception)
		{
			int num3 = default(int);
			StackFrameHelper.CreateException5(exception, num2, num, num3, this, string_0);
			throw;
		}
	}

	private static Struct20 smethod_6(Type type_0)
	{
		Struct20 @struct = default(Struct20);
		int num = default(int);
		int num2 = default(int);
		Assembly assembly = default(Assembly);
		Guid moduleVersionId = default(Guid);
		try
		{
			@struct = Struct20.smethod_0();
			if ((object)type_0 != null)
			{
				num = 2;
				if ((object)Form1.smethod_0(PoweredByAttribute1.smethod_4(type_0, 229, 152), "SmartAssembly.Attributes.PoweredByAttribute", 763, 731) != null)
				{
					num = 7;
					num2 = (SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_0(type_0, 544, 567) & 0xFFFFFF) - 1;
					@struct.string_0 = num2.ToString();
					num = 1;
					assembly = PoweredByAttribute1.smethod_4(type_0, 925, 992);
					moduleVersionId = DoNotDistributeAttribute.smethod_5(assembly, 353, 304).ModuleVersionId;
					@struct.struct19_0 = new Struct19(moduleVersionId.ToString("B"), assembly.FullName);
					num = 4;
				}
				else
				{
					num = 4;
				}
			}
			else
			{
				num = 4;
			}
			return @struct;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, @struct, assembly, num2, moduleVersionId, num, type_0);
			throw;
		}
	}

	private int method_4(Struct20 struct20_0)
	{
		string text = default(string);
		int count = default(int);
		int num = default(int);
		try
		{
			text = ReportSender1.smethod_2(struct20_0.struct19_0.string_0, 226, 158);
			if (dictionary_3.ContainsKey(text))
			{
				return dictionary_3[text];
			}
			count = list_0.Count;
			list_0.Add(struct20_0.struct19_0);
			dictionary_3.Add(text, count);
			num = 5;
			return count;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, text, count, num, this, struct20_0);
			throw;
		}
	}

	private void method_5(Type type_0)
	{
		int num = default(int);
		int num2 = default(int);
		Struct20 @struct = default(Struct20);
		int num3 = default(int);
		string text = default(string);
		int num4 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		string text2 = default(string);
		string text3 = default(string);
		int num5 = default(int);
		string text4 = default(string);
		int num6 = default(int);
		try
		{
			num = 4;
			if ((object)type_0 == null)
			{
				num = 1;
				return;
			}
			try
			{
				num2 = 21;
				@struct = smethod_6(type_0);
				if (!@struct.method_0())
				{
					num2 = 15;
					Attribute0.smethod_0(xmlWriter_0, "TypeDefID", @struct.string_0, 988, 1004);
					num2 = 10;
					num3 = method_4(@struct);
					if (num3 > 0)
					{
						num2 = 8;
						Attribute0.smethod_0(xmlWriter_0, "Assembly", num3.ToString(), 245, 197);
						num2 = 13;
					}
					else
					{
						num2 = 13;
					}
				}
				else
				{
					num2 = 0;
					text = AppNameFinder.smethod_4(type_0, 844, 810);
					if (dictionary_2.ContainsKey(text))
					{
						num2 = 11;
						num4 = dictionary_2[text];
						num2 = 12;
					}
					else
					{
						num2 = 1;
						stringBuilder = new StringBuilder();
						text2 = UnhandledExceptionHandlerWithUI.smethod_8(WaitSendingReportControl.smethod_2(PoweredByAttribute1.smethod_4(type_0, 273, 364), 996, 961), 467, 511);
						num2 = 14;
						if (AppPathFinder.smethod_1(text2, 739, 724) > 0)
						{
							num2 = 5;
							if (License.smethod_6(text2, "mscorlib", 883, 861))
							{
								num2 = 19;
								DoNotObfuscateTypeAttribute.smethod_5(stringBuilder, '[', 839, 841);
								Class21.smethod_4(stringBuilder, text2, 582, 533);
								num2 = 16;
								DoNotObfuscateTypeAttribute.smethod_5(stringBuilder, ']', 195, 205);
								num2 = 17;
							}
							else
							{
								num2 = 17;
							}
						}
						else
						{
							num2 = 17;
						}
						text3 = Class22.smethod_9(type_0, 517, 584);
						if (AppPathFinder.smethod_1(text3, 667, 684) > 0)
						{
							num2 = 23;
							Class21.smethod_4(stringBuilder, text3, 550, 629);
							DoNotObfuscateTypeAttribute.smethod_5(stringBuilder, '.', 130, 140);
							num2 = 24;
						}
						else
						{
							num2 = 24;
						}
						if (UsageCounts.smethod_7(type_0, 288, 381))
						{
							num2 = 4;
							type_0 = FatalExceptionEventArgs.smethod_4(type_0, 752, 645);
							num2 = 7;
						}
						else
						{
							num2 = 7;
						}
						num5 = Win32.smethod_14(text, "+", 240, 173);
						if (num5 > 0)
						{
							num2 = 3;
							text4 = text.Substring(AppPathFinder.smethod_1(text3, 404, 419) + 1, num5 - text3.Length).Replace("+", "/");
							num2 = 2;
							stringBuilder.Append(text4);
							num2 = 18;
						}
						else
						{
							num2 = 18;
						}
						stringBuilder.Append(type_0.Name);
						num4 = list_2.Count;
						num2 = 6;
						list_2.Add(stringBuilder.ToString());
						dictionary_2.Add(text, num4);
					}
					xmlWriter_0.WriteAttributeString("TypeName", num4.ToString());
				}
			}
			catch
			{
			}
			num6 = 1;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[14]
			{
				@struct, num3, num4, text, stringBuilder, text2, text3, num5, text4, num,
				num2, num6, this, type_0
			});
			throw;
		}
	}

	private int method_6(string string_0)
	{
		int num = default(int);
		bool flag = default(bool);
		int num2 = default(int);
		int num3 = default(int);
		char c = default(char);
		bool flag2 = default(bool);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		try
		{
			try
			{
				num = 9;
				flag = char_0[0] == '\u0001';
				if (string_0 == null)
				{
					num = 19;
					goto IL_015e;
				}
				num = 14;
				if (AppPathFinder.smethod_1(string_0, 126, 73) == 0)
				{
					num = 19;
					goto IL_015e;
				}
				num = 5;
				if (flag)
				{
					num = 4;
					if (AppPathFinder.smethod_1(string_0, 128, 183) > 4)
					{
						num = 19;
						goto IL_015e;
					}
					num = 16;
				}
				else
				{
					num = 16;
				}
				if (!flag)
				{
					num = 0;
					if (Class35.smethod_1(string_0, 0, 1010, 923) != '#')
					{
						num = 19;
						goto IL_015e;
					}
					num = 7;
				}
				else
				{
					num = 7;
				}
				num2 = 0;
				num3 = AppPathFinder.smethod_1(string_0, 703, 648) - 1;
				num = 13;
				while (true)
				{
					if (num3 >= 0)
					{
						num = 8;
						if (!flag)
						{
							num = 21;
							if (num3 == 0)
							{
								num = 17;
								goto IL_0147;
							}
							num = 20;
						}
						else
						{
							num = 20;
						}
						c = Class35.smethod_1(string_0, num3, 280, 369);
						flag2 = false;
						num4 = 0;
						num = 2;
						while (true)
						{
							if (num4 < char_0.Length)
							{
								num = 22;
								if (char_0[num4] != c)
								{
									num = 12;
									num4++;
									num = 2;
									continue;
								}
								num = 1;
								num2 = num2 * char_0.Length + num4;
								num = 24;
								flag2 = true;
								num = 18;
								break;
							}
							num = 18;
							break;
						}
						if (flag2)
						{
							num = 23;
							num3--;
							num = 13;
							continue;
						}
						num = 6;
						num5 = -1;
						break;
					}
					num = 17;
					goto IL_0147;
					IL_0147:
					num5 = num2;
					break;
				}
				goto end_IL_0000;
				IL_015e:
				num5 = -1;
				end_IL_0000:;
			}
			catch
			{
				num5 = -1;
			}
			num6 = 3;
			return num5;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[11]
			{
				flag, num2, num3, c, flag2, num4, num5, num, num6, this,
				string_0
			});
			throw;
		}
	}

	private static string smethod_7()
	{
		string text = default(string);
		try
		{
			try
			{
				text = UsageCounts.smethod_5(630, 621);
				return text;
			}
			catch
			{
				text = "N/A";
				return text;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, text);
			throw;
		}
	}

	private Assembly[] method_7()
	{
		Assembly[] array = default(Assembly[]);
		Assembly[] array2 = default(Assembly[]);
		try
		{
			try
			{
				array = SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_3(Class4.smethod_4(977, 974), 781, 852);
				return array;
			}
			catch
			{
				array2 = new Assembly[1] { smethod_8() };
				array = array2;
				return array;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, array, array2, this);
			throw;
		}
	}

	private static Assembly smethod_8()
	{
		Assembly assembly = default(Assembly);
		try
		{
			try
			{
				assembly = SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_1(281, 369);
				return assembly;
			}
			catch
			{
				assembly = null;
				return assembly;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, assembly);
			throw;
		}
	}

	internal byte[] method_8()
	{
		try
		{
			return method_9();
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException2(exception, num, this);
			throw;
		}
	}

	private byte[] method_9()
	{
		Class26 @class = default(Class26);
		int num = default(int);
		DateTime dateTime_ = default(DateTime);
		Guid guid = default(Guid);
		Guid guid2 = default(Guid);
		Class26 class2 = default(Class26);
		int num2 = default(int);
		Assembly assembly = default(Assembly);
		Assembly[] array = default(Assembly[]);
		int num3 = default(int);
		Assembly assembly2 = default(Assembly);
		Class26 class3 = default(Class26);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		Class26 class4 = default(Class26);
		int num10 = default(int);
		Dictionary<string, object>.KeyCollection.Enumerator enumerator = default(Dictionary<string, object>.KeyCollection.Enumerator);
		int num11 = default(int);
		int num12 = default(int);
		string current = default(string);
		Class26 class5 = default(Class26);
		int num13 = default(int);
		string text = default(string);
		int num14 = default(int);
		int num15 = default(int);
		int num16 = default(int);
		int num17 = default(int);
		int num18 = default(int);
		Class26 class6 = default(Class26);
		int num19 = default(int);
		Dictionary<string, Struct18>.KeyCollection.Enumerator enumerator2 = default(Dictionary<string, Struct18>.KeyCollection.Enumerator);
		int num20 = default(int);
		int num21 = default(int);
		string current2 = default(string);
		Class26 class7 = default(Class26);
		int num22 = default(int);
		Struct18 @struct = default(Struct18);
		int int_ = default(int);
		int num23 = default(int);
		int num24 = default(int);
		int num25 = default(int);
		int num26 = default(int);
		int num27 = default(int);
		Class26 class8 = default(Class26);
		int num28 = default(int);
		int num29 = default(int);
		int num30 = default(int);
		int num31 = default(int);
		List<Exception> list = default(List<Exception>);
		Exception ex = default(Exception);
		Class26 class9 = default(Class26);
		int num32 = default(int);
		List<Exception>.Enumerator enumerator3 = default(List<Exception>.Enumerator);
		int num33 = default(int);
		int num34 = default(int);
		Exception current3 = default(Exception);
		int num35 = default(int);
		ICollection collection = default(ICollection);
		int count = default(int);
		int num36 = default(int);
		IEnumerator enumerator4 = default(IEnumerator);
		int num37 = default(int);
		int num38 = default(int);
		object current4 = default(object);
		int num39 = default(int);
		Type type = default(Type);
		Class26 class10 = default(Class26);
		int num40 = default(int);
		int num41 = default(int);
		int num42 = default(int);
		int num43 = default(int);
		int num44 = default(int);
		int num45 = default(int);
		object[] array2 = default(object[]);
		Struct20 struct2 = default(Struct20);
		Class26 class11 = default(Class26);
		int num46 = default(int);
		int num47 = default(int);
		object[] array3 = default(object[]);
		int num48 = default(int);
		object obj3 = default(object);
		int num49 = default(int);
		int num50 = default(int);
		int num51 = default(int);
		int num52 = default(int);
		int num53 = default(int);
		IDisposable disposable = default(IDisposable);
		int num54 = default(int);
		int num55 = default(int);
		int num56 = default(int);
		int num57 = default(int);
		int num58 = default(int);
		Class26 class12 = default(Class26);
		int num59 = default(int);
		int count2 = default(int);
		int num60 = default(int);
		int num61 = default(int);
		string text2 = default(string);
		Exception ex3 = default(Exception);
		int num62 = default(int);
		int num63 = default(int);
		int num64 = default(int);
		Class26 class13 = default(Class26);
		int num65 = default(int);
		int count3 = default(int);
		int num66 = default(int);
		Class26 class14 = default(Class26);
		int num67 = default(int);
		Struct19 struct3 = default(Struct19);
		int num68 = default(int);
		int num69 = default(int);
		int num70 = default(int);
		int num71 = default(int);
		int num72 = default(int);
		int num73 = default(int);
		byte[] array4 = default(byte[]);
		try
		{
			if (byte_0 != null)
			{
				return byte_0;
			}
			SimpleZip.Stream0.smethod_1(xmlWriter_0, 624, 556);
			@class = new Class26(xmlWriter_0, "UnhandledExceptionReport");
			try
			{
				num = 0;
				Attribute0.smethod_0(xmlWriter_0, "AssemblyID", ReportSender1.smethod_2("{7BC8269A-DFA7-4C63-92DF-CECB0FBA593D}", 62, 66), 195, 243);
				num = 5;
				XmlWriter xmlWriter = xmlWriter_0;
				dateTime_ = UsageReportSender.smethod_9(170, 184);
				Attribute0.smethod_0(xmlWriter, "DateTime", MyComputer.smethod_0(ref dateTime_, "s", 266, 299), 435, 387);
				num = 4;
				Attribute0.smethod_0(xmlWriter_0, "Path", smethod_7(), 391, 439);
				num = 9;
				if (Class5.smethod_6(guid_0, Guid.Empty, 123, 107))
				{
					num = 3;
					XmlWriter xmlWriter2 = xmlWriter_0;
					guid = guid_0;
					Attribute0.smethod_0(xmlWriter2, "UserID", StackFrameHelper.smethod_3(ref guid, "B", 414, 397), 180, 132);
				}
				else
				{
					num = 13;
				}
				XmlWriter xmlWriter3 = xmlWriter_0;
				guid2 = SmartAssembly.SmartExceptionsCore.DoNotPruneAttribute.smethod_1(349, 287);
				Attribute0.smethod_0(xmlWriter3, "ReportID", StackFrameHelper.smethod_3(ref guid2, "B", 407, 388), 927, 943);
				num = 10;
				if (list_0.Count > 0)
				{
					num = 8;
					list_0.Clear();
				}
				else
				{
					num = 11;
				}
				list_0.Add(new Struct19("{7BC8269A-DFA7-4C63-92DF-CECB0FBA593D}", string.Empty));
				if (dictionary_3.Count > 0)
				{
					num = 7;
					dictionary_3.Clear();
				}
				else
				{
					num = 12;
				}
				dictionary_3.Add("{7BC8269A-DFA7-4C63-92DF-CECB0FBA593D}", 0);
				class2 = new Class26(xmlWriter_0, "Assemblies");
				try
				{
					num2 = 6;
					assembly = smethod_8();
					array = method_7();
					num3 = 0;
					while (num3 < array.Length)
					{
						assembly2 = array[num3];
						if ((object)assembly2 != null)
						{
							num2 = 4;
							class3 = new Class26(xmlWriter_0, "Assembly");
							try
							{
								try
								{
									num4 = 8;
									Attribute0.smethod_0(xmlWriter_0, "Name", Class36.smethod_9(assembly2, 529, 547), 525, 573);
									num4 = 1;
									Attribute0.smethod_0(xmlWriter_0, "CodeBase", DESCryptoIndirector.smethod_0(assembly2, 498, 400), 665, 681);
									num4 = 7;
									if ((object)assembly2 == assembly)
									{
										Attribute0.smethod_0(xmlWriter_0, "This", "1", 559, 543);
									}
								}
								catch
								{
								}
								num5 = 0;
							}
							finally
							{
								num6 = 0;
								((IDisposable)class3)?.Dispose();
							}
						}
						num7 = 3;
						num3++;
						num7 = 6;
					}
					num7 = 4;
				}
				finally
				{
					num8 = 0;
					((IDisposable)class2)?.Dispose();
				}
				num9 = 4;
				class4 = new Class26(xmlWriter_0, "CustomProperties");
				try
				{
					num10 = 1;
					if (dictionary_1 != null)
					{
						num10 = 4;
						if (dictionary_1.Count > 0)
						{
							num10 = 0;
							enumerator = dictionary_1.Keys.GetEnumerator();
							try
							{
								num11 = 0;
								while (true)
								{
									num12 = 2;
									if (!enumerator.MoveNext())
									{
										break;
									}
									current = enumerator.Current;
									class5 = new Class26(xmlWriter_0, "CustomProperty");
									try
									{
										num13 = 5;
										Attribute0.smethod_0(xmlWriter_0, "Name", current, 99, 83);
										num13 = 8;
										text = (string)dictionary_1[current];
										if (text == null)
										{
											Attribute0.smethod_0(xmlWriter_0, "Null", "1", 33, 17);
											num13 = 7;
										}
										else
										{
											Attribute0.smethod_0(xmlWriter_0, "Value", SendingReportFeedbackEventArgs1.smethod_3("\"", text, "\"", 592, 620), 449, 497);
										}
									}
									finally
									{
										num14 = 5;
										((IDisposable)class5)?.Dispose();
									}
								}
								num12 = 3;
							}
							finally
							{
								num15 = 2;
								((IDisposable)enumerator).Dispose();
							}
						}
					}
					num16 = 4;
				}
				finally
				{
					num17 = 4;
					((IDisposable)class4)?.Dispose();
				}
				num18 = 5;
				if (dictionary_0 != null)
				{
					num18 = 2;
					if (dictionary_0.Count > 0)
					{
						num18 = 4;
						class6 = new Class26(xmlWriter_0, "AttachedFiles");
						try
						{
							num19 = 1;
							enumerator2 = dictionary_0.Keys.GetEnumerator();
							try
							{
								num20 = 2;
								while (true)
								{
									num21 = 3;
									if (!enumerator2.MoveNext())
									{
										break;
									}
									current2 = enumerator2.Current;
									class7 = new Class26(xmlWriter_0, "AttachedFile");
									try
									{
										num22 = 3;
										Attribute0.smethod_0(xmlWriter_0, "Key", current2, 656, 672);
										num22 = 0;
										@struct = dictionary_0[current2];
										Attribute0.smethod_0(xmlWriter_0, "FileName", @struct.string_0, 372, 324);
										num22 = 6;
										XmlWriter xmlWriter4 = xmlWriter_0;
										int_ = @struct.int_0;
										Attribute0.smethod_0(xmlWriter4, "Length", int_.ToString(), 788, 804);
										num22 = 2;
										if (AppPathFinder.smethod_1(@struct.string_2, 458, 509) > 0)
										{
											Attribute0.smethod_0(xmlWriter_0, "Error", @struct.string_2, 357, 341);
											num22 = 5;
										}
										else
										{
											Attribute0.smethod_0(xmlWriter_0, "Data", @struct.string_1, 929, 913);
										}
									}
									finally
									{
										num23 = 2;
										((IDisposable)class7)?.Dispose();
									}
								}
								num21 = 1;
							}
							finally
							{
								num24 = 1;
								((IDisposable)enumerator2).Dispose();
							}
							num25 = 3;
						}
						finally
						{
							num26 = 1;
							((IDisposable)class6)?.Dispose();
						}
					}
				}
				num27 = 0;
				class8 = new Class26(xmlWriter_0, "SystemInformation");
				try
				{
					try
					{
						num28 = 2;
						Class36.smethod_10(xmlWriter_0, "NETVersion", UsageReportSender.smethod_15(SimpleZip.Class11.smethod_2(454, 396), 471, 425), 361, 260);
						num28 = 6;
						Class36.smethod_10(xmlWriter_0, "OSVersion", UsageReportSender.smethod_15(WaitSendingReportControl.smethod_6(ReportSender1.smethod_5(442, 407), 564, 562), 609, 543), 117, 24);
						num28 = 3;
						Class36.smethod_10(xmlWriter_0, "OSPlatformID", UsageReportSender.smethod_15(Class28.smethod_8(ReportSender1.smethod_5(1013, 984), 800, 875), 774, 888), 105, 4);
						num28 = 0;
						Class36.smethod_10(xmlWriter_0, "ServicePack", Win32.smethod_4(), 912, 1021);
						num28 = 8;
						Class36.smethod_10(xmlWriter_0, "ServerR2", Win32.smethod_2() ? "1" : "0", 283, 374);
						Class36.smethod_10(xmlWriter_0, "X64", Win32.smethod_1() ? "1" : "0", 639, 530);
						Class36.smethod_10(xmlWriter_0, "Workstation", Win32.smethod_3() ? "1" : "0", 64, 45);
					}
					catch
					{
					}
					num29 = 2;
				}
				finally
				{
					num30 = 1;
					((IDisposable)class8)?.Dispose();
				}
				num31 = 2;
				list = new List<Exception>();
				ex = exception_0;
				num31 = 3;
				while (ex != null)
				{
					list.Add(ex);
					ex = DoNotDistributeAttribute.smethod_3(ex, 986, 923);
					num31 = 3;
				}
				list.Reverse();
				class9 = new Class26(xmlWriter_0, "StackTrace");
				try
				{
					num32 = 2;
					enumerator3 = list.GetEnumerator();
					try
					{
						num33 = 0;
						while (true)
						{
							num34 = 1;
							if (!enumerator3.MoveNext())
							{
								break;
							}
							current3 = enumerator3.Current;
							try
							{
								num35 = 1;
								method_12(current3);
								if (Class23.smethod_1(current3, 162, 215).Contains("SmartStackFrames"))
								{
									num35 = 2;
									collection = (ICollection)Class23.smethod_1(current3, 601, 556)["SmartStackFrames"];
									num35 = 0;
									count = collection.Count;
									num36 = 0;
									enumerator4 = collection.GetEnumerator();
									try
									{
										num37 = 5;
										while (true)
										{
											num38 = 3;
											if (!enumerator4.MoveNext())
											{
												break;
											}
											current4 = enumerator4.Current;
											try
											{
												num39 = 3;
												type = SimpleZip.Stream0.smethod_0(current4, 841, 836);
												num36++;
												num39 = 2;
												if (num36 <= 100)
												{
													goto IL_08c8;
												}
												num39 = 4;
												if (num36 != count - 100)
												{
													goto IL_08c8;
												}
												num39 = 1;
												class10 = new Class26(xmlWriter_0, "RemovedFrames");
												try
												{
													num40 = 3;
													Attribute0.smethod_0(xmlWriter_0, "TotalFramesCount", count.ToString(), 802, 786);
												}
												finally
												{
													num41 = 4;
													((IDisposable)class10)?.Dispose();
												}
												num42 = 7;
												goto end_IL_0845;
												IL_08ed:
												num43 = (int)SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_3(PoweredBy.smethod_2(type, "MethodID", 18, 34), current4, 115, 63);
												num42 = 2;
												num44 = (int)SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_3(PoweredBy.smethod_2(type, "ILOffset", 711, 759), current4, 802, 878);
												num42 = 10;
												num45 = (int)SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_3(PoweredBy.smethod_2(type, "ExceptionStackDepth", 217, 233), current4, 356, 296);
												num42 = 6;
												array2 = (object[])SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_3(PoweredBy.smethod_2(type, "Objects", 903, 951), current4, 778, 838);
												num42 = 3;
												struct2 = smethod_6(type);
												if (!struct2.method_0())
												{
													num42 = 9;
													class11 = new Class26(xmlWriter_0, "StackFrame");
													try
													{
														num46 = 2;
														Attribute0.smethod_0(xmlWriter_0, "MethodID", num43.ToString(), 976, 992);
														num46 = 10;
														Attribute0.smethod_0(xmlWriter_0, "ExceptionStackDepth", num45.ToString(), 455, 503);
														num46 = 5;
														num47 = method_4(struct2);
														if (num47 > 0)
														{
															num46 = 1;
															Attribute0.smethod_0(xmlWriter_0, "Assembly", num47.ToString(), 149, 165);
														}
														else
														{
															num46 = 11;
														}
														if (num44 != -1)
														{
															num46 = 0;
															Attribute0.smethod_0(xmlWriter_0, "ILOffset", num44.ToString(), 661, 677);
														}
														else
														{
															num46 = 8;
														}
														array3 = array2;
														num48 = 0;
														while (num48 < array3.Length)
														{
															obj3 = array3[num48];
															try
															{
																num49 = 0;
																method_1(new Class21(obj3, bool_1: true), null);
															}
															catch
															{
															}
															num50 = 5;
															num48++;
															num50 = 1;
														}
														num50 = 3;
													}
													finally
													{
														num51 = 3;
														((IDisposable)class11)?.Dispose();
													}
												}
												num52 = 2;
												goto end_IL_0845;
												IL_08c8:
												if (num36 > 100)
												{
													num42 = 1;
													if (num36 <= count - 100)
													{
														num42 = 13;
														continue;
													}
													num42 = 12;
													goto IL_08ed;
												}
												num42 = 12;
												goto IL_08ed;
												end_IL_0845:;
											}
											catch
											{
											}
										}
										num38 = 5;
									}
									finally
									{
										num53 = 4;
										disposable = enumerator4 as IDisposable;
										disposable?.Dispose();
									}
								}
								num54 = 0;
							}
							catch
							{
							}
						}
						num34 = 5;
					}
					finally
					{
						num55 = 0;
						((IDisposable)enumerator3).Dispose();
					}
					num56 = 3;
				}
				finally
				{
					num57 = 1;
					((IDisposable)class9)?.Dispose();
				}
				num58 = 0;
				method_10();
				class12 = new Class26(xmlWriter_0, "TypeNames");
				try
				{
					num59 = 0;
					XmlWriter xmlWriter5 = xmlWriter_0;
					count2 = list_2.Count;
					xmlWriter5.WriteAttributeString("Count", count2.ToString());
					num59 = 2;
					num60 = 0;
					while (num60 < list_2.Count)
					{
						try
						{
							num61 = 2;
							text2 = list_2[num60].ToString();
						}
						catch (Exception ex2)
						{
							ex3 = ex2;
							text2 = '"' + ex3.Message + '"';
						}
						num62 = 3;
						xmlWriter_0.WriteElementString("TypeName", text2);
						num60++;
						num62 = 2;
					}
					num62 = 0;
				}
				finally
				{
					num63 = 4;
					((IDisposable)class12)?.Dispose();
				}
				num64 = 0;
				class13 = new Class26(xmlWriter_0, "AssemblyIDs");
				try
				{
					num65 = 0;
					XmlWriter xmlWriter6 = xmlWriter_0;
					count3 = list_0.Count;
					xmlWriter6.WriteAttributeString("Count", count3.ToString());
					num65 = 1;
					num66 = 0;
					while (num66 < list_0.Count)
					{
						class14 = new Class26(xmlWriter_0, "AssemblyID");
						try
						{
							num67 = 4;
							struct3 = list_0[num66];
							xmlWriter_0.WriteAttributeString("ID", struct3.string_0);
							num67 = 3;
							if (struct3.string_1.Length > 0)
							{
								xmlWriter_0.WriteAttributeString("FullName", struct3.string_1);
							}
						}
						finally
						{
							num68 = 0;
							((IDisposable)class14)?.Dispose();
						}
						num69 = 6;
						num66++;
						num69 = 0;
					}
					num69 = 1;
				}
				finally
				{
					num70 = 1;
					((IDisposable)class13)?.Dispose();
				}
				num71 = 1;
			}
			finally
			{
				num72 = 3;
				((IDisposable)@class)?.Dispose();
			}
			num73 = 5;
			xmlWriter_0.WriteEndDocument();
			xmlWriter_0.Flush();
			num73 = 0;
			memoryStream_0.Flush();
			array4 = (byte_0 = memoryStream_0.ToArray());
			num73 = 6;
			return byte_0;
		}
		catch (Exception caughtException)
		{
			int num74 = default(int);
			StackFrameHelper.CreateExceptionN(caughtException, new object[122]
			{
				assembly, assembly2, current, text, current2, @struct, list, ex, current3, collection,
				count, num36, current4, type, num43, num44, num45, array2, struct2, num47,
				obj3, num60, text2, ex3, num66, struct3, @class, dateTime_, guid, guid2,
				class2, array, num3, class3, class4, enumerator, class5, class6, enumerator2, class7,
				int_, class8, class9, enumerator3, enumerator4, class10, class11, array3, num48, disposable,
				class12, count2, class13, count3, class14, array4, num74, num, num2, num4,
				num5, num6, num7, num8, num9, num10, num11, num13, num14, num12,
				num15, num16, num17, num18, num19, num20, num22, num23, num21, num24,
				num25, num26, num27, num28, num29, num30, num31, num32, num33, num35,
				num37, num39, num40, num41, num42, num46, num49, num50, num51, num52,
				num38, num53, num54, num34, num55, num56, num57, num58, num59, num61,
				num62, num63, num64, num65, num67, num68, num69, num70, num71, num72,
				num73, this
			});
			throw;
		}
	}

	private void method_10()
	{
		Class26 @class = default(Class26);
		int num = default(int);
		int num2 = default(int);
		Class21 class2 = default(Class21);
		object obj = default(object);
		Type type = default(Type);
		Class26 class3 = default(Class26);
		int num3 = default(int);
		string text = default(string);
		bool flag = default(bool);
		char[] array = default(char[]);
		string[] array2 = default(string[]);
		int num4 = default(int);
		string text2 = default(string);
		object[] array3 = default(object[]);
		int num5 = default(int);
		Attribute attribute = default(Attribute);
		string text3 = default(string);
		int num6 = default(int);
		int num7 = default(int);
		Array array4 = default(Array);
		int num8 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		int num9 = default(int);
		int num10 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		int num13 = default(int);
		int num14 = default(int);
		Class26 class4 = default(Class26);
		int num15 = default(int);
		int num16 = default(int);
		IEnumerator enumerator = default(IEnumerator);
		int num17 = default(int);
		object current = default(object);
		int num18 = default(int);
		IDisposable disposable = default(IDisposable);
		int num19 = default(int);
		int num20 = default(int);
		int num21 = default(int);
		int num22 = default(int);
		int num23 = default(int);
		int num24 = default(int);
		int num25 = default(int);
		int num26 = default(int);
		try
		{
			@class = new Class26(xmlWriter_0, "Objects");
			try
			{
				num = 1;
				num2 = 0;
				while (num2 < list_1.Count)
				{
					class2 = list_1[num2];
					obj = class2.method_1();
					num = 6;
					type = class2.method_2();
					class3 = new Class26(xmlWriter_0, "ObjectDef");
					try
					{
						num3 = 19;
						Attribute0.smethod_0(xmlWriter_0, "ID", num2.ToString(), 211, 227);
						num3 = 10;
						text = null;
						flag = true;
						array = new char[1] { ',' };
						array2 = SendingReportFeedbackEventArgs1.smethod_2("", array, 136, 149);
						num3 = 5;
						num4 = 0;
						num3 = 6;
						while (true)
						{
							if (num4 < array2.Length)
							{
								num3 = 3;
								text2 = array2[num4];
								if (License.smethod_6(text2, "", 222, 240))
								{
									num3 = 12;
									if (AppNameFinder.smethod_2(AppNameFinder.smethod_4(type, 1019, 925), text2, 513, 582))
									{
										num3 = 16;
										flag = false;
										num3 = 18;
										break;
									}
									num3 = 1;
								}
								else
								{
									num3 = 1;
								}
								num4++;
								num3 = 6;
								continue;
							}
							num3 = 18;
							break;
						}
						array3 = AutoHeightLabel.smethod_4(type, bool_0: true, 878, 848);
						num5 = 0;
						num3 = 0;
						while (true)
						{
							if (num5 < array3.Length)
							{
								num3 = 4;
								attribute = (Attribute)array3[num5];
								text3 = ConfirmFeatureUsageReportingForm_1.smethod_2(SimpleZip.Stream0.smethod_0(attribute, 794, 791), 1011, 1013);
								num3 = 13;
								if (License.smethod_6(text3, "DoNotCaptureFieldsAttribute", 707, 749))
								{
									num3 = 11;
									if (License.smethod_6(text3, "DoNotCaptureAttribute", 251, 213))
									{
										num3 = 15;
										num5++;
										num3 = 0;
										continue;
									}
									num3 = 8;
								}
								else
								{
									num3 = 8;
								}
								flag = false;
								num3 = 2;
							}
							else
							{
								num3 = 2;
							}
							break;
						}
						if (flag)
						{
							try
							{
								num6 = 6;
								text = UsageReportSender.smethod_15(obj, 16, 110);
								if (Class2.smethod_9(text, AppNameFinder.smethod_4(type, 798, 888), 686, 756))
								{
									num6 = 2;
									text = null;
									num6 = 1;
								}
								else
								{
									num6 = 11;
									if (UsageCounts.smethod_7(type, 491, 436))
									{
										num6 = 5;
										text = Class28.smethod_9(type, obj, "d", 75, 78);
										num6 = 1;
									}
									else
									{
										num6 = 9;
										if (obj is Guid)
										{
											num6 = 3;
											text = SendingReportFeedbackEventArgs1.smethod_3("{", text, "}", 343, 363);
											num6 = 1;
										}
										else
										{
											num6 = 0;
											text = SendingReportFeedbackEventArgs1.smethod_3("\"", text, "\"", 327, 379);
											num6 = 1;
										}
									}
								}
							}
							catch
							{
							}
							num7 = 11;
							if (text != null)
							{
								num7 = 8;
								Attribute0.smethod_0(xmlWriter_0, "Value", smethod_5(text), 876, 860);
							}
							else
							{
								num7 = 14;
							}
						}
						if (UsageCounts.smethod_7(type, 831, 866))
						{
							num7 = 4;
							method_5(FatalExceptionEventArgs.smethod_4(type, 923, 1006));
							if (SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_7(type, 656, 696))
							{
								num7 = 24;
								Attribute0.smethod_0(xmlWriter_0, "ByRef", "1", 67, 115);
							}
							else
							{
								num7 = 23;
							}
							if (UsageCounts.smethod_7(type, 23, 73))
							{
								num7 = 1;
								Attribute0.smethod_0(xmlWriter_0, "Pointer", "1", 649, 697);
							}
							else
							{
								num7 = 10;
							}
							if (Form0.smethod_4(type, 344, 275))
							{
								num7 = 13;
								array4 = (Array)obj;
								XmlWriter xmlWriter = xmlWriter_0;
								num8 = smethod_14(array4, 147, 196);
								Attribute0.smethod_0(xmlWriter, "Rank", num8.ToString(), 416, 400);
								num7 = 3;
								stringBuilder = new StringBuilder();
								num9 = 0;
								num7 = 16;
								while (num9 < smethod_14(array4, 550, 625))
								{
									num7 = 20;
									if (num9 > 0)
									{
										num7 = 6;
										DoNotObfuscateTypeAttribute.smethod_5(stringBuilder, ',', 69, 75);
										num7 = 15;
									}
									else
									{
										num7 = 15;
									}
									SimpleZip.smethod_5(stringBuilder, SimpleZip.smethod_4(array4, num9, 338, 301), 4, 11);
									num7 = 12;
									num9++;
									num7 = 16;
								}
								num7 = 9;
								Attribute0.smethod_0(xmlWriter_0, "Length", UsageReportSender.smethod_15(stringBuilder, 200, 182), 582, 630);
								num7 = 2;
								if (smethod_14(array4, 216, 143) == 1)
								{
									num7 = 19;
									num10 = Class21.smethod_5(array4, 371, 353);
									num11 = 0;
									while (num11 < num10)
									{
										if (num11 == 10)
										{
											num7 = 22;
											if (num10 > 16)
											{
												num7 = 17;
												num11 = num10 - 5;
											}
										}
										try
										{
											num12 = 2;
											method_1(new Class21(Class4.smethod_7(array4, num11, 919, 1009), bool_1: false), null);
										}
										catch
										{
										}
										num13 = 3;
										num11++;
										num13 = 2;
									}
									num13 = 7;
								}
							}
						}
						else
						{
							method_5(type);
							if (class2.method_0())
							{
								num13 = 8;
								if (flag)
								{
									try
									{
										num14 = 2;
										if (obj is IEnumerable)
										{
											num14 = 0;
											class4 = new Class26(xmlWriter_0, "IEnumerable");
											try
											{
												num15 = 4;
												num16 = 0;
												enumerator = ((IEnumerable)obj).GetEnumerator();
												try
												{
													num17 = 0;
													num17 = 6;
													while (true)
													{
														if (enumerator.MoveNext())
														{
															num17 = 9;
															current = enumerator.Current;
															if (num16 <= 20)
															{
																num17 = 1;
																method_1(new Class21(current, bool_1: false), null);
																num16++;
																num17 = 6;
																continue;
															}
															num17 = 7;
															xmlWriter_0.WriteElementString("More", string.Empty);
															num17 = 3;
															break;
														}
														num17 = 3;
														break;
													}
												}
												finally
												{
													num18 = 1;
													disposable = enumerator as IDisposable;
													disposable?.Dispose();
												}
												num19 = 2;
											}
											finally
											{
												num20 = 1;
												((IDisposable)class4)?.Dispose();
											}
										}
										num21 = 4;
									}
									catch
									{
									}
									num22 = 0;
									method_11(class2);
								}
							}
						}
					}
					finally
					{
						num23 = 3;
						((IDisposable)class3)?.Dispose();
					}
					num24 = 5;
					num2++;
					num24 = 3;
				}
				num24 = 4;
			}
			finally
			{
				num25 = 5;
				((IDisposable)@class)?.Dispose();
			}
			num26 = 4;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[46]
			{
				num2, class2, obj, type, text, flag, text2, attribute, text3, array4,
				stringBuilder, num9, num10, num11, num16, current, @class, class3, array, array2,
				num4, array3, num5, num8, class4, enumerator, disposable, num, num3, num6,
				num7, num12, num13, num14, num15, num17, num18, num19, num20, num21,
				num22, num23, num24, num25, num26, this
			});
			throw;
		}
	}

	private void method_11(Class21 class21_0)
	{
		int num = default(int);
		FieldInfo[] array = default(FieldInfo[]);
		FieldInfo[] array2 = default(FieldInfo[]);
		int num2 = default(int);
		FieldInfo fieldInfo = default(FieldInfo);
		int num3 = default(int);
		bool flag = default(bool);
		object[] array3 = default(object[]);
		int num4 = default(int);
		Attribute attribute = default(Attribute);
		int num5 = default(int);
		Class26 @class = default(Class26);
		int num6 = default(int);
		int count = default(int);
		int num7 = default(int);
		int num8 = default(int);
		try
		{
			num = 3;
			array = Win32.smethod_16(class21_0.method_2(), BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, 970, 968);
			array2 = array;
			num = 0;
			num2 = 0;
			while (num2 < array2.Length)
			{
				fieldInfo = array2[num2];
				try
				{
					num3 = 12;
					if (Class32.smethod_3(fieldInfo, 667, 649))
					{
						num3 = 13;
					}
					else
					{
						num3 = 8;
						if (!AppRegistryKeys.smethod_3(fieldInfo, 81, 37))
						{
							num3 = 1;
							goto IL_0088;
						}
						num3 = 7;
						if (!SimpleZip.Stream0.smethod_3(fieldInfo, 269, 348))
						{
							num3 = 1;
							goto IL_0088;
						}
						num3 = 5;
					}
					goto end_IL_0035;
					IL_0088:
					flag = true;
					array3 = AutoHeightLabel.smethod_4(fieldInfo, bool_0: true, 461, 499);
					num4 = 0;
					num3 = 15;
					while (true)
					{
						if (num4 < array3.Length)
						{
							num3 = 16;
							attribute = (Attribute)array3[num4];
							if (!Class2.smethod_9(ConfirmFeatureUsageReportingForm_1.smethod_2(SimpleZip.Stream0.smethod_0(attribute, 19, 30), 62, 56), "DoNotCaptureAttribute", 803, 889))
							{
								num3 = 2;
								num4++;
								num3 = 15;
								continue;
							}
							num3 = 0;
							flag = false;
							num3 = 11;
							break;
						}
						num3 = 11;
						break;
					}
					if (!flag)
					{
						num3 = 3;
					}
					else
					{
						num3 = 9;
						method_1(new Class21(SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_3(fieldInfo, class21_0.method_1(), 731, 663), bool_1: false), fieldInfo);
					}
					end_IL_0035:;
				}
				catch
				{
				}
				num5 = 6;
				num2++;
				num5 = 8;
			}
			num5 = 7;
			class21_0 = new Class21(class21_0.method_1(), FatalExceptionEventArgs.smethod_4(class21_0.method_2(), 150, 226), class21_0.method_0());
			num5 = 0;
			if ((object)class21_0.method_2() == null)
			{
				num5 = 5;
				return;
			}
			@class = new Class26(xmlWriter_0, "Field");
			try
			{
				num6 = 4;
				method_3("__base");
				XmlWriter xmlWriter = xmlWriter_0;
				count = list_1.Count;
				xmlWriter.WriteAttributeString("ID", count.ToString());
			}
			finally
			{
				num7 = 3;
				((IDisposable)@class)?.Dispose();
			}
			num8 = 3;
			list_1.Add(class21_0);
		}
		catch (Exception caughtException)
		{
			int num9 = default(int);
			StackFrameHelper.CreateExceptionN(caughtException, new object[19]
			{
				array, fieldInfo, flag, attribute, array2, num2, array3, num4, @class, count,
				num, num3, num5, num9, num6, num7, num8, this, class21_0
			});
			throw;
		}
	}

	private void method_12(Exception exception_1)
	{
		Class26 @class = default(Class26);
		int num = default(int);
		Type type = default(Type);
		string text = default(string);
		int num2 = default(int);
		int num3 = default(int);
		string text2 = default(string);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		try
		{
			@class = new Class26(xmlWriter_0, "Exception");
			try
			{
				try
				{
					num = 0;
					type = WaitSendingReportControl.smethod_4(exception_1, 95, 53);
					method_5(type);
					text = "N/A";
					try
					{
						num2 = 3;
						text = UsageReportSender.smethod_12(exception_1, 199, 251);
					}
					catch
					{
					}
					num3 = 4;
					Attribute0.smethod_0(xmlWriter_0, "Message", text, 871, 855);
					num3 = 0;
					text2 = PoweredByAttribute.smethod_3(Class36.smethod_8(exception_1, 281, 379), 799, 882);
					num3 = 2;
					Attribute0.smethod_0(xmlWriter_0, "ExceptionStackTrace", text2, 164, 148);
					num3 = 5;
					num4 = SimpleZip.smethod_6(text2, ' ', 564, 601);
					text2 = Class40.smethod_5(text2, num4 + 1, 520, 598);
					num3 = 7;
					num4 = UnhandledExceptionHandlerWithUI.smethod_9(text2, "\r\n", 52, 40);
					if (num4 != -1)
					{
						text2 = text2.Substring(0, num4);
						num3 = 1;
					}
					xmlWriter_0.WriteAttributeString("Method", text2);
					method_2(new Class21(exception_1, bool_1: true));
				}
				catch
				{
				}
				num5 = 1;
			}
			finally
			{
				num6 = 6;
				((IDisposable)@class)?.Dispose();
			}
			num7 = 0;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[13]
			{
				type, text, text2, num4, @class, num, num2, num3, num5, num6,
				num7, this, exception_1
			});
			throw;
		}
	}

	internal void method_13(string string_0, object object_0)
	{
		try
		{
			dictionary_1.Add(string_0, object_0);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, string_0, object_0);
			throw;
		}
	}

	internal void method_14(string string_0, string string_1)
	{
		int num = default(int);
		Struct18 @struct = default(Struct18);
		try
		{
			num = 2;
			if (!SimpleZip.smethod_2(string_1, 926, 946))
			{
				num = 0;
				return;
			}
			@struct = new Struct18(string_1);
			dictionary_0.Add(string_0, @struct);
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, @struct, num, num2, this, string_0, string_1);
			throw;
		}
	}

	internal bool method_15()
	{
		int num = default(int);
		int num2 = default(int);
		byte[] array = default(byte[]);
		Exception ex2 = default(Exception);
		int num3 = default(int);
		int num4 = default(int);
		StackTrace stackTrace = default(StackTrace);
		StackFrame stackFrame = default(StackFrame);
		int num5 = default(int);
		bool flag = default(bool);
		int num6 = default(int);
		Class20 @class = default(Class20);
		Exception ex5 = default(Exception);
		int num7 = default(int);
		try
		{
			Class38.smethod_0(1u);
			try
			{
				num = 3;
				InvokeSendingReportFeedback(SendingReportStep.PreparingReport);
				try
				{
					num2 = 2;
					array = method_9();
				}
				catch (Exception ex)
				{
					ex2 = ex;
					num3 = -1;
					try
					{
						num4 = 4;
						stackTrace = new StackTrace(ex2);
						if (Class40.smethod_3(stackTrace, 94, 81) > 0)
						{
							stackFrame = DoNotEncodeStringsAttribute.smethod_2(stackTrace, Class40.smethod_3(stackTrace, 102, 105) - 1, 484, 447);
							num4 = 5;
							num3 = Class22.smethod_7(stackFrame, 946, 1018);
							num4 = 0;
						}
					}
					catch
					{
					}
					num5 = 2;
					InvokeSendingReportFeedback(SendingReportStep.PreparingReport, Class5.smethod_4("ERR 2006: {0} @ 0x{1:x4}", UsageReportSender.smethod_12(ex2, 765, 705), num3, 885, 830));
					num5 = 4;
					flag = false;
					goto end_IL_0006;
				}
				num6 = 1;
				@class = new Class20("", "server1", "v0.0.0.0 from 08/08/2013 05:46:54 ص");
				num6 = 0;
				flag = method_0(array, @class);
				end_IL_0006:;
			}
			catch (ThreadAbortException)
			{
				flag = false;
			}
			catch (Exception ex4)
			{
				ex5 = ex4;
				method_17(new FatalExceptionEventArgs(ex5));
				flag = false;
			}
			num7 = 0;
			return flag;
		}
		catch (Exception caughtException)
		{
			int num8 = default(int);
			StackFrameHelper.CreateExceptionN(caughtException, new object[16]
			{
				array, ex2, num3, stackTrace, stackFrame, @class, ex5, flag, num8, num,
				num2, num4, num5, num6, num7, this
			});
			throw;
		}
	}

	[SpecialName]
	public void method_16(FatalExceptionEventHandler fatalExceptionEventHandler_1)
	{
		int num = default(int);
		FatalExceptionEventHandler fatalExceptionEventHandler = default(FatalExceptionEventHandler);
		FatalExceptionEventHandler fatalExceptionEventHandler2 = default(FatalExceptionEventHandler);
		FatalExceptionEventHandler fatalExceptionEventHandler3 = default(FatalExceptionEventHandler);
		try
		{
			num = 3;
			fatalExceptionEventHandler = fatalExceptionEventHandler_0;
			num = 6;
			do
			{
				fatalExceptionEventHandler2 = fatalExceptionEventHandler;
				fatalExceptionEventHandler3 = (FatalExceptionEventHandler)WaitSendingReportControl.smethod_3(fatalExceptionEventHandler2, fatalExceptionEventHandler_1, 955, 955);
				num = 4;
				fatalExceptionEventHandler = Interlocked.CompareExchange(ref fatalExceptionEventHandler_0, fatalExceptionEventHandler3, fatalExceptionEventHandler2);
			}
			while ((object)fatalExceptionEventHandler != fatalExceptionEventHandler2);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, fatalExceptionEventHandler, fatalExceptionEventHandler2, fatalExceptionEventHandler3, num, this, fatalExceptionEventHandler_1);
			throw;
		}
	}

	public void method_17(FatalExceptionEventArgs fatalExceptionEventArgs_0)
	{
		int num = default(int);
		FatalExceptionEventHandler fatalExceptionEventHandler = default(FatalExceptionEventHandler);
		try
		{
			num = 2;
			fatalExceptionEventHandler = fatalExceptionEventHandler_0;
			fatalExceptionEventHandler?.Invoke(this, fatalExceptionEventArgs_0);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, fatalExceptionEventHandler, num, this, fatalExceptionEventArgs_0);
			throw;
		}
	}

	[SpecialName]
	public void method_18(EventHandler eventHandler_1)
	{
		int num = default(int);
		EventHandler eventHandler = default(EventHandler);
		EventHandler eventHandler2 = default(EventHandler);
		EventHandler eventHandler3 = default(EventHandler);
		try
		{
			num = 3;
			eventHandler = eventHandler_0;
			num = 1;
			do
			{
				eventHandler2 = eventHandler;
				eventHandler3 = (EventHandler)WaitSendingReportControl.smethod_3(eventHandler2, eventHandler_1, 971, 971);
				num = 4;
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, eventHandler3, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, eventHandler, eventHandler2, eventHandler3, num, this, eventHandler_1);
			throw;
		}
	}

	internal void method_19()
	{
		int num = default(int);
		string text = default(string);
		string text2 = default(string);
		Exception ex3 = default(Exception);
		int num2 = default(int);
		try
		{
			try
			{
				num = 5;
				text = smethod_15(591, 581);
				method_20(text);
				text2 = AppPathFinder.ReadInstalledSaPath();
				num = 4;
				Class26.smethod_1(Form0.smethod_1(text2, "SmartAssembly.exe", 908, 959), SendingReportFeedbackEventArgs1.smethod_3("/AddExceptionReport \"", text, "\"", 1009, 973), 424, 396);
				num = 3;
				if (eventHandler_0 != null)
				{
					eventHandler_0(this, EventArgs.Empty);
				}
			}
			catch (ThreadAbortException)
			{
			}
			catch (Exception ex2)
			{
				ex3 = ex2;
				method_17(new FatalExceptionEventArgs(ex3));
			}
			num2 = 4;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, text, text2, ex3, num, num2, this);
			throw;
		}
	}

	internal bool method_20(string string_0)
	{
		int num = default(int);
		byte[] array = default(byte[]);
		int num2 = default(int);
		byte[] array2 = default(byte[]);
		int num3 = default(int);
		byte[] array3 = default(byte[]);
		FileStream fileStream = default(FileStream);
		byte[] array4 = default(byte[]);
		bool flag = default(bool);
		int num4 = default(int);
		try
		{
			try
			{
				num = 1;
				array = method_9();
				try
				{
					num2 = 1;
					array2 = SimpleZip.Zip(array);
				}
				catch
				{
					array2 = null;
				}
				num3 = 3;
				array3 = Class16.smethod_0(array2, "<RSAKeyValue><Modulus>tD4LsHt5DvkuNayfApsr5CrN2wv0nGPr7RSMZFZe7PTJaKAiEUr1EgQuC2gxjwsI1FEXPujtmMRv+IYkJg9cLuORc3ZnYWjMglPOkqDDcTpvFRze2jmBOUxMDjbQvTV4EoaEYHNDwFNfDdWQnjzwtLSf2EBnOO2W1ntU7fnt5ac=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
				fileStream = Class36.smethod_11(string_0, 54, 127);
				num3 = 0;
				array4 = Class28.smethod_3(Class27.smethod_2(468, 459), "{7BC8269A-DFA7-4C63-92DF-CECB0FBA593D}", 851, 805);
				num3 = 5;
				ReportSender1.smethod_1(fileStream, array4, 0, array4.Length, 957, 963);
				num3 = 6;
				ReportSender1.smethod_1(fileStream, array3, 0, array3.Length, 798, 864);
				num3 = 4;
				fileStream.Close();
				flag = true;
			}
			catch (ThreadAbortException)
			{
				flag = false;
			}
			catch (Exception)
			{
				flag = false;
			}
			num4 = 0;
			return flag;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[12]
			{
				array, array2, array3, fileStream, array4, flag, num, num2, num3, num4,
				this, string_0
			});
			throw;
		}
	}

	static Class17()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static string smethod_9(string string_0, string string_1, string string_2, string string_3, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 72:
					return string_0 + string_1 + string_2 + string_3;
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, num, string_0, string_1, string_2, string_3, int_0, int_1);
			throw;
		}
	}

	internal static Process smethod_10(int int_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 88:
					return Process.GetProcessById(int_0);
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, int_0, int_1, int_2);
			throw;
		}
	}

	internal static void smethod_11(string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 4;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 75:
					File.Delete(string_0);
					return;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException5(exception, num, num2, string_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_12(HttpWebClientProtocol httpWebClientProtocol_0, IWebProxy iwebProxy_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 2;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 98:
					httpWebClientProtocol_0.set_Proxy(iwebProxy_1);
					return;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, httpWebClientProtocol_0, iwebProxy_1, int_0, int_1);
			throw;
		}
	}

	internal static WindowsIdentity smethod_13(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 47:
					return WindowsIdentity.GetCurrent();
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_14(Array array_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 87:
					return array_0.Rank;
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, array_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_15(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 10:
					return Path.GetTempFileName();
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, int_0, int_1);
			throw;
		}
	}
}
