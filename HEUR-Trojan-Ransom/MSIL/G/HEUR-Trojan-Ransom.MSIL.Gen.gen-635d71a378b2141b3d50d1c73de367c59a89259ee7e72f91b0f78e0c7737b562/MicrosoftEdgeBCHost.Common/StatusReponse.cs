using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StatusReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusReponse()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralMethod()
	{
	}
}
