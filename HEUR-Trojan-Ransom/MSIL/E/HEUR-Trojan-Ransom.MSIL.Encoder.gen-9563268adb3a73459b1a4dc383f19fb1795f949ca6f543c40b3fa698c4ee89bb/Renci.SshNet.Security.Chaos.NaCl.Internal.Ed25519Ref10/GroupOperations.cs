namespace Renci.SshNet.Security.Chaos.NaCl.Internal.Ed25519Ref10;

internal static class GroupOperations
{
	internal static void ge_add(out GroupElementP1P1 r, ref GroupElementP3 p, ref GroupElementCached q)
	{
		FieldOperations.fe_add(out r.X, ref p.Y, ref p.X);
		FieldOperations.fe_sub(out r.Y, ref p.Y, ref p.X);
		FieldOperations.fe_mul(out r.Z, ref r.X, ref q.YplusX);
		FieldOperations.fe_mul(out r.Y, ref r.Y, ref q.YminusX);
		FieldOperations.fe_mul(out r.T, ref q.T2d, ref p.T);
		FieldOperations.fe_mul(out r.X, ref p.Z, ref q.Z);
		FieldOperations.fe_add(out var h, ref r.X, ref r.X);
		FieldOperations.fe_sub(out r.X, ref r.Z, ref r.Y);
		FieldOperations.fe_add(out r.Y, ref r.Z, ref r.Y);
		FieldOperations.fe_add(out r.Z, ref h, ref r.T);
		FieldOperations.fe_sub(out r.T, ref h, ref r.T);
	}

	private static void slide(sbyte[] r, byte[] a)
	{
		for (int i = 0; i < 256; i++)
		{
			r[i] = (sbyte)(1 & (a[i >> 3] >> (i & 7)));
		}
		for (int i = 0; i < 256; i++)
		{
			if (r[i] == 0)
			{
				continue;
			}
			for (int j = 1; j <= 6 && i + j < 256; j++)
			{
				if (r[i + j] == 0)
				{
					continue;
				}
				if (r[i] + (r[i + j] << j) <= 15)
				{
					r[i] += (sbyte)(r[i + j] << j);
					r[i + j] = 0;
					continue;
				}
				if (r[i] - (r[i + j] << j) < -15)
				{
					break;
				}
				r[i] -= (sbyte)(r[i + j] << j);
				for (int k = i + j; k < 256; k++)
				{
					if (r[k] != 0)
					{
						r[k] = 0;
						continue;
					}
					r[k] = 1;
					break;
				}
			}
		}
	}

	internal static void ge_double_scalarmult_vartime(out GroupElementP2 r, byte[] a, ref GroupElementP3 A, byte[] b)
	{
		GroupElementPreComp[] @base = LookupTables.Base2;
		sbyte[] array = new sbyte[256];
		sbyte[] array2 = new sbyte[256];
		GroupElementCached[] array3 = new GroupElementCached[8];
		slide(array, a);
		slide(array2, b);
		ge_p3_to_cached(out array3[0], ref A);
		ge_p3_dbl(out var r2, ref A);
		ge_p1p1_to_p3(out var r3, ref r2);
		ge_add(out r2, ref r3, ref array3[0]);
		ge_p1p1_to_p3(out var r4, ref r2);
		ge_p3_to_cached(out array3[1], ref r4);
		ge_add(out r2, ref r3, ref array3[1]);
		ge_p1p1_to_p3(out r4, ref r2);
		ge_p3_to_cached(out array3[2], ref r4);
		ge_add(out r2, ref r3, ref array3[2]);
		ge_p1p1_to_p3(out r4, ref r2);
		ge_p3_to_cached(out array3[3], ref r4);
		ge_add(out r2, ref r3, ref array3[3]);
		ge_p1p1_to_p3(out r4, ref r2);
		ge_p3_to_cached(out array3[4], ref r4);
		ge_add(out r2, ref r3, ref array3[4]);
		ge_p1p1_to_p3(out r4, ref r2);
		ge_p3_to_cached(out array3[5], ref r4);
		ge_add(out r2, ref r3, ref array3[5]);
		ge_p1p1_to_p3(out r4, ref r2);
		ge_p3_to_cached(out array3[6], ref r4);
		ge_add(out r2, ref r3, ref array3[6]);
		ge_p1p1_to_p3(out r4, ref r2);
		ge_p3_to_cached(out array3[7], ref r4);
		ge_p2_0(out r);
		int num = 255;
		while (num >= 0 && array[num] == 0 && array2[num] == 0)
		{
			num--;
		}
		while (num >= 0)
		{
			ge_p2_dbl(out r2, ref r);
			if (array[num] > 0)
			{
				ge_p1p1_to_p3(out r4, ref r2);
				ge_add(out r2, ref r4, ref array3[array[num] / 2]);
			}
			else if (array[num] < 0)
			{
				ge_p1p1_to_p3(out r4, ref r2);
				ge_sub(out r2, ref r4, ref array3[-array[num] / 2]);
			}
			if (array2[num] > 0)
			{
				ge_p1p1_to_p3(out r4, ref r2);
				ge_madd(out r2, ref r4, ref @base[array2[num] / 2]);
			}
			else if (array2[num] < 0)
			{
				ge_p1p1_to_p3(out r4, ref r2);
				ge_msub(out r2, ref r4, ref @base[-array2[num] / 2]);
			}
			ge_p1p1_to_p2(out r, ref r2);
			num--;
		}
	}

	internal static int ge_frombytes_negate_vartime(out GroupElementP3 h, byte[] data, int offset)
	{
		FieldOperations.fe_frombytes(out h.Y, data, offset);
		FieldOperations.fe_1(out h.Z);
		FieldOperations.fe_sq(out var h2, ref h.Y);
		FieldOperations.fe_mul(out var h3, ref h2, ref LookupTables.d);
		FieldOperations.fe_sub(out h2, ref h2, ref h.Z);
		FieldOperations.fe_add(out h3, ref h3, ref h.Z);
		FieldOperations.fe_sq(out var h4, ref h3);
		FieldOperations.fe_mul(out h4, ref h4, ref h3);
		FieldOperations.fe_sq(out h.X, ref h4);
		FieldOperations.fe_mul(out h.X, ref h.X, ref h3);
		FieldOperations.fe_mul(out h.X, ref h.X, ref h2);
		FieldOperations.fe_pow22523(out h.X, ref h.X);
		FieldOperations.fe_mul(out h.X, ref h.X, ref h4);
		FieldOperations.fe_mul(out h.X, ref h.X, ref h2);
		FieldOperations.fe_sq(out var h5, ref h.X);
		FieldOperations.fe_mul(out h5, ref h5, ref h3);
		FieldOperations.fe_sub(out var h6, ref h5, ref h2);
		if (FieldOperations.fe_isnonzero(ref h6) != 0)
		{
			FieldOperations.fe_add(out h6, ref h5, ref h2);
			if (FieldOperations.fe_isnonzero(ref h6) != 0)
			{
				h = default(GroupElementP3);
				return -1;
			}
			FieldOperations.fe_mul(out h.X, ref h.X, ref LookupTables.sqrtm1);
		}
		if (FieldOperations.fe_isnegative(ref h.X) == data[offset + 31] >> 7)
		{
			FieldOperations.fe_neg(out h.X, ref h.X);
		}
		FieldOperations.fe_mul(out h.T, ref h.X, ref h.Y);
		return 0;
	}

	internal static void ge_madd(out GroupElementP1P1 r, ref GroupElementP3 p, ref GroupElementPreComp q)
	{
		FieldOperations.fe_add(out r.X, ref p.Y, ref p.X);
		FieldOperations.fe_sub(out r.Y, ref p.Y, ref p.X);
		FieldOperations.fe_mul(out r.Z, ref r.X, ref q.yplusx);
		FieldOperations.fe_mul(out r.Y, ref r.Y, ref q.yminusx);
		FieldOperations.fe_mul(out r.T, ref q.xy2d, ref p.T);
		FieldOperations.fe_add(out var h, ref p.Z, ref p.Z);
		FieldOperations.fe_sub(out r.X, ref r.Z, ref r.Y);
		FieldOperations.fe_add(out r.Y, ref r.Z, ref r.Y);
		FieldOperations.fe_add(out r.Z, ref h, ref r.T);
		FieldOperations.fe_sub(out r.T, ref h, ref r.T);
	}

	internal static void ge_msub(out GroupElementP1P1 r, ref GroupElementP3 p, ref GroupElementPreComp q)
	{
		FieldOperations.fe_add(out r.X, ref p.Y, ref p.X);
		FieldOperations.fe_sub(out r.Y, ref p.Y, ref p.X);
		FieldOperations.fe_mul(out r.Z, ref r.X, ref q.yminusx);
		FieldOperations.fe_mul(out r.Y, ref r.Y, ref q.yplusx);
		FieldOperations.fe_mul(out r.T, ref q.xy2d, ref p.T);
		FieldOperations.fe_add(out var h, ref p.Z, ref p.Z);
		FieldOperations.fe_sub(out r.X, ref r.Z, ref r.Y);
		FieldOperations.fe_add(out r.Y, ref r.Z, ref r.Y);
		FieldOperations.fe_sub(out r.Z, ref h, ref r.T);
		FieldOperations.fe_add(out r.T, ref h, ref r.T);
	}

	internal static void ge_p1p1_to_p2(out GroupElementP2 r, ref GroupElementP1P1 p)
	{
		FieldOperations.fe_mul(out r.X, ref p.X, ref p.T);
		FieldOperations.fe_mul(out r.Y, ref p.Y, ref p.Z);
		FieldOperations.fe_mul(out r.Z, ref p.Z, ref p.T);
	}

	internal static void ge_p1p1_to_p3(out GroupElementP3 r, ref GroupElementP1P1 p)
	{
		FieldOperations.fe_mul(out r.X, ref p.X, ref p.T);
		FieldOperations.fe_mul(out r.Y, ref p.Y, ref p.Z);
		FieldOperations.fe_mul(out r.Z, ref p.Z, ref p.T);
		FieldOperations.fe_mul(out r.T, ref p.X, ref p.Y);
	}

	internal static void ge_p2_0(out GroupElementP2 h)
	{
		FieldOperations.fe_0(out h.X);
		FieldOperations.fe_1(out h.Y);
		FieldOperations.fe_1(out h.Z);
	}

	internal static void ge_p2_dbl(out GroupElementP1P1 r, ref GroupElementP2 p)
	{
		FieldOperations.fe_sq(out r.X, ref p.X);
		FieldOperations.fe_sq(out r.Z, ref p.Y);
		FieldOperations.fe_sq2(out r.T, ref p.Z);
		FieldOperations.fe_add(out r.Y, ref p.X, ref p.Y);
		FieldOperations.fe_sq(out var h, ref r.Y);
		FieldOperations.fe_add(out r.Y, ref r.Z, ref r.X);
		FieldOperations.fe_sub(out r.Z, ref r.Z, ref r.X);
		FieldOperations.fe_sub(out r.X, ref h, ref r.Y);
		FieldOperations.fe_sub(out r.T, ref r.T, ref r.Z);
	}

	internal static void ge_p3_0(out GroupElementP3 h)
	{
		FieldOperations.fe_0(out h.X);
		FieldOperations.fe_1(out h.Y);
		FieldOperations.fe_1(out h.Z);
		FieldOperations.fe_0(out h.T);
	}

	internal static void ge_p3_dbl(out GroupElementP1P1 r, ref GroupElementP3 p)
	{
		ge_p3_to_p2(out var r2, ref p);
		ge_p2_dbl(out r, ref r2);
	}

	internal static void ge_p3_tobytes(byte[] s, int offset, ref GroupElementP3 h)
	{
		FieldOperations.fe_invert(out var result, ref h.Z);
		FieldOperations.fe_mul(out var h2, ref h.X, ref result);
		FieldOperations.fe_mul(out var h3, ref h.Y, ref result);
		FieldOperations.fe_tobytes(s, offset, ref h3);
		s[offset + 31] ^= (byte)(FieldOperations.fe_isnegative(ref h2) << 7);
	}

	internal static void ge_p3_to_cached(out GroupElementCached r, ref GroupElementP3 p)
	{
		FieldOperations.fe_add(out r.YplusX, ref p.Y, ref p.X);
		FieldOperations.fe_sub(out r.YminusX, ref p.Y, ref p.X);
		r.Z = p.Z;
		FieldOperations.fe_mul(out r.T2d, ref p.T, ref LookupTables.d2);
	}

	internal static void ge_p3_to_p2(out GroupElementP2 r, ref GroupElementP3 p)
	{
		r.X = p.X;
		r.Y = p.Y;
		r.Z = p.Z;
	}

	internal static void ge_precomp_0(out GroupElementPreComp h)
	{
		FieldOperations.fe_1(out h.yplusx);
		FieldOperations.fe_1(out h.yminusx);
		FieldOperations.fe_0(out h.xy2d);
	}

	private static byte equal(byte b, byte c)
	{
		byte b2 = c;
		return (byte)((uint)((byte)(b ^ b2) - 1) >> 31);
	}

	private static byte negative(sbyte b)
	{
		return (byte)((ulong)b >> 63);
	}

	private static void cmov(ref GroupElementPreComp t, ref GroupElementPreComp u, byte b)
	{
		FieldOperations.fe_cmov(ref t.yplusx, ref u.yplusx, b);
		FieldOperations.fe_cmov(ref t.yminusx, ref u.yminusx, b);
		FieldOperations.fe_cmov(ref t.xy2d, ref u.xy2d, b);
	}

	private static void select(out GroupElementPreComp t, int pos, sbyte b)
	{
		byte b2 = negative(b);
		byte b3 = (byte)(b - ((-b2 & b) << 1));
		ge_precomp_0(out t);
		GroupElementPreComp[] array = LookupTables.Base[pos];
		cmov(ref t, ref array[0], equal(b3, 1));
		cmov(ref t, ref array[1], equal(b3, 2));
		cmov(ref t, ref array[2], equal(b3, 3));
		cmov(ref t, ref array[3], equal(b3, 4));
		cmov(ref t, ref array[4], equal(b3, 5));
		cmov(ref t, ref array[5], equal(b3, 6));
		cmov(ref t, ref array[6], equal(b3, 7));
		cmov(ref t, ref array[7], equal(b3, 8));
		GroupElementPreComp u = default(GroupElementPreComp);
		u.yplusx = t.yminusx;
		u.yminusx = t.yplusx;
		FieldOperations.fe_neg(out u.xy2d, ref t.xy2d);
		cmov(ref t, ref u, b2);
	}

	internal static void ge_scalarmult_base(out GroupElementP3 h, byte[] a, int offset)
	{
		sbyte[] array = new sbyte[64];
		for (int i = 0; i < 32; i++)
		{
			array[2 * i] = (sbyte)(a[offset + i] & 0xF);
			array[2 * i + 1] = (sbyte)((a[offset + i] >> 4) & 0xF);
		}
		sbyte b = 0;
		for (int i = 0; i < 63; i++)
		{
			array[i] += b;
			b = (sbyte)(array[i] + 8);
			b = (sbyte)(b >> 4);
			array[i] -= (sbyte)(b << 4);
		}
		array[63] += b;
		ge_p3_0(out h);
		GroupElementPreComp q;
		GroupElementP1P1 r;
		for (int i = 1; i < 64; i += 2)
		{
			select(out q, i / 2, array[i]);
			ge_madd(out r, ref h, ref q);
			ge_p1p1_to_p3(out h, ref r);
		}
		ge_p3_dbl(out r, ref h);
		ge_p1p1_to_p2(out var r2, ref r);
		ge_p2_dbl(out r, ref r2);
		ge_p1p1_to_p2(out r2, ref r);
		ge_p2_dbl(out r, ref r2);
		ge_p1p1_to_p2(out r2, ref r);
		ge_p2_dbl(out r, ref r2);
		ge_p1p1_to_p3(out h, ref r);
		for (int i = 0; i < 64; i += 2)
		{
			select(out q, i / 2, array[i]);
			ge_madd(out r, ref h, ref q);
			ge_p1p1_to_p3(out h, ref r);
		}
	}

	internal static void ge_sub(out GroupElementP1P1 r, ref GroupElementP3 p, ref GroupElementCached q)
	{
		FieldOperations.fe_add(out r.X, ref p.Y, ref p.X);
		FieldOperations.fe_sub(out r.Y, ref p.Y, ref p.X);
		FieldOperations.fe_mul(out r.Z, ref r.X, ref q.YminusX);
		FieldOperations.fe_mul(out r.Y, ref r.Y, ref q.YplusX);
		FieldOperations.fe_mul(out r.T, ref q.T2d, ref p.T);
		FieldOperations.fe_mul(out r.X, ref p.Z, ref q.Z);
		FieldOperations.fe_add(out var h, ref r.X, ref r.X);
		FieldOperations.fe_sub(out r.X, ref r.Z, ref r.Y);
		FieldOperations.fe_add(out r.Y, ref r.Z, ref r.Y);
		FieldOperations.fe_sub(out r.Z, ref h, ref r.T);
		FieldOperations.fe_add(out r.T, ref h, ref r.T);
	}

	internal static void ge_tobytes(byte[] s, int offset, ref GroupElementP2 h)
	{
		FieldOperations.fe_invert(out var result, ref h.Z);
		FieldOperations.fe_mul(out var h2, ref h.X, ref result);
		FieldOperations.fe_mul(out var h3, ref h.Y, ref result);
		FieldOperations.fe_tobytes(s, offset, ref h3);
		s[offset + 31] ^= (byte)(FieldOperations.fe_isnegative(ref h2) << 7);
	}
}
