using System.Collections.Generic;
using Microsoft.Kofe.IJDWP;
using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class B6DF8D9E3
{
	private B92FAA9B7 BAAB9479A;

	private List<C1C0BFBF8> C5A48B238;

	public B6DF8D9E3(B92FAA9B7 engine)
	{
		BAAB9479A = engine;
		C5A48B238 = new List<C1C0BFBF8>();
	}

	public void B0FF78904(IDebugBreakpointRequest2 F4C82B497, out IDebugPendingBreakpoint2 AADB4D820)
	{
		lock (C5A48B238)
		{
			C1C0BFBF8 item = (C1C0BFBF8)(object)(AADB4D820 = (IDebugPendingBreakpoint2)(object)new C1C0BFBF8(F4C82B497, BAAB9479A, this));
			C5A48B238.Add(item);
		}
	}

	public void F76B8B846()
	{
		lock (C5A48B238)
		{
			foreach (C1C0BFBF8 item in C5A48B238)
			{
				item.E9B3B564F();
			}
		}
	}

	public void D526CA2B6(IJdwpClass FD7846FE3)
	{
		lock (C5A48B238)
		{
			foreach (C1C0BFBF8 item in C5A48B238)
			{
				item.B91C7FA3A(FD7846FE3);
			}
		}
	}
}
