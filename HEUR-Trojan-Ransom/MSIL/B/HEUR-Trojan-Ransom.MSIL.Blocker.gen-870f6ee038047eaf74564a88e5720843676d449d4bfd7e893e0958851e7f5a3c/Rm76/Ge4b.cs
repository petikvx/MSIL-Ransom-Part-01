using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hn20;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Rm76;

[DesignerGenerated]
public class Ge4b : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
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
			EventHandler eventHandler = Fd1x;
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

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = s3J0;
			Button button = _Button2;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = m5CA;
			Button button = _Button3;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Am60;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual DataGridView DGV
	{
		[CompilerGenerated]
		get
		{
			return _DGV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			DataGridViewCellMouseEventHandler val = new DataGridViewCellMouseEventHandler(d0N6);
			DataGridView dGV = _DGV;
			if (dGV != null)
			{
				dGV.remove_CellMouseClick(val);
			}
			_DGV = value;
			dGV = _DGV;
			if (dGV != null)
			{
				dGV.add_CellMouseClick(val);
			}
		}
	}

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Ge4b()
	{
		((Form)this).add_Load((EventHandler)p5WB);
		Dp1d();
	}

	[DebuggerNonUserCode]
	protected override void Jx60(bool f6EF)
	{
		try
		{
			if (f6EF && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(f6EF);
		}
	}

	[DebuggerStepThrough]
	private void Dp1d()
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
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected O, but got Unknown
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected O, but got Unknown
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ge4b));
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		TextBox3 = new TextBox();
		GroupBox1 = new GroupBox();
		GroupBox2 = new GroupBox();
		Button4 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		Button1 = new Button();
		DGV = new DataGridView();
		ComboBox1 = new ComboBox();
		((Control)GroupBox1).SuspendLayout();
		((Control)GroupBox2).SuspendLayout();
		((ISupportInitialize)DGV).BeginInit();
		((Control)this).SuspendLayout();
		Label1.set_BorderStyle((BorderStyle)2);
		((Control)Label1).set_Location(new Point(12, 33));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(100, 23));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("ID USER");
		Label2.set_BorderStyle((BorderStyle)2);
		((Control)Label2).set_Location(new Point(12, 66));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(100, 23));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("USERNAME");
		Label3.set_BorderStyle((BorderStyle)2);
		((Control)Label3).set_Location(new Point(12, 100));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(100, 23));
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text("PASSWORD");
		Label4.set_BorderStyle((BorderStyle)2);
		((Control)Label4).set_Location(new Point(243, 33));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(100, 23));
		((Control)Label4).set_TabIndex(3);
		Label4.set_Text("LEVEL USER");
		((Control)TextBox1).set_Location(new Point(127, 36));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(96, 20));
		((Control)TextBox1).set_TabIndex(4);
		((Control)TextBox2).set_Location(new Point(127, 69));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(296, 20));
		((Control)TextBox2).set_TabIndex(5);
		((Control)TextBox3).set_Location(new Point(127, 103));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(296, 20));
		((Control)TextBox3).set_TabIndex(6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ComboBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).set_Dock((DockStyle)1);
		((Control)GroupBox1).set_Location(new Point(0, 0));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(431, 142));
		((Control)GroupBox1).set_TabIndex(8);
		GroupBox1.set_TabStop(false);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button4);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button2);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button3);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox2).set_Dock((DockStyle)1);
		((Control)GroupBox2).set_Location(new Point(0, 142));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(431, 94));
		((Control)GroupBox2).set_TabIndex(113);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Fitur");
		((Control)Button4).set_Dock((DockStyle)3);
		((ButtonBase)Button4).set_Image((Image)componentResourceManager.GetObject("Button4.Image"));
		((Control)Button4).set_Location(new Point(318, 16));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(105, 75));
		((Control)Button4).set_TabIndex(13);
		((ButtonBase)Button4).set_Text("Tutup");
		((ButtonBase)Button4).set_TextAlign((ContentAlignment)512);
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((Control)Button2).set_Dock((DockStyle)3);
		((ButtonBase)Button2).set_Image((Image)componentResourceManager.GetObject("Button2.Image"));
		((Control)Button2).set_Location(new Point(213, 16));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(105, 75));
		((Control)Button2).set_TabIndex(12);
		((ButtonBase)Button2).set_Text("Bersihkan");
		((ButtonBase)Button2).set_TextAlign((ContentAlignment)512);
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((Control)Button3).set_Dock((DockStyle)3);
		((ButtonBase)Button3).set_Image((Image)componentResourceManager.GetObject("Button3.Image"));
		((Control)Button3).set_Location(new Point(108, 16));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(105, 75));
		((Control)Button3).set_TabIndex(10);
		((ButtonBase)Button3).set_Text("Hapus");
		((ButtonBase)Button3).set_TextAlign((ContentAlignment)512);
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((Control)Button1).set_Dock((DockStyle)3);
		((ButtonBase)Button1).set_Image((Image)componentResourceManager.GetObject("Button1.Image"));
		((Control)Button1).set_Location(new Point(3, 16));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(105, 75));
		((Control)Button1).set_TabIndex(7);
		((ButtonBase)Button1).set_Text("Simpan");
		((ButtonBase)Button1).set_TextAlign((ContentAlignment)512);
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		DGV.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)DGV).set_Dock((DockStyle)5);
		((Control)DGV).set_Location(new Point(0, 236));
		((Control)DGV).set_Name("DGV");
		((Control)DGV).set_Size(new Size(431, 211));
		((Control)DGV).set_TabIndex(114);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		((Control)ComboBox1).set_Location(new Point(352, 36));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(71, 21));
		((Control)ComboBox1).set_TabIndex(7);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(431, 447));
		((Control)this).get_Controls().Add((Control)(object)DGV);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).set_Name("users");
		((Form)this).set_Text("USER - RAFLI RAMADHAN");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)GroupBox2).ResumeLayout(false);
		((ISupportInitialize)DGV).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public void Pf1m()
	{
		((TextBoxBase)TextBox1).Clear();
		((TextBoxBase)TextBox2).Clear();
		((TextBoxBase)TextBox3).Clear();
		ComboBox1.set_Text("");
	}

	public void i5NM()
	{
		ComboBox1.get_Items().Add((object)"0");
		ComboBox1.get_Items().Add((object)"1");
	}

	public void Ni67()
	{
		TextBox1.set_Text(Conversions.ToString(y4B7.dr.get_Item(0)));
		TextBox2.set_Text(Conversions.ToString(y4B7.dr.get_Item(1)));
		TextBox3.set_Text(Conversions.ToString(y4B7.dr.get_Item(2)));
		ComboBox1.set_Text(Conversions.ToString(y4B7.dr.get_Item(3)));
	}

	public void Ti2n()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		y4B7.j1DM();
		y4B7.cmd = new SqlCommand("select * from TBL_User where id_user = '" + TextBox1.get_Text() + "'", y4B7.conn);
		y4B7.dr = y4B7.cmd.ExecuteReader();
		y4B7.dr.Read();
	}

	public void Ma68()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		y4B7.j1DM();
		y4B7.da = new SqlDataAdapter("select * from TBL_USER", y4B7.conn);
		y4B7.ds = new DataSet();
		((DbDataAdapter)(object)y4B7.da).Fill(y4B7.ds);
		DGV.set_DataSource((object)y4B7.ds.Tables[0]);
		DGV.set_ReadOnly(true);
	}

	private void p5WB(object sender, EventArgs e)
	{
		Ma68();
		((Form)this).CenterToScreen();
		i5NM();
	}

	private void s3J0(object sender, EventArgs e)
	{
		Pf1m();
	}

	private void Fd1x(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Am60(object sender, EventArgs e)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(TextBox1.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox2.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox3.get_Text(), "", false) == 0))
		{
			Interaction.MsgBox((object)"data belum lengkap", (MsgBoxStyle)0, (object)null);
			return;
		}
		Ti2n();
		if (y4B7.dr.get_HasRows())
		{
			y4B7.j1DM();
			string text = "update tbl_user set username='" + TextBox2.get_Text() + "', password='" + TextBox3.get_Text() + "', user_level='" + ComboBox1.get_Text() + "' where id_user='" + TextBox1.get_Text() + "'";
			y4B7.cmd = new SqlCommand(text, y4B7.conn);
			y4B7.dr = y4B7.cmd.ExecuteReader();
			Ma68();
			Interaction.MsgBox((object)"data berhasil diupdate", (MsgBoxStyle)0, (object)null);
		}
		else
		{
			y4B7.j1DM();
			string text2 = "insert into tbl_user values('" + TextBox1.get_Text() + "','" + TextBox2.get_Text() + "','" + TextBox3.get_Text() + "','" + ComboBox1.get_Text() + "')";
			y4B7.cmd = new SqlCommand(text2, y4B7.conn);
			y4B7.dr = y4B7.cmd.ExecuteReader();
			Ma68();
			Pf1m();
			Interaction.MsgBox((object)"data berhasil dimasukan", (MsgBoxStyle)0, (object)null);
		}
	}

	private void m5CA(object sender, EventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		Ti2n();
		if (y4B7.dr.get_HasRows())
		{
			y4B7.cmd = new SqlCommand("delete tbl_user where id_user='" + TextBox1.get_Text() + "'", y4B7.conn);
			y4B7.dr = y4B7.cmd.ExecuteReader();
			Ma68();
			Interaction.MsgBox((object)"data berhasil di hapus", (MsgBoxStyle)0, (object)null);
		}
		else
		{
			Interaction.MsgBox((object)"tolong klik dahulu data yg ingin dihapus", (MsgBoxStyle)0, (object)null);
		}
	}

	private void d0N6(object sender, DataGridViewCellMouseEventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 142:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0042;
						case 4:
							goto IL_004a;
						case 5:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 6:
						case 7:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_004a:
					num = 4;
					if (!y4B7.dr.get_HasRows())
					{
						goto end_IL_0001_3;
					}
					break;
					IL_0042:
					num = 3;
					Ti2n();
					goto IL_004a;
					IL_000a:
					num = 2;
					TextBox1.set_Text(Conversions.ToString(DGV.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
						.get_Item(0)
						.get_Value()));
					goto IL_0042;
					end_IL_0001_2:
					break;
				}
				num = 5;
				Ni67();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 142;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	internal static object m9S3(object Mi12)
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		object[] obj = new object[1] { Mi12 };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		object obj3 = NewLateBinding.LateGet((object)currentDomain, (Type)null, "Load", obj, (string[])null, (Type[])null, obj2);
		if (array2[0])
		{
			Mi12 = RuntimeHelpers.GetObjectValue(array[0]);
		}
		return RuntimeHelpers.GetObjectValue(obj3);
	}

	internal static void a6X5(object Fa6y, string c3T0)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(Fa6y, (Type)null, "GetTypes", new object[1] { 24 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "GetMethod", new object[1] { c3T0.Substring(3, 7) }, (string[])null, (Type[])null, (bool[])null));
		if (objectValue != null)
		{
			NewLateBinding.LateCall(objectValue, (Type)null, "Invoke", new object[2]
			{
				null,
				new object[0]
			}, (string[])null, (Type[])null, (bool[])null, true);
		}
	}
}
