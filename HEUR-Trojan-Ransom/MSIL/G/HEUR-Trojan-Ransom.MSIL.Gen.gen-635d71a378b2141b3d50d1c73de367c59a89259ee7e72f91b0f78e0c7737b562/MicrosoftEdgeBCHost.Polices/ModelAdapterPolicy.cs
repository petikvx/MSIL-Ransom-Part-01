using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ModelAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralAnnotation()
	{
	}
}
