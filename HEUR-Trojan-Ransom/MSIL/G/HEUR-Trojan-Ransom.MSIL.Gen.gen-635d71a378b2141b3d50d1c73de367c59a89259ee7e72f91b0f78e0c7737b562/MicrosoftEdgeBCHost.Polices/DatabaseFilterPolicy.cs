using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DatabaseFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyFacade()
	{
	}
}
