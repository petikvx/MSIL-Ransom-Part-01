namespace PenterWare.Actions.Results;

internal class KeyDerivationResult : ActionResult
{
	public string KeyBase64 { get; set; }

	public string SymmetricAlgorithm { get; set; }

	public string AsymmetricAlgorithm { get; set; }
}
