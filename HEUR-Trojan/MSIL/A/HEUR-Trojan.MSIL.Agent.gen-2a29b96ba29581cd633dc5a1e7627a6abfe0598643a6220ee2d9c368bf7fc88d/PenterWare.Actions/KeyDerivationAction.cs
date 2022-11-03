using System;
using System.Collections.Generic;
using PenterWare.Actions.Results;
using PenterWare.Crypt.CipherProviders;
using PenterWare.Utils;

namespace PenterWare.Actions;

internal class KeyDerivationAction : BaseAction<KeyDerivationResult>
{
	public static string Name = "KeyDerivation";

	private Dictionary<string, string> cryptoNameToLibrary = new Dictionary<string, string>
	{
		{ "Salsa20", "PenterWare.Crypt.EncryptionAlgorithms.Salsa20" },
		{ "RijndaelManaged", "System.Security.Cryptography.RijndaelManaged" }
	};

	public override string ActionName => Name;

	protected override void Run()
	{
		CipherProvider cipherProvider2 = (RunRegistry.Cipher = GenerateCrypto());
		if (cipherProvider2 == null)
		{
			throw new Exception("Invalid cipher");
		}
		byte[] key = cipherProvider2.GetKey();
		base.Result.KeyBase64 = Convert.ToBase64String(key);
		base.Result.SymmetricAlgorithm = ResourceData.SymmetricAlgorithm;
		base.Result.AsymmetricAlgorithm = ResourceData.AsymmetricAlgorithm;
	}

	protected CipherProvider GenerateCrypto()
	{
		string text = "";
		if (!cryptoNameToLibrary.ContainsKey(ResourceData.SymmetricAlgorithm))
		{
			return null;
		}
		text = cryptoNameToLibrary[ResourceData.SymmetricAlgorithm];
		Type typeFromHandle = typeof(SymmetricCipher<>);
		Type[] typeArguments = new Type[1] { Type.GetType(text) };
		return Activator.CreateInstance(typeFromHandle.MakeGenericType(typeArguments)) as CipherProvider;
	}
}
