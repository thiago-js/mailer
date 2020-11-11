using Mailer.Domain.Contracts;

namespace Mailer.Application.UseCases
{
    public interface ISendMail: IUseCase<SendMailInput, bool> { 
        
    }
}