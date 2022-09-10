using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Egebimtes.EtiketBasimi;

public class GForm0 : Form
{
	private IContainer components;

	private ToolTip toolTip;

	private GroupBox gbUstBilgi;

	private Label lblNo;

	private GroupBox gbKalemler;

	private RadioButton rbAlis;

	private TextBox txtBelgeNo;

	private Button btnYazdir;

	private Button btnTemizle;

	private Button btnListele;

	private Button btnFaturaRehber;

	private RadioButton rbSatis;

	private DataGridView dgvKalem;

	private CheckBox chkBasimMiktari;

	private CheckBox checkBox_0;

	private CheckBox checkBox_1;

	private Panel pnlBasimKriter;

	private Button button1;

	private Button btnHepsi;

	private string strBelgeTipi;

	private string strSecilenBelgeTipi;

	private string strSecilenBelgeCari;

	private bool blYazdir;

	private DBConn VTIslemleri;

	private DataTable dtKalemler;

	private DataTable dtBelgeUst;

	private string strDizaynAciklama1 = "";

	private string strDizaynAciklama2 = "";

	private string strDizaynAciklama3 = "";

	private string strDizaynAciklama4 = "";

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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected O, but got Unknown
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected O, but got Unknown
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected O, but got Unknown
		//IL_09d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e1: Expected O, but got Unknown
		//IL_0a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7a: Expected O, but got Unknown
		//IL_0b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b71: Expected O, but got Unknown
		components = new Container();
		toolTip = new ToolTip(components);
		gbUstBilgi = new GroupBox();
		btnYazdir = new Button();
		btnTemizle = new Button();
		btnListele = new Button();
		btnFaturaRehber = new Button();
		rbSatis = new RadioButton();
		rbAlis = new RadioButton();
		txtBelgeNo = new TextBox();
		lblNo = new Label();
		chkBasimMiktari = new CheckBox();
		checkBox_1 = new CheckBox();
		checkBox_0 = new CheckBox();
		gbKalemler = new GroupBox();
		dgvKalem = new DataGridView();
		pnlBasimKriter = new Panel();
		button1 = new Button();
		btnHepsi = new Button();
		((Control)gbUstBilgi).SuspendLayout();
		((Control)gbKalemler).SuspendLayout();
		((ISupportInitialize)dgvKalem).BeginInit();
		((Control)pnlBasimKriter).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)gbUstBilgi).get_Controls().Add((Control)(object)btnYazdir);
		((Control)gbUstBilgi).get_Controls().Add((Control)(object)btnTemizle);
		((Control)gbUstBilgi).get_Controls().Add((Control)(object)btnListele);
		((Control)gbUstBilgi).get_Controls().Add((Control)(object)btnFaturaRehber);
		((Control)gbUstBilgi).get_Controls().Add((Control)(object)rbSatis);
		((Control)gbUstBilgi).get_Controls().Add((Control)(object)rbAlis);
		((Control)gbUstBilgi).get_Controls().Add((Control)(object)txtBelgeNo);
		((Control)gbUstBilgi).get_Controls().Add((Control)(object)lblNo);
		((Control)gbUstBilgi).set_Dock((DockStyle)1);
		((Control)gbUstBilgi).set_Location(new Point(0, 0));
		((Control)gbUstBilgi).set_Name("gbUstBilgi");
		((Control)gbUstBilgi).set_Size(new Size(1063, 102));
		((Control)gbUstBilgi).set_TabIndex(7);
		gbUstBilgi.set_TabStop(false);
		((Control)btnYazdir).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)btnYazdir).set_Location(new Point(625, 25));
		((Control)btnYazdir).set_Name("btnYazdir");
		((Control)btnYazdir).set_Size(new Size(70, 38));
		((Control)btnYazdir).set_TabIndex(6);
		((Control)btnYazdir).set_Text("Yazdır");
		((ButtonBase)btnYazdir).set_UseVisualStyleBackColor(true);
		((Control)btnYazdir).add_Click((EventHandler)btnYazdir_Click);
		((Control)btnTemizle).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)btnTemizle).set_Location(new Point(539, 25));
		((Control)btnTemizle).set_Name("btnTemizle");
		((Control)btnTemizle).set_Size(new Size(70, 38));
		((Control)btnTemizle).set_TabIndex(5);
		((Control)btnTemizle).set_Text("Temizle");
		((ButtonBase)btnTemizle).set_UseVisualStyleBackColor(true);
		((Control)btnTemizle).add_Click((EventHandler)btnTemizle_Click);
		((Control)btnListele).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)btnListele).set_Location(new Point(453, 25));
		((Control)btnListele).set_Name("btnListele");
		((Control)btnListele).set_Size(new Size(70, 38));
		((Control)btnListele).set_TabIndex(4);
		((Control)btnListele).set_Text("Listele");
		((ButtonBase)btnListele).set_UseVisualStyleBackColor(true);
		((Control)btnListele).add_Click((EventHandler)btnListele_Click);
		((Control)btnFaturaRehber).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)btnFaturaRehber).set_Location(new Point(267, 35));
		((Control)btnFaturaRehber).set_Name("btnFaturaRehber");
		((Control)btnFaturaRehber).set_Size(new Size(36, 21));
		((Control)btnFaturaRehber).set_TabIndex(3);
		((Control)btnFaturaRehber).set_Text("R");
		((ButtonBase)btnFaturaRehber).set_UseVisualStyleBackColor(true);
		((Control)btnFaturaRehber).add_Click((EventHandler)btnFaturaRehber_Click);
		((Control)rbSatis).set_AutoSize(true);
		rbSatis.set_Checked(true);
		((Control)rbSatis).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)rbSatis).set_Location(new Point(93, 61));
		((Control)rbSatis).set_Name("rbSatis");
		((Control)rbSatis).set_Size(new Size(14, 13));
		((Control)rbSatis).set_TabIndex(2);
		rbSatis.set_TabStop(true);
		((ButtonBase)rbSatis).set_UseVisualStyleBackColor(true);
		((Control)rbAlis).set_AutoSize(true);
		((Control)rbAlis).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)rbAlis).set_Location(new Point(196, 61));
		((Control)rbAlis).set_Name("rbAlis");
		((Control)rbAlis).set_Size(new Size(14, 13));
		((Control)rbAlis).set_TabIndex(0);
		((ButtonBase)rbAlis).set_UseVisualStyleBackColor(true);
		((Control)txtBelgeNo).set_Location(new Point(90, 35));
		((Control)txtBelgeNo).set_Name("txtBelgeNo");
		((Control)txtBelgeNo).set_Size(new Size(171, 20));
		((Control)txtBelgeNo).set_TabIndex(1);
		((Control)lblNo).set_AutoSize(true);
		((Control)lblNo).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)lblNo).set_Location(new Point(8, 38));
		((Control)lblNo).set_Name("lblNo");
		((Control)lblNo).set_Size(new Size(63, 13));
		((Control)lblNo).set_TabIndex(0);
		((Control)lblNo).set_Text("Belge No:");
		((Control)chkBasimMiktari).set_AutoSize(true);
		((Control)chkBasimMiktari).set_Location(new Point(179, 14));
		((Control)chkBasimMiktari).set_Name("chkBasimMiktari");
		((Control)chkBasimMiktari).set_Size(new Size(137, 17));
		((Control)chkBasimMiktari).set_TabIndex(7);
		((Control)chkBasimMiktari).set_Text("Miktar Kadar Yazdır");
		((ButtonBase)chkBasimMiktari).set_UseVisualStyleBackColor(true);
		chkBasimMiktari.add_CheckedChanged((EventHandler)chkBasimMiktari_CheckedChanged);
		((Control)checkBox_1).set_AutoSize(true);
		((Control)checkBox_1).set_Location(new Point(397, 14));
		((Control)checkBox_1).set_Name("chkSeriyeGoreBasım");
		((Control)checkBox_1).set_Size(new Size(139, 17));
		((Control)checkBox_1).set_TabIndex(8);
		((Control)checkBox_1).set_Text("Seriye Göre Basılsın");
		((ButtonBase)checkBox_1).set_UseVisualStyleBackColor(true);
		((Control)checkBox_0).set_AutoSize(true);
		((Control)checkBox_0).set_Location(new Point(397, 41));
		((Control)checkBox_0).set_Name("chkSeriKadarBasım");
		((Control)checkBox_0).set_Size(new Size(174, 17));
		((Control)checkBox_0).set_TabIndex(9);
		((Control)checkBox_0).set_Text("Seri Miktarı Kadar Basılsın");
		((ButtonBase)checkBox_0).set_UseVisualStyleBackColor(true);
		((Control)gbKalemler).get_Controls().Add((Control)(object)dgvKalem);
		((Control)gbKalemler).set_Dock((DockStyle)2);
		((Control)gbKalemler).set_Location(new Point(0, 181));
		((Control)gbKalemler).set_Name("gbKalemler");
		((Control)gbKalemler).set_Size(new Size(1063, 305));
		((Control)gbKalemler).set_TabIndex(8);
		gbKalemler.set_TabStop(false);
		dgvKalem.set_AllowUserToAddRows(false);
		dgvKalem.set_AllowUserToDeleteRows(false);
		dgvKalem.set_AllowUserToResizeRows(false);
		dgvKalem.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		dgvKalem.set_BackgroundColor(SystemColors.Window);
		dgvKalem.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dgvKalem).set_Dock((DockStyle)5);
		((Control)dgvKalem).set_Location(new Point(3, 16));
		dgvKalem.set_MultiSelect(false);
		((Control)dgvKalem).set_Name("dgvKalem");
		((Control)dgvKalem).set_Size(new Size(1057, 286));
		((Control)dgvKalem).set_TabIndex(0);
		((Control)pnlBasimKriter).get_Controls().Add((Control)(object)button1);
		((Control)pnlBasimKriter).get_Controls().Add((Control)(object)btnHepsi);
		((Control)pnlBasimKriter).get_Controls().Add((Control)(object)checkBox_0);
		((Control)pnlBasimKriter).get_Controls().Add((Control)(object)checkBox_1);
		((Control)pnlBasimKriter).get_Controls().Add((Control)(object)chkBasimMiktari);
		((Control)pnlBasimKriter).set_Dock((DockStyle)5);
		((Control)pnlBasimKriter).set_Enabled(false);
		((Control)pnlBasimKriter).set_Location(new Point(0, 102));
		((Control)pnlBasimKriter).set_Name("pnlBasimKriter");
		((Control)pnlBasimKriter).set_Size(new Size(1063, 79));
		((Control)pnlBasimKriter).set_TabIndex(9);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)button1).set_Location(new Point(12, 41));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(116, 30));
		((Control)button1).set_TabIndex(11);
		((Control)button1).set_Text("Tümünü Temizle");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)btnHepsi).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)btnHepsi).set_Location(new Point(12, 6));
		((Control)btnHepsi).set_Name("btnHepsi");
		((Control)btnHepsi).set_Size(new Size(116, 30));
		((Control)btnHepsi).set_TabIndex(10);
		((Control)btnHepsi).set_Text("Tümünü Seç");
		((ButtonBase)btnHepsi).set_UseVisualStyleBackColor(true);
		((Control)btnHepsi).add_Click((EventHandler)btnHepsi_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1063, 486));
		((Control)this).get_Controls().Add((Control)(object)pnlBasimKriter);
		((Control)this).get_Controls().Add((Control)(object)gbKalemler);
		((Control)this).get_Controls().Add((Control)(object)gbUstBilgi);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Control)this).set_Name("FormEtiketBasımı");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("Etiket Basımı");
		((Form)this).add_Load((EventHandler)GForm0_Load);
		((Control)gbUstBilgi).ResumeLayout(false);
		((Control)gbUstBilgi).PerformLayout();
		((Control)gbKalemler).ResumeLayout(false);
		((ISupportInitialize)dgvKalem).EndInit();
		((Control)pnlBasimKriter).ResumeLayout(false);
		((Control)pnlBasimKriter).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public GForm0(string strBelgeTipiGelen)
	{
		InitializeComponent();
		strBelgeTipi = strBelgeTipiGelen;
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		SayfaDuzenleme();
		VTIslemleri = new DBConn();
		dtKalemler = new DataTable();
		dtBelgeUst = new DataTable();
	}

	private void SayfaDuzenleme()
	{
		switch (strBelgeTipi)
		{
		case "URS":
			((Control)lblNo).set_Text("Üretim Fiş No :");
			((Control)gbKalemler).set_Text("Üretim Fişi Kalemleri");
			((Control)rbAlis).set_Visible(false);
			((Control)rbSatis).set_Visible(false);
			((Control)this).set_Text("Üretim Fişi Etiket Basımı");
			break;
		case "SIP":
			((Control)lblNo).set_Text("Sipariş No :");
			((Control)gbKalemler).set_Text("Sipariş Kalemleri");
			((Control)rbAlis).set_Text("Satıcı");
			((Control)rbSatis).set_Text("Müşteri");
			((Control)this).set_Text("Sipariş Etiket Basımı");
			checkBox_0.set_Checked(false);
			((Control)checkBox_0).set_Visible(false);
			checkBox_1.set_Checked(false);
			((Control)checkBox_1).set_Visible(false);
			break;
		case "AMBAR":
			((Control)lblNo).set_Text("Ambar Fiş No :");
			((Control)gbKalemler).set_Text("Ambar Fişi Kalemleri");
			((Control)rbAlis).set_Text("Ambar Giriş");
			((Control)rbSatis).set_Text("Ambar Çıkış");
			((Control)this).set_Text("Ambar Fişi Etiket Basımı");
			break;
		case "IRS":
			((Control)lblNo).set_Text("İrsaliye No :");
			((Control)gbKalemler).set_Text("İrsaliye Kalemleri");
			((Control)rbAlis).set_Text("Alış");
			((Control)rbSatis).set_Text("Satış");
			((Control)this).set_Text("İrsaliye Etiket Basımı");
			break;
		case "FAT":
			((Control)lblNo).set_Text("Fatura No :");
			((Control)gbKalemler).set_Text("Fatura Kalemleri");
			((Control)rbAlis).set_Text("Alış");
			((Control)rbSatis).set_Text("Satış");
			((Control)this).set_Text("Fatura Etiket Basımı");
			break;
		}
	}

	private void btnFaturaRehber_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		btnTemizle_Click(this, e);
		if (!rbAlis.get_Checked() && !rbSatis.get_Checked())
		{
			MessageBox.Show("Lütfen alış veya satış mı olduğunu belirtin.", "Hata", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return;
		}
		strSecilenBelgeTipi = NetsisBelgeTipGetir();
		FormRehber formRehber = new FormRehber(this, strSecilenBelgeTipi);
		((Form)formRehber).ShowDialog();
	}

	private string NetsisBelgeTipGetir()
	{
		string result = "";
		if (rbAlis.get_Checked())
		{
			switch (strBelgeTipi)
			{
			case "URS":
				result = "9999";
				break;
			case "AMBAR":
				result = "9";
				break;
			case "SIP":
				result = "7";
				break;
			case "IRS":
				result = "4";
				break;
			case "FAT":
				result = "2";
				break;
			}
		}
		if (rbSatis.get_Checked())
		{
			switch (strBelgeTipi)
			{
			case "URS":
				result = "9999";
				break;
			case "AMBAR":
				result = "8";
				break;
			case "SIP":
				result = "6";
				break;
			case "IRS":
				result = "3";
				break;
			case "FAT":
				result = "1";
				break;
			}
		}
		return result;
	}

	private void btnTemizle_Click(object sender, EventArgs e)
	{
		chkBasimMiktari.set_Checked(false);
		checkBox_0.set_Checked(false);
		checkBox_1.set_Checked(false);
		((Control)txtBelgeNo).set_Text("");
		dtKalemler.Clear();
		((Control)pnlBasimKriter).set_Enabled(false);
	}

	private void btnListele_Click(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		dtKalemler.Clear();
		dtBelgeUst.Clear();
		if (((Control)txtBelgeNo).get_Text() == "")
		{
			MessageBox.Show("Lütfen belge numarası seçiniz.", "Hata", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return;
		}
		if (!rbAlis.get_Checked() && !rbSatis.get_Checked())
		{
			MessageBox.Show("Lütfen alış veya satış mı olduğunu belirtin.", "Hata", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return;
		}
		strSecilenBelgeTipi = NetsisBelgeTipGetir();
		try
		{
			dtKalemler = VTIslemleri.BelgeKalemListele(((Control)txtBelgeNo).get_Text(), strSecilenBelgeTipi, blReceteGetir: false);
			dgvKalem.set_DataSource((object)dtKalemler);
			DataGridAyarla();
			((Control)pnlBasimKriter).set_Enabled(true);
		}
		catch (Exception)
		{
			MessageBox.Show("Sipariş kalemleri listelenirken bir hata oluştu.", "Hata", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void DataGridAyarla()
	{
		((DataGridViewBand)dgvKalem.get_Columns().get_Item("STOK KODU")).set_ReadOnly(true);
		((DataGridViewBand)dgvKalem.get_Columns().get_Item("STOK ADI")).set_ReadOnly(true);
		((DataGridViewBand)dgvKalem.get_Columns().get_Item("MIKTARI")).set_ReadOnly(true);
		((DataGridViewBand)dgvKalem.get_Columns().get_Item("INCKEY")).set_Visible(false);
	}

	public void SetSiparisNo(string strSiparisNo, string strCariKod)
	{
		((Control)txtBelgeNo).set_Text(strSiparisNo);
		strSecilenBelgeCari = strCariKod;
	}

	public void SetUretimFisNo(string strUretimFisNo)
	{
		((Control)txtBelgeNo).set_Text(strUretimFisNo);
	}

	public void SetAciklamaSahalari(string strAcik1, string strAcik2, string strAcik3, string strAcik4)
	{
		strDizaynAciklama1 = strAcik1;
		strDizaynAciklama2 = strAcik2;
		strDizaynAciklama3 = strAcik3;
		strDizaynAciklama4 = strAcik4;
	}

	private void btnYazdir_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_Title("Etiket basımı için dizayn dosyası seçin");
		((FileDialog)val).set_Filter("Printer Output files (*.prn)|*.prn|Text files (*.txt)|*.txt");
		val.set_Multiselect(false);
		if ((int)((CommonDialog)val).ShowDialog() == 2)
		{
			MessageBox.Show("Etiket dizaynı seçilmeden basım yapılamaz !", "Etiket Basım");
			return;
		}
		Program.strSablonDosya = ((FileDialog)val).get_FileName();
		FormBasimAciklama formBasimAciklama = new FormBasimAciklama(this);
		((Form)formBasimAciklama).ShowDialog();
		string text = ((Control)txtBelgeNo).get_Text();
		foreach (DataGridViewRow item in (IEnumerable)dgvKalem.get_Rows())
		{
			DataGridViewRow val2 = item;
			int num = 0;
			if (!(bool)val2.get_Cells().get_Item("SEC").get_Value())
			{
				continue;
			}
			blYazdir = true;
			int num2 = 0;
			num2 = int.Parse(val2.get_Cells().get_Item("BASIM MIKTARI").get_Value()
				.ToString());
			int intIncKey = int.Parse(val2.get_Cells().get_Item("INCKEY").get_Value()
				.ToString());
			string strStokKoduGelen = val2.get_Cells().get_Item("STOK KODU").get_Value()
				.ToString();
			if (checkBox_0.get_Checked())
			{
				continue;
			}
			DataTable dataTable = VTIslemleri.SeriBilgiOku(intIncKey);
			DataRow rowStokHareketi = VTIslemleri.StokHareketOku(intIncKey);
			if (checkBox_1.get_Checked())
			{
				foreach (DataRow row in dataTable.Rows)
				{
					DosyaDuzelt(intIncKey, Program.strSablonDosya, strStokKoduGelen, text, Convert.ToDateTime(val2.get_Cells().get_Item("TARIH").get_Value()
						.ToString()), row, rowStokHareketi);
					for (int i = 0; i < num2; i++)
					{
						string arguments = "/C print ETIKETTMP.txt /d:" + Program.strPort;
						num++;
						Process process = new Process();
						process.EnableRaisingEvents = false;
						Process.Start("CMD.exe", arguments);
						Thread.Sleep(1000);
						process.Close();
					}
				}
			}
			else
			{
				DosyaDuzelt(intIncKey, Program.strSablonDosya, strStokKoduGelen, text, Convert.ToDateTime(val2.get_Cells().get_Item("TARIH").get_Value()
					.ToString()), null, rowStokHareketi);
				string text2 = Application.get_StartupPath() + "\\ETIKETTMP.txt";
				for (int j = 0; j < num2; j++)
				{
					string arguments2 = "/C print " + text2 + " /d:" + Program.strPort;
					num++;
					Process process2 = new Process();
					process2.EnableRaisingEvents = false;
					Process.Start("CMD.exe", arguments2);
					Thread.Sleep(1000);
					process2.Close();
				}
			}
		}
		if (!blYazdir)
		{
			MessageBox.Show("Yazdırılacak belge seçilmedi.", "Hata", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private bool DosyaDuzelt(int intIncKey, string strDosya, string strStokKoduGelen, string strBelgeNo, DateTime tarih, DataRow rowSeri, DataRow rowStokHareketi)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		StreamReader streamReader = new StreamReader(strDosya, Encoding.Default);
		StreamWriter streamWriter = new StreamWriter(Application.get_StartupPath() + "\\ETIKETTMP.txt", append: false, Encoding.Default);
		DataTable dataTable = VTIslemleri.StokBilgiOku(strStokKoduGelen);
		if (dataTable == null || dataTable.Rows.Count == 0)
		{
			MessageBox.Show("Seçilen satırdaki stok kodunun bilgileri okunamadı", "Hata");
		}
		string text = "";
		DateTime dateTime = tarih;
		if (dateTime.Day < 10)
		{
			text = "0";
		}
		text = text + dateTime.Day + ".";
		if (dateTime.Month < 10)
		{
			text += "0";
		}
		text = text + dateTime.Month + ".";
		text += dateTime.Year;
		string newValue = dataTable.Rows[0]["STOK_KODU"].ToString();
		string text2 = dataTable.Rows[0]["STOK_ADI"].ToString();
		string newValue2 = Convert.ToDecimal(dataTable.Rows[0]["PAY_1"]).ToString("#,##0.00");
		string newValue3 = Convert.ToDecimal(dataTable.Rows[0]["PAYDA_1"]).ToString("#,##0.00");
		string newValue4 = Convert.ToDecimal(dataTable.Rows[0]["PAY2"]).ToString("#,##0.00");
		string newValue5 = Convert.ToDecimal(dataTable.Rows[0]["PAYDA2"]).ToString("#,##0.00");
		dataTable.Rows[0]["GRUP_KODU"].ToString();
		string newValue6 = dataTable.Rows[0]["SATIS_FIAT1"].ToString();
		string newValue7 = dataTable.Rows[0]["SATIS_FIAT2"].ToString();
		string newValue8 = dataTable.Rows[0]["SATIS_FIAT3"].ToString();
		string newValue9 = dataTable.Rows[0]["SATIS_FIAT4"].ToString();
		string newValue10 = dataTable.Rows[0]["OLCU_BR1"].ToString();
		string newValue11 = dataTable.Rows[0]["OLCU_BR2"].ToString();
		string newValue12 = dataTable.Rows[0]["OLCU_BR3"].ToString();
		string newValue13 = dataTable.Rows[0]["KULL1S"].ToString();
		string newValue14 = dataTable.Rows[0]["KULL2S"].ToString();
		string newValue15 = dataTable.Rows[0]["KULL3S"].ToString();
		string newValue16 = dataTable.Rows[0]["KULL4S"].ToString();
		string newValue17 = dataTable.Rows[0]["KULL5S"].ToString();
		string newValue18 = dataTable.Rows[0]["KULL6S"].ToString();
		string newValue19 = dataTable.Rows[0]["KULL7S"].ToString();
		string newValue20 = dataTable.Rows[0]["KULL8S"].ToString();
		string newValue21 = Convert.ToDecimal(dataTable.Rows[0]["KULL1N"]).ToString("#,##0.00");
		string newValue22 = Convert.ToDecimal(dataTable.Rows[0]["KULL2N"]).ToString("#,##0.00");
		string newValue23 = Convert.ToDecimal(dataTable.Rows[0]["KULL3N"]).ToString("#,##0.00");
		string newValue24 = Convert.ToDecimal(dataTable.Rows[0]["KULL4N"]).ToString("#,##0.00");
		string newValue25 = Convert.ToDecimal(dataTable.Rows[0]["KULL5N"]).ToString("#,##0.00");
		string newValue26 = Convert.ToDecimal(dataTable.Rows[0]["KULL6N"]).ToString("#,##0.00");
		string newValue27 = Convert.ToDecimal(dataTable.Rows[0]["KULL7N"]).ToString("#,##0.00");
		string newValue28 = Convert.ToDecimal(dataTable.Rows[0]["KULL8N"]).ToString("#,##0.00");
		string newValue29 = dataTable.Rows[0]["INGISIM"].ToString();
		decimal d = Convert.ToDecimal(rowStokHareketi["STHAR_GCMIK"]);
		string newValue30 = Math.Round(d, 3).ToString();
		rowStokHareketi["STHAR_TARIH"].ToString();
		string text3 = "";
		while (streamReader.Peek() >= 0)
		{
			string text4 = streamReader.ReadLine();
			text3 = text4;
			text3 = text4.Replace("[*0*]", newValue);
			text3 = text3.Replace("[*1*]", text2);
			text3 = text3.Replace("[*20*]", newValue6);
			text3 = text3.Replace("[*21*]", newValue7);
			text3 = text3.Replace("[*22*]", newValue8);
			text3 = text3.Replace("[*23*]", newValue9);
			text3 = text3.Replace("[*6*]", newValue10);
			text3 = text3.Replace("[*7*]", newValue11);
			text3 = text3.Replace("[*8*]", newValue2);
			text3 = text3.Replace("[*9*]", newValue3);
			text3 = text3.Replace("[*10*]", newValue12);
			text3 = text3.Replace("[*11*]", newValue4);
			text3 = text3.Replace("[*12*]", newValue5);
			if (text2.Length > 30)
			{
				text3 = text3.Replace("[*1;30,1*]", text2.Substring(0, 30));
				text3 = text3.Replace("[*1;30,2*]", text2.Substring(30));
			}
			else
			{
				text3 = text3.Replace("[*1;30,1*]", text2);
				text3 = text3.Replace("[*1;30,2*]", "");
			}
			if (text2.Length > 15)
			{
				text3 = text3.Replace("[*1;15,1*]", text2.Substring(0, 15));
				text3 = text3.Replace("[*1;15,2*]", text2.Substring(15));
			}
			else
			{
				text3 = text3.Replace("[*1;15,1*]", text2);
				text3 = text3.Replace("[*1;15,2*]", "");
			}
			text3 = text3.Replace("[*37*]", newValue13);
			text3 = text3.Replace("[*38*]", newValue14);
			text3 = text3.Replace("[*39*]", newValue15);
			text3 = text3.Replace("[*40*]", newValue16);
			text3 = text3.Replace("[*59*]", newValue17);
			text3 = text3.Replace("[*60*]", newValue18);
			text3 = text3.Replace("[*61*]", newValue19);
			text3 = text3.Replace("[*62*]", newValue20);
			text3 = text3.Replace("[*41*]", newValue21);
			text3 = text3.Replace("[*42*]", newValue22);
			text3 = text3.Replace("[*43*]", newValue23);
			text3 = text3.Replace("[*44*]", newValue24);
			text3 = text3.Replace("[*63*]", newValue25);
			text3 = text3.Replace("[*64*]", newValue26);
			text3 = text3.Replace("[*65*]", newValue27);
			text3 = text3.Replace("[*66*]", newValue28);
			text3 = text3.Replace("[*4207*]", newValue29);
			text3 = text3.Replace("[*1001*]", strBelgeNo);
			text3 = text3.Replace("[*1003*]", text);
			text3 = text3.Replace("[*4100*]", newValue);
			text3 = text3.Replace("[*4102*]", newValue30);
			if (rowSeri != null)
			{
				text3 = text3.Replace("[*4431*]", rowSeri["SERI_NO"].ToString());
				text3 = text3.Replace("[*4432*]", rowSeri["ACIK1"].ToString());
			}
			if (Program.strPrinter == "ZEBRA")
			{
				text3 = text3.Replace("\\", "\\\\");
			}
			streamWriter.WriteLine(text3);
		}
		streamWriter.Close();
		return true;
	}

	private void btnHepsi_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < dtKalemler.Rows.Count; i++)
		{
			dtKalemler.Rows[i]["SEC"] = true;
			dtKalemler.Rows[i].AcceptChanges();
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < dtKalemler.Rows.Count; i++)
		{
			dtKalemler.Rows[i]["SEC"] = false;
			dtKalemler.Rows[i].AcceptChanges();
		}
	}

	private void chkBasimMiktari_CheckedChanged(object sender, EventArgs e)
	{
		if (chkBasimMiktari.get_Checked())
		{
			for (int i = 0; i < dtKalemler.Rows.Count; i++)
			{
				if (Convert.ToBoolean(dtKalemler.Rows[i]["SEC"]))
				{
					dtKalemler.Rows[i]["BASIM MIKTARI"] = Convert.ToInt32(dtKalemler.Rows[i]["MIKTARI"]);
					dtKalemler.Rows[i].AcceptChanges();
				}
			}
		}
		else
		{
			for (int j = 0; j < dtKalemler.Rows.Count; j++)
			{
				dtKalemler.Rows[j]["BASIM MIKTARI"] = 1;
				dtKalemler.Rows[j].AcceptChanges();
			}
		}
	}
}
