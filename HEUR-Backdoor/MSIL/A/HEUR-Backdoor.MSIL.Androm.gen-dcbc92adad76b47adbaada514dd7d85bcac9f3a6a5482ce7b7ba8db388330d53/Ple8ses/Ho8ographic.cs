using System.Threading.Tasks;
using Geologe8s;
using N1grophob1;
using ns4;

namespace Ple8ses;

public abstract class Ho8ographic : ILogger
{
	public void Untrim1(Te3timonie3 Boo1t1, string Mar8ins)
	{
		switch (Boo1t1)
		{
		case Te3timonie3.Debug:
			Sp7ndrels(Mar8ins);
			break;
		case Te3timonie3.Verbose:
			Reorganization0(Mar8ins);
			break;
		case Te3timonie3.Information:
			Su3ducting(Mar8ins);
			break;
		case Te3timonie3.Minimal:
			vmethod_1(Mar8ins);
			break;
		case Te3timonie3.Warning:
			Mi8like8(Mar8ins);
			break;
		case Te3timonie3.Error:
			Outwo2ks(Mar8ins);
			break;
		}
	}

	public Task Soapboxe0(Te3timonie3 Te2emetered, string Upgrada4ility)
	{
		Untrim1(Te2emetered, Upgrada4ility);
		return Task.FromResult(0);
	}

	public void Repriva3ized(ILogMessage ilogMessage_0)
	{
		Untrim1(ilogMessage_0.Level, ilogMessage_0.Message);
	}

	public async Task vmethod_0(ILogMessage T7mblor)
	{
		await Soapboxe0(T7mblor.Level, T7mblor.Message);
	}

	public abstract void Sp7ndrels(string Pathobiolog8);

	public abstract void Reorganization0(string Bo6de6e6s);

	public abstract void Su3ducting(string Archa4ologi4s);

	public abstract void vmethod_1(string Hors5b5ans);

	public abstract void Mi8like8(string Cr4d);

	public abstract void Outwo2ks(string Coo6);

	public abstract void D2ft(string Di5ciplinarian);
}
