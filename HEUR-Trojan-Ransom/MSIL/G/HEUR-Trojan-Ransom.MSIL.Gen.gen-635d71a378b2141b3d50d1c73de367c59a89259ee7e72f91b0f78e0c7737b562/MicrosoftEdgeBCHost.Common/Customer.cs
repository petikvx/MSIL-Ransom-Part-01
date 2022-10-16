using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Customer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Customer()
	{
		WriterPropertyProducer.ResolveStub();
		ViewMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewMapping()
	{
	}
}
