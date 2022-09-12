using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace InstagramApiSharp.Helpers;

internal class SerializationHelper
{
	public static Stream SerializeToStream(object o)
	{
		MemoryStream memoryStream = new MemoryStream();
		((IFormatter)new BinaryFormatter()).Serialize((Stream)memoryStream, o);
		memoryStream.Position = 0L;
		return memoryStream;
	}

	public static T DeserializeFromStream<T>(Stream stream)
	{
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		stream.Seek(0L, SeekOrigin.Begin);
		return (T)((IFormatter)binaryFormatter).Deserialize(stream);
	}

	public static string SerializeToString(object o)
	{
		return JsonConvert.SerializeObject(o);
	}

	public static T DeserializeFromString<T>(string json)
	{
		return JsonConvert.DeserializeObject<T>(json);
	}
}
