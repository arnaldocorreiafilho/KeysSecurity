using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArchMvc.WebUI.Controllers
{
    public class KeysController : Controller
    {
        IKeysService keyService;
        // GET: ProductsController
        public KeysController(IKeysService keyService)
        {
            this.keyService = keyService ;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var keysDTOs = await this.keyService.GetKeys();
            return View(keysDTOs);
        }

        // GET: ProductsController/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var keyDto = await keyService.GetById(id);

            if (keyDto == null)
                return NotFound();

            return View(keyDto);
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(KeysDTO keys)
        {
            try            
            {
                if (ModelState.IsValid)
                {

                    this.keyService.Create(keys);

                }
                
            }
            catch
            {
                return View();
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: ProductsController/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var keysDto = await this.keyService.GetById(id);

            if (keysDto == null) return NotFound();

            return View(keysDto);
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(KeysDTO keys)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    await this.keyService.Update(keys);

                }
            }
            catch
            {
                return View();
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: ProductsController/Delete/5
        [HttpGet()]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var keysDto = await keyService.GetById(id);

            if (keysDto == null) return NotFound();

            return View(keysDto);
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                await keyService.Delete(id);                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
