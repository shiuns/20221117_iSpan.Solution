using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_LINQ01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// DEMO01();
			// DEMO02();
			// DEMO03();
			// DEMO04();
			// DEMO05();
			// DEMO05B();
			DEMO06();
		}
		private static void DEMO06()
		{
			// 取分頁記錄,假設一頁有三筆,取第二頁(即4~6筆)
			int[] items = new int[] { 1, 2, 46, 5, 6, 34, 56, 67, 745, 67 };
			var secondPage = items.Skip(3).Take(3);

			foreach (var item in secondPage)
			{
				Console.WriteLine(item);
			}
			


		}
		private static void DEMO05B()
		{
			//計算累加
			int[] items = new int[] { 1,2,5 };
			string result = items.Select(x => x.ToString()).Aggregate((acc, next) => acc + "," + next);
			Console.WriteLine(result);

		}

		private static void DEMO05()
		{
			//計算累加
			string[] items = new string[] { "A", "B", "C"};
			string result = items.Aggregate(  (acc, next)=> acc + "," + next  );
			Console.WriteLine(result);
						
		}

		/// <summary>
		/// 聚合函數,Sum,Count, Average, Max, Min
		/// </summary>
		private static void DEMO04()
		{
			int[] items = new int[] { 1, 2, 46, 5, 6, 34, 56, 67, 745, 67 };

			Console.WriteLine("總和: " + items.Sum());
			Console.WriteLine("小於十的總和: " + items.Where(x=>x < 10).Sum());
			
			Console.WriteLine("總筆數: " + items.Count());
			Console.WriteLine("小於十的總筆數: " + items.Count(x=>x<10));
			Console.WriteLine("小於十的總筆數 #2: " + items.Where(x => x<10).Count());

			Console.WriteLine("前三筆的平均數: " + items.Take(3).Average());
			Console.WriteLine("前三筆的平均數,顯示到小數以下二位: " + items.Take(3).Average().ToString("f"));
			Console.WriteLine("前三筆的平均數,顯示到小數以下一位: " + items.Take(3).Average().ToString("f1"));
			Console.WriteLine("前三筆的平均數,顯示到小數以下三位: " + items.Take(3).Average().ToString("f3"));
			Console.WriteLine("前三筆的平均數,顯示到整數: " + items.Take(3).Average().ToString("f0"));

			Console.WriteLine("最大的數值是: " + items.Max());
			Console.WriteLine("最小的數值是: " + items.Min());
		}
		private static void DEMO03()
		{
			// 確定array裡,至少有一筆小於零
			int[] items = new int[] { 1, 2, 46, 5, 6, 34, 56, 67, 745, 67 };

			bool result = items.Any(x => x < 0);
			Console.WriteLine("是否至少有一筆小於零? " + result);
		}
		private static void DEMO02()
		{
			// 確定array裡,每一筆都大於零
			int[] items = new int[] { 1, 2, 46, 5, 6, 34, 56, -67, 745, 67 };

			bool result = items.All(x => x > 0);
			Console.WriteLine("是否全部大於零? " + result);
		}

		private static void DEMO01()
		{
			// find array裡, >50的第一筆
			int[] items = new int[] { 1, 2, 46, 5, 6, 34, 56, 67, 745, 67 };

			int firstValue = items.First(x => x > 5000); // 若找不到符合的記錄,會丟出例外
			int firstValue2 = items.FirstOrDefault(x => x > 5000); // 若找不到,會傳回此型別的預設值,不會丟出例外

			Console.WriteLine(firstValue);
			
		}
	}
}
