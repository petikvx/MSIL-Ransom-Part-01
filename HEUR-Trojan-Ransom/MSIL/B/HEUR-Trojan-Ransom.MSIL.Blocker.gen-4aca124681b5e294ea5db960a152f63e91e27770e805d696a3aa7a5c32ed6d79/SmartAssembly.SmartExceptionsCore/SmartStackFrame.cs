using System;
using System.Runtime.Serialization;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace SmartAssembly.SmartExceptionsCore;

[Serializable]
public sealed class SmartStackFrame : ISerializable
{
	public readonly int MethodID;

	public readonly object[] Objects;

	public readonly int ILOffset;

	public readonly int ExceptionStackDepth;

	[NonSerialized]
	internal static GetString getString_0;

	[SecurityCritical]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue(getString_0(107388642), MethodID, typeof(int));
		info.AddValue(getString_0(107388605), ILOffset, typeof(int));
		info.AddValue(getString_0(107388568), ExceptionStackDepth, typeof(int));
		int num = ((Objects != null) ? Objects.Length : 0);
		info.AddValue(getString_0(107388515), num, typeof(int));
		for (int i = 0; i < num; i++)
		{
			string name = string.Format(getString_0(107388438), i);
			try
			{
				if (Objects[i] == null)
				{
					info.AddValue(name, null, typeof(object));
				}
				else
				{
					info.AddValue(name, Objects[i].GetType()?.ToString() + getString_0(107387881) + Objects[i], typeof(string));
				}
			}
			catch (Exception)
			{
			}
		}
	}

	internal SmartStackFrame(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
	{
		MethodID = serializationInfo_0.GetInt32(getString_0(107388642));
		ILOffset = serializationInfo_0.GetInt32(getString_0(107388605));
		ExceptionStackDepth = serializationInfo_0.GetInt32(getString_0(107388568));
		int @int = serializationInfo_0.GetInt32(getString_0(107388515));
		Objects = new object[@int];
		for (int i = 0; i < @int; i++)
		{
			try
			{
				Objects[i] = serializationInfo_0.GetValue(string.Format(getString_0(107388438), i), typeof(string));
			}
			catch (Exception)
			{
				Objects[i] = getString_0(107387908);
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
		Strings.CreateGetStringDelegate(typeof(SmartStackFrame));
	}
}
