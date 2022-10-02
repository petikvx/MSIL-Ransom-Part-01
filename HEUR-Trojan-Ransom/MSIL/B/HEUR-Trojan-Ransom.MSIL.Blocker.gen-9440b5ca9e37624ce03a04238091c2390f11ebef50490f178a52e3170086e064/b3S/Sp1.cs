using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using d5N;
using g7N;

namespace b3S;

[DesignerGenerated]
public class Sp1 : Form
{
	private TextBox _TextBox1;

	private Label _Label1;

	private Button _Button1;

	internal IContainer f;

	public Sp1()
	{
		Mt8();
	}

	protected override void Kb9(bool t8L)
	{
		try
		{
			if (t8L && f != null)
			{
				f.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(t8L);
		}
	}

	private void Mt8()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		w3P(new TextBox());
		Yx3(new Label());
		g1B(new Button());
		((Control)this).SuspendLayout();
		((Control)Gf2()).set_Location(new Point(132, 74));
		((Control)Gf2()).set_Name("TextBox1");
		((Control)Gf2()).set_Size(new Size(132, 20));
		((Control)Gf2()).set_TabIndex(0);
		Nk7().set_AutoSize(true);
		((Control)Nk7()).set_Location(new Point(64, 81));
		((Control)Nk7()).set_Name("Label1");
		((Control)Nk7()).set_Size(new Size(61, 13));
		((Control)Nk7()).set_TabIndex(1);
		Nk7().set_Text("Student_ID");
		((Control)x9D()).set_Location(new Point(132, 112));
		((Control)x9D()).set_Name("Button1");
		((Control)x9D()).set_Size(new Size(132, 23));
		((Control)x9D()).set_TabIndex(2);
		((ButtonBase)x9D()).set_Text("Accept");
		((ButtonBase)x9D()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(364, 196));
		((Control)this).get_Controls().Add((Control)(object)x9D());
		((Control)this).get_Controls().Add((Control)(object)Nk7());
		((Control)this).get_Controls().Add((Control)(object)Gf2());
		((Control)this).set_Name("Decision");
		((Form)this).set_Text("Decision");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual TextBox Gf2()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w3P(TextBox Yb2)
	{
		_TextBox1 = Yb2;
	}

	[SpecialName]
	internal virtual Label Nk7()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yx3(Label Eq2)
	{
		_Label1 = Eq2;
	}

	[SpecialName]
	internal virtual Button x9D()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g1B(Button s7Y)
	{
		EventHandler eventHandler = c6H;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = s7Y;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	private void c6H(object sender, EventArgs e)
	{
		Rt9.Forms.Ym1().Fk0i().Nm1q();
		Rt9.Forms.Ym1().Fk0i().Dj6i(Rt9.Forms.Ym1().Ey53().Schedule);
	}

	internal static bool Sz5()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string q0D in array2)
				{
					if (!Cm7.m4Q(q0D))
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
