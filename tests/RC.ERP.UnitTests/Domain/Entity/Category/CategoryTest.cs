using FluentAssertions;
using RC.ERP.Domain.Exceptions;
using RC.ERP.UnitTests.Domain.Entity.Category;
using System;
using Xunit;
using DomainEntity = RC.ERP.Domain.Entity;

namespace RC.ERP.UnitTests.Domain.Entity
{
    [Collection(nameof(CategoryTestFixture))]
    public class CategoryTest
    {
        private readonly CategoryTestFixture _categoryTestFixture;

        public CategoryTest(CategoryTestFixture categoryTestFixture)
               => _categoryTestFixture = categoryTestFixture;

        [Fact(DisplayName = nameof(Instantiate))]
        [Trait("Domain", "Category - Aggregates")]
        public void Instantiate()
        {
            var validCategory = _categoryTestFixture.GetValidCategory();
            var datetimeBefore = DateTime.Now;

            var category = new DomainEntity.Category(validCategory.Name, validCategory.Description);
            var datetimeAfter = DateTime.Now.AddSeconds(1);

            category.Should().NotBeNull();
            category.Name.Should().Be(validCategory.Name);
            category.Description.Should().Be(validCategory.Description);
            category.Id.Should().NotBeEmpty();
            category.CreatedAt.Should().NotBeSameDateAs(default(DateTime));
            (category.CreatedAt >= datetimeBefore).Should().BeTrue();
            (category.CreatedAt <= datetimeAfter).Should().BeTrue();
            (category.IsActive).Should().BeTrue();
        }

        [Theory(DisplayName = nameof(InstantiateWithIsActive))]
        [Trait("Domain", "Category - Aggregates")]
        [InlineData(true)]
        [InlineData(false)]
        public void InstantiateWithIsActive(bool isActive)
        {
            var validData = new
            {
                Name = "Nome Categoria",
                Description = "Descrição Categoria",
            };

            var datetimeBefore = DateTime.Now;
            var category = new DomainEntity.Category(validData.Name, validData.Description, isActive);
            var datetimeAfter = DateTime.Now;

            Assert.NotNull(category);
            Assert.Equal(validData.Name, category.Name);
            Assert.Equal(validData.Description, category.Description);
            Assert.NotEqual(default(Guid), category.Id);
            Assert.NotEqual(default(DateTime), category.CreatedAt);
            Assert.True(category.CreatedAt > datetimeBefore);
            Assert.True(category.CreatedAt < datetimeAfter);
            Assert.Equal(isActive, category.IsActive);
        }

        [Theory(DisplayName = nameof(InstantiateErrorWhenNameIsEmpty))]
        [Trait("Domain", "Category - Aggregates")]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("   ")]
        public void InstantiateErrorWhenNameIsEmpty(string? name)
        {
            var validCategory = new
            {
                Name = "Nome Categoria",
                Description = "Descrição Categoria",
            };

            Action action =
                () => new DomainEntity.Category(name!, validCategory.Description);

            action.Should()
                .Throw<EntityValidationException>()
                .WithMessage("Name should not be empty or null");
        }

    }
}
