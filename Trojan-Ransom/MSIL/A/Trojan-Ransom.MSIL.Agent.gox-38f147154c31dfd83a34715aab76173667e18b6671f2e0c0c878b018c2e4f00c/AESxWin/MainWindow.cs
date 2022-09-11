using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AESxWin;

public class MainWindow : Form
{
	private IContainer icontainer_0 = null;

	private GroupBox gbPaths;

	private Button btnAddFolder;

	private Button btnAddFile;

	private ListBox lstPaths;

	private Button btnRemovePath;

	private GroupBox gbOptions;

	private CheckBox chkSubFolders;

	private CheckBox chkDeleteOrg;

	private GroupBox gbPassword;

	private TextBox txtPassword;

	private Button btnEncrypt;

	private Button btnDecrypt;

	private Label lblInfo;

	private ComboBox lstExts;

	private Label label1;

	private GroupBox gbLog;

	private TextBox txtLog;

	public MainWindow()
	{
		InitializeComponent();
		((Form)(object)this).smethod_0(txtLog);
	}

	public MainWindow(string[] args)
	{
		InitializeComponent();
		((Form)(object)this).smethod_0(txtLog);
		foreach (string text in args)
		{
			if (File.Exists(text) || Directory.Exists(text))
			{
				lstPaths.get_Items().Add((object)text);
			}
		}
	}

	private void MainWindow_Load(object sender, EventArgs e)
	{
		((ListControl)lstExts).set_SelectedIndex(6);
	}

	private void btnAddFile_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		try
		{
			((FileDialog)val).set_Title("Select your File(s)");
			((FileDialog)val).set_CheckFileExists(true);
			((FileDialog)val).set_CheckPathExists(true);
			val.set_Multiselect(true);
			((FileDialog)val).set_SupportMultiDottedExtensions(true);
			((FileDialog)val).set_InitialDirectory(Application.get_StartupPath());
			if ((int)((CommonDialog)val).ShowDialog() != 1)
			{
				return;
			}
			string[] fileNames = ((FileDialog)val).get_FileNames();
			if (fileNames == null || fileNames.Length == 0)
			{
				return;
			}
			string[] array = fileNames;
			foreach (string text in array)
			{
				ObjectCollection items = lstPaths.get_Items();
				if (!items.Contains((object)text))
				{
					lstPaths.get_Items().Add((object)text);
				}
				else
				{
					((Form)(object)this).smethod_4(text + " is already exist in the list.");
				}
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void btnRemovePath_Click(object sender, EventArgs e)
	{
		int selectedIndex = ((ListControl)lstPaths).get_SelectedIndex();
		if (selectedIndex != -1)
		{
			lstPaths.get_Items().RemoveAt(selectedIndex);
			((ListControl)lstPaths).set_SelectedIndex((selectedIndex < lstPaths.get_Items().get_Count()) ? selectedIndex : (selectedIndex - 1));
			((Control)lstPaths).Focus();
		}
	}

	private void btnAddFolder_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		FolderBrowserDialog val = new FolderBrowserDialog();
		try
		{
			val.set_Description("Select A Folder");
			val.set_ShowNewFolderButton(true);
			val.set_RootFolder(Environment.SpecialFolder.MyComputer);
			if ((int)((CommonDialog)val).ShowDialog() != 1)
			{
				return;
			}
			string selectedPath = val.get_SelectedPath();
			if (!string.IsNullOrEmpty(selectedPath))
			{
				ObjectCollection items = lstPaths.get_Items();
				if (!items.Contains((object)selectedPath))
				{
					lstPaths.get_Items().Add((object)selectedPath);
				}
				else
				{
					((Form)(object)this).smethod_4(selectedPath + " is already exist in the list.");
				}
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private async void btnEncrypt_Click(object sender, EventArgs e)
	{
		int num = 0;
		ObjectCollection items = lstPaths.get_Items();
		((Form)(object)this).smethod_4("Encryption Started.");
		if (items != null && items.get_Count() > 0)
		{
			foreach (string item in items)
			{
				if (File.Exists(item) && item.smethod_8(((Control)lstExts).get_Text().smethod_7()))
				{
					try
					{
						await item.smethod_0(((Control)txtPassword).get_Text());
						((Form)(object)this).smethod_4(item + " Encrypted.");
						num++;
						if (chkDeleteOrg.get_Checked())
						{
							File.Delete(item);
						}
					}
					catch (Exception ex)
					{
						Exception ex2 = ex;
						((Form)(object)this).smethod_4(item + " " + ex2.Message);
					}
				}
				if (!Directory.Exists(item))
				{
					continue;
				}
				bool bool_ = (chkSubFolders.get_Checked() ? true : false);
				IEnumerable<string> enumerable = item.smethod_6(bool_);
				foreach (string item2 in enumerable)
				{
					if (!item2.smethod_8(((Control)lstExts).get_Text().smethod_7()) || item2.EndsWith(".aes"))
					{
						continue;
					}
					try
					{
						await item2.smethod_0(((Control)txtPassword).get_Text());
						((Form)(object)this).smethod_4(item2 + " Encrypted.");
						num++;
						if (chkDeleteOrg.get_Checked())
						{
							File.Delete(item2);
						}
					}
					catch (Exception ex)
					{
						Exception ex3 = ex;
						((Form)(object)this).smethod_4(item2 + " " + ex3.Message);
					}
				}
			}
		}
		((Form)(object)this).smethod_4($"Finished : {num} File(s) Encrypted.");
	}

	private async void btnDecrypt_Click(object sender, EventArgs e)
	{
		int num = 0;
		ObjectCollection items = lstPaths.get_Items();
		((Form)(object)this).smethod_4("Decryption Started.");
		if (items.get_Count() <= 0)
		{
			return;
		}
		foreach (string item in items)
		{
			if (File.Exists(item) && item.EndsWith(".aes"))
			{
				try
				{
					await item.smethod_3(((Control)txtPassword).get_Text());
					((Form)(object)this).smethod_4(item + " Decrypted.");
					num++;
					if (chkDeleteOrg.get_Checked())
					{
						File.Delete(item);
					}
				}
				catch (Exception ex)
				{
					Exception ex2 = ex;
					((Form)(object)this).smethod_4(item + " " + ex2.Message);
					if (File.Exists(item.smethod_4()))
					{
						File.Delete(item.smethod_4());
					}
				}
			}
			if (!Directory.Exists(item))
			{
				continue;
			}
			bool bool_ = (chkSubFolders.get_Checked() ? true : false);
			IEnumerable<string> enumerable = item.smethod_6(bool_);
			foreach (string item2 in enumerable)
			{
				if (!item2.smethod_4().smethod_8(((Control)lstExts).get_Text().smethod_7()) || !item2.EndsWith(".aes"))
				{
					continue;
				}
				try
				{
					await item2.smethod_3(((Control)txtPassword).get_Text());
					((Form)(object)this).smethod_4(item2 + " Decrypted.");
					num++;
					if (chkDeleteOrg.get_Checked())
					{
						File.Delete(item2);
					}
				}
				catch (Exception ex)
				{
					Exception ex3 = ex;
					((Form)(object)this).smethod_4(item2 + " " + ex3.Message);
					if (File.Exists(item2.smethod_4()))
					{
						File.Delete(item2.smethod_4());
					}
				}
			}
		}
	}

	private void lblInfo_Click(object sender, EventArgs e)
	{
		Process.Start("http://eslamx.com");
	}

	private void lstPaths_DragDrop(object sender, DragEventArgs e)
	{
		object data = e.get_Data().GetData(DataFormats.FileDrop, false);
		if (!(data is IEnumerable<string> enumerable))
		{
			return;
		}
		foreach (string item in enumerable)
		{
			lstPaths.get_Items().Add((object)item);
		}
	}

	private void lstPaths_DragEnter(object sender, DragEventArgs e)
	{
		if (e.get_Data().GetDataPresent(DataFormats.FileDrop))
		{
			e.set_Effect((DragDropEffects)1);
		}
		else
		{
			e.set_Effect((DragDropEffects)0);
		}
	}

	private void lstPaths_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void gbPaths_Enter(object sender, EventArgs e)
	{
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
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected O, but got Unknown
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected O, but got Unknown
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected O, but got Unknown
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_079d: Expected O, but got Unknown
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Expected O, but got Unknown
		//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b21: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainWindow));
		gbPaths = new GroupBox();
		btnRemovePath = new Button();
		btnAddFolder = new Button();
		btnAddFile = new Button();
		lstPaths = new ListBox();
		gbOptions = new GroupBox();
		label1 = new Label();
		lstExts = new ComboBox();
		chkSubFolders = new CheckBox();
		chkDeleteOrg = new CheckBox();
		gbPassword = new GroupBox();
		txtPassword = new TextBox();
		btnEncrypt = new Button();
		btnDecrypt = new Button();
		lblInfo = new Label();
		gbLog = new GroupBox();
		txtLog = new TextBox();
		((Control)gbPaths).SuspendLayout();
		((Control)gbOptions).SuspendLayout();
		((Control)gbPassword).SuspendLayout();
		((Control)gbLog).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)gbPaths).get_Controls().Add((Control)(object)btnRemovePath);
		((Control)gbPaths).get_Controls().Add((Control)(object)btnAddFolder);
		((Control)gbPaths).get_Controls().Add((Control)(object)btnAddFile);
		((Control)gbPaths).get_Controls().Add((Control)(object)lstPaths);
		((Control)gbPaths).set_Location(new Point(12, 12));
		((Control)gbPaths).set_Name("gbPaths");
		((Control)gbPaths).set_Size(new Size(404, 130));
		((Control)gbPaths).set_TabIndex(0);
		gbPaths.set_TabStop(false);
		((Control)gbPaths).set_Text("Paths");
		((Control)gbPaths).add_Enter((EventHandler)gbPaths_Enter);
		((Control)btnRemovePath).set_Location(new Point(323, 95));
		((Control)btnRemovePath).set_Name("btnRemovePath");
		((Control)btnRemovePath).set_Size(new Size(75, 23));
		((Control)btnRemovePath).set_TabIndex(3);
		((Control)btnRemovePath).set_Text("Remove");
		((ButtonBase)btnRemovePath).set_UseVisualStyleBackColor(true);
		((Control)btnRemovePath).add_Click((EventHandler)btnRemovePath_Click);
		((Control)btnAddFolder).set_Location(new Point(88, 95));
		((Control)btnAddFolder).set_Name("btnAddFolder");
		((Control)btnAddFolder).set_Size(new Size(75, 23));
		((Control)btnAddFolder).set_TabIndex(2);
		((Control)btnAddFolder).set_Text("Add Folder");
		((ButtonBase)btnAddFolder).set_UseVisualStyleBackColor(true);
		((Control)btnAddFolder).add_Click((EventHandler)btnAddFolder_Click);
		((Control)btnAddFile).set_Location(new Point(7, 95));
		((Control)btnAddFile).set_Name("btnAddFile");
		((Control)btnAddFile).set_Size(new Size(75, 23));
		((Control)btnAddFile).set_TabIndex(1);
		((Control)btnAddFile).set_Text("Add File(s)");
		((ButtonBase)btnAddFile).set_UseVisualStyleBackColor(true);
		((Control)btnAddFile).add_Click((EventHandler)btnAddFile_Click);
		((Control)lstPaths).set_AllowDrop(true);
		((ListControl)lstPaths).set_FormattingEnabled(true);
		lstPaths.set_HorizontalScrollbar(true);
		((Control)lstPaths).set_Location(new Point(6, 19));
		((Control)lstPaths).set_Name("lstPaths");
		((Control)lstPaths).set_Size(new Size(392, 69));
		((Control)lstPaths).set_TabIndex(0);
		lstPaths.add_SelectedIndexChanged((EventHandler)lstPaths_SelectedIndexChanged);
		((Control)lstPaths).add_DragDrop(new DragEventHandler(lstPaths_DragDrop));
		((Control)lstPaths).add_DragEnter(new DragEventHandler(lstPaths_DragEnter));
		((Control)gbOptions).get_Controls().Add((Control)(object)label1);
		((Control)gbOptions).get_Controls().Add((Control)(object)lstExts);
		((Control)gbOptions).get_Controls().Add((Control)(object)chkSubFolders);
		((Control)gbOptions).get_Controls().Add((Control)(object)chkDeleteOrg);
		((Control)gbOptions).set_Location(new Point(12, 148));
		((Control)gbOptions).set_Name("gbOptions");
		((Control)gbOptions).set_Size(new Size(404, 69));
		((Control)gbOptions).set_TabIndex(1);
		gbOptions.set_TabStop(false);
		((Control)gbOptions).set_Text("Options");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(205, 43));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(64, 13));
		((Control)label1).set_TabIndex(3);
		((Control)label1).set_Text("Extensions :");
		((ListControl)lstExts).set_FormattingEnabled(true);
		lstExts.get_Items().AddRange(new object[7] { "(Images) jpg jpeg png gif bmp", "(Videos) avi flv mov mp4 mpg rm rmvb mkv swf vob wmv 3g2 3gp asf ogv", "(Audio) mp3 wav acc ogg amr wma", "(Documents) pdf txt rtf doc docx ppt pptx xls xlsx", "(Compresed) zip rar 7z tar gzip", "(Code) cs vb java py rb cpp html css js", "(All Files)" });
		((Control)lstExts).set_Location(new Point(277, 40));
		((Control)lstExts).set_Name("lstExts");
		((Control)lstExts).set_Size(new Size(121, 21));
		((Control)lstExts).set_TabIndex(2);
		((Control)chkSubFolders).set_AutoSize(true);
		((Control)chkSubFolders).set_Location(new Point(6, 42));
		((Control)chkSubFolders).set_Name("chkSubFolders");
		((Control)chkSubFolders).set_Size(new Size(115, 17));
		((Control)chkSubFolders).set_TabIndex(1);
		((Control)chkSubFolders).set_Text("Follow Sub Folders");
		((ButtonBase)chkSubFolders).set_UseVisualStyleBackColor(true);
		((Control)chkDeleteOrg).set_AutoSize(true);
		((Control)chkDeleteOrg).set_Location(new Point(7, 19));
		((Control)chkDeleteOrg).set_Name("chkDeleteOrg");
		((Control)chkDeleteOrg).set_Size(new Size(117, 17));
		((Control)chkDeleteOrg).set_TabIndex(0);
		((Control)chkDeleteOrg).set_Text("Delete Orignal Files");
		((ButtonBase)chkDeleteOrg).set_UseVisualStyleBackColor(true);
		((Control)gbPassword).get_Controls().Add((Control)(object)txtPassword);
		((Control)gbPassword).set_Location(new Point(12, 223));
		((Control)gbPassword).set_Name("gbPassword");
		((Control)gbPassword).set_Size(new Size(404, 48));
		((Control)gbPassword).set_TabIndex(2);
		gbPassword.set_TabStop(false);
		((Control)gbPassword).set_Text("Password");
		((Control)txtPassword).set_Dock((DockStyle)5);
		((Control)txtPassword).set_Font(new Font("Tahoma", 12f, (FontStyle)1));
		((Control)txtPassword).set_Location(new Point(3, 16));
		((Control)txtPassword).set_Name("txtPassword");
		txtPassword.set_PasswordChar('*');
		((Control)txtPassword).set_Size(new Size(398, 27));
		((Control)txtPassword).set_TabIndex(0);
		txtPassword.set_TextAlign((HorizontalAlignment)2);
		((Control)btnEncrypt).set_Font(new Font("Tahoma", 8f, (FontStyle)1));
		((Control)btnEncrypt).set_Location(new Point(12, 287));
		((Control)btnEncrypt).set_Name("btnEncrypt");
		((Control)btnEncrypt).set_Size(new Size(163, 41));
		((Control)btnEncrypt).set_TabIndex(3);
		((Control)btnEncrypt).set_Text("Encrypt");
		((ButtonBase)btnEncrypt).set_UseVisualStyleBackColor(true);
		((Control)btnEncrypt).add_Click((EventHandler)btnEncrypt_Click);
		((Control)btnDecrypt).set_Font(new Font("Tahoma", 8f, (FontStyle)1));
		((Control)btnDecrypt).set_Location(new Point(253, 287));
		((Control)btnDecrypt).set_Name("btnDecrypt");
		((Control)btnDecrypt).set_Size(new Size(163, 41));
		((Control)btnDecrypt).set_TabIndex(4);
		((Control)btnDecrypt).set_Text("Decrypt");
		((ButtonBase)btnDecrypt).set_UseVisualStyleBackColor(true);
		((Control)btnDecrypt).add_Click((EventHandler)btnDecrypt_Click);
		((Control)lblInfo).set_Dock((DockStyle)2);
		((Control)lblInfo).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)lblInfo).set_Location(new Point(0, 452));
		((Control)lblInfo).set_Name("lblInfo");
		((Control)lblInfo).set_Size(new Size(428, 20));
		((Control)lblInfo).set_TabIndex(5);
		((Control)lblInfo).set_Text("by : Eslam Hamouda (@EslaMx7) - www.eslamx.com");
		lblInfo.set_TextAlign((ContentAlignment)32);
		((Control)lblInfo).add_Click((EventHandler)lblInfo_Click);
		((Control)gbLog).get_Controls().Add((Control)(object)txtLog);
		((Control)gbLog).set_Location(new Point(12, 334));
		((Control)gbLog).set_Name("gbLog");
		((Control)gbLog).set_Size(new Size(401, 115));
		((Control)gbLog).set_TabIndex(6);
		gbLog.set_TabStop(false);
		((Control)gbLog).set_Text("Log");
		((Control)txtLog).set_BackColor(Color.White);
		((Control)txtLog).set_Dock((DockStyle)5);
		((Control)txtLog).set_Location(new Point(3, 16));
		((TextBoxBase)txtLog).set_Multiline(true);
		((Control)txtLog).set_Name("txtLog");
		((TextBoxBase)txtLog).set_ReadOnly(true);
		txtLog.set_ScrollBars((ScrollBars)3);
		((Control)txtLog).set_Size(new Size(395, 96));
		((Control)txtLog).set_TabIndex(0);
		((TextBoxBase)txtLog).set_WordWrap(false);
		((Control)this).set_AllowDrop(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(428, 472));
		((Control)this).get_Controls().Add((Control)(object)gbLog);
		((Control)this).get_Controls().Add((Control)(object)lblInfo);
		((Control)this).get_Controls().Add((Control)(object)btnDecrypt);
		((Control)this).get_Controls().Add((Control)(object)btnEncrypt);
		((Control)this).get_Controls().Add((Control)(object)gbPassword);
		((Control)this).get_Controls().Add((Control)(object)gbOptions);
		((Control)this).get_Controls().Add((Control)(object)gbPaths);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("MainWindow");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("AESxWin");
		((Form)this).add_Load((EventHandler)MainWindow_Load);
		((Control)gbPaths).ResumeLayout(false);
		((Control)gbOptions).ResumeLayout(false);
		((Control)gbOptions).PerformLayout();
		((Control)gbPassword).ResumeLayout(false);
		((Control)gbPassword).PerformLayout();
		((Control)gbLog).ResumeLayout(false);
		((Control)gbLog).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
