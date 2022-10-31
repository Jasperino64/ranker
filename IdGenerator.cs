using System;

namespace test {
	public class IdGenerator
	{
		private int _id = -1;
		public IdGenerator()
		{
		}

		public int Id { get { _id++; return _id; } }
	} 
}
