using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace rensenWare;

public class frmManualDecrypter : Form
{
	private byte[] Key;

	private byte[] IV;

	private IContainer components;

	private Label label1;

	private Label label2;

	private Label KeyPath;

	private Label IVPath;

	private Button ButtonKey;

	private Button ButtonIV;

	private Button StartDecrypt;

	private Label DecryptStatus;

	private ProgressBar ProgressDecrypt;

	private ListBox DecryptedList;

	public frmManualDecrypter()
	{
		InitializeComponent();
	}

	private void ButtonKey_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_Title("Open Key File");
		((FileDialog)val).set_Filter("Key/IV Binary File (*.bin)|*.bin");
		OpenFileDialog val2 = val;
		if ((int)((CommonDialog)val2).ShowDialog() == 1)
		{
			((Control)KeyPath).set_Text(((FileDialog)val2).get_FileName());
			Key = File.ReadAllBytes(((FileDialog)val2).get_FileName());
			if (Key.Length != 32)
			{
				MessageBox.Show("Invalid Key File!");
			}
		}
		else
		{
			Key = null;
		}
		((Control)StartDecrypt).set_Enabled((Key == null || IV == null) ? true : false);
	}

	private void StartDecrypt_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_Title("Open Multiple Encrypted Files");
		((FileDialog)val).set_Filter("All (*.*)|*.*");
		val.set_Multiselect(true);
		OpenFileDialog val2 = val;
		if ((int)((CommonDialog)val2).ShowDialog() != 1)
		{
			return;
		}
		string[] files = ((FileDialog)val2).get_FileNames();
		ProgressDecrypt.set_Value(0);
		ProgressDecrypt.set_Maximum(files.Length);
		new Thread((ThreadStart)delegate
		{
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Expected O, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			string[] array = files;
			foreach (string path in array)
			{
				try
				{
					((Control)DecryptStatus).Invoke((Delegate)(MethodInvoker)delegate
					{
						((Control)DecryptStatus).set_Text(Path.GetFileName(path));
					});
					Program.Crypt(path, IsDecrypt: true);
					((Control)ProgressDecrypt).Invoke((Delegate)(MethodInvoker)delegate
					{
						ProgressBar progressDecrypt = ProgressDecrypt;
						int value = progressDecrypt.get_Value();
						progressDecrypt.set_Value(value + 1);
					});
					((Control)DecryptedList).Invoke((Delegate)(MethodInvoker)delegate
					{
						DecryptedList.get_Items().Add((object)path);
						((ListControl)DecryptedList).set_SelectedIndex(DecryptedList.get_Items().get_Count() - 1);
					});
				}
				catch
				{
					((Control)DecryptedList).Invoke((Delegate)(MethodInvoker)delegate
					{
						DecryptedList.get_Items().Add((object)("FAIL : " + path));
						((ListControl)DecryptedList).set_SelectedIndex(DecryptedList.get_Items().get_Count() - 1);
					});
				}
			}
		}).Start();
	}

	private void ButtonIV_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_Title("Open IV File");
		((FileDialog)val).set_Filter("Key/IV Binary File (*.bin)|*.bin");
		OpenFileDialog val2 = val;
		if ((int)((CommonDialog)val2).ShowDialog() == 1)
		{
			((Control)IVPath).set_Text(((FileDialog)val2).get_FileName());
			Key = File.ReadAllBytes(((FileDialog)val2).get_FileName());
			if (Key.Length != 16)
			{
				MessageBox.Show("Invalid IV File!");
			}
		}
		else
		{
			IV = null;
		}
		((Control)StartDecrypt).set_Enabled((Key == null || IV == null) ? true : false);
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected O, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected O, but got Unknown
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected O, but got Unknown
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected O, but got Unknown
		label1 = new Label();
		label2 = new Label();
		KeyPath = new Label();
		IVPath = new Label();
		ButtonKey = new Button();
		ButtonIV = new Button();
		StartDecrypt = new Button();
		DecryptStatus = new Label();
		ProgressDecrypt = new ProgressBar();
		DecryptedList = new ListBox();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Consolas", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(13, 15));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(84, 15));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Key File : ");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Consolas", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(13, 45));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(84, 15));
		((Control)label2).set_TabIndex(0);
		((Control)label2).set_Text("IV File  : ");
		((Control)KeyPath).set_Font(new Font("Consolas", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)KeyPath).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)KeyPath).set_Location(new Point(95, 17));
		((Control)KeyPath).set_Name("KeyPath");
		((Control)KeyPath).set_Size(new Size(193, 14));
		((Control)KeyPath).set_TabIndex(1);
		((Control)IVPath).set_Font(new Font("Consolas", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)IVPath).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)IVPath).set_Location(new Point(95, 48));
		((Control)IVPath).set_Name("IVPath");
		((Control)IVPath).set_Size(new Size(193, 14));
		((Control)IVPath).set_TabIndex(1);
		((Control)ButtonKey).set_Font(new Font("Consolas", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)ButtonKey).set_Location(new Point(294, 13));
		((Control)ButtonKey).set_Name("ButtonKey");
		((Control)ButtonKey).set_Size(new Size(75, 27));
		((Control)ButtonKey).set_TabIndex(2);
		((Control)ButtonKey).set_Text("Browse...");
		((ButtonBase)ButtonKey).set_UseVisualStyleBackColor(true);
		((Control)ButtonKey).add_Click((EventHandler)ButtonKey_Click);
		((Control)ButtonIV).set_Font(new Font("Consolas", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)ButtonIV).set_Location(new Point(294, 43));
		((Control)ButtonIV).set_Name("ButtonIV");
		((Control)ButtonIV).set_Size(new Size(75, 27));
		((Control)ButtonIV).set_TabIndex(2);
		((Control)ButtonIV).set_Text("Browse...");
		((ButtonBase)ButtonIV).set_UseVisualStyleBackColor(true);
		((Control)ButtonIV).add_Click((EventHandler)ButtonIV_Click);
		((Control)StartDecrypt).set_Font(new Font("Consolas", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)StartDecrypt).set_Location(new Point(16, 82));
		((Control)StartDecrypt).set_Name("StartDecrypt");
		((Control)StartDecrypt).set_Size(new Size(353, 36));
		((Control)StartDecrypt).set_TabIndex(3);
		((Control)StartDecrypt).set_Text("Select File / Decrypt");
		((ButtonBase)StartDecrypt).set_UseVisualStyleBackColor(true);
		((Control)StartDecrypt).add_Click((EventHandler)StartDecrypt_Click);
		((Control)DecryptStatus).set_Font(new Font("Consolas", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)DecryptStatus).set_ForeColor(Color.White);
		((Control)DecryptStatus).set_Location(new Point(13, 129));
		((Control)DecryptStatus).set_Name("DecryptStatus");
		((Control)DecryptStatus).set_Size(new Size(356, 23));
		((Control)DecryptStatus).set_TabIndex(0);
		((Control)DecryptStatus).set_Text("Ready");
		((Control)ProgressDecrypt).set_Location(new Point(16, 162));
		((Control)ProgressDecrypt).set_Name("ProgressDecrypt");
		((Control)ProgressDecrypt).set_Size(new Size(348, 27));
		((Control)ProgressDecrypt).set_TabIndex(4);
		((Control)DecryptedList).set_Font(new Font("Consolas", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)DecryptedList).set_FormattingEnabled(true);
		DecryptedList.set_ItemHeight(14);
		((Control)DecryptedList).set_Location(new Point(16, 197));
		((Control)DecryptedList).set_Name("DecryptedList");
		((Control)DecryptedList).set_Size(new Size(348, 102));
		((Control)DecryptedList).set_TabIndex(5);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 14f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Red);
		((Form)this).set_ClientSize(new Size(376, 308));
		((Control)this).get_Controls().Add((Control)(object)DecryptedList);
		((Control)this).get_Controls().Add((Control)(object)ProgressDecrypt);
		((Control)this).get_Controls().Add((Control)(object)StartDecrypt);
		((Control)this).get_Controls().Add((Control)(object)ButtonIV);
		((Control)this).get_Controls().Add((Control)(object)ButtonKey);
		((Control)this).get_Controls().Add((Control)(object)IVPath);
		((Control)this).get_Controls().Add((Control)(object)KeyPath);
		((Control)this).get_Controls().Add((Control)(object)DecryptStatus);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Font(new Font("Consolas", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmManualDecrypter");
		((Form)this).set_ShowIcon(false);
		((Control)this).set_Text("ManualDecrypt");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
