using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace a7J;

[DesignerGenerated]
public class Mq8 : Form
{
	private Label _Label1;

	private Label _Label3;

	internal IContainer w;

	internal Label R;

	public Mq8()
	{
		Gm1();
	}

	protected override void Zy6(bool Ze3)
	{
		if (Ze3 && w != null)
		{
			w.Dispose();
		}
		((Form)this).Dispose(Ze3);
	}

	private void Gm1()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		Et4(new Label());
		Dr5(new Label());
		Bj2(new Label());
		((Control)this).SuspendLayout();
		j2K().set_AutoSize(true);
		((Control)j2K()).set_Location(new Point(23, 21));
		((Control)j2K()).set_Name("Label1");
		((Control)j2K()).set_Size(new Size(246, 20));
		((Control)j2K()).set_TabIndex(0);
		j2K().set_Text("Tên sinh viên: Bùi Quang Quyết");
		g4S().set_AutoSize(true);
		((Control)g4S()).set_Location(new Point(23, 52));
		((Control)g4S()).set_Name("Label2");
		((Control)g4S()).set_Size(new Size(112, 20));
		((Control)g4S()).set_TabIndex(1);
		g4S().set_Text("Lớp: TH16-02");
		x2Y().set_AutoSize(true);
		((Control)x2Y()).set_Location(new Point(23, 87));
		((Control)x2Y()).set_Name("Label3");
		((Control)x2Y()).set_Size(new Size(262, 20));
		((Control)x2Y()).set_TabIndex(2);
		x2Y().set_Text("Đề tài: Quản lý ký túc xá sinh viên");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(419, 138));
		((Control)this).get_Controls().Add((Control)(object)x2Y());
		((Control)this).get_Controls().Add((Control)(object)g4S());
		((Control)this).get_Controls().Add((Control)(object)j2K());
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Form)this).set_Margin(new Padding(4, 5, 4, 5));
		((Control)this).set_Name("Form8");
		((Form)this).set_Text("Thông tin");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label j2K()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Et4(Label g9W)
	{
		_Label1 = g9W;
	}

	[SpecialName]
	internal virtual Label g4S()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dr5(Label Dr3)
	{
		Label val = (R = Dr3);
	}

	[SpecialName]
	internal virtual Label x2Y()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bj2(Label a5Z)
	{
		_Label3 = a5Z;
	}

	internal static bool n1D(int z5E)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(z5E + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				z5E = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				z5E = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				z5E = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Loa", false) == 0 && Operators.CompareString(text, "d", false) == 0)
			{
				stringBuilder.Append(text);
			}
		}
		if (Operators.CompareString(stringBuilder.ToString(), "Load", false) == 0)
		{
			return true;
		}
		return false;
	}

	internal static string q8R(string[] Hf1, int Yw4, int Hj3)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = Yw4; i <= Hj3; i = checked(i + 1))
		{
			stringBuilder.Append(Hf1[i]);
		}
		return stringBuilder.ToString();
	}
}
