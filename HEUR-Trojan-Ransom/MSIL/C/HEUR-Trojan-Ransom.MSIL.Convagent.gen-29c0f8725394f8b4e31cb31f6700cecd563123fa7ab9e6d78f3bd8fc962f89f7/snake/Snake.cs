using System.Collections.Generic;
using System.Windows.Forms;

namespace snake;

public class Snake
{
	public List<Element> myList = new List<Element>();

	public Snake(int nbElements, object object1, int sizeElem, Panel panel1)
	{
		for (int i = 0; i < nbElements; i++)
		{
			myList.Add(new Element(100 + sizeElem * i, 20, object1, sizeElem, panel1));
		}
	}

	public bool detecteCorps()
	{
		bool result = false;
		for (int i = 1; i < myList.Count; i++)
		{
			result = true;
		}
		return result;
	}
}
