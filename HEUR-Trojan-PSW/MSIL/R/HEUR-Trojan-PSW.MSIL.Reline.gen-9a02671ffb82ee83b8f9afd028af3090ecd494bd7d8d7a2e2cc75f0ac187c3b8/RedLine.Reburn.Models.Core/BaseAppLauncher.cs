using System;
using System.Collections.Generic;
using System.Linq;
using RedLine.Reburn.Data.Core.LogParsers;
using RedLine.Reburn.Data.Extensions;

namespace RedLine.Reburn.Models.Core;

public abstract class BaseAppLauncher : IDisposable
{
	protected BaseAppLauncher(IEnumerable<IFileShield> fileShields = null)
	{
		foreach (IFileShield item in fileShields.IsNull<IEnumerable<IFileShield>>(Enumerable.Empty<IFileShield>()))
		{
			if (!item.Verify())
			{
				Dispose();
			}
		}
	}

	public abstract BaseAppLauncher Init(ICommunicator communicator);

	public abstract BaseAppLauncher Prepere(BaseLogParser logParser);

	public abstract BaseAppLauncher Report();

	public abstract void Dispose();
}
