using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace JSONSerializer;

[StandardModule]
public sealed class Serializer
{
	public static string Serialize(Types.JSONObject data)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("{");
		foreach (Types.JSONPair datum in data)
		{
			stringBuilder.Append($"\"{datum.Name}\":");
			if (Helpers.IsNumeric(RuntimeHelpers.GetObjectValue(datum.Value)))
			{
				stringBuilder.Append(Helpers.EscapeString(datum.Value.ToString()));
			}
			else if (Helpers.IsBoolean(RuntimeHelpers.GetObjectValue(datum.Value)))
			{
				stringBuilder.Append(Helpers.EscapeString(datum.Value.ToString()));
			}
			else if (Helpers.IsJSONObject(RuntimeHelpers.GetObjectValue(datum.Value)))
			{
				stringBuilder.Append(Serialize((Types.JSONObject)datum.Value));
			}
			else if (Helpers.IsJSONArray(RuntimeHelpers.GetObjectValue(datum.Value)))
			{
				stringBuilder.Append(SerializeArray((Types.JSONArray)datum.Value));
			}
			else
			{
				stringBuilder.Append($"\"{Helpers.EscapeString(datum.Value.ToString())}\"");
			}
			stringBuilder.Append(",");
		}
		stringBuilder.Remove(checked(stringBuilder.Length - 1), 1);
		stringBuilder.Append("}");
		return stringBuilder.ToString();
	}

	private static string SerializeArray(Types.JSONArray data)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("[");
		foreach (object datum in data)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(datum);
			if (Helpers.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue)))
			{
				stringBuilder.Append(Helpers.EscapeString(objectValue.ToString()));
			}
			else if (Helpers.IsBoolean(RuntimeHelpers.GetObjectValue(objectValue)))
			{
				stringBuilder.Append(Helpers.EscapeString(objectValue.ToString()));
			}
			else if (Helpers.IsJSONObject(RuntimeHelpers.GetObjectValue(objectValue)))
			{
				stringBuilder.Append(Serialize((Types.JSONObject)objectValue));
			}
			else if (Helpers.IsJSONArray(RuntimeHelpers.GetObjectValue(objectValue)))
			{
				stringBuilder.Append(SerializeArray((Types.JSONArray)objectValue));
			}
			else
			{
				stringBuilder.Append($"\"{Helpers.EscapeString(objectValue.ToString())}\"");
			}
			stringBuilder.Append(",");
		}
		stringBuilder.Remove(checked(stringBuilder.Length - 1), 1);
		stringBuilder.Append("]");
		return stringBuilder.ToString();
	}
}
