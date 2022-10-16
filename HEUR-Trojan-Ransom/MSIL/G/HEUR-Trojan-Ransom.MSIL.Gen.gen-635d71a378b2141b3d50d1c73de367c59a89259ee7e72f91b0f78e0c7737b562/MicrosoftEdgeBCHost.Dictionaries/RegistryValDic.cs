using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RegistryValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryValDic()
	{
		WriterPropertyProducer.ResolveStub();
		GetLiteralProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetLiteralProducer()
	{
	}
}
