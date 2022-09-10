using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class SafeCryptoKey : IDisposable
{
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	private struct BlobHeader
	{
		private const int PLAINTEXTKEYBLOB = 8;

		private const int CUR_BLOB_VERSION = 2;

		private const int CALG_AES = 26128;

		[FieldOffset(0)]
		public byte bType;

		[FieldOffset(1)]
		public byte bVersion;

		[FieldOffset(2)]
		public ushort reserved;

		[FieldOffset(4)]
		public uint aiKeyAlg;

		[FieldOffset(8)]
		public uint keyLength;

		public BlobHeader(int keySize)
		{
			bType = 8;
			bVersion = 2;
			reserved = 0;
			aiKeyAlg = 26128u;
			keyLength = (uint)keySize;
		}
	}

	private SafeCryptoKeyHandle m_handle;

	public SafeCryptoKeyHandle Handle => m_handle;

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool CryptSetKeyParam([In] SafeCryptoKeyHandle hKey, [In] uint dwParam, [In] IntPtr data, [In] uint flags);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool CryptImportKey([In] SafeRsaProviderHandle hProv, [In] IntPtr pbKeyData, [In] uint dwDataLen, [In] IntPtr hPubKey, [In] uint dwFlags, out SafeCryptoKeyHandle hKey);

	public unsafe SafeCryptoKey(SafeRsaProviderHandle provider, byte[] encryptedKey, byte[] iv)
	{
		BlobHeader blobHeader = new BlobHeader(encryptedKey.Length);
		int num = sizeof(BlobHeader) + encryptedKey.Length;
		byte* ptr = stackalloc byte[num];
		byte* ptr2 = (byte*)(&blobHeader);
		for (int i = 0; i < 12; i++)
		{
			ptr[i] = ptr2[i];
		}
		try
		{
			ProtectedMemory.Unprotect(encryptedKey, (MemoryProtectionScope)0);
			for (int j = 0; j < encryptedKey.Length; j++)
			{
				ptr[12 + j] = encryptedKey[j];
			}
		}
		finally
		{
			ProtectedMemory.Protect(encryptedKey, (MemoryProtectionScope)0);
		}
		if (!CryptImportKey(provider, (IntPtr)ptr, (uint)num, IntPtr.Zero, 0u, out m_handle))
		{
			Exception ex = new Win32Exception(Marshal.GetLastWin32Error());
			InfoCardTrace.CloseInvalidOutSafeHandle((SafeHandle)m_handle);
			InfoCardTrace.TraceAndLogException(ex);
			throw InfoCardTrace.ThrowHelperError(ex);
		}
		fixed (byte* ptr3 = &iv[0])
		{
			if (!CryptSetKeyParam(m_handle, 1u, (IntPtr)ptr3, 0u))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				Exception ex2 = new Win32Exception(lastWin32Error);
				m_handle.Dispose();
				throw InfoCardTrace.ThrowHelperError(ex2);
			}
		}
	}

	void IDisposable.Dispose()
	{
		m_handle.Dispose();
	}
}
