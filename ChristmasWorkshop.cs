using FluentResults;

namespace ChristmasResults
{
  //https://github.com/altmann/FluentResults
  public class ChristmasWorkshop
  {
    public List<Result> ValidateChristmasGift(Gift gift)
    {
      var giftBag = new List<Gift>();

      giftBag.Add(new Gift() { HasTag = true, IsWrapped = true, IsEmpty = false } );
      giftBag.Add(new Gift() { HasTag = false, IsWrapped = true, IsEmpty = true } );
      giftBag.Add(new Gift() { HasTag = true, IsWrapped = false, IsEmpty = false } );

      // Fill in the code of this method to validate the Christmas gifts in the giftBag.
      // - Check if the gift is wrapped
      // - Verify if the gift has a tag
      // - Ensure the gift is not empty
      // Return a list of results indicating success or failure with message about the failures.
    }
  }

  public class Gift
  {
    public bool IsWrapped { get; set; }
    public bool HasTag { get; set; }
    public bool IsEmpty { get; set; }
  }
}
