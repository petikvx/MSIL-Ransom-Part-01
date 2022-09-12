using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Kofe.IJDWP;
using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class C1C0BFBF8 : IDebugPendingBreakpoint2
{
	private class CDCCCC28F
	{
		public readonly IJdwpCodeLocation A0E321FF8;

		public readonly TEXT_POSITION A76AF6C7F;

		public readonly string F3670E8BD;

		public CDCCCC28F(IJdwpCodeLocation location, TEXT_POSITION textPosition, string documentName)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			A0E321FF8 = location;
			A76AF6C7F = textPosition;
			F3670E8BD = documentName;
		}
	}

	private IDebugBreakpointRequest2 D6AA1B408;

	private BP_REQUEST_INFO EFA884C7B;

	private B92FAA9B7 A50E62544;

	private B6DF8D9E3 D96AC52DB;

	private List<BE52A5725> E0F33298A;

	private List<ADBF6C470> CE28745B7;

	private bool E5AD07317;

	private bool AEC8A9B11;

	internal bool EEAC0C0DD => E5AD07317;

	public C1C0BFBF8(IDebugBreakpointRequest2 pBPRequest, B92FAA9B7 engine, B6DF8D9E3 bpManager)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		D6AA1B408 = pBPRequest;
		BP_REQUEST_INFO[] array = (BP_REQUEST_INFO[])(object)new BP_REQUEST_INFO[1];
		A09717160.BA0F763AF(D6AA1B408.GetRequestInfo((enum_BPREQI_FIELDS)511, array));
		EFA884C7B = array[0];
		A50E62544 = engine;
		D96AC52DB = bpManager;
		E0F33298A = new List<BE52A5725>();
		CE28745B7 = new List<ADBF6C470>();
		E5AD07317 = true;
		AEC8A9B11 = false;
	}

	private bool DCFCD603C()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		CE28745B7.Clear();
		_ = EFA884C7B;
		if (AEC8A9B11)
		{
			return false;
		}
		List<CDCCCC28F> list = D476A8962((enum_BP_LOCATION_TYPE)EFA884C7B.bpLocation.bpLocationType, null);
		if ((int)EFA884C7B.bpCondition.styleCondition != 0)
		{
			foreach (CDCCCC28F item in list)
			{
				E604AB64A codeContext = new E604AB64A(A50E62544, item.A0E321FF8);
				F21674B78 documentContext = new F21674B78(item.F3670E8BD, item.A76AF6C7F, item.A76AF6C7F, codeContext);
				AC89F237D breakpointResolution = new AC89F237D(A50E62544, item.A0E321FF8, documentContext);
				((IDebugBoundBreakpoint2)new BE52A5725(A50E62544, item.A0E321FF8, this, breakpointResolution)).SetCondition(EFA884C7B.bpCondition);
			}
		}
		return CE28745B7.Count == 0;
	}

	public void E9B3B564F()
	{
		lock (E0F33298A)
		{
			for (int num = E0F33298A.Count - 1; num >= 0; num--)
			{
				((IDebugBoundBreakpoint2)E0F33298A[num]).Delete();
			}
			E0F33298A.Clear();
		}
	}

	public void B91C7FA3A(IJdwpClass DB1AB9CB4)
	{
		ECE77AFF0(DB1AB9CB4);
	}

	public int CF30FF1B8()
	{
		return ECE77AFF0(null);
	}

	public int ECE77AFF0(IJdwpClass AC94C1300)
	{
		lock (E0F33298A)
		{
			if (DCFCD603C())
			{
				List<CDCCCC28F> list = D476A8962((enum_BP_LOCATION_TYPE)EFA884C7B.bpLocation.bpLocationType, AC94C1300);
				return (list.Count <= 0 || !B49CA1359(list)) ? (-2147467259) : 0;
			}
			if (!AEC8A9B11)
			{
				return -2147467259;
			}
			return -2147221408;
		}
	}

	private List<CDCCCC28F> D476A8962(enum_BP_LOCATION_TYPE F0F049AC4, IJdwpClass F3FAA2416)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		if ((int)F0F049AC4 == 65537)
		{
			return D0E5A9E58(F3FAA2416);
		}
		if ((int)F0F049AC4 == 131073)
		{
			return DE7B2D275(F3FAA2416);
		}
		AB1E81DA4(B0E4D9146.A57BB5859, null, null, (enum_BP_ERROR_TYPE)117440514);
		return new List<CDCCCC28F>();
	}

	private List<CDCCCC28F> D0E5A9E58(IJdwpClass ECFF1FB44)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		IDebugDocumentPosition2 val = (IDebugDocumentPosition2)Marshal.GetObjectForIUnknown(EFA884C7B.bpLocation.unionmember2);
		string text = default(string);
		A09717160.BA0F763AF(val.GetFileName(ref text));
		TEXT_POSITION[] array = (TEXT_POSITION[])(object)new TEXT_POSITION[1];
		TEXT_POSITION[] array2 = (TEXT_POSITION[])(object)new TEXT_POSITION[1];
		A09717160.BA0F763AF(val.GetRange(array, array2));
		string text2 = A50E62544.BEB396177.C7D223CD2(text);
		A50E62544.B3E3893F5.SetDebugPackage(text2);
		IJdwpClass[] array3 = (IJdwpClass[])(object)new IJdwpClass[0];
		if (ECFF1FB44 != null)
		{
			if (ECFF1FB44.get_Name() != null && ECFF1FB44.get_Name().StartsWith(text2 + ".", StringComparison.Ordinal))
			{
				array3 = (IJdwpClass[])(object)new IJdwpClass[1] { ECFF1FB44 };
			}
		}
		else
		{
			array3 = A50E62544.B3E3893F5.GetClasses(Path.GetFileName(text));
		}
		List<IJdwpClass> list = new List<IJdwpClass>();
		IJdwpClass[] array4 = array3;
		foreach (IJdwpClass val2 in array4)
		{
			string value = A50E62544.BEB396177.AEB742416(val2);
			if (text.EndsWith(value, StringComparison.OrdinalIgnoreCase) || (!Path.IsPathRooted(text) && string.Equals(((IJdwpReferenceType)val2).GetSourceFile(), text, StringComparison.OrdinalIgnoreCase)))
			{
				list.Add(val2);
			}
		}
		if (list.Count == 0)
		{
			AB1E81DA4(B0E4D9146.A44699B94, null, null, (enum_BP_ERROR_TYPE)117440513);
			return new List<CDCCCC28F>();
		}
		uint dwLine = array[0].dwLine;
		List<CDCCCC28F> list2 = new List<CDCCCC28F>();
		List<IJdwpCodeLocation> list3 = new List<IJdwpCodeLocation>();
		foreach (IJdwpClass item in list)
		{
			IJdwpCodeLocation location = item.GetLocation(dwLine + 1);
			if (location != null)
			{
				list3.Add(location);
			}
		}
		if (list3.Count > 0)
		{
			TEXT_POSITION textPosition = default(TEXT_POSITION);
			textPosition.dwLine = dwLine;
			textPosition.dwColumn = array[0].dwColumn;
			{
				foreach (IJdwpCodeLocation item2 in list3)
				{
					list2.Add(new CDCCCC28F(item2, textPosition, text));
				}
				return list2;
			}
		}
		AB1E81DA4(B0E4D9146.BA87E22E0, null, null, (enum_BP_ERROR_TYPE)117440513);
		return new List<CDCCCC28F>();
	}

	private List<CDCCCC28F> DE7B2D275(IJdwpClass F6129A00D)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		IDebugFunctionPosition2 val = (IDebugFunctionPosition2)Marshal.GetObjectForIUnknown(EFA884C7B.bpLocation.unionmember2);
		string text = default(string);
		A09717160.BA0F763AF(val.GetFunctionName(ref text));
		int num = text.LastIndexOf('.');
		string value = ((num != -1) ? text.Remove(num) : "");
		text = ((num != -1) ? text.Remove(0, num + 1) : text);
		bool flag = !string.IsNullOrWhiteSpace(value);
		TEXT_POSITION[] array = (TEXT_POSITION[])(object)new TEXT_POSITION[1];
		A09717160.BA0F763AF(val.GetOffset(array));
		List<CDCCCC28F> list = new List<CDCCCC28F>();
		IJdwpClass[] array2 = (IJdwpClass[])((F6129A00D == null) ? ((Array)A50E62544.B3E3893F5.GetClasses()) : ((Array)new IJdwpClass[1] { F6129A00D }));
		foreach (IJdwpClass val2 in array2)
		{
			string documentName = A50E62544.BEB396177.AEB742416(val2);
			IJdwpMethod[] methods = val2.GetMethods(text);
			foreach (IJdwpMethod val3 in methods)
			{
				if (!flag || val2.get_Name().Contains(value))
				{
					IJdwpCodeLocation startLocation = val3.GetStartLocation();
					IJdwpCodeLine[] lines = val3.GetLines();
					if (startLocation != null && lines.Length != 0)
					{
						TEXT_POSITION textPosition = default(TEXT_POSITION);
						textPosition.dwLine = (uint)(lines[0].get_LineNumber() + (int)array[0].dwLine - 1);
						textPosition.dwColumn = array[0].dwColumn;
						IJdwpCodeLocation location = val2.GetLocation((uint)lines[0].get_LineNumber());
						list.Add(new CDCCCC28F(location, textPosition, documentName));
					}
				}
			}
		}
		if (list.Count == 0)
		{
			AB1E81DA4(string.Format(CultureInfo.CurrentCulture, B0E4D9146.DC08A8D4E, new object[1] { text }), null, null, (enum_BP_ERROR_TYPE)117440513);
		}
		return list;
	}

	private bool B49CA1359(List<CDCCCC28F> C81A48031)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		foreach (CDCCCC28F item in C81A48031)
		{
			IJdwpCodeLocation a0E321FF = item.A0E321FF8;
			if (F0A592D84(a0E321FF))
			{
				E604AB64A codeContext = new E604AB64A(A50E62544, a0E321FF);
				F21674B78 f21674B = new F21674B78(item.F3670E8BD, item.A76AF6C7F, item.A76AF6C7F, codeContext);
				AC89F237D breakpointResolution = new AC89F237D(A50E62544, a0E321FF, f21674B);
				BE52A5725 bE52A = new BE52A5725(A50E62544, a0E321FF, this, breakpointResolution);
				((IDebugBoundBreakpoint2)bE52A).SetPassCount(EFA884C7B.bpPassCount);
				((IDebugBoundBreakpoint2)bE52A).SetCondition(EFA884C7B.bpCondition);
				try
				{
					A50E62544.B3E3893F5.SetBreakpoint(a0E321FF, (object)bE52A);
				}
				catch (Exception ex)
				{
					AB1E81DA4(ex.Message, a0E321FF, f21674B, (enum_BP_ERROR_TYPE)117440514);
					return false;
				}
				A50E62544.F4F01CC92.E28BC42B4(bE52A, a0E321FF);
				E0F33298A.Add(bE52A);
			}
		}
		return true;
	}

	private bool F0A592D84(IJdwpCodeLocation E9BA024D5)
	{
		foreach (BE52A5725 item in E0F33298A)
		{
			if (((object)E9BA024D5).Equals((object?)item.FF69D4640()))
			{
				return false;
			}
		}
		lock (CE28745B7)
		{
			foreach (ADBF6C470 item2 in new List<ADBF6C470>(CE28745B7))
			{
				if (((object)E9BA024D5).Equals((object?)item2.F477E8871()))
				{
					CE28745B7.Remove(item2);
				}
			}
		}
		return true;
	}

	public void AB1E81DA4(string AD691DC9C, IJdwpCodeLocation D45239114, F21674B78 E30823706, enum_BP_ERROR_TYPE A0CBDFB9A = 117440513)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		lock (CE28745B7)
		{
			foreach (ADBF6C470 item in new List<ADBF6C470>(CE28745B7))
			{
				if ((D45239114 == null || ((object)D45239114).Equals((object?)item.F477E8871())) && AD691DC9C == item.C719C3CCD())
				{
					return;
				}
			}
			B034EA488 errorResolution = new B034EA488(A50E62544, D45239114, E30823706, AD691DC9C, A0CBDFB9A);
			ADBF6C470 aDBF6C = new ADBF6C470((IDebugPendingBreakpoint2)(object)this, (IDebugErrorBreakpointResolution2)(object)errorResolution, D45239114, AD691DC9C);
			A50E62544.F4F01CC92.AF11E36AA(aDBF6C);
			CE28745B7.Add(aDBF6C);
		}
	}

	private int B4A1AA0A1(out IEnumDebugErrorBreakpoints2 E95FA91D7)
	{
		E95FA91D7 = null;
		if (!DCFCD603C())
		{
			lock (CE28745B7)
			{
				IDebugErrorBreakpoint2[] breakpoints = (IDebugErrorBreakpoint2[])(object)CE28745B7.ToArray();
				E95FA91D7 = (IEnumDebugErrorBreakpoints2)(object)new F7BD112C0(breakpoints);
				return 1;
			}
		}
		return 0;
	}

	private int C615EFBF7()
	{
		lock (E0F33298A)
		{
			for (int num = E0F33298A.Count - 1; num >= 0; num--)
			{
				((IDebugBoundBreakpoint2)E0F33298A[num]).Delete();
			}
			AEC8A9B11 = true;
			E0F33298A.Clear();
		}
		return 0;
	}

	private int C20E07C64(int F28BC8DDC)
	{
		lock (E0F33298A)
		{
			E5AD07317 = ((F28BC8DDC != 0) ? true : false);
			foreach (BE52A5725 item in E0F33298A)
			{
				((IDebugBoundBreakpoint2)item).Enable(F28BC8DDC);
			}
		}
		return 0;
	}

	private int CC5DCA85F(out IEnumDebugBoundBreakpoints2 A392D12F2)
	{
		lock (E0F33298A)
		{
			IDebugBoundBreakpoint2[] breakpoints = (IDebugBoundBreakpoint2[])(object)E0F33298A.ToArray();
			A392D12F2 = (IEnumDebugBoundBreakpoints2)(object)new EB9D79BED(breakpoints);
		}
		return 0;
	}

	private int D4F54657C(enum_BP_ERROR_TYPE EC1D3A31A, out IEnumDebugErrorBreakpoints2 EDC471ED5)
	{
		lock (CE28745B7)
		{
			IDebugErrorBreakpoint2[] breakpoints = (IDebugErrorBreakpoint2[])(object)CE28745B7.ToArray();
			EDC471ED5 = (IEnumDebugErrorBreakpoints2)(object)new F7BD112C0(breakpoints);
		}
		return 0;
	}

	private int F7A3B25A0(out IDebugBreakpointRequest2 FDD8FD39F)
	{
		FDD8FD39F = D6AA1B408;
		return 0;
	}

	private int D5971972F(PENDING_BP_STATE_INFO[] D6D92DEB3)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (AEC8A9B11)
		{
			D6D92DEB3[0].state = (enum_PENDING_BP_STATE)1;
		}
		else if (E5AD07317)
		{
			D6D92DEB3[0].state = (enum_PENDING_BP_STATE)3;
		}
		else if (!E5AD07317)
		{
			D6D92DEB3[0].state = (enum_PENDING_BP_STATE)2;
		}
		return 0;
	}

	private int F9AFF6B49(BP_CONDITION B92982D2F)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (AEC8A9B11)
		{
			return -2147221408;
		}
		lock (E0F33298A)
		{
			foreach (BE52A5725 item in E0F33298A)
			{
				((IDebugBoundBreakpoint2)item).SetCondition(B92982D2F);
			}
			EFA884C7B.bpCondition = B92982D2F;
		}
		return 0;
	}

	private int F4B24D0DE(BP_PASSCOUNT AFEB4C4E4)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (AEC8A9B11)
		{
			return -2147221408;
		}
		lock (E0F33298A)
		{
			foreach (BE52A5725 item in E0F33298A)
			{
				((IDebugBoundBreakpoint2)item).SetPassCount(AFEB4C4E4);
			}
		}
		return 0;
	}

	private int F03A1C4C3(int BADD007C4)
	{
		return 0;
	}
}
