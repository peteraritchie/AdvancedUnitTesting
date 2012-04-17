namespace Domain
{
	public class Class2
	{
		public enum MyType
		{
			Unknown, Type1, Type2
		}

		private int type;

		public void SetType(MyType type)
		{
		}

		public void SetIntType(int newType)
		{
			this.type = newType;
		}

		public void Method()
		{
			SetType(MyType.Type1);
			//SetType(5);
			SetIntType(5);
		}
	}
}