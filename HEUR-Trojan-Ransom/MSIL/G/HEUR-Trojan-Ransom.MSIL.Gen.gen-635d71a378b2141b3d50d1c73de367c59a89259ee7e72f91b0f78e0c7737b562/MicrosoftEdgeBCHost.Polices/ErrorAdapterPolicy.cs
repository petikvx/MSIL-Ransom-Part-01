using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ErrorAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralParameter()
	{
	}
}
