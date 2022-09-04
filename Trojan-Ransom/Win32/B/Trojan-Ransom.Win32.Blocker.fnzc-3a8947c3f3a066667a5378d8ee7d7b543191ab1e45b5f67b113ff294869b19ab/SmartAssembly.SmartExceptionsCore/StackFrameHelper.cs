using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class StackFrameHelper
{
	public const string DataEntryName = "SmartStackFrames";

	public static void CreateException0(Exception exception)
	{
		CreateExceptionN(exception, new object[0]);
	}

	public static void CreateException1(Exception exception, object o1)
	{
		CreateExceptionN(exception, new object[1] { o1 });
	}

	public static void CreateException2(Exception exception, object o1, object o2)
	{
		CreateExceptionN(exception, new object[2] { o1, o2 });
	}

	public static void CreateException3(Exception exception, object o1, object o2, object o3)
	{
		CreateExceptionN(exception, new object[3] { o1, o2, o3 });
	}

	public static void CreateException4(Exception exception, object o1, object o2, object o3, object o4)
	{
		CreateExceptionN(exception, new object[4] { o1, o2, o3, o4 });
	}

	public static void CreateException5(Exception exception, object o1, object o2, object o3, object o4, object o5)
	{
		CreateExceptionN(exception, new object[5] { o1, o2, o3, o4, o5 });
	}

	public static void CreateException6(Exception exception, object o1, object o2, object o3, object o4, object o5, object o6)
	{
		CreateExceptionN(exception, new object[6] { o1, o2, o3, o4, o5, o6 });
	}

	public static void CreateException7(Exception exception, object o1, object o2, object o3, object o4, object o5, object o6, object o7)
	{
		CreateExceptionN(exception, new object[7] { o1, o2, o3, o4, o5, o6, o7 });
	}

	public static void CreateException8(Exception exception, object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8)
	{
		CreateExceptionN(exception, new object[8] { o1, o2, o3, o4, o5, o6, o7, o8 });
	}

	public static void CreateException9(Exception exception, object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9)
	{
		CreateExceptionN(exception, new object[9] { o1, o2, o3, o4, o5, o6, o7, o8, o9 });
	}

	public static void CreateException10(Exception exception, object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10)
	{
		CreateExceptionN(exception, new object[10] { o1, o2, o3, o4, o5, o6, o7, o8, o9, o10 });
	}

	public static void CreateExceptionN(Exception caughtException, object[] objects)
	{
		int int_ = -1;
		int int_2 = -1;
		int num = 0;
		StackTrace stackTrace = new StackTrace(caughtException);
		try
		{
			if (SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_1(caughtException, 803, 874) != null)
			{
				string[] array = PoweredBy.smethod_2(SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_1(caughtException, 1006, 935), new char[2] { '\r', '\n' }, 7, 22);
				string[] array2 = array;
				foreach (string string_ in array2)
				{
					if (Class3.smethod_1(string_, 176, 216) > 0)
					{
						num++;
					}
				}
			}
		}
		catch
		{
			num = -1;
		}
		try
		{
			if (Win32.smethod_14(stackTrace, 173, 139) > 0)
			{
				StackFrame frame = stackTrace.GetFrame(Win32.smethod_14(stackTrace, 417, 391) - 1);
				int_ = (Class26.smethod_4(frame, 652, 677).MetadataToken & 0xFFFFFF) - 1;
				int_2 = Class21.smethod_7(frame, 87, 22);
			}
		}
		catch
		{
		}
		try
		{
			SmartStackFrame value = new SmartStackFrame(int_, objects, int_2, num);
			LinkedList<object> linkedList;
			if (!caughtException.Data.Contains("SmartStackFrames"))
			{
				linkedList = new LinkedList<object>();
				caughtException.Data["SmartStackFrames"] = linkedList;
			}
			else
			{
				linkedList = (LinkedList<object>)caughtException.Data["SmartStackFrames"];
			}
			linkedList.AddLast(value);
		}
		catch
		{
		}
	}

	[SecuritySafeCritical]
	static StackFrameHelper()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static void smethod_0(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 108:
				stream_0.Write(byte_0, int_0, int_1);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_1(Process process_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 54:
				return process_0.MainWindowTitle;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Type smethod_2(FieldInfo fieldInfo_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 64:
				return fieldInfo_0.FieldType;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_3(Array array_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 89:
				return array_0.GetValue(int_0);
			}
		}
	}
}
