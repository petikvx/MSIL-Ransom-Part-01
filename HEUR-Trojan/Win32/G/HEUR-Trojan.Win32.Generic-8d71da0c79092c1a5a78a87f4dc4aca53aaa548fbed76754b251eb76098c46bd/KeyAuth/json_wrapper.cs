using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace KeyAuth;

public class json_wrapper
{
	private DataContractJsonSerializer serializer;

	private object current_object;

	public json_wrapper(object obj_to_work_with)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		current_object = obj_to_work_with;
		Type type = current_object.GetType();
		serializer = new DataContractJsonSerializer(type);
		if (!is_serializable(type))
		{
			throw new Exception($"the object {current_object} isn't a serializable");
		}
	}

	public static bool is_serializable(Type to_check)
	{
		if (to_check.IsSerializable)
		{
			return true;
		}
		return to_check.IsDefined(typeof(DataContractAttribute), inherit: true);
	}

	public T string_to_generic<T>(string json)
	{
		return (T)string_to_object(json);
	}

	public object string_to_object(string json)
	{
		using MemoryStream memoryStream = new MemoryStream(Encoding.Default.GetBytes(json));
		return ((XmlObjectSerializer)serializer).ReadObject((Stream)memoryStream);
	}
}
