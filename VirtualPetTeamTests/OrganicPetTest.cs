using System;
using VirtualPetTeam;
using Xunit;

namespace VirtualPetTeamTests
{
    public class OrganicPetTest
    {
        
        [Fact]
        public void Feed_should_increase_hunger_by_2()
        {
            OrganicPet undertest = new OrganicPet("mAT", "CAT");
            undertest.Hunger = -2;

            undertest.Feed();

            Assert.Equal(0, undertest.Hunger);
        }
    }
}
