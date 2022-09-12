using System;

namespace Gecko.WebIDL;

public class mozContact : WebIDLBase
{
	public string Id
	{
		get
		{
			return GetProperty<string>("id");
		}
		set
		{
			SetProperty("id", value);
		}
	}

	public IntPtr Published => GetProperty<IntPtr>("published");

	public IntPtr Updated => GetProperty<IntPtr>("updated");

	public IntPtr Bday
	{
		get
		{
			return GetProperty<IntPtr>("bday");
		}
		set
		{
			SetProperty("bday", value);
		}
	}

	public IntPtr Anniversary
	{
		get
		{
			return GetProperty<IntPtr>("anniversary");
		}
		set
		{
			SetProperty("anniversary", value);
		}
	}

	public string Sex
	{
		get
		{
			return GetProperty<string>("sex");
		}
		set
		{
			SetProperty("sex", value);
		}
	}

	public string GenderIdentity
	{
		get
		{
			return GetProperty<string>("genderIdentity");
		}
		set
		{
			SetProperty("genderIdentity", value);
		}
	}

	public nsIDOMBlob[] Photo
	{
		get
		{
			return GetProperty<nsIDOMBlob[]>("photo");
		}
		set
		{
			SetProperty("photo", value);
		}
	}

	public object[] Adr
	{
		get
		{
			return GetProperty<object[]>("adr");
		}
		set
		{
			SetProperty("adr", value);
		}
	}

	public object[] Email
	{
		get
		{
			return GetProperty<object[]>("email");
		}
		set
		{
			SetProperty("email", value);
		}
	}

	public object[] Url
	{
		get
		{
			return GetProperty<object[]>("url");
		}
		set
		{
			SetProperty("url", value);
		}
	}

	public object[] Impp
	{
		get
		{
			return GetProperty<object[]>("impp");
		}
		set
		{
			SetProperty("impp", value);
		}
	}

	public object[] Tel
	{
		get
		{
			return GetProperty<object[]>("tel");
		}
		set
		{
			SetProperty("tel", value);
		}
	}

	public string[] Name
	{
		get
		{
			return GetProperty<string[]>("name");
		}
		set
		{
			SetProperty("name", value);
		}
	}

	public string[] HonorificPrefix
	{
		get
		{
			return GetProperty<string[]>("honorificPrefix");
		}
		set
		{
			SetProperty("honorificPrefix", value);
		}
	}

	public string[] GivenName
	{
		get
		{
			return GetProperty<string[]>("givenName");
		}
		set
		{
			SetProperty("givenName", value);
		}
	}

	public string[] PhoneticGivenName
	{
		get
		{
			return GetProperty<string[]>("phoneticGivenName");
		}
		set
		{
			SetProperty("phoneticGivenName", value);
		}
	}

	public string[] AdditionalName
	{
		get
		{
			return GetProperty<string[]>("additionalName");
		}
		set
		{
			SetProperty("additionalName", value);
		}
	}

	public string[] FamilyName
	{
		get
		{
			return GetProperty<string[]>("familyName");
		}
		set
		{
			SetProperty("familyName", value);
		}
	}

	public string[] PhoneticFamilyName
	{
		get
		{
			return GetProperty<string[]>("phoneticFamilyName");
		}
		set
		{
			SetProperty("phoneticFamilyName", value);
		}
	}

	public string[] HonorificSuffix
	{
		get
		{
			return GetProperty<string[]>("honorificSuffix");
		}
		set
		{
			SetProperty("honorificSuffix", value);
		}
	}

	public string[] Nickname
	{
		get
		{
			return GetProperty<string[]>("nickname");
		}
		set
		{
			SetProperty("nickname", value);
		}
	}

	public string[] Category
	{
		get
		{
			return GetProperty<string[]>("category");
		}
		set
		{
			SetProperty("category", value);
		}
	}

	public string[] Org
	{
		get
		{
			return GetProperty<string[]>("org");
		}
		set
		{
			SetProperty("org", value);
		}
	}

	public string[] JobTitle
	{
		get
		{
			return GetProperty<string[]>("jobTitle");
		}
		set
		{
			SetProperty("jobTitle", value);
		}
	}

	public string[] Note
	{
		get
		{
			return GetProperty<string[]>("note");
		}
		set
		{
			SetProperty("note", value);
		}
	}

	public string[] Key
	{
		get
		{
			return GetProperty<string[]>("key");
		}
		set
		{
			SetProperty("key", value);
		}
	}

	public mozContact(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Init()
	{
		CallVoidMethod("init");
	}

	public void Init(object properties)
	{
		CallVoidMethod("init", properties);
	}

	public void SetMetadata(string id, IntPtr published, IntPtr updated)
	{
		CallVoidMethod("setMetadata", id, published, updated);
	}
}
