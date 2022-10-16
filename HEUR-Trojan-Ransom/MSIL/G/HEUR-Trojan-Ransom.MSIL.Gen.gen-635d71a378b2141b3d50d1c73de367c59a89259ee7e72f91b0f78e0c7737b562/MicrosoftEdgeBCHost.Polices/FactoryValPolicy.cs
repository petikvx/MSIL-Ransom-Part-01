using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FactoryValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveWriter()
	{
	}
}
