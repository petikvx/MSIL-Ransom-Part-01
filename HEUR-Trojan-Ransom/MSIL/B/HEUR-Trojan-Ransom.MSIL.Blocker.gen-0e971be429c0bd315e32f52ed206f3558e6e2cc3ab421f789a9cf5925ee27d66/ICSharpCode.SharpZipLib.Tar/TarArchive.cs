using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace ICSharpCode.SharpZipLib.Tar;

public class TarArchive : IDisposable
{
	private bool lpGhVJiBRxYoNAsfpAdWCJissveY;

	private bool bCkEwviuFGpdVrfiCmNBxsODcOIZA;

	private int MxINTEoEEYZGyjioVCoYqFGaunen;

	private string ZuNEfYwUlISJWXoPnaHDCAuwDOhl;

	private bool bxGAkhlXqUHLXdJpJlMhmWOqezJd;

	private bool srUMRKsovcmVxUeUzmsOVZGHagun;

	private string vcsaHrCeChbXgCKCdvrvlptFclIS;

	private string xVSiUbVgWQksGPYHREyLylKSBbcw;

	private TarInputStream oeZGhjcqMTLXWUoXIriMufFgnMwK;

	private TarOutputStream xVcvsODYxUkSDXBqCPlhSoWSulYC;

	private int bECThAXngRsQNlQJLpbtZlvaEFRIA;

	private string tyOTbgMpTewRdOBuQOHRblUiFlaK;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ProgressMessageHandler UmODVhDxFdmTEdUCBpNtvUCqFlYb;

	public bool ApplyUserInfoOverrides
	{
		get
		{
			if (bxGAkhlXqUHLXdJpJlMhmWOqezJd)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			return lpGhVJiBRxYoNAsfpAdWCJissveY;
		}
		set
		{
			if (bxGAkhlXqUHLXdJpJlMhmWOqezJd)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			lpGhVJiBRxYoNAsfpAdWCJissveY = value;
		}
	}

	public bool AsciiTranslate
	{
		get
		{
			if (bxGAkhlXqUHLXdJpJlMhmWOqezJd)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			return bCkEwviuFGpdVrfiCmNBxsODcOIZA;
		}
		set
		{
			if (bxGAkhlXqUHLXdJpJlMhmWOqezJd)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			bCkEwviuFGpdVrfiCmNBxsODcOIZA = value;
		}
	}

	public int GroupId
	{
		get
		{
			if (bxGAkhlXqUHLXdJpJlMhmWOqezJd)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			return MxINTEoEEYZGyjioVCoYqFGaunen;
		}
	}

	public string GroupName
	{
		get
		{
			if (bxGAkhlXqUHLXdJpJlMhmWOqezJd)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			return ZuNEfYwUlISJWXoPnaHDCAuwDOhl;
		}
	}

	public string PathPrefix
	{
		get
		{
			if (bxGAkhlXqUHLXdJpJlMhmWOqezJd)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			return vcsaHrCeChbXgCKCdvrvlptFclIS;
		}
		set
		{
			if (bxGAkhlXqUHLXdJpJlMhmWOqezJd)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			vcsaHrCeChbXgCKCdvrvlptFclIS = value;
		}
	}

	public int RecordSize
	{
		get
		{
			if (bxGAkhlXqUHLXdJpJlMhmWOqezJd)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			if (oeZGhjcqMTLXWUoXIriMufFgnMwK != null)
			{
				return oeZGhjcqMTLXWUoXIriMufFgnMwK.RecordSize;
			}
			if (xVcvsODYxUkSDXBqCPlhSoWSulYC != null)
			{
				return xVcvsODYxUkSDXBqCPlhSoWSulYC.RecordSize;
			}
			return 10240;
		}
	}

	public string RootPath
	{
		get
		{
			if (bxGAkhlXqUHLXdJpJlMhmWOqezJd)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			return xVSiUbVgWQksGPYHREyLylKSBbcw;
		}
		set
		{
			if (bxGAkhlXqUHLXdJpJlMhmWOqezJd)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			xVSiUbVgWQksGPYHREyLylKSBbcw = value;
		}
	}

	public int UserId
	{
		get
		{
			if (bxGAkhlXqUHLXdJpJlMhmWOqezJd)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			return bECThAXngRsQNlQJLpbtZlvaEFRIA;
		}
	}

	public string UserName
	{
		get
		{
			if (bxGAkhlXqUHLXdJpJlMhmWOqezJd)
			{
				throw new ObjectDisposedException("TarArchive");
			}
			return tyOTbgMpTewRdOBuQOHRblUiFlaK;
		}
	}

	public event ProgressMessageHandler ProgressMessageEvent
	{
		[CompilerGenerated]
		add
		{
			ProgressMessageHandler progressMessageHandler = UmODVhDxFdmTEdUCBpNtvUCqFlYb;
			ProgressMessageHandler progressMessageHandler2;
			do
			{
				progressMessageHandler2 = progressMessageHandler;
				ProgressMessageHandler value2 = (ProgressMessageHandler)Delegate.Combine(progressMessageHandler2, value);
				progressMessageHandler = Interlocked.CompareExchange(ref UmODVhDxFdmTEdUCBpNtvUCqFlYb, value2, progressMessageHandler2);
			}
			while ((object)progressMessageHandler != progressMessageHandler2);
		}
		[CompilerGenerated]
		remove
		{
			ProgressMessageHandler progressMessageHandler = UmODVhDxFdmTEdUCBpNtvUCqFlYb;
			ProgressMessageHandler progressMessageHandler2;
			do
			{
				progressMessageHandler2 = progressMessageHandler;
				ProgressMessageHandler value2 = (ProgressMessageHandler)Delegate.Remove(progressMessageHandler2, value);
				progressMessageHandler = Interlocked.CompareExchange(ref UmODVhDxFdmTEdUCBpNtvUCqFlYb, value2, progressMessageHandler2);
			}
			while ((object)progressMessageHandler != progressMessageHandler2);
		}
	}

	protected TarArchive()
	{
		tyOTbgMpTewRdOBuQOHRblUiFlaK = string.Empty;
		ZuNEfYwUlISJWXoPnaHDCAuwDOhl = string.Empty;
	}

	protected TarArchive(TarInputStream stream)
	{
		tyOTbgMpTewRdOBuQOHRblUiFlaK = string.Empty;
		ZuNEfYwUlISJWXoPnaHDCAuwDOhl = string.Empty;
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		oeZGhjcqMTLXWUoXIriMufFgnMwK = stream;
	}

	protected TarArchive(TarOutputStream stream)
	{
		tyOTbgMpTewRdOBuQOHRblUiFlaK = string.Empty;
		ZuNEfYwUlISJWXoPnaHDCAuwDOhl = string.Empty;
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		xVcvsODYxUkSDXBqCPlhSoWSulYC = stream;
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
		if (inputStream != null)
		{
			if (!(inputStream is TarInputStream stream))
			{
				return CreateInputTarArchive(inputStream, 20);
			}
			return new TarArchive(stream);
		}
		throw new ArgumentNullException("inputStream");
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
		if (outputStream != null)
		{
			if (!(outputStream is TarOutputStream stream))
			{
				return CreateOutputTarArchive(outputStream, 20);
			}
			return new TarArchive(stream);
		}
		throw new ArgumentNullException("outputStream");
	}

	public static TarArchive CreateOutputTarArchive(Stream outputStream, int blockFactor)
	{
		if (outputStream != null)
		{
			if (outputStream is TarOutputStream)
			{
				throw new ArgumentException("TarOutputStream is not valid");
			}
			return new TarArchive(new TarOutputStream(outputStream, blockFactor));
		}
		throw new ArgumentNullException("outputStream");
	}

	protected virtual void Dispose(bool disposing)
	{
		if (bxGAkhlXqUHLXdJpJlMhmWOqezJd)
		{
			return;
		}
		bxGAkhlXqUHLXdJpJlMhmWOqezJd = true;
		if (disposing)
		{
			if (xVcvsODYxUkSDXBqCPlhSoWSulYC != null)
			{
				xVcvsODYxUkSDXBqCPlhSoWSulYC.Flush();
				xVcvsODYxUkSDXBqCPlhSoWSulYC.Close();
			}
			if (oeZGhjcqMTLXWUoXIriMufFgnMwK != null)
			{
				oeZGhjcqMTLXWUoXIriMufFgnMwK.Close();
			}
		}
	}

	private static void zrJadmCJrkKJebkqAHXxqTsgGlEMe(string directoryName)
	{
		if (!Directory.Exists(directoryName))
		{
			try
			{
				Directory.CreateDirectory(directoryName);
			}
			catch (Exception ex)
			{
				throw new TarException("Exception creating directory '" + directoryName + "', " + ex.Message, ex);
			}
		}
	}

	public void ExtractContents(string destinationDirectory)
	{
		if (bxGAkhlXqUHLXdJpJlMhmWOqezJd)
		{
			throw new ObjectDisposedException("TarArchive");
		}
		while (true)
		{
			TarEntry nextEntry = oeZGhjcqMTLXWUoXIriMufFgnMwK.GetNextEntry();
			if (nextEntry != null)
			{
				AYMKLXvsghVwlCsKiGanYIemWxPj(destinationDirectory, nextEntry);
				continue;
			}
			break;
		}
	}

	private void AYMKLXvsghVwlCsKiGanYIemWxPj(string destDir, TarEntry entry)
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
			zrJadmCJrkKJebkqAHXxqTsgGlEMe(text2);
			return;
		}
		zrJadmCJrkKJebkqAHXxqTsgGlEMe(Path.GetDirectoryName(text2));
		bool flag = true;
		FileInfo fileInfo = new FileInfo(text2);
		if (fileInfo.Exists)
		{
			if (srUMRKsovcmVxUeUzmsOVZGHagun)
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
		if (bCkEwviuFGpdVrfiCmNBxsODcOIZA)
		{
			flag2 = !kepNsdsCAGNnNIGcUIcnIylKXWAIA(text2);
		}
		StreamWriter streamWriter = null;
		if (flag2)
		{
			streamWriter = new StreamWriter(stream);
		}
		byte[] array = new byte[32768];
		while (true)
		{
			int num = oeZGhjcqMTLXWUoXIriMufFgnMwK.Read(array, 0, array.Length);
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
		if (!flag2)
		{
			stream.Close();
		}
		else
		{
			streamWriter.Close();
		}
	}

	~TarArchive()
	{
		Dispose(disposing: false);
	}

	private static bool kepNsdsCAGNnNIGcUIcnIylKXWAIA(string filename)
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
		if (bxGAkhlXqUHLXdJpJlMhmWOqezJd)
		{
			throw new ObjectDisposedException("TarArchive");
		}
		while (true)
		{
			TarEntry nextEntry = oeZGhjcqMTLXWUoXIriMufFgnMwK.GetNextEntry();
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
		if (UmODVhDxFdmTEdUCBpNtvUCqFlYb != null)
		{
			UmODVhDxFdmTEdUCBpNtvUCqFlYb(this, entry, message);
		}
	}

	[Obsolete("Use the AsciiTranslate property")]
	public void SetAsciiTranslation(bool asciiTranslate)
	{
		if (bxGAkhlXqUHLXdJpJlMhmWOqezJd)
		{
			throw new ObjectDisposedException("TarArchive");
		}
		bCkEwviuFGpdVrfiCmNBxsODcOIZA = asciiTranslate;
	}

	public void SetKeepOldFiles(bool keepOldFiles)
	{
		if (bxGAkhlXqUHLXdJpJlMhmWOqezJd)
		{
			throw new ObjectDisposedException("TarArchive");
		}
		srUMRKsovcmVxUeUzmsOVZGHagun = keepOldFiles;
	}

	public void SetUserInfo(int userId, string userName, int groupId, string groupName)
	{
		if (bxGAkhlXqUHLXdJpJlMhmWOqezJd)
		{
			throw new ObjectDisposedException("TarArchive");
		}
		bECThAXngRsQNlQJLpbtZlvaEFRIA = userId;
		tyOTbgMpTewRdOBuQOHRblUiFlaK = userName;
		MxINTEoEEYZGyjioVCoYqFGaunen = groupId;
		ZuNEfYwUlISJWXoPnaHDCAuwDOhl = groupName;
		lpGhVJiBRxYoNAsfpAdWCJissveY = true;
	}

	void IDisposable.Dispose()
	{
		Close();
	}

	public void WriteEntry(TarEntry sourceEntry, bool recurse)
	{
		if (sourceEntry != null)
		{
			if (!bxGAkhlXqUHLXdJpJlMhmWOqezJd)
			{
				try
				{
					if (recurse)
					{
						TarHeader.lSEJHlfluaUcwBsZMYMRlyTNSaeb(sourceEntry.UserId, sourceEntry.UserName, sourceEntry.GroupId, sourceEntry.GroupName);
					}
					zjpeDgfeMAtvktMztcOtqZLJsGyH(sourceEntry, recurse);
					return;
				}
				finally
				{
					if (recurse)
					{
						TarHeader.mowHqEwmPIIyQGjOhDjZZtRNvutA();
					}
				}
			}
			throw new ObjectDisposedException("TarArchive");
		}
		throw new ArgumentNullException("sourceEntry");
	}

	private void zjpeDgfeMAtvktMztcOtqZLJsGyH(TarEntry sourceEntry, bool recurse)
	{
		string text = null;
		string text2 = sourceEntry.File;
		TarEntry tarEntry = (TarEntry)sourceEntry.Clone();
		if (lpGhVJiBRxYoNAsfpAdWCJissveY)
		{
			tarEntry.GroupId = MxINTEoEEYZGyjioVCoYqFGaunen;
			tarEntry.GroupName = ZuNEfYwUlISJWXoPnaHDCAuwDOhl;
			tarEntry.UserId = bECThAXngRsQNlQJLpbtZlvaEFRIA;
			tarEntry.UserName = tyOTbgMpTewRdOBuQOHRblUiFlaK;
		}
		OnProgressMessageEvent(tarEntry, null);
		if (bCkEwviuFGpdVrfiCmNBxsODcOIZA && !tarEntry.IsDirectory && !kepNsdsCAGNnNIGcUIcnIylKXWAIA(text2))
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
		if (xVSiUbVgWQksGPYHREyLylKSBbcw != null && tarEntry.Name.StartsWith(xVSiUbVgWQksGPYHREyLylKSBbcw))
		{
			text4 = tarEntry.Name.Substring(xVSiUbVgWQksGPYHREyLylKSBbcw.Length + 1);
		}
		if (vcsaHrCeChbXgCKCdvrvlptFclIS != null)
		{
			text4 = ((text4 == null) ? (vcsaHrCeChbXgCKCdvrvlptFclIS + "/" + tarEntry.Name) : (vcsaHrCeChbXgCKCdvrvlptFclIS + "/" + text4));
		}
		if (text4 != null)
		{
			tarEntry.Name = text4;
		}
		xVcvsODYxUkSDXBqCPlhSoWSulYC.PutNextEntry(tarEntry);
		if (!tarEntry.IsDirectory)
		{
			using (Stream stream2 = File.OpenRead(text2))
			{
				int num = 0;
				byte[] array = new byte[32768];
				while (true)
				{
					int num2 = stream2.Read(array, 0, array.Length);
					if (num2 > 0)
					{
						xVcvsODYxUkSDXBqCPlhSoWSulYC.Write(array, 0, num2);
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
			xVcvsODYxUkSDXBqCPlhSoWSulYC.CloseEntry();
		}
		else if (recurse)
		{
			TarEntry[] directoryEntries = tarEntry.GetDirectoryEntries();
			for (int i = 0; i < directoryEntries.Length; i++)
			{
				zjpeDgfeMAtvktMztcOtqZLJsGyH(directoryEntries[i], recurse);
			}
		}
	}
}
