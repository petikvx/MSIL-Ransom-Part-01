using System;
using System.Runtime.Serialization;
using System.Security;

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
		int @int = default(int);
		int i = default(int);
		while (true)
		{
			base._002Ector();
			while (true)
			{
				MethodID = info.GetInt32("UnhandledException.MethodID");
				ILOffset = info.GetInt32("UnhandledException.ILOffset");
				ExceptionStackDepth = info.GetInt32("UnhandledException.ExceptionStackDepth");
				if (!K5rQb4XYxndOiE6fuqr())
				{
					switch (5)
					{
					case 1:
						break;
					case 2:
						goto end_IL_0003;
					case 5:
						@int = info.GetInt32("UnhandledException.Objects.Length");
						Objects = new object[@int];
						goto default;
					default:
						i = 0;
						goto IL_00ce;
					case 4:
					case 6:
						goto IL_00ce;
					case 7:
						return;
					}
					continue;
				}
				goto IL_00ce;
				IL_00ce:
				for (; i < @int; i++)
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
				return;
				continue;
				end_IL_0003:
				break;
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

	internal static bool lenlnLXCdn3VAKZkSVh()
	{
		return true;
	}

	internal static bool K5rQb4XYxndOiE6fuqr()
	{
		return false;
	}
}
