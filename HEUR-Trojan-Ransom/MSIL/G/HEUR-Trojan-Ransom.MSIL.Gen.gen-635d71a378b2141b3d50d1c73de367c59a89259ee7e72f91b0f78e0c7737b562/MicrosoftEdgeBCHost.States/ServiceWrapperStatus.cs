using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal sealed class ServiceWrapperStatus
{
	internal static object _Policy;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PopServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopServer()
	{
	}
}
