using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CallbackDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackDic()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralDatabase()
	{
	}
}
