using System;
using System.Runtime.Serialization;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace SmartAssembly.SmartExceptionsCore;

[Serializable]
public sealed class SmartStackFrame : ISerializable
{
	[NonSerialized]
	internal static GetString getString_0;

	public const string NotSerializable = "Non-serializable object's string representation: '{0}'";

	public readonly int MethodID;

	public readonly object[] Objects;

	public readonly int ILOffset;

	public readonly int ExceptionStackDepth;

	static SmartStackFrame()
	{
		Strings.CreateGetStringDelegate(typeof(SmartStackFrame));
	}

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue(getString_0(2740), MethodID, typeof(int));
		info.AddValue(getString_0(2777), ILOffset, typeof(int));
		info.AddValue(getString_0(2814), ExceptionStackDepth, typeof(int));
		int num = ((Objects != null) ? Objects.Length : 0);
		info.AddValue(getString_0(2867), num, typeof(int));
		for (int i = 0; i < num; i++)
		{
			string string_ = string.Format(getString_0(2912), i);
			try
			{
				smethod_0(info, string_, Objects[i]);
			}
			catch (Exception)
			{
				object object_ = getString_0(2957);
				smethod_0(info, string_, object_);
			}
		}
	}

	private static void smethod_0(SerializationInfo serializationInfo_0, string string_0, object object_0)
	{
		try
		{
			if (!object_0.GetType().IsSerializable)
			{
				object_0 = string.Format(getString_0(3058), object_0);
			}
			serializationInfo_0.AddValue(string_0, object_0, typeof(object));
		}
		catch (SerializationException)
		{
			serializationInfo_0.AddValue(string_0, string.Format(getString_0(3058), object_0), typeof(object));
		}
	}

	internal SmartStackFrame(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
	{
		MethodID = serializationInfo_0.GetInt32(getString_0(2740));
		ILOffset = serializationInfo_0.GetInt32(getString_0(2777));
		ExceptionStackDepth = serializationInfo_0.GetInt32(getString_0(2814));
		int @int = serializationInfo_0.GetInt32(getString_0(2867));
		Objects = new object[@int];
		for (int i = 0; i < @int; i++)
		{
			try
			{
				Objects[i] = serializationInfo_0.GetValue(string.Format(getString_0(2912), i), typeof(object));
			}
			catch (Exception)
			{
				Objects[i] = getString_0(3131);
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
}
