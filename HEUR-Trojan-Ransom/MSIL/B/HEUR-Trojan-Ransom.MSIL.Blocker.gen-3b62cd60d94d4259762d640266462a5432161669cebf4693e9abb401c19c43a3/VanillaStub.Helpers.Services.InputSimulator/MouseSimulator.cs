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

	public extern MouseSimulator(GInterface1 ginterface1_0);

	internal extern MouseSimulator(GInterface1 ginterface1_0, IInputMessageDispatcher iinputMessageDispatcher_0);

	public extern GInterface3 MoveMouseBy(int pixelDeltaX, int pixelDeltaY);

	GInterface3 GInterface3.imethod_0(int pixelDeltaX, int pixelDeltaY)
	{
		//ILSpy generated this explicit interface implementation from .override directive in MoveMouseBy
		return this.MoveMouseBy(pixelDeltaX, pixelDeltaY);
	}

	public GInterface3 MoveMouseTo(double absoluteX, double absoluteY)
	{
		//Discarded unreachable code: IL_000c, IL_0012, IL_0018, IL_001e, IL_0024
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (int)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: stloc 3 (out-of-bounds)*/;
		}
		((IntPtr[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = (IntPtr)/*Error near IL_0007: Stack underflow*/;
		/*Error near IL_0007: Invalid metadata token*/;
	}

	GInterface3 GInterface3.imethod_1(double absoluteX, double absoluteY)
	{
		//ILSpy generated this explicit interface implementation from .override directive in MoveMouseTo
		return this.MoveMouseTo(absoluteX, absoluteY);
	}

	public GInterface3 MoveMouseToPositionOnVirtualDesktop(double absoluteX, double absoluteY)
	{
		//Discarded unreachable code: IL_0010
		//IL_0012: Expected I4, but got I8
		checked
		{
			_ = (ulong)/*Error near IL_0001: Stack underflow*/;
			_ = -6510229482622377493L;
			_ = -1057214358;
			/*Error near IL_000f: Unknown opcode: 0xFC*/;
		}
	}

	GInterface3 GInterface3.imethod_2(double absoluteX, double absoluteY)
	{
		//ILSpy generated this explicit interface implementation from .override directive in MoveMouseToPositionOnVirtualDesktop
		return this.MoveMouseToPositionOnVirtualDesktop(absoluteX, absoluteY);
	}

	public unsafe GInterface3 LeftButtonDown()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		_ = 6;
		/*Error: Unexpected end of block*/;
	}

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

	public unsafe GInterface3 XButtonUp(int buttonId)
	{
		//Discarded unreachable code: IL_000d, IL_0012, IL_0017, IL_0023
		//IL_0003: Invalid comparison between Unknown and I8
		//IL_000c: Expected F4, but got I4
		ulong num2;
		do
		{
			int num = checked((int)/*Error near IL_0001: Stack underflow*/);
			*(short*)(nint)/*Error near IL_0002: Stack underflow*/ = (short)num;
			num2 = (ulong)/*Error near IL_0003: Stack underflow*/;
		}
		while ((long)/*Error near IL_0008: Stack underflow*/ > (long)num2);
		*(_003F*)(nint)/*Error near IL_000a: Stack underflow*/ = /*Error near IL_000a: Stack underflow*/;
		short num3 = (short)/*Error near IL_000b: Stack underflow*/;
		*(float*)(nint)/*Error near IL_000c: Stack underflow*/ = num3;
		/*Error near IL_000c: Unknown opcode: 0xFD*/;
	}

	GInterface3 GInterface3.imethod_12(int buttonId)
	{
		//ILSpy generated this explicit interface implementation from .override directive in XButtonUp
		return this.XButtonUp(buttonId);
	}

	public GInterface3 XButtonClick(int buttonId)
	{
		//Discarded unreachable code: IL_0006
		/*Error near IL_0001: Invalid metadata token*/;
	}

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

	public extern GInterface3 VerticalScroll(int scrollAmountInClicks);

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

	static extern double smethod_5(double double_0);

	static extern void smethod_6(int int_0);

	static extern void smethod_7(TimeSpan timeSpan_0);
}
