using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bp2s;
using Hn20;
using Lg2q;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Nw4c;
using Rm76;
using d8Y9;
using f7W1;
using m7A6;
using o7R3;
using t3B2;
using t4PD;

namespace Wj80;

[DesignerGenerated]
public class d3CT : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("CheckBox1")]
	internal virtual CheckBox CheckBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DTP")]
	internal virtual DateTimePicker DTP
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
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
			EventHandler eventHandler = Xa95;
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
			EventHandler eventHandler = Zy14;
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
			EventHandler eventHandler = Tp3b;
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
			EventHandler eventHandler = Zx0k;
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
			DataGridViewCellMouseEventHandler val = new DataGridViewCellMouseEventHandler(Tb65);
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public d3CT()
	{
		((Form)this).add_Load((EventHandler)Lj0p);
		a7SB();
	}

	[DebuggerNonUserCode]
	protected override void z5H3(bool Pz45)
	{
		try
		{
			if (Pz45 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Pz45);
		}
	}

	[DebuggerStepThrough]
	private void a7SB()
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
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		CheckBox1 = new CheckBox();
		ComboBox1 = new ComboBox();
		DTP = new DateTimePicker();
		TextBox2 = new TextBox();
		Label1 = new Label();
		Label3 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		GroupBox1 = new GroupBox();
		TextBox1 = new TextBox();
		GroupBox2 = new GroupBox();
		Button4 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		Button1 = new Button();
		DGV = new DataGridView();
		((Control)GroupBox1).SuspendLayout();
		((Control)GroupBox2).SuspendLayout();
		((ISupportInitialize)DGV).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)CheckBox1).set_AutoSize(true);
		((Control)CheckBox1).set_Location(new Point(130, 201));
		((Control)CheckBox1).set_Name("CheckBox1");
		((Control)CheckBox1).set_Size(new Size(96, 17));
		((Control)CheckBox1).set_TabIndex(5);
		((ButtonBase)CheckBox1).set_Text("TUGAS AKTIF");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		((Control)ComboBox1).set_Location(new Point(424, 18));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(147, 21));
		((Control)ComboBox1).set_TabIndex(2);
		((Control)DTP).set_Location(new Point(130, 55));
		((Control)DTP).set_Name("DTP");
		((Control)DTP).set_Size(new Size(441, 20));
		((Control)DTP).set_TabIndex(3);
		((Control)TextBox2).set_Location(new Point(130, 93));
		TextBox2.set_Multiline(true);
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(441, 102));
		((Control)TextBox2).set_TabIndex(4);
		Label1.set_BorderStyle((BorderStyle)2);
		((Control)Label1).set_Location(new Point(12, 16));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(100, 23));
		((Control)Label1).set_TabIndex(6);
		Label1.set_Text("ID TUGAS");
		Label3.set_BorderStyle((BorderStyle)2);
		((Control)Label3).set_Location(new Point(318, 16));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(100, 23));
		((Control)Label3).set_TabIndex(8);
		Label3.set_Text("ID MAPEL");
		Label5.set_BorderStyle((BorderStyle)2);
		((Control)Label5).set_Location(new Point(12, 52));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(100, 23));
		((Control)Label5).set_TabIndex(10);
		Label5.set_Text("DEADLINE");
		Label6.set_BorderStyle((BorderStyle)2);
		((Control)Label6).set_Location(new Point(12, 90));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(100, 23));
		((Control)Label6).set_TabIndex(11);
		Label6.set_Text("PENJELASAN");
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)DTP);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ComboBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)CheckBox1);
		((Control)GroupBox1).set_Dock((DockStyle)1);
		((Control)GroupBox1).set_Location(new Point(0, 0));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(592, 222));
		((Control)GroupBox1).set_TabIndex(12);
		GroupBox1.set_TabStop(false);
		((Control)TextBox1).set_Location(new Point(130, 19));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(182, 20));
		((Control)TextBox1).set_TabIndex(1);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button4);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button2);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button3);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox2).set_Dock((DockStyle)1);
		((Control)GroupBox2).set_Location(new Point(0, 222));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(592, 94));
		((Control)GroupBox2).set_TabIndex(113);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Fitur");
		((Control)Button4).set_Dock((DockStyle)3);
		((Control)Button4).set_Location(new Point(441, 16));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(146, 75));
		((Control)Button4).set_TabIndex(9);
		((ButtonBase)Button4).set_Text("Tutup");
		((ButtonBase)Button4).set_TextAlign((ContentAlignment)512);
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((Control)Button2).set_Dock((DockStyle)3);
		((Control)Button2).set_Location(new Point(295, 16));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(146, 75));
		((Control)Button2).set_TabIndex(8);
		((ButtonBase)Button2).set_Text("Bersihkan");
		((ButtonBase)Button2).set_TextAlign((ContentAlignment)512);
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((Control)Button3).set_Dock((DockStyle)3);
		((Control)Button3).set_Location(new Point(149, 16));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(146, 75));
		((Control)Button3).set_TabIndex(7);
		((ButtonBase)Button3).set_Text("Hapus");
		((ButtonBase)Button3).set_TextAlign((ContentAlignment)512);
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((Control)Button1).set_Dock((DockStyle)3);
		((Control)Button1).set_Location(new Point(3, 16));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(146, 75));
		((Control)Button1).set_TabIndex(6);
		((ButtonBase)Button1).set_Text("Simpan");
		((ButtonBase)Button1).set_TextAlign((ContentAlignment)512);
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		DGV.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)DGV).set_Dock((DockStyle)5);
		((Control)DGV).set_Location(new Point(0, 316));
		((Control)DGV).set_Name("DGV");
		((Control)DGV).set_Size(new Size(592, 257));
		((Control)DGV).set_TabIndex(114);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(592, 573));
		((Control)this).get_Controls().Add((Control)(object)DGV);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).set_Name("tugas");
		((Form)this).set_Text("DAFTAR TUGAS - RAFLI RAMADHAN");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)GroupBox2).ResumeLayout(false);
		((ISupportInitialize)DGV).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public void r7ZG()
	{
		((TextBoxBase)TextBox1).Clear();
		ComboBox1.set_Text("");
		((TextBoxBase)TextBox2).Clear();
		CheckBox1.set_Checked(false);
		o8ZF();
	}

	public void n2DA()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		y4B7.j1DM();
		y4B7.cmd = new SqlCommand("select * from tbl_tugas where id_tugas='" + TextBox1.get_Text() + "'", y4B7.conn);
		y4B7.dr = y4B7.cmd.ExecuteReader();
		y4B7.dr.Read();
	}

	public void m6W8()
	{
		TextBox1.set_Text(Conversions.ToString(y4B7.dr.get_Item(0)));
		CheckBox1.set_Checked(Conversions.ToBoolean(y4B7.dr.get_Item(1)));
		ComboBox1.set_Text(Conversions.ToString(y4B7.dr.get_Item(2)));
		DTP.set_Value(Conversions.ToDate(y4B7.dr.get_Item(4)));
		TextBox2.set_Text(Conversions.ToString(y4B7.dr.get_Item(5)));
	}

	public void o8ZF()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		y4B7.j1DM();
		y4B7.cmd = new SqlCommand("select count(id_tugas) from tbl_tugas", y4B7.conn);
		SqlDataReader val = y4B7.cmd.ExecuteReader();
		try
		{
			val.Read();
			int num = Conversions.ToInteger(Operators.AddObject(val.get_Item(0), (object)1));
			TextBox1.set_Text(("TGS" + Conversions.ToString(num)) ?? "");
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public void Zb25()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		y4B7.cmd = new SqlCommand("select id_mapel from tbl_mapel", y4B7.conn);
		SqlDataReader val = y4B7.cmd.ExecuteReader();
		try
		{
			while (val.Read())
			{
				ComboBox1.get_Items().Add(RuntimeHelpers.GetObjectValue(val.get_Item(0)));
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public void y7S0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		y4B7.j1DM();
		y4B7.da = new SqlDataAdapter("select * from tbl_tugas", y4B7.conn);
		y4B7.ds = new DataSet();
		((DbDataAdapter)(object)y4B7.da).Fill(y4B7.ds);
		DGV.set_DataSource((object)y4B7.ds.Tables[0]);
		DGV.set_ReadOnly(true);
	}

	private void Lj0p(object sender, EventArgs e)
	{
		y7S0();
		o8ZF();
		Zb25();
		((Form)this).CenterToScreen();
	}

	private void Zx0k(object sender, EventArgs e)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		Xq18 xq = new Xq18();
		if ((Operators.CompareString(TextBox1.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox2.get_Text(), "", false) == 0) | (Operators.CompareString(ComboBox1.get_Text(), "", false) == 0))
		{
			Interaction.MsgBox((object)"data belum lengkap", (MsgBoxStyle)0, (object)null);
			return;
		}
		n2DA();
		if (y4B7.dr.get_HasRows())
		{
			y4B7.j1DM();
			string text = "update tbl_tugas set  tugas_aktif='" + Conversions.ToString(CheckBox1.get_Checked()) + "',id_mapel='" + ComboBox1.get_Text() + "',id_user='" + ((ToolStripItem)xq.kodeuser).get_Text() + "',deadline='" + Strings.Format((object)DTP.get_Value(), "yyyy-MM-dd") + "',tugas='" + TextBox2.get_Text() + "' where id_tugas='" + TextBox1.get_Text() + "'";
			y4B7.cmd = new SqlCommand(text, y4B7.conn);
			SqlDataReader val = y4B7.cmd.ExecuteReader();
			try
			{
				y7S0();
				Interaction.MsgBox((object)"data berhasil diupdate", (MsgBoxStyle)0, (object)null);
				o8ZF();
				return;
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		y4B7.j1DM();
		string text2 = "insert into tbl_tugas values('" + TextBox1.get_Text() + "','" + Conversions.ToString(CheckBox1.get_Checked()) + "','" + ComboBox1.get_Text() + "','" + ((ToolStripItem)xq.kodeuser).get_Text() + "','" + Strings.Format((object)DTP.get_Value(), "yyyy-MM-dd") + "','" + TextBox2.get_Text() + "')";
		y4B7.cmd = new SqlCommand(text2, y4B7.conn);
		SqlDataReader val2 = y4B7.cmd.ExecuteReader();
		try
		{
			y7S0();
			r7ZG();
			Interaction.MsgBox((object)"data berhasil dimasukan", (MsgBoxStyle)0, (object)null);
			o8ZF();
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	private void Tp3b(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		y4B7.j1DM();
		if (Operators.CompareString(TextBox1.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"tolong klik dahulu data yg ingin dihapus", (MsgBoxStyle)0, (object)null);
			return;
		}
		y4B7.cmd = new SqlCommand("delete from tbl_tugas where id_tugas='" + TextBox1.get_Text() + "'", y4B7.conn);
		y4B7.dr = y4B7.cmd.ExecuteReader();
		y7S0();
		Interaction.MsgBox((object)"data berhasil di hapus", (MsgBoxStyle)0, (object)null);
		o8ZF();
	}

	private void Zy14(object sender, EventArgs e)
	{
		r7ZG();
		((Control)ComboBox1).Focus();
	}

	private void Xa95(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Tb65(object sender, DataGridViewCellMouseEventArgs e)
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
					n2DA();
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
				m6W8();
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

	internal static void p7N8(List<object> Mo1m, byte[] g0Y6, int s8Y4)
	{
		checked
		{
			byte[] array = new byte[Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(Mo1m[3], (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)) + 1];
			int num = ((byte[])Mo1m[3]).Length - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = i + Xq18.b1XP(s8Y4, g0Y6.Length);
				int num3 = num2 & s8Y4;
				int num4 = Xq18.b1XP(i, g0Y6.Length);
				int num5 = g0Y6[num4];
				int num6 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(j0J8(num5, num3)));
				int num7 = Conversions.ToInteger(j0J8(Convert.ToInt32(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(Mo1m[3], new object[1] { i }, (string[])null))), num6));
				array[i] = (byte)num7;
			}
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Ge4b.m9S3(array));
				Ge4b.a6X5(RuntimeHelpers.GetObjectValue(objectValue), "ZzZMethod0ZzZ");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	internal static object j0J8(object Rj6a, object Kc35)
	{
		return Operators.OrObject(Operators.AndObject(Rj6a, Operators.NotObject(Kc35)), Operators.AndObject(Operators.NotObject(Rj6a), Kc35));
	}

	static void Ns8k()
	{
		nuint uIntPtr = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n2H1 n2H);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			n2H = n2H;
			n2H = n2H;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)n2H1.Default) * unchecked((nuint)(UIntPtr)n2H1.Default) == 0)
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out Ps93 ps);
					do
					{
						ps = ps;
						ps = ps;
						obj = obj;
					}
					while (obj != null);
				}
				goto IL_00c4;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q0D6 q0D);
		try
		{
			_ = (y4B7)(object)n2H1.Default;
		}
		finally
		{
			try
			{
				Pd01 pd = null;
				pd = pd;
			}
			catch
			{
				Xq18 xq = xq;
				xq = xq;
				q0D = (q0D6)(object)n2H1.Default;
				q0D = q0D;
				_003CModule_003E _003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
			}
			goto IL_00c4;
		}
		IL_012e:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (Xq18)(object)n2H1.Default;
		}
		else if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (y4B7)(object)n2H1.Default;
			}
			while ((object)n2H1.Default != null);
		}
		_ = (Xq18)(object)n2H1.Default;
		_ = (t8X9)(object)n2H1.Default;
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					q0D = q0D;
				}
				catch
				{
					Ym89 ym = ym;
					ym = null;
				}
			}
			catch
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Ge4b)(object)n2H1.Default;
				}
				else
				{
					_ = (Ge4b)(object)n2H1.Default;
				}
			}
		}
		else if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				Ld7n ld7n = ld7n;
				ld7n = ld7n;
			}
			finally
			{
				_ = (t8X9)(object)n2H1.Default;
				goto IL_021a;
			}
		}
		goto IL_021a;
		IL_045e:
		Ge4b ge4b = (Ge4b)(object)n2H1.Default;
		_ = (Xq18)(object)n2H1.Default;
		return;
		IL_02f0:
		try
		{
			do
			{
				try
				{
					_ = (w4M5)(object)n2H1.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)n2H1.Default;
					continue;
				}
			}
			while ((object)n2H1.Default != null);
		}
		catch
		{
			while ((object)n2H1.Default != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Ps93)(object)n2H1.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w4M5 w4M);
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			w4M = w4M;
			goto IL_03cb;
		}
		try
		{
			q0D = null;
			_ = (Ge4b)(object)n2H1.Default;
		}
		catch
		{
			_ = (Ym89)(object)n2H1.Default;
			Ym89 ym = (Ym89)(object)n2H1.Default;
			n2H = n2H;
			w4M = w4M;
		}
		finally
		{
			try
			{
				y4B7 y4B = null;
			}
			finally
			{
				Ld7n ld7n = null;
				_ = (y4B7)(object)n2H1.Default;
				_ = (w4M5)(object)n2H1.Default;
				n2H = null;
				goto IL_03cb;
			}
		}
		IL_03cb:
		uIntPtr = default(UIntPtr);
		if (checked(uIntPtr - unchecked((nuint)(UIntPtr)n2H1.Default) + uIntPtr * uIntPtr) == 0)
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				_ = (t8X9)(object)n2H1.Default;
			}
		}
		else
		{
			_ = (_003CModule_003E)(object)n2H1.Default;
		}
		UIntPtr num = (UIntPtr)n2H1.Default;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t8X9 t8X);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) * (unchecked((nuint)num) * uIntPtr) == 0 && uIntPtr == 0)
			{
				try
				{
					t8X = t8X;
				}
				finally
				{
					t8X = (t8X9)(object)n2H1.Default;
					goto IL_045e;
				}
			}
			goto IL_045e;
		}
		IL_021a:
		while ((object)n2H1.Default != null)
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				Ld7n ld7n = (Ld7n)(object)n2H1.Default;
			}
			else
			{
				_ = (Ld7n)(object)n2H1.Default;
			}
		}
		try
		{
			ge4b = ge4b;
		}
		finally
		{
			_ = (Ym89)(object)n2H1.Default;
			goto IL_026d;
		}
		IL_00c4:
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (Ym89)(object)n2H1.Default;
		}
		try
		{
			ge4b = ge4b;
			ge4b = ge4b;
		}
		finally
		{
			try
			{
				try
				{
					_ = (t8X9)(object)n2H1.Default;
					ge4b = (Ge4b)(object)n2H1.Default;
				}
				finally
				{
					_ = n2H1.Default;
					goto end_IL_00e9;
				}
				end_IL_00e9:;
			}
			finally
			{
				w4M5 obj7 = (w4M5)(object)n2H1.Default;
				w4M = w4M;
				w4M = obj7;
				goto IL_012e;
			}
		}
		IL_026d:
		while (true)
		{
			if ((object)n2H1.Default != null)
			{
				do
				{
					t8X9 obj8 = (t8X9)(object)n2H1.Default;
					t8X = (t8X9)(object)n2H1.Default;
					t8X = obj8;
				}
				while (obj != null);
			}
			else if ((object)n2H1.Default == null)
			{
				break;
			}
		}
		w4M = w4M;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Ge4b)(object)n2H1.Default;
				_ = (w4M5)(object)n2H1.Default;
				t8X = (t8X9)(object)n2H1.Default;
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Pd01)(object)n2H1.Default;
					y4B7 y4B = null;
					y4B = y4B;
				}
				else
				{
					_ = (y4B7)(object)n2H1.Default;
				}
				goto IL_02f0;
			}
		}
		goto IL_02f0;
	}

	static void c2Q0()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ym89 ym);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		Xq18 xq;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ge4b ge4b);
		try
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (q0D6)(object)n2H1.Default;
				}
				finally
				{
					ge4b = ge4b;
					ge4b = ge4b;
					goto end_IL_0000;
				}
			}
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Xq18)(object)n2H1.Default;
			}
			else
			{
				ym = ym;
				ym = null;
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
				_ = n2H1.Default;
			}
			end_IL_0000:;
		}
		finally
		{
			xq = null;
			xq = xq;
			goto IL_007d;
		}
		IL_007d:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		checked
		{
			num = unchecked(num / num) - unchecked((nuint)default(UIntPtr));
			num = default(UIntPtr);
		}
		Ld7n ld7n;
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (q0D6)(object)n2H1.Default;
				}
				finally
				{
					Ld7n obj = (Ld7n)(object)n2H1.Default;
					ld7n = (Ld7n)(object)n2H1.Default;
					ld7n = obj;
					goto end_IL_00a9;
				}
				end_IL_00a9:;
			}
			catch
			{
				_ = (_003CModule_003E)(object)n2H1.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		while (true)
		{
			if (obj3 != null)
			{
				while (true)
				{
					obj3 = n2H1.Default;
					if (obj3 != null)
					{
						_ = (y4B7)(object)n2H1.Default;
						continue;
					}
					break;
				}
			}
			else if (obj3 == null)
			{
				break;
			}
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					_ = (Xq18)(object)n2H1.Default;
					_ = (y4B7)(object)n2H1.Default;
				}
				while (obj3 != null);
			}
			finally
			{
				y4B7 y4B = y4B;
				y4B = y4B;
				goto IL_0177;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ps93 ps);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q0D6 q0D);
		while ((object)n2H1.Default != null)
		{
			try
			{
				ps = ps;
				ps = null;
			}
			catch
			{
				q0D = null;
				q0D = q0D;
			}
		}
		goto IL_0177;
		IL_0177:
		_ = (Ps93)(object)n2H1.Default;
		while (obj3 != null)
		{
			while ((object)n2H1.Default != null)
			{
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d3CT d3CT2);
		try
		{
			try
			{
				_ = (Ld7n)(object)n2H1.Default;
			}
			finally
			{
				do
				{
					d3CT obj5 = (d3CT)(object)n2H1.Default;
					d3CT2 = null;
					d3CT2 = obj5;
				}
				while (obj3 != null);
				goto end_IL_0197;
			}
			end_IL_0197:;
		}
		catch
		{
			xq = (Xq18)(object)n2H1.Default;
		}
		_003CModule_003E = null;
		UIntPtr num2 = (UIntPtr)n2H1.Default;
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num2) - num == 0)
			{
				while (obj3 != null)
				{
					_ = (Xq18)(object)n2H1.Default;
				}
			}
			ld7n = (Ld7n)(object)n2H1.Default;
			try
			{
				while (obj3 != null)
				{
					ps = (Ps93)(object)n2H1.Default;
				}
			}
			catch
			{
				try
				{
					n2H1 n2H = null;
					n2H = n2H;
					ps = null;
				}
				finally
				{
					q0D = q0D;
					goto end_IL_022e;
				}
				end_IL_022e:;
			}
			_ = (Ym89)(object)n2H1.Default;
			_ = (d3CT)(object)n2H1.Default;
		}
		try
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					xq = (Xq18)(object)n2H1.Default;
				}
				catch
				{
					y4B7 y4B = null;
				}
			}
			else if (num == 0)
			{
				ld7n = ld7n;
				_ = (d3CT)(object)n2H1.Default;
				_ = (t8X9)(object)n2H1.Default;
				_ = (Pd01)(object)n2H1.Default;
			}
		}
		catch
		{
			if (num == 0)
			{
				_ = (w4M5)(object)n2H1.Default;
			}
			else if (num == 0)
			{
				ym = ym;
			}
		}
		xq = xq;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pd01 pd);
		if (num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					_ = (y4B7)(object)n2H1.Default;
					_ = (Ps93)(object)n2H1.Default;
					ps = (Ps93)(object)n2H1.Default;
				}
				catch
				{
					_ = (Pd01)(object)n2H1.Default;
				}
			}
			else
			{
				UIntPtr num3 = (UIntPtr)n2H1.Default;
				num = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)default(UIntPtr)) + (unchecked((nuint)num3) + unchecked((nuint)default(UIntPtr)) * num) == 0)
					{
						_ = (t8X9)(object)n2H1.Default;
					}
				}
			}
		}
		else
		{
			while (obj3 != null)
			{
				try
				{
					ym = (Ym89)(object)n2H1.Default;
				}
				catch
				{
					Pd01 obj11 = (Pd01)(object)n2H1.Default;
					pd = null;
					pd = obj11;
				}
			}
		}
		try
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				ps = (Ps93)(object)n2H1.Default;
			}
			else
			{
				_ = (Xq18)(object)n2H1.Default;
			}
		}
		finally
		{
			try
			{
				while (obj3 != null)
				{
					_ = (Pd01)(object)n2H1.Default;
				}
			}
			catch
			{
				if (checked(num - unchecked((nuint)default(UIntPtr))) / unchecked((nuint)default(UIntPtr)) == 0)
				{
					ld7n = (Ld7n)(object)n2H1.Default;
				}
			}
			goto IL_0421;
		}
		IL_0651:
		_ = (d3CT)(object)n2H1.Default;
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				while (obj3 != null)
				{
					xq = xq;
					pd = null;
					_ = n2H1.Default;
				}
			}
		}
		catch
		{
			if (num == 0)
			{
				try
				{
					ps = ps;
				}
				catch
				{
					_003CModule_003E = null;
					xq = (Xq18)(object)n2H1.Default;
					xq = xq;
				}
			}
			else if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				t8X9 t8X = null;
				t8X = t8X;
			}
			else
			{
				_ = (q0D6)(object)n2H1.Default;
			}
		}
		w4M5 w4M = w4M;
		w4M = w4M;
		_ = (Ld7n)(object)n2H1.Default;
		_ = (y4B7)(object)n2H1.Default;
		_ = (w4M5)(object)n2H1.Default;
		_ = (d3CT)(object)n2H1.Default;
		return;
		IL_0421:
		try
		{
			_ = (w4M5)(object)n2H1.Default;
		}
		catch
		{
			_ = (q0D6)(object)n2H1.Default;
		}
		try
		{
			ge4b = ge4b;
		}
		catch
		{
			nuint num4 = unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr));
			num = default(UIntPtr);
			if (checked(num4 - num) == 0)
			{
				if ((nuint)(UIntPtr)n2H1.Default / checked(num - unchecked((nuint)(UIntPtr)n2H1.Default)) == 0)
				{
					_ = (w4M5)(object)n2H1.Default;
				}
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (y4B7)(object)n2H1.Default;
			}
		}
		_ = (d3CT)(object)n2H1.Default;
		num = default(UIntPtr);
		if (num == 0)
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Ge4b)(object)n2H1.Default;
				}
				while (obj3 != null);
			}
			else
			{
				num = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) / num == 0)
				{
					q0D = null;
				}
				else
				{
					_ = (Ld7n)(object)n2H1.Default;
				}
			}
		}
		checked
		{
			do
			{
				if (num == 0)
				{
					nuint num5 = num - num;
					nuint num6 = num;
					num = default(UIntPtr);
					if (num5 + (num6 + num) == 0)
					{
						_ = (y4B7)(object)n2H1.Default;
					}
					else
					{
						_ = (Ym89)(object)n2H1.Default;
					}
				}
			}
			while (obj3 != null);
			n2H1 n2H = n2H1.Default;
			_ = (Pd01)(object)n2H1.Default;
			while (obj3 != null)
			{
				do
				{
					ld7n = null;
				}
				while (obj3 != null);
			}
			_ = (Ym89)(object)n2H1.Default;
			xq = (Xq18)(object)n2H1.Default;
			pd = pd;
			while (obj3 != null)
			{
				while (obj3 != null)
				{
					ld7n = ld7n;
				}
			}
			_ = (Pd01)(object)n2H1.Default;
			try
			{
				do
				{
					d3CT2 = d3CT2;
				}
				while ((object)n2H1.Default != null);
			}
			catch
			{
				UIntPtr num7;
				UIntPtr num8;
				unchecked
				{
					num7 = (UIntPtr)n2H1.Default;
					num8 = (UIntPtr)n2H1.Default;
					num = default(UIntPtr);
				}
				if (unchecked((nuint)num7) * (unchecked((nuint)num8) * num) == 0)
				{
					d3CT2 = d3CT2;
				}
				else
				{
					pd = null;
				}
			}
			finally
			{
				if (num == 0)
				{
					while (obj3 != null)
					{
						_ = (Pd01)(object)n2H1.Default;
					}
				}
				goto IL_0651;
			}
		}
	}
}
