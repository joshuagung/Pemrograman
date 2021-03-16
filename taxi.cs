using System;

namespace Program
{
	public class Taxi
	{
		public string DriverName { get; set; }
		public bool OnDuty { get; set; }
		public int NumPassanger { get; set; }
		public string a = "Yes", b = "No";

		public void TaxiInfo()
		{
			Console.WriteLine("DriverName: {0}", DriverName);
			if( OnDuty == true){
				Console.WriteLine("OnDuty: Yes");
			}else{
				Console.WriteLine("OnDuty: No");
			}
			Console.WriteLine("NumPassanger: {0}", NumPassanger);
			
		}
		public void PickUpPassanger(){
			Console.WriteLine("\n{0} sedang menjemput penumpang", DriverName);
			
		}
		public void DropOfPassanger(){
			Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
			
		}

		static void Main(string[] args)
		{
			Taxi taxi = new Taxi();

			taxi.DriverName = "Joshua";
			taxi.OnDuty = true;
			taxi.NumPassanger = 10;
			
			taxi.TaxiInfo();
			taxi.PickUpPassanger();
			taxi.DropOfPassanger();

			Console.ReadKey();
		}
	}
}