using System;
using System.Collections.Generic;

namespace ram_machine.Instructions;

internal class CopyValue2Instruction : Instruction
{
	public override int run(int[] tape)
	{
		tape[tape[parameters[0]]] = tape[parameters[1]];
		return line + 1;
	}

	public override void setParameters(List<int> parameters)
	{
		if (parameters.Count != 2)
		{
			throw CopyValue2Instruction.smethod_0("Copy Value 2 takes exactly two parameters!");
		}
		base.parameters.Add(parameters[0]);
		base.parameters.Add(parameters[1]);
	}

	public override string ToString()
	{
		return CopyValue2Instruction.smethod_1(new string[6]
		{
			line.ToString(),
			". M[M[",
			parameters[0].ToString(),
			"]] = M[",
			parameters[1].ToString(),
			"]"
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
