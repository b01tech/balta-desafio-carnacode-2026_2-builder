namespace BuilderChallenge.Models;

public interface IReport
{
    string Title { get; }
    string Format { get; }
    DateTime StartDate { get; }
    DateTime EndDate { get; }
    void Generate();
}
