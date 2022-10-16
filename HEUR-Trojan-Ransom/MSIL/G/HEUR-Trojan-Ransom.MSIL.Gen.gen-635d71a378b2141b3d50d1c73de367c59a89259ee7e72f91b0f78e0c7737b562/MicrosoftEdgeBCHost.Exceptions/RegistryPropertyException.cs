using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RegistryPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralOrder()
	{
	}
}
