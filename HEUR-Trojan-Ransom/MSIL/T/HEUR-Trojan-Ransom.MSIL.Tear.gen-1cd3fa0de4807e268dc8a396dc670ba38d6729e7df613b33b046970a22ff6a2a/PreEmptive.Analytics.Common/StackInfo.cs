namespace PreEmptive.Analytics.Common;

public struct StackInfo
{
	public int Sequence;

	public string Type;

	public string Method;

	public string Signature;

	public string File;

	public string Line;

	public StackInfo(int sequence, string type, string method, string signature, string file, string line)
	{
		Sequence = sequence;
		Type = type;
		Method = method;
		Signature = signature;
		File = file;
		Line = line;
	}
}
