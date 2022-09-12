using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using chicken;

internal static class uvHwjeiGekyDyGxmVAVARgArElNhA
{
	[CompilerGenerated]
	private sealed class NHJknBZmIBxhQeyOKOiFeeBhnreK
	{
		public string JezDUYHdtwccBoUbxIKFSmHsoNNVA;

		internal bool uYOVjcUeiUrLdTcQdGKsMuSyisNm(string s)
		{
			return s.EndsWith(JezDUYHdtwccBoUbxIKFSmHsoNNVA);
		}
	}

	[CompilerGenerated]
	private static class jsqOebwJzZVYgfCqcOpVdjsuekDZ
	{
		public static CallSite<Func<CallSite, object, string, object>> tTuywdTGWNpgESJAqqxEFdIgoHKV;

		public static CallSite<Func<CallSite, object, string, object>> XWKWBhejCMQWzmgBgtQdRpJIjVNL;

		public static CallSite<Func<CallSite, object, string, object>> KCSAjbKJTqpLWatcstdArImybxAh;

		public static CallSite<Action<CallSite, object>> QvAyTiNSNcbGKRiHLlZNCFPoTRLi;
	}

	[STAThread]
	private static void zKjBbukQdQxWbLBknCNCOWaJXgtiA()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		Mutex mutex = new Mutex(initiallyOwned: true, "Lineage");
		TimeSpan timeout = new TimeSpan(0, 0, 1);
		if (!mutex.WaitOne(timeout))
		{
			MessageBox.Show("'중복 실행' 기존 접속기를 종료하시거나 \n작업관리자에서  프로세서를 종료 해주세요.", "안내");
			return;
		}
		if (new FileInfo("Sprite.pak").Exists)
		{
			MessageBox.Show("리니지 폴더에서 실행시켜 주십시오.", " 안내");
			Application.Exit();
			return;
		}
		irPfQfhdyLIPyIEyeeTLLLRSQxEx();
		AijYXqULkuWsMMxfOwtOaaGqGjIGA.VSjheIcONfHVVIIpjagbUlrXknnC();
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form2());
	}

	public static bool ARQFNyJITQqSzorVkGZfUHauiteRA()
	{
		for (int i = 0; i < 16; i++)
		{
			if (!File.Exists($"Sprite{i:00}.idx"))
			{
				return false;
			}
		}
		return true;
	}

	private static Assembly xEYsmRPHMrFWeVadTvfHGdlTjyIE(object sender, ResolveEventArgs args)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string JezDUYHdtwccBoUbxIKFSmHsoNNVA = args.Name.Substring(0, args.Name.IndexOf(',')) + ".dll";
		List<string> source = (from s in executingAssembly.GetManifestResourceNames()
			where s.EndsWith(JezDUYHdtwccBoUbxIKFSmHsoNNVA)
			select s).ToList();
		if (!source.Any())
		{
			return null;
		}
		string name = source.First();
		using Stream stream = executingAssembly.GetManifestResourceStream(name);
		if (stream == null)
		{
			return null;
		}
		byte[] array = new byte[stream.Length];
		stream.Read(array, 0, array.Length);
		return Assembly.Load(array);
	}

	private static void irPfQfhdyLIPyIEyeeTLLLRSQxEx()
	{
		try
		{
			string text = BIJIHGoKHuvRZfjMCkLXJQAtGTSt();
			if (!string.IsNullOrEmpty(text))
			{
				FileInfo fileInfo = new FileInfo(text);
				dynamic val = Activator.CreateInstance(Type.GetTypeFromProgID("WScript.Shell"));
				dynamic val2 = val.CreateShortcut(fileInfo.FullName);
				val2.TargetPath = Application.get_ExecutablePath();
				val2.WorkingDirectory = Application.get_StartupPath();
				val2.Save();
			}
		}
		catch (Exception)
		{
		}
	}

	private static string OnluoqZdDajTxmcnymXDSUWEtsgt()
	{
		return Path.GetFileNameWithoutExtension(Application.get_ExecutablePath());
	}

	private static string BIJIHGoKHuvRZfjMCkLXJQAtGTSt()
	{
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension((string?)/*Error near IL_0005: Stack underflow*/);
		DirectoryInfo directoryInfo = dbYMiGGafUjMyHYbvRaSTUMpJpUAb();
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(directoryInfo.FullName).Append("\\").Append(fileNameWithoutExtension)
			.Append(".lnk");
		return stringBuilder.ToString();
	}

	private static DirectoryInfo dbYMiGGafUjMyHYbvRaSTUMpJpUAb()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		if (string.IsNullOrEmpty(folderPath))
		{
			folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		}
		if (!string.IsNullOrEmpty(folderPath))
		{
			return new DirectoryInfo(folderPath);
		}
		return null;
	}
}
