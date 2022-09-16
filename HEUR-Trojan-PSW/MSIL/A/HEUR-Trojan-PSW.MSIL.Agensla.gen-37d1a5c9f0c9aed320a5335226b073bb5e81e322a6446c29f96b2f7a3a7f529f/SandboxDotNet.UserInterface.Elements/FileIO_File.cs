using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SandboxDotNet.Helpers;

namespace SandboxDotNet.UserInterface.Elements;

public class FileIO_File : UserControl
{
	private readonly SandboxDotNet _parentUi;

	private IContainer components = null;

	private TableLayoutPanel mainTableLayout;

	private Label filePath;

	private TableLayoutPanel optionsTableLayout;

	private Button deleteButton;

	private TableLayoutPanel tableLayoutPanel3;

	private CheckBox readCheckBox;

	private CheckBox writeCheckBox;

	private CheckBox appendCheckBox;

	public string FilePath
	{
		get
		{
			return ((Control)filePath).get_Text();
		}
		set
		{
			((Control)filePath).set_Text(value);
		}
	}

	public bool Read
	{
		get
		{
			return readCheckBox.get_Checked();
		}
		set
		{
			readCheckBox.set_Checked(value);
		}
	}

	public bool Write
	{
		get
		{
			return writeCheckBox.get_Checked();
		}
		set
		{
			writeCheckBox.set_Checked(value);
		}
	}

	public bool Append
	{
		get
		{
			return appendCheckBox.get_Checked();
		}
		set
		{
			appendCheckBox.set_Checked(value);
		}
	}

	public FileIO_File(string path, bool read, bool write, bool append, SandboxDotNet sandboxUi)
	{
		InitializeComponent();
		((Control)filePath).set_Text(path);
		((Control)filePath).set_Cursor(Cursors.get_Hand());
		readCheckBox.set_Checked(read);
		writeCheckBox.set_Checked(write);
		appendCheckBox.set_Checked(append);
		_parentUi = sandboxUi;
	}

	private void filePath_Click(object sender, EventArgs e)
	{
		SandboxUtils.OpenFileInExplorer(Path.GetDirectoryName(Path.GetFullPath(FilePath)));
	}

	private void deleteButton_Click(object sender, EventArgs e)
	{
		_parentUi.RemovePathFromList(this);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
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
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected O, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected O, but got Unknown
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected O, but got Unknown
		mainTableLayout = new TableLayoutPanel();
		filePath = new Label();
		optionsTableLayout = new TableLayoutPanel();
		deleteButton = new Button();
		tableLayoutPanel3 = new TableLayoutPanel();
		readCheckBox = new CheckBox();
		writeCheckBox = new CheckBox();
		appendCheckBox = new CheckBox();
		((Control)mainTableLayout).SuspendLayout();
		((Control)optionsTableLayout).SuspendLayout();
		((Control)tableLayoutPanel3).SuspendLayout();
		((Control)this).SuspendLayout();
		mainTableLayout.set_ColumnCount(2);
		mainTableLayout.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		mainTableLayout.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 210f));
		mainTableLayout.get_Controls().Add((Control)(object)filePath, 0, 0);
		mainTableLayout.get_Controls().Add((Control)(object)optionsTableLayout, 1, 0);
		((Control)mainTableLayout).set_Dock((DockStyle)5);
		((Control)mainTableLayout).set_Location(new Point(0, 0));
		((Control)mainTableLayout).set_Name("mainTableLayout");
		mainTableLayout.set_RowCount(1);
		mainTableLayout.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)mainTableLayout).set_Size(new Size(398, 48));
		((Control)mainTableLayout).set_TabIndex(0);
		((Control)filePath).set_AutoSize(true);
		((Control)filePath).set_Dock((DockStyle)5);
		((Control)filePath).set_Location(new Point(5, 5));
		((Control)filePath).set_Margin(new Padding(5));
		((Control)filePath).set_Name("filePath");
		((Control)filePath).set_Size(new Size(178, 38));
		((Control)filePath).set_TabIndex(0);
		((Control)filePath).set_Text("[FILE PATH]");
		filePath.set_TextAlign((ContentAlignment)16);
		((Control)filePath).add_Click((EventHandler)filePath_Click);
		optionsTableLayout.set_ColumnCount(1);
		optionsTableLayout.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		optionsTableLayout.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 20f));
		optionsTableLayout.get_Controls().Add((Control)(object)deleteButton, 0, 1);
		optionsTableLayout.get_Controls().Add((Control)(object)tableLayoutPanel3, 0, 0);
		((Control)optionsTableLayout).set_Dock((DockStyle)5);
		((Control)optionsTableLayout).set_Location(new Point(188, 0));
		((Control)optionsTableLayout).set_Margin(new Padding(0));
		((Control)optionsTableLayout).set_Name("optionsTableLayout");
		optionsTableLayout.set_RowCount(2);
		optionsTableLayout.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		optionsTableLayout.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		((Control)optionsTableLayout).set_Size(new Size(210, 48));
		((Control)optionsTableLayout).set_TabIndex(1);
		((Control)deleteButton).set_Dock((DockStyle)5);
		((Control)deleteButton).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)deleteButton).set_Location(new Point(1, 25));
		((Control)deleteButton).set_Margin(new Padding(1));
		((Control)deleteButton).set_Name("deleteButton");
		((Control)deleteButton).set_Size(new Size(208, 22));
		((Control)deleteButton).set_TabIndex(0);
		((Control)deleteButton).set_Text("Remove File/Folder");
		((ButtonBase)deleteButton).set_UseVisualStyleBackColor(true);
		((Control)deleteButton).add_Click((EventHandler)deleteButton_Click);
		tableLayoutPanel3.set_ColumnCount(3);
		tableLayoutPanel3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33333f));
		tableLayoutPanel3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33333f));
		tableLayoutPanel3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33333f));
		tableLayoutPanel3.get_Controls().Add((Control)(object)readCheckBox, 0, 0);
		tableLayoutPanel3.get_Controls().Add((Control)(object)writeCheckBox, 1, 0);
		tableLayoutPanel3.get_Controls().Add((Control)(object)appendCheckBox, 2, 0);
		((Control)tableLayoutPanel3).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel3).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel3).set_Margin(new Padding(0));
		((Control)tableLayoutPanel3).set_Name("tableLayoutPanel3");
		tableLayoutPanel3.set_RowCount(1);
		tableLayoutPanel3.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel3).set_Size(new Size(210, 24));
		((Control)tableLayoutPanel3).set_TabIndex(1);
		((Control)readCheckBox).set_AutoSize(true);
		((Control)readCheckBox).set_Dock((DockStyle)5);
		((Control)readCheckBox).set_Location(new Point(3, 3));
		((Control)readCheckBox).set_Name("readCheckBox");
		((Control)readCheckBox).set_Size(new Size(63, 18));
		((Control)readCheckBox).set_TabIndex(0);
		((Control)readCheckBox).set_Text("Read");
		((ButtonBase)readCheckBox).set_UseVisualStyleBackColor(true);
		((Control)writeCheckBox).set_AutoSize(true);
		((Control)writeCheckBox).set_Dock((DockStyle)5);
		((Control)writeCheckBox).set_Location(new Point(72, 3));
		((Control)writeCheckBox).set_Name("writeCheckBox");
		((Control)writeCheckBox).set_Size(new Size(63, 18));
		((Control)writeCheckBox).set_TabIndex(1);
		((Control)writeCheckBox).set_Text("Write");
		((ButtonBase)writeCheckBox).set_UseVisualStyleBackColor(true);
		((Control)appendCheckBox).set_AutoSize(true);
		((Control)appendCheckBox).set_Dock((DockStyle)5);
		((Control)appendCheckBox).set_Location(new Point(141, 3));
		((Control)appendCheckBox).set_Name("appendCheckBox");
		((Control)appendCheckBox).set_Size(new Size(66, 18));
		((Control)appendCheckBox).set_TabIndex(2);
		((Control)appendCheckBox).set_Text("Append");
		((ButtonBase)appendCheckBox).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((UserControl)this).set_BorderStyle((BorderStyle)1);
		((Control)this).get_Controls().Add((Control)(object)mainTableLayout);
		((Control)this).set_Name("FileIO_File");
		((Control)this).set_Size(new Size(398, 48));
		((Control)mainTableLayout).ResumeLayout(false);
		((Control)mainTableLayout).PerformLayout();
		((Control)optionsTableLayout).ResumeLayout(false);
		((Control)tableLayoutPanel3).ResumeLayout(false);
		((Control)tableLayoutPanel3).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
