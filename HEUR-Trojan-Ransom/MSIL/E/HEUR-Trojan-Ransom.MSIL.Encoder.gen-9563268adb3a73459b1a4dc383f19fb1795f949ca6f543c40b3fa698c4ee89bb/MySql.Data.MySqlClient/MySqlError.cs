namespace MySql.Data.MySqlClient;

public class MySqlError
{
	public string Level { get; }

	public int Code { get; }

	public string Message { get; }

	public MySqlError(string level, int code, string message)
	{
		Level = level;
		Code = code;
		Message = message;
	}
}
