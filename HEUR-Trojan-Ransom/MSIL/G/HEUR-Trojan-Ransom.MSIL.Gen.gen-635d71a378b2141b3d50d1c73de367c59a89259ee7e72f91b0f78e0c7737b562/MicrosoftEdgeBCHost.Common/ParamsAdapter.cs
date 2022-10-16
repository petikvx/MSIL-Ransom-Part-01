using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParamsAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceIssuer()
	{
	}
}
