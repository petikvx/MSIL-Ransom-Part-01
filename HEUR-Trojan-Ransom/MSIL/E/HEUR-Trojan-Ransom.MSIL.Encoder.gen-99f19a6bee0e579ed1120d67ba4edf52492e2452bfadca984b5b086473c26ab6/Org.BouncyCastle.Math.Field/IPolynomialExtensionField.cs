namespace Org.BouncyCastle.Math.Field;

public interface IPolynomialExtensionField : IFiniteField, IExtensionField
{
	IPolynomial MinimalPolynomial { get; }
}
