using System.Text;

namespace LogToText;

internal class CallRec : LogRec
{
	public uint Level;

	public uint ThreadId;

	public uint CallAddr;

	public uint FuncAddr;

	public string FuncName;

	public string[] Args;

	public CallRec()
	{
		Type = LogRecType.CallRec;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (FuncName != "")
		{
			stringBuilder.AppendFormat("{0} ", FuncName);
		}
		else
		{
			stringBuilder.AppendFormat("0x{0:X} ", FuncAddr);
		}
		stringBuilder.Append("(");
		for (int i = 0; i < Args.Length; i++)
		{
			if (i > 0)
			{
				stringBuilder.Append(", ");
			}
			stringBuilder.AppendFormat("{0}", Args[i]);
		}
		stringBuilder.Append(")");
		return stringBuilder.ToString();
	}
}
