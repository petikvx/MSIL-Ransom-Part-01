namespace Renci.SshNet.Security.Chaos.NaCl.Internal.Ed25519Ref10;

internal struct GroupElementPreComp
{
	public FieldElement yplusx;

	public FieldElement yminusx;

	public FieldElement xy2d;

	public GroupElementPreComp(FieldElement yplusx, FieldElement yminusx, FieldElement xy2d)
	{
		this.yplusx = yplusx;
		this.yminusx = yminusx;
		this.xy2d = xy2d;
	}
}
