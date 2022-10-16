using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SingletonValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonValDic()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralStub()
	{
	}
}
