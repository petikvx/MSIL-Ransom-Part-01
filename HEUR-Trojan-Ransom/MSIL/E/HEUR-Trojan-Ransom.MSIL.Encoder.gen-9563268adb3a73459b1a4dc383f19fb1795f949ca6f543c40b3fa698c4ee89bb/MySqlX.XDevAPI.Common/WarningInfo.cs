namespace MySqlX.XDevAPI.Common;

public class WarningInfo
{
	public uint Code;

	public string Message;

	public uint Level;

	public WarningInfo(uint code, string msg)
	{
		Code = code;
		Message = msg;
	}
}
