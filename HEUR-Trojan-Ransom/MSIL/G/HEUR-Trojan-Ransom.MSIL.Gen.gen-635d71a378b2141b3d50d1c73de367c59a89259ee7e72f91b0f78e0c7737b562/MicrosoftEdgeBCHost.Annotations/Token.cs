using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class Token : Attribute, _003CModule_003E, Token
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Token()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
