using System.ServiceProcess;

namespace eRecoveryService;

internal static class Program
{
	private static void Main()
	{
		ServiceBase[] array = (ServiceBase[])(object)new ServiceBase[1]
		{
			new Service1()
		};
		ServiceBase.Run(array);
	}
}
