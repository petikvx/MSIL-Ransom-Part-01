using System;
using System.Security.Cryptography;

namespace ns0;

internal sealed class Class2
{
	internal struct CngSymmetricAlgorithmCore
	{
		private readonly ICngSymmetricAlgorithm _outer;

		private string _keyName;

		private CngProvider _provider;

		private CngKeyOpenOptions _optionOptions;

		private const int BitsPerByte = 8;

		private bool KeyInPlainText => _keyName == null;

		public CngSymmetricAlgorithmCore(ICngSymmetricAlgorithm outer)
		{
			_outer = outer;
			_keyName = null;
			_provider = null;
			_optionOptions = CngKeyOpenOptions.None;
		}

		public CngSymmetricAlgorithmCore(ICngSymmetricAlgorithm outer, string keyName, CngProvider provider, CngKeyOpenOptions openOptions)
		{
			_outer = outer;
			_keyName = keyName;
			_provider = provider;
			_optionOptions = openOptions;
			CngKey cngKey = ProduceCngKey();
			try
			{
				CngSymmetricAlgorithmCore.yuFtQkrulJLCUqpfYkrxwjFWCnCHA(cngKey);
				_outer.imethod_1();
				_outer.BaseKeySize = CngSymmetricAlgorithmCore.gSolTYINBFBBYZpXAhMVosSKDozJ(cngKey);
			}
			finally
			{
				if (cngKey != null)
				{
					CngSymmetricAlgorithmCore.SFDEHGcjNRNtHFVZpmnqkeRqrwHDA((IDisposable)(object)cngKey);
				}
			}
		}

		public byte[] GetKeyIfExportable()
		{
			if (KeyInPlainText)
			{
				return _outer.BaseKey;
			}
			return new byte[0];
		}

		public void SetKey(byte[] key)
		{
			_outer.BaseKey = key;
			_keyName = null;
		}

		public void SetKeySize(int keySize, ICngSymmetricAlgorithm outer)
		{
			outer.BaseKeySize = keySize;
			_keyName = null;
		}

		public void GenerateKey()
		{
			byte[] key = new byte[0];
			SetKey(key);
		}

		public void GenerateIV()
		{
			byte[] iV = new byte[0];
			_outer.IV = iV;
		}

		private CngKey ProduceCngKey()
		{
			return CngSymmetricAlgorithmCore.zDzFmnBfJGcJIrAMzVVHTQnqOyKm(_keyName, _provider, _optionOptions);
		}

		static CngAlgorithm yuFtQkrulJLCUqpfYkrxwjFWCnCHA(CngKey cngKey_0)
		{
			return cngKey_0.Algorithm;
		}

		static int gSolTYINBFBBYZpXAhMVosSKDozJ(CngKey cngKey_0)
		{
			return cngKey_0.KeySize;
		}

		static void SFDEHGcjNRNtHFVZpmnqkeRqrwHDA(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		static CngKey zDzFmnBfJGcJIrAMzVVHTQnqOyKm(string string_0, CngProvider cngProvider_0, CngKeyOpenOptions cngKeyOpenOptions_0)
		{
			return CngKey.Open(string_0, cngProvider_0, cngKeyOpenOptions_0);
		}
	}

	public static bool smethod_0(ResolveEventArgs resolveEventArgs_0)
	{
		return Class2.mxODlYraEphcGlhyMwiGeeGnUSZe(Class2.kGuaItNntBQpBkOJWDPkcbZPIgXEA(resolveEventArgs_0), Class3.smethod_0());
	}

	static string kGuaItNntBQpBkOJWDPkcbZPIgXEA(ResolveEventArgs resolveEventArgs_0)
	{
		return resolveEventArgs_0.Name;
	}

	static bool mxODlYraEphcGlhyMwiGeeGnUSZe(string string_0, string string_1)
	{
		return string_0.Contains(string_1);
	}
}
