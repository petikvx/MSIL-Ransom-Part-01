using System;
using System.Collections;
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
public class DRFGR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("GRF")]
	private Button _GRF;

	[AccessedThroughProperty("RF")]
	private TextBox _RF;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[AccessedThroughProperty("StatusStrip1")]
	private StatusStrip _StatusStrip1;

	[AccessedThroughProperty("ToolStripStatusLabel1")]
	private ToolStripStatusLabel _ToolStripStatusLabel1;

	[AccessedThroughProperty("ContextMenuStrip1")]
	private ContextMenuStrip _ContextMenuStrip1;

	[AccessedThroughProperty("RefreshToolStripMenuItem")]
	private ToolStripMenuItem _RefreshToolStripMenuItem;

	[AccessedThroughProperty("ColumnHeader1")]
	private ColumnHeader _ColumnHeader1;

	[AccessedThroughProperty("ColumnHeader2")]
	private ColumnHeader _ColumnHeader2;

	[AccessedThroughProperty("ImageList1")]
	private ImageList _ImageList1;

	private ColumnHeader m_SortingColumn;

	public int sock;

	public object R;

	internal virtual Button GRF
	{
		[DebuggerNonUserCode]
		get
		{
			return _GRF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = GRF_Click;
			if (_GRF != null)
			{
				((Control)_GRF).remove_Click(eventHandler);
			}
			_GRF = value;
			if (_GRF != null)
			{
				((Control)_GRF).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox RF
	{
		[DebuggerNonUserCode]
		get
		{
			return _RF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(RF_KeyDown);
			if (_RF != null)
			{
				((Control)_RF).remove_KeyDown(val);
			}
			_RF = value;
			if (_RF != null)
			{
				((Control)_RF).add_KeyDown(val);
			}
		}
	}

	internal virtual ListView ListView1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			ColumnClickEventHandler val = new ColumnClickEventHandler(ListView1_ColumnClick);
			if (_ListView1 != null)
			{
				_ListView1.remove_ColumnClick(val);
			}
			_ListView1 = value;
			if (_ListView1 != null)
			{
				_ListView1.add_ColumnClick(val);
			}
		}
	}

	internal virtual StatusStrip StatusStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip1 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel1 = value;
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContextMenuStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContextMenuStrip1 = value;
		}
	}

	internal virtual ToolStripMenuItem RefreshToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RefreshToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RefreshToolStripMenuItem_Click;
			if (_RefreshToolStripMenuItem != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem).remove_Click(eventHandler);
			}
			_RefreshToolStripMenuItem = value;
			if (_RefreshToolStripMenuItem != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem).add_Click(eventHandler);
			}
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

	[DebuggerNonUserCode]
	public DRFGR()
	{
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
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected O, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DRFGR));
		GRF = new Button();
		RF = new TextBox();
		ListView1 = new ListView();
		ColumnHeader1 = new ColumnHeader();
		ColumnHeader2 = new ColumnHeader();
		ContextMenuStrip1 = new ContextMenuStrip(components);
		RefreshToolStripMenuItem = new ToolStripMenuItem();
		ImageList1 = new ImageList(components);
		StatusStrip1 = new StatusStrip();
		ToolStripStatusLabel1 = new ToolStripStatusLabel();
		((Control)ContextMenuStrip1).SuspendLayout();
		((Control)StatusStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GRF).set_Anchor((AnchorStyles)9);
		((Control)GRF).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ButtonBase)GRF).set_Image((Image)(object)Resources._1487272171_winrar_view);
		Button gRF = GRF;
		Point location = new Point(657, 5);
		((Control)gRF).set_Location(location);
		((Control)GRF).set_Name("GRF");
		Button gRF2 = GRF;
		Size size = new Size(29, 23);
		((Control)gRF2).set_Size(size);
		((Control)GRF).set_TabIndex(0);
		((ButtonBase)GRF).set_UseVisualStyleBackColor(true);
		((Control)RF).set_Anchor((AnchorStyles)13);
		((Control)RF).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox rF = RF;
		location = new Point(4, 7);
		((Control)rF).set_Location(location);
		((Control)RF).set_Name("RF");
		TextBox rF2 = RF;
		size = new Size(651, 21);
		((Control)rF2).set_Size(size);
		((Control)RF).set_TabIndex(1);
		((Control)ListView1).set_Anchor((AnchorStyles)15);
		ListView1.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { ColumnHeader1, ColumnHeader2 });
		((Control)ListView1).set_ContextMenuStrip(ContextMenuStrip1);
		((Control)ListView1).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		ListView1.set_FullRowSelect(true);
		ListView1.set_GridLines(true);
		ListView1.set_LargeImageList(ImageList1);
		ListView listView = ListView1;
		location = new Point(4, 34);
		((Control)listView).set_Location(location);
		((Control)ListView1).set_Name("ListView1");
		ListView listView2 = ListView1;
		size = new Size(682, 314);
		((Control)listView2).set_Size(size);
		ListView1.set_SmallImageList(ImageList1);
		((Control)ListView1).set_TabIndex(2);
		ListView1.set_UseCompatibleStateImageBehavior(false);
		ListView1.set_View((View)1);
		ColumnHeader1.set_Text("File Name");
		ColumnHeader1.set_Width(605);
		ColumnHeader2.set_Text("Size");
		ColumnHeader2.set_Width(72);
		((ToolStrip)ContextMenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)RefreshToolStripMenuItem });
		((Control)ContextMenuStrip1).set_Name("ContextMenuStrip1");
		ContextMenuStrip contextMenuStrip = ContextMenuStrip1;
		size = new Size(114, 26);
		((Control)contextMenuStrip).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem).set_Image((Image)(object)Resources._1484270709_view_refresh);
		((ToolStripItem)RefreshToolStripMenuItem).set_Name("RefreshToolStripMenuItem");
		ToolStripMenuItem refreshToolStripMenuItem = RefreshToolStripMenuItem;
		size = new Size(113, 22);
		((ToolStripItem)refreshToolStripMenuItem).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem).set_Text("Refresh");
		ImageList1.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream"));
		ImageList1.set_TransparentColor(Color.Transparent);
		ImageList1.get_Images().SetKeyName(0, "1487274783_Folder.png");
		ImageList1.get_Images().SetKeyName(1, "1487274753_file.png");
		((ToolStrip)StatusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel1 });
		StatusStrip statusStrip = StatusStrip1;
		location = new Point(0, 351);
		((Control)statusStrip).set_Location(location);
		((Control)StatusStrip1).set_Name("StatusStrip1");
		StatusStrip statusStrip2 = StatusStrip1;
		size = new Size(691, 22);
		((Control)statusStrip2).set_Size(size);
		((Control)StatusStrip1).set_TabIndex(3);
		((Control)StatusStrip1).set_Text("StatusStrip1");
		((ToolStripItem)ToolStripStatusLabel1).set_Name("ToolStripStatusLabel1");
		ToolStripStatusLabel toolStripStatusLabel = ToolStripStatusLabel1;
		size = new Size(141, 17);
		((ToolStripItem)toolStripStatusLabel).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel1).set_Text("Ready to any Command !");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(691, 373);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip1);
		((Control)this).get_Controls().Add((Control)(object)ListView1);
		((Control)this).get_Controls().Add((Control)(object)RF);
		((Control)this).get_Controls().Add((Control)(object)GRF);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("DRF");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("DRFvb");
		((Control)ContextMenuStrip1).ResumeLayout(false);
		((Control)StatusStrip1).ResumeLayout(false);
		((Control)StatusStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void GRF_Click(object sender, EventArgs e)
	{
		if ((RF.get_Text().Length > 0 && (RF.get_Text().EndsWith(".zip") | RF.get_Text().EndsWith(".ZIP") | RF.get_Text().EndsWith(".rar") | RF.get_Text().EndsWith(".RAR") | RF.get_Text().EndsWith(".7z") | RF.get_Text().EndsWith(".7Z") | RF.get_Text().EndsWith(".jar") | RF.get_Text().EndsWith(".JAR") | RF.get_Text().EndsWith(".tar") | RF.get_Text().EndsWith(".TAR") | RF.get_Text().EndsWith(".tgz") | RF.get_Text().EndsWith(".TGZ") | RF.get_Text().EndsWith(".gz") | RF.get_Text().EndsWith(".GZ") | RF.get_Text().EndsWith(".bz2") | RF.get_Text().EndsWith(".BZ2") | RF.get_Text().EndsWith(".tbz2") | RF.get_Text().EndsWith(".TBZ2") | RF.get_Text().EndsWith(".gzip") | RF.get_Text().EndsWith(".GZIP") | RF.get_Text().EndsWith(".z") | RF.get_Text().EndsWith(".Z") | RF.get_Text().EndsWith(".sit") | RF.get_Text().EndsWith(".SIT") | RF.get_Text().EndsWith(".cab") | RF.get_Text().EndsWith(".CAB") | RF.get_Text().EndsWith(".lzh") | RF.get_Text().EndsWith(".LZH") | RF.get_Text().EndsWith(".pkg") | RF.get_Text().EndsWith(".PKG"))) ? true : false)
		{
			MyProject.Forms.FrmMAINGR.s.Send(sock, "RARFiles" + MyProject.Forms.FrmMAINGR.Key + Functions.Encode(RF.get_Text()));
			((Control)GRF).set_Enabled(false);
			((Control)ListView1).set_Enabled(false);
			((ToolStripItem)ToolStripStatusLabel1).set_Text("Please wait a moment ...");
		}
	}

	private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
	{
		ListView1.get_Items().Clear();
		SocketServer s = MyProject.Forms.FrmMAINGR.s;
		object[] array = new object[2]
		{
			sock,
			Operators.AddObject((object)("Getrarfilesinside" + MyProject.Forms.FrmMAINGR.Key), R)
		};
		bool[] array2 = new bool[2] { true, false };
		NewLateBinding.LateCall((object)s, (Type)null, "Send", array, (string[])null, (Type[])null, array2, true);
		if (array2[0])
		{
			sock = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
		}
		((Control)ListView1).set_Enabled(false);
		((ToolStripItem)ToolStripStatusLabel1).set_Text("Please wait a moment ...");
	}

	private void RF_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		if ((RF.get_Text().Length > 0 && (int)e.get_KeyCode() == 13) ? true : false)
		{
			if (RF.get_Multiline())
			{
				RF.set_Multiline(false);
			}
			if (RF.get_Text().EndsWith(".zip") | RF.get_Text().EndsWith(".ZIP") | RF.get_Text().EndsWith(".rar") | RF.get_Text().EndsWith(".RAR") | RF.get_Text().EndsWith(".7z") | RF.get_Text().EndsWith(".7Z") | RF.get_Text().EndsWith(".jar") | RF.get_Text().EndsWith(".JAR") | RF.get_Text().EndsWith(".tar") | RF.get_Text().EndsWith(".TAR") | RF.get_Text().EndsWith(".tgz") | RF.get_Text().EndsWith(".TGZ") | RF.get_Text().EndsWith(".gz") | RF.get_Text().EndsWith(".GZ") | RF.get_Text().EndsWith(".bz2") | RF.get_Text().EndsWith(".BZ2") | RF.get_Text().EndsWith(".tbz2") | RF.get_Text().EndsWith(".TBZ2") | RF.get_Text().EndsWith(".gzip") | RF.get_Text().EndsWith(".GZIP") | RF.get_Text().EndsWith(".z") | RF.get_Text().EndsWith(".Z") | RF.get_Text().EndsWith(".sit") | RF.get_Text().EndsWith(".SIT") | RF.get_Text().EndsWith(".cab") | RF.get_Text().EndsWith(".CAB") | RF.get_Text().EndsWith(".lzh") | RF.get_Text().EndsWith(".LZH") | RF.get_Text().EndsWith(".pkg") | RF.get_Text().EndsWith(".PKG"))
			{
				MyProject.Forms.FrmMAINGR.s.Send(sock, "RARFiles" + MyProject.Forms.FrmMAINGR.Key + Functions.Encode(RF.get_Text()));
			}
			if (!RF.get_Multiline())
			{
				RF.set_Multiline(true);
			}
			((Control)GRF).set_Enabled(false);
			((Control)RF).set_Enabled(false);
		}
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToDouble(ListView1.get_Items().get_Count().ToString()) != 0.0)
		{
			ColumnHeader val = ListView1.get_Columns().get_Item(e.get_Column());
			SortOrder val2;
			if (m_SortingColumn == null)
			{
				val2 = (SortOrder)1;
			}
			else
			{
				val2 = ((!((object)val).Equals((object?)m_SortingColumn)) ? ((SortOrder)1) : ((!Conversions.ToBoolean(NewLateBinding.LateGet(m_SortingColumn.get_Tag(), (Type)null, "StartsWith", new object[1] { "> " }, (string[])null, (Type[])null, (bool[])null))) ? ((SortOrder)1) : ((SortOrder)2)));
				m_SortingColumn.set_Tag(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(m_SortingColumn.get_Tag(), (Type)null, "Substring", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null)));
			}
			m_SortingColumn = val;
			if ((int)val2 == 1)
			{
				m_SortingColumn.set_Tag(Operators.ConcatenateObject((object)"> ", m_SortingColumn.get_Tag()));
			}
			else
			{
				m_SortingColumn.set_Tag(Operators.ConcatenateObject((object)"< ", m_SortingColumn.get_Tag()));
			}
			ListView1.set_ListViewItemSorter((IComparer)new ListViewItemComparer(e.get_Column(), val2));
			ListView1.Sort();
		}
	}
}
