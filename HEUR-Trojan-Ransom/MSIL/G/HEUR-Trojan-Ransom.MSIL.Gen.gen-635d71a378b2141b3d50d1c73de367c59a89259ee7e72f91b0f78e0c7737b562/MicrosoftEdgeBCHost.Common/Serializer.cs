using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Serializer : Attribute, _003CModule_003E, Serializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Serializer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
