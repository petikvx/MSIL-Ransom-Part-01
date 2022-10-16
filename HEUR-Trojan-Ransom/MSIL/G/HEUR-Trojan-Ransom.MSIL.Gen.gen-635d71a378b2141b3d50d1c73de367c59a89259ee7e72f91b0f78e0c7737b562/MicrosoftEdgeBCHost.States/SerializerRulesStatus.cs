using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SerializerRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterceptor()
	{
	}
}
