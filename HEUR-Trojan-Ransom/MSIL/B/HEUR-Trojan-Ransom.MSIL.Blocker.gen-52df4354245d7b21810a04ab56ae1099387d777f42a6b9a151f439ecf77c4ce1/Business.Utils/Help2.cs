using System;
using System.Security.Cryptography;
using MessagePack;
using Newtonsoft.Json;

namespace Business.Utils;

public static class Help2
{
	public static int GetValue(int? value, int defaultValue = 0)
	{
		if (value.HasValue && value.HasValue)
		{
			return value.Value;
		}
		return defaultValue;
	}

	public static double GetValue(double? value, double defaultValue = 0.0)
	{
		if (value.HasValue && value.HasValue)
		{
			return value.Value;
		}
		return defaultValue;
	}

	public static Type TryJsonDeserialize<Type>(string value, JsonSerializerSettings settings)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			return default(Type);
		}
		try
		{
			return JsonConvert.DeserializeObject<Type>(value, settings);
		}
		catch (Exception)
		{
			return default(Type);
		}
	}

	public static Type TryJsonDeserialize<Type>(string value, params JsonConverter[] converters)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			return default(Type);
		}
		try
		{
			return JsonConvert.DeserializeObject<Type>(value, converters);
		}
		catch
		{
			return default(Type);
		}
	}

	public static Type TryJsonDeserialize<Type>(string value, out string error)
	{
		error = null;
		if (string.IsNullOrWhiteSpace(value))
		{
			return default(Type);
		}
		try
		{
			return JsonConvert.DeserializeObject<Type>(value);
		}
		catch (Exception ex)
		{
			error = Convert.ToString(ex);
			return default(Type);
		}
	}

	public static bool TryJsonDeserialize<Type>(string value, System.Type type, out Type result)
	{
		try
		{
			result = (Type)JsonConvert.DeserializeObject(value, type);
			return true;
		}
		catch
		{
			result = default(Type);
			return false;
		}
	}

	public static bool TryJsonDeserialize<Type>(string value, out Type result)
	{
		try
		{
			result = JsonConvert.DeserializeObject<Type>(value);
			return true;
		}
		catch
		{
			result = default(Type);
			return false;
		}
	}

	public static object TryJsonDeserialize(string value, Type type, out string error)
	{
		error = null;
		if (string.IsNullOrWhiteSpace(value))
		{
			return null;
		}
		try
		{
			return JsonConvert.DeserializeObject(value, type);
		}
		catch (Exception ex)
		{
			error = Convert.ToString(ex);
			return null;
		}
	}

	public static string JsonSerialize<Type>(Type value, params JsonConverter[] converters)
	{
		return JsonConvert.SerializeObject((object)value, converters);
	}

	public static string JsonSerialize<Type>(Type value, JsonSerializerSettings settings)
	{
		return JsonConvert.SerializeObject((object)value, settings);
	}

	public static Type TryBinaryDeserialize<Type>(this byte[] source)
	{
		if (source == null)
		{
			return default(Type);
		}
		try
		{
			return MessagePackSerializer.Deserialize<Type>(source);
		}
		catch
		{
			return default(Type);
		}
	}

	public static bool TryBinaryDeserialize<Type>(this byte[] source, out Type result)
	{
		try
		{
			result = MessagePackSerializer.Deserialize<Type>(source);
			return true;
		}
		catch
		{
			result = default(Type);
			return false;
		}
	}

	public static byte[] BinarySerialize<Type>(this Type source)
	{
		return MessagePackSerializer.Serialize<Type>(source);
	}

	internal static Type ChangeType<Type>(object value)
	{
		return (Type)ChangeType(value, typeof(Type));
	}

	internal static object ChangeType(object value, Type type)
	{
		if (value == null)
		{
			return Activator.CreateInstance(type);
		}
		try
		{
			return Convert.ChangeType(value, type);
		}
		catch
		{
			return Activator.CreateInstance(type);
		}
	}

	internal static int Random(int minValue, int maxValue)
	{
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		return new Random(BitConverter.ToInt32(array, 0)).Next(minValue, maxValue);
	}

	internal static int Random(int maxValue)
	{
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[Convert.ToInt32(6.0 - Math.Truncate(2.0))];
		rNGCryptoServiceProvider.GetBytes(array);
		return new Random(BitConverter.ToInt32(array, 0)).Next(maxValue);
	}

	internal static double Random()
	{
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[Convert.ToInt32(2.585786437626905 + Math.Sqrt(2.0))];
		rNGCryptoServiceProvider.GetBytes(array);
		return new Random(BitConverter.ToInt32(array, 0)).NextDouble();
	}
}
