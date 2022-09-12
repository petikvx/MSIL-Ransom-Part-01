using System;

namespace Crypt3r;

[Serializable]
public class KeyInfo
{
	public byte[] Key { get; set; }

	public string Info { get; set; }
}
