
public class Kata
{
    public static string Shark(
      int pontoonDistance,
      int sharkDistance ,
      int yourSpeed,
      int sharkSpeed,
      bool dolphin)
    {
      int my = pontoonDistance * yourSpeed;
      int shark = sharkDistance * sharkSpeed;
      int result = my / shark;
        if (dolphin == true)
        {
          sharkSpeed / 2;
        }
        if (my > shark)
        {
          return "Alive!";
        }
      if (result < 1 )
        {
        return ("Alive!");
      }
      if
        {
        return ("Shark Bait!");
      }
  }
}