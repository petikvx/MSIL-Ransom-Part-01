using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InterceptorAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceError()
	{
	}
}
