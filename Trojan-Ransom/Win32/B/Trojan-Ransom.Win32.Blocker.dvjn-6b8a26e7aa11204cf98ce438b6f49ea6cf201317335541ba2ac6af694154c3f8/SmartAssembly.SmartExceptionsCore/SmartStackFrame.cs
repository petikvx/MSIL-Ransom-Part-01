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
		info.AddValue(Class14.smethod_0(2246), MethodID, typeof(int));
		info.AddValue(Class14.smethod_0(2283), ILOffset, typeof(int));
		info.AddValue(Class14.smethod_0(2320), ExceptionStackDepth, typeof(int));
		int num = ((Objects != null) ? Objects.Length : 0);
		info.AddValue(Class14.smethod_0(2373), num, typeof(int));
		for (int i = 0; i < num; i++)
		{
			string name = string.Format(Class14.smethod_0(2418), i);
			try
			{
				if (Objects[i] == null)
				{
					info.AddValue(name, null, typeof(object));
				}
				else
				{
					info.AddValue(name, string.Concat(Objects[i].GetType(), Class14.smethod_0(2463), Objects[i]), typeof(string));
				}
			}
			catch (Exception)
			{
			}
		}
	}

	internal SmartStackFrame(SerializationInfo info, StreamingContext context)
	{
		while (true)
		{
			base._002Ector();
			while (true)
			{
				MethodID = info.GetInt32(Class14.smethod_0(2246));
				while (true)
				{
					IL_001d:
					ILOffset = info.GetInt32(Class14.smethod_0(2283));
					ExceptionStackDepth = info.GetInt32(Class14.smethod_0(2320));
					int @int = info.GetInt32(Class14.smethod_0(2373));
					Objects = new object[@int];
					while (true)
					{
						IL_0066:
						int num = 0;
						while (true)
						{
							if (num < @int)
							{
								try
								{
									Objects[num] = info.GetValue(string.Format(Class14.smethod_0(2418), num), typeof(string));
								}
								catch (Exception)
								{
									Objects[num] = Class14.smethod_0(2468);
								}
								num++;
								if (qCmWHA4mUjBrGIXk8xP())
								{
									switch (3)
									{
									case 0:
										break;
									case 1:
										goto end_IL_0068;
									case 2:
									case 6:
										goto IL_001d;
									default:
										goto IL_0066;
									case 3:
									case 4:
										continue;
									case 7:
										return;
									}
									goto end_IL_0007;
								}
								break;
							}
							return;
							continue;
							end_IL_0068:
							break;
						}
						break;
					}
					break;
				}
				continue;
				end_IL_0007:
				break;
			}
		}
	}

	internal SmartStackFrame(int methodID, object[] objects, int ilOffset, int exceptionStackDepth)
	{
		int num = 3;
		if (!qCmWHA4mUjBrGIXk8xP())
		{
			goto IL_001e;
		}
		goto IL_0043;
		IL_0043:
		switch (num)
		{
		case 4:
			break;
		default:
			goto IL_001e;
		case 1:
		case 5:
			goto IL_0032;
		case 0:
		case 3:
			base._002Ector();
			goto IL_0032;
		case 6:
			return;
		}
		goto IL_000f;
		IL_001e:
		Objects = objects;
		num = 6;
		if (!qCmWHA4mUjBrGIXk8xP())
		{
			goto IL_0032;
		}
		goto IL_0043;
		IL_0032:
		MethodID = methodID;
		goto IL_000f;
		IL_000f:
		ExceptionStackDepth = exceptionStackDepth;
		ILOffset = ilOffset;
		goto IL_001e;
	}

	internal static bool qCmWHA4mUjBrGIXk8xP()
	{
		return true;
	}

	internal static bool eo70iZ4Gpelo6RcIVUK()
	{
		return false;
	}
}
