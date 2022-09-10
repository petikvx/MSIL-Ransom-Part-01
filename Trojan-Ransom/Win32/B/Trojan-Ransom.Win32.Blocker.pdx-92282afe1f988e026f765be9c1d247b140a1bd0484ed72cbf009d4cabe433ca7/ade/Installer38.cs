using System.ComponentModel;
using System.Configuration.Install;

namespace ade;

[RunInstaller(true)]
public class Installer38 : Installer
{
	private IContainer m__E000;

	public Installer38()
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		_E060._E000(this);
	}

	internal static int _E000()
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		return Installer23._E000 = _E008._E000(0);
	}

	protected override void Dispose(bool disposing)
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		if ((disposing || 1 == 0) && (this.m__E000 != null || 1 == 0))
		{
			_E015._E000(this.m__E000);
		}
		_E016._E000(this, disposing);
	}

	private void _E001()
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		this.m__E000 = _E017._E000();
	}

	static Installer38()
	{
	}
}
