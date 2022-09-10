using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Main;

public class FormBackground : Form
{
	private IContainer components;

	private Timer timerActivateChecker;

	public FormBackground()
	{
		//Discarded unreachable code: IL_0012, IL_0018, IL_0023, IL_0029
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		_003F val;
		do
		{
			checked
			{
				val = unchecked(/*Error near IL_0001: Stack underflow*/ % /*Error near IL_0001: Stack underflow*/) + /*Error near IL_0002: ldloc 0 (out-of-bounds)*/;
			}
		}
		while ((int)/*Error near IL_000a: Stack underflow*/ < (int)(sbyte)val);
		/*Error near IL_000d: Invalid metadata token*/;
	}

	private extern void timerActivateChecker_Tick(object sender, EventArgs e);

	private unsafe static void ImposeRestrictions()
	{
		//Discarded unreachable code: IL_001d, IL_0023, IL_0025
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_001e: Invalid comparison between Unknown and O
		while (true)
		{
			/*Error near IL_0001: stloc 2 (out-of-bounds)*/;
			if (/*Error near IL_0008: Stack underflow*/ != /*Error near IL_0008: Stack underflow*/)
			{
				_ = (byte)/*Error near IL_0009: Stack underflow*/;
				long num = checked((long)/*Error near IL_000d: Stack underflow*/);
				_003F val = /*Error near IL_000f: Stack underflow*/+ (float)num;
				*(IntPtr*)(nint)(/*Error near IL_0010: Stack underflow*/ + val) = (IntPtr)2;
				int num2 = *(int*)checked((ulong)/*Error near IL_0014: Stack underflow*/);
				if ((int)/*Error near IL_001a: Stack underflow*/ >= num2)
				{
					break;
				}
			}
		}
		_ = ((sbyte[])/*Error near IL_001b: Stack underflow*/)[/*Error near IL_001b: Stack underflow*/];
		/*Error near IL_001c: Unknown opcode: 0xFC*/;
	}

	protected override extern void Dispose(bool disposing);

	private extern void InitializeComponent();
}
