using System;
using System.Collections.Generic;

namespace ram_machine.Instructions;

internal class AssignValueInstruction : Instruction
{
	public override int run(int[] tape)
	{
		tape[parameters[0]] = parameters[1];
		return line + 1;
	}

	public override void setParameters(List<int> parameters)
	{
		if (parameters.Count != 2)
		{
			throw AssignValueInstruction.smethod_0("Assign Value takes exactly two parameters!");
		}
		base.parameters.Add(parameters[0]);
		base.parameters.Add(parameters[1]);
	}

	public override string ToString()
	{
		return AssignValueInstruction.smethod_1(new string[5]
		{
			line.ToString(),
			". M[",
			parameters[0].ToString(),
			"] = ",
			parameters[1].ToString()
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
