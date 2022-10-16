using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FactoryFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveRef()
	{
	}
}
