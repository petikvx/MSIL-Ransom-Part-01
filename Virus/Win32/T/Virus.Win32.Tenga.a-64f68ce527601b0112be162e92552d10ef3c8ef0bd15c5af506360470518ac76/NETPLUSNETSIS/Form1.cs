using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using DtkNetSDK;
using INI;
using NetOpenX40;

namespace NETPLUSNETSIS;

public class Form1 : Form
{
	private IContainer components = null;

	private GroupBox groupBox2;

	private GroupBox groupBox3;

	private ProgressBar PG;

	private Label label1;

	private RichTextBox edtInfo;

	private Panel panel1;

	private Panel panel2;

	private Panel panel3;

	private Button button2;

	private Button button1;

	private Label label7;

	private TextBox textBox4;

	private Label label6;

	private TextBox textBox3;

	private Label label5;

	private TextBox textBox2;

	private Label label4;

	private TextBox textBox1;

	private Label label8;

	private TextBox textBox5;

	private Label label9;

	private TextBox textBox6;

	private Label label10;

	private TextBox textBox7;

	private Label label11;

	private TextBox textBox8;

	private string constr = "";

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
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0f: Expected O, but got Unknown
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d49: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		groupBox2 = new GroupBox();
		label7 = new Label();
		textBox4 = new TextBox();
		label6 = new Label();
		textBox3 = new TextBox();
		label5 = new Label();
		textBox2 = new TextBox();
		label4 = new Label();
		textBox1 = new TextBox();
		groupBox3 = new GroupBox();
		label8 = new Label();
		textBox5 = new TextBox();
		label9 = new Label();
		textBox6 = new TextBox();
		label10 = new Label();
		textBox7 = new TextBox();
		label11 = new Label();
		textBox8 = new TextBox();
		PG = new ProgressBar();
		label1 = new Label();
		edtInfo = new RichTextBox();
		panel1 = new Panel();
		panel2 = new Panel();
		panel3 = new Panel();
		button2 = new Button();
		button1 = new Button();
		((Control)groupBox2).SuspendLayout();
		((Control)groupBox3).SuspendLayout();
		((Control)panel1).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((Control)panel3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)groupBox2).get_Controls().Add((Control)(object)label7);
		((Control)groupBox2).get_Controls().Add((Control)(object)textBox4);
		((Control)groupBox2).get_Controls().Add((Control)(object)label6);
		((Control)groupBox2).get_Controls().Add((Control)(object)textBox3);
		((Control)groupBox2).get_Controls().Add((Control)(object)label5);
		((Control)groupBox2).get_Controls().Add((Control)(object)textBox2);
		((Control)groupBox2).get_Controls().Add((Control)(object)label4);
		((Control)groupBox2).get_Controls().Add((Control)(object)textBox1);
		((Control)groupBox2).set_Location(new Point(0, 3));
		((Control)groupBox2).set_Name("groupBox2");
		((Control)groupBox2).set_Size(new Size(234, 122));
		((Control)groupBox2).set_TabIndex(1);
		groupBox2.set_TabStop(false);
		((Control)groupBox2).set_Text("Datakod");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Location(new Point(9, 97));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(31, 13));
		((Control)label7).set_TabIndex(13);
		((Control)label7).set_Text("Şifre:");
		((Control)textBox4).set_Location(new Point(75, 94));
		((Control)textBox4).set_Name("textBox4");
		textBox4.set_PasswordChar('*');
		((Control)textBox4).set_Size(new Size(133, 20));
		((Control)textBox4).set_TabIndex(12);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(9, 71));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(49, 13));
		((Control)label6).set_TabIndex(11);
		((Control)label6).set_Text("Kullanıcı:");
		((Control)textBox3).set_Location(new Point(75, 68));
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(133, 20));
		((Control)textBox3).set_TabIndex(10);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(9, 45));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(35, 13));
		((Control)label5).set_TabIndex(9);
		((Control)label5).set_Text("Şube:");
		((Control)textBox2).set_Location(new Point(75, 42));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(38, 20));
		((Control)textBox2).set_TabIndex(8);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(9, 19));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(37, 13));
		((Control)label4).set_TabIndex(7);
		((Control)label4).set_Text("Şirket:");
		((Control)textBox1).set_Location(new Point(75, 16));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(133, 20));
		((Control)textBox1).set_TabIndex(0);
		((Control)groupBox3).get_Controls().Add((Control)(object)label8);
		((Control)groupBox3).get_Controls().Add((Control)(object)textBox5);
		((Control)groupBox3).get_Controls().Add((Control)(object)label9);
		((Control)groupBox3).get_Controls().Add((Control)(object)textBox6);
		((Control)groupBox3).get_Controls().Add((Control)(object)label10);
		((Control)groupBox3).get_Controls().Add((Control)(object)textBox7);
		((Control)groupBox3).get_Controls().Add((Control)(object)label11);
		((Control)groupBox3).get_Controls().Add((Control)(object)textBox8);
		((Control)groupBox3).set_Location(new Point(240, 3));
		((Control)groupBox3).set_Name("groupBox3");
		((Control)groupBox3).set_Size(new Size(234, 122));
		((Control)groupBox3).set_TabIndex(2);
		groupBox3.set_TabStop(false);
		((Control)groupBox3).set_Text("Netsis");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Location(new Point(18, 97));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(31, 13));
		((Control)label8).set_TabIndex(21);
		((Control)label8).set_Text("Şifre:");
		((Control)textBox5).set_Location(new Point(84, 94));
		((Control)textBox5).set_Name("textBox5");
		textBox5.set_PasswordChar('*');
		((Control)textBox5).set_Size(new Size(133, 20));
		((Control)textBox5).set_TabIndex(20);
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Location(new Point(18, 71));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(49, 13));
		((Control)label9).set_TabIndex(19);
		((Control)label9).set_Text("Kullanıcı:");
		((Control)textBox6).set_Location(new Point(84, 68));
		((Control)textBox6).set_Name("textBox6");
		((Control)textBox6).set_Size(new Size(133, 20));
		((Control)textBox6).set_TabIndex(18);
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Location(new Point(18, 45));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(35, 13));
		((Control)label10).set_TabIndex(17);
		((Control)label10).set_Text("Şube:");
		((Control)textBox7).set_Location(new Point(84, 42));
		((Control)textBox7).set_Name("textBox7");
		((Control)textBox7).set_Size(new Size(38, 20));
		((Control)textBox7).set_TabIndex(16);
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_Location(new Point(18, 19));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(37, 13));
		((Control)label11).set_TabIndex(15);
		((Control)label11).set_Text("Şirket:");
		((Control)textBox8).set_Location(new Point(84, 16));
		((Control)textBox8).set_Name("textBox8");
		((Control)textBox8).set_Size(new Size(133, 20));
		((Control)textBox8).set_TabIndex(14);
		((Control)PG).set_Location(new Point(13, 32));
		((Control)PG).set_Name("PG");
		((Control)PG).set_Size(new Size(458, 23));
		((Control)PG).set_TabIndex(0);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(10, 14));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(40, 13));
		((Control)label1).set_TabIndex(5);
		((Control)label1).set_Text("Hazır...");
		((Control)edtInfo).set_BackColor(SystemColors.Control);
		((TextBoxBase)edtInfo).set_BorderStyle((BorderStyle)0);
		((Control)edtInfo).set_Location(new Point(13, 61));
		((Control)edtInfo).set_Name("edtInfo");
		((Control)edtInfo).set_Size(new Size(458, 181));
		((Control)edtInfo).set_TabIndex(7);
		((Control)edtInfo).set_Text("");
		((Control)panel1).get_Controls().Add((Control)(object)groupBox2);
		((Control)panel1).get_Controls().Add((Control)(object)groupBox3);
		((Control)panel1).set_Dock((DockStyle)1);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(486, 133));
		((Control)panel1).set_TabIndex(8);
		((Control)panel2).get_Controls().Add((Control)(object)PG);
		((Control)panel2).get_Controls().Add((Control)(object)label1);
		((Control)panel2).get_Controls().Add((Control)(object)edtInfo);
		((Control)panel2).set_Dock((DockStyle)5);
		((Control)panel2).set_Location(new Point(0, 133));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(486, 294));
		((Control)panel2).set_TabIndex(9);
		((Control)panel3).get_Controls().Add((Control)(object)button2);
		((Control)panel3).get_Controls().Add((Control)(object)button1);
		((Control)panel3).set_Dock((DockStyle)2);
		((Control)panel3).set_Location(new Point(0, 381));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(486, 46));
		((Control)panel3).set_TabIndex(10);
		((Control)button2).set_Location(new Point(15, 11));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 23));
		((Control)button2).set_TabIndex(1);
		((Control)button2).set_Text("Aktar");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button1).set_Location(new Point(396, 11));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Kapat");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(486, 427));
		((Control)this).get_Controls().Add((Control)(object)panel3);
		((Control)this).get_Controls().Add((Control)(object)panel2);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Datakod.Net Plus -> Netsis Veri Aktarım");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox2).PerformLayout();
		((Control)groupBox3).ResumeLayout(false);
		((Control)groupBox3).PerformLayout();
		((Control)panel1).ResumeLayout(false);
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((Control)panel3).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public Form1()
	{
		InitializeComponent();
	}

	private void KaydetParam()
	{
		IniFile iniFile = new IniFile(Application.get_StartupPath() + "\\CONFIG.INI");
		iniFile.IniWriteValue("DATAKOD", "SIRKET", ((Control)textBox1).get_Text());
		iniFile.IniWriteValue("DATAKOD", "SUBE", ((Control)textBox2).get_Text());
		iniFile.IniWriteValue("DATAKOD", "KULL", ((Control)textBox3).get_Text());
		iniFile.IniWriteValue("DATAKOD", "SIFRE", ((Control)textBox4).get_Text());
		iniFile.IniWriteValue("NETSIS", "SIRKET", ((Control)textBox8).get_Text());
		iniFile.IniWriteValue("NETSIS", "SUBE", ((Control)textBox7).get_Text());
		iniFile.IniWriteValue("NETSIS", "KULL", ((Control)textBox6).get_Text());
		iniFile.IniWriteValue("NETSIS", "SIFRE", ((Control)textBox5).get_Text());
		iniFile = null;
	}

	private void AlParam()
	{
		IniFile iniFile = new IniFile(Application.get_StartupPath() + "\\CONFIG.INI");
		((Control)textBox1).set_Text(iniFile.IniReadValue("DATAKOD", "SIRKET"));
		((Control)textBox2).set_Text(iniFile.IniReadValue("DATAKOD", "SUBE"));
		((Control)textBox3).set_Text(iniFile.IniReadValue("DATAKOD", "KULL"));
		((Control)textBox4).set_Text(iniFile.IniReadValue("DATAKOD", "SIFRE"));
		((Control)textBox8).set_Text(iniFile.IniReadValue("NETSIS", "SIRKET"));
		((Control)textBox7).set_Text(iniFile.IniReadValue("NETSIS", "SUBE"));
		((Control)textBox6).set_Text(iniFile.IniReadValue("NETSIS", "KULL"));
		((Control)textBox5).set_Text(iniFile.IniReadValue("NETSIS", "SIFRE"));
		constr = iniFile.IniReadValue("NETSIS", "SQLCON");
		iniFile = null;
	}

	public static string NullString(object val)
	{
		string text = "";
		text = ((val != null) ? val.ToString() : "");
		return text.Replace("'", "`");
	}

	private void yazBilgi(string pBilgi, Color pColor)
	{
		edtInfo.set_SelectionColor(pColor);
		((TextBoxBase)edtInfo).AppendText(pBilgi + Convert.ToChar(13) + Convert.ToChar(10));
		Application.DoEvents();
	}

	private void Aktar()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Invalid comparison between Unknown and I4
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_086e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected O, but got Unknown
		//IL_0f16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1d: Expected O, but got Unknown
		//IL_1373: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			yazBilgi("İşlem başlatıldı!", Color.Blue);
			TNetKernel val = new TNetKernel(true, true);
			TNetSirket val2 = val.yeniSirket(((Control)textBox1).get_Text(), Convert.ToInt32(((Control)textBox2).get_Text()), ((Control)textBox3).get_Text(), ((Control)textBox4).get_Text());
			yazBilgi("Datakod.Net Plus'a bağlanıldı...", Color.Blue);
			Kernel val3 = (Kernel)new KernelClass();
			Sirket val4 = (Sirket)new SirketClass();
			val4 = ((IKernel)val3).yeniSirket((TVTTipi)0, ((Control)textBox8).get_Text(), "TEMELSET", "", ((Control)textBox6).get_Text(), ((Control)textBox5).get_Text(), Convert.ToInt32(((Control)textBox7).get_Text()));
			if (val4 == null)
			{
				throw new Exception("Netsis bağlantısı kurulamadı!");
			}
			yazBilgi("Netsis'e bağlanıldı...", Color.Blue);
			OleDbConnection val5 = null;
			val5 = new OleDbConnection(constr);
			((DbConnection)(object)val5).Open();
			yazBilgi("Netsis SQL bağlanıldı...", Color.Blue);
			OleDbCommand val6 = new OleDbCommand("EXEC DATAKOD_NETPLUSFATURA_COUNT", val5);
			((DbCommand)(object)val6).CommandTimeout = 999999;
			OleDbDataReader val7 = val6.ExecuteReader();
			yazBilgi("Counting...", Color.Blue);
			if (((DbDataReader)(object)val7).Read())
			{
				PG.set_Value(0);
				PG.set_Maximum(Convert.ToInt32(((DbDataReader)(object)val7)["LN"]) + 5);
			}
			((DbDataReader)(object)val7).Close();
			((DbDataReader)(object)val7).Dispose();
			val7 = null;
			((Component)(object)val6).Dispose();
			val6 = null;
			val6 = new OleDbCommand("EXEC DATAKOD_NETPLUSFATURA", val5);
			((DbCommand)(object)val6).CommandTimeout = 999999;
			val7 = val6.ExecuteReader();
			while (((DbDataReader)(object)val7).Read())
			{
				if (NullString(((DbDataReader)(object)val7)["CARI_KODU"]) != "")
				{
					TCari val8 = new TCari(val2);
					if (!val8.Kayit_Ac(val2.get_BayiKod(), ((DbDataReader)(object)val7)["CARI_KODU"].ToString()))
					{
						NetRS val9 = ((IKernel)val3).yeniNetRS(val4);
						((INetRS)val9).Ac("SELECT * FROM TBLCASABIT   WHERE CARI_KOD = '" + ((DbDataReader)(object)val7)["CARI_KODU"].ToString() + "'");
						if (!((INetRS)val9).get_EOF())
						{
							val8.Kayit_Varsayilan();
							val8.set_CariKod(((INetField)((INetRS)val9).FieldByName("CARI_KOD")).get_AsString());
							val8.set_Unvan(NullString(((INetField)((INetRS)val9).FieldByName("CARI_ISIM")).get_AsString()));
							val8.set_Adres1(NullString(((INetField)((INetRS)val9).FieldByName("CARI_ADRES")).get_AsString()));
							val8.set_Ilce(NullString(((INetField)((INetRS)val9).FieldByName("CARI_ILCE")).get_AsString()));
							val8.set_Vd(NullString(((INetField)((INetRS)val9).FieldByName("VERGI_DAIRESI")).get_AsString()));
							val8.set_Vn(NullString(((INetField)((INetRS)val9).FieldByName("VERGI_NUMARASI")).get_AsString()));
							val8.set_Grup1Kod("001");
							val8.set_IlKod(NullString(((INetRS)val9).FieldByName("RAPOR_KODU1")).Substring(0, 2));
							val8.set_IsAktif(true);
							val8.Kayit_Ekle(false);
						}
					}
				}
				TBelge val10 = val2.yeniBelge();
				if (((DbDataReader)(object)val7)["FTIRSIP"].ToString() == "1")
				{
					val10.set_FisBelgeTip((TFisBelgeTip)2);
					val10.set_FisBelgeTur((TFisBelgeTur)2);
					if (((DbDataReader)(object)val7)["TIPI"].ToString() == "4")
					{
						val10.set_FisBelgeCins((TFisBelgeCins)3);
					}
					else
					{
						val10.set_FisBelgeCins((TFisBelgeCins)0);
					}
					val10.set_FisOdemeTip((TFisOdemeTip)0);
				}
				else if (((DbDataReader)(object)val7)["FTIRSIP"].ToString() == "2")
				{
					val10.set_FisBelgeTip((TFisBelgeTip)2);
					val10.set_FisBelgeTur((TFisBelgeTur)1);
					if (((DbDataReader)(object)val7)["TIPI"].ToString() == "2")
					{
						val10.set_FisBelgeCins((TFisBelgeCins)0);
					}
					else
					{
						val10.set_FisBelgeCins((TFisBelgeCins)3);
					}
					val10.set_FisOdemeTip((TFisOdemeTip)0);
				}
				else if (((DbDataReader)(object)val7)["FTIRSIP"].ToString() == "9")
				{
					val10.set_FisBelgeTip((TFisBelgeTip)3);
					val10.set_FisBelgeTur((TFisBelgeTur)3);
					val10.set_FisBelgeCins((TFisBelgeCins)0);
					val10.set_FisOdemeTip((TFisOdemeTip)0);
				}
				else if (((DbDataReader)(object)val7)["FTIRSIP"].ToString() == "8")
				{
					val10.set_FisBelgeTip((TFisBelgeTip)3);
					val10.set_FisBelgeTur((TFisBelgeTur)4);
					val10.set_FisBelgeCins((TFisBelgeCins)0);
					val10.set_FisOdemeTip((TFisOdemeTip)0);
				}
				else if (((DbDataReader)(object)val7)["FTIRSIP"].ToString() == "4")
				{
					val10.set_FisBelgeTip((TFisBelgeTip)1);
					val10.set_FisBelgeTur((TFisBelgeTur)1);
					val10.set_FisBelgeCins((TFisBelgeCins)0);
					val10.set_FisOdemeTip((TFisOdemeTip)0);
				}
				if ((int)val10.get_FisBelgeTur() == 1)
				{
					val10.set_FisNo(val10.Al_YeniFisNo(val10.get_FisBelgeTip(), val10.get_FisBelgeTur(), "", true));
				}
				else
				{
					val10.set_FisNo(((DbDataReader)(object)val7)["FATIRS_NO"].ToString());
				}
				val10.set_PerKod(((DbDataReader)(object)val7)["PLA_KODU"].ToString());
				val10.set_BTarih(Convert.ToDateTime(((DbDataReader)(object)val7)["TARIH"]));
				val10.set_VTarih(Convert.ToDateTime(((DbDataReader)(object)val7)["ODEMETARIHI"]));
				val10.set_STarih(Convert.ToDateTime(((DbDataReader)(object)val7)["SIPARIS_TEST"]));
				val10.set_OKod1S(((DbDataReader)(object)val7)["FATIRS_NO"].ToString());
				val10.set_OKod2S(NullString(((DbDataReader)(object)val7)["KOD1"]));
				val10.set_OKod3S(NullString(((DbDataReader)(object)val7)["KOD2"]));
				val10.set_CariKod(NullString(((DbDataReader)(object)val7)["CARI_KODU"].ToString()));
				if (NullString(((DbDataReader)(object)val7)["CARI_KOD2"].ToString()) != "")
				{
					val10.set_TesCariKod(NullString(((DbDataReader)(object)val7)["CARI_KOD2"].ToString()));
				}
				if (((DbDataReader)(object)val7)["TIPI"].ToString() == "1")
				{
					val10.set_FisOdemeTip((TFisOdemeTip)1);
					val10.set_KasaKod("1");
				}
				if (((DbDataReader)(object)val7)["TIPI"].ToString() == "4" || ((DbDataReader)(object)val7)["TIPI"].ToString() == "5")
				{
					val10.set_FisBelgeCins((TFisBelgeCins)3);
				}
				val10.set_AIsk1(Convert.ToDouble(((DbDataReader)(object)val7)["GEN_ISK1O"]));
				val10.set_AIsk2(Convert.ToDouble(((DbDataReader)(object)val7)["GEN_ISK2O"]));
				val10.set_AIsk3(Convert.ToDouble(((DbDataReader)(object)val7)["GEN_ISK3O"]));
				NetRS val11 = ((IKernel)val3).yeniNetRS(val4);
				((INetRS)val11).Ac("SELECT *,TBLSTSABIT.OLCU_BR1,TBLSTSABIT.OLCU_BR2,TBLSTSABIT.OLCU_BR3,   TBLSTSABIT.URETICI_KODU,   CASE TBLSTHAR.OLCUBR   WHEN 0 THEN TBLSTSABIT.OLCU_BR1   WHEN 1 THEN TBLSTSABIT.OLCU_BR1   WHEN 2 THEN TBLSTSABIT.OLCU_BR2   WHEN 3 THEN TBLSTSABIT.OLCU_BR3   WHEN 4 THEN ISNULL((SELECT B.OLCUBIRIMI FROM TBLSTBIRIM B WHERE B.KOD = TBLSTSABIT.STOK_KODU AND B.INCKEYNO=EK.I_YEDEK1),'')   WHEN 5 THEN ISNULL((SELECT B.OLCUBIRIMI FROM TBLSTBIRIM B WHERE B.KOD = TBLSTSABIT.STOK_KODU AND B.INCKEYNO=EK.L_YEDEK1),'')   END BIRIMFF,  CASE TBLSTHAR.OLCUBR   WHEN 0 THEN 1   WHEN 1 THEN 1   WHEN 2 THEN PAY_1   WHEN 3 THEN PAY2   END PAYFF, CASE TBLSTHAR.OLCUBR   WHEN 0 THEN 1   WHEN 1 THEN 1   WHEN 2 THEN PAYDA_1   WHEN 3 THEN PAYDA2   END PAYDAFF, TBLSTHAR.CEVRIM,  CASE TBLSTHAR.OLCUBR   WHEN 0 THEN 1   WHEN 1 THEN 1   WHEN 2 THEN TBLSTSABIT.PAYDA_1   WHEN 3 THEN TBLSTSABIT.PAYDA2   WHEN 4 THEN ISNULL((SELECT B.PAYDA FROM TBLSTBIRIM B WHERE B.KOD = TBLSTSABIT.STOK_KODU AND B.INCKEYNO=EK.I_YEDEK1),'')   WHEN 5 THEN ISNULL((SELECT B.PAYDA FROM TBLSTBIRIM B WHERE B.KOD = TBLSTSABIT.STOK_KODU AND B.INCKEYNO=EK.L_YEDEK1),'')   END BIRIMPAYDA   FROM TBLSTHAR WITH(NOLOCK),TBLSTSABIT WITH(NOLOCK),TBLSTSABITEK EK WITH(NOLOCK)         WHERE TBLSTHAR.FISNO = '" + ((DbDataReader)(object)val7)["FATIRS_NO"].ToString() + "'          AND TBLSTHAR.STHAR_FTIRSIP = '" + ((DbDataReader)(object)val7)["FTIRSIP"].ToString() + "'          AND TBLSTHAR.STHAR_ACIKLAMA = '" + ((DbDataReader)(object)val7)["CARI_KODU"].ToString() + "'          AND TBLSTSABIT.STOK_KODU = TBLSTHAR.STOK_KODU           AND EK.STOK_KODU = TBLSTHAR.STOK_KODU            ");
				while (!((INetRS)val11).get_EOF())
				{
					bool flag = false;
					int index = val10.Ekle_BelgeKalem(((INetField)((INetRS)val11).FieldByName("STOK_KODU")).get_AsString(), true);
					val10.get_BelgeKalem()[index].set_StokKod(((INetField)((INetRS)val11).FieldByName("STOK_KODU")).get_AsString());
					double miktar = ((INetField)((INetRS)val11).FieldByName("STHAR_GCMIK")).get_AsFloat();
					if (((INetField)((INetRS)val11).FieldByName("CEVRIM")).get_AsFloat() != 0.0)
					{
						miktar = Math.Round(((INetField)((INetRS)val11).FieldByName("STHAR_GCMIK")).get_AsFloat() * ((INetField)((INetRS)val11).FieldByName("CEVRIM")).get_AsFloat());
					}
					string text = "";
					text = NullString(((INetField)((INetRS)val11).FieldByName("BIRIMFF")).get_AsString());
					if (text == "")
					{
						yazBilgi(NullString(((INetField)((INetRS)val11).FieldByName("STOK_KODU")).get_AsString()) + " birim bulunamadı!", Color.Red);
					}
					TStokBirim val12 = new TStokBirim(val2);
					val12.Kayit_Ac(val2.get_BayiKod(), val10.get_BelgeKalem()[index].get_StokKod(), text);
					val10.get_BelgeKalem()[index].set_Miktar(miktar);
					val12.Dispose();
					val12 = null;
					if (((INetField)((INetRS)val11).FieldByName("STHAR_MALFISK")).get_AsFloat() == 0.0)
					{
						val10.get_BelgeKalem()[index].set_CikisTip("N");
						val10.get_BelgeKalem()[index].set_Isk1(((INetField)((INetRS)val11).FieldByName("STHAR_SATISK")).get_AsFloat() * 100000.0);
						val10.get_BelgeKalem()[index].set_Isk2(((INetField)((INetRS)val11).FieldByName("STHAR_SATISK2")).get_AsFloat());
						val10.get_BelgeKalem()[index].set_Isk3(((INetField)((INetRS)val11).FieldByName("STRA_SATISK3")).get_AsFloat());
						val10.get_BelgeKalem()[index].set_Isk4(((INetField)((INetRS)val11).FieldByName("STRA_SATISK4")).get_AsFloat());
						val10.get_BelgeKalem()[index].set_Isk5(((INetField)((INetRS)val11).FieldByName("STRA_SATISK5")).get_AsFloat());
						val10.get_BelgeKalem()[index].set_Isk6(((INetField)((INetRS)val11).FieldByName("STRA_SATISK6")).get_AsFloat());
					}
					else if (((INetField)((INetRS)val11).FieldByName("STHAR_GCMIK")).get_AsFloat() - ((INetField)((INetRS)val11).FieldByName("STHAR_MALFISK")).get_AsFloat() != 0.0)
					{
						flag = true;
						val10.get_BelgeKalem()[index].set_Isk1(((INetField)((INetRS)val11).FieldByName("STHAR_SATISK")).get_AsFloat() * 100000.0);
						val10.get_BelgeKalem()[index].set_Isk2(((INetField)((INetRS)val11).FieldByName("STHAR_SATISK2")).get_AsFloat());
						val10.get_BelgeKalem()[index].set_Isk3(((INetField)((INetRS)val11).FieldByName("STRA_SATISK3")).get_AsFloat());
						val10.get_BelgeKalem()[index].set_Isk4(((INetField)((INetRS)val11).FieldByName("STRA_SATISK4")).get_AsFloat());
						val10.get_BelgeKalem()[index].set_Isk5(((INetField)((INetRS)val11).FieldByName("STRA_SATISK5")).get_AsFloat());
						val10.get_BelgeKalem()[index].set_Isk6(((INetField)((INetRS)val11).FieldByName("STRA_SATISK6")).get_AsFloat());
						double miktar2 = ((INetField)((INetRS)val11).FieldByName("STHAR_GCMIK")).get_AsFloat() - ((INetField)((INetRS)val11).FieldByName("STHAR_MALFISK")).get_AsFloat();
						if (((INetField)((INetRS)val11).FieldByName("CEVRIM")).get_AsFloat() != 0.0)
						{
							miktar2 = Math.Round((((INetField)((INetRS)val11).FieldByName("STHAR_GCMIK")).get_AsFloat() - ((INetField)((INetRS)val11).FieldByName("STHAR_MALFISK")).get_AsFloat()) * ((INetField)((INetRS)val11).FieldByName("CEVRIM")).get_AsFloat());
						}
						val10.get_BelgeKalem()[index].set_Miktar(miktar2);
					}
					else
					{
						val10.get_BelgeKalem()[index].set_CikisTip("B");
						val10.get_BelgeKalem()[index].set_BdlIsk(100.0);
						val10.get_BelgeKalem()[index].set_Isk1(0.0);
						val10.get_BelgeKalem()[index].set_Isk2(0.0);
						val10.get_BelgeKalem()[index].set_Isk3(0.0);
						val10.get_BelgeKalem()[index].set_Isk4(0.0);
						val10.get_BelgeKalem()[index].set_Isk5(0.0);
						val10.get_BelgeKalem()[index].set_Isk6(0.0);
						val10.get_BelgeKalem()[index].set_Isk7(0.0);
						val10.get_BelgeKalem()[index].set_Isk8(0.0);
						val10.get_BelgeKalem()[index].set_Isk9(0.0);
						val10.get_BelgeKalem()[index].set_Isk10(0.0);
						val10.get_BelgeKalem()[index].set_Isk11(0.0);
						val10.get_BelgeKalem()[index].set_Isk12(0.0);
					}
					val10.get_BelgeKalem()[index].set_Birim(text);
					val10.get_BelgeKalem()[index].set_Fiyat(((INetField)((INetRS)val11).FieldByName("STHAR_BF")).get_AsFloat() * ((INetField)((INetRS)val11).FieldByName("BIRIMPAYDA")).get_AsFloat());
					val10.get_BelgeKalem()[index].set_DovizFiyat(val10.get_BelgeKalem()[index].get_Fiyat());
					val10.get_BelgeKalem()[index].set_DovizKur(1.0);
					val10.get_BelgeKalem()[index].set_Doviz(val.get_VarsayilanDoviz());
					val10.get_BelgeKalem()[index].set_VadeGun((short)((INetField)((INetRS)val11).FieldByName("STHAR_ODEGUN")).get_AsInteger());
					val10.get_BelgeKalem()[index].set_Kdv(((INetField)((INetRS)val11).FieldByName("STHAR_KDV")).get_AsFloat());
					val10.get_BelgeKalem()[index].set_DepoKod("1");
					if (flag)
					{
						index = val10.Ekle_BelgeKalem(((INetField)((INetRS)val11).FieldByName("URETICI_KODU")).get_AsString(), true);
						val10.get_BelgeKalem()[index].set_StokKod(((INetField)((INetRS)val11).FieldByName("URETICI_KODU")).get_AsString());
						miktar = ((INetField)((INetRS)val11).FieldByName("STHAR_MALFISK")).get_AsFloat();
						if (((INetField)((INetRS)val11).FieldByName("CEVRIM")).get_AsFloat() != 0.0)
						{
							miktar = Math.Round(((INetField)((INetRS)val11).FieldByName("STHAR_MALFISK")).get_AsFloat() * ((INetField)((INetRS)val11).FieldByName("CEVRIM")).get_AsFloat());
						}
						text = "";
						text = NullString(((INetField)((INetRS)val11).FieldByName("BIRIMFF")).get_AsString());
						if (text == "")
						{
							yazBilgi(NullString(((INetField)((INetRS)val11).FieldByName("STOK_KODU")).get_AsString()) + " birim bulunamadı!", Color.Red);
						}
						val12 = new TStokBirim(val2);
						val12.Kayit_Ac(val2.get_BayiKod(), val10.get_BelgeKalem()[index].get_StokKod(), text);
						val10.get_BelgeKalem()[index].set_Miktar(miktar);
						val12.Dispose();
						val12 = null;
						val10.get_BelgeKalem()[index].set_CikisTip("B");
						val10.get_BelgeKalem()[index].set_BdlIsk(100.0);
						val10.get_BelgeKalem()[index].set_Isk1(0.0);
						val10.get_BelgeKalem()[index].set_Isk2(0.0);
						val10.get_BelgeKalem()[index].set_Isk3(0.0);
						val10.get_BelgeKalem()[index].set_Isk4(0.0);
						val10.get_BelgeKalem()[index].set_Isk5(0.0);
						val10.get_BelgeKalem()[index].set_Isk6(0.0);
						val10.get_BelgeKalem()[index].set_Isk7(0.0);
						val10.get_BelgeKalem()[index].set_Isk8(0.0);
						val10.get_BelgeKalem()[index].set_Isk9(0.0);
						val10.get_BelgeKalem()[index].set_Isk10(0.0);
						val10.get_BelgeKalem()[index].set_Isk11(0.0);
						val10.get_BelgeKalem()[index].set_Isk12(0.0);
						val10.get_BelgeKalem()[index].set_Birim(text);
						val10.get_BelgeKalem()[index].set_Fiyat(((INetField)((INetRS)val11).FieldByName("STHAR_BF")).get_AsFloat() * ((INetField)((INetRS)val11).FieldByName("BIRIMPAYDA")).get_AsFloat());
						val10.get_BelgeKalem()[index].set_DovizFiyat(val10.get_BelgeKalem()[index].get_Fiyat());
						val10.get_BelgeKalem()[index].set_DovizKur(1.0);
						val10.get_BelgeKalem()[index].set_Doviz(val.get_VarsayilanDoviz());
						val10.get_BelgeKalem()[index].set_VadeGun((short)((INetField)((INetRS)val11).FieldByName("STHAR_ODEGUN")).get_AsInteger());
						val10.get_BelgeKalem()[index].set_Kdv(((INetField)((INetRS)val11).FieldByName("STHAR_KDV")).get_AsFloat());
						val10.get_BelgeKalem()[index].set_DepoKod("1");
					}
					((INetRS)val11).SonrakiK();
				}
				((INetRS)val11).Kapat();
				val11 = null;
				try
				{
					val2.TransactionBaslat();
					val10.Kayit_Ekle(false);
					val2.TransactionOnayla();
				}
				catch (Exception ex)
				{
					try
					{
						val2.TransactionBitir();
					}
					catch
					{
					}
					yazBilgi("Belge Aktarılamadı!: " + ((DbDataReader)(object)val7)["FATIRS_NO"].ToString() + Convert.ToChar(13) + Convert.ToChar(10) + ex.Message, Color.Red);
				}
				val10.Dispose();
				val10 = null;
				ProgressBar pG = PG;
				pG.set_Value(pG.get_Value() + 1);
				((Control)label1).set_Text(((DbDataReader)(object)val7)["FATIRS_NO"].ToString() + " " + PG.get_Value() + "/" + PG.get_Maximum());
				Application.DoEvents();
			}
			((DbDataReader)(object)val7).Close();
			((DbDataReader)(object)val7).Dispose();
			val7 = null;
			((Component)(object)val6)?.Dispose();
			val6 = null;
			val4 = null;
			((IKernel)val3).FreeNetsisLibrary();
			val3 = null;
			val2.Dispose();
			val2 = null;
			val.Bosalt_Kernel();
			val.Dispose();
			val = null;
			MessageBox.Show("İşlem tamamlandı!");
		}
		catch (Exception ex)
		{
			yazBilgi(ex.Message, Color.Red);
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			AlParam();
		}
		catch
		{
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			KaydetParam();
		}
		catch
		{
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		((Control)button2).set_Enabled(false);
		Aktar();
		((Control)button2).set_Enabled(true);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
