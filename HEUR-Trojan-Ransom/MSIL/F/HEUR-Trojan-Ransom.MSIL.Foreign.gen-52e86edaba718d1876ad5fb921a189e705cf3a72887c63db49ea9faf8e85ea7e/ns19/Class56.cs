using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MySqlX.XDevAPI;
using ns20;
using ns21;
using ns22;

namespace ns19;

internal abstract class Class56<T> where T : Class48
{
	[CompilerGenerated]
	private BaseSession baseSession_0;

	public BaseSession Session
	{
		[CompilerGenerated]
		get
		{
			return baseSession_0;
		}
		[CompilerGenerated]
		private set
		{
			baseSession_0 = value;
		}
	}

	public Class56(BaseSession baseSession_1)
	{
		Session = baseSession_1;
	}

	public abstract T vmethod_0();

	[AsyncStateMachine(typeof(Class56<>.Struct5))]
	public Task<T> method_0()
	{
		Struct5 stateMachine = default(Struct5);
		stateMachine.class56_0 = this;
		stateMachine.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<T>.Create();
		stateMachine.int_0 = -1;
		AsyncTaskMethodBuilder<T> asyncTaskMethodBuilder_ = stateMachine.asyncTaskMethodBuilder_0;
		asyncTaskMethodBuilder_.Start(ref stateMachine);
		return stateMachine.asyncTaskMethodBuilder_0.Task;
	}

	[CompilerGenerated]
	private T method_1()
	{
		T val = vmethod_0();
		if (val is Class49<Class43>)
		{
			(val as Class49<Class43>).method_2();
		}
		else if (val is Class49<Class55>)
		{
			(val as Class49<Class55>).method_2();
		}
		return val;
	}
}
