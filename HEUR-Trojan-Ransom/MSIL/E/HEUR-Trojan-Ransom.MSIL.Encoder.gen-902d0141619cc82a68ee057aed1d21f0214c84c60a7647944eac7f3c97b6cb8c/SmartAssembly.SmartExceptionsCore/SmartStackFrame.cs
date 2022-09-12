using System;
using System.Runtime.Serialization;
using System.Security;
using _000E;

namespace SmartAssembly.SmartExceptionsCore;

[Serializable]
public sealed class SmartStackFrame : ISerializable
{
	public readonly int MethodID;

	public readonly object[] Objects;

	public readonly int ILOffset;

	public readonly int ExceptionStackDepth;

	[SecurityCritical]
	public virtual void GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		//IL_0191: Incompatible stack heights: 0 vs 2
		//IL_019b: Incompatible stack heights: 0 vs 1
		//IL_01a1: Incompatible stack heights: 0 vs 1
		//IL_01ab: Incompatible stack heights: 0 vs 2
		//IL_01bb: Incompatible stack heights: 0 vs 2
		//IL_01c5: Incompatible stack heights: 0 vs 1
		//IL_01cb: Incompatible stack heights: 0 vs 1
		//IL_01d5: Incompatible stack heights: 0 vs 2
		_ = _0017_0002._007E_001F_0004;
		_000E._0003._0001(107394924);
		_ = (object)((SmartStackFrame)/*Error near IL_001e: Stack underflow*/).MethodID;
		_001F._009E_0002(typeof(int).TypeHandle);
		/*Error near IL_01b5: Stack underflow*/((object)/*Error near IL_01b5: Stack underflow*/, (string)/*Error near IL_01b5: Stack underflow*/, (object)/*Error near IL_01b5: Stack underflow*/, (Type)/*Error near IL_01b5: Stack underflow*/);
		_ = _0017_0002._007E_001F_0004;
		_000E._0003._0001(107394887);
		_ = (object)((SmartStackFrame)/*Error near IL_0055: Stack underflow*/).ILOffset;
		_001F._009E_0002(typeof(int).TypeHandle);
		/*Error near IL_006e: Stack underflow*/((object)/*Error near IL_006e: Stack underflow*/, (string)/*Error near IL_006e: Stack underflow*/, (object)/*Error near IL_006e: Stack underflow*/, (Type)/*Error near IL_006e: Stack underflow*/);
		_0017_0002._007E_001F_0004(P_0, _000E._0003._0001(107394850), ExceptionStackDepth, _001F._009E_0002(typeof(int).TypeHandle));
		int num = ((Objects != null) ? Objects.Length : 0);
		_0017_0002._007E_001F_0004(P_0, _000E._0003._0001(107394285), num, _001F._009E_0002(typeof(int).TypeHandle));
		int num2 = 0;
		while (true)
		{
			int num3 = num2;
			do
			{
				if (num3 >= num)
				{
					return;
				}
				string text = _0018_0002._007F_0004(_000E._0003._0001(107394240), num2);
				try
				{
					if (Objects[num2] == null)
					{
						_0017_0002._007E_001F_0004(P_0, text, null, _001F._009E_0002(typeof(object).TypeHandle));
					}
					else
					{
						P_0.AddValue(text, _008F._007E_008A_0003(Objects[num2])?.ToString() + _000E._0003._0001(107394227) + Objects[num2], _001F._009E_0002(typeof(string).TypeHandle));
					}
				}
				catch (Exception)
				{
				}
				num3 = num2;
			}
			while (4 == 0);
			num2 = num3 + 1;
		}
	}

	internal SmartStackFrame(SerializationInfo P_0, StreamingContext P_1)
	{
		MethodID = P_0.GetInt32(_000E._0003._0001(107394924));
		ILOffset = P_0.GetInt32(_000E._0003._0001(107394887));
		ExceptionStackDepth = P_0.GetInt32(_000E._0003._0001(107394850));
		int @int = P_0.GetInt32(_000E._0003._0001(107394285));
		Objects = new object[@int];
		for (int i = 0; i < @int; i++)
		{
			try
			{
				Objects[i] = P_0.GetValue(string.Format(_000E._0003._0001(107394240), i), typeof(string));
			}
			catch (Exception)
			{
				Objects[i] = _000E._0003._0001(107394190);
			}
		}
	}

	internal SmartStackFrame(int P_0, object[] P_1, int P_2, int P_3)
	{
		MethodID = P_0;
		ExceptionStackDepth = P_3;
		ILOffset = P_2;
		Objects = P_1;
	}
}
