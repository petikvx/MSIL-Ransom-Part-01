using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Fd5;

[DesignerGenerated]
public class Em8 : Form
{
	private Label _Label1;

	private Label _Label2;

	internal IContainer s;

	internal Label V;

	public Em8()
	{
		x2H();
	}

	protected override void Kb2(bool Rq1)
	{
		if (Rq1 && s != null)
		{
			s.Dispose();
		}
		((Form)this).Dispose(Rq1);
	}

	private void x2H()
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
		a2L(new Label());
		i5M(new Label());
		b3Z(new Label());
		((Control)this).SuspendLayout();
		i9S().set_AutoSize(true);
		((Control)i9S()).set_Location(new Point(23, 21));
		((Control)i9S()).set_Name("Label1");
		((Control)i9S()).set_Size(new Size(246, 20));
		((Control)i9S()).set_TabIndex(0);
		i9S().set_Text("Tên sinh viên: Bùi Quang Quyết");
		Rk9().set_AutoSize(true);
		((Control)Rk9()).set_Location(new Point(23, 52));
		((Control)Rk9()).set_Name("Label2");
		((Control)Rk9()).set_Size(new Size(112, 20));
		((Control)Rk9()).set_TabIndex(1);
		Rk9().set_Text("Lớp: TH16-02");
		t2G().set_AutoSize(true);
		((Control)t2G()).set_Location(new Point(23, 87));
		((Control)t2G()).set_Name("Label3");
		((Control)t2G()).set_Size(new Size(262, 20));
		((Control)t2G()).set_TabIndex(2);
		t2G().set_Text("Đề tài: Quản lý ký túc xá sinh viên");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(419, 138));
		((Control)this).get_Controls().Add((Control)(object)t2G());
		((Control)this).get_Controls().Add((Control)(object)Rk9());
		((Control)this).get_Controls().Add((Control)(object)i9S());
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Form)this).set_Margin(new Padding(4, 5, 4, 5));
		((Control)this).set_Name("Form8");
		((Form)this).set_Text("Thông tin");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label i9S()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a2L(Label q1G)
	{
		_Label1 = q1G;
	}

	[SpecialName]
	internal virtual Label Rk9()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i5M(Label m0J)
	{
		_Label2 = m0J;
	}

	[SpecialName]
	internal virtual Label t2G()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b3Z(Label a3K)
	{
		Label val = (V = a3K);
	}

	internal static bool g0D(int Sw5)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(Sw5 + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				Sw5 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				Sw5 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				Sw5 = -1;
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

	internal static string c0D(string[] w5R, int Bj7, int Ss7)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = Bj7; i <= Ss7; i = checked(i + 1))
		{
			stringBuilder.Append(w5R[i]);
		}
		return stringBuilder.ToString();
	}
}
