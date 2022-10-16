using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FilterContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterContext()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceClient()
	{
	}
}
