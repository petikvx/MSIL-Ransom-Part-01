using System;
using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class Definition : Attribute, _003CModule_003E, Definition
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Definition()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInstance()
	{
	}
}
