using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.PageObjectModel
{
    internal class SearchLookTest
    {
        //Constructor
        IWebDriver driver;
        public SearchLookTest(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        //Busqueda de Elementos - Clases Objetcs
        //1.Identificar cuadro de texto
        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement BusquedaCajaDeTexto { get; set; }
        //2.Identificar el boton "Me siento con suerte"
        [FindsBy(How = How.ClassName, Using = "RNmpXc")]
        public IWebElement BotonMeSientoConSuerte { get; set; }
        //Funciones a realizar
        public void NavegarMeSientoSuerte()
        {
            BusquedaCajaDeTexto.SendKeys("CrediTienda");
            BotonMeSientoConSuerte.Click();
        }
    }
}
