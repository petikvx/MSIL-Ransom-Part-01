using System;
using System.Runtime.Serialization;
using System.Security;
using _0023ab;

namespace SmartAssembly.SmartExceptionsCore;

[Serializable]
public class SmartStackFrame : ISerializable
{
	public readonly int MethodID;

	public readonly object[] Objects;

	public readonly int ILOffset;

	public readonly int ExceptionStackDepth;

	[SecurityCritical]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue(_00239._00237(107393623), MethodID, typeof(int));
		info.AddValue(_00239._00237(107393586), ILOffset, typeof(int));
		info.AddValue(_00239._00237(107394029), ExceptionStackDepth, typeof(int));
		int num = ((Objects != null) ? Objects.Length : 0);
		info.AddValue(_00239._00237(107394008), num, typeof(int));
		for (int i = 0; i < num; i++)
		{
			string name = string.Format(_00239._00237(107393931), i);
			try
			{
				if (Objects[i] == null)
				{
					info.AddValue(name, null, typeof(object));
				}
				else
				{
					info.AddValue(name, Objects[i].GetType()?.ToString() + _00239._00237(107393918) + Objects[i], typeof(string));
				}
			}
			catch (Exception)
			{
			}
		}
	}

	internal SmartStackFrame(SerializationInfo info, StreamingContext context)
	{
		MethodID = info.GetInt32(_00239._00237(107393623));
		ILOffset = info.GetInt32(_00239._00237(107393586));
		ExceptionStackDepth = info.GetInt32(_00239._00237(107394029));
		int @int = info.GetInt32(_00239._00237(107394008));
		Objects = new object[@int];
		for (int i = 0; i < @int; i++)
		{
			try
			{
				Objects[i] = info.GetValue(string.Format(_00239._00237(107393931), i), typeof(string));
			}
			catch (Exception)
			{
				Objects[i] = _00239._00237(107393913);
			}
		}
	}

	internal SmartStackFrame(int methodID, object[] objects, int ilOffset, int exceptionStackDepth)
	{
		MethodID = methodID;
		ExceptionStackDepth = exceptionStackDepth;
		ILOffset = ilOffset;
		Objects = objects;
	}
}
