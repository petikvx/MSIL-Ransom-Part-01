using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AuthenticationOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralRecord()
	{
	}
}
