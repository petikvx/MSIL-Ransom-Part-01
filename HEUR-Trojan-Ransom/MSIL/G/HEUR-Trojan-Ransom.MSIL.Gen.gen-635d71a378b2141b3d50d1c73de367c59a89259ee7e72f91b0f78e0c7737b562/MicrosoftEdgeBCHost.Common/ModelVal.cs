using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ModelVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelVal()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateSpecification()
	{
	}
}
