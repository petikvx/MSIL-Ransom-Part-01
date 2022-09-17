using System;
using System.IO;
using System.Runtime.CompilerServices;

public class GClass6
{
	private int int_0;

	private readonly object object_0 = new object();

	private const int int_1 = 65535;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	public string Path
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		private set
		{
			string_0 = value;
		}
	}

	public string LastError
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		private set
		{
			string_1 = value;
		}
	}

	public int MaxBlocks
	{
		get
		{
			if (int_0 <= 0 && int_0 != -1)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(Path);
					if (!fileInfo.Exists)
					{
						throw new FileNotFoundException();
					}
					int_0 = (int)Math.Ceiling((double)fileInfo.Length / 65535.0);
				}
				catch (UnauthorizedAccessException)
				{
					int_0 = -1;
					LastError = "Access denied";
				}
				catch (IOException ex2)
				{
					int_0 = -1;
					if (ex2 is FileNotFoundException)
					{
						LastError = "File not found";
					}
					if (ex2 is PathTooLongException)
					{
						LastError = "Path is too long";
					}
				}
				return int_0;
			}
			return int_0;
		}
	}

	public GClass6(string path)
	{
		Path = path;
	}

	private int method_0(long length)
	{
		if (length >= 65535L)
		{
			return 65535;
		}
		return (int)length;
	}

	public bool method_1(int blockNumber, out byte[] readBytes)
	{
		try
		{
			if (blockNumber > MaxBlocks)
			{
				throw new ArgumentOutOfRangeException();
			}
			lock (object_0)
			{
				using FileStream fileStream = File.OpenRead(Path);
				if (blockNumber == 0)
				{
					fileStream.Seek(0L, SeekOrigin.Begin);
					long num = fileStream.Length - fileStream.Position;
					if (num < 0L)
					{
						throw new IOException("negative length");
					}
					readBytes = new byte[method_0(num)];
					fileStream.Read(readBytes, 0, readBytes.Length);
				}
				else
				{
					fileStream.Seek(blockNumber * 65535, SeekOrigin.Begin);
					long num2 = fileStream.Length - fileStream.Position;
					if (num2 < 0L)
					{
						throw new IOException("negative length");
					}
					readBytes = new byte[method_0(num2)];
					fileStream.Read(readBytes, 0, readBytes.Length);
				}
			}
			return true;
		}
		catch (ArgumentOutOfRangeException)
		{
			readBytes = new byte[0];
			LastError = "BlockNumber bigger than MaxBlocks";
		}
		catch (UnauthorizedAccessException)
		{
			readBytes = new byte[0];
			LastError = "Access denied";
		}
		catch (IOException ex3)
		{
			readBytes = new byte[0];
			if (ex3 is FileNotFoundException)
			{
				LastError = "File not found";
			}
			else if (ex3 is DirectoryNotFoundException)
			{
				LastError = "Directory not found";
			}
			else if (ex3 is PathTooLongException)
			{
				LastError = "Path is too long";
			}
			else
			{
				LastError = "Unable to read from File Stream";
			}
		}
		return false;
	}

	public bool method_2(byte[] block, int blockNumber)
	{
		try
		{
			if (!File.Exists(Path) && blockNumber > 0)
			{
				throw new FileNotFoundException();
			}
			lock (object_0)
			{
				if (blockNumber == 0)
				{
					using (FileStream fileStream = File.Open(Path, FileMode.Create, FileAccess.Write))
					{
						fileStream.Seek(0L, SeekOrigin.Begin);
						fileStream.Write(block, 0, block.Length);
					}
					return true;
				}
				using FileStream fileStream2 = File.Open(Path, FileMode.Append, FileAccess.Write);
				fileStream2.Seek(blockNumber * 65535, SeekOrigin.Begin);
				fileStream2.Write(block, 0, block.Length);
			}
			return true;
		}
		catch (UnauthorizedAccessException)
		{
			LastError = "Access denied";
		}
		catch (IOException ex2)
		{
			if (ex2 is FileNotFoundException)
			{
				LastError = "File not found";
			}
			else if (ex2 is DirectoryNotFoundException)
			{
				LastError = "Directory not found";
			}
			else if (ex2 is PathTooLongException)
			{
				LastError = "Path is too long";
			}
			else
			{
				LastError = "Unable to write to File Stream";
			}
		}
		return false;
	}
}
