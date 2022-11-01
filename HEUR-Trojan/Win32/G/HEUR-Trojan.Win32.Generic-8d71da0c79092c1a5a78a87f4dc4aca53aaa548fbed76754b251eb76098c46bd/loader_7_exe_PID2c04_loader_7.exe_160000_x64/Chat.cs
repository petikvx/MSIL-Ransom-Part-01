using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI.WinForms;
using KeyAuth;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Suite;
using YullySpoofer;

namespace loader_7_exe_PID2c04_loader_7.exe_160000_x64;

public class Chat : Form
{
	private string chatchannel = "channel";

	private IContainer components = null;

	private SiticoneRoundedButton sendmsg;

	private DataGridView dataGridView1;

	private GunaTextBox chatmsg;

	private Timer timer1;

	private Button button1;

	private DataGridViewTextBoxColumn Sender;

	private DataGridViewTextBoxColumn Message;

	private DataGridViewTextBoxColumn Time;

	public DateTime UnixTimeToDateTime(long unixtime)
	{
		return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local).AddSeconds(unixtime).ToLocalTime();
	}

	public Chat()
	{
		InitializeComponent();
	}

	private void sendmsg_Click(object sender, EventArgs e)
	{
		if (Program.KeyAuthApp.chatsend(((Control)chatmsg).get_Text(), chatchannel))
		{
			dataGridView1.get_Rows().Insert(0, new object[3]
			{
				Program.KeyAuthApp.user_data.username,
				((Control)chatmsg).get_Text(),
				UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds())
			});
		}
		else
		{
			dataGridView1.get_Rows().Insert(0, new object[3]
			{
				"Yully Spoofer",
				"No Chat Messages",
				UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds())
			});
		}
	}

	private void Chat_Load(object sender, EventArgs e)
	{
		timer1.Start();
		((Form)this).set_TopMost(true);
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		dataGridView1.get_Rows().Clear();
		timer1.set_Interval(15000);
		if (!string.IsNullOrEmpty(chatchannel))
		{
			List<api.msg> list = Program.KeyAuthApp.chatget(chatchannel);
			if (list != null)
			{
				foreach (api.msg item in list)
				{
					dataGridView1.get_Rows().Insert(0, new object[3]
					{
						item.author,
						item.message,
						UnixTimeToDateTime(long.Parse(item.timestamp))
					});
					((Control)chatmsg).set_Text("");
				}
				return;
			}
			dataGridView1.get_Rows().Insert(0, new object[3]
			{
				"Yully Spoofer",
				"No Chat Messages",
				UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds())
			});
		}
		else
		{
			dataGridView1.get_Rows().Insert(0, new object[3]
			{
				"Yully Spoofer",
				"No Chat Messages",
				UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds())
			});
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Process.Start("https://discord.gg/TcPNrnwkyc");
		((Form)this).Close();
	}

	private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void chatmsg_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			if (Program.KeyAuthApp.chatsend(((Control)chatmsg).get_Text(), chatchannel))
			{
				dataGridView1.get_Rows().Insert(0, new object[3]
				{
					Program.KeyAuthApp.user_data.username,
					((Control)chatmsg).get_Text(),
					UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds())
				});
				((Control)chatmsg).set_Text("");
			}
			else
			{
				dataGridView1.get_Rows().Insert(0, new object[3]
				{
					"Yully Spoofer",
					"No Chat Messages",
					UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds())
				});
			}
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
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected O, but got Unknown
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected O, but got Unknown
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Expected O, but got Unknown
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected O, but got Unknown
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected O, but got Unknown
		//IL_099f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		DataGridViewCellStyle val7 = new DataGridViewCellStyle();
		DataGridViewCellStyle val8 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Chat));
		sendmsg = new SiticoneRoundedButton();
		dataGridView1 = new DataGridView();
		Sender = new DataGridViewTextBoxColumn();
		Message = new DataGridViewTextBoxColumn();
		Time = new DataGridViewTextBoxColumn();
		chatmsg = new GunaTextBox();
		timer1 = new Timer(components);
		button1 = new Button();
		((ISupportInitialize)dataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		((SiticoneButton)sendmsg).set_BorderColor(Color.Fuchsia);
		((SiticoneButton)sendmsg).set_BorderThickness(1);
		((SiticoneButton)sendmsg).get_CheckedState().set_Parent((CustomButtonBase)(object)sendmsg);
		((SiticoneButton)sendmsg).get_CustomImages().set_Parent((CustomButtonBase)(object)sendmsg);
		((SiticoneButton)sendmsg).set_FillColor(Color.FromArgb(12, 12, 12));
		((Control)sendmsg).set_Font(new Font("Segoe UI", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)sendmsg).set_ForeColor(Color.White);
		((SiticoneButton)sendmsg).get_HoveredState().set_BorderColor(Color.FromArgb(213, 218, 223));
		((SiticoneButton)sendmsg).get_HoveredState().set_Parent((CustomButtonBase)(object)sendmsg);
		((Control)sendmsg).set_Location(new Point(511, 387));
		((Control)sendmsg).set_Name("sendmsg");
		((SiticoneButton)sendmsg).get_ShadowDecoration().set_Parent((Control)(object)sendmsg);
		((Control)sendmsg).set_Size(new Size(105, 31));
		((Control)sendmsg).set_TabIndex(45);
		((Control)sendmsg).set_Text("Send");
		((Control)sendmsg).add_Click((EventHandler)sendmsg_Click);
		dataGridView1.set_AllowUserToAddRows(false);
		dataGridView1.set_AllowUserToDeleteRows(false);
		val.set_BackColor(Color.FromArgb(20, 20, 20));
		val.set_Font(new Font("Segoe UI", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val.set_ForeColor(Color.White);
		val.set_SelectionBackColor(Color.FromArgb(20, 20, 20));
		val.set_SelectionForeColor(Color.White);
		dataGridView1.set_AlternatingRowsDefaultCellStyle(val);
		dataGridView1.set_BackgroundColor(Color.FromArgb(20, 20, 20));
		dataGridView1.set_BorderStyle((BorderStyle)0);
		val2.set_Alignment((DataGridViewContentAlignment)16);
		val2.set_BackColor(Color.FromArgb(20, 20, 20));
		val2.set_Font(new Font("Segoe UI", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val2.set_ForeColor(Color.White);
		val2.set_SelectionBackColor(Color.FromArgb(20, 20, 20));
		val2.set_SelectionForeColor(Color.White);
		val2.set_WrapMode((DataGridViewTriState)1);
		dataGridView1.set_ColumnHeadersDefaultCellStyle(val2);
		dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dataGridView1.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)Sender,
			(DataGridViewColumn)Message,
			(DataGridViewColumn)Time
		});
		val3.set_Alignment((DataGridViewContentAlignment)16);
		val3.set_BackColor(Color.FromArgb(20, 20, 20));
		val3.set_Font(new Font("Segoe UI", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val3.set_ForeColor(Color.White);
		val3.set_SelectionBackColor(Color.FromArgb(20, 20, 20));
		val3.set_SelectionForeColor(SystemColors.HighlightText);
		val3.set_WrapMode((DataGridViewTriState)2);
		dataGridView1.set_DefaultCellStyle(val3);
		dataGridView1.set_GridColor(Color.FromArgb(20, 20, 20));
		((Control)dataGridView1).set_Location(new Point(12, 12));
		((Control)dataGridView1).set_Name("dataGridView1");
		dataGridView1.set_ReadOnly(true);
		val4.set_Alignment((DataGridViewContentAlignment)16);
		val4.set_BackColor(Color.FromArgb(20, 20, 20));
		val4.set_Font(new Font("Segoe UI", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val4.set_ForeColor(Color.White);
		val4.set_SelectionBackColor(Color.FromArgb(20, 20, 20));
		val4.set_SelectionForeColor(Color.White);
		val4.set_WrapMode((DataGridViewTriState)1);
		dataGridView1.set_RowHeadersDefaultCellStyle(val4);
		val5.set_BackColor(Color.FromArgb(20, 20, 20));
		val5.set_ForeColor(Color.White);
		val5.set_SelectionBackColor(Color.FromArgb(20, 20, 20));
		val5.set_SelectionForeColor(Color.White);
		dataGridView1.set_RowsDefaultCellStyle(val5);
		((Control)dataGridView1).set_Size(new Size(604, 373));
		((Control)dataGridView1).set_TabIndex(44);
		dataGridView1.add_CellContentClick(new DataGridViewCellEventHandler(dataGridView1_CellContentClick));
		val6.set_BackColor(Color.FromArgb(20, 20, 20));
		val6.set_ForeColor(Color.White);
		val6.set_SelectionBackColor(Color.FromArgb(20, 20, 20));
		val6.set_SelectionForeColor(Color.White);
		((DataGridViewBand)Sender).set_DefaultCellStyle(val6);
		((DataGridViewColumn)Sender).set_HeaderText("Sender");
		((DataGridViewColumn)Sender).set_Name("Sender");
		((DataGridViewBand)Sender).set_ReadOnly(true);
		((DataGridViewColumn)Sender).set_Width(75);
		val7.set_BackColor(Color.FromArgb(20, 20, 20));
		val7.set_ForeColor(Color.White);
		val7.set_SelectionBackColor(Color.FromArgb(20, 20, 20));
		val7.set_SelectionForeColor(Color.White);
		((DataGridViewBand)Message).set_DefaultCellStyle(val7);
		((DataGridViewColumn)Message).set_HeaderText("Message");
		((DataGridViewColumn)Message).set_Name("Message");
		((DataGridViewBand)Message).set_ReadOnly(true);
		((DataGridViewColumn)Message).set_Width(200);
		val8.set_BackColor(Color.FromArgb(20, 20, 20));
		val8.set_ForeColor(Color.White);
		val8.set_SelectionBackColor(Color.FromArgb(20, 20, 20));
		val8.set_SelectionForeColor(Color.White);
		((DataGridViewBand)Time).set_DefaultCellStyle(val8);
		((DataGridViewColumn)Time).set_HeaderText("Time");
		Time.set_MaxInputLength(50000);
		((DataGridViewColumn)Time).set_Name("Time");
		((DataGridViewBand)Time).set_ReadOnly(true);
		((DataGridViewColumn)Time).set_Width(190);
		((Control)chatmsg).set_BackColor(Color.Transparent);
		chatmsg.set_BaseColor(Color.FromArgb(12, 12, 12));
		chatmsg.set_BorderColor(Color.Fuchsia);
		chatmsg.set_BorderSize(1);
		((Control)chatmsg).set_Cursor(Cursors.get_IBeam());
		chatmsg.set_FocusedBaseColor(Color.FromArgb(12, 12, 12));
		chatmsg.set_FocusedBorderColor(Color.Fuchsia);
		chatmsg.set_FocusedForeColor(Color.White);
		((Control)chatmsg).set_Font(new Font("Segoe UI", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)chatmsg).set_ForeColor(Color.FromArgb(93, 101, 111));
		((Control)chatmsg).set_Location(new Point(12, 387));
		((Control)chatmsg).set_Name("chatmsg");
		chatmsg.set_PasswordChar('\0');
		chatmsg.set_Radius(3);
		chatmsg.set_SelectedText("");
		((Control)chatmsg).set_Size(new Size(493, 31));
		((Control)chatmsg).set_TabIndex(59);
		((Control)chatmsg).add_KeyDown(new KeyEventHandler(chatmsg_KeyDown));
		timer1.set_Enabled(true);
		timer1.set_Interval(1);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ButtonBase)button1).get_FlatAppearance().set_BorderColor(Color.FromArgb(24, 24, 24));
		((ButtonBase)button1).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(10, 10, 10));
		((ButtonBase)button1).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(10, 10, 10));
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_Font(new Font("Segoe UI Semibold", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_ForeColor(Color.White);
		((Control)button1).set_Location(new Point(12, 423));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(177, 38));
		((Control)button1).set_TabIndex(60);
		((Control)button1).set_Text("Quit Customer Chatting App.");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(10, 10, 10));
		((Form)this).set_ClientSize(new Size(628, 466));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)chatmsg);
		((Control)this).get_Controls().Add((Control)(object)sendmsg);
		((Control)this).get_Controls().Add((Control)(object)dataGridView1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Chat");
		((Control)this).set_Text("Chat");
		((Form)this).add_Load((EventHandler)Chat_Load);
		((ISupportInitialize)dataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
