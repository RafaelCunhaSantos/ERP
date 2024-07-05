using Xunit;
using DomainEntity = RC.ERP.Domain.Entity;

namespace RC.ERP.UnitTests.Domain.Entity
{
    public class CategoryTest
    {

        public void Instantiate()
        {
            //Arrange
            var validData = new
            {
                Name = "Nome Categoria",
                Description = "Descrição Categoria",
            };

            //Act
            var catagoty = new DomainEntity.Category(validData.Name, validData.Description);

            //Assert
            Assert.NotNull(catagoty);
            Assert.Equal(validData.Name, catagoty.Name);
            Assert.Equal(validData.Description, catagoty.Description);
        }

    }
}
