using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.AspNetCore.Mvc;
using SG_Blazor_4.Server.Datos;
using System.IO;
using System.Threading.Tasks;
using System;
using iText.Kernel.Pdf.Canvas.Draw;

namespace SG_Blazor_4.Server.Controllers.Reports
{
    [Route("api/ba7report")]
    [ApiController]
    public class Ba7ReportController : ControllerBase
    {
        private readonly SG_Blazor_4Context _context;

        public Ba7ReportController(SG_Blazor_4Context context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAction(int id)
        {
            var ba7 = await _context.Ba7Models.FindAsync(id);

            MemoryStream ms = new MemoryStream();

            PdfWriter pw = new PdfWriter(ms);
            PdfDocument pd = new PdfDocument(pw);
            Document doc = new Document(pd, PageSize.A4);
            doc.SetFontSize(10);

            #region Estilos
            /*Colores*/
            Color ColTExt1 = new DeviceRgb(72, 87, 94);
            Color ColText2 = new DeviceRgb(133, 143, 148);
            Color ColNar = new DeviceRgb(241, 144, 89);
            Color ColCel = new DeviceRgb(89, 214, 241);
            /*Fin Colores*/

            Style ParraTit1 = new Style()
                .SetFontSize(12)
                .SetFontColor(ColTExt1)
                .SetVerticalAlignment(VerticalAlignment.BOTTOM)
                ;

            Style ParraNorm = new Style()
                .SetFontSize(10)
                .SetFontColor(ColTExt1)
                ;

            Style cell0 = new Style()
                .SetFontColor(ColorConstants.WHITE)
                .SetBold()
                .SetBackgroundColor(ColText2)
                .SetBorder(new SolidBorder(ColText2, 2))
                .SetPaddingTop(1)
                .SetPaddingBottom(1)
                .SetTextAlignment(TextAlignment.CENTER);

            Style cell1 = new Style()
                .SetFontColor(ColTExt1)
                 .SetBorder(new SolidBorder(ColTExt1, 1))
                .SetPaddingTop(1)
                .SetPaddingBottom(1)
                .SetTextAlignment(TextAlignment.CENTER);


            #endregion


            #region Encabezado
            #region Encabezado Titulo
            Table table = new Table(1).UseAllAvailableWidth();

            Cell cell = new Cell().Add(new Paragraph("BA7").SetFontSize(24).Add(new Paragraph("  Test-A").SetFontSize(12)))
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetBorder(Border.NO_BORDER);
            table.AddCell(cell);
            doc.Add(table);

            SolidLine Line = new SolidLine(1f);
            Line.SetColor(ColNar);
            doc.Add(new LineSeparator(Line));
            #endregion

            #region Encabezado Datos paciente
            table = new Table(2).UseAllAvailableWidth();

            cell = new Cell().Add(new Paragraph("Nombres y Apellidos: ").AddStyle(ParraTit1).Add(new Paragraph(ba7.NomApe).AddStyle(ParraNorm)))
                .SetBorder(Border.NO_BORDER)
                .SetPaddings(0, 0, 0, 0);
            table.AddCell(cell);

            cell = new Cell().Add(new Paragraph("DNI: ").AddStyle(ParraTit1).Add(new Paragraph(ba7.Dni).AddStyle(ParraNorm)))
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetBorder(Border.NO_BORDER)
                .SetPaddings(0, 0, 0, 0);
            table.AddCell(cell);

            cell = new Cell().Add(new Paragraph("Grado de instrucción: ").AddStyle(ParraTit1).Add(new Paragraph(ba7.GradoInstruccion).AddStyle(ParraNorm)))
                .SetBorder(Border.NO_BORDER)
                .SetPaddings(0, 0, 0, 0);
            table.AddCell(cell);

            cell = new Cell().Add(new Paragraph("Edad: ").AddStyle(ParraTit1).Add(new Paragraph(ba7.Edad.ToString()).AddStyle(ParraNorm)))
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetBorder(Border.NO_BORDER)
                .SetPaddings(0, 0, 0, 0);
            table.AddCell(cell);

            doc.Add(table);
            #endregion
            #endregion

            #region Detalle

            table = new Table(UnitValue.CreatePercentArray(new float[] {4,6})).UseAllAvailableWidth();
            Table table1 = new Table(UnitValue.CreatePercentArray(new float[] { 5,5})).UseAllAvailableWidth();
            Table table2 = new Table(2).UseAllAvailableWidth().SetFontSize(8).SetBorder(Border.NO_BORDER);

            //cell = new Cell().Add(new Paragraph("01")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._1.ToString())).AddStyle(cell1); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(" ")).AddStyle(cell2); table2.AddCell(cell);

            #region MyRegion
            cell = new Cell().Add(new Paragraph("1")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._1.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("2")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._2.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("3")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._3.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("4")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._4.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("5")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._5.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("6")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._6.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("7")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._7.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("8")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._8.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("9")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._9.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("10")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._10.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("11")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._11.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("12")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._12.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("13")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._13.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("14")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._14.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("15")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._15.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("16")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._16.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("17")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._17.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("18")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._18.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("19")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._19.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("20")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._20.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("21")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._21.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("22")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._22.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("23")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._23.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("24")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._24.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("25")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._25.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("26")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._26.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("27")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._27.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("28")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._28.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("29")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._29.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("30")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._30.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("31")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._31.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("32")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._32.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("33")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._33.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("34")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._34.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("35")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._35.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("36")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._36.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("37")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._37.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("38")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._38.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("39")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._39.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("40")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._40.ToString())).AddStyle(cell1); table2.AddCell(cell);

            #endregion

            table1.AddCell(new Cell().Add(table2).SetBorder(Border.NO_BORDER));

            #region MyRegion
            table2 = new Table(2).UseAllAvailableWidth().SetFontSize(8);
            cell = new Cell().Add(new Paragraph("41")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._41.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("42")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._42.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("43")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._43.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("44")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._44.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("45")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._45.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("46")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._46.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("47")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._47.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("48")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._48.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("49")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._49.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("50")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._50.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("51")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._51.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("52")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._52.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("53")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._53.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("54")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._54.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("55")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._55.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("56")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._56.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("57")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._57.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("58")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._58.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("59")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._59.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("60")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._60.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("61")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._61.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("62")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._62.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("63")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._63.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("64")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._64.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("65")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._65.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("66")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._66.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("67")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._67.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("68")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._68.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("69")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._69.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("70")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._70.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("71")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._71.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("72")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._72.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("73")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._73.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("74")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._74.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("75")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._75.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("76")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._76.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("77")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._77.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("78")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._78.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("79")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._79.ToString())).AddStyle(cell1); table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("80")).AddStyle(cell0); table2.AddCell(cell); cell = new Cell().Add(new Paragraph(ba7._80.ToString())).AddStyle(cell1); table2.AddCell(cell);

            #endregion

            table1.AddCell(new Cell().Add(table2).SetBorder(Border.NO_BORDER));
            table.AddCell(new Cell().Add(table1).SetBorder(Border.NO_BORDER));

            /*RESUSTADOS*/

            table2 = new Table(UnitValue.CreatePercentArray(new float[] { 3,2,5 })).SetFontColor(ColTExt1);
            cell = new Cell().Add( new Paragraph("P.D.: ").Add(new Paragraph(ba7.Atencion_PD().ToString())));
            table2.AddCell(cell);

            cell = new Cell(1,2).Add(new Paragraph("P.C.: ").Add(new Paragraph(ba7.Atencion_PC().ToString())));
            table2.AddCell(cell);

            cell = new Cell(1,3).Add(new Paragraph("NIVEL APTITUDINAL: ").Add(new Paragraph(ba7.Atencion_Nivel().ToString())));
            table2.AddCell(cell);
            cell = new Cell(1, 3).Add(new Paragraph("")).SetBorder(Border.NO_BORDER);
            table2.AddCell(cell);
            /**/
            cell = new Cell(2,1).Add(new Paragraph("CON="));
            table2.AddCell(cell);

            cell = new Cell().Add(new Paragraph(ba7.Atencion_PD().ToString()));
            table2.AddCell(cell);

            cell = new Cell(2, 1).Add(new Paragraph("X100"));
            table2.AddCell(cell);

            cell = new Cell().Add(new Paragraph(ba7.EjericiosResueltos().ToString()));
            table2.AddCell(cell);

            cell = new Cell(1,3).Add(new Paragraph("")).SetBorder(Border.NO_BORDER);
            table2.AddCell(cell);
            /**/
            cell = new Cell().Add(new Paragraph("CON"));
            table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("PC"));
            table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph("NIVEL APTITUDINAL"));
            table2.AddCell(cell);

            cell = new Cell().Add(new Paragraph(ba7.CON().ToString()));
            table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph(ba7.NivelAptitu_PC().ToString()));
            table2.AddCell(cell);
            cell = new Cell().Add(new Paragraph(ba7.NivelAptirudinal()));
            table2.AddCell(cell);
            
            cell = new Cell(1, 3).Add(new Paragraph("")).SetBorder(Border.NO_BORDER).SetHeight(20);
            table2.AddCell(cell);
            /**/

            cell = new Cell(1, 2).Add(new Paragraph("")).SetBorder(Border.NO_BORDER).SetHeight(50);
            table2.AddCell(cell);

            cell = new Cell(1, 1).Add(new Paragraph(""));
            table2.AddCell(cell);

            cell = new Cell(1,2).Add(new Paragraph("FIRMA"))
                .SetBorderBottom(Border.NO_BORDER)
                .SetBorderLeft(Border.NO_BORDER)
                .SetBorderRight(Border.NO_BORDER)
                .SetTextAlignment(TextAlignment.CENTER);
            table2.AddCell(cell);

            cell = new Cell().Add(new Paragraph("Huella digital"))
               .SetBorder(Border.NO_BORDER)
               .SetTextAlignment(TextAlignment.CENTER);
            table2.AddCell(cell).SetHorizontalAlignment(HorizontalAlignment.RIGHT);

            table.AddCell(new Cell().Add(table2).SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE).SetBorder(Border.NO_BORDER));
            doc.Add(table);
            #endregion

            doc.Add(new LineSeparator(Line));
            doc.Add(new Paragraph(DateTime.Now.ToString() + " Salud Ocupacional Integral San Gabriel ").SetFontColor(ColText2).SetFontSize(7).SetTextAlignment(TextAlignment.RIGHT));
            doc.Close();
            byte[] bts = ms.ToArray();
            ms = new MemoryStream();
            ms.Write(bts, 0, bts.Length);
            ms.Position = 0;


            return new FileStreamResult(ms, "application/pdf");
        }


    }


}
