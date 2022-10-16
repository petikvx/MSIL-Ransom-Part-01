using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ManagerOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceProxy()
	{
	}
}
