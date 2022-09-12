using System;
using System.Collections.Generic;
using System.Drawing;

namespace Gecko;

public class GeckoRange : ICloneable
{
	public nsIDOMRange DomRange { get; protected set; }

	public GeckoNode StartContainer => GeckoNode.Create(DomRange.GetStartContainerAttribute());

	public int StartOffset => DomRange.GetStartOffsetAttribute();

	public GeckoNode EndContainer => GeckoNode.Create(DomRange.GetEndContainerAttribute());

	public int EndOffset => DomRange.GetEndOffsetAttribute();

	public bool Collapsed => DomRange.GetCollapsedAttribute();

	public GeckoNode CommonAncestorContainer => GeckoNode.Create(DomRange.GetCommonAncestorContainerAttribute());

	public Rectangle BoundingClientRect
	{
		get
		{
			nsIDOMClientRect boundingClientRect = DomRange.GetBoundingClientRect();
			return new Rectangle((int)boundingClientRect.GetLeftAttribute(), (int)boundingClientRect.GetTopAttribute(), (int)boundingClientRect.GetWidthAttribute(), (int)boundingClientRect.GetHeightAttribute());
		}
	}

	public IEnumerable<Rectangle> ClientRects
	{
		get
		{
			nsIDOMClientRectList domRectangles = DomRange.GetClientRects();
			for (uint i = 0u; i < domRectangles.GetLengthAttribute(); i++)
			{
				nsIDOMClientRect domRect = domRectangles.Item(i);
				yield return new Rectangle((int)domRect.GetLeftAttribute(), (int)domRect.GetTopAttribute(), (int)domRect.GetWidthAttribute(), (int)domRect.GetHeightAttribute());
			}
		}
	}

	internal GeckoRange(nsIDOMRange range)
	{
		DomRange = range;
	}

	public void SetStart(GeckoNode node, int offset)
	{
		DomRange.SetStart(node.DomObject, offset);
	}

	public void SetEnd(GeckoNode node, int offset)
	{
		DomRange.SetEnd(node.DomObject, offset);
	}

	public void SetStartBefore(GeckoNode node)
	{
		DomRange.SetStartBefore(node.DomObject);
	}

	public void SetStartAfter(GeckoNode node)
	{
		DomRange.SetStartAfter(node.DomObject);
	}

	public void SetEndBefore(GeckoNode node)
	{
		DomRange.SetEndBefore(node.DomObject);
	}

	public void SetEndAfter(GeckoNode node)
	{
		DomRange.SetEndAfter(node.DomObject);
	}

	public void Collapse(bool toStart)
	{
		DomRange.Collapse(toStart);
	}

	public void SelectNode(GeckoNode node)
	{
		DomRange.SelectNode(node.DomObject);
	}

	public void SelectNodeContents(GeckoNode node)
	{
		DomRange.SelectNodeContents(node.DomObject);
	}

	public short CompareBoundaryPoints(ushort how, GeckoRange sourceRange)
	{
		return DomRange.CompareBoundaryPoints(how, sourceRange.DomRange);
	}

	public void DeleteContents()
	{
		DomRange.DeleteContents();
	}

	public GeckoNode ExtractContents()
	{
		return GeckoNode.Create(DomRange.ExtractContents());
	}

	public GeckoNode CloneContents()
	{
		return GeckoNode.Create(DomRange.CloneContents());
	}

	public void InsertNode(GeckoNode newNode)
	{
		DomRange.InsertNode(newNode.DomObject);
	}

	public void SurroundContents(GeckoNode newParent)
	{
		DomRange.SurroundContents(newParent.DomObject);
	}

	public object Clone()
	{
		return CloneRange();
	}

	public GeckoRange CloneRange()
	{
		return new GeckoRange(DomRange.CloneRange());
	}

	public override string ToString()
	{
		using nsAString nsAString2 = new nsAString();
		DomRange.ToString(nsAString2);
		return nsAString2.ToString();
	}

	public void Detach()
	{
		DomRange.Detach();
	}

	public bool IsPointInRange(GeckoNode node, int offset)
	{
		return DomRange.IsPointInRange(node.DomObject, offset);
	}
}
