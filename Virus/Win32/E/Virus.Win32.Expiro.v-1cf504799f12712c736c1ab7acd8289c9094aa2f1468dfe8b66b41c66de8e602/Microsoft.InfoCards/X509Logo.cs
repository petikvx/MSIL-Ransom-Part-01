using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace Microsoft.InfoCards;

internal abstract class X509Logo
{
	private X509LogoType m_logoType;

	private string m_mediaType;

	private Dictionary<Oid, byte[]> m_fileHashes;

	private List<string> m_fileLocations;

	public X509LogoType LogoType => m_logoType;

	public string MediaType => m_mediaType;

	public Dictionary<Oid, byte[]> Hashes => m_fileHashes;

	public List<string> FileLocations => m_fileLocations;

	public X509Logo(X509LogoType logoType, string mediaType, Dictionary<Oid, byte[]> hashes, List<string> fileLocations)
	{
		m_logoType = logoType;
		m_mediaType = mediaType;
		m_fileHashes = hashes;
		m_fileLocations = fileLocations;
	}

	public override string ToString()
	{
		return base.ToString();
	}

	protected virtual void OnSerialize(BinaryWriter writer)
	{
	}

	public void Serialize(BinaryWriter writer)
	{
		writer.Write((byte)LogoType);
		Utility.SerializeString(writer, MediaType);
		writer.Write(Hashes.Count);
		foreach (Oid key in Hashes.Keys)
		{
			Utility.SerializeString(writer, key.Value);
			Utility.SerializeBytes(writer, m_fileHashes[key]);
		}
		writer.Write(FileLocations.Count);
		foreach (string fileLocation in FileLocations)
		{
			Utility.SerializeString(writer, fileLocation);
		}
		OnSerialize(writer);
	}
}
