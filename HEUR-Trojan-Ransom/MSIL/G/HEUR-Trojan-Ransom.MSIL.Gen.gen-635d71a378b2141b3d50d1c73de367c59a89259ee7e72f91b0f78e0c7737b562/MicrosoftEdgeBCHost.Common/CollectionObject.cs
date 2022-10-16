using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CollectionObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionObject()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralListener()
	{
	}
}
