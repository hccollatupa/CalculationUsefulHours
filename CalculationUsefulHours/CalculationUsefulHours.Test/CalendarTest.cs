using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CalculationUsefulHours.Helpers;

namespace CalculationUsefulHours.Test
{
    [TestClass]
    public class CalendarTest
    {
        List<DateTime> holidays = new List<DateTime>();

        [TestInitialize]
        public void TestInitialize()
        {
            holidays.Add(new DateTime(2017, 3, 19));
            holidays.Add(new DateTime(2017, 3, 18));
        }  

        [TestMethod]
        public void ConteoHorasUtilesUnicoDia_Sabado_CeroHoras()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 4, 9, 29, 0));
            Assert.AreEqual(59, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtilesUnicoDia_Sabado_UnaHora_1()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 4, 9, 30, 0));
            Assert.AreEqual(60, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtilesUnicoDia_Sabado_UnaHora_2()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 4, 10, 0, 0));
            Assert.AreEqual(90, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtilesUnicoDia_Sabado_UnaHora_3()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 4, 10, 27, 0));
            Assert.AreEqual(117, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtilesUnicoDia_Sabado_DosHoras_1()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 4, 10, 30, 0));
            Assert.AreEqual(120, x1);
        }

        [TestMethod]
        public void ConteoHorasUtilesUnicoDia_Sabado_DosHoras_2()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 4, 10, 59, 0));
            Assert.AreEqual(149, x1);
        }

        [TestMethod]
        public void ConteoHorasUtilesUnicoDia_Sabado_DosHoras_3()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 4, 11, 0, 0));
            Assert.AreEqual(150, x1);
        }

        [TestMethod]
        public void ConteoHorasUtilesUnicoDia_Sabado_DosHoras_4()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 4, 11, 1, 0));
            Assert.AreEqual(151, x1);
        }

        [TestMethod]
        public void ConteoHorasUtilesUnicoDia_Sabado_DosHoras_5()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 4, 11, 29, 0));
            Assert.AreEqual(179, x1);
        }

        [TestMethod]
        public void ConteoHorasUtilesUnicoDia_Sabado_TresHoras_1()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 4, 11, 30, 0));
            Assert.AreEqual(180, x1);
        }

        [TestMethod]
        public void ConteoHorasUtilesUnicoDia_Sabado_TresHoras_2()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 4, 11, 47, 0));
            Assert.AreEqual(197, x1);
        }

        [TestMethod]
        public void ConteoHorasUtilesUnicoDia_Sabado_TresHoras_3()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 4, 12, 0, 0));
            Assert.AreEqual(210, x1);
        }

        [TestMethod]
        public void ConteoHorasUtilesUnicoDia_Sabado_TresHoras_4()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 4, 12, 17, 0));
            Assert.AreEqual(227, x1);
        }

        [TestMethod]
        public void ConteoHorasUtilesUnicoDia_Sabado_CuatroHoras_1()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 4, 12, 30, 0));
            Assert.AreEqual(240, x1);
        }

        [TestMethod]
        public void ConteoHorasUtilesUnicoDia_Sabado_OchoHoras_1()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 4, 16, 30, 0));
            Assert.AreEqual(480, x1);
        }

        [TestMethod]
        public void ConteoHorasUtilesUnicoDia_Sabado_OchoHoras_2()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 4, 16, 58, 0));
            Assert.AreEqual(480, x1);
        }

        [TestMethod]
        public void ConteoHorasUtilesUnicoDia_Sabado_OchoHoras_3()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 4, 17, 00, 0));
            Assert.AreEqual(480, x1);
        }

        [TestMethod]
        public void ConteoHorasUtilesUnicoDia_Sabado_OchoHoras_4()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 4, 18, 30, 0));
            Assert.AreEqual(480, x1);
        }

        [TestMethod]
        public void ConteoHorasUtilesUnicoDia_Sabado_OchoHoras_5()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 4, 19, 30, 0));
            Assert.AreEqual(480, x1);
        }

        [TestMethod]
        public void ConteoHorasUtilesDosDias_Sabado_y_Domingo_OchoHoras()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 5, 7, 0, 0));
            Assert.AreEqual(480, x1);
        }

        [TestMethod]
        public void ConteoHorasUtilesTresDias_Sabado_Domingo_y_Lunes_DiezHoras()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 0, 0), new DateTime(2017, 3, 6, 9, 0, 0));
            Assert.AreEqual(600, x1);
        }

        [TestMethod]
        public void ConteoHorasUtilesDosDias_Viernes_y_Sabado_DosHoras()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 3, 20, 0, 0), new DateTime(2017, 3, 4, 9, 30, 0));
            Assert.AreEqual(120, x1);
        }

        [TestMethod]
        public void ConteoHorasUtilesTresDias_Sabado_Domingo_y_Lunes_OchoHoras()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 4, 8, 30, 0), new DateTime(2017, 3, 6, 7, 0, 0));
            Assert.AreEqual(480, x1);
        }

        [TestMethod]
        public void ConteoHorasUtilesDosDias_De_Semana_Lunes_y_Martes_UnaHora()
        {
            Calendar calendar = new Calendar(holidays, true);
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 6, 22, 30, 0), new DateTime(2017, 3, 7, 8, 0, 0));
            Assert.AreEqual(60, x1);
        }

        [TestMethod]
        public void ConteoHorasUtiles_Incluye_Feriados_DiezHoras()
        {
            List<DateTime> holidays_ = new List<DateTime>();
            // Se define 28 y 29 de Julio como feriado, 29 cae sábado por lo que se suplanta los días útiles del sábado por 0 días útiles al considerarse feriado
            holidays_.Add(new DateTime(2017, 7, 28));
            holidays_.Add(new DateTime(2017, 7, 29));

            Calendar calendar = new Calendar(holidays_, true);
            // De Jueves 27/07/2017 11:19 a Lunes 31/07/2017 07:18   -> 9 Horas
            // De Jueves 27/07/2017 11:19 a Lunes 31/07/2017 07:19   -> 10 Horas
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 7, 27, 11, 19, 0), new DateTime(2017, 7, 31, 7, 19, 0));
            Assert.AreEqual(600, x1);
        }

        [TestMethod]
        public void ConteoHorasUtiles_DiaSemana_VeintidosHoras()
        {
            Calendar calendar = new Calendar();
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2017, 3, 20, 10, 42, 0), new DateTime(2017, 3, 21, 19, 6, 0));
            Assert.AreEqual(1344, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtiles_FinSemana_1()
        {
            Calendar calendar = new Calendar();
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2018, 8, 25, 16, 29, 0), new DateTime(2018, 8, 26, 6, 0, 0));
            Assert.AreEqual(1, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtiles_FinSemana_2()
        {
            Calendar calendar = new Calendar();
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2018, 8, 25, 16, 29, 0), new DateTime(2018, 8, 25, 20, 0, 0));
            Assert.AreEqual(1, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtiles_FinSemana_3()
        {
            Calendar calendar = new Calendar();
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2018, 8, 25, 8, 30, 0), new DateTime(2018, 8, 25, 8, 33, 0));
            Assert.AreEqual(3, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtiles_Desde_FinSemana_a_InicioSemana_1()
        {
            Calendar calendar = new Calendar();
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2018, 8, 25, 16, 29, 0), new DateTime(2018, 8, 27, 7, 0, 0));
            Assert.AreEqual(1, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtiles_Desde_FinSemana_a_InicioSemana_2()
        {
            Calendar calendar = new Calendar();
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2018, 8, 25, 16, 29, 0), new DateTime(2018, 8, 27, 7, 10, 0));
            Assert.AreEqual(11, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtiles_Desde_FinSemana_a_InicioSemana_3()
        {
            Calendar calendar = new Calendar();
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2018, 8, 25, 16, 29, 0), new DateTime(2018, 8, 27, 7, 1, 1));
            Assert.AreEqual(2, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtiles_Desde_FinSemana_a_InicioSemana_4()
        {
            Calendar calendar = new Calendar();
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2018, 8, 25, 16, 29, 0), new DateTime(2018, 8, 27, 7, 3, 1));
            Assert.AreEqual(4, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtiles_Desde_FinSemana_a_InicioSemana_5()
        {
            Calendar calendar = new Calendar();
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2018, 8, 25, 16, 25, 0), new DateTime(2018, 8, 27, 7, 3, 1));
            Assert.AreEqual(8, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtiles_SabadoCompleto_CalculoExacto()
        {
            Calendar calendar = new Calendar();
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2018, 8, 25, 08, 30, 0), new DateTime(2018, 8, 25, 16, 30, 0));
            Assert.AreEqual(480, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtiles_DiaSemanaCompleto_CalculoExacto()
        {
            Calendar calendar = new Calendar();
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2018, 8, 23, 07, 0, 0), new DateTime(2018, 8, 23, 21, 0, 0));
            Assert.AreEqual(840, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtiles_DiaSemanaCompleto_Mas_SabadoCompleto()
        {
            Calendar calendar = new Calendar();
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2018, 8, 24, 07, 0, 0), new DateTime(2018, 8, 25, 22, 0, 0));
            Assert.AreEqual(1320, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtiles_DiaSemanaCompleto_Mas_ParteSabado()
        {
            Calendar calendar = new Calendar();
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2018, 8, 24, 07, 0, 0), new DateTime(2018, 8, 25, 8, 35, 0));
            Assert.AreEqual(845, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtiles_ParteDeViernes_Mas_SabadoCompleto_Mas_ParteDeLunes()
        {
            Calendar calendar = new Calendar();
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2018, 8, 24, 20, 55, 0), new DateTime(2018, 8, 27, 7, 5, 0));
            Assert.AreEqual(490, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtiles_DiaSemana_1()
        {
            Calendar calendar = new Calendar();
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2018, 8, 24, 10, 0, 0), new DateTime(2018, 8, 24, 10, 30, 0));
            Assert.AreEqual(30, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtiles_DiaSemana_2()
        {
            Calendar calendar = new Calendar();
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2018, 8, 24, 8, 30, 0), new DateTime(2018, 8, 24, 8, 32, 0));
            Assert.AreEqual(2, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtiles_DiaSemana_3()
        {
            Calendar calendar = new Calendar();
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2018, 8, 24, 8, 30, 0), new DateTime(2018, 8, 24, 9, 59, 0));
            Assert.AreEqual(89, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtiles_DiaSemana_4()
        {
            Calendar calendar = new Calendar();
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2018, 8, 24, 6, 0, 0), new DateTime(2018, 8, 24, 21, 15, 0));
            Assert.AreEqual(840, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtiles_SolicitudAprobada_DentroDeSabado()
        {
            Calendar calendar = new Calendar();
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2018, 8, 25, 09, 35, 0), new DateTime(2018, 8, 25, 09, 39, 0));
            Assert.AreEqual(4, x1);
        }

        [TestMethod]
        public void ConteoMinutosUtiles_SolicitudAprobada_DentroDeDiaSemana()
        {
            Calendar calendar = new Calendar();
            var x1 = calendar.CalculateUsefulMinutes(new DateTime(2018, 8, 28, 10, 33, 0), new DateTime(2018, 8, 28, 10, 36, 0));
            Assert.AreEqual(3, x1);
        }
    }
}