using System;
using System.Collections;
using System.Collections.Generic;

namespace Gecko;

public class GeckoStyleSheet
{
	public class StyleRuleCollection : IEnumerable<GeckoStyleRule>, IEnumerable
	{
		private GeckoStyleSheet StyleSheet;

		private nsIDOMCSSRuleList List;

		private nsIDOMWindow _window;

		public bool IsReadOnly => List == null;

		public int Count => (int)((List != null) ? List.GetLengthAttribute() : 0);

		public GeckoStyleRule this[int index]
		{
			get
			{
				if (index < 0 || index >= Count)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				return GeckoStyleRule.Create(List.Item((uint)index));
			}
		}

		internal StyleRuleCollection(GeckoStyleSheet styleSheet)
		{
			StyleSheet = styleSheet;
			List = GetRuleList();
		}

		private nsIDOMCSSRuleList GetRuleList()
		{
			using AutoJSContext autoJSContext = new AutoJSContext(GetGlobalWindow());
			nsIDOMWindow globalWindow = GetGlobalWindow();
			return (nsIDOMCSSRuleList)autoJSContext.EvaluateScript("this.document.styleSheets[0].cssRules;", globalWindow).ToObject();
		}

		private nsIDOMWindow GetGlobalWindow()
		{
			if (_window == null)
			{
				_window = StyleSheet._DomStyleSheet.GetOwnerNodeAttribute().GetOwnerDocumentAttribute().GetDefaultViewAttribute();
			}
			return _window;
		}

		public void Reload()
		{
			List = GetRuleList();
		}

		public void Add(string rule)
		{
			Insert(Count, rule);
		}

		public int Insert(int index, string rule)
		{
			if (IsReadOnly)
			{
				throw new InvalidOperationException("This collection is read-only.");
			}
			if (index < 0 || index > Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (string.IsNullOrEmpty(rule))
			{
				return -1;
			}
			using AutoJSContext autoJSContext = new AutoJSContext(GetGlobalWindow());
			nsIDOMWindow defaultViewAttribute = StyleSheet._DomStyleSheet.GetOwnerNodeAttribute().GetOwnerDocumentAttribute().GetDefaultViewAttribute();
			return autoJSContext.EvaluateScript($"this.document.styleSheets[0].insertRule('{rule}',{index});", defaultViewAttribute).ToInteger();
		}

		public void RemoveAt(int index)
		{
			if (IsReadOnly)
			{
				throw new InvalidOperationException("This collection is read-only.");
			}
			if (index < 0 || index >= Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			using AutoJSContext autoJSContext = new AutoJSContext(GetGlobalWindow());
			nsIDOMWindow defaultViewAttribute = StyleSheet._DomStyleSheet.GetOwnerNodeAttribute().GetOwnerDocumentAttribute().GetDefaultViewAttribute();
			autoJSContext.EvaluateScript($"this.document.styleSheets[0].deleteRule({index});", defaultViewAttribute);
		}

		public void Clear()
		{
			if (IsReadOnly && Count > 0)
			{
				throw new InvalidOperationException("This collection is read-only.");
			}
			using AutoJSContext autoJSContext = new AutoJSContext(GetGlobalWindow());
			nsIDOMWindow defaultViewAttribute = StyleSheet._DomStyleSheet.GetOwnerNodeAttribute().GetOwnerDocumentAttribute().GetDefaultViewAttribute();
			for (int num = Count - 1; num >= 0; num--)
			{
				autoJSContext.EvaluateScript($"this.document.styleSheets[0].deleteRule({num});", defaultViewAttribute);
			}
		}

		public IEnumerator<GeckoStyleRule> GetEnumerator()
		{
			int length = Count;
			for (int i = 0; i < length; i++)
			{
				yield return GeckoStyleRule.Create(List.Item((uint)i));
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			using IEnumerator<GeckoStyleRule> enumerator = GetEnumerator();
			while (enumerator.MoveNext())
			{
				yield return enumerator.Current;
			}
		}
	}

	private nsIDOMCSSStyleSheet _DomStyleSheet;

	private StyleRuleCollection _CssRules;

	public object DomStyleSheet => _DomStyleSheet;

	public bool Disabled
	{
		get
		{
			return _DomStyleSheet.GetDisabledAttribute();
		}
		set
		{
			_DomStyleSheet.SetDisabledAttribute(value);
		}
	}

	public string Href => nsString.Get(_DomStyleSheet.GetHrefAttribute);

	public GeckoStyleSheet ParentStyleSheet => Create((nsIDOMCSSStyleSheet)_DomStyleSheet.GetParentStyleSheetAttribute());

	public GeckoStyleRule OwnerRule => GeckoStyleRule.Create(_DomStyleSheet.GetOwnerRuleAttribute());

	public GeckoNode OwnerNode => GeckoNode.Create(_DomStyleSheet.GetOwnerNodeAttribute());

	public StyleRuleCollection CssRules => (_CssRules == null) ? (_CssRules = new StyleRuleCollection(this)) : _CssRules;

	private GeckoStyleSheet(nsIDOMCSSStyleSheet styleSheet)
	{
		_DomStyleSheet = styleSheet;
	}

	internal static GeckoStyleSheet Create(nsIDOMCSSStyleSheet styleSheet)
	{
		return (styleSheet == null) ? null : new GeckoStyleSheet(styleSheet);
	}

	public override string ToString()
	{
		return "Href=" + Href;
	}
}
