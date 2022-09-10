using System;
using System.Runtime.InteropServices;

internal struct UQkCdRPdgdJMKUlIljivRBZeXTrm : IDisposable
{
	public uint sVbyWCmIyyGiYBhehIMKpLSwagtb;

	[MarshalAs(UnmanagedType.LPTStr)]
	public string DPfaxAgAMeXmGjxkvkisxIGzaLhv;

	public IntPtr iPtbqmdGafbEneKpMSPjgWOJJVWdb;

	public IntPtr fVwKWGXQeQMyHEGupEcOjviXHoYbA;

	public UQkCdRPdgdJMKUlIljivRBZeXTrm(string string_0, Guid guid_0)
	{
		sVbyWCmIyyGiYBhehIMKpLSwagtb = (uint)UQkCdRPdgdJMKUlIljivRBZeXTrm.uGctKzIvObJrZodRHcHhgjAUncADb(UQkCdRPdgdJMKUlIljivRBZeXTrm.hehKcXKAonXSIGxLBuAAocKGxHYl(typeof(UQkCdRPdgdJMKUlIljivRBZeXTrm).TypeHandle));
		DPfaxAgAMeXmGjxkvkisxIGzaLhv = string_0;
		if (guid_0 != Guid.Empty)
		{
			fVwKWGXQeQMyHEGupEcOjviXHoYbA = UQkCdRPdgdJMKUlIljivRBZeXTrm.ZVgNWvNeJpIzlmXfwsnlcMxFKoyF(UQkCdRPdgdJMKUlIljivRBZeXTrm.uGctKzIvObJrZodRHcHhgjAUncADb(UQkCdRPdgdJMKUlIljivRBZeXTrm.hehKcXKAonXSIGxLBuAAocKGxHYl(typeof(Guid).TypeHandle)));
			UQkCdRPdgdJMKUlIljivRBZeXTrm.ARzQIoifpImQrAcNaIwPflMiDAHdb((object)guid_0, fVwKWGXQeQMyHEGupEcOjviXHoYbA, (byte)_003CModule_003E.vCgetZRAfwOfXDFjqBKEQPxCexnFA<int>(137503599u) != 0);
		}
		else
		{
			fVwKWGXQeQMyHEGupEcOjviXHoYbA = IntPtr.Zero;
		}
		iPtbqmdGafbEneKpMSPjgWOJJVWdb = IntPtr.Zero;
	}

	public void Dispose()
	{
		yPehnkqyBlTibjcctKufoRogYsAy((byte)_003CModule_003E.oQGcPizWpTmKJWhqplvYaKxHcQrO<int>(3636103151u) != 0);
	}

	private void yPehnkqyBlTibjcctKufoRogYsAy(bool bool_0)
	{
		if (!(fVwKWGXQeQMyHEGupEcOjviXHoYbA != IntPtr.Zero))
		{
			return;
		}
		while (true)
		{
			int num = 842964280;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-947328635 - (num2 + 1539154527))) % 3u)
				{
				case 1u:
					goto IL_0014;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0014:
				UQkCdRPdgdJMKUlIljivRBZeXTrm.DzjoyIZpWZauefUTyRZqeQpgtnTL(fVwKWGXQeQMyHEGupEcOjviXHoYbA, UQkCdRPdgdJMKUlIljivRBZeXTrm.hehKcXKAonXSIGxLBuAAocKGxHYl(typeof(Guid).TypeHandle));
				UQkCdRPdgdJMKUlIljivRBZeXTrm.kApapWoreKleHFzmuDcXbmqtEpYl(fVwKWGXQeQMyHEGupEcOjviXHoYbA);
				num = (int)(num3 * 1912671336) ^ -1759909953;
			}
		}
	}

	static Type hehKcXKAonXSIGxLBuAAocKGxHYl(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static int uGctKzIvObJrZodRHcHhgjAUncADb(Type type_0)
	{
		return Marshal.SizeOf(type_0);
	}

	static IntPtr ZVgNWvNeJpIzlmXfwsnlcMxFKoyF(int int_0)
	{
		return Marshal.AllocHGlobal(int_0);
	}

	static void ARzQIoifpImQrAcNaIwPflMiDAHdb(object object_0, IntPtr intptr_0, bool bool_0)
	{
		Marshal.StructureToPtr(object_0, intptr_0, bool_0);
	}

	static void DzjoyIZpWZauefUTyRZqeQpgtnTL(IntPtr intptr_0, Type type_0)
	{
		Marshal.DestroyStructure(intptr_0, type_0);
	}

	static void kApapWoreKleHFzmuDcXbmqtEpYl(IntPtr intptr_0)
	{
		Marshal.FreeHGlobal(intptr_0);
	}
}
