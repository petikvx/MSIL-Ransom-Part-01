using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class Consumer : System.Attribute, _003CModule_003E, Consumer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Consumer()
	{
		WriterPropertyProducer.ResolveStub();
		InsertValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertValue()
	{
	}
}
