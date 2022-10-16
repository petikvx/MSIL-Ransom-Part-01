using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AdvisorFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorFilter()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterIterator()
	{
	}
}
