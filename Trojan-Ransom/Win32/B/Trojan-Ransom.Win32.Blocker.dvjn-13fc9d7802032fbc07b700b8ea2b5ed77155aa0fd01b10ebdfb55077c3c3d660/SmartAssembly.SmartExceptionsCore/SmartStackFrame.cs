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
		int num2 = default(int);
		int i = default(int);
		while (true)
		{
			info.AddValue("UnhandledException.MethodID", MethodID, typeof(int));
			while (true)
			{
				info.AddValue("UnhandledException.ILOffset", ILOffset, typeof(int));
				int num = 4;
				if (!Ov7JU7plsas6Q4Jb194())
				{
					while (true)
					{
						switch (num)
						{
						default:
							num = 5;
							if (FtlChVppRvao5VHI2eV())
							{
								continue;
							}
							goto case 5;
						case 1:
						case 2:
							break;
						case 0:
						case 3:
							goto end_IL_0036;
						case 4:
							info.AddValue("UnhandledException.ExceptionStackDepth", ExceptionStackDepth, typeof(int));
							goto case 5;
						case 5:
							num2 = ((Objects != null) ? Objects.Length : 0);
							info.AddValue("UnhandledException.Objects.Length", num2, typeof(int));
							i = 0;
							goto IL_014a;
						case 6:
							goto IL_014a;
						case 7:
							return;
						}
						break;
					}
					continue;
				}
				goto IL_014a;
				IL_014a:
				for (; i < num2; i++)
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
				return;
				continue;
				end_IL_0036:
				break;
			}
		}
	}

	internal SmartStackFrame(SerializationInfo info, StreamingContext context)
	{
		int num = 6;
		if (FtlChVppRvao5VHI2eV())
		{
			goto IL_0012;
		}
		goto IL_00c8;
		IL_0012:
		int @int = default(int);
		int i = default(int);
		switch (num)
		{
		case 6:
			base._002Ector();
			goto case 1;
		case 1:
		case 3:
			MethodID = info.GetInt32("UnhandledException.MethodID");
			goto case 2;
		case 2:
		case 4:
			ILOffset = info.GetInt32("UnhandledException.ILOffset");
			ExceptionStackDepth = info.GetInt32("UnhandledException.ExceptionStackDepth");
			@int = info.GetInt32("UnhandledException.Objects.Length");
			Objects = new object[@int];
			goto default;
		default:
			i = 0;
			break;
		case 5:
			break;
		case 7:
			return;
		}
		goto IL_00c8;
		IL_00c8:
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
		num = 7;
		if (Ov7JU7plsas6Q4Jb194())
		{
		}
		goto IL_0012;
	}

	internal SmartStackFrame(int methodID, object[] objects, int ilOffset, int exceptionStackDepth)
	{
		while (true)
		{
			base._002Ector();
			while (true)
			{
				MethodID = methodID;
				ExceptionStackDepth = exceptionStackDepth;
				int num = 4;
				if (!FtlChVppRvao5VHI2eV())
				{
					break;
				}
				while (true)
				{
					switch (num)
					{
					default:
						num = 0;
						if (FtlChVppRvao5VHI2eV())
						{
							continue;
						}
						return;
					case 1:
					case 2:
						break;
					case 5:
						goto end_IL_0032;
					case 4:
						ILOffset = ilOffset;
						goto case 0;
					case 0:
					case 3:
						Objects = objects;
						return;
					case 6:
						return;
					}
					break;
				}
				continue;
				end_IL_0032:
				break;
			}
		}
	}

	internal static bool FtlChVppRvao5VHI2eV()
	{
		return true;
	}

	internal static bool Ov7JU7plsas6Q4Jb194()
	{
		return false;
	}
}
