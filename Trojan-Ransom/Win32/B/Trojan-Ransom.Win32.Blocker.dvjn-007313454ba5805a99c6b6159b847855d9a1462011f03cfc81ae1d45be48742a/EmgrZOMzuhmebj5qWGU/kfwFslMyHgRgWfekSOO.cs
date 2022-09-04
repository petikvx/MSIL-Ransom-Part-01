using System;
using System.Collections.Generic;
using System.Diagnostics;
using ProwxkN4F4ab5Fc8FL;
using SmartAssembly.SmartExceptionsCore;

namespace EmgrZOMzuhmebj5qWGU;

internal sealed class kfwFslMyHgRgWfekSOO
{
	public static void J60KhDFtEY(Exception exception_0)
	{
		Y33KiQyvn7(exception_0, new object[0]);
	}

	public static void vcvKkadLLU(Exception exception_0, object object_0)
	{
		Y33KiQyvn7(exception_0, new object[1] { object_0 });
	}

	public static void Eo5KXObpr9(Exception exception_0, object object_0, object object_1)
	{
		Y33KiQyvn7(exception_0, new object[2] { object_0, object_1 });
	}

	public static void VC2KRZPAuR(Exception exception_0, object object_0, object object_1, object object_2)
	{
		Y33KiQyvn7(exception_0, new object[3] { object_0, object_1, object_2 });
	}

	public static void a9hKWr0GUi(Exception exception_0, object object_0, object object_1, object object_2, object object_3)
	{
		Y33KiQyvn7(exception_0, new object[4] { object_0, object_1, object_2, object_3 });
	}

	public static void xABKbTHr1M(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		Y33KiQyvn7(exception_0, new object[5] { object_0, object_1, object_2, object_3, object_4 });
	}

	public static void vPkK1v7U7G(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		Y33KiQyvn7(exception_0, new object[6] { object_0, object_1, object_2, object_3, object_4, object_5 });
	}

	public static void BjJKwXaaTv(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		Y33KiQyvn7(exception_0, new object[7] { object_0, object_1, object_2, object_3, object_4, object_5, object_6 });
	}

	public static void r1wKe4UF6I(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		Y33KiQyvn7(exception_0, new object[8] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7 });
	}

	public static void XqZKxvxIvX(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8)
	{
		Y33KiQyvn7(exception_0, new object[9] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8 });
	}

	public static void uGrKVrWZVh(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9)
	{
		Y33KiQyvn7(exception_0, new object[10] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9 });
	}

	public static void Y33KiQyvn7(Exception exception_0, object[] object_0)
	{
		int int_ = -1;
		int int_2 = -1;
		int num = 0;
		StackTrace stackTrace = new StackTrace(exception_0);
		try
		{
			if (exception_0.StackTrace != null)
			{
				string[] array = exception_0.StackTrace!.Split('\r', '\n');
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text.Length > 0)
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
				int_ = (frame.GetMethod()!.MetadataToken & 0xFFFFFF) - 1;
				int_2 = frame.GetILOffset();
			}
		}
		catch
		{
		}
		try
		{
			SmartStackFrame value = new SmartStackFrame(int_, object_0, int_2, num);
			LinkedList<object> linkedList;
			if (!exception_0.Data.Contains(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(680288)))
			{
				linkedList = new LinkedList<object>();
				exception_0.Data[DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(680288)] = linkedList;
			}
			else
			{
				linkedList = (LinkedList<object>)exception_0.Data[DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(680288)];
			}
			linkedList.AddLast(value);
		}
		catch
		{
		}
	}

	internal static bool lpUSVO4Y8HmyK8ZuP8D()
	{
		return true;
	}

	internal static bool Cwx8b34w0QAJCdUfUuc()
	{
		return false;
	}
}
