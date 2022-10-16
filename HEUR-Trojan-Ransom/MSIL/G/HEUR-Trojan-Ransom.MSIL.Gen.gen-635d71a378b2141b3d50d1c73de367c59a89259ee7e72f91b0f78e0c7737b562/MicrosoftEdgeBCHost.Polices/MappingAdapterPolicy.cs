using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MappingAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralInvocation()
	{
	}
}
