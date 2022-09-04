using System;
using System.Runtime.Serialization;

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

	internal SmartStackFrame(SerializationInfo info, StreamingContext context)
	{
		Class2.l4t8M9wzGUypc();
		base._002Ector();
		MethodID = info.GetInt32("UnhandledException.MethodID");
		ILOffset = info.GetInt32("UnhandledException.ILOffset");
		ExceptionStackDepth = info.GetInt32("UnhandledException.ExceptionStackDepth");
		int @int = info.GetInt32("UnhandledException.Objects.Length");
		Objects = new object[@int];
		for (int i = 0; i < @int; i++)
		{
			try
			{
				Objects[i] = info.GetValue($"UnhandledException.Objects[{i}]", typeof(string));
			}
			catch (Exception)
			{
				Objects[i] = "Could not deserialize the obect";
			}
		}
	}

	internal SmartStackFrame(int methodID, object[] objects, int ilOffset, int exceptionStackDepth)
	{
		Class2.l4t8M9wzGUypc();
		base._002Ector();
		MethodID = methodID;
		ExceptionStackDepth = exceptionStackDepth;
		ILOffset = ilOffset;
		Objects = objects;
	}
}
