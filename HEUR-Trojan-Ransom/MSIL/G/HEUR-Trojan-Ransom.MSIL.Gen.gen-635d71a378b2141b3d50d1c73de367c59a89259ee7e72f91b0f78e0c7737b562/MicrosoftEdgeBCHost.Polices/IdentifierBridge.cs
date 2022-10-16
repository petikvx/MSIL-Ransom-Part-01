using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class IdentifierBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierBridge()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateMapper()
	{
	}
}
