using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AuthenticationWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationWorker()
	{
		WriterPropertyProducer.ResolveStub();
		RateDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateDatabase()
	{
	}
}
