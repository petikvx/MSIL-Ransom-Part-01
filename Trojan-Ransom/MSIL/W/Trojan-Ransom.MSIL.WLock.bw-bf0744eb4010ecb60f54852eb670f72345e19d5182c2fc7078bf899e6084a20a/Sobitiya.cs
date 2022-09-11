using System;

public class Sobitiya : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] MethodsUp;

	public string[] SobytsUp;

	public Sobitiya(string sobyt)
	{
		PropertysSobyt propertysSobyt = new PropertysSobyt(null, null, null, sobyt);
		Propertys = new string[checked(propertysSobyt.Paramy.Count - 1 + 1)];
		propertysSobyt.Paramy.Keys.CopyTo(Propertys, 0);
		peremens.CreatePropertySobytsUp(this);
	}

	public Sobitiya(PropertysSobyt param)
	{
		Propertys = new string[checked(param.Paramy.Count - 1 + 1)];
		param.Paramy.Keys.CopyTo(Propertys, 0);
		peremens.CreatePropertySobytsUp(this);
	}

	public bool EstProperty(string prop)
	{
		if (PropertysUp == null)
		{
			return false;
		}
		if (Array.IndexOf(PropertysUp, prop) != -1)
		{
			return true;
		}
		return false;
	}
}
