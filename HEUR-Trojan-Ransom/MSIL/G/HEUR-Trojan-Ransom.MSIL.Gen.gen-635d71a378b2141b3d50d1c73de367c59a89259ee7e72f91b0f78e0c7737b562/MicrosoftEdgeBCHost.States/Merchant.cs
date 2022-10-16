using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class Merchant : System.Attribute, _003CModule_003E, Merchant
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Merchant()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptFactory()
	{
	}
}
