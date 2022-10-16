using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class Reader : System.Attribute, _003CModule_003E, Reader
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Reader()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
