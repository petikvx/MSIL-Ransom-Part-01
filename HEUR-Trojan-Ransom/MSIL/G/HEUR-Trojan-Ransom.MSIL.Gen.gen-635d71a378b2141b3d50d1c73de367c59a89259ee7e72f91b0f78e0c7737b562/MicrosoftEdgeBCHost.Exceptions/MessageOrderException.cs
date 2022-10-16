using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MessageOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceFactory()
	{
	}
}
