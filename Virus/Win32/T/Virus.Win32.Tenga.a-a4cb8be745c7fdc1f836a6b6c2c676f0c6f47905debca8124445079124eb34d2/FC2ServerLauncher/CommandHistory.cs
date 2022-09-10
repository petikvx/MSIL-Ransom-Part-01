using System.Collections;

namespace FC2ServerLauncher;

internal class CommandHistory
{
	private int currentPosn;

	private string lastCommand;

	private string lastFind;

	private ArrayList commandHistory = new ArrayList();

	internal string LastFind
	{
		get
		{
			return lastFind;
		}
		set
		{
			lastFind = value;
		}
	}

	internal string LastCommand => lastCommand;

	internal CommandHistory()
	{
		lastFind = "";
	}

	internal void Add(string command)
	{
		if (command != lastCommand)
		{
			commandHistory.Add(command);
			lastCommand = command;
			currentPosn = commandHistory.Count;
		}
	}

	internal bool DoesPreviousCommandExist()
	{
		return currentPosn > 0;
	}

	internal bool DoesNextCommandExist()
	{
		return currentPosn < commandHistory.Count - 1;
	}

	internal string GetPreviousCommand()
	{
		lastCommand = (string)commandHistory[--currentPosn];
		return lastCommand;
	}

	internal string GetNextCommand()
	{
		lastCommand = (string)commandHistory[++currentPosn];
		return LastCommand;
	}

	internal string[] GetCommandHistory()
	{
		return (string[])commandHistory.ToArray(typeof(string));
	}
}
