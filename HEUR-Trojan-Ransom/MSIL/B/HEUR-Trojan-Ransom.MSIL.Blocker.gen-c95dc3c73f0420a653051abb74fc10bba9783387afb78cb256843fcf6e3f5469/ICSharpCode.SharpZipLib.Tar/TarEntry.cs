using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Tar;

public class TarEntry : ICloneable
{
	private string rGvGbWtqlCLDJhoYUXdeUyHGEvSE;

	private TarHeader UPfZSYNLPQcxFgasndIsQSNuUghBA;

	public string File => rGvGbWtqlCLDJhoYUXdeUyHGEvSE;

	public int GroupId
	{
		get
		{
			return UPfZSYNLPQcxFgasndIsQSNuUghBA.GroupId;
		}
		set
		{
			UPfZSYNLPQcxFgasndIsQSNuUghBA.GroupId = value;
		}
	}

	public string GroupName
	{
		get
		{
			return UPfZSYNLPQcxFgasndIsQSNuUghBA.GroupName;
		}
		set
		{
			UPfZSYNLPQcxFgasndIsQSNuUghBA.GroupName = value;
		}
	}

	public bool IsDirectory
	{
		get
		{
			if (rGvGbWtqlCLDJhoYUXdeUyHGEvSE != null)
			{
				return Directory.Exists(rGvGbWtqlCLDJhoYUXdeUyHGEvSE);
			}
			if (UPfZSYNLPQcxFgasndIsQSNuUghBA != null && (UPfZSYNLPQcxFgasndIsQSNuUghBA.TypeFlag == 53 || Name.EndsWith("/")))
			{
				return true;
			}
			return false;
		}
	}

	public DateTime ModTime
	{
		get
		{
			return UPfZSYNLPQcxFgasndIsQSNuUghBA.ModTime;
		}
		set
		{
			UPfZSYNLPQcxFgasndIsQSNuUghBA.ModTime = value;
		}
	}

	public string Name
	{
		get
		{
			return UPfZSYNLPQcxFgasndIsQSNuUghBA.Name;
		}
		set
		{
			UPfZSYNLPQcxFgasndIsQSNuUghBA.Name = value;
		}
	}

	public long Size
	{
		get
		{
			return UPfZSYNLPQcxFgasndIsQSNuUghBA.Size;
		}
		set
		{
			UPfZSYNLPQcxFgasndIsQSNuUghBA.Size = value;
		}
	}

	public TarHeader TarHeader => UPfZSYNLPQcxFgasndIsQSNuUghBA;

	public int UserId
	{
		get
		{
			return UPfZSYNLPQcxFgasndIsQSNuUghBA.UserId;
		}
		set
		{
			UPfZSYNLPQcxFgasndIsQSNuUghBA.UserId = value;
		}
	}

	public string UserName
	{
		get
		{
			return UPfZSYNLPQcxFgasndIsQSNuUghBA.UserName;
		}
		set
		{
			UPfZSYNLPQcxFgasndIsQSNuUghBA.UserName = value;
		}
	}

	private TarEntry()
	{
		UPfZSYNLPQcxFgasndIsQSNuUghBA = new TarHeader();
	}

	public TarEntry(byte[] headerBuffer)
	{
		UPfZSYNLPQcxFgasndIsQSNuUghBA = new TarHeader();
		UPfZSYNLPQcxFgasndIsQSNuUghBA.ParseBuffer(headerBuffer);
	}

	public TarEntry(TarHeader header)
	{
		if (header == null)
		{
			throw new ArgumentNullException("header");
		}
		UPfZSYNLPQcxFgasndIsQSNuUghBA = (TarHeader)header.Clone();
	}

	public static void AdjustEntryName(byte[] buffer, string newName)
	{
		TarHeader.GetNameBytes(newName, buffer, 0, 100);
	}

	public object Clone()
	{
		return new TarEntry
		{
			rGvGbWtqlCLDJhoYUXdeUyHGEvSE = rGvGbWtqlCLDJhoYUXdeUyHGEvSE,
			UPfZSYNLPQcxFgasndIsQSNuUghBA = (TarHeader)UPfZSYNLPQcxFgasndIsQSNuUghBA.Clone(),
			Name = Name
		};
	}

	public static TarEntry CreateEntryFromFile(string fileName)
	{
		TarEntry tarEntry = new TarEntry();
		tarEntry.GetFileTarHeader(tarEntry.UPfZSYNLPQcxFgasndIsQSNuUghBA, fileName);
		return tarEntry;
	}

	public static TarEntry CreateTarEntry(string name)
	{
		TarEntry tarEntry = new TarEntry();
		NameTarHeader(tarEntry.UPfZSYNLPQcxFgasndIsQSNuUghBA, name);
		return tarEntry;
	}

	public override bool Equals(object object_0)
	{
		if (object_0 is TarEntry tarEntry)
		{
			return Name.Equals(tarEntry.Name);
		}
		return false;
	}

	public TarEntry[] GetDirectoryEntries()
	{
		if (rGvGbWtqlCLDJhoYUXdeUyHGEvSE != null && Directory.Exists(rGvGbWtqlCLDJhoYUXdeUyHGEvSE))
		{
			string[] fileSystemEntries = Directory.GetFileSystemEntries(rGvGbWtqlCLDJhoYUXdeUyHGEvSE);
			TarEntry[] array = new TarEntry[fileSystemEntries.Length];
			for (int i = 0; i < fileSystemEntries.Length; i++)
			{
				array[i] = CreateEntryFromFile(fileSystemEntries[i]);
			}
			return array;
		}
		return new TarEntry[0];
	}

	public void GetFileTarHeader(TarHeader header, string file)
	{
		if (header == null)
		{
			throw new ArgumentNullException("header");
		}
		if (file == null)
		{
			throw new ArgumentNullException("file");
		}
		rGvGbWtqlCLDJhoYUXdeUyHGEvSE = file;
		string text = file;
		if (text.IndexOf(Environment.CurrentDirectory) == 0)
		{
			text = text.Substring(Environment.CurrentDirectory.Length);
		}
		text = text.Replace(Path.DirectorySeparatorChar, '/');
		while (text.StartsWith("/"))
		{
			text = text.Substring(1);
		}
		header.LinkName = string.Empty;
		header.Name = text;
		if (Directory.Exists(file))
		{
			header.Mode = 1003;
			header.TypeFlag = 53;
			if (header.Name.Length == 0 || header.Name[header.Name.Length - 1] != '/')
			{
				header.Name += "/";
			}
			header.Size = 0L;
		}
		else
		{
			header.Mode = 33216;
			header.TypeFlag = 48;
			header.Size = new FileInfo(file.Replace('/', Path.DirectorySeparatorChar)).Length;
		}
		header.ModTime = System.IO.File.GetLastWriteTime(file.Replace('/', Path.DirectorySeparatorChar)).ToUniversalTime();
		header.DevMajor = 0;
		header.DevMinor = 0;
	}

	public override int GetHashCode()
	{
		return Name.GetHashCode();
	}

	public bool IsDescendent(TarEntry toTest)
	{
		if (toTest == null)
		{
			throw new ArgumentNullException("toTest");
		}
		return toTest.Name.StartsWith(Name);
	}

	public static void NameTarHeader(TarHeader header, string name)
	{
		if (header == null)
		{
			throw new ArgumentNullException("header");
		}
		if (name != null)
		{
			bool flag = name.EndsWith("/");
			header.Name = name;
			header.Mode = (flag ? 1003 : 33216);
			header.UserId = 0;
			header.GroupId = 0;
			header.Size = 0L;
			header.ModTime = DateTime.UtcNow;
			header.TypeFlag = (byte)(flag ? 53 : 48);
			header.LinkName = string.Empty;
			header.UserName = string.Empty;
			header.GroupName = string.Empty;
			header.DevMajor = 0;
			header.DevMinor = 0;
			return;
		}
		throw new ArgumentNullException("name");
	}

	public void SetIds(int userId, int groupId)
	{
		UserId = userId;
		GroupId = groupId;
	}

	public void SetNames(string userName, string groupName)
	{
		UserName = userName;
		GroupName = groupName;
	}

	public void WriteEntryHeader(byte[] outBuffer)
	{
		UPfZSYNLPQcxFgasndIsQSNuUghBA.WriteHeader(outBuffer);
	}
}
