using ClassLibrary1;

CalCulator c=new CalCulator();
Console.WriteLine($"Daxil etdiyiniz reqemlerin ceminden alinan netice:{c.Cem(5, 6)}");
Console.WriteLine($"Daxil etsiyinz reqemin ozu ile eyni dereceden quvvete yukseldilmesinden alinan netice:{c.Quvvet(5)}");
c.Muqayise(5,7);
Console.WriteLine($"Daxil edilmis reqemlerin hasilinden alinmis netice:{c.Hasil(124, 1250)}");
Console.WriteLine($"Daxil edilmis iki reqemin nisbetinden alinmis netice:{c.Bolme(234,12)}");
Console.WriteLine($"Daxil edilmis ededlerin ferqinin tapilmasindan alinan netice:{c.Ferq(1243123,132123)}");