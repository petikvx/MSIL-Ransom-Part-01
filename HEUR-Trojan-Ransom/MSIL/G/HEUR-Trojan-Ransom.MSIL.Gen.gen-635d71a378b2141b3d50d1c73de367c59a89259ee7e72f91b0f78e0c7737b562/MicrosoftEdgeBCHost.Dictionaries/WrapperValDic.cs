using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WrapperValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperValDic()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralInitializer()
	{
	}
}
