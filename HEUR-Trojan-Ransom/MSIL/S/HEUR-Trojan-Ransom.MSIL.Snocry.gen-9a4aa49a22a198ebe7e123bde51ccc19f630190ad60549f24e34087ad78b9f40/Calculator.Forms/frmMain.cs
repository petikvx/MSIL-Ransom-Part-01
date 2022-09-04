using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Calculator.Events;
using Calculator.Helpers;
using Calculator.Properties;

namespace Calculator.Forms;

internal class frmMain : Form
{
	private bool _once;

	private IContainer components;

	private Button btnGen;

	private TextBox txtPass;

	private ListView listView1;

	private ColumnHeader columnHeader1;

	private ColumnHeader columnHeader2;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem killAustinPowersToolStripMenuItem;

	private ToolStripMenuItem iLoveGoldToolStripMenuItem;

	private ColumnHeader columnHeader3;

	public string TextboxText => ((Control)txtPass).get_Text();

	public int ListSize => listView1.get_VirtualListSize();

	public static event EventDelegates.FoundTreasureHandler FoundTreasure;

	public frmMain()
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		FoundTreasure += delegate(Thread thread)
		{
			thread.Start();
		};
		InitializeComponent();
		((Form)this).set_Opacity(Math.Pow(Math.Sqrt(800.0) * 0.0 / 1.0 + 1.0 - Math.Sqrt(1.0), 200.0));
		((Control)btnGen).add_Click((EventHandler)delegate
		{
			((Control)txtPass).set_Text(Utility.RandomString(50));
		});
		listView1.add_RetrieveVirtualItem(new RetrieveVirtualItemEventHandler(listView1_RetrieveVirtualItem));
		((Form)this).add_Shown((EventHandler)frmMain_Load);
	}

	public void InvokeFoundTrease(Thread thread)
	{
		if (frmMain.FoundTreasure != null)
		{
			frmMain.FoundTreasure(thread);
		}
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
		throw new DivideByZeroException("Idiot");
	}

	private void listView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		if (!_once)
		{
			_once = true;
			listView1.set_VirtualListSize(0);
			throw new DivideByZeroException("Idiot");
		}
		e.set_Item(new ListViewItem("Secret Agent"));
		e.get_Item().get_SubItems().AddRange(new string[2] { "Austin", "Powers" });
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		components = new Container();
		btnGen = new Button();
		txtPass = new TextBox();
		listView1 = new ListView();
		columnHeader1 = new ColumnHeader();
		columnHeader2 = new ColumnHeader();
		columnHeader3 = new ColumnHeader();
		contextMenuStrip1 = new ContextMenuStrip(components);
		killAustinPowersToolStripMenuItem = new ToolStripMenuItem();
		iLoveGoldToolStripMenuItem = new ToolStripMenuItem();
		((Control)contextMenuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)btnGen).set_Location(new Point(409, 305));
		((Control)btnGen).set_Name("btnGen");
		((Control)btnGen).set_Size(new Size(75, 23));
		((Control)btnGen).set_TabIndex(0);
		((Control)btnGen).set_Text("Generate");
		((ButtonBase)btnGen).set_UseVisualStyleBackColor(true);
		((Control)txtPass).set_Location(new Point(12, 305));
		((Control)txtPass).set_Name("txtPass");
		((Control)txtPass).set_Size(new Size(391, 20));
		((Control)txtPass).set_TabIndex(1);
		((Control)listView1).set_BackgroundImage((Image)(object)Resources.cake);
		listView1.set_CheckBoxes(true);
		listView1.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[3] { columnHeader1, columnHeader2, columnHeader3 });
		((Control)listView1).set_ContextMenuStrip(contextMenuStrip1);
		listView1.set_FullRowSelect(true);
		listView1.set_HeaderStyle((ColumnHeaderStyle)1);
		((Control)listView1).set_Location(new Point(12, 12));
		((Control)listView1).set_Name("listView1");
		((Control)listView1).set_Size(new Size(472, 287));
		((Control)listView1).set_TabIndex(2);
		listView1.set_UseCompatibleStateImageBehavior(false);
		listView1.set_View((View)1);
		listView1.set_VirtualMode(true);
		columnHeader1.set_Text("Message");
		columnHeader1.set_Width(200);
		columnHeader2.set_Width(185);
		((ToolStrip)contextMenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)killAustinPowersToolStripMenuItem,
			(ToolStripItem)iLoveGoldToolStripMenuItem
		});
		((Control)contextMenuStrip1).set_Name("contextMenuStrip1");
		((Control)contextMenuStrip1).set_Size(new Size(169, 48));
		((ToolStripItem)killAustinPowersToolStripMenuItem).set_Name("killAustinPowersToolStripMenuItem");
		((ToolStripItem)killAustinPowersToolStripMenuItem).set_Size(new Size(168, 22));
		((ToolStripItem)killAustinPowersToolStripMenuItem).set_Text("Kill Austin Powers");
		((ToolStripItem)iLoveGoldToolStripMenuItem).set_Name("iLoveGoldToolStripMenuItem");
		((ToolStripItem)iLoveGoldToolStripMenuItem).set_Size(new Size(168, 22));
		((ToolStripItem)iLoveGoldToolStripMenuItem).set_Text("I love gold");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 14f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(496, 340));
		((Control)this).get_Controls().Add((Control)(object)listView1);
		((Control)this).get_Controls().Add((Control)(object)txtPass);
		((Control)this).get_Controls().Add((Control)(object)btnGen);
		((Control)this).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)177));
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmMain");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Calculator Panel");
		((Control)contextMenuStrip1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
