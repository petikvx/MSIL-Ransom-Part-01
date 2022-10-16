using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ConnectionValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PopInterfaceContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopInterfaceContainer()
	{
	}
}
