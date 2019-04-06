using TeduShop.Model.Model;
using TeduShopData.Infratructure;
using TeduShopData.Repositoris;

namespace TeduShop.Service
{
    public interface IErrorService
    {
        Error Create(Error error);

        void Save();
    }

    public class ErrorService : IErrorService
    {
        IErrorRepository _errorRepository;
        IUnitofWork _unitofWork;
        public ErrorService(IErrorRepository errorRepository,IUnitofWork unitofWork)
        {
            this._errorRepository = errorRepository;
            this._unitofWork = unitofWork;
        }
        public Error Create(Error error)
        {
            return _errorRepository.Add(error);
        }

        public void Save()
        {
            _unitofWork.Commit();
        }
    }
}