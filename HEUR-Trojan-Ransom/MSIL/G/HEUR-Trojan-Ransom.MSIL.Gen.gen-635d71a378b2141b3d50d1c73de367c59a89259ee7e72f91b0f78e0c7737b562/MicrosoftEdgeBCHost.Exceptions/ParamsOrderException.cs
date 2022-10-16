using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParamsOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceEvent()
	{
	}
}
