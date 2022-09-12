namespace Renci.SshNet.Security.Org.BouncyCastle.Math.Field;

internal interface IPolynomialExtensionField : IExtensionField, IFiniteField
{
	IPolynomial MinimalPolynomial { get; }
}
