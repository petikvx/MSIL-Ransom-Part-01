using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

internal class runFD : FontDialog, MyEvents, MyDialogs
{
	public string TypeObj;

	public string defaultName;

	public object MyObj;

	private MyEvents.CreatedEventHandler CreatedEvent;

	public PropertysRun Props;

	private string nam;

	public string Name
	{
		get
		{
			if (Operators.CompareString(nam, "", false) == 0)
			{
				object proj = peremens2.proj;
				object[] array = new object[1] { defaultName };
				bool[] array2 = new bool[1] { true };
				object obj = NewLateBinding.LateGet(proj, (Type)null, "GiveName", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					defaultName = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				}
				nam = Conversions.ToString(obj);
			}
			return nam;
		}
		set
		{
			nam = value;
		}
	}

	public object Left
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public object Top
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public event MyEvents.CreatedEventHandler Created
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			CreatedEvent = (MyEvents.CreatedEventHandler)Delegate.Combine(CreatedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			CreatedEvent = (MyEvents.CreatedEventHandler)Delegate.Remove(CreatedEvent, value);
		}
	}

	public runFD()
	{
		TypeObj = "PoluObj";
		defaultName = peremens.trans("Окно шрифта");
		Props = new PropertysRun(this);
	}

	public void Load()
	{
	}

	public void RaiseCreate()
	{
		CreatedEvent?.Invoke(this, new EventArgs());
	}

	public void BringToFront()
	{
	}

	public void SendToBack()
	{
	}
}
