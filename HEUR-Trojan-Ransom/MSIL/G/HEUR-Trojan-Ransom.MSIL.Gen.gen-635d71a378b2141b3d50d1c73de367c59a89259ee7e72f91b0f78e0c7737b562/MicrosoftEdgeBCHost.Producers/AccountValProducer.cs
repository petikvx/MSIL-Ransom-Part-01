using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AccountValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		AddComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddComparator()
	{
	}
}
