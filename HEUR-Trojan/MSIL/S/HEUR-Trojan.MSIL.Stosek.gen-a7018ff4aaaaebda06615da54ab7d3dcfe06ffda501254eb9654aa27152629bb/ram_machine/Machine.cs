using System;
using System.Collections.Generic;
using ram_machine.Instructions;

namespace ram_machine;

internal class Machine
{
	private int[] tape;

	private List<Instruction> instructions;

	private int current_line;

	public Machine(int size)
	{
		tape = new int[size];
		for (int i = 0; i < size; i++)
		{
			tape[i] = 0;
		}
		instructions = new List<Instruction>();
		current_line = 0;
	}

	public void addInstruction(Instruction i)
	{
		i.setLine(instructions.Count);
		instructions.Add(i);
	}

	public void insertInput(int[] input)
	{
		if (input.Length > tape.Length)
		{
			throw Machine.smethod_0();
		}
		for (int i = 0; i < input.Length; i++)
		{
			tape[i] = input[i];
		}
	}

	public int[] getTape()
	{
		return tape;
	}

	public bool runOneInstruction()
	{
		if (current_line == -1)
		{
			return false;
		}
		return true;
	}

	public void runUntilHalt()
	{
		while (runOneInstruction())
		{
		}
	}

	public string getInstructionsString()
	{
		string text = "";
		foreach (Instruction instruction in instructions)
		{
			text = Machine.smethod_1(text, instruction.ToString(), "\n");
		}
		if (instructions.Count == 0)
		{
			text = "empty";
		}
		return text;
	}

	public static Machine getSampleMachine()
	{
		Machine machine = new Machine(6);
		Instruction instruction = new AddInstruction();
		List<int> list = new List<int>();
		list.Add(2);
		list.Add(3);
		list.Add(0);
		instruction.setParameters(list);
		machine.addInstruction(instruction);
		Instruction instruction2 = new AssignValueInstruction();
		list.Clear();
		list.Add(4);
		list.Add(1);
		instruction2.setParameters(list);
		machine.addInstruction(instruction2);
		Instruction instruction3 = new GotoIfInstruction();
		list.Clear();
		list.Add(5);
		list.Add(2);
		instruction3.setParameters(list);
		machine.addInstruction(instruction3);
		Instruction instruction4 = new AddInstruction();
		list.Clear();
		list.Add(0);
		list.Add(3);
		list.Add(5);
		instruction4.setParameters(list);
		machine.addInstruction(instruction4);
		Instruction i = new HaltInstruction();
		machine.addInstruction(i);
		Instruction instruction5 = new AddInstruction();
		list.Clear();
		list.Add(3);
		list.Add(3);
		list.Add(1);
		instruction5.setParameters(list);
		machine.addInstruction(instruction5);
		Instruction instruction6 = new SubstractInstruction();
		list.Clear();
		list.Add(2);
		list.Add(2);
		list.Add(4);
		instruction6.setParameters(list);
		machine.addInstruction(instruction6);
		Instruction instruction7 = new GotoIfInstruction();
		list.Clear();
		list.Add(2);
		list.Add(4);
		instruction7.setParameters(list);
		machine.addInstruction(instruction7);
		int[] input = new int[2] { 5, 6 };
		machine.insertInput(input);
		return machine;
	}

	static ArgumentOutOfRangeException smethod_0()
	{
		return new ArgumentOutOfRangeException();
	}

	static string smethod_1(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}
}
