using System;
using System.Runtime.Serialization;
using System.Security;
using SmartAssembly.SmartExceptionsCore.UI;
using ns0;

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
		info.AddValue("UnhandledException.MethodID", MethodID, Class26.smethod_1(typeof(int).TypeHandle, 803, 775));
		info.AddValue("UnhandledException.ILOffset", ILOffset, Class26.smethod_1(typeof(int).TypeHandle, 7, 35));
		info.AddValue("UnhandledException.ExceptionStackDepth", ExceptionStackDepth, Class26.smethod_1(typeof(int).TypeHandle, 383, 347));
		int num = ((Objects != null) ? Objects.Length : 0);
		info.AddValue("UnhandledException.Objects.Length", num, Class26.smethod_1(typeof(int).TypeHandle, 311, 275));
		for (int i = 0; i < num; i++)
		{
			string name = FeedbackControl.smethod_1("UnhandledException.Objects[{0}]", i, 851, 833);
			try
			{
				if (Objects[i] == null)
				{
					info.AddValue(name, null, Class26.smethod_1(typeof(object).TypeHandle, 396, 424));
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

	internal SmartStackFrame(int int_0, object[] object_0, int int_1, int int_2)
	{
		MethodID = int_0;
		ExceptionStackDepth = int_2;
		ILOffset = int_1;
		Objects = object_0;
	}

	[SecuritySafeCritical]
	static SmartStackFrame()
	{
		Class32.smethod_1();
	}
}
