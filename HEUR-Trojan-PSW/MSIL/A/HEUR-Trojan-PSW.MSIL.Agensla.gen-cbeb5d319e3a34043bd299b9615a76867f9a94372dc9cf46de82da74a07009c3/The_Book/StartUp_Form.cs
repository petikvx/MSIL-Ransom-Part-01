using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace The_Book;

[DesignerGenerated]
public class StartUp_Form : Form
{
	private IContainer components;

	internal virtual Button btnEnter
	{
		[CompilerGenerated]
		get
		{
			return _btnEnter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnEnter_Click;
			Button val = _btnEnter;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnEnter = value;
			val = _btnEnter;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public StartUp_Form()
	{
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
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		btnEnter = new Button();
		Label1 = new Label();
		PictureBox1 = new PictureBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)btnEnter).set_BackColor(Color.Transparent);
		((Control)btnEnter).set_Font(new Font("Palatino Linotype", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnEnter).set_Location(new Point(72, 165));
		((Control)btnEnter).set_Name("btnEnter");
		((Control)btnEnter).set_Size(new Size(92, 39));
		((Control)btnEnter).set_TabIndex(0);
		((ButtonBase)btnEnter).set_Text("Enter");
		((ButtonBase)btnEnter).set_UseVisualStyleBackColor(false);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Monotype Corsiva", 24f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(56, 23));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(124, 39));
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("The Book");
		((Control)PictureBox1).set_Location(new Point(88, 87));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(60, 58));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)2);
		PictureBox1.set_TabIndex(2);
		PictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(236, 232));
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)btnEnter);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("StartUp_Form");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("The Book!");
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void btnEnter_Click(object sender, EventArgs e)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				Database_Handling database_Handling = new Database_Handling();
				database_Handling.Open();
				int inc = 0;
				int count = Database_Handling.ds.Tables["Child"]!.Rows.Count;
				int num = count - 1;
				for (int i = 0; i <= num; i++)
				{
					database_Handling.LoadList(ref inc);
				}
				if (Child.lstChild.Count - 1 != count - 1)
				{
					MessageBox.Show("Error: Not able to load some or all values from database.", "Error");
				}
				else
				{
					MessageBox.Show("Database loaded successfully!", "Success");
				}
				Main_Menu main_Menu = new Main_Menu();
				((Control)main_Menu).Show();
				((Form)this).Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				MessageBox.Show("Database could not be located!");
				ProjectData.ClearProjectError();
			}
		}
	}
}
