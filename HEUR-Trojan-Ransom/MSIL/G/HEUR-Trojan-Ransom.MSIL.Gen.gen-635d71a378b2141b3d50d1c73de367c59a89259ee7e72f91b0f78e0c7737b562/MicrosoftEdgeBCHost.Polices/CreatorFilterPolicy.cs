using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CreatorFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FillBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillBridge()
	{
	}
}
