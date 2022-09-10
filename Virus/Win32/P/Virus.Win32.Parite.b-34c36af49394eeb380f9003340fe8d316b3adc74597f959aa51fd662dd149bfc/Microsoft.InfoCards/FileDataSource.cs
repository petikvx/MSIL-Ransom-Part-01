using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Threading;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class FileDataSource : DataSource
{
	public const int ENCRYPTIONKEYBUFFERSIZE = 32;

	public const int ENCRYPTIONKEYBITLENGTH = 256;

	public const int ENCRYPTIONBLOCKBUFFERSIZE = 16;

	public const int ENCRYPTIONBLOCKBITLENGTH = 128;

	public const int ENCRYPTIONITERATIONS = 1000;

	public const int INITIALINDEXITEMCOUNT = 20;

	public const int INITIALINDEXAREASIZE = 80;

	public const int INITIALBLOBAREASIZE = 2048;

	public const int FILEVERSION = 11;

	public const int FILEVERSIONV2 = 12;

	private static readonly SecurityIdentifier AdministratorSid = new SecurityIdentifier(WellKnownSidType.BuiltinAdministratorsSid, null);

	private int m_variableSignatureLength = 64;

	private FileInfo m_fileInfo;

	private FileStream m_file;

	private FileInfo m_shadowInfo;

	private FileStream m_shadow;

	private byte[] m_header;

	private IndexedDataBuffer m_data;

	private SecondaryIndexList m_indexes;

	private ReaderWriterLock m_lock;

	private SymmetricAlgorithm m_encAlg;

	private byte[] m_key;

	private bool m_keyProtected;

	private WindowsIdentity m_identity;

	private bool m_currentTransactionDirty;

	private SafeRsaProviderHandle m_provider;

	private byte[] m_encryptedKey;

	public IndexedDataBuffer Buffer
	{
		get
		{
			ThrowIfDisposed();
			ThrowIfNotLoaded();
			return m_data;
		}
	}

	public byte[] Header
	{
		get
		{
			ThrowIfDisposed();
			ThrowIfNotLoaded();
			return m_header;
		}
	}

	public SecondaryIndexList Indexes
	{
		get
		{
			ThrowIfDisposed();
			ThrowIfNotLoaded();
			return m_indexes;
		}
	}

	protected WindowsIdentity Identity => m_identity;

	protected FileDataSource()
		: base(null, null)
	{
	}

	public FileDataSource(WindowsIdentity identity, string fileName)
		: this(identity, fileName, Guid.NewGuid().ToString("P"), SecondaryIndexDefinition.MasterIndexes)
	{
	}

	public FileDataSource(WindowsIdentity identity, string fileName, string instanceId, SecondaryIndexDefinition[] indexDefinitions)
		: base(instanceId, fileName)
	{
		m_identity = identity;
		m_currentTransactionDirty = false;
		m_fileInfo = new FileInfo(fileName);
		m_shadowInfo = new FileInfo(m_fileInfo.FullName + ".shadow");
		m_lock = new ReaderWriterLock();
		m_indexes = new SecondaryIndexList(indexDefinitions);
		m_encAlg = CreateEncryptionAlg();
		SetupProvider();
	}

	protected internal override void OnClear()
	{
		using (new SystemIdentity(throwIfAlreadySystem: true))
		{
			ResilientDelete(m_fileInfo);
			ResilientDelete(m_shadowInfo);
		}
	}

	protected internal override void OnLoad()
	{
		ThrowIfDisposed();
		try
		{
			CreateDirAndFiles();
			if (m_shadow.Length > 0L)
			{
				if (m_file.Length > 0L)
				{
					m_shadow.SetLength(0L);
					LoadFrom(m_file);
				}
				else
				{
					LoadFrom(m_shadow);
					FlushToShadow();
					SwapFileWithShadow();
				}
			}
			else if (m_file.Length > 0L)
			{
				LoadFrom(m_file);
			}
			else
			{
				CreateEmptyStore();
				FlushToShadow();
				SwapFileWithShadow();
			}
			m_file.Seek(0L, SeekOrigin.Begin);
		}
		catch
		{
			CloseFiles();
			throw;
		}
	}

	private void CloseFiles()
	{
		using (new SystemIdentity(throwIfAlreadySystem: false))
		{
			if (m_file != null)
			{
				m_file.Close();
				m_file = null;
			}
			if (m_shadow != null)
			{
				m_shadow.Close();
				m_shadow = null;
			}
		}
	}

	protected void CreateDirAndFiles()
	{
		CheckReparsePoints();
		if (NativeMcppMethods.PathSupportsPersistedSecurity(m_fileInfo.Directory!.FullName))
		{
			ValidateDirectoryAccess();
		}
		using (new SystemIdentity(throwIfAlreadySystem: true))
		{
			try
			{
				if (!m_fileInfo.Directory!.Exists)
				{
					try
					{
						if (NativeMcppMethods.PathSupportsPersistedSecurity(m_fileInfo.Directory!.FullName))
						{
							m_fileInfo.Directory!.Create(CreateSecurityDescriptor<DirectorySecurity>());
						}
						else
						{
							m_fileInfo.Directory!.Create();
						}
						m_fileInfo.Directory!.Attributes |= FileAttributes.Hidden | FileAttributes.NotContentIndexed;
					}
					catch (UnauthorizedAccessException ex)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)(object)new DataAccessException(ex.Message));
					}
				}
				else if (NativeMcppMethods.PathSupportsPersistedSecurity(m_fileInfo.Directory!.FullName) && LogIfAclsTampered(m_fileInfo.Directory))
				{
					m_fileInfo.Directory!.SetAccessControl(CreateSecurityDescriptor<DirectorySecurity>());
				}
				InfoCardTrace.Assert(m_shadowInfo.Directory!.Exists, "m_shadowInfo directory should be same as main directory", new object[0]);
				OpenOrCreateHelper(m_fileInfo, out m_file);
				OpenOrCreateHelper(m_shadowInfo, out m_shadow);
			}
			catch (IOException ex2)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new DataAccessException(ex2.Message));
			}
		}
	}

	private void CheckReparsePoints()
	{
		using (new SystemIdentity(throwIfAlreadySystem: true))
		{
			DirectoryInfo directoryInfo = m_fileInfo.Directory;
			while (true)
			{
				if (directoryInfo != null)
				{
					if (!directoryInfo.Exists || (directoryInfo.Attributes & FileAttributes.ReparsePoint) == 0)
					{
						directoryInfo = directoryInfo.Parent;
						continue;
					}
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new DataAccessException(SR.GetString("StoreNoReparsePointAllowed")));
				}
				if (Directory.Exists(m_fileInfo.FullName) && (m_fileInfo.Attributes & FileAttributes.ReparsePoint) != 0)
				{
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new DataAccessException(SR.GetString("StoreNoReparsePointAllowed")));
				}
				break;
			}
		}
	}

	private void ValidateDirectoryAccess()
	{
		InfoCardTrace.Assert(!WindowsIdentity.GetCurrent().IsSystem, "Should not be running as system", new object[0]);
		IdentityReference identityReference = WindowsIdentity.GetCurrent().User!.Translate(typeof(NTAccount));
		bool flag = false;
		DirectoryInfo parent = m_fileInfo.Directory!.Parent;
		if (parent.Exists)
		{
			AuthorizationRuleCollection accessRules = parent.GetAccessControl().GetAccessRules(includeExplicit: true, includeInherited: true, typeof(NTAccount));
			foreach (FileSystemAccessRule item in accessRules)
			{
				if (item.IdentityReference == identityReference && item.FileSystemRights == FileSystemRights.FullControl && item.AccessControlType == AccessControlType.Allow)
				{
					flag = true;
					break;
				}
			}
		}
		if (!flag)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new DataAccessException(SR.GetString("StoreInvalidDataFilePath")));
		}
	}

	private void OpenOrCreateHelper(FileInfo theFile, out FileStream fileStream)
	{
		InfoCardTrace.Assert(WindowsIdentity.GetCurrent().IsSystem, "Should be running as system", new object[0]);
		if (!File.Exists(theFile.FullName))
		{
			fileStream = ResilientOpen(theFile, FileMode.CreateNew, FileAccess.ReadWrite);
			theFile.Attributes |= FileAttributes.Hidden | FileAttributes.NotContentIndexed;
			theFile.SetAccessControl(CreateSecurityDescriptor<FileSecurity>());
			return;
		}
		if (NativeMcppMethods.PathSupportsPersistedSecurity(m_fileInfo.Directory!.FullName) && LogIfAclsTampered(theFile))
		{
			theFile.SetAccessControl(CreateSecurityDescriptor<FileSecurity>());
			theFile.Attributes |= FileAttributes.Hidden | FileAttributes.NotContentIndexed;
		}
		fileStream = ResilientOpen(theFile, FileMode.Open, FileAccess.ReadWrite);
	}

	protected virtual void OnSwapFileWithShadow()
	{
		using (new SystemIdentity(throwIfAlreadySystem: true))
		{
			string fullName = m_fileInfo.FullName;
			ResilientDelete(m_fileInfo);
			ResilientMove(m_shadowInfo, m_fileInfo);
			m_fileInfo = new FileInfo(fullName);
			m_shadowInfo = new FileInfo(fullName + ".shadow");
		}
	}

	protected internal override void OnClose()
	{
		ThrowIfDisposed();
		if (m_data != null)
		{
			m_data.Close();
			m_data = null;
		}
		m_indexes.Close();
		CloseFiles();
		m_provider.Dispose();
	}

	protected internal override DataRow ReadRow(int localId, QueryDetails details)
	{
		DataRow dataRow = null;
		if (QueryDetails.Header == (details & QueryDetails.Header))
		{
			dataRow = m_data.CreateDataRow(localId);
			if (QueryDetails.DataBlob == (details & QueryDetails.DataBlob))
			{
				byte[] iv = AllocateIvBuffer();
				m_data.CopyIVFromObject(localId, iv, 0);
				using Stream stream = m_data.GetStreamForObjectData(localId);
				using MemoryStream memoryStream = new MemoryStream((int)stream.Length);
				DecryptData(iv, stream, memoryStream);
				dataRow.SetDataField(memoryStream.ToArray());
				byte[] buffer = memoryStream.GetBuffer();
				Array.Clear(buffer, 0, buffer.Length);
			}
			if (QueryDetails.IndexData == (details & QueryDetails.IndexData))
			{
				m_indexes.PopulateRowIndexBuffer(dataRow);
			}
		}
		return dataRow;
	}

	protected internal override bool SingleMatch(QueryParameter match, LocalIdCollection localIds)
	{
		ThrowIfDisposed();
		ThrowIfNotLoaded();
		if (localIds == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("localIds");
		}
		if (match == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("match");
		}
		if (string.IsNullOrEmpty(match.IndexName))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentException(SR.GetString("StoreDataSourceInvalidIndexName", new object[1] { match.IndexName }), "match"));
		}
		bool flag = false;
		try
		{
			try
			{
			}
			finally
			{
				m_lock.AcquireReaderLock(0);
				flag = true;
			}
			return m_indexes.Match(match, localIds);
		}
		finally
		{
			if (flag)
			{
				m_lock.ReleaseReaderLock();
			}
		}
	}

	protected internal override void OnBeginTransaction()
	{
		InfoCardTrace.Assert(!m_currentTransactionDirty, "m_currentTransactionDirty should have been set to false before beginning a transaction", new object[0]);
		base.OnBeginTransaction();
	}

	protected internal override void OnRollbackTransaction()
	{
		try
		{
			base.OnRollbackTransaction();
			LoadFrom(m_file);
		}
		finally
		{
			m_currentTransactionDirty = false;
		}
	}

	protected internal override void OnCommitTransaction()
	{
		try
		{
			base.OnCommitTransaction();
			if (m_currentTransactionDirty)
			{
				FlushToShadow();
				SwapFileWithShadow();
			}
		}
		finally
		{
			m_currentTransactionDirty = false;
		}
	}

	protected internal override void WriteRow(DataRow row)
	{
		ThrowIfDisposed();
		ThrowIfNotLoaded();
		ThrowIfWriteLockNotHeld();
		if (row == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("row");
		}
		bool flag = false;
		try
		{
			try
			{
			}
			finally
			{
				m_lock.AcquireWriterLock(0);
				flag = true;
			}
			using MemoryStream memoryStream = new MemoryStream();
			m_encAlg.GenerateIV();
			byte[] iV = m_encAlg.IV;
			byte[] dataField = row.GetDataField();
			using MemoryStream input = new MemoryStream(dataField);
			EncryptData(iV, input, memoryStream);
			int localId = m_data.WriteObject(row.LocalId, iV, memoryStream.ToArray(), row.ObjectType, row.LastChange, row.GlobalId);
			m_indexes.SetValuesForId(localId, row.IndexBuffer, remove: true);
			row.SourceId = base.SourceId;
			row.InstanceId = base.InstanceId;
			row.LocalId = localId;
		}
		finally
		{
			if (flag)
			{
				m_lock.ReleaseWriterLock();
			}
		}
		m_currentTransactionDirty = true;
	}

	protected internal override void RemoveObject(int id)
	{
		if ((uint)id > (uint)(m_data.Index.Length / 4 - 1))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("id", id, SR.GetString("StoreDataSourceIdOutOfRange")));
		}
		bool flag = false;
		try
		{
			try
			{
			}
			finally
			{
				m_lock.AcquireWriterLock(0);
				flag = true;
			}
			m_data.RemoveObject(id);
			m_indexes.RemoveAllValuesForId(id);
		}
		finally
		{
			if (flag)
			{
				m_lock.ReleaseWriterLock();
			}
		}
		m_currentTransactionDirty = true;
	}

	private void ProtectKey()
	{
		if (m_keyProtected)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreKeyAlreadyProtected")));
		}
		ProtectedMemory.Protect(m_key, (MemoryProtectionScope)0);
		m_keyProtected = true;
	}

	private void UnprotectKey()
	{
		if (!m_keyProtected)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreKeyNotAlreadyProtected")));
		}
		ProtectedMemory.Unprotect(m_key, (MemoryProtectionScope)0);
		m_keyProtected = false;
	}

	private unsafe void DecryptData(byte[] iv, Stream input, Stream output)
	{
		Exception ex = null;
		InfoCardTrace.Assert(input is MemoryStream, "Invalid stream type", new object[0]);
		if (iv != null && iv.Length != 0)
		{
			if (input == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("input");
			}
			if (output == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("output");
			}
			using SafeCryptoKey safeCryptoKey = new SafeCryptoKey(m_provider, m_key, iv);
			byte[] array = new byte[input.Length];
			input.Seek(0L, SeekOrigin.Begin);
			input.Read(array, 0, (int)input.Length);
			uint length = (uint)array.Length;
			try
			{
				fixed (byte* ptr = &array[0])
				{
					if (!NativeMethods.CryptDecrypt(safeCryptoKey.Handle, IntPtr.Zero, 1u, 0u, (IntPtr)ptr, ref length))
					{
						ex = new Win32Exception(Marshal.GetLastWin32Error());
						Array.Clear(array, 0, array.Length);
						InfoCardTrace.TraceAndLogException(ex);
						throw InfoCardTrace.ThrowHelperError(ex);
					}
				}
			}
			finally
			{
			}
			output.Write(array, 0, (int)length);
			return;
		}
		throw InfoCardTrace.ThrowHelperArgumentNull("iv");
	}

	private unsafe void EncryptData(byte[] iv, Stream input, Stream output)
	{
		Exception ex = null;
		if (iv != null && iv.Length != 0)
		{
			if (input == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("input");
			}
			if (output == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("output");
			}
			using SafeCryptoKey safeCryptoKey = new SafeCryptoKey(m_provider, m_key, iv);
			byte[] array = new byte[input.Length + m_key.Length];
			input.Seek(0L, SeekOrigin.Begin);
			input.Read(array, 0, (int)input.Length);
			uint length = (uint)input.Length;
			try
			{
				fixed (byte* ptr = &array[0])
				{
					if (!NativeMethods.CryptEncrypt(safeCryptoKey.Handle, IntPtr.Zero, 1u, 0u, (IntPtr)ptr, ref length, (uint)array.Length))
					{
						ex = new Win32Exception(Marshal.GetLastWin32Error());
						InfoCardTrace.TraceAndLogException(ex);
						throw InfoCardTrace.ThrowHelperError(ex);
					}
				}
			}
			finally
			{
			}
			output.Write(array, 0, (int)length);
			return;
		}
		throw InfoCardTrace.ThrowHelperArgumentNull("iv");
	}

	private unsafe void CreateEmptyStore()
	{
		byte[] masterIndex = new byte[80];
		byte[] buffer = new byte[2048];
		m_data = new IndexedDataBuffer(masterIndex, buffer, 0, this);
		m_encAlg.GenerateKey();
		m_key = new byte[m_encAlg.Key.Length];
		Array.Copy(m_encAlg.Key, 0, m_key, 0, m_encAlg.Key.Length);
		m_encAlg.GenerateKey();
		m_keyProtected = false;
		ProtectKey();
		m_header = new byte[GetTotalHeaderSize()];
		fixed (byte* ptr = &m_header[GetOffsetToEncryptedFileHeader()])
		{
			EncryptedFileStoreHeader* ptr2 = (EncryptedFileStoreHeader*)ptr;
			ptr2->Version = 12u;
		}
		EncryptAndSaveDPAPIKeyToHeader();
	}

	private void FlushToShadow()
	{
		FlushToStream(m_shadow);
	}

	private unsafe int GetTotalHeaderSize()
	{
		return sizeof(EncryptedFileStoreHeader) + GetTotalSignatureSize();
	}

	private int GetOffsetToEncryptedFileHeader()
	{
		return m_variableSignatureLength + 4;
	}

	private int GetTotalSignatureSize()
	{
		return GetOffsetToEncryptedFileHeader();
	}

	private long GetRequiredFileSize()
	{
		long num = Convert.ToInt64(GetTotalHeaderSize());
		num += Convert.ToInt64(m_encryptedKey.Length);
		num += Convert.ToInt64(m_data.DataLength);
		num += Convert.ToInt64(m_data.Index.Length + 4);
		foreach (string key in m_indexes.InnerIndexes.Keys)
		{
			byte[] buffer = ((SecondaryIndex)m_indexes.InnerIndexes[key]).GetBuffer();
			num += Convert.ToInt64(8 + buffer.Length);
		}
		return num + num / 20L;
	}

	private unsafe void FlushToStream(Stream stream)
	{
		if (stream == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("stream");
		}
		stream.SetLength(GetRequiredFileSize());
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		byte[] array = null;
		BinaryWriter binaryWriter = new BinaryWriter(stream);
		long num4 = 0L;
		m_encAlg.GenerateIV();
		array = m_encAlg.IV;
		num = m_data.DataLength;
		stream.Seek(GetTotalHeaderSize(), SeekOrigin.Begin);
		binaryWriter.Write(m_encryptedKey);
		binaryWriter.Write(array);
		num4 = stream.Position;
		using (BinaryWriter binaryWriter2 = new BinaryWriter(new MemoryStream()))
		{
			binaryWriter2.Write(m_data.Index.Length / 4);
			binaryWriter2.Write(m_data.Index);
			binaryWriter2.Write(m_indexes.Count);
			foreach (string key in m_indexes.InnerIndexes.Keys)
			{
				SecondaryIndex secondaryIndex = (SecondaryIndex)m_indexes.InnerIndexes[key];
				int lastIndex = secondaryIndex.LastIndex;
				binaryWriter2.Write(lastIndex);
				int initialSize = SecondaryIndexDefinition.GetByName(key).InitialSize;
				if (lastIndex + 1 < initialSize)
				{
					binaryWriter2.Write(initialSize);
					InfoCardTrace.Assert(initialSize * sizeof(SecondaryIndexItem) <= secondaryIndex.GetBuffer().Length, "Buffer length is at least min capacity", new object[0]);
					binaryWriter2.Write(secondaryIndex.GetBuffer(), 0, initialSize * sizeof(SecondaryIndexItem));
				}
				else
				{
					binaryWriter2.Write(lastIndex + 1);
					binaryWriter2.Write(secondaryIndex.GetBuffer(), 0, (lastIndex + 1) * sizeof(SecondaryIndexItem));
				}
			}
			binaryWriter2.Flush();
			binaryWriter2.Seek(0, SeekOrigin.Begin);
			EncryptData(array, binaryWriter2.BaseStream, binaryWriter.BaseStream);
		}
		num3 = Convert.ToInt32(stream.Position - num4);
		num2 = num3 + m_data.DataLength + GetTotalHeaderSize() + array.Length + m_encryptedKey.Length;
		binaryWriter.Write(m_data.Data, 0, m_data.DataLength);
		stream.Seek(0L, SeekOrigin.Begin);
		binaryWriter.Flush();
		fixed (byte* ptr = &m_header[GetOffsetToEncryptedFileHeader()])
		{
			EncryptedFileStoreHeader* ptr2 = (EncryptedFileStoreHeader*)ptr;
			ptr2->DataSize = num;
			ptr2->Version = 12u;
			ptr2->Size = num2;
			ptr2->IndexSize = num3;
		}
		binaryWriter.Write(m_header);
		stream.SetLength(Convert.ToInt64(num2));
		binaryWriter.Flush();
		SignStream(stream);
	}

	private unsafe void SignStream(Stream input)
	{
		if (input == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("input");
		}
		long position = input.Position;
		m_encAlg.GenerateIV();
		byte[] iV = m_encAlg.IV;
		byte[] array = SignDigest(iV, CreateStreamDigest(input));
		byte[] array2 = new byte[GetTotalSignatureSize()];
		fixed (byte* ptr = &array2[0])
		{
			SignatureHeader* ptr2 = (SignatureHeader*)ptr;
			ptr2->SignatureSize = m_variableSignatureLength;
		}
		Array.Copy(array, 0, array2, 4, array.Length);
		input.Seek(0L, SeekOrigin.Begin);
		input.Write(array2, 0, array2.Length);
		InfoCardTrace.Assert(m_variableSignatureLength >= array.Length, "Generated signature should be less than signature length", new object[0]);
		input.Seek(position, SeekOrigin.Begin);
	}

	private byte[] CreateStreamDigest(Stream input)
	{
		input.Seek(GetOffsetToEncryptedFileHeader(), SeekOrigin.Begin);
		int num = Convert.ToInt32((input.Length / 4096L + 1L) * HashUtility.HashBufferLength);
		byte[] array = new byte[num];
		int num2 = 0;
		byte[] array2 = new byte[4096];
		int num3 = 0;
		do
		{
			num3 = input.Read(array2, 0, array2.Length);
			if (num3 > 0)
			{
				HashUtility.SetHashValue(array, num2, array2, 0, num3);
				num2 += HashUtility.HashBufferLength;
			}
		}
		while (num3 == array2.Length);
		return array;
	}

	private byte[] SignDigest(byte[] iv, byte[] digest)
	{
		byte[] array = new byte[m_variableSignatureLength];
		using MemoryStream input = new MemoryStream(digest);
		using MemoryStream memoryStream = new MemoryStream(digest.Length);
		EncryptData(iv, input, memoryStream);
		byte[] buffer = memoryStream.GetBuffer();
		int sourceIndex = Convert.ToInt32(memoryStream.Position - 1L) - iv.Length;
		Array.Copy(buffer, sourceIndex, array, 0, iv.Length);
		Array.Copy(iv, 0, array, iv.Length, iv.Length);
		return array;
	}

	private void ValidateSignature(Stream input)
	{
		if (input == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("input");
		}
		long position = input.Position;
		byte[] array = new byte[m_variableSignatureLength];
		byte[] array2 = AllocateIvBuffer();
		input.Seek(20L, SeekOrigin.Begin);
		input.Read(array2, 0, array2.Length);
		byte[] array3 = SignDigest(array2, CreateStreamDigest(input));
		input.Seek(4L, SeekOrigin.Begin);
		input.Read(array, 0, array.Length);
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != array3[i])
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new CorruptStoreException(SR.GetString("StoreSignatureNotValid")));
			}
		}
		input.Seek(position, SeekOrigin.Begin);
	}

	protected unsafe void LoadFrom(Stream stream)
	{
		if (stream == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("stream");
		}
		stream.Seek(0L, SeekOrigin.Begin);
		BinaryReader binaryReader = new InfoCardBinaryReader(stream);
		m_header = new byte[GetTotalHeaderSize()];
		binaryReader.Read(m_header, 0, m_header.Length);
		fixed (byte* ptr = &m_header[GetOffsetToEncryptedFileHeader()])
		{
			EncryptedFileStoreHeader* ptr2 = (EncryptedFileStoreHeader*)ptr;
			if (11 != ptr2->Version && 12 != ptr2->Version)
			{
				CorruptStoreException ex = new CorruptStoreException(SR.GetString("StoreVersionNotSupported", new object[1] { ptr2->Version }));
				InfoCardTrace.TraceAndLogException((Exception)ex);
				throw InfoCardTrace.ThrowHelperError((Exception)ex);
			}
			if (12 == ptr2->Version)
			{
				m_encryptedKey = new byte[ptr2->KeyBlockV2.KeyDataSize];
				binaryReader.Read(m_encryptedKey, 0, ptr2->KeyBlockV2.KeyDataSize);
			}
		}
		fixed (byte* ptr3 = &m_header[0])
		{
			SignatureHeader* ptr4 = (SignatureHeader*)ptr3;
			int signatureSize = ptr4->SignatureSize;
			if (m_variableSignatureLength != signatureSize)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new CorruptStoreException(SR.GetString("StoreSignatureNotValid")));
			}
		}
		ObtainDataKeyFromHeader();
		ValidateSignature(stream);
		fixed (byte* ptr5 = &m_header[GetOffsetToEncryptedFileHeader()])
		{
			EncryptedFileStoreHeader* ptr6 = (EncryptedFileStoreHeader*)ptr5;
			byte[] array = AllocateIvBuffer();
			byte[] masterIndex;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				binaryReader.Read(array, 0, array.Length);
				byte[] array2 = binaryReader.ReadBytes(ptr6->IndexSize);
				using (MemoryStream input = new MemoryStream(array2))
				{
					DecryptData(array, input, memoryStream);
					Array.Clear(array2, 0, array2.Length);
				}
				memoryStream.Seek(0L, SeekOrigin.Begin);
				BinaryReader binaryReader2 = new InfoCardBinaryReader(memoryStream);
				int num = binaryReader2.ReadInt32();
				InfoCardTrace.Assert(num > 0, "MasterIndexCount Invalid", new object[0]);
				masterIndex = binaryReader2.ReadBytes(num * 4);
				int num2 = binaryReader2.ReadInt32();
				InfoCardTrace.Assert((uint)num2 <= (uint)m_indexes.Count, "SecondaryIndexCount Invalid", new object[0]);
				foreach (string key in m_indexes.InnerIndexes.Keys)
				{
					int lastIndex = binaryReader2.ReadInt32();
					int num3 = binaryReader2.ReadInt32();
					int num4 = Utility.CalculateIncreaseByPercent(num3 * sizeof(SecondaryIndexItem), sizeof(SecondaryIndexItem), SecondaryIndexDefinition.GetByName(key).GrowthFactor);
					byte[] buffer = new byte[num4];
					binaryReader2.Read(buffer, 0, num3 * sizeof(SecondaryIndexItem));
					m_indexes.SetBuffer(key, buffer, lastIndex);
				}
			}
			int capacity = Utility.CalculateIncreaseByPercent(Convert.ToInt32(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position), 1, 5);
			using MemoryStream memoryStream2 = new MemoryStream(capacity);
			byte[] array3 = new byte[256];
			int num5 = 0;
			int num6 = 0;
			do
			{
				num5 = binaryReader.Read(array3, 0, array3.Length);
				memoryStream2.Write(array3, 0, num5);
				num6 += num5;
			}
			while (num5 == array3.Length);
			byte[] buffer2 = memoryStream2.GetBuffer();
			if (num6 == 0)
			{
				buffer2 = new byte[2048];
			}
			m_data = new IndexedDataBuffer(masterIndex, buffer2, ptr6->DataSize, this);
		}
	}

	protected virtual void SwapFileWithShadow()
	{
		CloseFiles();
		OnSwapFileWithShadow();
		try
		{
			CreateDirAndFiles();
		}
		catch
		{
			CloseFiles();
			throw;
		}
	}

	private unsafe void EncryptAndSaveDPAPIKeyToHeader()
	{
		DataBlob dataBlob = default(DataBlob);
		DataBlob dataBlob2 = default(DataBlob);
		byte[] array = new byte[32 + HashUtility.HashBufferLength];
		UnprotectKey();
		try
		{
			Array.Copy(m_key, 0, array, 0, 32);
			HashUtility.SetHashValue(array, 32, m_key, 0, 32);
			fixed (byte* value = &array[0])
			{
				DataBlob dataBlob3 = default(DataBlob);
				dataBlob3.pbData = new IntPtr(value);
				dataBlob3.cbData = array.Length;
				try
				{
					if (!NativeMethods.CryptProtectData(new IntPtr(&dataBlob3), null, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, 65, new IntPtr(&dataBlob)))
					{
						throw InfoCardTrace.ThrowHelperError((Exception)new Win32Exception(Marshal.GetLastWin32Error(), SR.GetString("StoreCryptProtectDataFailed")));
					}
					using (new SystemIdentity(throwIfAlreadySystem: true))
					{
						if (!NativeMethods.CryptProtectData(new IntPtr(&dataBlob), null, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, 65, new IntPtr(&dataBlob2)))
						{
							throw InfoCardTrace.ThrowHelperError((Exception)new Win32Exception(Marshal.GetLastWin32Error(), SR.GetString("StoreCryptProtectDataAsSystemFailed")));
						}
					}
					fixed (byte* ptr = &m_header[GetOffsetToEncryptedFileHeader()])
					{
						EncryptedFileStoreHeader* ptr2 = (EncryptedFileStoreHeader*)ptr;
						ptr2->KeyBlockV2.KeyDataOffset = 0;
						ptr2->KeyBlockV2.KeyDataSize = dataBlob2.cbData;
						m_encryptedKey = new byte[dataBlob2.cbData];
						for (int i = 0; i < dataBlob2.cbData; i++)
						{
							m_encryptedKey[i] = ((byte*)dataBlob2.pbData.ToPointer())[i];
						}
					}
				}
				finally
				{
					Exception ex = null;
					if (IntPtr.Zero != dataBlob.pbData)
					{
						Utility.ClearUnsafeMemory(dataBlob.pbData, dataBlob.cbData);
						if (IntPtr.Zero != NativeMethods.LocalFree(dataBlob.pbData))
						{
							ex = new Win32Exception(Marshal.GetLastWin32Error());
						}
					}
					if (IntPtr.Zero != dataBlob2.pbData)
					{
						Utility.ClearUnsafeMemory(dataBlob2.pbData, dataBlob2.cbData);
						if (IntPtr.Zero != NativeMethods.LocalFree(dataBlob2.pbData))
						{
							ex = new Win32Exception(Marshal.GetLastWin32Error());
						}
					}
					if (ex != null)
					{
						throw InfoCardTrace.ThrowHelperError(ex);
					}
				}
			}
		}
		finally
		{
			ProtectKey();
			Array.Clear(array, 0, array.Length);
		}
	}

	private void ObtainDataKeyFromHeader()
	{
		try
		{
			byte[] array = TryObtainDataKeyFromDPAPI();
			if (array == null)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreUnableToGetStoreKeyFromDPAPI")));
			}
			m_key = array;
			m_keyProtected = false;
			ProtectKey();
		}
		catch (Exception ex)
		{
			if (InfoCardTrace.IsFatal(ex))
			{
				throw;
			}
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidStoreProtectionKeyException());
		}
	}

	private unsafe byte[] TryObtainDataKeyFromDPAPI()
	{
		DataBlob dataBlob = default(DataBlob);
		DataBlob dataBlob2 = default(DataBlob);
		fixed (byte* ptr = &m_header[GetOffsetToEncryptedFileHeader()])
		{
			EncryptedFileStoreHeader* ptr2 = (EncryptedFileStoreHeader*)ptr;
			if (11 == ptr2->Version && ptr2->KeyBlock.KeyType != 0)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreFileNotProtectedWithDPAPI")));
			}
			byte[] array = null;
			byte[] array2 = null;
			GCHandle gCHandle = default(GCHandle);
			try
			{
				DataBlob dataBlob3 = default(DataBlob);
				if (ptr2->Version == 12)
				{
					gCHandle = GCHandle.Alloc(m_encryptedKey, GCHandleType.Pinned);
					dataBlob3.pbData = gCHandle.AddrOfPinnedObject();
					dataBlob3.cbData = ptr2->KeyBlockV2.KeyDataSize;
				}
				else
				{
					dataBlob3.pbData = new IntPtr(&ptr2->KeyBlock.EncryptedKey);
					dataBlob3.cbData = ptr2->KeyBlock.EncryptedKeySize;
					ptr2->KeyBlockV2.KeyDataOffset = 0;
					ptr2->KeyBlockV2.KeyDataSize = dataBlob3.cbData;
					m_encryptedKey = new byte[dataBlob3.cbData];
					for (int i = 0; i < dataBlob3.cbData; i++)
					{
						m_encryptedKey[i] = ((byte*)dataBlob3.pbData.ToPointer())[i];
					}
				}
				using (new SystemIdentity(throwIfAlreadySystem: true))
				{
					if (!NativeMethods.CryptUnprotectData(new IntPtr(&dataBlob3), null, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, 1, new IntPtr(&dataBlob2)))
					{
						throw InfoCardTrace.ThrowHelperError((Exception)new Win32Exception(Marshal.GetLastWin32Error(), SR.GetString("StoreCryptUnprotectDataAsSystemFailed")));
					}
				}
				if (!NativeMethods.CryptUnprotectData(new IntPtr(&dataBlob2), null, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, 1, new IntPtr(&dataBlob)))
				{
					throw InfoCardTrace.ThrowHelperError((Exception)new Win32Exception(Marshal.GetLastWin32Error(), SR.GetString("StoreCryptUnprotectDataFailed")));
				}
				InfoCardTrace.Assert(dataBlob.cbData == 32 + HashUtility.HashBufferLength, "The data size returned by CryptUnprotectData is invalid or corrupt.", new object[0]);
				array = new byte[32];
				Marshal.Copy(dataBlob.pbData, array, 0, 32);
				array2 = new byte[HashUtility.HashBufferLength];
				HashUtility.SetHashValue(array2, 0, array, 0, 32);
				for (int j = 0; j < array2.Length; j++)
				{
					if (array2[j] != ((byte*)dataBlob.pbData.ToPointer())[32 + j])
					{
						throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreDecryptedKeyIsNotValid")));
					}
				}
				return array;
			}
			catch
			{
				if (array != null)
				{
					Array.Clear(array, 0, array.Length);
				}
				throw;
			}
			finally
			{
				if (gCHandle.IsAllocated)
				{
					gCHandle.Free();
				}
				if (IntPtr.Zero != dataBlob2.pbData)
				{
					Utility.ClearUnsafeMemory(dataBlob2.pbData, dataBlob2.cbData);
					NativeMethods.LocalFree(dataBlob2.pbData);
				}
				if (IntPtr.Zero != dataBlob.pbData)
				{
					Utility.ClearUnsafeMemory(dataBlob.pbData, dataBlob.cbData);
					NativeMethods.LocalFree(dataBlob.pbData);
				}
			}
		}
	}

	private bool LogIfAclsTampered(FileSystemInfo fileSysInfo)
	{
		bool flag = true;
		try
		{
			FileSystemSecurity fileSystemSecurity = null;
			if (fileSysInfo is DirectoryInfo)
			{
				fileSystemSecurity = ((DirectoryInfo)fileSysInfo).GetAccessControl(AccessControlSections.Access | AccessControlSections.Owner);
			}
			else
			{
				InfoCardTrace.Assert(fileSysInfo is FileInfo, "Only fileinfo possible", new object[0]);
				fileSystemSecurity = ((FileInfo)fileSysInfo).GetAccessControl(AccessControlSections.Access | AccessControlSections.Owner);
			}
			flag = LogIfAclsTamperedHelper(fileSystemSecurity);
		}
		catch (UnauthorizedAccessException)
		{
			InfoCardTrace.Assert(flag, "ACL must have been tampered with", new object[0]);
		}
		if (flag)
		{
			DataAccessException ex2 = new DataAccessException(SR.GetString("StoreAclsTamperedWith"));
			InfoCardTrace.TraceAndLogException((Exception)(object)ex2);
		}
		return flag;
	}

	private bool LogIfAclsTamperedHelper(FileSystemSecurity fs)
	{
		if (SystemIdentity.LsaIdentityReference != fs.GetOwner(typeof(SecurityIdentifier)))
		{
			return true;
		}
		AuthorizationRuleCollection accessRules = fs.GetAccessRules(includeExplicit: true, includeInherited: true, typeof(SecurityIdentifier));
		bool flag = fs is DirectorySecurity;
		foreach (FileSystemAccessRule item in accessRules)
		{
			if ((!(SystemIdentity.LsaIdentityReference == item.IdentityReference) || FileSystemRights.FullControl != item.FileSystemRights || item.AccessControlType != 0) && (!flag || !(AdministratorSid == item.IdentityReference) || item.AccessControlType != 0 || (FileSystemRights.ListDirectory | FileSystemRights.DeleteSubdirectoriesAndFiles | FileSystemRights.Synchronize) != item.FileSystemRights))
			{
				return true;
			}
		}
		return false;
	}

	private static T CreateSecurityDescriptor<T>() where T : FileSystemSecurity, new()
	{
		T val = new T();
		val.SetOwner(SystemIdentity.LsaIdentityReference);
		AuthorizationRuleCollection accessRules = val.GetAccessRules(includeExplicit: true, includeInherited: true, typeof(SecurityIdentifier));
		foreach (FileSystemAccessRule item in accessRules)
		{
			val.RemoveAccessRuleAll(item);
		}
		val.AddAccessRule(new FileSystemAccessRule(SystemIdentity.LsaIdentityReference, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow));
		if (val is DirectorySecurity)
		{
			val.AddAccessRule(new FileSystemAccessRule(AdministratorSid, FileSystemRights.ListDirectory | FileSystemRights.DeleteSubdirectoriesAndFiles, AccessControlType.Allow));
		}
		val.SetAccessRuleProtection(isProtected: true, preserveInheritance: false);
		return val;
	}

	private void SetupProvider()
	{
		m_provider = SafeRsaProviderHandle.Construct();
	}

	private byte[] AllocateIvBuffer()
	{
		InfoCardTrace.Assert(16 == m_encAlg.IV.Length, "Must be equal", new object[0]);
		InfoCardTrace.Assert(16 == m_encAlg.IV.Length, "Must be equal", new object[0]);
		return new byte[m_encAlg.IV.Length];
	}

	private static void ResilientDelete(FileInfo toDelete)
	{
		int num = 10;
		bool flag = true;
		Exception inner = null;
		do
		{
			if (!flag)
			{
				Thread.Sleep(num);
				num *= 2;
			}
			try
			{
				toDelete.Delete();
				flag = true;
			}
			catch (IOException ex)
			{
				inner = ex;
				flag = false;
			}
		}
		while (!flag && num <= 500);
		if (!flag)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new DataAccessException(SR.GetString("StoreFileInUse"), inner));
		}
	}

	private static void ResilientMove(FileInfo fileFrom, FileInfo fileTo)
	{
		int num = 10;
		bool flag = true;
		do
		{
			if (!flag)
			{
				Thread.Sleep(num);
				num *= 2;
			}
			try
			{
				fileFrom.MoveTo(fileTo.FullName);
				flag = true;
			}
			catch (IOException)
			{
				flag = false;
			}
		}
		while (!flag && num <= 500);
		if (!flag)
		{
			InfoCardTrace.FailFast(SR.GetString("StoreFileInUse"));
		}
	}

	private static FileStream ResilientOpen(FileInfo toOpen, FileMode mode, FileAccess access)
	{
		int num = 10;
		bool flag = true;
		Exception inner = null;
		FileStream result = null;
		do
		{
			if (!flag)
			{
				Thread.Sleep(num);
				num *= 2;
			}
			try
			{
				result = toOpen.Open(mode, access, FileShare.None);
				flag = true;
			}
			catch (IOException ex)
			{
				inner = ex;
				flag = false;
			}
		}
		while (!flag && num <= 500);
		if (!flag)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new DataAccessException(SR.GetString("StoreFileInUse"), inner));
		}
		return result;
	}

	internal static SymmetricAlgorithm CreateEncryptionAlg()
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.Mode = CipherMode.CBC;
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		return rijndaelManaged;
	}
}
