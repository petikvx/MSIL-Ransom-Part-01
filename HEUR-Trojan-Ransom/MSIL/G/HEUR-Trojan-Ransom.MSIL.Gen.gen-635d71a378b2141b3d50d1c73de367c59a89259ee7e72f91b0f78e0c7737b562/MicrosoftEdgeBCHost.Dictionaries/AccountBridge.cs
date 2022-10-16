using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AccountBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountBridge()
	{
		WriterPropertyProducer.ResolveStub();
		CalcResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcResolver()
	{
	}
}
