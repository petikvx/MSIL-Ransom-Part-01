using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SingletonValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonValException()
	{
		WriterPropertyProducer.ResolveStub();
		AssetGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetGetter()
	{
	}
}
