using System;
using Org.BouncyCastle.Asn1.X500;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.IsisMtt.X509;

public class AdditionalInformationSyntax : Asn1Encodable
{
	private readonly DirectoryString information;

	public virtual DirectoryString Information => information;

	public static AdditionalInformationSyntax GetInstance(object obj)
	{
		if (obj is AdditionalInformationSyntax)
		{
			return (AdditionalInformationSyntax)obj;
		}
		if (!(obj is IAsn1String))
		{
			throw new ArgumentException("Unknown object in GetInstance: " + Platform.GetTypeName(obj), "obj");
		}
		return new AdditionalInformationSyntax(DirectoryString.GetInstance(obj));
	}

	private AdditionalInformationSyntax(DirectoryString information)
	{
		this.information = information;
	}

	public AdditionalInformationSyntax(string information)
	{
		this.information = new DirectoryString(information);
	}

	public override Asn1Object ToAsn1Object()
	{
		return information.ToAsn1Object();
	}
}
