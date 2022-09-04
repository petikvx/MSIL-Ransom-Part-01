using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Serialization;
using ns4;

namespace SmartAssembly.SmartExceptionsCore;

[Serializable]
public sealed class UnhandledException : Exception
{
	public int MethodID;

	public object[] Objects;

	public int ILOffset;

	private Exception previousException;

	internal Exception method_0()
	{
		return previousException;
	}

	public static Exception smethod_0(Exception exception_0)
	{
		return smethod_11(exception_0, new object[0]);
	}

	public static Exception smethod_1(Exception exception_0, object object_0)
	{
		return smethod_11(exception_0, new object[1] { object_0 });
	}

	public static Exception smethod_2(Exception exception_0, object object_0, object object_1)
	{
		return smethod_11(exception_0, new object[2] { object_0, object_1 });
	}

	public static Exception smethod_3(Exception exception_0, object object_0, object object_1, object object_2)
	{
		return smethod_11(exception_0, new object[3] { object_0, object_1, object_2 });
	}

	public static Exception smethod_4(Exception exception_0, object object_0, object object_1, object object_2, object object_3)
	{
		return smethod_11(exception_0, new object[4] { object_0, object_1, object_2, object_3 });
	}

	public static Exception smethod_5(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		return smethod_11(exception_0, new object[5] { object_0, object_1, object_2, object_3, object_4 });
	}

	public static Exception smethod_6(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		return smethod_11(exception_0, new object[6] { object_0, object_1, object_2, object_3, object_4, object_5 });
	}

	public static Exception smethod_7(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		return smethod_11(exception_0, new object[7] { object_0, object_1, object_2, object_3, object_4, object_5, object_6 });
	}

	public static Exception smethod_8(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		return smethod_11(exception_0, new object[8] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7 });
	}

	public static Exception smethod_9(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8)
	{
		return smethod_11(exception_0, new object[9] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8 });
	}

	public static Exception smethod_10(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9)
	{
		return smethod_11(exception_0, new object[10] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9 });
	}

	public static Exception smethod_11(Exception exception_0, object[] object_0)
	{
		if (Class18.bool_0)
		{
			return null;
		}
		int int_ = -1;
		int int_2 = -1;
		try
		{
			StackTrace stackTrace = new StackTrace(exception_0);
			if (stackTrace.FrameCount > 0)
			{
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int_2 = (frame.GetMethod()!.MetadataToken & 0xFFFFFF) - 1;
				int_ = frame.GetILOffset();
			}
		}
		catch
		{
		}
		UnhandledException value = new UnhandledException(int_2, object_0, int_, exception_0);
		if (exception_0 is UnhandledException)
		{
			Exception ex = (exception_0 as UnhandledException).method_0();
			if (ex != null)
			{
				exception_0 = ex;
			}
		}
		Exception ex2 = exception_0;
		while (ex2.InnerException != null)
		{
			ex2 = ex2.InnerException;
		}
		try
		{
			FieldInfo field = typeof(Exception).GetField("_innerException", BindingFlags.Instance | BindingFlags.NonPublic);
			field.SetValue(ex2, value);
			return exception_0;
		}
		catch
		{
			return exception_0;
		}
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("UnhandledException.MethodID", MethodID, typeof(int));
		info.AddValue("UnhandledException.ILOffset", ILOffset, typeof(int));
		info.AddValue("UnhandledException.PreviousException", previousException, typeof(Exception));
		int num = ((Objects != null) ? Objects.Length : 0);
		info.AddValue("UnhandledException.Objects.Length", num, typeof(int));
		for (int i = 0; i < num; i++)
		{
			info.AddValue($"UnhandledException.Objects[{i}]", Objects[i], typeof(object));
		}
	}

	internal UnhandledException(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		: base(serializationInfo_0, streamingContext_0)
	{
		MethodID = serializationInfo_0.GetInt32("UnhandledException.MethodID");
		ILOffset = serializationInfo_0.GetInt32("UnhandledException.ILOffset");
		previousException = (Exception)serializationInfo_0.GetValue("UnhandledException.PreviousException", typeof(Exception));
		int @int = serializationInfo_0.GetInt32("UnhandledException.Objects.Length");
		Objects = new object[@int];
		for (int i = 0; i < @int; i++)
		{
			Objects[i] = serializationInfo_0.GetValue($"UnhandledException.Objects[{i}]", typeof(object));
		}
	}

	internal UnhandledException(int int_0, object[] object_0, int int_1, Exception exception_0)
		: base($"SmartExceptionsCore.UnhandledException @ {int_0}, offset:{int_1}")
	{
		MethodID = int_0;
		Objects = object_0;
		ILOffset = int_1;
		previousException = exception_0;
	}
}
