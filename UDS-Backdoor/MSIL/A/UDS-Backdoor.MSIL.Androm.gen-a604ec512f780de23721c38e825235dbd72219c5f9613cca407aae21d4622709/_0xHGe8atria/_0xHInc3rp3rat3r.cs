using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace _0xHGe8atria;

public class _0xHInc3rp3rat3r : IValueConverter
{
	public bool _0xHPho0eyed { get; set; }

	public bool _0xHU4bo { get; set; }

	[SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "interface implementation.")]
	public object _0xHNon2n2tomic(object _0xHSp6ca, Type _0xH3ilder, object _0xHDeioni1ing, CultureInfo _0xH4aleen)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		double num = (double)((TypeConverter)new FontSizeConverter()).ConvertFrom(_0xHSp6ca);
		if (_0xHPho0eyed)
		{
			return num * Convert.ToDouble(_0xHDeioni1ing, CultureInfo.InvariantCulture);
		}
		if (_0xHU4bo)
		{
			return num - (double)((TypeConverter)new FontSizeConverter()).ConvertFrom(_0xHDeioni1ing);
		}
		return num + (double)((TypeConverter)new FontSizeConverter()).ConvertFrom(_0xHDeioni1ing);
	}

	[SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "interface implementation.")]
	public object _0xHPe4ve4seness(object _0xHS5uden5ship, Type _0xHTipl4ss, object _0xHFi0gerpri0ti0g, CultureInfo _0xHAph3gi3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		double num = (double)((TypeConverter)new FontSizeConverter()).ConvertFrom(_0xHS5uden5ship);
		if (_0xHPho0eyed)
		{
			return num / Convert.ToDouble(_0xHFi0gerpri0ti0g, CultureInfo.InvariantCulture);
		}
		if (_0xHU4bo)
		{
			return num + (double)((TypeConverter)new FontSizeConverter()).ConvertFrom(_0xHFi0gerpri0ti0g);
		}
		return num - (double)((TypeConverter)new FontSizeConverter()).ConvertFrom(_0xHFi0gerpri0ti0g);
	}
}
