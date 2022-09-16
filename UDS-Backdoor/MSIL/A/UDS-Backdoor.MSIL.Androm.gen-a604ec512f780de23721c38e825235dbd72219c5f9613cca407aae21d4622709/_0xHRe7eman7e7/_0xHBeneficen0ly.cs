using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace _0xHRe7eman7e7;

public class _0xHBeneficen0ly : IValueConverter
{
	public bool _0xHP4otecto4s { get; set; }

	public bool _0xH0ormlike { get; set; }

	[SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "interface implementation.")]
	public object _0xHSig1alma1(object _0xHTangl5ng, Type _0xHBewitc1ing, object _0xH2ustify, CultureInfo _0xH1alium)
	{
		bool flag = _0xHTangl5ng != null;
		if (_0xHP4otecto4s)
		{
			flag = !flag;
		}
		if (flag)
		{
			return (object)(Visibility)0;
		}
		return (object)(Visibility)(_0xH0ormlike ? 1 : 2);
	}

	[SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "interface implementation.")]
	public object _0xHFree3ase(object _0xHGladia3e, Type _0xHOt7erw7ere, object _0xHExaggera1ion, CultureInfo _0xHAmi2ogen)
	{
		throw new NotImplementedException();
	}
}
