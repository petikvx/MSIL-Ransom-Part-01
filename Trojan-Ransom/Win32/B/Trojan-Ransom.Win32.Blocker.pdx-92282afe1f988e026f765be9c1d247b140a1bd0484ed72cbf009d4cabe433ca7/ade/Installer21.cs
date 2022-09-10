using System.ComponentModel;
using System.Configuration.Install;

namespace ade;

public class Installer21 : Installer
{
	private IContainer m__E000;

	public Installer21()
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		_E033._E000(this);
	}

	internal static void _E000()
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		Installer6.sefg sefg = (Installer6.sefg)_E036._E000(_E01C._E000(typeof(Installer6.sefg).TypeHandle), _E034._E000(), _E035._E000());
		_E037._E000(sefg);
	}

	private static void Main()
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		_E038._E000();
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

	static Installer21()
	{
		_E009._E000();
	}
}
