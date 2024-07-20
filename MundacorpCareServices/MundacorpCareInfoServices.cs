using MundacorpCareModels;
using MundacorpCareRepositories.Interfaces;
using MundacorpCareUtilities;
using MundacorpCareViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundacorpCareServices
{
    public class MundacorpCareInfoServices : IMundacorpCareInfo
    {
        private IUnitOfWork _unitOfWork;

        public MundacorpCareInfoServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void DeleteMundacorpcareInfo(int id)
        {
            var model = _unitOfWork.GenericRepository<MundacorpcareInfo>().GetById(id);
            _unitOfWork.GenericRepository<MundacorpcareInfo>().Delete(model);
            _unitOfWork.Save();
        }

        public PagedResult<MundacorpcareInfoViewModels> GetAll(int pageNumber, int pageSize)
        {
            var vm = new MundacorpcareInfoViewModels();
            int totalCount;
            List<MundacorpcareInfoViewModels> vmList = new List<MundacorpcareInfoViewModels>();
            try
            {
                int ExcludeRecords = (pageSize * pageNumber) - pageSize;

                var modelList = _unitOfWork.GenericRepository<MundacorpcareInfo>().GetAll()
                    .Skip(ExcludeRecords).Take(pageSize).ToList();

                totalCount = _unitOfWork.GenericRepository<MundacorpcareInfo>().GetAll().ToList().Count;

                vmList = ConvertModelToViewModelList(modelList);

            }

            catch (Exception)
            {
                throw;
            }

            var result = new PagedResult<MundacorpcareInfoViewModels>
            {
                Data = vmList,
                TotalItems = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
            return result;
        }

        public MundacorpcareInfoViewModels GetMundacorpCareById(int MundacorpCareId)
        {
            var model = _unitOfWork.GenericRepository<MundacorpcareInfo>().GetById(MundacorpCareId);
            var vm = new MundacorpcareInfoViewModels(model);
            return vm;  
        }

        public void InsertMundacorpcareInfo(MundacorpcareInfoViewModels MundacorpCareInfo)
        {
            var model = new MundacorpcareInfoViewModels().ConvertViewModel(MundacorpCareInfo);
          
            _unitOfWork.GenericRepository<MundacorpcareInfo>().Add(model);
            _unitOfWork.Save();

        }

        public void UpdateMundacorpcareInfo(MundacorpcareInfoViewModels MundacorpCareInfo)
        {
            var model = new MundacorpcareInfoViewModels().ConvertViewModel(MundacorpCareInfo);
            var modelById =_unitOfWork.GenericRepository<MundacorpcareInfo>().GetById(model.Id);
            modelById.Name = MundacorpCareInfo.Name;
            modelById.City = MundacorpCareInfo.City;
            modelById.PinCode = MundacorpCareInfo.PinCode;
            modelById.Country = MundacorpCareInfo.Country;
            _unitOfWork.GenericRepository<MundacorpcareInfo>().Update(modelById);
            _unitOfWork.Save();

        }

        private List<MundacorpcareInfoViewModels> ConvertModelToViewModelList(List<MundacorpcareInfo> modelList)
        { 
            return modelList.Select(x => new MundacorpcareInfoViewModels(x)).ToList();
        }
    }
}
