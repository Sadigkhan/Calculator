namespace ClassLibrary1
{
    
    
        public class CalCulator
        {
            // Ededin quvvete ozu qeder quvvete yukseldilmesi   
            public double Quvvet (double  reqem)
            {
                return reqem* reqem;
            } 
            // Daxil edilmis ededlerin ceminin  tapilmasi
            public double Cem (double reqem1, double reqem2)
            {
                return reqem1 + reqem2;
            }

            // Daxil edilmis ededlerin hasilinin tapilmasi  
            public double Hasil (double reqem1, double reqem2)
            {
                return reqem1 * reqem2;
            }
            // Daxil edilmis ededlerin muqayisesi 
            public void Muqayise (double reqem1, double reqem2)
            {
                if (reqem1 > reqem2)
                {
                Console.WriteLine($"Daxil etdiyiniz reqemlerden boyuk olani:{reqem1}");
                }
                else
                {
                 Console.WriteLine($"Daxil etdiyiniz reqemlerdn boyuk olani:{reqem2}");
                }                             
            }
            // Daxil edilmis ededlerin nisbetinin tapilmasi  
            public float Bolme (float reqem1, float reqem2)
            {
                return reqem1 / reqem2;
            }
            // Daxil edilmis ededlerinn ferqinin tapilmasi
            public double Ferq (double reqem1, double reqem2)
            {
            return reqem1 - reqem2;
            }

    }
    
}