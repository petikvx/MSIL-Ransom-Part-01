namespace Gecko.WebIDL;

public class Gamepad : WebIDLBase
{
	public string Id => GetProperty<string>("id");

	public uint Index => GetProperty<uint>("index");

	public GamepadMappingType Mapping => GetProperty<GamepadMappingType>("mapping");

	public bool Connected => GetProperty<bool>("connected");

	public nsISupports[] Buttons => GetProperty<nsISupports[]>("buttons");

	public double[] Axes => GetProperty<double[]>("axes");

	public double Timestamp => GetProperty<double>("timestamp");

	public Gamepad(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
