using FluentResults;

namespace ChristmasResults;

public class CookieBakery
{
  //https://github.com/altmann/FluentResults
  public List<Result<Cookie>> BakeChristmasCookies()
  {
    // Use the various results from the other methods in this class to bake a list of cookies.
    // Return a result containing a list of results containing the baked cookies.
  }

  private Result<Ingredient> RetrieveInegredients()
  {
    // Fill in the code to retrieve and return various ingredients for the cookies.
  }

  private Result<List<Ingredient>> MixIngredients()
  {
    // Fill in the code to mix the ingredients in a list an return a success result containing the list.
  }

  private Result<Cookie> ShapeCookies()
  {
    // Fill in the code of this method to shape the cookies and give them a name.
    // - Return a Result indicating success or failure with appropriate messages
  }
}

public class Ingredient
{
  public string Name { get; set; }
}

public class Cookie
{
  private List<Ingredient> Ingredients { get; set; }
  public string Name { get; set; }
}