using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CollectionAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceConnection()
	{
	}
}
