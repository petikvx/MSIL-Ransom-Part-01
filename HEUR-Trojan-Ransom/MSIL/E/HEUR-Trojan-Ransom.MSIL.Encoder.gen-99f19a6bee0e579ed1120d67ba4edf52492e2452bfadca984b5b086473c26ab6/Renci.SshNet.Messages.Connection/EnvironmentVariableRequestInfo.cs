using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Connection;

internal class EnvironmentVariableRequestInfo : RequestInfo
{
	private byte[] _variableName;

	private byte[] _variableValue;

	public const string Name = "env";

	public override string RequestName => "env";

	public string VariableName => SshData.Utf8.GetString(_variableName, 0, _variableName.Length);

	public string VariableValue => SshData.Utf8.GetString(_variableValue, 0, _variableValue.Length);

	protected override int BufferCapacity => base.BufferCapacity + 4 + _variableName.Length + 4 + _variableValue.Length;

	public EnvironmentVariableRequestInfo()
	{
		base.WantReply = true;
	}

	public EnvironmentVariableRequestInfo(string variableName, string variableValue)
		: this()
	{
		_variableName = SshData.Utf8.GetBytes(variableName);
		_variableValue = SshData.Utf8.GetBytes(variableValue);
	}

	protected override void LoadData()
	{
		base.LoadData();
		_variableName = ReadBinary();
		_variableValue = ReadBinary();
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(_variableName);
		WriteBinaryString(_variableValue);
	}
}
