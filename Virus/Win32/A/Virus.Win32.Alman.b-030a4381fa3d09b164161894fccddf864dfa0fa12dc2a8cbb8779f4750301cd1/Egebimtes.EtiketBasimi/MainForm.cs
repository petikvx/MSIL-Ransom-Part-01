using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Egebimtes.EtiketBasimi;

public class MainForm : Form
{
	private IContainer components;

	private MenuStrip menuStrip1;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem_3;

	private ToolStripMenuItem toolStripMenuItem_4;

	private ToolStripMenuItem toolStripMenuItem_5;

	private ToolStripMenuItem toolStripMenuItem_6;

	private ToolStripMenuItem UretimEtiketBasim;

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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected O, but got Unknown
		menuStrip1 = new MenuStrip();
		toolStripMenuItem_0 = new ToolStripMenuItem();
		toolStripMenuItem_1 = new ToolStripMenuItem();
		toolStripMenuItem_2 = new ToolStripMenuItem();
		toolStripMenuItem_3 = new ToolStripMenuItem();
		toolStripMenuItem_6 = new ToolStripMenuItem();
		UretimEtiketBasim = new ToolStripMenuItem();
		toolStripMenuItem_4 = new ToolStripMenuItem();
		toolStripMenuItem_5 = new ToolStripMenuItem();
		((Control)menuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)menuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)toolStripMenuItem_0,
			(ToolStripItem)toolStripMenuItem_4
		});
		((Control)menuStrip1).set_Location(new Point(0, 0));
		((Control)menuStrip1).set_Name("menuStrip1");
		((Control)menuStrip1).set_Size(new Size(871, 24));
		((Control)menuStrip1).set_TabIndex(1);
		((Control)menuStrip1).set_Text("menuStrip1");
		((ToolStripDropDownItem)toolStripMenuItem_0).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)toolStripMenuItem_1,
			(ToolStripItem)toolStripMenuItem_2,
			(ToolStripItem)toolStripMenuItem_3,
			(ToolStripItem)toolStripMenuItem_6,
			(ToolStripItem)UretimEtiketBasim
		});
		((ToolStripItem)toolStripMenuItem_0).set_Name("hareketKartlarındanEtiketBasımıToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_0).set_Size(new Size(138, 20));
		((ToolStripItem)toolStripMenuItem_0).set_Text("Belgeden Etiket Basımı");
		((ToolStripItem)toolStripMenuItem_1).set_Name("faturadanEtiketBasımıToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_1).set_Size(new Size(227, 22));
		((ToolStripItem)toolStripMenuItem_1).set_Text("Faturadan Etiket Basımı");
		((ToolStripItem)toolStripMenuItem_1).add_Click((EventHandler)toolStripMenuItem_1_Click);
		((ToolStripItem)toolStripMenuItem_2).set_Name("irsaliyedenEtiketBasımıToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_2).set_Size(new Size(227, 22));
		((ToolStripItem)toolStripMenuItem_2).set_Text("İrsaliyeden Etiket Basımı");
		((ToolStripItem)toolStripMenuItem_2).add_Click((EventHandler)toolStripMenuItem_2_Click);
		((ToolStripItem)toolStripMenuItem_3).set_Name("sipariştenEtiketBasımıToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_3).set_Size(new Size(227, 22));
		((ToolStripItem)toolStripMenuItem_3).set_Text("Siparişten Etiket Basımı");
		((ToolStripItem)toolStripMenuItem_3).set_Visible(false);
		((ToolStripItem)toolStripMenuItem_3).add_Click((EventHandler)toolStripMenuItem_3_Click);
		((ToolStripItem)toolStripMenuItem_6).set_Name("ambarFişindenEtiketBasımıToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_6).set_Size(new Size(227, 22));
		((ToolStripItem)toolStripMenuItem_6).set_Text("Ambar Fişinden Etiket Basımı");
		((ToolStripItem)toolStripMenuItem_6).set_Visible(false);
		((ToolStripItem)toolStripMenuItem_6).add_Click((EventHandler)toolStripMenuItem_6_Click);
		((ToolStripItem)UretimEtiketBasim).set_Name("UretimEtiketBasim");
		((ToolStripItem)UretimEtiketBasim).set_Size(new Size(227, 22));
		((ToolStripItem)UretimEtiketBasim).set_Text("Üretim Fişinden Etiket Basımı");
		((ToolStripItem)UretimEtiketBasim).add_Click((EventHandler)UretimEtiketBasim_Click);
		((ToolStripDropDownItem)toolStripMenuItem_4).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)toolStripMenuItem_5 });
		((ToolStripItem)toolStripMenuItem_4).set_Name("stokKartındanEtiketBasımıToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_4).set_Size(new Size(172, 20));
		((ToolStripItem)toolStripMenuItem_4).set_Text("Sabit Kartlardan Etiket Basımı");
		((ToolStripItem)toolStripMenuItem_5).set_Name("mnustokKartındanEtiketBasımı");
		((ToolStripItem)toolStripMenuItem_5).set_Size(new Size(221, 22));
		((ToolStripItem)toolStripMenuItem_5).set_Text("Stok Kartından Etiket Basımı");
		((ToolStripItem)toolStripMenuItem_5).add_Click((EventHandler)toolStripMenuItem_5_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(871, 482));
		((Control)this).get_Controls().Add((Control)(object)menuStrip1);
		((Form)this).set_IsMdiContainer(true);
		((Form)this).set_MainMenuStrip(menuStrip1);
		((Control)this).set_Name("MainForm");
		((Control)this).set_Text("Egebimtes Barkod Basımı");
		((Form)this).add_FormClosed(new FormClosedEventHandler(MainForm_FormClosed));
		((Form)this).add_Load((EventHandler)MainForm_Load);
		((Control)menuStrip1).ResumeLayout(false);
		((Control)menuStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public MainForm()
	{
		InitializeComponent();
		((Form)this).CenterToScreen();
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		GForm0 gForm = new GForm0("FAT");
		((Form)gForm).set_MdiParent((Form)(object)this);
		((Control)gForm).Show();
	}

	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		GForm0 gForm = new GForm0("IRS");
		((Form)gForm).set_MdiParent((Form)(object)this);
		((Control)gForm).Show();
	}

	private void toolStripMenuItem_3_Click(object sender, EventArgs e)
	{
		GForm0 gForm = new GForm0("SIP");
		((Form)gForm).set_MdiParent((Form)(object)this);
		((Control)gForm).Show();
	}

	private void toolStripMenuItem_6_Click(object sender, EventArgs e)
	{
		GForm0 gForm = new GForm0("AMBAR");
		((Form)gForm).set_MdiParent((Form)(object)this);
		((Control)gForm).Show();
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		((Control)this).set_Text(((Control)this).get_Text() + " - Şirket: " + Program.strVTAdi + " Şube: " + Program.intSubeKodu);
	}

	private void UretimEtiketBasim_Click(object sender, EventArgs e)
	{
		GForm0 gForm = new GForm0("URS");
		((Form)gForm).set_MdiParent((Form)(object)this);
		((Control)gForm).Show();
	}

	private void toolStripMenuItem_5_Click(object sender, EventArgs e)
	{
		FrmStok frmStok = new FrmStok();
		((Form)frmStok).set_MdiParent((Form)(object)this);
		((Control)frmStok).Show();
	}

	private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
	{
		Application.Exit();
	}
}
