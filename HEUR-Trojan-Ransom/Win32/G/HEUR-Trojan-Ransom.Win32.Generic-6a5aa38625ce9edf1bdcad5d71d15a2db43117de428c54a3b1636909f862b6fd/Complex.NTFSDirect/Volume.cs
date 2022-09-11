using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace Complex.NTFSDirect;

public class Volume
{
	public void EnumerateVolume(string drive, HashSet<string> fileExtensions, out Dictionary<ulong, FileEntry> files, out Dictionary<ulong, FileEntry> directories)
	{
		directories = new Dictionary<ulong, FileEntry>();
		files = new Dictionary<ulong, FileEntry>();
		IntPtr medBuffer = IntPtr.Zero;
		IntPtr changeJournalRootHandle = IntPtr.Zero;
		try
		{
			GetRootFrnEntry(drive, directories);
			GetRootHandle(drive, out changeJournalRootHandle);
			CreateChangeJournal(changeJournalRootHandle);
			SetupMFT_Enum_DataBuffer(ref medBuffer, changeJournalRootHandle);
			EnumerateFiles(medBuffer, ref files, fileExtensions, directories, changeJournalRootHandle);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException("Error in EnumerateVolume()", ex);
		}
		finally
		{
			if (changeJournalRootHandle.ToInt32() != -1)
			{
				WinApi.CloseHandle(changeJournalRootHandle);
			}
			if (medBuffer != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(medBuffer);
			}
		}
	}

	private void GetRootFrnEntry(string drive, Dictionary<ulong, FileEntry> directories)
	{
		string text = "\\\\.\\" + drive;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = WinApi.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			WinApi.BY_HANDLE_FILE_INFORMATION lpFileInformation = default(WinApi.BY_HANDLE_FILE_INFORMATION);
			if (WinApi.GetFileInformationByHandle(intPtr, out lpFileInformation))
			{
				ulong num = lpFileInformation.FileIndexHigh;
				ulong key = (num << 32) | lpFileInformation.FileIndexLow;
				FileEntry value = new FileEntry(text, 0uL);
				directories.Add(key, value);
			}
			WinApi.CloseHandle(intPtr);
		}
	}

	private void GetRootHandle(string drive, out IntPtr changeJournalRootHandle)
	{
		string lpFileName = "\\\\.\\" + drive;
		changeJournalRootHandle = WinApi.CreateFile(lpFileName, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void EnumerateFiles(IntPtr medBuffer, ref Dictionary<ulong, FileEntry> files, HashSet<string> fileExtensions, Dictionary<ulong, FileEntry> directories, IntPtr changeJournalRootHandle)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		WinApi.ZeroMemory(intPtr, 65544);
		uint lpBytesReturned = 0u;
		while (WinApi.DeviceIoControl(changeJournalRootHandle, 590003u, medBuffer, sizeof(WinApi.MFT_ENUM_DATA), intPtr, 65544, out lpBytesReturned, IntPtr.Zero))
		{
			IntPtr p = new IntPtr(intPtr.ToInt32() + 8);
			while (lpBytesReturned > 60)
			{
				WinApi.USN_RECORD uSN_RECORD = new WinApi.USN_RECORD(p);
				if (0 != (uSN_RECORD.FileAttributes & 0x10))
				{
					if (directories.ContainsKey(uSN_RECORD.FileReferenceNumber))
					{
						throw new Exception($"Duplicate FRN: {uSN_RECORD.FileReferenceNumber} for {uSN_RECORD.FileName}");
					}
					directories.Add(uSN_RECORD.FileReferenceNumber, new FileEntry(uSN_RECORD.FileName, uSN_RECORD.ParentFileReferenceNumber));
				}
				else
				{
					bool flag = true;
					if (fileExtensions != null)
					{
						string extension = Path.GetExtension(uSN_RECORD.FileName);
						flag = fileExtensions.Contains(extension);
					}
					if (flag)
					{
						if (!files.ContainsKey(uSN_RECORD.FileReferenceNumber))
						{
							files.Add(uSN_RECORD.FileReferenceNumber, new FileEntry(uSN_RECORD.FileName, uSN_RECORD.ParentFileReferenceNumber));
						}
						else
						{
							FileEntry fileEntry = files[uSN_RECORD.FileReferenceNumber];
							if (0 != string.Compare(uSN_RECORD.FileName, fileEntry.Name, ignoreCase: true))
							{
								Console.WriteLine("Attempt to add duplicate file reference number: {0} for file {1}, file from index {2}", uSN_RECORD.FileReferenceNumber, uSN_RECORD.FileName, fileEntry.Name);
								throw new Exception($"Duplicate FRN: {uSN_RECORD.FileReferenceNumber} for {uSN_RECORD.FileName}");
							}
						}
					}
				}
				p = new IntPtr(p.ToInt32() + uSN_RECORD.RecordLength);
				lpBytesReturned -= uSN_RECORD.RecordLength;
			}
			Marshal.WriteInt64(medBuffer, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void CreateChangeJournal(IntPtr changeJournalRootHandle)
	{
		WinApi.CREATE_USN_JOURNAL_DATA structure = default(WinApi.CREATE_USN_JOURNAL_DATA);
		structure.MaximumSize = 8388608uL;
		structure.AllocationDelta = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		WinApi.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		WinApi.DeviceIoControl(changeJournalRootHandle, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void SetupMFT_Enum_DataBuffer(ref IntPtr medBuffer, IntPtr changeJournalRootHandle)
	{
		uint lpBytesReturned = 0u;
		WinApi.USN_JOURNAL_DATA lpOutBuffer = default(WinApi.USN_JOURNAL_DATA);
		if (WinApi.DeviceIoControl(changeJournalRootHandle, 590068u, IntPtr.Zero, 0, out lpOutBuffer, sizeof(WinApi.USN_JOURNAL_DATA), out lpBytesReturned, IntPtr.Zero))
		{
			WinApi.MFT_ENUM_DATA structure = default(WinApi.MFT_ENUM_DATA);
			structure.StartFileReferenceNumber = 0uL;
			structure.LowUsn = 0L;
			structure.HighUsn = lpOutBuffer.NextUsn;
			int num = Marshal.SizeOf(structure);
			medBuffer = Marshal.AllocHGlobal(num);
			WinApi.ZeroMemory(medBuffer, num);
			Marshal.StructureToPtr(structure, medBuffer, fDeleteOld: true);
		}
	}
}
