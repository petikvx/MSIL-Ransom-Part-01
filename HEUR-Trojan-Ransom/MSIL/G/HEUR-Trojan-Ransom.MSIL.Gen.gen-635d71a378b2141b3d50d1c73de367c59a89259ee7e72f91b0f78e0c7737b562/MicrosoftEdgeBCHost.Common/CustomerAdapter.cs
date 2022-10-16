using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CustomerAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceCode()
	{
	}
}
