using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProcessFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessFilter()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeClient()
	{
	}
}
