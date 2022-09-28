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

	public KeyboardSimulator(GInterface1 ginterface1_0)
	{
		//Discarded unreachable code: IL_000e, IL_000f
		//IL_0009: Expected I4, but got I8
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
		{
		}
		long num = ((long[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/];
		((short[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/] = (short)num;
		/*Error near IL_0009: Invalid metadata token*/;
	}

	internal extern KeyboardSimulator(GInterface1 ginterface1_0, IInputMessageDispatcher iinputMessageDispatcher_0);

	public GInterface2 KeyDown(GEnum3 keyCode)
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
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

	public GInterface2 KeyPress(params GEnum3[] keyCodes)
	{
		//Discarded unreachable code: IL_0008, IL_000d
		checked
		{
			_ = (uint)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: stloc 0 (out-of-bounds)*/;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	GInterface2 GInterface2.imethod_2(params GEnum3[] keyCodes)
	{
		//ILSpy generated this explicit interface implementation from .override directive in KeyPress
		return this.KeyPress(keyCodes);
	}

	public unsafe GInterface2 ModifiedKeyStroke(GEnum3 modifierKeyCode, GEnum3 keyCode)
	{
		//Discarded unreachable code: IL_000a, IL_0010, IL_0016, IL_0018, IL_0021, IL_002b
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I8, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		int num = *(int*)((Array)/*Error near IL_0001: Stack underflow*/).LongLength;
		((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (sbyte)num;
		/*Error near IL_0005: Invalid metadata token*/;
	}

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

	public extern GInterface2 TextEntry(string text);

	GInterface2 GInterface2.imethod_8(string text)
	{
		//ILSpy generated this explicit interface implementation from .override directive in TextEntry
		return this.TextEntry(text);
	}

	public unsafe GInterface2 TextEntry(char character)
	{
		//Discarded unreachable code: IL_0024, IL_002f
		//IL_0007: Incompatible stack heights: 0 vs 1
		//IL_0012: Expected native int or pointer, but got O
		//IL_0013: Invalid comparison between Unknown and O
		//IL_0018: Incompatible stack heights: 0 vs 1
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected I, but got F4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		uint num;
		do
		{
			IL_0000:
			checked
			{
				if (/*Error near IL_0002: Stack underflow*/ <= /*Error near IL_0002: Stack underflow*/)
				{
					_ = (uint)/*Error near IL_0003: Stack underflow*/;
					if (0 != 3)
					{
						goto IL_0000;
					}
					/*Error near IL_000c: stloc 0 (out-of-bounds)*/;
					unchecked
					{
						*(_003F*)(nint)/*Error near IL_000f: Stack underflow*/ = /*Error near IL_000f: Stack underflow*/;
						object obj = *(object*)(nint)((object[])/*Error near IL_0010: Stack underflow*/)[/*Error near IL_0010: Stack underflow*/];
						if (/*Error near IL_0018: Stack underflow*/ <= obj)
						{
							goto IL_0000;
						}
					}
					_ = (nuint)/*Error near IL_0019: Stack underflow*/;
				}
				num = ((uint[])/*Error near IL_001a: Stack underflow*/)[/*Error near IL_001a: Stack underflow*/];
			}
		}
		while ((int)/*Error near IL_001f: Stack underflow*/ >= (int)num);
		/*Error near IL_001f: Invalid metadata token*/;
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

	private unsafe void ModifiersDown(Class8 builder, IEnumerable<GEnum3> modifierKeyCodes)
	{
		//Discarded unreachable code: IL_0006, IL_000c
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	private extern void ModifiersUp(Class8 builder, IEnumerable<GEnum3> modifierKeyCodes);

	private extern void KeysPress(Class8 builder, IEnumerable<GEnum3> keyCodes);

	private void SendSimulatedInput(INPUT[] inputList)
	{
		//Discarded unreachable code: IL_0005, IL_000c, IL_0011, IL_0013, IL_0019
		/*Error: Invalid metadata token*/;
	}

	static extern ArgumentNullException smethod_0(string string_0);

	static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		//Discarded unreachable code: IL_0006
		_ = (uint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern string smethod_2(MemberInfo memberInfo_0);

	static extern string smethod_3(string string_0, object object_0, object object_1, object object_2);

	static extern InvalidOperationException smethod_4(string string_0);

	static extern int smethod_5(string string_0);

	static string smethod_6(string string_0, object object_0)
	{
		//Discarded unreachable code: IL_0006, IL_0007, IL_000d, IL_0012
		//IL_0008: Invalid comparison between Unknown and O
		checked
		{
			_ = (short)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	static ArgumentException smethod_7(string string_0, string string_1)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0021, IL_0027, IL_002f, IL_0038
		//IL_000e: Expected O, but got I4
		//IL_0017: Expected I4, but got F8
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I4, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and F4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		/*Error: stloc 1 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_8(int int_0);

	static extern void smethod_9(TimeSpan timeSpan_0);

	static extern bool smethod_10(IEnumerator ienumerator_0);

	static extern void smethod_11(IDisposable idisposable_0);
}
