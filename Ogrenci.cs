public class Ogrenci
{

    private int OgrenciNo;
    public string Ad;
    public string OkulAdi;
    private int Yas;

    //Kapsüllemek Getter ve Setter metotlarını yazalım

    public int Get_OgrenciNo()
    {
        return this.OgrenciNo;
    }
    public void Set_OgrenciNo(int ogrenciNo)
    {

        if (ogrenciNo != 0 || ogrenciNo! < 0)
        {

            this.OgrenciNo = ogrenciNo;
        }
        else
        {
            // hiç değer atanmaz, olduğu gibi kalır, ancak değişken güvendedir çünkü okul no 0 yada 0dan küçük olamaz!!
            throw new ArgumentException("öğrenci numarası 0 yada 0'dan küçük olamaz!!");
        }


    }

    public string Get_Ad()
    {
        return this.Ad;
    }
    public void Set_Ad(string ad)
    {
        // isim kurallarını bu satırda işletebiliriz
        bool isAnormal = false;
        for (int i = 0; i < ad.Length; i++)
        {
            if (char.IsDigit(ad[i]) || char.IsWhiteSpace(ad[i]) || char.IsSymbol(ad[i]))
            {
                isAnormal = true;
                break;
            }
        }
        if (isAnormal == false)
        {
            // kontrol ettik, ad alanının içerisinde rakam, boşluk yada sembol karakterler yok, direk değişkene atama gerçekleştirilebilir
            this.Ad = ad;
        }
        else
        {
            throw new ArgumentException("Ad Alanına uygun değer giriniz");
        }

    }
    public string Get_OkulAd()
    {
        return this.OkulAdi;
    }
    public void Set_OkulAd(string okulAd)
    {
        if (okulAd.Length < 10 && okulAd.Length > 5)
        {
            this.OkulAdi = okulAd;
        }

    }
    public int Get_Yas()
    {
        return this.Yas;
    }
    public void Set_Yas(int yas)
    {
        if(yas>7 && yas<20){
            this.Yas = yas;
        }
        else{
            throw new ArgumentException("Yaş alanına uygun değer giriniz");
        }
        
    }
}