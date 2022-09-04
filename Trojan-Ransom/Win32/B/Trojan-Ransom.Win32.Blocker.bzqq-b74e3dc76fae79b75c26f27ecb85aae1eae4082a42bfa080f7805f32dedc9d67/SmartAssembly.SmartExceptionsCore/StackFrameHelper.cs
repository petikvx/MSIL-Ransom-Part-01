using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Xml;
using SmartAssembly.Shared;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class StackFrameHelper
{
	public const string DataEntryName = "SmartStackFrames";

	public static void CreateException0(Exception exception)
	{
		try
		{
			CreateExceptionN(exception, new object[0]);
		}
		catch (Exception exception2)
		{
			CreateException1(exception2, exception);
			throw;
		}
	}

	public static void CreateException1(Exception exception, object o1)
	{
		object[] array = default(object[]);
		try
		{
			array = new object[1] { o1 };
			CreateExceptionN(exception, array);
		}
		catch (Exception exception2)
		{
			CreateException3(exception2, array, exception, o1);
			throw;
		}
	}

	public static void CreateException2(Exception exception, object o1, object o2)
	{
		object[] array = default(object[]);
		try
		{
			array = new object[2] { o1, o2 };
			CreateExceptionN(exception, array);
		}
		catch (Exception exception2)
		{
			CreateException4(exception2, array, exception, o1, o2);
			throw;
		}
	}

	public static void CreateException3(Exception exception, object o1, object o2, object o3)
	{
		object[] array = default(object[]);
		try
		{
			array = new object[3] { o1, o2, o3 };
			CreateExceptionN(exception, array);
		}
		catch (Exception exception2)
		{
			CreateException5(exception2, array, exception, o1, o2, o3);
			throw;
		}
	}

	public static void CreateException4(Exception exception, object o1, object o2, object o3, object o4)
	{
		object[] array = default(object[]);
		try
		{
			array = new object[4] { o1, o2, o3, o4 };
			CreateExceptionN(exception, array);
		}
		catch (Exception exception2)
		{
			CreateException6(exception2, array, exception, o1, o2, o3, o4);
			throw;
		}
	}

	public static void CreateException5(Exception exception, object o1, object o2, object o3, object o4, object o5)
	{
		object[] array = default(object[]);
		try
		{
			array = new object[5] { o1, o2, o3, o4, o5 };
			CreateExceptionN(exception, array);
		}
		catch (Exception exception2)
		{
			CreateException7(exception2, array, exception, o1, o2, o3, o4, o5);
			throw;
		}
	}

	public static void CreateException6(Exception exception, object o1, object o2, object o3, object o4, object o5, object o6)
	{
		object[] array = default(object[]);
		try
		{
			array = new object[6] { o1, o2, o3, o4, o5, o6 };
			CreateExceptionN(exception, array);
		}
		catch (Exception exception2)
		{
			CreateException8(exception2, array, exception, o1, o2, o3, o4, o5, o6);
			throw;
		}
	}

	public static void CreateException7(Exception exception, object o1, object o2, object o3, object o4, object o5, object o6, object o7)
	{
		object[] array = default(object[]);
		try
		{
			array = new object[7] { o1, o2, o3, o4, o5, o6, o7 };
			CreateExceptionN(exception, array);
		}
		catch (Exception exception2)
		{
			CreateException9(exception2, array, exception, o1, o2, o3, o4, o5, o6, o7);
			throw;
		}
	}

	public static void CreateException8(Exception exception, object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8)
	{
		object[] array = default(object[]);
		try
		{
			array = new object[8] { o1, o2, o3, o4, o5, o6, o7, o8 };
			CreateExceptionN(exception, array);
		}
		catch (Exception exception2)
		{
			CreateException10(exception2, array, exception, o1, o2, o3, o4, o5, o6, o7, o8);
			throw;
		}
	}

	public static void CreateException9(Exception exception, object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9)
	{
		object[] array = default(object[]);
		try
		{
			array = new object[9] { o1, o2, o3, o4, o5, o6, o7, o8, o9 };
			CreateExceptionN(exception, array);
		}
		catch (Exception caughtException)
		{
			CreateExceptionN(caughtException, new object[11]
			{
				array, exception, o1, o2, o3, o4, o5, o6, o7, o8,
				o9
			});
			throw;
		}
	}

	public static void CreateException10(Exception exception, object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10)
	{
		object[] array = default(object[]);
		try
		{
			array = new object[10] { o1, o2, o3, o4, o5, o6, o7, o8, o9, o10 };
			CreateExceptionN(exception, array);
		}
		catch (Exception caughtException)
		{
			CreateExceptionN(caughtException, new object[12]
			{
				array, exception, o1, o2, o3, o4, o5, o6, o7, o8,
				o9, o10
			});
			throw;
		}
	}

	public static void CreateExceptionN(Exception caughtException, object[] objects)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		StackTrace stackTrace = default(StackTrace);
		int num4 = default(int);
		char[] array = default(char[]);
		string[] array2 = default(string[]);
		string[] array3 = default(string[]);
		int num5 = default(int);
		string text = default(string);
		int num6 = default(int);
		StackFrame stackFrame = default(StackFrame);
		int num7 = default(int);
		SmartStackFrame smartStackFrame = default(SmartStackFrame);
		LinkedList<object> linkedList = default(LinkedList<object>);
		int num8 = default(int);
		try
		{
			num = -1;
			num2 = -1;
			num3 = 0;
			stackTrace = new StackTrace(caughtException);
			try
			{
				num4 = 10;
				if (Class36.smethod_8(caughtException, 900, 998) != null)
				{
					num4 = 6;
					string string_ = Class36.smethod_8(caughtException, 512, 610);
					array = new char[2] { '\r', '\n' };
					array2 = SendingReportFeedbackEventArgs1.smethod_2(string_, array, 31, 2);
					num4 = 7;
					array3 = array2;
					num5 = 0;
					num4 = 3;
					while (num5 < array3.Length)
					{
						num4 = 2;
						text = array3[num5];
						if (AppPathFinder.smethod_1(text, 940, 923) > 0)
						{
							num4 = 8;
							num3++;
							num4 = 5;
						}
						else
						{
							num4 = 5;
						}
						num5++;
						num4 = 3;
					}
					num4 = 1;
				}
				else
				{
					num4 = 1;
				}
			}
			catch
			{
				num3 = -1;
			}
			try
			{
				num6 = 3;
				if (Class40.smethod_3(stackTrace, 928, 943) > 0)
				{
					stackFrame = DoNotEncodeStringsAttribute.smethod_2(stackTrace, Class40.smethod_3(stackTrace, 882, 893) - 1, 266, 337);
					num6 = 1;
					num = (SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_0(DESCryptoIndirector.smethod_1(stackFrame, 295, 306), 949, 930) & 0xFFFFFF) - 1;
					num6 = 8;
					num2 = Class22.smethod_7(stackFrame, 1008, 952);
					num6 = 2;
				}
			}
			catch
			{
			}
			try
			{
				num7 = 4;
				smartStackFrame = new SmartStackFrame(num, objects, num2, num3);
				if (!Class23.smethod_1(caughtException, 620, 537).Contains("SmartStackFrames"))
				{
					linkedList = new LinkedList<object>();
					caughtException.Data["SmartStackFrames"] = linkedList;
					num7 = 7;
				}
				else
				{
					linkedList = (LinkedList<object>)caughtException.Data["SmartStackFrames"];
					num7 = 7;
				}
				linkedList.AddLast(smartStackFrame);
			}
			catch
			{
			}
			num8 = 0;
		}
		catch (Exception caughtException2)
		{
			CreateExceptionN(caughtException2, new object[18]
			{
				num, num2, num3, stackTrace, array2, text, stackFrame, smartStackFrame, linkedList, array,
				array3, num5, num4, num6, num7, num8, caughtException, objects
			});
			throw;
		}
	}

	public StackFrameHelper()
	{
		try
		{
		}
		catch (Exception exception)
		{
			CreateException1(exception, this);
			throw;
		}
	}

	static StackFrameHelper()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			CreateException0(exception);
			throw;
		}
	}

	internal static string[] smethod_0(string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 116:
					return Directory.GetDirectories(string_0);
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			CreateException4(exception, num, string_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_1(Graphics graphics_0, Image image_0, Rectangle rectangle_0, Rectangle rectangle_1, GraphicsUnit graphicsUnit_0, int int_0, int int_1)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		try
		{
			num = 4;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 66:
					graphics_0.DrawImage(image_0, rectangle_0, rectangle_1, graphicsUnit_0);
					return;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			CreateException9(exception, num, num2, graphics_0, image_0, rectangle_0, rectangle_1, graphicsUnit_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_2(XmlWriter xmlWriter_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 3;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 66:
					xmlWriter_0.WriteEndElement();
					return;
				case 67:
					xmlWriter_0.Flush();
					return;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			CreateException5(exception, num, num2, xmlWriter_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_3(ref Guid guid_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 19:
					return guid_0.ToString(string_0);
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			CreateException5(exception, num, guid_0, string_0, int_0, int_1);
			throw;
		}
	}
}
