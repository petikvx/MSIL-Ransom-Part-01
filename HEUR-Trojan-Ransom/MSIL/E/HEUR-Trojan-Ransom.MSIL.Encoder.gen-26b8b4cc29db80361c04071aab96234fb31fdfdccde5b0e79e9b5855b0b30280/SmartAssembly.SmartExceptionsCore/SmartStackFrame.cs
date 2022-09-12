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
		_ = _001A_0002._007E_0082_0004;
		_000E._0003._0001(107394934);
		_ = (object)((SmartStackFrame)/*Error near IL_001e: Stack underflow*/).MethodID;
		_0083._0005_0003(typeof(int).TypeHandle);
		/*Error near IL_01b5: Stack underflow*/((object)/*Error near IL_01b5: Stack underflow*/, (string)/*Error near IL_01b5: Stack underflow*/, (object)/*Error near IL_01b5: Stack underflow*/, (Type)/*Error near IL_01b5: Stack underflow*/);
		_ = _001A_0002._007E_0082_0004;
		_000E._0003._0001(107394897);
		_ = (object)((SmartStackFrame)/*Error near IL_0055: Stack underflow*/).ILOffset;
		_0083._0005_0003(typeof(int).TypeHandle);
		/*Error near IL_006e: Stack underflow*/((object)/*Error near IL_006e: Stack underflow*/, (string)/*Error near IL_006e: Stack underflow*/, (object)/*Error near IL_006e: Stack underflow*/, (Type)/*Error near IL_006e: Stack underflow*/);
		_001A_0002._007E_0082_0004(P_0, _000E._0003._0001(107394828), ExceptionStackDepth, _0083._0005_0003(typeof(int).TypeHandle));
		int num = ((Objects != null) ? Objects.Length : 0);
		_001A_0002._007E_0082_0004(P_0, _000E._0003._0001(107394295), num, _0083._0005_0003(typeof(int).TypeHandle));
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
				string text = _001B_0002._0083_0004(_000E._0003._0001(107394218), num2);
				try
				{
					if (Objects[num2] == null)
					{
						_001A_0002._007E_0082_0004(P_0, text, null, _0083._0005_0003(typeof(object).TypeHandle));
					}
					else
					{
						P_0.AddValue(text, _0093._007E_008F_0003(Objects[num2])?.ToString() + _000E._0003._0001(107394205) + Objects[num2], _0083._0005_0003(typeof(string).TypeHandle));
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
		MethodID = P_0.GetInt32(_000E._0003._0001(107394934));
		ILOffset = P_0.GetInt32(_000E._0003._0001(107394897));
		ExceptionStackDepth = P_0.GetInt32(_000E._0003._0001(107394828));
		int @int = P_0.GetInt32(_000E._0003._0001(107394295));
		Objects = new object[@int];
		for (int i = 0; i < @int; i++)
		{
			try
			{
				Objects[i] = P_0.GetValue(string.Format(_000E._0003._0001(107394218), i), typeof(string));
			}
			catch (Exception)
			{
				Objects[i] = _000E._0003._0001(107394200);
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
