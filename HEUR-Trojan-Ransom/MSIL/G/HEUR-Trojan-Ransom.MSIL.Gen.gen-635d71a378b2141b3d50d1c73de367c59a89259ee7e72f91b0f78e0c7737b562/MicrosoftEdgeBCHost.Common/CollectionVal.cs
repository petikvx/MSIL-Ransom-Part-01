using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CollectionVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionVal()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterpreter()
	{
	}
}
