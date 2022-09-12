using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace ICSharpCode.SharpZipLib.Tar;

public class TarArchive : IDisposable
{
	private bool ceSadyQvPWPAXvTMgLwnktjfEQbv;

	private bool eGsQHWGZJzZdDETqZIMyCVfEbqPD;

	private int VeQzdrAYMnenkAGZObvjYaLneMzY;

	private string QlZfcjQEjrTaKkCTwCzwckfhdccZA;

	private bool asYEuKHHJttrBtCcWhoKVCLpXRSvA;

	private bool jEUdVlCBvLlRtvMzwdvlnFOKBHzE;

	private string unsEOEenEOklkhuzmHwGRwoEbOTV;

	private string yeEBeGzLAjhEYaKcGadifKLZxUfrA;

	private TarInputStream lqZpsUQiIsidOdxXPRofgOUjeGnZA;

	private TarOutputStream kJqVXvfAStQENiauDWWKuwtTGFXM;

	private int yRQJUhpOiecrXGgpCiYUfintoeKF;

	private string clOonDuBLTPKdhoVLDVkfFHdPqnvA;

	[CompilerGenerated]
	private ProgressMessageHandler TjqBrsGhbcMEBdQzUKkmdJVbwseAb;

	public bool ApplyUserInfoOverrides
	{
		get
		{
			if (asYEuKHHJttrBtCcWhoKVCLpXRSvA)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			return ceSadyQvPWPAXvTMgLwnktjfEQbv;
		}
		set
		{
			if (asYEuKHHJttrBtCcWhoKVCLpXRSvA)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			ceSadyQvPWPAXvTMgLwnktjfEQbv = value;
		}
	}

	public bool AsciiTranslate
	{
		get
		{
			if (asYEuKHHJttrBtCcWhoKVCLpXRSvA)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			return eGsQHWGZJzZdDETqZIMyCVfEbqPD;
		}
		set
		{
			if (asYEuKHHJttrBtCcWhoKVCLpXRSvA)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			eGsQHWGZJzZdDETqZIMyCVfEbqPD = value;
		}
	}

	public int GroupId
	{
		get
		{
			if (asYEuKHHJttrBtCcWhoKVCLpXRSvA)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			return VeQzdrAYMnenkAGZObvjYaLneMzY;
		}
	}

	public string GroupName
	{
		get
		{
			if (asYEuKHHJttrBtCcWhoKVCLpXRSvA)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			return QlZfcjQEjrTaKkCTwCzwckfhdccZA;
		}
	}

	public string PathPrefix
	{
		get
		{
			if (asYEuKHHJttrBtCcWhoKVCLpXRSvA)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			return unsEOEenEOklkhuzmHwGRwoEbOTV;
		}
		set
		{
			if (asYEuKHHJttrBtCcWhoKVCLpXRSvA)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			unsEOEenEOklkhuzmHwGRwoEbOTV = value;
		}
	}

	public int RecordSize
	{
		get
		{
			if (asYEuKHHJttrBtCcWhoKVCLpXRSvA)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			if (lqZpsUQiIsidOdxXPRofgOUjeGnZA == null)
			{
				if (kJqVXvfAStQENiauDWWKuwtTGFXM != null)
				{
					return kJqVXvfAStQENiauDWWKuwtTGFXM.RecordSize;
				}
				return 10240;
			}
			return lqZpsUQiIsidOdxXPRofgOUjeGnZA.RecordSize;
		}
	}

	public string RootPath
	{
		get
		{
			if (asYEuKHHJttrBtCcWhoKVCLpXRSvA)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			return yeEBeGzLAjhEYaKcGadifKLZxUfrA;
		}
		set
		{
			if (asYEuKHHJttrBtCcWhoKVCLpXRSvA)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			yeEBeGzLAjhEYaKcGadifKLZxUfrA = value;
		}
	}

	public int UserId
	{
		get
		{
			if (asYEuKHHJttrBtCcWhoKVCLpXRSvA)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			return yRQJUhpOiecrXGgpCiYUfintoeKF;
		}
	}

	public string UserName
	{
		get
		{
			if (asYEuKHHJttrBtCcWhoKVCLpXRSvA)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			return clOonDuBLTPKdhoVLDVkfFHdPqnvA;
		}
	}

	public event ProgressMessageHandler ProgressMessageEvent
	{
		[CompilerGenerated]
		add
		{
			ProgressMessageHandler progressMessageHandler = TjqBrsGhbcMEBdQzUKkmdJVbwseAb;
			ProgressMessageHandler progressMessageHandler2;
			do
			{
				progressMessageHandler2 = progressMessageHandler;
				ProgressMessageHandler value2 = (ProgressMessageHandler)Delegate.Combine(progressMessageHandler2, value);
				progressMessageHandler = Interlocked.CompareExchange(ref TjqBrsGhbcMEBdQzUKkmdJVbwseAb, value2, progressMessageHandler2);
			}
			while ((object)progressMessageHandler != progressMessageHandler2);
		}
		[CompilerGenerated]
		remove
		{
			ProgressMessageHandler progressMessageHandler = TjqBrsGhbcMEBdQzUKkmdJVbwseAb;
			ProgressMessageHandler progressMessageHandler2;
			do
			{
				progressMessageHandler2 = progressMessageHandler;
				ProgressMessageHandler value2 = (ProgressMessageHandler)Delegate.Remove(progressMessageHandler2, value);
				progressMessageHandler = Interlocked.CompareExchange(ref TjqBrsGhbcMEBdQzUKkmdJVbwseAb, value2, progressMessageHandler2);
			}
			while ((object)progressMessageHandler != progressMessageHandler2);
		}
	}

	protected TarArchive()
	{
		clOonDuBLTPKdhoVLDVkfFHdPqnvA = string.Empty;
		QlZfcjQEjrTaKkCTwCzwckfhdccZA = string.Empty;
	}

	protected TarArchive(TarInputStream stream)
	{
		clOonDuBLTPKdhoVLDVkfFHdPqnvA = string.Empty;
		QlZfcjQEjrTaKkCTwCzwckfhdccZA = string.Empty;
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		lqZpsUQiIsidOdxXPRofgOUjeGnZA = stream;
	}

	protected TarArchive(TarOutputStream stream)
	{
		clOonDuBLTPKdhoVLDVkfFHdPqnvA = string.Empty;
		QlZfcjQEjrTaKkCTwCzwckfhdccZA = string.Empty;
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		kJqVXvfAStQENiauDWWKuwtTGFXM = stream;
	}

	public virtual void Close()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[Obsolete("Use Close instead")]
	public void CloseArchive()
	{
		Close();
	}

	public static TarArchive CreateInputTarArchive(Stream inputStream)
	{
		if (inputStream == null)
		{
			throw new ArgumentNullException("inputStream");
		}
		if (!(inputStream is TarInputStream stream))
		{
			return CreateInputTarArchive(inputStream, 20);
		}
		return new TarArchive(stream);
	}

	public static TarArchive CreateInputTarArchive(Stream inputStream, int blockFactor)
	{
		if (inputStream == null)
		{
			throw new ArgumentNullException("inputStream");
		}
		if (inputStream is TarInputStream)
		{
			throw new ArgumentException("TarInputStream not valid");
		}
		return new TarArchive(new TarInputStream(inputStream, blockFactor));
	}

	public static TarArchive CreateOutputTarArchive(Stream outputStream)
	{
		if (outputStream == null)
		{
			throw new ArgumentNullException("outputStream");
		}
		if (outputStream is TarOutputStream stream)
		{
			return new TarArchive(stream);
		}
		return CreateOutputTarArchive(outputStream, 20);
	}

	public static TarArchive CreateOutputTarArchive(Stream outputStream, int blockFactor)
	{
		if (outputStream == null)
		{
			throw new ArgumentNullException("outputStream");
		}
		if (outputStream is TarOutputStream)
		{
			throw new ArgumentException("TarOutputStream is not valid");
		}
		return new TarArchive(new TarOutputStream(outputStream, blockFactor));
	}

	protected virtual void Dispose(bool disposing)
	{
		if (asYEuKHHJttrBtCcWhoKVCLpXRSvA)
		{
			return;
		}
		asYEuKHHJttrBtCcWhoKVCLpXRSvA = true;
		if (disposing)
		{
			if (kJqVXvfAStQENiauDWWKuwtTGFXM != null)
			{
				kJqVXvfAStQENiauDWWKuwtTGFXM.Flush();
				kJqVXvfAStQENiauDWWKuwtTGFXM.Close();
			}
			if (lqZpsUQiIsidOdxXPRofgOUjeGnZA != null)
			{
				lqZpsUQiIsidOdxXPRofgOUjeGnZA.Close();
			}
		}
	}

	private static void aJBHVtBdZtgyTYZUGwWdprXSgTj(string directoryName)
	{
		//IL_002d: Expected O, but got I4
		if (!Directory.Exists(directoryName))
		{
			try
			{
				Directory.CreateDirectory(directoryName);
			}
			catch (Exception ex)
			{
				throw new TarException(directoryName + (string?)72 + "" + ex.Message, ex);
			}
		}
	}

	public void ExtractContents(string destinationDirectory)
	{
		if (asYEuKHHJttrBtCcWhoKVCLpXRSvA)
		{
			throw new ObjectDisposedException("TarArchive");
		}
		while (true)
		{
			TarEntry nextEntry = lqZpsUQiIsidOdxXPRofgOUjeGnZA.GetNextEntry();
			if (nextEntry != null)
			{
				HmYWccVZgMjttpLXzFBQqlpvPdAo(destinationDirectory, nextEntry);
				continue;
			}
			break;
		}
	}

	private void HmYWccVZgMjttpLXzFBQqlpvPdAo(string destDir, TarEntry entry)
	{
		OnProgressMessageEvent(entry, null);
		string text = entry.Name;
		if (Path.IsPathRooted(text))
		{
			text = text.Substring(Path.GetPathRoot(text)!.Length);
		}
		text = text.Replace('/', Path.DirectorySeparatorChar);
		string text2 = Path.Combine(destDir, text);
		if (entry.IsDirectory)
		{
			aJBHVtBdZtgyTYZUGwWdprXSgTj(text2);
			return;
		}
		aJBHVtBdZtgyTYZUGwWdprXSgTj(Path.GetDirectoryName(text2));
		bool flag = true;
		FileInfo fileInfo = new FileInfo(text2);
		if (fileInfo.Exists)
		{
			if (jEUdVlCBvLlRtvMzwdvlnFOKBHzE)
			{
				OnProgressMessageEvent(entry, "Destination file already exists");
				flag = false;
			}
			else if ((fileInfo.Attributes & FileAttributes.ReadOnly) != 0)
			{
				OnProgressMessageEvent(entry, "Destination file already exists, and is read-only");
				flag = false;
			}
		}
		if (!flag)
		{
			return;
		}
		bool flag2 = false;
		Stream stream = File.Create(text2);
		if (eGsQHWGZJzZdDETqZIMyCVfEbqPD)
		{
			flag2 = !tlzAqGWoGlNMXnfXLgzMMOiXNbTP(text2);
		}
		StreamWriter streamWriter = null;
		if (flag2)
		{
			streamWriter = new StreamWriter(stream);
		}
		byte[] array = new byte[32768];
		while (true)
		{
			int num = lqZpsUQiIsidOdxXPRofgOUjeGnZA.Read(array, 0, array.Length);
			if (num <= 0)
			{
				break;
			}
			if (!flag2)
			{
				stream.Write(array, 0, num);
				continue;
			}
			int num2 = 0;
			for (int i = 0; i < num; i++)
			{
				if (array[i] == 10)
				{
					string @string = Encoding.ASCII.GetString(array, num2, i - num2);
					streamWriter.WriteLine(@string);
					num2 = i + 1;
				}
			}
		}
		if (flag2)
		{
			streamWriter.Close();
		}
		else
		{
			stream.Close();
		}
	}

	~TarArchive()
	{
		Dispose(disposing: false);
	}

	private static bool tlzAqGWoGlNMXnfXLgzMMOiXNbTP(string filename)
	{
		using (FileStream fileStream = File.OpenRead(filename))
		{
			int num = Math.Min(4096, (int)fileStream.Length);
			byte[] array = new byte[num];
			int num2 = fileStream.Read(array, 0, num);
			for (int i = 0; i < num2; i++)
			{
				byte b = array[i];
				if (b < 8 || (b > 13 && b < 32) || b == byte.MaxValue)
				{
					return true;
				}
			}
		}
		return false;
	}

	public void ListContents()
	{
		if (asYEuKHHJttrBtCcWhoKVCLpXRSvA)
		{
			throw new ObjectDisposedException("TarArchive");
		}
		while (true)
		{
			TarEntry nextEntry = lqZpsUQiIsidOdxXPRofgOUjeGnZA.GetNextEntry();
			if (nextEntry != null)
			{
				OnProgressMessageEvent(nextEntry, null);
				continue;
			}
			break;
		}
	}

	protected virtual void OnProgressMessageEvent(TarEntry entry, string message)
	{
		if (TjqBrsGhbcMEBdQzUKkmdJVbwseAb != null)
		{
			TjqBrsGhbcMEBdQzUKkmdJVbwseAb(this, entry, message);
		}
	}

	[Obsolete("Use the AsciiTranslate property")]
	public void SetAsciiTranslation(bool asciiTranslate)
	{
		if (asYEuKHHJttrBtCcWhoKVCLpXRSvA)
		{
			throw new ObjectDisposedException("TarArchive");
		}
		eGsQHWGZJzZdDETqZIMyCVfEbqPD = asciiTranslate;
	}

	public void SetKeepOldFiles(bool keepOldFiles)
	{
		if (asYEuKHHJttrBtCcWhoKVCLpXRSvA)
		{
			throw new ObjectDisposedException("TarArchive");
		}
		jEUdVlCBvLlRtvMzwdvlnFOKBHzE = keepOldFiles;
	}

	public void SetUserInfo(int userId, string userName, int groupId, string groupName)
	{
		if (asYEuKHHJttrBtCcWhoKVCLpXRSvA)
		{
			throw new ObjectDisposedException("TarArchive");
		}
		yRQJUhpOiecrXGgpCiYUfintoeKF = userId;
		clOonDuBLTPKdhoVLDVkfFHdPqnvA = userName;
		VeQzdrAYMnenkAGZObvjYaLneMzY = groupId;
		QlZfcjQEjrTaKkCTwCzwckfhdccZA = groupName;
		ceSadyQvPWPAXvTMgLwnktjfEQbv = true;
	}

	void IDisposable.Dispose()
	{
		Close();
	}

	public void WriteEntry(TarEntry sourceEntry, bool recurse)
	{
		if (sourceEntry == null)
		{
			throw new ArgumentNullException("sourceEntry");
		}
		if (asYEuKHHJttrBtCcWhoKVCLpXRSvA)
		{
			throw new ObjectDisposedException("TarArchive");
		}
		try
		{
			if (recurse)
			{
				TarHeader.gMKAbiFNvDLksecPIHDnHTrEOprOB(sourceEntry.UserId, sourceEntry.UserName, sourceEntry.GroupId, sourceEntry.GroupName);
			}
			gSbzmXDxUfThmGsWcbnICJEGNNfi(sourceEntry, recurse);
		}
		finally
		{
			if (recurse)
			{
				TarHeader.vkyBfTATocEymbMSPwOYzaoKqMlw();
			}
		}
	}

	private void gSbzmXDxUfThmGsWcbnICJEGNNfi(TarEntry sourceEntry, bool recurse)
	{
		string text = null;
		string text2 = sourceEntry.File;
		TarEntry tarEntry = (TarEntry)sourceEntry.Clone();
		if (ceSadyQvPWPAXvTMgLwnktjfEQbv)
		{
			tarEntry.GroupId = VeQzdrAYMnenkAGZObvjYaLneMzY;
			tarEntry.GroupName = QlZfcjQEjrTaKkCTwCzwckfhdccZA;
			tarEntry.UserId = yRQJUhpOiecrXGgpCiYUfintoeKF;
			tarEntry.UserName = clOonDuBLTPKdhoVLDVkfFHdPqnvA;
		}
		OnProgressMessageEvent(tarEntry, null);
		if (eGsQHWGZJzZdDETqZIMyCVfEbqPD && !tarEntry.IsDirectory && !tlzAqGWoGlNMXnfXLgzMMOiXNbTP(text2))
		{
			text = Path.GetTempFileName();
			using (StreamReader streamReader = File.OpenText(text2))
			{
				using Stream stream = File.Create(text);
				while (true)
				{
					string text3 = streamReader.ReadLine();
					if (text3 == null)
					{
						break;
					}
					byte[] bytes = Encoding.ASCII.GetBytes(text3);
					stream.Write(bytes, 0, bytes.Length);
					stream.WriteByte(10);
				}
				stream.Flush();
			}
			tarEntry.Size = new FileInfo(text).Length;
			text2 = text;
		}
		string text4 = null;
		if (yeEBeGzLAjhEYaKcGadifKLZxUfrA != null && tarEntry.Name.StartsWith(yeEBeGzLAjhEYaKcGadifKLZxUfrA))
		{
			text4 = tarEntry.Name.Substring(yeEBeGzLAjhEYaKcGadifKLZxUfrA.Length + 1);
		}
		if (unsEOEenEOklkhuzmHwGRwoEbOTV != null)
		{
			text4 = ((text4 == null) ? (unsEOEenEOklkhuzmHwGRwoEbOTV + "/" + tarEntry.Name) : (unsEOEenEOklkhuzmHwGRwoEbOTV + "/" + text4));
		}
		if (text4 != null)
		{
			tarEntry.Name = text4;
		}
		kJqVXvfAStQENiauDWWKuwtTGFXM.PutNextEntry(tarEntry);
		if (tarEntry.IsDirectory)
		{
			if (recurse)
			{
				TarEntry[] directoryEntries = tarEntry.GetDirectoryEntries();
				for (int i = 0; i < directoryEntries.Length; i++)
				{
					gSbzmXDxUfThmGsWcbnICJEGNNfi(directoryEntries[i], recurse);
				}
			}
			return;
		}
		using (Stream stream2 = File.OpenRead(text2))
		{
			int num = 0;
			byte[] array = new byte[32768];
			while (true)
			{
				int num2 = stream2.Read(array, 0, array.Length);
				if (num2 > 0)
				{
					kJqVXvfAStQENiauDWWKuwtTGFXM.Write(array, 0, num2);
					num += num2;
					continue;
				}
				break;
			}
		}
		if (text != null && text.Length > 0)
		{
			File.Delete(text);
		}
		kJqVXvfAStQENiauDWWKuwtTGFXM.CloseEntry();
	}
}
