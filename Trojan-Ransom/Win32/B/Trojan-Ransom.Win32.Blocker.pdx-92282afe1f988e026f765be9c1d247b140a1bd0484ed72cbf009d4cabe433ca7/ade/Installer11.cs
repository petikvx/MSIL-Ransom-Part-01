using System;
using System.ComponentModel;
using System.Configuration.Install;

namespace ade;

public class Installer11 : Installer
{
	internal static readonly Installer35.BCToUInt64 _E000;

	private IContainer _E001;

	public Installer11()
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		_E01B._E000(this);
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

	static Installer11()
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		Installer11._E000 = (Installer35.BCToUInt64)_E01F._E000(_E01C._E000(typeof(Installer35.BCToUInt64).TypeHandle), _E01E._E000(_E01C._E000(typeof(BitConverter).TypeHandle), _E01D._E000()));
	}
}
