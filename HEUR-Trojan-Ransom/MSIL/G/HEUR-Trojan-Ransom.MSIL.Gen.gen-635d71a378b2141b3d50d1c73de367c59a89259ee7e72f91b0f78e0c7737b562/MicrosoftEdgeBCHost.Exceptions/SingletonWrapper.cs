using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SingletonWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectService()
	{
	}
}
