using MediatR;
using RC.ERP.Application.UseCases.Category.Common;

namespace RC.ERP.Application.UseCases.Category.CreateCategory
{
    public interface ICreateCategory : IRequestHandler<CreateCategoryInput, CategoryModelOutput>
    { 
    
    }

}
