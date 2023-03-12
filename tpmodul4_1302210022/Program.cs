using static KodePos;
public class KodePos
{
    public enum Kelurahan
    {
        Batununggal,
        Kujangsari,
        Mengger,
        Wates,
        Cijaura,
        Jatisari,
        Margasari,
        Sekejati,
        Kebonwaru,
        Maleer,
        Samoja
    }

    public class getKode
    {
        public static int getKodePos(Kelurahan kelurahan)
        {
            int[] kodelist = { 40266 , 40287 ,40267, 40256, 40287, 40286 , 40286, 40286 , 40272 , 40274, 40273 };
            return kodelist[(int)kelurahan];
        }
    }
   
}

class Program
{
    static void Main(string[] args)
    {
        getKode kodepos = new getKode();
        Kelurahan daerah = Kelurahan.Margasari;
        int kode = getKode.getKodePos(daerah);
        Console.WriteLine(kode);
    }
}