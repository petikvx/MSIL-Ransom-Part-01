using System;
using System.Reflection;
using VanillaStub.Helpers.Services.InputSimulator.Native;

namespace VanillaStub.Helpers.Services.InputSimulator;

public class MouseSimulator : GInterface3
{
	private const int MouseWheelClickSize = 120;

	private readonly GInterface1 _inputSimulator;

	private readonly IInputMessageDispatcher _messageDispatcher;

	extern GInterface2 GInterface3.GInterface2_0 { get; }

	public unsafe MouseSimulator(GInterface1 ginterface1_0)
	{
		do
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		}
		while (*(object*)(int)checked((ushort)/*Error near IL_0001: ldloc 1 (out-of-bounds)*/) == null);
		/*Error near IL_000a: Invalid metadata token*/;
	}

	internal extern MouseSimulator(GInterface1 ginterface1_0, IInputMessageDispatcher iinputMessageDispatcher_0);

	public extern GInterface3 MoveMouseBy(int pixelDeltaX, int pixelDeltaY);

	GInterface3 GInterface3.imethod_0(int pixelDeltaX, int pixelDeltaY)
	{
		//ILSpy generated this explicit interface implementation from .override directive in MoveMouseBy
		return this.MoveMouseBy(pixelDeltaX, pixelDeltaY);
	}

	public GInterface3 MoveMouseTo(double absoluteX, double absoluteY)
	{
		/*Error near IL_0001: Invalid metadata token*/;
	}

	GInterface3 GInterface3.imethod_1(double absoluteX, double absoluteY)
	{
		//ILSpy generated this explicit interface implementation from .override directive in MoveMouseTo
		return this.MoveMouseTo(absoluteX, absoluteY);
	}

	public extern GInterface3 MoveMouseToPositionOnVirtualDesktop(double absoluteX, double absoluteY);

	GInterface3 GInterface3.imethod_2(double absoluteX, double absoluteY)
	{
		//ILSpy generated this explicit interface implementation from .override directive in MoveMouseToPositionOnVirtualDesktop
		return this.MoveMouseToPositionOnVirtualDesktop(absoluteX, absoluteY);
	}

	public extern GInterface3 LeftButtonDown();

	GInterface3 GInterface3.imethod_3()
	{
		//ILSpy generated this explicit interface implementation from .override directive in LeftButtonDown
		return this.LeftButtonDown();
	}

	public extern GInterface3 LeftButtonUp();

	GInterface3 GInterface3.imethod_4()
	{
		//ILSpy generated this explicit interface implementation from .override directive in LeftButtonUp
		return this.LeftButtonUp();
	}

	public extern GInterface3 LeftButtonClick();

	GInterface3 GInterface3.imethod_5()
	{
		//ILSpy generated this explicit interface implementation from .override directive in LeftButtonClick
		return this.LeftButtonClick();
	}

	public extern GInterface3 LeftButtonDoubleClick();

	GInterface3 GInterface3.imethod_6()
	{
		//ILSpy generated this explicit interface implementation from .override directive in LeftButtonDoubleClick
		return this.LeftButtonDoubleClick();
	}

	public extern GInterface3 RightButtonDown();

	GInterface3 GInterface3.imethod_7()
	{
		//ILSpy generated this explicit interface implementation from .override directive in RightButtonDown
		return this.RightButtonDown();
	}

	public extern GInterface3 RightButtonUp();

	GInterface3 GInterface3.imethod_8()
	{
		//ILSpy generated this explicit interface implementation from .override directive in RightButtonUp
		return this.RightButtonUp();
	}

	public extern GInterface3 RightButtonClick();

	GInterface3 GInterface3.imethod_9()
	{
		//ILSpy generated this explicit interface implementation from .override directive in RightButtonClick
		return this.RightButtonClick();
	}

	public extern GInterface3 RightButtonDoubleClick();

	GInterface3 GInterface3.imethod_10()
	{
		//ILSpy generated this explicit interface implementation from .override directive in RightButtonDoubleClick
		return this.RightButtonDoubleClick();
	}

	public extern GInterface3 XButtonDown(int buttonId);

	GInterface3 GInterface3.imethod_11(int buttonId)
	{
		//ILSpy generated this explicit interface implementation from .override directive in XButtonDown
		return this.XButtonDown(buttonId);
	}

	public extern GInterface3 XButtonUp(int buttonId);

	GInterface3 GInterface3.imethod_12(int buttonId)
	{
		//ILSpy generated this explicit interface implementation from .override directive in XButtonUp
		return this.XButtonUp(buttonId);
	}

	public extern GInterface3 XButtonClick(int buttonId);

	GInterface3 GInterface3.imethod_13(int buttonId)
	{
		//ILSpy generated this explicit interface implementation from .override directive in XButtonClick
		return this.XButtonClick(buttonId);
	}

	public extern GInterface3 XButtonDoubleClick(int buttonId);

	GInterface3 GInterface3.imethod_14(int buttonId)
	{
		//ILSpy generated this explicit interface implementation from .override directive in XButtonDoubleClick
		return this.XButtonDoubleClick(buttonId);
	}

	public GInterface3 VerticalScroll(int scrollAmountInClicks)
	{
		//Discarded unreachable code: IL_001c
		//IL_0001: Invalid comparison between Unknown and I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Incompatible stack heights: 0 vs 1
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 5)
			{
				continue;
			}
			long num = ((long[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/];
			_ = ((byte[])/*Error near IL_000a: Stack underflow*/)[num];
			if (/*Error near IL_0010: Stack underflow*/ >= /*Error near IL_0010: Stack underflow*/)
			{
				if ((int)/*Error near IL_0012: Stack underflow*/ == 0)
				{
					_ = (double)(/*Error near IL_0013: Stack underflow*/ - /*Error near IL_0013: Stack underflow*/) >> 4;
					/*Error near IL_0017: Invalid metadata token*/;
				}
				_003F val = checked(/*Error near IL_001f: Stack underflow*/ + 1);
				if (/*Error near IL_0024: Stack underflow*/ <= val)
				{
					break;
				}
			}
		}
		short num2 = checked((short)/*Error near IL_0025: Stack underflow*/);
		_ = ((long[])/*Error near IL_0026: Stack underflow*/)[num2];
		/*Error: Unexpected end of block*/;
	}

	GInterface3 GInterface3.imethod_15(int scrollAmountInClicks)
	{
		//ILSpy generated this explicit interface implementation from .override directive in VerticalScroll
		return this.VerticalScroll(scrollAmountInClicks);
	}

	public extern GInterface3 HorizontalScroll(int scrollAmountInClicks);

	GInterface3 GInterface3.imethod_16(int scrollAmountInClicks)
	{
		//ILSpy generated this explicit interface implementation from .override directive in HorizontalScroll
		return this.HorizontalScroll(scrollAmountInClicks);
	}

	public extern GInterface3 Sleep(int millsecondsTimeout);

	GInterface3 GInterface3.imethod_17(int millsecondsTimeout)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Sleep
		return this.Sleep(millsecondsTimeout);
	}

	public extern GInterface3 Sleep(TimeSpan timeout);

	GInterface3 GInterface3.imethod_18(TimeSpan timeout)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Sleep
		return this.Sleep(timeout);
	}

	private extern void SendSimulatedInput(INPUT[] inputList);

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

	static double smethod_5(double double_0)
	{
		//Discarded unreachable code: IL_0005, IL_0007, IL_000d, IL_0015, IL_0018
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_6(int int_0);

	static extern void smethod_7(TimeSpan timeSpan_0);
}
