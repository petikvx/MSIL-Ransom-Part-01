using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StubFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubFacade()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralReg()
	{
	}
}
