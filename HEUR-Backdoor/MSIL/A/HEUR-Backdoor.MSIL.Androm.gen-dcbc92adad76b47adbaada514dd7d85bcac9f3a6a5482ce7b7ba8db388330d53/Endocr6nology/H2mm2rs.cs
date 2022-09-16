using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Dorso0atera0;
using Geologe8s;
using N1grophob1;
using ns4;

namespace Endocr6nology;

public abstract class H2mm2rs : ILogger
{
	[CompilerGenerated]
	private Te3timonie3 Sa8a;

	public Te3timonie3 P1osecution
	{
		[CompilerGenerated]
		get
		{
			return Sa8a;
		}
		[CompilerGenerated]
		set
		{
			Sa8a = value;
		}
	}

	public H2mm2rs()
	{
	}

	public H2mm2rs(Te3timonie3 verbosityLevel)
	{
		P1osecution = verbosityLevel;
	}

	public abstract void Ri7si7g(ILogMessage Me6aliths);

	public abstract Task Black0ody(ILogMessage Re5uses);

	public virtual void vmethod_0(Te3timonie3 Bar1ngs, string Mis6ial)
	{
		if (DisplayMessage(Bar1ngs))
		{
			Ri7si7g(new Extra2agate(Bar1ngs, Mis6ial));
		}
	}

	public virtual Task Gradual1ess(Te3timonie3 Redepos1t1ng, string string_0)
	{
		if (DisplayMessage(Redepos1t1ng))
		{
			return Black0ody(new Extra2agate(Redepos1t1ng, string_0));
		}
		return Task.FromResult(result: true);
	}

	public virtual void vmethod_1(string Fla4)
	{
		vmethod_0(Te3timonie3.Debug, Fla4);
	}

	public virtual void Bisect3rs(string Sooc8ongs)
	{
		vmethod_0(Te3timonie3.Error, Sooc8ongs);
	}

	public virtual void Draw5lates(string A1do1)
	{
		vmethod_0(Te3timonie3.Information, A1do1);
	}

	public virtual void O6tunds(string Innat1n1ss1s)
	{
		vmethod_0(Te3timonie3.Information, Innat1n1ss1s);
	}

	public virtual void Or1eat(string Overstaff4ng)
	{
		vmethod_0(Te3timonie3.Minimal, Overstaff4ng);
	}

	public virtual void Momen5o(string Cl3sters)
	{
		vmethod_0(Te3timonie3.Verbose, Cl3sters);
	}

	public virtual void Parrie2(string Demagoge7)
	{
		vmethod_0(Te3timonie3.Warning, Demagoge7);
	}

	protected virtual bool DisplayMessage(Te3timonie3 messageLevel)
	{
		return messageLevel >= P1osecution;
	}

	protected virtual bool CollectMessage(Te3timonie3 messageLevel)
	{
		return messageLevel >= Te3timonie3.Warning;
	}
}
