using System;


namespace test {
	public class IdGenerator
	{
		private int _id = -1;
		public int Id { get { this._id++; return this._id; } }

		public IdGenerator()
		{
		}

	} 
}

