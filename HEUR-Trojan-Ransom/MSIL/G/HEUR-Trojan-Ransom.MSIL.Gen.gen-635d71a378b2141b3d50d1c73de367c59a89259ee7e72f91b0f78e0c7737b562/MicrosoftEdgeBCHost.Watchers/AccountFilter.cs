using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AccountFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountFilter()
	{
		WriterPropertyProducer.ResolveStub();
		DefineMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineMock()
	{
	}
}
