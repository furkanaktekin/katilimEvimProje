using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;

namespace katilimEvimProje
{

    public partial class Default : System.Web.UI.Page
    {
        protected void UploadButton_Click(object sender, EventArgs e)
        {

            if (FileUpload1.HasFile)
            {

                string[] textLineNumbersUp;
                string[] textLineNumbersDown;

                int[] numbersUp;
                int[] numbersDown;

                int sonuc=0;

                int toplam=0;

                string secilenler="";

                List<string> list = new List<string>();

                // SEÇİLEN DOSYANIN HER BİR SATIRINI OKUYUP LİST'E ATTIM.
                StreamReader reader = new StreamReader(FileUpload1.FileContent);
                do
                {
                    list.Add(reader.ReadLine());
                }
                while (reader.Peek() != -1);
                reader.Close();


                // HER SATIRI BOŞLUK İFADESİNE GÖRE PARÇALAYIP STRİNGLERİ İNT DİZİYE ÇEVİRDİM.
                // DAHA SONRA BU İNT DİZİYİ KÜÇÜKTEN BÜYÜĞE SIRALADIM.
                // BİR ALT SATIRI DA AYNI ŞEKİLDE PARÇALAYIP İNT DİZİYE ÇEVİRİP SIRALADIM.
                // ÜST SATIRIN MİN DEĞERİ ALT SATIRIN MİN DEĞERİNDEN BÜYÜKSE O ELEMANI SEÇTİM.
                for(int i=0;i<list.Count;i++)
                {
                    textLineNumbersUp = list[i].Split(' ');

                    numbersUp = Array.ConvertAll<string, int>(textLineNumbersUp, int.Parse);

                    Array.Sort(numbersUp);

                    if (i + 1 == list.Count)
                        sonuc = numbersUp[0];
                    else
                    {
                        for (int j = 0; j < numbersUp.Length; j++)
                        {
                            sonuc = numbersUp[j];

                            
                            textLineNumbersDown = list[i + 1].Split(' ');

                            numbersDown = Array.ConvertAll<string, int>(textLineNumbersDown, int.Parse);

                            Array.Sort(numbersDown);

                            if (sonuc > numbersDown[0])
                                break;
                    
                        }
                    }
                    
                    secilenler += sonuc+" + ";

                    toplam = toplam + sonuc;
                }

                secilenler = secilenler.Remove(secilenler.Length - 3);

                UploadStatusLabel.Text = "Minimal path is: "+secilenler+" = "+toplam;
            }
            else
            {
                UploadStatusLabel.Text = "Lütfen Önce Dosya Seçip Daha Sonra Dosyayı Oku Butonuna Basınız";
            }
        }
    }
}
