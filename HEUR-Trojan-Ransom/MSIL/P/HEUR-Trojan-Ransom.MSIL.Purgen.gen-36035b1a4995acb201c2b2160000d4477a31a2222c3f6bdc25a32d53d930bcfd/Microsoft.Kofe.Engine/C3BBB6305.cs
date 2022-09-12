using System;
using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class C3BBB6305 : IDebugProperty3, IDebugProperty2
{
	private ADB5C0658 A8A757312;

	public C3BBB6305(ADB5C0658 vi)
	{
		A8A757312 = vi;
	}

	public DEBUG_PROPERTY_INFO C8A04EC89(enum_DEBUGPROP_INFO_FLAGS D53F2C28B)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		DEBUG_PROPERTY_INFO result = default(DEBUG_PROPERTY_INFO);
		if ((D53F2C28B & 1) != 0)
		{
			result.bstrFullName = A8A757312.E5CC7F130;
			ref enum_DEBUGPROP_INFO_FLAGS dwFields = ref result.dwFields;
			dwFields = (enum_DEBUGPROP_INFO_FLAGS)((uint)dwFields | 1u);
		}
		if ((D53F2C28B & 2) != 0)
		{
			result.bstrName = A8A757312.D39A1F445;
			ref enum_DEBUGPROP_INFO_FLAGS dwFields2 = ref result.dwFields;
			dwFields2 = (enum_DEBUGPROP_INFO_FLAGS)((uint)dwFields2 | 2u);
		}
		if ((D53F2C28B & 4) != 0)
		{
			result.bstrType = A8A757312.F32AC590E;
			ref enum_DEBUGPROP_INFO_FLAGS dwFields3 = ref result.dwFields;
			dwFields3 = (enum_DEBUGPROP_INFO_FLAGS)((uint)dwFields3 | 4u);
		}
		if ((D53F2C28B & 8) != 0 && A8A757312.FC3E9C6DA != null)
		{
			result.bstrValue = A8A757312.FC3E9C6DA.DisplayValue;
			ref enum_DEBUGPROP_INFO_FLAGS dwFields4 = ref result.dwFields;
			dwFields4 = (enum_DEBUGPROP_INFO_FLAGS)((uint)dwFields4 | 8u);
		}
		if ((D53F2C28B & 0x10) != 0)
		{
			ref enum_DBG_ATTRIB_FLAGS dwAttrib = ref result.dwAttrib;
			dwAttrib = (enum_DBG_ATTRIB_FLAGS)((ulong)dwAttrib | 0x10uL);
			if (A8A757312.F2670EC3C)
			{
				ref enum_DBG_ATTRIB_FLAGS dwAttrib2 = ref result.dwAttrib;
				dwAttrib2 = (enum_DBG_ATTRIB_FLAGS)((ulong)dwAttrib2 | 1uL);
			}
			if (A8A757312.FC3E9C6DA is F34C80160)
			{
				ref enum_DBG_ATTRIB_FLAGS dwAttrib3 = ref result.dwAttrib;
				dwAttrib3 = (enum_DBG_ATTRIB_FLAGS)((ulong)dwAttrib3 | 0x4000uL);
			}
			if (A8A757312 is F8EDDC856)
			{
				F8EDDC856 obj = (F8EDDC856)A8A757312;
				if (((uint)obj.CCC12947E.get_Modifiers() & 8u) != 0)
				{
					ref enum_DBG_ATTRIB_FLAGS dwAttrib4 = ref result.dwAttrib;
					dwAttrib4 = (enum_DBG_ATTRIB_FLAGS)((ulong)dwAttrib4 | 0x4000000uL);
				}
				if (((uint)obj.CCC12947E.get_Modifiers() & 2u) != 0)
				{
					ref enum_DBG_ATTRIB_FLAGS dwAttrib5 = ref result.dwAttrib;
					dwAttrib5 = (enum_DBG_ATTRIB_FLAGS)((ulong)dwAttrib5 | 0x40000uL);
				}
				if (((uint)obj.CCC12947E.get_Modifiers() & (true ? 1u : 0u)) != 0)
				{
					ref enum_DBG_ATTRIB_FLAGS dwAttrib6 = ref result.dwAttrib;
					dwAttrib6 = (enum_DBG_ATTRIB_FLAGS)((ulong)dwAttrib6 | 0x20000uL);
				}
				if (((uint)obj.CCC12947E.get_Modifiers() & 4u) != 0)
				{
					ref enum_DBG_ATTRIB_FLAGS dwAttrib7 = ref result.dwAttrib;
					dwAttrib7 = (enum_DBG_ATTRIB_FLAGS)((ulong)dwAttrib7 | 0x80000uL);
				}
				if (((uint)obj.CCC12947E.get_Modifiers() & 0x40u) != 0)
				{
					ref enum_DBG_ATTRIB_FLAGS dwAttrib8 = ref result.dwAttrib;
					dwAttrib8 = (enum_DBG_ATTRIB_FLAGS)((ulong)dwAttrib8 | 0x1000000000uL);
				}
			}
		}
		if ((D53F2C28B & 0x20) != 0 || A8A757312.F2670EC3C || A8A757312.FC3E9C6DA is F34C80160)
		{
			result.pProperty = (IDebugProperty2)(object)this;
			ref enum_DEBUGPROP_INFO_FLAGS dwFields5 = ref result.dwFields;
			dwFields5 = (enum_DEBUGPROP_INFO_FLAGS)((uint)dwFields5 | 0x20u);
		}
		return result;
	}

	public int C273D335B()
	{
		throw new NotImplementedException();
	}

	public int A381A3672()
	{
		throw new NotImplementedException();
	}

	public int FFF664332(enum_DEBUGPROP_INFO_FLAGS A2A2F3750, uint BD8F52C06, ref Guid B50A20A47, enum_DBG_ATTRIB_FLAGS B6ECD3A1D, string C3D675EBB, uint B395A6E48, out IEnumDebugPropertyInfo2 EB1CCEADF)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		EB1CCEADF = null;
		if (A8A757312.F2670EC3C)
		{
			ADB5C0658[] array = A8A757312.CF4481569();
			DEBUG_PROPERTY_INFO[] array2 = (DEBUG_PROPERTY_INFO[])(object)new DEBUG_PROPERTY_INFO[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = new C3BBB6305(array[i]).C8A04EC89(A2A2F3750);
			}
			EB1CCEADF = (IEnumDebugPropertyInfo2)(object)new CE44A9496(array2);
			return 0;
		}
		return 1;
	}

	public int CD26C0D49(out uint CAB0F2870)
	{
		CAB0F2870 = 0u;
		return 0;
	}

	public int A78024798(uint EB770AA93, uint CEE5C4556, DEBUG_CUSTOM_VIEWER[] F8698E673, out uint ACBEC2532)
	{
		throw new NotImplementedException();
	}

	public int B55B3FE7A(out IDebugProperty2 B49B37A34)
	{
		throw new NotImplementedException();
	}

	public int D92EBCFB8(ref Guid C182A6D91, out object FC9BAD2C1)
	{
		throw new NotImplementedException();
	}

	public int BD040DACA(out IDebugMemoryBytes2 C2A086B47)
	{
		throw new NotImplementedException();
	}

	public int E79040A12(out IDebugMemoryContext2 AB490C17A)
	{
		AB490C17A = null;
		return 263521;
	}

	public int CF919D384(out IDebugProperty2 D82BCA1C4)
	{
		throw new NotImplementedException();
	}

	public int FE82BC1F9(enum_DEBUGPROP_INFO_FLAGS A7F77F362, uint DBF28F399, uint ADB96F8A6, IDebugReference2[] F2F0063DA, uint BA832999B, DEBUG_PROPERTY_INFO[] DCAFFD974)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		DCAFFD974[0] = default(DEBUG_PROPERTY_INFO);
		F2F0063DA = null;
		DCAFFD974[0] = C8A04EC89(A7F77F362);
		return 0;
	}

	public int F7A51F584(out IDebugReference2 D578CE034)
	{
		throw new NotImplementedException();
	}

	public int D36C778F1(out uint FF1B1235C)
	{
		throw new NotImplementedException();
	}

	public int EB6BD811B(out uint B139C93AB)
	{
		if (!(A8A757312.FC3E9C6DA is F34C80160 f34C) || f34C.C0C405351 == null)
		{
			B139C93AB = 0u;
			return -2147467259;
		}
		B139C93AB = (uint)f34C.C0C405351.Length;
		return 0;
	}

	public int AF885C36C(uint E0EC68FF6, ushort[] E39F21316, out uint C66741B24)
	{
		if (!(A8A757312.FC3E9C6DA is F34C80160 f34C) || f34C.C0C405351 == null)
		{
			C66741B24 = 0u;
			return -2147467259;
		}
		int num = f34C.C0C405351.Length;
		for (C66741B24 = 0u; C66741B24 < Math.Min(num, E0EC68FF6); C66741B24++)
		{
			E39F21316[C66741B24] = f34C.C0C405351[C66741B24];
		}
		return 0;
	}

	public int BB4CE4AF9(IDebugReference2[] EF041635B, uint E8D296644, IDebugReference2 FCB1C71A6, uint C43E31D3F)
	{
		throw new NotImplementedException();
	}

	public int AFAB00D0E(string EEAFC2AF7, uint A6B0F894F, uint FFF5B522E)
	{
		throw new NotImplementedException();
	}

	public int EDB38A694(string C0AEA0516, uint F4395FD53, uint CB475F63A, out string B93191262)
	{
		throw new NotImplementedException();
	}
}
