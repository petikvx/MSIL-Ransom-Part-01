using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PublisherPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceReader()
	{
	}
}
