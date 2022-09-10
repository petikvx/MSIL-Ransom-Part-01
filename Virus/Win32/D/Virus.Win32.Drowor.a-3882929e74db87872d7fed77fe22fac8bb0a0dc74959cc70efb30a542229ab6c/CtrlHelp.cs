using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class CtrlHelp : UserControl
{
	private string string_0 = "";

	private IContainer icontainer_0;

	private GClass9 panelHelp;

	private Label lblHelp;

	[SpecialName]
	public string method_0()
	{
		return string_0;
	}

	[SpecialName]
	public void method_1(string string_1)
	{
		string_0 = string_1;
		method_2();
	}

	public CtrlHelp()
	{
		InitializeComponent();
		method_2();
	}

	public void method_2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		ToolTip val = new ToolTip();
		val.set_InitialDelay(0);
		val.set_IsBalloon(true);
		val.set_AutomaticDelay(500000);
		val.set_AutoPopDelay(500000);
		val.SetToolTip((Control)(object)panelHelp, string_0);
		val = new ToolTip();
		val.set_InitialDelay(0);
		val.set_IsBalloon(true);
		val.set_AutomaticDelay(500000);
		val.set_AutoPopDelay(500000);
		val.SetToolTip((Control)(object)this, string_0);
		val = new ToolTip();
		val.set_InitialDelay(0);
		val.set_IsBalloon(true);
		val.set_AutomaticDelay(500000);
		val.set_AutoPopDelay(500000);
		val.SetToolTip((Control)(object)lblHelp, string_0);
	}

	private void lblHelp_Click(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		method_2();
		MessageBox.Show(method_0());
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		panelHelp = new GClass9();
		lblHelp = new Label();
		((Control)panelHelp).SuspendLayout();
		((Control)this).SuspendLayout();
		panelHelp.method_1(Color.DarkSeaGreen);
		panelHelp.method_9(Color.Black);
		panelHelp.method_7((BorderStyle)1);
		((Control)panelHelp).get_Controls().Add((Control)(object)lblHelp);
		panelHelp.method_13(10);
		((Control)panelHelp).set_Dock((DockStyle)5);
		((Control)panelHelp).set_Location(new Point(0, 0));
		((Control)panelHelp).set_Name("panelHelp");
		((Control)panelHelp).set_Size(new Size(24, 23));
		((Control)panelHelp).set_TabIndex(0);
		((Control)lblHelp).set_Dock((DockStyle)5);
		((Control)lblHelp).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblHelp).set_ForeColor(Color.White);
		((Control)lblHelp).set_Location(new Point(0, 0));
		((Control)lblHelp).set_Name("lblHelp");
		((Control)lblHelp).set_Size(new Size(24, 23));
		((Control)lblHelp).set_TabIndex(0);
		((Control)lblHelp).set_Text(" ?");
		lblHelp.set_TextAlign((ContentAlignment)32);
		((Control)lblHelp).add_Click((EventHandler)lblHelp_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).get_Controls().Add((Control)(object)panelHelp);
		((Control)this).set_Name("CtrlHelp");
		((Control)this).set_Size(new Size(24, 23));
		((Control)panelHelp).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
