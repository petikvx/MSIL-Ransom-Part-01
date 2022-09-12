using System;

namespace Gecko.WebIDL;

public class HTMLInputElement : WebIDLBase
{
	public string Accept
	{
		get
		{
			return GetProperty<string>("accept");
		}
		set
		{
			SetProperty("accept", value);
		}
	}

	public string Alt
	{
		get
		{
			return GetProperty<string>("alt");
		}
		set
		{
			SetProperty("alt", value);
		}
	}

	public string Autocomplete
	{
		get
		{
			return GetProperty<string>("autocomplete");
		}
		set
		{
			SetProperty("autocomplete", value);
		}
	}

	public bool Autofocus
	{
		get
		{
			return GetProperty<bool>("autofocus");
		}
		set
		{
			SetProperty("autofocus", value);
		}
	}

	public bool DefaultChecked
	{
		get
		{
			return GetProperty<bool>("defaultChecked");
		}
		set
		{
			SetProperty("defaultChecked", value);
		}
	}

	public bool Checked
	{
		get
		{
			return GetProperty<bool>("checked");
		}
		set
		{
			SetProperty("checked", value);
		}
	}

	public bool Disabled
	{
		get
		{
			return GetProperty<bool>("disabled");
		}
		set
		{
			SetProperty("disabled", value);
		}
	}

	public nsISupports Form => GetProperty<nsISupports>("form");

	public nsISupports Files => GetProperty<nsISupports>("files");

	public string FormAction
	{
		get
		{
			return GetProperty<string>("formAction");
		}
		set
		{
			SetProperty("formAction", value);
		}
	}

	public string FormEnctype
	{
		get
		{
			return GetProperty<string>("formEnctype");
		}
		set
		{
			SetProperty("formEnctype", value);
		}
	}

	public string FormMethod
	{
		get
		{
			return GetProperty<string>("formMethod");
		}
		set
		{
			SetProperty("formMethod", value);
		}
	}

	public bool FormNoValidate
	{
		get
		{
			return GetProperty<bool>("formNoValidate");
		}
		set
		{
			SetProperty("formNoValidate", value);
		}
	}

	public string FormTarget
	{
		get
		{
			return GetProperty<string>("formTarget");
		}
		set
		{
			SetProperty("formTarget", value);
		}
	}

	public uint Height
	{
		get
		{
			return GetProperty<uint>("height");
		}
		set
		{
			SetProperty("height", value);
		}
	}

	public bool Indeterminate
	{
		get
		{
			return GetProperty<bool>("indeterminate");
		}
		set
		{
			SetProperty("indeterminate", value);
		}
	}

	public string InputMode
	{
		get
		{
			return GetProperty<string>("inputMode");
		}
		set
		{
			SetProperty("inputMode", value);
		}
	}

	public nsISupports List => GetProperty<nsISupports>("list");

	public string Max
	{
		get
		{
			return GetProperty<string>("max");
		}
		set
		{
			SetProperty("max", value);
		}
	}

	public int MaxLength
	{
		get
		{
			return GetProperty<int>("maxLength");
		}
		set
		{
			SetProperty("maxLength", value);
		}
	}

	public string Min
	{
		get
		{
			return GetProperty<string>("min");
		}
		set
		{
			SetProperty("min", value);
		}
	}

	public bool Multiple
	{
		get
		{
			return GetProperty<bool>("multiple");
		}
		set
		{
			SetProperty("multiple", value);
		}
	}

	public string Name
	{
		get
		{
			return GetProperty<string>("name");
		}
		set
		{
			SetProperty("name", value);
		}
	}

	public string Pattern
	{
		get
		{
			return GetProperty<string>("pattern");
		}
		set
		{
			SetProperty("pattern", value);
		}
	}

	public string Placeholder
	{
		get
		{
			return GetProperty<string>("placeholder");
		}
		set
		{
			SetProperty("placeholder", value);
		}
	}

	public bool ReadOnly
	{
		get
		{
			return GetProperty<bool>("readOnly");
		}
		set
		{
			SetProperty("readOnly", value);
		}
	}

	public bool Required
	{
		get
		{
			return GetProperty<bool>("required");
		}
		set
		{
			SetProperty("required", value);
		}
	}

	public uint Size
	{
		get
		{
			return GetProperty<uint>("size");
		}
		set
		{
			SetProperty("size", value);
		}
	}

	public string Src
	{
		get
		{
			return GetProperty<string>("src");
		}
		set
		{
			SetProperty("src", value);
		}
	}

	public string Step
	{
		get
		{
			return GetProperty<string>("step");
		}
		set
		{
			SetProperty("step", value);
		}
	}

	public string Type
	{
		get
		{
			return GetProperty<string>("type");
		}
		set
		{
			SetProperty("type", value);
		}
	}

	public string DefaultValue
	{
		get
		{
			return GetProperty<string>("defaultValue");
		}
		set
		{
			SetProperty("defaultValue", value);
		}
	}

	public string Value
	{
		get
		{
			return GetProperty<string>("value");
		}
		set
		{
			SetProperty("value", value);
		}
	}

	public IntPtr ValueAsDate
	{
		get
		{
			return GetProperty<IntPtr>("valueAsDate");
		}
		set
		{
			SetProperty("valueAsDate", value);
		}
	}

	public double ValueAsNumber
	{
		get
		{
			return GetProperty<double>("valueAsNumber");
		}
		set
		{
			SetProperty("valueAsNumber", value);
		}
	}

	public uint Width
	{
		get
		{
			return GetProperty<uint>("width");
		}
		set
		{
			SetProperty("width", value);
		}
	}

	public bool WillValidate => GetProperty<bool>("willValidate");

	public nsISupports Validity => GetProperty<nsISupports>("validity");

	public string ValidationMessage => GetProperty<string>("validationMessage");

	public int SelectionStart
	{
		get
		{
			return GetProperty<int>("selectionStart");
		}
		set
		{
			SetProperty("selectionStart", value);
		}
	}

	public int SelectionEnd
	{
		get
		{
			return GetProperty<int>("selectionEnd");
		}
		set
		{
			SetProperty("selectionEnd", value);
		}
	}

	public string SelectionDirection
	{
		get
		{
			return GetProperty<string>("selectionDirection");
		}
		set
		{
			SetProperty("selectionDirection", value);
		}
	}

	public string Align
	{
		get
		{
			return GetProperty<string>("align");
		}
		set
		{
			SetProperty("align", value);
		}
	}

	public string UseMap
	{
		get
		{
			return GetProperty<string>("useMap");
		}
		set
		{
			SetProperty("useMap", value);
		}
	}

	public nsISupports Controllers => GetProperty<nsISupports>("controllers");

	public int TextLength => GetProperty<int>("textLength");

	public nsISupports OwnerNumberControl => GetProperty<nsISupports>("ownerNumberControl");

	public nsISupports Editor => GetProperty<nsISupports>("editor");

	public bool Directory
	{
		get
		{
			return GetProperty<bool>("directory");
		}
		set
		{
			SetProperty("directory", value);
		}
	}

	public bool IsFilesAndDirectoriesSupported => GetProperty<bool>("isFilesAndDirectoriesSupported");

	public HTMLInputElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void StepUp()
	{
		CallVoidMethod("stepUp");
	}

	public void StepUp(int n)
	{
		CallVoidMethod("stepUp", n);
	}

	public void StepDown()
	{
		CallVoidMethod("stepDown");
	}

	public void StepDown(int n)
	{
		CallVoidMethod("stepDown", n);
	}

	public bool CheckValidity()
	{
		return CallMethod<bool>("checkValidity", new object[0]);
	}

	public void SetCustomValidity(string error)
	{
		CallVoidMethod("setCustomValidity", error);
	}

	public void Select()
	{
		CallVoidMethod("select");
	}

	public void SetRangeText(string replacement)
	{
		CallVoidMethod("setRangeText", replacement);
	}

	public void SetRangeText(string replacement, uint start, uint end)
	{
		CallVoidMethod("setRangeText", replacement, start, end);
	}

	public void SetRangeText(string replacement, uint start, uint end, SelectionMode selectionMode)
	{
		CallVoidMethod("setRangeText", replacement, start, end, selectionMode);
	}

	public void SetSelectionRange(int start, int end)
	{
		CallVoidMethod("setSelectionRange", start, end);
	}

	public void SetSelectionRange(int start, int end, string direction)
	{
		CallVoidMethod("setSelectionRange", start, end, direction);
	}

	public string[] MozGetFileNameArray()
	{
		return CallMethod<string[]>("mozGetFileNameArray", new object[0]);
	}

	public void MozSetFileNameArray(string[] fileNames)
	{
		CallVoidMethod("mozSetFileNameArray", fileNames);
	}

	public void MozSetFileArray(nsISupports[] files)
	{
		CallVoidMethod("mozSetFileArray", files);
	}

	public bool MozIsTextField(bool aExcludePassword)
	{
		return CallMethod<bool>("mozIsTextField", new object[1] { aExcludePassword });
	}

	public object GetAutocompleteInfo()
	{
		return CallMethod<object>("getAutocompleteInfo", new object[0]);
	}

	public void SetUserInput(string input)
	{
		CallVoidMethod("setUserInput", input);
	}

	public Promise<WebIDLUnion<nsISupports, nsISupports>> GetFilesAndDirectories()
	{
		return CallMethod<Promise<WebIDLUnion<nsISupports, nsISupports>>>("getFilesAndDirectories", new object[0]);
	}

	public void ChooseDirectory()
	{
		CallVoidMethod("chooseDirectory");
	}
}
