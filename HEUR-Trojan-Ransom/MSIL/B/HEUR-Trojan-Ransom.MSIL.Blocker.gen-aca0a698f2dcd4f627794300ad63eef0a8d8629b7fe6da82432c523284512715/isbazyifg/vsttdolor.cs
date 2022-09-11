using System;
using System.Reflection;
using lxpgdbqps;
using vpikmiohc;

namespace isbazyifg;

internal sealed class vsttdolor
{
	internal static void X(TypeInfo typeInfo_0)
	{
		((xuueaetns.drzxzkllj)Delegate.CreateDelegate(typeof(xuueaetns.drzxzkllj), typeInfo_0, "Main", ignoreCase: false, throwOnBindFailure: true))?.Invoke();
	}

	internal static bool H(byte[] byte_0, int int_0, int int_1, ref int int_2, ref int int_3)
	{
		if (zctqvosun.I > 0)
		{
			if (int_1 < zctqvosun.g - zctqvosun.I)
			{
				Buffer.BlockCopy(byte_0, int_0, zctqvosun.j, zctqvosun.I, int_1);
				zctqvosun.I += int_1;
				return true;
			}
			Buffer.BlockCopy(byte_0, int_0, zctqvosun.j, zctqvosun.I, zctqvosun.g - zctqvosun.I);
			int_2 += zctqvosun.g - zctqvosun.I;
			int_3 -= zctqvosun.g - zctqvosun.I;
			zctqvosun.I = zctqvosun.g;
		}
		if (zctqvosun.P > 0)
		{
			zctqvosun.D.Write(zctqvosun.W, 0, zctqvosun.P);
			zctqvosun.P = 0;
		}
		if (zctqvosun.I == zctqvosun.g)
		{
			zctqvosun.D.Write(zctqvosun.W, 0, zctqvosun.M.TransformBlock(zctqvosun.j, 0, zctqvosun.g, zctqvosun.W, 0));
			zctqvosun.I = 0;
		}
		return false;
	}
}
