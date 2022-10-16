using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StructOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructOrder()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterRegistry()
	{
	}
}
