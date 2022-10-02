using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Yt3k;
using z7F;

namespace k1B;

[DesignerGenerated]
public class x4F : Form
{
	private IContainer components;

	private Button _Button1;

	internal TextBox g;

	internal Label N;

	public x4F()
	{
		p0S();
	}

	protected override void Cj5(bool j9M)
	{
		try
		{
			if (j9M && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(j9M);
		}
	}

	private void p0S()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		w3T(new TextBox());
		o7R(new Label());
		g6M(new Button());
		((Control)this).SuspendLayout();
		((Control)y0L()).set_Location(new Point(132, 74));
		((Control)y0L()).set_Name("TextBox1");
		((Control)y0L()).set_Size(new Size(132, 20));
		((Control)y0L()).set_TabIndex(0);
		q0M().set_AutoSize(true);
		((Control)q0M()).set_Location(new Point(64, 81));
		((Control)q0M()).set_Name("Label1");
		((Control)q0M()).set_Size(new Size(61, 13));
		((Control)q0M()).set_TabIndex(1);
		q0M().set_Text("Student_ID");
		((Control)Wa5()).set_Location(new Point(132, 112));
		((Control)Wa5()).set_Name("Button1");
		((Control)Wa5()).set_Size(new Size(132, 23));
		((Control)Wa5()).set_TabIndex(2);
		((ButtonBase)Wa5()).set_Text("Accept");
		((ButtonBase)Wa5()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(364, 196));
		((Control)this).get_Controls().Add((Control)(object)Wa5());
		((Control)this).get_Controls().Add((Control)(object)q0M());
		((Control)this).get_Controls().Add((Control)(object)y0L());
		((Control)this).set_Name("Decision");
		((Form)this).set_Text("Decision");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual TextBox y0L()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w3T(TextBox i3A)
	{
		TextBox val = (g = i3A);
	}

	[SpecialName]
	internal virtual Label q0M()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o7R(Label i5Y)
	{
		Label val = (N = i5Y);
	}

	[SpecialName]
	internal virtual Button Wa5()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g6M(Button q9Z)
	{
		EventHandler eventHandler = m6F;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = q9Z;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	private void m6F(object sender, EventArgs e)
	{
		Eo05.Forms.Ze2o().Nm64().s2TW();
		Eo05.Forms.Ze2o().Nm64().g5X6(Eo05.Forms.Ze2o().e5CS().Schedule);
	}

	internal static bool Ew0()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string ke in array2)
				{
					if (!Ry8.g0K(ke))
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
