using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CallbackWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		RunInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInitializer()
	{
	}
}
