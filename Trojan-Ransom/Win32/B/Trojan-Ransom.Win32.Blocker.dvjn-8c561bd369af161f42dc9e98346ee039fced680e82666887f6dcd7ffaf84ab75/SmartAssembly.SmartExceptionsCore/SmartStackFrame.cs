using System;
using System.Runtime.Serialization;
using System.Security;
using ns7;

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
		while (true)
		{
			info.AddValue(Class14.smethod_0(5973), MethodID, typeof(int));
			while (true)
			{
				IL_0026:
				info.AddValue(Class14.smethod_0(6010), ILOffset, typeof(int));
				while (true)
				{
					IL_004b:
					info.AddValue(Class14.smethod_0(6047), ExceptionStackDepth, typeof(int));
					int num;
					if (Objects == null)
					{
						num = 0;
						goto IL_007c;
					}
					goto IL_0142;
					IL_007c:
					int num2 = num;
					info.AddValue(Class14.smethod_0(6100), num2, typeof(int));
					int num3 = 0;
					while (true)
					{
						if (num3 < num2)
						{
							string name = string.Format(Class14.smethod_0(6145), num3);
							try
							{
								if (Objects[num3] == null)
								{
									info.AddValue(name, null, typeof(object));
								}
								else
								{
									info.AddValue(name, string.Concat(Objects[num3].GetType(), Class14.smethod_0(6190), Objects[num3]), typeof(string));
								}
							}
							catch (Exception)
							{
							}
							num3++;
							continue;
						}
						if (!CehdsgrSXaEOMjQ7x8R())
						{
							switch (7)
							{
							case 0:
								break;
							case 3:
								goto IL_0026;
							case 2:
							case 5:
								goto IL_004b;
							case 4:
							case 6:
								continue;
							default:
								goto IL_0142;
							case 7:
								return;
							}
							break;
						}
						return;
					}
					break;
					IL_0142:
					num = Objects.Length;
					goto IL_007c;
				}
				break;
			}
		}
	}

	internal SmartStackFrame(SerializationInfo info, StreamingContext context)
	{
		MethodID = info.GetInt32(Class14.smethod_0(5973));
		ILOffset = info.GetInt32(Class14.smethod_0(6010));
		ExceptionStackDepth = info.GetInt32(Class14.smethod_0(6047));
		int @int = info.GetInt32(Class14.smethod_0(6100));
		Objects = new object[@int];
		for (int i = 0; i < @int; i++)
		{
			try
			{
				Objects[i] = info.GetValue(string.Format(Class14.smethod_0(6145), i), typeof(string));
			}
			catch (Exception)
			{
				Objects[i] = Class14.smethod_0(6195);
			}
		}
	}

	internal SmartStackFrame(int methodID, object[] objects, int ilOffset, int exceptionStackDepth)
	{
		while (true)
		{
			base._002Ector();
			if (D4fUmkrR7HPNo69w6Co())
			{
				switch (3)
				{
				case 0:
				case 5:
					continue;
				case 1:
				case 3:
					MethodID = methodID;
					ExceptionStackDepth = exceptionStackDepth;
					goto case 2;
				case 2:
					ILOffset = ilOffset;
					break;
				case 6:
					return;
				}
			}
			break;
		}
		Objects = objects;
	}

	internal static bool D4fUmkrR7HPNo69w6Co()
	{
		return true;
	}

	internal static bool CehdsgrSXaEOMjQ7x8R()
	{
		return false;
	}
}
