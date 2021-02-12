namespace Model
{
	public class Check
	{
		public static Check Instance { get; } = new Check();

		public string Version { get; } = "1.0.0";

		private Check() { }
	}
}
