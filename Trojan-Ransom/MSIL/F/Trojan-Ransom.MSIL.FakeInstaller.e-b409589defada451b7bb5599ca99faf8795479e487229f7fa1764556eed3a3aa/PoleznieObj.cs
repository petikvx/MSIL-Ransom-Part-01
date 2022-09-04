using System.Windows.Forms;

public class PoleznieObj : Control
{
	public string TypeObj;

	public PropertysOther Props;

	public object MyObj;

	public string defaultName;

	public string LastProp;

	public string LastSobyt;

	public string LastObj;

	public PoleznieObj(string n)
	{
		TypeObj = "Polezniy";
		Props = new PropertysOther(this);
		Props.Name = n;
	}
}
