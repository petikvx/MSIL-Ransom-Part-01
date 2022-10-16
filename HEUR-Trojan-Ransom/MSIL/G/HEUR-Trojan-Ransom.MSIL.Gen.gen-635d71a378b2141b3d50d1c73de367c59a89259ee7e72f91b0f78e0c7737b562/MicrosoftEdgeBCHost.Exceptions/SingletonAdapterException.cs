using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SingletonAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceStruct()
	{
	}
}
