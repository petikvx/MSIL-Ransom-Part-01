using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SingletonValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SetLiteralDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetLiteralDispatcher()
	{
	}
}
