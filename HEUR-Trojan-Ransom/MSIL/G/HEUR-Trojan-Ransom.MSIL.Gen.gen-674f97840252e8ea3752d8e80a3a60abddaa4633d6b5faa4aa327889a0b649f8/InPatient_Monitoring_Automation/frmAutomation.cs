using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using InPatient_Monitoring_Automation.Classes;

namespace InPatient_Monitoring_Automation;

public class frmAutomation : Form
{
	public const int WM_NCLBUTTONDOWN = 161;

	public const int HTCAPTION = 2;

	private IContainer components;

	public ProgressBar progressBar;

	private Button btnStart;

	private Label label1;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	[DllImport("User32.dll")]
	public static extern bool ReleaseCapture();

	[DllImport("User32.dll")]
	public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

	public frmAutomation()
	{
		InitializeComponent();
	}

	private void btnStart_Click(object sender, EventArgs e)
	{
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		Log log = new Log();
		AdMedikaAutomation adMedikaAutomation = new AdMedikaAutomation();
		Excel_Formatting excel_Formatting = new Excel_Formatting();
		string user_def_path = global_variable.user_def_path;
		string text = user_def_path + "\\Inpatient Monitoring Report\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("MMM") + "\\" + DateTime.Now.ToString("dd");
		new Excel_Formatting();
		CreateSummary createSummary = new CreateSummary();
		Outlook_Send outlook_Send = new Outlook_Send();
		ErrorNExceptionLog errorNExceptionLog = new ErrorNExceptionLog();
		string path = Environment.CurrentDirectory + "\\Resources\\Config.xlsx";
		int num = 0;
		log = adMedikaAutomation.check_path_email_flag(path);
		text = global_variable.user_def_path + "\\Inpatient Monitoring Report\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("MMM") + "\\" + DateTime.Now.ToString("dd");
		if (log.status)
		{
			num += 10;
			progressBar.set_Value(num);
			((Control)label1).set_Text("Downloading Claim Files from Admedika Portal.....");
			log = adMedikaAutomation.AdMedikaPortalAutomation();
			if (log.status)
			{
				num += 10;
				progressBar.set_Value(num);
				log = excel_Formatting.sub_office_code();
				if (log.status)
				{
					num += 10;
					progressBar.set_Value(num);
					log = excel_Formatting.rename(text);
					if (log.status)
					{
						num += 10;
						progressBar.set_Value(num);
						log = excel_Formatting.copydata(text);
						if (log.status)
						{
							num += 10;
							progressBar.set_Value(num);
							((Control)label1).set_Text("Formatting Downloaded Claim Files......");
							log = excel_Formatting.excel_format(text);
							if (log.status)
							{
								num += 10;
								progressBar.set_Value(num);
								log = excel_Formatting.nda(text);
								if (log.status)
								{
									num += 10;
									progressBar.set_Value(num);
									((Control)label1).set_Text("Creating Summary File......");
									log = createSummary.CreateSummaryFile();
									if (log.status)
									{
										num += 10;
										progressBar.set_Value(num);
										((Control)label1).set_Text("Sending/Saving Emails.....");
										log = outlook_Send.Outlook_SendMail();
									}
								}
							}
						}
					}
				}
			}
		}
		if (!log.status)
		{
			num = 90;
			progressBar.set_Value(90);
			((Control)label1).set_Text("Execution Terminated due to Error");
			errorNExceptionLog.CreateLog(log);
			errorNExceptionLog.SendLogMail(log);
		}
		else
		{
			num += 20;
			progressBar.set_Value(num);
			((Control)label1).set_Text("Execution Complete");
			MessageBox.Show("Execution Complete");
		}
		File.Delete(global_variable.user_def_path + "\\Sub_Office_Codes.xlsx");
		num = 0;
		progressBar.set_Value(0);
		((Control)label1).set_Text("");
	}

	private void Form1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			ReleaseCapture();
			SendMessage(((Control)this).get_Handle(), 161, 2, 0);
		}
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void frmAutomation_Load(object sender, EventArgs e)
	{
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
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmAutomation));
		progressBar = new ProgressBar();
		btnStart = new Button();
		label1 = new Label();
		pictureBox1 = new PictureBox();
		pictureBox2 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)progressBar).set_ForeColor(Color.Lime);
		((Control)progressBar).set_Location(new Point(36, 98));
		((Control)progressBar).set_Name("progressBar");
		((Control)progressBar).set_Size(new Size(393, 23));
		((Control)progressBar).set_TabIndex(0);
		((Control)btnStart).set_BackColor(Color.Purple);
		((Control)btnStart).set_Font(new Font("Modern No. 20", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnStart).set_ForeColor(SystemColors.Window);
		((Control)btnStart).set_Location(new Point(161, 48));
		((Control)btnStart).set_Name("btnStart");
		((Control)btnStart).set_Size(new Size(141, 30));
		((Control)btnStart).set_TabIndex(1);
		((Control)btnStart).set_Text("START");
		((ButtonBase)btnStart).set_UseVisualStyleBackColor(false);
		((Control)btnStart).add_Click((EventHandler)btnStart_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_ForeColor(Color.Black);
		((Control)label1).set_Location(new Point(33, 135));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(0, 13));
		((Control)label1).set_TabIndex(2);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(1, -4));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(81, 51));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox1.set_TabIndex(3);
		pictureBox1.set_TabStop(false);
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(375, 149));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(100, 50));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox2.set_TabIndex(4);
		pictureBox2.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(475, 198));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)btnStart);
		((Control)this).get_Controls().Add((Control)(object)progressBar);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmAutomation");
		((Control)this).set_Text("Inpatient Monitoring Report");
		((Form)this).add_Load((EventHandler)frmAutomation_Load);
		((Control)this).add_MouseDown(new MouseEventHandler(Form1_MouseDown));
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
