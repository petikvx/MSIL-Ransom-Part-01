using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;
using CustomControls.RJControls;
using slam_loader.Properties;

namespace slam_loader;

public class Form1 : Form
{
	public static string dentro = "no";

	private IContainer components = null;

	private RJButton rjButton1;

	private RJButton rjButton2;

	private RJButton rjButton3;

	private RJButton rjButton4;

	private RJButton rjButton5;

	private Timer timer1;

	private RJButton rjButton6;

	private RJButton rjButton7;

	private RJButton rjButton8;

	private RJButton rjButton9;

	private RJButton rjButton10;

	private RJButton rjButton11;

	private RJButton rjButton12;

	private RJButton rjButton13;

	private Timer timer2;

	private Timer timer3;

	private Timer timer4;

	private Timer timer5;

	private Timer timer6;

	private Button button1;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Label label5;

	private Label label6;

	private Label label7;

	private Label label8;

	private Timer timer7;

	private CircularProgressBar circularProgressBar1;

	private RJButton rjButton14;

	private Label label9;

	public Form1()
	{
		InitializeComponent();
	}

	private void rjButton1_MouseEnter(object sender, EventArgs e)
	{
		timer1.Stop();
		dentro = "si";
		((Control)rjButton2).set_Visible(true);
		((Control)rjButton3).set_Visible(true);
		((Control)rjButton4).set_Visible(true);
		((Control)rjButton5).set_Visible(true);
		((Control)rjButton6).set_Visible(false);
		((Control)rjButton7).set_Visible(false);
		((Control)rjButton8).set_Visible(false);
		((Control)rjButton9).set_Visible(false);
		((Control)rjButton10).set_Visible(false);
		((Control)rjButton11).set_Visible(false);
		((Control)rjButton12).set_Visible(false);
		((Control)rjButton13).set_Visible(false);
	}

	private void rjButton2_MouseEnter(object sender, EventArgs e)
	{
		timer1.Stop();
		timer5.Stop();
		dentro = "si";
		((Control)rjButton13).set_Visible(true);
		((Control)rjButton12).set_Visible(true);
	}

	private void rjButton3_MouseEnter(object sender, EventArgs e)
	{
		timer4.Stop();
		timer1.Stop();
		((Control)rjButton8).set_Visible(true);
		((Control)rjButton9).set_Visible(true);
		((Control)rjButton14).set_Visible(true);
	}

	private void rjButton4_MouseEnter(object sender, EventArgs e)
	{
		timer1.Stop();
		timer3.Stop();
		dentro = "si";
		((Control)rjButton10).set_Visible(true);
		((Control)rjButton11).set_Visible(true);
	}

	private void rjButton5_MouseEnter(object sender, EventArgs e)
	{
		timer1.Stop();
		timer2.Stop();
		dentro = "si";
		((Control)rjButton7).set_Visible(true);
		((Control)rjButton6).set_Visible(true);
	}

	private void rjButton5_MouseLeave(object sender, EventArgs e)
	{
		timer1.Start();
		dentro = "no";
		timer2.Start();
		timer1.Start();
		dentro = "no";
		timer2.Start();
	}

	private void rjButton4_MouseLeave(object sender, EventArgs e)
	{
		timer1.Start();
		dentro = "no";
		timer3.Start();
		timer1.Start();
		dentro = "no";
		timer3.Start();
	}

	private void rjButton3_MouseLeave(object sender, EventArgs e)
	{
		timer4.Start();
		timer1.Start();
	}

	private void rjButton2_MouseLeave(object sender, EventArgs e)
	{
		timer1.Start();
		dentro = "no";
		timer5.Start();
		timer1.Start();
		dentro = "no";
		timer5.Start();
	}

	private void rjButton1_MouseLeave(object sender, EventArgs e)
	{
		timer1.Start();
		dentro = "no";
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		((Control)rjButton2).set_Visible(false);
		((Control)rjButton3).set_Visible(false);
		((Control)rjButton4).set_Visible(false);
		((Control)rjButton5).set_Visible(false);
		timer1.Stop();
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		((Control)rjButton7).set_Visible(false);
		((Control)rjButton6).set_Visible(false);
	}

	private void timer3_Tick(object sender, EventArgs e)
	{
		((Control)rjButton10).set_Visible(false);
		((Control)rjButton11).set_Visible(false);
	}

	private void timer4_Tick(object sender, EventArgs e)
	{
		((Control)rjButton8).set_Visible(false);
		((Control)rjButton9).set_Visible(false);
		((Control)rjButton14).set_Visible(false);
	}

	private void timer5_Tick(object sender, EventArgs e)
	{
		((Control)rjButton13).set_Visible(false);
		((Control)rjButton12).set_Visible(false);
	}

	private void rjButton7_MouseEnter(object sender, EventArgs e)
	{
		timer2.Stop();
		timer1.Stop();
	}

	private void rjButton7_MouseLeave(object sender, EventArgs e)
	{
		timer2.Start();
		timer1.Start();
	}

	private void rjButton12_MouseEnter(object sender, EventArgs e)
	{
		timer5.Stop();
		timer1.Stop();
	}

	private void rjButton12_MouseLeave(object sender, EventArgs e)
	{
		timer5.Start();
		timer1.Start();
	}

	private void rjButton11_MouseEnter(object sender, EventArgs e)
	{
		timer3.Stop();
		timer1.Stop();
	}

	private void rjButton11_MouseLeave(object sender, EventArgs e)
	{
		timer3.Start();
		timer1.Start();
	}

	private void rjButton8_MouseEnter(object sender, EventArgs e)
	{
		timer4.Stop();
		timer1.Stop();
	}

	private void rjButton8_MouseLeave(object sender, EventArgs e)
	{
		timer4.Start();
		timer1.Start();
	}

	private void timer6_Tick(object sender, EventArgs e)
	{
		if (!((Control)rjButton2).get_Visible())
		{
			((Control)rjButton13).set_Visible(false);
			((Control)rjButton12).set_Visible(false);
		}
		if (!((Control)rjButton4).get_Visible())
		{
			((Control)rjButton10).set_Visible(false);
			((Control)rjButton11).set_Visible(false);
		}
		if (!((Control)rjButton5).get_Visible())
		{
			((Control)rjButton7).set_Visible(false);
			((Control)rjButton6).set_Visible(false);
		}
		if (!((Control)rjButton3).get_Visible())
		{
			((Control)rjButton8).set_Visible(false);
			((Control)rjButton9).set_Visible(false);
			((Control)rjButton14).set_Visible(false);
		}
	}

	private void rjButton1_Click(object sender, EventArgs e)
	{
	}

	private void rjButton14_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
		Application.Exit();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
		Application.Exit();
	}

	private void label4_MouseEnter(object sender, EventArgs e)
	{
		((Control)rjButton14).set_Visible(false);
		((Control)rjButton13).set_Visible(false);
		((Control)rjButton12).set_Visible(false);
		((Control)rjButton11).set_Visible(false);
		((Control)rjButton10).set_Visible(false);
		((Control)rjButton9).set_Visible(false);
		((Control)rjButton8).set_Visible(false);
		((Control)rjButton7).set_Visible(false);
		((Control)rjButton6).set_Visible(false);
		((Control)rjButton5).set_Visible(false);
		((Control)rjButton4).set_Visible(false);
		((Control)rjButton3).set_Visible(false);
		((Control)rjButton2).set_Visible(false);
	}

	private void rjButton2_Click(object sender, EventArgs e)
	{
	}

	private void label4_Click(object sender, EventArgs e)
	{
	}

	private void appShortcutToDesktop(string nombre, string icono, string aplicacion)
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + nombre + ".url");
			streamWriter.WriteLine("[InternetShortcut]");
			streamWriter.WriteLine("URL=file:///" + aplicacion);
			streamWriter.WriteLine("IconIndex=0");
			streamWriter.WriteLine("IconFile=" + icono);
			streamWriter.Flush();
		}
		catch (Exception)
		{
		}
	}

	private static bool isRunning(int id)
	{
		try
		{
			Process.GetProcessById(id);
		}
		catch (InvalidOperationException)
		{
			return false;
		}
		catch (ArgumentException)
		{
			return false;
		}
		return true;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		GraphicsPath val = new GraphicsPath();
		val.AddEllipse(0, 0, ((Control)this).get_Width(), ((Control)this).get_Width());
		((Control)this).set_Region(new Region(val));
		if (File.Exists("C:\\slam_mbr_builder\\ndp472-devpack-enu.exe"))
		{
			((Control)rjButton9).set_Text("reinstall .net 4.7.2");
			((Control)rjButton14).set_Enabled(true);
		}
	}

	private void rjButton12_Click(object sender, EventArgs e)
	{
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		string text = null;
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		try
		{
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			if (((Control)rjButton12).get_Text() == "uninstall")
			{
				Directory.CreateDirectory(text + "\\slambuilder_temp");
				Directory.CreateDirectory("C:\\slam_ransomware_builder");
				Directory.CreateDirectory("C:\\slam_ransomware_builder\\Logs");
				Directory.Delete("C:\\slam_ransomware_builder", recursive: true);
				Directory.Delete(text + "\\slambuilder_temp", recursive: true);
				File.Delete(folderPath2 + "\\slam ransomware builder.url");
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = "cmd.exe";
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.Arguments = "/c cd " + folderPath2 + " & del /Q /F slam_ransomware_builder.url & exit";
				Process.Start(processStartInfo);
				((Control)rjButton12).set_Text("install");
				File.Delete(folderPath + "\\slam.zip");
				((Control)rjButton13).set_Enabled(false);
			}
			else
			{
				Directory.CreateDirectory(text + "\\slambuilder_temp");
				Directory.CreateDirectory("C:\\slam_ransomware_builder");
				Directory.Delete("C:\\slam_ransomware_builder", recursive: true);
				Directory.Delete(text + "\\slambuilder_temp", recursive: true);
				File.Delete(folderPath2 + "\\slam ransomware builder.url");
				ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
				processStartInfo2.FileName = "cmd.exe";
				processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo2.Arguments = "/c cd " + folderPath2 + " & del /Q /F slam_ransomware_builder.url & taskkill /F /IM slam.exe & exit";
				Process.Start(processStartInfo2);
				Directory.CreateDirectory(text + "\\slambuilder_temp");
				Directory.CreateDirectory("C:\\slam_ransomware_builder");
				Directory.Delete("C:\\slam_ransomware_builder", recursive: true);
				Directory.Delete(text + "\\slambuilder_temp", recursive: true);
				File.Delete(folderPath2 + "\\slam ransomware builder.url");
				ProcessStartInfo processStartInfo3 = new ProcessStartInfo();
				processStartInfo3.FileName = "cmd.exe";
				processStartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo3.Arguments = "/c cd " + folderPath2 + " & del /Q /F slam_ransomware_builder.url & exit";
				Process.Start(processStartInfo3);
				Directory.CreateDirectory("C:\\slam_ransomware_builder");
				File.WriteAllBytes(folderPath + "\\slam.zip", Resources.slam_ransomware_builder);
				((Control)label1).set_Text("100%");
				ZipFile.ExtractToDirectory(folderPath + "\\slam.zip", "C:\\slam_ransomware_builder");
				appShortcutToDesktop("slam_ransomware_builder", "C:\\slam_ransomware_builder\\1.ico", "C:\\slam_ransomware_builder\\start.exe");
				((Control)rjButton13).set_Enabled(true);
				File.Delete(folderPath + "\\slam.zip");
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("ha habido un error: " + ex.Message);
		}
	}

	private void rjButton13_Click(object sender, EventArgs e)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = "/c start C:\\slam_ransomware_builder\\start.exe & exit";
		Process.Start(processStartInfo);
	}

	private void timer7_Tick(object sender, EventArgs e)
	{
		try
		{
			if (Directory.Exists("C:\\slam_ransomware_builder\\") & File.Exists("C:\\slam_ransomware_builder\\slam.exe"))
			{
				((Control)rjButton12).set_Text("uninstall");
				((Control)rjButton13).set_Enabled(true);
			}
			else if (Directory.Exists("C:\\slam_ransomware_builder\\") & File.Exists("C:\\slam_ransomware_builder\\slam ransomware builder.exe"))
			{
				((Control)rjButton12).set_Text("uninstall");
				((Control)rjButton13).set_Enabled(true);
			}
			Process[] processesByName = Process.GetProcessesByName("slam");
			if (processesByName.Length == 0)
			{
				((Form)this).set_WindowState((FormWindowState)0);
			}
			else
			{
				((Form)this).set_WindowState((FormWindowState)1);
			}
		}
		catch (Exception)
		{
		}
	}

	private void rjButton8_Click(object sender, EventArgs e)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.Arguments = "/c start C:\\slam_mbr_builder\\start.exe & exit";
			Process.Start(processStartInfo);
		}
		catch (Exception)
		{
		}
	}

	private void cargando(object sender, DownloadProgressChangedEventArgs e)
	{
		circularProgressBar1.Value = e.ProgressPercentage;
		((Control)circularProgressBar1).set_Text(circularProgressBar1.Value + "%");
	}

	private void descargado(object sender, AsyncCompletedEventArgs e)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			ZipFile.ExtractToDirectory(folderPath + "\\mbr.zip", "C:\\slam_mbr_builder");
			if (File.Exists("C:\\slam_mbr_builder\\ndp472-devpack-enu.exe"))
			{
				Process.Start("C:\\slam_mbr_builder\\ndp472-devpack-enu.exe");
				((Control)rjButton9).set_Text("reinstall .net 4.7.2");
			}
			else
			{
				MessageBox.Show("an error has occurred with the download, one of the files does not exist, please uninstall and install again");
			}
			circularProgressBar1.Value = 0L;
			((Control)circularProgressBar1).set_Text("0%");
			((Control)circularProgressBar1).set_Visible(false);
			((Control)rjButton14).set_Enabled(true);
			File.WriteAllBytes(folderPath + "\\slam2.zip", Resources.slam_mbr_builder);
			ZipFile.ExtractToDirectory(folderPath + "\\slam2.zip", "C:\\slam_mbr_builder");
			appShortcutToDesktop("slam_mbr_builder", "C:\\slam_mbr_builder\\1.ico", "C:\\slam_mbr_builder\\start.exe");
		}
		catch (Exception)
		{
		}
	}

	private void rjButton9_Click(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (((Control)rjButton9).get_Text().Contains("4.7.2"))
			{
				if (File.Exists("C:\\slam_mbr_builder\\ndp472-devpack-enu.exe"))
				{
					Process.Start("C:\\slam_mbr_builder\\ndp472-devpack-enu.exe");
				}
				else
				{
					MessageBox.Show("an error has occurred with the download, one of the files does not exist, please uninstall and install again");
				}
				return;
			}
			Directory.CreateDirectory("C:\\slam_mbr_builder");
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			((Control)circularProgressBar1).set_Visible(true);
			WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += cargando;
			webClient.DownloadFileCompleted += descargado;
			webClient.DownloadFileAsync(new Uri("https://www.dropbox.com/s/zcmz26sgypmmk60/requierements.zip?dl=1"), folderPath + "\\mbr.zip", true);
		}
		catch (Exception)
		{
		}
	}

	private void rjButton14_Click_1(object sender, EventArgs e)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.Arguments = "/c taskkill /F /IM VBCSCompiler.exe & taskkill /F /IM cmd.exe & exit";
			Process.Start(processStartInfo);
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			Directory.Delete("C:\\slam_mbr_builder", recursive: true);
			((Control)rjButton14).set_Enabled(false);
			((Control)rjButton9).set_Text("install");
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
			processStartInfo2.FileName = "cmd.exe";
			processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo2.Arguments = "/c cd " + folderPath + " & del /Q /F slam_mbr_builder.url & exit";
			Process.Start(processStartInfo2);
		}
		catch (Exception)
		{
			ProcessStartInfo processStartInfo3 = new ProcessStartInfo();
			processStartInfo3.FileName = "cmd.exe";
			processStartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo3.Arguments = "/c taskkill /F /IM VBCSCompiler.exe & taskkill /F /IM cmd.exe & exit";
			Process.Start(processStartInfo3);
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			Directory.Delete("C:\\slam_mbr_builder", recursive: true);
			((Control)rjButton14).set_Enabled(false);
			((Control)rjButton9).set_Text("install");
			ProcessStartInfo processStartInfo4 = new ProcessStartInfo();
			processStartInfo4.FileName = "cmd.exe";
			processStartInfo4.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo4.Arguments = "/c cd " + folderPath2 + " & del /Q /F slam_mbr_builder.url & exit";
			Process.Start(processStartInfo4);
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected O, but got Unknown
		components = new Container();
		timer1 = new Timer(components);
		timer2 = new Timer(components);
		timer3 = new Timer(components);
		timer4 = new Timer(components);
		timer5 = new Timer(components);
		timer6 = new Timer(components);
		button1 = new Button();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		label6 = new Label();
		label7 = new Label();
		label8 = new Label();
		timer7 = new Timer(components);
		circularProgressBar1 = new CircularProgressBar();
		rjButton12 = new RJButton();
		rjButton13 = new RJButton();
		rjButton11 = new RJButton();
		rjButton10 = new RJButton();
		rjButton8 = new RJButton();
		rjButton9 = new RJButton();
		rjButton7 = new RJButton();
		rjButton6 = new RJButton();
		rjButton5 = new RJButton();
		rjButton4 = new RJButton();
		rjButton3 = new RJButton();
		rjButton2 = new RJButton();
		rjButton1 = new RJButton();
		rjButton14 = new RJButton();
		label9 = new Label();
		((Control)this).SuspendLayout();
		timer1.set_Interval(700);
		timer1.add_Tick((EventHandler)timer1_Tick);
		timer2.set_Interval(700);
		timer2.add_Tick((EventHandler)timer2_Tick);
		timer3.set_Interval(700);
		timer3.add_Tick((EventHandler)timer3_Tick);
		timer4.set_Interval(700);
		timer4.add_Tick((EventHandler)timer4_Tick);
		timer5.set_Interval(700);
		timer5.add_Tick((EventHandler)timer5_Tick);
		timer6.set_Enabled(true);
		timer6.add_Tick((EventHandler)timer6_Tick);
		((Control)button1).set_BackColor(Color.Red);
		((ButtonBase)button1).set_FlatStyle((FlatStyle)1);
		((Control)button1).set_Font(new Font("Microsoft Tai Le", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_Location(new Point(609, 9));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(40, 38));
		((Control)button1).set_TabIndex(13);
		((Control)button1).set_Text("X");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).set_Visible(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(412, 400));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(223, 208));
		((Control)label1).set_TabIndex(14);
		((Control)label1).set_Text("                                                                        \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
		((Control)label1).add_MouseEnter((EventHandler)label4_MouseEnter);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(18, 397));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(223, 208));
		((Control)label2).set_TabIndex(15);
		((Control)label2).set_Text("                                                                        \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
		((Control)label2).add_MouseEnter((EventHandler)label4_MouseEnter);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(18, 47));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(223, 208));
		((Control)label3).set_TabIndex(16);
		((Control)label3).set_Text("                                                                        \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
		((Control)label3).add_MouseEnter((EventHandler)label4_MouseEnter);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(426, 47));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(190, 208));
		((Control)label4).set_TabIndex(17);
		((Control)label4).set_Text("                                                             \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
		((Control)label4).add_Click((EventHandler)label4_Click);
		((Control)label4).add_MouseEnter((EventHandler)label4_MouseEnter);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(622, 103));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(22, 182));
		((Control)label5).set_TabIndex(18);
		((Control)label5).set_Text("     \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
		((Control)label5).add_MouseEnter((EventHandler)label4_MouseEnter);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(18, 243));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(22, 182));
		((Control)label6).set_TabIndex(19);
		((Control)label6).set_Text("     \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
		((Control)label6).add_MouseEnter((EventHandler)label4_MouseEnter);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Location(new Point(185, 58));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(277, 13));
		((Control)label7).set_TabIndex(20);
		((Control)label7).set_Text("                                                                                          ");
		((Control)label7).add_MouseEnter((EventHandler)label4_MouseEnter);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Location(new Point(185, 583));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(277, 13));
		((Control)label8).set_TabIndex(21);
		((Control)label8).set_Text("                                                                                          ");
		((Control)label8).add_MouseEnter((EventHandler)label4_MouseEnter);
		timer7.set_Enabled(true);
		timer7.add_Tick((EventHandler)timer7_Tick);
		((Control)circularProgressBar1).set_BackColor(Color.Transparent);
		((Control)circularProgressBar1).set_BackgroundImageLayout((ImageLayout)0);
		circularProgressBar1.BarColor1 = Color.MediumSlateBlue;
		circularProgressBar1.BarColor2 = Color.Magenta;
		circularProgressBar1.BarWidth = 5f;
		((Control)circularProgressBar1).set_Font(new Font("Segoe UI", 15f));
		((Control)circularProgressBar1).set_ForeColor(Color.Orchid);
		circularProgressBar1.GradientMode = (LinearGradientMode)2;
		circularProgressBar1.LineColor = Color.DimGray;
		circularProgressBar1.LineWidth = 1;
		((Control)circularProgressBar1).set_Location(new Point(259, 254));
		circularProgressBar1.Maximum = 100L;
		((Control)circularProgressBar1).set_MinimumSize(new Size(100, 100));
		((Control)circularProgressBar1).set_Name("circularProgressBar1");
		circularProgressBar1.ProgressShape = CircularProgressBar._ProgressShape.Round;
		((Control)circularProgressBar1).set_RightToLeft((RightToLeft)0);
		((Control)circularProgressBar1).set_Size(new Size(141, 141));
		((Control)circularProgressBar1).set_TabIndex(22);
		((Control)circularProgressBar1).set_Text("0");
		circularProgressBar1.TextMode = CircularProgressBar._TextMode.Percentage;
		circularProgressBar1.Value = 0L;
		((Control)circularProgressBar1).set_Visible(false);
		((Control)rjButton12).set_BackColor(Color.MediumSlateBlue);
		rjButton12.BackgroundColor = Color.MediumSlateBlue;
		rjButton12.BorderColor = Color.DarkSlateBlue;
		rjButton12.BorderRadius = 32;
		rjButton12.BorderSize = 3;
		((ButtonBase)rjButton12).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)rjButton12).set_FlatStyle((FlatStyle)0);
		((Control)rjButton12).set_ForeColor(Color.White);
		((Control)rjButton12).set_Location(new Point(337, 77));
		((Control)rjButton12).set_Name("rjButton12");
		((Control)rjButton12).set_Size(new Size(68, 65));
		((Control)rjButton12).set_TabIndex(12);
		((Control)rjButton12).set_Text("install");
		rjButton12.TextColor = Color.White;
		((ButtonBase)rjButton12).set_UseVisualStyleBackColor(false);
		((Control)rjButton12).set_Visible(false);
		((Control)rjButton12).add_Click((EventHandler)rjButton12_Click);
		((Control)rjButton12).add_MouseEnter((EventHandler)rjButton12_MouseEnter);
		((Control)rjButton12).add_MouseLeave((EventHandler)rjButton12_MouseLeave);
		((Control)rjButton13).set_BackColor(Color.MediumSlateBlue);
		rjButton13.BackgroundColor = Color.MediumSlateBlue;
		rjButton13.BorderColor = Color.DarkSlateBlue;
		rjButton13.BorderRadius = 32;
		rjButton13.BorderSize = 3;
		((Control)rjButton13).set_Enabled(false);
		((ButtonBase)rjButton13).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)rjButton13).set_FlatStyle((FlatStyle)0);
		((Control)rjButton13).set_ForeColor(Color.White);
		((Control)rjButton13).set_Location(new Point(259, 77));
		((Control)rjButton13).set_Name("rjButton13");
		((Control)rjButton13).set_Size(new Size(68, 65));
		((Control)rjButton13).set_TabIndex(11);
		((Control)rjButton13).set_Text("start");
		rjButton13.TextColor = Color.White;
		((ButtonBase)rjButton13).set_UseVisualStyleBackColor(false);
		((Control)rjButton13).set_Visible(false);
		((Control)rjButton13).add_Click((EventHandler)rjButton13_Click);
		((Control)rjButton13).add_MouseEnter((EventHandler)rjButton12_MouseEnter);
		((Control)rjButton13).add_MouseLeave((EventHandler)rjButton12_MouseLeave);
		((Control)rjButton11).set_BackColor(Color.MediumSlateBlue);
		rjButton11.BackgroundColor = Color.MediumSlateBlue;
		rjButton11.BorderColor = Color.DarkSlateBlue;
		rjButton11.BorderRadius = 32;
		rjButton11.BorderSize = 3;
		((ButtonBase)rjButton11).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)rjButton11).set_FlatStyle((FlatStyle)0);
		((Control)rjButton11).set_ForeColor(Color.White);
		((Control)rjButton11).set_Location(new Point(337, 506));
		((Control)rjButton11).set_Name("rjButton11");
		((Control)rjButton11).set_Size(new Size(68, 65));
		((Control)rjButton11).set_TabIndex(10);
		((Control)rjButton11).set_Text("install");
		rjButton11.TextColor = Color.White;
		((ButtonBase)rjButton11).set_UseVisualStyleBackColor(false);
		((Control)rjButton11).set_Visible(false);
		((Control)rjButton11).add_MouseEnter((EventHandler)rjButton11_MouseEnter);
		((Control)rjButton11).add_MouseLeave((EventHandler)rjButton11_MouseLeave);
		((Control)rjButton10).set_BackColor(Color.MediumSlateBlue);
		rjButton10.BackgroundColor = Color.MediumSlateBlue;
		rjButton10.BorderColor = Color.DarkSlateBlue;
		rjButton10.BorderRadius = 32;
		rjButton10.BorderSize = 3;
		((ButtonBase)rjButton10).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)rjButton10).set_FlatStyle((FlatStyle)0);
		((Control)rjButton10).set_ForeColor(Color.White);
		((Control)rjButton10).set_Location(new Point(259, 506));
		((Control)rjButton10).set_Name("rjButton10");
		((Control)rjButton10).set_Size(new Size(68, 65));
		((Control)rjButton10).set_TabIndex(9);
		((Control)rjButton10).set_Text("start");
		rjButton10.TextColor = Color.White;
		((ButtonBase)rjButton10).set_UseVisualStyleBackColor(false);
		((Control)rjButton10).set_Visible(false);
		((Control)rjButton10).add_MouseEnter((EventHandler)rjButton11_MouseEnter);
		((Control)rjButton10).add_MouseLeave((EventHandler)rjButton11_MouseLeave);
		((Control)rjButton8).set_BackColor(Color.MediumSlateBlue);
		rjButton8.BackgroundColor = Color.MediumSlateBlue;
		rjButton8.BorderColor = Color.DarkSlateBlue;
		rjButton8.BorderRadius = 32;
		rjButton8.BorderSize = 3;
		((ButtonBase)rjButton8).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)rjButton8).set_FlatStyle((FlatStyle)0);
		((Control)rjButton8).set_ForeColor(Color.White);
		((Control)rjButton8).set_Location(new Point(514, 258));
		((Control)rjButton8).set_Name("rjButton8");
		((Control)rjButton8).set_Size(new Size(68, 65));
		((Control)rjButton8).set_TabIndex(8);
		((Control)rjButton8).set_Text("start");
		rjButton8.TextColor = Color.White;
		((ButtonBase)rjButton8).set_UseVisualStyleBackColor(false);
		((Control)rjButton8).set_Visible(false);
		((Control)rjButton8).add_Click((EventHandler)rjButton8_Click);
		((Control)rjButton8).add_MouseEnter((EventHandler)rjButton8_MouseEnter);
		((Control)rjButton8).add_MouseLeave((EventHandler)rjButton8_MouseLeave);
		((Control)rjButton9).set_BackColor(Color.MediumSlateBlue);
		rjButton9.BackgroundColor = Color.MediumSlateBlue;
		((Control)rjButton9).set_BackgroundImageLayout((ImageLayout)3);
		rjButton9.BorderColor = Color.DarkSlateBlue;
		rjButton9.BorderRadius = 32;
		rjButton9.BorderSize = 3;
		((ButtonBase)rjButton9).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)rjButton9).set_FlatStyle((FlatStyle)0);
		((Control)rjButton9).set_ForeColor(Color.White);
		((Control)rjButton9).set_Location(new Point(514, 329));
		((Control)rjButton9).set_Name("rjButton9");
		((Control)rjButton9).set_Size(new Size(68, 65));
		((Control)rjButton9).set_TabIndex(7);
		((Control)rjButton9).set_Text("install");
		rjButton9.TextColor = Color.White;
		((ButtonBase)rjButton9).set_UseVisualStyleBackColor(false);
		((Control)rjButton9).set_Visible(false);
		((Control)rjButton9).add_Click((EventHandler)rjButton9_Click);
		((Control)rjButton9).add_MouseEnter((EventHandler)rjButton8_MouseEnter);
		((Control)rjButton9).add_MouseLeave((EventHandler)rjButton8_MouseLeave);
		((Control)rjButton7).set_BackColor(Color.MediumSlateBlue);
		rjButton7.BackgroundColor = Color.MediumSlateBlue;
		rjButton7.BorderColor = Color.DarkSlateBlue;
		rjButton7.BorderRadius = 32;
		rjButton7.BorderSize = 3;
		((ButtonBase)rjButton7).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)rjButton7).set_FlatStyle((FlatStyle)0);
		((Control)rjButton7).set_ForeColor(Color.White);
		((Control)rjButton7).set_Location(new Point(77, 258));
		((Control)rjButton7).set_Name("rjButton7");
		((Control)rjButton7).set_Size(new Size(68, 65));
		((Control)rjButton7).set_TabIndex(6);
		((Control)rjButton7).set_Text("start");
		rjButton7.TextColor = Color.White;
		((ButtonBase)rjButton7).set_UseVisualStyleBackColor(false);
		((Control)rjButton7).set_Visible(false);
		((Control)rjButton7).add_MouseEnter((EventHandler)rjButton7_MouseEnter);
		((Control)rjButton7).add_MouseLeave((EventHandler)rjButton7_MouseLeave);
		((Control)rjButton6).set_BackColor(Color.MediumSlateBlue);
		rjButton6.BackgroundColor = Color.MediumSlateBlue;
		rjButton6.BorderColor = Color.DarkSlateBlue;
		rjButton6.BorderRadius = 32;
		rjButton6.BorderSize = 3;
		((ButtonBase)rjButton6).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)rjButton6).set_FlatStyle((FlatStyle)0);
		((Control)rjButton6).set_ForeColor(Color.White);
		((Control)rjButton6).set_Location(new Point(77, 329));
		((Control)rjButton6).set_Name("rjButton6");
		((Control)rjButton6).set_Size(new Size(68, 65));
		((Control)rjButton6).set_TabIndex(5);
		((Control)rjButton6).set_Text("install");
		rjButton6.TextColor = Color.White;
		((ButtonBase)rjButton6).set_UseVisualStyleBackColor(false);
		((Control)rjButton6).set_Visible(false);
		((Control)rjButton6).add_MouseEnter((EventHandler)rjButton7_MouseEnter);
		((Control)rjButton6).add_MouseLeave((EventHandler)rjButton7_MouseLeave);
		((Control)rjButton5).set_BackColor(Color.MediumSlateBlue);
		rjButton5.BackgroundColor = Color.MediumSlateBlue;
		rjButton5.BorderColor = Color.DarkSlateBlue;
		rjButton5.BorderRadius = 50;
		rjButton5.BorderSize = 3;
		((ButtonBase)rjButton5).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)rjButton5).set_FlatStyle((FlatStyle)0);
		((Control)rjButton5).set_ForeColor(Color.White);
		((Control)rjButton5).set_Location(new Point(151, 274));
		((Control)rjButton5).set_Name("rjButton5");
		((Control)rjButton5).set_Size(new Size(102, 100));
		((Control)rjButton5).set_TabIndex(4);
		((Control)rjButton5).set_Text("comming soon");
		rjButton5.TextColor = Color.White;
		((ButtonBase)rjButton5).set_UseVisualStyleBackColor(false);
		((Control)rjButton5).set_Visible(false);
		((Control)rjButton5).add_MouseEnter((EventHandler)rjButton5_MouseEnter);
		((Control)rjButton5).add_MouseLeave((EventHandler)rjButton5_MouseLeave);
		((Control)rjButton4).set_BackColor(Color.MediumSlateBlue);
		rjButton4.BackgroundColor = Color.MediumSlateBlue;
		rjButton4.BorderColor = Color.DarkSlateBlue;
		rjButton4.BorderRadius = 50;
		rjButton4.BorderSize = 3;
		((ButtonBase)rjButton4).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)rjButton4).set_FlatStyle((FlatStyle)0);
		((Control)rjButton4).set_ForeColor(Color.White);
		((Control)rjButton4).set_Location(new Point(279, 400));
		((Control)rjButton4).set_Name("rjButton4");
		((Control)rjButton4).set_Size(new Size(102, 100));
		((Control)rjButton4).set_TabIndex(3);
		((Control)rjButton4).set_Text("slam screenlocker builder\r\n(comming soon)");
		rjButton4.TextColor = Color.White;
		((ButtonBase)rjButton4).set_UseVisualStyleBackColor(false);
		((Control)rjButton4).set_Visible(false);
		((Control)rjButton4).add_MouseEnter((EventHandler)rjButton4_MouseEnter);
		((Control)rjButton4).add_MouseLeave((EventHandler)rjButton4_MouseLeave);
		((Control)rjButton3).set_BackColor(Color.MediumSlateBlue);
		rjButton3.BackgroundColor = Color.MediumSlateBlue;
		rjButton3.BorderColor = Color.DarkSlateBlue;
		rjButton3.BorderRadius = 50;
		rjButton3.BorderSize = 3;
		((ButtonBase)rjButton3).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)rjButton3).set_FlatStyle((FlatStyle)0);
		((Control)rjButton3).set_ForeColor(Color.White);
		((Control)rjButton3).set_Location(new Point(406, 274));
		((Control)rjButton3).set_Name("rjButton3");
		((Control)rjButton3).set_Size(new Size(102, 100));
		((Control)rjButton3).set_TabIndex(2);
		((Control)rjButton3).set_Text("slam mbr builder\r\n(pre alpha 0.0.1)");
		rjButton3.TextColor = Color.White;
		((ButtonBase)rjButton3).set_UseVisualStyleBackColor(false);
		((Control)rjButton3).set_Visible(false);
		((Control)rjButton3).add_MouseEnter((EventHandler)rjButton3_MouseEnter);
		((Control)rjButton3).add_MouseLeave((EventHandler)rjButton3_MouseLeave);
		((Control)rjButton2).set_BackColor(Color.MediumSlateBlue);
		rjButton2.BackgroundColor = Color.MediumSlateBlue;
		rjButton2.BorderColor = Color.DarkSlateBlue;
		rjButton2.BorderRadius = 50;
		rjButton2.BorderSize = 3;
		((ButtonBase)rjButton2).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)rjButton2).set_FlatStyle((FlatStyle)0);
		((Control)rjButton2).set_ForeColor(Color.White);
		((Control)rjButton2).set_Location(new Point(279, 148));
		((Control)rjButton2).set_Name("rjButton2");
		((Control)rjButton2).set_Size(new Size(102, 100));
		((Control)rjButton2).set_TabIndex(1);
		((Control)rjButton2).set_Text("slam ransomware builder (1.7)");
		rjButton2.TextColor = Color.White;
		((ButtonBase)rjButton2).set_UseVisualStyleBackColor(false);
		((Control)rjButton2).set_Visible(false);
		((Control)rjButton2).add_Click((EventHandler)rjButton2_Click);
		((Control)rjButton2).add_MouseEnter((EventHandler)rjButton2_MouseEnter);
		((Control)rjButton2).add_MouseLeave((EventHandler)rjButton2_MouseLeave);
		((Control)rjButton1).set_BackColor(Color.MediumSlateBlue);
		rjButton1.BackgroundColor = Color.MediumSlateBlue;
		rjButton1.BorderColor = Color.DarkSlateBlue;
		rjButton1.BorderRadius = 67;
		rjButton1.BorderSize = 3;
		((ButtonBase)rjButton1).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)rjButton1).set_FlatStyle((FlatStyle)0);
		((Control)rjButton1).set_ForeColor(Color.White);
		((Control)rjButton1).set_Location(new Point(259, 254));
		((Control)rjButton1).set_Name("rjButton1");
		((Control)rjButton1).set_Size(new Size(141, 140));
		((Control)rjButton1).set_TabIndex(0);
		((Control)rjButton1).set_Text("slam builders");
		rjButton1.TextColor = Color.White;
		((ButtonBase)rjButton1).set_UseVisualStyleBackColor(false);
		((Control)rjButton1).add_Click((EventHandler)rjButton1_Click);
		((Control)rjButton1).add_MouseEnter((EventHandler)rjButton1_MouseEnter);
		((Control)rjButton1).add_MouseLeave((EventHandler)rjButton1_MouseLeave);
		((Control)rjButton14).set_BackColor(Color.MediumSlateBlue);
		rjButton14.BackgroundColor = Color.MediumSlateBlue;
		((Control)rjButton14).set_BackgroundImageLayout((ImageLayout)3);
		rjButton14.BorderColor = Color.DarkSlateBlue;
		rjButton14.BorderRadius = 32;
		rjButton14.BorderSize = 3;
		((Control)rjButton14).set_Enabled(false);
		((ButtonBase)rjButton14).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)rjButton14).set_FlatStyle((FlatStyle)0);
		((Control)rjButton14).set_ForeColor(Color.White);
		((Control)rjButton14).set_Location(new Point(581, 292));
		((Control)rjButton14).set_Name("rjButton14");
		((Control)rjButton14).set_Size(new Size(68, 65));
		((Control)rjButton14).set_TabIndex(23);
		((Control)rjButton14).set_Text("uninstall");
		rjButton14.TextColor = Color.White;
		((ButtonBase)rjButton14).set_UseVisualStyleBackColor(false);
		((Control)rjButton14).set_Visible(false);
		((Control)rjButton14).add_Click((EventHandler)rjButton14_Click_1);
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Location(new Point(627, 369));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(22, 182));
		((Control)label9).set_TabIndex(24);
		((Control)label9).set_Text("     \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(661, 661));
		((Control)this).get_Controls().Add((Control)(object)label9);
		((Control)this).get_Controls().Add((Control)(object)rjButton14);
		((Control)this).get_Controls().Add((Control)(object)circularProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)rjButton12);
		((Control)this).get_Controls().Add((Control)(object)rjButton13);
		((Control)this).get_Controls().Add((Control)(object)rjButton11);
		((Control)this).get_Controls().Add((Control)(object)rjButton10);
		((Control)this).get_Controls().Add((Control)(object)rjButton8);
		((Control)this).get_Controls().Add((Control)(object)rjButton9);
		((Control)this).get_Controls().Add((Control)(object)rjButton7);
		((Control)this).get_Controls().Add((Control)(object)rjButton6);
		((Control)this).get_Controls().Add((Control)(object)rjButton5);
		((Control)this).get_Controls().Add((Control)(object)rjButton4);
		((Control)this).get_Controls().Add((Control)(object)rjButton3);
		((Control)this).get_Controls().Add((Control)(object)rjButton2);
		((Control)this).get_Controls().Add((Control)(object)rjButton1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
