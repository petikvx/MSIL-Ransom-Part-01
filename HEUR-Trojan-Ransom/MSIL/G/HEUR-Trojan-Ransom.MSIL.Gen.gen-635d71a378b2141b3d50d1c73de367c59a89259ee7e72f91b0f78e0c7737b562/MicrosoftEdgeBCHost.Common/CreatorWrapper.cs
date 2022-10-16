using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CreatorWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeBridge()
	{
	}
}
