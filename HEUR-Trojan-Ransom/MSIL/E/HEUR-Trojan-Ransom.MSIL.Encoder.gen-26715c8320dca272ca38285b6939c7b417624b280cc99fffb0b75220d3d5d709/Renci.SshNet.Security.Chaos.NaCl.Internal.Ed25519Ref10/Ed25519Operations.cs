using System;

namespace Renci.SshNet.Security.Chaos.NaCl.Internal.Ed25519Ref10;

internal static class Ed25519Operations
{
	internal static void crypto_sign_keypair(byte[] pk, int pkoffset, byte[] sk, int skoffset, byte[] seed, int seedoffset)
	{
		Array.Copy(seed, seedoffset, sk, skoffset, 32);
		byte[] array = Sha512.Hash(sk, skoffset, 32);
		ScalarOperations.sc_clamp(array, 0);
		GroupOperations.ge_scalarmult_base(out var h, array, 0);
		GroupOperations.ge_p3_tobytes(pk, pkoffset, ref h);
		for (int i = 0; i < 32; i++)
		{
			sk[skoffset + 32 + i] = pk[pkoffset + i];
		}
		CryptoBytes.Wipe(array);
	}

	internal static bool crypto_sign_verify(byte[] sig, int sigoffset, byte[] m, int moffset, int mlen, byte[] pk, int pkoffset)
	{
		byte[] array = new byte[32];
		if ((sig[sigoffset + 63] & 0xE0u) != 0)
		{
			return false;
		}
		if (GroupOperations.ge_frombytes_negate_vartime(out var h, pk, pkoffset) != 0)
		{
			return false;
		}
		Sha512 sha = new Sha512();
		sha.Update(sig, sigoffset, 32);
		sha.Update(pk, pkoffset, 32);
		sha.Update(m, moffset, mlen);
		byte[] array2 = sha.Finish();
		ScalarOperations.sc_reduce(array2);
		byte[] array3 = new byte[32];
		Array.Copy(sig, sigoffset + 32, array3, 0, 32);
		GroupOperations.ge_double_scalarmult_vartime(out var r, array2, ref h, array3);
		GroupOperations.ge_tobytes(array, 0, ref r);
		bool result = CryptoBytes.ConstantTimeEquals(array, 0, sig, sigoffset, 32);
		CryptoBytes.Wipe(array2);
		CryptoBytes.Wipe(array);
		return result;
	}

	internal static void crypto_sign2(byte[] sig, int sigoffset, byte[] m, int moffset, int mlen, byte[] sk, int skoffset)
	{
		Sha512 sha = new Sha512();
		sha.Update(sk, skoffset, 32);
		byte[] array = sha.Finish();
		ScalarOperations.sc_clamp(array, 0);
		sha.Init();
		sha.Update(array, 32, 32);
		sha.Update(m, moffset, mlen);
		byte[] array2 = sha.Finish();
		ScalarOperations.sc_reduce(array2);
		GroupOperations.ge_scalarmult_base(out var h, array2, 0);
		GroupOperations.ge_p3_tobytes(sig, sigoffset, ref h);
		sha.Init();
		sha.Update(sig, sigoffset, 32);
		sha.Update(sk, skoffset + 32, 32);
		sha.Update(m, moffset, mlen);
		byte[] array3 = sha.Finish();
		ScalarOperations.sc_reduce(array3);
		byte[] array4 = new byte[32];
		Array.Copy(sig, sigoffset + 32, array4, 0, 32);
		ScalarOperations.sc_muladd(array4, array3, array, array2);
		Array.Copy(array4, 0, sig, sigoffset + 32, 32);
		CryptoBytes.Wipe(array4);
	}
}
