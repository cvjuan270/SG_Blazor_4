using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SG_Blazor_4.Server.Datos;
using SG_Blazor_4.Shared.Models.Psico;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SG_Blazor_4.Server.Controllers.Reports
{
    [Route("api/ba7report")]
    [ApiController]
    public class Ba7Report : ControllerBase
    {
        private readonly SG_Blazor_4Context _context;

        public Ba7Report(SG_Blazor_4Context context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Getpdf(int id)
        {
            Ba7Model ba7 = new Ba7Model();

            ba7 = await _context.Ba7Models.FindAsync(id);

            MemoryStream ms = new MemoryStream();
            PdfWriter pw = new PdfWriter(ms);
            PdfDocument pd = new PdfDocument(pw);
            Document doc = new Document(pd, PageSize.A4);
            string Dni = ba7.Dni;
            string NomApe = ba7.NomApe;
            List lst= new List();
            lst.Add(new ListItem($"DNI: {Dni}"));
            lst.Add(new ListItem($"Nombre: {NomApe}"));

            doc.Add(lst);
            doc.Close();

            byte[] bts = ms.ToArray();
            ms = new MemoryStream();
            ms.Write(bts, 0, bts.Length);
            ms.Position = 0;
            return new FileStreamResult(ms, "application/pdf");
        }


    }
}
