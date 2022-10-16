using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DescriptorValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceFactory()
	{
	}
}
