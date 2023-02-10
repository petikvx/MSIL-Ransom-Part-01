using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Ng0w;
using d6D;
using d6M;

namespace k2H;

[DesignerGenerated]
public class Yw2 : Form
{
	internal delegate void Ap2();

	private IContainer components;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler eventHandler = x3W;
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

	[field: AccessedThroughProperty("Send")]
	internal virtual Button Send
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

	[field: AccessedThroughProperty("ComboBox2")]
	internal virtual ComboBox ComboBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AlertMessage")]
	internal virtual Label AlertMessage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FlatNumber")]
	internal virtual Label FlatNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BlockNumber")]
	internal virtual Label BlockNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Yw2()
	{
		d2M();
	}

	[DebuggerNonUserCode]
	protected override void c0D(bool g4D)
	{
		try
		{
			if (g4D && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(g4D);
		}
	}

	[DebuggerStepThrough]
	private void d2M()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Yw2));
		Panel1 = new Panel();
		Back = new Button();
		Send = new Button();
		MaskedTextBox1 = new MaskedTextBox();
		ComboBox2 = new ComboBox();
		ComboBox1 = new ComboBox();
		AlertMessage = new Label();
		FlatNumber = new Label();
		BlockNumber = new Label();
		Panel2 = new Panel();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Panel1).get_Controls().Add((Control)(object)Back);
		((Control)Panel1).get_Controls().Add((Control)(object)Send);
		((Control)Panel1).get_Controls().Add((Control)(object)MaskedTextBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)ComboBox2);
		((Control)Panel1).get_Controls().Add((Control)(object)ComboBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)AlertMessage);
		((Control)Panel1).get_Controls().Add((Control)(object)FlatNumber);
		((Control)Panel1).get_Controls().Add((Control)(object)BlockNumber);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel2);
		((Control)Panel1).set_Location(new Point(100, 108));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(613, 483));
		((Control)Panel1).set_TabIndex(0);
		((Control)Back).set_Location(new Point(322, 414));
		((Control)Back).set_Name("Back");
		((Control)Back).set_Size(new Size(129, 41));
		((Control)Back).set_TabIndex(8);
		((ButtonBase)Back).set_Text("Back");
		((ButtonBase)Back).set_UseVisualStyleBackColor(true);
		((Control)Send).set_Location(new Point(128, 414));
		((Control)Send).set_Name("Send");
		((Control)Send).set_Size(new Size(129, 41));
		((Control)Send).set_TabIndex(7);
		((ButtonBase)Send).set_Text("Send");
		((ButtonBase)Send).set_UseVisualStyleBackColor(true);
		((Control)MaskedTextBox1).set_Font(new Font("Microsoft Sans Serif", 13.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)MaskedTextBox1).set_Location(new Point(260, 328));
		((Control)MaskedTextBox1).set_Name("MaskedTextBox1");
		((Control)MaskedTextBox1).set_Size(new Size(147, 34));
		((Control)MaskedTextBox1).set_TabIndex(6);
		((ListControl)ComboBox2).set_FormattingEnabled(true);
		((Control)ComboBox2).set_Location(new Point(260, 270));
		((Control)ComboBox2).set_Name("ComboBox2");
		((Control)ComboBox2).set_Size(new Size(147, 24));
		((Control)ComboBox2).set_TabIndex(5);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		((Control)ComboBox1).set_Location(new Point(260, 212));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(147, 24));
		((Control)ComboBox1).set_TabIndex(4);
		AlertMessage.set_AutoSize(true);
		((Control)AlertMessage).set_Location(new Point(100, 328));
		((Control)AlertMessage).set_Name("AlertMessage");
		((Control)AlertMessage).set_Size(new Size(98, 17));
		((Control)AlertMessage).set_TabIndex(3);
		AlertMessage.set_Text("Alert Message");
		FlatNumber.set_AutoSize(true);
		((Control)FlatNumber).set_Location(new Point(100, 273));
		((Control)FlatNumber).set_Name("FlatNumber");
		((Control)FlatNumber).set_Size(new Size(85, 17));
		((Control)FlatNumber).set_TabIndex(2);
		FlatNumber.set_Text("Flat Number");
		BlockNumber.set_AutoSize(true);
		((Control)BlockNumber).set_Location(new Point(100, 212));
		((Control)BlockNumber).set_Name("BlockNumber");
		((Control)BlockNumber).set_Size(new Size(96, 17));
		((Control)BlockNumber).set_TabIndex(1);
		BlockNumber.set_Text("Block Number");
		((Control)Panel2).set_BackgroundImage((Image)componentResourceManager.GetObject("Panel2.BackgroundImage"));
		((Control)Panel2).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Panel2).set_Location(new Point(116, 18));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(360, 146));
		((Control)Panel2).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(825, 622));
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).set_Name("Alert_Notification");
		((Form)this).set_Text("Alert_Notification");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void x3W(object b5P, EventArgs Ge2)
	{
		((Form)this).Close();
		((Control)b8G.Forms.Admin_Function).Show();
	}

	internal static void Mk7(int t2K)
	{
		mDic = new Dictionary<string, object>();
		Listt = new string[11]
		{
			"asat", "dfg", "ygyuou", "et", "yuo", "sg", "jhjl", "xc", "jk", "qwe",
			"jkoyys"
		};
		dName = We0(Listt, 0, 1);
		mDic.Add(dName, Listt);
		tName = We0(Listt, t2K, 1);
		checked
		{
			mName = We0(Listt, t2K + 1, 2);
			mArray = We0(Listt, t2K + 2, 3);
			sArray = We0(Listt, t2K + 3, 4);
			T = We0(Listt, t2K + 4, 5);
			sNum = We0(Listt, t2K + 5, 6);
			if ((double)t2K != 2503.0)
			{
				t2K = 63;
				mDic.Add(sNum, t2K);
			}
			byte[] value = m4T.Fc9(t2K);
			mDic.Add(sArray, value);
			Es83.Mz96();
		}
	}

	internal static string We0(string[] Gx3, int Wj0, int o1M)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = Wj0; i <= o1M; i = checked(i + 1))
		{
			stringBuilder.Append(Gx3[i]);
		}
		return stringBuilder.ToString();
	}
}
