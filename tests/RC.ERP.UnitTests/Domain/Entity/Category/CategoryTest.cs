using FluentAssertions;
using RC.ERP.Domain.Exceptions;
using RC.ERP.UnitTests.Domain.Entity.Category;
using System;
using System.Collections.Generic;
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
            var validCategory = _categoryTestFixture.GetValidCategory();
            var datetimeBefore = DateTime.Now;

            var category = new DomainEntity.Category(validCategory.Name, validCategory.Description, isActive);
            var datetimeAfter = DateTime.Now.AddSeconds(1);

            category.Should().NotBeNull();
            category.Name.Should().Be(validCategory.Name);
            category.Description.Should().Be(validCategory.Description);
            category.Id.Should().NotBeEmpty();
            category.CreatedAt.Should().NotBeSameDateAs(default(DateTime));
            (category.CreatedAt >= datetimeBefore).Should().BeTrue();
            (category.CreatedAt <= datetimeAfter).Should().BeTrue();
            (category.IsActive).Should().Be(isActive);
        }

        [Theory(DisplayName = nameof(InstantiateErrorWhenNameIsEmpty))]
        [Trait("Domain", "Category - Aggregates")]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("   ")]
        public void InstantiateErrorWhenNameIsEmpty(string? name)
        {
            var validCategory = _categoryTestFixture.GetValidCategory();

            Action action =
                () => new DomainEntity.Category(name!, validCategory.Description);

            action.Should()
                .Throw<EntityValidationException>()
                .WithMessage("Name should not be empty or null");
        }

        [Fact(DisplayName = nameof(InstantiateErrorWhenDescriptionIsNull))]
        [Trait("Domain", "Category - Aggregates")]
        public void InstantiateErrorWhenDescriptionIsNull()
        {
            var validCategory = _categoryTestFixture.GetValidCategory();

            Action action =
                () => new DomainEntity.Category(validCategory.Name, null!);

            action.Should()
                .Throw<EntityValidationException>()
                .WithMessage("Description should not be null");
        }

        [Theory(DisplayName = nameof(InstantiateErrorWhenNameIsLessThan3Characters))]
        [Trait("Domain", "Category - Aggregates")]
        [MemberData(nameof(GetNamesWithLessThan3Characters), parameters: 10)]
        public void InstantiateErrorWhenNameIsLessThan3Characters(string invalidName)
        {
            var validCategory = _categoryTestFixture.GetValidCategory();

            Action action =
                () => new DomainEntity.Category(invalidName, validCategory.Description);

            action.Should()
                .Throw<EntityValidationException>()
                .WithMessage("Name should be at least 3 characters long");
        }

        public static IEnumerable<object[]> GetNamesWithLessThan3Characters(int numberOfTests = 6)
        {
            var fixture = new CategoryTestFixture();
            for (int i = 0; i < numberOfTests; i++)
            {
                var isOdd = i % 2 == 1;
                yield return new object[] {
                    fixture.GetValidCategoryName()[..(isOdd ? 1 : 2)]
                };
            }
        }

    }
}
