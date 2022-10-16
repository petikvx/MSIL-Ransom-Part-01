using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MockVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockVal()
	{
		WriterPropertyProducer.ResolveStub();
		CreateToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateToken()
	{
	}
}
