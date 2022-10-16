using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DatabaseFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseFilter()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectClient()
	{
	}
}
