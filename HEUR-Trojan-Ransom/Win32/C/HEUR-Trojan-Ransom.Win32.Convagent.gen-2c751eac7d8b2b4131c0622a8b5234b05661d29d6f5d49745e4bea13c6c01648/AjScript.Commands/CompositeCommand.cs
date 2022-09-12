using System.Collections.Generic;

namespace AjScript.Commands;

public class CompositeCommand : ICommand
{
	private ICollection<ICommand> hoistedCommands;

	private ICollection<ICommand> commands;

	public int CommandCount
	{
		get
		{
			if (commands == null)
			{
				return 0;
			}
			return commands.Count;
		}
	}

	public ICollection<ICommand> Commands => commands;

	public int HoistedCommandCount
	{
		get
		{
			if (hoistedCommands == null)
			{
				return 0;
			}
			return hoistedCommands.Count;
		}
	}

	public ICollection<ICommand> HoistedCommands => hoistedCommands;

	public CompositeCommand(ICollection<ICommand> commands)
		: this(null, commands)
	{
	}

	public CompositeCommand(ICollection<ICommand> hoistedCommands, ICollection<ICommand> commands)
	{
		this.hoistedCommands = hoistedCommands;
		this.commands = commands;
	}

	public virtual void Execute(IContext context)
	{
		if (hoistedCommands != null)
		{
			foreach (ICommand hoistedCommand in hoistedCommands)
			{
				hoistedCommand.Execute(context);
			}
		}
		foreach (ICommand command in commands)
		{
			command.Execute(context);
			if (context.ReturnValue != null)
			{
				break;
			}
		}
	}
}
