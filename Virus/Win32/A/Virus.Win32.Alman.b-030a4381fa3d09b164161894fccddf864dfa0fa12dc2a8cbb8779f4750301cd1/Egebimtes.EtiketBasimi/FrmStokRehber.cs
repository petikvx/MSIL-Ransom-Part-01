using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Egebimtes.EtiketBasimi;

public class FrmStokRehber : Form
{
	private IContainer components;

	private GroupBox gbListe;

	private DataGridView dgvListe;

	private GroupBox gbArama;

	private Button btnSec;

	private Button btnAra;

	private TextBox txtStokAdi;

	private TextBox txtStokKodu;

	private Label lblCariAd;

	private Label lblStokKod;

	private DBConn VTIslemleri;

	private FrmStok frmStok;

	private DataTable dtRehber;

	private StokKoduTipi stokKoduTipi;

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
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		gbListe = new GroupBox();
		dgvListe = new DataGridView();
		gbArama = new GroupBox();
		btnSec = new Button();
		btnAra = new Button();
		txtStokAdi = new TextBox();
		txtStokKodu = new TextBox();
		lblCariAd = new Label();
		lblStokKod = new Label();
		((Control)gbListe).SuspendLayout();
		((ISupportInitialize)dgvListe).BeginInit();
		((Control)gbArama).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)gbListe).get_Controls().Add((Control)(object)dgvListe);
		((Control)gbListe).set_Location(new Point(257, 12));
		((Control)gbListe).set_Name("gbListe");
		((Control)gbListe).set_Size(new Size(430, 336));
		((Control)gbListe).set_TabIndex(3);
		gbListe.set_TabStop(false);
		dgvListe.set_AllowUserToAddRows(false);
		dgvListe.set_AllowUserToDeleteRows(false);
		dgvListe.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		dgvListe.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dgvListe).set_Dock((DockStyle)5);
		((Control)dgvListe).set_Location(new Point(3, 16));
		((Control)dgvListe).set_Name("dgvListe");
		((Control)dgvListe).set_Size(new Size(424, 317));
		((Control)dgvListe).set_TabIndex(0);
		dgvListe.add_CellDoubleClick(new DataGridViewCellEventHandler(dgvListe_CellDoubleClick));
		((Control)gbArama).get_Controls().Add((Control)(object)btnSec);
		((Control)gbArama).get_Controls().Add((Control)(object)btnAra);
		((Control)gbArama).get_Controls().Add((Control)(object)txtStokAdi);
		((Control)gbArama).get_Controls().Add((Control)(object)txtStokKodu);
		((Control)gbArama).get_Controls().Add((Control)(object)lblCariAd);
		((Control)gbArama).get_Controls().Add((Control)(object)lblStokKod);
		((Control)gbArama).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)gbArama).set_Location(new Point(12, 12));
		((Control)gbArama).set_Name("gbArama");
		((Control)gbArama).set_Size(new Size(228, 336));
		((Control)gbArama).set_TabIndex(2);
		gbArama.set_TabStop(false);
		((Control)gbArama).set_Text("Arama");
		((Control)btnSec).set_Location(new Point(145, 144));
		((Control)btnSec).set_Name("btnSec");
		((Control)btnSec).set_Size(new Size(75, 23));
		((Control)btnSec).set_TabIndex(9);
		((Control)btnSec).set_Text("Seç");
		((ButtonBase)btnSec).set_UseVisualStyleBackColor(true);
		((Control)btnSec).add_Click((EventHandler)btnSec_Click);
		((Control)btnAra).set_Location(new Point(145, 103));
		((Control)btnAra).set_Name("btnAra");
		((Control)btnAra).set_Size(new Size(75, 23));
		((Control)btnAra).set_TabIndex(8);
		((Control)btnAra).set_Text("Ara");
		((ButtonBase)btnAra).set_UseVisualStyleBackColor(true);
		((Control)btnAra).add_Click((EventHandler)btnAra_Click);
		((Control)txtStokAdi).set_Location(new Point(100, 61));
		((Control)txtStokAdi).set_Name("txtStokAdi");
		((Control)txtStokAdi).set_Size(new Size(120, 20));
		((Control)txtStokAdi).set_TabIndex(7);
		((Control)txtStokKodu).set_Location(new Point(100, 32));
		((Control)txtStokKodu).set_Name("txtStokKodu");
		((Control)txtStokKodu).set_Size(new Size(120, 20));
		((Control)txtStokKodu).set_TabIndex(6);
		((Control)lblCariAd).set_AutoSize(true);
		((Control)lblCariAd).set_Location(new Point(8, 65));
		((Control)lblCariAd).set_Name("lblCariAd");
		((Control)lblCariAd).set_Size(new Size(55, 13));
		((Control)lblCariAd).set_TabIndex(2);
		((Control)lblCariAd).set_Text("Stok Adı");
		((Control)lblStokKod).set_AutoSize(true);
		((Control)lblStokKod).set_Location(new Point(8, 35));
		((Control)lblStokKod).set_Name("lblStokKod");
		((Control)lblStokKod).set_Size(new Size(66, 13));
		((Control)lblStokKod).set_TabIndex(1);
		((Control)lblStokKod).set_Text("Stok Kodu");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(699, 363));
		((Control)this).get_Controls().Add((Control)(object)gbListe);
		((Control)this).get_Controls().Add((Control)(object)gbArama);
		((Control)this).set_Name("FrmStokRehber");
		((Control)this).set_Text("Stok Rehberi");
		((Control)gbListe).ResumeLayout(false);
		((ISupportInitialize)dgvListe).EndInit();
		((Control)gbArama).ResumeLayout(false);
		((Control)gbArama).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public FrmStokRehber(FrmStok frmGelen, StokKoduTipi tip)
	{
		InitializeComponent();
		frmStok = frmGelen;
		stokKoduTipi = tip;
		VTIslemleri = new DBConn();
		dtRehber = new DataTable();
	}

	private void btnAra_Click(object sender, EventArgs e)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		dtRehber.Clear();
		((Control)dgvListe).Refresh();
		try
		{
			dtRehber = VTIslemleri.StoklariGetir(((Control)txtStokKodu).get_Text(), ((Control)txtStokAdi).get_Text());
			if (dtRehber != null && dtRehber.Rows.Count != 0)
			{
				dgvListe.set_DataSource((object)dtRehber);
			}
			else
			{
				MessageBox.Show("Verilen kısıtlara uygun kayıt bulunamadı.");
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("Stoklar listelenirken bir hata oluştu.\nHata mesajı : " + ex.Message);
		}
	}

	private void btnSec_Click(object sender, EventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (dgvListe.get_CurrentRow() == null)
		{
			MessageBox.Show("Lütfen bir stok kartı seçiniz.", "Hata", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return;
		}
		frmStok.SetStokKodu(dgvListe.get_CurrentRow().get_Cells().get_Item("STOK KODU")
			.get_Value()
			.ToString(), stokKoduTipi);
		((Form)this).Close();
	}

	private void dgvListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		btnSec_Click(this, (EventArgs)(object)e);
	}
}
