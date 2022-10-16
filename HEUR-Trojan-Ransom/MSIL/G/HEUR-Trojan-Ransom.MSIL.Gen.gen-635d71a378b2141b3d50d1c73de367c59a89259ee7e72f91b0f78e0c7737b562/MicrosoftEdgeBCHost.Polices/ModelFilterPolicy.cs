using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ModelFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateSchema()
	{
	}
}
