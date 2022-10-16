using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TaskClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskClass()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfaceReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfaceReg()
	{
	}
}
