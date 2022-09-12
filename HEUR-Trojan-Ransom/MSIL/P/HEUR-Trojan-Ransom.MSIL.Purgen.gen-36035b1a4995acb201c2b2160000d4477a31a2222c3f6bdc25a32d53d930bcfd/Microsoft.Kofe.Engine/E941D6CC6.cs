using System;
using Microsoft.Kofe.IJDWP;
using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class E941D6CC6 : IDebugModule2, IDebugModule3
{
	public readonly IJdwpClass A1F5DE617;

	public E941D6CC6(IJdwpClass module)
	{
		A1F5DE617 = module;
	}

	private int B455A4E1B(enum_MODULE_INFO_FIELDS A85EBF78A, MODULE_INFO[] A3AD27B84)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		try
		{
			MODULE_INFO val = default(MODULE_INFO);
			if ((A85EBF78A & 1) != 0)
			{
				val.m_bstrName = A1F5DE617.get_Name();
				ref enum_MODULE_INFO_FIELDS dwValidFields = ref val.dwValidFields;
				dwValidFields = (enum_MODULE_INFO_FIELDS)((uint)dwValidFields | 1u);
			}
			if ((A85EBF78A & 2) != 0)
			{
				val.m_bstrUrl = A1F5DE617.get_Name();
				ref enum_MODULE_INFO_FIELDS dwValidFields2 = ref val.dwValidFields;
				dwValidFields2 = (enum_MODULE_INFO_FIELDS)((uint)dwValidFields2 | 2u);
			}
			if ((A85EBF78A & 0x10) != 0)
			{
				val.m_addrLoadAddress = A1F5DE617.get_BaseAddress();
				ref enum_MODULE_INFO_FIELDS dwValidFields3 = ref val.dwValidFields;
				dwValidFields3 = (enum_MODULE_INFO_FIELDS)((uint)dwValidFields3 | 0x10u);
			}
			if ((A85EBF78A & 0x20) != 0)
			{
				val.m_addrPreferredLoadAddress = A1F5DE617.get_BaseAddress();
				ref enum_MODULE_INFO_FIELDS dwValidFields4 = ref val.dwValidFields;
				dwValidFields4 = (enum_MODULE_INFO_FIELDS)((uint)dwValidFields4 | 0x20u);
			}
			if ((A85EBF78A & 0x40) != 0)
			{
				val.m_dwSize = A1F5DE617.get_Size();
				ref enum_MODULE_INFO_FIELDS dwValidFields5 = ref val.dwValidFields;
				dwValidFields5 = (enum_MODULE_INFO_FIELDS)((uint)dwValidFields5 | 0x40u);
			}
			if ((A85EBF78A & 0x80) != 0)
			{
				val.m_dwLoadOrder = (uint)A1F5DE617.GetLoadOrder();
				ref enum_MODULE_INFO_FIELDS dwValidFields6 = ref val.dwValidFields;
				dwValidFields6 = (enum_MODULE_INFO_FIELDS)((uint)dwValidFields6 | 0x80u);
			}
			if ((A85EBF78A & 0x200) != 0)
			{
				val.m_bstrUrlSymbolLocation = string.Empty;
				ref enum_MODULE_INFO_FIELDS dwValidFields7 = ref val.dwValidFields;
				dwValidFields7 = (enum_MODULE_INFO_FIELDS)((uint)dwValidFields7 | 0x200u);
			}
			if ((A85EBF78A & 0x400) != 0)
			{
				val.m_dwModuleFlags = (enum_MODULE_FLAGS)0;
				if (((IJdwpReferenceType)A1F5DE617).get_SymbolsLoaded())
				{
					ref enum_MODULE_FLAGS dwModuleFlags = ref val.m_dwModuleFlags;
					dwModuleFlags = (enum_MODULE_FLAGS)((uint)dwModuleFlags | 2u);
				}
				ref enum_MODULE_INFO_FIELDS dwValidFields8 = ref val.dwValidFields;
				dwValidFields8 = (enum_MODULE_INFO_FIELDS)((uint)dwValidFields8 | 0x400u);
			}
			A3AD27B84[0] = val;
			return 0;
		}
		catch (ComponentException val2)
		{
			return ((Exception)val2).HResult;
		}
		catch (Exception a97A2962F)
		{
			return A09717160.ABD5D2EFF(a97A2962F);
		}
	}

	private int E1E2936AC(string B5C7F70E3, out string F96802C89)
	{
		F96802C89 = null;
		return 1;
	}

	private int F1ACA8318(string E6FEB6680, out string DC253BCE8)
	{
		throw new NotImplementedException();
	}

	private int F0E78FDF7(enum_MODULE_INFO_FIELDS AF63BBA4B, MODULE_INFO[] D4A4610AD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((IDebugModule2)this).GetInfo(AF63BBA4B, D4A4610AD);
	}

	private int B19896FD4(enum_SYMBOL_SEARCH_INFO_FIELDS ECC700732, MODULE_SYMBOL_SEARCH_INFO[] B9A40401B)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		B9A40401B[0] = default(MODULE_SYMBOL_SEARCH_INFO);
		B9A40401B[0].dwValidFields = 1u;
		if (((IJdwpReferenceType)A1F5DE617).get_SymbolsLoaded())
		{
			string bstrVerboseSearchInfo = "Symbols Loaded - " + ((IJdwpReferenceType)A1F5DE617).GetSourceFile();
			B9A40401B[0].bstrVerboseSearchInfo = bstrVerboseSearchInfo;
		}
		else
		{
			string bstrVerboseSearchInfo2 = "Symbols not loaded";
			B9A40401B[0].bstrVerboseSearchInfo = bstrVerboseSearchInfo2;
		}
		return 0;
	}

	private int FE63E4762(out int FC7806A25)
	{
		FC7806A25 = 1;
		return 0;
	}

	private int AC2DFE284()
	{
		((IJdwpReferenceType)A1F5DE617).GetSourceFile();
		return 0;
	}

	private int FFC27BAA2(int EDAB74F21)
	{
		throw new NotImplementedException();
	}
}
