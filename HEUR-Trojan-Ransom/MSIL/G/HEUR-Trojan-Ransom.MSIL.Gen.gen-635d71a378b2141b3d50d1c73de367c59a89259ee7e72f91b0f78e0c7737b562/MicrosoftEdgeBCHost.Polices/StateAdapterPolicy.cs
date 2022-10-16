using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StateAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralProperty()
	{
	}
}
