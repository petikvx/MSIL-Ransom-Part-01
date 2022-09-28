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

	internal extern KeyboardSimulator(GInterface1 ginterface1_0, IInputMessageDispatcher iinputMessageDispatcher_0);

	public GInterface2 KeyDown(GEnum3 keyCode)
	{
		//Discarded unreachable code: IL_0005, IL_000d, IL_0013, IL_001e
		//IL_0008: Invalid comparison between I4 and Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
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

	public extern GInterface2 KeyPress(params GEnum3[] keyCodes);

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

	public GInterface2 ModifiedKeyStroke(IEnumerable<GEnum3> modifierKeyCodes, GEnum3 keyCode)
	{
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ != 0 && /*Error near IL_000b: Stack underflow*/>= /*Error near IL_000b: Stack underflow*/)
			{
				((IntPtr[])/*Error near IL_000f: Stack underflow*/)[3] = (IntPtr)1;
				int num = checked((int)/*Error near IL_0010: Stack underflow*/);
				if ((int)/*Error near IL_0015: Stack underflow*/ != num)
				{
					break;
				}
			}
		}
		int num2 = checked((int)/*Error near IL_0018: Stack underflow*/);
		_ = /*Error near IL_0019: Stack underflow*/<< num2;
		/*Error: Unexpected end of block*/;
	}

	GInterface2 GInterface2.imethod_5(IEnumerable<GEnum3> modifierKeyCodes, GEnum3 keyCode)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ModifiedKeyStroke
		return this.ModifiedKeyStroke(modifierKeyCodes, keyCode);
	}

	public extern GInterface2 ModifiedKeyStroke(GEnum3 modifierKey, IEnumerable<GEnum3> keyCodes);

	GInterface2 GInterface2.imethod_6(GEnum3 modifierKey, IEnumerable<GEnum3> keyCodes)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ModifiedKeyStroke
		return this.ModifiedKeyStroke(modifierKey, keyCodes);
	}

	public extern GInterface2 ModifiedKeyStroke(IEnumerable<GEnum3> modifierKeyCodes, IEnumerable<GEnum3> keyCodes);

	GInterface2 GInterface2.imethod_4(IEnumerable<GEnum3> modifierKeyCodes, IEnumerable<GEnum3> keyCodes)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ModifiedKeyStroke
		return this.ModifiedKeyStroke(modifierKeyCodes, keyCodes);
	}

	public GInterface2 TextEntry(string text)
	{
		//Discarded unreachable code: IL_000b
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		uint num = checked((uint)/*Error near IL_0001: Stack underflow*/);
		((int[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (int)num;
		checked
		{
			_ = (ulong)/*Error near IL_0006: Stack underflow*/;
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	GInterface2 GInterface2.imethod_8(string text)
	{
		//ILSpy generated this explicit interface implementation from .override directive in TextEntry
		return this.TextEntry(text);
	}

	public GInterface2 TextEntry(char character)
	{
		_ = 5;
		/*Error near IL_0001: Invalid metadata token*/;
	}

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

	private void ModifiersDown(Class8 builder, IEnumerable<GEnum3> modifierKeyCodes)
	{
		//Discarded unreachable code: IL_0001, IL_0006, IL_000b, IL_0013
		/*Error: Unknown opcode: 0xF9*/;
	}

	private extern void ModifiersUp(Class8 builder, IEnumerable<GEnum3> modifierKeyCodes);

	private extern void KeysPress(Class8 builder, IEnumerable<GEnum3> keyCodes);

	private extern void SendSimulatedInput(INPUT[] inputList);

	static extern ArgumentNullException smethod_0(string string_0);

	static extern Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0);

	static string smethod_2(MemberInfo memberInfo_0)
	{
		//Discarded unreachable code: IL_000d, IL_0012, IL_0017
		//IL_0008: Incompatible stack heights: 0 vs 3
		checked
		{
			while (true)
			{
				_ = (byte)/*Error near IL_0001: ldloc 1 (out-of-bounds)*/;
				/*Error near IL_0006: ldarg 2 (out-of-bounds)*/;
				_ = 7;
			}
		}
	}

	unsafe static string smethod_3(string string_0, object object_0, object object_1, object object_2)
	{
		//IL_0004: Expected F4, but got I4
		int num = *(ushort*)(nint)/*Error near IL_0001: Stack underflow*/;
		((float[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = num;
		/*Error: Unexpected end of block*/;
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
