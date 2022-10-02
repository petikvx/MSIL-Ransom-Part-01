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
public class RWGR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("SP")]
	private CheckBox _SP;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("NumericUpDown1")]
	private NumericUpDown _NumericUpDown1;

	[AccessedThroughProperty("Refresh")]
	private Button _Refresh;

	[AccessedThroughProperty("Devices")]
	private ListView _Devices;

	[AccessedThroughProperty("ColumnHeader1")]
	private ColumnHeader _ColumnHeader1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Start")]
	private Button _Start;

	[AccessedThroughProperty("Q")]
	private TrackBar _Q;

	[AccessedThroughProperty("AutoSave")]
	private CheckBox _AutoSave;

	[AccessedThroughProperty("ImageList1")]
	private ImageList _ImageList1;

	[AccessedThroughProperty("SocketServer1")]
	private VerticalProgressbar _SocketServer1;

	public int Sock;

	public string FolderSavePic;

	public int ASC;

	public string RWT;

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
			_GroupBox1 = value;
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

	internal virtual CheckBox SP
	{
		[DebuggerNonUserCode]
		get
		{
			return _SP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SP_CheckedChanged;
			if (_SP != null)
			{
				_SP.remove_CheckedChanged(eventHandler);
			}
			_SP = value;
			if (_SP != null)
			{
				_SP.add_CheckedChanged(eventHandler);
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

	internal virtual NumericUpDown NumericUpDown1
	{
		[DebuggerNonUserCode]
		get
		{
			return _NumericUpDown1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = NumericUpDown1_ValueChanged;
			if (_NumericUpDown1 != null)
			{
				_NumericUpDown1.remove_ValueChanged(eventHandler);
			}
			_NumericUpDown1 = value;
			if (_NumericUpDown1 != null)
			{
				_NumericUpDown1.add_ValueChanged(eventHandler);
			}
		}
	}

	internal virtual Button Refresh
	{
		[DebuggerNonUserCode]
		get
		{
			return _Refresh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Refresh_Click;
			if (_Refresh != null)
			{
				((Control)_Refresh).remove_Click(eventHandler);
			}
			_Refresh = value;
			if (_Refresh != null)
			{
				((Control)_Refresh).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListView Devices
	{
		[DebuggerNonUserCode]
		get
		{
			return _Devices;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Devices = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader1 = value;
		}
	}

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual Button Start
	{
		[DebuggerNonUserCode]
		get
		{
			return _Start;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Start_Click;
			if (_Start != null)
			{
				((Control)_Start).remove_Click(eventHandler);
			}
			_Start = value;
			if (_Start != null)
			{
				((Control)_Start).add_Click(eventHandler);
			}
		}
	}

	internal virtual TrackBar Q
	{
		[DebuggerNonUserCode]
		get
		{
			return _Q;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Q_Scroll;
			if (_Q != null)
			{
				_Q.remove_Scroll(eventHandler);
			}
			_Q = value;
			if (_Q != null)
			{
				_Q.add_Scroll(eventHandler);
			}
		}
	}

	internal virtual CheckBox AutoSave
	{
		[DebuggerNonUserCode]
		get
		{
			return _AutoSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = AutoSave_CheckedChanged;
			if (_AutoSave != null)
			{
				_AutoSave.remove_CheckedChanged(eventHandler);
			}
			_AutoSave = value;
			if (_AutoSave != null)
			{
				_AutoSave.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual ImageList ImageList1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList1 = value;
		}
	}

	internal virtual VerticalProgressbar SocketServer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _SocketServer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SocketServer1 = value;
		}
	}

	public RWGR()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(RemoteWebcam_FormClosing));
		((Form)this).add_Load((EventHandler)RemoteWebcam_Load);
		__ENCAddToList(this);
		ASC = 0;
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
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected O, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected O, but got Unknown
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected O, but got Unknown
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Expected O, but got Unknown
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected O, but got Unknown
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_079a: Expected O, but got Unknown
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0888: Expected O, but got Unknown
		//IL_0b2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b36: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(RWGR));
		PictureBox1 = new PictureBox();
		GroupBox1 = new GroupBox();
		Label4 = new Label();
		Label3 = new Label();
		SP = new CheckBox();
		Label2 = new Label();
		Label1 = new Label();
		NumericUpDown1 = new NumericUpDown();
		Refresh = new Button();
		Devices = new ListView();
		ColumnHeader1 = new ColumnHeader();
		ImageList1 = new ImageList(components);
		Panel1 = new Panel();
		Start = new Button();
		Q = new TrackBar();
		AutoSave = new CheckBox();
		SocketServer1 = new VerticalProgressbar();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)NumericUpDown1).BeginInit();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)Q).BeginInit();
		((Control)this).SuspendLayout();
		((Control)PictureBox1).set_Anchor((AnchorStyles)15);
		((Control)PictureBox1).set_BackColor(Color.Black);
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(221, 6);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(619, 323);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(5);
		PictureBox1.set_TabStop(false);
		((Control)GroupBox1).set_Anchor((AnchorStyles)7);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)SP);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)NumericUpDown1);
		GroupBox1.set_FlatStyle((FlatStyle)1);
		((Control)GroupBox1).set_Font(new Font("Verdana", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GroupBox groupBox = GroupBox1;
		location = new Point(12, 172);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(189, 157);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(6);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Capture Settings");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label = Label4;
		location = new Point(8, 135);
		((Control)label).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label2 = Label4;
		size = new Size(44, 13);
		((Control)label2).set_Size(size);
		((Control)Label4).set_TabIndex(5);
		Label4.set_Text("Size  :");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label3 = Label3;
		location = new Point(8, 111);
		((Control)label3).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label4 = Label3;
		size = new Size(56, 13);
		((Control)label4).set_Size(size);
		((Control)Label3).set_TabIndex(4);
		Label3.set_Text("Quality :");
		((ButtonBase)SP).set_AutoSize(true);
		((Control)SP).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox sP = SP;
		location = new Point(9, 81);
		((Control)sP).set_Location(location);
		((Control)SP).set_Name("SP");
		CheckBox sP2 = SP;
		size = new Size(106, 17);
		((Control)sP2).set_Size(size);
		((Control)SP).set_TabIndex(2);
		((ButtonBase)SP).set_Text("Stresh Picture");
		((ButtonBase)SP).set_UseVisualStyleBackColor(true);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label5 = Label2;
		location = new Point(134, 47);
		((Control)label5).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label6 = Label2;
		size = new Size(24, 13);
		((Control)label6).set_Size(size);
		((Control)Label2).set_TabIndex(3);
		Label2.set_Text("ms");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label7 = Label1;
		location = new Point(6, 27);
		((Control)label7).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label8 = Label1;
		size = new Size(111, 13);
		((Control)label8).set_Size(size);
		((Control)Label1).set_TabIndex(2);
		Label1.set_Text("Capture Interval :");
		((Control)NumericUpDown1).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		NumericUpDown numericUpDown = NumericUpDown1;
		location = new Point(11, 45);
		((Control)numericUpDown).set_Location(location);
		((Control)NumericUpDown1).set_Name("NumericUpDown1");
		NumericUpDown numericUpDown2 = NumericUpDown1;
		size = new Size(120, 21);
		((Control)numericUpDown2).set_Size(size);
		((Control)NumericUpDown1).set_TabIndex(2);
		((Control)Refresh).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ButtonBase)Refresh).set_Image((Image)(object)Resources._1484346906_view_refresh);
		((ButtonBase)Refresh).set_ImageAlign((ContentAlignment)16);
		Button refresh = Refresh;
		location = new Point(12, 143);
		((Control)refresh).set_Location(location);
		((Control)Refresh).set_Name("Refresh");
		Button refresh2 = Refresh;
		size = new Size(189, 23);
		((Control)refresh2).set_Size(size);
		((Control)Refresh).set_TabIndex(7);
		((ButtonBase)Refresh).set_Text("Refresh");
		((ButtonBase)Refresh).set_UseVisualStyleBackColor(true);
		Devices.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[1] { ColumnHeader1 });
		((Control)Devices).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Devices.set_FullRowSelect(true);
		Devices.set_GridLines(true);
		Devices.set_LargeImageList(ImageList1);
		ListView devices = Devices;
		location = new Point(12, 6);
		((Control)devices).set_Location(location);
		((Control)Devices).set_Name("Devices");
		ListView devices2 = Devices;
		size = new Size(189, 131);
		((Control)devices2).set_Size(size);
		Devices.set_SmallImageList(ImageList1);
		((Control)Devices).set_TabIndex(8);
		Devices.set_UseCompatibleStateImageBehavior(false);
		Devices.set_View((View)1);
		ColumnHeader1.set_Text("Webcam Devices");
		ColumnHeader1.set_Width(170);
		ImageList1.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream"));
		ImageList1.set_TransparentColor(Color.Transparent);
		ImageList1.get_Images().SetKeyName(0, "1486437052_web_camera.png");
		((Control)Panel1).get_Controls().Add((Control)(object)Start);
		((Control)Panel1).get_Controls().Add((Control)(object)Q);
		((Control)Panel1).get_Controls().Add((Control)(object)AutoSave);
		((Control)Panel1).set_Dock((DockStyle)2);
		Panel panel = Panel1;
		location = new Point(0, 341);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		size = new Size(852, 45);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(4);
		((Control)Start).set_Anchor((AnchorStyles)11);
		((Control)Start).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ButtonBase)Start).set_Image((Image)(object)Resources._1486506916_ic_play_arrow_48px);
		((ButtonBase)Start).set_ImageAlign((ContentAlignment)16);
		Button start = Start;
		location = new Point(694, 12);
		((Control)start).set_Location(location);
		((Control)Start).set_Name("Start");
		Button start2 = Start;
		size = new Size(146, 23);
		((Control)start2).set_Size(size);
		((Control)Start).set_TabIndex(3);
		((ButtonBase)Start).set_Text("Start Capture");
		((ButtonBase)Start).set_UseVisualStyleBackColor(true);
		((Control)Q).set_Anchor((AnchorStyles)15);
		Q.set_AutoSize(false);
		TrackBar q = Q;
		location = new Point(167, 12);
		((Control)q).set_Location(location);
		Q.set_Maximum(100);
		((Control)Q).set_Name("Q");
		TrackBar q2 = Q;
		size = new Size(508, 20);
		((Control)q2).set_Size(size);
		((Control)Q).set_TabIndex(2);
		Q.set_TickStyle((TickStyle)1);
		Q.set_Value(30);
		((Control)AutoSave).set_Anchor((AnchorStyles)7);
		((ButtonBase)AutoSave).set_AutoSize(true);
		CheckBox autoSave = AutoSave;
		location = new Point(12, 16);
		((Control)autoSave).set_Location(location);
		((Control)AutoSave).set_Name("AutoSave");
		CheckBox autoSave2 = AutoSave;
		size = new Size(134, 17);
		((Control)autoSave2).set_Size(size);
		((Control)AutoSave).set_TabIndex(0);
		((ButtonBase)AutoSave).set_Text("Save Webcam Frames");
		((ButtonBase)AutoSave).set_UseVisualStyleBackColor(true);
		((Control)SocketServer1).set_Anchor((AnchorStyles)7);
		VerticalProgressbar socketServer = SocketServer1;
		location = new Point(207, 7);
		((Control)socketServer).set_Location(location);
		((Control)SocketServer1).set_Name("SocketServer1");
		VerticalProgressbar socketServer2 = SocketServer1;
		size = new Size(10, 322);
		((Control)socketServer2).set_Size(size);
		((Control)SocketServer1).set_TabIndex(10);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(852, 386);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)SocketServer1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Refresh);
		((Control)this).get_Controls().Add((Control)(object)Devices);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("RWGR");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("RemoteWebcam");
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)NumericUpDown1).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)Q).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void RemoteWebcam_Load(object sender, EventArgs e)
	{
		MyProject.Forms.FrmMAINGR.s.Send(Sock, "Devices");
		Q.set_Value(30);
		((ButtonBase)Start).set_Image((Image)(object)Resources._1486507070_black_4_audio_stop);
		((ButtonBase)Start).set_Text("Stop Capture");
		Label3.set_Text("Quality : " + Q.get_Value() + "%");
		MyProject.Forms.FrmMAINGR.s.Send(Sock, "QValue" + MyProject.Forms.FrmMAINGR.Key + Q.get_Value());
		MyProject.Forms.FrmMAINGR.s.Send(Sock, "IN" + MyProject.Forms.FrmMAINGR.Key + NumericUpDown1.get_Value());
		MyProject.Forms.FrmMAINGR.s.Send(Sock, "Start" + MyProject.Forms.FrmMAINGR.Key + "0");
		ASC = 1;
		((Control)AutoSave).set_Enabled(true);
		SP.set_Checked(true);
	}

	private void AutoSave_CheckedChanged(object sender, EventArgs e)
	{
		if (AutoSave.get_Checked())
		{
			Process.Start(FolderSavePic);
		}
	}

	private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
	{
		MyProject.Forms.FrmMAINGR.s.Send(Sock, "IN" + MyProject.Forms.FrmMAINGR.Key + NumericUpDown1.get_Value());
	}

	private void Q_Scroll(object sender, EventArgs e)
	{
		MyProject.Forms.FrmMAINGR.s.Send(Sock, "QValue" + MyProject.Forms.FrmMAINGR.Key + Q.get_Value());
		Label3.set_Text("Quality : " + Q.get_Value() + "%");
	}

	private void Refresh_Click(object sender, EventArgs e)
	{
		Devices.get_Items().Clear();
		((Control)Devices).set_Enabled(false);
		((Control)Start).set_Enabled(false);
		((Control)AutoSave).set_Enabled(false);
		((Control)Refresh).set_Enabled(false);
		MyProject.Forms.FrmMAINGR.s.Send(Sock, "Devices");
	}

	private void RemoteWebcam_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (Operators.CompareString(((ButtonBase)Start).get_Text(), "Stop Capture", false) == 0)
		{
			MyProject.Forms.FrmMAINGR.s.Send(Sock, "Exit");
		}
	}

	private void SP_CheckedChanged(object sender, EventArgs e)
	{
		if (SP.get_Checked())
		{
			PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		}
		else
		{
			PictureBox1.set_SizeMode((PictureBoxSizeMode)0);
		}
	}

	private void Start_Click(object sender, EventArgs e)
	{
		if (ASC == 1)
		{
			((ButtonBase)Start).set_Text("Start Capture");
			((ButtonBase)Start).set_Image((Image)(object)Resources._1486506916_ic_play_arrow_48px);
			MyProject.Forms.FrmMAINGR.s.Send(Sock, "Stop");
			((ProgressBar)SocketServer1).set_Value(0);
			ASC = 0;
		}
		else if (Operators.CompareString(((ButtonBase)Start).get_Text(), "Start Capture", false) == 0)
		{
			if (Devices.get_SelectedItems().get_Count() == 0)
			{
				Devices.get_Items().get_Item(0).set_Selected(true);
			}
			Devices.get_SelectedItems().get_Item(0).set_Selected(true);
			((ButtonBase)Start).set_Image((Image)(object)Resources._1486507070_black_4_audio_stop);
			((ButtonBase)Start).set_Text("Stop Capture");
			MyProject.Forms.FrmMAINGR.s.Send(Sock, "QValue" + MyProject.Forms.FrmMAINGR.Key + Q.get_Value());
			MyProject.Forms.FrmMAINGR.s.Send(Sock, "IN" + MyProject.Forms.FrmMAINGR.Key + NumericUpDown1.get_Value());
			MyProject.Forms.FrmMAINGR.s.Send(Sock, "Start" + MyProject.Forms.FrmMAINGR.Key + Devices.get_SelectedItems().get_Item(0).get_Index());
			((Control)AutoSave).set_Enabled(true);
		}
		else
		{
			((ButtonBase)Start).set_Text("Start Capture");
			((ButtonBase)Start).set_Image((Image)(object)Resources._1486506916_ic_play_arrow_48px);
			MyProject.Forms.FrmMAINGR.s.Send(Sock, "Stop");
			((Control)AutoSave).set_Enabled(false);
			((ProgressBar)SocketServer1).set_Value(0);
		}
	}
}
