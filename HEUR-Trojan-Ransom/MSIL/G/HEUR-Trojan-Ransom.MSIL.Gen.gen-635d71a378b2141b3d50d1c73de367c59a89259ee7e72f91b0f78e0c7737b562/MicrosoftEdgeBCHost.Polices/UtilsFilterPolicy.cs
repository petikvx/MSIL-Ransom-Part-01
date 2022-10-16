using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class UtilsFilterPolicy : Attribute, _003CModule_003E, UtilsFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInstance()
	{
	}
}
