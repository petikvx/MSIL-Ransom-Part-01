using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class FacadeBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeBridge()
	{
		WriterPropertyProducer.ResolveStub();
		PatchAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchAttr()
	{
	}
}
