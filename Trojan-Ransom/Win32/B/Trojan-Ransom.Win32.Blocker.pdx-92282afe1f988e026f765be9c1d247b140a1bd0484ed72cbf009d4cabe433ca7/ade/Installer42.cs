using System;
using System.ComponentModel;
using System.Configuration.Install;

namespace ade;

[RunInstaller(true)]
public class Installer42 : Installer
{
	internal static readonly Installer17.ConvByte _E000;

	private IContainer _E001;

	public Installer42()
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		_E066._E000(this);
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

	static Installer42()
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		Type type = _E01C._E000(typeof(Installer17.ConvByte).TypeHandle);
		Type type2 = _E01C._E000(typeof(Convert).TypeHandle);
		string text = _E067._E000();
		Type[] array = new Type[_E008._E000(1)];
		array[_E008._E000(0)] = _E01C._E000(typeof(int).TypeHandle);
		Installer42._E000 = (Installer17.ConvByte)_E01F._E000(type, _E068._E000(type2, text, array));
	}
}
