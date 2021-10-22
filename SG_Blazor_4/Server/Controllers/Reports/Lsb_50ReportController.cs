using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
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
    [Route("api/lsb_50report/")]
    [ApiController]
    public class Lsb_50ReportController : ControllerBase
    {
        private readonly SG_Blazor_4Context _context;

        public Lsb_50ReportController(SG_Blazor_4Context context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAction(int id)
        {
            LSB_50Model lSB_50 = await _context.LSB_50Model.FindAsync(id);

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
                .SetTextAlignment(TextAlignment.LEFT);

            Style cell2 = new Style()
               .SetFontColor(ColTExt1)
                .SetBorder(new SolidBorder(ColTExt1, 1))
               .SetPaddingTop(1)
               .SetPaddingBottom(1)
               .SetTextAlignment(TextAlignment.CENTER);


            #endregion

            #region Encabezado
            #region Encabezado Titulo
            Table table = new Table(1).UseAllAvailableWidth();

            Cell cell = new Cell().Add(new Paragraph("LSB-50  ").SetFontSize(24))
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

            cell = new Cell().Add(new Paragraph("Nombres y Apellidos: ").AddStyle(ParraTit1).Add(new Paragraph(lSB_50.NomApe).AddStyle(ParraNorm)))
                .SetBorder(Border.NO_BORDER)
                .SetPaddings(0, 0, 0, 0);
            table.AddCell(cell);

            cell = new Cell().Add(new Paragraph("DNI: ").AddStyle(ParraTit1).Add(new Paragraph(lSB_50.Dni).AddStyle(ParraNorm)))
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetBorder(Border.NO_BORDER)
                .SetPaddings(0, 0, 0, 0);
            table.AddCell(cell);

            cell = new Cell().Add(new Paragraph("Grado de instrucción: ").AddStyle(ParraTit1).Add(new Paragraph(lSB_50.GradoInstruccion).AddStyle(ParraNorm)))
                .SetBorder(Border.NO_BORDER)
                .SetPaddings(0, 0, 0, 0);
            table.AddCell(cell);

            cell = new Cell().Add(new Paragraph("Edad: ").AddStyle(ParraTit1).Add(new Paragraph(lSB_50.Edad.ToString()).AddStyle(ParraNorm)))
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetBorder(Border.NO_BORDER)
                .SetPaddings(0, 0, 0, 0);
            table.AddCell(cell);

            doc.Add(table);
            #endregion
            #endregion

            #region Detalle

            

            table = new Table(UnitValue.CreatePercentArray(new float[] { 2, 2, 2, 2, 2 })).UseAllAvailableWidth();
            table.AddHeaderCell(new Cell(1, 5).Add(new Paragraph("Grados de sintomas")).AddStyle(cell0));
            table.AddHeaderCell(new Cell().Add(new Paragraph("NADA")).AddStyle(cell0));
            table.AddHeaderCell(new Cell().Add(new Paragraph("POCO")).AddStyle(cell0));
            table.AddHeaderCell(new Cell().Add(new Paragraph("MODERADAMENTE")).AddStyle(cell0));
            table.AddHeaderCell(new Cell().Add(new Paragraph("BASTANTE")).AddStyle(cell0));
            table.AddHeaderCell(new Cell().Add(new Paragraph("MUCHO")).AddStyle(cell0));

            table.AddCell(new Cell().Add(new Paragraph("0")).AddStyle(cell2));
            table.AddCell(new Cell().Add(new Paragraph("1")).AddStyle(cell2));
            table.AddCell(new Cell().Add(new Paragraph("2")).AddStyle(cell2));
            table.AddCell(new Cell().Add(new Paragraph("3")).AddStyle(cell2));
            table.AddCell(new Cell().Add(new Paragraph("4")).AddStyle(cell2));
            doc.Add(table);
            doc.Add(new Paragraph(" "));
            table = new Table(UnitValue.CreatePercentArray(new float[] { 1, 8, 1 })).UseAllAvailableWidth();

            //cell = new Cell().Add(new Paragraph("1")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("text")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._1.ToString())).AddStyle(cell1); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("1")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Mi corazón palpita o va muy deprisa ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._1.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("2")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me siento triste.   ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._2.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("3")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Tengo ganas de romper o destruir algo.  ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._3.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("4")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Siento nerviosismo o agitación interior. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._4.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("5")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Tengo mareos o sensación de desmayo.  ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._5.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("6")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me preocupa la dejadez y el descuido.   ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._6.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("7")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Tengo que comprobar una y otra vez todo lo que hago.  ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._7.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("8")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me cuesta tomar decisiones  ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._8.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("9")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me irrito o enfado por cualquier cosa.  ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._9.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("10")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Siento miedo en la calle o espacios abiertos. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._10.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("11")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Tengo dolores de cabeza. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._11.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("12")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me siento decaído o falta de fuerzas. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._12.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("13")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me despierto de madrugada. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._13.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("14")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Duermo inquieto o me despierto mucho en la noche. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._14.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("15")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Doy vueltas a palabras o ideas que no consigo quitarme de la cabeza. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._15.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("16")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me siento incomodo o vergonzoso cuando estoy en reuniones con gente. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._16.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("17")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me vienen ideas de acabar con mi vida. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._17.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("18")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Tengo miedo sin motivo. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._18.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("19")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Tengo molestias digestivas o nauseas. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._19.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("20")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Siento hormigueo o se me duerme alguna parte del cuerpo. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._20.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("21")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Veo mi futuro sin esperanzas. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._21.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("22")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me da miedo estar solo. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._22.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("23")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Tengo ataques de ira que no puedo controlar. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._23.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("24")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me siento incomprendido. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._24.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("25")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me da miedo salir de casa solo. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._25.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("26")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me parece que otras personas me observan o hablan de mi. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._26.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("27")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me cuesta dormirme. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._27.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("28")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Tengo sentimiento de culpa. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._28.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("29")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me siento incomodo comiendo o bebiendo en público. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._29.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("30")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me siento herido con facilidad. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._30.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("31")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me siento incapaz de hacer las cosas o terminar las tereas. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._31.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("32")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("No siento interés por nada. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._32.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("33")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Tengo manías como repetir cosas innecesarias (tocar algo, lavarme, comprobar, etc.) ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._33.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("34")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me vienen ideas o imágenes que me dan miedo. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._34.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("35")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me siento temeroso. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._35.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("36")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Tengo que hacer las cosas muy despacio para estar seguro que las hago bien. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._36.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("37")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me siento solo. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._37.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("38")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me siento inferior a los demás. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._38.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("39")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Lloro con facilidad. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._39.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("40")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me siento solo aunque tenga compañía. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._40.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("41")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me da por gritar y tirar las cosas. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._41.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("42")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me siento inútil y poco valioso. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._42.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("43")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me duelen los músculos. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._43.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("44")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Discuto con frecuencia. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._44.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("45")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Tengo dolores de corazón en el pecho. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._45.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("46")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me dan ahogos o me cuesta respirar. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._46.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("47")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Tengo que evitar ciertas cosas, lugares o actividades porque me da miedo. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._47.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("48")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Me dan ganas de golpear o hacer daño a alguien. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._48.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("49")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Siento que todo requiere un gran esfuerzo. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._49.ToString())).AddStyle(cell2); table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("50")).AddStyle(cell0); table.AddCell(cell); cell = new Cell().Add(new Paragraph("Tengo presentimientos que va a pasar algo malo. ")).AddStyle(cell1); table.AddCell(cell); cell = new Cell().Add(new Paragraph(lSB_50._50.ToString())).AddStyle(cell2); table.AddCell(cell);


            doc.Add(table);
            #endregion

            doc.Add(new Paragraph(" "));
            doc.Add(new LineSeparator(Line));
            doc.Add(new Paragraph(" "));

            table = new Table(UnitValue.CreatePercentArray(new float[] { 3, 7 })).UseAllAvailableWidth();

            Table table1 = new Table(2).UseAllAvailableWidth();
            table1.AddHeaderCell(new Cell(1, 2).Add(new Paragraph("Cuadro PC LSB-50")).AddStyle(cell0));

            table1.AddCell(new Cell().Add(new Paragraph("Min")).AddStyle(cell0));
            table1.AddCell(new Cell().Add(new Paragraph(lSB_50.Min().ToString())).AddStyle(cell2));

            table1.AddCell(new Cell().Add(new Paragraph("Mag")).AddStyle(cell0));
            table1.AddCell(new Cell().Add(new Paragraph(lSB_50.Mag().ToString())).AddStyle(cell2));

            table1.AddCell(new Cell().Add(new Paragraph("Pr")).AddStyle(cell0));
            table1.AddCell(new Cell().Add(new Paragraph(lSB_50.Pr().ToString())).AddStyle(cell2));

            table1.AddCell(new Cell().Add(new Paragraph("Hp")).AddStyle(cell0));
            table1.AddCell(new Cell().Add(new Paragraph(lSB_50.Hp().ToString())).AddStyle(cell2));

            table1.AddCell(new Cell().Add(new Paragraph("Ob")).AddStyle(cell0));
            table1.AddCell(new Cell().Add(new Paragraph(lSB_50.Ob().ToString())).AddStyle(cell2));

            table1.AddCell(new Cell().Add(new Paragraph("An")).AddStyle(cell0));
            table1.AddCell(new Cell().Add(new Paragraph(lSB_50.An().ToString())).AddStyle(cell2));

            table1.AddCell(new Cell().Add(new Paragraph("Hs")).AddStyle(cell0));
            table1.AddCell(new Cell().Add(new Paragraph(lSB_50.Hs().ToString())).AddStyle(cell2));

            table1.AddCell(new Cell().Add(new Paragraph("Sm")).AddStyle(cell0));
            table1.AddCell(new Cell().Add(new Paragraph(lSB_50.Sm().ToString())).AddStyle(cell2));

            table1.AddCell(new Cell().Add(new Paragraph("De")).AddStyle(cell0));
            table1.AddCell(new Cell().Add(new Paragraph(lSB_50.De().ToString())).AddStyle(cell2));

            table1.AddCell(new Cell().Add(new Paragraph("Su")).AddStyle(cell0));
            table1.AddCell(new Cell().Add(new Paragraph(lSB_50.Su().ToString())).AddStyle(cell2));

            table1.AddCell(new Cell().Add(new Paragraph("Su-a")).AddStyle(cell0));
            table1.AddCell(new Cell().Add(new Paragraph(lSB_50.Su_a().ToString())).AddStyle(cell2));

            table1.AddCell(new Cell().Add(new Paragraph("IRPsi")).AddStyle(cell0));
            table1.AddCell(new Cell().Add(new Paragraph(lSB_50.IRPsi().ToString())).AddStyle(cell2));

            table.AddCell(table1);

            table1 = new Table(UnitValue.CreatePercentArray(new float[] { 25, 25, 25,25 }));
            table1.AddCell(new Cell().Add(new Paragraph("Total: " + lSB_50.Total().ToString())));
            table1.AddCell(new Cell().Add(new Paragraph("/50")));
            table1.AddCell(new Cell().Add(new Paragraph("PD GLOBAL: " + lSB_50.PdGlobal().ToString())));
            table1.AddCell(new Cell().Add(new Paragraph("PC: " + lSB_50.Pc().ToString())));

            table1.AddCell(new Cell().Add(new Paragraph("50-")));
            table1.AddCell(new Cell().Add(new Paragraph("# CEROS: " + lSB_50.NumCer().ToString())));
            table1.AddCell(new Cell().Add(new Paragraph("PD NUM: " + lSB_50.PdNum().ToString())));
            table1.AddCell(new Cell().Add(new Paragraph("PC: " + lSB_50.Pc1().ToString())));

            table1.AddCell(new Cell().Add(new Paragraph("Total")));
            table1.AddCell(new Cell().Add(new Paragraph("PD NUM: " + lSB_50.PdNum().ToString())));
            table1.AddCell(new Cell().Add(new Paragraph("PD INT: " + lSB_50.PdInt().ToString())));
            table1.AddCell(new Cell().Add(new Paragraph("PC: " + lSB_50.Pc2().ToString())));

            cell = new Cell().AddStyle(cell2);
            cell.Add(table1);
            cell.Add(new Paragraph("Índice global de severidad (GLOBAL): "+lSB_50.IndiceGlobal()));
            cell.Add(new Paragraph("Número de sintomas presentes (NUM): " + lSB_50.NumSintimas()));
            cell.Add(new Paragraph("Índice de intensidad de síntomas presentes (INT): " + lSB_50.IntensidadSintomas()));
            table.AddCell(cell);

            doc.Add(table);

            doc.Close();
            byte[] bts = ms.ToArray();
            ms = new MemoryStream();
            ms.Write(bts, 0, bts.Length);
            ms.Position = 0;

            return new FileStreamResult(ms, "application/pdf");
        }
    }
}
