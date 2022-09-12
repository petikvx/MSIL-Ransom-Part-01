using System;

namespace ICSharpCode.SharpZipLib.Zip;

public class KeysRequiredEventArgs : EventArgs
{
	private byte[] YzBRIVUxaJVmjEDtROkGJXZIcLMW;

	private string aKhVWeUWmvRxPyHgLbxOrFTvpQvg;

	public string FileName => aKhVWeUWmvRxPyHgLbxOrFTvpQvg;

	public byte[] Key
	{
		get
		{
			return YzBRIVUxaJVmjEDtROkGJXZIcLMW;
		}
		set
		{
			YzBRIVUxaJVmjEDtROkGJXZIcLMW = value;
		}
	}

	public KeysRequiredEventArgs(string name)
	{
		aKhVWeUWmvRxPyHgLbxOrFTvpQvg = name;
	}

	public KeysRequiredEventArgs(string name, byte[] keyValue)
	{
		aKhVWeUWmvRxPyHgLbxOrFTvpQvg = name;
		YzBRIVUxaJVmjEDtROkGJXZIcLMW = keyValue;
	}
}
