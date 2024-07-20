using MundacorpCareUtilities;
using MundacorpCareViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundacorpCareServices
{
    public interface IMundacorpCareInfo
    {
        PagedResult<MundacorpcareInfoViewModels> GetAll(int pageNumber, int pageSize);
        MundacorpcareInfoViewModels GetMundacorpCareById(int MundacorpCareId);
        void UpdateMundacorpcareInfo(MundacorpcareInfoViewModels MundacorpCareInfo);
        void InsertMundacorpcareInfo(MundacorpcareInfoViewModels MundacorpCareInfo);
        void DeleteMundacorpcareInfo(int id);
    }
}
