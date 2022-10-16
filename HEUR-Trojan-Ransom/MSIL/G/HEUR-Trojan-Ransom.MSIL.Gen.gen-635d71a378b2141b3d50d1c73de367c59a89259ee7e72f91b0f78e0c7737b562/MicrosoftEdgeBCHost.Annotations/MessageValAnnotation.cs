using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MessageValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceTask()
	{
	}
}
