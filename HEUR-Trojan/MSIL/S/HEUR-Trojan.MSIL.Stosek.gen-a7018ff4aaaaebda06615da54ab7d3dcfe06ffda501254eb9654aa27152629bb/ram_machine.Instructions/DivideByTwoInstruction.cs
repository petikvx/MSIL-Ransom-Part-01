using System;
using System.Collections.Generic;

namespace ram_machine.Instructions;

internal class DivideByTwoInstruction : Instruction
{
	public override int run(int[] tape)
	{
		tape[parameters[0]] = tape[parameters[0]] / 2;
		return line + 1;
	}

	public override void setParameters(List<int> parameters)
	{
		if (parameters.Count != 1)
		{
			throw DivideByTwoInstruction.smethod_0("Divide By Two takes exactly one parameter!");
		}
		base.parameters.Add(parameters[0]);
	}

	public override string ToString()
	{
		return DivideByTwoInstruction.smethod_1(new string[6]
		{
			line.ToString(),
			". M[",
			parameters[0].ToString(),
			"] = floor(M[",
			parameters[0].ToString(),
			"]/2)"
		});
	}

	static ArgumentException smethod_0(string string_0)
	{
		return new ArgumentException(string_0);
	}

	static string smethod_1(string[] string_0)
	{
		return string.Concat(string_0);
	}
}
