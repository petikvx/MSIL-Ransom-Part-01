using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SingletonRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonRules()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeModel()
	{
	}
}
