using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FC2ServerLauncher;

public class FormFind : Form
{
	private IContainer components;

	private Button buttonFind;

	private TextBox textBoxFind;

	private string toFind = "";

	public string ToFind
	{
		get
		{
			return toFind;
		}
		set
		{
			toFind = value;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormFind));
		buttonFind = new Button();
		textBoxFind = new TextBox();
		((Control)this).SuspendLayout();
		((Control)buttonFind).set_Anchor((AnchorStyles)10);
		((Control)buttonFind).set_Location(new Point(205, 46));
		((Control)buttonFind).set_Name("buttonFind");
		((Control)buttonFind).set_Size(new Size(75, 23));
		((Control)buttonFind).set_TabIndex(0);
		((Control)buttonFind).set_Text("Find");
		((ButtonBase)buttonFind).set_UseVisualStyleBackColor(true);
		((Control)buttonFind).add_Click((EventHandler)buttonFind_Click);
		((Control)textBoxFind).set_Anchor((AnchorStyles)13);
		((Control)textBoxFind).set_Location(new Point(13, 13));
		((Control)textBoxFind).set_Name("textBoxFind");
		((Control)textBoxFind).set_Size(new Size(267, 20));
		((Control)textBoxFind).set_TabIndex(1);
		((Control)textBoxFind).add_KeyDown(new KeyEventHandler(textBoxFind_KeyDown));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(292, 81));
		((Control)this).get_Controls().Add((Control)(object)textBoxFind);
		((Control)this).get_Controls().Add((Control)(object)buttonFind);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("FormFind");
		((Control)this).set_Text("Find");
		((Form)this).add_Shown((EventHandler)FormFind_Shown);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public FormFind()
	{
		InitializeComponent();
	}

	private void FormFind_Shown(object sender, EventArgs e)
	{
		((Control)textBoxFind).set_Text(ToFind);
		((TextBoxBase)textBoxFind).Select(0, ((Control)textBoxFind).get_Text().Length);
		((Control)textBoxFind).Focus();
	}

	private void buttonFind_Click(object sender, EventArgs e)
	{
		ToFind = ((Control)textBoxFind).get_Text();
		((Form)this).Close();
	}

	private void textBoxFind_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			buttonFind_Click(null, null);
		}
	}
}
