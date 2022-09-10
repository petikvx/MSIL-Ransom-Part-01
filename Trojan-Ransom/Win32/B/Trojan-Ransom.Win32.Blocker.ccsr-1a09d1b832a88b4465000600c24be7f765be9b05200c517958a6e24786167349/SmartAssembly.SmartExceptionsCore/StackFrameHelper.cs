using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.Zip;
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
			if (Win32.smethod_10(caughtException, 698, 719) != null)
			{
				string[] array = WaitSendingReportControl.smethod_0(Win32.smethod_10(caughtException, 511, 394), new char[2] { '\r', '\n' }, 631, 558);
				string[] array2 = array;
				foreach (string string_ in array2)
				{
					if (PoweredBy.smethod_0(string_, 991, 911) > 0)
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
			if (stackTrace.FrameCount > 0)
			{
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int_ = (FeedbackControl.smethod_2(frame, 363, 310).MetadataToken & 0xFFFFFF) - 1;
				int_2 = PoweredBy.smethod_1(frame, 991, 902);
			}
		}
		catch
		{
		}
		try
		{
			SmartStackFrame value = new SmartStackFrame(int_, objects, int_2, num);
			LinkedList<object> linkedList;
			if (!Class30.smethod_0(caughtException, 766, 680).Contains("SmartStackFrames"))
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

	static StackFrameHelper()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static void smethod_0(AsymmetricAlgorithm asymmetricAlgorithm_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 23:
				asymmetricAlgorithm_0.FromXmlString(string_0);
				return;
			}
		}
	}

	internal static byte[] smethod_1(SymmetricAlgorithm symmetricAlgorithm_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 92:
				return symmetricAlgorithm_0.IV;
			}
		}
	}

	internal static string smethod_2(string string_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 119:
				return string_0.Remove(int_0);
			case 120:
				return string_0.Substring(int_0);
			}
		}
	}

	internal static void smethod_3(XmlWriter xmlWriter_0, string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 86:
				xmlWriter_0.WriteElementString(string_0, string_1);
				return;
			}
		}
	}

	internal static StringBuilder smethod_4(StringBuilder stringBuilder_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 86:
				return stringBuilder_0.Append(int_0);
			}
		}
	}
}
