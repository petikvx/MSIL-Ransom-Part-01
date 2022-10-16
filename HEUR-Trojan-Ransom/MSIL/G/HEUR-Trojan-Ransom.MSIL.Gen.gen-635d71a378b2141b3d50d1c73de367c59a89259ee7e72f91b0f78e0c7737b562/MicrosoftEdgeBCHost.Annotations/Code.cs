using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class Code : Attribute, _003CModule_003E, Code
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Code()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
