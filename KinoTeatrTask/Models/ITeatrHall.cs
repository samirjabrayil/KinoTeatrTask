namespace KinoTeatrTask.Models
{
    public interface ITeatrHall
    {
        TeatrHall.TeatrHall[] TeatrHalls { get; set; }

        string ToString();
    }
}