using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class Listener : Attribute, _003CModule_003E, Listener
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Listener()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInstance()
	{
	}
}
