public class Kata
{
    public static string AbbrevName(string name)
    {
        string[] fio = name.Split(' ');
        string str = (fio[0][0] + "." + fio[1][0]);
        return str.ToUpper();
    }
}