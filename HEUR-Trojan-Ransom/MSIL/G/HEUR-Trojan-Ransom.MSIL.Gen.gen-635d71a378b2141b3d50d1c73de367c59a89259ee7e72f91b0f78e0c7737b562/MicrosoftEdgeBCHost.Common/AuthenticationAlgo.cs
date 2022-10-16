using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AuthenticationAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralStatus()
	{
	}
}
