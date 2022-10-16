using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RulesAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralCode()
	{
	}
}
