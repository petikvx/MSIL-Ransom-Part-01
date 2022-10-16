using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AdapterFilterPolicy : Attribute, _003CModule_003E, AdapterFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteError()
	{
	}
}
