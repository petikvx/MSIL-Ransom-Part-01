using System;

namespace Orcus.Commands.WindowsCustomizer;

public interface IWindowsPropertyInfo
{
	string Name { get; }

	object Value { get; set; }

	Type DataType { get; }
}
