using System;
using System.Security.Cryptography;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal static class HashUtility
{
	public const string HashAlgorithmName = "SHA256";

	private static object s_lock = new object();

	private static SHA256Managed s_hasher = new SHA256Managed();

	public static int HashBitLength => s_hasher.HashSize;

	public static int HashBufferLength => HashBitLength / 8;

	public static void SetHashValue(byte[] data, int dataIndex, byte[] dataToHash)
	{
		if (dataToHash == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("dataToHash");
		}
		SetHashValue(data, dataIndex, dataToHash, 0, dataToHash.Length);
	}

	public static void SetHashValue(byte[] data, int dataIndex, byte[] dataToHash, int dataToHashIndex, int dataToHashSize)
	{
		if (data == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("data");
		}
		if (dataIndex >= 0 && dataIndex < data.Length)
		{
			if (dataToHash == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("dataToHash");
			}
			if (dataToHashIndex >= 0 && dataToHashIndex <= dataToHash.Length)
			{
				if (dataToHashSize >= 0 && dataToHashSize <= dataToHash.Length - dataToHashIndex)
				{
					byte[] array = null;
					lock (s_lock)
					{
						array = s_hasher.ComputeHash(dataToHash, dataToHashIndex, dataToHashSize);
					}
					Array.Copy(array, 0, data, dataIndex, array.Length);
					Array.Clear(array, 0, array.Length);
					return;
				}
				throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("dataToHashIndex", dataToHashIndex, SR.GetString("StoreHashUtilityDataToHashOutOfRange")));
			}
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("dataToHashIndex", dataToHashIndex, SR.GetString("StoreHashUtilityDataToHashOutOfRange")));
		}
		throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("dataIndex", dataIndex, SR.GetString("StoreHashUtilityDataOutOfRange")));
	}
}
