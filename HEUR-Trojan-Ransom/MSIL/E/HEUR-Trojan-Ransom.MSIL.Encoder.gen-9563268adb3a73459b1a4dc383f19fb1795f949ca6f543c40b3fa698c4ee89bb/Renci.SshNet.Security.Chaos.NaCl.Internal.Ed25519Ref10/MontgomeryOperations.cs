namespace Renci.SshNet.Security.Chaos.NaCl.Internal.Ed25519Ref10;

internal static class MontgomeryOperations
{
	internal static void scalarmult(byte[] q, int qoffset, byte[] n, int noffset, byte[] p, int poffset)
	{
		FieldOperations.fe_frombytes2(out var h, p, poffset);
		scalarmult(out var q2, n, noffset, ref h);
		FieldOperations.fe_tobytes(q, qoffset, ref q2);
	}

	internal static void scalarmult(out FieldElement q, byte[] n, int noffset, ref FieldElement p)
	{
		byte[] array = new byte[32];
		for (uint num = 0u; num < 32; num++)
		{
			array[num] = n[noffset + num];
		}
		ScalarOperations.sc_clamp(array, 0);
		FieldElement f = p;
		FieldOperations.fe_1(out var h);
		FieldOperations.fe_0(out var h2);
		FieldElement g = f;
		FieldOperations.fe_1(out var h3);
		uint num2 = 0u;
		for (int num3 = 254; num3 >= 0; num3--)
		{
			uint num4 = (uint)(array[num3 / 8] >> (num3 & 7));
			num4 &= 1u;
			num2 ^= num4;
			FieldOperations.fe_cswap(ref h, ref g, num2);
			FieldOperations.fe_cswap(ref h2, ref h3, num2);
			num2 = num4;
			FieldOperations.fe_sub(out var h4, ref g, ref h3);
			FieldOperations.fe_sub(out var h5, ref h, ref h2);
			FieldOperations.fe_add(out h, ref h, ref h2);
			FieldOperations.fe_add(out h2, ref g, ref h3);
			FieldOperations.fe_mul(out h3, ref h4, ref h);
			FieldOperations.fe_mul(out h2, ref h2, ref h5);
			FieldOperations.fe_sq(out h4, ref h5);
			FieldOperations.fe_sq(out h5, ref h);
			FieldOperations.fe_add(out g, ref h3, ref h2);
			FieldOperations.fe_sub(out h2, ref h3, ref h2);
			FieldOperations.fe_mul(out h, ref h5, ref h4);
			FieldOperations.fe_sub(out h5, ref h5, ref h4);
			FieldOperations.fe_sq(out h2, ref h2);
			FieldOperations.fe_mul121666(out h3, ref h5);
			FieldOperations.fe_sq(out g, ref g);
			FieldOperations.fe_add(out h4, ref h4, ref h3);
			FieldOperations.fe_mul(out h3, ref f, ref h2);
			FieldOperations.fe_mul(out h2, ref h5, ref h4);
		}
		FieldOperations.fe_cswap(ref h, ref g, num2);
		FieldOperations.fe_cswap(ref h2, ref h3, num2);
		FieldOperations.fe_invert(out h2, ref h2);
		FieldOperations.fe_mul(out h, ref h, ref h2);
		q = h;
		CryptoBytes.Wipe(array);
	}
}
