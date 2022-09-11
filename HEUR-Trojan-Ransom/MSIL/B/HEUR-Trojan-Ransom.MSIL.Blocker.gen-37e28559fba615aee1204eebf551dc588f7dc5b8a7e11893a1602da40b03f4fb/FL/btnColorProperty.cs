using System.Collections;
using System.ComponentModel;
using Microsoft.VisualBasic;

namespace FL;

public class btnColorProperty : StringConverter
{
	public btnColorProperty()
	{
		Class8.t3hvLuccnmfIO();
		Class8.t3hvLuccnmfIO();
		base._002Ector();
	}

	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
	{
		return new StandardValuesCollection(method_0());
	}

	public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
	{
		return true;
	}

	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
	{
		return true;
	}

	private IList method_0()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Collection val = new Collection();
		Collection val2 = val;
		val2.Add((object)"Light", (string)null, (object)null, (object)null);
		val2.Add((object)"Dark", (string)null, (object)null, (object)null);
		val2 = null;
		return (IList)val;
	}
}
