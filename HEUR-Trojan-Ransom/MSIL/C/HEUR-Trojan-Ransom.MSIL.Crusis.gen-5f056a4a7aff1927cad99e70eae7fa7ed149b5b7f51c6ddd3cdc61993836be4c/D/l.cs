using System;
using System.Runtime.CompilerServices;

namespace D;

internal sealed class l
{
	internal virtual int vmethod_0(byte byte_0, int int_0, char PUF6Qbqc70NoEh08yIRsMbp1QhLQwnomKQ8saRB4D3CvoJIqYszrEoM1hc5vHDAXN3Pe1EqqEW1en8EwQVDaTB1QZ26aG5xeFBEJX3bpWopPduBZ, int int_1)
	{
		return vmethod_0(byte_0, int_0, PUF6Qbqc70NoEh08yIRsMbp1QhLQwnomKQ8saRB4D3CvoJIqYszrEoM1hc5vHDAXN3Pe1EqqEW1en8EwQVDaTB1QZ26aG5xeFBEJX3bpWopPduBZ, int_1);
	}

	internal static B smethod_0<B>(CallSite callSite_0)
	{
		CallSite<Func<CallSite, B>> callSite = (CallSite<Func<CallSite, B>>)callSite_0;
		Func<CallSite, B> func = callSite.Target;
		callSite_0 = callSite;
		Func<CallSite, B>[] array = new Func<CallSite, B>[0];
		Func<CallSite, B> func2;
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				func2 = array[i];
				if (func2 != func)
				{
					callSite.Target = func2;
					func2(callSite_0);
				}
			}
		}
		for (int j = 0; j < array.Length; j++)
		{
			func2 = (callSite.Target = array[j]);
			try
			{
				func2(callSite_0);
			}
			catch
			{
			}
		}
		func2 = null;
		while (true)
		{
			callSite.Target = func;
			func2 = callSite.Target;
			try
			{
				func2(callSite_0);
			}
			catch
			{
			}
		}
	}

	internal static ResolveEventHandler smethod_1()
	{
		return B.smethod_0;
	}
}
