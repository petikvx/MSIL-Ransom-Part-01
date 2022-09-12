using System;
using System.Collections;
using System.Collections.Generic;

namespace HtmlAgilityPack;

public class HtmlNodeCollection : IEnumerable<HtmlNode>, IList<HtmlNode>, ICollection<HtmlNode>, IEnumerable
{
	private readonly HtmlNode _parentnode;

	private readonly List<HtmlNode> _items = new List<HtmlNode>();

	public int this[HtmlNode node]
	{
		get
		{
			int nodeIndex = GetNodeIndex(node);
			if (nodeIndex == -1)
			{
				throw new ArgumentOutOfRangeException("node", "Node \"" + node.CloneNode(deep: false).OuterHtml + "\" was not found in the collection");
			}
			return nodeIndex;
		}
	}

	public HtmlNode this[string nodeName]
	{
		get
		{
			int num = 0;
			while (true)
			{
				if (num < _items.Count)
				{
					if (string.Equals(_items[num].Name, nodeName, StringComparison.OrdinalIgnoreCase))
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return _items[num];
		}
	}

	public int Count => _items.Count;

	public bool IsReadOnly => false;

	public HtmlNode this[int index]
	{
		get
		{
			return _items[index];
		}
		set
		{
			_items[index] = value;
		}
	}

	public HtmlNodeCollection(HtmlNode parentnode)
	{
		_parentnode = parentnode;
	}

	public void Add(HtmlNode node)
	{
		Add(node, setParent: true);
	}

	public void Add(HtmlNode node, bool setParent)
	{
		_items.Add(node);
		if (setParent)
		{
			node.ParentNode = _parentnode;
		}
	}

	public void Clear()
	{
		foreach (HtmlNode item in _items)
		{
			item.ParentNode = null;
			item.NextSibling = null;
			item.PreviousSibling = null;
		}
		_items.Clear();
	}

	public bool Contains(HtmlNode item)
	{
		return _items.Contains(item);
	}

	public void CopyTo(HtmlNode[] array, int arrayIndex)
	{
		_items.CopyTo(array, arrayIndex);
	}

	IEnumerator<HtmlNode> IEnumerable<HtmlNode>.GetEnumerator()
	{
		return _items.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return _items.GetEnumerator();
	}

	public int IndexOf(HtmlNode item)
	{
		return _items.IndexOf(item);
	}

	public void Insert(int index, HtmlNode node)
	{
		HtmlNode htmlNode = null;
		HtmlNode htmlNode2 = null;
		if (index > 0)
		{
			htmlNode2 = _items[index - 1];
		}
		if (index < _items.Count)
		{
			htmlNode = _items[index];
		}
		_items.Insert(index, node);
		if (htmlNode2 != null)
		{
			if (node == htmlNode2)
			{
				throw new InvalidProgramException("Unexpected error.");
			}
			htmlNode2._nextnode = node;
		}
		if (htmlNode != null)
		{
			htmlNode._prevnode = node;
		}
		node._prevnode = htmlNode2;
		if (htmlNode == node)
		{
			throw new InvalidProgramException("Unexpected error.");
		}
		node._nextnode = htmlNode;
		node.SetParent(_parentnode);
	}

	public bool Remove(HtmlNode item)
	{
		int index = _items.IndexOf(item);
		RemoveAt(index);
		return true;
	}

	public void RemoveAt(int index)
	{
		HtmlNode htmlNode = null;
		HtmlNode htmlNode2 = null;
		HtmlNode htmlNode3 = _items[index];
		HtmlNode htmlNode4 = _parentnode ?? htmlNode3._parentnode;
		if (index > 0)
		{
			htmlNode2 = _items[index - 1];
		}
		if (index < _items.Count - 1)
		{
			htmlNode = _items[index + 1];
		}
		_items.RemoveAt(index);
		if (htmlNode2 != null)
		{
			if (htmlNode == htmlNode2)
			{
				throw new InvalidProgramException("Unexpected error.");
			}
			htmlNode2._nextnode = htmlNode;
		}
		if (htmlNode != null)
		{
			htmlNode._prevnode = htmlNode2;
		}
		htmlNode3._prevnode = null;
		htmlNode3._nextnode = null;
		htmlNode3._parentnode = null;
		htmlNode4?.SetChanged();
	}

	public static HtmlNode FindFirst(HtmlNodeCollection items, string name)
	{
		foreach (HtmlNode item in (IEnumerable<HtmlNode>)items)
		{
			if (!item.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
			{
				if (item.HasChildNodes)
				{
					HtmlNode htmlNode = FindFirst(item.ChildNodes, name);
					if (htmlNode != null)
					{
						return htmlNode;
					}
				}
				continue;
			}
			return item;
		}
		return null;
	}

	public void Append(HtmlNode node)
	{
		HtmlNode htmlNode = null;
		if (_items.Count > 0)
		{
			htmlNode = _items[_items.Count - 1];
		}
		_items.Add(node);
		node._prevnode = htmlNode;
		node._nextnode = null;
		node.SetParent(_parentnode);
		if (htmlNode != null)
		{
			if (htmlNode == node)
			{
				throw new InvalidProgramException("Unexpected error.");
			}
			htmlNode._nextnode = node;
		}
	}

	public HtmlNode FindFirst(string name)
	{
		return FindFirst(this, name);
	}

	public int GetNodeIndex(HtmlNode node)
	{
		int num = 0;
		while (true)
		{
			if (num < _items.Count)
			{
				if (node == _items[num])
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	public void Prepend(HtmlNode node)
	{
		HtmlNode htmlNode = null;
		if (_items.Count > 0)
		{
			htmlNode = _items[0];
		}
		_items.Insert(0, node);
		if (node == htmlNode)
		{
			throw new InvalidProgramException("Unexpected error.");
		}
		node._nextnode = htmlNode;
		node._prevnode = null;
		node.SetParent(_parentnode);
		if (htmlNode != null)
		{
			htmlNode._prevnode = node;
		}
	}

	public bool Remove(int index)
	{
		RemoveAt(index);
		return true;
	}

	public void Replace(int index, HtmlNode node)
	{
		HtmlNode htmlNode = null;
		HtmlNode htmlNode2 = null;
		HtmlNode htmlNode3 = _items[index];
		if (index > 0)
		{
			htmlNode2 = _items[index - 1];
		}
		if (index < _items.Count - 1)
		{
			htmlNode = _items[index + 1];
		}
		_items[index] = node;
		if (htmlNode2 != null)
		{
			if (node == htmlNode2)
			{
				throw new InvalidProgramException("Unexpected error.");
			}
			htmlNode2._nextnode = node;
		}
		if (htmlNode != null)
		{
			htmlNode._prevnode = node;
		}
		node._prevnode = htmlNode2;
		if (htmlNode == node)
		{
			throw new InvalidProgramException("Unexpected error.");
		}
		node._nextnode = htmlNode;
		node.SetParent(_parentnode);
		htmlNode3._prevnode = null;
		htmlNode3._nextnode = null;
		htmlNode3._parentnode = null;
	}

	public IEnumerable<HtmlNode> Descendants()
	{
		foreach (HtmlNode item in _items)
		{
			foreach (HtmlNode item2 in item.Descendants())
			{
				yield return item2;
			}
		}
	}

	public IEnumerable<HtmlNode> Descendants(string name)
	{
		foreach (HtmlNode item in _items)
		{
			foreach (HtmlNode item2 in item.Descendants(name))
			{
				yield return item2;
			}
		}
	}

	public IEnumerable<HtmlNode> Elements()
	{
		foreach (HtmlNode item in _items)
		{
			foreach (HtmlNode item2 in (IEnumerable<HtmlNode>)item.ChildNodes)
			{
				yield return item2;
			}
		}
	}

	public IEnumerable<HtmlNode> Elements(string name)
	{
		foreach (HtmlNode item in _items)
		{
			foreach (HtmlNode item2 in item.Elements(name))
			{
				yield return item2;
			}
		}
	}

	public IEnumerable<HtmlNode> Nodes()
	{
		foreach (HtmlNode item in _items)
		{
			foreach (HtmlNode item2 in (IEnumerable<HtmlNode>)item.ChildNodes)
			{
				yield return item2;
			}
		}
	}
}
