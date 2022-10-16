using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DecoratorValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceDescriptor()
	{
	}
}
