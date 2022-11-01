namespace YullySpoofer;

public class WinXParameters
{
	private byte[] _payload;

	private string _targetProcess;

	private string[] _arguments;

	private bool _hidden;

	public string[] Arguments
	{
		get
		{
			return _arguments;
		}
		protected set
		{
			_arguments = value;
		}
	}

	public bool Hidden
	{
		get
		{
			return _hidden;
		}
		protected set
		{
			_hidden = value;
		}
	}

	public byte[] Payload
	{
		get
		{
			return _payload;
		}
		protected set
		{
			_payload = value;
		}
	}

	public string TargetProcess
	{
		get
		{
			return _targetProcess;
		}
		protected set
		{
			_targetProcess = value;
		}
	}

	private WinXParameters()
	{
	}

	public static WinXParameters Create(byte[] payload, string targetProcess, bool hidden, params string[] arguments)
	{
		return new WinXParameters
		{
			TargetProcess = targetProcess,
			Payload = payload,
			Arguments = arguments,
			Hidden = hidden
		};
	}

	public string GetFormattedHostFileName()
	{
		if (Arguments == null || Arguments.Length == 0)
		{
			return TargetProcess;
		}
		return string.Format("{0} {1}", TargetProcess, string.Join(" ", Arguments)).TrimEnd(new char[1] { ' ' });
	}
}
