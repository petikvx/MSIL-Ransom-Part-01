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

public class FrmStok : Form
{
	private IContainer components;

	private Label lblBasla;

	private Label lblBitis;

	private Label lblStokKodu;

	private TextBox txtStokKoduBasla;

	private TextBox txtStokKoduBitis;

	private GroupBox gbRehber;

	private GroupBox gbStokKoduListe;

	private DataGridView dgvStokKartiListe;

	private Button btnStokKoduBitisRehber;

	private Button btnStokKoduBaslaRehber;

	private Button btnTemizle;

	private Button btnYazdir;

	private Button btnListele;

	private DBConn vtIslemleri;

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
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		lblBasla = new Label();
		lblBitis = new Label();
		lblStokKodu = new Label();
		txtStokKoduBasla = new TextBox();
		txtStokKoduBitis = new TextBox();
		gbRehber = new GroupBox();
		btnTemizle = new Button();
		btnYazdir = new Button();
		btnListele = new Button();
		btnStokKoduBitisRehber = new Button();
		btnStokKoduBaslaRehber = new Button();
		gbStokKoduListe = new GroupBox();
		dgvStokKartiListe = new DataGridView();
		((Control)gbRehber).SuspendLayout();
		((Control)gbStokKoduListe).SuspendLayout();
		((ISupportInitialize)dgvStokKartiListe).BeginInit();
		((Control)this).SuspendLayout();
		((Control)lblBasla).set_AutoSize(true);
		((Control)lblBasla).set_Location(new Point(197, 27));
		((Control)lblBasla).set_Name("lblBasla");
		((Control)lblBasla).set_Size(new Size(53, 13));
		((Control)lblBasla).set_TabIndex(0);
		((Control)lblBasla).set_Text("Başlangıç");
		((Control)lblBitis).set_AutoSize(true);
		((Control)lblBitis).set_Location(new Point(445, 27));
		((Control)lblBitis).set_Name("lblBitis");
		((Control)lblBitis).set_Size(new Size(26, 13));
		((Control)lblBitis).set_TabIndex(1);
		((Control)lblBitis).set_Text("Bitiş");
		((Control)lblStokKodu).set_AutoSize(true);
		((Control)lblStokKodu).set_Location(new Point(73, 67));
		((Control)lblStokKodu).set_Name("lblStokKodu");
		((Control)lblStokKodu).set_Size(new Size(57, 13));
		((Control)lblStokKodu).set_TabIndex(2);
		((Control)lblStokKodu).set_Text("Stok Kodu");
		((Control)txtStokKoduBasla).set_Location(new Point(151, 60));
		((Control)txtStokKoduBasla).set_Name("txtStokKoduBasla");
		((Control)txtStokKoduBasla).set_Size(new Size(182, 20));
		((Control)txtStokKoduBasla).set_TabIndex(5);
		((Control)txtStokKoduBitis).set_Location(new Point(448, 60));
		((Control)txtStokKoduBitis).set_Name("txtStokKoduBitis");
		((Control)txtStokKoduBitis).set_Size(new Size(162, 20));
		((Control)txtStokKoduBitis).set_TabIndex(6);
		((Control)gbRehber).get_Controls().Add((Control)(object)btnTemizle);
		((Control)gbRehber).get_Controls().Add((Control)(object)btnYazdir);
		((Control)gbRehber).get_Controls().Add((Control)(object)btnListele);
		((Control)gbRehber).get_Controls().Add((Control)(object)btnStokKoduBitisRehber);
		((Control)gbRehber).get_Controls().Add((Control)(object)btnStokKoduBaslaRehber);
		((Control)gbRehber).get_Controls().Add((Control)(object)txtStokKoduBasla);
		((Control)gbRehber).get_Controls().Add((Control)(object)lblBasla);
		((Control)gbRehber).get_Controls().Add((Control)(object)lblBitis);
		((Control)gbRehber).get_Controls().Add((Control)(object)lblStokKodu);
		((Control)gbRehber).get_Controls().Add((Control)(object)txtStokKoduBitis);
		((Control)gbRehber).set_Location(new Point(12, 23));
		((Control)gbRehber).set_Name("gbRehber");
		((Control)gbRehber).set_Size(new Size(761, 173));
		((Control)gbRehber).set_TabIndex(11);
		gbRehber.set_TabStop(false);
		((Control)gbRehber).set_Text("Stok Kodu Rehberi");
		((Control)btnTemizle).set_Location(new Point(542, 116));
		((Control)btnTemizle).set_Name("btnTemizle");
		((Control)btnTemizle).set_Size(new Size(103, 32));
		((Control)btnTemizle).set_TabIndex(19);
		((Control)btnTemizle).set_Text("Temizle");
		((ButtonBase)btnTemizle).set_UseVisualStyleBackColor(true);
		((Control)btnTemizle).add_Click((EventHandler)btnTemizle_Click);
		((Control)btnYazdir).set_Location(new Point(343, 116));
		((Control)btnYazdir).set_Name("btnYazdir");
		((Control)btnYazdir).set_Size(new Size(103, 32));
		((Control)btnYazdir).set_TabIndex(18);
		((Control)btnYazdir).set_Text("Yazdır");
		((ButtonBase)btnYazdir).set_UseVisualStyleBackColor(true);
		((Control)btnYazdir).add_Click((EventHandler)btnYazdir_Click);
		((Control)btnListele).set_Location(new Point(151, 116));
		((Control)btnListele).set_Name("btnListele");
		((Control)btnListele).set_Size(new Size(103, 32));
		((Control)btnListele).set_TabIndex(17);
		((Control)btnListele).set_Text("Listele");
		((ButtonBase)btnListele).set_UseVisualStyleBackColor(true);
		((Control)btnListele).add_Click((EventHandler)btnListele_Click);
		((Control)btnStokKoduBitisRehber).set_Location(new Point(616, 58));
		((Control)btnStokKoduBitisRehber).set_Name("btnStokKoduBitisRehber");
		((Control)btnStokKoduBitisRehber).set_Size(new Size(29, 23));
		((Control)btnStokKoduBitisRehber).set_TabIndex(14);
		((Control)btnStokKoduBitisRehber).set_Text("R");
		((ButtonBase)btnStokKoduBitisRehber).set_UseVisualStyleBackColor(true);
		((Control)btnStokKoduBitisRehber).add_Click((EventHandler)btnStokKoduBitisRehber_Click);
		((Control)btnStokKoduBaslaRehber).set_Location(new Point(343, 60));
		((Control)btnStokKoduBaslaRehber).set_Name("btnStokKoduBaslaRehber");
		((Control)btnStokKoduBaslaRehber).set_Size(new Size(29, 23));
		((Control)btnStokKoduBaslaRehber).set_TabIndex(11);
		((Control)btnStokKoduBaslaRehber).set_Text("R");
		((ButtonBase)btnStokKoduBaslaRehber).set_UseVisualStyleBackColor(true);
		((Control)btnStokKoduBaslaRehber).add_Click((EventHandler)btnStokKoduBaslaRehber_Click);
		((Control)gbStokKoduListe).get_Controls().Add((Control)(object)dgvStokKartiListe);
		((Control)gbStokKoduListe).set_Location(new Point(12, 202));
		((Control)gbStokKoduListe).set_Name("gbStokKoduListe");
		((Control)gbStokKoduListe).set_Size(new Size(761, 309));
		((Control)gbStokKoduListe).set_TabIndex(12);
		gbStokKoduListe.set_TabStop(false);
		((Control)gbStokKoduListe).set_Text("Stok Listesi");
		dgvStokKartiListe.set_AllowUserToAddRows(false);
		dgvStokKartiListe.set_AllowUserToDeleteRows(false);
		dgvStokKartiListe.set_AllowUserToOrderColumns(true);
		dgvStokKartiListe.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		dgvStokKartiListe.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dgvStokKartiListe).set_Dock((DockStyle)5);
		((Control)dgvStokKartiListe).set_Location(new Point(3, 16));
		((Control)dgvStokKartiListe).set_Name("dgvStokKartiListe");
		((Control)dgvStokKartiListe).set_Size(new Size(755, 290));
		((Control)dgvStokKartiListe).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(785, 523));
		((Control)this).get_Controls().Add((Control)(object)gbStokKoduListe);
		((Control)this).get_Controls().Add((Control)(object)gbRehber);
		((Control)this).set_Name("FrmStok");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Stok Kartı Formu");
		((Control)gbRehber).ResumeLayout(false);
		((Control)gbRehber).PerformLayout();
		((Control)gbStokKoduListe).ResumeLayout(false);
		((ISupportInitialize)dgvStokKartiListe).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public FrmStok()
	{
		InitializeComponent();
		vtIslemleri = new DBConn();
	}

	private void btnListele_Click(object sender, EventArgs e)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			dgvStokKartiListe.set_DataSource((object)vtIslemleri.StokKartListele(((Control)txtStokKoduBasla).get_Text(), ((Control)txtStokKoduBitis).get_Text(), string.Empty, string.Empty, string.Empty, string.Empty));
		}
		catch (Exception ex)
		{
			MessageBox.Show("Stok kartları listelenirken bir hata oluştu.\nHata mesajı : " + ex.Message, "Hata", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void btnTemizle_Click(object sender, EventArgs e)
	{
		dgvStokKartiListe.set_DataSource((object)null);
		((Control)txtStokKoduBasla).set_Text("");
		((Control)txtStokKoduBitis).set_Text("");
	}

	private void btnStokKoduBaslaRehber_Click(object sender, EventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		FrmStokRehber frmStokRehber = new FrmStokRehber(this, StokKoduTipi.Baslangic);
		((Form)frmStokRehber).ShowDialog();
	}

	private void btnStokKoduBitisRehber_Click(object sender, EventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		FrmStokRehber frmStokRehber = new FrmStokRehber(this, StokKoduTipi.Bitis);
		((Form)frmStokRehber).ShowDialog();
	}

	private void btnYazdir_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_Title("Etiket basımı için dizayn dosyası seçin");
		((FileDialog)val).set_Filter("Printer Output files (*.prn)|*.prn|Text files (*.txt)|*.txt");
		val.set_Multiselect(false);
		if ((int)((CommonDialog)val).ShowDialog() == 2)
		{
			MessageBox.Show("Etiket dizaynı seçilmeden basım yapılamaz.", "Etiket Basım");
			return;
		}
		Program.strSablonDosya = ((FileDialog)val).get_FileName();
		try
		{
			foreach (DataGridViewRow item in (IEnumerable)dgvStokKartiListe.get_Rows())
			{
				DataGridViewRow val2 = item;
				if ((bool)val2.get_Cells().get_Item("SEC").get_Value())
				{
					DataTable dataTable = vtIslemleri.StokBilgiOku(val2.get_Cells().get_Item("STOK KODU").get_Value()
						.ToString());
					if (dataTable == null || dataTable.Rows.Count == 0)
					{
						MessageBox.Show("Stok kaydı bulunamadı.", "Hata", (MessageBoxButtons)0);
						break;
					}
					EtiketYazdir(dataTable, (int)val2.get_Cells().get_Item("BASIM MIKTARI").get_Value());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("Etiketler yazdirilirken bir hata oluştu.\nHata mesajı : " + ex.Message, "Hata", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void EtiketYazdir(DataTable dtStokBilgi, int intBasimMiktari)
	{
		DosyaDuzelt(Program.strSablonDosya, dtStokBilgi.Rows[0]);
		for (int i = 0; i < intBasimMiktari; i++)
		{
			string arguments = "/C print ETIKETTMP.txt /d:" + Program.strPort;
			Process process = new Process();
			process.EnableRaisingEvents = false;
			Process.Start("CMD.exe", arguments);
			Thread.Sleep(1000);
			process.Close();
		}
	}

	private void DosyaDuzelt(string strDosya, DataRow rowStok)
	{
		StreamReader streamReader = new StreamReader(strDosya, Encoding.Default);
		StreamWriter streamWriter = new StreamWriter("ETIKETTMP.txt", append: false, Encoding.Default);
		string text = "";
		while (streamReader.Peek() >= 0)
		{
			string text2 = streamReader.ReadLine();
			text = text2;
			string newValue = rowStok["STOK_KODU"].ToString();
			string text3 = rowStok["STOK_ADI"].ToString();
			string newValue2 = Convert.ToDecimal(rowStok["PAY_1"]).ToString("#,##0.00");
			string newValue3 = Convert.ToDecimal(rowStok["PAYDA_1"]).ToString("#,##0.00");
			string newValue4 = Convert.ToDecimal(rowStok["PAY2"]).ToString("#,##0.00");
			string newValue5 = Convert.ToDecimal(rowStok["PAYDA2"]).ToString("#,##0.00");
			string newValue6 = rowStok["OLCU_BR1"].ToString();
			string newValue7 = rowStok["OLCU_BR2"].ToString();
			string newValue8 = rowStok["OLCU_BR3"].ToString();
			rowStok["GRUP_KODU"].ToString();
			string newValue9 = rowStok["SATIS_FIAT1"].ToString();
			string newValue10 = rowStok["SATIS_FIAT2"].ToString();
			string newValue11 = rowStok["SATIS_FIAT3"].ToString();
			string newValue12 = rowStok["SATIS_FIAT4"].ToString();
			string newValue13 = rowStok["KULL1S"].ToString();
			string newValue14 = rowStok["KULL2S"].ToString();
			string newValue15 = rowStok["KULL3S"].ToString();
			string newValue16 = rowStok["KULL4S"].ToString();
			string newValue17 = rowStok["KULL5S"].ToString();
			string newValue18 = rowStok["KULL6S"].ToString();
			string newValue19 = rowStok["KULL7S"].ToString();
			string newValue20 = rowStok["KULL8S"].ToString();
			string newValue21 = rowStok["KULL1N"].ToString();
			string newValue22 = rowStok["KULL2N"].ToString();
			string newValue23 = rowStok["KULL3N"].ToString();
			string newValue24 = rowStok["KULL4N"].ToString();
			string newValue25 = rowStok["KULL5N"].ToString();
			string newValue26 = rowStok["KULL6N"].ToString();
			string newValue27 = rowStok["KULL7N"].ToString();
			string newValue28 = rowStok["KULL8N"].ToString();
			string newValue29 = rowStok["INGISIM"].ToString();
			text = text2.Replace("[*0*]", newValue);
			text = text.Replace("[*1*]", text3);
			text = text.Replace("[*20*]", newValue9);
			text = text.Replace("[*21*]", newValue10);
			text = text.Replace("[*22*]", newValue11);
			text = text.Replace("[*23*]", newValue12);
			text = text.Replace("[*6*]", newValue6);
			text = text.Replace("[*7*]", newValue7);
			text = text.Replace("[*8*]", newValue2);
			text = text.Replace("[*9*]", newValue3);
			text = text.Replace("[*10*]", newValue8);
			text = text.Replace("[*11*]", newValue4);
			text = text.Replace("[*12*]", newValue5);
			if (text3.Length > 30)
			{
				text = text.Replace("[*1;30,1*]", text3.Substring(0, 30));
				text = text.Replace("[*1;30,2*]", text3.Substring(30));
			}
			else
			{
				text = text.Replace("[*1;30,1*]", text3);
				text = text.Replace("[*1;30,2*]", "");
			}
			if (text3.Length > 15)
			{
				text = text.Replace("[*1;15,1*]", text3.Substring(0, 15));
				text = text.Replace("[*1;15,2*]", text3.Substring(15));
			}
			else
			{
				text = text.Replace("[*1;15,1*]", text3);
				text = text.Replace("[*1;15,2*]", "");
			}
			text = text.Replace("[*37*]", newValue13);
			text = text.Replace("[*38*]", newValue14);
			text = text.Replace("[*39*]", newValue15);
			text = text.Replace("[*40*]", newValue16);
			text = text.Replace("[*59*]", newValue17);
			text = text.Replace("[*60*]", newValue18);
			text = text.Replace("[*61*]", newValue19);
			text = text.Replace("[*62*]", newValue20);
			text = text.Replace("[*41*]", newValue21);
			text = text.Replace("[*42*]", newValue22);
			text = text.Replace("[*43*]", newValue23);
			text = text.Replace("[*44*]", newValue24);
			text = text.Replace("[*63*]", newValue25);
			text = text.Replace("[*64*]", newValue26);
			text = text.Replace("[*65*]", newValue27);
			text = text.Replace("[*66*]", newValue28);
			text = text.Replace("[*4207*]", newValue29);
			if (Program.strPrinter == "ZEBRA")
			{
				text = text.Replace("\\", "\\\\");
			}
			streamWriter.WriteLine(text);
		}
		streamWriter.Close();
		streamReader.Close();
	}

	public void SetStokKodu(string strStokKodu, StokKoduTipi tip)
	{
		switch (tip)
		{
		case StokKoduTipi.Baslangic:
			((Control)txtStokKoduBasla).set_Text(strStokKodu);
			break;
		case StokKoduTipi.Bitis:
			((Control)txtStokKoduBitis).set_Text(strStokKodu);
			break;
		}
	}
}
