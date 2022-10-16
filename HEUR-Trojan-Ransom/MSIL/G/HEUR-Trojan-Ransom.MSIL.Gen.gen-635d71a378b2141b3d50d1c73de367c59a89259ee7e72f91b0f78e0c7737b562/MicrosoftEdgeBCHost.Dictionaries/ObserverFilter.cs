using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ObserverFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverFilter()
	{
		WriterPropertyProducer.ResolveStub();
		LoginMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginMock()
	{
	}
}
