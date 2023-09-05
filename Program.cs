using System;

namespace Mevduat_Hesaplama
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("1-Ana para ile devam etmek için");
			Console.WriteLine("2-Aylık olarak yatırım için tuşlayınız.");
			int mainChoice = int.Parse(Console.ReadLine());

			switch (mainChoice)
			{
				case 1:
					Console.WriteLine("Lütfen Ana paranızı Giriniz:");
					int anapara = int.Parse(Console.ReadLine());

					Console.WriteLine("1-Her ay düzenli olarak ekleme yapmak için");
					Console.WriteLine("2-Sadece Ana para ile devam etmek için tuşlayınız.");
					int subChoice = int.Parse(Console.ReadLine());

					switch (subChoice)
					{
						case 1:
							Console.WriteLine("Lütfen düzenli olarak eklenecek Parayı Giriniz:");
							int herayeklenecekpara = int.Parse(Console.ReadLine());

							Console.WriteLine("Lütfen Faiz Oranını Giriniz:(Örn:%30)");
							double faizoranı = double.Parse(Console.ReadLine()) / 12;

							Console.WriteLine("1-Erişmek İstediğiniz bir fiyat varsa");
							Console.WriteLine("2-Yıllık Getiri Hesabı Yapmak istiyorsanız tuşlayınız.");

							int goalChoice = int.Parse(Console.ReadLine());

							if (goalChoice == 1)
							{
								Console.WriteLine("Lütfen Erişmek İstediğiniz Ücreti Giriniz:");
								int erisilmesibeklenenucret = int.Parse(Console.ReadLine());
								int toplamfiyat = anapara;
								int yilsayar = 0;

								Console.Clear();
								Console.WriteLine("İLK YIL ÖDEME PLANINIZ");

								while (toplamfiyat <= erisilmesibeklenenucret)
								{
									toplamfiyat = Convert.ToInt32((toplamfiyat + herayeklenecekpara) + (toplamfiyat) * (faizoranı / 100));
									yilsayar = yilsayar + 1;

									if (yilsayar > 0)
									{
										if (yilsayar % 12 == 0)
										{
											Console.WriteLine();
											Console.WriteLine(yilsayar / 12 + 1 + ". YIL ÖDEME Planınız:");
											Console.WriteLine("-----------------------");
										}

										Console.WriteLine(yilsayar + "." + "Ay Ana Para:" + toplamfiyat + " TL");
									}
								}

								Console.WriteLine();
								Console.WriteLine("MEVDUAT HESABINIZ BAŞARIYLA OLUŞTURULMUŞTUR.");
								Console.ReadLine();
							}
							break;

						case 2:
							Console.WriteLine("Lütfen Faiz Oranını Giriniz:(Örn:%30)");
							double faizoranı2 = double.Parse(Console.ReadLine()) / 12;

							Console.WriteLine("Kaç Yıllık Mevduat Hesabı Açık Dursun ?");
							int yıl = int.Parse(Console.ReadLine());

							Console.Clear();
							int ay2 = yıl * 12;

							for (int i = 0; i < ay2; i++)
							{
								anapara = Convert.ToInt32(anapara + (anapara * (faizoranı2 / 100)));
								Console.WriteLine(i + 1 + "." + " Ay Mevduat Hesabınız: " + anapara + " TL");
							}

							Console.ReadLine();
							break;
					}
					break;

				case 2:
					Console.WriteLine("Lütfen Her Ay Yatırmayı Planladığınız Parayı Yazınız:");
					int herayyatırılıcakpara=int.Parse(Console.ReadLine());
                    Console.WriteLine("Lütfen Kaç Ay Boyunca Mevduat Hesabını Kullanacağınızı Yazınız:");
					int ay = int.Parse(Console.ReadLine());
					Console.WriteLine("Lütfen Faiz Oranını Giriniz(Örn:30):");
					double faiz=Convert.ToDouble(Console.ReadLine())/12;
					Console.Clear();
					int toplam = 0;
					for (int i = 0; i < ay; i++)
					{
						if (toplam==0)
						{
							toplam = herayyatırılıcakpara;
						}
						else
						{
							toplam = Convert.ToInt32(toplam + herayyatırılıcakpara + (toplam * faiz / 100));
							Console.WriteLine(i+1 + "." + " Ay Hesabınızdaki Para Miktarı: " + toplam + " TL");
						}
						
					}
					Console.ReadLine();
                    break;
			}
		}
	}
}
