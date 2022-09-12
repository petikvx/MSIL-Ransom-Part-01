using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FaturaDecryptor;

public class KeyValidationWindow : Form
{
	private const int PublicPrivateKeyLength = 2440;

	public string PublicPrivateKey = string.Empty;

	private IContainer components;

	private RichTextBox DecryptionKeyTxt;

	private Label label1;

	private Button SubmitDecryptionKeyBtn;

	public KeyValidationWindow()
	{
		InitializeComponent();
	}

	private void SubmitDecryptionKeyBtn_Click(object sender, EventArgs e)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)DecryptionKeyTxt).get_Text().Length == 2440)
		{
			string text = DecodeString(((Control)DecryptionKeyTxt).get_Text());
			if (text != null && text.Contains("<RSAKeyValue>"))
			{
				PublicPrivateKey = text;
				((Form)this).Close();
			}
			else
			{
				MessageBox.Show("The decryption key has bad format.", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
		else
		{
			MessageBox.Show("The decryption key has bad format.", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private string DecodeString(string str)
	{
		try
		{
			return GetString(Convert.FromBase64String(str));
		}
		catch (Exception)
		{
			return null;
		}
	}

	private string GetString(byte[] bytes)
	{
		char[] array = new char[bytes.Length / 2];
		Buffer.BlockCopy(bytes, 0, array, 0, bytes.Length);
		return new string(array);
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
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		DecryptionKeyTxt = new RichTextBox();
		label1 = new Label();
		SubmitDecryptionKeyBtn = new Button();
		((Control)this).SuspendLayout();
		((Control)DecryptionKeyTxt).set_Anchor((AnchorStyles)15);
		((Control)DecryptionKeyTxt).set_Font(new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)DecryptionKeyTxt).set_Location(new Point(14, 33));
		((Control)DecryptionKeyTxt).set_Name("DecryptionKeyTxt");
		((Control)DecryptionKeyTxt).set_Size(new Size(462, 227));
		((Control)DecryptionKeyTxt).set_TabIndex(0);
		((Control)DecryptionKeyTxt).set_Text("");
		((Control)label1).set_Anchor((AnchorStyles)13);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label1).set_Location(new Point(10, 10));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(240, 15));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Şifre çözme anahtarınızı buraya yapıştırın :");
		((Control)SubmitDecryptionKeyBtn).set_Anchor((AnchorStyles)14);
		((Control)SubmitDecryptionKeyBtn).set_Font(new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)SubmitDecryptionKeyBtn).set_Location(new Point(14, 278));
		((Control)SubmitDecryptionKeyBtn).set_Name("SubmitDecryptionKeyBtn");
		((Control)SubmitDecryptionKeyBtn).set_Size(new Size(463, 46));
		((Control)SubmitDecryptionKeyBtn).set_TabIndex(2);
		((Control)SubmitDecryptionKeyBtn).set_Text("Şifre Çözme İşlemin Başlat");
		((ButtonBase)SubmitDecryptionKeyBtn).set_UseVisualStyleBackColor(true);
		((Control)SubmitDecryptionKeyBtn).add_Click((EventHandler)SubmitDecryptionKeyBtn_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 15f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(491, 339));
		((Control)this).get_Controls().Add((Control)(object)SubmitDecryptionKeyBtn);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)DecryptionKeyTxt);
		((Control)this).set_Font(new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("KeyValidationWindow");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Anahtar Doğrulayıcı");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
