using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Gecko;

internal class PropertiesDialog : Form
{
	private IContainer components = null;

	private TabControl tabControl;

	private XPTabPage pageGeneral;

	private Button btnOK;

	private Label label2;

	private Label label1;

	private Panel panel1;

	private GroupBox groupBox1;

	private Label lblModifiedDate;

	private ReadOnlyTextBox txtReferrer;

	private Label lblSize;

	private Label lblEncoding;

	private Label lblDocType;

	private Label lblContentType;

	private ReadOnlyTextBox txtAddress;

	private Label label7;

	private Label label6;

	private Label label5;

	private Label label4;

	private Label label3;

	private ReadOnlyTextBox txtTitle;

	public PropertiesDialog()
	{
		InitializeComponent();
	}

	public PropertiesDialog(nsIDOMDocument doc)
		: this()
	{
		((Control)txtTitle).set_Text(nsString.Get(doc.GetTitleAttribute));
		((Control)txtAddress).set_Text(nsString.Get(doc.GetDocumentURIAttribute));
		((Control)txtReferrer).set_Text(nsString.Get(doc.GetReferrerAttribute));
		nsIDOMDocumentType doctypeAttribute = doc.GetDoctypeAttribute();
		if (doctypeAttribute != null)
		{
			((Control)lblDocType).set_Text(nsString.Get(doctypeAttribute.GetPublicIdAttribute));
		}
		else
		{
			((Control)lblDocType).set_Text("(none)");
		}
	}

	protected override bool ProcessDialogKey(Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 112)
		{
			string text = ((object)this).GetType().Assembly.GetName().Version!.ToString();
			MessageBox.Show("GeckoFX v" + text + "\r\n\r\nhttp://bitbucket.org/geckofx/", "About GeckoFX", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return true;
		}
		return ((Form)this).ProcessDialogKey(keyData);
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected O, but got Unknown
		//IL_0bb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc2: Expected O, but got Unknown
		tabControl = new TabControl();
		pageGeneral = new XPTabPage();
		txtTitle = new ReadOnlyTextBox();
		lblModifiedDate = new Label();
		txtReferrer = new ReadOnlyTextBox();
		lblSize = new Label();
		lblEncoding = new Label();
		lblDocType = new Label();
		lblContentType = new Label();
		txtAddress = new ReadOnlyTextBox();
		label7 = new Label();
		label6 = new Label();
		label5 = new Label();
		label4 = new Label();
		label3 = new Label();
		label2 = new Label();
		label1 = new Label();
		panel1 = new Panel();
		groupBox1 = new GroupBox();
		btnOK = new Button();
		((Control)tabControl).SuspendLayout();
		((Control)pageGeneral).SuspendLayout();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)tabControl).set_Anchor((AnchorStyles)15);
		((Control)tabControl).get_Controls().Add((Control)(object)pageGeneral);
		((Control)tabControl).set_Location(new Point(6, 6));
		((Control)tabControl).set_Name("tabControl");
		tabControl.set_SelectedIndex(0);
		((Control)tabControl).set_Size(new Size(338, 350));
		((Control)tabControl).set_TabIndex(0);
		((Control)pageGeneral).get_Controls().Add((Control)(object)txtTitle);
		((Control)pageGeneral).get_Controls().Add((Control)(object)lblModifiedDate);
		((Control)pageGeneral).get_Controls().Add((Control)(object)txtReferrer);
		((Control)pageGeneral).get_Controls().Add((Control)(object)lblSize);
		((Control)pageGeneral).get_Controls().Add((Control)(object)lblEncoding);
		((Control)pageGeneral).get_Controls().Add((Control)(object)lblDocType);
		((Control)pageGeneral).get_Controls().Add((Control)(object)lblContentType);
		((Control)pageGeneral).get_Controls().Add((Control)(object)txtAddress);
		((Control)pageGeneral).get_Controls().Add((Control)(object)label7);
		((Control)pageGeneral).get_Controls().Add((Control)(object)label6);
		((Control)pageGeneral).get_Controls().Add((Control)(object)label5);
		((Control)pageGeneral).get_Controls().Add((Control)(object)label4);
		((Control)pageGeneral).get_Controls().Add((Control)(object)label3);
		((Control)pageGeneral).get_Controls().Add((Control)(object)label2);
		((Control)pageGeneral).get_Controls().Add((Control)(object)label1);
		((Control)pageGeneral).get_Controls().Add((Control)(object)panel1);
		((TabPage)pageGeneral).set_Location(new Point(4, 22));
		((Control)pageGeneral).set_Name("pageGeneral");
		((Control)pageGeneral).set_Padding(new Padding(3));
		((Control)pageGeneral).set_Size(new Size(330, 324));
		((TabPage)pageGeneral).set_TabIndex(0);
		((Control)pageGeneral).set_Text("Page");
		((TabPage)pageGeneral).set_UseVisualStyleBackColor(true);
		((TextBoxBase)txtTitle).set_BorderStyle((BorderStyle)0);
		((Control)txtTitle).set_Font(new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtTitle).set_Location(new Point(8, 16));
		((TextBoxBase)txtTitle).set_Multiline(true);
		((Control)txtTitle).set_Name("txtTitle");
		((TextBoxBase)txtTitle).set_ReadOnly(true);
		((Control)txtTitle).set_Size(new Size(300, 16));
		((Control)txtTitle).set_TabIndex(17);
		((Control)txtTitle).set_Text("Title");
		((TextBoxBase)txtTitle).set_WordWrap(false);
		((Control)lblModifiedDate).set_AutoSize(true);
		((Control)lblModifiedDate).set_Location(new Point(92, 204));
		((Control)lblModifiedDate).set_Name("lblModifiedDate");
		((Control)lblModifiedDate).set_Size(new Size(70, 13));
		((Control)lblModifiedDate).set_TabIndex(16);
		((Control)lblModifiedDate).set_Text("ModifiedDate");
		((Control)lblModifiedDate).set_Visible(false);
		((TextBoxBase)txtReferrer).set_BorderStyle((BorderStyle)0);
		((Control)txtReferrer).set_Location(new Point(92, 108));
		((TextBoxBase)txtReferrer).set_Multiline(true);
		((Control)txtReferrer).set_Name("txtReferrer");
		((TextBoxBase)txtReferrer).set_ReadOnly(true);
		((Control)txtReferrer).set_Size(new Size(234, 13));
		((Control)txtReferrer).set_TabIndex(15);
		((Control)txtReferrer).set_Text("Referrer");
		((TextBoxBase)txtReferrer).set_WordWrap(false);
		((Control)lblSize).set_AutoSize(true);
		((Control)lblSize).set_Location(new Point(92, 156));
		((Control)lblSize).set_Name("lblSize");
		((Control)lblSize).set_Size(new Size(26, 13));
		((Control)lblSize).set_TabIndex(14);
		((Control)lblSize).set_Text("Size");
		((Control)lblSize).set_Visible(false);
		((Control)lblEncoding).set_AutoSize(true);
		((Control)lblEncoding).set_Location(new Point(92, 132));
		((Control)lblEncoding).set_Name("lblEncoding");
		((Control)lblEncoding).set_Size(new Size(50, 13));
		((Control)lblEncoding).set_TabIndex(13);
		((Control)lblEncoding).set_Text("Encoding");
		((Control)lblEncoding).set_Visible(false);
		((Control)lblDocType).set_AutoSize(true);
		((Control)lblDocType).set_Location(new Point(92, 84));
		((Control)lblDocType).set_Name("lblDocType");
		((Control)lblDocType).set_Size(new Size(49, 13));
		((Control)lblDocType).set_TabIndex(12);
		((Control)lblDocType).set_Text("DocType");
		((Control)lblContentType).set_AutoSize(true);
		((Control)lblContentType).set_Location(new Point(92, 180));
		((Control)lblContentType).set_Name("lblContentType");
		((Control)lblContentType).set_Size(new Size(70, 13));
		((Control)lblContentType).set_TabIndex(11);
		((Control)lblContentType).set_Text("ContentType");
		((Control)lblContentType).set_Visible(false);
		((TextBoxBase)txtAddress).set_BorderStyle((BorderStyle)0);
		((Control)txtAddress).set_Location(new Point(92, 60));
		((TextBoxBase)txtAddress).set_Multiline(true);
		((Control)txtAddress).set_Name("txtAddress");
		((TextBoxBase)txtAddress).set_ReadOnly(true);
		((Control)txtAddress).set_Size(new Size(234, 13));
		((Control)txtAddress).set_TabIndex(10);
		((Control)txtAddress).set_Text("Address");
		((TextBoxBase)txtAddress).set_WordWrap(false);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Location(new Point(8, 204));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(74, 13));
		((Control)label7).set_TabIndex(9);
		((Control)label7).set_Text("Last Modified:");
		((Control)label7).set_Visible(false);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(8, 108));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(78, 13));
		((Control)label6).set_TabIndex(8);
		((Control)label6).set_Text("Referring URL:");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(8, 156));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(30, 13));
		((Control)label5).set_TabIndex(7);
		((Control)label5).set_Text("Size:");
		((Control)label5).set_Visible(false);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(8, 132));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(54, 13));
		((Control)label4).set_TabIndex(6);
		((Control)label4).set_Text("Encoding:");
		((Control)label4).set_Visible(false);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(8, 84));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(54, 13));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("Doc type:");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(8, 180));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(75, 13));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("Content type:");
		((Control)label2).set_Visible(false);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(8, 60));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(50, 13));
		((Control)label1).set_TabIndex(3);
		((Control)label1).set_Text("Address:");
		((Control)panel1).set_Anchor((AnchorStyles)13);
		((Control)panel1).get_Controls().Add((Control)(object)groupBox1);
		((Control)panel1).set_Location(new Point(4, 40));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(320, 16));
		((Control)panel1).set_TabIndex(2);
		((Control)groupBox1).set_Anchor((AnchorStyles)13);
		((Control)groupBox1).set_Location(new Point(-8, 0));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(338, 24));
		((Control)groupBox1).set_TabIndex(1);
		groupBox1.set_TabStop(false);
		((Control)btnOK).set_Anchor((AnchorStyles)10);
		btnOK.set_DialogResult((DialogResult)1);
		((Control)btnOK).set_Location(new Point(268, 360));
		((Control)btnOK).set_Name("btnOK");
		((Control)btnOK).set_Size(new Size(75, 23));
		((Control)btnOK).set_TabIndex(1);
		((Control)btnOK).set_Text("Close");
		((ButtonBase)btnOK).set_UseVisualStyleBackColor(true);
		((Form)this).set_AcceptButton((IButtonControl)(object)btnOK);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)btnOK);
		((Form)this).set_ClientSize(new Size(350, 390));
		((Control)this).get_Controls().Add((Control)(object)btnOK);
		((Control)this).get_Controls().Add((Control)(object)tabControl);
		((Control)this).set_Font(new Font("Tahoma", 8.25f));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("PropertiesDialog");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("Properties");
		((Control)tabControl).ResumeLayout(false);
		((Control)pageGeneral).ResumeLayout(false);
		((Control)pageGeneral).PerformLayout();
		((Control)panel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
