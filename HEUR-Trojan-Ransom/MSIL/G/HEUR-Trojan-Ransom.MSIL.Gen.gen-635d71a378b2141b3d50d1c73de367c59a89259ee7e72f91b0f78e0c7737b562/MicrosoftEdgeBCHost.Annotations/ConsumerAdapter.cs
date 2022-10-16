using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ConsumerAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceError()
	{
	}
}
