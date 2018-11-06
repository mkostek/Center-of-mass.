/*
 * SharpDevelop tarafından düzenlendi.
 * Kullanıcı: abuzer
 * Tarih: 4.11.2018
 * Zaman: 21:17
 * 
 * Bu şablonu değiştirmek için Araçlar | Seçenekler | Kodlama | Standart Başlıkları Düzenle 'yi kullanın.
 */
using System;

namespace mass_centre
{
	class Program
	{
		static double[] masscentre(int[][] arr)
		{
			double[] a = new double[4];/*birinci paramere x,ikinci parametre y,üçüncü paramtre z ve sonuncusu ise ağırlıktır.*/
			a[0]=(double)arr[0][0];
			a[1]=(double)arr[0][1];
			a[2]=(double)arr[0][2];
			a[3]=(double)arr[0][3];//type casting
			double dif=0;
			for(int i=arr.Length-1;i>0;i--){//sondan abaşa doğru hesaplıyor
				dif=a[3]+arr[i][3];//total ağıtlık
				for(int k=0;k<3;k++){//üç boyut için 3 e kadar
					a[k]+=(arr[i][k]-a[k])*arr[i][3]/dif;//yeni ağırlık merkezinin konumu=(dizinin k.boyutu-bizim k. boyutumuz)*dizinin k.ağırlığı/toplam ağırlık
					a[3]=dif;//ağırlığı set et
				}
				
			}
			return a;//değeri döndür
		}

		public static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());

			int[][] arr = new int[n][];

			for (int i = 0; i < n; i++) {
				arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
			}

			double[] result = masscentre(arr);

			Console.WriteLine(string.Join("\n", result));
			Console.ReadKey();
		}
	}
}