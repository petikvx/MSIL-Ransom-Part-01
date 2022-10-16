using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ObserverDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverDic()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralDatabase()
	{
	}
}
