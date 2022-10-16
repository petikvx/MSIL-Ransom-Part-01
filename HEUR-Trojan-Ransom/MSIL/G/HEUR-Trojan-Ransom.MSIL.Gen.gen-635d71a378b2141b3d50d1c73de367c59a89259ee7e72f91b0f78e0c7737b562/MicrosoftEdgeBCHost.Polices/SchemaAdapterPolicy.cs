using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SchemaAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralSpecification()
	{
	}
}
