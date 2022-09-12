using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Lt35;
using Microsoft.VisualBasic.CompilerServices;
using r4CR;
using t4AQ;
using z2SR;

namespace o3D8;

[DesignerGenerated]
public class g0W3 : Form
{
	private ToolStripMenuItem _StudentsToolStripMenuItem;

	internal IContainer e;

	internal MenuStrip W;

	internal ToolStripMenuItem B;

	internal ToolStripMenuItem j;

	internal ToolStripMenuItem k;

	internal ToolStripMenuItem f;

	public g0W3()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Rr0d);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Jx9w));
		((Control)this).add_Resize((EventHandler)q2Y5);
		Pk39();
	}

	private void g2C7(object sender, EventArgs e)
	{
		((Control)Fb9z.Forms.n2B5()).Show();
		((Control)this).Hide();
	}

	private void i2H3(object sender, EventArgs e)
	{
		Tb17 tb = new Tb17();
		((Form)tb).set_MdiParent((Form)(object)this);
		((Control)tb).Show();
	}

	private void Rr0d(object sender, EventArgs e)
	{
		Eb3s.g4R6();
	}

	internal static bool p3M6(string Nx01)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(Nx01);
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

	private void Jx9w(object sender, FormClosingEventArgs e)
	{
		((Form)Fb9z.Forms.j1CF()).Close();
	}

	private void Pj18(object sender, EventArgs e)
	{
		Lt8o lt8o = new Lt8o();
		((Form)lt8o).set_MdiParent((Form)(object)this);
		((Control)lt8o).Show();
	}

	private void q2Y5(object sender, EventArgs e)
	{
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
	}

	internal static bool p7CN(int Nc37)
	{
		string[] array = new string[4] { "h", "j", "k", "l" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "hjkl", false) != 0)
		{
			string text = array[new Random().Next(0, checked(Nc37 + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "h", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "j", "k", "l" };
				Nc37 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "h", false) == 0 && Operators.CompareString(text, "j", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "k", "l" };
				Nc37 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "hj", false) == 0 && Operators.CompareString(text, "k", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "l" };
				Nc37 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "hjk", false) == 0 && Operators.CompareString(text, "l", false) == 0)
			{
				stringBuilder.Append(text);
			}
		}
		if (Operators.CompareString(stringBuilder.ToString(), "hjkl", false) == 0)
		{
			return true;
		}
		return false;
	}

	protected override void y3LH(bool b2SZ)
	{
		try
		{
			if (b2SZ && e != null)
			{
				e.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(b2SZ);
		}
	}

	private void Pk39()
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
		x5SC(new MenuStrip());
		Ce72(new ToolStripMenuItem());
		Bf5o(new ToolStripMenuItem());
		k3E6(new ToolStripMenuItem());
		Td09(new ToolStripMenuItem());
		Ms74(new ToolStripMenuItem());
		((Control)Ez58()).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)Ez58()).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)q2TD(),
			(ToolStripItem)Tq1w(),
			(ToolStripItem)Xf5p()
		});
		((Control)Ez58()).set_Location(new Point(0, 0));
		((Control)Ez58()).set_Name("MenuStrip1");
		((Control)Ez58()).set_Size(new Size(809, 24));
		((Control)Ez58()).set_TabIndex(0);
		((Control)Ez58()).set_Text("MenuStrip1");
		((ToolStripDropDownItem)q2TD()).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)Ny40() });
		((ToolStripItem)q2TD()).set_Name("FileToolStripMenuItem");
		((ToolStripItem)q2TD()).set_Size(new Size(43, 20));
		((ToolStripItem)q2TD()).set_Text("Staff");
		((ToolStripItem)Ny40()).set_Name("LibrarianToolStripMenuItem");
		((ToolStripItem)Ny40()).set_Size(new Size(120, 22));
		((ToolStripItem)Ny40()).set_Text("Librarian");
		((ToolStripDropDownItem)Tq1w()).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)z6J3() });
		((ToolStripItem)Tq1w()).set_Name("StudentsToolStripMenuItem");
		((ToolStripItem)Tq1w()).set_Size(new Size(65, 20));
		((ToolStripItem)Tq1w()).set_Text("Students");
		((ToolStripItem)z6J3()).set_Name("ComputerScienceToolStripMenuItem");
		((ToolStripItem)z6J3()).set_Size(new Size(171, 22));
		((ToolStripItem)z6J3()).set_Text("Computer Science");
		((ToolStripItem)Xf5p()).set_Name("AboutToolStripMenuItem");
		((ToolStripItem)Xf5p()).set_Size(new Size(52, 20));
		((ToolStripItem)Xf5p()).set_Text("About");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(809, 382));
		((Control)this).get_Controls().Add((Control)(object)Ez58());
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_IsMdiContainer(true);
		((Form)this).set_MainMenuStrip(Ez58());
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Library Management System ");
		((Control)Ez58()).ResumeLayout(false);
		((Control)Ez58()).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual MenuStrip Ez58()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x5SC(MenuStrip d9S6)
	{
		MenuStrip val = (W = d9S6);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem q2TD()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ce72(ToolStripMenuItem o5FL)
	{
		ToolStripMenuItem val = (B = o5FL);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem Ny40()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bf5o(ToolStripMenuItem a1N9)
	{
		EventHandler eventHandler = i2H3;
		ToolStripMenuItem val = j;
		if (val != null)
		{
			((ToolStripItem)val).remove_Click(eventHandler);
		}
		ToolStripMenuItem val2 = (j = a1N9);
		val = j;
		if (val != null)
		{
			((ToolStripItem)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem Tq1w()
	{
		return _StudentsToolStripMenuItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k3E6(ToolStripMenuItem n4J7)
	{
		_StudentsToolStripMenuItem = n4J7;
	}

	[SpecialName]
	internal virtual ToolStripMenuItem z6J3()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Td09(ToolStripMenuItem w7YG)
	{
		EventHandler eventHandler = g2C7;
		ToolStripMenuItem val = k;
		if (val != null)
		{
			((ToolStripItem)val).remove_Click(eventHandler);
		}
		ToolStripMenuItem val2 = (k = w7YG);
		val = k;
		if (val != null)
		{
			((ToolStripItem)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem Xf5p()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ms74(ToolStripMenuItem c6WM)
	{
		EventHandler eventHandler = Pj18;
		ToolStripMenuItem val = f;
		if (val != null)
		{
			((ToolStripItem)val).remove_Click(eventHandler);
		}
		ToolStripMenuItem val2 = (f = c6WM);
		val = f;
		if (val != null)
		{
			((ToolStripItem)val).add_Click(eventHandler);
		}
	}
}
