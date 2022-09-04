using System.ComponentModel;
using System.Windows.Forms;

namespace 哽峠_2F23ㅑ䉨氃枞_222E;

public class _3820 : Control
{
	internal static aa1.膤瘇ǌஐ蓷㪢 _E000;

	private IContainer _E001;

	public _3820()
	{
		_E000();
	}

	protected override void ᬎ䔮ἵ_4DF9ࣆ㟐(PaintEventArgs pe)
	{
		_E004._E000(this, pe);
	}

	protected override void ᬎ䔮ἵ_4DF9ࣆ㟐(bool disposing)
	{
		if (disposing && _E001 != null)
		{
			_E005._E000(_E001);
		}
		_E006._E000(this, disposing);
	}

	private void _E000()
	{
		_E001 = _E007._E000();
	}

	static _3820()
	{
		_3820._E000 = (aa1.膤瘇ǌஐ蓷㪢)_E00B._E000(_E008._E000(typeof(aa1.膤瘇ǌஐ蓷㪢).TypeHandle), _152._E000, _15b18._E000);
	}
}
