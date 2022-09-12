using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Nn5;

namespace i3W;

[DesignerGenerated]
public class g2J : Form
{
	private Label _Label2;

	private RichTextBox _RichTextBox5;

	private PictureBox _PictureBox1;

	private PictureBox _PictureBox2;

	private PictureBox _PictureBox3;

	private PictureBox _PictureBox5;

	internal IContainer m;

	internal Button A;

	internal Label d;

	internal PictureBox I;

	internal PictureBox w;

	internal ComboBox T;

	public g2J()
	{
		Cj3();
	}

	protected override void Hn3(bool Rp0)
	{
		try
		{
			if (Rp0 && m != null)
			{
				m.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Rp0);
		}
	}

	private void Cj3()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected O, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected O, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected O, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected O, but got Unknown
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(g2J));
		We1(new Button());
		Pe9(new Label());
		Qe3(new Label());
		c9P(new RichTextBox());
		Ls8(new PictureBox());
		q0D(new PictureBox());
		c9B(new PictureBox());
		Hp7(new PictureBox());
		Eo6(new PictureBox());
		w1N(new PictureBox());
		i2P(new ComboBox());
		((ISupportInitialize)a4T()).BeginInit();
		((ISupportInitialize)k5F()).BeginInit();
		((ISupportInitialize)Qx2()).BeginInit();
		((ISupportInitialize)e3S()).BeginInit();
		((ISupportInitialize)w6W()).BeginInit();
		((ISupportInitialize)Sx3()).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)Zq2()).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(0, 0, 192));
		((Control)Zq2()).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Zq2()).set_Location(new Point(21, 342));
		((Control)Zq2()).set_Name("Button2");
		((Control)Zq2()).set_Size(new Size(129, 40));
		((Control)Zq2()).set_TabIndex(82);
		((ButtonBase)Zq2()).set_Text("Back to Menu");
		((ButtonBase)Zq2()).set_UseVisualStyleBackColor(true);
		x7M().set_AutoSize(true);
		((Control)x7M()).set_BackColor(Color.Transparent);
		((Control)x7M()).set_Font(new Font("Microsoft Sans Serif", 20f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)x7M()).set_Location(new Point(15, 12));
		((Control)x7M()).set_Name("Label2");
		((Control)x7M()).set_Size(new Size(332, 31));
		((Control)x7M()).set_TabIndex(81);
		x7M().set_Text("HEAVENS FELL HOTEL");
		s3D().set_AutoSize(true);
		((Control)s3D()).set_BackColor(Color.Transparent);
		((Control)s3D()).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)s3D()).set_Location(new Point(15, 54));
		((Control)s3D()).set_Name("Label1");
		((Control)s3D()).set_Size(new Size(110, 22));
		((Control)s3D()).set_TabIndex(80);
		s3D().set_Text("LOCATION");
		((TextBoxBase)Ck6()).set_BackColor(Color.AliceBlue);
		((TextBoxBase)Ck6()).set_BorderStyle((BorderStyle)0);
		((Control)Ck6()).set_Enabled(false);
		Ck6().set_Font(new Font("Microsoft Sans Serif", 11f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Ck6().set_ForeColor(Color.Black);
		((Control)Ck6()).set_Location(new Point(21, 93));
		((Control)Ck6()).set_Name("RichTextBox5");
		((Control)Ck6()).set_Size(new Size(199, 129));
		((Control)Ck6()).set_TabIndex(83);
		Ck6().set_Text("HOW TO LOCATE \nHEAVENS FELL HOTEL:\n1. Go get World MAP\n2. Locate Bermuda's Triangle\n3. Fight the STORMS\n4. Reach Heaven Island\n5. YOU ARRIVED");
		((Control)a4T()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)a4T()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)a4T()).set_Location(new Point(336, 93));
		((Control)a4T()).set_Name("PictureBox1");
		((Control)a4T()).set_Size(new Size(423, 229));
		a4T().set_TabIndex(84);
		a4T().set_TabStop(false);
		((Control)k5F()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)k5F()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)k5F()).set_Location(new Point(336, 93));
		((Control)k5F()).set_Name("PictureBox2");
		((Control)k5F()).set_Size(new Size(423, 229));
		k5F().set_TabIndex(85);
		k5F().set_TabStop(false);
		((Control)Qx2()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox3.BackgroundImage"));
		((Control)Qx2()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Qx2()).set_Location(new Point(336, 93));
		((Control)Qx2()).set_Name("PictureBox3");
		((Control)Qx2()).set_Size(new Size(423, 229));
		Qx2().set_TabIndex(86);
		Qx2().set_TabStop(false);
		((Control)e3S()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox4.BackgroundImage"));
		((Control)e3S()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)e3S()).set_Location(new Point(336, 93));
		((Control)e3S()).set_Name("PictureBox4");
		((Control)e3S()).set_Size(new Size(423, 229));
		e3S().set_TabIndex(87);
		e3S().set_TabStop(false);
		((Control)w6W()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox5.BackgroundImage"));
		((Control)w6W()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)w6W()).set_Location(new Point(336, 93));
		((Control)w6W()).set_Name("PictureBox5");
		((Control)w6W()).set_Size(new Size(423, 229));
		w6W().set_TabIndex(88);
		w6W().set_TabStop(false);
		((Control)Sx3()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Sx3()).set_Location(new Point(336, 93));
		((Control)Sx3()).set_Name("PictureBox6");
		((Control)Sx3()).set_Size(new Size(423, 229));
		Sx3().set_TabIndex(89);
		Sx3().set_TabStop(false);
		((Control)r2K()).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)r2K()).set_FormattingEnabled(true);
		r2K().get_Items().AddRange(new object[5] { "1. Go get World MAP", "2. Locate Bermuda's Triangle", "3. Fight the STORMS", "4. Reach Heaven Island", "5. YOU ARRIVED" });
		((Control)r2K()).set_Location(new Point(397, 328));
		((Control)r2K()).set_Name("ComboBox1");
		((Control)r2K()).set_Size(new Size(330, 24));
		((Control)r2K()).set_TabIndex(90);
		r2K().set_Text("Click to see images . . . . .");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(771, 394));
		((Control)this).get_Controls().Add((Control)(object)r2K());
		((Control)this).get_Controls().Add((Control)(object)Sx3());
		((Control)this).get_Controls().Add((Control)(object)w6W());
		((Control)this).get_Controls().Add((Control)(object)e3S());
		((Control)this).get_Controls().Add((Control)(object)Qx2());
		((Control)this).get_Controls().Add((Control)(object)k5F());
		((Control)this).get_Controls().Add((Control)(object)a4T());
		((Control)this).get_Controls().Add((Control)(object)Ck6());
		((Control)this).get_Controls().Add((Control)(object)Zq2());
		((Control)this).get_Controls().Add((Control)(object)x7M());
		((Control)this).get_Controls().Add((Control)(object)s3D());
		((Control)this).set_Name("Form10");
		((Form)this).set_Text("LOCATION");
		((ISupportInitialize)a4T()).EndInit();
		((ISupportInitialize)k5F()).EndInit();
		((ISupportInitialize)Qx2()).EndInit();
		((ISupportInitialize)e3S()).EndInit();
		((ISupportInitialize)w6W()).EndInit();
		((ISupportInitialize)Sx3()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button Zq2()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void We1(Button Cr4)
	{
		EventHandler eventHandler = b0R;
		Button a = A;
		if (a != null)
		{
			((Control)a).remove_Click(eventHandler);
		}
		Button val = (A = Cr4);
		a = A;
		if (a != null)
		{
			((Control)a).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label x7M()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pe9(Label m1D)
	{
		_Label2 = m1D;
	}

	[SpecialName]
	internal virtual Label s3D()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qe3(Label Yx1)
	{
		Label val = (d = Yx1);
	}

	[SpecialName]
	internal virtual RichTextBox Ck6()
	{
		return _RichTextBox5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c9P(RichTextBox Br7)
	{
		_RichTextBox5 = Br7;
	}

	[SpecialName]
	internal virtual PictureBox a4T()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ls8(PictureBox d5A)
	{
		_PictureBox1 = d5A;
	}

	[SpecialName]
	internal virtual PictureBox k5F()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q0D(PictureBox Gm1)
	{
		_PictureBox2 = Gm1;
	}

	[SpecialName]
	internal virtual PictureBox Qx2()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c9B(PictureBox Sc7)
	{
		_PictureBox3 = Sc7;
	}

	[SpecialName]
	internal virtual PictureBox e3S()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hp7(PictureBox Bk2)
	{
		PictureBox val = (I = Bk2);
	}

	[SpecialName]
	internal virtual PictureBox w6W()
	{
		return _PictureBox5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eo6(PictureBox k6D)
	{
		_PictureBox5 = k6D;
	}

	[SpecialName]
	internal virtual PictureBox Sx3()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w1N(PictureBox q2G)
	{
		PictureBox val = (w = q2G);
	}

	[SpecialName]
	internal virtual ComboBox r2K()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i2P(ComboBox Jr5)
	{
		EventHandler eventHandler = g2M;
		ComboBox t = T;
		if (t != null)
		{
			t.remove_SelectedIndexChanged(eventHandler);
		}
		ComboBox val = (T = Jr5);
		t = T;
		if (t != null)
		{
			t.add_SelectedIndexChanged(eventHandler);
		}
	}

	private void b0R(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)i7X.Forms.Ek0()).Show();
	}

	internal static bool t8T()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string li in array2)
				{
					if (!Kn5(li))
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

	private void g2M(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(r2K().get_SelectedItem(), (object)"1. Go get World MAP", false))
		{
			((Control)k5F()).Hide();
			((Control)Qx2()).Hide();
			((Control)e3S()).Hide();
			((Control)w6W()).Hide();
			((Control)Sx3()).Hide();
			((Control)a4T()).Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(r2K().get_SelectedItem(), (object)"2. Locate Bermuda's Triangle", false))
		{
			((Control)a4T()).Hide();
			((Control)Qx2()).Hide();
			((Control)e3S()).Hide();
			((Control)w6W()).Hide();
			((Control)Sx3()).Hide();
			((Control)k5F()).Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(r2K().get_SelectedItem(), (object)"3. Fight the STORMS", false))
		{
			((Control)a4T()).Hide();
			((Control)k5F()).Hide();
			((Control)e3S()).Hide();
			((Control)w6W()).Hide();
			((Control)Sx3()).Hide();
			((Control)Qx2()).Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(r2K().get_SelectedItem(), (object)"4. Reach Heaven Island", false))
		{
			((Control)a4T()).Hide();
			((Control)k5F()).Hide();
			((Control)Qx2()).Hide();
			((Control)w6W()).Hide();
			((Control)Sx3()).Hide();
			((Control)e3S()).Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(r2K().get_SelectedItem(), (object)"5. YOU ARRIVED", false))
		{
			((Control)a4T()).Hide();
			((Control)k5F()).Hide();
			((Control)Qx2()).Hide();
			((Control)e3S()).Hide();
			((Control)Sx3()).Hide();
			((Control)w6W()).Show();
		}
	}

	internal static bool Kn5(string Li8)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(Li8);
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
