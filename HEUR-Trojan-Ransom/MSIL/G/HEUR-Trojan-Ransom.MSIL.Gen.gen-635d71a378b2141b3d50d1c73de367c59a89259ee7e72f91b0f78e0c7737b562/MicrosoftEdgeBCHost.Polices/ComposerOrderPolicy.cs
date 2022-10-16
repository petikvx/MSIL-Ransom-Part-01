using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ComposerOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralMap()
	{
	}
}
