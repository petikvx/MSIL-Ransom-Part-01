using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SandboxDotNet.ErrorHandler;

public class SandboxUI_Errors : Form
{
	private bool _showDetailedError;

	private IContainer components = null;

	private TableLayoutPanel errorLayoutTable;

	private Label errorMessage;

	private Button closeButton;

	private Panel showMorePanel;

	private Button showMoreButton;

	private RichTextBox fullErrorTextBox;

	public SandboxUI_Errors(Exception exception, string titleType, bool showDetailed = false)
	{
		InitializeComponent();
		((Control)this).set_Text("SbDN: " + titleType);
		((Control)errorMessage).set_Text(exception.Message);
		((Control)fullErrorTextBox).set_Text(exception.ToString());
		_showDetailedError = showDetailed;
		ShowMore(_showDetailedError);
	}

	private void ShowMore(bool showDetailed)
	{
		_showDetailedError = showDetailed;
		if (!_showDetailedError)
		{
			((Control)showMoreButton).set_Text("Show Detailed Exception");
			((Control)fullErrorTextBox).Hide();
			((TableLayoutStyle)errorLayoutTable.get_RowStyles().get_Item(2)).set_SizeType((SizeType)1);
			errorLayoutTable.get_RowStyles().get_Item(2).set_Height(0f);
		}
		else
		{
			((Control)showMoreButton).set_Text("Hide Detailed Exception");
			((TableLayoutStyle)errorLayoutTable.get_RowStyles().get_Item(2)).set_SizeType((SizeType)2);
			errorLayoutTable.get_RowStyles().get_Item(2).set_Height(60f);
			((Control)fullErrorTextBox).Show();
		}
	}

	private void showMoreButton_Click(object sender, EventArgs e)
	{
		ShowMore(!_showDetailedError);
	}

	private void closeButton_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
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
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		errorLayoutTable = new TableLayoutPanel();
		showMorePanel = new Panel();
		closeButton = new Button();
		showMoreButton = new Button();
		errorMessage = new Label();
		fullErrorTextBox = new RichTextBox();
		((Control)errorLayoutTable).SuspendLayout();
		((Control)showMorePanel).SuspendLayout();
		((Control)this).SuspendLayout();
		errorLayoutTable.set_ColumnCount(1);
		errorLayoutTable.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		errorLayoutTable.get_Controls().Add((Control)(object)showMorePanel, 0, 1);
		errorLayoutTable.get_Controls().Add((Control)(object)errorMessage, 0, 0);
		errorLayoutTable.get_Controls().Add((Control)(object)fullErrorTextBox, 0, 2);
		((Control)errorLayoutTable).set_Dock((DockStyle)5);
		((Control)errorLayoutTable).set_Location(new Point(0, 0));
		((Control)errorLayoutTable).set_Name("errorLayoutTable");
		errorLayoutTable.set_RowCount(3);
		errorLayoutTable.get_RowStyles().Add(new RowStyle((SizeType)2, 30f));
		errorLayoutTable.get_RowStyles().Add(new RowStyle((SizeType)1, 30f));
		errorLayoutTable.get_RowStyles().Add(new RowStyle((SizeType)2, 70f));
		((Control)errorLayoutTable).set_Size(new Size(414, 211));
		((Control)errorLayoutTable).set_TabIndex(0);
		((Control)showMorePanel).get_Controls().Add((Control)(object)closeButton);
		((Control)showMorePanel).get_Controls().Add((Control)(object)showMoreButton);
		((Control)showMorePanel).set_Dock((DockStyle)5);
		((Control)showMorePanel).set_Location(new Point(3, 57));
		((Control)showMorePanel).set_Name("showMorePanel");
		((Control)showMorePanel).set_Size(new Size(408, 24));
		((Control)showMorePanel).set_TabIndex(0);
		((Control)closeButton).set_Dock((DockStyle)5);
		((Control)closeButton).set_Location(new Point(136, 0));
		((Control)closeButton).set_Name("closeButton");
		((Control)closeButton).set_Size(new Size(272, 24));
		((Control)closeButton).set_TabIndex(3);
		((Control)closeButton).set_Text("Close");
		((ButtonBase)closeButton).set_UseVisualStyleBackColor(true);
		((Control)closeButton).add_Click((EventHandler)closeButton_Click);
		((Control)showMoreButton).set_AutoSize(true);
		((Control)showMoreButton).set_Dock((DockStyle)3);
		((Control)showMoreButton).set_Location(new Point(0, 0));
		((Control)showMoreButton).set_Name("showMoreButton");
		((Control)showMoreButton).set_Size(new Size(136, 24));
		((Control)showMoreButton).set_TabIndex(0);
		((Control)showMoreButton).set_Text("Show Detailed Exception");
		((ButtonBase)showMoreButton).set_UseVisualStyleBackColor(true);
		((Control)showMoreButton).add_Click((EventHandler)showMoreButton_Click);
		((Control)errorMessage).set_Dock((DockStyle)5);
		((Control)errorMessage).set_Location(new Point(6, 6));
		((Control)errorMessage).set_Margin(new Padding(6));
		((Control)errorMessage).set_Name("errorMessage");
		((Control)errorMessage).set_Size(new Size(402, 42));
		((Control)errorMessage).set_TabIndex(1);
		((Control)errorMessage).set_Text("PLACEHOLDER TEXT");
		((Control)fullErrorTextBox).set_Dock((DockStyle)5);
		((Control)fullErrorTextBox).set_Location(new Point(3, 87));
		((Control)fullErrorTextBox).set_Name("fullErrorTextBox");
		((TextBoxBase)fullErrorTextBox).set_ReadOnly(true);
		fullErrorTextBox.set_ScrollBars((RichTextBoxScrollBars)2);
		((Control)fullErrorTextBox).set_Size(new Size(408, 121));
		((Control)fullErrorTextBox).set_TabIndex(2);
		((Control)fullErrorTextBox).set_Text("");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(414, 211));
		((Control)this).get_Controls().Add((Control)(object)errorLayoutTable);
		((Control)this).set_MinimumSize(new Size(430, 250));
		((Control)this).set_Name("SandboxUI_Errors");
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Control)this).set_Text("SBdN: Error");
		((Form)this).set_TopMost(true);
		((Control)errorLayoutTable).ResumeLayout(false);
		((Control)showMorePanel).ResumeLayout(false);
		((Control)showMorePanel).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
