using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ConfigOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceDescriptor()
	{
	}
}
