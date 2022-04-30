using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
//using OpenQA.Selenium.Support.PageObjects;

//Squi se 
namespace TestProject1.PageObjectModel
{
    public class SearchPage
    {
        //Constructor
        IWebDriver driver;
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        //Busqueda de Elementos - Clases Objetcs
        [FindsBy(How=How.Name,Using = "q")]
        public IWebElement BusquedaCajaDeTexto { get; set; }
        //Buscar el boton Buscar
        [FindsBy(How=How.ClassName,Using = "gNO89b")]
        public IWebElement BotonBuscarConGoogle { get; set; }
        //Buscar la pagina Concredito
        [FindsBy(How=How.CssSelector, Using = ".LC20lb.MBeuO.DKV0Md")]
        public IWebElement SeleccionaPagina { get; set; }

        public void NavegarEnPaginaDeResultados()
        {
                BusquedaCajaDeTexto.SendKeys("ConCredito");
                BotonBuscarConGoogle.Click();
                SeleccionaPagina.Click();
                Console.WriteLine("\nTitulo Pagina Final:\n" + driver.Title);
                Console.WriteLine("URL Pagina Final:\n"+ driver.Url);
        }

        //Seunda prueba para buscar dos paginas
        public void DosPAginasNavegar()
        {
            BusquedaCajaDeTexto.SendKeys("Primer Busqueda");
            BotonBuscarConGoogle.Click();
            driver.Navigate().Back();
            BusquedaCajaDeTexto.SendKeys("Segunda Busqueda");
            BotonBuscarConGoogle.Click();            
        }
        
        //Cuarta Prueba: Cambiar pagina resultado con validacion
        //Seleccionar Pagina 1
        [FindsBy(How = How.CssSelector, Using = ".LC20lb.MBeuO.DKV0Md")]
        public IWebElement SeleccionarPagina1 { get; set; }
        //Seleccionar Pagina 2
        [FindsBy(How = How.ClassName, Using = "H1u2de")]
        public IWebElement SeleccionarPagina2 { get; set; }
        public void CambioPaginaResultado()
        {
            BusquedaCajaDeTexto.SendKeys("Interpol Evil");
            BotonBuscarConGoogle.Click();
            SeleccionarPagina1.Click();
            Console.WriteLine("\nTitulo Pagina Medio:\n" + driver.Title);
            Console.WriteLine("URL Pagina Medio:\n" + driver.Url);
            driver.Navigate().Back();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleccionarPagina2.Click();
            Console.WriteLine("\nTitulo Pagina Final:\n" + driver.Title);
            Console.WriteLine("URL Pagina Final:\n" + driver.Url);
        }
        //Prueba 5: Buscar una imagen y cerrarla
        //Buscar Boton IMagen
        [FindsBy(How =How.XPath, Using = "html/body/div[7]/div/div[4]/div/div/div/div/div/div[3]/a")]
        public IWebElement BotonImagen { get; set; }
        //Seleccionar Imagen
        [FindsBy(How =How.XPath, Using = "//*[@jsname='Q4LuWd']")]
        public IWebElement ImagenSeleccionar { get; set; }
        //Seleccionar Boton cerrar imagen
        [FindsBy(How =How.XPath, Using = "//*[@jsname='tqp7ud']")]
        public IWebElement  IMagenCerrar { get; set; }
        public void BuscarImagenValidarImagenCerrarImagen()
        {
            BusquedaCajaDeTexto.SendKeys("ConCredito");
            BotonBuscarConGoogle.Click();
            BotonImagen.Click();
            ImagenSeleccionar.Click();
            Console.WriteLine("\nTipo De Archivo Abierto:\n" + ImagenSeleccionar.TagName);
            IMagenCerrar.Click();
            if (ImagenSeleccionar == ImagenSeleccionar)
            {
                Console.WriteLine("\n¡Imagen Cerrada!");
            }
        }
    }
}
