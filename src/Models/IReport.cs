namespace DesignPatternChallenge.Models;

public interface IReport
{
    string Title { get; set; }
    string Format { get; set; }
    DateTime StartDate { get; set; }
    DateTime EndDate { get; set; }
    void Generate();
}
