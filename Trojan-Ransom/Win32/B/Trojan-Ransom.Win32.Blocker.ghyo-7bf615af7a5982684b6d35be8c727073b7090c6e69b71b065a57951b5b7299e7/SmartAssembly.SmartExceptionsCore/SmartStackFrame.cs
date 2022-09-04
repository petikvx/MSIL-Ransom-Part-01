using System;
using System.Runtime.Serialization;

namespace SmartAssembly.SmartExceptionsCore;

[Serializable]
public sealed class SmartStackFrame : ISerializable
{
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
			string name = $"UnhandledException.Objects[{i}]";
			try
			{
				if (Objects[i] == null)
				{
					info.AddValue(name, null, typeof(object));
				}
				else
				{
					info.AddValue(name, string.Concat(Objects[i].GetType(), " - ", Objects[i]), typeof(string));
				}
			}
			catch (Exception)
			{
			}
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
				Objects[i] = serializationInfo_0.GetValue($"UnhandledException.Objects[{i}]", typeof(string));
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
