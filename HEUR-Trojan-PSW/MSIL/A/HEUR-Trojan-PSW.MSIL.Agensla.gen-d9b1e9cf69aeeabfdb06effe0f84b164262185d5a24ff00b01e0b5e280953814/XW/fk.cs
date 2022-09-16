using System.Configuration;

namespace XW;

public class fk
{
	private static fk LqF;

	public void eii(string string_0)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		string text = Dca.nJ(Nc4.nJ(Nc4.bcG), "DebugWriteLineEnabled", Dca.ncA);
		if (text == null)
		{
			throw new ConfigurationErrorsException("Please configure the 'DebugWriteLineEnabled' [bool] appSetting.");
		}
		if (FXs.nJ(text, FXs.ncv))
		{
			ayW.nJ(string_0, ayW.qcr);
		}
	}

	public fk()
	{
		G3.nJ(G3.By);
		base._002Ector();
	}

	internal static bool fq7()
	{
		return LqF == null;
	}

	internal static fk GqV()
	{
		return LqF;
	}
}
