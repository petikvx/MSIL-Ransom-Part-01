using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TaskAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceHelper()
	{
	}
}
