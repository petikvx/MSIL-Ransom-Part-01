using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using q4F8;
using y4J;

namespace q8D;

[DesignerGenerated]
public class n5J : Form
{
	internal IContainer e;

	internal TextBox s;

	internal Label T;

	internal Button a;

	public n5J()
	{
		b2W();
	}

	protected override void a8J(bool g0X)
	{
		try
		{
			if (g0X && e != null)
			{
				e.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(g0X);
		}
	}

	private void b2W()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		s7D(new TextBox());
		Tw1(new Label());
		f3N(new Button());
		((Control)this).SuspendLayout();
		((Control)Cf2()).set_Location(new Point(132, 74));
		((Control)Cf2()).set_Name("TextBox1");
		((Control)Cf2()).set_Size(new Size(132, 20));
		((Control)Cf2()).set_TabIndex(0);
		k6J().set_AutoSize(true);
		((Control)k6J()).set_Location(new Point(64, 81));
		((Control)k6J()).set_Name("Label1");
		((Control)k6J()).set_Size(new Size(61, 13));
		((Control)k6J()).set_TabIndex(1);
		k6J().set_Text("Student_ID");
		((Control)Yy4()).set_Location(new Point(132, 112));
		((Control)Yy4()).set_Name("Button1");
		((Control)Yy4()).set_Size(new Size(132, 23));
		((Control)Yy4()).set_TabIndex(2);
		((ButtonBase)Yy4()).set_Text("Accept");
		((ButtonBase)Yy4()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(364, 196));
		((Control)this).get_Controls().Add((Control)(object)Yy4());
		((Control)this).get_Controls().Add((Control)(object)k6J());
		((Control)this).get_Controls().Add((Control)(object)Cf2());
		((Control)this).set_Name("Decision");
		((Form)this).set_Text("Decision");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual TextBox Cf2()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s7D(TextBox r3G)
	{
		TextBox val = (s = r3G);
	}

	[SpecialName]
	internal virtual Label k6J()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tw1(Label Pi8)
	{
		Label val = (T = Pi8);
	}

	[SpecialName]
	internal virtual Button Yy4()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f3N(Button Ro4)
	{
		EventHandler eventHandler = Pc8;
		Button val = a;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (a = Ro4);
		val = a;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	private void Pc8(object sender, EventArgs e)
	{
		d7H8.Forms.Wz6e().Cs5g().Hq6c();
		d7H8.Forms.Wz6e().Cs5g().Do2q(d7H8.Forms.Wz6e().Zz15().Schedule);
	}

	internal static bool i0Z()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string f8A in array2)
				{
					if (!b0D.Rs6(f8A))
					{
						if (num > 0)
						{
							num--;
						}
						Task.Delay(30000).Wait();
					}
					else
					{
						num++;
					}
				}
			}
			if (num == 2)
			{
				return true;
			}
			return false;
		}
	}
}
