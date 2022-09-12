using System;
using C70E4DCD4;
using Microsoft.Kofe.IJDWP;
using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class F21674B78 : IDebugDocumentContext2
{
	private string B7FC0EBE9;

	private TEXT_POSITION C8464973C;

	private TEXT_POSITION A8A2C2194;

	private E604AB64A F4611F729;

	public F21674B78(string fileName, TEXT_POSITION begPos, TEXT_POSITION endPos, E604AB64A codeContext)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		B7FC0EBE9 = fileName;
		C8464973C = begPos;
		A8A2C2194 = endPos;
		F4611F729 = codeContext;
	}

	private int B964FEAC4(enum_DOCCONTEXT_COMPARE B54613F12, IDebugDocumentContext2[] B414B2608, uint BF819626A, out uint CB51C1407)
	{
		BF819626A = 0u;
		CB51C1407 = 0u;
		return 1;
	}

	private int A67B80447(out IEnumDebugCodeContexts2 F688EBE1C)
	{
		//IL_0024: Expected O, but got Unknown
		F688EBE1C = null;
		try
		{
			F688EBE1C = (IEnumDebugCodeContexts2)(object)new DF6742DA9((IDebugCodeContext2[])(object)new E604AB64A[1] { F4611F729 });
			return 0;
		}
		catch (ComponentException val)
		{
			return ((Exception)val).HResult;
		}
		catch (Exception a97A2962F)
		{
			return A09717160.ABD5D2EFF(a97A2962F);
		}
	}

	private int BAE7A2584(out IDebugDocument2 AE2DCBB4B)
	{
		AE2DCBB4B = null;
		return 1;
	}

	private int C41776C3E(ref string AAC647707, ref Guid F30E1413C)
	{
		AAC647707 = "Java";
		F30E1413C = EC594D2A3.E0822BBCF;
		return 0;
	}

	private int FCE357D6B(enum_GETNAME_TYPE EF3E0A689, out string D3B404C40)
	{
		D3B404C40 = B7FC0EBE9;
		return 0;
	}

	private int ADB7ED782(TEXT_POSITION[] C0475E198, TEXT_POSITION[] C138B1B24)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		C0475E198[0] = C8464973C;
		C138B1B24[0] = A8A2C2194;
		return 0;
	}

	private int F3368DEB4(TEXT_POSITION[] E14BC53F1, TEXT_POSITION[] AC71B77B9)
	{
		//IL_0063: Expected O, but got Unknown
		try
		{
			E14BC53F1[0].dwColumn = C8464973C.dwColumn;
			E14BC53F1[0].dwLine = C8464973C.dwLine;
			AC71B77B9[0].dwColumn = A8A2C2194.dwColumn;
			AC71B77B9[0].dwLine = A8A2C2194.dwLine;
		}
		catch (ComponentException val)
		{
			return ((Exception)val).HResult;
		}
		catch (Exception a97A2962F)
		{
			return A09717160.ABD5D2EFF(a97A2962F);
		}
		return 0;
	}

	private int E985300D5(int C7AA7D414, out IDebugDocumentContext2 A9EA2FCBF)
	{
		A9EA2FCBF = null;
		return 1;
	}
}
