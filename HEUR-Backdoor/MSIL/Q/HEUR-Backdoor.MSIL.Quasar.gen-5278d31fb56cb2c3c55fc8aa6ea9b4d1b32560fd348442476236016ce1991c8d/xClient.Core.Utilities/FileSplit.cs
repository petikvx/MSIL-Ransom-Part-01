using System;
using System.IO;

namespace xClient.Core.Utilities;

public class FileSplit
{
	private int _maxBlocks;

	private readonly object _fileStreamLock = new object();

	private const int MAX_BLOCK_SIZE = 65535;

	public string Path { get; private set; }

	public string LastError { get; private set; }

	public int MaxBlocks
	{
		get
		{
			if (_maxBlocks > 0 || _maxBlocks == -1)
			{
				return _maxBlocks;
			}
			try
			{
				FileInfo fileInfo = new FileInfo(Path);
				if (!fileInfo.Exists)
				{
					throw new FileNotFoundException();
				}
				_maxBlocks = (int)Math.Ceiling((double)fileInfo.Length / 65535.0);
			}
			catch (UnauthorizedAccessException)
			{
				_maxBlocks = -1;
				LastError = "Access denied";
			}
			catch (IOException ex2)
			{
				_maxBlocks = -1;
				if (ex2 is FileNotFoundException)
				{
					LastError = "File not found";
				}
				if (ex2 is PathTooLongException)
				{
					LastError = "Path is too long";
				}
			}
			return _maxBlocks;
		}
	}

	public FileSplit(string path)
	{
		Path = path;
	}

	private int GetSize(long length)
	{
		if (length >= 65535)
		{
			return 65535;
		}
		return (int)length;
	}

	public bool ReadBlock(int blockNumber, out byte[] readBytes)
	{
		try
		{
			if (blockNumber > MaxBlocks)
			{
				throw new ArgumentOutOfRangeException();
			}
			lock (_fileStreamLock)
			{
				using FileStream fileStream = File.OpenRead(Path);
				if (blockNumber == 0)
				{
					fileStream.Seek(0L, SeekOrigin.Begin);
					long num = fileStream.Length - fileStream.Position;
					if (num < 0)
					{
						throw new IOException("negative length");
					}
					readBytes = new byte[GetSize(num)];
					fileStream.Read(readBytes, 0, readBytes.Length);
				}
				else
				{
					fileStream.Seek(blockNumber * 65535, SeekOrigin.Begin);
					long num2 = fileStream.Length - fileStream.Position;
					if (num2 < 0)
					{
						throw new IOException("negative length");
					}
					readBytes = new byte[GetSize(num2)];
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

	public bool AppendBlock(byte[] block, int blockNumber)
	{
		try
		{
			if (!File.Exists(Path) && blockNumber > 0)
			{
				throw new FileNotFoundException();
			}
			lock (_fileStreamLock)
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
