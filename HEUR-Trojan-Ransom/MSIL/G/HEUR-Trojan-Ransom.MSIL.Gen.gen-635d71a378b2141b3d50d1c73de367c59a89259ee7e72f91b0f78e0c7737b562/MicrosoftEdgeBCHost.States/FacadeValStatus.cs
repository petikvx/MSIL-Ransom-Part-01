using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FacadeValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralDescriptor()
	{
	}
}
