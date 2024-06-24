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

namespace LojaDeCarros.Controllers
{
    public class NotasController : Controller
    {
        private readonly LojaDeCarrosContext _context;

        public NotasController(LojaDeCarrosContext context)
        {
            _context = context;
        }

        // GET: Notas
        public  async Task<IActionResult> Index()

        {
           
            var compradorContext = _context.Nota.Include(c => c.Comprador);
            var sellerContext = _context.Nota.Include(s => s.Seller);
            var carroContext = _context.Nota.Include(car => car.Carro);
            var notasContext = _context.Nota;
            
            return View(await notasContext.ToListAsync());
        }

        // GET: Notas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

         
            var notaComprador = await _context.Nota.Include(c => c.Comprador)
                .FirstOrDefaultAsync(n => n.Id == id);
            var notaVendedor = await _context.Nota.Include(s => s.Seller).FirstOrDefaultAsync(s => s.Id == id);
            var notaCarro = await _context.Nota.Include(car => car.Carro).FirstOrDefaultAsync(c => c.Id == id);
            if (notaComprador == null)
            {
                return NotFound();
            }

            return View(notaComprador);
        }

        // GET: Notas/Create
        public IActionResult Create()
        {
            ViewData["CompradorId"] = new SelectList(_context.Cliente, "Id", "Name");
            ViewData["SellerId"] = new SelectList(_context.Seller, "Id", "Name");
            ViewData["CarroId"] = new SelectList(_context.Carro, "Id", "Modelo");
            return View();
        }

        // POST: Notas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>  Create(Nota nota)
        {
            _context.Add(nota);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            
               

        }

        // GET: Notas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            
            if (id == null || _context.Nota == null)
            {
                return NotFound();
            }
            var nota = await _context.Nota.FindAsync(id);
            if (nota == null)
            {
                return NotFound();
            }
            ViewData["CompradorID"] = new SelectList(_context.Cliente, "Id", "Name", nota.CompradorId);
            ViewData["SellerID"] = new SelectList(_context.Seller, "Id", "Name", nota.SellerId);
            ViewData["CarroID"] = new SelectList(_context.Carro, "Id", "Modelo", nota.CarroId);
            return View(nota);
        }

        // POST: Notas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Nota nota)
        {
            if (id != nota.Id)
            {
                return NotFound();
            }

                            {
            _context.Update(nota);
            await _context.SaveChangesAsync();
               
            }
            return RedirectToAction("Index");
        }

        // GET: Notas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            
            if (id == null || _context.Nota == null )
            {
                return NotFound();
            }
            var nota = await _context.Nota.FindAsync(id);
            var delNotaCliente = await _context.Nota.Include(c => c.Comprador).FirstOrDefaultAsync(m  => m.Id == id);
            var delNotaSeller = await _context.Nota.Include(s => s.Seller).FirstOrDefaultAsync(m => m.Id == id);
            var delNotaCar = await _context.Nota.Include(c => c.Carro).FirstOrDefaultAsync(m => m.Id == id);
            if (nota == null)
            {
                return NotFound();
            }

            return View(nota);
        }

        // POST: Notas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nota = await _context.Nota.FindAsync(id);
            if (nota != null)
            {
                _context.Nota.Remove(nota);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NotaExists(int id)
        {
            return _context.Nota.Any(e => e.Id == id);
        }
    }
}
