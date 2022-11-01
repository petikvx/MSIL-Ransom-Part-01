using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Suite;
using YullySpoofer.UserControls;
using mafioso;

namespace YullySpoofer;

public class Client : Form
{
	private IContainer components;

	private SiticoneButton siticoneButton3;

	private SiticoneButton siticoneButton1;

	private SiticoneButton siticoneButton2;

	private Panel panel1;

	private Guna2Button guna2Button5;

	private Guna2Button guna2Button1;

	private Guna2Button guna2Button7;

	private Guna2Button guna2Button6;

	private Panel panelContainer;

	private SiticoneButton siticoneButton4;

	public Client()
	{
		InitializeComponent();
	}

	private void Client_Load(object sender, EventArgs e)
	{
		UC_Dashboard userControl = new UC_Dashboard();
		addUserControl((UserControl)(object)userControl);
		try
		{
			Program.KeyAuthApp.check();
			((CustomButtonBase)siticoneButton1).PerformClick();
			UnixTimeToDateTime(long.Parse(Program.KeyAuthApp.user_data.createdate));
			UnixTimeToDateTime(long.Parse(Program.KeyAuthApp.user_data.lastlogin));
		}
		catch (Exception ex)
		{
			Exception ex2 = ex;
			string[] array = new string[6] { "ERROR MESSAGE : ", ex2.Message, " | LINE OF CODE : ", ex2.Source, " ", null };
			MethodBase targetSite = ex2.TargetSite;
			string text = (array[5] = ((!(targetSite != null)) ? null : targetSite.ToString()));
			OnlineErrorReport.SendException(string.Concat(array), Severe: true);
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

	[DllImport("DwmApi")]
	private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

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
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected O, but got Unknown
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected O, but got Unknown
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected O, but got Unknown
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected O, but got Unknown
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected O, but got Unknown
		//IL_0af1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba0: Expected O, but got Unknown
		//IL_0ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caf: Expected O, but got Unknown
		//IL_0d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2a: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Client));
		siticoneButton3 = new SiticoneButton();
		siticoneButton1 = new SiticoneButton();
		siticoneButton2 = new SiticoneButton();
		siticoneButton4 = new SiticoneButton();
		panel1 = new Panel();
		guna2Button7 = new Guna2Button();
		guna2Button6 = new Guna2Button();
		guna2Button5 = new Guna2Button();
		guna2Button1 = new Guna2Button();
		panelContainer = new Panel();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		siticoneButton3.get_CheckedState().set_Parent((CustomButtonBase)(object)siticoneButton3);
		siticoneButton3.get_CustomImages().set_Parent((CustomButtonBase)(object)siticoneButton3);
		((Control)siticoneButton3).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)siticoneButton3).set_ForeColor(Color.White);
		siticoneButton3.get_HoveredState().set_Parent((CustomButtonBase)(object)siticoneButton3);
		((Control)siticoneButton3).set_Location(new Point(246, 21));
		((Control)siticoneButton3).set_Name("siticoneButton3");
		siticoneButton3.get_ShadowDecoration().set_Parent((Control)(object)siticoneButton3);
		((Control)siticoneButton3).set_Size(new Size(123, 45));
		((Control)siticoneButton3).set_TabIndex(3);
		((Control)siticoneButton3).set_Text("DOCUMENTATION");
		((Control)siticoneButton3).add_Click((EventHandler)siticoneButton3_Click);
		siticoneButton1.get_CheckedState().set_Parent((CustomButtonBase)(object)siticoneButton1);
		siticoneButton1.get_CustomImages().set_Parent((CustomButtonBase)(object)siticoneButton1);
		((Control)siticoneButton1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)siticoneButton1).set_ForeColor(Color.White);
		siticoneButton1.get_HoveredState().set_Parent((CustomButtonBase)(object)siticoneButton1);
		((Control)siticoneButton1).set_Location(new Point(68, 21));
		((Control)siticoneButton1).set_Name("siticoneButton1");
		siticoneButton1.get_ShadowDecoration().set_Parent((Control)(object)siticoneButton1);
		((Control)siticoneButton1).set_Size(new Size(102, 45));
		((Control)siticoneButton1).set_TabIndex(1);
		((Control)siticoneButton1).set_Text("DASHBOARD");
		((Control)siticoneButton1).add_Click((EventHandler)siticoneButton1_Click_1);
		siticoneButton2.get_CheckedState().set_Parent((CustomButtonBase)(object)siticoneButton2);
		siticoneButton2.get_CustomImages().set_Parent((CustomButtonBase)(object)siticoneButton2);
		((Control)siticoneButton2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)siticoneButton2).set_ForeColor(Color.White);
		siticoneButton2.get_HoveredState().set_Parent((CustomButtonBase)(object)siticoneButton2);
		((Control)siticoneButton2).set_Location(new Point(167, 21));
		((Control)siticoneButton2).set_Name("siticoneButton2");
		siticoneButton2.get_ShadowDecoration().set_Parent((Control)(object)siticoneButton2);
		((Control)siticoneButton2).set_Size(new Size(82, 45));
		((Control)siticoneButton2).set_TabIndex(2);
		((Control)siticoneButton2).set_Text("SETTINGS");
		((Control)siticoneButton2).add_Click((EventHandler)siticoneButton2_Click_1);
		siticoneButton4.get_CheckedState().set_Parent((CustomButtonBase)(object)siticoneButton4);
		siticoneButton4.get_CustomImages().set_Parent((CustomButtonBase)(object)siticoneButton4);
		((Control)siticoneButton4).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)siticoneButton4).set_ForeColor(Color.White);
		siticoneButton4.get_HoveredState().set_Parent((CustomButtonBase)(object)siticoneButton4);
		((Control)siticoneButton4).set_Location(new Point(370, 21));
		((Control)siticoneButton4).set_Name("siticoneButton4");
		siticoneButton4.get_ShadowDecoration().set_Parent((Control)(object)siticoneButton4);
		((Control)siticoneButton4).set_Size(new Size(74, 45));
		((Control)siticoneButton4).set_TabIndex(4);
		((Control)siticoneButton4).set_Text("PROFILE");
		((Control)siticoneButton4).add_Click((EventHandler)siticoneButton4_Click);
		((Control)panel1).set_BackColor(Color.FromArgb(10, 10, 10));
		((Control)panel1).get_Controls().Add((Control)(object)guna2Button7);
		((Control)panel1).get_Controls().Add((Control)(object)guna2Button6);
		((Control)panel1).get_Controls().Add((Control)(object)guna2Button5);
		((Control)panel1).get_Controls().Add((Control)(object)guna2Button1);
		((Control)panel1).set_Location(new Point(-13, -4));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(761, 49));
		((Control)panel1).set_TabIndex(0);
		((Control)panel1).add_Paint(new PaintEventHandler(panel1_Paint));
		guna2Button7.set_Animated(true);
		guna2Button7.set_ButtonMode((ButtonMode)1);
		guna2Button7.get_CheckedState().set_CustomBorderColor(Color.Fuchsia);
		guna2Button7.get_CheckedState().set_FillColor(Color.FromArgb(10, 10, 10));
		guna2Button7.get_CheckedState().set_ForeColor(Color.Fuchsia);
		guna2Button7.set_CustomBorderThickness(new Padding(0, 0, 0, 1));
		guna2Button7.get_DisabledState().set_BorderColor(Color.DarkGray);
		guna2Button7.get_DisabledState().set_CustomBorderColor(Color.DarkGray);
		guna2Button7.get_DisabledState().set_FillColor(Color.FromArgb(169, 169, 169));
		guna2Button7.get_DisabledState().set_ForeColor(Color.FromArgb(141, 141, 141));
		guna2Button7.set_FillColor(Color.FromArgb(10, 10, 10));
		((Control)guna2Button7).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)guna2Button7).set_ForeColor(Color.White);
		guna2Button7.get_HoverState().set_CustomBorderColor(Color.FromArgb(0, 0, 0, 1));
		guna2Button7.get_HoverState().set_FillColor(Color.FromArgb(10, 10, 10));
		((Control)guna2Button7).set_Location(new Point(411, 7));
		((Control)guna2Button7).set_Name("guna2Button7");
		((Control)guna2Button7).set_Size(new Size(87, 39));
		((Control)guna2Button7).set_TabIndex(10);
		((Control)guna2Button7).set_Text("PROFILE");
		((Control)guna2Button7).add_Click((EventHandler)guna2Button7_Click);
		guna2Button6.set_Animated(true);
		guna2Button6.set_ButtonMode((ButtonMode)1);
		guna2Button6.get_CheckedState().set_CustomBorderColor(Color.Fuchsia);
		guna2Button6.get_CheckedState().set_FillColor(Color.FromArgb(10, 10, 10));
		guna2Button6.get_CheckedState().set_ForeColor(Color.Fuchsia);
		guna2Button6.set_CustomBorderThickness(new Padding(0, 0, 0, 1));
		guna2Button6.get_DisabledState().set_BorderColor(Color.DarkGray);
		guna2Button6.get_DisabledState().set_CustomBorderColor(Color.DarkGray);
		guna2Button6.get_DisabledState().set_FillColor(Color.FromArgb(169, 169, 169));
		guna2Button6.get_DisabledState().set_ForeColor(Color.FromArgb(141, 141, 141));
		guna2Button6.set_FillColor(Color.FromArgb(10, 10, 10));
		((Control)guna2Button6).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)guna2Button6).set_ForeColor(Color.White);
		guna2Button6.get_HoverState().set_CustomBorderColor(Color.FromArgb(0, 0, 0, 1));
		guna2Button6.get_HoverState().set_FillColor(Color.FromArgb(10, 10, 10));
		((Control)guna2Button6).set_Location(new Point(253, 7));
		((Control)guna2Button6).set_Name("guna2Button6");
		((Control)guna2Button6).set_Size(new Size(156, 39));
		((Control)guna2Button6).set_TabIndex(9);
		((Control)guna2Button6).set_Text("DOCUMENTATION");
		((Control)guna2Button6).add_Click((EventHandler)guna2Button6_Click);
		guna2Button5.set_Animated(true);
		guna2Button5.set_ButtonMode((ButtonMode)1);
		guna2Button5.get_CheckedState().set_CustomBorderColor(Color.Fuchsia);
		guna2Button5.get_CheckedState().set_FillColor(Color.FromArgb(10, 10, 10));
		guna2Button5.get_CheckedState().set_ForeColor(Color.Fuchsia);
		guna2Button5.set_CustomBorderThickness(new Padding(0, 0, 0, 1));
		guna2Button5.get_DisabledState().set_BorderColor(Color.DarkGray);
		guna2Button5.get_DisabledState().set_CustomBorderColor(Color.DarkGray);
		guna2Button5.get_DisabledState().set_FillColor(Color.FromArgb(169, 169, 169));
		guna2Button5.get_DisabledState().set_ForeColor(Color.FromArgb(141, 141, 141));
		guna2Button5.set_FillColor(Color.FromArgb(10, 10, 10));
		((Control)guna2Button5).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)guna2Button5).set_ForeColor(Color.White);
		guna2Button5.get_HoverState().set_CustomBorderColor(Color.FromArgb(0, 0, 0, 1));
		guna2Button5.get_HoverState().set_FillColor(Color.FromArgb(10, 10, 10));
		((Control)guna2Button5).set_Location(new Point(158, 7));
		((Control)guna2Button5).set_Name("guna2Button5");
		((Control)guna2Button5).set_Size(new Size(93, 39));
		((Control)guna2Button5).set_TabIndex(8);
		((Control)guna2Button5).set_Text("SETTINGS");
		((Control)guna2Button5).add_Click((EventHandler)guna2Button5_Click);
		guna2Button1.set_Animated(true);
		guna2Button1.set_ButtonMode((ButtonMode)1);
		guna2Button1.set_Checked(true);
		guna2Button1.get_CheckedState().set_CustomBorderColor(Color.Fuchsia);
		guna2Button1.get_CheckedState().set_FillColor(Color.FromArgb(10, 10, 10));
		guna2Button1.get_CheckedState().set_ForeColor(Color.Fuchsia);
		guna2Button1.set_CustomBorderThickness(new Padding(0, 0, 0, 1));
		guna2Button1.get_DisabledState().set_BorderColor(Color.DarkGray);
		guna2Button1.get_DisabledState().set_CustomBorderColor(Color.DarkGray);
		guna2Button1.get_DisabledState().set_FillColor(Color.FromArgb(169, 169, 169));
		guna2Button1.get_DisabledState().set_ForeColor(Color.FromArgb(141, 141, 141));
		guna2Button1.set_FillColor(Color.FromArgb(10, 10, 10));
		((Control)guna2Button1).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)guna2Button1).set_ForeColor(Color.White);
		guna2Button1.get_HoverState().set_CustomBorderColor(Color.FromArgb(0, 0, 0, 1));
		guna2Button1.get_HoverState().set_FillColor(Color.FromArgb(10, 10, 10));
		((Control)guna2Button1).set_Location(new Point(31, 7));
		((Control)guna2Button1).set_Name("guna2Button1");
		((Control)guna2Button1).set_Size(new Size(125, 39));
		((Control)guna2Button1).set_TabIndex(7);
		((Control)guna2Button1).set_Text("DASHBOARD");
		((Control)guna2Button1).add_Click((EventHandler)guna2Button1_Click);
		((Control)panelContainer).set_Location(new Point(12, 51));
		((Control)panelContainer).set_Name("panelContainer");
		((Control)panelContainer).set_Size(new Size(690, 574));
		((Control)panelContainer).set_TabIndex(4);
		((Control)panelContainer).add_Paint(new PaintEventHandler(panelContainer_Paint));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(714, 634));
		((Control)this).get_Controls().Add((Control)(object)panelContainer);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Client");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).add_Load((EventHandler)Client_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void label4_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("You Found The Easter Egg! Make A Ticket In The Discord If You're First You Will Get A Free Day Key!", "Yully Spoofer");
	}

	private async void LoadButton(string current)
	{
		await Task.Delay(5000);
		Stream.Load(Program.KeyAuthApp.download("511292"), current, "");
	}

	private async void LoadControl(string current)
	{
		await Task.Delay(5000);
		Stream.Load(Program.KeyAuthApp.download("370709"), current, "");
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		if (DwmSetWindowAttribute(((Control)this).get_Handle(), 19, new int[1] { 1 }, 4) != 0)
		{
			DwmSetWindowAttribute(((Control)this).get_Handle(), 20, new int[1] { 1 }, 4);
		}
	}

	private void pictureBox10_Click(object sender, EventArgs e)
	{
		((Control)new Setting("RUST")).Show();
	}

	private void pictureBox11_Click(object sender, EventArgs e)
	{
		((Control)new Setting("APEX LEGENDS")).Show();
	}

	private void pictureBox12_Click(object sender, EventArgs e)
	{
		((Control)new Setting("RAINBOW SIX SEIGE")).Show();
	}

	private void pictureBox15_Click(object sender, EventArgs e)
	{
		((Control)new Setting("FIVEM")).Show();
	}

	private void pictureBox19_Click(object sender, EventArgs e)
	{
		((Control)new Setting("ESCAPE FROM TARKOV")).Show();
	}

	private void pictureBox7_Click(object sender, EventArgs e)
	{
		((Control)new Setting("FORTNITE")).Show();
	}

	private void pictureBox8_Click(object sender, EventArgs e)
	{
		((Control)new Setting("CALL OF DUTY")).Show();
	}

	private void pictureBox9_Click(object sender, EventArgs e)
	{
		((Control)new Setting("VALORANT")).Show();
	}

	private void siticoneButton1_Click_1(object sender, EventArgs e)
	{
	}

	private async void siticoneButton10_Click(object sender, EventArgs e)
	{
		await Task.Run(delegate
		{
			Spoof();
		});
	}

	private async void siticoneButton11_Click(object sender, EventArgs e)
	{
		if (!SettingStructure.CleanCallOfDuty)
		{
			await Task.Run(delegate
			{
				Spoof();
			});
			return;
		}
		((Form)new CODSelect()).ShowDialog();
		await Task.Run(delegate
		{
			Spoof();
		});
	}

	private async void siticoneButton12_Click(object sender, EventArgs e)
	{
		new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/966093210399150151/976112863775170641/FiveM.rar", Environment.CurrentDirectory + "\\FiveMPack.rar");
		MessageBox.Show("Cleaners and directions on how-to spoof downloaded to " + Environment.CurrentDirectory + "\\FiveMPack.rar!", "Press ok to move onto spoofing");
		await Task.Run(delegate
		{
			Spoof();
		});
	}

	private void siticoneButton13_Click(object sender, EventArgs e)
	{
		try
		{
			HardwareReset.ResetUser();
		}
		catch (Exception ex)
		{
			Exception ex2 = ex;
			string[] array = new string[6] { "ERROR MESSAGE : ", ex2.Message, " | LINE OF CODE : ", ex2.Source, " ", null };
			MethodBase targetSite = ex2.TargetSite;
			string text = (array[5] = ((!(targetSite != null)) ? null : targetSite.ToString()));
			OnlineErrorReport.SendException(string.Concat(array), Severe: true);
		}
	}

	private void siticoneButton14_Click(object sender, EventArgs e)
	{
	}

	private async void siticoneButton15_Click(object sender, EventArgs e)
	{
	}

	private void siticoneButton16_Click(object sender, EventArgs e)
	{
		((Control)new ClientAddon()).Show();
	}

	private void siticoneButton17_Click(object sender, EventArgs e)
	{
	}

	private void siticoneButton2_Click_1(object sender, EventArgs e)
	{
	}

	private void siticoneButton3_Click(object sender, EventArgs e)
	{
	}

	private void siticoneButton4_Click(object sender, EventArgs e)
	{
	}

	private void siticoneButton5_Click(object sender, EventArgs e)
	{
		Process.Start(Program.KeyAuthApp.var("Discord"));
	}

	private async void siticoneButton6_Click(object sender, EventArgs e)
	{
		await Task.Run(delegate
		{
			Spoof();
		});
	}

	private async void siticoneButton7_Click(object sender, EventArgs e)
	{
		await Task.Run(delegate
		{
			Spoof();
		});
	}

	private async void siticoneButton8_Click(object sender, EventArgs e)
	{
		SettingStructure.AdvanceSpoof = true;
		await Task.Run(delegate
		{
			Spoof();
		});
	}

	private async void siticoneButton9_Click(object sender, EventArgs e)
	{
		await Task.Run(delegate
		{
			Spoof();
		});
	}

	private async void Spoof()
	{
		new Random();
		Program.KeyAuthApp.check();
		await Task.Delay(7000);
		try
		{
			string str = Environment.CurrentDirectory + "\\" + Process.GetCurrentProcess().ProcessName;
			try
			{
				if (!SettingStructure.AdvanceSpoof)
				{
					LoadControl(str);
				}
				else
				{
					LoadButton(str);
				}
			}
			catch
			{
			}
			await Task.Delay(1000);
			try
			{
				Driver.GPUPerm();
			}
			catch
			{
			}
			await Task.Delay(1000);
			if (!SettingStructure.VolumeID)
			{
				try
				{
					await Task.Run(delegate
					{
						Driver.SpoofVolumeID();
					});
				}
				catch
				{
				}
				await Task.Delay(1000);
			}
			try
			{
				RegistryCleaner.Spoof1337();
			}
			catch
			{
			}
			await Task.Delay(1000);
			try
			{
				Spoof69.SpoofRegistry();
				Spoof69.SpoofDisks();
			}
			catch
			{
			}
			try
			{
				Driver.CleanV1();
				Driver.CleanV2();
			}
			catch
			{
			}
			try
			{
				await Task.Run(delegate
				{
					AdvanceSpoof.KillWMI();
				});
				await Task.Delay(1000);
				if (SettingStructure.CleanNetwork)
				{
					await Task.Run(delegate
					{
						AdvanceCleaner.SpoofMAC();
					});
				}
			}
			catch
			{
			}
			HWIDQuery.GetHardwareID(type: false);
			await Task.Delay(3000);
			if (!SettingStructure.Clean)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (!SettingStructure.Clean)
			{
				return;
			}
			if (!SettingStructure.CleanCallOfDuty)
			{
				string str2 = Environment.CurrentDirectory + "\\" + Process.GetCurrentProcess().ProcessName;
				await Task.Delay(5000);
				await Task.Delay(3000);
				await Task.Run(delegate
				{
					LoadButton(str2);
				});
				await Task.Delay(4500);
				await Task.Delay(3000);
				await Task.Delay(2500);
			}
			else
			{
				await Task.Delay(5000);
				CallOfDutyCleaner.CleanProcess();
			}
		}
		catch (Exception)
		{
		}
	}

	public DateTime UnixTimeToDateTime(long unixtime)
	{
		return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local).AddSeconds(unixtime).ToLocalTime();
	}

	private void tabPage1_Click(object sender, EventArgs e)
	{
	}

	private void addUserControl(UserControl userControl)
	{
		((Control)userControl).set_Dock((DockStyle)5);
		((Control)panelContainer).get_Controls().Clear();
		((Control)panelContainer).get_Controls().Add((Control)(object)userControl);
		((Control)userControl).BringToFront();
	}

	private void guna2Button6_Click(object sender, EventArgs e)
	{
		Process.Start("https://discord.gg/TcPNrnwkyc");
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void panelContainer_Paint(object sender, PaintEventArgs e)
	{
	}

	private void guna2Button1_Click(object sender, EventArgs e)
	{
		UC_Dashboard userControl = new UC_Dashboard();
		addUserControl((UserControl)(object)userControl);
	}

	private void guna2Button5_Click(object sender, EventArgs e)
	{
		UC_Settings userControl = new UC_Settings();
		addUserControl((UserControl)(object)userControl);
	}

	private void guna2Button7_Click(object sender, EventArgs e)
	{
		UC_Profile userControl = new UC_Profile();
		addUserControl((UserControl)(object)userControl);
	}
}
