using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SerializerValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralCustomer()
	{
	}
}
