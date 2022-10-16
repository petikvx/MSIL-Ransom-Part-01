using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RequestUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestUtils()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceMapper()
	{
	}
}
