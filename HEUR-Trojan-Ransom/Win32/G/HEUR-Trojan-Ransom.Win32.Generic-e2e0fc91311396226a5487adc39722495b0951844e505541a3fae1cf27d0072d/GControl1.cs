using System;
using System.Drawing;
using System.Windows.Forms;

public abstract class GControl1 : Control
{
	protected extern GControl1();

	private extern Rectangle method_0(IDeviceContext ideviceContext_0, TextFormatFlags textFormatFlags_0);

	private unsafe TextFormatFlags method_1()
	{
		//Discarded unreachable code: IL_000c, IL_0013
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		object obj = *(object*)(nint)/*Error near IL_0002: Stack underflow*/;
		checked
		{
			_003F val = /*Error near IL_0003: Stack underflow*/+ obj;
			_ = (long)(/*Error near IL_0004: Stack underflow*/ * val);
			_ = 5;
			/*Error near IL_0007: Invalid metadata token*/;
		}
	}

	public abstract void vmethod_0(GEventArgs1 geventArgs1_0);

	protected unsafe sealed override void OnPaint(PaintEventArgs e)
	{
		//Discarded unreachable code: IL_000c, IL_0012, IL_001a, IL_0020, IL_0025, IL_002f, IL_0036
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected F8, but got I
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		_003F val = checked(/*Error near IL_0002: Stack underflow*/ * /*Error near IL_0002: Stack underflow*/);
		((double[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (nint)(nuint)val;
		int num = *(int*)((short)/*Error near IL_0005: Stack underflow*/ % 0);
		_ = ((IntPtr[])/*Error near IL_000b: Stack underflow*/)[num];
		/*Error near IL_000b: Unknown opcode: 0xF9*/;
	}

	protected override extern void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified);

	internal static extern Graphics smethod_0<T>(T gparam_0, int int_0, char char_0) where T : PaintEventArgs;

	static extern Graphics smethod_1(PaintEventArgs paintEventArgs_0);
}
