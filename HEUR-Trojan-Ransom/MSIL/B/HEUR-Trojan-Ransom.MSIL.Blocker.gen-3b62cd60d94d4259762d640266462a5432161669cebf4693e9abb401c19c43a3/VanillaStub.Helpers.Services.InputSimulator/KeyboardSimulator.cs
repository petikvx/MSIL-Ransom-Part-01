using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using VanillaStub.Helpers.Services.InputSimulator.Native;

namespace VanillaStub.Helpers.Services.InputSimulator;

public class KeyboardSimulator : GInterface2
{
	private readonly GInterface1 _inputSimulator;

	private readonly IInputMessageDispatcher _messageDispatcher;

	extern GInterface3 GInterface2.GInterface3_0 { get; }

	public extern KeyboardSimulator(GInterface1 ginterface1_0);

	internal KeyboardSimulator(GInterface1 ginterface1_0, IInputMessageDispatcher iinputMessageDispatcher_0)
	{
		//Discarded unreachable code: IL_0014, IL_001a, IL_0034
		//IL_0003: Expected I4, but got O
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unsupported input type for neg.
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got I8
		//IL_002f: Invalid comparison between I4 and Unknown
		//IL_002f: Incompatible stack heights: 0 vs 1
		_003F val3;
		do
		{
			((sbyte[])/*Error near IL_0003: Stack underflow*/)[(object)this] = (sbyte)(int)this;
			_003F val = /*Error near IL_0005: Stack underflow*/& -1;
			short num = ((short[])/*Error near IL_0006: Stack underflow*/)[val];
			_003F val2 = /*Error near IL_0007: Stack underflow*/+ num;
			val3 = /*Error near IL_0009: Stack underflow*/& (0 - val2);
		}
		while (/*Error near IL_000f: Stack underflow*/ >= val3);
		/*Error near IL_000f: Invalid metadata token*/;
	}

	public unsafe GInterface2 KeyDown(GEnum3 keyCode)
	{
		//Discarded unreachable code: IL_000e, IL_0013, IL_0018, IL_001e
		//IL_0003: Expected I8, but got F4
		//IL_0007: Expected I4, but got F4
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		float num = *(float*)(nint)/*Error near IL_0002: Stack underflow*/;
		*(long*)(nint)/*Error near IL_0003: Stack underflow*/ = (long)num;
		float num2 = *(float*)(int)(uint)/*Error near IL_0004: Stack underflow*/;
		*(sbyte*)(nint)/*Error near IL_0007: Stack underflow*/ = (sbyte)(int)num2;
		long num3 = checked((long)/*Error near IL_0008: Stack underflow*/);
		_ = ((object[])/*Error near IL_0009: Stack underflow*/)[num3];
		/*Error near IL_0009: Invalid metadata token*/;
	}

	GInterface2 GInterface2.imethod_0(GEnum3 keyCode)
	{
		//ILSpy generated this explicit interface implementation from .override directive in KeyDown
		return this.KeyDown(keyCode);
	}

	public extern GInterface2 KeyUp(GEnum3 keyCode);

	GInterface2 GInterface2.imethod_3(GEnum3 keyCode)
	{
		//ILSpy generated this explicit interface implementation from .override directive in KeyUp
		return this.KeyUp(keyCode);
	}

	public extern GInterface2 KeyPress(GEnum3 keyCode);

	GInterface2 GInterface2.imethod_1(GEnum3 keyCode)
	{
		//ILSpy generated this explicit interface implementation from .override directive in KeyPress
		return this.KeyPress(keyCode);
	}

	public unsafe GInterface2 KeyPress(params GEnum3[] keyCodes)
	{
		//Discarded unreachable code: IL_000b, IL_0010
		while (*(ushort*)(-1) == 0)
		{
		}
		checked
		{
			_ = (ulong)(uint)/*Error near IL_0008: Stack underflow*/;
			/*Error near IL_000a: Unknown opcode: 0xFB*/;
		}
	}

	GInterface2 GInterface2.imethod_2(params GEnum3[] keyCodes)
	{
		//ILSpy generated this explicit interface implementation from .override directive in KeyPress
		return this.KeyPress(keyCodes);
	}

	public extern GInterface2 ModifiedKeyStroke(GEnum3 modifierKeyCode, GEnum3 keyCode);

	GInterface2 GInterface2.imethod_7(GEnum3 modifierKeyCode, GEnum3 keyCode)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ModifiedKeyStroke
		return this.ModifiedKeyStroke(modifierKeyCode, keyCode);
	}

	public extern GInterface2 ModifiedKeyStroke(IEnumerable<GEnum3> modifierKeyCodes, GEnum3 keyCode);

	GInterface2 GInterface2.imethod_5(IEnumerable<GEnum3> modifierKeyCodes, GEnum3 keyCode)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ModifiedKeyStroke
		return this.ModifiedKeyStroke(modifierKeyCodes, keyCode);
	}

	public unsafe GInterface2 ModifiedKeyStroke(GEnum3 modifierKey, IEnumerable<GEnum3> keyCodes)
	{
		//Discarded unreachable code: IL_000f
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected I4, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		byte num = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		byte num2 = *(byte*)(nint)(/*Error near IL_0003: Stack underflow*/ / num);
		_003F val = /*Error near IL_0005: Stack underflow*/% num2;
		*(int*)(nint)/*Error near IL_0006: Stack underflow*/ = (int)val;
		checked
		{
			_ = (sbyte)(/*Error near IL_0008: Stack underflow*/ >> unchecked((int)/*Error near IL_0008: Stack underflow*/));
			/*Error near IL_000a: Invalid metadata token*/;
		}
	}

	GInterface2 GInterface2.imethod_6(GEnum3 modifierKey, IEnumerable<GEnum3> keyCodes)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ModifiedKeyStroke
		return this.ModifiedKeyStroke(modifierKey, keyCodes);
	}

	public GInterface2 ModifiedKeyStroke(IEnumerable<GEnum3> modifierKeyCodes, IEnumerable<GEnum3> keyCodes)
	{
		throw /*Error near IL_0001: Stack underflow*/;
	}

	GInterface2 GInterface2.imethod_4(IEnumerable<GEnum3> modifierKeyCodes, IEnumerable<GEnum3> keyCodes)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ModifiedKeyStroke
		return this.ModifiedKeyStroke(modifierKeyCodes, keyCodes);
	}

	public extern GInterface2 TextEntry(string text);

	GInterface2 GInterface2.imethod_8(string text)
	{
		//ILSpy generated this explicit interface implementation from .override directive in TextEntry
		return this.TextEntry(text);
	}

	public extern GInterface2 TextEntry(char character);

	GInterface2 GInterface2.imethod_9(char character)
	{
		//ILSpy generated this explicit interface implementation from .override directive in TextEntry
		return this.TextEntry(character);
	}

	public extern GInterface2 Sleep(int millsecondsTimeout);

	GInterface2 GInterface2.imethod_10(int millsecondsTimeout)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Sleep
		return this.Sleep(millsecondsTimeout);
	}

	public extern GInterface2 Sleep(TimeSpan timeout);

	GInterface2 GInterface2.imethod_11(TimeSpan timeout)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Sleep
		return this.Sleep(timeout);
	}

	private extern void ModifiersDown(Class8 builder, IEnumerable<GEnum3> modifierKeyCodes);

	private unsafe void ModifiersUp(Class8 builder, IEnumerable<GEnum3> modifierKeyCodes)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			sbyte num = checked((sbyte)(/*Error near IL_0003: Stack underflow*/ ^ /*Error near IL_0003: Stack underflow*/));
			*(short*)(nint)/*Error near IL_0005: Stack underflow*/ = num;
			val = /*Error near IL_0006: Stack underflow*/+ /*Error near IL_0006: Stack underflow*/;
		}
		while (/*Error near IL_000b: Stack underflow*/ == val);
		/*Error: Unexpected end of block*/;
	}

	private extern void KeysPress(Class8 builder, IEnumerable<GEnum3> keyCodes);

	private extern void SendSimulatedInput(INPUT[] inputList);

	static extern ArgumentNullException smethod_0(string string_0);

	unsafe static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		//Discarded unreachable code: IL_000b, IL_0010, IL_0018, IL_001d, IL_0022
		//IL_0001: Invalid comparison between Unknown and F4
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			float num = *(float*)(nint)/*Error near IL_0001: Stack underflow*/;
			if ((float)/*Error near IL_0006: Stack underflow*/ > num)
			{
			}
		}
	}

	static extern string smethod_2(MemberInfo memberInfo_0);

	static string smethod_3(string string_0, object object_0, object object_1, object object_2)
	{
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
			{
				/*Error: Could not find block for branch target IL_0005*/;
			}
		}
	}

	static extern InvalidOperationException smethod_4(string string_0);

	static extern int smethod_5(string string_0);

	static extern string smethod_6(string string_0, object object_0);

	static extern ArgumentException smethod_7(string string_0, string string_1);

	static extern void smethod_8(int int_0);

	static extern void smethod_9(TimeSpan timeSpan_0);

	static extern bool smethod_10(IEnumerator ienumerator_0);

	static extern void smethod_11(IDisposable idisposable_0);
}
