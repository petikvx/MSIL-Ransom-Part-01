using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AdapterWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		SetCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetCustomer()
	{
	}
}
