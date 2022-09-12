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

internal static class rbDHoVMsUZxgubeJYSKblfVwULMJ
{
	[CompilerGenerated]
	private sealed class WaLoUixdCuOTSHenBgDyiKIyvEvqA
	{
		public string SIjohnLvPJKRsnAyvPeIQEkneQoc;

		internal bool zSSvzDqRcbNRvgOliwFHqOHtFUKl(string s)
		{
			return s.EndsWith(SIjohnLvPJKRsnAyvPeIQEkneQoc);
		}
	}

	[CompilerGenerated]
	private static class gZcQmOOsheeemOZPpwEsLTdxNxEH
	{
		public static CallSite<Func<CallSite, object, string, object>> eacQdMvMWsQzMrUfngbzrJZhmxBG;

		public static CallSite<Func<CallSite, object, string, object>> YdUfhEAKCtuopZFwzFXOnTMJErCL;

		public static CallSite<Func<CallSite, object, string, object>> LXMCmEckRXtZESDQfHaxBRphYENCA;

		public static CallSite<Action<CallSite, object>> FjOVQHhUAZnHOyYaYfyoiTEhuwAu;
	}

	[STAThread]
	private static void yxyJBgehvtifUqPcoGrnkhELPoEA()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		Mutex mutex = new Mutex(initiallyOwned: true, "Lineage");
		TimeSpan timeout = new TimeSpan(0, 0, 1);
		if (mutex.WaitOne(timeout))
		{
			FileInfo fileInfo = new FileInfo("Sprite.pak");
			if (fileInfo.Exists)
			{
				vvLifMBcDatyibHSjIiwzGCFYZFH();
				TUjdcLygmNYYMxhYLmVnALLfUoTH.QOnfLrCCAEGzNUbzeYdSdyiSNVqtA();
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run((Form)(object)new Form2());
			}
			else
			{
				MessageBox.Show("리니지 폴더에서 실행시켜 주십시오.", " 안내");
				Application.Exit();
			}
		}
		else
		{
			MessageBox.Show("'중복 실행' 기존 접속기를 종료하시거나 \n작업관리자에서  프로세서를 종료 해주세요.", "안내");
		}
	}

	public static bool TwMbHPkXehyWbMqUnOTApdgzYOre()
	{
		int num = 0;
		while (true)
		{
			if (num < 16)
			{
				string path = $"Sprite{num:00}.idx";
				if (!File.Exists(path))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	private static Assembly kACdGXgzVSGdYRiTEMiyekeSpQZcA(object sender, ResolveEventArgs args)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string SIjohnLvPJKRsnAyvPeIQEkneQoc = args.Name.Substring(0, args.Name.IndexOf(',')) + ".dll";
		List<string> source = (from s in executingAssembly.GetManifestResourceNames()
			where s.EndsWith(SIjohnLvPJKRsnAyvPeIQEkneQoc)
			select s).ToList();
		if (source.Any())
		{
			string name = source.First();
			using Stream stream = executingAssembly.GetManifestResourceStream(name);
			if (stream != null)
			{
				byte[] array = new byte[stream.Length];
				stream.Read(array, 0, array.Length);
				return Assembly.Load(array);
			}
			return null;
		}
		return null;
	}

	private static void vvLifMBcDatyibHSjIiwzGCFYZFH()
	{
		try
		{
			string text = GyJAjnCqHZddDQCnNEOybxNcNcXTA();
			if (!string.IsNullOrEmpty(text))
			{
				FileInfo fileInfo = new FileInfo(text);
				Type typeFromProgID = Type.GetTypeFromProgID("WScript.Shell");
				dynamic val = Activator.CreateInstance(typeFromProgID);
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

	private static string RDnDEBllFFrftJJArxQquNJRvHvv()
	{
		return Path.GetFileNameWithoutExtension(Application.get_ExecutablePath());
	}

	private static string GyJAjnCqHZddDQCnNEOybxNcNcXTA()
	{
		string value = RDnDEBllFFrftJJArxQquNJRvHvv();
		DirectoryInfo directoryInfo = aQObEdgLdvaasbtIspjpIkXwIOZnA();
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(directoryInfo.FullName).Append("\\").Append(value)
			.Append(".lnk");
		return stringBuilder.ToString();
	}

	private static DirectoryInfo aQObEdgLdvaasbtIspjpIkXwIOZnA()
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
