using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InitializerRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerRules()
	{
		WriterPropertyProducer.ResolveStub();
		SelectParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectParam()
	{
	}
}
