using AutoMapper;
using Domain.Interfaces;
using Infra.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Extensions;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class ProductsController : MainController
    {
        private readonly IProductRepository _produtoRepository;
        private readonly ISupplierRepository _SupplierRepository;
        private readonly IProductService _produtoService;
        private readonly IMapper _mapper;

        public ProductsController(IProductRepository productRepository, ISupplierRepository supplierRepository, IMapper mapper, IProductService productService)/*,
                                  INotificador notificador) : base(notificador)*/
        {
            _produtoRepository = productRepository;
            _SupplierRepository = supplierRepository;
            _mapper = mapper;
            _produtoService = productService;
        }
        // GET: ProductsController
        /*[AllowAnonymous]
        [Route("lista-de-produtos")]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<ProductViewModel>>(await _produtoRepository.ObterProdutosFornecedores()));

        }*/

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductsController/Create
        [Route("Novo Produto")]
        public async Task<IActionResult> Create()
        {
            var productViewModel = await PopularSuppliers(new ProductViewModel());
            return View(productViewModel);
        }
        private async Task<ProductViewModel> ObterProduct(Guid id)
        {
            var produto = _mapper.Map<ProductViewModel>(await _produtoRepository.GetProductSuppliersById(id));
            produto.supplier = _mapper.Map<IEnumerable<SupplierViewModel>>(await _SupplierRepository.GetAll());
            return produto;
        }

        private async Task<ProductViewModel> PopularSuppliers(ProductViewModel productViewModel)
        {
            productViewModel.supplier = _mapper.Map<IEnumerable<SupplierViewModel>>(await _SupplierRepository.GetAll());
            return productViewModel;
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
