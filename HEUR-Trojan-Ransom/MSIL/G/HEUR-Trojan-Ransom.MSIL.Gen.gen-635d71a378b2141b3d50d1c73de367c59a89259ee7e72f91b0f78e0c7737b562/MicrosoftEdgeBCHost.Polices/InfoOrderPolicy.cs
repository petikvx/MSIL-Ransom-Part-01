using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InfoOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralCode()
	{
	}
}
