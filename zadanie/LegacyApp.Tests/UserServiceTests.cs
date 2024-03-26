namespace LegacyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void AddUser_ReturnsFlaseWhenFirstNameIsEmpty()
    {
        //Arrange
        var userService = new UserService();
        
        //Act
        var result = userService.AddUser(
            null,
            "Kowalski",
            "Kowalski@gmail.com",
            DateTime.Parse("2000-01-01"),
            1
            );

        //Assert
        Assert.False(result);
    }

    public void AddUser_ThrowsExceptionWhenClientDoesNotExist()
    {
        //Arrange
        var userService = new UserService();

        //Act
        Action action = () =>
        {
            userService.AddUser(
                "Jan",
                "Kowalski",
                "Kowalski@gmail.com",
                DateTime.Parse("2000-01-01"),
                100
            );
        };
        //Assert
        Assert.Throws<ArgumentException>(action);
    }
}