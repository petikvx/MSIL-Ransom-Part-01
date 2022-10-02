using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Km43;
using Lm9e;
using Microsoft.VisualBasic.CompilerServices;
using Yt3k;
using b9L;
using o0N8;
using s7YR;
using t5MS;
using w4Q;
using x4J2;

namespace z7F;

[DesignerGenerated]
public class Ry8 : Form
{
	private BindingSource _PendingBindingSource;

	private Gw8q _TableAdapterManager;

	private Qb24 _ScheduleTableAdapter;

	private Panel _PanelTitleBar;

	private Panel _PanelDesktop;

	private q8Z.Fq4 _IconButton2;

	private q8Z.Fq4 _IconButton1;

	private q8Z.d8E _IconCurrentForm;

	private Label _lblFormTitle;

	private q8Z.Fq4 _IconButton5;

	private q8Z.Fq4 _IconButton4;

	private q8Z.Fq4 _IconButton3;

	private LinkLabel _LinkLabel1;

	private q8Z.Fq4 currentBtn;

	private Panel leftBorderBtn;

	internal IContainer m;

	internal Panel i;

	internal q6SX o;

	internal Bf57 U;

	internal BindingSource X;

	internal NotifyIcon p;

	internal Form G;

	protected override void d1T(bool Rs5)
	{
		try
		{
			if (Rs5 && m != null)
			{
				m.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Rs5);
		}
	}

	private void q8Q()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected O, but got Unknown
		IContainer container = (m = new Container());
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ry8));
		y1R(new Panel());
		Hc3(new LinkLabel());
		m5J(new q8Z.Fq4());
		Fy1(new q8Z.Fq4());
		Sp8(new BindingSource(m));
		e5P(new q6SX());
		Qm0(new BindingSource(m));
		r7G(new Bf57());
		Yn4(new Gw8q());
		Fm1(new Qb24());
		Bk9(new Panel());
		Xa0(new q8Z.Fq4());
		y5D(new q8Z.Fq4());
		m8F(new q8Z.Fq4());
		n6K(new Label());
		g8J(new q8Z.d8E());
		e8Y(new Panel());
		z5X(new NotifyIcon(m));
		((Control)z3K()).SuspendLayout();
		((ISupportInitialize)Mb8()).BeginInit();
		((ISupportInitialize)Zr7()).BeginInit();
		((ISupportInitialize)j3M()).BeginInit();
		((Control)o0R()).SuspendLayout();
		((ISupportInitialize)(object)b3M()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)z3K()).set_BackColor(Color.FromArgb(31, 30, 68));
		((Control)z3K()).get_Controls().Add((Control)(object)b4Z());
		((Control)z3K()).set_Dock((DockStyle)3);
		((Control)z3K()).set_Location(new Point(0, 0));
		((Control)z3K()).set_Name("PanelMenu");
		((Control)z3K()).set_Size(new Size(170, 439));
		((Control)z3K()).set_TabIndex(0);
		((Label)b4Z()).set_AutoSize(true);
		((Control)b4Z()).set_ForeColor(Color.Gainsboro);
		((Control)b4Z()).set_Location(new Point(12, 19));
		((Control)b4Z()).set_Name("LinkLabel1");
		((Control)b4Z()).set_Size(new Size(32, 13));
		((Control)b4Z()).set_TabIndex(6);
		b4Z().set_TabStop(true);
		b4Z().set_Text("Back");
		Mb8().set_DataMember("Pending");
		Mb8().set_DataSource((object)Zr7());
		Zr7().DataSetName = "Database1DataSet";
		Zr7().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		j3M().set_DataMember("Schedule");
		j3M().set_DataSource((object)Zr7());
		y1F().ClearBeforeFill = true;
		Yk8().BackupDataSetBeforeUpdate = false;
		Yk8().FloginTableAdapter = null;
		Yk8().HistoryTableAdapter = null;
		Yk8().PendingTableAdapter = y1F();
		Yk8().ScheduleTableAdapter = Ca5();
		Yk8().SloginTableAdapter = null;
		Yk8().TableTableAdapter = null;
		Yk8().UpdateOrder = Gw8q.w1F.InsertUpdateDelete;
		Ca5().ClearBeforeFill = true;
		((Control)o0R()).set_BackColor(Color.FromArgb(31, 30, 68));
		((Control)o0R()).set_Dock((DockStyle)1);
		((Control)o0R()).set_Location(new Point(170, 0));
		((Control)o0R()).set_Name("PanelTitleBar");
		((Control)o0R()).set_Size(new Size(662, 75));
		((Control)o0R()).set_TabIndex(2);
		o0Y().set_AutoSize(true);
		((Control)o0Y()).set_ForeColor(Color.Gainsboro);
		((Control)o0Y()).set_Location(new Point(69, 45));
		((Control)o0Y()).set_Name("lblFormTitle");
		((Control)o0Y()).set_Size(new Size(39, 13));
		((Control)o0Y()).set_TabIndex(2);
		o0Y().set_Text("Label1");
		((Control)j6Q()).set_BackColor(Color.FromArgb(31, 30, 68));
		((Control)j6Q()).set_Dock((DockStyle)5);
		((Control)j6Q()).set_Location(new Point(170, 75));
		((Control)j6Q()).set_Name("PanelDesktop");
		((Control)j6Q()).set_Size(new Size(662, 364));
		((Control)j6Q()).set_TabIndex(3);
		Rp8().set_BalloonTipTitle("Click Me!");
		Rp8().set_Icon((Icon)componentResourceManager.GetObject("NotifyIcon1.Icon"));
		Rp8().set_Text("NotifyIcon1");
		Rp8().set_Visible(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(832, 439));
		((Control)this).get_Controls().Add((Control)(object)j6Q());
		((Control)this).get_Controls().Add((Control)(object)o0R());
		((Control)this).get_Controls().Add((Control)(object)z3K());
		((Control)this).set_Name("Faculty");
		((Form)this).set_Text("Faculty");
		((Control)z3K()).ResumeLayout(false);
		((Control)z3K()).PerformLayout();
		((ISupportInitialize)Mb8()).EndInit();
		((ISupportInitialize)Zr7()).EndInit();
		((ISupportInitialize)j3M()).EndInit();
		((Control)o0R()).ResumeLayout(false);
		((Control)o0R()).PerformLayout();
		((ISupportInitialize)(object)b3M()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel z3K()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y1R(Panel w0F)
	{
		Panel val = (i = w0F);
	}

	[SpecialName]
	internal virtual q6SX Zr7()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e5P(q6SX x8S)
	{
		q6SX q6SX = (o = x8S);
	}

	[SpecialName]
	internal virtual BindingSource Mb8()
	{
		return _PendingBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sp8(BindingSource t1J)
	{
		_PendingBindingSource = t1J;
	}

	[SpecialName]
	internal virtual Bf57 y1F()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r7G(Bf57 b5A)
	{
		Bf57 bf = (U = b5A);
	}

	[SpecialName]
	internal virtual Gw8q Yk8()
	{
		return _TableAdapterManager;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yn4(Gw8q x8T)
	{
		_TableAdapterManager = x8T;
	}

	[SpecialName]
	internal virtual Qb24 Ca5()
	{
		return _ScheduleTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fm1(Qb24 Wc0)
	{
		_ScheduleTableAdapter = Wc0;
	}

	[SpecialName]
	internal virtual BindingSource j3M()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qm0(BindingSource m9L)
	{
		BindingSource val = (X = m9L);
	}

	[SpecialName]
	internal virtual Panel o0R()
	{
		return _PanelTitleBar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bk9(Panel c9W)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MouseEventHandler val = new MouseEventHandler(Pb3);
		Panel panelTitleBar = _PanelTitleBar;
		if (panelTitleBar != null)
		{
			((Control)panelTitleBar).remove_MouseDown(val);
		}
		_PanelTitleBar = c9W;
		panelTitleBar = _PanelTitleBar;
		if (panelTitleBar != null)
		{
			((Control)panelTitleBar).add_MouseDown(val);
		}
	}

	[SpecialName]
	internal virtual Panel j6Q()
	{
		return _PanelDesktop;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8Y(Panel b7H)
	{
		_PanelDesktop = b7H;
	}

	[SpecialName]
	internal virtual q8Z.Fq4 r7Z()
	{
		return _IconButton2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m5J(q8Z.Fq4 Xt8)
	{
		q8Z.Fq4.Ap2 ap = d7Q;
		_IconButton2?.w9L(ap);
		_IconButton2 = Xt8;
		_IconButton2?.t2E(ap);
	}

	[SpecialName]
	internal virtual q8Z.Fq4 Aw3()
	{
		return _IconButton1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fy1(q8Z.Fq4 j2D)
	{
		q8Z.Fq4.Ap2 ap = d7K;
		_IconButton1?.w9L(ap);
		_IconButton1 = j2D;
		_IconButton1?.t2E(ap);
	}

	[SpecialName]
	internal virtual q8Z.d8E b3M()
	{
		return _IconCurrentForm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g8J(q8Z.d8E Nc4)
	{
		_IconCurrentForm = Nc4;
	}

	[SpecialName]
	internal virtual Label o0Y()
	{
		return _lblFormTitle;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n6K(Label z0S)
	{
		_lblFormTitle = z0S;
	}

	[SpecialName]
	internal virtual q8Z.Fq4 g9S()
	{
		return _IconButton5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xa0(q8Z.Fq4 Ac0)
	{
		_IconButton5 = Ac0;
	}

	[SpecialName]
	internal virtual q8Z.Fq4 Mg6()
	{
		return _IconButton4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y5D(q8Z.Fq4 Rr4)
	{
		_IconButton4 = Rr4;
	}

	[SpecialName]
	internal virtual q8Z.Fq4 Sy1()
	{
		return _IconButton3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m8F(q8Z.Fq4 Dw2)
	{
		_IconButton3 = Dw2;
	}

	[SpecialName]
	internal virtual LinkLabel b4Z()
	{
		return _LinkLabel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hc3(LinkLabel Qp0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(Cb0);
		LinkLabel linkLabel = _LinkLabel1;
		if (linkLabel != null)
		{
			linkLabel.remove_LinkClicked(val);
		}
		_LinkLabel1 = Qp0;
		linkLabel = _LinkLabel1;
		if (linkLabel != null)
		{
			linkLabel.add_LinkClicked(val);
		}
	}

	[SpecialName]
	internal virtual NotifyIcon Rp8()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z5X(NotifyIcon Ps8)
	{
		NotifyIcon val = (p = Ps8);
	}

	public Ry8()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		((Control)this).add_Resize((EventHandler)r6W);
		q8Q();
		leftBorderBtn = new Panel();
		((Control)leftBorderBtn).set_Size(new Size(7, 60));
		((Control)z3K()).get_Controls().Add((Control)(object)leftBorderBtn);
		((Form)this).set_Text(string.Empty);
		((Form)this).set_ControlBox(false);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_MaximizedBounds(Screen.get_PrimaryScreen().get_WorkingArea());
	}

	private void Hb4(object o1F, Color Kz3)
	{
		if (o1F != null)
		{
			Ki1();
			((Control)leftBorderBtn).set_BackColor(Kz3);
			((Control)leftBorderBtn).set_Visible(true);
			((Control)leftBorderBtn).BringToFront();
		}
	}

	private void Ki1()
	{
		if (currentBtn != null)
		{
		}
	}

	private void Gs3(Form Xz1)
	{
		if (G != null)
		{
			G.Close();
		}
		Form val = (G = Xz1);
		Xz1.set_TopLevel(false);
		Xz1.set_FormBorderStyle((FormBorderStyle)0);
		((Control)Xz1).set_Dock((DockStyle)5);
		((Control)j6Q()).get_Controls().Add((Control)(object)Xz1);
		((Control)j6Q()).set_Tag((object)Xz1);
		((Control)Xz1).BringToFront();
		((Control)Xz1).Show();
		o0Y().set_Text(Xz1.get_Text());
	}

	internal static string Br3(string[] o9K, int Fr5, int Gw9)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = Fr5; i <= Gw9; i = checked(i + 1))
		{
			stringBuilder.Append(o9K[i]);
		}
		return stringBuilder.ToString();
	}

	[DllImport("user32.DLL")]
	private static extern void ReleaseCapture();

	[DllImport("user32.DLL")]
	private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

	private void Pb3(object sender, MouseEventArgs e)
	{
		ReleaseCapture();
		SendMessage(((Control)this).get_Handle(), 274, 61458, 0);
	}

	private void r6W(object sender, EventArgs e)
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

	private void Cb0(object sender, LinkLabelLinkClickedEventArgs e)
	{
		((Control)Eo05.Forms.Hp69()).Show();
	}

	private void d7K(object sender, EventArgs e)
	{
		Hb4(RuntimeHelpers.GetObjectValue(sender), Wd5.color5);
		Gs3((Form)(object)new Mf15());
	}

	private void d7Q(object sender, EventArgs e)
	{
		Hb4(RuntimeHelpers.GetObjectValue(sender), Wd5.color5);
		Gs3((Form)(object)new Dp84());
	}

	internal static bool g0K(string Ke8)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(Ke8);
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
