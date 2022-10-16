using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WrapperFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperFilter()
	{
		WriterPropertyProducer.ResolveStub();
		StopPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopPage()
	{
	}
}
