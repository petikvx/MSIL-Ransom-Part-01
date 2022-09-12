using System.Collections.Generic;
using Renci.SshNet.Common;

namespace Renci.SshNet.Security;

public class KeyHostAlgorithm : HostAlgorithm
{
	private class SshKeyData : SshData
	{
		private byte[] _name;

		private IList<byte[]> _keys;

		public BigInteger[] Keys
		{
			get
			{
				BigInteger[] array = new BigInteger[_keys.Count];
				for (int i = 0; i < _keys.Count; i++)
				{
					byte[] data = _keys[i];
					array[i] = data.ToBigInteger();
				}
				return array;
			}
			private set
			{
				_keys = new List<byte[]>(value.Length);
				foreach (BigInteger bigInteger in value)
				{
					_keys.Add(bigInteger.ToByteArray().Reverse());
				}
			}
		}

		private string Name
		{
			get
			{
				return SshData.Utf8.GetString(_name, 0, _name.Length);
			}
			set
			{
				_name = SshData.Utf8.GetBytes(value);
			}
		}

		protected override int BufferCapacity
		{
			get
			{
				int bufferCapacity = base.BufferCapacity;
				bufferCapacity += 4;
				bufferCapacity += _name.Length;
				foreach (byte[] key in _keys)
				{
					bufferCapacity += 4;
					bufferCapacity += key.Length;
				}
				return bufferCapacity;
			}
		}

		public SshKeyData()
		{
		}

		public SshKeyData(string name, params BigInteger[] keys)
		{
			Name = name;
			Keys = keys;
		}

		protected override void LoadData()
		{
			_name = ReadBinary();
			_keys = new List<byte[]>();
			while (!base.IsEndOfData)
			{
				_keys.Add(ReadBinary());
			}
		}

		protected override void SaveData()
		{
			WriteBinaryString(_name);
			foreach (byte[] key in _keys)
			{
				WriteBinaryString(key);
			}
		}
	}

	private class SignatureKeyData : SshData
	{
		private byte[] AlgorithmName { get; set; }

		public byte[] Signature { get; private set; }

		protected override int BufferCapacity => base.BufferCapacity + 4 + AlgorithmName.Length + 4 + Signature.Length;

		public SignatureKeyData()
		{
		}

		public SignatureKeyData(string name, byte[] signature)
		{
			AlgorithmName = SshData.Utf8.GetBytes(name);
			Signature = signature;
		}

		protected override void LoadData()
		{
			AlgorithmName = ReadBinary();
			Signature = ReadBinary();
		}

		protected override void SaveData()
		{
			WriteBinaryString(AlgorithmName);
			WriteBinaryString(Signature);
		}
	}

	public Key Key { get; private set; }

	public override byte[] Data => new SshKeyData(base.Name, Key.Public).GetBytes();

	public KeyHostAlgorithm(string name, Key key)
		: base(name)
	{
		Key = key;
	}

	public KeyHostAlgorithm(string name, Key key, byte[] data)
		: base(name)
	{
		Key = key;
		SshKeyData sshKeyData = new SshKeyData();
		sshKeyData.Load(data);
		Key.Public = sshKeyData.Keys;
	}

	public override byte[] Sign(byte[] data)
	{
		return new SignatureKeyData(base.Name, Key.Sign(data)).GetBytes();
	}

	public override bool VerifySignature(byte[] data, byte[] signature)
	{
		SignatureKeyData signatureKeyData = new SignatureKeyData();
		signatureKeyData.Load(signature);
		return Key.VerifySignature(data, signatureKeyData.Signature);
	}
}
