using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Gecko;

internal class PromptDialog : Form
{
	private IContainer components = null;

	private Label label;

	private Button btnOK;

	private Button btnCancel;

	private TextBox txtResult;

	private CheckBox checkBox;

	public string Result => ((Control)txtResult).get_Text();

	public bool IsChecked => checkBox.get_Checked();

	public PromptDialog()
	{
		InitializeComponent();
	}

	public PromptDialog(string title, string message, string original, string checkMessage)
		: this()
	{
		((Control)this).set_Text(title);
		((Control)label).set_Text(message);
		((Control)txtResult).set_Text(original);
		if (!string.IsNullOrEmpty(checkMessage))
		{
			((Control)checkBox).set_Text(checkMessage);
			return;
		}
		((Form)this).set_ClientSize(new Size(((Form)this).get_ClientSize().Width, ((Control)checkBox).get_Top() - 4));
		((Control)checkBox).set_Visible(false);
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		label = new Label();
		btnOK = new Button();
		btnCancel = new Button();
		txtResult = new TextBox();
		checkBox = new CheckBox();
		((Control)this).SuspendLayout();
		((Control)label).set_Location(new Point(8, 8));
		((Control)label).set_Name("label");
		((Control)label).set_Size(new Size(328, 52));
		((Control)label).set_TabIndex(0);
		((Control)label).set_Text("label");
		btnOK.set_DialogResult((DialogResult)1);
		((Control)btnOK).set_Location(new Point(340, 8));
		((Control)btnOK).set_Name("btnOK");
		((Control)btnOK).set_Size(new Size(75, 23));
		((Control)btnOK).set_TabIndex(3);
		((Control)btnOK).set_Text("OK");
		((ButtonBase)btnOK).set_UseVisualStyleBackColor(true);
		btnCancel.set_DialogResult((DialogResult)2);
		((Control)btnCancel).set_Location(new Point(340, 36));
		((Control)btnCancel).set_Name("btnCancel");
		((Control)btnCancel).set_Size(new Size(75, 23));
		((Control)btnCancel).set_TabIndex(4);
		((Control)btnCancel).set_Text("Cancel");
		((ButtonBase)btnCancel).set_UseVisualStyleBackColor(true);
		((Control)txtResult).set_Location(new Point(8, 68));
		((Control)txtResult).set_Name("txtResult");
		((Control)txtResult).set_Size(new Size(408, 21));
		((Control)txtResult).set_TabIndex(1);
		((Control)checkBox).set_AutoSize(true);
		((Control)checkBox).set_Location(new Point(8, 100));
		((Control)checkBox).set_Name("checkBox");
		((Control)checkBox).set_Size(new Size(15, 14));
		((Control)checkBox).set_TabIndex(2);
		((ButtonBase)checkBox).set_UseVisualStyleBackColor(true);
		((Form)this).set_AcceptButton((IButtonControl)(object)btnOK);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)btnCancel);
		((Form)this).set_ClientSize(new Size(423, 123));
		((Control)this).get_Controls().Add((Control)(object)checkBox);
		((Control)this).get_Controls().Add((Control)(object)txtResult);
		((Control)this).get_Controls().Add((Control)(object)btnCancel);
		((Control)this).get_Controls().Add((Control)(object)btnOK);
		((Control)this).get_Controls().Add((Control)(object)label);
		((Control)this).set_Font(new Font("Tahoma", 8.25f));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("PromptDialog");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("Javascript Prompt");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
