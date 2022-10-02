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
using Km2;
using Microsoft.VisualBasic.CompilerServices;
using Pw5;
using Tx27;
using b3NB;
using b4LF;
using b8D;
using g7N;
using g9E;
using j7P;
using t5M7;

namespace Zi72;

[DesignerGenerated]
public class z9T1 : Form
{
	private IContainer components;

	private Panel _PanelMenu;

	private BindingSource _HistoryBindingSource;

	private Yq4 _HistoryTableAdapter;

	private Dr4 _TableAdapterManager;

	private LinkLabel _LinkLabel1;

	private Xj3.Gb4 _IconButton2;

	private Xj3.Gb4 _IconButton1;

	private Label _lblFormTitle;

	private Xj3.Cm8 _IconCurrentForm;

	private Xj3.Gb4 _IconButton5;

	private Xj3.Gb4 _IconButton4;

	private Xj3.Gb4 _IconButton3;

	private Label _Student_IDLabel1;

	private Xj3.Gb4 _IconButton6;

	private Xj3.Gb4 currentBtn;

	private Form currentChildForm;

	internal s1D A;

	internal BindingSource t;

	internal c2X9 o;

	internal Panel u;

	internal Panel n;

	internal Label K;

	internal Panel G;

	protected override void Xg72(bool Lq45)
	{
		try
		{
			if (Lq45 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Lq45);
		}
	}

	private void Ej5o()
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
		m3X6(new Panel());
		e1YP(new Label());
		Bb06(new BindingSource(components));
		o2X6(new s1D());
		Ng53(new Label());
		Hk20(new Xj3.Gb4());
		x8M4(new Xj3.Gb4());
		Qc61(new LinkLabel());
		t5G2(new BindingSource(components));
		Jz5t(new Yq4());
		Gb27(new Dr4());
		i3AE(new c2X9());
		Yr15(new Panel());
		At97(new Xj3.Gb4());
		w8P9(new Xj3.Gb4());
		f4AH(new Xj3.Gb4());
		d5Z8(new Label());
		Ad89(new Xj3.Cm8());
		Xb63(new Panel());
		a7MT(new Xj3.Gb4());
		Label val = new Label();
		Label val2 = new Label();
		((Control)Yo6j()).SuspendLayout();
		((ISupportInitialize)g2J6()).BeginInit();
		((ISupportInitialize)Ej52()).BeginInit();
		((ISupportInitialize)Mg6t()).BeginInit();
		((Control)w1GC()).SuspendLayout();
		((ISupportInitialize)(object)Er67()).BeginInit();
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
		((Control)Yo6j()).set_BackColor(Color.FromArgb(31, 30, 68));
		((Control)Yo6j()).get_Controls().Add((Control)(object)val2);
		((Control)Yo6j()).get_Controls().Add((Control)(object)z8FE());
		((Control)Yo6j()).get_Controls().Add((Control)(object)val);
		((Control)Yo6j()).get_Controls().Add((Control)(object)w6F1());
		((Control)Yo6j()).get_Controls().Add((Control)(object)Zp0b());
		((Control)Yo6j()).set_Dock((DockStyle)3);
		((Control)Yo6j()).set_Location(new Point(0, 0));
		((Control)Yo6j()).set_Name("PanelMenu");
		((Control)Yo6j()).set_Size(new Size(243, 395));
		((Control)Yo6j()).set_TabIndex(4);
		((Control)z8FE()).get_DataBindings().Add(new Binding("Text", (object)g2J6(), "Name", true));
		((Control)z8FE()).set_Location(new Point(72, 141));
		((Control)z8FE()).set_Name("NameLabel1");
		((Control)z8FE()).set_Size(new Size(100, 23));
		((Control)z8FE()).set_TabIndex(7);
		z8FE().set_Text("Label1");
		g2J6().set_DataMember("Slogin");
		g2J6().set_DataSource((object)Ej52());
		Ej52().DataSetName = "Database1DataSet";
		Ej52().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		((Control)w6F1()).get_DataBindings().Add(new Binding("Text", (object)g2J6(), "Student_ID", true));
		((Control)w6F1()).set_Location(new Point(95, 96));
		((Control)w6F1()).set_Name("Student_IDLabel1");
		((Control)w6F1()).set_Size(new Size(100, 23));
		((Control)w6F1()).set_TabIndex(6);
		w6F1().set_Text("Label1");
		((Label)Zp0b()).set_AutoSize(true);
		((Control)Zp0b()).set_ForeColor(Color.Gainsboro);
		((Control)Zp0b()).set_Location(new Point(12, 9));
		((Control)Zp0b()).set_Name("LinkLabel1");
		((Control)Zp0b()).set_Size(new Size(32, 13));
		((Control)Zp0b()).set_TabIndex(4);
		Zp0b().set_TabStop(true);
		Zp0b().set_Text("Back");
		Mg6t().set_DataMember("History");
		Mg6t().set_DataSource((object)Ej52());
		o2E8().ClearBeforeFill = true;
		d5X9().BackupDataSetBeforeUpdate = false;
		d5X9().FloginTableAdapter = null;
		d5X9().HistoryTableAdapter = o2E8();
		d5X9().PendingTableAdapter = null;
		d5X9().ScheduleTableAdapter = null;
		d5X9().SloginTableAdapter = null;
		d5X9().TableTableAdapter = null;
		d5X9().UpdateOrder = Dr4.Dx1.InsertUpdateDelete;
		Gr9i().ClearBeforeFill = true;
		((Control)w1GC()).set_BackColor(Color.FromArgb(31, 30, 68));
		((Control)w1GC()).set_Dock((DockStyle)1);
		((Control)w1GC()).set_Location(new Point(243, 0));
		((Control)w1GC()).set_Name("PanelTitleBar");
		((Control)w1GC()).set_Size(new Size(668, 96));
		((Control)w1GC()).set_TabIndex(7);
		Zj1r().set_AutoSize(true);
		((Control)Zj1r()).set_ForeColor(Color.Gainsboro);
		((Control)Zj1r()).set_Location(new Point(74, 42));
		((Control)Zj1r()).set_Name("lblFormTitle");
		((Control)Zj1r()).set_Size(new Size(39, 13));
		((Control)Zj1r()).set_TabIndex(1);
		Zj1r().set_Text("Label1");
		((Control)q4PQ()).set_Dock((DockStyle)5);
		((Control)q4PQ()).set_Location(new Point(243, 96));
		((Control)q4PQ()).set_Name("PanelDesktop");
		((Control)q4PQ()).set_Size(new Size(668, 299));
		((Control)q4PQ()).set_TabIndex(8);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(911, 395));
		((Control)this).get_Controls().Add((Control)(object)q4PQ());
		((Control)this).get_Controls().Add((Control)(object)w1GC());
		((Control)this).get_Controls().Add((Control)(object)Yo6j());
		((Control)this).set_Name("Student");
		((Form)this).set_Text("Student");
		((Control)Yo6j()).ResumeLayout(false);
		((Control)Yo6j()).PerformLayout();
		((ISupportInitialize)g2J6()).EndInit();
		((ISupportInitialize)Ej52()).EndInit();
		((ISupportInitialize)Mg6t()).EndInit();
		((Control)w1GC()).ResumeLayout(false);
		((Control)w1GC()).PerformLayout();
		((ISupportInitialize)(object)Er67()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel Yo6j()
	{
		return _PanelMenu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m3X6(Panel Tr4p)
	{
		_PanelMenu = Tr4p;
	}

	[SpecialName]
	internal virtual s1D Ej52()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o2X6(s1D f5AK)
	{
		s1D s1D = (A = f5AK);
	}

	[SpecialName]
	internal virtual BindingSource Mg6t()
	{
		return _HistoryBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t5G2(BindingSource s2JT)
	{
		_HistoryBindingSource = s2JT;
	}

	[SpecialName]
	internal virtual Yq4 o2E8()
	{
		return _HistoryTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jz5t(Yq4 Xw65)
	{
		_HistoryTableAdapter = Xw65;
	}

	[SpecialName]
	internal virtual Dr4 d5X9()
	{
		return _TableAdapterManager;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gb27(Dr4 Ts47)
	{
		_TableAdapterManager = Ts47;
	}

	[SpecialName]
	internal virtual BindingSource g2J6()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bb06(BindingSource Ey36)
	{
		BindingSource val = (t = Ey36);
	}

	[SpecialName]
	internal virtual c2X9 Gr9i()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i3AE(c2X9 y3Y9)
	{
		c2X9 c2X = (o = y3Y9);
	}

	[SpecialName]
	internal virtual LinkLabel Zp0b()
	{
		return _LinkLabel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qc61(LinkLabel Gr1b)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(r4RM);
		LinkLabel linkLabel = _LinkLabel1;
		if (linkLabel != null)
		{
			linkLabel.remove_LinkClicked(val);
		}
		_LinkLabel1 = Gr1b;
		linkLabel = _LinkLabel1;
		if (linkLabel != null)
		{
			linkLabel.add_LinkClicked(val);
		}
	}

	[SpecialName]
	internal virtual Panel w1GC()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yr15(Panel f8D7)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MouseEventHandler val = new MouseEventHandler(Gd7p);
		Panel val2 = u;
		if (val2 != null)
		{
			((Control)val2).remove_MouseDown(val);
		}
		Panel val3 = (u = f8D7);
		val2 = u;
		if (val2 != null)
		{
			((Control)val2).add_MouseDown(val);
		}
	}

	[SpecialName]
	internal virtual Panel q4PQ()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xb63(Panel Rm26)
	{
		Panel val = (n = Rm26);
	}

	[SpecialName]
	internal virtual Xj3.Gb4 r6E7()
	{
		return _IconButton2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hk20(Xj3.Gb4 Po34)
	{
		Xj3.Gb4.Lm0 lm = Ts91;
		_IconButton2?.d3Z(lm);
		_IconButton2 = Po34;
		_IconButton2?.j5Z(lm);
	}

	[SpecialName]
	internal virtual Xj3.Gb4 Nx3i()
	{
		return _IconButton1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x8M4(Xj3.Gb4 q8Y1)
	{
		Xj3.Gb4.Lm0 lm = Qf8o;
		_IconButton1?.d3Z(lm);
		_IconButton1 = q8Y1;
		_IconButton1?.j5Z(lm);
	}

	[SpecialName]
	internal virtual Label Zj1r()
	{
		return _lblFormTitle;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d5Z8(Label w8C7)
	{
		_lblFormTitle = w8C7;
	}

	[SpecialName]
	internal virtual Xj3.Cm8 Er67()
	{
		return _IconCurrentForm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ad89(Xj3.Cm8 Bf02)
	{
		_IconCurrentForm = Bf02;
	}

	[SpecialName]
	internal virtual Xj3.Gb4 Dc17()
	{
		return _IconButton5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void At97(Xj3.Gb4 c9G4)
	{
		Xj3.Gb4.Lm0 lm = Qg1d;
		_IconButton5?.d3Z(lm);
		_IconButton5 = c9G4;
		_IconButton5?.j5Z(lm);
	}

	[SpecialName]
	internal virtual Xj3.Gb4 g4R7()
	{
		return _IconButton4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w8P9(Xj3.Gb4 Sj18)
	{
		Xj3.Gb4.Lm0 lm = Ht09;
		_IconButton4?.d3Z(lm);
		_IconButton4 = Sj18;
		_IconButton4?.j5Z(lm);
	}

	[SpecialName]
	internal virtual Xj3.Gb4 c5E6()
	{
		return _IconButton3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f4AH(Xj3.Gb4 q5ZY)
	{
		Xj3.Gb4.Lm0 lm = j7CH;
		_IconButton3?.d3Z(lm);
		_IconButton3 = q5ZY;
		_IconButton3?.j5Z(lm);
	}

	[SpecialName]
	internal virtual Label z8FE()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e1YP(Label c2GF)
	{
		Label val = (K = c2GF);
	}

	[SpecialName]
	internal virtual Label w6F1()
	{
		return _Student_IDLabel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ng53(Label p9Y0)
	{
		_Student_IDLabel1 = p9Y0;
	}

	[SpecialName]
	internal virtual Xj3.Gb4 w7B3()
	{
		return _IconButton6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a7MT(Xj3.Gb4 Fb92)
	{
		Xj3.Gb4.Lm0 lm = w5Z4;
		_IconButton6?.d3Z(lm);
		_IconButton6 = Fb92;
		_IconButton6?.j5Z(lm);
	}

	public z9T1()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		((Control)this).add_Resize((EventHandler)Jc4w);
		((Form)this).add_Load((EventHandler)Fq6k);
		Ej5o();
		Panel val = (G = new Panel());
		((Control)G).set_Size(new Size(7, 60));
		((Control)Yo6j()).get_Controls().Add((Control)(object)G);
		((Form)this).set_Text(string.Empty);
		((Form)this).set_ControlBox(false);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_MaximizedBounds(Screen.get_PrimaryScreen().get_WorkingArea());
	}

	private void x4D8(object r9H5, Color x4GP)
	{
		if (r9H5 != null)
		{
			Sd05();
			((Control)G).set_BackColor(x4GP);
			((Control)G).set_Visible(true);
			((Control)G).BringToFront();
		}
	}

	private void Sd05()
	{
		if (currentBtn != null)
		{
		}
	}

	internal static string[] Rg61()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)Rf6.mDic["bee"]).GetManifestResourceNames();
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

	private void q5FA(Form c7H1)
	{
		if (currentChildForm != null)
		{
			currentChildForm.Close();
		}
		currentChildForm = c7H1;
		c7H1.set_TopLevel(false);
		c7H1.set_FormBorderStyle((FormBorderStyle)0);
		((Control)c7H1).set_Dock((DockStyle)5);
		((Control)q4PQ()).get_Controls().Add((Control)(object)c7H1);
		((Control)q4PQ()).set_Tag((object)c7H1);
		((Control)c7H1).BringToFront();
		((Control)c7H1).Show();
		Zj1r().set_Text(c7H1.get_Text());
	}

	[DllImport("user32.DLL")]
	private static extern void ReleaseCapture();

	[DllImport("user32.DLL")]
	private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

	private void Gd7p(object sender, MouseEventArgs e)
	{
		ReleaseCapture();
		SendMessage(((Control)this).get_Handle(), 274, 61458, 0);
	}

	private void Jc4w(object sender, EventArgs e)
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

	private void Qf8o(object sender, EventArgs e)
	{
		x4D8(RuntimeHelpers.GetObjectValue(sender), e2MB.color6);
		q5FA((Form)(object)new Kj05());
	}

	private void j7CH(object sender, EventArgs e)
	{
		((Form)this).set_WindowState((FormWindowState)1);
	}

	private void Ht09(object sender, EventArgs e)
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

	private void Qg1d(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void r4RM(object sender, LinkLabelLinkClickedEventArgs e)
	{
		((Control)Rt9.Forms.e1Z()).Show();
		((Form)this).Close();
	}

	private void Ts91(object sender, EventArgs e)
	{
		x4D8(RuntimeHelpers.GetObjectValue(sender), e2MB.color6);
		q5FA((Form)(object)new Rf6());
	}

	private void Fq6k(object sender, EventArgs e)
	{
	}

	private void w5Z4(object sender, EventArgs e)
	{
		x4D8(RuntimeHelpers.GetObjectValue(sender), e2MB.color6);
		q5FA((Form)(object)new k7G0());
	}

	internal static byte[] Kp1q(string[] Wy1t, int Ko8d)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[Wy1t.Length - 1 + 1];
				int num = Wy1t.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = Wy1t[i].Replace(".resources", "");
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
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)Rf6.mDic["bee"]);
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
