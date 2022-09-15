using System.IO;
using sexas.Logic.Json;

namespace sexas.Logic.Extensions;

public static class JsonExt
{
	public static JsonValue FromJSON(this string json)
	{
		return JsonValue.Load(new StringReader(json));
	}

	public static string ToJSON<T>(this T instance)
	{
		return JsonValue.ToJsonValue(instance);
	}
}
