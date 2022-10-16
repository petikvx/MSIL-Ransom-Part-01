using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConnectionUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CloneInterfaceExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneInterfaceExporter()
	{
	}
}
