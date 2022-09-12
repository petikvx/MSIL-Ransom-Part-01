using System;
using System.Security.Cryptography;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Security;

namespace Renci.SshNet.Common;

public class HostKeyEventArgs : EventArgs
{
	public bool CanTrust { get; set; }

	public byte[] HostKey { get; private set; }

	public string HostKeyName { get; private set; }

	public byte[] FingerPrint { get; private set; }

	public int KeyLength { get; private set; }

	public HostKeyEventArgs(KeyHostAlgorithm host)
	{
		CanTrust = true;
		HostKey = host.Data;
		HostKeyName = host.Name;
		KeyLength = host.Key.KeyLength;
		using MD5 mD = CryptoAbstraction.CreateMD5();
		FingerPrint = mD.ComputeHash(host.Data);
	}
}
