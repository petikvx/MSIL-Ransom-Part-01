using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Jc0a;
using Microsoft.VisualBasic.CompilerServices;
using Mt5x;
using Pw5;
using Wc2f;
using b8D;
using g7N;
using g9E;
using k0ZX;
using y0P;

namespace d5N;

[DesignerGenerated]
public class Cm7 : Form
{
	private IContainer components;

	private s1D _Database1DataSet;

	private BindingSource _PendingBindingSource;

	private w5BF _PendingTableAdapter;

	private Dr4 _TableAdapterManager;

	private BindingSource _ScheduleBindingSource;

	private Panel _PanelTitleBar;

	private Panel _PanelDesktop;

	private Xj3.Gb4 _IconButton2;

	private Xj3.Gb4 _IconButton1;

	private Xj3.Cm8 _IconCurrentForm;

	private Xj3.Gb4 _IconButton5;

	private Xj3.Gb4 _IconButton4;

	private Xj3.Gb4 _IconButton3;

	private Xj3.Gb4 currentBtn;

	private Panel leftBorderBtn;

	private Form currentChildForm;

	internal Panel m;

	internal Mk2d H;

	internal Label n;

	internal LinkLabel r;

	internal NotifyIcon y;

	protected override void Lp6(bool Sk4)
	{
		try
		{
			if (Sk4 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Sk4);
		}
	}

	private void Fk4()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Cm7));
		r1P(new Panel());
		k5J(new LinkLabel());
		Fk5(new Xj3.Gb4());
		t0R(new Xj3.Gb4());
		Dz2(new BindingSource(components));
		o1P(new s1D());
		Jp2(new BindingSource(components));
		Ha1(new w5BF());
		r8J(new Dr4());
		Ng7(new Mk2d());
		n5L(new Panel());
		i5G(new Xj3.Gb4());
		q5M(new Xj3.Gb4());
		Ze6(new Xj3.Gb4());
		Ei5(new Label());
		g3Y(new Xj3.Cm8());
		q0H(new Panel());
		y1P(new NotifyIcon(components));
		((Control)Zg2()).SuspendLayout();
		((ISupportInitialize)f7E()).BeginInit();
		((ISupportInitialize)Po5()).BeginInit();
		((ISupportInitialize)Hf4()).BeginInit();
		((Control)Cm6()).SuspendLayout();
		((ISupportInitialize)(object)Er5()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Zg2()).set_BackColor(Color.FromArgb(31, 30, 68));
		((Control)Zg2()).get_Controls().Add((Control)(object)Ef9());
		((Control)Zg2()).set_Dock((DockStyle)3);
		((Control)Zg2()).set_Location(new Point(0, 0));
		((Control)Zg2()).set_Name("PanelMenu");
		((Control)Zg2()).set_Size(new Size(170, 439));
		((Control)Zg2()).set_TabIndex(0);
		((Label)Ef9()).set_AutoSize(true);
		((Control)Ef9()).set_ForeColor(Color.Gainsboro);
		((Control)Ef9()).set_Location(new Point(12, 19));
		((Control)Ef9()).set_Name("LinkLabel1");
		((Control)Ef9()).set_Size(new Size(32, 13));
		((Control)Ef9()).set_TabIndex(6);
		Ef9().set_TabStop(true);
		Ef9().set_Text("Back");
		f7E().set_DataMember("Pending");
		f7E().set_DataSource((object)Po5());
		Po5().DataSetName = "Database1DataSet";
		Po5().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		Hf4().set_DataMember("Schedule");
		Hf4().set_DataSource((object)Po5());
		q4J().ClearBeforeFill = true;
		d0D().BackupDataSetBeforeUpdate = false;
		d0D().FloginTableAdapter = null;
		d0D().HistoryTableAdapter = null;
		d0D().PendingTableAdapter = q4J();
		d0D().ScheduleTableAdapter = x0J();
		d0D().SloginTableAdapter = null;
		d0D().TableTableAdapter = null;
		d0D().UpdateOrder = Dr4.Dx1.InsertUpdateDelete;
		x0J().ClearBeforeFill = true;
		((Control)Cm6()).set_BackColor(Color.FromArgb(31, 30, 68));
		((Control)Cm6()).set_Dock((DockStyle)1);
		((Control)Cm6()).set_Location(new Point(170, 0));
		((Control)Cm6()).set_Name("PanelTitleBar");
		((Control)Cm6()).set_Size(new Size(662, 75));
		((Control)Cm6()).set_TabIndex(2);
		Zn9().set_AutoSize(true);
		((Control)Zn9()).set_ForeColor(Color.Gainsboro);
		((Control)Zn9()).set_Location(new Point(69, 45));
		((Control)Zn9()).set_Name("lblFormTitle");
		((Control)Zn9()).set_Size(new Size(39, 13));
		((Control)Zn9()).set_TabIndex(2);
		Zn9().set_Text("Label1");
		((Control)Mx4()).set_BackColor(Color.FromArgb(31, 30, 68));
		((Control)Mx4()).set_Dock((DockStyle)5);
		((Control)Mx4()).set_Location(new Point(170, 75));
		((Control)Mx4()).set_Name("PanelDesktop");
		((Control)Mx4()).set_Size(new Size(662, 364));
		((Control)Mx4()).set_TabIndex(3);
		x4J().set_BalloonTipTitle("Click Me!");
		x4J().set_Icon((Icon)componentResourceManager.GetObject("NotifyIcon1.Icon"));
		x4J().set_Text("NotifyIcon1");
		x4J().set_Visible(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(832, 439));
		((Control)this).get_Controls().Add((Control)(object)Mx4());
		((Control)this).get_Controls().Add((Control)(object)Cm6());
		((Control)this).get_Controls().Add((Control)(object)Zg2());
		((Control)this).set_Name("Faculty");
		((Form)this).set_Text("Faculty");
		((Control)Zg2()).ResumeLayout(false);
		((Control)Zg2()).PerformLayout();
		((ISupportInitialize)f7E()).EndInit();
		((ISupportInitialize)Po5()).EndInit();
		((ISupportInitialize)Hf4()).EndInit();
		((Control)Cm6()).ResumeLayout(false);
		((Control)Cm6()).PerformLayout();
		((ISupportInitialize)(object)Er5()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel Zg2()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r1P(Panel w8N)
	{
		Panel val = (m = w8N);
	}

	[SpecialName]
	internal virtual s1D Po5()
	{
		return _Database1DataSet;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o1P(s1D Bo5)
	{
		_Database1DataSet = Bo5;
	}

	[SpecialName]
	internal virtual BindingSource f7E()
	{
		return _PendingBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dz2(BindingSource Hg0)
	{
		_PendingBindingSource = Hg0;
	}

	[SpecialName]
	internal virtual w5BF q4J()
	{
		return _PendingTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ha1(w5BF d6H)
	{
		_PendingTableAdapter = d6H;
	}

	[SpecialName]
	internal virtual Dr4 d0D()
	{
		return _TableAdapterManager;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r8J(Dr4 Yi8)
	{
		_TableAdapterManager = Yi8;
	}

	[SpecialName]
	internal virtual Mk2d x0J()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ng7(Mk2d Bt2)
	{
		Mk2d mk2d = (H = Bt2);
	}

	[SpecialName]
	internal virtual BindingSource Hf4()
	{
		return _ScheduleBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jp2(BindingSource g7A)
	{
		_ScheduleBindingSource = g7A;
	}

	[SpecialName]
	internal virtual Panel Cm6()
	{
		return _PanelTitleBar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n5L(Panel Rc0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MouseEventHandler val = new MouseEventHandler(c9M);
		Panel panelTitleBar = _PanelTitleBar;
		if (panelTitleBar != null)
		{
			((Control)panelTitleBar).remove_MouseDown(val);
		}
		_PanelTitleBar = Rc0;
		panelTitleBar = _PanelTitleBar;
		if (panelTitleBar != null)
		{
			((Control)panelTitleBar).add_MouseDown(val);
		}
	}

	[SpecialName]
	internal virtual Panel Mx4()
	{
		return _PanelDesktop;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q0H(Panel Bq4)
	{
		_PanelDesktop = Bq4;
	}

	[SpecialName]
	internal virtual Xj3.Gb4 Go0()
	{
		return _IconButton2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fk5(Xj3.Gb4 w3H)
	{
		Xj3.Gb4.Lm0 lm = s9M;
		_IconButton2?.d3Z(lm);
		_IconButton2 = w3H;
		_IconButton2?.j5Z(lm);
	}

	[SpecialName]
	internal virtual Xj3.Gb4 Ka8()
	{
		return _IconButton1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t0R(Xj3.Gb4 i8E)
	{
		Xj3.Gb4.Lm0 lm = Cf9;
		_IconButton1?.d3Z(lm);
		_IconButton1 = i8E;
		_IconButton1?.j5Z(lm);
	}

	[SpecialName]
	internal virtual Xj3.Cm8 Er5()
	{
		return _IconCurrentForm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g3Y(Xj3.Cm8 g1D)
	{
		_IconCurrentForm = g1D;
	}

	[SpecialName]
	internal virtual Label Zn9()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ei5(Label y3R)
	{
		Label val = (n = y3R);
	}

	[SpecialName]
	internal virtual Xj3.Gb4 An8()
	{
		return _IconButton5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i5G(Xj3.Gb4 n3F)
	{
		_IconButton5 = n3F;
	}

	[SpecialName]
	internal virtual Xj3.Gb4 s6Y()
	{
		return _IconButton4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q5M(Xj3.Gb4 k0T)
	{
		_IconButton4 = k0T;
	}

	[SpecialName]
	internal virtual Xj3.Gb4 Zn2()
	{
		return _IconButton3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ze6(Xj3.Gb4 i1F)
	{
		_IconButton3 = i1F;
	}

	[SpecialName]
	internal virtual LinkLabel Ef9()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k5J(LinkLabel Em5)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(g6K);
		LinkLabel val2 = r;
		if (val2 != null)
		{
			val2.remove_LinkClicked(val);
		}
		LinkLabel val3 = (r = Em5);
		val2 = r;
		if (val2 != null)
		{
			val2.add_LinkClicked(val);
		}
	}

	[SpecialName]
	internal virtual NotifyIcon x4J()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y1P(NotifyIcon j2L)
	{
		NotifyIcon val = (y = j2L);
	}

	public Cm7()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		((Control)this).add_Resize((EventHandler)Sy2);
		Fk4();
		leftBorderBtn = new Panel();
		((Control)leftBorderBtn).set_Size(new Size(7, 60));
		((Control)Zg2()).get_Controls().Add((Control)(object)leftBorderBtn);
		((Form)this).set_Text(string.Empty);
		((Form)this).set_ControlBox(false);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_MaximizedBounds(Screen.get_PrimaryScreen().get_WorkingArea());
	}

	private void x0M(object x0S, Color Yn4)
	{
		if (x0S != null)
		{
			Tk8();
			((Control)leftBorderBtn).set_BackColor(Yn4);
			((Control)leftBorderBtn).set_Visible(true);
			((Control)leftBorderBtn).BringToFront();
		}
	}

	private void Tk8()
	{
		if (currentBtn != null)
		{
		}
	}

	private void Zp8(Form z6C)
	{
		if (currentChildForm != null)
		{
			currentChildForm.Close();
		}
		currentChildForm = z6C;
		z6C.set_TopLevel(false);
		z6C.set_FormBorderStyle((FormBorderStyle)0);
		((Control)z6C).set_Dock((DockStyle)5);
		((Control)Mx4()).get_Controls().Add((Control)(object)z6C);
		((Control)Mx4()).set_Tag((object)z6C);
		((Control)z6C).BringToFront();
		((Control)z6C).Show();
		Zn9().set_Text(z6C.get_Text());
	}

	internal static string t7X(string[] Mo8, int n1Z, int e7R)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = n1Z; i <= e7R; i = checked(i + 1))
		{
			stringBuilder.Append(Mo8[i]);
		}
		return stringBuilder.ToString();
	}

	[DllImport("user32.DLL")]
	private static extern void ReleaseCapture();

	[DllImport("user32.DLL")]
	private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

	private void c9M(object sender, MouseEventArgs e)
	{
		ReleaseCapture();
		SendMessage(((Control)this).get_Handle(), 274, 61458, 0);
	}

	private void Sy2(object sender, EventArgs e)
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

	private void g6K(object sender, LinkLabelLinkClickedEventArgs e)
	{
		((Control)Rt9.Forms.e1Z()).Show();
	}

	private void Cf9(object sender, EventArgs e)
	{
		x0M(RuntimeHelpers.GetObjectValue(sender), Ac0.color5);
		Zp8((Form)(object)new Gs7x());
	}

	private void s9M(object sender, EventArgs e)
	{
		x0M(RuntimeHelpers.GetObjectValue(sender), Ac0.color5);
		Zp8((Form)(object)new g4A7());
	}

	internal static bool m4Q(string q0D)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(q0D);
			webRequest.GetResponse();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}
}
