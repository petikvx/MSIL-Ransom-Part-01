using System;

namespace BlackHawkDown;

internal class M16 : Firearm
{
	private bool _silencer;

	private bool _m203;

	private bool _Acog;

	private bool _grip;

	private bool _peq15;

	public M16(string Name)
	{
		name = Name;
		status = "created";
		firingmode = "safe";
		caliber = "5.56x45";
		Console.WriteLine("M16 " + name + " is " + status);
	}

	public void addattachment(string attach)
	{
		switch (attach)
		{
		case "silencer":
			_silencer = true;
			Console.WriteLine("silencer has been attached to " + name);
			break;
		case "m203":
			_m203 = true;
			break;
		case "Acog":
			_Acog = true;
			break;
		case "grip":
			_grip = true;
			break;
		case "peq15":
			_peq15 = true;
			break;
		default:
			Console.WriteLine("Thats not a correct attachment");
			break;
		}
	}

	public void removeattachment(string attach)
	{
		switch (attach)
		{
		case "silencer":
			_silencer = false;
			break;
		case "m203":
			_m203 = false;
			break;
		case "Acog":
			_Acog = false;
			break;
		case "grip":
			_grip = false;
			break;
		case "peq15":
			_peq15 = false;
			break;
		default:
			Console.WriteLine("thats not a correct attachment");
			break;
		}
	}

	public override void changemode(int mode)
	{
		switch (mode)
		{
		case 0:
			firingmode = "safe";
			Console.WriteLine(Owner.name + " set " + name + " to " + firingmode);
			break;
		case 2:
			firingmode = "semi";
			Console.WriteLine(Owner.name + " set " + name + " to " + firingmode);
			break;
		case 3:
			firingmode = "auto";
			Console.WriteLine(Owner.name + " set " + name + " to " + firingmode);
			break;
		default:
			Console.WriteLine("Thats not a correct number");
			break;
		}
	}
}
