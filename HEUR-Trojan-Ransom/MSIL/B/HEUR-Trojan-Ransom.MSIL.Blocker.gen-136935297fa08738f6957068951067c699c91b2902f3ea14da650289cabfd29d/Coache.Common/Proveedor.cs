namespace Coache.Common;

public class Proveedor : User
{
	public static Profile Profile = Profile.Proveedor;

	public string RazonSocial { get; set; }

	public string CUIT { get; set; }

	public string NombreContacto { get; set; }

	public Rubro Rubro { get; set; }

	public override string ToString()
	{
		return RazonSocial;
	}
}
