using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MundacorpCareServices;
using MundacorpCareViewModels;

namespace MundacorpCare.Areas.Admin.Controllers
{
    [Area("admin")]
    public class MundacorpCaresController : Controller
    {
        private IMundacorpCareInfo _mundacorpCareInfo;

        public MundacorpCaresController(IMundacorpCareInfo mundacorpCareInfo)
        {
            _mundacorpCareInfo = mundacorpCareInfo;
        }

        public IActionResult Index(int pageNumber = 1, int pageSize = 10)
        {
            return View(_mundacorpCareInfo.GetAll(pageNumber, pageSize));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var viewModel = _mundacorpCareInfo.GetMundacorpCareById(id);
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Edit(MundacorpcareInfoViewModels vm)
        {
            _mundacorpCareInfo.UpdateMundacorpcareInfo(vm);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MundacorpcareInfoViewModels vm)
        {
            _mundacorpCareInfo.InsertMundacorpcareInfo(vm);
            return RedirectToAction("Index");
        }
        
        public IActionResult Delete(int id)
        {
            _mundacorpCareInfo.DeleteMundacorpcareInfo(id);
            return RedirectToAction("Index");
        }

    }
}
