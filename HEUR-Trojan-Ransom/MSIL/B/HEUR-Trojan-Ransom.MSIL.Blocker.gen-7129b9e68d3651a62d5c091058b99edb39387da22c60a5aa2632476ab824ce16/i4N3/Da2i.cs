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
using Co2;
using Hw2;
using Microsoft.VisualBasic.CompilerServices;
using Qz92;
using Yt3k;
using c2TP;
using k9W;
using o0N8;
using w4Q;
using x4J2;
using y8SN;

namespace i4N3;

[DesignerGenerated]
public class Da2i : Form
{
	private IContainer components;

	private Panel _PanelMenu;

	private q6SX _Database1DataSet;

	private Gw8q _TableAdapterManager;

	private z3T7 _SloginTableAdapter;

	private LinkLabel _LinkLabel1;

	private q8Z.Fq4 _IconButton2;

	private q8Z.Fq4 _IconButton1;

	private Label _lblFormTitle;

	private q8Z.d8E _IconCurrentForm;

	private q8Z.Fq4 _IconButton5;

	private q8Z.Fq4 _IconButton4;

	private q8Z.Fq4 _IconButton3;

	private Label _NameLabel1;

	private q8Z.Fq4 _IconButton6;

	private q8Z.Fq4 currentBtn;

	private Panel leftBorderBtn;

	internal BindingSource H;

	internal Ez42 P;

	internal BindingSource U;

	internal Panel j;

	internal Panel W;

	internal Label F;

	internal Form b;

	protected override void x4K0(bool f6XF)
	{
		try
		{
			if (f6XF && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(f6XF);
		}
	}

	private void Tp81()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		components = new Container();
		Nj7a(new Panel());
		Sz89(new Label());
		Gz82(new BindingSource(components));
		Ci30(new q6SX());
		x0YP(new Label());
		Zp0m(new q8Z.Fq4());
		Nq3s(new q8Z.Fq4());
		c4AB(new LinkLabel());
		Zr1i(new BindingSource(components));
		Ga7y(new Ez42());
		Rk93(new Gw8q());
		Mk15(new z3T7());
		An90(new Panel());
		j2SL(new q8Z.Fq4());
		r6PC(new q8Z.Fq4());
		o1XB(new q8Z.Fq4());
		Nc2x(new Label());
		c5JL(new q8Z.d8E());
		Mo5j(new Panel());
		Do6s(new q8Z.Fq4());
		Label val = new Label();
		Label val2 = new Label();
		((Control)Dp20()).SuspendLayout();
		((ISupportInitialize)d5K2()).BeginInit();
		((ISupportInitialize)k3TF()).BeginInit();
		((ISupportInitialize)Do05()).BeginInit();
		((Control)Rn31()).SuspendLayout();
		((ISupportInitialize)(object)e1D4()).BeginInit();
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
		((Control)Dp20()).set_BackColor(Color.FromArgb(31, 30, 68));
		((Control)Dp20()).get_Controls().Add((Control)(object)val2);
		((Control)Dp20()).get_Controls().Add((Control)(object)t4E6());
		((Control)Dp20()).get_Controls().Add((Control)(object)val);
		((Control)Dp20()).get_Controls().Add((Control)(object)Zb5f());
		((Control)Dp20()).get_Controls().Add((Control)(object)Zq01());
		((Control)Dp20()).set_Dock((DockStyle)3);
		((Control)Dp20()).set_Location(new Point(0, 0));
		((Control)Dp20()).set_Name("PanelMenu");
		((Control)Dp20()).set_Size(new Size(243, 395));
		((Control)Dp20()).set_TabIndex(4);
		((Control)t4E6()).get_DataBindings().Add(new Binding("Text", (object)d5K2(), "Name", true));
		((Control)t4E6()).set_Location(new Point(72, 141));
		((Control)t4E6()).set_Name("NameLabel1");
		((Control)t4E6()).set_Size(new Size(100, 23));
		((Control)t4E6()).set_TabIndex(7);
		t4E6().set_Text("Label1");
		d5K2().set_DataMember("Slogin");
		d5K2().set_DataSource((object)k3TF());
		k3TF().DataSetName = "Database1DataSet";
		k3TF().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		((Control)Zb5f()).get_DataBindings().Add(new Binding("Text", (object)d5K2(), "Student_ID", true));
		((Control)Zb5f()).set_Location(new Point(95, 96));
		((Control)Zb5f()).set_Name("Student_IDLabel1");
		((Control)Zb5f()).set_Size(new Size(100, 23));
		((Control)Zb5f()).set_TabIndex(6);
		Zb5f().set_Text("Label1");
		((Label)Zq01()).set_AutoSize(true);
		((Control)Zq01()).set_ForeColor(Color.Gainsboro);
		((Control)Zq01()).set_Location(new Point(12, 9));
		((Control)Zq01()).set_Name("LinkLabel1");
		((Control)Zq01()).set_Size(new Size(32, 13));
		((Control)Zq01()).set_TabIndex(4);
		Zq01().set_TabStop(true);
		Zq01().set_Text("Back");
		Do05().set_DataMember("History");
		Do05().set_DataSource((object)k3TF());
		Pk85().ClearBeforeFill = true;
		r9CM().BackupDataSetBeforeUpdate = false;
		r9CM().FloginTableAdapter = null;
		r9CM().HistoryTableAdapter = Pk85();
		r9CM().PendingTableAdapter = null;
		r9CM().ScheduleTableAdapter = null;
		r9CM().SloginTableAdapter = null;
		r9CM().TableTableAdapter = null;
		r9CM().UpdateOrder = Gw8q.w1F.InsertUpdateDelete;
		f7Q3().ClearBeforeFill = true;
		((Control)Rn31()).set_BackColor(Color.FromArgb(31, 30, 68));
		((Control)Rn31()).set_Dock((DockStyle)1);
		((Control)Rn31()).set_Location(new Point(243, 0));
		((Control)Rn31()).set_Name("PanelTitleBar");
		((Control)Rn31()).set_Size(new Size(668, 96));
		((Control)Rn31()).set_TabIndex(7);
		Ma3r().set_AutoSize(true);
		((Control)Ma3r()).set_ForeColor(Color.Gainsboro);
		((Control)Ma3r()).set_Location(new Point(74, 42));
		((Control)Ma3r()).set_Name("lblFormTitle");
		((Control)Ma3r()).set_Size(new Size(39, 13));
		((Control)Ma3r()).set_TabIndex(1);
		Ma3r().set_Text("Label1");
		((Control)Ja16()).set_Dock((DockStyle)5);
		((Control)Ja16()).set_Location(new Point(243, 96));
		((Control)Ja16()).set_Name("PanelDesktop");
		((Control)Ja16()).set_Size(new Size(668, 299));
		((Control)Ja16()).set_TabIndex(8);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(911, 395));
		((Control)this).get_Controls().Add((Control)(object)Ja16());
		((Control)this).get_Controls().Add((Control)(object)Rn31());
		((Control)this).get_Controls().Add((Control)(object)Dp20());
		((Control)this).set_Name("Student");
		((Form)this).set_Text("Student");
		((Control)Dp20()).ResumeLayout(false);
		((Control)Dp20()).PerformLayout();
		((ISupportInitialize)d5K2()).EndInit();
		((ISupportInitialize)k3TF()).EndInit();
		((ISupportInitialize)Do05()).EndInit();
		((Control)Rn31()).ResumeLayout(false);
		((Control)Rn31()).PerformLayout();
		((ISupportInitialize)(object)e1D4()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel Dp20()
	{
		return _PanelMenu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nj7a(Panel y7L4)
	{
		_PanelMenu = y7L4;
	}

	[SpecialName]
	internal virtual q6SX k3TF()
	{
		return _Database1DataSet;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ci30(q6SX o3XG)
	{
		_Database1DataSet = o3XG;
	}

	[SpecialName]
	internal virtual BindingSource Do05()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zr1i(BindingSource Tc05)
	{
		BindingSource val = (H = Tc05);
	}

	[SpecialName]
	internal virtual Ez42 Pk85()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ga7y(Ez42 Xt40)
	{
		Ez42 ez = (P = Xt40);
	}

	[SpecialName]
	internal virtual Gw8q r9CM()
	{
		return _TableAdapterManager;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rk93(Gw8q Tk29)
	{
		_TableAdapterManager = Tk29;
	}

	[SpecialName]
	internal virtual BindingSource d5K2()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gz82(BindingSource Wp8w)
	{
		BindingSource val = (U = Wp8w);
	}

	[SpecialName]
	internal virtual z3T7 f7Q3()
	{
		return _SloginTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mk15(z3T7 As0e)
	{
		_SloginTableAdapter = As0e;
	}

	[SpecialName]
	internal virtual LinkLabel Zq01()
	{
		return _LinkLabel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c4AB(LinkLabel s1NW)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(Yj0);
		LinkLabel linkLabel = _LinkLabel1;
		if (linkLabel != null)
		{
			linkLabel.remove_LinkClicked(val);
		}
		_LinkLabel1 = s1NW;
		linkLabel = _LinkLabel1;
		if (linkLabel != null)
		{
			linkLabel.add_LinkClicked(val);
		}
	}

	[SpecialName]
	internal virtual Panel Rn31()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void An90(Panel Sg3x)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MouseEventHandler val = new MouseEventHandler(Mc6w);
		Panel val2 = j;
		if (val2 != null)
		{
			((Control)val2).remove_MouseDown(val);
		}
		Panel val3 = (j = Sg3x);
		val2 = j;
		if (val2 != null)
		{
			((Control)val2).add_MouseDown(val);
		}
	}

	[SpecialName]
	internal virtual Panel Ja16()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mo5j(Panel s5MN)
	{
		Panel val = (W = s5MN);
	}

	[SpecialName]
	internal virtual q8Z.Fq4 Qm31()
	{
		return _IconButton2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zp0m(q8Z.Fq4 Hx10)
	{
		q8Z.Fq4.Ap2 ap = Qq1;
		_IconButton2?.w9L(ap);
		_IconButton2 = Hx10;
		_IconButton2?.t2E(ap);
	}

	[SpecialName]
	internal virtual q8Z.Fq4 q1RA()
	{
		return _IconButton1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nq3s(q8Z.Fq4 g4N7)
	{
		q8Z.Fq4.Ap2 ap = Kf1;
		_IconButton1?.w9L(ap);
		_IconButton1 = g4N7;
		_IconButton1?.t2E(ap);
	}

	[SpecialName]
	internal virtual Label Ma3r()
	{
		return _lblFormTitle;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nc2x(Label Lz7r)
	{
		_lblFormTitle = Lz7r;
	}

	[SpecialName]
	internal virtual q8Z.d8E e1D4()
	{
		return _IconCurrentForm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c5JL(q8Z.d8E a2H0)
	{
		_IconCurrentForm = a2H0;
	}

	[SpecialName]
	internal virtual q8Z.Fq4 Gj71()
	{
		return _IconButton5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j2SL(q8Z.Fq4 m2T3)
	{
		q8Z.Fq4.Ap2 ap = Cb9;
		_IconButton5?.w9L(ap);
		_IconButton5 = m2T3;
		_IconButton5?.t2E(ap);
	}

	[SpecialName]
	internal virtual q8Z.Fq4 Xo75()
	{
		return _IconButton4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r6PC(q8Z.Fq4 a4W5)
	{
		q8Z.Fq4.Ap2 ap = z7Y;
		_IconButton4?.w9L(ap);
		_IconButton4 = a4W5;
		_IconButton4?.t2E(ap);
	}

	[SpecialName]
	internal virtual q8Z.Fq4 Ja3g()
	{
		return _IconButton3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o1XB(q8Z.Fq4 m3X0)
	{
		q8Z.Fq4.Ap2 ap = Qa4;
		_IconButton3?.w9L(ap);
		_IconButton3 = m3X0;
		_IconButton3?.t2E(ap);
	}

	[SpecialName]
	internal virtual Label t4E6()
	{
		return _NameLabel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sz89(Label o5L1)
	{
		_NameLabel1 = o5L1;
	}

	[SpecialName]
	internal virtual Label Zb5f()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x0YP(Label c8F9)
	{
		Label val = (F = c8F9);
	}

	[SpecialName]
	internal virtual q8Z.Fq4 Xk38()
	{
		return _IconButton6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Do6s(q8Z.Fq4 x7F1)
	{
		q8Z.Fq4.Ap2 ap = Aj2;
		_IconButton6?.w9L(ap);
		_IconButton6 = x7F1;
		_IconButton6?.t2E(ap);
	}

	public Da2i()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		((Control)this).add_Resize((EventHandler)c7A9);
		((Form)this).add_Load((EventHandler)Kz5);
		Tp81();
		leftBorderBtn = new Panel();
		((Control)leftBorderBtn).set_Size(new Size(7, 60));
		((Control)Dp20()).get_Controls().Add((Control)(object)leftBorderBtn);
		((Form)this).set_Text(string.Empty);
		((Form)this).set_ControlBox(false);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_MaximizedBounds(Screen.get_PrimaryScreen().get_WorkingArea());
	}

	private void e4L3(object t1TE, Color Nm30)
	{
		if (t1TE != null)
		{
			Gn3q();
			((Control)leftBorderBtn).set_BackColor(Nm30);
			((Control)leftBorderBtn).set_Visible(true);
			((Control)leftBorderBtn).BringToFront();
		}
	}

	private void Gn3q()
	{
		if (currentBtn != null)
		{
		}
	}

	internal static string[] b4SQ()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)Jp0.mDic["bee"]).GetManifestResourceNames();
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

	private void Hy3p(Form a0EB)
	{
		if (b != null)
		{
			b.Close();
		}
		Form val = (b = a0EB);
		a0EB.set_TopLevel(false);
		a0EB.set_FormBorderStyle((FormBorderStyle)0);
		((Control)a0EB).set_Dock((DockStyle)5);
		((Control)Ja16()).get_Controls().Add((Control)(object)a0EB);
		((Control)Ja16()).set_Tag((object)a0EB);
		((Control)a0EB).BringToFront();
		((Control)a0EB).Show();
		Ma3r().set_Text(a0EB.get_Text());
	}

	[DllImport("user32.DLL")]
	private static extern void ReleaseCapture();

	[DllImport("user32.DLL")]
	private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

	private void Mc6w(object sender, MouseEventArgs e)
	{
		ReleaseCapture();
		SendMessage(((Control)this).get_Handle(), 274, 61458, 0);
	}

	private void c7A9(object sender, EventArgs e)
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

	private void Kf1(object sender, EventArgs e)
	{
		e4L3(RuntimeHelpers.GetObjectValue(sender), Dp9.color6);
		Hy3p((Form)(object)new i9S4());
	}

	private void Qa4(object sender, EventArgs e)
	{
		((Form)this).set_WindowState((FormWindowState)1);
	}

	private void z7Y(object sender, EventArgs e)
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

	private void Cb9(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void Yj0(object sender, LinkLabelLinkClickedEventArgs e)
	{
		((Control)Eo05.Forms.Hp69()).Show();
		((Form)this).Close();
	}

	private void Qq1(object sender, EventArgs e)
	{
		e4L3(RuntimeHelpers.GetObjectValue(sender), Dp9.color6);
		Hy3p((Form)(object)new Jp0());
	}

	private void Kz5(object sender, EventArgs e)
	{
	}

	private void Aj2(object sender, EventArgs e)
	{
		e4L3(RuntimeHelpers.GetObjectValue(sender), Dp9.color6);
		Hy3p((Form)(object)new g9Q());
	}

	internal static byte[] Ty3(string[] Xe4, int Za0)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[Xe4.Length - 1 + 1];
				int num = Xe4.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = Xe4[i].Replace(".resources", "");
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
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)Jp0.mDic["bee"]);
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
