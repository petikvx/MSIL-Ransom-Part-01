using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class HelperBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperBridge()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeAttr()
	{
	}
}
