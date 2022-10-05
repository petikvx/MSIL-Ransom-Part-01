using System.IO;
using System.Runtime.Serialization;

namespace RedLine.Reburn.Models.Info;

[DataContract(Name = "RemoteFile", Namespace = "v1/Models")]
public class RemoteFile
{
	[DataMember(Name = "FileName")]
	public string FileName { get; set; }

	[DataMember(Name = "SourcePath")]
	public string SourcePath { get; set; }

	[DataMember(Name = "Body")]
	public byte[] Body { get; set; }

	[DataMember(Name = "FileDirectory")]
	public string FileDirectory { get; set; }

	public RemoteFile()
	{
	}

	public RemoteFile(string filename)
	{
		FileName = new FileInfo(filename).Name;
		Body = File.ReadAllBytes(filename);
	}
}
