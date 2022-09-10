using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PtoP;

public class setPortForm : Form
{
	private GroupBox groupBox1;

	private Button ok;

	private TextBox portnum;

	private Container components;

	public extern setPortForm();

	protected override extern void Dispose(bool disposing);

	private extern void InitializeComponent();

	private extern void ok_Click(object sender, EventArgs e);

	private unsafe void setPortForm_Load(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_001e
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected I, but got I8
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			int num = ((int[])/*Error near IL_0002: Stack underflow*/)[val];
			((IntPtr[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (IntPtr)num;
			*(_003F*)(nint)/*Error near IL_0005: Stack underflow*/ = /*Error near IL_0005: Stack underflow*/;
			*(_003F*)(nint)/*Error near IL_0006: Stack underflow*/ = /*Error near IL_0006: Stack underflow*/;
		}
		while (/*Error near IL_000c: Stack underflow*/ <= /*Error near IL_000c: Stack underflow*/|| /*Error near IL_0013: Stack underflow*/> /*Error near IL_0013: Stack underflow*/);
		checked
		{
			_ = (ulong)unchecked((uint)(~checked((sbyte)/*Error near IL_0015: Stack underflow*/)));
			_ = 0;
			/*Error near IL_0019: Invalid metadata token*/;
		}
	}

	private extern void portnum_KeyDown(object sender, KeyEventArgs e);
}
