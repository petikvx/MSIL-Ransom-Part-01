using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParameterValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotLiteralTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotLiteralTemplate()
	{
	}
}
