using System;
using System.Collections;
using System.IO;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip;

public class FastZip
{
	public delegate bool ConfirmOverwriteDelegate(string fileName);

	public enum Overwrite
	{
		Prompt,
		Never,
		Always
	}

	private byte[] apDMpruwtLlJCAuUPtphtOimkoBl;

	private ConfirmOverwriteDelegate rcnoxbZUEBYOBGKyXFaoAaHfyEEm;

	private bool nPreNlszaOiKdPricjwweQSuQLgV;

	private bool ScdSudgpVfjvqyqNZxZlnXYiizGw;

	private NameFilter pxlaYbJffTNlOZYoilHxnaPprzZC;

	private IEntryFactory GAHBeOXnYZwueeJGLhLSJgJsZtNsA;

	private FastZipEvents PKFaIUpPAKnjEvjGabFNBjWUwiAn;

	private INameTransform APbksnpmEfREeaGgRuJRsxyNVvNH;

	private NameFilter wKydZuOcoODDyquyLpOyWATujZQ;

	private ZipOutputStream zwTbIECxvzYAUItQZIaVqKwoDPmdb;

	private Overwrite xtPvRcVOERbYzqDZyQDCvTvlzBzg;

	private string yGnAmMCZHbalIhmePfpnRccumoRp;

	private bool oIpbARwiYmSjppEECNwVYwtpDuDB;

	private bool sfzedyFewsPLQUFgACxckzqRqnOBA;

	private string ocGUtCZkYuENAOBowhfepLgwBCPf;

	private UseZip64 bKsRPzWeosiiVJMdrYkiLDpYbLKcA;

	private ZipFile YWcZOOdhJvCLkNXCwAijEUDPtuCuA;

	public bool CreateEmptyDirectories
	{
		get
		{
			return ScdSudgpVfjvqyqNZxZlnXYiizGw;
		}
		set
		{
			ScdSudgpVfjvqyqNZxZlnXYiizGw = value;
		}
	}

	public IEntryFactory EntryFactory
	{
		get
		{
			return GAHBeOXnYZwueeJGLhLSJgJsZtNsA;
		}
		set
		{
			if (value == null)
			{
				GAHBeOXnYZwueeJGLhLSJgJsZtNsA = new ZipEntryFactory();
			}
			else
			{
				GAHBeOXnYZwueeJGLhLSJgJsZtNsA = value;
			}
		}
	}

	public INameTransform NameTransform
	{
		get
		{
			return GAHBeOXnYZwueeJGLhLSJgJsZtNsA.NameTransform;
		}
		set
		{
			GAHBeOXnYZwueeJGLhLSJgJsZtNsA.NameTransform = value;
		}
	}

	public string Password
	{
		get
		{
			return yGnAmMCZHbalIhmePfpnRccumoRp;
		}
		set
		{
			yGnAmMCZHbalIhmePfpnRccumoRp = value;
		}
	}

	public bool RestoreAttributesOnExtract
	{
		get
		{
			return oIpbARwiYmSjppEECNwVYwtpDuDB;
		}
		set
		{
			oIpbARwiYmSjppEECNwVYwtpDuDB = value;
		}
	}

	public bool RestoreDateTimeOnExtract
	{
		get
		{
			return sfzedyFewsPLQUFgACxckzqRqnOBA;
		}
		set
		{
			sfzedyFewsPLQUFgACxckzqRqnOBA = value;
		}
	}

	public UseZip64 UseZip64
	{
		get
		{
			return bKsRPzWeosiiVJMdrYkiLDpYbLKcA;
		}
		set
		{
			bKsRPzWeosiiVJMdrYkiLDpYbLKcA = value;
		}
	}

	public FastZip()
	{
		GAHBeOXnYZwueeJGLhLSJgJsZtNsA = new ZipEntryFactory();
		bKsRPzWeosiiVJMdrYkiLDpYbLKcA = UseZip64.Dynamic;
	}

	public FastZip(FastZipEvents events)
	{
		GAHBeOXnYZwueeJGLhLSJgJsZtNsA = new ZipEntryFactory();
		bKsRPzWeosiiVJMdrYkiLDpYbLKcA = UseZip64.Dynamic;
		PKFaIUpPAKnjEvjGabFNBjWUwiAn = events;
	}

	private void DABokwxHFOCDJcbWLilSYjCubpxAA(string name, Stream stream)
	{
		if (stream != null)
		{
			if (apDMpruwtLlJCAuUPtphtOimkoBl == null)
			{
				apDMpruwtLlJCAuUPtphtOimkoBl = new byte[4096];
			}
			if (PKFaIUpPAKnjEvjGabFNBjWUwiAn != null && PKFaIUpPAKnjEvjGabFNBjWUwiAn.Progress != null)
			{
				StreamUtils.Copy(stream, zwTbIECxvzYAUItQZIaVqKwoDPmdb, apDMpruwtLlJCAuUPtphtOimkoBl, PKFaIUpPAKnjEvjGabFNBjWUwiAn.Progress, PKFaIUpPAKnjEvjGabFNBjWUwiAn.ProgressInterval, this, name);
			}
			else
			{
				StreamUtils.Copy(stream, zwTbIECxvzYAUItQZIaVqKwoDPmdb, apDMpruwtLlJCAuUPtphtOimkoBl);
			}
			if (PKFaIUpPAKnjEvjGabFNBjWUwiAn != null)
			{
				nPreNlszaOiKdPricjwweQSuQLgV = PKFaIUpPAKnjEvjGabFNBjWUwiAn.OnCompletedFile(name);
			}
			return;
		}
		throw new ArgumentNullException("stream");
	}

	public void CreateZip(string zipFileName, string sourceDirectory, bool recurse, string fileFilter)
	{
		CreateZip(File.Create(zipFileName), sourceDirectory, recurse, fileFilter, null);
	}

	public void CreateZip(Stream outputStream, string sourceDirectory, bool recurse, string fileFilter, string directoryFilter)
	{
		NameTransform = new ZipNameTransform(sourceDirectory);
		ocGUtCZkYuENAOBowhfepLgwBCPf = sourceDirectory;
		using (zwTbIECxvzYAUItQZIaVqKwoDPmdb = new ZipOutputStream(outputStream))
		{
			if (yGnAmMCZHbalIhmePfpnRccumoRp != null)
			{
				zwTbIECxvzYAUItQZIaVqKwoDPmdb.Password = yGnAmMCZHbalIhmePfpnRccumoRp;
			}
			zwTbIECxvzYAUItQZIaVqKwoDPmdb.UseZip64 = UseZip64;
			FileSystemScanner fileSystemScanner = new FileSystemScanner(fileFilter, directoryFilter);
			FileSystemScanner fileSystemScanner2 = fileSystemScanner;
			fileSystemScanner2.ProcessFile = (ProcessFileHandler)Delegate.Combine(fileSystemScanner2.ProcessFile, new ProcessFileHandler(nULghWIthOgOUiAQvXCDcITfDvWgB));
			if (CreateEmptyDirectories)
			{
				FileSystemScanner fileSystemScanner3 = fileSystemScanner;
				fileSystemScanner3.ProcessDirectory = (ProcessDirectoryHandler)Delegate.Combine(fileSystemScanner3.ProcessDirectory, new ProcessDirectoryHandler(DPlaIYkkeMFWisujinEPanVgtSHKb));
			}
			if (PKFaIUpPAKnjEvjGabFNBjWUwiAn != null)
			{
				if (PKFaIUpPAKnjEvjGabFNBjWUwiAn.FileFailure != null)
				{
					FileSystemScanner fileSystemScanner4 = fileSystemScanner;
					fileSystemScanner4.FileFailure = (FileFailureHandler)Delegate.Combine(fileSystemScanner4.FileFailure, PKFaIUpPAKnjEvjGabFNBjWUwiAn.FileFailure);
				}
				if (PKFaIUpPAKnjEvjGabFNBjWUwiAn.DirectoryFailure != null)
				{
					FileSystemScanner fileSystemScanner5 = fileSystemScanner;
					fileSystemScanner5.DirectoryFailure = (DirectoryFailureHandler)Delegate.Combine(fileSystemScanner5.DirectoryFailure, PKFaIUpPAKnjEvjGabFNBjWUwiAn.DirectoryFailure);
				}
			}
			fileSystemScanner.Scan(sourceDirectory, recurse);
		}
	}

	public void CreateZip(string zipFileName, string sourceDirectory, bool recurse, string fileFilter, string directoryFilter)
	{
		CreateZip(File.Create(zipFileName), sourceDirectory, recurse, fileFilter, directoryFilter);
	}

	private void AYMKLXvsghVwlCsKiGanYIemWxPj(ZipEntry entry)
	{
		bool flag = entry.IsCompressionMethodSupported();
		string text = entry.Name;
		if (flag)
		{
			if (!entry.IsFile)
			{
				if (entry.IsDirectory)
				{
					text = APbksnpmEfREeaGgRuJRsxyNVvNH.TransformDirectory(text);
				}
			}
			else
			{
				text = APbksnpmEfREeaGgRuJRsxyNVvNH.TransformFile(text);
			}
			flag = text != null && text.Length != 0;
		}
		string path = null;
		if (flag)
		{
			path = (entry.IsDirectory ? text : Path.GetDirectoryName(Path.GetFullPath(text)));
		}
		if (flag && !Directory.Exists(path) && (!entry.IsDirectory || CreateEmptyDirectories))
		{
			try
			{
				Directory.CreateDirectory(path);
			}
			catch (Exception exception_)
			{
				flag = false;
				if (PKFaIUpPAKnjEvjGabFNBjWUwiAn == null)
				{
					nPreNlszaOiKdPricjwweQSuQLgV = false;
					throw;
				}
				if (!entry.IsDirectory)
				{
					nPreNlszaOiKdPricjwweQSuQLgV = PKFaIUpPAKnjEvjGabFNBjWUwiAn.OnFileFailure(text, exception_);
				}
				else
				{
					nPreNlszaOiKdPricjwweQSuQLgV = PKFaIUpPAKnjEvjGabFNBjWUwiAn.OnDirectoryFailure(text, exception_);
				}
			}
		}
		if (flag && entry.IsFile)
		{
			QvFAHnckmtIskeclheoEyAbrUdxZ(entry, text);
		}
	}

	private void QvFAHnckmtIskeclheoEyAbrUdxZ(ZipEntry entry, string targetName)
	{
		bool flag = true;
		if (xtPvRcVOERbYzqDZyQDCvTvlzBzg != Overwrite.Always && File.Exists(targetName))
		{
			flag = xtPvRcVOERbYzqDZyQDCvTvlzBzg == Overwrite.Prompt && rcnoxbZUEBYOBGKyXFaoAaHfyEEm != null && rcnoxbZUEBYOBGKyXFaoAaHfyEEm(targetName);
		}
		if (!flag)
		{
			return;
		}
		if (PKFaIUpPAKnjEvjGabFNBjWUwiAn != null)
		{
			nPreNlszaOiKdPricjwweQSuQLgV = PKFaIUpPAKnjEvjGabFNBjWUwiAn.OnProcessFile(entry.Name);
		}
		if (!nPreNlszaOiKdPricjwweQSuQLgV)
		{
			return;
		}
		try
		{
			using (FileStream destination = File.Create(targetName))
			{
				if (apDMpruwtLlJCAuUPtphtOimkoBl == null)
				{
					apDMpruwtLlJCAuUPtphtOimkoBl = new byte[4096];
				}
				if (PKFaIUpPAKnjEvjGabFNBjWUwiAn == null || PKFaIUpPAKnjEvjGabFNBjWUwiAn.Progress == null)
				{
					StreamUtils.Copy(YWcZOOdhJvCLkNXCwAijEUDPtuCuA.GetInputStream(entry), destination, apDMpruwtLlJCAuUPtphtOimkoBl);
				}
				else
				{
					StreamUtils.Copy(YWcZOOdhJvCLkNXCwAijEUDPtuCuA.GetInputStream(entry), destination, apDMpruwtLlJCAuUPtphtOimkoBl, PKFaIUpPAKnjEvjGabFNBjWUwiAn.Progress, PKFaIUpPAKnjEvjGabFNBjWUwiAn.ProgressInterval, this, entry.Name, entry.Size);
				}
				if (PKFaIUpPAKnjEvjGabFNBjWUwiAn != null)
				{
					nPreNlszaOiKdPricjwweQSuQLgV = PKFaIUpPAKnjEvjGabFNBjWUwiAn.OnCompletedFile(entry.Name);
				}
			}
			if (sfzedyFewsPLQUFgACxckzqRqnOBA)
			{
				File.SetLastWriteTime(targetName, entry.DateTime);
			}
			if (RestoreAttributesOnExtract && entry.IsDOSEntry && entry.ExternalFileAttributes != -1)
			{
				FileAttributes fileAttributes = (FileAttributes)(entry.ExternalFileAttributes & 0xA3);
				File.SetAttributes(targetName, fileAttributes);
			}
		}
		catch (Exception exception_)
		{
			if (PKFaIUpPAKnjEvjGabFNBjWUwiAn == null)
			{
				nPreNlszaOiKdPricjwweQSuQLgV = false;
				throw;
			}
			nPreNlszaOiKdPricjwweQSuQLgV = PKFaIUpPAKnjEvjGabFNBjWUwiAn.OnFileFailure(targetName, exception_);
		}
	}

	public void ExtractZip(string zipFileName, string targetDirectory, string fileFilter)
	{
		ExtractZip(zipFileName, targetDirectory, Overwrite.Always, null, fileFilter, null, sfzedyFewsPLQUFgACxckzqRqnOBA);
	}

	public void ExtractZip(string zipFileName, string targetDirectory, Overwrite overwrite, ConfirmOverwriteDelegate confirmDelegate, string fileFilter, string directoryFilter, bool restoreDateTime)
	{
		if (overwrite != 0 || confirmDelegate != null)
		{
			nPreNlszaOiKdPricjwweQSuQLgV = true;
			xtPvRcVOERbYzqDZyQDCvTvlzBzg = overwrite;
			rcnoxbZUEBYOBGKyXFaoAaHfyEEm = confirmDelegate;
			APbksnpmEfREeaGgRuJRsxyNVvNH = new WindowsNameTransform(targetDirectory);
			wKydZuOcoODDyquyLpOyWATujZQ = new NameFilter(fileFilter);
			pxlaYbJffTNlOZYoilHxnaPprzZC = new NameFilter(directoryFilter);
			sfzedyFewsPLQUFgACxckzqRqnOBA = restoreDateTime;
			using (YWcZOOdhJvCLkNXCwAijEUDPtuCuA = new ZipFile(zipFileName))
			{
				if (yGnAmMCZHbalIhmePfpnRccumoRp != null)
				{
					YWcZOOdhJvCLkNXCwAijEUDPtuCuA.Password = yGnAmMCZHbalIhmePfpnRccumoRp;
				}
				IEnumerator enumerator = YWcZOOdhJvCLkNXCwAijEUDPtuCuA.GetEnumerator();
				while (nPreNlszaOiKdPricjwweQSuQLgV && enumerator.MoveNext())
				{
					ZipEntry zipEntry = (ZipEntry)enumerator.Current;
					if (!zipEntry.IsFile)
					{
						if (zipEntry.IsDirectory && pxlaYbJffTNlOZYoilHxnaPprzZC.IsMatch(zipEntry.Name) && CreateEmptyDirectories)
						{
							AYMKLXvsghVwlCsKiGanYIemWxPj(zipEntry);
						}
					}
					else if (pxlaYbJffTNlOZYoilHxnaPprzZC.IsMatch(Path.GetDirectoryName(zipEntry.Name)) && wKydZuOcoODDyquyLpOyWATujZQ.IsMatch(zipEntry.Name))
					{
						AYMKLXvsghVwlCsKiGanYIemWxPj(zipEntry);
					}
				}
				return;
			}
		}
		throw new ArgumentNullException("confirmDelegate");
	}

	private static int gDaYyRkXtcUzQfBBSglcSqoeVAQT(FileInfo info)
	{
		return (int)info.Attributes;
	}

	private static bool StlASUYpadZentHypKPLHFsNygXk(string name)
	{
		return name != null && name.Length > 0 && name.IndexOfAny(Path.GetInvalidPathChars()) < 0;
	}

	private void DPlaIYkkeMFWisujinEPanVgtSHKb(object sender, DirectoryEventArgs e)
	{
		if (!e.HasMatchingFiles && CreateEmptyDirectories)
		{
			if (PKFaIUpPAKnjEvjGabFNBjWUwiAn != null)
			{
				PKFaIUpPAKnjEvjGabFNBjWUwiAn.OnProcessDirectory(e.Name, e.HasMatchingFiles);
			}
			if (e.ContinueRunning && e.Name != ocGUtCZkYuENAOBowhfepLgwBCPf)
			{
				ZipEntry entry = GAHBeOXnYZwueeJGLhLSJgJsZtNsA.MakeDirectoryEntry(e.Name);
				zwTbIECxvzYAUItQZIaVqKwoDPmdb.PutNextEntry(entry);
			}
		}
	}

	private void nULghWIthOgOUiAQvXCDcITfDvWgB(object sender, ScanEventArgs e)
	{
		if (PKFaIUpPAKnjEvjGabFNBjWUwiAn != null && PKFaIUpPAKnjEvjGabFNBjWUwiAn.ProcessFile != null)
		{
			PKFaIUpPAKnjEvjGabFNBjWUwiAn.ProcessFile(sender, e);
		}
		if (e.ContinueRunning)
		{
			using (FileStream stream = File.OpenRead(e.Name))
			{
				ZipEntry entry = GAHBeOXnYZwueeJGLhLSJgJsZtNsA.MakeFileEntry(e.Name);
				zwTbIECxvzYAUItQZIaVqKwoDPmdb.PutNextEntry(entry);
				DABokwxHFOCDJcbWLilSYjCubpxAA(e.Name, stream);
			}
		}
	}
}
