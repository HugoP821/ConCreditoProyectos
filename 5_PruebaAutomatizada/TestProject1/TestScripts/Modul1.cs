using NUnit.Framework;
using TestProject1.PageObjectModel;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject1.TestScripts
{
    [TestFixture]
    public class Modul1 : BaseTest
    {
        [Test]
        public void BusquedaPAgina()
        {
            var BusquedaPagina = new SearchPage(driver);
            BusquedaPagina.NavegarEnPaginaDeResultados();
            Thread.Sleep(1000);
        }
        [Test]
        public void BusquedaMeSientoConSuerte()
        {
            var MeSientoSuerte = new SearchLookTest(driver);
            MeSientoSuerte.NavegarMeSientoSuerte();
            Thread.Sleep(1000);
        }
        [Test]
        public void BusquedaDosPAginaSeguidas()
        {
            var BusquedaDosPaginas = new SearchPage(driver);
            BusquedaDosPaginas.DosPAginasNavegar();
            Thread.Sleep(1000);
        }
        [Test]
        public void CambiarPaginaResultadosConValidacion()
        {
            var BusquedaDePAginasValidacion = new SearchPage(driver);
            BusquedaDePAginasValidacion.CambioPaginaResultado();
            Thread.Sleep(1000);
        }
        [Test]
        public void BuscarImagenCerrarla()
        {
            var ImagenBusqueda = new SearchPage(driver);
            ImagenBusqueda.BuscarImagenValidarImagenCerrarImagen();
            Thread.Sleep(1000);
        }
    }
}