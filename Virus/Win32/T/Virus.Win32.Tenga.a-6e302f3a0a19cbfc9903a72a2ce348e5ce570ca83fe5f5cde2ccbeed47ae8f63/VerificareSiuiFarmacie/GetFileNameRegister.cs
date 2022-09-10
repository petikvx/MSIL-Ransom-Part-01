using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VerificareSiuiFarmacie;

public class GetFileNameRegister : Form
{
	private IContainer icontainer_0 = null;

	private Button btnOk;

	private Button btnAbandon;

	private Label lblNumeFisier;

	private TextBox txtNumeFisier;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private string string_0;

	public bool Cancelled
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public string FileName
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public GetFileNameRegister()
	{
		InitializeComponent();
	}

	public GetFileNameRegister(string fileName)
		: this()
	{
		((Control)txtNumeFisier).set_Text(fileName);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
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
		btnOk = new Button();
		btnAbandon = new Button();
		lblNumeFisier = new Label();
		txtNumeFisier = new TextBox();
		((Control)this).SuspendLayout();
		((Control)btnOk).set_Anchor((AnchorStyles)10);
		((Control)btnOk).set_Location(new Point(292, 60));
		((Control)btnOk).set_Name("btnOk");
		((Control)btnOk).set_Size(new Size(75, 23));
		((Control)btnOk).set_TabIndex(2);
		((Control)btnOk).set_Text("&Ok");
		((ButtonBase)btnOk).set_UseVisualStyleBackColor(true);
		((Control)btnOk).add_Click((EventHandler)btnOk_Click);
		((Control)btnAbandon).set_Anchor((AnchorStyles)10);
		btnAbandon.set_DialogResult((DialogResult)2);
		((Control)btnAbandon).set_Location(new Point(373, 60));
		((Control)btnAbandon).set_Name("btnAbandon");
		((Control)btnAbandon).set_Size(new Size(75, 23));
		((Control)btnAbandon).set_TabIndex(3);
		((Control)btnAbandon).set_Text("&Abandon");
		((ButtonBase)btnAbandon).set_UseVisualStyleBackColor(true);
		((Control)btnAbandon).add_Click((EventHandler)btnAbandon_Click);
		((Control)lblNumeFisier).set_AutoSize(true);
		((Control)lblNumeFisier).set_Location(new Point(13, 13));
		((Control)lblNumeFisier).set_Name("lblNumeFisier");
		((Control)lblNumeFisier).set_Size(new Size(133, 13));
		((Control)lblNumeFisier).set_TabIndex(0);
		((Control)lblNumeFisier).set_Text("Specificati numele fisierului");
		((Control)txtNumeFisier).set_Location(new Point(16, 30));
		((Control)txtNumeFisier).set_Name("txtNumeFisier");
		((Control)txtNumeFisier).set_Size(new Size(427, 20));
		((Control)txtNumeFisier).set_TabIndex(1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)btnAbandon);
		((Form)this).set_ClientSize(new Size(460, 95));
		((Control)this).get_Controls().Add((Control)(object)txtNumeFisier);
		((Control)this).get_Controls().Add((Control)(object)lblNumeFisier);
		((Control)this).get_Controls().Add((Control)(object)btnAbandon);
		((Control)this).get_Controls().Add((Control)(object)btnOk);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("GetFileNameRegister");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Nume fisier test register");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void btnAbandon_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void btnOk_Click(object sender, EventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(((Control)txtNumeFisier).get_Text()))
		{
			MessageBox.Show("Nu ati specificat numele fisierului!");
			return;
		}
		Cancelled = false;
		FileName = ((Control)txtNumeFisier).get_Text();
		((Form)this).Close();
	}
}
