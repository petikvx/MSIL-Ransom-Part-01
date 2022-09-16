using System.Collections;
using System.Collections.Generic;

namespace yKFnPcLKLkIvyuyev;

public class GPaSREEQwv : IEnumerator
{
	private List<EwTlhZtGQJxOhT> QANJhPrhTXJmRz;

	private int BKQUOtlfwcALNJVh = -1;

	object IEnumerator.Current => QANJhPrhTXJmRz[BKQUOtlfwcALNJVh];

	public GPaSREEQwv(List<EwTlhZtGQJxOhT> FwwFaLrsvTCFzjR)
	{
		QANJhPrhTXJmRz = FwwFaLrsvTCFzjR;
	}

	bool IEnumerator.MoveNext()
	{
		BKQUOtlfwcALNJVh++;
		return BKQUOtlfwcALNJVh < QANJhPrhTXJmRz.Count;
	}

	void IEnumerator.Reset()
	{
		BKQUOtlfwcALNJVh = -1;
	}
}
