using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hospital_Management_System.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class Form4 : Form
{
	private IContainer components;

	private OleDbConnection myconnection;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button OkBtn
	{
		[CompilerGenerated]
		get
		{
			return _OkBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click;
			Button okBtn = _OkBtn;
			if (okBtn != null)
			{
				((Control)okBtn).remove_Click(eventHandler);
			}
			_OkBtn = value;
			okBtn = _OkBtn;
			if (okBtn != null)
			{
				((Control)okBtn).add_Click(eventHandler);
			}
		}
	}

	public Form4()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form4_Load);
		myconnection = new OleDbConnection();
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
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		Label1 = new Label();
		TextBox1 = new TextBox();
		OkBtn = new Button();
		((Control)this).SuspendLayout();
		((Control)Label1).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(32, 43));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(200, 49));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Update Amount");
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)TextBox1).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)TextBox1).set_Location(new Point(60, 107));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(146, 28));
		((Control)TextBox1).set_TabIndex(1);
		((ButtonBase)OkBtn).set_BackColor(Color.MidnightBlue);
		((Control)OkBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)OkBtn).set_ForeColor(Color.White);
		((Control)OkBtn).set_Location(new Point(77, 157));
		((Control)OkBtn).set_Name("OkBtn");
		((Control)OkBtn).set_Size(new Size(96, 37));
		((Control)OkBtn).set_TabIndex(2);
		((ButtonBase)OkBtn).set_Text("Ok");
		((ButtonBase)OkBtn).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(282, 253));
		((Control)this).get_Controls().Add((Control)(object)OkBtn);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form4");
		((Form)this).set_Text("Form4");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		if (!MyProject.Forms.Form1.Decimal_Validator(TextBox1.get_Text()))
		{
			MessageBox.Show("Enter Valid Amount");
			return;
		}
		OleDbCommand val = new OleDbCommand();
		string text = "Update [Blood_Available] Set Quantity = " + TextBox1.get_Text() + " Where [ID] =" + Conversions.ToString(MyProject.Forms.Form1.blood_available_id) + ";";
		myconnection.Open();
		try
		{
			val = new OleDbCommand(text, myconnection);
			val.ExecuteNonQuery();
			((Component)(object)val).Dispose();
			myconnection.Close();
			MyProject.Forms.Form1.cur_blood_amount = Conversions.ToDecimal(TextBox1.get_Text());
			((Form)this).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MessageBox.Show("Error Updating database");
			myconnection.Close();
			ProjectData.ClearProjectError();
		}
	}

	private void Form4_Load(object sender, EventArgs e)
	{
		myconnection.set_ConnectionString(MyProject.Forms.Form1.provider + MyProject.Forms.Form1.datafile);
	}
}
