using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class VisitorRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorRules()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateProperty()
	{
	}
}
