using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Egebimtes.EtiketBasimi;

public class FormRehber : Form
{
	private DBConn VTIslemleri;

	private GForm0 frmEtiket;

	private string strBelgeTipi;

	private DataTable dtRehber;

	private IContainer components;

	private GroupBox gbArama;

	private GroupBox gbListe;

	private DateTimePicker dpTarih;

	private Label Tarih;

	private Label lblCariAd;

	private Label lblCariKod;

	private Label lblBelgeNo;

	private Button btnSec;

	private Button btnAra;

	private TextBox tbCariAd;

	private TextBox tbCariKodu;

	private TextBox tbBelgeNo;

	private DataGridView dgvListe;

	private CheckBox cbTarih;

	public extern FormRehber(GForm0 frmGelen, string strBelgeTipiGelen);

	private extern void FormRehber_Load(object sender, EventArgs e);

	private void SayfaDuzenleme()
	{
		//Discarded unreachable code: IL_000e, IL_0015, IL_0016, IL_0018, IL_001b, IL_001c, IL_001d, IL_0023, IL_0029, IL_002e, IL_0033, IL_003b, IL_003d
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_000a: Expected O, but got I8
		//IL_003b: Incompatible stack heights: 1 vs 0
		sbyte num2;
		do
		{
			sbyte num = ((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			num2 = ((sbyte[])/*Error near IL_0002: Stack underflow*/)[num];
		}
		while ((int)/*Error near IL_0007: Stack underflow*/ != num2);
		checked
		{
			_ = (long)/*Error near IL_0008: Stack underflow*/;
			/*Error near IL_0009: Invalid metadata token*/;
		}
	}

	private void btnAra_Click(object sender, EventArgs e)
	{
	}

	private extern void cbTarih_CheckedChanged(object sender, EventArgs e);

	private extern void btnSec_Click(object sender, EventArgs e);

	private extern void dgvListe_CellContentClick(object sender, DataGridViewCellEventArgs e);

	protected override extern void Dispose(bool disposing);

	private extern void InitializeComponent();
}
