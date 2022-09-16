using System;
using System.Collections.Generic;

namespace ram_machine.Instructions;

internal class HaltInstruction : Instruction
{
	public override int run(int[] tape)
	{
		return -1;
	}

	public override void setParameters(List<int> parameters)
	{
		if (parameters.Count > 0)
		{
			throw HaltInstruction.smethod_0("HALT doesn't take any parameters");
		}
	}

	public override string ToString()
	{
		return HaltInstruction.smethod_1(line.ToString(), ". HALT");
	}

	static ArgumentException smethod_0(string string_0)
	{
		return new ArgumentException(string_0);
	}

	static string smethod_1(string string_0, string string_1)
	{
		return string_0 + string_1;
	}
}
