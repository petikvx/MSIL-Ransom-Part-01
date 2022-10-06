using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Bg5s;
using Microsoft.VisualBasic.CompilerServices;
using Re2;
using To59;
using Xj5;
using Xx4q;
using Yn32;
using g8B;
using q4F8;
using s1G;

namespace y4J;

[DesignerGenerated]
public class b0D : Form
{
	private IContainer components;

	private Panel _PanelMenu;

	private Ck89 _Database1DataSet;

	private n0QH _TableAdapterManager;

	private w8K _ScheduleTableAdapter;

	private BindingSource _ScheduleBindingSource;

	private Panel _PanelTitleBar;

	private Pt4.Fo7 _IconButton2;

	private Pt4.Fo7 _IconButton1;

	private Pt4.j0H _IconCurrentForm;

	private Pt4.Fo7 _IconButton5;

	private Pt4.Fo7 _IconButton4;

	private Pt4.Fo7 _IconButton3;

	private Pt4.Fo7 currentBtn;

	private Panel leftBorderBtn;

	internal BindingSource e;

	internal w1E k;

	internal Panel q;

	internal Label s;

	internal LinkLabel V;

	internal NotifyIcon d;

	internal Form x;

	protected override void f9J(bool s1S)
	{
		try
		{
			if (s1S && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(s1S);
		}
	}

	private void Xa3()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(b0D));
		i3W(new Panel());
		Jc9(new LinkLabel());
		i8E(new Pt4.Fo7());
		j7D(new Pt4.Fo7());
		a8W(new BindingSource(components));
		Mt9(new Ck89());
		Rs6(new BindingSource(components));
		g2W(new w1E());
		r3R(new n0QH());
		s6M(new w8K());
		e5Q(new Panel());
		i3T(new Pt4.Fo7());
		Fc9(new Pt4.Fo7());
		Tb6(new Pt4.Fo7());
		Pf8(new Label());
		Dd1(new Pt4.j0H());
		q1Q(new Panel());
		Ry2(new NotifyIcon(components));
		((Control)Hz2()).SuspendLayout();
		((ISupportInitialize)k0W()).BeginInit();
		((ISupportInitialize)Dz8()).BeginInit();
		((ISupportInitialize)Yo2()).BeginInit();
		((Control)k4X()).SuspendLayout();
		((ISupportInitialize)(object)Qe6()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Hz2()).set_BackColor(Color.FromArgb(31, 30, 68));
		((Control)Hz2()).get_Controls().Add((Control)(object)Tz7());
		((Control)Hz2()).set_Dock((DockStyle)3);
		((Control)Hz2()).set_Location(new Point(0, 0));
		((Control)Hz2()).set_Name("PanelMenu");
		((Control)Hz2()).set_Size(new Size(170, 439));
		((Control)Hz2()).set_TabIndex(0);
		((Label)Tz7()).set_AutoSize(true);
		((Control)Tz7()).set_ForeColor(Color.Gainsboro);
		((Control)Tz7()).set_Location(new Point(12, 19));
		((Control)Tz7()).set_Name("LinkLabel1");
		((Control)Tz7()).set_Size(new Size(32, 13));
		((Control)Tz7()).set_TabIndex(6);
		Tz7().set_TabStop(true);
		Tz7().set_Text("Back");
		k0W().set_DataMember("Pending");
		k0W().set_DataSource((object)Dz8());
		Dz8().DataSetName = "Database1DataSet";
		Dz8().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		Yo2().set_DataMember("Schedule");
		Yo2().set_DataSource((object)Dz8());
		Fn5().ClearBeforeFill = true;
		Xb3().BackupDataSetBeforeUpdate = false;
		Xb3().FloginTableAdapter = null;
		Xb3().HistoryTableAdapter = null;
		Xb3().PendingTableAdapter = Fn5();
		Xb3().ScheduleTableAdapter = k0P();
		Xb3().SloginTableAdapter = null;
		Xb3().TableTableAdapter = null;
		Xb3().UpdateOrder = n0QH.y9Q.InsertUpdateDelete;
		k0P().ClearBeforeFill = true;
		((Control)k4X()).set_BackColor(Color.FromArgb(31, 30, 68));
		((Control)k4X()).set_Dock((DockStyle)1);
		((Control)k4X()).set_Location(new Point(170, 0));
		((Control)k4X()).set_Name("PanelTitleBar");
		((Control)k4X()).set_Size(new Size(662, 75));
		((Control)k4X()).set_TabIndex(2);
		Yc9().set_AutoSize(true);
		((Control)Yc9()).set_ForeColor(Color.Gainsboro);
		((Control)Yc9()).set_Location(new Point(69, 45));
		((Control)Yc9()).set_Name("lblFormTitle");
		((Control)Yc9()).set_Size(new Size(39, 13));
		((Control)Yc9()).set_TabIndex(2);
		Yc9().set_Text("Label1");
		((Control)Mt9()).set_BackColor(Color.FromArgb(31, 30, 68));
		((Control)Mt9()).set_Dock((DockStyle)5);
		((Control)Mt9()).set_Location(new Point(170, 75));
		((Control)Mt9()).set_Name("PanelDesktop");
		((Control)Mt9()).set_Size(new Size(662, 364));
		((Control)Mt9()).set_TabIndex(3);
		Do4().set_BalloonTipTitle("Click Me!");
		Do4().set_Icon((Icon)componentResourceManager.GetObject("NotifyIcon1.Icon"));
		Do4().set_Text("NotifyIcon1");
		Do4().set_Visible(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(832, 439));
		((Control)this).get_Controls().Add((Control)(object)Mt9());
		((Control)this).get_Controls().Add((Control)(object)k4X());
		((Control)this).get_Controls().Add((Control)(object)Hz2());
		((Control)this).set_Name("Faculty");
		((Form)this).set_Text("Faculty");
		((Control)Hz2()).ResumeLayout(false);
		((Control)Hz2()).PerformLayout();
		((ISupportInitialize)k0W()).EndInit();
		((ISupportInitialize)Dz8()).EndInit();
		((ISupportInitialize)Yo2()).EndInit();
		((Control)k4X()).ResumeLayout(false);
		((Control)k4X()).PerformLayout();
		((ISupportInitialize)(object)Qe6()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel Hz2()
	{
		return _PanelMenu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i3W(Panel Ej2)
	{
		_PanelMenu = Ej2;
	}

	[SpecialName]
	internal virtual Ck89 Dz8()
	{
		return _Database1DataSet;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mt9(Ck89 Kq2)
	{
		_Database1DataSet = Kq2;
	}

	[SpecialName]
	internal virtual BindingSource k0W()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a8W(BindingSource Tk9)
	{
		BindingSource val = (e = Tk9);
	}

	[SpecialName]
	internal virtual w1E Fn5()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g2W(w1E Ym0)
	{
		w1E w1E = (k = Ym0);
	}

	[SpecialName]
	internal virtual n0QH Xb3()
	{
		return _TableAdapterManager;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r3R(n0QH o2G)
	{
		_TableAdapterManager = o2G;
	}

	[SpecialName]
	internal virtual w8K k0P()
	{
		return _ScheduleTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s6M(w8K c3H)
	{
		_ScheduleTableAdapter = c3H;
	}

	[SpecialName]
	internal virtual BindingSource Yo2()
	{
		return _ScheduleBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rs6(BindingSource y3Q)
	{
		_ScheduleBindingSource = y3Q;
	}

	[SpecialName]
	internal virtual Panel k4X()
	{
		return _PanelTitleBar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e5Q(Panel r3R)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MouseEventHandler val = new MouseEventHandler(Hn9);
		Panel panelTitleBar = _PanelTitleBar;
		if (panelTitleBar != null)
		{
			((Control)panelTitleBar).remove_MouseDown(val);
		}
		_PanelTitleBar = r3R;
		panelTitleBar = _PanelTitleBar;
		if (panelTitleBar != null)
		{
			((Control)panelTitleBar).add_MouseDown(val);
		}
	}

	[SpecialName]
	internal virtual Panel Mt9()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q1Q(Panel c3Y)
	{
		Panel val = (q = c3Y);
	}

	[SpecialName]
	internal virtual Pt4.Fo7 q9P()
	{
		return _IconButton2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i8E(Pt4.Fo7 f6P)
	{
		Pt4.Fo7.f1M f1M = Do0;
		_IconButton2?.Wm7(f1M);
		_IconButton2 = f6P;
		_IconButton2?.x5Y(f1M);
	}

	[SpecialName]
	internal virtual Pt4.Fo7 a2N()
	{
		return _IconButton1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j7D(Pt4.Fo7 Qy3)
	{
		Pt4.Fo7.f1M f1M = Yf4;
		_IconButton1?.Wm7(f1M);
		_IconButton1 = Qy3;
		_IconButton1?.x5Y(f1M);
	}

	[SpecialName]
	internal virtual Pt4.j0H Qe6()
	{
		return _IconCurrentForm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dd1(Pt4.j0H k2A)
	{
		_IconCurrentForm = k2A;
	}

	[SpecialName]
	internal virtual Label Yc9()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pf8(Label g8W)
	{
		Label val = (s = g8W);
	}

	[SpecialName]
	internal virtual Pt4.Fo7 y2C()
	{
		return _IconButton5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i3T(Pt4.Fo7 Ln1)
	{
		_IconButton5 = Ln1;
	}

	[SpecialName]
	internal virtual Pt4.Fo7 f6E()
	{
		return _IconButton4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fc9(Pt4.Fo7 Lj1)
	{
		_IconButton4 = Lj1;
	}

	[SpecialName]
	internal virtual Pt4.Fo7 w3Q()
	{
		return _IconButton3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tb6(Pt4.Fo7 De1)
	{
		_IconButton3 = De1;
	}

	[SpecialName]
	internal virtual LinkLabel Tz7()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jc9(LinkLabel Nw0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(Ci3);
		LinkLabel v = V;
		if (v != null)
		{
			v.remove_LinkClicked(val);
		}
		LinkLabel val2 = (V = Nw0);
		v = V;
		if (v != null)
		{
			v.add_LinkClicked(val);
		}
	}

	[SpecialName]
	internal virtual NotifyIcon Do4()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ry2(NotifyIcon s8Q)
	{
		NotifyIcon val = (d = s8Q);
	}

	public b0D()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		((Control)this).add_Resize((EventHandler)Rw4);
		Xa3();
		leftBorderBtn = new Panel();
		((Control)leftBorderBtn).set_Size(new Size(7, 60));
		((Control)Hz2()).get_Controls().Add((Control)(object)leftBorderBtn);
		((Form)this).set_Text(string.Empty);
		((Form)this).set_ControlBox(false);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_MaximizedBounds(Screen.get_PrimaryScreen().get_WorkingArea());
	}

	private void g2Y(object d9K, Color o0Y)
	{
		if (d9K != null)
		{
			y4Y();
			((Control)leftBorderBtn).set_BackColor(o0Y);
			((Control)leftBorderBtn).set_Visible(true);
			((Control)leftBorderBtn).BringToFront();
		}
	}

	private void y4Y()
	{
		if (currentBtn != null)
		{
		}
	}

	private void f9K(Form Yi6)
	{
		if (x != null)
		{
			x.Close();
		}
		Form val = (x = Yi6);
		Yi6.set_TopLevel(false);
		Yi6.set_FormBorderStyle((FormBorderStyle)0);
		((Control)Yi6).set_Dock((DockStyle)5);
		((Control)Mt9()).get_Controls().Add((Control)(object)Yi6);
		((Control)Mt9()).set_Tag((object)Yi6);
		((Control)Yi6).BringToFront();
		((Control)Yi6).Show();
		Yc9().set_Text(Yi6.get_Text());
	}

	internal static string Si1(string[] Nz1, int n4Q, int y7D)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = n4Q; i <= y7D; i = checked(i + 1))
		{
			stringBuilder.Append(Nz1[i]);
		}
		return stringBuilder.ToString();
	}

	[DllImport("user32.DLL")]
	private static extern void ReleaseCapture();

	[DllImport("user32.DLL")]
	private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

	private void Hn9(object sender, MouseEventArgs e)
	{
		ReleaseCapture();
		SendMessage(((Control)this).get_Handle(), 274, 61458, 0);
	}

	private void Rw4(object sender, EventArgs e)
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

	private void Ci3(object sender, LinkLabelLinkClickedEventArgs e)
	{
		((Control)d7H8.Forms.b1Y5()).Show();
	}

	private void Yf4(object sender, EventArgs e)
	{
		g2Y(RuntimeHelpers.GetObjectValue(sender), Lq6.color5);
		f9K((Form)(object)new d1D9());
	}

	private void Do0(object sender, EventArgs e)
	{
		g2Y(RuntimeHelpers.GetObjectValue(sender), Lq6.color5);
		f9K((Form)(object)new Cb91());
	}

	internal static bool Rs6(string f8A)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(f8A);
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
