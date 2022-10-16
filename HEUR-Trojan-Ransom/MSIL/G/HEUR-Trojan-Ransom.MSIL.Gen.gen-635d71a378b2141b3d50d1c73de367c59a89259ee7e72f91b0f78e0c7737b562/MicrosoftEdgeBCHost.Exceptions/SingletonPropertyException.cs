using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SingletonPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralRules()
	{
	}
}
