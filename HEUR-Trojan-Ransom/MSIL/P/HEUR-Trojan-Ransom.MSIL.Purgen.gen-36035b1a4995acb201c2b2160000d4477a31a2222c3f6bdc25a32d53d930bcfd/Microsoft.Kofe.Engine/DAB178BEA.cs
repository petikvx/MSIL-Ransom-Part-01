using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;
using System.Threading;
using MICore;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

public class DAB178BEA : IDisposable
{
	[CompilerGenerated]
	private sealed class C85824B3A
	{
		public string BF7B4F80B;

		internal bool C9334DD49(KeyValuePair<string, string> B42FDE26E)
		{
			return B42FDE26E.Key.Equals(BF7B4F80B, StringComparison.OrdinalIgnoreCase);
		}

		internal bool C2E8E3341(KeyValuePair<string, string> B63146D9A)
		{
			string key = B63146D9A.Key;
			char directorySeparatorChar = Path.DirectorySeparatorChar;
			return key.EndsWith(directorySeparatorChar + BF7B4F80B, StringComparison.OrdinalIgnoreCase);
		}
	}

	[CompilerGenerated]
	private sealed class BE8B23443
	{
		public string DA33178F2;

		public string CB20D7374;

		internal bool CDE79E8A2(KeyValuePair<string, string> B39F7E7E4)
		{
			if (B39F7E7E4.Key.EndsWith(DA33178F2, StringComparison.OrdinalIgnoreCase))
			{
				return B39F7E7E4.Value.Equals(CB20D7374, StringComparison.Ordinal);
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class F21020738
	{
		public string E0A888503;

		public BE8B23443 E60BE145B;

		internal bool BB7D94955(KeyValuePair<string, string> A41D65DEF)
		{
			string key = A41D65DEF.Key;
			char directorySeparatorChar = Path.DirectorySeparatorChar;
			if (key.EndsWith(directorySeparatorChar + E0A888503, StringComparison.OrdinalIgnoreCase))
			{
				return A41D65DEF.Value.Equals(E60BE145B.CB20D7374, StringComparison.Ordinal);
			}
			return false;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class EDA2ABD8D
	{
		public static readonly EDA2ABD8D F645568EB = new EDA2ABD8D();

		public static Func<SourceRoot, bool> C2B0B2816;

		public static Func<SourceRoot, SourceRoot> F4A42BDE8;

		public static Func<SourceRoot, int> F2EE40F09;

		internal bool E20F5A6A0(SourceRoot B5CF99D46)
		{
			return Path.IsPathRooted(B5CF99D46.get_Path());
		}

		internal SourceRoot A40750FDF(SourceRoot CB6840BAF)
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			return new SourceRoot(D4E3CB64A(CB6840BAF.get_Path()), CB6840BAF.get_RecursiveSearchEnabled());
		}

		internal int B664E690D(SourceRoot F06457D12)
		{
			return F06457D12.get_Path().Length;
		}
	}

	[CompilerGenerated]
	private sealed class AF25B30F1
	{
		public string E4D63C292;

		internal bool D0B34402A(SourceRoot CA902A788)
		{
			if (CA902A788.get_Path().StartsWith(E4D63C292, StringComparison.OrdinalIgnoreCase))
			{
				return CA902A788.get_RecursiveSearchEnabled();
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class ACF8DEC6F
	{
		public string D994913A5;

		public Func<KeyValuePair<string, string>, bool> D4053736E;

		internal bool F0C6163A5(KeyValuePair<string, string> BEA3F91E4)
		{
			return BEA3F91E4.Key.StartsWith(D994913A5, StringComparison.OrdinalIgnoreCase);
		}
	}

	private Thread B33212021;

	protected BlockingCollection<SourceRoot> _processQueue;

	protected ConcurrentDictionary<string, string> _fileToPackageMap = new ConcurrentDictionary<string, string>();

	private CancellationTokenSource B013A48D9;

	private IEnumerable<SourceRoot> CF34A3D85;

	private List<FileSystemWatcher> FAE461C6A = new List<FileSystemWatcher>();

	protected bool _running;

	private object B3E8C264D = new object();

	private const string CDBF6DA52 = "*.java";

	private const string DE5C98612 = ".java";

	private bool D564A420A;

	public IEnumerable<SourceRoot> C4C974AF9
	{
		get
		{
			return CF34A3D85;
		}
		set
		{
			CF34A3D85 = AF1D07DF6(value);
		}
	}

	public DAB178BEA()
	{
	}

	public DAB178BEA(IEnumerable<SourceRoot> sourceRootsToWatch)
	{
		C4C974AF9 = sourceRootsToWatch;
	}

	public void C1A369FA3()
	{
		E0358ADD6();
		_running = true;
		if (C4C974AF9 == null)
		{
			throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, "{0} not set", new object[1] { "SourceRootsToWatch" }));
		}
		_processQueue = new BlockingCollection<SourceRoot>();
		B013A48D9 = new CancellationTokenSource();
		foreach (SourceRoot item in C4C974AF9)
		{
			AD0A3D063(item);
		}
		ParameterizedThreadStart start = AD02950E4;
		B33212021 = new Thread(start);
		B33212021.IsBackground = true;
		B33212021.Priority = ThreadPriority.Lowest;
		B33212021.Start();
		B33212021.Name = "DAB178BEA Thread";
		BC4EA9BD1();
	}

	private void D1507C74C(string BB58485E2, string E525ADF42)
	{
		E0358ADD6();
		if (string.IsNullOrWhiteSpace(BB58485E2))
		{
			throw new ArgumentNullException("path");
		}
		if (string.IsNullOrWhiteSpace(E525ADF42))
		{
			throw new ArgumentNullException("package");
		}
		if (!Path.IsPathRooted(BB58485E2))
		{
			throw new ArgumentException("path", "Should be fully rooted");
		}
		if (_fileToPackageMap.TryGetValue(BB58485E2, out var value))
		{
			if (value != null && !value.Equals(E525ADF42, StringComparison.Ordinal))
			{
				_fileToPackageMap.TryUpdate(BB58485E2, E525ADF42, value);
			}
		}
		else
		{
			_fileToPackageMap.TryAdd(BB58485E2, E525ADF42);
		}
	}

	public string C7D223CD2(string F6A201C84)
	{
		E0358ADD6();
		string text = null;
		if (Path.IsPathRooted(F6A201C84))
		{
			text = _fileToPackageMap.SingleOrDefault((KeyValuePair<string, string> B42FDE26E) => B42FDE26E.Key.Equals(F6A201C84, StringComparison.OrdinalIgnoreCase))!.Value;
			if (text == null)
			{
				text = A2350BD6E(F6A201C84);
				if (text != null)
				{
					D1507C74C(F6A201C84, text);
				}
			}
		}
		else
		{
			text = _fileToPackageMap.FirstOrDefault(delegate(KeyValuePair<string, string> B63146D9A)
			{
				string key = B63146D9A.Key;
				char directorySeparatorChar = Path.DirectorySeparatorChar;
				return key.EndsWith(directorySeparatorChar + F6A201C84, StringComparison.OrdinalIgnoreCase);
			})!.Value;
		}
		return text;
	}

	private string F8614B802(string CE8E68209, string CA89859B7)
	{
		string result = null;
		IEnumerable<KeyValuePair<string, string>> source = _fileToPackageMap.Where((KeyValuePair<string, string> B39F7E7E4) => B39F7E7E4.Key.EndsWith(CE8E68209, StringComparison.OrdinalIgnoreCase) && B39F7E7E4.Value.Equals(CA89859B7, StringComparison.Ordinal));
		if (!source.Any())
		{
			string E0A888503 = Path.GetFileName(CE8E68209);
			source = _fileToPackageMap.Where(delegate(KeyValuePair<string, string> A41D65DEF)
			{
				string key = A41D65DEF.Key;
				char directorySeparatorChar = Path.DirectorySeparatorChar;
				return key.EndsWith(directorySeparatorChar + E0A888503, StringComparison.OrdinalIgnoreCase) && A41D65DEF.Value.Equals(CA89859B7, StringComparison.Ordinal);
			});
		}
		if (source.Any())
		{
			result = source.First().Key;
		}
		return result;
	}

	private static string A2350BD6E(string DADE7B690)
	{
		try
		{
			if (File.Exists(DADE7B690))
			{
				using StreamReader streamReader = File.OpenText(DADE7B690);
				char[] array = new char[8192];
				int length = streamReader.ReadBlock(array, 0, 8192);
				Match match = Regex.Match(new string(array, 0, length), "^\\s*package\\s[a-zA-Z_\\$][a-zA-Z_\\$0-9]*(\\.[a-zA-Z_\\$][a-zA-Z_\\$0-9]*)*\\s*;", RegexOptions.Multiline);
				if (match.Success)
				{
					int num = match.Value.IndexOf("package", StringComparison.Ordinal) + 7;
					int num2 = match.Value.IndexOf(';');
					return match.Value.Substring(num, num2 - num).Trim();
				}
			}
		}
		catch (Exception b89511B)
		{
			if (!E05B8CD64(b89511B))
			{
				throw;
			}
		}
		return null;
	}

	private static bool E05B8CD64(Exception B89511B97)
	{
		if (!(B89511B97 is DirectoryNotFoundException) && !(B89511B97 is IOException) && !(B89511B97 is PathTooLongException) && !(B89511B97 is SecurityException) && !(B89511B97 is UnauthorizedAccessException) && !(B89511B97 is NotSupportedException) && !(B89511B97 is ArgumentException) && !(B89511B97 is ArgumentNullException))
		{
			return B89511B97 is FileNotFoundException;
		}
		return true;
	}

	public string AEB742416(IJdwpClass C7CD084A9)
	{
		E0358ADD6();
		if (C7CD084A9 == null)
		{
			throw new ArgumentNullException("javaClass");
		}
		if (C7CD084A9.get_AbsolutePath() != null)
		{
			return C7CD084A9.get_AbsolutePath();
		}
		if (string.IsNullOrEmpty(((IJdwpReferenceType)C7CD084A9).GetSourceFile()))
		{
			return string.Empty;
		}
		string text = C7CD084A9.get_Name().Split(new char[1] { '$' })[0];
		int num = text.LastIndexOf('.');
		string text2 = ((num != -1) ? text.Remove(num + 1) : string.Empty);
		string text3 = text2.Replace('.', Path.DirectorySeparatorChar) + ((IJdwpReferenceType)C7CD084A9).GetSourceFile();
		text2 = ((text2.Length > 0) ? text2.Remove(text2.Length - 1) : text2);
		char directorySeparatorChar = Path.DirectorySeparatorChar;
		string text4 = F8614B802(directorySeparatorChar + text3, text2);
		if (!string.IsNullOrWhiteSpace(text4))
		{
			C7CD084A9.set_AbsolutePath(text4);
			return text4;
		}
		foreach (SourceRoot item in CF34A3D85)
		{
			string text5 = Path.Combine(item.get_Path(), ((IJdwpReferenceType)C7CD084A9).GetSourceFile());
			if (File.Exists(text5))
			{
				C7CD084A9.set_AbsolutePath(text5);
				return text5;
			}
		}
		C7CD084A9.set_AbsolutePath(text3);
		return text3;
	}

	private static string D4E3CB64A(string EF43D9950)
	{
		string text = EF43D9950.Trim();
		string text2 = text;
		char directorySeparatorChar = Path.DirectorySeparatorChar;
		if (!text2.EndsWith(directorySeparatorChar.ToString(), StringComparison.OrdinalIgnoreCase))
		{
			string text3 = text;
			directorySeparatorChar = Path.DirectorySeparatorChar;
			text = text3 + directorySeparatorChar;
		}
		string? directoryName = Path.GetDirectoryName(text);
		directorySeparatorChar = Path.DirectorySeparatorChar;
		return directoryName + directorySeparatorChar;
	}

	public static IEnumerable<SourceRoot> AF1D07DF6(IEnumerable<SourceRoot> EAAF34A2D)
	{
		List<SourceRoot> list = new List<SourceRoot>();
		if (EAAF34A2D != null)
		{
			foreach (SourceRoot item in from F06457D12 in EAAF34A2D.Where((SourceRoot B5CF99D46) => Path.IsPathRooted(B5CF99D46.get_Path())).Select((Func<SourceRoot, SourceRoot>)((SourceRoot CB6840BAF) => new SourceRoot(D4E3CB64A(CB6840BAF.get_Path()), CB6840BAF.get_RecursiveSearchEnabled())))
				orderby F06457D12.get_Path().Length
				select F06457D12)
			{
				bool flag = false;
				foreach (SourceRoot item2 in list)
				{
					if (item.get_Path().StartsWith(item2.get_Path(), StringComparison.OrdinalIgnoreCase) && item.get_RecursiveSearchEnabled() && item.get_RecursiveSearchEnabled() == item2.get_RecursiveSearchEnabled())
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list.Add(item);
				}
			}
			return list;
		}
		return list;
	}

	public void BEA836341()
	{
		E0358ADD6();
		_running = false;
		if (B013A48D9 != null)
		{
			B013A48D9.Cancel();
			B013A48D9.Dispose();
			B013A48D9 = null;
		}
		lock (B3E8C264D)
		{
			C918CDFFB();
			F69B0674A();
		}
	}

	private void F69B0674A()
	{
		if (_processQueue != null)
		{
			_processQueue.Dispose();
			_processQueue = null;
		}
	}

	private void BC4EA9BD1()
	{
		foreach (SourceRoot item in C4C974AF9)
		{
			try
			{
				FileSystemWatcher fileSystemWatcher = new FileSystemWatcher(item.get_Path());
				FAE461C6A.Add(fileSystemWatcher);
				fileSystemWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.Size | NotifyFilters.LastWrite;
				if (item.get_RecursiveSearchEnabled())
				{
					fileSystemWatcher.IncludeSubdirectories = true;
					fileSystemWatcher.NotifyFilter |= NotifyFilters.DirectoryName;
				}
				fileSystemWatcher.Changed += A42844B30;
				fileSystemWatcher.Created += C5E8986DB;
				fileSystemWatcher.Deleted += B96073B33;
				fileSystemWatcher.Renamed += C36770292;
				fileSystemWatcher.EnableRaisingEvents = true;
			}
			catch (ArgumentException)
			{
			}
			catch (PathTooLongException)
			{
			}
		}
	}

	private void A011C0D49(string C4883BDAE)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		bool flag = C4C974AF9.Any((SourceRoot CA902A788) => CA902A788.get_Path().StartsWith(C4883BDAE, StringComparison.OrdinalIgnoreCase) && CA902A788.get_RecursiveSearchEnabled());
		_processQueue.Add(new SourceRoot(C4883BDAE, flag));
	}

	private void AD0A3D063(SourceRoot F366F9603)
	{
		_processQueue.Add(F366F9603);
	}

	private void F3E3C7C52(string BCC7E30EE, string BB8DD0084 = null)
	{
		string value;
		if (!string.IsNullOrEmpty(BB8DD0084) && Directory.Exists(BB8DD0084))
		{
			string D994913A5 = D4E3CB64A(BCC7E30EE);
			{
				foreach (KeyValuePair<string, string> item in _fileToPackageMap.Where((KeyValuePair<string, string> BEA3F91E4) => BEA3F91E4.Key.StartsWith(D994913A5, StringComparison.OrdinalIgnoreCase)))
				{
					_fileToPackageMap.TryRemove(item.Key, out value);
				}
				return;
			}
		}
		_fileToPackageMap.TryRemove(BCC7E30EE, out value);
	}

	private bool AFD4E8065(string E5FA2E939)
	{
		if (!Directory.Exists(E5FA2E939))
		{
			if (File.Exists(E5FA2E939))
			{
				return Path.GetExtension(E5FA2E939)!.Equals(".java", StringComparison.OrdinalIgnoreCase);
			}
			return false;
		}
		return true;
	}

	private void C36770292(object E7DA7E24D, RenamedEventArgs A10FE12AD)
	{
		if (AFD4E8065(A10FE12AD.FullPath))
		{
			F3E3C7C52(A10FE12AD.OldFullPath, A10FE12AD.FullPath);
			A011C0D49(A10FE12AD.FullPath);
		}
	}

	private void B96073B33(object EF76CFD37, FileSystemEventArgs E655735E6)
	{
		F3E3C7C52(E655735E6.FullPath);
	}

	private void C5E8986DB(object E27601C7A, FileSystemEventArgs D97A66D75)
	{
		if (AFD4E8065(D97A66D75.FullPath))
		{
			A011C0D49(D97A66D75.FullPath);
		}
	}

	private void A42844B30(object DF050615E, FileSystemEventArgs CBD1275DE)
	{
		if (AFD4E8065(CBD1275DE.FullPath))
		{
			A011C0D49(CBD1275DE.FullPath);
		}
	}

	private void AD02950E4(object D0C5A732F)
	{
		CancellationToken token = B013A48D9.Token;
		while (_running)
		{
			try
			{
				lock (B3E8C264D)
				{
					SourceRoot f5FD8BF = _processQueue.Take(token);
					D501381B3(f5FD8BF);
				}
			}
			catch (OperationCanceledException)
			{
				break;
			}
		}
	}

	private void D501381B3(SourceRoot F5FD8BF11)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		try
		{
			if (Directory.Exists(F5FD8BF11.get_Path()))
			{
				foreach (string item in Directory.EnumerateFiles(F5FD8BF11.get_Path(), "*.java", SearchOption.TopDirectoryOnly))
				{
					AD0A3D063(new SourceRoot(item, F5FD8BF11.get_RecursiveSearchEnabled()));
				}
				if (!F5FD8BF11.get_RecursiveSearchEnabled())
				{
					return;
				}
				{
					foreach (string item2 in Directory.EnumerateDirectories(F5FD8BF11.get_Path(), "*.*", SearchOption.TopDirectoryOnly))
					{
						AD0A3D063(new SourceRoot(item2, F5FD8BF11.get_RecursiveSearchEnabled()));
					}
					return;
				}
			}
			if (File.Exists(F5FD8BF11.get_Path()))
			{
				string text = A2350BD6E(F5FD8BF11.get_Path());
				if (text == null)
				{
					return;
				}
				if (_fileToPackageMap.TryGetValue(F5FD8BF11.get_Path(), out var value))
				{
					if (value != null && !value.Equals(text, StringComparison.Ordinal))
					{
						_fileToPackageMap.TryUpdate(F5FD8BF11.get_Path(), text, value);
					}
				}
				else
				{
					_fileToPackageMap.TryAdd(F5FD8BF11.get_Path(), text);
				}
			}
			else
			{
				_fileToPackageMap.TryRemove(F5FD8BF11.get_Path(), out var _);
			}
		}
		catch (Exception b89511B)
		{
			if (!E05B8CD64(b89511B))
			{
				throw;
			}
		}
	}

	~DAB178BEA()
	{
		Dispose(disposing: false);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (D564A420A)
		{
			return;
		}
		if (disposing)
		{
			if (B33212021 != null)
			{
				B33212021 = null;
			}
			if (B013A48D9 != null)
			{
				B013A48D9.Dispose();
				B013A48D9 = null;
			}
			C918CDFFB();
			F69B0674A();
		}
		D564A420A = true;
	}

	private void C918CDFFB()
	{
		if (FAE461C6A == null)
		{
			return;
		}
		foreach (FileSystemWatcher item in FAE461C6A)
		{
			item.EnableRaisingEvents = false;
			item.Changed -= A42844B30;
			item.Created -= C5E8986DB;
			item.Deleted -= B96073B33;
			item.Renamed -= C36770292;
			item.Dispose();
		}
		FAE461C6A.Clear();
		FAE461C6A = null;
	}

	public void DF1712D92()
	{
		if (_running)
		{
			BEA836341();
		}
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void E0358ADD6()
	{
		if (D564A420A)
		{
			throw new ObjectDisposedException("Object disposed");
		}
	}
}
