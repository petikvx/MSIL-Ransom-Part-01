using System;
using System.Runtime.Serialization;

namespace SmartAssembly.SmartExceptionsCore;

[Serializable]
public class SmartStackFrame : ISerializable
{
	public const string NotSerializable = "Non-serializable object's string representation: '{0}'";

	public readonly int MethodID;

	public readonly object[] Objects;

	public readonly int ILOffset;

	public readonly int ExceptionStackDepth;

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("UnhandledException.MethodID", MethodID, typeof(int));
		info.AddValue("UnhandledException.ILOffset", ILOffset, typeof(int));
		info.AddValue("UnhandledException.ExceptionStackDepth", ExceptionStackDepth, typeof(int));
		int num = ((Objects != null) ? Objects.Length : 0);
		info.AddValue("UnhandledException.Objects.Length", num, typeof(int));
		for (int i = 0; i < num; i++)
		{
			string string_ = $"UnhandledException.Objects[{i}]";
			try
			{
				smethod_0(info, string_, Objects[i]);
			}
			catch (Exception)
			{
				object object_ = "Could not serialize the object or retrieve a string represenation for it.";
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
				object_0 = $"Non-serializable object's string representation: '{object_0}'";
			}
			serializationInfo_0.AddValue(string_0, object_0, typeof(object));
		}
		catch (SerializationException)
		{
			serializationInfo_0.AddValue(string_0, $"Non-serializable object's string representation: '{object_0}'", typeof(object));
		}
	}

	internal SmartStackFrame(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
	{
		MethodID = serializationInfo_0.GetInt32("UnhandledException.MethodID");
		ILOffset = serializationInfo_0.GetInt32("UnhandledException.ILOffset");
		ExceptionStackDepth = serializationInfo_0.GetInt32("UnhandledException.ExceptionStackDepth");
		int @int = serializationInfo_0.GetInt32("UnhandledException.Objects.Length");
		Objects = new object[@int];
		for (int i = 0; i < @int; i++)
		{
			try
			{
				Objects[i] = serializationInfo_0.GetValue($"UnhandledException.Objects[{i}]", typeof(object));
			}
			catch (Exception)
			{
				Objects[i] = "Could not deserialize the obect";
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
