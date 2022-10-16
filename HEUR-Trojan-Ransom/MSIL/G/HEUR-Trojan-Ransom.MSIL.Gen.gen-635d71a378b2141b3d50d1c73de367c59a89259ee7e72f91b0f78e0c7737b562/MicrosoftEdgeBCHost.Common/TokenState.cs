using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TokenState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenState()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceConfiguration()
	{
	}
}
