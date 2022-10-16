using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ServerUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerUtils()
	{
		WriterPropertyProducer.ResolveStub();
		InitInterfaceParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInterfaceParser()
	{
	}
}
