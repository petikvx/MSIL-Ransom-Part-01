using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hr60;
using Microsoft.VisualBasic.CompilerServices;
using k9X;
using q3G;
using t8C;

namespace Ex8;

[DesignerGenerated]
public class m4F : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FeesGrid")]
	internal virtual DataGridView FeesGrid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSearch")]
	internal virtual TextBox txtSearch
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("avatar")]
	private virtual Button avatar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel10")]
	internal virtual Panel Panel10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button4
	{
		[CompilerGenerated]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = b6F;
			Button button = _Button4;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button4 = value;
			button = _Button4;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Button5")]
	private virtual Button Button5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column5")]
	internal virtual DataGridViewTextBoxColumn Column5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column8")]
	internal virtual DataGridViewTextBoxColumn Column8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column2")]
	internal virtual DataGridViewTextBoxColumn Column2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column7")]
	internal virtual DataGridViewTextBoxColumn Column7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column3")]
	internal virtual DataGridViewTextBoxColumn Column3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column9")]
	internal virtual DataGridViewTextBoxColumn Column9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BIRTHDAY")]
	internal virtual DataGridViewTextBoxColumn BIRTHDAY
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column4")]
	internal virtual DataGridViewTextBoxColumn Column4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column6")]
	internal virtual DataGridViewTextBoxColumn Column6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ADDRESS")]
	internal virtual DataGridViewTextBoxColumn ADDRESS
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column1")]
	internal virtual DataGridViewTextBoxColumn Column1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public m4F()
	{
		((Form)this).add_Load((EventHandler)w1L);
		Lw3();
	}

	[DebuggerNonUserCode]
	protected override void Nn9(bool x6W)
	{
		try
		{
			if (x6W && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(x6W);
		}
	}

	[DebuggerStepThrough]
	private void Lw3()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected O, but got Unknown
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected O, but got Unknown
		//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Expected O, but got Unknown
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0902: Expected O, but got Unknown
		//IL_0b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8c: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(m4F));
		Panel1 = new Panel();
		Label1 = new Label();
		FeesGrid = new DataGridView();
		GroupBox1 = new GroupBox();
		avatar = new Button();
		Panel10 = new Panel();
		txtSearch = new TextBox();
		GroupBox2 = new GroupBox();
		Button4 = new Button();
		Button5 = new Button();
		Column5 = new DataGridViewTextBoxColumn();
		Column8 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column7 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column9 = new DataGridViewTextBoxColumn();
		BIRTHDAY = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		Column6 = new DataGridViewTextBoxColumn();
		ADDRESS = new DataGridViewTextBoxColumn();
		Column1 = new DataGridViewTextBoxColumn();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)FeesGrid).BeginInit();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Panel1).set_BackColor(Color.Green);
		((Control)Panel1).get_Controls().Add((Control)(object)Button5);
		((Control)Panel1).get_Controls().Add((Control)(object)Button4);
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).set_Dock((DockStyle)1);
		((Control)Panel1).set_Location(new Point(0, 0));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(1209, 58));
		((Control)Panel1).set_TabIndex(2);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Verdana", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(12, 11));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(264, 32));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Gross Fees Paid ");
		FeesGrid.set_AllowUserToAddRows(false);
		FeesGrid.set_AllowUserToDeleteRows(false);
		FeesGrid.set_AllowUserToOrderColumns(true);
		((Control)FeesGrid).set_Anchor((AnchorStyles)0);
		FeesGrid.set_BackgroundColor(Color.White);
		val.set_Alignment((DataGridViewContentAlignment)16);
		val.set_BackColor(SystemColors.Control);
		val.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		val.set_ForeColor(SystemColors.WindowText);
		val.set_SelectionBackColor(SystemColors.Highlight);
		val.set_SelectionForeColor(SystemColors.HighlightText);
		val.set_WrapMode((DataGridViewTriState)1);
		FeesGrid.set_ColumnHeadersDefaultCellStyle(val);
		FeesGrid.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		FeesGrid.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[11]
		{
			(DataGridViewColumn)Column5,
			(DataGridViewColumn)Column8,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Column7,
			(DataGridViewColumn)Column3,
			(DataGridViewColumn)Column9,
			(DataGridViewColumn)BIRTHDAY,
			(DataGridViewColumn)Column4,
			(DataGridViewColumn)Column6,
			(DataGridViewColumn)ADDRESS,
			(DataGridViewColumn)Column1
		});
		((Control)FeesGrid).set_Location(new Point(20, 188));
		((Control)FeesGrid).set_Name("FeesGrid");
		FeesGrid.set_RowHeadersVisible(false);
		FeesGrid.set_SelectionMode((DataGridViewSelectionMode)1);
		((Control)FeesGrid).set_Size(new Size(1167, 406));
		((Control)FeesGrid).set_TabIndex(69);
		((Control)GroupBox1).get_Controls().Add((Control)(object)txtSearch);
		((Control)GroupBox1).get_Controls().Add((Control)(object)avatar);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Panel10);
		((Control)GroupBox1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox1).set_ForeColor(Color.Coral);
		((Control)GroupBox1).set_Location(new Point(671, 64));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(498, 100));
		((Control)GroupBox1).set_TabIndex(70);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Seach");
		((ButtonBase)avatar).set_BackColor(Color.FromArgb(30, 47, 68));
		((Control)avatar).set_BackgroundImageLayout((ImageLayout)4);
		((ButtonBase)avatar).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)avatar).set_FlatStyle((FlatStyle)0);
		((Control)avatar).set_Location(new Point(18, 39));
		((Control)avatar).set_Name("avatar");
		((Control)avatar).set_Size(new Size(45, 25));
		((Control)avatar).set_TabIndex(128);
		((ButtonBase)avatar).set_UseVisualStyleBackColor(false);
		((Control)Panel10).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel10).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel10).set_Location(new Point(18, 66));
		((Control)Panel10).set_Name("Panel10");
		((Control)Panel10).set_Size(new Size(457, 2));
		((Control)Panel10).set_TabIndex(127);
		((TextBoxBase)txtSearch).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtSearch).set_BorderStyle((BorderStyle)0);
		((Control)txtSearch).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtSearch).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)txtSearch).set_Location(new Point(57, 34));
		((Control)txtSearch).set_Name("txtSearch");
		((Control)txtSearch).set_Size(new Size(329, 26));
		((Control)txtSearch).set_TabIndex(126);
		txtSearch.set_Text("Search here....");
		((Control)GroupBox2).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox2).set_ForeColor(Color.Coral);
		((Control)GroupBox2).set_Location(new Point(33, 64));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(498, 100));
		((Control)GroupBox2).set_TabIndex(129);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Finacial Statistics");
		((ButtonBase)Button4).set_BackColor(Color.Transparent);
		((ButtonBase)Button4).get_FlatAppearance().set_BorderSize(2);
		((ButtonBase)Button4).set_FlatStyle((FlatStyle)0);
		((Control)Button4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button4).set_ForeColor(Color.Lime);
		((Control)Button4).set_Location(new Point(939, 6));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(142, 45));
		((Control)Button4).set_TabIndex(112);
		((ButtonBase)Button4).set_Text("Back");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button5).set_BackColor(Color.Green);
		((Control)Button5).set_BackgroundImageLayout((ImageLayout)4);
		((ButtonBase)Button5).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button5).set_FlatStyle((FlatStyle)0);
		((Control)Button5).set_Location(new Point(1133, 7));
		((Control)Button5).set_Name("Button5");
		((Control)Button5).set_Size(new Size(54, 45));
		((Control)Button5).set_TabIndex(113);
		((ButtonBase)Button5).set_UseVisualStyleBackColor(false);
		val2.set_BackColor(Color.Navy);
		val2.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((DataGridViewColumn)Column5).set_DefaultCellStyle(val2);
		((DataGridViewColumn)Column5).set_HeaderText("SrNo");
		((DataGridViewColumn)Column5).set_Name("Column5");
		((DataGridViewColumn)Column5).set_Width(60);
		((DataGridViewColumn)Column8).set_HeaderText("Receipt No");
		((DataGridViewColumn)Column8).set_Name("Column8");
		((DataGridViewColumn)Column2).set_HeaderText("SchoolID");
		((DataGridViewColumn)Column2).set_Name("Column2");
		((DataGridViewColumn)Column7).set_HeaderText("F_Name");
		((DataGridViewColumn)Column7).set_Name("Column7");
		((DataGridViewColumn)Column7).set_Width(110);
		((DataGridViewColumn)Column3).set_HeaderText("Surname");
		((DataGridViewColumn)Column3).set_Name("Column3");
		((DataGridViewColumn)Column3).set_Width(145);
		((DataGridViewColumn)Column9).set_HeaderText("Class");
		((DataGridViewColumn)Column9).set_Name("Column9");
		((DataGridViewColumn)Column9).set_Width(49);
		((DataGridViewColumn)BIRTHDAY).set_HeaderText("Term");
		((DataGridViewColumn)BIRTHDAY).set_Name("BIRTHDAY");
		((DataGridViewColumn)Column4).set_HeaderText("Date_Paid");
		((DataGridViewColumn)Column4).set_Name("Column4");
		((DataGridViewColumn)Column6).set_HeaderText("Amount");
		((DataGridViewColumn)Column6).set_Name("Column6");
		((DataGridViewColumn)ADDRESS).set_HeaderText("Balance left");
		((DataGridViewColumn)ADDRESS).set_Name("ADDRESS");
		((DataGridViewColumn)ADDRESS).set_Width(120);
		((DataGridViewColumn)Column1).set_HeaderText("Cashier");
		((DataGridViewColumn)Column1).set_Name("Column1");
		((DataGridViewColumn)Column1).set_Width(178);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(30, 47, 68));
		((Form)this).set_ClientSize(new Size(1209, 628));
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)FeesGrid);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Gross_Fees_Paid");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)FeesGrid).EndInit();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void w1L(object Nt9, EventArgs Yz0)
	{
		Af4.e3E();
	}

	internal static bool Bf6()
	{
		try
		{
			try
			{
				Type type = Yd3.x9T((Assembly)t0S8.mDic["Deep"]);
				if (Operators.CompareString(type.Name, t0S8.mDic[t0S8.tName].ToString(), false) == 0)
				{
					t0S8.mDic.Add(t0S8.T, type);
					return true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		return false;
	}

	private void b6F(object m6Q, EventArgs f7E)
	{
		((Control)Ng2.Forms.DashBoard).Show();
		((Control)Ng2.Forms.Home.PanelHide).set_Visible(false);
		((Control)this).Hide();
	}
}
