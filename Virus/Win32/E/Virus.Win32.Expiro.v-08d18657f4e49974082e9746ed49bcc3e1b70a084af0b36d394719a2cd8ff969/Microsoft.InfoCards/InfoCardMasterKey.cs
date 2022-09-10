using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class InfoCardMasterKey
{
	private const byte Marker = 29;

	private const byte Version = 1;

	private Uri m_infoCardId;

	private byte[] m_key;

	public byte[] Key => m_key;

	public InfoCardMasterKey(Uri infoCardId)
	{
		m_infoCardId = infoCardId;
	}

	public InfoCardMasterKey(Uri infoCardId, byte[] key)
	{
		m_infoCardId = infoCardId;
		m_key = key;
	}

	public static InfoCardMasterKey NewMasterKey(Uri infoCardId)
	{
		InfoCardMasterKey infoCardMasterKey = new InfoCardMasterKey(infoCardId);
		InfoCardTrace.Assert(null == infoCardMasterKey.m_key, "Should be null", new object[0]);
		infoCardMasterKey.m_key = GenerateKey();
		return infoCardMasterKey;
	}

	private static byte[] GenerateKey()
	{
		byte[] array = new byte[32];
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	public void Get(StoreConnection con)
	{
		InfoCardTrace.Assert(null != m_infoCardId, "populate infocard id before calling Get", new object[0]);
		InfoCardTrace.Assert(con != null, "null connection", new object[0]);
		DataRow row = GetRow(con, QueryDetails.FullRow);
		Deserialize(new MemoryStream(row.GetDataField()));
	}

	public void Save(StoreConnection con)
	{
		InfoCardTrace.Assert(con != null, "null connection", new object[0]);
		ThrowIfNotComplete();
		DataRow dataRow = TryGetRow(con, QueryDetails.FullHeader);
		if (dataRow == null)
		{
			dataRow = new DataRow();
			dataRow.ObjectType = 3;
			dataRow.GlobalId = Guid.NewGuid();
		}
		dataRow.SetIndexValue("ix_parentid", GlobalId.DeriveFrom(m_infoCardId.ToString()));
		dataRow.SetIndexValue("ix_masterkey", m_key);
		MemoryStream memoryStream = new MemoryStream();
		Serialize(memoryStream);
		dataRow.SetDataField(memoryStream.ToArray());
		con.Save(dataRow);
	}

	public void ThrowIfNotComplete()
	{
		if (!(null != m_infoCardId) || Utility.ArrayIsNullOrEmpty(m_key))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new SerializationIncompleteException(GetType()));
		}
	}

	public void Encrypt(PinProtectionHelper pinHelper)
	{
		m_key = pinHelper.EncryptMasterKey(m_key);
	}

	public void Decrypt(PinProtectionHelper pinHelper)
	{
		m_key = pinHelper.DecryptMasterKey(m_key);
	}

	public PinProtectionHelper GetPinHelper(string pin)
	{
		return new PinProtectionHelper(pin, m_key);
	}

	private void Serialize(Stream stream)
	{
		ThrowIfNotComplete();
		BinaryWriter binaryWriter = new BinaryWriter(stream, Encoding.Unicode);
		binaryWriter.Write((byte)1);
		Utility.SerializeBytes(binaryWriter, m_key);
		binaryWriter.Write((byte)29);
	}

	private void Deserialize(Stream stream)
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(stream, Encoding.Unicode);
		if (1 != binaryReader.ReadByte())
		{
			InfoCardTrace.Assert(false, "Master key version mismatch", new object[0]);
		}
		m_key = binaryReader.ReadBytes(binaryReader.ReadInt32());
		if (29 != binaryReader.ReadByte())
		{
			InfoCardTrace.Assert(false, "Invalid stream detected", new object[0]);
		}
		ThrowIfNotComplete();
	}

	protected DataRow GetRow(StoreConnection con, QueryDetails details)
	{
		DataRow dataRow = TryGetRow(con, details);
		InfoCardTrace.Assert(dataRow != null && 3 == dataRow.ObjectType, "invalid service object type", new object[0]);
		return dataRow;
	}

	protected DataRow TryGetRow(StoreConnection con, QueryDetails details)
	{
		InfoCardTrace.Assert(null != m_infoCardId, "populate cardid before retrieving row", new object[0]);
		return con.GetSingleRow(details, new QueryParameter("ix_objecttype", 3), new QueryParameter("ix_parentid", GlobalId.DeriveFrom(m_infoCardId.ToString())));
	}
}
