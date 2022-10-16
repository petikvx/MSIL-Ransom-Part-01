using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RulesFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesFilter()
	{
		WriterPropertyProducer.ResolveStub();
		CreatePage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreatePage()
	{
	}
}
