using System.ComponentModel;
using System.Configuration.Install;

namespace ade;

[RunInstaller(true)]
public class Installer41 : Installer
{
	internal static byte[] _E000;

	private IContainer _E001;

	internal static string _E000 => "ToInt32";

	public Installer41()
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		_E065._E000(this);
	}

	protected override void Dispose(bool disposing)
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		if ((disposing || 1 == 0) && (_E001 != null || 1 == 0))
		{
			_E015._E000(_E001);
		}
		_E016._E000(this, disposing);
	}

	private void _E000()
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		_E001 = _E017._E000();
	}

	static Installer41()
	{
	}
}
