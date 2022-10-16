using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ConnectionClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionClass()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceFilter()
	{
	}
}
