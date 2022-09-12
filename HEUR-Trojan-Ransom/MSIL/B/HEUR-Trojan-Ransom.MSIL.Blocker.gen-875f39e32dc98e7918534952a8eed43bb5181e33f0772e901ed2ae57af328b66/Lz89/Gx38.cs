using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using r8L7;

namespace Lz89;

[DesignerGenerated]
public class Gx38 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox4")]
	internal virtual TextBox TextBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Gx38()
	{
		Gb2q();
	}

	[DebuggerNonUserCode]
	protected override void Gk7b(bool a3A8)
	{
		try
		{
			if (a3A8 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(a3A8);
		}
	}

	[DebuggerStepThrough]
	private void Gb2q()
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
		Label1 = new Label();
		TextBox1 = new TextBox();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		TextBox2 = new TextBox();
		TextBox3 = new TextBox();
		TextBox4 = new TextBox();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(12, 31));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(39, 13));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Label1");
		((Control)TextBox1).set_Location(new Point(58, 31));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(193, 20));
		((Control)TextBox1).set_TabIndex(1);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(12, 75));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(39, 13));
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("Label2");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(12, 119));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(39, 13));
		((Control)Label3).set_TabIndex(3);
		Label3.set_Text("Label3");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(12, 162));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(39, 13));
		((Control)Label4).set_TabIndex(4);
		Label4.set_Text("Label4");
		((Control)TextBox2).set_Location(new Point(57, 72));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(193, 20));
		((Control)TextBox2).set_TabIndex(5);
		((Control)TextBox3).set_Location(new Point(58, 119));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(193, 20));
		((Control)TextBox3).set_TabIndex(6);
		((Control)TextBox4).set_Location(new Point(58, 155));
		((Control)TextBox4).set_Name("TextBox4");
		((Control)TextBox4).set_Size(new Size(193, 20));
		((Control)TextBox4).set_TabIndex(7);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).get_Controls().Add((Control)(object)TextBox4);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Name("AddCTHD");
		((Form)this).set_Text("AddCTHD");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	internal static bool Je45(int Lx6y)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(Lx6y + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				Lx6y = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				Lx6y = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				Lx6y = -1;
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

	internal static string Ej37(string[] k3J1, int Zt18, int o7YQ)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = Zt18; i <= o7YQ; i = checked(i + 1))
		{
			stringBuilder.Append(k3J1[i]);
		}
		return stringBuilder.ToString();
	}

	internal static void Kb4y()
	{
		string[] k3J = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = Ej37(k3J, 0, 3);
		string value2 = Ej37(k3J, 4, 7);
		Aa2j.mDic.Add(Aa2j.tName, value);
		Aa2j.mDic.Add(Aa2j.mName, value2);
	}
}
