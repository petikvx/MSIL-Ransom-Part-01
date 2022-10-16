using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ObjectAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceRules()
	{
	}
}
