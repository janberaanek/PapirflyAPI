using FluentValidation;
using WebApplication1.DTO.Article.Request;

public class CreateArticleDtoValidator : AbstractValidator<CreateArticleDto>
{
    public CreateArticleDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name of the article is required.");                        

        RuleFor(x => x.Price)
            .NotEmpty().WithMessage("Price is required");
    }
}