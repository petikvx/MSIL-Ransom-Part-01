using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Pharming_v6.My;

namespace Pharming_v6;

[StandardModule]
internal sealed class so
{
	public static void so()
	{
		Module1.osName = ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName();
	}
}
