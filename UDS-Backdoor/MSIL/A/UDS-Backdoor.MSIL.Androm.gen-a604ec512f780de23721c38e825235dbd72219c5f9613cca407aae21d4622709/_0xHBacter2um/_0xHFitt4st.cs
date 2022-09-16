using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace _0xHBacter2um;

internal static class _0xHFitt4st
{
	public static T _0xHDisow3me3ts<T>(string _0xHC4rous)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		DataContractJsonSerializer val = new DataContractJsonSerializer(typeof(T));
		using MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(_0xHC4rous));
		return (T)((XmlObjectSerializer)val).ReadObject((Stream)memoryStream);
	}

	public static string _0xHDr6ars<T>(T _0xHTr7ced)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		DataContractJsonSerializer val = new DataContractJsonSerializer(typeof(T));
		using MemoryStream memoryStream = new MemoryStream();
		((XmlObjectSerializer)val).WriteObject((Stream)memoryStream, (object)_0xHTr7ced);
		return Encoding.UTF8.GetString(memoryStream.ToArray());
	}
}
