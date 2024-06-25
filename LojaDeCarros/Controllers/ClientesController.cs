using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LojaDeCarros.Data;
using LojaDeCarros.Models;
using LojaDeCarros.Models.ViewModels;
using NuGet.Protocol.Plugins;

namespace LojaDeCarros.Controllers
{
    public class ClientesController : Controller
    {
        private readonly LojaDeCarrosContext _context;

        public ClientesController(LojaDeCarrosContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public IActionResult Index()

        {
            var clientes = _context.Cliente.ToList();


            return View(clientes);
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente
                .FirstOrDefaultAsync(c => c.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: Clientes/Create
        public IActionResult Create()
           
        {
            var viewModel = new ClienteFormViewModel();
            
            return View(viewModel);
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,BirthDate,Email,Telefone,Endereco,CPF")] Cliente cliente)
        {
            if (cliente == null)
            {
                return NotFound();
            }
            _context.Add(cliente);
            _context.SaveChanges();


            return RedirectToAction("Index");
        }

        // GET: Clientes/Edit/5
        public IActionResult Edit(int? id)
        {
            Cliente cliente = _context.Cliente.FirstOrDefault(c=> c.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

          
            ClienteFormViewModel viewModel = new ClienteFormViewModel();
           
            viewModel.Cliente = cliente;
            return View(viewModel);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Cliente cliente)
        {
            if (cliente == null)
            {
                return NotFound();
            }

            //_context.cliente.Update(seller);
            //Podemos chamar o update sem informar a tabela
            _context.Update(cliente);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Clientes/Delete/5
        public IActionResult Delete(int? id)
        {
            //Busca no banco de dados o cliente com o id informado
            Cliente cliente = _context.Cliente.FirstOrDefault(c => c.Id == id);

            if (cliente == null) {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost]
       
        public IActionResult Delete(int id)
        {
           Cliente cliente = _context.Cliente.FirstOrDefault(c  => c.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }
            _context.Remove(cliente);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        private bool ClienteExists(int id)
        {
            return _context.Cliente.Any(e => e.Id == id);
        }
    }
}
