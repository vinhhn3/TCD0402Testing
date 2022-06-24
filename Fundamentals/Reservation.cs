namespace Fundamentals
{
  public class User
  {
    public bool IsAdmin { get; set; }
  }
  public class Reservation
  {
    public User MadeBy { get; set; }

    public bool CanBeCancelledBy(User user)
    {
      return user.IsAdmin || MadeBy == user;
    }

  }
}
