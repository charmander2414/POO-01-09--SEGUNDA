public class Televisao
{
    private const int VOL_MAX = 100;
    private const int VOL_MIN = 0;

    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
    }

    public float Tamanho { get; }
    public int Resolucao { get; set; } 
    public int Volume { get; private set; }
    public int Canal  { get; set; }
    public bool Estado { get; set; }

 public void AumentarVolume()
 {
    if(Volume < VOL_MAX)
        Volume++;
    else
        Console.WriteLine("TV já está no máx.");
 }
public void DiminuirVolume()
{
    if (Volume > VOL_MIN)
         Volume--;
    else 
        Console.WriteLine("TV já está no min.");

 }


     void Mute() {
        Volume = 0;
        Console.WriteLine("Tv está no mudo. Volume $Volume");

    }
}