
#region 1
/*int[] arr = new int[21];
    for (int i = 0; i <= 20; i++)
    {
        arr[i] = i;
    }

    foreach (int sayi in arr)
    {
        if (sayi != 13 && sayi != 17 && sayi != 19)
        {
            Console.WriteLine(sayi);
        }
    }*/
#endregion
#region 2

//string[] array = { "mercedes", "bmw", "hyundai", "kia", "lexus" };

//foreach (var item in array)
//{
//    Console.WriteLine(item);
//}
#endregion
#region 3


//Console.WriteLine("Salam zehmet olmasa yasinizi daxil edin");
//int yas = int.Parse(Console.ReadLine());
//if (yas < 18)
//{
//    Console.WriteLine("hele balacasan");
//}
//else if (yas > 18 && yas < 35)
//{
//    Console.WriteLine("hele cavansan");
//}
//else if (yas > 35 && yas < 55)
//{
//    Console.WriteLine(
//        "uje qocalirsan...");
//}
//else
//{
//    Console.WriteLine("qocaldin ");
//}




#endregion

#region PR
string dogruSoz = "salam";
int dogruTexminSayisi = 5;
bool dogruTexmin = false;

Console.WriteLine("Bir soz texmin edin:");

while (dogruTexminSayisi > 0)
{
    string texmin = Console.ReadLine();

    if (texmin.ToLower() == dogruSoz)
    {
        dogruTexmin = true;
        break;
    }
    else
    {
        dogruTexminSayisi--;
        Console.WriteLine($"Yanlış soz,Qalan haqqiniz: {dogruTexminSayisi}");
        if (dogruTexminSayisi > 0)
            Console.WriteLine("Basga bir texmin:");
    }
}

if (dogruTexmin)
{
    Console.WriteLine("Tebrikler, doğru sozu tapdiniz!");
}
else
{
    Console.WriteLine("Sizin haqqiniz bitdi. Doğru soz: Salam ");
}


#endregion







