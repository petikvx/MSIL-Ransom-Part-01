using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ParameterAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralWriter()
	{
	}
}
