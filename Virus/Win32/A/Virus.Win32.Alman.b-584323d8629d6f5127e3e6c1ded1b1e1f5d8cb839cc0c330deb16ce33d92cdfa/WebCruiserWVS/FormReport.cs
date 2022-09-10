using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace WebCruiserWVS;

public class FormReport : Form
{
	private FormMain formMain_0;

	private IContainer icontainer_0;

	private TextBox txtReportAuthor;

	private Label label22;

	private Button btnGenReport;

	public FormReport(FormMain formMain_1)
	{
		//Discarded unreachable code: IL_0004, IL_0005, IL_0006, IL_0007, IL_000c, IL_0011, IL_0024, IL_0029, IL_002e
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got I
		/*Error near IL_0003: Unknown opcode: 0xFF*/;
	}

	private unsafe void btnGenReport_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got I
		_003F val;
		do
		{
			float num = (float)/*Error near IL_0001: Stack underflow*/;
			val = /*Error near IL_0002: Stack underflow*/& num;
		}
		while (/*Error near IL_0007: Stack underflow*/ == val);
		uint num2;
		checked
		{
			num2 = (uint)unchecked((int)checked((byte)unchecked((nuint)(int)checked((byte)/*Error near IL_0009: Stack underflow*/))));
		}
		_ = *(IntPtr*)(nint)(/*Error near IL_000e: Stack underflow*/ | num2);
		this = (FormReport)(*(nint*)2);
		/*Error near IL_0015: Invalid metadata token*/;
	}

	private extern string method_0(XmlDocument xmlDocument_0);

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_1()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		txtReportAuthor = new TextBox();
		label22 = new Label();
		btnGenReport = new Button();
		((Control)this).SuspendLayout();
		((Control)txtReportAuthor).set_Location(new Point(80, 54));
		((Control)txtReportAuthor).set_Name("txtReportAuthor");
		((Control)txtReportAuthor).set_Size(new Size(210, 21));
		((Control)txtReportAuthor).set_TabIndex(5);
		((Control)txtReportAuthor).set_Text("WebCruiser");
		((Control)label22).set_AutoSize(true);
		((Control)label22).set_Location(new Point(20, 57));
		((Control)label22).set_Name("label22");
		((Control)label22).set_Size(new Size(47, 12));
		((Control)label22).set_TabIndex(4);
		((Control)label22).set_Text("Made By");
		((Control)btnGenReport).set_Location(new Point(317, 52));
		((Control)btnGenReport).set_Name("btnGenReport");
		((Control)btnGenReport).set_Size(new Size(127, 23));
		((Control)btnGenReport).set_TabIndex(3);
		((Control)btnGenReport).set_Text("Generate Report");
		((ButtonBase)btnGenReport).set_UseVisualStyleBackColor(true);
		((Control)btnGenReport).add_Click((EventHandler)btnGenReport_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.Window);
		((Form)this).set_ClientSize(new Size(486, 317));
		((Control)this).get_Controls().Add((Control)(object)txtReportAuthor);
		((Control)this).get_Controls().Add((Control)(object)label22);
		((Control)this).get_Controls().Add((Control)(object)btnGenReport);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("FormReport");
		((Control)this).set_Text("FormReport");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
