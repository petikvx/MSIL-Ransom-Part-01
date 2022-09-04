using System;
using System.Runtime.Serialization;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;

namespace SmartAssembly.SmartExceptionsCore;

[Serializable]
public class SmartStackFrame : ISerializable
{
	public readonly int MethodID;

	public readonly object[] Objects;

	public readonly int ILOffset;

	public readonly int ExceptionStackDepth;

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string text = default(string);
		int num4 = default(int);
		int num5 = default(int);
		try
		{
			num = 3;
			FeedbackControl.smethod_0(info, "UnhandledException.MethodID", MethodID, SendingReportFeedbackEventArgs1.smethod_0(typeof(int).TypeHandle, 958, 965), 594, 543);
			num = 2;
			FeedbackControl.smethod_0(info, "UnhandledException.ILOffset", ILOffset, SendingReportFeedbackEventArgs1.smethod_0(typeof(int).TypeHandle, 851, 808), 438, 507);
			num = 0;
			FeedbackControl.smethod_0(info, "UnhandledException.ExceptionStackDepth", ExceptionStackDepth, SendingReportFeedbackEventArgs1.smethod_0(typeof(int).TypeHandle, 370, 265), 609, 556);
			num = 7;
			num2 = ((Objects != null) ? Objects.Length : 0);
			FeedbackControl.smethod_0(info, "UnhandledException.Objects.Length", num2, SendingReportFeedbackEventArgs1.smethod_0(typeof(int).TypeHandle, 870, 797), 328, 261);
			num = 9;
			num3 = 0;
			while (num3 < num2)
			{
				text = DoNotPruneAttribute.smethod_0("UnhandledException.Objects[{0}]", num3, 701, 751);
				try
				{
					num4 = 2;
					if (Objects[num3] == null)
					{
						FeedbackControl.smethod_0(info, text, null, SendingReportFeedbackEventArgs1.smethod_0(typeof(object).TypeHandle, 344, 291), 623, 546);
						num4 = 3;
					}
					else
					{
						info.AddValue(text, string.Concat(Objects[num3].GetType(), " - ", Objects[num3]), typeof(string));
					}
				}
				catch (Exception)
				{
				}
				num5 = 5;
				num3++;
				num5 = 2;
			}
			num5 = 1;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException9(exception, num2, num3, text, num, num4, num5, this, info, context);
			throw;
		}
	}

	internal SmartStackFrame(int int_0, object[] object_0, int int_1, int int_2)
	{
		try
		{
			MethodID = int_0;
			ExceptionStackDepth = int_2;
			ILOffset = int_1;
			Objects = object_0;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, this, int_0, object_0, int_1, int_2);
			throw;
		}
	}

	static SmartStackFrame()
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
