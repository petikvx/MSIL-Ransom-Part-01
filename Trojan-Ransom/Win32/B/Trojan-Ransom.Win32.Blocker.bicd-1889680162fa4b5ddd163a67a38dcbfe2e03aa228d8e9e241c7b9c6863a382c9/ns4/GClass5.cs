using System;
using System.Runtime.Serialization;
using System.Security;

namespace ns4;

[Serializable]
public class GClass5 : ISerializable
{
	public readonly int int_0;

	public readonly object[] object_0;

	public readonly int int_1;

	public readonly int int_2;

	[SecurityCritical]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("UnhandledException.MethodID", int_0, typeof(int));
		info.AddValue("UnhandledException.ILOffset", int_1, typeof(int));
		info.AddValue("UnhandledException.ExceptionStackDepth", int_2, typeof(int));
		int num = ((object_0 != null) ? object_0.Length : 0);
		info.AddValue("UnhandledException.Objects.Length", num, typeof(int));
		for (int i = 0; i < num; i++)
		{
			string name = $"UnhandledException.Objects[{i}]";
			try
			{
				if (object_0[i] == null)
				{
					info.AddValue(name, null, typeof(object));
				}
				else
				{
					info.AddValue(name, string.Concat(object_0[i].GetType(), " - ", object_0[i]), typeof(string));
				}
			}
			catch (Exception)
			{
			}
		}
	}

	internal GClass5(int int_3, object[] object_1, int int_4, int int_5)
	{
		int_0 = int_3;
		int_2 = int_5;
		int_1 = int_4;
		object_0 = object_1;
	}

	static GClass5()
	{
		GClass11.smethod_0();
	}
}
