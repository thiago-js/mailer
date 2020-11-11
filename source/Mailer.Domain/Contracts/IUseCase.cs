using System.Threading.Tasks;

namespace Mailer.Domain.Contracts
{
    public interface IUseCase<TReq, TRes>
    {
        Task<TRes> Execute(TReq request);
    }
}
