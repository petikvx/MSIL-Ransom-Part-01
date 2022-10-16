using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SerializerOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceFilter()
	{
	}
}
