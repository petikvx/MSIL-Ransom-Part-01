using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace ns0;

internal sealed class Class9
{
	private enum Enum0
	{
		const_0 = 0,
		const_1 = 1,
		const_2 = 2,
		const_3 = 4,
		const_4 = 8
	}

	private sealed class Class10
	{
		private Enum0 enum0_0;
	}

	internal sealed class Class11 : IEqualityComparer<Class3>, IEqualityComparer<StackFrame>
	{
		bool IEqualityComparer<Class3>.Equals(Class3 x, Class3 y)
		{
			return smethod_0(x, y);
		}

		int IEqualityComparer<Class3>.GetHashCode(Class3 obj)
		{
			return obj.stackFrame_0.GetMethod()!.MetadataToken ^ obj.stackFrame_0.GetMethod()!.DeclaringType!.GetHashCode();
		}

		bool IEqualityComparer<StackFrame>.Equals(StackFrame x, StackFrame y)
		{
			return smethod_1(x, y);
		}

		int IEqualityComparer<StackFrame>.GetHashCode(StackFrame obj)
		{
			return obj.GetMethod()!.MetadataToken ^ obj.GetMethod()!.DeclaringType!.GetHashCode();
		}

		internal static bool smethod_0(Class3 class3_0, Class3 class3_1)
		{
			return smethod_1(class3_0.stackFrame_0, class3_1.stackFrame_0);
		}

		internal static bool smethod_1(StackFrame stackFrame_0, StackFrame stackFrame_1)
		{
			MethodBase method = stackFrame_0.GetMethod();
			MethodBase method2 = stackFrame_1.GetMethod();
			bool flag = smethod_43(method);
			bool flag2 = smethod_43(method2);
			if (flag && flag2)
			{
				return method.Name == method2.Name;
			}
			if (!flag && !flag2)
			{
				if (method.MetadataToken == method2.MetadataToken)
				{
					return method.DeclaringType!.Equals(method2.DeclaringType);
				}
				return false;
			}
			return false;
		}
	}

	private sealed class Class12 : IComparer<Assembly>
	{
		int IComparer<Assembly>.Compare(Assembly x, Assembly y)
		{
			try
			{
				return x.FullName!.CompareTo(y.FullName);
			}
			catch
			{
			}
			return 0;
		}
	}

	private sealed class Class13 : IComparer<Process>
	{
		int IComparer<Process>.Compare(Process x, Process y)
		{
			try
			{
				return x.ProcessName.CompareTo(y.ProcessName);
			}
			catch
			{
			}
			return 0;
		}
	}

	internal sealed class Class14 : IDisposable
	{
		private XmlWriter xmlWriter_0;

		private Class14()
		{
		}

		internal static IDisposable smethod_0(XmlWriter xmlWriter_1, string string_0)
		{
			Class14 @class = new Class14();
			@class.method_0(xmlWriter_1, string_0);
			return @class;
		}

		private void method_0(XmlWriter xmlWriter_1, string string_0)
		{
			xmlWriter_0 = xmlWriter_1;
			xmlWriter_1.WriteStartElement(string_0);
		}

		void IDisposable.Dispose()
		{
			xmlWriter_0.WriteEndElement();
		}
	}

	internal static string string_0;

	internal static string string_1;

	internal static string string_2;

	private static Dictionary<string, string> dictionary_0;

	private static Delegate0 delegate0_0;

	private static Delegate1 delegate1_0;

	private static Delegate2 delegate2_0;

	private static Delegate3 delegate3_0;

	internal static string string_3;

	internal static string string_4;

	internal static string string_5;

	internal static string string_6;

	internal static bool bool_0;

	internal static bool bool_1;

	internal static string string_7;

	public static bool bool_2;

	internal static bool bool_3;

	internal static bool bool_4;

	private static string string_8;

	internal static Dictionary<string, object> dictionary_1;

	internal static Dictionary<string, bool> dictionary_2;

	internal static string string_9;

	public static string String_0
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public static string String_1
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}

	public static string String_2
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
		}
	}

	public static string String_3
	{
		get
		{
			return string_3;
		}
		set
		{
			string_3 = value;
		}
	}

	public static string String_4
	{
		get
		{
			return string_4;
		}
		set
		{
			string_4 = value;
		}
	}

	public static event Delegate0 Event_0
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			delegate0_0 = (Delegate0)Delegate.Combine(delegate0_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			delegate0_0 = (Delegate0)Delegate.Remove(delegate0_0, value);
		}
	}

	public static event Delegate1 Event_1
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			delegate1_0 = (Delegate1)Delegate.Combine(delegate1_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			delegate1_0 = (Delegate1)Delegate.Remove(delegate1_0, value);
		}
	}

	public static event Delegate2 Event_2
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			delegate2_0 = (Delegate2)Delegate.Combine(delegate2_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			delegate2_0 = (Delegate2)Delegate.Remove(delegate2_0, value);
		}
	}

	public static event Delegate3 Event_3
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			delegate3_0 = (Delegate3)Delegate.Combine(delegate3_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			delegate3_0 = (Delegate3)Delegate.Remove(delegate3_0, value);
		}
	}

	static Class9()
	{
		string_3 = string.Empty;
		string_4 = string.Empty;
		string_5 = string.Empty;
		string_6 = string.Empty;
		bool_0 = true;
		bool_1 = true;
		bool_2 = false;
		bool_3 = true;
		bool_4 = true;
		string_8 = "{0} has encountered a problem - {1}.\n\nTo help improve the software you use, {2} is interested in learning more about the error. We have created an error report for you to send to us.\n\nWould you like to send the report?";
		dictionary_1 = new Dictionary<string, object>
		{
			{ "get_Message", null },
			{ "get_Data", null },
			{ "get_InnerException", null },
			{ "get_TargetSite", null },
			{ "get_StackTrace", null },
			{ "get_Source", null },
			{ "get_HelpLink", null }
		};
		dictionary_2 = new Dictionary<string, bool>();
		string_9 = "http://localhost:3030/Service.asmx";
		dictionary_0 = new Dictionary<string, string>();
		dictionary_0["System.Void"] = "void";
		dictionary_0["System.Object"] = "object";
		dictionary_0["System.String"] = "string";
		dictionary_0["System.Boolean"] = "bool";
		dictionary_0["System.Char"] = "char";
		dictionary_0["System.Single"] = "float";
		dictionary_0["System.Double"] = "double";
		dictionary_0["System.Byte"] = "byte";
		dictionary_0["System.Int16"] = "short";
		dictionary_0["System.UInt16"] = "ushort";
		dictionary_0["System.Int32"] = "int";
		dictionary_0["System.UInt32"] = "uint";
		dictionary_0["System.Int64"] = "long";
		dictionary_0["System.UInt64"] = "ulong";
	}

	public static bool smethod_0(Exception exception_0, string string_10)
	{
		if (exception_0.Data["CO_StackFrameList"] == null)
		{
			smethod_32(exception_0, null);
		}
		try
		{
			using FileStream fileStream = new FileStream(string_10, FileMode.Create, FileAccess.Write);
			byte[] array = smethod_8(exception_0);
			fileStream.Write(array, 0, array.Length);
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_1(Exception exception_0)
	{
		if (exception_0.Data["CO_StackFrameList"] == null)
		{
			smethod_32(exception_0, null);
		}
		return smethod_11(exception_0);
	}

	public static void smethod_2(Exception exception_0, string string_10, string string_11)
	{
		try
		{
			Dictionary<string, string> dictionary = exception_0.Data["CO_CustomData"] as Dictionary<string, string>;
			if (dictionary == null)
			{
				dictionary = new Dictionary<string, string>();
				exception_0.Data["CO_CustomData"] = dictionary;
			}
			dictionary[string_10] = string_11;
		}
		catch
		{
		}
	}

	public static void smethod_3(Exception exception_0, string string_10, Image image_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		ImageFormat val = image_0.get_RawFormat();
		if (((object)val).Equals((object?)ImageFormat.get_MemoryBmp()))
		{
			val = ImageFormat.get_Png();
		}
		image_0.Save((Stream)memoryStream, val);
		memoryStream.Position = 0L;
		smethod_5(exception_0, string_10, memoryStream);
	}

	public static void smethod_4(Exception exception_0, string string_10, string string_11)
	{
		using FileStream stream_ = File.OpenRead(string_11);
		smethod_5(exception_0, string_10, stream_);
	}

	public static void smethod_5(Exception exception_0, string string_10, Stream stream_0)
	{
		byte[] array = new byte[stream_0.Length];
		stream_0.Read(array, 0, (int)stream_0.Length);
		smethod_6(exception_0, string_10, array);
	}

	public static void smethod_6(Exception exception_0, string string_10, byte[] byte_0)
	{
		try
		{
			Dictionary<string, Class8> dictionary = exception_0.Data["CO_BinaryData"] as Dictionary<string, Class8>;
			if (dictionary == null)
			{
				dictionary = new Dictionary<string, Class8>();
				exception_0.Data["CO_BinaryData"] = dictionary;
			}
			dictionary[string_10] = new Class8(byte_0);
		}
		catch
		{
		}
	}

	public static void smethod_7(EventArgs0 eventArgs0_0)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (eventArgs0_0.exception_0.Data["CO_StackFrameList"] == null)
			{
				smethod_32(eventArgs0_0.exception_0, null);
			}
			ExceptionReportingConsentForm exceptionReportingConsentForm = new ExceptionReportingConsentForm();
			try
			{
				exceptionReportingConsentForm.eventArgs0_0 = eventArgs0_0;
				((Form)exceptionReportingConsentForm).ShowDialog();
			}
			finally
			{
				((IDisposable)(object)exceptionReportingConsentForm)?.Dispose();
			}
		}
		catch
		{
		}
	}

	public static byte[] smethod_8(Exception exception_0)
	{
		if (exception_0.Data["CO_StackFrameList"] == null)
		{
			smethod_32(exception_0, null);
		}
		MemoryStream memoryStream = new MemoryStream();
		Stream stream = memoryStream;
		smethod_12(memoryStream);
		DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress, leaveOpen: true);
		stream = deflateStream;
		XmlWriter xmlWriter = new XmlTextWriter(stream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		xmlWriter.WriteStartDocument();
		using (Class14.smethod_0(xmlWriter, "Report"))
		{
			xmlWriter.WriteAttributeString("Time", DateTime.UtcNow.Ticks.ToString());
			xmlWriter.WriteAttributeString("BuildID", string_4);
			xmlWriter.WriteAttributeString("BuildTime", string_5);
			xmlWriter.WriteAttributeString("ProjectID", string_3);
			xmlWriter.WriteAttributeString("UserEmail", string_2);
			smethod_33("Exception", exception_0, xmlWriter);
			smethod_41(exception_0, xmlWriter);
			smethod_42(exception_0, xmlWriter);
			smethod_37(xmlWriter);
			try
			{
				smethod_38(xmlWriter);
			}
			catch
			{
			}
			smethod_36(xmlWriter, exception_0);
		}
		xmlWriter.Flush();
		xmlWriter.Close();
		return memoryStream.ToArray();
	}

	[SecuritySafeCritical]
	public static void smethod_9()
	{
		try
		{
			smethod_15();
			AppDomain.CurrentDomain.UnhandledException += smethod_17;
			Application.add_ThreadException((ThreadExceptionEventHandler)smethod_16);
		}
		catch
		{
		}
	}

	public static void smethod_10(Exception exception_0)
	{
		if (exception_0 == null || exception_0.Data["CO_Handled"] != null)
		{
			return;
		}
		exception_0.Data["CO_Handled"] = true;
		if (exception_0.Data["CO_StackFrameList"] == null)
		{
			smethod_32(exception_0, null);
		}
		if ((exception_0 is SecurityException && smethod_18(exception_0 as SecurityException)) || exception_0 is ThreadAbortException)
		{
			return;
		}
		try
		{
			EventArgs0 eventArgs = new EventArgs0();
			eventArgs.exception_0 = exception_0;
			eventArgs.bool_0 = true;
			eventArgs.Boolean_3 = bool_0;
			eventArgs.Boolean_4 = bool_1;
			eventArgs.string_0 = exception_0.Message;
			if (delegate0_0 != null)
			{
				delegate0_0(null, eventArgs);
			}
			if (!eventArgs.Boolean_2)
			{
				smethod_19(eventArgs);
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception)
		{
		}
	}

	private static bool smethod_11(Exception exception_0)
	{
		Exception exception_ = null;
		bool result = false;
		try
		{
			byte[] inArray = smethod_8(exception_0);
			smethod_71(string_9, "UploadReport", new string[2] { "data", "projectid" }, new string[2]
			{
				Convert.ToBase64String(inArray),
				string_3
			}, exception_0);
			result = true;
		}
		catch (Exception ex)
		{
			exception_ = ex;
		}
		if (delegate2_0 != null)
		{
			EventArgs2 e = new EventArgs2(result, exception_);
			delegate2_0(null, e);
		}
		return result;
	}

	private static void smethod_12(MemoryStream memoryStream_0)
	{
		byte[] bytes = BitConverter.GetBytes(2u);
		memoryStream_0.Write(bytes, 0, bytes.Length);
	}

	internal static void smethod_13(Exception exception_0, bool bool_5)
	{
		if (exception_0 == null || exception_0.Data["CO_Handled"] != null)
		{
			return;
		}
		exception_0.Data["CO_Handled"] = true;
		bool flag = true;
		if (exception_0 is ThreadAbortException)
		{
			return;
		}
		try
		{
			EventArgs0 eventArgs = new EventArgs0();
			eventArgs.exception_0 = exception_0;
			eventArgs.bool_0 = bool_5;
			eventArgs.Boolean_3 = bool_0;
			eventArgs.Boolean_4 = bool_1;
			eventArgs.string_0 = exception_0.Message;
			if (!bool_5)
			{
				eventArgs.Boolean_1 = false;
			}
			else if (bool_3)
			{
				eventArgs.Boolean_1 = true;
			}
			if (delegate0_0 != null)
			{
				delegate0_0(null, eventArgs);
			}
			if (!eventArgs.Boolean_2)
			{
				smethod_19(eventArgs);
			}
			flag = !eventArgs.Boolean_1;
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception)
		{
		}
		if (flag)
		{
			smethod_14();
		}
	}

	private static void smethod_14()
	{
		try
		{
			try
			{
				Application.Exit();
			}
			catch
			{
			}
			try
			{
				Environment.Exit(0);
			}
			catch
			{
			}
		}
		catch
		{
		}
	}

	internal static void smethod_15()
	{
		string_3 = "{e5faaaa3-b9af-4917-8b93-10e8c02956a3}";
		string_9 = "ssware.com";
		bool_3 = false;
		string_4 = "";
		string_5 = "635388901815572246";
		string_1 = "";
		string_0 = "";
		bool_4 = false;
		string_6 = "Patch";
		bool_0 = false;
		bool_1 = false;
		string_7 = "A";
		bool_2 = true;
	}

	internal static void smethod_16(object sender, ThreadExceptionEventArgs e)
	{
		try
		{
			Exception exception = e.Exception;
			if (!(exception is SecurityException) || !smethod_18(exception as SecurityException))
			{
				smethod_13(exception, bool_5: true);
			}
		}
		catch
		{
		}
	}

	internal static void smethod_17(object sender, UnhandledExceptionEventArgs e)
	{
		try
		{
			if ((!(e.ExceptionObject is SecurityException) || !smethod_18(e.ExceptionObject as SecurityException)) && e.ExceptionObject is Exception)
			{
				smethod_13((Exception)e.ExceptionObject, !e.IsTerminating);
			}
		}
		catch
		{
		}
	}

	internal static bool smethod_18(SecurityException securityException_0)
	{
		return false;
	}

	internal static void smethod_19(EventArgs0 eventArgs0_0)
	{
		if (bool_4)
		{
			smethod_7(eventArgs0_0);
		}
		else
		{
			smethod_1(eventArgs0_0.Exception_0);
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_20(Exception exception_0)
	{
		smethod_31(exception_0, null);
	}

	[SecuritySafeCritical]
	internal static void smethod_21(Exception exception_0, object object_0)
	{
		smethod_31(exception_0, new object[1] { object_0 });
	}

	[SecuritySafeCritical]
	internal static void smethod_22(Exception exception_0, object object_0, object object_1)
	{
		smethod_31(exception_0, new object[2] { object_0, object_1 });
	}

	[SecuritySafeCritical]
	internal static void smethod_23(Exception exception_0, object object_0, object object_1, object object_2)
	{
		smethod_31(exception_0, new object[3] { object_0, object_1, object_2 });
	}

	[SecuritySafeCritical]
	internal static void smethod_24(Exception exception_0, object object_0, object object_1, object object_2, object object_3)
	{
		smethod_31(exception_0, new object[4] { object_0, object_1, object_2, object_3 });
	}

	[SecuritySafeCritical]
	internal static void smethod_25(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		smethod_31(exception_0, new object[5] { object_0, object_1, object_2, object_3, object_4 });
	}

	[SecuritySafeCritical]
	internal static void smethod_26(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		smethod_31(exception_0, new object[6] { object_0, object_1, object_2, object_3, object_4, object_5 });
	}

	[SecuritySafeCritical]
	internal static void smethod_27(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		smethod_31(exception_0, new object[7] { object_0, object_1, object_2, object_3, object_4, object_5, object_6 });
	}

	[SecuritySafeCritical]
	internal static void smethod_28(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		smethod_31(exception_0, new object[8] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7 });
	}

	[SecuritySafeCritical]
	internal static void smethod_29(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8)
	{
		smethod_31(exception_0, new object[9] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8 });
	}

	[SecuritySafeCritical]
	internal static void smethod_30(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9)
	{
		smethod_31(exception_0, new object[10] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9 });
	}

	[SecuritySafeCritical]
	internal static void smethod_31(Exception exception_0, object[] object_0)
	{
		smethod_32(exception_0, object_0);
	}

	[SecuritySafeCritical]
	internal static void smethod_32(Exception exception_0, object[] object_0)
	{
		Type typeFromHandle = typeof(Class9);
		Dictionary<StackFrame, object[]> dictionary = null;
		StackTrace stackTrace = new StackTrace(fNeedFileInfo: true);
		List<Class3> list = null;
		list = exception_0.Data["CO_StackFrameList"] as List<Class3>;
		if (list == null)
		{
			list = new List<Class3>();
			exception_0.Data["CO_StackFrameList"] = list;
			StackTrace stackTrace2 = new StackTrace(exception_0, fNeedFileInfo: true);
			int i;
			for (i = 0; i < stackTrace2.FrameCount; i++)
			{
				StackFrame frame = stackTrace2.GetFrame(i);
				MethodBase method = frame.GetMethod();
				if (!method.Name.EndsWith("_Encrypted$"))
				{
					if ((object)method.DeclaringType == null || method.DeclaringType!.Equals(typeFromHandle))
					{
						continue;
					}
					Type baseType = method.DeclaringType!.BaseType;
					if ((object)baseType == null || (method.IsStatic && baseType.FullName == "System.MulticastDelegate"))
					{
						continue;
					}
				}
				list.Add(new Class3(frame, bool_1: true));
			}
			for (i = 0; i < stackTrace.FrameCount; i++)
			{
				StackFrame frame2 = stackTrace.GetFrame(i);
				MethodBase method2 = frame2.GetMethod();
				if (!method2.Name.EndsWith("_Encrypted$"))
				{
					if ((object)method2.DeclaringType == null || method2.DeclaringType!.Equals(typeFromHandle))
					{
						continue;
					}
					Type baseType2 = method2.DeclaringType!.BaseType;
					if ((object)baseType2 == null || (method2.IsStatic && baseType2.FullName == "System.MulticastDelegate"))
					{
						continue;
					}
				}
				if (list.Count > 0 && Class11.smethod_1(frame2, list[list.Count - 1].stackFrame_0))
				{
					break;
				}
			}
			for (i++; i < stackTrace.FrameCount; i++)
			{
				StackFrame frame3 = stackTrace.GetFrame(i);
				MethodBase method3 = frame3.GetMethod();
				if ((object)method3.DeclaringType != null && !method3.DeclaringType!.Equals(typeFromHandle))
				{
					Type baseType3 = method3.DeclaringType!.BaseType;
					if ((object)baseType3 != null && (!method3.IsStatic || !(baseType3.FullName == "System.MulticastDelegate")))
					{
						list.Add(new Class3(frame3, bool_1: false));
					}
				}
			}
			if (exception_0.InnerException != null && exception_0.InnerException!.Data["CO_StackFrameList"] == null)
			{
				smethod_32(exception_0.InnerException, null);
			}
		}
		exception_0.Data["CO_IsInner"] = false;
		for (Exception innerException = exception_0.InnerException; innerException != null; innerException = innerException.InnerException)
		{
			innerException.Data["CO_IsInner"] = true;
		}
		dictionary = exception_0.Data["CO_MapStackFrameArgs"] as Dictionary<StackFrame, object[]>;
		if (dictionary == null)
		{
			dictionary = new Dictionary<StackFrame, object[]>(new Class11());
			exception_0.Data["CO_MapStackFrameArgs"] = dictionary;
		}
		int num = 0;
		StackFrame frame4;
		while (true)
		{
			if (num < stackTrace.FrameCount)
			{
				frame4 = stackTrace.GetFrame(num);
				MethodBase method4 = frame4.GetMethod();
				if ((object)method4.DeclaringType != null && !method4.DeclaringType!.Equals(typeFromHandle))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		dictionary[frame4] = object_0;
	}

	internal static void smethod_33(string string_10, Exception exception_0, XmlWriter xmlWriter_0)
	{
		if (exception_0 == null)
		{
			return;
		}
		using (Class14.smethod_0(xmlWriter_0, string_10))
		{
			xmlWriter_0.WriteAttributeString("Type", smethod_58(exception_0.GetType()));
			xmlWriter_0.WriteAttributeString("Message", exception_0.Message);
			xmlWriter_0.WriteAttributeString("Source", exception_0.Source);
			xmlWriter_0.WriteAttributeString("HelpLink", exception_0.HelpLink);
			smethod_51(xmlWriter_0, exception_0, exception_0.GetType(), BindingFlags.Instance | BindingFlags.Public);
			smethod_52(xmlWriter_0, exception_0);
			smethod_44(exception_0, xmlWriter_0);
			smethod_33("InnerException", exception_0.InnerException, xmlWriter_0);
		}
	}

	public static bool smethod_34()
	{
		try
		{
			if (IntPtr.Size == 8)
			{
				return true;
			}
			bool bool_;
			return smethod_35("kernel32.dll", "IsWow64Process") && IsWow64Process(GetCurrentProcess(), out bool_) && bool_;
		}
		catch
		{
		}
		return IntPtr.Size == 8;
	}

	private static bool smethod_35(string string_10, string string_11)
	{
		try
		{
			IntPtr moduleHandle = GetModuleHandle(string_10);
			if (moduleHandle == IntPtr.Zero)
			{
				return false;
			}
			return GetProcAddress(moduleHandle, string_11) != IntPtr.Zero;
		}
		catch
		{
		}
		return false;
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr GetModuleHandle(string string_10);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPStr)] string string_10);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWow64Process(IntPtr intptr_0, out bool bool_5);

	internal static void smethod_36(XmlWriter xmlWriter_0, Exception exception_0)
	{
		try
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			OperatingSystem oSVersion = Environment.OSVersion;
			dictionary["PlatformID"] = oSVersion.Platform.ToString();
			dictionary["OSVersion"] = oSVersion.Version.ToString();
			dictionary["NumProcessors"] = Environment.ProcessorCount.ToString();
			try
			{
				dictionary["CurrentDir"] = Environment.CurrentDirectory;
			}
			catch
			{
			}
			try
			{
				dictionary["ServicePack"] = oSVersion.ServicePack.ToString();
			}
			catch
			{
			}
			try
			{
				dictionary["SystemDir"] = Environment.SystemDirectory;
			}
			catch
			{
			}
			try
			{
				dictionary["Name"] = Environment.UserName;
			}
			catch
			{
			}
			try
			{
				dictionary["UserDomain"] = Environment.UserDomainName;
			}
			catch
			{
			}
			try
			{
				Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
				string text2 = (dictionary["ScreenResolution"] = bounds.Width + " x " + bounds.Height);
			}
			catch
			{
			}
			dictionary["CLRVersion"] = Environment.Version.ToString();
			dictionary["Is64BitProcess"] = ((IntPtr.Size == 8) ? "Yes" : "No");
			try
			{
				dictionary["Is64BitPlatform"] = (smethod_34() ? "Yes" : "No");
			}
			catch
			{
			}
			if (delegate3_0 != null)
			{
				EventArgs3 e = new EventArgs3(dictionary, exception_0);
				delegate3_0(null, e);
			}
			if (dictionary.Count <= 0)
			{
				return;
			}
			using (Class14.smethod_0(xmlWriter_0, "SysInfo"))
			{
				foreach (KeyValuePair<string, string> item in dictionary)
				{
					xmlWriter_0.WriteAttributeString(item.Key, item.Value);
				}
			}
		}
		catch
		{
		}
	}

	internal static void smethod_37(XmlWriter xmlWriter_0)
	{
		try
		{
			Assembly[] array = smethod_40();
			if (array == null || array.Length <= 0)
			{
				return;
			}
			Array.Sort(array, new Class12());
			Assembly[] array2 = array;
			foreach (Assembly assembly in array2)
			{
				using (Class14.smethod_0(xmlWriter_0, "Assembly"))
				{
					xmlWriter_0.WriteAttributeString("Name", assembly.FullName);
					xmlWriter_0.WriteAttributeString("Codebase", assembly.CodeBase);
				}
			}
		}
		catch
		{
		}
	}

	internal static void smethod_38(XmlWriter xmlWriter_0)
	{
		try
		{
			smethod_39(xmlWriter_0);
		}
		catch
		{
		}
	}

	internal static void smethod_39(XmlWriter xmlWriter_0)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			if (processes == null || processes.Length <= 0)
			{
				return;
			}
			Array.Sort(processes, new Class13());
			using (Class14.smethod_0(xmlWriter_0, "Processes"))
			{
				Process[] array = processes;
				foreach (Process process in array)
				{
					using (Class14.smethod_0(xmlWriter_0, "Process"))
					{
						try
						{
							xmlWriter_0.WriteAttributeString("Name", process.ProcessName);
						}
						catch
						{
						}
						try
						{
							xmlWriter_0.WriteAttributeString("ID", process.Id.ToString());
						}
						catch
						{
						}
						try
						{
							xmlWriter_0.WriteAttributeString("FileName", process.MainModule!.FileName);
						}
						catch
						{
						}
						try
						{
							xmlWriter_0.WriteAttributeString("Threads", process.Threads.Count.ToString());
						}
						catch
						{
						}
					}
				}
			}
		}
		catch
		{
		}
	}

	internal static Assembly[] smethod_40()
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
		}
		return new Assembly[1] { Assembly.GetExecutingAssembly() };
	}

	internal static void smethod_41(Exception exception_0, XmlWriter xmlWriter_0)
	{
		try
		{
			if (!(exception_0.Data["CO_CustomData"] is Dictionary<string, string> dictionary))
			{
				return;
			}
			foreach (KeyValuePair<string, string> item in dictionary)
			{
				using (Class14.smethod_0(xmlWriter_0, "CustomData"))
				{
					xmlWriter_0.WriteAttributeString("Name", item.Key);
					xmlWriter_0.WriteAttributeString("Value", item.Value);
				}
			}
		}
		catch
		{
		}
	}

	internal static void smethod_42(Exception exception_0, XmlWriter xmlWriter_0)
	{
		try
		{
			if (!(exception_0.Data["CO_BinaryData"] is Dictionary<string, Class8> dictionary))
			{
				return;
			}
			foreach (KeyValuePair<string, Class8> item in dictionary)
			{
				using (Class14.smethod_0(xmlWriter_0, "BinaryData"))
				{
					xmlWriter_0.WriteAttributeString("Name", item.Key);
					if (item.Value.byte_0 != null && item.Value.byte_0.Length > 0)
					{
						xmlWriter_0.WriteString(Convert.ToBase64String(item.Value.byte_0));
					}
				}
			}
		}
		catch
		{
		}
	}

	internal static bool smethod_43(MethodBase methodBase_0)
	{
		return methodBase_0.GetType().FullName == "System.Reflection.Emit.DynamicMethod+RTDynamicMethod";
	}

	internal static void smethod_44(Exception exception_0, XmlWriter xmlWriter_0)
	{
		_ = (bool)exception_0.Data["CO_IsInner"];
		try
		{
			using (Class14.smethod_0(xmlWriter_0, "StackTrace"))
			{
				if (!(exception_0.Data["CO_StackFrameList"] is List<Class3> list))
				{
					return;
				}
				foreach (Class3 item in list)
				{
					if (!smethod_43(item.stackFrame_0.GetMethod()))
					{
						smethod_46(exception_0, xmlWriter_0, item.stackFrame_0, item.bool_0);
					}
				}
			}
		}
		catch
		{
		}
	}

	internal static string smethod_45(Assembly assembly_0)
	{
		string text = assembly_0.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	internal static void smethod_46(Exception exception_0, XmlWriter xmlWriter_0, StackFrame stackFrame_0, bool bool_5)
	{
		try
		{
			using (Class14.smethod_0(xmlWriter_0, "StackFrame"))
			{
				MethodBase method = stackFrame_0.GetMethod();
				xmlWriter_0.WriteAttributeString("Signature", smethod_55(method));
				xmlWriter_0.WriteAttributeString("Assembly", smethod_45(method.DeclaringType!.Assembly));
				xmlWriter_0.WriteAttributeString("Type", smethod_57(method.DeclaringType));
				xmlWriter_0.WriteAttributeString("File", "%dn:" + stackFrame_0.GetFileName() + "%");
				xmlWriter_0.WriteAttributeString("Line", stackFrame_0.GetFileLineNumber().ToString());
				xmlWriter_0.WriteAttributeString("Column", stackFrame_0.GetFileColumnNumber().ToString());
				smethod_47(exception_0, xmlWriter_0, stackFrame_0);
			}
		}
		catch
		{
		}
	}

	internal static void smethod_47(Exception exception_0, XmlWriter xmlWriter_0, StackFrame stackFrame_0)
	{
		try
		{
			if (exception_0.Data["CO_MapStackFrameArgs"] is Dictionary<StackFrame, object[]> dictionary && dictionary.TryGetValue(stackFrame_0, out var value) && value != null)
			{
				for (int i = 0; i < value.Length; i++)
				{
					smethod_48(xmlWriter_0, value[i], null, smethod_61(stackFrame_0.GetMethod(), i), bool_5: true);
				}
			}
		}
		catch
		{
		}
	}

	internal static void smethod_48(XmlWriter xmlWriter_0, object object_0, Type type_0, string string_10, bool bool_5)
	{
		try
		{
			using (Class14.smethod_0(xmlWriter_0, "Variable"))
			{
				if ((object)type_0 == null && object_0 != null)
				{
					type_0 = object_0.GetType();
				}
				bool flag = false;
				IList list = null;
				string text = null;
				if (object_0 == null)
				{
					text = "null";
				}
				else if (!type_0.IsPrimitive && !(object_0 is IntPtr) && !(object_0 is UIntPtr))
				{
					if (type_0.IsArray)
					{
						list = object_0 as IList;
						text = "Count=" + list.Count;
					}
					else if (object_0 is string)
					{
						text = object_0 as string;
					}
					else
					{
						text = object_0.ToString();
						flag = true;
					}
				}
				else
				{
					text = smethod_53(object_0);
				}
				string text2 = null;
				if ((object)type_0 != null)
				{
					text2 = type_0.FullName;
				}
				if (text2 != text)
				{
					xmlWriter_0.WriteAttributeString("Value", text);
				}
				if ((object)type_0 != null)
				{
					xmlWriter_0.WriteAttributeString("Type", smethod_57(type_0));
				}
				if (!string.IsNullOrEmpty(string_10))
				{
					xmlWriter_0.WriteAttributeString("Name", string_10);
				}
				if (list != null)
				{
					smethod_49(xmlWriter_0, list, null);
				}
				if (flag && bool_5)
				{
					smethod_50(xmlWriter_0, object_0, type_0, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
					smethod_50(xmlWriter_0, object_0, type_0, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic);
				}
			}
		}
		catch
		{
		}
	}

	internal static void smethod_49(XmlWriter xmlWriter_0, IList ilist_0, Type type_0)
	{
		try
		{
			int num = Math.Min(ilist_0.Count, 10);
			for (int i = 0; i < num; i++)
			{
				try
				{
					smethod_48(xmlWriter_0, ilist_0[i], null, "[" + i + "]", bool_5: false);
				}
				catch
				{
				}
			}
			if (num < ilist_0.Count)
			{
				string text = ilist_0.Count - num + " more";
				smethod_48(xmlWriter_0, text, null, text, bool_5: false);
			}
		}
		catch
		{
		}
	}

	internal static void smethod_50(XmlWriter xmlWriter_0, object object_0, Type type_0, BindingFlags bindingFlags_0)
	{
		try
		{
			FieldInfo[] fields = type_0.GetFields(bindingFlags_0);
			FieldInfo[] array = fields;
			foreach (FieldInfo fieldInfo in array)
			{
				try
				{
					smethod_48(xmlWriter_0, fieldInfo.GetValue(object_0), fieldInfo.FieldType, smethod_60(fieldInfo), bool_5: false);
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

	internal static void smethod_51(XmlWriter xmlWriter_0, object object_0, Type type_0, BindingFlags bindingFlags_0)
	{
		try
		{
			PropertyInfo[] properties = type_0.GetProperties(bindingFlags_0);
			PropertyInfo[] array = properties;
			foreach (PropertyInfo propertyInfo in array)
			{
				try
				{
					MethodInfo getMethod = propertyInfo.GetGetMethod();
					if ((object)getMethod != null)
					{
						string text = smethod_59(getMethod);
						if (!dictionary_1.ContainsKey(text))
						{
							smethod_48(xmlWriter_0, propertyInfo.GetValue(object_0, null), propertyInfo.PropertyType, text, bool_5: false);
						}
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

	internal static void smethod_52(XmlWriter xmlWriter_0, Exception exception_0)
	{
		try
		{
			foreach (DictionaryEntry datum in exception_0.Data)
			{
				try
				{
					if (!(datum.Key is string text) || !text.StartsWith("CO_"))
					{
						smethod_48(xmlWriter_0, datum.Value, null, datum.Key.ToString(), bool_5: false);
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

	internal static string smethod_53(object object_0)
	{
		try
		{
			if (!(object_0 is bool flag))
			{
				if (!(object_0 is float) && !(object_0 is double))
				{
					StringBuilder stringBuilder = new StringBuilder();
					if (object_0 is int num)
					{
						if (num >= 32)
						{
							stringBuilder.Append('\'');
							stringBuilder.Append((char)object_0);
							stringBuilder.Append("' ");
						}
						stringBuilder.Append("(0x");
						stringBuilder.Append(num.ToString("x"));
						stringBuilder.Append(')');
						return stringBuilder.ToString();
					}
					stringBuilder.Append(object_0.ToString());
					stringBuilder.Append(" (0x");
					if (object_0 is int num2)
					{
						stringBuilder.Append(num2.ToString("x"));
					}
					if (object_0 is long num3)
					{
						stringBuilder.Append(num3.ToString("x"));
					}
					if (object_0 is short num4)
					{
						stringBuilder.Append(num4.ToString("x"));
					}
					if (object_0 is uint num5)
					{
						stringBuilder.Append(num5.ToString("x"));
					}
					if (object_0 is ulong num6)
					{
						stringBuilder.Append(num6.ToString("x"));
					}
					if (object_0 is ushort num7)
					{
						stringBuilder.Append(num7.ToString("x"));
					}
					if (object_0 is byte b)
					{
						stringBuilder.Append(b.ToString("x"));
					}
					if (object_0 is sbyte b2)
					{
						stringBuilder.Append(b2.ToString("x"));
					}
					if (object_0 is IntPtr intPtr)
					{
						stringBuilder.Append(intPtr.ToInt64().ToString("x"));
					}
					if (object_0 is UIntPtr uIntPtr)
					{
						stringBuilder.Append(uIntPtr.ToUInt64().ToString("x"));
					}
					stringBuilder.Append(')');
					return stringBuilder.ToString();
				}
				return object_0.ToString();
			}
			return flag.ToString().ToLower();
		}
		catch
		{
		}
		return string.Empty;
	}

	internal static bool smethod_54(MethodBase methodBase_0)
	{
		if (methodBase_0.IsGenericMethod)
		{
			return !methodBase_0.IsGenericMethodDefinition;
		}
		return false;
	}

	internal static string smethod_55(MethodBase methodBase_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (methodBase_0 is MethodInfo methodInfo)
		{
			stringBuilder.Append(smethod_57(methodInfo.ReturnType));
			stringBuilder.Append(' ');
		}
		stringBuilder.Append(smethod_59(methodBase_0));
		if (smethod_54(methodBase_0))
		{
			stringBuilder.Append("<");
			Type[] genericArguments = methodBase_0.GetGenericArguments();
			for (int i = 0; i < genericArguments.Length; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(",");
				}
				stringBuilder.Append(smethod_57(genericArguments[i]));
			}
			stringBuilder.Append(">");
		}
		stringBuilder.Append("(");
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		for (int i = 0; i < parameters.Length; i++)
		{
			if (i > 0)
			{
				stringBuilder.Append(",");
			}
			stringBuilder.Append(smethod_57(parameters[i].ParameterType));
			stringBuilder.Append(" ");
			stringBuilder.Append(smethod_61(methodBase_0, i + ((!methodBase_0.IsStatic) ? 1 : 0)));
		}
		stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	internal static bool smethod_56(Type type_0)
	{
		if (type_0.IsGenericType)
		{
			return !type_0.IsGenericTypeDefinition;
		}
		return false;
	}

	internal static string smethod_57(Type type_0)
	{
		if (type_0.HasElementType)
		{
			if (type_0.IsPointer)
			{
				return smethod_57(type_0.GetElementType()) + "*";
			}
			if (type_0.IsArray)
			{
				int arrayRank = type_0.GetArrayRank();
				if (arrayRank == 1)
				{
					return smethod_57(type_0.GetElementType()) + "[]";
				}
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append('[');
				for (int i = 1; i < arrayRank; i++)
				{
					stringBuilder.Append(',');
				}
				stringBuilder.Append(']');
				return smethod_57(type_0.GetElementType()) + stringBuilder.ToString();
			}
			if (type_0.IsByRef)
			{
				return smethod_57(type_0.GetElementType()) + "&";
			}
		}
		if (smethod_56(type_0))
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(smethod_57(type_0.GetGenericTypeDefinition()));
			stringBuilder.Append("<");
			Type[] genericArguments = type_0.GetGenericArguments();
			for (int i = 0; i < genericArguments.Length; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(",");
				}
				stringBuilder.Append(smethod_57(genericArguments[i]));
			}
			stringBuilder.Append(">");
			return stringBuilder.ToString();
		}
		if (type_0.IsGenericParameter)
		{
			return type_0.Name;
		}
		return smethod_58(type_0);
	}

	internal static string smethod_58(Type type_0)
	{
		if (smethod_62(type_0))
		{
			return "%tfn:" + smethod_45(type_0.Assembly) + "|" + type_0.MetadataToken + "%";
		}
		string text = null;
		text = (((object)type_0.DeclaringType != null) ? (type_0.DeclaringType!.FullName + "/" + type_0.Name) : ((type_0.Namespace == null || type_0.Namespace!.Length == 0) ? type_0.Name : (type_0.Namespace + "." + type_0.Name)));
		if (dictionary_0.TryGetValue(text, out var value))
		{
			return value;
		}
		return text;
	}

	internal static string smethod_59(MethodBase methodBase_0)
	{
		if (smethod_62(methodBase_0.DeclaringType))
		{
			return "%mn:" + smethod_45(methodBase_0.DeclaringType!.Assembly) + "|" + methodBase_0.MetadataToken + "%";
		}
		return methodBase_0.Name;
	}

	internal static string smethod_60(FieldInfo fieldInfo_0)
	{
		if (smethod_62(fieldInfo_0.DeclaringType))
		{
			return "%fn:" + smethod_45(fieldInfo_0.DeclaringType!.Assembly) + "|" + fieldInfo_0.MetadataToken + "%";
		}
		return fieldInfo_0.Name;
	}

	internal static string smethod_61(MethodBase methodBase_0, int int_0)
	{
		return "%vn:" + smethod_45(methodBase_0.DeclaringType!.Assembly) + "|" + methodBase_0.MetadataToken + "|" + int_0.ToString() + "%";
	}

	internal static bool smethod_62(Type type_0)
	{
		string fullName = type_0.Assembly.FullName;
		if (!dictionary_2.TryGetValue(fullName, out var value))
		{
			object[] customAttributes = type_0.Assembly.GetCustomAttributes(inherit: false);
			int num = 0;
			while (true)
			{
				if (num < customAttributes.Length)
				{
					object obj = customAttributes[num];
					if (obj.GetType().FullName == string_7 + ".AssemblyInfoAttribute")
					{
						break;
					}
					num++;
					continue;
				}
				dictionary_2[fullName] = false;
				return false;
			}
			dictionary_2[fullName] = true;
			return true;
		}
		return value;
	}

	internal static string smethod_63(string string_10, string string_11)
	{
		string text = string_10;
		if (text.EndsWith("/"))
		{
			return text + string_11;
		}
		return text + "/" + string_11;
	}

	internal static string smethod_64(string[] string_10, string[] string_11)
	{
		string empty = string.Empty;
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			for (int i = 0; i < string_10.Length; i++)
			{
				if (!string.IsNullOrEmpty(string_10[i]))
				{
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append("&");
					}
					stringBuilder.Append(string_10[i]);
					stringBuilder.Append("=");
					stringBuilder.Append(smethod_65(string_11[i]));
				}
			}
			return stringBuilder.ToString();
		}
		catch
		{
			return string.Empty;
		}
	}

	internal static string smethod_65(string string_10)
	{
		if (string_10 == null)
		{
			return null;
		}
		return smethod_66(string_10, Encoding.UTF8);
	}

	internal static string smethod_66(string string_10, Encoding encoding_0)
	{
		if (string_10 == null)
		{
			return null;
		}
		byte[] array = smethod_67(string_10, encoding_0);
		return Encoding.ASCII.GetString(array, 0, array.Length);
	}

	internal static byte[] smethod_67(string string_10, Encoding encoding_0)
	{
		if (string_10 == null)
		{
			return null;
		}
		byte[] bytes = encoding_0.GetBytes(string_10);
		return smethod_68(bytes, 0, bytes.Length, bool_5: false);
	}

	private static byte[] smethod_68(byte[] byte_0, int int_0, int int_1, bool bool_5)
	{
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < int_1; i++)
		{
			char c = (char)byte_0[int_0 + i];
			if (c == ' ')
			{
				num++;
			}
			else if (!smethod_70(c))
			{
				num2++;
			}
		}
		if (!bool_5 && num == 0 && num2 == 0)
		{
			return byte_0;
		}
		byte[] array = new byte[int_1 + num2 * 2];
		int num3 = 0;
		for (int j = 0; j < int_1; j++)
		{
			byte b = byte_0[int_0 + j];
			char c2 = (char)b;
			if (smethod_70(c2))
			{
				array[num3++] = b;
				continue;
			}
			if (c2 == ' ')
			{
				array[num3++] = 43;
				continue;
			}
			array[num3++] = 37;
			array[num3++] = (byte)smethod_69((b >> 4) & 0xF);
			array[num3++] = (byte)smethod_69(b & 0xF);
		}
		return array;
	}

	internal static char smethod_69(int int_0)
	{
		if (int_0 <= 9)
		{
			return (char)(int_0 + 48);
		}
		return (char)(int_0 - 10 + 97);
	}

	internal static bool smethod_70(char char_0)
	{
		if ((char_0 >= 'a' && char_0 <= 'z') || (char_0 >= 'A' && char_0 <= 'Z') || (char_0 >= '0' && char_0 <= '9'))
		{
			return true;
		}
		switch (char_0)
		{
		default:
			return false;
		case '!':
		case '\'':
		case '(':
		case ')':
		case '*':
		case '-':
		case '.':
		case '_':
			return true;
		}
	}

	internal static string smethod_71(string string_10, string string_11, string[] string_12, string[] string_13, Exception exception_0)
	{
		if (string_10 != null && string_10.Length != 0)
		{
			string requestUriString = smethod_63(string_10, string_11);
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
			if (delegate1_0 != null)
			{
				EventArgs1 e = new EventArgs1(httpWebRequest, exception_0);
				delegate1_0(null, e);
			}
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			string s = smethod_64(string_12, string_13);
			byte[] bytes = Encoding.ASCII.GetBytes(s);
			httpWebRequest.ContentLength = bytes.Length;
			if (bytes.Length > 0)
			{
				Stream requestStream = httpWebRequest.GetRequestStream();
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Close();
			}
			WebResponse response = httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(response.GetResponseStream());
			string text = streamReader.ReadToEnd();
			if (text.Length > 0)
			{
				try
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.LoadXml(text);
					return xmlDocument.DocumentElement!.InnerText;
				}
				catch
				{
					throw new Exception("Invalid response");
				}
			}
			return text;
		}
		throw new InvalidOperationException("Exception reporting service URL not specified.");
	}
}
