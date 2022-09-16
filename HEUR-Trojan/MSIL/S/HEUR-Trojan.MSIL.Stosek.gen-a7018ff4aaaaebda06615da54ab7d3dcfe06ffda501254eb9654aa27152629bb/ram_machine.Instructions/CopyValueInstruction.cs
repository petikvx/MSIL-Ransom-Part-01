using System;
using System.Collections.Generic;

namespace ram_machine.Instructions;

internal class CopyValueInstruction : Instruction
{
	public override int run(int[] tape)
	{
		tape[parameters[0]] = tape[tape[parameters[1]]];
		return line + 1;
	}

	public override void setParameters(List<int> parameters)
	{
		if (parameters.Count != 2)
		{
			throw CopyValueInstruction.smethod_0("Copy Value takes exactly two parameters!");
		}
		base.parameters.Add(parameters[0]);
		base.parameters.Add(parameters[1]);
	}

	public override string ToString()
	{
		return CopyValueInstruction.smethod_1(new string[6]
		{
			line.ToString(),
			". M[",
			parameters[0].ToString(),
			"] = M[M[",
			parameters[1].ToString(),
			"]]"
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
