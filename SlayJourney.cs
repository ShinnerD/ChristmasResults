using FluentResults;

namespace ChristmasResults;

//https://github.com/altmann/FluentResults
public class SlayJourney
{
  public Result CheckReindeerHealth(List<Reindeer> reindeerList)
  {
    var prancer = new Reindeer { Name = "Pranecer", IsFitForJourney = false };
    var dancer = new Reindeer { Name = "Dancer", IsFitForJourney = true };
    var vixen = new Reindeer { Name = "Vixen", IsFitForJourney = true };

    // Fill in the code of this method to perform health checks on Santa's reindeer
    // - Check if each reindeer is fit for the Christmas Eve journey
    // - Use Fluent Results to report any health issues
    // - Return a Result indicating success or failure with names "failed" reindeer.
  }
}

public class Reindeer
{
  public string Name { get; set; }
  public bool IsFitForJourney { get; set; }
}