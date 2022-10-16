using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ErrorRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorRules()
	{
		WriterPropertyProducer.ResolveStub();
		LoginDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginDispatcher()
	{
	}
}
