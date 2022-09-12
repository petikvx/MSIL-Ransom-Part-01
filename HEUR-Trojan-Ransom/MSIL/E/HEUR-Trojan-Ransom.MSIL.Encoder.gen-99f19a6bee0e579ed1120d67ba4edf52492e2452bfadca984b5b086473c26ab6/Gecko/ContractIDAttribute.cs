using System;

namespace Gecko;

public sealed class ContractIDAttribute : Attribute
{
	public readonly string ContractID;

	public ContractIDAttribute(string contractID)
	{
		ContractID = contractID;
	}
}
