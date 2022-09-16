using System;
using System.Collections.Generic;

namespace ram_machine.Instructions;

internal class AddInstruction : Instruction
{
	public override int run(int[] tape)
	{
		tape[parameters[0]] = tape[parameters[1]] + tape[parameters[2]];
		return line + 1;
	}

	public override void setParameters(List<int> parameters)
	{
		if (parameters.Count != 3)
		{
			throw AddInstruction.smethod_0("Add takes exactly three parameters!");
		}
		base.parameters.Add(parameters[0]);
		base.parameters.Add(parameters[1]);
		base.parameters.Add(parameters[2]);
	}

	public override string ToString()
	{
		return AddInstruction.smethod_1(new string[8]
		{
			line.ToString(),
			". M[",
			parameters[0].ToString(),
			"] = M[",
			parameters[1].ToString(),
			"] + M[",
			parameters[2].ToString(),
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
