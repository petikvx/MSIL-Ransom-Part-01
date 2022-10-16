using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SingletonClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonClass()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceClass()
	{
	}
}
