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
		int num = default(int);
		if (NimOfMGp72aD46E3XnY())
		{
			switch (0)
			{
			case 0:
				info.AddValue("UnhandledException.MethodID", MethodID, typeof(int));
				goto case 5;
			case 5:
				info.AddValue("UnhandledException.ILOffset", ILOffset, typeof(int));
				info.AddValue("UnhandledException.ExceptionStackDepth", ExceptionStackDepth, typeof(int));
				goto case 1;
			case 1:
			case 2:
				num = ((Objects != null) ? Objects.Length : 0);
				info.AddValue("UnhandledException.Objects.Length", num, typeof(int));
				break;
			case 6:
				goto IL_0137;
			case 7:
				return;
			}
		}
		int i = 0;
		goto IL_0137;
		IL_0137:
		for (; i < num; i++)
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

	internal SmartStackFrame(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
	{
		int num = 4;
		if (NimOfMGp72aD46E3XnY())
		{
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					base._002Ector();
					num = 5;
					if (NimOfMGp72aD46E3XnY())
					{
						continue;
					}
					goto case 1;
				case 1:
				case 5:
					MethodID = serializationInfo_0.GetInt32("UnhandledException.MethodID");
					break;
				case 3:
					break;
				default:
					goto IL_006b;
				case 2:
					goto IL_00d6;
				case 7:
					return;
				}
				break;
			}
		}
		ILOffset = serializationInfo_0.GetInt32("UnhandledException.ILOffset");
		goto IL_006b;
		IL_006b:
		ExceptionStackDepth = serializationInfo_0.GetInt32("UnhandledException.ExceptionStackDepth");
		int @int = serializationInfo_0.GetInt32("UnhandledException.Objects.Length");
		Objects = new object[@int];
		int i = 0;
		goto IL_00d6;
		IL_00d6:
		for (; i < @int; i++)
		{
			try
			{
				Objects[i] = serializationInfo_0.GetValue($"UnhandledException.Objects[{i}]", typeof(string));
			}
			catch (Exception)
			{
				Objects[i] = "Could not deserialize the obect";
			}
		}
	}

	internal SmartStackFrame(int int_0, object[] object_0, int int_1, int int_2)
	{
		while (true)
		{
			base._002Ector();
			while (true)
			{
				MethodID = int_0;
				ExceptionStackDepth = int_2;
				if (!InpDoyGUgc5yVGYWIML())
				{
					switch (4)
					{
					case 1:
					case 5:
						break;
					case 0:
						goto end_IL_0003;
					case 4:
						goto IL_004a;
					default:
						goto IL_0051;
					case 6:
						return;
					}
					continue;
				}
				goto IL_004a;
				IL_0051:
				Objects = object_0;
				return;
				IL_004a:
				ILOffset = int_1;
				goto IL_0051;
				continue;
				end_IL_0003:
				break;
			}
		}
	}

	internal static bool NimOfMGp72aD46E3XnY()
	{
		return true;
	}

	internal static bool InpDoyGUgc5yVGYWIML()
	{
		return false;
	}
}
