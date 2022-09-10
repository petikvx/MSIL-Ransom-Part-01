using System;
using System.Runtime.Serialization;
using System.Security;
using ns10;

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
		int num2 = default(int);
		int num3 = default(int);
		if (kMYYVuR1i8sSdJQFNsG())
		{
			int num;
			switch (6)
			{
			case 6:
				info.AddValue(Class32.smethod_0(6133), MethodID, typeof(int));
				goto case 1;
			case 1:
			case 5:
				info.AddValue(Class32.smethod_0(6170), ILOffset, typeof(int));
				info.AddValue(Class32.smethod_0(6207), ExceptionStackDepth, typeof(int));
				if (Objects != null)
				{
					goto case 2;
				}
				num = 0;
				goto IL_00be;
			case 2:
			case 4:
				num = Objects.Length;
				goto IL_00be;
			case 3:
				break;
			default:
				goto IL_0155;
			case 7:
				return;
				IL_00be:
				num2 = num;
				info.AddValue(Class32.smethod_0(6260), num2, typeof(int));
				num3 = 0;
				goto IL_0155;
			}
		}
		goto IL_00f9;
		IL_00f9:
		string name = default(string);
		try
		{
			if (Objects[num3] == null)
			{
				info.AddValue(name, null, typeof(object));
			}
			else
			{
				info.AddValue(name, string.Concat(Objects[num3].GetType(), Class32.smethod_0(6350), Objects[num3]), typeof(string));
			}
		}
		catch (Exception)
		{
		}
		num3++;
		goto IL_0155;
		IL_0155:
		if (num3 < num2)
		{
			name = string.Format(Class32.smethod_0(6305), num3);
			goto IL_00f9;
		}
	}

	internal SmartStackFrame(SerializationInfo info, StreamingContext context)
	{
		if (IAkm9HRfcx2f9fjIqNX())
		{
		}
		int @int = default(int);
		int i = default(int);
		switch (5)
		{
		case 5:
			base._002Ector();
			goto case 0;
		case 0:
			MethodID = info.GetInt32(Class32.smethod_0(6133));
			goto case 2;
		case 2:
		case 4:
			ILOffset = info.GetInt32(Class32.smethod_0(6170));
			ExceptionStackDepth = info.GetInt32(Class32.smethod_0(6207));
			goto default;
		default:
			@int = info.GetInt32(Class32.smethod_0(6260));
			Objects = new object[@int];
			i = 0;
			break;
		case 6:
			break;
		case 7:
			return;
		}
		for (; i < @int; i++)
		{
			try
			{
				Objects[i] = info.GetValue(string.Format(Class32.smethod_0(6305), i), typeof(string));
			}
			catch (Exception)
			{
				Objects[i] = Class32.smethod_0(6355);
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

	internal static bool kMYYVuR1i8sSdJQFNsG()
	{
		return true;
	}

	internal static bool IAkm9HRfcx2f9fjIqNX()
	{
		return false;
	}
}
