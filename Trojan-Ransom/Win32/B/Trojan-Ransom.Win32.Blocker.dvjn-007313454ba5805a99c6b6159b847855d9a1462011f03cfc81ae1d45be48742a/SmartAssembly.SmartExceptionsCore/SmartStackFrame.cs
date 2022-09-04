using System;
using System.Runtime.Serialization;
using ProwxkN4F4ab5Fc8FL;

namespace SmartAssembly.SmartExceptionsCore;

[Serializable]
public sealed class SmartStackFrame : ISerializable
{
	public readonly int MethodID;

	public readonly object[] Objects;

	public readonly int ILOffset;

	public readonly int ExceptionStackDepth;

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(680904), MethodID, typeof(int));
		info.AddValue(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(680941), ILOffset, typeof(int));
		info.AddValue(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(680978), ExceptionStackDepth, typeof(int));
		int num = ((Objects != null) ? Objects.Length : 0);
		info.AddValue(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681031), num, typeof(int));
		for (int i = 0; i < num; i++)
		{
			string name = string.Format(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681076), i);
			try
			{
				if (Objects[i] == null)
				{
					info.AddValue(name, null, typeof(object));
				}
				else
				{
					info.AddValue(name, string.Concat(Objects[i].GetType(), DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681121), Objects[i]), typeof(string));
				}
			}
			catch (Exception)
			{
			}
		}
	}

	internal SmartStackFrame(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
	{
		MethodID = serializationInfo_0.GetInt32(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(680904));
		ILOffset = serializationInfo_0.GetInt32(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(680941));
		ExceptionStackDepth = serializationInfo_0.GetInt32(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(680978));
		int @int = serializationInfo_0.GetInt32(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681031));
		Objects = new object[@int];
		for (int i = 0; i < @int; i++)
		{
			try
			{
				Objects[i] = serializationInfo_0.GetValue(string.Format(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681076), i), typeof(string));
			}
			catch (Exception)
			{
				Objects[i] = DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681126);
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
				if (!V70YWS48p42X4Ioe6X4())
				{
					switch (6)
					{
					case 2:
						break;
					case 0:
					case 5:
						goto end_IL_0003;
					case 6:
						ExceptionStackDepth = int_2;
						goto default;
					default:
						ILOffset = int_1;
						goto IL_0057;
					case 4:
						goto IL_0057;
					case 7:
						return;
					}
					continue;
				}
				goto IL_0057;
				IL_0057:
				Objects = object_0;
				return;
				continue;
				end_IL_0003:
				break;
			}
		}
	}

	internal static bool WTVGDR47qVOJLRfAtCO()
	{
		return true;
	}

	internal static bool V70YWS48p42X4Ioe6X4()
	{
		return false;
	}
}
