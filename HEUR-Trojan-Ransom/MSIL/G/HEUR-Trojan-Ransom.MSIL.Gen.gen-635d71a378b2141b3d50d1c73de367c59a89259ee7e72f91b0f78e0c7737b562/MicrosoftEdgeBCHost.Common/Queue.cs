using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Queue : Attribute, _003CModule_003E, Queue
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Queue()
	{
		WriterPropertyProducer.ResolveStub();
		PrintIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintIssuer()
	{
	}
}
