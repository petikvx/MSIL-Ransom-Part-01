using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class HelperHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperHelper()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralAdvisor()
	{
	}
}
