namespace _111zal2;

public class get_IsTransient
{
	private string Errors;

	private string GatewayIPAddressInformationCollection;

	private Class2.Class4.Class9 class9_0 = new Class2.Class4.Class9();

	public int ControlInformation
	{
		get
		{
			return class9_0.int_0;
		}
		set
		{
			class9_0.int_0 = value;
		}
	}

	public string SxSRequirements
	{
		get
		{
			return Errors;
		}
		set
		{
			Errors = value;
		}
	}

	public string _003CParseRootLevelWhitespaceAsync_003Ed__557
	{
		get
		{
			return GatewayIPAddressInformationCollection;
		}
		set
		{
			GatewayIPAddressInformationCollection = value;
		}
	}
}
