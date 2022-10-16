using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FilterAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterfaceMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterfaceMethod()
	{
	}
}
