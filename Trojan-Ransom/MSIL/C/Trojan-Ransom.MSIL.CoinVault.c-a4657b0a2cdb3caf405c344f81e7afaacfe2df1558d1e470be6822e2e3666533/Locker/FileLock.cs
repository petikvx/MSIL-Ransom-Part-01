using System.IO;

namespace Locker;

internal class FileLock
{
	private string path = string.Empty;

	private string filename = string.Empty;

	public string originalFileFullPath
	{
		get
		{
			return Path.Combine(path, filename);
		}
		set
		{
			path = Path.GetDirectoryName(value);
			filename = Path.GetFileName(value);
		}
	}

	public string cryptedFileFullPath
	{
		get
		{
			return Path.Combine(path, filename + "._clf");
		}
		set
		{
			path = Path.GetDirectoryName(value);
			filename = Path.GetFileName(value.Replace("._clf", ""));
		}
	}

	public static bool operator ==(FileLock fileA, FileLock fileB)
	{
		if (object.ReferenceEquals(fileA, fileB))
		{
			return true;
		}
		if ((object)fileA != null && (object)fileB != null)
		{
			return fileA.originalFileFullPath == fileB.originalFileFullPath;
		}
		return false;
	}

	public static bool operator !=(FileLock fileA, FileLock fileB)
	{
		if (object.ReferenceEquals(fileA, fileB))
		{
			return false;
		}
		if ((object)fileA != null && (object)fileB != null)
		{
			return fileA.originalFileFullPath != fileB.originalFileFullPath;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (!(obj is FileLock fileLock))
		{
			return false;
		}
		return originalFileFullPath == fileLock.originalFileFullPath;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}
}
