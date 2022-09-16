using System;

namespace pal.EventLogAnalyzer.ConsoleClient;

internal class CommandLineArgumentHandler
{
	private readonly InputFilterArguments _inputFilterArguments;

	private readonly OutputFilterArguments _outputArguments;

	private readonly ProcessControlArguments _processControlArguments;

	public InputFilterArguments Filters => _inputFilterArguments;

	public ProcessControlArguments ProcessArguments => _processControlArguments;

	public OutputFilterArguments OutputArguments => _outputArguments;

	public CommandLineArgumentHandler()
	{
		_inputFilterArguments = new InputFilterArguments();
		_outputArguments = new OutputFilterArguments();
		_processControlArguments = new ProcessControlArguments();
	}

	public void PickArgument(string argumentSwitch, string argumentParameter)
	{
		if (!IsKnown(argumentSwitch))
		{
			throw new Exception();
		}
		if (_inputFilterArguments.IsKnown(argumentSwitch))
		{
			_inputFilterArguments.Add(argumentSwitch, argumentParameter);
		}
		if (_outputArguments.IsKnown(argumentSwitch))
		{
			_outputArguments.Add(argumentSwitch, argumentParameter);
		}
		else if (_processControlArguments.IsKnown(argumentSwitch))
		{
			_processControlArguments.Add(argumentSwitch, argumentParameter);
		}
	}

	public bool IsKnown(string @switch)
	{
		return _inputFilterArguments.IsKnown(@switch) || _outputArguments.IsKnown(@switch) || _processControlArguments.IsKnown(@switch);
	}
}
