using System;
using System.Runtime.Serialization;
using ns9;

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
		info.AddValue(Class15.smethod_0(951478), MethodID, typeof(int));
		info.AddValue(Class15.smethod_0(951515), ILOffset, typeof(int));
		info.AddValue(Class15.smethod_0(951552), ExceptionStackDepth, typeof(int));
		int num = ((Objects != null) ? Objects.Length : 0);
		info.AddValue(Class15.smethod_0(951605), num, typeof(int));
		for (int i = 0; i < num; i++)
		{
			string name = string.Format(Class15.smethod_0(951650), i);
			try
			{
				if (Objects[i] == null)
				{
					info.AddValue(name, null, typeof(object));
				}
				else
				{
					info.AddValue(name, string.Concat(Objects[i].GetType(), Class15.smethod_0(951695), Objects[i]), typeof(string));
				}
			}
			catch (Exception)
			{
			}
		}
	}

	internal SmartStackFrame(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
	{
		MethodID = serializationInfo_0.GetInt32(Class15.smethod_0(951478));
		ILOffset = serializationInfo_0.GetInt32(Class15.smethod_0(951515));
		ExceptionStackDepth = serializationInfo_0.GetInt32(Class15.smethod_0(951552));
		int @int = serializationInfo_0.GetInt32(Class15.smethod_0(951605));
		Objects = new object[@int];
		for (int i = 0; i < @int; i++)
		{
			try
			{
				Objects[i] = serializationInfo_0.GetValue(string.Format(Class15.smethod_0(951650), i), typeof(string));
			}
			catch (Exception)
			{
				Objects[i] = Class15.smethod_0(951700);
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
