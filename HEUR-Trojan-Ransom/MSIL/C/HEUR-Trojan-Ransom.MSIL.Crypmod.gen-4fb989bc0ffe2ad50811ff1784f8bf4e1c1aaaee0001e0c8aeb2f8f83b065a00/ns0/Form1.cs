using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using X;

namespace ns0;

public class Form1 : Form
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 422)]
	private struct U
	{
	}

	internal const int int_0 = 5377;

	private Button M;

	private Button Q_1;

	private Button E_1;

	private static readonly Array array_0;

	private static readonly object object_0 = new char[211];

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

	internal IContainer E;

	internal Button Q;

	internal TextBox N;

	internal NumericUpDown O;

	internal TextBox I;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int SendMessage(IntPtr intptr_0, int int_1, int int_2, [MarshalAs(UnmanagedType.LPWStr)] string string_0);

	public Form1()
	{
		InitializeComponent();
		SendMessage(((Control)N).get_Handle(), 5377, 1, "Please type your name here...");
		SendMessage(((Control)N).get_Handle(), 5377, 1, "Please type your your age here...");
	}

	internal static byte[] smethod_0(byte[] byte_1, byte[] byte_2)
	{
		int num = 0;
		for (int i = 0; i < byte_1.Length; i++)
		{
			num = X.M.smethod_0(byte_1, num, byte_2, i);
		}
		return byte_1;
	}

	protected override void vmethod_0(bool bool_0)
	{
		if (bool_0 && E != null)
		{
			E.Dispose();
		}
		((Form)this).Dispose(bool_0);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		Button val = (Q = new Button());
		TextBox val2 = (N = new TextBox());
		M = new Button();
		NumericUpDown val3 = (O = new NumericUpDown());
		TextBox val4 = (I = new TextBox());
		Q_1 = new Button();
		E_1 = new Button();
		((ISupportInitialize)O).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Q).set_Location(new Point(75, 12));
		((Control)Q).set_Name("A");
		((Control)Q).set_Size(new Size(75, 23));
		((Control)Q).set_TabIndex(0);
		((Control)Q).set_Text("Enter Name");
		((ButtonBase)Q).set_UseVisualStyleBackColor(true);
		((Control)N).set_Location(new Point(12, 41));
		((Control)N).set_Name("D");
		((Control)N).set_Size(new Size(209, 20));
		((Control)N).set_TabIndex(1);
		((Control)M).set_Location(new Point(75, 80));
		((Control)M).set_Name("M");
		((Control)M).set_Size(new Size(75, 23));
		((Control)M).set_TabIndex(2);
		((Control)M).set_Text("Enter Age");
		((ButtonBase)M).set_UseVisualStyleBackColor(true);
		((Control)O).set_Location(new Point(12, 109));
		((Control)O).set_Name("H");
		((Control)O).set_Size(new Size(209, 20));
		((Control)O).set_TabIndex(3);
		((Control)I).set_Location(new Point(12, 177));
		((Control)I).set_Name("K");
		((Control)I).set_Size(new Size(209, 20));
		((Control)I).set_TabIndex(5);
		((Control)Q_1).set_Location(new Point(75, 148));
		((Control)Q_1).set_Name("Q");
		((Control)Q_1).set_Size(new Size(75, 23));
		((Control)Q_1).set_TabIndex(4);
		((Control)Q_1).set_Text("Enter Your Location");
		((ButtonBase)Q_1).set_UseVisualStyleBackColor(true);
		E_1.set_DialogResult((DialogResult)1);
		((Control)E_1).set_Location(new Point(40, 241));
		((Control)E_1).set_Name("E");
		((Control)E_1).set_Size(new Size(124, 23));
		((Control)E_1).set_TabIndex(6);
		((Control)E_1).set_Text("Calculate Family Tree");
		((ButtonBase)E_1).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(262, 276));
		((Control)this).get_Controls().Add((Control)(object)E_1);
		((Control)this).get_Controls().Add((Control)(object)I);
		((Control)this).get_Controls().Add((Control)(object)Q_1);
		((Control)this).get_Controls().Add((Control)(object)O);
		((Control)this).get_Controls().Add((Control)(object)M);
		((Control)this).get_Controls().Add((Control)(object)N);
		((Control)this).get_Controls().Add((Control)(object)Q);
		((Form)this).set_HelpButton(true);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((ISupportInitialize)O).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	static Form1()
	{
		char[] array = new char[8];
		array[2] = 'ᥒ';
		array[6] = 'ᓞ';
		array[7] = 'ၻ';
		array[0] = '⇠';
		array[5] = '\u1c2a';
		array[4] = '㩗';
		array[1] = '\u0cb4';
		array[3] = '㋞';
		object_1 = new string[17];
		array_0 = array;
	}
}
