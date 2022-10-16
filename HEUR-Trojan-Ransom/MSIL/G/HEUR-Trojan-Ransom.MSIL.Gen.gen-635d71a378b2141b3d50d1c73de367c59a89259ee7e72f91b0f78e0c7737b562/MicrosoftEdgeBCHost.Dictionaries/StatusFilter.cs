using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StatusFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusFilter()
	{
		WriterPropertyProducer.ResolveStub();
		LoginComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginComparator()
	{
	}
}
