using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CNBC.DAL;
using CNBC_MONEY_2009.My;
using Infragistics.Win.Misc;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class frmDJNewBody : InheritedForm
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	private string _NewsID;

	internal virtual RichTextBox RichTextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RichTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RichTextBox1 = value;
		}
	}

	public string NewsID
	{
		get
		{
			return _NewsID;
		}
		set
		{
			_NewsID = value;
		}
	}

	[DebuggerNonUserCode]
	public frmDJNewBody()
	{
		((Form)this).add_Load((EventHandler)frmDJNewBody_Load);
		__ENCList.Add(new WeakReference(this));
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		RichTextBox1 = new RichTextBox();
		((ISupportInitialize)grForm).BeginInit();
		((Control)grForm).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)grForm).get_Controls().Add((Control)(object)RichTextBox1);
		UltraGroupBox obj = grForm;
		Size size = new Size(569, 444);
		((Control)obj).set_Size(size);
		grForm.set_Text("DOWJONES STORY");
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)CloseButton, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)RichTextBox1, 0);
		UltraButton closeButton = CloseButton;
		Point location = new Point(529, 2);
		((Control)closeButton).set_Location(location);
		((TextBoxBase)RichTextBox1).set_BackColor(Color.FromArgb(198, 219, 247));
		((TextBoxBase)RichTextBox1).set_BorderStyle((BorderStyle)0);
		((Control)RichTextBox1).set_Dock((DockStyle)5);
		RichTextBox richTextBox = RichTextBox1;
		location = new Point(3, 29);
		((Control)richTextBox).set_Location(location);
		((Control)RichTextBox1).set_Name("RichTextBox1");
		((TextBoxBase)RichTextBox1).set_ReadOnly(true);
		RichTextBox richTextBox2 = RichTextBox1;
		size = new Size(563, 412);
		((Control)richTextBox2).set_Size(size);
		((Control)RichTextBox1).set_TabIndex(14);
		RichTextBox1.set_Text("");
		SizeF autoScaleDimensions = new SizeF(7f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((Form)this).set_CancelButton((IButtonControl)null);
		size = new Size(569, 444);
		((Form)this).set_ClientSize(size);
		((Control)this).set_Name("frmDJNewBody");
		((Form)this).set_Text("DowJones Body");
		((ISupportInitialize)grForm).EndInit();
		((Control)grForm).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void frmDJNewBody_Load(object sender, EventArgs e)
	{
		BindControls();
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void BindControls()
	{
		try
		{
			DataTable dataTable = new DataTable();
			string text = "Select * from CMW_Wires where CMW_STORY_NUMBER= '" + NewsID + "'";
			dataTable = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, text).Tables[0];
			RichTextBox1.set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable.Rows[0]["Headline"], (object)"\t"), dataTable.Rows[0]["transmission_datetime"]), (object)"\r\n"), (object)"\r\n"), dataTable.Rows[0]["Body"])));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
