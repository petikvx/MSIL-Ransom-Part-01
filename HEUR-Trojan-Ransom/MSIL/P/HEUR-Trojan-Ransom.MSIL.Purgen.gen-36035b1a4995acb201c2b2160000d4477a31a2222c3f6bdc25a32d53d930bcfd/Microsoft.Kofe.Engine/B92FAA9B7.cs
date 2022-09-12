using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BD9409C89;
using MICore;
using Microsoft.DebugEngineHost;
using Microsoft.Kofe.IJDWP;
using Microsoft.VisualStudio.Debugger.Interop;
using Microsoft.Win32;

namespace Microsoft.Kofe.Engine;

[ComVisible(true)]
[Guid("CA454416-95AC-4702-ADD1-FE8B82FD177C")]
public class B92FAA9B7 : IDebugEngine2, IDebugEngineLaunch2, IDebugProgram3, IDebugProgram2, IDebugEngineProgram2, IDebugSymbolSettings100, IDebugEngine110
{
	private const string FBFDE56EB = "MaxFrames";

	private const int BCD453819 = 5000;

	private C34CB4AC6 B921E49E4;

	private IJDbg FE7B06DD7;

	private B6DF8D9E3 CCA89DDF4;

	private Guid A68EA7084;

	private string BDC3AC52B;

	private HostConfigurationStore F8EF90C8A;

	private int A3212B05B;

	private DB7064EFF F5382BFA0;

	private IDebugSettingsCallback110 E64F1DCE7;

	private AD_PROCESS_ID FBDEAC594;

	private string B64BEF33F;

	[CompilerGenerated]
	private DAB178BEA D1107DCFC;

	public DAB178BEA BEB396177
	{
		[CompilerGenerated]
		get
		{
			return D1107DCFC;
		}
		[CompilerGenerated]
		private set
		{
			D1107DCFC = value;
		}
	}

	internal C34CB4AC6 F4F01CC92 => B921E49E4;

	internal IJDbg B3E3893F5 => FE7B06DD7;

	internal int C58936D0E
	{
		get
		{
			if (A3212B05B == 0)
			{
				A3212B05B = E44E5AEFC();
			}
			return A3212B05B;
		}
	}

	public B92FAA9B7()
	{
		CCA89DDF4 = new B6DF8D9E3(this);
		BEB396177 = new DAB178BEA();
	}

	internal uint C826EF455()
	{
		uint result = default(uint);
		if (E64F1DCE7 == null || E64F1DCE7.GetDisplayRadix(ref result) != 0)
		{
			return 10u;
		}
		return result;
	}

	public void A41E71F6C(string E8B451AAD, params object[] C35CACB76)
	{
		F5382BFA0?.CD51BAE3D(E8B451AAD, C35CACB76);
	}

	private int F541C0290(IDebugProgram2[] EC2F32D01, IDebugProgramNode2[] FC53DFFFD, uint EF71D4250, IDebugEventCallback2 EA6808AA4, enum_ATTACH_REASON EE6E8F7FB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		if (EF71D4250 != 1)
		{
			throw new ArgumentException();
		}
		try
		{
			AD_PROCESS_ID eB = A09717160.FD33F459F(EC2F32D01[0]);
			A09717160.BA0F763AF(EC2F32D01[0].GetProgramId(ref A68EA7084));
			if (FE7B06DD7 == null)
			{
				B921E49E4 = new C34CB4AC6(this, EA6808AA4);
			}
			else if (!A09717160.E5CC8D070(eB, FBDEAC594))
			{
				return 1;
			}
		}
		catch (ComponentException val)
		{
			return ((Exception)val).HResult;
		}
		try
		{
			FE7B06DD7.Initialize(C33AFA128(), "Java Exceptions");
		}
		catch (Exception ex)
		{
			B921E49E4.A61FE0ED3(string.Format(CultureInfo.CurrentCulture, B0E4D9146.D80EA1684, new object[1] { ex.Message }));
			return 1;
		}
		BD52E9688.D30D556F9(this);
		EE3ABAF2D.B25F8A1ED(this);
		return 0;
	}

	private Dictionary<string, bool> C33AFA128()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Invalid comparison between Unknown and I4
		Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(BDC3AC52B + "\\AD7Metrics\\Exception\\{029D0BD7-2382-44D7-BBE9-E45D5514E439}");
		using RegistryKey registryKey2 = registryKey.OpenSubKey("Java Exceptions");
		enum_EXCEPTION_STATE val = (enum_EXCEPTION_STATE)registryKey2.GetValue("State");
		dictionary["Java Exceptions"] = (val & 1) > 0;
		string[] subKeyNames = registryKey2.GetSubKeyNames();
		foreach (string text in subKeyNames)
		{
			using RegistryKey registryKey3 = registryKey2.OpenSubKey(text);
			val = (enum_EXCEPTION_STATE)registryKey3.GetValue("State");
			dictionary[text] = (val & 1) > 0;
		}
		return dictionary;
	}

	private int E44E5AEFC()
	{
		int num = F8EF90C8A.GetDebuggerConfigurationSetting<int>("MaxFrames", 5000);
		if (num < 10 || num > 20000)
		{
			num = 5000;
		}
		return num;
	}

	private int D9D6DFEF4()
	{
		return ((IDebugProgram2)this).CauseBreak();
	}

	private int C8F829A11(IDebugEvent2 E61BEE283)
	{
		try
		{
			if (E61BEE283 is A0F065618)
			{
				B921E49E4 = null;
				A68EA7084 = Guid.Empty;
				FE7B06DD7 = null;
			}
			else
			{
				_ = E61BEE283 is EE17CB70B;
			}
		}
		catch (Exception a97A2962F)
		{
			return A09717160.ABD5D2EFF(a97A2962F);
		}
		return 0;
	}

	private int AA9DEFE35(IDebugBreakpointRequest2 CA0FDB66A, out IDebugPendingBreakpoint2 EC9AA7EB8)
	{
		EC9AA7EB8 = null;
		try
		{
			CCA89DDF4.B0FF78904(CA0FDB66A, out EC9AA7EB8);
		}
		catch (Exception a97A2962F)
		{
			return A09717160.ABD5D2EFF(a97A2962F);
		}
		return 0;
	}

	internal void BC1C4713E(IJdwpClass CFD373304)
	{
		CCA89DDF4.D526CA2B6(CFD373304);
	}

	private int BD257F92D(IDebugProgram2 ED407BE1C)
	{
		return -2147218687;
	}

	private int E000A21E5(out Guid B87E5F7E1)
	{
		B87E5F7E1 = new Guid("{029D0BD7-2382-44D7-BBE9-E45D5514E439}");
		return 0;
	}

	private int E937EC043(ref Guid D4BD8F20D)
	{
		if (D4BD8F20D == Guid.Empty)
		{
			FE7B06DD7.ClearExceptionSettings();
		}
		return 0;
	}

	private int F59CF301C(EXCEPTION_INFO[] A20A7B321)
	{
		FE7B06DD7.SetException(A20A7B321[0].bstrExceptionName, false);
		return 0;
	}

	private int DF172B972(EXCEPTION_INFO[] B1A185C8C)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		EXCEPTION_INFO val = B1A185C8C[0];
		FE7B06DD7.SetException(val.bstrExceptionName, (val.dwState & 1) > 0);
		return 0;
	}

	private int C24B5055B(ushort AAD0A7D93)
	{
		return 0;
	}

	private int E286909B9(string C8077D50A, object B7971E92D)
	{
		return 0;
	}

	private int F25AA8480(string DA4E931D5)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		F8EF90C8A = new HostConfigurationStore(DA4E931D5);
		F8EF90C8A.SetEngineGuid(new Guid("{029D0BD7-2382-44D7-BBE9-E45D5514E439}"));
		BDC3AC52B = DA4E931D5;
		return 0;
	}

	private int A6497CF98(IDebugProcess2 EFFD4A811)
	{
		return 0;
	}

	private int B943910D4(string E67E55034, IDebugPort2 ABC3B48E6, string C4B7A8E85, string BA3E3F45A, string B1F20E058, string F4C49E085, string BDB4F90EE, enum_LAUNCH_FLAGS B0362844D, uint EADAB60F6, uint A447F1D37, uint CF7FFFC4E, IDebugEventCallback2 F8FACB3F1, out IDebugProcess2 E890D7082)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		E890D7082 = null;
		B921E49E4 = new C34CB4AC6(this, F8FACB3F1);
		try
		{
			JavaLaunchOptions val = (JavaLaunchOptions)LaunchOptions.GetInstance(F8EF90C8A, C4B7A8E85, BA3E3F45A, B1F20E058, BDB4F90EE, false, (IDeviceAppLauncherEventCallback)(object)B921E49E4, (TargetEngine)2, (Logger)null);
			BEB396177.C4C974AF9 = val.get_SourceRoots();
			BEB396177.C1A369FA3();
			B64BEF33F = val.get_ProcessName();
			FE7B06DD7 = JavaFactory.CreateJDbg();
			FE7B06DD7.Attach(val.get_JVMHost(), val.get_JVMPort(), (IEngineCallback)(object)B921E49E4);
			F5382BFA0 = DB7064EFF.B8F20CD6F(F8EF90C8A);
			F5382BFA0.CD51BAE3D(BDB4F90EE);
		}
		catch (Exception ex)
		{
			A747D62C3.B550BC694(ex);
			F5382BFA0?.CD51BAE3D(B0E4D9146.A550DE73D, ex.Message);
			return -2147221469;
		}
		AD_PROCESS_ID val2 = default(AD_PROCESS_ID);
		val2.ProcessIdType = 1u;
		val2.guidProcessId = Guid.NewGuid();
		FBDEAC594 = val2;
		return ABC3B48E6.GetProcess(val2, ref E890D7082);
	}

	private int BA73AD92A(IDebugProcess2 B5343178C)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		try
		{
			if (!A09717160.E5CC8D070(A09717160.AEB40F257(B5343178C), FBDEAC594))
			{
				return 1;
			}
			IDebugPort2 val = default(IDebugPort2);
			A09717160.BA0F763AF(B5343178C.GetPort(ref val));
			IDebugPortNotify2 val2 = default(IDebugPortNotify2);
			A09717160.BA0F763AF(((IDebugDefaultPort2)val).GetPortNotify(ref val2));
			A09717160.BA0F763AF(val2.AddProgramNode((IDebugProgramNode2)(object)new AA6E8A8A4(FBDEAC594, B64BEF33F)));
			if (A68EA7084 == Guid.Empty)
			{
				B921E49E4.A61FE0ED3(B0E4D9146.B01C7B211);
				return 1;
			}
			return 0;
		}
		catch (ComponentException val3)
		{
			return ((Exception)val3).HResult;
		}
		catch (Exception ex)
		{
			B921E49E4.A61FE0ED3(string.Format(CultureInfo.CurrentCulture, B0E4D9146.B27F41BB2, new object[1] { ex.Message }));
			return 1;
		}
	}

	private int CFC13BFC5(IDebugProcess2 E1BFB8B5B)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		try
		{
			if (!A09717160.E5CC8D070(A09717160.AEB40F257(E1BFB8B5B), FBDEAC594))
			{
				return 1;
			}
			if (FE7B06DD7 != null)
			{
				FE7B06DD7.Close();
				return 0;
			}
			return 1;
		}
		catch (ComponentException val)
		{
			return ((Exception)val).HResult;
		}
		catch (Exception a97A2962F)
		{
			return A09717160.ABD5D2EFF(a97A2962F);
		}
		finally
		{
			D35CD9549();
		}
	}

	private void D35CD9549()
	{
		if (BEB396177 != null)
		{
			BEB396177.DF1712D92();
			BEB396177 = null;
		}
	}

	public int F86BEFAF1()
	{
		return 0;
	}

	public int AD6782D16()
	{
		FE7B06DD7.CauseBreak();
		return 0;
	}

	public int DCE5B3F5B(IDebugThread2 CF1326CFF)
	{
		FE7B06DD7.Continue();
		return 0;
	}

	public int F59B4DE29()
	{
		CCA89DDF4.F76B8B846();
		FE7B06DD7.Close();
		D35CD9549();
		return 0;
	}

	public int AE9852C9D(IDebugDocumentPosition2 CBC7F021B, out IEnumDebugCodeContexts2 BFF82EFE3)
	{
		throw new NotImplementedException();
	}

	public int F6095942F(string ECE95F88E, IDebugCodeContext2 D8BFF55B3, IDebugStackFrame2 B8DE515BC, int D6C193648, out IEnumCodePaths2 A343A4DA4, out IDebugCodeContext2 C263D8F29)
	{
		A343A4DA4 = null;
		C263D8F29 = null;
		return 1;
	}

	public int D2B358B4D(out IEnumDebugModules2 FBAA57C67)
	{
		IJdwpClass[] classes = FE7B06DD7.GetClasses();
		E941D6CC6[] array = new E941D6CC6[classes.Length];
		for (int i = 0; i < classes.Length; i++)
		{
			array[i] = new E941D6CC6(classes[i]);
		}
		FBAA57C67 = (IEnumDebugModules2)(object)new D04E124C3((IDebugModule2[])(object)array);
		return 0;
	}

	public int C765306A3(out IEnumDebugThreads2 A710E9BB2)
	{
		IJdwpThread[] threads = FE7B06DD7.GetThreads();
		FE8030C1E[] array = new FE8030C1E[threads.Length];
		for (int i = 0; i < threads.Length; i++)
		{
			array[i] = (FE8030C1E)threads[i].get_Client();
		}
		A710E9BB2 = (IEnumDebugThreads2)(object)new CA7C58B0D((IDebugThread2[])(object)array);
		return 0;
	}

	public int DB191812B(out IDebugProperty2 E03E1FB15)
	{
		throw new NotImplementedException();
	}

	public int A2B354F23(enum_DISASSEMBLY_STREAM_SCOPE D546B4416, IDebugCodeContext2 ECEA1CBE7, out IDebugDisassemblyStream2 B24F71881)
	{
		B24F71881 = null;
		return 1;
	}

	public int BCEACBD70(out object B045A6101)
	{
		B045A6101 = null;
		return -2147467263;
	}

	public int B429FA917(out string CB94BE136, out Guid EA27B67FC)
	{
		CB94BE136 = B0E4D9146.E34BDB9D2;
		EA27B67FC = new Guid("{029D0BD7-2382-44D7-BBE9-E45D5514E439}");
		return 0;
	}

	public int D54B7E72F(out IDebugMemoryBytes2 A95288E34)
	{
		throw new NotImplementedException();
	}

	public int CE67D2EE4(out string BCB8E0362)
	{
		BCB8E0362 = B64BEF33F;
		return 0;
	}

	public int ECE702C1E(out Guid F9C4D5B67)
	{
		F9C4D5B67 = A68EA7084;
		return 0;
	}

	public int C679D8379(IDebugThread2 B3648CA2A, enum_STEPKIND B3390EE01, enum_STEPUNIT A20CDE083)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected I4, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		FE8030C1E fE8030C1E = (FE8030C1E)(object)B3648CA2A;
		if (fE8030C1E == null || fE8030C1E.BAB7FF789() == null)
		{
			B921E49E4.AEEFE1C6A(B0E4D9146.E04609340);
			return 1;
		}
		StepDepth dDA2D97BE = (StepDepth)1;
		switch ((int)B3390EE01)
		{
		case 0:
			dDA2D97BE = (StepDepth)0;
			break;
		case 2:
			dDA2D97BE = (StepDepth)2;
			break;
		default:
			throw new NotImplementedException();
		case 1:
			break;
		}
		StepSize e91040BE = (StepSize)((int)A20CDE083 != 2);
		fE8030C1E.D869BD2AD(dDA2D97BE, e91040BE);
		return 0;
	}

	public int C2536A886()
	{
		return 0;
	}

	public int AE3A99680(enum_DUMPTYPE F3384DE7D, string CDA29C280)
	{
		return 1;
	}

	public int E337F8ED1(IDebugThread2 F9C2FD4E9)
	{
		FE7B06DD7.Execute();
		return 0;
	}

	public int A77840C6C()
	{
		throw new NotImplementedException();
	}

	public int CF06D43A1(IDebugProgram2 D3DEFB4A0, uint DD43D57D4, uint F95F890B2, IDebugEventCallback2 AA5439379, int EAA374AEC)
	{
		return 0;
	}

	public int BFC67E6D1(IDebugProgram2 C96D4C549, uint DF75BEF85, int F22153A1C, uint E4B4F447D)
	{
		return 0;
	}

	public int B3715A0C4(int E14712C31, int C6BEAA45C, string FE7F5DD76, string CA2E57C04)
	{
		return 0;
	}

	private int F46ECECE7(out IEnumDebugPrograms2 C8C003CE4)
	{
		C8C003CE4 = null;
		return 1;
	}

	public int AA223C657(IDebugEventCallback2 F020AD096)
	{
		return 1;
	}

	public int B8866D6A2(out IDebugProcess2 F05885A4B)
	{
		F05885A4B = null;
		return 1;
	}

	public int E23AED7B5()
	{
		return 1;
	}

	public int EE5533C77(IDebugSettingsCallback110 A1D8A59AA)
	{
		E64F1DCE7 = A1D8A59AA;
		return 0;
	}
}
