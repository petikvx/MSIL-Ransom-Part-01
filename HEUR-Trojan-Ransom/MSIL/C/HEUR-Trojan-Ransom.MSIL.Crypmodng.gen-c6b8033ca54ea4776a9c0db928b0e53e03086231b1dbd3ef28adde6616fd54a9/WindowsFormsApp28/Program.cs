using System.Collections;
using System.Linq;
using System.Management;

namespace WindowsFormsApp28;

internal class Program
{
	private static void Main()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		string s = "";
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT UserName FROM Win32_ComputerSystem");
			ManagementObjectCollection source = val.Get();
			s = (string)((IEnumerable)source).Cast<ManagementBaseObject>().First().get_Item("UserName");
		}
		catch
		{
		}
		Debug.Analysis(s);
	}
}
