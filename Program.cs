using System;

namespace ricerca_binaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10000;
            int[] arr = new int[n] ;
            Random r = new Random();
            int min=0;
            int max=10;
            //qui riempiamo l'array
            for(int i = 0; i < n; i++)
            {

                arr[i] = r.Next(min,max);
                min = arr[i];
                max += 5;
                //Console.Write(arr[i]+"  ");
            }
            Console.WriteLine();

            int x;

            int dx=(arr.Length)-1;
            int sx=0;
            int meta;
            bool c=false;
            

            
            DateTime dt = DateTime.Now;
            long t1 = dt.Millisecond;

            Console.WriteLine(DateTime.Now);

            long ttot = 0;

            for (int i = 0; i < 10000; i++)
            {

                x = arr[r.Next(0, n - 1)];

                meta = 0;
                sx = 0;
                dx = (arr.Length - 1);
                c = false;

                while (dx >= sx && c == false)
                {
                    meta = (dx + sx) / 2;
                    if (arr[meta] > x)
                        dx = meta - 1;

                    if (arr[meta] < x)
                        sx = meta + 1;

                    if (arr[meta] == x)
                    {
                        c = true;
                        //Console.WriteLine("trovato");

                    }

                }

                /*if (c == false)
                {
                    Console.WriteLine("il numero non è stato trovato");
                }*/
                dt = DateTime.Now;
                long t2 = dt.Millisecond;
                //Console.WriteLine("ci ha impiegato {0} millisecondi", t2 - t1);
                ttot += (t2 - t1);



            }

            Console.WriteLine("la media dei tempi della ricerca biaria è di {0}", ttot/10000);

            
            dt = DateTime.Now;
            t1 = dt.Millisecond;
            c = false;
            int z = 0;
            long ttot2=0;
            for (int i = 0; i < 10000; i++)
            {
                c = false;
                z = 0;                
                
                while (z < n && c == false)
                {
                    x = arr[r.Next(0, n - 1)];
                    if (arr[z] == x)
                    {
                        c = true;
                        //Console.WriteLine("trovato");

                    }
                    z++;
                    if (z == n && c == false)
                    {
                        //Console.WriteLine("il numero non è stato trovato");
                    }
                }
                dt = DateTime.Now;
                long t22 = dt.Millisecond;
                //Console.WriteLine("ci ha impiegato {0} millisecondi", t22 - t1);
                //Console.WriteLine(DateTime.Now);
                ttot2 += t22 - t1;


            }
            Console.WriteLine("la media dei tempi della ricerca biaria è di {0}", ttot2 / 10000);

        }
    }
}
