using System;
using System.Runtime.InteropServices;

internal struct jRwCzurTFUmFrpvyZHLqrQuCDIUW : IDisposable
{
	public uint HWdNftGKtZJKZeJZNbjNFAoSbFZl;

	[MarshalAs(UnmanagedType.LPTStr)]
	public string oOdAoxIjdHpoxGwYVPwpTMxVAdWL;

	public IntPtr VOhuPLkkBAdDQKlNwkswcczdOYbdA;

	public IntPtr QUkDzbtMHvIrmpRGJwDLXYPhmvls;

	public jRwCzurTFUmFrpvyZHLqrQuCDIUW(string string_0, Guid guid_0)
	{
		HWdNftGKtZJKZeJZNbjNFAoSbFZl = (uint)jRwCzurTFUmFrpvyZHLqrQuCDIUW.eQxAqHgvkpBRpgaJhAjVdxPhHlcCc(jRwCzurTFUmFrpvyZHLqrQuCDIUW.NIqfUTEUwqdLHthsXYHbjQMLilhz(typeof(jRwCzurTFUmFrpvyZHLqrQuCDIUW).TypeHandle));
		oOdAoxIjdHpoxGwYVPwpTMxVAdWL = string_0;
		if (guid_0 != Guid.Empty)
		{
			QUkDzbtMHvIrmpRGJwDLXYPhmvls = jRwCzurTFUmFrpvyZHLqrQuCDIUW.sJjreUECcJldlVVvtCGuOgOugYaDA(jRwCzurTFUmFrpvyZHLqrQuCDIUW.eQxAqHgvkpBRpgaJhAjVdxPhHlcCc(jRwCzurTFUmFrpvyZHLqrQuCDIUW.NIqfUTEUwqdLHthsXYHbjQMLilhz(typeof(Guid).TypeHandle)));
			jRwCzurTFUmFrpvyZHLqrQuCDIUW.gZuIDOtAqfuioNEVTQuUAGdYeGRr((object)guid_0, QUkDzbtMHvIrmpRGJwDLXYPhmvls, (byte)_003CModule_003E.InSeajbqYmMBLFjcDEnfkUXlgyLtB<int>(3933008549u) != 0);
		}
		else
		{
			QUkDzbtMHvIrmpRGJwDLXYPhmvls = IntPtr.Zero;
		}
		VOhuPLkkBAdDQKlNwkswcczdOYbdA = IntPtr.Zero;
	}

	public void Dispose()
	{
		LpcQbBEuqQQtMGbGRDksKFPKkzjN((byte)_003CModule_003E.dpxHirlQuRSzbXiBGQArohLuCnMj<int>(3943964843u) != 0);
	}

	private void LpcQbBEuqQQtMGbGRDksKFPKkzjN(bool bool_0)
	{
		if (!(QUkDzbtMHvIrmpRGJwDLXYPhmvls != IntPtr.Zero))
		{
			return;
		}
		while (true)
		{
			int num = 1605391347;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(~((num2 * -851950461) ^ -689899418) + -1058971106))) % 4u)
				{
				case 2u:
					jRwCzurTFUmFrpvyZHLqrQuCDIUW.CEZOmfdPhpGbTLtkrBxaACyBOyDPA(QUkDzbtMHvIrmpRGJwDLXYPhmvls);
					num = (int)(num3 * 1884509400) ^ -864758583;
					continue;
				case 1u:
					jRwCzurTFUmFrpvyZHLqrQuCDIUW.JLWuRWQAFYijudRvAOzVwqjePEKt(QUkDzbtMHvIrmpRGJwDLXYPhmvls, jRwCzurTFUmFrpvyZHLqrQuCDIUW.NIqfUTEUwqdLHthsXYHbjQMLilhz(typeof(Guid).TypeHandle));
					num = (int)(num3 * 2101897730) ^ -11608420;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	static Type NIqfUTEUwqdLHthsXYHbjQMLilhz(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static int eQxAqHgvkpBRpgaJhAjVdxPhHlcCc(Type type_0)
	{
		return Marshal.SizeOf(type_0);
	}

	static IntPtr sJjreUECcJldlVVvtCGuOgOugYaDA(int int_0)
	{
		return Marshal.AllocHGlobal(int_0);
	}

	static void gZuIDOtAqfuioNEVTQuUAGdYeGRr(object object_0, IntPtr intptr_0, bool bool_0)
	{
		Marshal.StructureToPtr(object_0, intptr_0, bool_0);
	}

	static void JLWuRWQAFYijudRvAOzVwqjePEKt(IntPtr intptr_0, Type type_0)
	{
		Marshal.DestroyStructure(intptr_0, type_0);
	}

	static void CEZOmfdPhpGbTLtkrBxaACyBOyDPA(IntPtr intptr_0)
	{
		Marshal.FreeHGlobal(intptr_0);
	}
}
