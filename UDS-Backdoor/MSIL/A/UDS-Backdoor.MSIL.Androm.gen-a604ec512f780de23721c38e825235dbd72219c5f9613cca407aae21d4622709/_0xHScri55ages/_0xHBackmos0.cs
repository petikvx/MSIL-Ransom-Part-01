using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows.Data;

namespace _0xHScri55ages;

public class _0xHBackmos0 : IValueConverter
{
	public bool _0xHA0ticles { get; set; }

	public bool _0xHWrong5ully { get; set; }

	[SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "interface implementation.")]
	public object _0xHRille2(object _0xHMi1shipman, Type _0xHMon0oe, object _0xH2oomorph, CultureInfo _0xHDisqualifyi8g)
	{
		if (_0xHMi1shipman is string && _0xHWrong5ully)
		{
			return _0xHA0ticles ? string.IsNullOrEmpty(_0xHMi1shipman as string) : (!string.IsNullOrEmpty(_0xHMi1shipman as string));
		}
		return _0xHA0ticles ? (_0xHMi1shipman == null) : (_0xHMi1shipman != null);
	}

	[SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "interface implementation.")]
	public object _0xHSa0vagers(object _0xHHeaddre44, Type _0xHPenkn6ves, object _0xH7olloes, CultureInfo _0xHA5venturesses)
	{
		throw new NotImplementedException();
	}
}
