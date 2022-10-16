using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class Dispatcher : Attribute, _003CModule_003E, Dispatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Dispatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CallInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInstance()
	{
	}
}
