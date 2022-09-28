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

	public extern GInterface3 MoveMouseTo(double absoluteX, double absoluteY);

	GInterface3 GInterface3.imethod_1(double absoluteX, double absoluteY)
	{
		//ILSpy generated this explicit interface implementation from .override directive in MoveMouseTo
		return this.MoveMouseTo(absoluteX, absoluteY);
	}

	public GInterface3 MoveMouseToPositionOnVirtualDesktop(double absoluteX, double absoluteY)
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_0010
		//IL_0006: Invalid comparison between Unknown and I4
		/*Error: Invalid metadata token*/;
	}

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

	public GInterface3 LeftButtonUp()
	{
		//Discarded unreachable code: IL_000a
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
		{
		}
		/*Error near IL_0005: Invalid metadata token*/;
	}

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

	static extern double smethod_5(double double_0);

	static extern void smethod_6(int int_0);

	static extern void smethod_7(TimeSpan timeSpan_0);
}
