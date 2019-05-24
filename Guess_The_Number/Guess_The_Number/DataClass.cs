using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_The_Number
{
	/// <summary>
	/// Статический класс для хранения и передачи данных между формами
	/// </summary>
	static class DataClass
	{
		public static int PLG;
		static Random r = new Random();
		public static int questNumber = r.Next(0, 100);
	}
}
