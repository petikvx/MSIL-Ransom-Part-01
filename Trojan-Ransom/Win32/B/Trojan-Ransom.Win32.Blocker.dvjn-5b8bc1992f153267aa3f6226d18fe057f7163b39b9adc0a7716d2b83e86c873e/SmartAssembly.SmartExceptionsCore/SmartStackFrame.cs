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
		while (true)
		{
			info.AddValue("UnhandledException.MethodID", MethodID, typeof(int));
			while (true)
			{
				IL_0021:
				info.AddValue("UnhandledException.ILOffset", ILOffset, typeof(int));
				while (true)
				{
					IL_0041:
					info.AddValue("UnhandledException.ExceptionStackDepth", ExceptionStackDepth, typeof(int));
					while (true)
					{
						IL_0061:
						int num = ((Objects != null) ? Objects.Length : 0);
						info.AddValue("UnhandledException.Objects.Length", num, typeof(int));
						int num2 = 0;
						while (true)
						{
							if (num2 < num)
							{
								string name = $"UnhandledException.Objects[{num2}]";
								try
								{
									if (Objects[num2] == null)
									{
										if (m3rABuv1DVdZSarpPDr())
										{
										}
										switch (2)
										{
										case 0:
										case 2:
											info.AddValue(name, null, typeof(object));
											break;
										case 1:
										case 3:
											break;
										}
									}
									else
									{
										info.AddValue(name, string.Concat(Objects[num2].GetType(), " - ", Objects[num2]), typeof(string));
									}
								}
								catch (Exception)
								{
								}
								num2++;
								continue;
							}
							if (m3rABuv1DVdZSarpPDr())
							{
							}
							switch (7)
							{
							case 4:
								break;
							case 1:
								goto IL_0021;
							case 2:
							case 6:
								goto IL_0041;
							default:
								goto IL_0061;
							case 5:
								continue;
							case 7:
								return;
							}
							break;
						}
						break;
					}
					break;
				}
				break;
			}
		}
	}

	internal SmartStackFrame(SerializationInfo info, StreamingContext context)
	{
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
		MethodID = methodID;
		ExceptionStackDepth = exceptionStackDepth;
		ILOffset = ilOffset;
		Objects = objects;
	}

	internal static bool qThXSEvvXVkMCkQ5gX6()
	{
		return true;
	}

	internal static bool m3rABuv1DVdZSarpPDr()
	{
		return false;
	}
}
