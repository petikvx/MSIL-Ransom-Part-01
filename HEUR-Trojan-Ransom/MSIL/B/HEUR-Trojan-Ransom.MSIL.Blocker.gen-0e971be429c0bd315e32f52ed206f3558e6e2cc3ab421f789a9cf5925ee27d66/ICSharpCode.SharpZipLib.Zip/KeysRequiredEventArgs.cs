using System;

namespace ICSharpCode.SharpZipLib.Zip;

public class KeysRequiredEventArgs : EventArgs
{
	private byte[] FnNczgeTiwCRfrmMSzVbtHOBuXHF;

	private string lxhstJijkIxlZNiBQEavPUEeAWyV;

	public string FileName => lxhstJijkIxlZNiBQEavPUEeAWyV;

	public byte[] Key
	{
		get
		{
			return FnNczgeTiwCRfrmMSzVbtHOBuXHF;
		}
		set
		{
			FnNczgeTiwCRfrmMSzVbtHOBuXHF = value;
		}
	}

	public KeysRequiredEventArgs(string name)
	{
		lxhstJijkIxlZNiBQEavPUEeAWyV = name;
	}

	public KeysRequiredEventArgs(string name, byte[] keyValue)
	{
		lxhstJijkIxlZNiBQEavPUEeAWyV = name;
		FnNczgeTiwCRfrmMSzVbtHOBuXHF = keyValue;
	}
}
