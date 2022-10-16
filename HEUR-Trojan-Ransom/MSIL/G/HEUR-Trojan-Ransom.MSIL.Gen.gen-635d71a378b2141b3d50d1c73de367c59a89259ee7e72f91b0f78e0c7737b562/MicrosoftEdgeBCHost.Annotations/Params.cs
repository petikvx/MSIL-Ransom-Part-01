using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class Params : Attribute, _003CModule_003E, Params
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Params()
	{
		WriterPropertyProducer.ResolveStub();
		QueryError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryError()
	{
	}
}
