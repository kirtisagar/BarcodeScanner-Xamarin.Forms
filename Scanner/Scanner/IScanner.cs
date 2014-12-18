using System;
using System.Threading.Tasks;

namespace Scanner
{
	public interface IScanner
	{
		Task<string> Scan();
	}
}

