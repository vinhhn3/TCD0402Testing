using NUnit.Framework;

namespace Fundamentals.UnitTests
{
  class ReservationTest
  {
    private Reservation _reservation;
    private User _admin;
    private User _user;
    private User _anotherUser;
    [SetUp]
    public void SetUp()
    {
      _reservation = new Reservation();
      _admin = new User();
      _admin.IsAdmin = true;
      _user = new User();
      _user.IsAdmin = false;
      _reservation.MadeBy = _user;
      _anotherUser = new User();
      _anotherUser.IsAdmin = false;
    }
    [Test]
    public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
    {
      // Arrange 
      // Act
      var result = _reservation.CanBeCancelledBy(_admin);
      // Assert
      Assert.True(result);
    }
    [Test]
    public void CanBeCancelledBy_UserIsMadeBy_ReturnTrue()
    {
      // Arrange 

      // Act
      var result = _reservation.CanBeCancelledBy(_user);
      // Assert
      Assert.True(result);
    }
    [Test]
    public void CanBeCancelledBy_UserIsNotAdminAndNotMadeBy_ReturnFalse()
    {
      // Arrange 
      // Act
      var result = _reservation.CanBeCancelledBy(_anotherUser);
      // Assert
      Assert.False(result);
    }
  }
}
