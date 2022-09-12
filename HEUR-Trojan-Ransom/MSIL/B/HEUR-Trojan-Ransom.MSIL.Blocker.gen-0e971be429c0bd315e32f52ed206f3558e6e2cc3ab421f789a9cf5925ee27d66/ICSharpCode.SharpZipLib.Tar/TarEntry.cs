using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Tar;

public class TarEntry : ICloneable
{
	private string oclgwzdRyjHpRrMLPgEZGyhdLbBJB;

	private TarHeader BVryKdnfZxNpBRJNoFNFuHQtiFyR;

	public string File => oclgwzdRyjHpRrMLPgEZGyhdLbBJB;

	public int GroupId
	{
		get
		{
			return BVryKdnfZxNpBRJNoFNFuHQtiFyR.GroupId;
		}
		set
		{
			BVryKdnfZxNpBRJNoFNFuHQtiFyR.GroupId = value;
		}
	}

	public string GroupName
	{
		get
		{
			return BVryKdnfZxNpBRJNoFNFuHQtiFyR.GroupName;
		}
		set
		{
			BVryKdnfZxNpBRJNoFNFuHQtiFyR.GroupName = value;
		}
	}

	public bool IsDirectory
	{
		get
		{
			if (oclgwzdRyjHpRrMLPgEZGyhdLbBJB != null)
			{
				return Directory.Exists(oclgwzdRyjHpRrMLPgEZGyhdLbBJB);
			}
			if (BVryKdnfZxNpBRJNoFNFuHQtiFyR != null && (BVryKdnfZxNpBRJNoFNFuHQtiFyR.TypeFlag == 53 || Name.EndsWith("/")))
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
			return BVryKdnfZxNpBRJNoFNFuHQtiFyR.ModTime;
		}
		set
		{
			BVryKdnfZxNpBRJNoFNFuHQtiFyR.ModTime = value;
		}
	}

	public string Name
	{
		get
		{
			return BVryKdnfZxNpBRJNoFNFuHQtiFyR.Name;
		}
		set
		{
			BVryKdnfZxNpBRJNoFNFuHQtiFyR.Name = value;
		}
	}

	public long Size
	{
		get
		{
			return BVryKdnfZxNpBRJNoFNFuHQtiFyR.Size;
		}
		set
		{
			BVryKdnfZxNpBRJNoFNFuHQtiFyR.Size = value;
		}
	}

	public TarHeader TarHeader => BVryKdnfZxNpBRJNoFNFuHQtiFyR;

	public int UserId
	{
		get
		{
			return BVryKdnfZxNpBRJNoFNFuHQtiFyR.UserId;
		}
		set
		{
			BVryKdnfZxNpBRJNoFNFuHQtiFyR.UserId = value;
		}
	}

	public string UserName
	{
		get
		{
			return BVryKdnfZxNpBRJNoFNFuHQtiFyR.UserName;
		}
		set
		{
			BVryKdnfZxNpBRJNoFNFuHQtiFyR.UserName = value;
		}
	}

	private TarEntry()
	{
		BVryKdnfZxNpBRJNoFNFuHQtiFyR = new TarHeader();
	}

	public TarEntry(byte[] headerBuffer)
	{
		BVryKdnfZxNpBRJNoFNFuHQtiFyR = new TarHeader();
		BVryKdnfZxNpBRJNoFNFuHQtiFyR.ParseBuffer(headerBuffer);
	}

	public TarEntry(TarHeader header)
	{
		if (header == null)
		{
			throw new ArgumentNullException("header");
		}
		BVryKdnfZxNpBRJNoFNFuHQtiFyR = (TarHeader)header.Clone();
	}

	public static void AdjustEntryName(byte[] buffer, string newName)
	{
		TarHeader.GetNameBytes(newName, buffer, 0, 100);
	}

	public object Clone()
	{
		return new TarEntry
		{
			oclgwzdRyjHpRrMLPgEZGyhdLbBJB = oclgwzdRyjHpRrMLPgEZGyhdLbBJB,
			BVryKdnfZxNpBRJNoFNFuHQtiFyR = (TarHeader)BVryKdnfZxNpBRJNoFNFuHQtiFyR.Clone(),
			Name = Name
		};
	}

	public static TarEntry CreateEntryFromFile(string fileName)
	{
		TarEntry tarEntry = new TarEntry();
		tarEntry.GetFileTarHeader(tarEntry.BVryKdnfZxNpBRJNoFNFuHQtiFyR, fileName);
		return tarEntry;
	}

	public static TarEntry CreateTarEntry(string name)
	{
		TarEntry tarEntry = new TarEntry();
		NameTarHeader(tarEntry.BVryKdnfZxNpBRJNoFNFuHQtiFyR, name);
		return tarEntry;
	}

	public override bool Equals(object object_0)
	{
		return object_0 is TarEntry tarEntry && Name.Equals(tarEntry.Name);
	}

	public TarEntry[] GetDirectoryEntries()
	{
		if (oclgwzdRyjHpRrMLPgEZGyhdLbBJB == null || !Directory.Exists(oclgwzdRyjHpRrMLPgEZGyhdLbBJB))
		{
			return new TarEntry[0];
		}
		string[] fileSystemEntries = Directory.GetFileSystemEntries(oclgwzdRyjHpRrMLPgEZGyhdLbBJB);
		TarEntry[] array = new TarEntry[fileSystemEntries.Length];
		for (int i = 0; i < fileSystemEntries.Length; i++)
		{
			array[i] = CreateEntryFromFile(fileSystemEntries[i]);
		}
		return array;
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
		oclgwzdRyjHpRrMLPgEZGyhdLbBJB = file;
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
		if (!Directory.Exists(file))
		{
			header.Mode = 33216;
			header.TypeFlag = 48;
			header.Size = new FileInfo(file.Replace('/', Path.DirectorySeparatorChar)).Length;
		}
		else
		{
			header.Mode = 1003;
			header.TypeFlag = 53;
			if (header.Name.Length == 0 || header.Name[header.Name.Length - 1] != '/')
			{
				header.Name += "/";
			}
			header.Size = 0L;
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
		BVryKdnfZxNpBRJNoFNFuHQtiFyR.WriteHeader(outBuffer);
	}
}
