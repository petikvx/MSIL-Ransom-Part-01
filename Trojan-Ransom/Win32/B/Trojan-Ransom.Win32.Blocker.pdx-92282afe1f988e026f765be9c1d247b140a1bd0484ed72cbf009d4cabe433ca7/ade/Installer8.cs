using System.ComponentModel;
using System.Configuration.Install;

namespace ade;

[RunInstaller(true)]
public class Installer8 : Installer
{
	private IContainer m__E000;

	internal static string _E000 => _E087._E000();

	public Installer8()
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		_E086._E000(this);
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

	internal static int _E001(int _E000)
	{
		return _E000 switch
		{
			31 => -3, 
			24 => -1, 
			25 => -64, 
			32 => -16, 
			26 => -4, 
			_ => -1, 
		};
	}
}
