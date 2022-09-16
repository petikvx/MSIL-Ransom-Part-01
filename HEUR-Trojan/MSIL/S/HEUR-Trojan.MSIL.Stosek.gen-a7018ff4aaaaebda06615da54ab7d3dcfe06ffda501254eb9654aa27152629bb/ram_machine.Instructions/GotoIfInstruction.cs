using System;
using System.Collections.Generic;

namespace ram_machine.Instructions;

internal class GotoIfInstruction : Instruction
{
	public override int run(int[] tape)
	{
		if (tape[parameters[1]] <= 0)
		{
			return line + 1;
		}
		return parameters[0];
	}

	public override void setParameters(List<int> parameters)
	{
		if (parameters.Count != 2)
		{
			throw GotoIfInstruction.smethod_0("Goto If takes exactly two parameters!");
		}
		base.parameters.Add(parameters[0]);
		base.parameters.Add(parameters[1]);
	}

	public override string ToString()
	{
		return GotoIfInstruction.smethod_1(new string[6]
		{
			line.ToString(),
			". goto ",
			parameters[0].ToString(),
			" if M[",
			parameters[1].ToString(),
			"] > 0"
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
