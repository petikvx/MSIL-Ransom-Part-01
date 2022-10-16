using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MapperWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		CollectRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectRef()
	{
	}
}
