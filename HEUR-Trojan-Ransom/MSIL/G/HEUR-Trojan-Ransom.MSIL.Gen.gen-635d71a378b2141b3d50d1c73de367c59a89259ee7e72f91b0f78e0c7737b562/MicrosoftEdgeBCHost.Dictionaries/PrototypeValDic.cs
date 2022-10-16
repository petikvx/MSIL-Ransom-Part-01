using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PrototypeValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeValDic()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralSingleton()
	{
	}
}
