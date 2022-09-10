using System.ComponentModel;
using System.Configuration.Install;

namespace ade;

[RunInstaller(true)]
public class Installer2 : Installer
{
	private IContainer m__E000;

	internal static int _E000 => _E02F._E000();

	private static int _E001 => _E030._E000();

	internal static int _E002 => _E008._E000(2);

	public Installer2()
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		_E02E._E000(this);
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

	private void _E000()
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		this.m__E000 = _E017._E000();
	}

	static Installer2()
	{
	}
}
