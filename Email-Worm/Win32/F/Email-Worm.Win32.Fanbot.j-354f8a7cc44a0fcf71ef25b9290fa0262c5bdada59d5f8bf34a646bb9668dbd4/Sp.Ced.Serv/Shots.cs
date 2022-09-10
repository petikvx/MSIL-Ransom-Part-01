using System.Runtime.Serialization;

namespace Sp.Ced.Serv;

[DataContract]
public class Shots
{
	[DataMember]
	public string Error { get; set; }

	[DataMember]
	public byte[] Shot { get; set; }
}
