using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ErrorAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceConnection()
	{
	}
}
