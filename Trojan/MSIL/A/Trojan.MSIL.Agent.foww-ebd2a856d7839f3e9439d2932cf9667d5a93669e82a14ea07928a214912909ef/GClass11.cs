using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

public static class GClass11
{
	public static string smethod_0<T>(T o)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		DataContractJsonSerializer val = new DataContractJsonSerializer(typeof(T));
		using MemoryStream memoryStream = new MemoryStream();
		((XmlObjectSerializer)val).WriteObject((Stream)memoryStream, (object)o);
		return Encoding.UTF8.GetString(memoryStream.ToArray());
	}

	public static T smethod_1<T>(string json)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		DataContractJsonSerializer val = new DataContractJsonSerializer(typeof(T));
		using MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(json));
		return (T)((XmlObjectSerializer)val).ReadObject((Stream)memoryStream);
	}
}
