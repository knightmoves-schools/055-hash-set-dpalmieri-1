namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Return_A_HashWet_Of_Strings_Containing_The_Three_String_Parameters_That_Were_Passed_Into_The_CreateTeam_Method(){
       var classroom = new Classroom();
       HashSet<string> team = classroom.CreateTeam("first", "second", "first");

       Assert.NotNull(team);
       Assert.Equal(2, team.Count());
       Assert.Contains("first", team);
       Assert.Contains("second", team);
    }
}