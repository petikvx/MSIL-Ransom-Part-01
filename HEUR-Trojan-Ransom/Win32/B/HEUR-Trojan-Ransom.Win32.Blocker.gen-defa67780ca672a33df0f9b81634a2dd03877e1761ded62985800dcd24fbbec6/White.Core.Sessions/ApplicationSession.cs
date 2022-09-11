using System;
using System.Collections.Generic;
using White.Core.Factory;

namespace White.Core.Sessions;

public class ApplicationSession : IDisposable
{
	private Application application;

	private readonly Dictionary<string, WindowSession> windowSessions = new Dictionary<string, WindowSession>();

	public virtual Application Application => application;

	internal virtual void Register(Application associatedApplication)
	{
		application = associatedApplication;
	}

	public virtual void Dispose()
	{
		if (!application.HasExited)
		{
			application.Kill();
		}
	}

	public virtual WindowSession WindowSession(InitializeOption initializeOption)
	{
		if (initializeOption.Identifier == null)
		{
			return new NullWindowSession();
		}
		if (windowSessions.TryGetValue(initializeOption.Identifier, out var value))
		{
			return value;
		}
		value = new WindowSession(this, initializeOption);
		windowSessions.Add(initializeOption.Identifier, value);
		return value;
	}

	public virtual void Save()
	{
		foreach (WindowSession value in windowSessions.Values)
		{
			value.Dispose();
		}
	}
}
