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

	private byte[] dBDQqMWitmmPAbOzGDgIDezrgZMY;

	private ConfirmOverwriteDelegate uudpIYxUEuHkPrSVAnYTcdQmrHNS;

	private bool cfdpmYMeyzmirebDvJdHUjVlcmtfA;

	private bool XqpMeYIyBEBFqVXmAQrEPHNzALJl;

	private NameFilter eKxzKYnppabzSDgznuwURKfofGEjA;

	private IEntryFactory JrViIhxWCusIwZozUTGtAuWlQCCv;

	private FastZipEvents YdFPIrBBAvRLOQIllLYczQTPMTVM;

	private INameTransform ZIduWEXJmYPvwTLXQubaAsjMjsCP;

	private NameFilter xfObLqGVcZhnBJBJlgovjEXEOQQyB;

	private ZipOutputStream sDhohBozWiqKCgzUKzesSxdHenT;

	private Overwrite qFDqXFznCqWVrNmuxKNbHmUefWciA;

	private string bXrDCxobHKSXCSOHINiCjLrxAZAP;

	private bool nehCVzEOmNJkvmAhXyEPDcxcvirqA;

	private bool lkxDDkOiGXrIMmDWNyVJHjCEKBXB;

	private string dqWtmtzmiHAuOdRepviDRkOdjiUz;

	private UseZip64 svuDrGoXqHoWNqaKclrVfIkLByFbA;

	private ZipFile BJoclnJfTIvUyqejhbkMaxUYHeLL;

	public bool CreateEmptyDirectories
	{
		get
		{
			return XqpMeYIyBEBFqVXmAQrEPHNzALJl;
		}
		set
		{
			XqpMeYIyBEBFqVXmAQrEPHNzALJl = value;
		}
	}

	public IEntryFactory EntryFactory
	{
		get
		{
			return JrViIhxWCusIwZozUTGtAuWlQCCv;
		}
		set
		{
			if (value == null)
			{
				JrViIhxWCusIwZozUTGtAuWlQCCv = new ZipEntryFactory();
			}
			else
			{
				JrViIhxWCusIwZozUTGtAuWlQCCv = value;
			}
		}
	}

	public INameTransform NameTransform
	{
		get
		{
			return JrViIhxWCusIwZozUTGtAuWlQCCv.NameTransform;
		}
		set
		{
			JrViIhxWCusIwZozUTGtAuWlQCCv.NameTransform = value;
		}
	}

	public string Password
	{
		get
		{
			return bXrDCxobHKSXCSOHINiCjLrxAZAP;
		}
		set
		{
			bXrDCxobHKSXCSOHINiCjLrxAZAP = value;
		}
	}

	public bool RestoreAttributesOnExtract
	{
		get
		{
			return nehCVzEOmNJkvmAhXyEPDcxcvirqA;
		}
		set
		{
			nehCVzEOmNJkvmAhXyEPDcxcvirqA = value;
		}
	}

	public bool RestoreDateTimeOnExtract
	{
		get
		{
			return lkxDDkOiGXrIMmDWNyVJHjCEKBXB;
		}
		set
		{
			lkxDDkOiGXrIMmDWNyVJHjCEKBXB = value;
		}
	}

	public UseZip64 UseZip64
	{
		get
		{
			return svuDrGoXqHoWNqaKclrVfIkLByFbA;
		}
		set
		{
			svuDrGoXqHoWNqaKclrVfIkLByFbA = value;
		}
	}

	public FastZip()
	{
		JrViIhxWCusIwZozUTGtAuWlQCCv = new ZipEntryFactory();
		svuDrGoXqHoWNqaKclrVfIkLByFbA = UseZip64.Dynamic;
	}

	public FastZip(FastZipEvents events)
	{
		JrViIhxWCusIwZozUTGtAuWlQCCv = new ZipEntryFactory();
		svuDrGoXqHoWNqaKclrVfIkLByFbA = UseZip64.Dynamic;
		YdFPIrBBAvRLOQIllLYczQTPMTVM = events;
	}

	private void WURWODNKBdawHLChKjehofXpBIuZ(string name, Stream stream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (dBDQqMWitmmPAbOzGDgIDezrgZMY == null)
		{
			dBDQqMWitmmPAbOzGDgIDezrgZMY = new byte[4096];
		}
		if (YdFPIrBBAvRLOQIllLYczQTPMTVM != null && YdFPIrBBAvRLOQIllLYczQTPMTVM.Progress != null)
		{
			StreamUtils.Copy(stream, sDhohBozWiqKCgzUKzesSxdHenT, dBDQqMWitmmPAbOzGDgIDezrgZMY, YdFPIrBBAvRLOQIllLYczQTPMTVM.Progress, YdFPIrBBAvRLOQIllLYczQTPMTVM.ProgressInterval, this, name);
		}
		else
		{
			StreamUtils.Copy(stream, sDhohBozWiqKCgzUKzesSxdHenT, dBDQqMWitmmPAbOzGDgIDezrgZMY);
		}
		if (YdFPIrBBAvRLOQIllLYczQTPMTVM != null)
		{
			cfdpmYMeyzmirebDvJdHUjVlcmtfA = YdFPIrBBAvRLOQIllLYczQTPMTVM.OnCompletedFile(name);
		}
	}

	public void CreateZip(string zipFileName, string sourceDirectory, bool recurse, string fileFilter)
	{
		CreateZip(File.Create(zipFileName), sourceDirectory, recurse, fileFilter, null);
	}

	public void CreateZip(Stream outputStream, string sourceDirectory, bool recurse, string fileFilter, string directoryFilter)
	{
		NameTransform = new ZipNameTransform(sourceDirectory);
		dqWtmtzmiHAuOdRepviDRkOdjiUz = sourceDirectory;
		using (sDhohBozWiqKCgzUKzesSxdHenT = new ZipOutputStream(outputStream))
		{
			if (bXrDCxobHKSXCSOHINiCjLrxAZAP != null)
			{
				sDhohBozWiqKCgzUKzesSxdHenT.Password = bXrDCxobHKSXCSOHINiCjLrxAZAP;
			}
			sDhohBozWiqKCgzUKzesSxdHenT.UseZip64 = UseZip64;
			FileSystemScanner fileSystemScanner = new FileSystemScanner(fileFilter, directoryFilter);
			fileSystemScanner.ProcessFile = (ProcessFileHandler)Delegate.Combine(fileSystemScanner.ProcessFile, new ProcessFileHandler(ozVVctNhkzuAOvCjiVycyFMYGgXH));
			if (CreateEmptyDirectories)
			{
				fileSystemScanner.ProcessDirectory = (ProcessDirectoryHandler)Delegate.Combine(fileSystemScanner.ProcessDirectory, new ProcessDirectoryHandler(vLkpDSwfIicXJUnbBmMRSgSxAIA));
			}
			if (YdFPIrBBAvRLOQIllLYczQTPMTVM != null)
			{
				if (YdFPIrBBAvRLOQIllLYczQTPMTVM.FileFailure != null)
				{
					fileSystemScanner.FileFailure = (FileFailureHandler)Delegate.Combine(fileSystemScanner.FileFailure, YdFPIrBBAvRLOQIllLYczQTPMTVM.FileFailure);
				}
				if (YdFPIrBBAvRLOQIllLYczQTPMTVM.DirectoryFailure != null)
				{
					fileSystemScanner.DirectoryFailure = (DirectoryFailureHandler)Delegate.Combine(fileSystemScanner.DirectoryFailure, YdFPIrBBAvRLOQIllLYczQTPMTVM.DirectoryFailure);
				}
			}
			fileSystemScanner.Scan(sourceDirectory, recurse);
		}
	}

	public void CreateZip(string zipFileName, string sourceDirectory, bool recurse, string fileFilter, string directoryFilter)
	{
		CreateZip(File.Create(zipFileName), sourceDirectory, recurse, fileFilter, directoryFilter);
	}

	private void HmYWccVZgMjttpLXzFBQqlpvPdAo(ZipEntry entry)
	{
		bool flag = entry.IsCompressionMethodSupported();
		string text = entry.Name;
		if (flag)
		{
			if (!entry.IsFile)
			{
				if (entry.IsDirectory)
				{
					text = ZIduWEXJmYPvwTLXQubaAsjMjsCP.TransformDirectory(text);
				}
			}
			else
			{
				text = ZIduWEXJmYPvwTLXQubaAsjMjsCP.TransformFile(text);
			}
			flag = text != null && text.Length != 0;
		}
		string path = null;
		if (flag)
		{
			path = ((!entry.IsDirectory) ? Path.GetDirectoryName(Path.GetFullPath(text)) : text);
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
				if (YdFPIrBBAvRLOQIllLYczQTPMTVM == null)
				{
					cfdpmYMeyzmirebDvJdHUjVlcmtfA = false;
					throw;
				}
				if (entry.IsDirectory)
				{
					cfdpmYMeyzmirebDvJdHUjVlcmtfA = YdFPIrBBAvRLOQIllLYczQTPMTVM.OnDirectoryFailure(text, exception_);
				}
				else
				{
					cfdpmYMeyzmirebDvJdHUjVlcmtfA = YdFPIrBBAvRLOQIllLYczQTPMTVM.OnFileFailure(text, exception_);
				}
			}
		}
		if (flag && entry.IsFile)
		{
			RgFIrAKRmUnImHOGgjbrkQakxWmO(entry, text);
		}
	}

	private void RgFIrAKRmUnImHOGgjbrkQakxWmO(ZipEntry entry, string targetName)
	{
		bool flag = true;
		if (qFDqXFznCqWVrNmuxKNbHmUefWciA != Overwrite.Always && File.Exists(targetName))
		{
			flag = qFDqXFznCqWVrNmuxKNbHmUefWciA == Overwrite.Prompt && uudpIYxUEuHkPrSVAnYTcdQmrHNS != null && uudpIYxUEuHkPrSVAnYTcdQmrHNS(targetName);
		}
		if (!flag)
		{
			return;
		}
		if (YdFPIrBBAvRLOQIllLYczQTPMTVM != null)
		{
			cfdpmYMeyzmirebDvJdHUjVlcmtfA = YdFPIrBBAvRLOQIllLYczQTPMTVM.OnProcessFile(entry.Name);
		}
		if (!cfdpmYMeyzmirebDvJdHUjVlcmtfA)
		{
			return;
		}
		try
		{
			using (FileStream destination = File.Create(targetName))
			{
				if (dBDQqMWitmmPAbOzGDgIDezrgZMY == null)
				{
					dBDQqMWitmmPAbOzGDgIDezrgZMY = new byte[4096];
				}
				if (YdFPIrBBAvRLOQIllLYczQTPMTVM != null && YdFPIrBBAvRLOQIllLYczQTPMTVM.Progress != null)
				{
					StreamUtils.Copy(BJoclnJfTIvUyqejhbkMaxUYHeLL.GetInputStream(entry), destination, dBDQqMWitmmPAbOzGDgIDezrgZMY, YdFPIrBBAvRLOQIllLYczQTPMTVM.Progress, YdFPIrBBAvRLOQIllLYczQTPMTVM.ProgressInterval, this, entry.Name, entry.Size);
				}
				else
				{
					StreamUtils.Copy(BJoclnJfTIvUyqejhbkMaxUYHeLL.GetInputStream(entry), destination, dBDQqMWitmmPAbOzGDgIDezrgZMY);
				}
				if (YdFPIrBBAvRLOQIllLYczQTPMTVM != null)
				{
					cfdpmYMeyzmirebDvJdHUjVlcmtfA = YdFPIrBBAvRLOQIllLYczQTPMTVM.OnCompletedFile(entry.Name);
				}
			}
			if (lkxDDkOiGXrIMmDWNyVJHjCEKBXB)
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
			if (YdFPIrBBAvRLOQIllLYczQTPMTVM == null)
			{
				cfdpmYMeyzmirebDvJdHUjVlcmtfA = false;
				throw;
			}
			cfdpmYMeyzmirebDvJdHUjVlcmtfA = YdFPIrBBAvRLOQIllLYczQTPMTVM.OnFileFailure(targetName, exception_);
		}
	}

	public void ExtractZip(string zipFileName, string targetDirectory, string fileFilter)
	{
		ExtractZip(zipFileName, targetDirectory, Overwrite.Always, null, fileFilter, null, lkxDDkOiGXrIMmDWNyVJHjCEKBXB);
	}

	public void ExtractZip(string zipFileName, string targetDirectory, Overwrite overwrite, ConfirmOverwriteDelegate confirmDelegate, string fileFilter, string directoryFilter, bool restoreDateTime)
	{
		if (overwrite == Overwrite.Prompt && confirmDelegate == null)
		{
			throw new ArgumentNullException("confirmDelegate");
		}
		cfdpmYMeyzmirebDvJdHUjVlcmtfA = true;
		qFDqXFznCqWVrNmuxKNbHmUefWciA = overwrite;
		uudpIYxUEuHkPrSVAnYTcdQmrHNS = confirmDelegate;
		ZIduWEXJmYPvwTLXQubaAsjMjsCP = new WindowsNameTransform(targetDirectory);
		xfObLqGVcZhnBJBJlgovjEXEOQQyB = new NameFilter(fileFilter);
		eKxzKYnppabzSDgznuwURKfofGEjA = new NameFilter(directoryFilter);
		lkxDDkOiGXrIMmDWNyVJHjCEKBXB = restoreDateTime;
		using (BJoclnJfTIvUyqejhbkMaxUYHeLL = new ZipFile(zipFileName))
		{
			if (bXrDCxobHKSXCSOHINiCjLrxAZAP != null)
			{
				BJoclnJfTIvUyqejhbkMaxUYHeLL.Password = bXrDCxobHKSXCSOHINiCjLrxAZAP;
			}
			IEnumerator enumerator = BJoclnJfTIvUyqejhbkMaxUYHeLL.GetEnumerator();
			while (cfdpmYMeyzmirebDvJdHUjVlcmtfA && enumerator.MoveNext())
			{
				ZipEntry zipEntry = (ZipEntry)enumerator.Current;
				if (!zipEntry.IsFile)
				{
					if (zipEntry.IsDirectory && eKxzKYnppabzSDgznuwURKfofGEjA.IsMatch(zipEntry.Name) && CreateEmptyDirectories)
					{
						HmYWccVZgMjttpLXzFBQqlpvPdAo(zipEntry);
					}
				}
				else if (eKxzKYnppabzSDgznuwURKfofGEjA.IsMatch(Path.GetDirectoryName(zipEntry.Name)) && xfObLqGVcZhnBJBJlgovjEXEOQQyB.IsMatch(zipEntry.Name))
				{
					HmYWccVZgMjttpLXzFBQqlpvPdAo(zipEntry);
				}
			}
		}
	}

	private static bool NNbTgnqFrIWdpMLVwIRmfTnMtFSW(string name)
	{
		if (name != null && name.Length > 0)
		{
			return name.IndexOfAny(Path.GetInvalidPathChars()) < 0;
		}
		return false;
	}

	private void vLkpDSwfIicXJUnbBmMRSgSxAIA(object sender, DirectoryEventArgs e)
	{
		if (!e.HasMatchingFiles && CreateEmptyDirectories)
		{
			if (YdFPIrBBAvRLOQIllLYczQTPMTVM != null)
			{
				YdFPIrBBAvRLOQIllLYczQTPMTVM.OnProcessDirectory(e.Name, e.HasMatchingFiles);
			}
			if (e.ContinueRunning && e.Name != dqWtmtzmiHAuOdRepviDRkOdjiUz)
			{
				ZipEntry entry = JrViIhxWCusIwZozUTGtAuWlQCCv.MakeDirectoryEntry(e.Name);
				sDhohBozWiqKCgzUKzesSxdHenT.PutNextEntry(entry);
			}
		}
	}

	private void ozVVctNhkzuAOvCjiVycyFMYGgXH(object sender, ScanEventArgs e)
	{
		if (YdFPIrBBAvRLOQIllLYczQTPMTVM != null && YdFPIrBBAvRLOQIllLYczQTPMTVM.ProcessFile != null)
		{
			YdFPIrBBAvRLOQIllLYczQTPMTVM.ProcessFile(sender, e);
		}
		if (e.ContinueRunning)
		{
			using (FileStream stream = File.OpenRead(e.Name))
			{
				ZipEntry entry = JrViIhxWCusIwZozUTGtAuWlQCCv.MakeFileEntry(e.Name);
				sDhohBozWiqKCgzUKzesSxdHenT.PutNextEntry(entry);
				WURWODNKBdawHLChKjehofXpBIuZ(e.Name, stream);
			}
		}
	}
}
