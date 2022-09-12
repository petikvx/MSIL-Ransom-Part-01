using System;
using System.Collections.Generic;
using MICore;
using Microsoft.Kofe.IJDWP;
using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class C34CB4AC6 : IEngineCallback, IDeviceAppLauncherEventCallback
{
	private readonly IDebugEventCallback2 ED18DFC74;

	private readonly B92FAA9B7 DD62107F2;

	public C34CB4AC6(B92FAA9B7 engine, IDebugEventCallback2 ad7Callback)
	{
		ED18DFC74 = ad7Callback;
		DD62107F2 = engine;
	}

	public void A66BFCA0B(IDebugEvent2 C0EFB72BE, string BB5A0F36F, IDebugProgram2 E6B9EBD94, IDebugThread2 E9F0BD9D9)
	{
		Guid guid = new Guid(BB5A0F36F);
		uint num = default(uint);
		A09717160.BA0F763AF(C0EFB72BE.GetAttributes(ref num));
		A09717160.DEA99FC95(ED18DFC74.Event((IDebugEngine2)(object)DD62107F2, (IDebugProcess2)null, E6B9EBD94, E9F0BD9D9, C0EFB72BE, ref guid, num));
	}

	public void D14E82737(IDebugEvent2 F07AE03F4, string A26CE2DAE, IDebugThread2 E599DE972)
	{
		A66BFCA0B(F07AE03F4, A26CE2DAE, (IDebugProgram2)(object)DD62107F2, E599DE972);
	}

	public void A61FE0ED3(string D2746AF64)
	{
		DD62107F2.A41E71F6C(D2746AF64);
		EE17CB70B f07AE03F = new EE17CB70B(D2746AF64, EE17CB70B.EE5245CC9.MESSAGEBOX);
		D14E82737((IDebugEvent2)(object)f07AE03F, "3BDB28CF-DBD2-4D24-AF03-01072B67EB9E", null);
	}

	public void AEEFE1C6A(string A1474068A)
	{
		DD62107F2.A41E71F6C(A1474068A);
		EE17CB70B f07AE03F = new EE17CB70B(A1474068A, EE17CB70B.EE5245CC9.OUTPUT);
		D14E82737((IDebugEvent2)(object)f07AE03F, "3BDB28CF-DBD2-4D24-AF03-01072B67EB9E", null);
	}

	public void E45597A34(string C841D47C3)
	{
		DD62107F2.A41E71F6C(C841D47C3);
	}

	public void DE39B0D5A(string A1113C5EA)
	{
		EE17CB70B f07AE03F = new EE17CB70B(A1113C5EA, (EE17CB70B.EE5245CC9)257);
		D14E82737((IDebugEvent2)(object)f07AE03F, "3BDB28CF-DBD2-4D24-AF03-01072B67EB9E", null);
	}

	public void C9F413720(IJdwpClass F18E43543)
	{
		E941D6CC6 e941D6CC = new E941D6CC6(F18E43543);
		A64E803B9 f07AE03F = new A64E803B9(e941D6CC, fLoad: true);
		F18E43543.set_Client((object)e941D6CC);
		DD62107F2.BC1C4713E(F18E43543);
		D14E82737((IDebugEvent2)(object)f07AE03F, "989DB083-0D7C-40D1-A9D9-921BF611A4B2", null);
	}

	public void F18C93422(IJdwpClass E83D01246)
	{
		A64E803B9 f07AE03F = new A64E803B9((E941D6CC6)E83D01246.get_Client(), fLoad: false);
		D14E82737((IDebugEvent2)(object)f07AE03F, "989DB083-0D7C-40D1-A9D9-921BF611A4B2", null);
	}

	public void A24856D48(string F12AFC4D8)
	{
		DD62107F2.A41E71F6C(F12AFC4D8);
		C1DFE54C0 f07AE03F = new C1DFE54C0(F12AFC4D8);
		D14E82737((IDebugEvent2)(object)f07AE03F, "569c4bb1-7b82-46fc-ae28-4536ddad753e", null);
	}

	public void FFCFB1E2D(uint F8869F6FA)
	{
		A0F065618 f07AE03F = new A0F065618(F8869F6FA);
		D14E82737((IDebugEvent2)(object)f07AE03F, "E147E9E3-6440-4073-A7B7-A65592C714B5", null);
	}

	public void D8082DBC6(IJdwpThread FBBD81883, uint B46FF0506)
	{
		FE8030C1E e599DE = (FE8030C1E)FBBD81883.get_Client();
		C46F831C9 f07AE03F = new C46F831C9(B46FF0506);
		D14E82737((IDebugEvent2)(object)f07AE03F, "2C3B7532-A36F-4A6E-9072-49BE649B8541", (IDebugThread2)(object)e599DE);
	}

	public void C9F56DAA3(IJdwpThread F9A8D1086)
	{
		FE8030C1E fE8030C1E = new FE8030C1E(DD62107F2, F9A8D1086);
		F9A8D1086.set_Client((object)fE8030C1E);
		FAF3A2842 f07AE03F = new FAF3A2842();
		D14E82737((IDebugEvent2)(object)f07AE03F, "2090CCFC-70C5-491D-A5E8-BAD2DD9EE3EA", (IDebugThread2)(object)fE8030C1E);
	}

	public void A86293343(IJdwpThread C2DF01062, List<object> D0E1DB8AF, IJdwpCodeLocation E3BB4524E, bool B0572DEBE)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		IDebugBoundBreakpoint2[] array = (IDebugBoundBreakpoint2[])(object)new IDebugBoundBreakpoint2[D0E1DB8AF.Count];
		int num = 0;
		foreach (IDebugBoundBreakpoint2 item in D0E1DB8AF)
		{
			IDebugBoundBreakpoint2 val = item;
			uint num2 = 0u;
			val.GetHitCount(ref num2);
			val.SetHitCount(num2 + 1);
			if (!B0572DEBE || ((BE52A5725)(object)val).CEC3DFA24(C2DF01062))
			{
				array[num] = val;
				num++;
			}
		}
		DF5B5E024 f07AE03F = new DF5B5E024((IEnumDebugBoundBreakpoints2)(object)new EB9D79BED(array));
		FE8030C1E e599DE = (FE8030C1E)C2DF01062.get_Client();
		D14E82737((IDebugEvent2)(object)f07AE03F, "501C1E21-C557-48B8-BA30-A1EAB0BC4A74", (IDebugThread2)(object)e599DE);
	}

	public void AF11E36AA(object C46B23511)
	{
		ABE09AC6A f07AE03F = new ABE09AC6A((ADBF6C470)C46B23511);
		D14E82737((IDebugEvent2)(object)f07AE03F, "abb0ca42-f82b-4622-84e4-6903ae90f210", null);
	}

	public void C1944EA52(IJdwpThread B2A58B784)
	{
		((FE8030C1E)B2A58B784.get_Client()).A15ACDA04();
	}

	public void A2E70BB9B(IJdwpThread CABC5C531, string DC928723F, string C9789F14E, bool C75F4A4C4)
	{
		AAE8A68E4 f07AE03F = new AAE8A68E4((IDebugProgram2)(object)DD62107F2, DC928723F, 0u, C9789F14E, C75F4A4C4);
		FE8030C1E e599DE = (FE8030C1E)CABC5C531.get_Client();
		D14E82737((IDebugEvent2)(object)f07AE03F, "51a94113-8788-4a54-ae15-08b74ff922d0", (IDebugThread2)(object)e599DE);
	}

	public void BFF265956(IJdwpThread F6A8BE0C3)
	{
		FE8030C1E e599DE = (FE8030C1E)F6A8BE0C3.get_Client();
		D20222E9B f07AE03F = new D20222E9B();
		D14E82737((IDebugEvent2)(object)f07AE03F, "c7405d1d-e24b-44e0-b707-d8a5a4e1641b", (IDebugThread2)(object)e599DE);
	}

	public void B60331524(IJdwpThread A35DBCDFD)
	{
		FE8030C1E e599DE = ((A35DBCDFD != null) ? ((FE8030C1E)A35DBCDFD.get_Client()) : null);
		EFEACFA57 f07AE03F = new EFEACFA57();
		D14E82737((IDebugEvent2)(object)f07AE03F, "B1844850-1349-45D4-9F12-495212F5EB0B", (IDebugThread2)(object)e599DE);
	}

	public void E44665EFD(uint F15D41546)
	{
		A0F065618 f07AE03F = new A0F065618(F15D41546);
		D14E82737((IDebugEvent2)(object)f07AE03F, "E147E9E3-6440-4073-A7B7-A65592C714B5", null);
	}

	public void C3A3ED129(IJdwpClass C9B00B550, string D1AF9895E, uint C1E26ED95)
	{
		string searchInfo = ((C1E26ED95 == 1) ? "Symbols Loaded - " : "No symbols loaded") + D1AF9895E;
		C387EF2B4 f07AE03F = new C387EF2B4(new E941D6CC6(C9B00B550), searchInfo, C1E26ED95);
		D14E82737((IDebugEvent2)(object)f07AE03F, "638F7C54-C160-4c7b-B2D0-E0337BC61F8C", null);
	}

	public void E28BC42B4(object E1C041A54, IJdwpCodeLocation FE5F5BEF3)
	{
		BE52A5725 bE52A = (BE52A5725)E1C041A54;
		IDebugPendingBreakpoint2 val = default(IDebugPendingBreakpoint2);
		((IDebugBoundBreakpoint2)bE52A).GetPendingBreakpoint(ref val);
		B46FD4907 f07AE03F = new B46FD4907((C1C0BFBF8)(object)val, bE52A);
		D14E82737((IDebugEvent2)(object)f07AE03F, "1dddb704-cf99-4b8a-b746-dabb01dd13a0", null);
	}

	public void F64C06FA4(Guid D5EBC2300, Guid BF2FD3B95, int ED8CE8CFB, object B1B74CB02, object D942817F8)
	{
		throw new NotImplementedException();
	}
}
