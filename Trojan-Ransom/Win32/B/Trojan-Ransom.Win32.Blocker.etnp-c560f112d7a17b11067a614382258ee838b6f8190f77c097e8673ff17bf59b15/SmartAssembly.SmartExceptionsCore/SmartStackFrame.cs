using System;
using System.Runtime.Serialization;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

[Serializable]
public sealed class SmartStackFrame : ISerializable
{
	public readonly int int_0;

	public readonly object[] object_0;

	public readonly int int_1;

	public readonly int int_2;

	internal SmartStackFrame(SerializationInfo CO_, StreamingContext CO_)
	{
		int_0 = CO_.GetInt32(Class5.smethod_0(81592));
		int_1 = CO_.GetInt32(Class5.smethod_0(81629));
		int_2 = CO_.GetInt32(Class5.smethod_0(81666));
		int @int = CO_.GetInt32(Class5.smethod_0(81719));
		object_0 = new object[@int];
		for (int i = 0; i < @int; i++)
		{
			try
			{
				object_0[i] = CO_.GetValue(string.Format(Class5.smethod_0(81764), i), typeof(string));
			}
			catch (Exception)
			{
				object_0[i] = Class5.smethod_0(81814);
			}
		}
	}

	internal SmartStackFrame(int CO_, object[] CO_, int CO_, int CO_)
	{
		int_0 = CO_;
		int_2 = CO_;
		int_1 = CO_;
		object_0 = CO_;
	}

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue(Class5.smethod_0(81592), int_0, typeof(int));
		info.AddValue(Class5.smethod_0(81629), int_1, typeof(int));
		info.AddValue(Class5.smethod_0(81666), int_2, typeof(int));
		int num;
		if (object_0 != null)
		{
			num = object_0.Length;
			goto IL_0082;
		}
		goto IL_0086;
		IL_00b2:
		int num2;
		while (4 == 0)
		{
			if (num2 == 0)
			{
				continue;
			}
			goto IL_00b8;
		}
		int num3;
		if (num3 >= num2)
		{
			return;
		}
		int num4;
		string name = string.Format(Class5.smethod_0(81764), num4);
		try
		{
			while (true)
			{
				if (object_0[num4] != null)
				{
					if (5 == 0)
					{
						continue;
					}
					if (7u != 0)
					{
						info.AddValue(name, string.Concat(object_0[num4].GetType(), Class5.smethod_0(81809), object_0[num4]), typeof(string));
						break;
					}
				}
				info.AddValue(name, null, typeof(object));
				break;
			}
		}
		catch (Exception)
		{
		}
		goto IL_0135;
		IL_0086:
		if (3u != 0)
		{
			num = 0;
			goto IL_0082;
		}
		goto IL_0135;
		IL_00b0:
		num3 = num4;
		int num5;
		num2 = num5;
		goto IL_00b2;
		IL_0082:
		num5 = num;
		if (5 == 0)
		{
			goto IL_0086;
		}
		info.AddValue(Class5.smethod_0(81719), num5, typeof(int));
		num4 = 0;
		goto IL_00b0;
		IL_00b8:
		num4 = num3 + num2;
		goto IL_00b0;
		IL_0135:
		num3 = num4;
		num2 = 1;
		if (num2 == 0)
		{
			goto IL_00b2;
		}
		goto IL_00b8;
	}
}
