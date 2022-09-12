using System;

namespace Gecko;

public class GeckoStyleRule
{
	private nsIDOMCSSRule _DomStyleRule;

	public object DomStyleRule => _DomStyleRule;

	public string SelectorText
	{
		get
		{
			nsIDOMCSSStyleRule nsIDOMCSSStyleRule2 = Xpcom.QueryInterface<nsIDOMCSSStyleRule>(DomStyleRule);
			if (nsIDOMCSSStyleRule2 != null)
			{
				return nsString.Get(nsIDOMCSSStyleRule2.GetSelectorTextAttribute);
			}
			return null;
		}
	}

	public string CssText => nsString.Get(_DomStyleRule.GetCssTextAttribute);

	public string StyleCssText
	{
		get
		{
			nsIDOMCSSStyleRule nsIDOMCSSStyleRule2 = Xpcom.QueryInterface<nsIDOMCSSStyleRule>(DomStyleRule);
			if (nsIDOMCSSStyleRule2 != null)
			{
				return nsString.Get(nsIDOMCSSStyleRule2.GetStyleAttribute().GetCssTextAttribute);
			}
			return null;
		}
		set
		{
			nsIDOMCSSStyleRule nsIDOMCSSStyleRule2 = Xpcom.QueryInterface<nsIDOMCSSStyleRule>(DomStyleRule);
			if (nsIDOMCSSStyleRule2 == null)
			{
				throw new InvalidOperationException("This rule does not support StyleCssText.");
			}
			nsString.Set(nsIDOMCSSStyleRule2.GetStyleAttribute().SetCssTextAttribute, value);
		}
	}

	public GeckoStyleSheet ParentStyleSheet => GeckoStyleSheet.Create(_DomStyleRule.GetParentStyleSheetAttribute());

	public GeckoStyleSheet ImportedStyleSheet
	{
		get
		{
			nsIDOMCSSImportRule nsIDOMCSSImportRule2 = Xpcom.QueryInterface<nsIDOMCSSImportRule>(DomStyleRule);
			if (nsIDOMCSSImportRule2 != null)
			{
				return GeckoStyleSheet.Create(nsIDOMCSSImportRule2.GetStyleSheetAttribute());
			}
			return null;
		}
	}

	public string ImportedHref
	{
		get
		{
			nsIDOMCSSImportRule nsIDOMCSSImportRule2 = Xpcom.QueryInterface<nsIDOMCSSImportRule>(DomStyleRule);
			if (nsIDOMCSSImportRule2 != null)
			{
				return nsString.Get(nsIDOMCSSImportRule2.GetHrefAttribute);
			}
			return null;
		}
	}

	public GeckoMediaList ImportedMedia
	{
		get
		{
			nsIDOMCSSImportRule nsIDOMCSSImportRule2 = Xpcom.QueryInterface<nsIDOMCSSImportRule>(DomStyleRule);
			if (nsIDOMCSSImportRule2 != null)
			{
				return new GeckoMediaList(nsIDOMCSSImportRule2.GetMediaAttribute());
			}
			return null;
		}
	}

	public GeckoRuleType RuleType => (GeckoRuleType)_DomStyleRule.GetTypeAttribute();

	private GeckoStyleRule(nsIDOMCSSRule rule)
	{
		_DomStyleRule = rule;
	}

	internal static GeckoStyleRule Create(nsIDOMCSSRule rule)
	{
		return (rule == null) ? null : new GeckoStyleRule(rule);
	}

	public override string ToString()
	{
		return CssText;
	}
}
