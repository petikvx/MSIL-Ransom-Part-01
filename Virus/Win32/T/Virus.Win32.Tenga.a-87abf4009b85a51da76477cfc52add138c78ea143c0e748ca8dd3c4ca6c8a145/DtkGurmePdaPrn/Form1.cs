using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using DtkNetDBSDK;
using DtkNetSDK;
using mdlPrint;

namespace DtkGurmePdaPrn;

public class Form1 : Form
{
	private IContainer components;

	private Timer tmr;

	private NotifyIcon notifyIcon1;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem ayarlarToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_0;

	private Button button1;

	private Panel panel1;

	private TextBox textBox1;

	private bool isFirst = true;

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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		tmr = new Timer(components);
		notifyIcon1 = new NotifyIcon(components);
		contextMenuStrip1 = new ContextMenuStrip(components);
		ayarlarToolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem_0 = new ToolStripMenuItem();
		button1 = new Button();
		panel1 = new Panel();
		textBox1 = new TextBox();
		((Control)contextMenuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		tmr.set_Interval(1000);
		tmr.add_Tick((EventHandler)tmr_Tick);
		notifyIcon1.set_BalloonTipIcon((ToolTipIcon)1);
		notifyIcon1.set_BalloonTipText("Datakod GURME PDA Yazdırma Servisi");
		notifyIcon1.set_BalloonTipTitle("Datakod GURME PDA Yazdırma Servisi");
		notifyIcon1.set_ContextMenuStrip(contextMenuStrip1);
		notifyIcon1.set_Icon((Icon)componentResourceManager.GetObject("notifyIcon1.Icon"));
		notifyIcon1.set_Text("Datakod GURME PDA Yazdırma Servisi");
		notifyIcon1.set_Visible(true);
		notifyIcon1.add_DoubleClick((EventHandler)notifyIcon1_DoubleClick_1);
		((ToolStrip)contextMenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ayarlarToolStripMenuItem,
			(ToolStripItem)toolStripMenuItem_0
		});
		((Control)contextMenuStrip1).set_Name("contextMenuStrip1");
		((Control)contextMenuStrip1).set_Size(new Size(122, 48));
		((ToolStripItem)ayarlarToolStripMenuItem).set_Name("ayarlarToolStripMenuItem");
		((ToolStripItem)ayarlarToolStripMenuItem).set_Size(new Size(121, 22));
		((ToolStripItem)ayarlarToolStripMenuItem).set_Text("Ayarlar...");
		((ToolStripItem)ayarlarToolStripMenuItem).add_Click((EventHandler)ayarlarToolStripMenuItem_Click);
		((ToolStripItem)toolStripMenuItem_0).set_Name("çıkışToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_0).set_Size(new Size(121, 22));
		((ToolStripItem)toolStripMenuItem_0).set_Text("Çıkış");
		((ToolStripItem)toolStripMenuItem_0).add_Click((EventHandler)toolStripMenuItem_0_Click);
		((Control)button1).set_Location(new Point(128, 12));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(282, 35));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Durdur");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)panel1).set_Location(new Point(234, 53));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(76, 30));
		((Control)panel1).set_TabIndex(2);
		((Control)textBox1).set_Location(new Point(12, 107));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(507, 159));
		((Control)textBox1).set_TabIndex(3);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(531, 278));
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Datakod GURME PDA Yazdırma Servisi");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).add_Paint(new PaintEventHandler(Form1_Paint));
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Control)this).add_Resize((EventHandler)Form1_Resize);
		((Control)contextMenuStrip1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public Form1()
	{
		InitializeComponent();
	}

	public void Calistir_Timer()
	{
		tmr.set_Enabled(false);
		if (((TextBoxBase)textBox1).get_Lines().Length > 1000)
		{
			((Control)textBox1).set_Text("");
		}
		string[] files = Directory.GetFiles("C:\\DATAKOD", "*.cst");
		if (files.Length > 0)
		{
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					StreamReader streamReader = File.OpenText(files[i]);
					string pSirketKod = streamReader.ReadLine();
					int pSubeKod = Convert.ToInt32(streamReader.ReadLine());
					string pRaporDosya = streamReader.ReadLine();
					string pYazici = streamReader.ReadLine();
					string pParam = streamReader.ReadLine();
					string pParam2 = streamReader.ReadLine();
					string pParam3 = streamReader.ReadLine();
					string pParam4 = streamReader.ReadLine();
					string pParam5 = streamReader.ReadLine();
					string pParam6 = streamReader.ReadLine();
					streamReader.Close();
					try
					{
						streamReader.Dispose();
					}
					catch
					{
					}
					streamReader = null;
					if (Yazdir_Custom(pSirketKod, pSubeKod, pRaporDosya, pYazici, pParam, pParam2, pParam3, pParam4, pParam5, pParam6))
					{
						File.Delete(files[i]);
					}
					Thread.Sleep(400);
					if (File.Exists(files[i]))
					{
						TextBox obj2 = textBox1;
						((Control)obj2).set_Text(((Control)obj2).get_Text() + " SORUN VAR!!!!!!!!");
					}
				}
				catch
				{
				}
			}
		}
		string[] files2 = Directory.GetFiles("C:\\DATAKOD", "*.ifo");
		if (files2.Length > 0)
		{
			for (int j = 0; j < files2.Length; j++)
			{
				try
				{
					StreamReader streamReader = File.OpenText(files2[j]);
					string pSirketKod2 = streamReader.ReadLine();
					int pSubeKod2 = Convert.ToInt32(streamReader.ReadLine());
					string text = streamReader.ReadLine();
					string pRaporDosya2 = streamReader.ReadLine();
					streamReader.Close();
					try
					{
						streamReader.Dispose();
					}
					catch
					{
					}
					streamReader = null;
					if (Yazdir_AdisInfo(pSirketKod2, pSubeKod2, text, pRaporDosya2))
					{
						File.Delete(files2[j]);
					}
					Thread.Sleep(400);
					if (File.Exists(files2[j]))
					{
						TextBox obj5 = textBox1;
						((Control)obj5).set_Text(((Control)obj5).get_Text() + text + " SORUN VAR!!!!!!!!");
					}
				}
				catch
				{
				}
			}
		}
		string[] files3 = Directory.GetFiles("C:\\DATAKOD", "*.ifp");
		if (files3.Length > 0)
		{
			for (int k = 0; k < files3.Length; k++)
			{
				try
				{
					StreamReader streamReader = File.OpenText(files3[k]);
					bool flag = Yazdir_AdisInfoIptal(streamReader.ReadLine(), Convert.ToInt32(streamReader.ReadLine()), streamReader.ReadLine(), streamReader.ReadLine());
					streamReader.Close();
					try
					{
						streamReader.Dispose();
					}
					catch
					{
					}
					streamReader = null;
					Thread.Sleep(400);
					if (flag)
					{
						File.Delete(files3[k]);
					}
				}
				catch
				{
				}
			}
		}
		string[] files4 = Directory.GetFiles("C:\\DATAKOD", "*.ads");
		if (files4.Length > 0)
		{
			for (int l = 0; l < files4.Length; l++)
			{
				try
				{
					StreamReader streamReader = File.OpenText(files4[l]);
					bool flag2 = Yazdir_Adisyon(streamReader.ReadLine(), Convert.ToInt32(streamReader.ReadLine()), streamReader.ReadLine(), streamReader.ReadLine(), streamReader.ReadLine());
					streamReader.Close();
					try
					{
						streamReader.Dispose();
					}
					catch
					{
					}
					streamReader = null;
					Thread.Sleep(400);
					if (flag2)
					{
						File.Delete(files4[l]);
					}
				}
				catch
				{
				}
			}
		}
		tmr.set_Enabled(true);
	}

	public bool Yazdir_Custom(string pSirketKod, int pSubeKod, string pRaporDosya, string pYazici, string pParam1, string pParam2, string pParam3, string pParam4, string pParam5, string pParam6)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		bool result = false;
		try
		{
			TextBox obj = textBox1;
			object text = ((Control)obj).get_Text();
			((Control)obj).set_Text(string.Concat(text, $"{DateTime.Now:dd.MM.yy HH:mm}", "_YAZ_1::", Convert.ToChar(13), Convert.ToChar(10)));
			TNetKernel val = new TNetKernel(true);
			TNetSirket val2 = val.yeniSirket(pSirketKod, pSubeKod, "DATAKOD", "b1998_DTKDDD");
			INetSorgu val3 = new INetSorgu(val2.get_NetBaglanti());
			if (pRaporDosya != "" && File.Exists(pRaporDosya))
			{
				TPrint val4 = new TPrint();
				val4.raporDosya = pRaporDosya;
				if (pParam1 != "")
				{
					val4.degiskenList.Add("Param1");
					val4.degerList.Add("'" + pParam1 + "'");
				}
				if (pParam2 != "")
				{
					val4.degiskenList.Add("Param2");
					val4.degerList.Add("'" + pParam2 + "'");
				}
				if (pParam3 != "")
				{
					val4.degiskenList.Add("Param3");
					val4.degerList.Add("'" + pParam3 + "'");
				}
				if (pParam4 != "")
				{
					val4.degiskenList.Add("Param4");
					val4.degerList.Add("'" + pParam4 + "'");
				}
				if (pParam5 != "")
				{
					val4.degiskenList.Add("Param5");
					val4.degerList.Add("'" + pParam5 + "'");
				}
				if (pParam6 != "")
				{
					if (pParam6.IndexOf("@") == -1)
					{
						val4.degiskenList.Add("Param6");
						val4.degerList.Add("'" + pParam6 + "'");
					}
					else
					{
						val4.degiskenList.Add("Param6");
						val4.degerList.Add("'" + pParam6.Substring(0, pParam6.IndexOf("@") - 1) + "'");
						if (pParam6.IndexOf("&") == -1)
						{
							string text2 = pParam6.Substring(pParam6.IndexOf("@") + 1);
							val4.degiskenList.Add("Param7");
							val4.degerList.Add("'" + text2 + "'");
						}
						else
						{
							string text3 = pParam6.Substring(pParam6.IndexOf("@") + 1, pParam6.IndexOf("&") - 1);
							val4.degiskenList.Add("Param7");
							val4.degerList.Add("'" + text3 + "'");
							text3 = pParam6.Substring(pParam6.IndexOf("&") + 1);
							val4.degiskenList.Add("Param8");
							val4.degerList.Add("'" + text3 + "'");
						}
					}
				}
				if (pYazici != "")
				{
					val4.yaziciAdi = pYazici;
				}
				val4.connStr = val2.get_NetBaglanti().get_BaglantiStr();
				val4.Hazirla_Rapor();
				val4.Yazdir_Rapor();
				val4.Dispose();
				val4 = null;
			}
			result = true;
			if (val3 != null)
			{
				val3.Dispose();
			}
			val3 = null;
			if (val2 != null)
			{
				val2.Dispose();
			}
			val2 = null;
			val.Bosalt_Kernel();
			if (val != null)
			{
				val.Dispose();
			}
			val = null;
			return result;
		}
		catch (Exception ex)
		{
			TextBox obj2 = textBox1;
			object text4 = ((Control)obj2).get_Text();
			((Control)obj2).set_Text(string.Concat(text4, "ERR_1:::", ex.Message, Convert.ToChar(13), Convert.ToChar(10)));
			return result;
		}
	}

	public bool Yazdir_AdisInfo(string pSirketKod, int pSubeKod, string pFisNo, string pRaporDosya)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		bool result = false;
		try
		{
			TextBox obj = textBox1;
			object text = ((Control)obj).get_Text();
			((Control)obj).set_Text(string.Concat(text, $"{DateTime.Now:dd.MM.yy HH:mm}", "_YAZ_1::", pFisNo, Convert.ToChar(13), Convert.ToChar(10)));
			TNetKernel val = new TNetKernel(true);
			TNetSirket val2 = val.yeniSirket(pSirketKod, pSubeKod, "DATAKOD", "b1998_DTKDDD");
			INetSorgu val3 = new INetSorgu(val2.get_NetBaglanti());
			if (pRaporDosya != "" && File.Exists(pRaporDosya))
			{
				ArrayList arrayList = new ArrayList();
				val3.Sorgu_Ac("EXEC func_AlAdisStokYazici '" + val2.get_BayiKod() + "','" + pFisNo + "'," + pSubeKod + ",'',0");
				while (val3.KayitSonraki())
				{
					string value = "";
					if (val3.DegerAl("OKod1S").ToString() != "")
					{
						value = val3.DegerAl("OKod1S").ToString();
					}
					else if (val3.DegerAl("DepoOKod1S").ToString() != "")
					{
						value = val3.DegerAl("DepoOKod1S").ToString();
					}
					else if (val3.DegerAl("Depo2OKod1S").ToString() != "")
					{
						value = val3.DegerAl("Depo2OKod1S").ToString();
					}
					if (arrayList.IndexOf(value) == -1)
					{
						arrayList.Add(value);
					}
				}
				val3.Kapat();
				for (int i = 0; i < arrayList.Count; i++)
				{
					TPrint val4 = new TPrint();
					val4.raporDosya = pRaporDosya;
					val4.degiskenList.Add("FisNo");
					val4.degerList.Add("'" + pFisNo + "'");
					val4.degiskenList.Add("Yazici");
					val4.degerList.Add("'" + arrayList[i]!.ToString() + "'");
					val4.degiskenList.Add("Iptal");
					val4.degerList.Add("''");
					val4.yaziciAdi = arrayList[i]!.ToString();
					val4.connStr = val2.get_NetBaglanti().get_BaglantiStr();
					val4.Hazirla_Rapor();
					val4.Yazdir_Rapor();
					val4.Dispose();
					val4 = null;
				}
				arrayList.Clear();
				arrayList = null;
			}
			val2.TransactionBaslat();
			INetProc val5 = new INetProc(val2.get_NetBaglanti());
			val5.Hazirla("func_YazdirAdisInfo");
			val5.Parametre_Ekle("@BayiKod", (TDataTip)200, 15, (object)"");
			val5.Parametre_Ekle("@FisNo", (TDataTip)200, 15, (object)pFisNo);
			val5.Parametre_Ekle("@SubeKod", (TDataTip)3, (object)pSubeKod);
			val5.Calistir();
			val5.Dispose();
			val5 = null;
			val2.TransactionOnayla();
			result = true;
			if (val3 != null)
			{
				val3.Dispose();
			}
			val3 = null;
			if (val2 != null)
			{
				val2.Dispose();
			}
			val2 = null;
			val.Bosalt_Kernel();
			if (val != null)
			{
				val.Dispose();
			}
			val = null;
			return result;
		}
		catch (Exception ex)
		{
			TextBox obj2 = textBox1;
			object text2 = ((Control)obj2).get_Text();
			((Control)obj2).set_Text(string.Concat(text2, "ERR_1::", pFisNo, ":", ex.Message, Convert.ToChar(13), Convert.ToChar(10)));
			return result;
		}
	}

	public bool Yazdir_AdisInfoIptal(string pSirketKod, int pSubeKod, string pFisNo, string pRaporDosya)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		bool result = false;
		try
		{
			TextBox obj = textBox1;
			string text = ((Control)obj).get_Text();
			TextBox obj2 = textBox1;
			object text2 = ((Control)obj2).get_Text();
			string text3;
			((Control)obj2).set_Text(text3 = string.Concat(text2, $"{DateTime.Now:dd.MM.yy HH:mm}", "_YAZ_2::", pFisNo, Convert.ToChar(13), Convert.ToChar(10)));
			((Control)obj).set_Text(text + text3);
			TNetKernel val = new TNetKernel(true);
			TNetSirket val2 = val.yeniSirket(pSirketKod, pSubeKod, "DATAKOD", "b1998_DTKDDD");
			INetSorgu val3 = new INetSorgu(val2.get_NetBaglanti());
			if (pRaporDosya != "" && File.Exists(pRaporDosya))
			{
				ArrayList arrayList = new ArrayList();
				val3.Sorgu_Ac("EXEC func_AlAdisStokYazici '" + val2.get_BayiKod() + "','" + pFisNo + "'," + pSubeKod + ",'',1");
				while (val3.KayitSonraki())
				{
					string value = "";
					if (val3.DegerAl("OKod1S").ToString() != "")
					{
						value = val3.DegerAl("OKod1S").ToString();
					}
					else if (val3.DegerAl("DepoOKod1S").ToString() != "")
					{
						value = val3.DegerAl("DepoOKod1S").ToString();
					}
					else if (val3.DegerAl("Depo2OKod1S").ToString() != "")
					{
						value = val3.DegerAl("Depo2OKod1S").ToString();
					}
					if (arrayList.IndexOf(value) == -1)
					{
						arrayList.Add(value);
					}
				}
				for (int i = 0; i < arrayList.Count; i++)
				{
					TPrint val4 = new TPrint();
					val4.raporDosya = pRaporDosya;
					val4.degiskenList.Add("FisNo");
					val4.degerList.Add("'" + pFisNo + "'");
					val4.degiskenList.Add("Yazici");
					val4.degerList.Add("'" + arrayList[i]!.ToString() + "'");
					val4.degiskenList.Add("Iptal");
					val4.degerList.Add("'X'");
					val4.yaziciAdi = arrayList[i]!.ToString();
					val4.connStr = val2.get_NetBaglanti().get_BaglantiStr();
					val4.Hazirla_Rapor();
					val4.Yazdir_Rapor();
					val4.Dispose();
					val4 = null;
				}
				arrayList.Clear();
				arrayList = null;
			}
			val3.Sorgu_Calistir("UPDATE TblBelgeDetay SET Miktar2 = 0  WHERE FisNo = '" + pFisNo + "'   AND SebepKod <> ''    AND BelgeTip = 'X'    AND BelgeTur = '2' ");
			val3.Kapat();
			val3.Dispose();
			val3 = null;
			result = true;
			if (val2 != null)
			{
				val2.Dispose();
			}
			val2 = null;
			val.Bosalt_Kernel();
			if (val != null)
			{
				val.Dispose();
			}
			val = null;
			return result;
		}
		catch (Exception ex)
		{
			TextBox obj3 = textBox1;
			object text4 = ((Control)obj3).get_Text();
			((Control)obj3).set_Text(string.Concat(text4, "ERR_2::", pFisNo, ":", ex.Message, Convert.ToChar(13), Convert.ToChar(10)));
			return result;
		}
	}

	public bool Yazdir_Adisyon(string pSirketKod, int pSubeKod, string pFisNo, string pRaporDosya, string pYazici)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		bool result = false;
		try
		{
			TextBox obj = textBox1;
			object text = ((Control)obj).get_Text();
			((Control)obj).set_Text(string.Concat(text, $"{DateTime.Now:dd.MM.yy HH:mm}", "_YAZ_3::", pFisNo, Convert.ToChar(13), Convert.ToChar(10)));
			string text2 = "";
			TNetKernel val = new TNetKernel(true);
			TNetSirket val2 = val.yeniSirket(pSirketKod, pSubeKod, "DATAKOD", "b1998_DTKDDD");
			TGurmeParam val3 = new TGurmeParam(val2);
			val3.Al_Parametre();
			text2 = val3.get_Adisyon_YaziciAdi();
			if (val3.get_Adisyon_Dizayn() != "")
			{
				if (File.Exists(val3.get_Adisyon_Dizayn()))
				{
					INetSorgu val4 = new INetSorgu(val2.get_NetBaglanti());
					val4.Sorgu_Ac("SELECT M.OKod1S FROM TblBelge B   LEFT JOIN TblMasa M ON (M.BayiKod = B.BayiKod AND M.MasaKod = B.Acklm1)  WHERE B.BayiKod = '" + val2.get_BayiKod() + "'   AND B.SubeKod = " + val2.get_SubeKod() + "   AND B.FisNo = '" + pFisNo + "'   AND B.BelgeTip = 'X'    AND B.BelgeTur = '2' ");
					if (val4.KayitSonraki() && val4.DegerAl("OKod1S").ToString() != "")
					{
						text2 = val4.DegerAl("OKod1S").ToString();
					}
					val4.Kapat();
					TPrint val5 = new TPrint();
					val5.raporDosya = val3.get_Adisyon_Dizayn();
					val5.yaziciAdi = text2;
					val5.degiskenList.Add("FisNo");
					val5.degerList.Add("'" + pFisNo + "'");
					val5.yaziciAdi = text2;
					val5.connStr = val2.get_NetBaglanti().get_BaglantiStr();
					TBelge val6 = new TBelge(val2);
					val6.Kayit_Ac(pFisNo, (TFisBelgeTip)6, (TFisBelgeTur)2);
					val6.set_IsYazdir(true);
					val6.set_PTarih(DateTime.Now);
					val6.Kayit_Duzelt(true);
					val6.Dispose();
					val6 = null;
					val4.Kapat();
					val4.Dispose();
					val4 = null;
					val5.yaziciAdi = text2;
					val5.Hazirla_Rapor();
					val5.yaziciAdi = text2;
					val5.Yazdir_Rapor();
					val5.Dispose();
					val5 = null;
					result = true;
				}
				else
				{
					result = true;
				}
			}
			else
			{
				result = true;
			}
			if (val2 != null)
			{
				val2.Dispose();
			}
			val2 = null;
			val.Bosalt_Kernel();
			if (val != null)
			{
				val.Dispose();
			}
			val = null;
			return result;
		}
		catch (Exception ex)
		{
			TextBox obj2 = textBox1;
			object text3 = ((Control)obj2).get_Text();
			((Control)obj2).set_Text(string.Concat(text3, "ERR_3::", pFisNo, ":", ex.Message, Convert.ToChar(13), Convert.ToChar(10)));
			return result;
		}
	}

	private void Form1_Resize(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between I4 and Unknown
		if (1 == (int)((Form)this).get_WindowState())
		{
			((Control)this).Hide();
		}
	}

	private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)this).Show();
		((Form)this).set_WindowState((FormWindowState)0);
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void tmr_Tick(object sender, EventArgs e)
	{
		Calistir_Timer();
		if (((Control)panel1).get_BackColor() == Color.Black)
		{
			((Control)panel1).set_BackColor(Color.Red);
		}
		else
		{
			((Control)panel1).set_BackColor(Color.Black);
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (tmr.get_Enabled())
		{
			((Control)button1).set_Text("Başlat");
			tmr.set_Enabled(false);
			((Form)this).set_WindowState((FormWindowState)1);
		}
		else
		{
			((Control)button1).set_Text("Durdur");
			tmr.set_Enabled(true);
			((Form)this).set_WindowState((FormWindowState)1);
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		tmr.set_Enabled(true);
	}

	private void notifyIcon1_DoubleClick_1(object sender, EventArgs e)
	{
		((Control)this).Show();
		((Form)this).set_WindowState((FormWindowState)0);
	}

	private void Form1_Paint(object sender, PaintEventArgs e)
	{
		if (isFirst)
		{
			isFirst = false;
			((Form)this).set_WindowState((FormWindowState)1);
			((Control)this).Hide();
		}
	}
}
