using System;
using System.Runtime.Serialization;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.Zip;

namespace SmartAssembly.SmartExceptionsCore;

[Serializable]
[DoNotObfuscateType]
public class SmartStackFrame : ISerializable
{
	public readonly int MethodID;

	public readonly object[] Objects;

	public readonly int ILOffset;

	public readonly int ExceptionStackDepth;

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		FeedbackControl.smethod_1(info, "UnhandledException.MethodID", MethodID, DoNotEncodeStringsAttribute.smethod_0(typeof(int).TypeHandle, 529, 584), 189, 190);
		FeedbackControl.smethod_1(info, "UnhandledException.ILOffset", ILOffset, DoNotEncodeStringsAttribute.smethod_0(typeof(int).TypeHandle, 409, 448), 237, 238);
		FeedbackControl.smethod_1(info, "UnhandledException.ExceptionStackDepth", ExceptionStackDepth, DoNotEncodeStringsAttribute.smethod_0(typeof(int).TypeHandle, 945, 1000), 410, 409);
		int num = ((Objects != null) ? Objects.Length : 0);
		FeedbackControl.smethod_1(info, "UnhandledException.Objects.Length", num, DoNotEncodeStringsAttribute.smethod_0(typeof(int).TypeHandle, 54, 111), 989, 990);
		for (int i = 0; i < num; i++)
		{
			string text = $"UnhandledException.Objects[{i}]";
			try
			{
				if (Objects[i] == null)
				{
					FeedbackControl.smethod_1(info, text, null, DoNotEncodeStringsAttribute.smethod_0(typeof(object).TypeHandle, 941, 1012), 637, 638);
				}
				else
				{
					info.AddValue(text, string.Concat(Objects[i].GetType(), " - ", Objects[i]), typeof(string));
				}
			}
			catch (Exception)
			{
			}
		}
	}

	internal SmartStackFrame(int int_0, object[] object_0, int int_1, int int_2)
	{
		MethodID = int_0;
		ExceptionStackDepth = int_2;
		ILOffset = int_1;
		Objects = object_0;
	}

	static SmartStackFrame()
	{
		DESCryptoIndirector.smethod_0();
	}
}
